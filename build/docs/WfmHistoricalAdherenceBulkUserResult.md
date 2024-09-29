# WfmHistoricalAdherenceBulkUserResult

## ININ.PureCloudApi.Model.WfmHistoricalAdherenceBulkUserResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **UserId** | **string** | The ID of the user for whom the adherence is queried | [optional] |
| **AdherencePercentage** | **double?** | Adherence percentage for this user, in the scale of 0 - 100 | [optional] |
| **ConformancePercentage** | **double?** | Conformance percentage for this user, in the scale of 0 - 100. Conformance percentage can be greater than 100 when the actual on queue time is greater than the scheduled on queue time for the same period. | [optional] |
| **Impact** | **string** | The impact of the current adherence state for this user | [optional] |
| **ExceptionInfo** | [**List&lt;HistoricalAdherenceExceptionInfo&gt;**](HistoricalAdherenceExceptionInfo) | List of adherence exceptions for this user | [optional] |
| **Actuals** | [**List&lt;HistoricalAdherenceActuals&gt;**](HistoricalAdherenceActuals) | List of adherence actuals for this user | [optional] |
| **DayMetrics** | [**List&lt;WfmHistoricalAdherenceBulkUserDayMetrics&gt;**](WfmHistoricalAdherenceBulkUserDayMetrics) | Adherence and conformance metrics for days in query range | [optional] |



_PureCloudPlatform.Client.V2 216.0.0_
