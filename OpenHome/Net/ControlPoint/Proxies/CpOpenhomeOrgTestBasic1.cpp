#include "CpOpenhomeOrgTestBasic1.h"
#include <OpenHome/Net/Core/CpProxy.h>
#include <OpenHome/Net/Private/CpiService.h>
#include <OpenHome/Private/Thread.h>
#include <OpenHome/Net/Private/AsyncPrivate.h>
#include <OpenHome/Net/Core/CpDevice.h>
#include <OpenHome/Net/Private/Error.h>
#include <OpenHome/Net/Private/CpiDevice.h>

namespace OpenHome {
namespace Net {

class SyncIncrementOpenhomeOrgTestBasic1 : public SyncProxyAction
{
public:
    SyncIncrementOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy, TUint& aResult);
    virtual void CompleteRequest(IAsync& aAsync);
private:
    CpProxyOpenhomeOrgTestBasic1& iService;
    TUint& iResult;
};

class SyncEchoAllowedRangeUintOpenhomeOrgTestBasic1 : public SyncProxyAction
{
public:
    SyncEchoAllowedRangeUintOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy, TUint& aResult);
    virtual void CompleteRequest(IAsync& aAsync);
private:
    CpProxyOpenhomeOrgTestBasic1& iService;
    TUint& iResult;
};

class SyncDecrementOpenhomeOrgTestBasic1 : public SyncProxyAction
{
public:
    SyncDecrementOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy, TInt& aResult);
    virtual void CompleteRequest(IAsync& aAsync);
private:
    CpProxyOpenhomeOrgTestBasic1& iService;
    TInt& iResult;
};

class SyncToggleOpenhomeOrgTestBasic1 : public SyncProxyAction
{
public:
    SyncToggleOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy, TBool& aResult);
    virtual void CompleteRequest(IAsync& aAsync);
private:
    CpProxyOpenhomeOrgTestBasic1& iService;
    TBool& iResult;
};

class SyncEchoStringOpenhomeOrgTestBasic1 : public SyncProxyAction
{
public:
    SyncEchoStringOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy, Brh& aResult);
    virtual void CompleteRequest(IAsync& aAsync);
private:
    CpProxyOpenhomeOrgTestBasic1& iService;
    Brh& iResult;
};

class SyncEchoAllowedValueStringOpenhomeOrgTestBasic1 : public SyncProxyAction
{
public:
    SyncEchoAllowedValueStringOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy, Brh& aResult);
    virtual void CompleteRequest(IAsync& aAsync);
private:
    CpProxyOpenhomeOrgTestBasic1& iService;
    Brh& iResult;
};

class SyncEchoBinaryOpenhomeOrgTestBasic1 : public SyncProxyAction
{
public:
    SyncEchoBinaryOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy, Brh& aResult);
    virtual void CompleteRequest(IAsync& aAsync);
private:
    CpProxyOpenhomeOrgTestBasic1& iService;
    Brh& iResult;
};

class SyncSetUintOpenhomeOrgTestBasic1 : public SyncProxyAction
{
public:
    SyncSetUintOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy);
    virtual void CompleteRequest(IAsync& aAsync);
private:
    CpProxyOpenhomeOrgTestBasic1& iService;
};

class SyncGetUintOpenhomeOrgTestBasic1 : public SyncProxyAction
{
public:
    SyncGetUintOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy, TUint& aValueUint);
    virtual void CompleteRequest(IAsync& aAsync);
private:
    CpProxyOpenhomeOrgTestBasic1& iService;
    TUint& iValueUint;
};

class SyncSetIntOpenhomeOrgTestBasic1 : public SyncProxyAction
{
public:
    SyncSetIntOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy);
    virtual void CompleteRequest(IAsync& aAsync);
private:
    CpProxyOpenhomeOrgTestBasic1& iService;
};

class SyncGetIntOpenhomeOrgTestBasic1 : public SyncProxyAction
{
public:
    SyncGetIntOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy, TInt& aValueInt);
    virtual void CompleteRequest(IAsync& aAsync);
private:
    CpProxyOpenhomeOrgTestBasic1& iService;
    TInt& iValueInt;
};

class SyncSetBoolOpenhomeOrgTestBasic1 : public SyncProxyAction
{
public:
    SyncSetBoolOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy);
    virtual void CompleteRequest(IAsync& aAsync);
private:
    CpProxyOpenhomeOrgTestBasic1& iService;
};

class SyncGetBoolOpenhomeOrgTestBasic1 : public SyncProxyAction
{
public:
    SyncGetBoolOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy, TBool& aValueBool);
    virtual void CompleteRequest(IAsync& aAsync);
private:
    CpProxyOpenhomeOrgTestBasic1& iService;
    TBool& iValueBool;
};

class SyncSetMultipleOpenhomeOrgTestBasic1 : public SyncProxyAction
{
public:
    SyncSetMultipleOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy);
    virtual void CompleteRequest(IAsync& aAsync);
private:
    CpProxyOpenhomeOrgTestBasic1& iService;
};

class SyncGetMultipleOpenhomeOrgTestBasic1 : public SyncProxyAction
{
public:
    SyncGetMultipleOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy, TUint& aValueUint, TInt& aValueInt, TBool& aValueBool);
    virtual void CompleteRequest(IAsync& aAsync);
private:
    CpProxyOpenhomeOrgTestBasic1& iService;
    TUint& iValueUint;
    TInt& iValueInt;
    TBool& iValueBool;
};

class SyncSetStringOpenhomeOrgTestBasic1 : public SyncProxyAction
{
public:
    SyncSetStringOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy);
    virtual void CompleteRequest(IAsync& aAsync);
private:
    CpProxyOpenhomeOrgTestBasic1& iService;
};

class SyncGetStringOpenhomeOrgTestBasic1 : public SyncProxyAction
{
public:
    SyncGetStringOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy, Brh& aValueStr);
    virtual void CompleteRequest(IAsync& aAsync);
private:
    CpProxyOpenhomeOrgTestBasic1& iService;
    Brh& iValueStr;
};

class SyncSetBinaryOpenhomeOrgTestBasic1 : public SyncProxyAction
{
public:
    SyncSetBinaryOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy);
    virtual void CompleteRequest(IAsync& aAsync);
private:
    CpProxyOpenhomeOrgTestBasic1& iService;
};

class SyncGetBinaryOpenhomeOrgTestBasic1 : public SyncProxyAction
{
public:
    SyncGetBinaryOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy, Brh& aValueBin);
    virtual void CompleteRequest(IAsync& aAsync);
private:
    CpProxyOpenhomeOrgTestBasic1& iService;
    Brh& iValueBin;
};

class SyncToggleBoolOpenhomeOrgTestBasic1 : public SyncProxyAction
{
public:
    SyncToggleBoolOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy);
    virtual void CompleteRequest(IAsync& aAsync);
private:
    CpProxyOpenhomeOrgTestBasic1& iService;
};

class SyncReportErrorOpenhomeOrgTestBasic1 : public SyncProxyAction
{
public:
    SyncReportErrorOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy);
    virtual void CompleteRequest(IAsync& aAsync);
private:
    CpProxyOpenhomeOrgTestBasic1& iService;
};

class SyncWriteFileOpenhomeOrgTestBasic1 : public SyncProxyAction
{
public:
    SyncWriteFileOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy);
    virtual void CompleteRequest(IAsync& aAsync);
private:
    CpProxyOpenhomeOrgTestBasic1& iService;
};

class SyncShutdownOpenhomeOrgTestBasic1 : public SyncProxyAction
{
public:
    SyncShutdownOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy);
    virtual void CompleteRequest(IAsync& aAsync);
private:
    CpProxyOpenhomeOrgTestBasic1& iService;
};

} // namespace Net
} // namespace OpenHome


using namespace OpenHome;
using namespace OpenHome::Net;


// SyncIncrementOpenhomeOrgTestBasic1

