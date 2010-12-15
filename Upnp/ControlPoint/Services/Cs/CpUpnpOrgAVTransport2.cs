using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Text;
using Zapp.Core;
using Zapp.ControlPoint;

namespace Zapp.ControlPoint.Proxies
{
    public interface ICpProxyUpnpOrgAVTransport2 : ICpProxy, IDisposable
    {
        void SyncSetAVTransportURI(uint aInstanceID, String aCurrentURI, String aCurrentURIMetaData);
        void BeginSetAVTransportURI(uint aInstanceID, String aCurrentURI, String aCurrentURIMetaData, CpProxy.CallbackAsyncComplete aCallback);
        void EndSetAVTransportURI(IntPtr aAsyncHandle);
        void SyncSetNextAVTransportURI(uint aInstanceID, String aNextURI, String aNextURIMetaData);
        void BeginSetNextAVTransportURI(uint aInstanceID, String aNextURI, String aNextURIMetaData, CpProxy.CallbackAsyncComplete aCallback);
        void EndSetNextAVTransportURI(IntPtr aAsyncHandle);
        void SyncGetMediaInfo(uint aInstanceID, out uint aNrTracks, out String aMediaDuration, out String aCurrentURI, out String aCurrentURIMetaData, out String aNextURI, out String aNextURIMetaData, out String aPlayMedium, out String aRecordMedium, out String aWriteStatus);
        void BeginGetMediaInfo(uint aInstanceID, CpProxy.CallbackAsyncComplete aCallback);
        void EndGetMediaInfo(IntPtr aAsyncHandle, out uint aNrTracks, out String aMediaDuration, out String aCurrentURI, out String aCurrentURIMetaData, out String aNextURI, out String aNextURIMetaData, out String aPlayMedium, out String aRecordMedium, out String aWriteStatus);
        void SyncGetMediaInfo_Ext(uint aInstanceID, out String aCurrentType, out uint aNrTracks, out String aMediaDuration, out String aCurrentURI, out String aCurrentURIMetaData, out String aNextURI, out String aNextURIMetaData, out String aPlayMedium, out String aRecordMedium, out String aWriteStatus);
        void BeginGetMediaInfo_Ext(uint aInstanceID, CpProxy.CallbackAsyncComplete aCallback);
        void EndGetMediaInfo_Ext(IntPtr aAsyncHandle, out String aCurrentType, out uint aNrTracks, out String aMediaDuration, out String aCurrentURI, out String aCurrentURIMetaData, out String aNextURI, out String aNextURIMetaData, out String aPlayMedium, out String aRecordMedium, out String aWriteStatus);
        void SyncGetTransportInfo(uint aInstanceID, out String aCurrentTransportState, out String aCurrentTransportStatus, out String aCurrentSpeed);
        void BeginGetTransportInfo(uint aInstanceID, CpProxy.CallbackAsyncComplete aCallback);
        void EndGetTransportInfo(IntPtr aAsyncHandle, out String aCurrentTransportState, out String aCurrentTransportStatus, out String aCurrentSpeed);
        void SyncGetPositionInfo(uint aInstanceID, out uint aTrack, out String aTrackDuration, out String aTrackMetaData, out String aTrackURI, out String aRelTime, out String aAbsTime, out int aRelCount, out int aAbsCount);
        void BeginGetPositionInfo(uint aInstanceID, CpProxy.CallbackAsyncComplete aCallback);
        void EndGetPositionInfo(IntPtr aAsyncHandle, out uint aTrack, out String aTrackDuration, out String aTrackMetaData, out String aTrackURI, out String aRelTime, out String aAbsTime, out int aRelCount, out int aAbsCount);
        void SyncGetDeviceCapabilities(uint aInstanceID, out String aPlayMedia, out String aRecMedia, out String aRecQualityModes);
        void BeginGetDeviceCapabilities(uint aInstanceID, CpProxy.CallbackAsyncComplete aCallback);
        void EndGetDeviceCapabilities(IntPtr aAsyncHandle, out String aPlayMedia, out String aRecMedia, out String aRecQualityModes);
        void SyncGetTransportSettings(uint aInstanceID, out String aPlayMode, out String aRecQualityMode);
        void BeginGetTransportSettings(uint aInstanceID, CpProxy.CallbackAsyncComplete aCallback);
        void EndGetTransportSettings(IntPtr aAsyncHandle, out String aPlayMode, out String aRecQualityMode);
        void SyncStop(uint aInstanceID);
        void BeginStop(uint aInstanceID, CpProxy.CallbackAsyncComplete aCallback);
        void EndStop(IntPtr aAsyncHandle);
        void SyncPlay(uint aInstanceID, String aSpeed);
        void BeginPlay(uint aInstanceID, String aSpeed, CpProxy.CallbackAsyncComplete aCallback);
        void EndPlay(IntPtr aAsyncHandle);
        void SyncPause(uint aInstanceID);
        void BeginPause(uint aInstanceID, CpProxy.CallbackAsyncComplete aCallback);
        void EndPause(IntPtr aAsyncHandle);
        void SyncRecord(uint aInstanceID);
        void BeginRecord(uint aInstanceID, CpProxy.CallbackAsyncComplete aCallback);
        void EndRecord(IntPtr aAsyncHandle);
        void SyncSeek(uint aInstanceID, String aUnit, String aTarget);
        void BeginSeek(uint aInstanceID, String aUnit, String aTarget, CpProxy.CallbackAsyncComplete aCallback);
        void EndSeek(IntPtr aAsyncHandle);
        void SyncNext(uint aInstanceID);
        void BeginNext(uint aInstanceID, CpProxy.CallbackAsyncComplete aCallback);
        void EndNext(IntPtr aAsyncHandle);
        void SyncPrevious(uint aInstanceID);
        void BeginPrevious(uint aInstanceID, CpProxy.CallbackAsyncComplete aCallback);
        void EndPrevious(IntPtr aAsyncHandle);
        void SyncSetPlayMode(uint aInstanceID, String aNewPlayMode);
        void BeginSetPlayMode(uint aInstanceID, String aNewPlayMode, CpProxy.CallbackAsyncComplete aCallback);
        void EndSetPlayMode(IntPtr aAsyncHandle);
        void SyncSetRecordQualityMode(uint aInstanceID, String aNewRecordQualityMode);
        void BeginSetRecordQualityMode(uint aInstanceID, String aNewRecordQualityMode, CpProxy.CallbackAsyncComplete aCallback);
        void EndSetRecordQualityMode(IntPtr aAsyncHandle);
        void SyncGetCurrentTransportActions(uint aInstanceID, out String aActions);
        void BeginGetCurrentTransportActions(uint aInstanceID, CpProxy.CallbackAsyncComplete aCallback);
        void EndGetCurrentTransportActions(IntPtr aAsyncHandle, out String aActions);
        void SyncGetDRMState(uint aInstanceID, out String aCurrentDRMState);
        void BeginGetDRMState(uint aInstanceID, CpProxy.CallbackAsyncComplete aCallback);
        void EndGetDRMState(IntPtr aAsyncHandle, out String aCurrentDRMState);
        void SyncGetStateVariables(uint aInstanceID, String aStateVariableList, out String aStateVariableValuePairs);
        void BeginGetStateVariables(uint aInstanceID, String aStateVariableList, CpProxy.CallbackAsyncComplete aCallback);
        void EndGetStateVariables(IntPtr aAsyncHandle, out String aStateVariableValuePairs);
        void SyncSetStateVariables(uint aInstanceID, String aAVTransportUDN, String aServiceType, String aServiceId, String aStateVariableValuePairs, out String aStateVariableList);
        void BeginSetStateVariables(uint aInstanceID, String aAVTransportUDN, String aServiceType, String aServiceId, String aStateVariableValuePairs, CpProxy.CallbackAsyncComplete aCallback);
        void EndSetStateVariables(IntPtr aAsyncHandle, out String aStateVariableList);
        void SetPropertyLastChangeChanged(CpProxy.CallbackPropertyChanged aLastChangeChanged);
        String PropertyLastChange();
        void SetPropertyDRMStateChanged(CpProxy.CallbackPropertyChanged aDRMStateChanged);
        String PropertyDRMState();
    }

