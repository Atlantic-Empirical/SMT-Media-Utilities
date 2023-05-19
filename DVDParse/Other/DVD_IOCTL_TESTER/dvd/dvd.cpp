#include "stdafx.h"
#include <windows.h>
#include "..\IOCTL_DVD\IOCTL_DVD.h"

int _tmain(int argc, _TCHAR* argv[])
{
	DVD_REGION dvd_region;
	ReadDVDRegion('d', &dvd_region);

	DVD_COPYRIGHT_DESCRIPTOR cd;
	ReadStructure_Copyright('d', &cd);

	DVD_BCA_DESCRIPTOR bd;
	ReadStructure_BCA('d', &bd);

	DVD_LAYER_DESCRIPTOR ld;
	ReadStructure_Layer('d', &ld);

	DVD_MANUFACTURER_DESCRIPTOR md;
	ReadStructure_Manufacturer('d', &md);

	return 0;
}