SyncIncrementOpenhomeOrgTestBasic1::SyncIncrementOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy, TUint& aResult)
    : iService(aProxy)
    , iResult(aResult)
{
}

void SyncIncrementOpenhomeOrgTestBasic1::CompleteRequest(IAsync& aAsync)
{
    iService.EndIncrement(aAsync, iResult);
}

// SyncEchoAllowedRangeUintOpenhomeOrgTestBasic1

SyncEchoAllowedRangeUintOpenhomeOrgTestBasic1::SyncEchoAllowedRangeUintOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy, TUint& aResult)
    : iService(aProxy)
    , iResult(aResult)
{
}

void SyncEchoAllowedRangeUintOpenhomeOrgTestBasic1::CompleteRequest(IAsync& aAsync)
{
    iService.EndEchoAllowedRangeUint(aAsync, iResult);
}

// SyncDecrementOpenhomeOrgTestBasic1

SyncDecrementOpenhomeOrgTestBasic1::SyncDecrementOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy, TInt& aResult)
    : iService(aProxy)
    , iResult(aResult)
{
}

void SyncDecrementOpenhomeOrgTestBasic1::CompleteRequest(IAsync& aAsync)
{
    iService.EndDecrement(aAsync, iResult);
}

// SyncToggleOpenhomeOrgTestBasic1

SyncToggleOpenhomeOrgTestBasic1::SyncToggleOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy, TBool& aResult)
    : iService(aProxy)
    , iResult(aResult)
{
}

void SyncToggleOpenhomeOrgTestBasic1::CompleteRequest(IAsync& aAsync)
{
    iService.EndToggle(aAsync, iResult);
}

// SyncEchoStringOpenhomeOrgTestBasic1

SyncEchoStringOpenhomeOrgTestBasic1::SyncEchoStringOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy, Brh& aResult)
    : iService(aProxy)
    , iResult(aResult)
{
}

void SyncEchoStringOpenhomeOrgTestBasic1::CompleteRequest(IAsync& aAsync)
{
    iService.EndEchoString(aAsync, iResult);
}

// SyncEchoAllowedValueStringOpenhomeOrgTestBasic1

SyncEchoAllowedValueStringOpenhomeOrgTestBasic1::SyncEchoAllowedValueStringOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy, Brh& aResult)
    : iService(aProxy)
    , iResult(aResult)
{
}

void SyncEchoAllowedValueStringOpenhomeOrgTestBasic1::CompleteRequest(IAsync& aAsync)
{
    iService.EndEchoAllowedValueString(aAsync, iResult);
}

// SyncEchoBinaryOpenhomeOrgTestBasic1

SyncEchoBinaryOpenhomeOrgTestBasic1::SyncEchoBinaryOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy, Brh& aResult)
    : iService(aProxy)
    , iResult(aResult)
{
}

void SyncEchoBinaryOpenhomeOrgTestBasic1::CompleteRequest(IAsync& aAsync)
{
    iService.EndEchoBinary(aAsync, iResult);
}

// SyncSetUintOpenhomeOrgTestBasic1

SyncSetUintOpenhomeOrgTestBasic1::SyncSetUintOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy)
    : iService(aProxy)
{
}

void SyncSetUintOpenhomeOrgTestBasic1::CompleteRequest(IAsync& aAsync)
{
    iService.EndSetUint(aAsync);
}

// SyncGetUintOpenhomeOrgTestBasic1

SyncGetUintOpenhomeOrgTestBasic1::SyncGetUintOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy, TUint& aValueUint)
    : iService(aProxy)
    , iValueUint(aValueUint)
{
}

void SyncGetUintOpenhomeOrgTestBasic1::CompleteRequest(IAsync& aAsync)
{
    iService.EndGetUint(aAsync, iValueUint);
}

// SyncSetIntOpenhomeOrgTestBasic1

SyncSetIntOpenhomeOrgTestBasic1::SyncSetIntOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy)
    : iService(aProxy)
{
}

void SyncSetIntOpenhomeOrgTestBasic1::CompleteRequest(IAsync& aAsync)
{
    iService.EndSetInt(aAsync);
}

// SyncGetIntOpenhomeOrgTestBasic1

SyncGetIntOpenhomeOrgTestBasic1::SyncGetIntOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy, TInt& aValueInt)
    : iService(aProxy)
    , iValueInt(aValueInt)
{
}

void SyncGetIntOpenhomeOrgTestBasic1::CompleteRequest(IAsync& aAsync)
{
    iService.EndGetInt(aAsync, iValueInt);
}

// SyncSetBoolOpenhomeOrgTestBasic1

SyncSetBoolOpenhomeOrgTestBasic1::SyncSetBoolOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy)
    : iService(aProxy)
{
}

void SyncSetBoolOpenhomeOrgTestBasic1::CompleteRequest(IAsync& aAsync)
{
    iService.EndSetBool(aAsync);
}

// SyncGetBoolOpenhomeOrgTestBasic1

SyncGetBoolOpenhomeOrgTestBasic1::SyncGetBoolOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy, TBool& aValueBool)
    : iService(aProxy)
    , iValueBool(aValueBool)
{
}

void SyncGetBoolOpenhomeOrgTestBasic1::CompleteRequest(IAsync& aAsync)
{
    iService.EndGetBool(aAsync, iValueBool);
}

// SyncSetMultipleOpenhomeOrgTestBasic1

SyncSetMultipleOpenhomeOrgTestBasic1::SyncSetMultipleOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy)
    : iService(aProxy)
{
}

void SyncSetMultipleOpenhomeOrgTestBasic1::CompleteRequest(IAsync& aAsync)
{
    iService.EndSetMultiple(aAsync);
}

// SyncGetMultipleOpenhomeOrgTestBasic1

SyncGetMultipleOpenhomeOrgTestBasic1::SyncGetMultipleOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy, TUint& aValueUint, TInt& aValueInt, TBool& aValueBool)
    : iService(aProxy)
    , iValueUint(aValueUint)
    , iValueInt(aValueInt)
    , iValueBool(aValueBool)
{
}

void SyncGetMultipleOpenhomeOrgTestBasic1::CompleteRequest(IAsync& aAsync)
{
    iService.EndGetMultiple(aAsync, iValueUint, iValueInt, iValueBool);
}

// SyncSetStringOpenhomeOrgTestBasic1

SyncSetStringOpenhomeOrgTestBasic1::SyncSetStringOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy)
    : iService(aProxy)
{
}

void SyncSetStringOpenhomeOrgTestBasic1::CompleteRequest(IAsync& aAsync)
{
    iService.EndSetString(aAsync);
}

// SyncGetStringOpenhomeOrgTestBasic1

SyncGetStringOpenhomeOrgTestBasic1::SyncGetStringOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy, Brh& aValueStr)
    : iService(aProxy)
    , iValueStr(aValueStr)
{
}

void SyncGetStringOpenhomeOrgTestBasic1::CompleteRequest(IAsync& aAsync)
{
    iService.EndGetString(aAsync, iValueStr);
}

// SyncSetBinaryOpenhomeOrgTestBasic1

SyncSetBinaryOpenhomeOrgTestBasic1::SyncSetBinaryOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy)
    : iService(aProxy)
{
}

void SyncSetBinaryOpenhomeOrgTestBasic1::CompleteRequest(IAsync& aAsync)
{
    iService.EndSetBinary(aAsync);
}

// SyncGetBinaryOpenhomeOrgTestBasic1

SyncGetBinaryOpenhomeOrgTestBasic1::SyncGetBinaryOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy, Brh& aValueBin)
    : iService(aProxy)
    , iValueBin(aValueBin)
{
}

void SyncGetBinaryOpenhomeOrgTestBasic1::CompleteRequest(IAsync& aAsync)
{
    iService.EndGetBinary(aAsync, iValueBin);
}

// SyncToggleBoolOpenhomeOrgTestBasic1

