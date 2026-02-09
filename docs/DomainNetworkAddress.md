# DomainNetworkAddress

## ININ.PureCloudApi.Model.DomainNetworkAddress

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | The type of address. | [optional] |
| **Address** | **string** | An IPv4 or IPv6 IP address. When specifying an address of type \&quot;ip\&quot;, use CIDR format for the subnet mask. | [optional] |
| **Persistent** | **bool?** | True if this address will persist on Edge restart.  Addresses assigned by DHCP will be returned as false. | [optional] |
| **Family** | **int?** | The address family for this address. | [optional] |



_PureCloudPlatform.Client.V2 256.0.0_
