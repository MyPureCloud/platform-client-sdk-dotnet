# TrunkBaseMetrics

## ININ.PureCloudApi.Model.TrunkBaseMetrics

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **TrunkBase** | [**AddressableEntityRef**](AddressableEntityRef) | TrunkBase resource identifier | |
| **TrunkType** | **string** | The type of the TrunkBase | [optional] |
| **InboundCallCount** | **int?** | The number of inbound calls | [optional] |
| **OutboundCallCount** | **int?** | The number of outbound calls | [optional] |
| **EventTime** | **DateTime?** | The timestamp of the data publication. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **QosMismatchCount** | **int?** | The number of QoS mismatch events | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 277.0.0_