SyncToggleBoolOpenhomeOrgTestBasic1::SyncToggleBoolOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy)
    : iService(aProxy)
{
}

void SyncToggleBoolOpenhomeOrgTestBasic1::CompleteRequest(IAsync& aAsync)
{
    iService.EndToggleBool(aAsync);
}

// SyncReportErrorOpenhomeOrgTestBasic1

SyncReportErrorOpenhomeOrgTestBasic1::SyncReportErrorOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy)
    : iService(aProxy)
{
}

void SyncReportErrorOpenhomeOrgTestBasic1::CompleteRequest(IAsync& aAsync)
{
    iService.EndReportError(aAsync);
}

// SyncWriteFileOpenhomeOrgTestBasic1

SyncWriteFileOpenhomeOrgTestBasic1::SyncWriteFileOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy)
    : iService(aProxy)
{
}

void SyncWriteFileOpenhomeOrgTestBasic1::CompleteRequest(IAsync& aAsync)
{
    iService.EndWriteFile(aAsync);
}

// SyncShutdownOpenhomeOrgTestBasic1

SyncShutdownOpenhomeOrgTestBasic1::SyncShutdownOpenhomeOrgTestBasic1(CpProxyOpenhomeOrgTestBasic1& aProxy)
    : iService(aProxy)
{
}

void SyncShutdownOpenhomeOrgTestBasic1::CompleteRequest(IAsync& aAsync)
{
    iService.EndShutdown(aAsync);
}


// CpProxyOpenhomeOrgTestBasic1

CpProxyOpenhomeOrgTestBasic1::CpProxyOpenhomeOrgTestBasic1(CpDevice& aDevice)
    : iCpProxy("openhome-org", "TestBasic", 1, aDevice.Device())
{
    OpenHome::Net::Parameter* param;
    TChar** allowedValues;
    TUint index;

    iActionIncrement = new Action("Increment");
    param = new OpenHome::Net::ParameterUint("Value");
    iActionIncrement->AddInputParameter(param);
    param = new OpenHome::Net::ParameterUint("Result");
    iActionIncrement->AddOutputParameter(param);

    iActionEchoAllowedRangeUint = new Action("EchoAllowedRangeUint");
    param = new OpenHome::Net::ParameterUint("Value", 10, 20);
    iActionEchoAllowedRangeUint->AddInputParameter(param);
    param = new OpenHome::Net::ParameterUint("Result");
    iActionEchoAllowedRangeUint->AddOutputParameter(param);

    iActionDecrement = new Action("Decrement");
    param = new OpenHome::Net::ParameterInt("Value");
    iActionDecrement->AddInputParameter(param);
    param = new OpenHome::Net::ParameterInt("Result");
    iActionDecrement->AddOutputParameter(param);

    iActionToggle = new Action("Toggle");
    param = new OpenHome::Net::ParameterBool("Value");
    iActionToggle->AddInputParameter(param);
    param = new OpenHome::Net::ParameterBool("Result");
    iActionToggle->AddOutputParameter(param);

    iActionEchoString = new Action("EchoString");
    param = new OpenHome::Net::ParameterString("Value");
    iActionEchoString->AddInputParameter(param);
    param = new OpenHome::Net::ParameterString("Result");
    iActionEchoString->AddOutputParameter(param);

    iActionEchoAllowedValueString = new Action("EchoAllowedValueString");
    index = 0;
    allowedValues = new TChar*[4];
    allowedValues[index++] = (TChar*)"One";
    allowedValues[index++] = (TChar*)"Two";
    allowedValues[index++] = (TChar*)"Three";
    allowedValues[index++] = (TChar*)"Four";
    param = new OpenHome::Net::ParameterString("Value", allowedValues, 4);
    iActionEchoAllowedValueString->AddInputParameter(param);
    delete[] allowedValues;
    param = new OpenHome::Net::ParameterString("Result");
    iActionEchoAllowedValueString->AddOutputParameter(param);

    iActionEchoBinary = new Action("EchoBinary");
    param = new OpenHome::Net::ParameterBinary("Value");
    iActionEchoBinary->AddInputParameter(param);
    param = new OpenHome::Net::ParameterBinary("Result");
    iActionEchoBinary->AddOutputParameter(param);

    iActionSetUint = new Action("SetUint");
    param = new OpenHome::Net::ParameterUint("ValueUint");
    iActionSetUint->AddInputParameter(param);

    iActionGetUint = new Action("GetUint");
    param = new OpenHome::Net::ParameterUint("ValueUint");
    iActionGetUint->AddOutputParameter(param);

    iActionSetInt = new Action("SetInt");
    param = new OpenHome::Net::ParameterInt("ValueInt");
    iActionSetInt->AddInputParameter(param);

    iActionGetInt = new Action("GetInt");
    param = new OpenHome::Net::ParameterInt("ValueInt");
    iActionGetInt->AddOutputParameter(param);

    iActionSetBool = new Action("SetBool");
    param = new OpenHome::Net::ParameterBool("ValueBool");
    iActionSetBool->AddInputParameter(param);

    iActionGetBool = new Action("GetBool");
    param = new OpenHome::Net::ParameterBool("ValueBool");
    iActionGetBool->AddOutputParameter(param);

    iActionSetMultiple = new Action("SetMultiple");
    param = new OpenHome::Net::ParameterUint("ValueUint");
    iActionSetMultiple->AddInputParameter(param);
    param = new OpenHome::Net::ParameterInt("ValueInt");
    iActionSetMultiple->AddInputParameter(param);
    param = new OpenHome::Net::ParameterBool("ValueBool");
    iActionSetMultiple->AddInputParameter(param);

    iActionGetMultiple = new Action("GetMultiple");
    param = new OpenHome::Net::ParameterUint("ValueUint");
    iActionGetMultiple->AddOutputParameter(param);
    param = new OpenHome::Net::ParameterInt("ValueInt");
    iActionGetMultiple->AddOutputParameter(param);
    param = new OpenHome::Net::ParameterBool("ValueBool");
    iActionGetMultiple->AddOutputParameter(param);

    iActionSetString = new Action("SetString");
    param = new OpenHome::Net::ParameterString("ValueStr");
    iActionSetString->AddInputParameter(param);

    iActionGetString = new Action("GetString");
    param = new OpenHome::Net::ParameterString("ValueStr");
    iActionGetString->AddOutputParameter(param);

    iActionSetBinary = new Action("SetBinary");
    param = new OpenHome::Net::ParameterBinary("ValueBin");
    iActionSetBinary->AddInputParameter(param);

    iActionGetBinary = new Action("GetBinary");
    param = new OpenHome::Net::ParameterBinary("ValueBin");
    iActionGetBinary->AddOutputParameter(param);

    iActionToggleBool = new Action("ToggleBool");

    iActionReportError = new Action("ReportError");

    iActionWriteFile = new Action("WriteFile");
    param = new OpenHome::Net::ParameterString("Data");
    iActionWriteFile->AddInputParameter(param);
    param = new OpenHome::Net::ParameterString("FileFullName");
    iActionWriteFile->AddInputParameter(param);

    iActionShutdown = new Action("Shutdown");

    Functor functor;
    functor = MakeFunctor(*this, &CpProxyOpenhomeOrgTestBasic1::VarUintPropertyChanged);
    iVarUint = new PropertyUint("VarUint", functor);
    AddProperty(iVarUint);
    functor = MakeFunctor(*this, &CpProxyOpenhomeOrgTestBasic1::VarIntPropertyChanged);
    iVarInt = new PropertyInt("VarInt", functor);
    AddProperty(iVarInt);
    functor = MakeFunctor(*this, &CpProxyOpenhomeOrgTestBasic1::VarBoolPropertyChanged);
    iVarBool = new PropertyBool("VarBool", functor);
    AddProperty(iVarBool);
    functor = MakeFunctor(*this, &CpProxyOpenhomeOrgTestBasic1::VarStrPropertyChanged);
    iVarStr = new PropertyString("VarStr", functor);
    AddProperty(iVarStr);
    functor = MakeFunctor(*this, &CpProxyOpenhomeOrgTestBasic1::VarBinPropertyChanged);
    iVarBin = new PropertyBinary("VarBin", functor);
    AddProperty(iVarBin);
}

