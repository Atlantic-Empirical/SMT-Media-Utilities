// CVOBReader.cpp : Implementation of CCVOBReader

#include "stdafx.h"
#include "CVOBReader.h"


// CCVOBReader

STDMETHODIMP CCVOBReader::ReadSector(long SectorNumber, LPBYTE * SectorData)
{
	unsigned char	p_data[ DVDCSS_BLOCK_SIZE * 2 ];
    unsigned char	*p_buffer;
    unsigned int	i_sector;
    long			i_ret;

    /* Print version number */
    //printf( "cool, I found libdvdcss version %s\n", dvdcss_interface_2 );

    /* Save the requested sector */
    i_sector = (unsigned int)SectorNumber;

    /* Align our read buffer */
    p_buffer = p_data + DVDCSS_BLOCK_SIZE - ((long int)p_data & (DVDCSS_BLOCK_SIZE-1));

	if ( i_sector == 0)
	{
		/* Set the file descriptor at sector i_sector and read one sector */
		i_ret = dvdcss_seek( dvdcss, i_sector, DVDCSS_SEEK_MPEG );
		if( i_ret != (int)i_sector )
		{
			//printf( "seek failed (%s)\n", dvdcss_error( dvdcss ) );
			dvdcss_close( dvdcss );
			return E_FAIL;
		}
	}
	else
	{
		/* Set the file descriptor at sector i_sector and read one sector */
		i_ret = dvdcss_seek( dvdcss, i_sector, DVDCSS_NOFLAGS );
		if( i_ret != (int)i_sector )
		{
			//printf( "seek failed (%s)\n", dvdcss_error( dvdcss ) );
			dvdcss_close( dvdcss );
			return E_FAIL;
		}
	}

    /* Read sector again, and decrypt it on the fly */
    i_ret = dvdcss_read( dvdcss, p_buffer, 1, DVDCSS_READ_DECRYPT );
    if( i_ret != 1 )
    {
        //printf( "read failed (%s)\n", dvdcss_error( dvdcss ) );
        dvdcss_close( dvdcss );
		return E_FAIL;
    }

	LPBYTE buf2pass = (LPBYTE)CoTaskMemAlloc(2048);
	memcpy(buf2pass, p_buffer, 2048);

	*SectorData = buf2pass;

	////	DEBUGGING
	//wchar_t buff[256];
	//_stprintf(buff, _T("C:\\Temp\\native_dump_sector_%d.bin"), i_sector);
	//FILE * Out = _wfopen(buff, _T("w"));
	//fwrite(p_buffer, 2048, 1, Out);
	//fclose(Out);

	//wchar_t pointer[256];
	//_stprintf(pointer, _T("native pointer = 0x%08x"), *SectorData);
	//OutputDebugString( pointer );
	////	DEBUGGING

	return i_ret;
}

STDMETHODIMP CCVOBReader::Initialize(LPCWSTR inVOBPath)
{
	USES_CONVERSION;
	VOBPath = W2A(inVOBPath);

    /* Initialize libdvdcss */
    dvdcss = dvdcss_open( VOBPath );
    if( dvdcss == NULL )
    {
        printf( "argh ! couldn't open DVD (%s)\n", VOBPath );
		return E_FAIL;
    }

	return S_OK;
}

STDMETHODIMP CCVOBReader::DeInit(void)
{
    /* Close the device */
	int i_ret = dvdcss_close( dvdcss );
	return i_ret;
}

STDMETHODIMP CCVOBReader::UnlockDrive(LPCWSTR DrivePath)
{
	USES_CONVERSION;
	char * pth = W2A(DrivePath);
	return drive_unlock( pth );
}

