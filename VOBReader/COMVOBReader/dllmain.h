// dllmain.h : Declaration of module class.

class CCOMVOBReaderModule : public CAtlDllModuleT< CCOMVOBReaderModule >
{
public :
	DECLARE_LIBID(LIBID_COMVOBReaderLib)
	DECLARE_REGISTRY_APPID_RESOURCEID(IDR_COMVOBREADER, "{8C995599-2176-4310-BBE8-255F5FF76A9C}")
};

extern class CCOMVOBReaderModule _AtlModule;
