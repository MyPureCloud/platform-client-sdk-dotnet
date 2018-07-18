---
title: ImportShortTermForecastRequest
---
## ININ.PureCloudApi.Model.ImportShortTermForecastRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **FileName** | **string** | The file name, if applicable, this data was extracted from (display purposes only) | [optional] |
| **Description** | **string** | Description for the imported forecast.  Pass an empty string for no description | |
| **RouteGroupList** | [**RouteGroupList**](RouteGroupList.html) | The raw data to import | |
| **PartialUploadIds** | **List&lt;string&gt;** | IDs of partial uploads to include in this imported forecast.  Only relevant for large forecasts | [optional] |
{: class="table table-striped"}


