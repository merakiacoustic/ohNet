using System;
using System.Runtime.InteropServices;
using System.Text;
using Zapp.Core;
using System.Collections.Generic;

namespace Zapp.Device
{
    /// <summary>
    /// Base class for a service provider.
    /// </summary>
    /// <remarks>Derivations will typically be by service-specific auto-generated code which will
    /// offer 0..n actions and 0..n properties.</remarks>
    public class DvProvider
    {
        [DllImport("ZappUpnp")]
        static extern unsafe IntPtr DvProviderCreate(IntPtr aDevice, char* aDomain, char* aType, uint aVersion);
        [DllImport("ZappUpnp")]
        static extern void DvProviderDestroy(IntPtr aProvider);
        [DllImport("ZappUpnp")]
        static extern void DvProviderAddAction(IntPtr aProvider, IntPtr aAction, ActionDelegate aCallback, IntPtr aPtr);
        [DllImport("ZappUpnp")]
        static extern void DvProviderPropertiesLock(IntPtr aHandle);
        [DllImport("ZappUpnp")]
        static extern void DvProviderPropertiesUnlock(IntPtr aHandle);
        [DllImport("ZappUpnp")]
        static extern void DvProviderAddProperty(IntPtr aProvider, IntPtr aProperty);
        [DllImport("ZappUpnp")]
        static extern unsafe int DvProviderSetPropertyInt(IntPtr aProvider, IntPtr aProperty, int aValue, uint* aChanged);
        [DllImport("ZappUpnp")]
        static extern unsafe int DvProviderSetPropertyUint(IntPtr aProvider, IntPtr aProperty, uint aValue, uint* aChanged);
        [DllImport("ZappUpnp")]
        static extern unsafe int DvProviderSetPropertyBool(IntPtr aProvider, IntPtr aProperty, uint aValue, uint* aChanged);
        [DllImport("ZappUpnp")]
        static extern unsafe int DvProviderSetPropertyString(IntPtr aProvider, IntPtr aProperty, char* aValue, uint* aChanged);
        [DllImport("ZappUpnp")]
        static extern unsafe int DvProviderSetPropertyBinary(IntPtr aProvider, IntPtr aProperty, char* aData, uint aLen, uint* aChanged);

        protected delegate int ActionDelegate(IntPtr aPtr, IntPtr aInvocation, uint aVersion);

        protected IntPtr iHandle;
        private List<Zapp.Core.Action> iActions;
        private List<Zapp.Core.Property> iProperties;

        /// <summary>
        /// Lock the provider's properties, blocking publication of updates.
        /// </summary>
        /// <remarks>This is not necessary when updating a single property but is used by providers that
        /// have >1 properties whose values are related.  Without locking, updates to some properties may
        /// be published, leaving related properties in their old (now incompatible) states.
        /// 
        /// Every call to this must be followed by (exactly) one call to PropertiesUnlock().</remarks>
        public void PropertiesLock()
        {
            DvProviderPropertiesLock(iHandle);
        }

