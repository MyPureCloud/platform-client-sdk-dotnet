---
title: DomainLogicalInterface
---
## ININ.PureCloudApi.Model.DomainLogicalInterface

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the entity. | |
| **Division** | [**Division**](Division.html) | The division to which this entity belongs. | [optional] |
| **Description** | **string** | The resource&#39;s description. | [optional] |
| **Version** | **int?** | The current version of the resource. | [optional] |
| **DateCreated** | **DateTime?** | The date the resource was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedBy** | **string** | The ID of the user that last modified the resource. | [optional] |
| **CreatedBy** | **string** | The ID of the user that created the resource. | [optional] |
| **State** | **string** | Indicates if the resource is active, inactive, or deleted. | [optional] |
| **ModifiedByApp** | **string** | The application that last modified the resource. | [optional] |
| **CreatedByApp** | **string** | The application that created the resource. | [optional] |
| **EdgeUri** | **string** |  | [optional] |
| **EdgeAssignedId** | **string** |  | [optional] |
| **FriendlyName** | **string** | Friendly Name | |
| **VlanTagId** | **int?** |  | [optional] |
| **HardwareAddress** | **string** | Hardware Address | |
| **PhysicalAdapterId** | **string** | Physical Adapter Id | |
| **IfStatus** | **string** |  | [optional] |
| **InterfaceType** | **string** | The type of this network interface. | [optional] |
| **PublicNatAddressIpV4** | **string** | IPv4 NENT IP Address | [optional] |
| **PublicNatAddressIpV6** | **string** | IPv6 NENT IP Address | [optional] |
| **Routes** | [**List&lt;DomainNetworkRoute&gt;**](DomainNetworkRoute.html) | The list of routes assigned to this interface. | [optional] |
| **Addresses** | [**List&lt;DomainNetworkAddress&gt;**](DomainNetworkAddress.html) | The list of IP addresses on this interface.  Priority of dns addresses are based on order in the list. | [optional] |
| **Ipv4Capabilities** | [**DomainCapabilities**](DomainCapabilities.html) | IPv4 interface settings. | [optional] |
| **Ipv6Capabilities** | [**DomainCapabilities**](DomainCapabilities.html) | IPv6 interface settings. | [optional] |
| **CurrentState** | **string** |  | [optional] |
| **LastModifiedUserId** | **string** |  | [optional] |
| **LastModifiedCorrelationId** | **string** |  | [optional] |
| **CommandResponses** | [**List&lt;DomainNetworkCommandResponse&gt;**](DomainNetworkCommandResponse.html) |  | [optional] |
| **InheritPhoneTrunkBasesIPv4** | **bool?** | The IPv4 phone trunk base assignment will be inherited from the Edge Group. | [optional] |
| **InheritPhoneTrunkBasesIPv6** | **bool?** | The IPv6 phone trunk base assignment will be inherited from the Edge Group. | [optional] |
| **UseForInternalEdgeCommunication** | **bool?** | This interface will be used for all internal edge-to-edge communication using settings from the edgeTrunkBaseAssignment on the Edge Group. | [optional] |
| **UseForIndirectEdgeCommunication** | **bool?** | Site Interconnects using the \&quot;Indirect\&quot; method will communicate using the Public IP Address specified on the interface. Use this option when a NAT enabled firewall is between the Edge and the far end. | [optional] |
| **UseForCloudProxyEdgeCommunication** | **bool?** | Site Interconnects using the \&quot;Cloud Proxy\&quot; method will broker the connection between them with a Cloud Proxy. This method is required for connections between one or more Sites using Cloud Media, but can optionally be used between two premises Sites if Direct or Indirect are not an option. | [optional] |
| **UseForWanInterface** | **bool?** | This interface will be used for all communication with the internet. | [optional] |
| **ExternalTrunkBaseAssignments** | [**List&lt;TrunkBaseAssignment&gt;**](TrunkBaseAssignment.html) | External trunk base settings to use for external communication from this interface. | [optional] |
| **PhoneTrunkBaseAssignments** | [**List&lt;TrunkBaseAssignment&gt;**](TrunkBaseAssignment.html) | Phone trunk base settings to use for phone communication from this interface.  These settings will be ignored when \&quot;inheritPhoneTrunkBases\&quot; is true. | [optional] |
| **TraceEnabled** | **bool?** |  | [optional] |
| **StartDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **EndDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


