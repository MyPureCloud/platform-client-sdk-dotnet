---
title: GenerateShortTermForecastResponse
---
## ININ.PureCloudApi.Model.GenerateShortTermForecastResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Status** | **string** | The status of the request | [optional] |
| **Result** | [**ShortTermForecast**](ShortTermForecast.html) | The resulting forecast.  May be sent asynchronously via notification depending on the complexity of the forecast | [optional] |
| **OperationId** | **string** | The operation id to watch for on the notification topic | [optional] |
| **Progress** | **int?** | Percent progress.  Subscribe to the corresponding notification to view progress and await the result | [optional] |
{: class="table table-striped"}