        /// <summary>
        /// Unlock the provider's properties, allowing publication of updates.
        /// </summary>
        /// <remarks>Any pending updates will automatically be scheduled.
        /// 
        /// This must only be called following a call to PropertiesLock().</remarks>
        public void PropertiesUnlock()
        {
            DvProviderPropertiesUnlock(iHandle);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="aDevice">Device the service is being added to and will be offered by</param>
        /// <param name="aDomain">Domain of the vendor who defined the service</param>
        /// <param name="aType">Name of the service</param>
        /// <param name="aVersion">Version number of the service</param>
        protected unsafe DvProvider(DvDevice aDevice, String aDomain, String aType, uint aVersion)
        {
            char* domain = (char*)Marshal.StringToHGlobalAnsi(aDomain);
            char* type = (char*)Marshal.StringToHGlobalAnsi(aType);
            iHandle = DvProviderCreate(aDevice.Handle(), domain, type, aVersion);
            Marshal.FreeHGlobal((IntPtr)type);
            Marshal.FreeHGlobal((IntPtr)domain);
            iActions = new List<Zapp.Core.Action>();
            iProperties = new List<Zapp.Core.Property>();
        }

        /// <summary>
        /// Register an action as available.  The action will be published as part of the owning device's service xml
        /// </summary>
        /// <param name="aAction">Action being registered as availabke</param>
        /// <param name="aDelegate">Delegate to call when the action is invoked</param>
        /// <param name="aPtr">Data to pass to the delegate</param>
        protected void EnableAction(Zapp.Core.Action aAction, ActionDelegate aDelegate, IntPtr aPtr)
        {
            iActions.Add(aAction);
            DvProviderAddAction(iHandle, aAction.Handle(), aDelegate, aPtr);
        }
        
        /// <summary>
        /// Add a property to this provider
        /// </summary>
        /// <remarks>Any later updates to the value of the property will be automatically published to
        /// any subscribers</remarks>
        /// <param name="aProperty">Property being added</param>
        protected void AddProperty(Zapp.Core.Property aProperty)
        {
            DvProviderAddProperty(iHandle, aProperty.Handle());
        }
        
        /// <summary>
        /// Utility function which updates the value of a PropertyInt. (Not intended for external use)
        /// </summary>
        /// <remarks>If the property value has changed and the properties are not locked (PropertiesLock()
        /// called more recently than PropertiesUnlock()), publication of an update is scheduled.
        ///
        /// Throws ParameterValidationError if the property has a range of allowed values and
        /// the new value is not in this range</remarks>
        /// <param name="aProperty">Property to be updated</param>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the property's value has changed (aValue was different to the previous value)</returns>
        protected unsafe bool SetPropertyInt(PropertyInt aProperty, int aValue)
        {
            uint changed;
            int err = DvProviderSetPropertyInt(iHandle, aProperty.Handle(), aValue, &changed);
            if (err != 0)
            {
                throw new PropertyUpdateError();
            }
            return (changed != 0);
        }

        /// <summary>
        /// Utility function which updates the value of a PropertyUint. (Not intended for external use)
        /// </summary>
        /// <remarks>If the property value has changed and the properties are not locked (PropertiesLock()
        /// called more recently than PropertiesUnlock()), publication of an update is scheduled.
        ///
        /// Throws ParameterValidationError if the property has a range of allowed values and
        /// the new value is not in this range</remarks>
        /// <param name="aProperty">Property to be updated</param>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the property's value has changed (aValue was different to the previous value)</returns>
        protected unsafe bool SetPropertyUint(PropertyUint aProperty, uint aValue)
        {
            uint changed;
            int err = DvProviderSetPropertyUint(iHandle, aProperty.Handle(), aValue, &changed);
            if (err != 0)
            {
                throw new PropertyUpdateError();
            }
            return (changed != 0);
        }

        /// <summary>
        /// Utility function which updates the value of a PropertyBool. (Not intended for external use)
        /// </summary>
        /// <remarks>If the property value has changed and the properties are not locked (PropertiesLock()
        /// called more recently than PropertiesUnlock()), publication of an update is scheduled</remarks>
        /// <param name="aProperty">Property to be updated</param>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the property's value has changed (aValue was different to the previous value)</returns>
        protected unsafe bool SetPropertyBool(PropertyBool aProperty, bool aValue)
        {
            uint changed;
            uint val = (aValue ? 1u : 0u);
            int err = DvProviderSetPropertyBool(iHandle, aProperty.Handle(), val, &changed);
            if (err != 0)
            {
                throw new PropertyUpdateError();
            }
            return (changed != 0);
        }

        /// <summary>
        /// Utility function which updates the value of a PropertyString. (Not intended for external use)
        /// </summary>
        /// <remarks>If the property value has changed and the properties are not locked (PropertiesLock()
        /// called more recently than PropertiesUnlock()), publication of an update is scheduled.
        ///
        /// Throws ParameterValidationError if the property has a range of allowed values and
        /// the new value is not in this range</remarks>
        /// <param name="aProperty">Property to be updated</param>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the property's value has changed (aValue was different to the previous value)</returns>
        protected unsafe bool SetPropertyString(PropertyString aProperty, String aValue)
        {
            uint changed;
            char* value = (char*)Marshal.StringToHGlobalAnsi(aValue).ToPointer();
            int err = DvProviderSetPropertyString(iHandle, aProperty.Handle(), value, &changed);
            Marshal.FreeHGlobal((IntPtr)value);
            if (err != 0)
            {
                throw new PropertyUpdateError();
            }
            return (changed != 0);
        }

        /// <summary>
        /// Utility function which updates the value of a PropertyBinary. (Not intended for external use)
        /// </summary>
        /// <remarks>If the property value has changed and the properties are not locked (PropertiesLock()
        /// called more recently than PropertiesUnlock()), publication of an update is scheduled</remarks>
        /// <param name="aProperty">Property to be updated</param>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the property's value has changed (aValue was different to the previous value)</returns>
        protected unsafe bool SetPropertyBinary(PropertyBinary aProperty, String aValue)
        {
            uint changed;
            char* value = (char*)Marshal.StringToHGlobalAnsi(aValue).ToPointer();
            int err = DvProviderSetPropertyBinary(iHandle, aProperty.Handle(), value, (uint)aValue.Length, &changed);
            Marshal.FreeHGlobal((IntPtr)value);
            if (err != 0)
            {
                throw new PropertyUpdateError();
            }
            return (changed != 0);
        }

        /// <summary>
        /// Must be called by each sub-class, preferably from their Dispose() method
        /// </summary>
        protected void DisposeProvider()
        {
            DvProviderDestroy(iHandle);
            iHandle = IntPtr.Zero;
            for (int i = 0; i < iActions.Count; i++)
            {
                iActions[i].Dispose();
            }
            for (int i = 0; i < iProperties.Count; i++)
            {
                iProperties[i].Dispose();
            }
        }
    }

