// CVOBReader.h : Declaration of the CCVOBReader

#pragma once
#include "resource.h"       // main symbols

#include "COMVOBReader_i.h"

#include "dvdcss.h"

#if defined(_WIN32_WCE) && !defined(_CE_DCOM) && !defined(_CE_ALLOW_SINGLE_THREADED_OBJECTS_IN_MTA)
#error "Single-threaded COM objects are not properly supported on Windows CE platform, such as the Windows Mobile platforms that do not include full DCOM support. Define _CE_ALLOW_SINGLE_THREADED_OBJECTS_IN_MTA to force ATL to support creating single-thread COM object's and allow use of it's single-threaded COM object implementations. The threading model in your rgs file was set to 'Free' as that is the only threading model supported in non DCOM Windows CE platforms."
#endif



// CCVOBReader

class ATL_NO_VTABLE CCVOBReader :
	public CComObjectRootEx<CComSingleThreadModel>,
	public CComCoClass<CCVOBReader, &CLSID_CVOBReader>,
	public IDispatchImpl<IVOBReader, &IID_IVOBReader, &LIBID_COMVOBReaderLib, /*wMajor =*/ 1, /*wMinor =*/ 0>
{
public:
	CCVOBReader()
	{
	}

DECLARE_REGISTRY_RESOURCEID(IDR_CVOBREADER)


BEGIN_COM_MAP(CCVOBReader)
	COM_INTERFACE_ENTRY(IVOBReader)
	COM_INTERFACE_ENTRY(IUnknown)
END_COM_MAP()



	DECLARE_PROTECT_FINAL_CONSTRUCT()

	HRESULT FinalConstruct()
	{
		return S_OK;
	}

	void FinalRelease()
	{
		//CloseTheFile();
		::CoTaskMemFree(&VOBPath);
	}

public:

	STDMETHOD(Initialize)(LPCWSTR inVOBPath);
	STDMETHOD(ReadSector)(long SectorNumber, LPBYTE * SectorData);
	STDMETHOD(DeInit)(void);
	STDMETHOD(Test_A)(LPBYTE * SectorData, long test);
	STDMETHOD(UnlockDrive)(LPCWSTR DrivePath);

	// FOR libdvdcss
	dvdcss_t       dvdcss;
	int isscrambled( unsigned char *p_buffer );

	char * VOBPath;

};

OBJECT_ENTRY_AUTO(__uuidof(CVOBReader), CCVOBReader)
