# HistoricalAdherenceQueryResult

## ININ.PureCloudApi.Model.HistoricalAdherenceQueryResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **UserId** | **string** | The ID of the user for whom the adherence is queried | [optional] |
| **ManagementUnitId** | **string** | The ID of the management unit of the user for whom the adherence is queried | [optional] |
| **StartDate** | **DateTime?** | Beginning of the date range that was queried, in ISO-8601 format | [optional] |
| **EndDate** | **DateTime?** | End of the date range that was queried, in ISO-8601 format. If it was not set, end date will be set to the queried time | [optional] |
| **AdherencePercentage** | **double?** | Adherence percentage for this user, in the scale of 0 - 100 | [optional] |
| **ConformancePercentage** | **double?** | Conformance percentage for this user, in the scale of 0 - 100. Conformance percentage can be greater than 100 when the actual on queue time is greater than the scheduled on queue time for the same period. | [optional] |
| **Impact** | **string** | The impact of the current adherence state for this user | [optional] |
| **ExceptionInfo** | [**List&lt;HistoricalAdherenceExceptionInfo&gt;**](HistoricalAdherenceExceptionInfo) | List of adherence exceptions for this user | [optional] |
| **DayMetrics** | [**List&lt;HistoricalAdherenceDayMetrics&gt;**](HistoricalAdherenceDayMetrics) | Adherence and conformance metrics for days in query range | [optional] |
| **ActualsEndDate** | **DateTime?** | The end date of the actual activities in ISO-8601 format. | [optional] |
| **Actuals** | [**List&lt;HistoricalAdherenceActuals&gt;**](HistoricalAdherenceActuals) | List of actual activity with offset for this user | [optional] |



_PureCloudPlatform.Client.V2 226.0.0_
