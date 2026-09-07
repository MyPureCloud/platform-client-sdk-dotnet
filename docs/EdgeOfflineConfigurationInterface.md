# EdgeOfflineConfigurationInterface

## ININ.PureCloudApi.Model.EdgeOfflineConfigurationInterface

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Routes** | [**List&lt;DomainNetworkRoute&gt;**](DomainNetworkRoute) | The list of routes assigned to this interface. | [optional] |
| **Addresses** | [**List&lt;DomainNetworkAddress&gt;**](DomainNetworkAddress) | The list of IP addresses on this interface.  Priority of dns addresses are based on order in the list. | [optional] |
| **Ipv4Capabilities** | [**DomainCapabilities**](DomainCapabilities) | IPv4 interface settings. | [optional] |
| **Ipv6Capabilities** | [**DomainCapabilities**](DomainCapabilities) | IPv6 interface settings. | [optional] |



_PureCloudPlatform.Client.V2 272.0.0_
