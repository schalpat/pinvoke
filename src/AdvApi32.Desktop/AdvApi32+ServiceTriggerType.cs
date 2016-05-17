﻿// Copyright (c) to owners found in https://github.com/AArnott/pinvoke/blob/master/COPYRIGHT.md. All rights reserved.
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.

namespace PInvoke
{
    /// <content>
    /// Contains the <see cref="ServiceTriggerType"/> nested type.
    /// </content>
    public static partial class AdvApi32
    {
        public enum ServiceTriggerType
        {
            /// <summary>
            /// The event is triggered when a device of the specified device interface class arrives or is present when the system starts. This trigger event is commonly used to start a service.
            /// The pTriggerSubtype member specifies the device interface class GUID. These GUIDs are defined in device-specific header files provided with the Windows Driver Kit(WDK).
            /// The pDataItems member specifies one or more hardware ID and compatible ID strings for the device interface class. Strings must be Unicode.If more than one string is specified, the event is triggered if any one of the strings match. For example, the Wpdbusenum service is started when a device of device interface class GUID_DEVINTERFACE_DISK {53f56307-b6bf-11d0-94f2-00a0c91efb8b }
            /// and a hardware ID string of "USBSTOR\GenDisk" arrives.
            /// </summary>
            SERVICE_TRIGGER_TYPE_DEVICE_INTERFACE_ARRIVAL = 1,

            /// <summary>
            /// The event is triggered when the first IP address on the TCP/IP networking stack becomes available or the last IP address on the stack becomes unavailable. This trigger event can be used to start or stop a service.
            /// The pTriggerSubtype member specifies NETWORK_MANAGER_FIRST_IP_ADDRESS_ARRIVAL_GUID or NETWORK_MANAGER_LAST_IP_ADDRESS_REMOVAL_GUID.
            /// The pDataItems member is not used.
            /// </summary>
            SERVICE_TRIGGER_TYPE_IP_ADDRESS_AVAILABILITY = 2,

            /// <summary>
            /// The event is triggered when the computer joins or leaves a domain. This trigger event can be used to start or stop a service.
            /// The pTriggerSubtype member specifies DOMAIN_JOIN_GUID or DOMAIN_LEAVE_GUID.
            /// The pDataItems member is not used.
            /// </summary>
            SERVICE_TRIGGER_TYPE_DOMAIN_JOIN = 3,

            /// <summary>
            /// The event is triggered when a firewall port is opened or approximately 60 seconds after the firewall port is closed. This trigger event can be used to start or stop a service.
            /// The pTriggerSubtype member specifies FIREWALL_PORT_OPEN_GUID or FIREWALL_PORT_CLOSE_GUID.
            /// The pDataItems member specifies the port, the protocol, and optionally the executable path and user information (SID string or name) of the service listening on the event. The "RPC" token can be used in place of the port to specify any listening socket used by RPC. The "system" token can be used in place of the executable path to specify ports created by and listened on by the Windows kernel.
            /// The event is triggered only if all strings match. For example, if MyService hosted inside MyServiceProcess.exe is to be trigger-started when port UDP 5001 opens, the trigger-specific data would be the Unicode representation of "5001\0UDP\0%programfiles%\MyApplication\MyServiceProcess.exe\0MyService\0\0".
            /// </summary>
            SERVICE_TRIGGER_TYPE_FIREWALL_PORT_EVENT = 4,

            /// <summary>
            /// The event is triggered when a machine policy or user policy change occurs. This trigger event is commonly used to start a service.
            /// The pTriggerSubtype member specifies MACHINE_POLICY_PRESENT_GUID or USER_POLICY_PRESENT_GUID.
            /// The pDataItems member is not used.
            /// </summary>
            SERVICE_TRIGGER_TYPE_GROUP_POLICY = 5,

            /// <summary>
            /// The event is triggered when a packet or request arrives on a particular network protocol. This request is commonly used to start a service that has stopped itself after an idle time-out when there is no work to do.
            /// Windows 7 and Windows Server 2008 R2:  This trigger type is not supported until Windows 8 and Windows Server 2012.
            /// The pTriggerSubtype member specifies one of the following values: RPC_INTERFACE_EVENT_GUID, NAMED_PIPE_EVENT_GUID, TCP_PORT_EVENT_GUID, or UDP_EVENT_PORT_GUID.
            /// The pDataItems member specifies an endpoint or interface GUID. The string must be Unicode.The event triggers if the string is an exact match.
            /// The dwAction member must be SERVICE_TRIGGER_ACTION_SERVICE_START.
            /// </summary>
            SERVICE_TRIGGER_TYPE_NETWORK_ENDPOINT = 6,

            /// <summary>
            /// The event is a custom event generated by an Event Tracing for Windows (ETW) provider.
            /// This trigger event can be used to start or stop a service.
            /// The pTriggerSubtype member specifies the event provider's GUID.
            /// The pDataItems member specifies trigger-specific data defined by the provider.
            /// </summary>
            SERVICE_TRIGGER_TYPE_CUSTOM = 20
        }
    }
}