    /// <summary>
    /// Utility class used by providers to read input and write output arguments
    /// </summary>
    /// <remarks>Only intended for use by auto-generated providers</remarks>
    public class DvInvocation
    {
        [DllImport("ZappUpnp")]
        static extern int DvInvocationReadStart(IntPtr aInvocation);
        [DllImport("ZappUpnp")]
        static extern unsafe int DvInvocationReadInt(IntPtr aInvocation, char* aName, int* aValue);
        [DllImport("ZappUpnp")]
        static extern unsafe int DvInvocationReadUint(IntPtr aInvocation, char* aName, uint* aValue);
        [DllImport("ZappUpnp")]
        static extern unsafe int DvInvocationReadBool(IntPtr aInvocation, char* aName, uint* aValue);
        [DllImport("ZappUpnp")]
        static extern unsafe int DvInvocationReadString(IntPtr aInvocation, char* aName, char** aValue);
        [DllImport("ZappUpnp")]
        static extern unsafe int DvInvocationReadBinary(IntPtr aInvocation, char* aName, char** aData, uint* aLen);
        [DllImport("ZappUpnp")]
        static extern int DvInvocationReadEnd(IntPtr aInvocation);
        [DllImport("ZappUpnp")]
        static extern int DvInvocationWriteStart(IntPtr aInvocation);
        [DllImport("ZappUpnp")]
        static extern unsafe int DvInvocationWriteInt(IntPtr aInvocation, char* aName, int aValue);
        [DllImport("ZappUpnp")]
        static extern unsafe int DvInvocationWriteUint(IntPtr aInvocation, char* aName, uint aValue);
        [DllImport("ZappUpnp")]
        static extern unsafe int DvInvocationWriteBool(IntPtr aInvocation, char* aName, uint aValue);
        [DllImport("ZappUpnp")]
        static extern unsafe int DvInvocationWriteStringStart(IntPtr aInvocation, char* aName);
        [DllImport("ZappUpnp")]
        static extern unsafe int DvInvocationWriteString(IntPtr aInvocation, char* aValue);
        [DllImport("ZappUpnp")]
        static extern unsafe int DvInvocationWriteStringEnd(IntPtr aInvocation, char* aName);
        [DllImport("ZappUpnp")]
        static extern unsafe int DvInvocationWriteBinaryStart(IntPtr aInvocation, char* aName);
        [DllImport("ZappUpnp")]
        static extern unsafe int DvInvocationWriteBinary(IntPtr aInvocation, char* aData, uint aLen);
        [DllImport("ZappUpnp")]
        static extern unsafe int DvInvocationWriteBinaryEnd(IntPtr aInvocation, char* aName);
        [DllImport("ZappUpnp")]
        static extern int DvInvocationWriteEnd(IntPtr aInvocation);
        [DllImport("ZappUpnp")]
        static extern unsafe void ZappFree(IntPtr aPtr);