    internal class SyncSetAVTransportURIUpnpOrgAVTransport2 : SyncProxyAction
    {
        private CpProxyUpnpOrgAVTransport2 iService;

        public SyncSetAVTransportURIUpnpOrgAVTransport2(CpProxyUpnpOrgAVTransport2 aProxy)
        {
            iService = aProxy;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndSetAVTransportURI(aAsyncHandle);
        }
    };

    internal class SyncSetNextAVTransportURIUpnpOrgAVTransport2 : SyncProxyAction
    {
        private CpProxyUpnpOrgAVTransport2 iService;

        public SyncSetNextAVTransportURIUpnpOrgAVTransport2(CpProxyUpnpOrgAVTransport2 aProxy)
        {
            iService = aProxy;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndSetNextAVTransportURI(aAsyncHandle);
        }
    };

    internal class SyncGetMediaInfoUpnpOrgAVTransport2 : SyncProxyAction
    {
        private CpProxyUpnpOrgAVTransport2 iService;
        private uint iNrTracks;
        private String iMediaDuration;
        private String iCurrentURI;
        private String iCurrentURIMetaData;
        private String iNextURI;
        private String iNextURIMetaData;
        private String iPlayMedium;
        private String iRecordMedium;
        private String iWriteStatus;

        public SyncGetMediaInfoUpnpOrgAVTransport2(CpProxyUpnpOrgAVTransport2 aProxy)
        {
            iService = aProxy;
        }
        public uint NrTracks()
        {
            return iNrTracks;
        }
        public String MediaDuration()
        {
            return iMediaDuration;
        }
        public String CurrentURI()
        {
            return iCurrentURI;
        }
        public String CurrentURIMetaData()
        {
            return iCurrentURIMetaData;
        }
        public String NextURI()
        {
            return iNextURI;
        }
        public String NextURIMetaData()
        {
            return iNextURIMetaData;
        }
        public String PlayMedium()
        {
            return iPlayMedium;
        }
        public String RecordMedium()
        {
            return iRecordMedium;
        }
        public String WriteStatus()
        {
            return iWriteStatus;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndGetMediaInfo(aAsyncHandle, out iNrTracks, out iMediaDuration, out iCurrentURI, out iCurrentURIMetaData, out iNextURI, out iNextURIMetaData, out iPlayMedium, out iRecordMedium, out iWriteStatus);
        }
    };

    internal class SyncGetMediaInfo_ExtUpnpOrgAVTransport2 : SyncProxyAction
    {
        private CpProxyUpnpOrgAVTransport2 iService;
        private String iCurrentType;
        private uint iNrTracks;
        private String iMediaDuration;
        private String iCurrentURI;
        private String iCurrentURIMetaData;
        private String iNextURI;
        private String iNextURIMetaData;
        private String iPlayMedium;
        private String iRecordMedium;
        private String iWriteStatus;

        public SyncGetMediaInfo_ExtUpnpOrgAVTransport2(CpProxyUpnpOrgAVTransport2 aProxy)
        {
            iService = aProxy;
        }
        public String CurrentType()
        {
            return iCurrentType;
        }
        public uint NrTracks()
        {
            return iNrTracks;
        }
        public String MediaDuration()
        {
            return iMediaDuration;
        }
        public String CurrentURI()
        {
            return iCurrentURI;
        }
        public String CurrentURIMetaData()
        {
            return iCurrentURIMetaData;
        }
        public String NextURI()
        {
            return iNextURI;
        }
        public String NextURIMetaData()
        {
            return iNextURIMetaData;
        }
        public String PlayMedium()
        {
            return iPlayMedium;
        }
        public String RecordMedium()
        {
            return iRecordMedium;
        }
        public String WriteStatus()
        {
            return iWriteStatus;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndGetMediaInfo_Ext(aAsyncHandle, out iCurrentType, out iNrTracks, out iMediaDuration, out iCurrentURI, out iCurrentURIMetaData, out iNextURI, out iNextURIMetaData, out iPlayMedium, out iRecordMedium, out iWriteStatus);
        }
    };

    internal class SyncGetTransportInfoUpnpOrgAVTransport2 : SyncProxyAction
    {
        private CpProxyUpnpOrgAVTransport2 iService;
        private String iCurrentTransportState;
        private String iCurrentTransportStatus;
        private String iCurrentSpeed;

        public SyncGetTransportInfoUpnpOrgAVTransport2(CpProxyUpnpOrgAVTransport2 aProxy)
        {
            iService = aProxy;
        }
        public String CurrentTransportState()
        {
            return iCurrentTransportState;
        }
        public String CurrentTransportStatus()
        {
            return iCurrentTransportStatus;
        }
        public String CurrentSpeed()
        {
            return iCurrentSpeed;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndGetTransportInfo(aAsyncHandle, out iCurrentTransportState, out iCurrentTransportStatus, out iCurrentSpeed);
        }
    };

    internal class SyncGetPositionInfoUpnpOrgAVTransport2 : SyncProxyAction
    {
        private CpProxyUpnpOrgAVTransport2 iService;
        private uint iTrack;
        private String iTrackDuration;
        private String iTrackMetaData;
        private String iTrackURI;
        private String iRelTime;
        private String iAbsTime;
        private int iRelCount;
        private int iAbsCount;

        public SyncGetPositionInfoUpnpOrgAVTransport2(CpProxyUpnpOrgAVTransport2 aProxy)
        {
            iService = aProxy;
        }
        public uint Track()
        {
            return iTrack;
        }
        public String TrackDuration()
        {
            return iTrackDuration;
        }
        public String TrackMetaData()
        {
            return iTrackMetaData;
        }
        public String TrackURI()
        {
            return iTrackURI;
        }
        public String RelTime()
        {
            return iRelTime;
        }
        public String AbsTime()
        {
            return iAbsTime;
        }
        public int RelCount()
        {
            return iRelCount;
        }
        public int AbsCount()
        {
            return iAbsCount;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndGetPositionInfo(aAsyncHandle, out iTrack, out iTrackDuration, out iTrackMetaData, out iTrackURI, out iRelTime, out iAbsTime, out iRelCount, out iAbsCount);
        }
    };

    internal class SyncGetDeviceCapabilitiesUpnpOrgAVTransport2 : SyncProxyAction
    {
        private CpProxyUpnpOrgAVTransport2 iService;
        private String iPlayMedia;
        private String iRecMedia;
        private String iRecQualityModes;

        public SyncGetDeviceCapabilitiesUpnpOrgAVTransport2(CpProxyUpnpOrgAVTransport2 aProxy)
        {
            iService = aProxy;
        }
        public String PlayMedia()
        {
            return iPlayMedia;
        }
        public String RecMedia()
        {
            return iRecMedia;
        }
        public String RecQualityModes()
        {
            return iRecQualityModes;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndGetDeviceCapabilities(aAsyncHandle, out iPlayMedia, out iRecMedia, out iRecQualityModes);
        }
    };

    internal class SyncGetTransportSettingsUpnpOrgAVTransport2 : SyncProxyAction
    {
        private CpProxyUpnpOrgAVTransport2 iService;
        private String iPlayMode;
        private String iRecQualityMode;

        public SyncGetTransportSettingsUpnpOrgAVTransport2(CpProxyUpnpOrgAVTransport2 aProxy)
        {
            iService = aProxy;
        }
        public String PlayMode()
        {
            return iPlayMode;
        }
        public String RecQualityMode()
        {
            return iRecQualityMode;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndGetTransportSettings(aAsyncHandle, out iPlayMode, out iRecQualityMode);
        }
    };

    internal class SyncStopUpnpOrgAVTransport2 : SyncProxyAction
    {
        private CpProxyUpnpOrgAVTransport2 iService;

        public SyncStopUpnpOrgAVTransport2(CpProxyUpnpOrgAVTransport2 aProxy)
        {
            iService = aProxy;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndStop(aAsyncHandle);
        }
    };

    internal class SyncPlayUpnpOrgAVTransport2 : SyncProxyAction
    {
        private CpProxyUpnpOrgAVTransport2 iService;

