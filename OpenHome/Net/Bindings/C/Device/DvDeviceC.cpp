#include <OpenHome/Net/C/DvDevice.h>
#include <OpenHome/Net/Core/DvDevice.h>
#include "DviDeviceC.h"
#include <OpenHome/Private/Stream.h>

using namespace OpenHome;
using namespace OpenHome::Net;

// DviDeviceC

DviDeviceC::DviDeviceC(const char* aUdn)
{
	Brn udn(aUdn);
	iDevice = new DvDevice(udn);
	iResourceManager = NULL;
	iCallbackArg = NULL;
}

DviDeviceC::DviDeviceC()
{
	iResourceManager = NULL;
	iCallbackArg = NULL;
}

DviDeviceC::~DviDeviceC()
{
	delete iDevice;
}

DvDevice* DviDeviceC::Device()
{
	return iDevice;
}

void DviDeviceC::WriteResource(const Brx& aUriTail, TIpAddress aInterface, std::vector<char*>& aLanguageList, IResourceWriter& aResourceWriter)
{
	ASSERT(iResourceManager != NULL);
	Brhz uriTail(aUriTail);
	int32_t err = iResourceManager(iCallbackArg, uriTail.CString(), aInterface, &aLanguageList, &aResourceWriter, WriteResourceBegin, WriteResource, WriteResourceEnd);
    if (err != 0) {
        THROW(WriterError);
    }
}

int32_t STDCALL DviDeviceC::WriteResourceBegin(void* aPtr, uint32_t aTotalBytes, const char* aMimeType)
{ // static
	IResourceWriter* writer = reinterpret_cast<IResourceWriter*>(aPtr);
    try {
	    writer->WriteResourceBegin(aTotalBytes, aMimeType);
    }
    catch (...) {
        return -1;
    }
    return 0;
}

int32_t STDCALL DviDeviceC::WriteResource(void* aPtr, const uint8_t* aData, uint32_t aBytes)
{ // static
	IResourceWriter* writer = reinterpret_cast<IResourceWriter*>(aPtr);
    try {
    	writer->WriteResource(aData, aBytes);
    }
    catch (...) {
        return -1;
    }
    return 0;
}

int32_t STDCALL DviDeviceC::WriteResourceEnd(void* aPtr)
{ // static
	IResourceWriter* writer = reinterpret_cast<IResourceWriter*>(aPtr);
    try {
    	writer->WriteResourceEnd();
    }
    catch (...) {
        return -1;
    }
    return 0;
}


// DviDeviceStandardC

DviDeviceStandardC::DviDeviceStandardC(const char* aUdn)
{
	Brn udn(aUdn);
	iDevice = new DvDeviceStandard(udn);
}

DviDeviceStandardC::DviDeviceStandardC(const char* aUdn, OhNetCallbackResourceManager aResourceManager, void* aPtr)
{
	Brn udn(aUdn);
	iDevice = new DvDeviceStandard(udn, *this);
	iResourceManager = aResourceManager;
	iCallbackArg = aPtr;
}


// C APIs

DvDeviceC STDCALL DvDeviceCreate(const char* aUdn)
{
	DviDeviceC* wrapper = new DviDeviceC(aUdn);
	return (DvDeviceC)wrapper;
}

void STDCALL DvDeviceDestroy(DvDeviceC aDevice)
{
	delete (DviDeviceC*)aDevice;
}

const char* STDCALL DvDeviceUdn(DvDeviceC aDevice)
{
	return (const char*)DviDeviceC::DeviceFromHandle(aDevice)->Udn().Ptr();
}

int32_t STDCALL DvDeviceEnabled(DvDeviceC aDevice)
{
	return (DviDeviceC::DeviceFromHandle(aDevice)->Enabled()? 1 : 0);
}

void STDCALL DvDeviceSetEnabled(DvDeviceC aDevice)
{
	DviDeviceC::DeviceFromHandle(aDevice)->SetEnabled();
}

void STDCALL DvDeviceSetDisabled(DvDeviceC aDevice, OhNetCallback aCompleted, void* aPtr)
{
	Functor completed = MakeFunctor(aPtr, aCompleted);
	DviDeviceC::DeviceFromHandle(aDevice)->SetDisabled(completed);
}

void STDCALL DvDeviceGetAttribute(DvDeviceC aDevice, const char* aKey, const char** aValue)
{
	DviDeviceC::DeviceFromHandle(aDevice)->GetAttribute(aKey, aValue);
}

void STDCALL DvDeviceSetAttribute(DvDeviceC aDevice, const char* aKey, const char* aValue)
{
	DviDeviceC::DeviceFromHandle(aDevice)->SetAttribute(aKey, aValue);
}

DvDeviceC STDCALL DvDeviceStandardCreateNoResources(const char* aUdn)
{
	DviDeviceStandardC* wrapper = new DviDeviceStandardC(aUdn);
	return (DvDeviceC)wrapper;
}

DvDeviceC STDCALL DvDeviceStandardCreate(const char* aUdn, OhNetCallbackResourceManager aResourceManager, void* aPtr)
{
	DviDeviceStandardC* wrapper = new DviDeviceStandardC(aUdn, aResourceManager, aPtr);
	return (DvDeviceC)wrapper;
}

uint32_t STDCALL DvResourceWriterLanguageCount(THandle aLanguageList)
{
    std::vector<char*>* list = reinterpret_cast<std::vector<char*>*>(aLanguageList);
    ASSERT(list != NULL);
    return (uint32_t)list->size();
}

const char* STDCALL DvResourceWriterLanguage(THandle aLanguageList, uint32_t aIndex)
{
    std::vector<char*>* list = reinterpret_cast<std::vector<char*>*>(aLanguageList);
    ASSERT(list != NULL);
    ASSERT(aIndex < (uint32_t)list->size());
    return (*list)[aIndex];
}
