# DomainNetworkRoute

## ININ.PureCloudApi.Model.DomainNetworkRoute

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Prefix** | **string** | The IPv4 or IPv6 route prefix in CIDR notation. | [optional] |
| **Nexthop** | **string** | The IPv4 or IPv6 nexthop IP address. | [optional] |
| **Persistent** | **bool?** | True if this route will persist on Edge restart.  Routes assigned by DHCP will be returned as false. | [optional] |
| **Metric** | **int?** | The metric being used for route. Lower values will have a higher priority. | [optional] |
| **Family** | **int?** | The address family for this route. | [optional] |



_PureCloudPlatform.Client.V2 228.0.0_
