// IOCTL_DVD.cpp : Defines the entry point for the DLL application.
//

#include "stdafx.h"
#include "IOCTL_DVD.h"
#include <windows.h>
#include <tchar.h>

#ifdef _MANAGED
#pragma managed(push, off)
#endif

BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
					 )
{
	switch (ul_reason_for_call)
	{
	case DLL_PROCESS_ATTACH:
	case DLL_THREAD_ATTACH:
	case DLL_THREAD_DETACH:
	case DLL_PROCESS_DETACH:
		break;
	}
    return TRUE;
}

#ifdef _MANAGED
#pragma managed(pop)
#endif

static HANDLE OpenDrive(CHAR drive)
{
	//OutputDebugString(_T("Start OpenDrive()"));
	
	TCHAR buff[16];
	_stprintf(buff, _T("\\\\.\\%c:"), (TCHAR)drive);
	//OutputDebugString(_T("Return OpenDrive()"));

	HANDLE hDrive = CreateFile(buff, GENERIC_READ, FILE_SHARE_READ, NULL, OPEN_EXISTING, FILE_ATTRIBUTE_READONLY|FILE_FLAG_SEQUENTIAL_SCAN, (HANDLE)NULL);

	TCHAR szBuf[80]; 
	DWORD dw = GetLastError(); 
	_stprintf(szBuf, _T("Bad handle (hDrive). Error: %u, buff: %s\n"), dw, buff); 
	//OutputDebugString(szBuf);
	if(hDrive == INVALID_HANDLE_VALUE)
	{
		TCHAR szBuf[80]; 
		DWORD dw = GetLastError(); 
		//_stprintf(szBuf, _T("Bad handle (hDrive). Error: %u\n"), dw); 
		_stprintf(szBuf, _T("Bad handle (hDrive). Error: %u, buff: %s\n"), dw, buff); 
		OutputDebugString(szBuf);
	}
	return hDrive;
}

//static HANDLE OpenDrive(TCHAR drive)
//{
//	OutputDebugString(_T("Start OpenDrive()"));
//	TCHAR buff[16];
//	_stprintf(buff, _T("\\\\.\\%c:"), drive);
//	OutputDebugString(_T("Return OpenDrive()"));
//	return CreateFile(buff, GENERIC_READ, FILE_SHARE_READ, NULL, 
//		OPEN_EXISTING, FILE_ATTRIBUTE_READONLY|FILE_FLAG_SEQUENTIAL_SCAN, (HANDLE)NULL);
//}

IOCTL_DVD_API bool GetRegion(CHAR drive, DVD_REGION& s)
{
	HANDLE hDrive = OpenDrive(drive);
	if(hDrive == INVALID_HANDLE_VALUE)
	{
		return false;
	}	

	DWORD BytesReturned = 0;
	if(!DeviceIoControl(hDrive, IOCTL_DVD_GET_REGION, NULL, 0, &s, sizeof(s), &BytesReturned, NULL))
		BytesReturned = 0;

	CloseHandle(hDrive);

	return BytesReturned == sizeof(s);
}

//template<DVD_STRUCTURE_FORMAT F, class T>
//bool ReadStructure(TCHAR drive, T& s)

//template<class T>
//bool ReadStructure(TCHAR drive, DVD_STRUCTURE_FORMAT F, T& s)

