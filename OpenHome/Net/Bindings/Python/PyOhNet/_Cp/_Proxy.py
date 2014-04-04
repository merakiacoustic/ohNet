"""Proxy - python ohNet bindings for base of control point proxies"""

import PyOhNet
import abc
import ctypes
import threading


class Proxy():
    "Control Point proxy (service) abstract base class"
    __metaclass__ = abc.ABCMeta
    
    @abc.abstractmethod
    def __init__( self, aDomain, aName, aVersion, aDevice ):
        self.lib             = PyOhNet.lib
        self.handle          = self.lib.CpProxyCreate( aDomain, aName, aVersion, aDevice.handle )
        self.service         = self.lib.CpProxyService( self.handle )
        self._propertyAnyCb  = None
        self._propertyInitCb = None
        self.actions         = []
        self.properties      = []
        self.semaReady       = threading.Semaphore( 0 )   # Sema rather than Event as can be multiple
        PyOhNet.cpProxies.append( self )                  # actions ongoing at any time  
                                                          
    def Shutdown( self ):
        PyOhNet.cpProxies.remove( self )
        if self.handle:
            self.Unsubscribe()
            self.lib.CpProxyDestroy( self.handle )

    #                                                      
    # ==== Internal methods ====
    #
    
    def _InvokeAction( self, aInvocation ):
        self.lib.CpServiceInvokeAction( self.service, aInvocation.handle )
        
    def _AddProperty( self, aProperty ):
        self.lib.CpProxyAddProperty( self.handle, aProperty.handle )
        self.properties.append( aProperty )
    
    def _PropertyValue( self, aProperty ):
        self.lib.CpProxyPropertyReadLock( self.handle )
        val = aProperty.Value()
        self.lib.CpProxyPropertyReadUnlock( self.handle )
        return val
        
    def _AnyEventCb( self, aDummy ):
        if self._propertyAnyCb is not None:
            self._propertyAnyCb()
                   
    def _InitEventCb( self, aDummy ):
        if self._propertyInitCb is not None:
            self._propertyInitCb()
        
    def _Str( self, aName=None ):
        msg = '  %s' % aName
        msg += '\n    Actions:'
        for action in self.actions:
            msg += '\n' + action.__str__()
        msg += '\n    Properties:'
        for property in self.properties:
            msg += '\n' + property.__str__()
        return msg

    #            
    # ==== Public interface ====                                                    
    #
    
    def Subscribe( self ):
        self.lib.CpProxySubscribe( self.handle )
        
    def Unsubscribe( self ):
        self.lib.CpProxyUnsubscribe( self.handle )
        
    def SetPropertyChanged( self, aCb ):
        self._propertyAnyCb = aCb
        CB = PyOhNet.makeCb( None, ctypes.c_void_p )
        self._AnyEvent = CB( self._AnyEventCb )
        self.lib.CpProxySetPropertyChanged( self.handle, self._AnyEvent, None )
        
    def SetPropertyInitialEvent( self, aCb ):
        self._propertyInitCb = aCb
        CB = PyOhNet.makeCb( None, ctypes.c_void_p )
        self._InitEvent = CB( self._InitEventCb )
        self.lib.CpProxySetPropertyInitialEvent( self.handle, self._InitEvent, None )
