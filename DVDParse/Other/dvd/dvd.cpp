// dvd.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <windows.h>
#include "ntddcdvd.h"

static HANDLE OpenDrive(TCHAR drive)
{
	TCHAR buff[16];
	_stprintf(buff, _T("\\\\.\\%c:"), drive);
	return CreateFile(buff, GENERIC_READ, FILE_SHARE_READ, NULL, 
		OPEN_EXISTING, FILE_ATTRIBUTE_READONLY|FILE_FLAG_SEQUENTIAL_SCAN, (HANDLE)NULL);
}

bool GetRegion(TCHAR drive, DVD_REGION& s)
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

template<DVD_STRUCTURE_FORMAT F, class T>
bool ReadStructure(TCHAR drive, T& s)
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

	return BytesReturned == sizeof(T);
}

struct 
{
	USHORT Length;
	UCHAR Reserved[2];
	DVD_BCA_DESCRIPTOR bca;
} DVD_BCA;

struct 
{
	USHORT Length;
	UCHAR Reserved[2];
	DVD_LAYER_DESCRIPTOR layer;
} DVD_LD;

struct 
{
	USHORT Length;
	UCHAR Reserved[2];
	DVD_MANUFACTURER_DESCRIPTOR manu;
} DVD_MD;

struct 
{
	USHORT Length;
	UCHAR Reserved[2];
	DVD_COPYRIGHT_DESCRIPTOR copy;
} DVD_CD;

int _tmain(int argc, _TCHAR* argv[])
{
	//CTL_CODE(0x00000033, 0x0450, 0, 0x0001);
	//CTL_CODE( DeviceType, Function, Method, Access );
//	#define CTL_CODE( DeviceType, Function, Method, Access ) (                 \
//    ((DeviceType) << 16) | ((Access) << 14) | ((Function) << 2) | (Method) \
//)

	//(((0x00000033) << 16) | ((0x0001) << 14) | ((0x0450) << 2) | (0)); //IOCTL_DVD_READ_STRUCTURE
	//(((0x00000033) << 16) | ((0x0001) << 14) | ((0x0400) << 2) | (0)); //IOCTL_DVD_START_SESSION
	//(((0x00000033) << 16) | ((0x0001) << 14) | ((0x0403) << 2) | (0)); //IOCTL_DVD_END_SESSION
	//(((0x00000033) << 16) | ((0x0001) << 14) | ((0x0405) << 2) | (0)); //IOCTL_DVD_GET_REGION

	DVD_REGION dvd_region;
	GetRegion('d', dvd_region);

	ReadStructure<DvdPhysicalDescriptor>('d', DVD_LD);
	sizeof(DVD_LD);
	sizeof(DvdPhysicalDescriptor);
	if (DVD_LD.layer.BCAFlag == 1)
	{
		ReadStructure<DvdBCADescriptor>('d', DVD_BCA);
	}
	
	ReadStructure<DvdCopyrightDescriptor>('d', DVD_CD);
	ReadStructure<DvdManufacturerDescriptor>('d', DVD_MD);

	return 0;
}
