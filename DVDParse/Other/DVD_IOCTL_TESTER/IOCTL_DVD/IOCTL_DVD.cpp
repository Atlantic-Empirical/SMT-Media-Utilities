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

static HANDLE OpenDrive(TCHAR drive)
{
	TCHAR buff[16];
	_stprintf(buff, _T("\\\\.\\%c:"), drive);
	return CreateFile(buff, GENERIC_READ, FILE_SHARE_READ, NULL, 
		OPEN_EXISTING, FILE_ATTRIBUTE_READONLY|FILE_FLAG_SEQUENTIAL_SCAN, (HANDLE)NULL);
}

IOCTL_DVD_API bool GetRegion(TCHAR drive, DVD_REGION& s)
{
	HANDLE hDrive = OpenDrive(drive);
	if(hDrive == INVALID_HANDLE_VALUE)
		return false;

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
DWORD ReadStructure(TCHAR drive, DVD_STRUCTURE_FORMAT F, T& s)
{
	HANDLE hDrive = OpenDrive(drive);
	if(hDrive == INVALID_HANDLE_VALUE)
		return false;

	DVD_SESSION_ID id;

	DWORD BytesReturned = 0;
	if(!DeviceIoControl(hDrive, IOCTL_DVD_START_SESSION, NULL, 0, &id, sizeof(id), &BytesReturned, NULL))
	{
		id = DVD_END_ALL_SESSIONS;
		if(!DeviceIoControl(hDrive, IOCTL_DVD_END_SESSION, &id, sizeof(id), NULL, 0, &BytesReturned, NULL)
		|| !DeviceIoControl(hDrive, IOCTL_DVD_START_SESSION, NULL, 0, &id, sizeof(id), &BytesReturned, NULL))
		{
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
	if(!DeviceIoControl(hDrive, IOCTL_DVD_READ_STRUCTURE, &rs, sizeof(rs), &s, sizeof(s), &BytesReturned, NULL))
		BytesReturned = 0;

	DWORD BytesReturned2 = 0;
	DeviceIoControl(hDrive, IOCTL_DVD_END_SESSION, &id, sizeof(id), NULL, 0, &BytesReturned2, NULL);

	CloseHandle(hDrive);

	return BytesReturned;
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

IOCTL_DVD_API DWORD ReadStructure_Copyright(TCHAR drive, DVD_COPYRIGHT_DESCRIPTOR * cd)
{
	DVD_CD s;
	DWORD b = ReadStructure('d', DvdCopyrightDescriptor, s);
	*cd = s.copy;
	return b;
}

IOCTL_DVD_API DWORD ReadStructure_BCA(TCHAR drive, DVD_BCA_DESCRIPTOR * bca)
{
	DVD_BCA s;
	DWORD b = ReadStructure('d', DvdBCADescriptor, s);
	*bca = s.bca;
	return b;
}

IOCTL_DVD_API DWORD ReadStructure_Layer(TCHAR drive, DVD_LAYER_DESCRIPTOR * layer)
{
	DVD_LD s;
	DWORD b = ReadStructure('d', DvdPhysicalDescriptor, s);
	*layer = s.layer;
	return b;
}

IOCTL_DVD_API DWORD ReadStructure_Manufacturer(TCHAR drive, DVD_MANUFACTURER_DESCRIPTOR * md)
{
	DVD_MD s;
	DWORD b = ReadStructure('d', DvdManufacturerDescriptor, s);
	*md = s.manu;
	return b;
}

IOCTL_DVD_API bool ReadDVDRegion(TCHAR drive, DVD_REGION * dvd_region)
{
	return GetRegion('d', *dvd_region);
}
