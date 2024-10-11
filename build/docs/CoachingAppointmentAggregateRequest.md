# CoachingAppointmentAggregateRequest

## ININ.PureCloudApi.Model.CoachingAppointmentAggregateRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Interval** | **string** | Interval to aggregate across. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | |
| **Metrics** | **List&lt;string&gt;** | A list of metrics to aggregate.  If omitted, all metrics are returned. | [optional] |
| **GroupBy** | **List&lt;string&gt;** | An optional list of items by which to group the result data. | [optional] |
| **Filter** | [**QueryRequestFilter**](QueryRequestFilter) | The filter applied to the data | |



_PureCloudPlatform.Client.V2 218.0.0_
