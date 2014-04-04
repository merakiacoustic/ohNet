"""PyOhNet: control point device support
"""
import PyOhNet
import ctypes
import os
import re
import sys
import tempfile
import urllib2
import urlparse
import xml.etree.ElementTree as ET
import _GenProxy as GenProxy


class Device():
    "UPnP Device (from perspective of a control point)"
    
    def __init__( self, aHandle ):
        self.lib = PyOhNet.lib
        self.handle = aHandle
        self.lib.CpDeviceCAddRef( self.handle )
        self.proxies = []
        PyOhNet.devices.append( self )  
        
    def __str__( self ):
        msg = 'Device %s (%s)' % (self.friendlyName, self.udn)
        for proxy in self.proxies:
            msg += '\n'
            msg += eval( 'self.%s.__str__()' % proxy  )
        return msg
        
    #
    # ==== Internal methods ====
    #
        
    def _GetAttribute( self, aAttr ):
        request  = ctypes.c_char_p( aAttr )
        response = ctypes.c_char_p()
        self.lib.CpDeviceCGetAttribute( self.handle, request, ctypes.byref( response ))
        return response.value 
        
    def _GetServices( self ):
        "Returns list of services reported by device"
        result   = []
        devXml   = self._GetAttribute( 'Upnp.DeviceXml' )
        location = self._GetAttribute( 'Upnp.Location' )
        baseUrl  = re.match('^(.+)(\/\/)([\w\.\:]+)', location ).group()
        xml      = re.sub( ' xmlns="[^"]+"', '', devXml )    # remove namespace
        root     = ET.fromstring( xml )
        
        devices = root.findall( 'device' )
        for device in devices:
            serviceList = device.find( 'serviceList' )
            services = serviceList.findall( 'service' )
            for service in services:
                type = service.find( 'serviceType' ).text
                url  = urlparse.urljoin( baseUrl, service.find( 'SCPDURL' ).text )
                m = re.match('urn:([\w\-\.]+):service:([\w\-\.]+):(\d+)', type )
                domain, name, version = m.groups()
                domainName = ''
                fields = domain.replace( '.', '-' ).split( '-' )
                for field in fields:
                    domainName += field[0].upper()
                    domainName += field[1:]
                result.append( {'type':type, 'url':url, 'domain':domainName, 'name':name, 'version':int( version )} )
        return result
                
    def _AddProxy( self, aService ):
        "Generate and add proxy for specified service"
        # The proxy code is auto-generated (from the service XML) and then
        # imported and added as a class attribute to the device. Named the
        # same as the service, with lower-case first letter. All ohNet proxy
        # actions and properties are accessible via these attributes
        #
        # TestBasic service   -> device.testBasic
        # AVTransport service -> device.aVTRansport
        tempDir   = tempfile.gettempdir()
        attrName  = aService['name'][0].lower() + aService['name'][1:]
        proxyName = 'CpProxy%s%s%s' % \
            (aService['domain'], aService['name'][0].upper() + aService['name'][1:], aService['version'])
            
        if tempDir not in sys.path:
            sys.path.append( tempDir )
        serviceXml = urllib2.urlopen( aService['url'] ).read()
        proxy = GenProxy.GenProxy( aService['type'], serviceXml )
        proxyPath = os.path.join( tempDir, proxyName+'.py' ) 
        proxy.Write( proxyPath )
        exec( 'import %s as proxyModule' % proxyName )
        setattr( self, attrName, eval( 'proxyModule.%s( self )' % proxyName ))
        self.proxies.append( attrName )
    
    def _GetUdn( self ):
        udn = ctypes.c_char_p()
        len = ctypes.c_int()
        self.lib.CpDeviceCGetUdn( self.handle, ctypes.byref( udn ), ctypes.byref( len ))
        return udn.value
    
    def _GetFriendlyName( self ):
        return self._GetAttribute( 'Upnp.FriendlyName' )

    #
    # ==== Public interface ====
    #
    
    def Start( self, aProxies=['all'] ):
        "Start device - add proxies for all or specified services on device"
        services = self._GetServices()
        for service in services:
            if service['name'] in aProxies or 'all' in aProxies:
                self._AddProxy( service )
    
    def Shutdown( self ):
        PyOhNet.devices.remove( self )
        if self.handle:
            self.lib.CpDeviceCRemoveRef( self.handle )

    friendlyName = property( _GetFriendlyName, None, None, '' )        
    udn          = property( _GetUdn, None, None, '' )
