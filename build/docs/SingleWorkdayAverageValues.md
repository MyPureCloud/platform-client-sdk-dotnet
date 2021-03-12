---
title: SingleWorkdayAverageValues
---
## ININ.PureCloudApi.Model.SingleWorkdayAverageValues

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **DateWorkday** | **String** | The targeted workday for average value query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **Division** | [**Division**](Division.html) | The targeted division for the metrics | [optional] |
| **User** | [**UserReference**](UserReference.html) | The targeted user for the metrics | [optional] |
| **Timezone** | **string** | The time zone used for aggregating metric values | [optional] |
| **Results** | [**List&lt;WorkdayValuesMetricItem&gt;**](WorkdayValuesMetricItem.html) | The metric value averages | [optional] |
{: class="table table-striped"}


