# LogCaptureUserConfigurationResponse

## ININ.PureCloudApi.Model.LogCaptureUserConfigurationResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **DateStarted** | **DateTime?** | Indicates when log capture was enabled for the user. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateExpired** | **DateTime?** | Indicates when log capture will be turned off for the user. (Must be within 24 hours). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 237.0.0_
