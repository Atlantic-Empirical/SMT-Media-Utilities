// The following ifdef block is the standard way of creating macros which make exporting 
// from a DLL simpler. All files within this DLL are compiled with the IOCTL_DVD_EXPORTS
// symbol defined on the command line. this symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see 
// IOCTL_DVD_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#ifdef IOCTL_DVD_EXPORTS
#define IOCTL_DVD_API extern "C" __declspec(dllexport)
#else
#define IOCTL_DVD_API extern "C" __declspec(dllimport)
#endif

#include "ntddcdvd.h"

IOCTL_DVD_API DWORD ReadStructure_Copyright(CHAR drive, DVD_COPYRIGHT_DESCRIPTOR * cd);
IOCTL_DVD_API DWORD ReadStructure_BCA(CHAR drive, DVD_BCA_DESCRIPTOR * bca);
IOCTL_DVD_API DWORD ReadStructure_Layer(CHAR drive, DVD_LAYER_DESCRIPTOR * layer);
IOCTL_DVD_API DWORD ReadStructure_Manufacturer(CHAR drive, DVD_MANUFACTURER_DESCRIPTOR * md);
IOCTL_DVD_API bool ReadDVDRegion(CHAR drive, DVD_REGION * dvd_region);