CpProxyOpenhomeOrgTestBasic1::~CpProxyOpenhomeOrgTestBasic1()
{
    DestroyService();
    delete iActionIncrement;
    delete iActionEchoAllowedRangeUint;
    delete iActionDecrement;
    delete iActionToggle;
    delete iActionEchoString;
    delete iActionEchoAllowedValueString;
    delete iActionEchoBinary;
    delete iActionSetUint;
    delete iActionGetUint;
    delete iActionSetInt;
    delete iActionGetInt;
    delete iActionSetBool;
    delete iActionGetBool;
    delete iActionSetMultiple;
    delete iActionGetMultiple;
    delete iActionSetString;
    delete iActionGetString;
    delete iActionSetBinary;
    delete iActionGetBinary;
    delete iActionToggleBool;
    delete iActionReportError;
    delete iActionWriteFile;
    delete iActionShutdown;
}

void CpProxyOpenhomeOrgTestBasic1::SyncIncrement(TUint aValue, TUint& aResult)
{
    SyncIncrementOpenhomeOrgTestBasic1 sync(*this, aResult);
    BeginIncrement(aValue, sync.Functor());
    sync.Wait();
}

void CpProxyOpenhomeOrgTestBasic1::BeginIncrement(TUint aValue, FunctorAsync& aFunctor)
{
    Invocation* invocation = iCpProxy.GetService().Invocation(*iActionIncrement, aFunctor);
    TUint inIndex = 0;
    const Action::VectorParameters& inParams = iActionIncrement->InputParameters();
    invocation->AddInput(new ArgumentUint(*inParams[inIndex++], aValue));
    TUint outIndex = 0;
    const Action::VectorParameters& outParams = iActionIncrement->OutputParameters();
    invocation->AddOutput(new ArgumentUint(*outParams[outIndex++]));
    iCpProxy.GetInvocable().InvokeAction(*invocation);
}

void CpProxyOpenhomeOrgTestBasic1::EndIncrement(IAsync& aAsync, TUint& aResult)
{
    ASSERT(((Async&)aAsync).Type() == Async::eInvocation);
    Invocation& invocation = (Invocation&)aAsync;
    ASSERT(invocation.Action().Name() == Brn("Increment"));

    Error::ELevel level;
    TUint code;
    const TChar* ignore;
    if (invocation.Error(level, code, ignore)) {
        THROW_PROXYERROR(level, code);
    }
    TUint index = 0;
    aResult = ((ArgumentUint*)invocation.OutputArguments()[index++])->Value();
}

void CpProxyOpenhomeOrgTestBasic1::SyncEchoAllowedRangeUint(TUint aValue, TUint& aResult)
{
    SyncEchoAllowedRangeUintOpenhomeOrgTestBasic1 sync(*this, aResult);
    BeginEchoAllowedRangeUint(aValue, sync.Functor());
    sync.Wait();
}

void CpProxyOpenhomeOrgTestBasic1::BeginEchoAllowedRangeUint(TUint aValue, FunctorAsync& aFunctor)
{
    Invocation* invocation = iCpProxy.GetService().Invocation(*iActionEchoAllowedRangeUint, aFunctor);
    TUint inIndex = 0;
    const Action::VectorParameters& inParams = iActionEchoAllowedRangeUint->InputParameters();
    invocation->AddInput(new ArgumentUint(*inParams[inIndex++], aValue));
    TUint outIndex = 0;
    const Action::VectorParameters& outParams = iActionEchoAllowedRangeUint->OutputParameters();
    invocation->AddOutput(new ArgumentUint(*outParams[outIndex++]));
    iCpProxy.GetInvocable().InvokeAction(*invocation);
}

void CpProxyOpenhomeOrgTestBasic1::EndEchoAllowedRangeUint(IAsync& aAsync, TUint& aResult)
{
    ASSERT(((Async&)aAsync).Type() == Async::eInvocation);
    Invocation& invocation = (Invocation&)aAsync;
    ASSERT(invocation.Action().Name() == Brn("EchoAllowedRangeUint"));

    Error::ELevel level;
    TUint code;
    const TChar* ignore;
    if (invocation.Error(level, code, ignore)) {
        THROW_PROXYERROR(level, code);
    }
    TUint index = 0;
    aResult = ((ArgumentUint*)invocation.OutputArguments()[index++])->Value();
}

void CpProxyOpenhomeOrgTestBasic1::SyncDecrement(TInt aValue, TInt& aResult)
{
    SyncDecrementOpenhomeOrgTestBasic1 sync(*this, aResult);
    BeginDecrement(aValue, sync.Functor());
    sync.Wait();
}

void CpProxyOpenhomeOrgTestBasic1::BeginDecrement(TInt aValue, FunctorAsync& aFunctor)
{
    Invocation* invocation = iCpProxy.GetService().Invocation(*iActionDecrement, aFunctor);
    TUint inIndex = 0;
    const Action::VectorParameters& inParams = iActionDecrement->InputParameters();
    invocation->AddInput(new ArgumentInt(*inParams[inIndex++], aValue));
    TUint outIndex = 0;
    const Action::VectorParameters& outParams = iActionDecrement->OutputParameters();
    invocation->AddOutput(new ArgumentInt(*outParams[outIndex++]));
    iCpProxy.GetInvocable().InvokeAction(*invocation);
}

void CpProxyOpenhomeOrgTestBasic1::EndDecrement(IAsync& aAsync, TInt& aResult)
{
    ASSERT(((Async&)aAsync).Type() == Async::eInvocation);
    Invocation& invocation = (Invocation&)aAsync;
    ASSERT(invocation.Action().Name() == Brn("Decrement"));

    Error::ELevel level;
    TUint code;
    const TChar* ignore;
    if (invocation.Error(level, code, ignore)) {
        THROW_PROXYERROR(level, code);
    }
    TUint index = 0;
    aResult = ((ArgumentInt*)invocation.OutputArguments()[index++])->Value();
}

void CpProxyOpenhomeOrgTestBasic1::SyncToggle(TBool aValue, TBool& aResult)
{
    SyncToggleOpenhomeOrgTestBasic1 sync(*this, aResult);
    BeginToggle(aValue, sync.Functor());
    sync.Wait();
}

void CpProxyOpenhomeOrgTestBasic1::BeginToggle(TBool aValue, FunctorAsync& aFunctor)
{
    Invocation* invocation = iCpProxy.GetService().Invocation(*iActionToggle, aFunctor);
    TUint inIndex = 0;
    const Action::VectorParameters& inParams = iActionToggle->InputParameters();
    invocation->AddInput(new ArgumentBool(*inParams[inIndex++], aValue));
    TUint outIndex = 0;
    const Action::VectorParameters& outParams = iActionToggle->OutputParameters();
    invocation->AddOutput(new ArgumentBool(*outParams[outIndex++]));
    iCpProxy.GetInvocable().InvokeAction(*invocation);
}

void CpProxyOpenhomeOrgTestBasic1::EndToggle(IAsync& aAsync, TBool& aResult)
{
    ASSERT(((Async&)aAsync).Type() == Async::eInvocation);
    Invocation& invocation = (Invocation&)aAsync;
    ASSERT(invocation.Action().Name() == Brn("Toggle"));

    Error::ELevel level;
    TUint code;
    const TChar* ignore;
    if (invocation.Error(level, code, ignore)) {
        THROW_PROXYERROR(level, code);
    }
    TUint index = 0;
    aResult = ((ArgumentBool*)invocation.OutputArguments()[index++])->Value();
}

