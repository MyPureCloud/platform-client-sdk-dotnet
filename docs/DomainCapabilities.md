# DomainCapabilities

## ININ.PureCloudApi.Model.DomainCapabilities

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Enabled** | **bool?** | True if this address family on the interface is enabled. | [optional] |
| **Dhcp** | **bool?** | True if this address family on the interface is using DHCP. | [optional] |
| **Metric** | **int?** | The metric being used for the address family on this interface. Lower values will have a higher priority. If autoMetric is true, this value will be the automatically calculated metric. To set this value be sure autoMetric is false. If no value is returned, metric configuration is not supported on this Edge. | [optional] |
| **AutoMetric** | **bool?** | True if the metric is being calculated automatically for the address family on this interface. | [optional] |
| **SupportsMetric** | **bool?** | True if metric configuration is supported. | [optional] |
| **PingEnabled** | **bool?** | Set to true to enable this address family on this interface to respond to ping requests. | [optional] |



_PureCloudPlatform.Client.V2 222.0.0_
