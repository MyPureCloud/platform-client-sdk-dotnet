---
title: WorkdayPointsTrend
---
## ININ.PureCloudApi.Model.WorkdayPointsTrend

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **DateStartWorkday** | **String** | The start workday for the query range for the gamification points trend. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **DateEndWorkday** | **String** | The end workday for the query range for the gamification points trend. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **User** | [**UserReference**](UserReference.html) | The targeted user for the query | [optional] |
| **DayOfWeek** | **string** | Aggregated for same day comparison | [optional] |
| **AveragePoints** | **double?** | The total average points | [optional] |
| **Trend** | [**List&lt;WorkdayPointsTrendItem&gt;**](WorkdayPointsTrendItem.html) | Daily points trends | [optional] |
{: class="table table-striped"}


