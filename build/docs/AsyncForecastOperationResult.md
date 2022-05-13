---
title: AsyncForecastOperationResult
---
## ININ.PureCloudApi.Model.AsyncForecastOperationResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Status** | **string** | The status of the operation | [optional] |
| **OperationId** | **string** | The ID for the operation | [optional] |
| **Result** | [**BuShortTermForecast**](BuShortTermForecast.html) | The result of the operation.  Null unless status &#x3D;&#x3D; Complete | [optional] |
| **Progress** | **int?** | Percent progress for the operation | [optional] |
{: class="table table-striped"}


