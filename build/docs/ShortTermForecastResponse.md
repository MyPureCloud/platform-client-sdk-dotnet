---
title: ShortTermForecastResponse
---
## ININ.PureCloudApi.Model.ShortTermForecastResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Status** | **string** | The status of the request | [optional] |
| **Result** | [**ShortTermForecast**](ShortTermForecast.html) | The resulting forecast.  May be sent asynchronously via notification depending on the complexity of the forecast | [optional] |
| **OperationId** | **string** | The operation id to watch for on the notification topic | [optional] |
{: class="table table-striped"}