        public SyncPlayUpnpOrgAVTransport2(CpProxyUpnpOrgAVTransport2 aProxy)
        {
            iService = aProxy;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndPlay(aAsyncHandle);
        }
    };

    internal class SyncPauseUpnpOrgAVTransport2 : SyncProxyAction
    {
        private CpProxyUpnpOrgAVTransport2 iService;

        public SyncPauseUpnpOrgAVTransport2(CpProxyUpnpOrgAVTransport2 aProxy)
        {
            iService = aProxy;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndPause(aAsyncHandle);
        }
    };

    internal class SyncRecordUpnpOrgAVTransport2 : SyncProxyAction
    {
        private CpProxyUpnpOrgAVTransport2 iService;

        public SyncRecordUpnpOrgAVTransport2(CpProxyUpnpOrgAVTransport2 aProxy)
        {
            iService = aProxy;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndRecord(aAsyncHandle);
        }
    };

    internal class SyncSeekUpnpOrgAVTransport2 : SyncProxyAction
    {
        private CpProxyUpnpOrgAVTransport2 iService;

        public SyncSeekUpnpOrgAVTransport2(CpProxyUpnpOrgAVTransport2 aProxy)
        {
            iService = aProxy;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndSeek(aAsyncHandle);
        }
    };

    internal class SyncNextUpnpOrgAVTransport2 : SyncProxyAction
    {
        private CpProxyUpnpOrgAVTransport2 iService;

        public SyncNextUpnpOrgAVTransport2(CpProxyUpnpOrgAVTransport2 aProxy)
        {
            iService = aProxy;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndNext(aAsyncHandle);
        }
    };

    internal class SyncPreviousUpnpOrgAVTransport2 : SyncProxyAction
    {
        private CpProxyUpnpOrgAVTransport2 iService;

        public SyncPreviousUpnpOrgAVTransport2(CpProxyUpnpOrgAVTransport2 aProxy)
        {
            iService = aProxy;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndPrevious(aAsyncHandle);
        }
    };

    internal class SyncSetPlayModeUpnpOrgAVTransport2 : SyncProxyAction
    {
        private CpProxyUpnpOrgAVTransport2 iService;

        public SyncSetPlayModeUpnpOrgAVTransport2(CpProxyUpnpOrgAVTransport2 aProxy)
        {
            iService = aProxy;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndSetPlayMode(aAsyncHandle);
        }
    };

    internal class SyncSetRecordQualityModeUpnpOrgAVTransport2 : SyncProxyAction
    {
        private CpProxyUpnpOrgAVTransport2 iService;

        public SyncSetRecordQualityModeUpnpOrgAVTransport2(CpProxyUpnpOrgAVTransport2 aProxy)
        {
            iService = aProxy;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndSetRecordQualityMode(aAsyncHandle);
        }
    };

    internal class SyncGetCurrentTransportActionsUpnpOrgAVTransport2 : SyncProxyAction
    {
        private CpProxyUpnpOrgAVTransport2 iService;
        private String iActions;

        public SyncGetCurrentTransportActionsUpnpOrgAVTransport2(CpProxyUpnpOrgAVTransport2 aProxy)
        {
            iService = aProxy;
        }
        public String Actions()
        {
            return iActions;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndGetCurrentTransportActions(aAsyncHandle, out iActions);
        }
    };

    internal class SyncGetDRMStateUpnpOrgAVTransport2 : SyncProxyAction
    {
        private CpProxyUpnpOrgAVTransport2 iService;
        private String iCurrentDRMState;

        public SyncGetDRMStateUpnpOrgAVTransport2(CpProxyUpnpOrgAVTransport2 aProxy)
        {
            iService = aProxy;
        }
        public String CurrentDRMState()
        {
            return iCurrentDRMState;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndGetDRMState(aAsyncHandle, out iCurrentDRMState);
        }
    };

    internal class SyncGetStateVariablesUpnpOrgAVTransport2 : SyncProxyAction
    {
        private CpProxyUpnpOrgAVTransport2 iService;
        private String iStateVariableValuePairs;

        public SyncGetStateVariablesUpnpOrgAVTransport2(CpProxyUpnpOrgAVTransport2 aProxy)
        {
            iService = aProxy;
        }
        public String StateVariableValuePairs()
        {
            return iStateVariableValuePairs;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndGetStateVariables(aAsyncHandle, out iStateVariableValuePairs);
        }
    };

    internal class SyncSetStateVariablesUpnpOrgAVTransport2 : SyncProxyAction
    {
        private CpProxyUpnpOrgAVTransport2 iService;
        private String iStateVariableList;

        public SyncSetStateVariablesUpnpOrgAVTransport2(CpProxyUpnpOrgAVTransport2 aProxy)
        {
            iService = aProxy;
        }
        public String StateVariableList()
        {
            return iStateVariableList;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndSetStateVariables(aAsyncHandle, out iStateVariableList);
        }
    };

