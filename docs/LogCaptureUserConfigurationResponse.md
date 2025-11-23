# LogCaptureUserConfigurationResponse

## ININ.PureCloudApi.Model.LogCaptureUserConfigurationResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The ID of the user for which log capture is configured. | [optional] |
| **DateStarted** | **DateTime?** | Indicates when log capture was enabled for the user. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateExpired** | **DateTime?** | Indicates when log capture will be turned off for the user. (Must be within 24 hours). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 249.0.0_
