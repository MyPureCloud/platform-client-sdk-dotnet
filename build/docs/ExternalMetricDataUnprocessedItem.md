---
title: ExternalMetricDataUnprocessedItem
---
## ININ.PureCloudApi.Model.ExternalMetricDataUnprocessedItem

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **UserId** | **string** | The user ID. Must provide either userId or userEmail, but not both. | [optional] |
| **UserEmail** | **string** | The user main email used in user&#39;s GenesysCloud account. Must provide either userId or userEmail, but not both. | [optional] |
| **MetricId** | **string** | The ID of the external metric definition | |
| **DateOccurred** | **String** | The date of the metric data. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **Value** | **double?** | The value of the metric data. When value is null, the metric data will be deleted. | |
| **Count** | **int?** | The number of data points. The default value is 1. | [optional] |
| **Message** | **string** | The error message | [optional] |
| **Code** | **string** | The error code | [optional] |
{: class="table table-striped"}


