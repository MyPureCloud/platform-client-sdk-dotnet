# TimeOffLimitRange

## ININ.PureCloudApi.Model.TimeOffLimitRange

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **StartDate** | **String** | Start date of the range. The end date is determined by &#39;granularity&#39; and the size of &#39;limitMinutesPerInterval&#39;. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **Granularity** | **string** | Granularity choice for the time off limit | |
| **LimitMinutesPerInterval** | **List&lt;int?&gt;** | The list of time off limit values in minutes per granularity interval. If &#39;null&#39; is specified, then interval specific value is cleared. Such interval will have &#39;defaultLimitMinutes&#39; value | |



_PureCloudPlatform.Client.V2 238.0.0_