STDMETHODIMP CCVOBReader::Test_A(LPBYTE * SectorData, long test)
{
	//dvdcss = dvdcss_open("G:\\");
	//return 1;

	return drive_unlock( "G:\\" );

	//   dvdcss_t       dvdcss;
 //   unsigned char  p_data[ DVDCSS_BLOCK_SIZE * 2 ];
 //   unsigned char *p_buffer;
 //   unsigned int   i_sector;
 //   int            i_ret;
	//char		  *pszTarget;

	//pszTarget = "G:";
	////\VIDEO_TS\\VTS_01_1.VOB

	///* Print version number */
 //   //printf( "cool, I found libdvdcss version %s\n", dvdcss_interface_2 );

 //   /* Save the requested sector */
 //   i_sector = test;

 //   /* Initialize libdvdcss */
 //   dvdcss = dvdcss_open( pszTarget );
 //   if( dvdcss == NULL )
 //   {
 //       //printf( "argh ! couldn't open DVD (%s)\n", pszTarget );
 //       //return -1;
	//	return E_FAIL;
 //   }
	//else
	//{
	//	i_ret = 1;
	//}

 ////   /* Align our read buffer */
 ////   p_buffer = p_data + DVDCSS_BLOCK_SIZE - ((long int)p_data & (DVDCSS_BLOCK_SIZE-1));

 ////   /* Set the file descriptor at sector i_sector and read one sector */
 ////   i_ret = dvdcss_seek( dvdcss, i_sector, DVDCSS_NOFLAGS );
 ////   if( i_ret != (int)i_sector )
 ////   {
 ////       //printf( "seek failed (%s)\n", dvdcss_error( dvdcss ) );
 ////       dvdcss_close( dvdcss );
 ////       //return i_ret;
	////	return E_FAIL;
 ////   }

 ////   i_ret = dvdcss_read( dvdcss, p_buffer, 1, DVDCSS_NOFLAGS ); //DVDCSS_NOFLAGS 
 ////   if( i_ret != 1 )
 ////   {
 ////       //printf( "read failed (%s)\n", dvdcss_error( dvdcss ) );
 ////       dvdcss_close( dvdcss );
 ////       //return i_ret;
	////	return E_FAIL;
 ////   }

 ////   /* Check if sector was encrypted */
 ////   if( isscrambled( p_buffer ) )
 ////   {
 ////       /* Set the file descriptor position to the previous location */
 ////       /* ... and get the appropriate key for this sector */
 ////       i_ret = dvdcss_seek( dvdcss, i_sector, DVDCSS_SEEK_KEY );
 ////       if( i_ret != (int)i_sector )
 ////       {
 ////           //printf( "seek failed (%s)\n", dvdcss_error( dvdcss ) );
 ////           dvdcss_close( dvdcss );
 ////           //return i_ret;
	////		return E_FAIL;
 ////       }

 ////       /* Read sector again, and decrypt it on the fly */
 ////       i_ret = dvdcss_read( dvdcss, p_buffer, 1, DVDCSS_READ_DECRYPT );
 ////       if( i_ret != 1 )
 ////       {
 ////           //printf( "read failed (%s)\n", dvdcss_error( dvdcss ) );
 ////           dvdcss_close( dvdcss );
 ////           //return i_ret;
	////		return E_FAIL;
 ////       }
	////	i_ret = 1;
 ////   }
	////else
	////{
	////	i_ret = 2;
	////}

	////LPBYTE buf2pass = (LPBYTE)CoTaskMemAlloc(2048);
	////memcpy(buf2pass, p_buffer, 2048);

	////*SectorData = buf2pass;

	////////	DEBUGGING
	//////wchar_t buff[256];
	//////_stprintf(buff, _T("C:\\Temp\\native_dump_sector_%d.bin"), i_sector);
	//////FILE * Out = _wfopen(buff, _T("w"));
	//////fwrite(p_buffer, 2048, 1, Out);
	//////fclose(Out);

	//////wchar_t pointer[256];
	//////_stprintf(pointer, _T("native pointer = 0x%08x"), *SectorData);
	//////OutputDebugString( pointer );
	////////	DEBUGGING

 ////   /* Close the device */
 ////   dvdcss_close( dvdcss );

 //   return i_ret;
}

/* Check if a sector is scrambled */
int CCVOBReader::isscrambled( unsigned char *p_buffer )
{
    return p_buffer[ 0x14 ] & 0x30;
}