void CpProxyOpenhomeOrgTestBasic1::SyncEchoString(const Brx& aValue, Brh& aResult)
{
    SyncEchoStringOpenhomeOrgTestBasic1 sync(*this, aResult);
    BeginEchoString(aValue, sync.Functor());
    sync.Wait();
}

void CpProxyOpenhomeOrgTestBasic1::BeginEchoString(const Brx& aValue, FunctorAsync& aFunctor)
{
    Invocation* invocation = iCpProxy.GetService().Invocation(*iActionEchoString, aFunctor);
    TUint inIndex = 0;
    const Action::VectorParameters& inParams = iActionEchoString->InputParameters();
    invocation->AddInput(new ArgumentString(*inParams[inIndex++], aValue));
    TUint outIndex = 0;
    const Action::VectorParameters& outParams = iActionEchoString->OutputParameters();
    invocation->AddOutput(new ArgumentString(*outParams[outIndex++]));
    iCpProxy.GetInvocable().InvokeAction(*invocation);
}

void CpProxyOpenhomeOrgTestBasic1::EndEchoString(IAsync& aAsync, Brh& aResult)
{
    ASSERT(((Async&)aAsync).Type() == Async::eInvocation);
    Invocation& invocation = (Invocation&)aAsync;
    ASSERT(invocation.Action().Name() == Brn("EchoString"));

    Error::ELevel level;
    TUint code;
    const TChar* ignore;
    if (invocation.Error(level, code, ignore)) {
        THROW_PROXYERROR(level, code);
    }
    TUint index = 0;
    ((ArgumentString*)invocation.OutputArguments()[index++])->TransferTo(aResult);
}

void CpProxyOpenhomeOrgTestBasic1::SyncEchoAllowedValueString(const Brx& aValue, Brh& aResult)
{
    SyncEchoAllowedValueStringOpenhomeOrgTestBasic1 sync(*this, aResult);
    BeginEchoAllowedValueString(aValue, sync.Functor());
    sync.Wait();
}

void CpProxyOpenhomeOrgTestBasic1::BeginEchoAllowedValueString(const Brx& aValue, FunctorAsync& aFunctor)
{
    Invocation* invocation = iCpProxy.GetService().Invocation(*iActionEchoAllowedValueString, aFunctor);
    TUint inIndex = 0;
    const Action::VectorParameters& inParams = iActionEchoAllowedValueString->InputParameters();
    invocation->AddInput(new ArgumentString(*inParams[inIndex++], aValue));
    TUint outIndex = 0;
    const Action::VectorParameters& outParams = iActionEchoAllowedValueString->OutputParameters();
    invocation->AddOutput(new ArgumentString(*outParams[outIndex++]));
    iCpProxy.GetInvocable().InvokeAction(*invocation);
}

void CpProxyOpenhomeOrgTestBasic1::EndEchoAllowedValueString(IAsync& aAsync, Brh& aResult)
{
    ASSERT(((Async&)aAsync).Type() == Async::eInvocation);
    Invocation& invocation = (Invocation&)aAsync;
    ASSERT(invocation.Action().Name() == Brn("EchoAllowedValueString"));

    Error::ELevel level;
    TUint code;
    const TChar* ignore;
    if (invocation.Error(level, code, ignore)) {
        THROW_PROXYERROR(level, code);
    }
    TUint index = 0;
    ((ArgumentString*)invocation.OutputArguments()[index++])->TransferTo(aResult);
}

void CpProxyOpenhomeOrgTestBasic1::SyncEchoBinary(const Brx& aValue, Brh& aResult)
{
    SyncEchoBinaryOpenhomeOrgTestBasic1 sync(*this, aResult);
    BeginEchoBinary(aValue, sync.Functor());
    sync.Wait();
}

void CpProxyOpenhomeOrgTestBasic1::BeginEchoBinary(const Brx& aValue, FunctorAsync& aFunctor)
{
    Invocation* invocation = iCpProxy.GetService().Invocation(*iActionEchoBinary, aFunctor);
    TUint inIndex = 0;
    const Action::VectorParameters& inParams = iActionEchoBinary->InputParameters();
    invocation->AddInput(new ArgumentBinary(*inParams[inIndex++], aValue));
    TUint outIndex = 0;
    const Action::VectorParameters& outParams = iActionEchoBinary->OutputParameters();
    invocation->AddOutput(new ArgumentBinary(*outParams[outIndex++]));
    iCpProxy.GetInvocable().InvokeAction(*invocation);
}

void CpProxyOpenhomeOrgTestBasic1::EndEchoBinary(IAsync& aAsync, Brh& aResult)
{
    ASSERT(((Async&)aAsync).Type() == Async::eInvocation);
    Invocation& invocation = (Invocation&)aAsync;
    ASSERT(invocation.Action().Name() == Brn("EchoBinary"));

    Error::ELevel level;
    TUint code;
    const TChar* ignore;
    if (invocation.Error(level, code, ignore)) {
        THROW_PROXYERROR(level, code);
    }
    TUint index = 0;
    ((ArgumentBinary*)invocation.OutputArguments()[index++])->TransferTo(aResult);
}

void CpProxyOpenhomeOrgTestBasic1::SyncSetUint(TUint aValueUint)
{
    SyncSetUintOpenhomeOrgTestBasic1 sync(*this);
    BeginSetUint(aValueUint, sync.Functor());
    sync.Wait();
}

void CpProxyOpenhomeOrgTestBasic1::BeginSetUint(TUint aValueUint, FunctorAsync& aFunctor)
{
    Invocation* invocation = iCpProxy.GetService().Invocation(*iActionSetUint, aFunctor);
    TUint inIndex = 0;
    const Action::VectorParameters& inParams = iActionSetUint->InputParameters();
    invocation->AddInput(new ArgumentUint(*inParams[inIndex++], aValueUint));
    iCpProxy.GetInvocable().InvokeAction(*invocation);
}

void CpProxyOpenhomeOrgTestBasic1::EndSetUint(IAsync& aAsync)
{
    ASSERT(((Async&)aAsync).Type() == Async::eInvocation);
    Invocation& invocation = (Invocation&)aAsync;
    ASSERT(invocation.Action().Name() == Brn("SetUint"));

    Error::ELevel level;
    TUint code;
    const TChar* ignore;
    if (invocation.Error(level, code, ignore)) {
        THROW_PROXYERROR(level, code);
    }
}

void CpProxyOpenhomeOrgTestBasic1::SyncGetUint(TUint& aValueUint)
{
    SyncGetUintOpenhomeOrgTestBasic1 sync(*this, aValueUint);
    BeginGetUint(sync.Functor());
    sync.Wait();
}

void CpProxyOpenhomeOrgTestBasic1::BeginGetUint(FunctorAsync& aFunctor)
{
    Invocation* invocation = iCpProxy.GetService().Invocation(*iActionGetUint, aFunctor);
    TUint outIndex = 0;
    const Action::VectorParameters& outParams = iActionGetUint->OutputParameters();
    invocation->AddOutput(new ArgumentUint(*outParams[outIndex++]));
    iCpProxy.GetInvocable().InvokeAction(*invocation);
}

void CpProxyOpenhomeOrgTestBasic1::EndGetUint(IAsync& aAsync, TUint& aValueUint)
{
    ASSERT(((Async&)aAsync).Type() == Async::eInvocation);
    Invocation& invocation = (Invocation&)aAsync;
    ASSERT(invocation.Action().Name() == Brn("GetUint"));

    Error::ELevel level;
    TUint code;
    const TChar* ignore;
    if (invocation.Error(level, code, ignore)) {
        THROW_PROXYERROR(level, code);
    }
    TUint index = 0;
    aValueUint = ((ArgumentUint*)invocation.OutputArguments()[index++])->Value();
}

void CpProxyOpenhomeOrgTestBasic1::SyncSetInt(TInt aValueInt)
{
    SyncSetIntOpenhomeOrgTestBasic1 sync(*this);
    BeginSetInt(aValueInt, sync.Functor());
    sync.Wait();
}