        protected IntPtr iHandle;
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="aHandle">'aInvocation' argument to ActionDelegate</param>
        public DvInvocation(IntPtr aHandle)
        {
            iHandle = aHandle;
        }
        /// <summary>
        /// Begin reading (input arguments for) an invocation
        /// </summary>
        /// <remarks>Must be called before the values of any input arguments are read.
        /// Must be called for invocations with no input arguments.</remarks>
        public void ReadStart()
        {
            CheckError(DvInvocationReadStart(iHandle));
        }
        /// <summary>
        /// Read the value of an integer input argument for an invocation
        /// </summary>
        /// <param name="aName">Name of the parameter associated with this input argument</param>
        /// <returns>Value of the input argument</returns>
        public unsafe int ReadInt(String aName)
        {
            char* name = (char*)Marshal.StringToHGlobalAnsi(aName);
            int val;
            int err = DvInvocationReadInt(iHandle, name, &val);
            Marshal.FreeHGlobal((IntPtr)name);
            CheckError(err);
            return val;
        }
        /// <summary>
        /// Read the value of an unsigned integer input argument for an invocation
        /// </summary>
        /// <param name="aName">Name of the parameter associated with this input argument</param>
        /// <returns>Value of the input argument</returns>
        public unsafe uint ReadUint(String aName)
        {
            char* name = (char*)Marshal.StringToHGlobalAnsi(aName);
            uint val;
            int err = DvInvocationReadUint(iHandle, name, &val);
            Marshal.FreeHGlobal((IntPtr)name);
            CheckError(err);
            return val;
        }
        /// <summary>
        /// Read the value of a boolean input argument for an invocation
        /// </summary>
        /// <param name="aName">Name of the parameter associated with this input argument</param>
        /// <returns>Value of the input argument</returns>
        public unsafe bool ReadBool(String aName)
        {
            char* name = (char*)Marshal.StringToHGlobalAnsi(aName);
            uint val;
            int err = DvInvocationReadBool(iHandle, name, &val);
            Marshal.FreeHGlobal((IntPtr)name);
            CheckError(err);
            return (val != 0);
        }
        /// <summary>
        /// Read the value of a string input argument for an invocation
        /// </summary>
        /// <param name="aName">Name of the parameter associated with this input argument</param>
        /// <returns>Value of the input argument</returns>
        public unsafe String ReadString(String aName)
        {
            char* name = (char*)Marshal.StringToHGlobalAnsi(aName);
            char* cStr;
            int err = DvInvocationReadString(iHandle, name, &cStr);
            Marshal.FreeHGlobal((IntPtr)name);
            String str = Marshal.PtrToStringAnsi((IntPtr)cStr);
            ZappFree((IntPtr)cStr);
            CheckError(err);
            return str;
        }
        /// <summary>
        /// Read the value of a binary input argument for an invocation
        /// </summary>
        /// <param name="aName">Name of the parameter associated with this input argument</param>
        /// <returns>Value of the input argument</returns>
        public unsafe String ReadBinary(String aName)
        {
            char* name = (char*)Marshal.StringToHGlobalAnsi(aName);
            char* data;
            uint len;
            int err = DvInvocationReadBinary(iHandle, name, &data, &len);
            Marshal.FreeHGlobal((IntPtr)name);
            String bin = Marshal.PtrToStringAnsi((IntPtr)data, (int)len);
            ZappFree((IntPtr)data);
            CheckError(err);
            return bin;
        }
        /// <summary>
        /// Complete reading (input arguments for) an invocation
        /// </summary>
        /// <remarks>Must be called after the values of all input arguments are read.
        /// Must be called for invocations with no input arguments.</remarks>
        public void ReadEnd()
        {
            int err = DvInvocationReadEnd(iHandle);
            CheckError(err);
        }
        /// <summary>
        /// Begin reading (output arguments for) an invocation
        /// </summary>
        /// <remarks>Must be called before the values of any output arguments are written.
        /// Must be called for invocations with no output arguments.</remarks>
        public void WriteStart()
        {
            CheckError(DvInvocationWriteStart(iHandle));
        }
        /// <summary>
        /// Set the value of an integer output argument for an invocation.
        /// </summary>
        /// <param name="aName">Name of the parameter associated with this output argument</param>
        /// <param name="aValue">Value of the output argument</param>
        public unsafe void WriteInt(String aName, int aValue)
        {
            char* name = (char*)Marshal.StringToHGlobalAnsi(aName);
            int err = DvInvocationWriteInt(iHandle, name, aValue);
            Marshal.FreeHGlobal((IntPtr)name);
            CheckError(err);
        }
        /// <summary>
        /// Set the value of an unsigned integer output argument for an invocation.
        /// </summary>
        /// <param name="aName">Name of the parameter associated with this output argument</param>
        /// <param name="aValue">Value of the output argument</param>
        public unsafe void WriteUint(String aName, uint aValue)
        {
            char* name = (char*)Marshal.StringToHGlobalAnsi(aName);
            int err = DvInvocationWriteUint(iHandle, name, aValue);
            Marshal.FreeHGlobal((IntPtr)name);
            CheckError(err);
        }
        /// <summary>
        /// Set the value of a boolean output argument for an invocation.
        /// </summary>
        /// <param name="aName">Name of the parameter associated with this output argument</param>
        /// <param name="aValue">Value of the output argument</param>
        public unsafe void WriteBool(String aName, bool aValue)
        {
            char* name = (char*)Marshal.StringToHGlobalAnsi(aName);
            uint val = (aValue? 1u : 0u);
            int err = DvInvocationWriteBool(iHandle, name, val);
            Marshal.FreeHGlobal((IntPtr)name);
            CheckError(err);
        }
        /// <summary>
        /// Set the value of a string output argument for an invocation.
        /// </summary>
        /// <param name="aName">Name of the parameter associated with this output argument</param>
        /// <param name="aValue">Value of the output argument</param>
        public unsafe void WriteString(String aName, String aValue)
        {
            char* name = (char*)Marshal.StringToHGlobalAnsi(aName);
            char* value = (char*)Marshal.StringToHGlobalAnsi(aValue).ToPointer();
            int err = DvInvocationWriteStringStart(iHandle, name);
            if (err == 0)
            {
                err = DvInvocationWriteString(iHandle, value);
            }
            Marshal.FreeHGlobal((IntPtr)value);
            if (err == 0)
            {
                err = DvInvocationWriteStringEnd(iHandle, name);
            }
            Marshal.FreeHGlobal((IntPtr)name);
            CheckError(err);
        }
        /// <summary>
        /// Set the value of a binary output argument for an invocation.
        /// </summary>
        /// <param name="aName">Name of the parameter associated with this output argument</param>
        /// <param name="aValue">Value of the output argument</param>
        public unsafe void WriteBinary(String aName, String aData)
        {
            char* name = (char*)Marshal.StringToHGlobalAnsi(aName);
            char* data = (char*)Marshal.StringToHGlobalAnsi(aData).ToPointer();
            int err = DvInvocationWriteBinaryStart(iHandle, name);
            if (err == 0)
            {
                err = DvInvocationWriteBinary(iHandle, data, (uint)aData.Length);
            }
            Marshal.FreeHGlobal((IntPtr)data);
            if (err == 0)
            {
                err = DvInvocationWriteBinaryEnd(iHandle, name);
            }
            Marshal.FreeHGlobal((IntPtr)name);
            CheckError(err);
        }
        /// <summary>
        /// Complete writing (output arguments for) an invocation
        /// </summary>
        /// <remarks>Must be called after the values of all output arguments are written.
        /// Must be called for invocations with no output arguments.</remarks>
        public void WriteEnd()
        {
            CheckError(DvInvocationWriteEnd(iHandle));
        }
        private void CheckError(int aError)
        {
            if (aError != 0)
            {
                throw (new ActionError());
            }
        }
    }
}
