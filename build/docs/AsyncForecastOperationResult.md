# AsyncForecastOperationResult

## ININ.PureCloudApi.Model.AsyncForecastOperationResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Status** | **string** | The status of the operation | [optional] |
| **OperationId** | **string** | The ID for the operation | [optional] |
| **Result** | [**BuShortTermForecast**](BuShortTermForecast) | The result of the operation.  Null unless status &#x3D;&#x3D; Complete | [optional] |
| **Progress** | **int?** | Percent progress for the operation | [optional] |



_PureCloudPlatform.Client.V2 227.0.0_