    /// <summary>
    /// Proxy for the upnp.org:AVTransport:2 UPnP service
    /// </summary>
    public class CpProxyUpnpOrgAVTransport2 : CpProxy, IDisposable, ICpProxyUpnpOrgAVTransport2
    {
        private Zapp.Core.Action iActionSetAVTransportURI;
        private Zapp.Core.Action iActionSetNextAVTransportURI;
        private Zapp.Core.Action iActionGetMediaInfo;
        private Zapp.Core.Action iActionGetMediaInfo_Ext;
        private Zapp.Core.Action iActionGetTransportInfo;
        private Zapp.Core.Action iActionGetPositionInfo;
        private Zapp.Core.Action iActionGetDeviceCapabilities;
        private Zapp.Core.Action iActionGetTransportSettings;
        private Zapp.Core.Action iActionStop;
        private Zapp.Core.Action iActionPlay;
        private Zapp.Core.Action iActionPause;
        private Zapp.Core.Action iActionRecord;
        private Zapp.Core.Action iActionSeek;
        private Zapp.Core.Action iActionNext;
        private Zapp.Core.Action iActionPrevious;
        private Zapp.Core.Action iActionSetPlayMode;
        private Zapp.Core.Action iActionSetRecordQualityMode;
        private Zapp.Core.Action iActionGetCurrentTransportActions;
        private Zapp.Core.Action iActionGetDRMState;
        private Zapp.Core.Action iActionGetStateVariables;
        private Zapp.Core.Action iActionSetStateVariables;
        private PropertyString iLastChange;
        private PropertyString iDRMState;
        private CallbackPropertyChanged iLastChangeChanged;
        private CallbackPropertyChanged iDRMStateChanged;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <remarks>Use CpProxy::[Un]Subscribe() to enable/disable querying of state variable and reporting of their changes.</remarks>
        /// <param name="aDevice">The device to use</param>
        public CpProxyUpnpOrgAVTransport2(CpDevice aDevice)
            : base("schemas-upnp-org", "AVTransport", 2, aDevice)
        {
            Zapp.Core.Parameter param;
            List<String> allowedValues = new List<String>();

            iActionSetAVTransportURI = new Zapp.Core.Action("SetAVTransportURI");
            param = new ParameterUint("InstanceID");
            iActionSetAVTransportURI.AddInputParameter(param);
            param = new ParameterString("CurrentURI", allowedValues);
            iActionSetAVTransportURI.AddInputParameter(param);
            param = new ParameterString("CurrentURIMetaData", allowedValues);
            iActionSetAVTransportURI.AddInputParameter(param);

            iActionSetNextAVTransportURI = new Zapp.Core.Action("SetNextAVTransportURI");
            param = new ParameterUint("InstanceID");
            iActionSetNextAVTransportURI.AddInputParameter(param);
            param = new ParameterString("NextURI", allowedValues);
            iActionSetNextAVTransportURI.AddInputParameter(param);
            param = new ParameterString("NextURIMetaData", allowedValues);
            iActionSetNextAVTransportURI.AddInputParameter(param);

            iActionGetMediaInfo = new Zapp.Core.Action("GetMediaInfo");
            param = new ParameterUint("InstanceID");
            iActionGetMediaInfo.AddInputParameter(param);
            param = new ParameterUint("NrTracks", 0, 0);
            iActionGetMediaInfo.AddOutputParameter(param);
            param = new ParameterString("MediaDuration", allowedValues);
            iActionGetMediaInfo.AddOutputParameter(param);
            param = new ParameterString("CurrentURI", allowedValues);
            iActionGetMediaInfo.AddOutputParameter(param);
            param = new ParameterString("CurrentURIMetaData", allowedValues);
            iActionGetMediaInfo.AddOutputParameter(param);
            param = new ParameterString("NextURI", allowedValues);
            iActionGetMediaInfo.AddOutputParameter(param);
            param = new ParameterString("NextURIMetaData", allowedValues);
            iActionGetMediaInfo.AddOutputParameter(param);
            param = new ParameterString("PlayMedium", allowedValues);
            iActionGetMediaInfo.AddOutputParameter(param);
            param = new ParameterString("RecordMedium", allowedValues);
            iActionGetMediaInfo.AddOutputParameter(param);
            param = new ParameterString("WriteStatus", allowedValues);
            iActionGetMediaInfo.AddOutputParameter(param);

            iActionGetMediaInfo_Ext = new Zapp.Core.Action("GetMediaInfo_Ext");
            param = new ParameterUint("InstanceID");
            iActionGetMediaInfo_Ext.AddInputParameter(param);
            allowedValues.Add("NO_MEDIA");
            allowedValues.Add("TRACK_AWARE");
            allowedValues.Add("TRACK_UNAWARE");
            param = new ParameterString("CurrentType", allowedValues);
            iActionGetMediaInfo_Ext.AddOutputParameter(param);
            allowedValues.Clear();
            param = new ParameterUint("NrTracks", 0, 0);
            iActionGetMediaInfo_Ext.AddOutputParameter(param);
            param = new ParameterString("MediaDuration", allowedValues);
            iActionGetMediaInfo_Ext.AddOutputParameter(param);
            param = new ParameterString("CurrentURI", allowedValues);
            iActionGetMediaInfo_Ext.AddOutputParameter(param);
            param = new ParameterString("CurrentURIMetaData", allowedValues);
            iActionGetMediaInfo_Ext.AddOutputParameter(param);
            param = new ParameterString("NextURI", allowedValues);
            iActionGetMediaInfo_Ext.AddOutputParameter(param);
            param = new ParameterString("NextURIMetaData", allowedValues);
            iActionGetMediaInfo_Ext.AddOutputParameter(param);
            param = new ParameterString("PlayMedium", allowedValues);
            iActionGetMediaInfo_Ext.AddOutputParameter(param);
            param = new ParameterString("RecordMedium", allowedValues);
            iActionGetMediaInfo_Ext.AddOutputParameter(param);
            param = new ParameterString("WriteStatus", allowedValues);
            iActionGetMediaInfo_Ext.AddOutputParameter(param);

            iActionGetTransportInfo = new Zapp.Core.Action("GetTransportInfo");
            param = new ParameterUint("InstanceID");
            iActionGetTransportInfo.AddInputParameter(param);
            allowedValues.Add("STOPPED");
            allowedValues.Add("PLAYING");
            param = new ParameterString("CurrentTransportState", allowedValues);
            iActionGetTransportInfo.AddOutputParameter(param);
            allowedValues.Clear();
            allowedValues.Add("OK");
            allowedValues.Add("ERROR_OCCURRED");
            param = new ParameterString("CurrentTransportStatus", allowedValues);
            iActionGetTransportInfo.AddOutputParameter(param);
            allowedValues.Clear();
            allowedValues.Add("1");
            param = new ParameterString("CurrentSpeed", allowedValues);
            iActionGetTransportInfo.AddOutputParameter(param);
            allowedValues.Clear();

            iActionGetPositionInfo = new Zapp.Core.Action("GetPositionInfo");
            param = new ParameterUint("InstanceID");
            iActionGetPositionInfo.AddInputParameter(param);
            param = new ParameterUint("Track", 0, 0, 1);
            iActionGetPositionInfo.AddOutputParameter(param);
            param = new ParameterString("TrackDuration", allowedValues);
            iActionGetPositionInfo.AddOutputParameter(param);
            param = new ParameterString("TrackMetaData", allowedValues);
            iActionGetPositionInfo.AddOutputParameter(param);
            param = new ParameterString("TrackURI", allowedValues);
            iActionGetPositionInfo.AddOutputParameter(param);
            param = new ParameterString("RelTime", allowedValues);
            iActionGetPositionInfo.AddOutputParameter(param);
            param = new ParameterString("AbsTime", allowedValues);
            iActionGetPositionInfo.AddOutputParameter(param);
            param = new ParameterInt("RelCount");
            iActionGetPositionInfo.AddOutputParameter(param);
            param = new ParameterInt("AbsCount");
            iActionGetPositionInfo.AddOutputParameter(param);

            iActionGetDeviceCapabilities = new Zapp.Core.Action("GetDeviceCapabilities");
            param = new ParameterUint("InstanceID");
            iActionGetDeviceCapabilities.AddInputParameter(param);
            param = new ParameterString("PlayMedia", allowedValues);
            iActionGetDeviceCapabilities.AddOutputParameter(param);
            param = new ParameterString("RecMedia", allowedValues);
            iActionGetDeviceCapabilities.AddOutputParameter(param);
            param = new ParameterString("RecQualityModes", allowedValues);
            iActionGetDeviceCapabilities.AddOutputParameter(param);

            iActionGetTransportSettings = new Zapp.Core.Action("GetTransportSettings");
            param = new ParameterUint("InstanceID");
            iActionGetTransportSettings.AddInputParameter(param);
            allowedValues.Add("NORMAL");
            param = new ParameterString("PlayMode", allowedValues);
            iActionGetTransportSettings.AddOutputParameter(param);
            allowedValues.Clear();
            param = new ParameterString("RecQualityMode", allowedValues);
            iActionGetTransportSettings.AddOutputParameter(param);

            iActionStop = new Zapp.Core.Action("Stop");
            param = new ParameterUint("InstanceID");
            iActionStop.AddInputParameter(param);

            iActionPlay = new Zapp.Core.Action("Play");
            param = new ParameterUint("InstanceID");
            iActionPlay.AddInputParameter(param);
            allowedValues.Add("1");
            param = new ParameterString("Speed", allowedValues);
            iActionPlay.AddInputParameter(param);
            allowedValues.Clear();

            iActionPause = new Zapp.Core.Action("Pause");
            param = new ParameterUint("InstanceID");
            iActionPause.AddInputParameter(param);

            iActionRecord = new Zapp.Core.Action("Record");
            param = new ParameterUint("InstanceID");
            iActionRecord.AddInputParameter(param);

            iActionSeek = new Zapp.Core.Action("Seek");
            param = new ParameterUint("InstanceID");
            iActionSeek.AddInputParameter(param);
            allowedValues.Add("TRACK_NR");
            param = new ParameterString("Unit", allowedValues);
            iActionSeek.AddInputParameter(param);
            allowedValues.Clear();
            param = new ParameterString("Target", allowedValues);
            iActionSeek.AddInputParameter(param);

            iActionNext = new Zapp.Core.Action("Next");
            param = new ParameterUint("InstanceID");
            iActionNext.AddInputParameter(param);

            iActionPrevious = new Zapp.Core.Action("Previous");
            param = new ParameterUint("InstanceID");
            iActionPrevious.AddInputParameter(param);

            iActionSetPlayMode = new Zapp.Core.Action("SetPlayMode");
            param = new ParameterUint("InstanceID");
            iActionSetPlayMode.AddInputParameter(param);
            allowedValues.Add("NORMAL");
            param = new ParameterString("NewPlayMode", allowedValues);
            iActionSetPlayMode.AddInputParameter(param);
            allowedValues.Clear();

            iActionSetRecordQualityMode = new Zapp.Core.Action("SetRecordQualityMode");
            param = new ParameterUint("InstanceID");
            iActionSetRecordQualityMode.AddInputParameter(param);
            param = new ParameterString("NewRecordQualityMode", allowedValues);
            iActionSetRecordQualityMode.AddInputParameter(param);

            iActionGetCurrentTransportActions = new Zapp.Core.Action("GetCurrentTransportActions");
            param = new ParameterUint("InstanceID");
            iActionGetCurrentTransportActions.AddInputParameter(param);
            param = new ParameterString("Actions", allowedValues);
            iActionGetCurrentTransportActions.AddOutputParameter(param);

            iActionGetDRMState = new Zapp.Core.Action("GetDRMState");
            param = new ParameterUint("InstanceID");
            iActionGetDRMState.AddInputParameter(param);
            allowedValues.Add("OK");
            param = new ParameterString("CurrentDRMState", allowedValues);
            iActionGetDRMState.AddOutputParameter(param);
            allowedValues.Clear();

            iActionGetStateVariables = new Zapp.Core.Action("GetStateVariables");
            param = new ParameterUint("InstanceID");
            iActionGetStateVariables.AddInputParameter(param);
            param = new ParameterString("StateVariableList", allowedValues);
            iActionGetStateVariables.AddInputParameter(param);
            param = new ParameterString("StateVariableValuePairs", allowedValues);
            iActionGetStateVariables.AddOutputParameter(param);

            iActionSetStateVariables = new Zapp.Core.Action("SetStateVariables");
            param = new ParameterUint("InstanceID");
            iActionSetStateVariables.AddInputParameter(param);
            param = new ParameterString("AVTransportUDN", allowedValues);
            iActionSetStateVariables.AddInputParameter(param);
            param = new ParameterString("ServiceType", allowedValues);
            iActionSetStateVariables.AddInputParameter(param);
            param = new ParameterString("ServiceId", allowedValues);
            iActionSetStateVariables.AddInputParameter(param);
            param = new ParameterString("StateVariableValuePairs", allowedValues);
            iActionSetStateVariables.AddInputParameter(param);
            param = new ParameterString("StateVariableList", allowedValues);
            iActionSetStateVariables.AddOutputParameter(param);

            iLastChange = new PropertyString("LastChange", LastChangePropertyChanged);
            AddProperty(iLastChange);
            iDRMState = new PropertyString("DRMState", DRMStatePropertyChanged);
            AddProperty(iDRMState);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aCurrentURI"></param>
        /// <param name="aCurrentURIMetaData"></param>
        public void SyncSetAVTransportURI(uint aInstanceID, String aCurrentURI, String aCurrentURIMetaData)
        {
            SyncSetAVTransportURIUpnpOrgAVTransport2 sync = new SyncSetAVTransportURIUpnpOrgAVTransport2(this);
            BeginSetAVTransportURI(aInstanceID, aCurrentURI, aCurrentURIMetaData, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndSetAVTransportURI().</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aCurrentURI"></param>
        /// <param name="aCurrentURIMetaData"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginSetAVTransportURI(uint aInstanceID, String aCurrentURI, String aCurrentURIMetaData, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionSetAVTransportURI, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionSetAVTransportURI.InputParameter(inIndex++), aInstanceID));
            invocation.AddInput(new ArgumentString((ParameterString)iActionSetAVTransportURI.InputParameter(inIndex++), aCurrentURI));
            invocation.AddInput(new ArgumentString((ParameterString)iActionSetAVTransportURI.InputParameter(inIndex++), aCurrentURIMetaData));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        public void EndSetAVTransportURI(IntPtr aAsyncHandle)
        {
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aNextURI"></param>
        /// <param name="aNextURIMetaData"></param>
        public void SyncSetNextAVTransportURI(uint aInstanceID, String aNextURI, String aNextURIMetaData)
        {
            SyncSetNextAVTransportURIUpnpOrgAVTransport2 sync = new SyncSetNextAVTransportURIUpnpOrgAVTransport2(this);
            BeginSetNextAVTransportURI(aInstanceID, aNextURI, aNextURIMetaData, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndSetNextAVTransportURI().</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aNextURI"></param>
        /// <param name="aNextURIMetaData"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginSetNextAVTransportURI(uint aInstanceID, String aNextURI, String aNextURIMetaData, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionSetNextAVTransportURI, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionSetNextAVTransportURI.InputParameter(inIndex++), aInstanceID));
            invocation.AddInput(new ArgumentString((ParameterString)iActionSetNextAVTransportURI.InputParameter(inIndex++), aNextURI));
            invocation.AddInput(new ArgumentString((ParameterString)iActionSetNextAVTransportURI.InputParameter(inIndex++), aNextURIMetaData));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        public void EndSetNextAVTransportURI(IntPtr aAsyncHandle)
        {
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aNrTracks"></param>
        /// <param name="aMediaDuration"></param>
        /// <param name="aCurrentURI"></param>
        /// <param name="aCurrentURIMetaData"></param>
        /// <param name="aNextURI"></param>
        /// <param name="aNextURIMetaData"></param>
        /// <param name="aPlayMedium"></param>
        /// <param name="aRecordMedium"></param>
        /// <param name="aWriteStatus"></param>
        public void SyncGetMediaInfo(uint aInstanceID, out uint aNrTracks, out String aMediaDuration, out String aCurrentURI, out String aCurrentURIMetaData, out String aNextURI, out String aNextURIMetaData, out String aPlayMedium, out String aRecordMedium, out String aWriteStatus)
        {
            SyncGetMediaInfoUpnpOrgAVTransport2 sync = new SyncGetMediaInfoUpnpOrgAVTransport2(this);
            BeginGetMediaInfo(aInstanceID, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aNrTracks = sync.NrTracks();
            aMediaDuration = sync.MediaDuration();
            aCurrentURI = sync.CurrentURI();
            aCurrentURIMetaData = sync.CurrentURIMetaData();
            aNextURI = sync.NextURI();
            aNextURIMetaData = sync.NextURIMetaData();
            aPlayMedium = sync.PlayMedium();
            aRecordMedium = sync.RecordMedium();
            aWriteStatus = sync.WriteStatus();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndGetMediaInfo().</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginGetMediaInfo(uint aInstanceID, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionGetMediaInfo, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionGetMediaInfo.InputParameter(inIndex++), aInstanceID));
            int outIndex = 0;
            invocation.AddOutput(new ArgumentUint((ParameterUint)iActionGetMediaInfo.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetMediaInfo.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetMediaInfo.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetMediaInfo.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetMediaInfo.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetMediaInfo.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetMediaInfo.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetMediaInfo.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetMediaInfo.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aNrTracks"></param>
        /// <param name="aMediaDuration"></param>
        /// <param name="aCurrentURI"></param>
        /// <param name="aCurrentURIMetaData"></param>
        /// <param name="aNextURI"></param>
        /// <param name="aNextURIMetaData"></param>
        /// <param name="aPlayMedium"></param>
        /// <param name="aRecordMedium"></param>
        /// <param name="aWriteStatus"></param>
        public void EndGetMediaInfo(IntPtr aAsyncHandle, out uint aNrTracks, out String aMediaDuration, out String aCurrentURI, out String aCurrentURIMetaData, out String aNextURI, out String aNextURIMetaData, out String aPlayMedium, out String aRecordMedium, out String aWriteStatus)
        {
            uint index = 0;
            aNrTracks = Invocation.OutputUint(aAsyncHandle, index++);
            aMediaDuration = Invocation.OutputString(aAsyncHandle, index++);
            aCurrentURI = Invocation.OutputString(aAsyncHandle, index++);
            aCurrentURIMetaData = Invocation.OutputString(aAsyncHandle, index++);
            aNextURI = Invocation.OutputString(aAsyncHandle, index++);
            aNextURIMetaData = Invocation.OutputString(aAsyncHandle, index++);
            aPlayMedium = Invocation.OutputString(aAsyncHandle, index++);
            aRecordMedium = Invocation.OutputString(aAsyncHandle, index++);
            aWriteStatus = Invocation.OutputString(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aCurrentType"></param>
        /// <param name="aNrTracks"></param>
        /// <param name="aMediaDuration"></param>
        /// <param name="aCurrentURI"></param>
        /// <param name="aCurrentURIMetaData"></param>
        /// <param name="aNextURI"></param>
        /// <param name="aNextURIMetaData"></param>
        /// <param name="aPlayMedium"></param>
        /// <param name="aRecordMedium"></param>
        /// <param name="aWriteStatus"></param>
        public void SyncGetMediaInfo_Ext(uint aInstanceID, out String aCurrentType, out uint aNrTracks, out String aMediaDuration, out String aCurrentURI, out String aCurrentURIMetaData, out String aNextURI, out String aNextURIMetaData, out String aPlayMedium, out String aRecordMedium, out String aWriteStatus)
        {
            SyncGetMediaInfo_ExtUpnpOrgAVTransport2 sync = new SyncGetMediaInfo_ExtUpnpOrgAVTransport2(this);
            BeginGetMediaInfo_Ext(aInstanceID, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aCurrentType = sync.CurrentType();
            aNrTracks = sync.NrTracks();
            aMediaDuration = sync.MediaDuration();
            aCurrentURI = sync.CurrentURI();
            aCurrentURIMetaData = sync.CurrentURIMetaData();
            aNextURI = sync.NextURI();
            aNextURIMetaData = sync.NextURIMetaData();
            aPlayMedium = sync.PlayMedium();
            aRecordMedium = sync.RecordMedium();
            aWriteStatus = sync.WriteStatus();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndGetMediaInfo_Ext().</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginGetMediaInfo_Ext(uint aInstanceID, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionGetMediaInfo_Ext, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionGetMediaInfo_Ext.InputParameter(inIndex++), aInstanceID));
            int outIndex = 0;
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetMediaInfo_Ext.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentUint((ParameterUint)iActionGetMediaInfo_Ext.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetMediaInfo_Ext.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetMediaInfo_Ext.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetMediaInfo_Ext.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetMediaInfo_Ext.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetMediaInfo_Ext.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetMediaInfo_Ext.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetMediaInfo_Ext.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetMediaInfo_Ext.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aCurrentType"></param>
        /// <param name="aNrTracks"></param>
        /// <param name="aMediaDuration"></param>
        /// <param name="aCurrentURI"></param>
        /// <param name="aCurrentURIMetaData"></param>
        /// <param name="aNextURI"></param>
        /// <param name="aNextURIMetaData"></param>
        /// <param name="aPlayMedium"></param>
        /// <param name="aRecordMedium"></param>
        /// <param name="aWriteStatus"></param>
        public void EndGetMediaInfo_Ext(IntPtr aAsyncHandle, out String aCurrentType, out uint aNrTracks, out String aMediaDuration, out String aCurrentURI, out String aCurrentURIMetaData, out String aNextURI, out String aNextURIMetaData, out String aPlayMedium, out String aRecordMedium, out String aWriteStatus)
        {
            uint index = 0;
            aCurrentType = Invocation.OutputString(aAsyncHandle, index++);
            aNrTracks = Invocation.OutputUint(aAsyncHandle, index++);
            aMediaDuration = Invocation.OutputString(aAsyncHandle, index++);
            aCurrentURI = Invocation.OutputString(aAsyncHandle, index++);
            aCurrentURIMetaData = Invocation.OutputString(aAsyncHandle, index++);
            aNextURI = Invocation.OutputString(aAsyncHandle, index++);
            aNextURIMetaData = Invocation.OutputString(aAsyncHandle, index++);
            aPlayMedium = Invocation.OutputString(aAsyncHandle, index++);
            aRecordMedium = Invocation.OutputString(aAsyncHandle, index++);
            aWriteStatus = Invocation.OutputString(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aCurrentTransportState"></param>
        /// <param name="aCurrentTransportStatus"></param>
        /// <param name="aCurrentSpeed"></param>
        public void SyncGetTransportInfo(uint aInstanceID, out String aCurrentTransportState, out String aCurrentTransportStatus, out String aCurrentSpeed)
        {
            SyncGetTransportInfoUpnpOrgAVTransport2 sync = new SyncGetTransportInfoUpnpOrgAVTransport2(this);
            BeginGetTransportInfo(aInstanceID, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aCurrentTransportState = sync.CurrentTransportState();
            aCurrentTransportStatus = sync.CurrentTransportStatus();
            aCurrentSpeed = sync.CurrentSpeed();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndGetTransportInfo().</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginGetTransportInfo(uint aInstanceID, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionGetTransportInfo, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionGetTransportInfo.InputParameter(inIndex++), aInstanceID));
            int outIndex = 0;
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetTransportInfo.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetTransportInfo.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetTransportInfo.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aCurrentTransportState"></param>
        /// <param name="aCurrentTransportStatus"></param>
        /// <param name="aCurrentSpeed"></param>
        public void EndGetTransportInfo(IntPtr aAsyncHandle, out String aCurrentTransportState, out String aCurrentTransportStatus, out String aCurrentSpeed)
        {
            uint index = 0;
            aCurrentTransportState = Invocation.OutputString(aAsyncHandle, index++);
            aCurrentTransportStatus = Invocation.OutputString(aAsyncHandle, index++);
            aCurrentSpeed = Invocation.OutputString(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aTrack"></param>
        /// <param name="aTrackDuration"></param>
        /// <param name="aTrackMetaData"></param>
        /// <param name="aTrackURI"></param>
        /// <param name="aRelTime"></param>
        /// <param name="aAbsTime"></param>
        /// <param name="aRelCount"></param>
        /// <param name="aAbsCount"></param>
        public void SyncGetPositionInfo(uint aInstanceID, out uint aTrack, out String aTrackDuration, out String aTrackMetaData, out String aTrackURI, out String aRelTime, out String aAbsTime, out int aRelCount, out int aAbsCount)
        {
            SyncGetPositionInfoUpnpOrgAVTransport2 sync = new SyncGetPositionInfoUpnpOrgAVTransport2(this);
            BeginGetPositionInfo(aInstanceID, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aTrack = sync.Track();
            aTrackDuration = sync.TrackDuration();
            aTrackMetaData = sync.TrackMetaData();
            aTrackURI = sync.TrackURI();
            aRelTime = sync.RelTime();
            aAbsTime = sync.AbsTime();
            aRelCount = sync.RelCount();
            aAbsCount = sync.AbsCount();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndGetPositionInfo().</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginGetPositionInfo(uint aInstanceID, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionGetPositionInfo, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionGetPositionInfo.InputParameter(inIndex++), aInstanceID));
            int outIndex = 0;
            invocation.AddOutput(new ArgumentUint((ParameterUint)iActionGetPositionInfo.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetPositionInfo.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetPositionInfo.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetPositionInfo.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetPositionInfo.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetPositionInfo.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentInt((ParameterInt)iActionGetPositionInfo.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentInt((ParameterInt)iActionGetPositionInfo.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aTrack"></param>
        /// <param name="aTrackDuration"></param>
        /// <param name="aTrackMetaData"></param>
        /// <param name="aTrackURI"></param>
        /// <param name="aRelTime"></param>
        /// <param name="aAbsTime"></param>
        /// <param name="aRelCount"></param>
        /// <param name="aAbsCount"></param>
        public void EndGetPositionInfo(IntPtr aAsyncHandle, out uint aTrack, out String aTrackDuration, out String aTrackMetaData, out String aTrackURI, out String aRelTime, out String aAbsTime, out int aRelCount, out int aAbsCount)
        {
            uint index = 0;
            aTrack = Invocation.OutputUint(aAsyncHandle, index++);
            aTrackDuration = Invocation.OutputString(aAsyncHandle, index++);
            aTrackMetaData = Invocation.OutputString(aAsyncHandle, index++);
            aTrackURI = Invocation.OutputString(aAsyncHandle, index++);
            aRelTime = Invocation.OutputString(aAsyncHandle, index++);
            aAbsTime = Invocation.OutputString(aAsyncHandle, index++);
            aRelCount = Invocation.OutputInt(aAsyncHandle, index++);
            aAbsCount = Invocation.OutputInt(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aPlayMedia"></param>
        /// <param name="aRecMedia"></param>
        /// <param name="aRecQualityModes"></param>
        public void SyncGetDeviceCapabilities(uint aInstanceID, out String aPlayMedia, out String aRecMedia, out String aRecQualityModes)
        {
            SyncGetDeviceCapabilitiesUpnpOrgAVTransport2 sync = new SyncGetDeviceCapabilitiesUpnpOrgAVTransport2(this);
            BeginGetDeviceCapabilities(aInstanceID, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aPlayMedia = sync.PlayMedia();
            aRecMedia = sync.RecMedia();
            aRecQualityModes = sync.RecQualityModes();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndGetDeviceCapabilities().</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginGetDeviceCapabilities(uint aInstanceID, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionGetDeviceCapabilities, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionGetDeviceCapabilities.InputParameter(inIndex++), aInstanceID));
            int outIndex = 0;
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetDeviceCapabilities.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetDeviceCapabilities.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetDeviceCapabilities.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aPlayMedia"></param>
        /// <param name="aRecMedia"></param>
        /// <param name="aRecQualityModes"></param>
        public void EndGetDeviceCapabilities(IntPtr aAsyncHandle, out String aPlayMedia, out String aRecMedia, out String aRecQualityModes)
        {
            uint index = 0;
            aPlayMedia = Invocation.OutputString(aAsyncHandle, index++);
            aRecMedia = Invocation.OutputString(aAsyncHandle, index++);
            aRecQualityModes = Invocation.OutputString(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aPlayMode"></param>
        /// <param name="aRecQualityMode"></param>
        public void SyncGetTransportSettings(uint aInstanceID, out String aPlayMode, out String aRecQualityMode)
        {
            SyncGetTransportSettingsUpnpOrgAVTransport2 sync = new SyncGetTransportSettingsUpnpOrgAVTransport2(this);
            BeginGetTransportSettings(aInstanceID, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aPlayMode = sync.PlayMode();
            aRecQualityMode = sync.RecQualityMode();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndGetTransportSettings().</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginGetTransportSettings(uint aInstanceID, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionGetTransportSettings, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionGetTransportSettings.InputParameter(inIndex++), aInstanceID));
            int outIndex = 0;
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetTransportSettings.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetTransportSettings.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aPlayMode"></param>
        /// <param name="aRecQualityMode"></param>
        public void EndGetTransportSettings(IntPtr aAsyncHandle, out String aPlayMode, out String aRecQualityMode)
        {
            uint index = 0;
            aPlayMode = Invocation.OutputString(aAsyncHandle, index++);
            aRecQualityMode = Invocation.OutputString(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aInstanceID"></param>
        public void SyncStop(uint aInstanceID)
        {
            SyncStopUpnpOrgAVTransport2 sync = new SyncStopUpnpOrgAVTransport2(this);
            BeginStop(aInstanceID, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndStop().</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginStop(uint aInstanceID, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionStop, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionStop.InputParameter(inIndex++), aInstanceID));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        public void EndStop(IntPtr aAsyncHandle)
        {
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aSpeed"></param>
        public void SyncPlay(uint aInstanceID, String aSpeed)
        {
            SyncPlayUpnpOrgAVTransport2 sync = new SyncPlayUpnpOrgAVTransport2(this);
            BeginPlay(aInstanceID, aSpeed, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndPlay().</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aSpeed"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginPlay(uint aInstanceID, String aSpeed, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionPlay, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionPlay.InputParameter(inIndex++), aInstanceID));
            invocation.AddInput(new ArgumentString((ParameterString)iActionPlay.InputParameter(inIndex++), aSpeed));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        public void EndPlay(IntPtr aAsyncHandle)
        {
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aInstanceID"></param>
        public void SyncPause(uint aInstanceID)
        {
            SyncPauseUpnpOrgAVTransport2 sync = new SyncPauseUpnpOrgAVTransport2(this);
            BeginPause(aInstanceID, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndPause().</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginPause(uint aInstanceID, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionPause, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionPause.InputParameter(inIndex++), aInstanceID));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        public void EndPause(IntPtr aAsyncHandle)
        {
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aInstanceID"></param>
        public void SyncRecord(uint aInstanceID)
        {
            SyncRecordUpnpOrgAVTransport2 sync = new SyncRecordUpnpOrgAVTransport2(this);
            BeginRecord(aInstanceID, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndRecord().</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginRecord(uint aInstanceID, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionRecord, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionRecord.InputParameter(inIndex++), aInstanceID));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        public void EndRecord(IntPtr aAsyncHandle)
        {
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aUnit"></param>
        /// <param name="aTarget"></param>
        public void SyncSeek(uint aInstanceID, String aUnit, String aTarget)
        {
            SyncSeekUpnpOrgAVTransport2 sync = new SyncSeekUpnpOrgAVTransport2(this);
            BeginSeek(aInstanceID, aUnit, aTarget, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndSeek().</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aUnit"></param>
        /// <param name="aTarget"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginSeek(uint aInstanceID, String aUnit, String aTarget, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionSeek, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionSeek.InputParameter(inIndex++), aInstanceID));
            invocation.AddInput(new ArgumentString((ParameterString)iActionSeek.InputParameter(inIndex++), aUnit));
            invocation.AddInput(new ArgumentString((ParameterString)iActionSeek.InputParameter(inIndex++), aTarget));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        public void EndSeek(IntPtr aAsyncHandle)
        {
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aInstanceID"></param>
        public void SyncNext(uint aInstanceID)
        {
            SyncNextUpnpOrgAVTransport2 sync = new SyncNextUpnpOrgAVTransport2(this);
            BeginNext(aInstanceID, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndNext().</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginNext(uint aInstanceID, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionNext, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionNext.InputParameter(inIndex++), aInstanceID));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        public void EndNext(IntPtr aAsyncHandle)
        {
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aInstanceID"></param>
        public void SyncPrevious(uint aInstanceID)
        {
            SyncPreviousUpnpOrgAVTransport2 sync = new SyncPreviousUpnpOrgAVTransport2(this);
            BeginPrevious(aInstanceID, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndPrevious().</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginPrevious(uint aInstanceID, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionPrevious, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionPrevious.InputParameter(inIndex++), aInstanceID));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        public void EndPrevious(IntPtr aAsyncHandle)
        {
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aNewPlayMode"></param>
        public void SyncSetPlayMode(uint aInstanceID, String aNewPlayMode)
        {
            SyncSetPlayModeUpnpOrgAVTransport2 sync = new SyncSetPlayModeUpnpOrgAVTransport2(this);
            BeginSetPlayMode(aInstanceID, aNewPlayMode, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndSetPlayMode().</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aNewPlayMode"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginSetPlayMode(uint aInstanceID, String aNewPlayMode, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionSetPlayMode, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionSetPlayMode.InputParameter(inIndex++), aInstanceID));
            invocation.AddInput(new ArgumentString((ParameterString)iActionSetPlayMode.InputParameter(inIndex++), aNewPlayMode));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        public void EndSetPlayMode(IntPtr aAsyncHandle)
        {
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aNewRecordQualityMode"></param>
        public void SyncSetRecordQualityMode(uint aInstanceID, String aNewRecordQualityMode)
        {
            SyncSetRecordQualityModeUpnpOrgAVTransport2 sync = new SyncSetRecordQualityModeUpnpOrgAVTransport2(this);
            BeginSetRecordQualityMode(aInstanceID, aNewRecordQualityMode, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndSetRecordQualityMode().</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aNewRecordQualityMode"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginSetRecordQualityMode(uint aInstanceID, String aNewRecordQualityMode, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionSetRecordQualityMode, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionSetRecordQualityMode.InputParameter(inIndex++), aInstanceID));
            invocation.AddInput(new ArgumentString((ParameterString)iActionSetRecordQualityMode.InputParameter(inIndex++), aNewRecordQualityMode));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        public void EndSetRecordQualityMode(IntPtr aAsyncHandle)
        {
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aActions"></param>
        public void SyncGetCurrentTransportActions(uint aInstanceID, out String aActions)
        {
            SyncGetCurrentTransportActionsUpnpOrgAVTransport2 sync = new SyncGetCurrentTransportActionsUpnpOrgAVTransport2(this);
            BeginGetCurrentTransportActions(aInstanceID, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aActions = sync.Actions();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndGetCurrentTransportActions().</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginGetCurrentTransportActions(uint aInstanceID, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionGetCurrentTransportActions, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionGetCurrentTransportActions.InputParameter(inIndex++), aInstanceID));
            int outIndex = 0;
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetCurrentTransportActions.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aActions"></param>
        public void EndGetCurrentTransportActions(IntPtr aAsyncHandle, out String aActions)
        {
            uint index = 0;
            aActions = Invocation.OutputString(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aCurrentDRMState"></param>
        public void SyncGetDRMState(uint aInstanceID, out String aCurrentDRMState)
        {
            SyncGetDRMStateUpnpOrgAVTransport2 sync = new SyncGetDRMStateUpnpOrgAVTransport2(this);
            BeginGetDRMState(aInstanceID, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aCurrentDRMState = sync.CurrentDRMState();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndGetDRMState().</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginGetDRMState(uint aInstanceID, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionGetDRMState, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionGetDRMState.InputParameter(inIndex++), aInstanceID));
            int outIndex = 0;
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetDRMState.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aCurrentDRMState"></param>
        public void EndGetDRMState(IntPtr aAsyncHandle, out String aCurrentDRMState)
        {
            uint index = 0;
            aCurrentDRMState = Invocation.OutputString(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aStateVariableList"></param>
        /// <param name="aStateVariableValuePairs"></param>
        public void SyncGetStateVariables(uint aInstanceID, String aStateVariableList, out String aStateVariableValuePairs)
        {
            SyncGetStateVariablesUpnpOrgAVTransport2 sync = new SyncGetStateVariablesUpnpOrgAVTransport2(this);
            BeginGetStateVariables(aInstanceID, aStateVariableList, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aStateVariableValuePairs = sync.StateVariableValuePairs();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndGetStateVariables().</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aStateVariableList"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginGetStateVariables(uint aInstanceID, String aStateVariableList, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionGetStateVariables, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionGetStateVariables.InputParameter(inIndex++), aInstanceID));
            invocation.AddInput(new ArgumentString((ParameterString)iActionGetStateVariables.InputParameter(inIndex++), aStateVariableList));
            int outIndex = 0;
            invocation.AddOutput(new ArgumentString((ParameterString)iActionGetStateVariables.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aStateVariableValuePairs"></param>
        public void EndGetStateVariables(IntPtr aAsyncHandle, out String aStateVariableValuePairs)
        {
            uint index = 0;
            aStateVariableValuePairs = Invocation.OutputString(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aAVTransportUDN"></param>
        /// <param name="aServiceType"></param>
        /// <param name="aServiceId"></param>
        /// <param name="aStateVariableValuePairs"></param>
        /// <param name="aStateVariableList"></param>
        public void SyncSetStateVariables(uint aInstanceID, String aAVTransportUDN, String aServiceType, String aServiceId, String aStateVariableValuePairs, out String aStateVariableList)
        {
            SyncSetStateVariablesUpnpOrgAVTransport2 sync = new SyncSetStateVariablesUpnpOrgAVTransport2(this);
            BeginSetStateVariables(aInstanceID, aAVTransportUDN, aServiceType, aServiceId, aStateVariableValuePairs, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aStateVariableList = sync.StateVariableList();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndSetStateVariables().</remarks>
        /// <param name="aInstanceID"></param>
        /// <param name="aAVTransportUDN"></param>
        /// <param name="aServiceType"></param>
        /// <param name="aServiceId"></param>
        /// <param name="aStateVariableValuePairs"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginSetStateVariables(uint aInstanceID, String aAVTransportUDN, String aServiceType, String aServiceId, String aStateVariableValuePairs, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionSetStateVariables, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionSetStateVariables.InputParameter(inIndex++), aInstanceID));
            invocation.AddInput(new ArgumentString((ParameterString)iActionSetStateVariables.InputParameter(inIndex++), aAVTransportUDN));
            invocation.AddInput(new ArgumentString((ParameterString)iActionSetStateVariables.InputParameter(inIndex++), aServiceType));
            invocation.AddInput(new ArgumentString((ParameterString)iActionSetStateVariables.InputParameter(inIndex++), aServiceId));
            invocation.AddInput(new ArgumentString((ParameterString)iActionSetStateVariables.InputParameter(inIndex++), aStateVariableValuePairs));
            int outIndex = 0;
            invocation.AddOutput(new ArgumentString((ParameterString)iActionSetStateVariables.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aStateVariableList"></param>
        public void EndSetStateVariables(IntPtr aAsyncHandle, out String aStateVariableList)
        {
            uint index = 0;
            aStateVariableList = Invocation.OutputString(aAsyncHandle, index++);
        }

        /// <summary>
        /// Set a delegate to be run when the LastChange state variable changes.
        /// </summary>
        /// <remarks>Callbacks may be run in different threads but callbacks for a
        /// CpProxyUpnpOrgAVTransport2 instance will not overlap.</remarks>
        /// <param name="aLastChangeChanged">The delegate to run when the state variable changes</param>
        public void SetPropertyLastChangeChanged(CallbackPropertyChanged aLastChangeChanged)
        {
            lock (this)
            {
                iLastChangeChanged = aLastChangeChanged;
            }
        }

        private void LastChangePropertyChanged()
        {
            lock (this)
            {
                if (iLastChangeChanged != null)
                {
                    iLastChangeChanged();
                }
            }
        }

        /// <summary>
        /// Set a delegate to be run when the DRMState state variable changes.
        /// </summary>
        /// <remarks>Callbacks may be run in different threads but callbacks for a
        /// CpProxyUpnpOrgAVTransport2 instance will not overlap.</remarks>
        /// <param name="aDRMStateChanged">The delegate to run when the state variable changes</param>
        public void SetPropertyDRMStateChanged(CallbackPropertyChanged aDRMStateChanged)
        {
            lock (this)
            {
                iDRMStateChanged = aDRMStateChanged;
            }
        }

        private void DRMStatePropertyChanged()
        {
            lock (this)
            {
                if (iDRMStateChanged != null)
                {
                    iDRMStateChanged();
                }
            }
        }

        /// <summary>
        /// Query the value of the LastChange property.
        /// </summary>
        /// <remarks>This function is threadsafe and can only be called if Subscribe() has been
        /// called and a first eventing callback received more recently than any call
        /// to Unsubscribe().</remarks>
        /// <param name="aLastChange">Will be set to the value of the property</param>
        public String PropertyLastChange()
        {
            return iLastChange.Value();
        }

        /// <summary>
        /// Query the value of the DRMState property.
        /// </summary>
        /// <remarks>This function is threadsafe and can only be called if Subscribe() has been
        /// called and a first eventing callback received more recently than any call
        /// to Unsubscribe().</remarks>
        /// <param name="aDRMState">Will be set to the value of the property</param>
        public String PropertyDRMState()
        {
            return iDRMState.Value();
        }

        /// <summary>
        /// Must be called for each class instance.  Must be called before Core.Library.Close().
        /// </summary>
        public void Dispose()
        {
            DoDispose(true);
        }

        ~CpProxyUpnpOrgAVTransport2()
        {
            DoDispose(false);
        }

        private void DoDispose(bool aDisposing)
        {
            lock (this)
            {
                if (iHandle == IntPtr.Zero)
                {
                    return;
                }
                DisposeProxy();
                iHandle = IntPtr.Zero;
                iActionSetAVTransportURI.Dispose();
                iActionSetNextAVTransportURI.Dispose();
                iActionGetMediaInfo.Dispose();
                iActionGetMediaInfo_Ext.Dispose();
                iActionGetTransportInfo.Dispose();
                iActionGetPositionInfo.Dispose();
                iActionGetDeviceCapabilities.Dispose();
                iActionGetTransportSettings.Dispose();
                iActionStop.Dispose();
                iActionPlay.Dispose();
                iActionPause.Dispose();
                iActionRecord.Dispose();
                iActionSeek.Dispose();
                iActionNext.Dispose();
                iActionPrevious.Dispose();
                iActionSetPlayMode.Dispose();
                iActionSetRecordQualityMode.Dispose();
                iActionGetCurrentTransportActions.Dispose();
                iActionGetDRMState.Dispose();
                iActionGetStateVariables.Dispose();
                iActionSetStateVariables.Dispose();
            }
            if (aDisposing)
            {
                GC.SuppressFinalize(this);
            }
        }
    }
}