void CpProxyOpenhomeOrgTestBasic1::BeginSetInt(TInt aValueInt, FunctorAsync& aFunctor)
{
    Invocation* invocation = iCpProxy.GetService().Invocation(*iActionSetInt, aFunctor);
    TUint inIndex = 0;
    const Action::VectorParameters& inParams = iActionSetInt->InputParameters();
    invocation->AddInput(new ArgumentInt(*inParams[inIndex++], aValueInt));
    iCpProxy.GetInvocable().InvokeAction(*invocation);
}

void CpProxyOpenhomeOrgTestBasic1::EndSetInt(IAsync& aAsync)
{
    ASSERT(((Async&)aAsync).Type() == Async::eInvocation);
    Invocation& invocation = (Invocation&)aAsync;
    ASSERT(invocation.Action().Name() == Brn("SetInt"));

    Error::ELevel level;
    TUint code;
    const TChar* ignore;
    if (invocation.Error(level, code, ignore)) {
        THROW_PROXYERROR(level, code);
    }
}

void CpProxyOpenhomeOrgTestBasic1::SyncGetInt(TInt& aValueInt)
{
    SyncGetIntOpenhomeOrgTestBasic1 sync(*this, aValueInt);
    BeginGetInt(sync.Functor());
    sync.Wait();
}

void CpProxyOpenhomeOrgTestBasic1::BeginGetInt(FunctorAsync& aFunctor)
{
    Invocation* invocation = iCpProxy.GetService().Invocation(*iActionGetInt, aFunctor);
    TUint outIndex = 0;
    const Action::VectorParameters& outParams = iActionGetInt->OutputParameters();
    invocation->AddOutput(new ArgumentInt(*outParams[outIndex++]));
    iCpProxy.GetInvocable().InvokeAction(*invocation);
}

void CpProxyOpenhomeOrgTestBasic1::EndGetInt(IAsync& aAsync, TInt& aValueInt)
{
    ASSERT(((Async&)aAsync).Type() == Async::eInvocation);
    Invocation& invocation = (Invocation&)aAsync;
    ASSERT(invocation.Action().Name() == Brn("GetInt"));

    Error::ELevel level;
    TUint code;
    const TChar* ignore;
    if (invocation.Error(level, code, ignore)) {
        THROW_PROXYERROR(level, code);
    }
    TUint index = 0;
    aValueInt = ((ArgumentInt*)invocation.OutputArguments()[index++])->Value();
}

void CpProxyOpenhomeOrgTestBasic1::SyncSetBool(TBool aValueBool)
{
    SyncSetBoolOpenhomeOrgTestBasic1 sync(*this);
    BeginSetBool(aValueBool, sync.Functor());
    sync.Wait();
}

void CpProxyOpenhomeOrgTestBasic1::BeginSetBool(TBool aValueBool, FunctorAsync& aFunctor)
{
    Invocation* invocation = iCpProxy.GetService().Invocation(*iActionSetBool, aFunctor);
    TUint inIndex = 0;
    const Action::VectorParameters& inParams = iActionSetBool->InputParameters();
    invocation->AddInput(new ArgumentBool(*inParams[inIndex++], aValueBool));
    iCpProxy.GetInvocable().InvokeAction(*invocation);
}

void CpProxyOpenhomeOrgTestBasic1::EndSetBool(IAsync& aAsync)
{
    ASSERT(((Async&)aAsync).Type() == Async::eInvocation);
    Invocation& invocation = (Invocation&)aAsync;
    ASSERT(invocation.Action().Name() == Brn("SetBool"));

    Error::ELevel level;
    TUint code;
    const TChar* ignore;
    if (invocation.Error(level, code, ignore)) {
        THROW_PROXYERROR(level, code);
    }
}

void CpProxyOpenhomeOrgTestBasic1::SyncGetBool(TBool& aValueBool)
{
    SyncGetBoolOpenhomeOrgTestBasic1 sync(*this, aValueBool);
    BeginGetBool(sync.Functor());
    sync.Wait();
}

void CpProxyOpenhomeOrgTestBasic1::BeginGetBool(FunctorAsync& aFunctor)
{
    Invocation* invocation = iCpProxy.GetService().Invocation(*iActionGetBool, aFunctor);
    TUint outIndex = 0;
    const Action::VectorParameters& outParams = iActionGetBool->OutputParameters();
    invocation->AddOutput(new ArgumentBool(*outParams[outIndex++]));
    iCpProxy.GetInvocable().InvokeAction(*invocation);
}

void CpProxyOpenhomeOrgTestBasic1::EndGetBool(IAsync& aAsync, TBool& aValueBool)
{
    ASSERT(((Async&)aAsync).Type() == Async::eInvocation);
    Invocation& invocation = (Invocation&)aAsync;
    ASSERT(invocation.Action().Name() == Brn("GetBool"));

    Error::ELevel level;
    TUint code;
    const TChar* ignore;
    if (invocation.Error(level, code, ignore)) {
        THROW_PROXYERROR(level, code);
    }
    TUint index = 0;
    aValueBool = ((ArgumentBool*)invocation.OutputArguments()[index++])->Value();
}

void CpProxyOpenhomeOrgTestBasic1::SyncSetMultiple(TUint aValueUint, TInt aValueInt, TBool aValueBool)
{
    SyncSetMultipleOpenhomeOrgTestBasic1 sync(*this);
    BeginSetMultiple(aValueUint, aValueInt, aValueBool, sync.Functor());
    sync.Wait();
}

void CpProxyOpenhomeOrgTestBasic1::BeginSetMultiple(TUint aValueUint, TInt aValueInt, TBool aValueBool, FunctorAsync& aFunctor)
{
    Invocation* invocation = iCpProxy.GetService().Invocation(*iActionSetMultiple, aFunctor);
    TUint inIndex = 0;
    const Action::VectorParameters& inParams = iActionSetMultiple->InputParameters();
    invocation->AddInput(new ArgumentUint(*inParams[inIndex++], aValueUint));
    invocation->AddInput(new ArgumentInt(*inParams[inIndex++], aValueInt));
    invocation->AddInput(new ArgumentBool(*inParams[inIndex++], aValueBool));
    iCpProxy.GetInvocable().InvokeAction(*invocation);
}

void CpProxyOpenhomeOrgTestBasic1::EndSetMultiple(IAsync& aAsync)
{
    ASSERT(((Async&)aAsync).Type() == Async::eInvocation);
    Invocation& invocation = (Invocation&)aAsync;
    ASSERT(invocation.Action().Name() == Brn("SetMultiple"));

    Error::ELevel level;
    TUint code;
    const TChar* ignore;
    if (invocation.Error(level, code, ignore)) {
        THROW_PROXYERROR(level, code);
    }
}

void CpProxyOpenhomeOrgTestBasic1::SyncGetMultiple(TUint& aValueUint, TInt& aValueInt, TBool& aValueBool)
{
    SyncGetMultipleOpenhomeOrgTestBasic1 sync(*this, aValueUint, aValueInt, aValueBool);
    BeginGetMultiple(sync.Functor());
    sync.Wait();
}

void CpProxyOpenhomeOrgTestBasic1::BeginGetMultiple(FunctorAsync& aFunctor)
{
    Invocation* invocation = iCpProxy.GetService().Invocation(*iActionGetMultiple, aFunctor);
    TUint outIndex = 0;
    const Action::VectorParameters& outParams = iActionGetMultiple->OutputParameters();
    invocation->AddOutput(new ArgumentUint(*outParams[outIndex++]));
    invocation->AddOutput(new ArgumentInt(*outParams[outIndex++]));
    invocation->AddOutput(new ArgumentBool(*outParams[outIndex++]));
    iCpProxy.GetInvocable().InvokeAction(*invocation);
}

