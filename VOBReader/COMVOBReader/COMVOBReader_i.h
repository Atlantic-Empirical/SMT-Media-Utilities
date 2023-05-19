

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 7.00.0500 */
/* at Sat Jan 03 03:06:08 2009
 */
/* Compiler settings for .\COMVOBReader.idl:
    Oicf, W1, Zp8, env=Win32 (32b run)
    protocol : dce , ms_ext, c_ext, robust
    error checks: stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
//@@MIDL_FILE_HEADING(  )

#pragma warning( disable: 4049 )  /* more than 64k source lines */


/* verify that the <rpcndr.h> version is high enough to compile this file*/
#ifndef __REQUIRED_RPCNDR_H_VERSION__
#define __REQUIRED_RPCNDR_H_VERSION__ 475
#endif

#include "rpc.h"
#include "rpcndr.h"

#ifndef __RPCNDR_H_VERSION__
#error this stub requires an updated version of <rpcndr.h>
#endif // __RPCNDR_H_VERSION__

#ifndef COM_NO_WINDOWS_H
#include "windows.h"
#include "ole2.h"
#endif /*COM_NO_WINDOWS_H*/

#ifndef __COMVOBReader_i_h__
#define __COMVOBReader_i_h__

#if defined(_MSC_VER) && (_MSC_VER >= 1020)
#pragma once
#endif

/* Forward Declarations */ 

#ifndef __IVOBReader_FWD_DEFINED__
#define __IVOBReader_FWD_DEFINED__
typedef interface IVOBReader IVOBReader;
#endif 	/* __IVOBReader_FWD_DEFINED__ */


#ifndef __CVOBReader_FWD_DEFINED__
#define __CVOBReader_FWD_DEFINED__

#ifdef __cplusplus
typedef class CVOBReader CVOBReader;
#else
typedef struct CVOBReader CVOBReader;
#endif /* __cplusplus */

#endif 	/* __CVOBReader_FWD_DEFINED__ */


/* header files for imported files */
#include "oaidl.h"
#include "ocidl.h"

#ifdef __cplusplus
extern "C"{
#endif 


/* interface __MIDL_itf_COMVOBReader_0000_0000 */
/* [local] */ 

typedef BYTE *LPBYTE;



extern RPC_IF_HANDLE __MIDL_itf_COMVOBReader_0000_0000_v0_0_c_ifspec;
extern RPC_IF_HANDLE __MIDL_itf_COMVOBReader_0000_0000_v0_0_s_ifspec;

#ifndef __IVOBReader_INTERFACE_DEFINED__
#define __IVOBReader_INTERFACE_DEFINED__

/* interface IVOBReader */
/* [unique][helpstring][nonextensible][uuid][object] */ 


EXTERN_C const IID IID_IVOBReader;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("C2134A04-839F-44E6-A5D6-A1ABBA62CB1E")
    IVOBReader : public IUnknown
    {
    public:
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ReadSector( 
            /* [in] */ long SectorNumber,
            /* [out] */ LPBYTE *SectorData) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE Initialize( 
            /* [in] */ LPCWSTR VOBPath) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE Test_A( 
            /* [out] */ LPBYTE *SectorData,
            long test) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE DeInit( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE UnlockDrive( 
            /* [in] */ LPCWSTR DrivePath) = 0;
        
    };
    
#else 	/* C style interface */

    typedef struct IVOBReaderVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            IVOBReader * This,
            /* [in] */ REFIID riid,
            /* [iid_is][out] */ 
            __RPC__deref_out  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            IVOBReader * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            IVOBReader * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *ReadSector )( 
            IVOBReader * This,
            /* [in] */ long SectorNumber,
            /* [out] */ LPBYTE *SectorData);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *Initialize )( 
            IVOBReader * This,
            /* [in] */ LPCWSTR VOBPath);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *Test_A )( 
            IVOBReader * This,
            /* [out] */ LPBYTE *SectorData,
            long test);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *DeInit )( 
            IVOBReader * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *UnlockDrive )( 
            IVOBReader * This,
            /* [in] */ LPCWSTR DrivePath);
        
        END_INTERFACE
    } IVOBReaderVtbl;

    interface IVOBReader
    {
        CONST_VTBL struct IVOBReaderVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define IVOBReader_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define IVOBReader_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define IVOBReader_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define IVOBReader_ReadSector(This,SectorNumber,SectorData)	\
    ( (This)->lpVtbl -> ReadSector(This,SectorNumber,SectorData) ) 

#define IVOBReader_Initialize(This,VOBPath)	\
    ( (This)->lpVtbl -> Initialize(This,VOBPath) ) 

#define IVOBReader_Test_A(This,SectorData,test)	\
    ( (This)->lpVtbl -> Test_A(This,SectorData,test) ) 

#define IVOBReader_DeInit(This)	\
    ( (This)->lpVtbl -> DeInit(This) ) 

#define IVOBReader_UnlockDrive(This,DrivePath)	\
    ( (This)->lpVtbl -> UnlockDrive(This,DrivePath) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __IVOBReader_INTERFACE_DEFINED__ */



#ifndef __COMVOBReaderLib_LIBRARY_DEFINED__
#define __COMVOBReaderLib_LIBRARY_DEFINED__

/* library COMVOBReaderLib */
/* [helpstring][version][uuid] */ 


EXTERN_C const IID LIBID_COMVOBReaderLib;

EXTERN_C const CLSID CLSID_CVOBReader;

#ifdef __cplusplus

class DECLSPEC_UUID("707DBF60-B624-4ADF-B89C-6A9B438B2395")
CVOBReader;
#endif
#endif /* __COMVOBReaderLib_LIBRARY_DEFINED__ */

/* Additional Prototypes for ALL interfaces */

/* end of Additional Prototypes */

#ifdef __cplusplus
}
#endif

#endif


