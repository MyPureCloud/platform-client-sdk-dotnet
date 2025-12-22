# PerformancePredictionResponse

## ININ.PureCloudApi.Model.PerformancePredictionResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **WeekDate** | **String** | The weekDate of the short term forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **ScheduleId** | **string** | The ID of the schedule this performance prediction is associated with | |
| **DownloadUrl** | **string** | The url to GET the results of the performance prediction. This field is populated only if query state is &#39;Complete&#39; | [optional] |
| **DownloadResult** | [**PerformancePredictionOutputs**](PerformancePredictionOutputs) | Result will always come via downloadUrls; however the schema is included for documentation | [optional] |
| **State** | **string** | The state of the performance prediction | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 252.0.0_