void CpProxyOpenhomeOrgTestBasic1::EndGetMultiple(IAsync& aAsync, TUint& aValueUint, TInt& aValueInt, TBool& aValueBool)
{
    ASSERT(((Async&)aAsync).Type() == Async::eInvocation);
    Invocation& invocation = (Invocation&)aAsync;
    ASSERT(invocation.Action().Name() == Brn("GetMultiple"));

    Error::ELevel level;
    TUint code;
    const TChar* ignore;
    if (invocation.Error(level, code, ignore)) {
        THROW_PROXYERROR(level, code);
    }
    TUint index = 0;
    aValueUint = ((ArgumentUint*)invocation.OutputArguments()[index++])->Value();
    aValueInt = ((ArgumentInt*)invocation.OutputArguments()[index++])->Value();
    aValueBool = ((ArgumentBool*)invocation.OutputArguments()[index++])->Value();
}

void CpProxyOpenhomeOrgTestBasic1::SyncSetString(const Brx& aValueStr)
{
    SyncSetStringOpenhomeOrgTestBasic1 sync(*this);
    BeginSetString(aValueStr, sync.Functor());
    sync.Wait();
}

void CpProxyOpenhomeOrgTestBasic1::BeginSetString(const Brx& aValueStr, FunctorAsync& aFunctor)
{
    Invocation* invocation = iCpProxy.GetService().Invocation(*iActionSetString, aFunctor);
    TUint inIndex = 0;
    const Action::VectorParameters& inParams = iActionSetString->InputParameters();
    invocation->AddInput(new ArgumentString(*inParams[inIndex++], aValueStr));
    iCpProxy.GetInvocable().InvokeAction(*invocation);
}

void CpProxyOpenhomeOrgTestBasic1::EndSetString(IAsync& aAsync)
{
    ASSERT(((Async&)aAsync).Type() == Async::eInvocation);
    Invocation& invocation = (Invocation&)aAsync;
    ASSERT(invocation.Action().Name() == Brn("SetString"));

    Error::ELevel level;
    TUint code;
    const TChar* ignore;
    if (invocation.Error(level, code, ignore)) {
        THROW_PROXYERROR(level, code);
    }
}

void CpProxyOpenhomeOrgTestBasic1::SyncGetString(Brh& aValueStr)
{
    SyncGetStringOpenhomeOrgTestBasic1 sync(*this, aValueStr);
    BeginGetString(sync.Functor());
    sync.Wait();
}

void CpProxyOpenhomeOrgTestBasic1::BeginGetString(FunctorAsync& aFunctor)
{
    Invocation* invocation = iCpProxy.GetService().Invocation(*iActionGetString, aFunctor);
    TUint outIndex = 0;
    const Action::VectorParameters& outParams = iActionGetString->OutputParameters();
    invocation->AddOutput(new ArgumentString(*outParams[outIndex++]));
    iCpProxy.GetInvocable().InvokeAction(*invocation);
}

void CpProxyOpenhomeOrgTestBasic1::EndGetString(IAsync& aAsync, Brh& aValueStr)
{
    ASSERT(((Async&)aAsync).Type() == Async::eInvocation);
    Invocation& invocation = (Invocation&)aAsync;
    ASSERT(invocation.Action().Name() == Brn("GetString"));

    Error::ELevel level;
    TUint code;
    const TChar* ignore;
    if (invocation.Error(level, code, ignore)) {
        THROW_PROXYERROR(level, code);
    }
    TUint index = 0;
    ((ArgumentString*)invocation.OutputArguments()[index++])->TransferTo(aValueStr);
}

void CpProxyOpenhomeOrgTestBasic1::SyncSetBinary(const Brx& aValueBin)
{
    SyncSetBinaryOpenhomeOrgTestBasic1 sync(*this);
    BeginSetBinary(aValueBin, sync.Functor());
    sync.Wait();
}

void CpProxyOpenhomeOrgTestBasic1::BeginSetBinary(const Brx& aValueBin, FunctorAsync& aFunctor)
{
    Invocation* invocation = iCpProxy.GetService().Invocation(*iActionSetBinary, aFunctor);
    TUint inIndex = 0;
    const Action::VectorParameters& inParams = iActionSetBinary->InputParameters();
    invocation->AddInput(new ArgumentBinary(*inParams[inIndex++], aValueBin));
    iCpProxy.GetInvocable().InvokeAction(*invocation);
}

void CpProxyOpenhomeOrgTestBasic1::EndSetBinary(IAsync& aAsync)
{
    ASSERT(((Async&)aAsync).Type() == Async::eInvocation);
    Invocation& invocation = (Invocation&)aAsync;
    ASSERT(invocation.Action().Name() == Brn("SetBinary"));

    Error::ELevel level;
    TUint code;
    const TChar* ignore;
    if (invocation.Error(level, code, ignore)) {
        THROW_PROXYERROR(level, code);
    }
}

void CpProxyOpenhomeOrgTestBasic1::SyncGetBinary(Brh& aValueBin)
{
    SyncGetBinaryOpenhomeOrgTestBasic1 sync(*this, aValueBin);
    BeginGetBinary(sync.Functor());
    sync.Wait();
}

void CpProxyOpenhomeOrgTestBasic1::BeginGetBinary(FunctorAsync& aFunctor)
{
    Invocation* invocation = iCpProxy.GetService().Invocation(*iActionGetBinary, aFunctor);
    TUint outIndex = 0;
    const Action::VectorParameters& outParams = iActionGetBinary->OutputParameters();
    invocation->AddOutput(new ArgumentBinary(*outParams[outIndex++]));
    iCpProxy.GetInvocable().InvokeAction(*invocation);
}

void CpProxyOpenhomeOrgTestBasic1::EndGetBinary(IAsync& aAsync, Brh& aValueBin)
{
    ASSERT(((Async&)aAsync).Type() == Async::eInvocation);
    Invocation& invocation = (Invocation&)aAsync;
    ASSERT(invocation.Action().Name() == Brn("GetBinary"));

    Error::ELevel level;
    TUint code;
    const TChar* ignore;
    if (invocation.Error(level, code, ignore)) {
        THROW_PROXYERROR(level, code);
    }
    TUint index = 0;
    ((ArgumentBinary*)invocation.OutputArguments()[index++])->TransferTo(aValueBin);
}

void CpProxyOpenhomeOrgTestBasic1::SyncToggleBool()
{
    SyncToggleBoolOpenhomeOrgTestBasic1 sync(*this);
    BeginToggleBool(sync.Functor());
    sync.Wait();
}

void CpProxyOpenhomeOrgTestBasic1::BeginToggleBool(FunctorAsync& aFunctor)
{
    Invocation* invocation = iCpProxy.GetService().Invocation(*iActionToggleBool, aFunctor);
    iCpProxy.GetInvocable().InvokeAction(*invocation);
}

void CpProxyOpenhomeOrgTestBasic1::EndToggleBool(IAsync& aAsync)
{
    ASSERT(((Async&)aAsync).Type() == Async::eInvocation);
    Invocation& invocation = (Invocation&)aAsync;
    ASSERT(invocation.Action().Name() == Brn("ToggleBool"));

    Error::ELevel level;
    TUint code;
    const TChar* ignore;
    if (invocation.Error(level, code, ignore)) {
        THROW_PROXYERROR(level, code);
    }
}

void CpProxyOpenhomeOrgTestBasic1::SyncReportError()
{
    SyncReportErrorOpenhomeOrgTestBasic1 sync(*this);
    BeginReportError(sync.Functor());
    sync.Wait();
}

void CpProxyOpenhomeOrgTestBasic1::BeginReportError(FunctorAsync& aFunctor)
{
    Invocation* invocation = iCpProxy.GetService().Invocation(*iActionReportError, aFunctor);
    iCpProxy.GetInvocable().InvokeAction(*invocation);
}

