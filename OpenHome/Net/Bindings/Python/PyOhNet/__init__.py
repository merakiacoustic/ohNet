"""PyOhNet: entry point for python ohNet bindings
""" 
#
# ==== Initialise module-level data ====
#

lib        = None
makeCb     = None
initParams = None

#
# ==== Exception handler for ohNet-python ====
#

import exceptions
class OhNetError( exceptions.Exception ):
    
    def __init__( self, *aArgs ):
        self.args = aArgs

#
# ==== Load ohNet library and configure callback calling convention ====
#

import os
import ctypes
import platform
__platform = platform.system() 
__libPath = os.path.dirname( __file__ )

if __platform in ['Windows', 'cli']:
    __library = os.path.join( __libPath, 'ohNet.dll' )
elif __platform == 'Linux':
    __library = os.path.join( __libPath, 'libohNet.so' )
elif __platform == 'Darwin':
    __library = os.path.join( __libPath, 'libohNet.dylib' )
else:
    raise OhNetError( 'Unsupported platform - %s' % __platform )

try:    
    if __platform in ['Windows', 'cli']:
        lib = ctypes.windll.LoadLibrary( __library )
    else:
        lib = ctypes.cdll.LoadLibrary( __library )
except:
    raise OhNetError( 'Failed to load %s' % __library )

if __platform in ['Windows', 'cli']:
    makeCb = ctypes.WINFUNCTYPE
else:
    makeCb = ctypes.CFUNCTYPE
    
#
# ==== Import rest of ohNet-python functionality ====
#

from _Network import *          # access to Adapter and AdapterList classes
from _DebugLevels import *      # debug level constants
import _Cp as Cp                # control point stack
   
#
# ==== Track ohNet objects (updated on object create/delete) to permit clean shutdown ====
#

adapters     = []
adapterLists = []
devices      = []    
devLists     = []
actions      = []
cpProxies    = []  
               
#
# ==== Public module-level methods ====
#

def Initialise( aInitParams=None ):
    "Initialise ohNet library - must be first call to module"
    if not aInitParams:
        initParams = lib.OhNetInitParamsCreate()
        err = lib.OhNetLibraryInitialise( initParams )
    else:
        # create initParams temp object from passed in initParams
        # init library using handle for temp initParams just created
        # cleanup temp initParams
        # see C# bindings - line 814 of file OhNet.cs onwards
        initParams = None
        raise OhNetError( 'initParams functionality not implemented' )
    if err:
        raise OhNetError( 'Failed to initialise Library')

def SetDebugLevel( aDebugLevel=kDebugLevel['None'] ):
    "Configure debug logging for underlying ohNet library"    
    lib.OhNetDebugSetLevel( aDebugLevel )
    
def Start( aMode='cp', aInterface=None ):
    "Start ohNet (optionally specifying interface by adapter, IP or subnet)"
    adapterList = AdapterList()
    adapters    = adapterList.adapters
    numAdapters = adapterList.size
    adapter     = None
         
    if numAdapters == 0:
        # no adapters present - throw
        raise OhNetError( 'NO network adapter detected' )
    elif numAdapters == 1:
        # only one adapter - use it (ignoring aHost param if requested)
        adapter = adapters[0]
    else:
        if aInterface==None:
            # no host specified - use first adapter 
            adapter = adapters[0]
        else:
            # host specified - find matching adapter and use it
            for item in adapters:
                if aInterface == item            or \
                   aInterface == item.addressStr or \
                   aInterface == item.subnetStr:
                    adapter = item
                    break
            if not adapter:
                raise OhNetError( 'NO network adapter matching %s found' % aInterface )
                
    if aMode.lower() == 'cp':                
        Cp._Start( adapter )
    else:
        raise OhNetError( 'Stack mode <%s> not supported' % aMode )
    
def Shutdown():    
    "Cleanly shut down ohNet"
    while len( adapters ):
        adapters[0].Shutdown()
    while len( adapterLists ):
        adapterLists[0].Shutdown()
    while len( devices ):
        devices[0].Shutdown()
    while len( devLists ):
        devLists[0].Shutdown()
    while len( actions ):
        actions[0].Shutdown()
    while len( cpProxies ):
        cpProxies[0].Shutdown()
    if lib:
       if initParams: 
          lib.OhNetInitParamsDestroy( initParams )
       lib.OhNetLibraryClose()
    
