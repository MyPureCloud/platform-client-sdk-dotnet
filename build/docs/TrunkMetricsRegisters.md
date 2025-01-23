# TrunkMetricsRegisters

## ININ.PureCloudApi.Model.TrunkMetricsRegisters

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ProxyAddress** | **string** | Server proxy address that this registers array element represents. | [optional] |
| **RegisterState** | **bool?** | True if last REGISTER message had positive response; false if error response or no response. | [optional] |
| **RegisterStateTime** | **DateTime?** | ISO 8601 format UTC absolute date &amp; time of the last change of the register state. | [optional] |
| **ErrorInfo** | [**TrunkErrorInfo**](TrunkErrorInfo) |  | [optional] |



_PureCloudPlatform.Client.V2 225.0.0_