template<class T>
DWORD ReadStructure(CHAR drive, DVD_STRUCTURE_FORMAT F, T& s)
{
	//OutputDebugString(_T("Start ReadStructure()"));

	//OutputDebugString(_T("ReadStructure() - OpenDrive"));
	HANDLE hDrive = OpenDrive(drive);
	if(hDrive == INVALID_HANDLE_VALUE) return 0;

	//OutputDebugString(_T("ReadStructure() - Done with OpenDrive"));

	DVD_SESSION_ID id;

	DWORD BytesReturned = 0;
	//OutputDebugString(_T("ReadStructure() - first IOCTL call."));
	if(!DeviceIoControl(hDrive, IOCTL_DVD_START_SESSION, NULL, 0, &id, sizeof(id), &BytesReturned, NULL))
	{
		id = DVD_END_ALL_SESSIONS;
		if(!DeviceIoControl(hDrive, IOCTL_DVD_END_SESSION, &id, sizeof(id), NULL, 0, &BytesReturned, NULL)
		|| !DeviceIoControl(hDrive, IOCTL_DVD_START_SESSION, NULL, 0, &id, sizeof(id), &BytesReturned, NULL))
		{
			TCHAR szBuf[80]; 
			DWORD dw = GetLastError(); 
			_stprintf(szBuf, _T("DeviceIoControl (start session) failed: GetLastError returned %u\n"), dw); 
			OutputDebugString(szBuf);

			CloseHandle(hDrive);
			return false;
		}
	}

	DVD_READ_STRUCTURE rs;
	rs.BlockByteOffset.QuadPart = 0;
	rs.Format = F;
	rs.LayerNumber = 0;
	rs.SessionId = id;

	BytesReturned = 0;
	//OutputDebugString(_T("ReadStructure() - second IOCTL call."));
	if(!DeviceIoControl(hDrive, IOCTL_DVD_READ_STRUCTURE, &rs, sizeof(rs), &s, sizeof(s), &BytesReturned, NULL))
	{
		BytesReturned = 0;
	    TCHAR szBuf[80]; 
		DWORD dw = GetLastError(); 
		_stprintf(szBuf, _T("DeviceIoControl (read structure) failed: GetLastError returned %u\n"), dw); 
		OutputDebugString(szBuf);
	}	

	DWORD BytesReturned2 = 0;
	//OutputDebugString(_T("ReadStructure() - third IOCTL call."));
	if (!DeviceIoControl(hDrive, IOCTL_DVD_END_SESSION, &id, sizeof(id), NULL, 0, &BytesReturned2, NULL))
	{
		TCHAR szBuf[80]; 
		DWORD dw = GetLastError(); 
		_stprintf(szBuf, _T("DeviceIoControl (end session) failed: GetLastError returned %u\n"), dw); 
		OutputDebugString(szBuf);
	}

	//OutputDebugString(_T("ReadStructure() - all IOCTL calls complete."));

	//OutputDebugString(_T("ReadStructure() - close handle."));
	CloseHandle(hDrive);
	//OutputDebugString(_T("ReadStructure() - done with close handle."));

	TCHAR szBuf[80]; 
	_stprintf(szBuf, _T("Actual bytes out %u\n"), BytesReturned); 
	//OutputDebugString(szBuf);

	return BytesReturned-4; //remove four bytes from length so we're just specifying the size of the DESCRIPTOR and not it's container structure
	//return BytesReturned == sizeof(T);
}

struct DVD_BCA
{
	USHORT Length;
	UCHAR Reserved[2];
	DVD_BCA_DESCRIPTOR bca;
};

struct DVD_LD
{
	USHORT Length;
	UCHAR Reserved[2];
	DVD_LAYER_DESCRIPTOR layer;
};

struct DVD_MD
{
	USHORT Length;
	UCHAR Reserved[2];
	DVD_MANUFACTURER_DESCRIPTOR manu;
};

struct DVD_CD
{
	USHORT Length;
	UCHAR Reserved[2];
	DVD_COPYRIGHT_DESCRIPTOR copy;
};

IOCTL_DVD_API DWORD ReadStructure_Copyright(CHAR drive, DVD_COPYRIGHT_DESCRIPTOR * cd)
{
	DVD_CD s;
	DWORD b = ReadStructure(drive, DvdCopyrightDescriptor, s);
	*cd = s.copy;
	return b;
}

IOCTL_DVD_API DWORD ReadStructure_BCA(CHAR drive, DVD_BCA_DESCRIPTOR * bca)
{
	DVD_BCA s;
	DWORD b = ReadStructure(drive, DvdBCADescriptor, s);
	*bca = s.bca;
	return b;
}

IOCTL_DVD_API DWORD ReadStructure_Layer(CHAR drive, DVD_LAYER_DESCRIPTOR * layer)
{
	DVD_LD s;
	DWORD b = ReadStructure(drive, DvdPhysicalDescriptor, s);
	//TCHAR buff[1024]; _stprintf(buff, _T("%d"), s.layer.StartingDataSector); 
	//OutputDebugString(buff);
	*layer = s.layer;
	return b;
}

IOCTL_DVD_API DWORD ReadStructure_Manufacturer(CHAR drive, DVD_MANUFACTURER_DESCRIPTOR * md)
{
	DVD_MD s;
	DWORD b = ReadStructure(drive, DvdManufacturerDescriptor, s);
	*md = s.manu;
	return b;
}

IOCTL_DVD_API bool ReadDVDRegion(CHAR drive, DVD_REGION * dvd_region)
{
	return GetRegion(drive, *dvd_region);
}
