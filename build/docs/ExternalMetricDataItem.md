# ExternalMetricDataItem

## ININ.PureCloudApi.Model.ExternalMetricDataItem

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **UserId** | **string** | The user ID. Must provide either userId or userEmail, but not both. | [optional] |
| **UserEmail** | **string** | The user main email used in user&#39;s GenesysCloud account. Must provide either userId or userEmail, but not both. | [optional] |
| **MetricId** | **string** | The ID of the external metric definition | |
| **DateOccurred** | **String** | The date of the metric data. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **Value** | **double?** | The value of the metric data. When value is null, the metric data will be deleted. | |
| **Count** | **int?** | The number of data points. The default value is 0 when type is Cumulative and the metric data already exists, otherwise 1. When total count reaches 0, the metric data will be deleted. | [optional] |
| **Type** | **string** | The type of the metric data. The default value is Total. | [optional] |



_PureCloudPlatform.Client.V2 228.0.0_
