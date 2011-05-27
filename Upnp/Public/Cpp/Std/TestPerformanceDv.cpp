#include <TestFramework.h>
#include <OptionParser.h>
#include <OhNetTypes.h>
#include <Std/DvDevice.h>
#include <OhNet.h>
#include <Std/TestBasicDv.h>

#include <stdlib.h>
#include <vector>
#include <sys/stat.h>

using namespace OpenHome;
using namespace OpenHome::Net;
using namespace OpenHome::TestFramework;

void OpenHome::TestFramework::Runner::Main(TInt aArgc, TChar* aArgv[], InitialisationParams* aInitParams)
{
    OptionParser parser;
    Brn emptyString("");
    OptionBool loopback("-l", "--loopback", "Use the loopback adapter only");
    parser.AddOption(&loopback);
    if (!parser.Parse(aArgc, aArgv) || parser.HelpDisplayed()) {
        return;
    }
    if (loopback.Value()) {
        aInitParams->SetUseLoopbackNetworkInterface();
    }
    UpnpLibrary::Initialise(aInitParams);
    UpnpLibrary::StartDv();

    Print("TestPerformanceDv - starting ('q' to quit)\n");
    DeviceBasic* device = new DeviceBasic(DeviceBasic::eProtocolUpnp);
    while (getchar() != 'q');
    delete device;
    Print("TestPerformanceDv - exiting\n");

    UpnpLibrary::Close();
}
