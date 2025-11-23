# PerformancePredictionRecalculationResponse

## ININ.PureCloudApi.Model.PerformancePredictionRecalculationResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **OperationId** | **string** | The operationId for which to listen | |
| **DownloadUrl** | **string** | The url to GET the results of the performance prediction. This field is populated only if query state is &#39;Complete&#39; | [optional] |
| **DownloadResult** | [**PerformancePredictionOutputs**](PerformancePredictionOutputs) | Result will always come via downloadUrls; however the schema is included for documentation | [optional] |
| **State** | **string** | The state of the performance prediction | |



_PureCloudPlatform.Client.V2 249.0.0_