void CpProxyOpenhomeOrgTestBasic1::EndReportError(IAsync& aAsync)
{
    ASSERT(((Async&)aAsync).Type() == Async::eInvocation);
    Invocation& invocation = (Invocation&)aAsync;
    ASSERT(invocation.Action().Name() == Brn("ReportError"));

    Error::ELevel level;
    TUint code;
    const TChar* ignore;
    if (invocation.Error(level, code, ignore)) {
        THROW_PROXYERROR(level, code);
    }
}

void CpProxyOpenhomeOrgTestBasic1::SyncWriteFile(const Brx& aData, const Brx& aFileFullName)
{
    SyncWriteFileOpenhomeOrgTestBasic1 sync(*this);
    BeginWriteFile(aData, aFileFullName, sync.Functor());
    sync.Wait();
}

void CpProxyOpenhomeOrgTestBasic1::BeginWriteFile(const Brx& aData, const Brx& aFileFullName, FunctorAsync& aFunctor)
{
    Invocation* invocation = iCpProxy.GetService().Invocation(*iActionWriteFile, aFunctor);
    TUint inIndex = 0;
    const Action::VectorParameters& inParams = iActionWriteFile->InputParameters();
    invocation->AddInput(new ArgumentString(*inParams[inIndex++], aData));
    invocation->AddInput(new ArgumentString(*inParams[inIndex++], aFileFullName));
    iCpProxy.GetInvocable().InvokeAction(*invocation);
}

void CpProxyOpenhomeOrgTestBasic1::EndWriteFile(IAsync& aAsync)
{
    ASSERT(((Async&)aAsync).Type() == Async::eInvocation);
    Invocation& invocation = (Invocation&)aAsync;
    ASSERT(invocation.Action().Name() == Brn("WriteFile"));

    Error::ELevel level;
    TUint code;
    const TChar* ignore;
    if (invocation.Error(level, code, ignore)) {
        THROW_PROXYERROR(level, code);
    }
}

void CpProxyOpenhomeOrgTestBasic1::SyncShutdown()
{
    SyncShutdownOpenhomeOrgTestBasic1 sync(*this);
    BeginShutdown(sync.Functor());
    sync.Wait();
}

void CpProxyOpenhomeOrgTestBasic1::BeginShutdown(FunctorAsync& aFunctor)
{
    Invocation* invocation = iCpProxy.GetService().Invocation(*iActionShutdown, aFunctor);
    iCpProxy.GetInvocable().InvokeAction(*invocation);
}

void CpProxyOpenhomeOrgTestBasic1::EndShutdown(IAsync& aAsync)
{
    ASSERT(((Async&)aAsync).Type() == Async::eInvocation);
    Invocation& invocation = (Invocation&)aAsync;
    ASSERT(invocation.Action().Name() == Brn("Shutdown"));

    Error::ELevel level;
    TUint code;
    const TChar* ignore;
    if (invocation.Error(level, code, ignore)) {
        THROW_PROXYERROR(level, code);
    }
}

void CpProxyOpenhomeOrgTestBasic1::SetPropertyVarUintChanged(Functor& aFunctor)
{
    iCpProxy.GetLock().Wait();
    iVarUintChanged = aFunctor;
    iCpProxy.GetLock().Signal();
}

void CpProxyOpenhomeOrgTestBasic1::SetPropertyVarIntChanged(Functor& aFunctor)
{
    iCpProxy.GetLock().Wait();
    iVarIntChanged = aFunctor;
    iCpProxy.GetLock().Signal();
}

void CpProxyOpenhomeOrgTestBasic1::SetPropertyVarBoolChanged(Functor& aFunctor)
{
    iCpProxy.GetLock().Wait();
    iVarBoolChanged = aFunctor;
    iCpProxy.GetLock().Signal();
}

void CpProxyOpenhomeOrgTestBasic1::SetPropertyVarStrChanged(Functor& aFunctor)
{
    iCpProxy.GetLock().Wait();
    iVarStrChanged = aFunctor;
    iCpProxy.GetLock().Signal();
}

void CpProxyOpenhomeOrgTestBasic1::SetPropertyVarBinChanged(Functor& aFunctor)
{
    iCpProxy.GetLock().Wait();
    iVarBinChanged = aFunctor;
    iCpProxy.GetLock().Signal();
}

void CpProxyOpenhomeOrgTestBasic1::PropertyVarUint(TUint& aVarUint) const
{
    AutoMutex a(iCpProxy.PropertyReadLock());
    if (iCpProxy.GetSubscriptionStatus() != CpProxy::eSubscribed) {
        THROW(ProxyNotSubscribed);
    }
    aVarUint = iVarUint->Value();
}

void CpProxyOpenhomeOrgTestBasic1::PropertyVarInt(TInt& aVarInt) const
{
    AutoMutex a(iCpProxy.PropertyReadLock());
    if (iCpProxy.GetSubscriptionStatus() != CpProxy::eSubscribed) {
        THROW(ProxyNotSubscribed);
    }
    aVarInt = iVarInt->Value();
}

void CpProxyOpenhomeOrgTestBasic1::PropertyVarBool(TBool& aVarBool) const
{
    AutoMutex a(iCpProxy.PropertyReadLock());
    if (iCpProxy.GetSubscriptionStatus() != CpProxy::eSubscribed) {
        THROW(ProxyNotSubscribed);
    }
    aVarBool = iVarBool->Value();
}

void CpProxyOpenhomeOrgTestBasic1::PropertyVarStr(Brhz& aVarStr) const
{
    AutoMutex a(iCpProxy.PropertyReadLock());
    if (iCpProxy.GetSubscriptionStatus() != CpProxy::eSubscribed) {
        THROW(ProxyNotSubscribed);
    }
    aVarStr.Set(iVarStr->Value());
}

void CpProxyOpenhomeOrgTestBasic1::PropertyVarBin(Brh& aVarBin) const
{
    AutoMutex a(iCpProxy.PropertyReadLock());
    if (iCpProxy.GetSubscriptionStatus() != CpProxy::eSubscribed) {
        THROW(ProxyNotSubscribed);
    }
    aVarBin.Set(iVarBin->Value());
}

void CpProxyOpenhomeOrgTestBasic1::VarUintPropertyChanged()
{
    ReportEvent(iVarUintChanged);
}

void CpProxyOpenhomeOrgTestBasic1::VarIntPropertyChanged()
{
    ReportEvent(iVarIntChanged);
}

void CpProxyOpenhomeOrgTestBasic1::VarBoolPropertyChanged()
{
    ReportEvent(iVarBoolChanged);
}

void CpProxyOpenhomeOrgTestBasic1::VarStrPropertyChanged()
{
    ReportEvent(iVarStrChanged);
}

void CpProxyOpenhomeOrgTestBasic1::VarBinPropertyChanged()
{
    ReportEvent(iVarBinChanged);
}


void CpProxyOpenhomeOrgTestBasic1::Subscribe()
{
  iCpProxy.Subscribe();
}

void CpProxyOpenhomeOrgTestBasic1::Unsubscribe()
{
 iCpProxy.Unsubscribe();
}

void CpProxyOpenhomeOrgTestBasic1::SetPropertyChanged(Functor& aFunctor)
{
  iCpProxy.SetPropertyChanged(aFunctor);
}

void CpProxyOpenhomeOrgTestBasic1::SetPropertyInitialEvent(Functor& aFunctor)
{
  iCpProxy.SetPropertyInitialEvent(aFunctor);
}
void CpProxyOpenhomeOrgTestBasic1::AddProperty(Property* aProperty)
{
  iCpProxy.AddProperty(aProperty);
}

void CpProxyOpenhomeOrgTestBasic1::DestroyService()
{
  iCpProxy.DestroyService();
}

void CpProxyOpenhomeOrgTestBasic1::ReportEvent(Functor aFunctor)
{
  iCpProxy.ReportEvent(aFunctor);
}

TUint CpProxyOpenhomeOrgTestBasic1::Version() const
{
  return iCpProxy.Version();
}


