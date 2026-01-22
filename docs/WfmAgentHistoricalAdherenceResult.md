# WfmAgentHistoricalAdherenceResult

## ININ.PureCloudApi.Model.WfmAgentHistoricalAdherenceResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **User** | [**UserReference**](UserReference) | The user who submitted the agent historical adherence query | [optional] |
| **StartDate** | **DateTime?** | Beginning of the date range that was queried, in ISO-8601 format | |
| **EndDate** | **DateTime?** | End of the date range that was queried, in ISO-8601 format. If it was not set, end date will be set to the queried time | |
| **CalculationsCompletedDate** | **DateTime?** | Completed date of calculations that was queried, in ISO-8601 format. | |
| **TargetAdherencePercentage** | **double?** | Target percentage for this user, in the scale of 0 - 100 | |
| **AdherencePercentage** | **double?** | Adherence percentage for this user, in the scale of 0 - 100 | [optional] |
| **ConformancePercentage** | **double?** | Conformance percentage for this user, in the scale of 0 - 100. Conformance percentage can be greater than 100 when the actual on queue time is greater than the scheduled on queue time for the same period. | [optional] |
| **Impact** | **string** | The impact of the current adherence state for this user | |
| **ExceptionInfo** | [**List&lt;HistoricalAdherenceExceptionInfo&gt;**](HistoricalAdherenceExceptionInfo) | List of adherence exceptions for this user | [optional] |
| **DayMetrics** | [**List&lt;AgentAdherenceDayMetrics&gt;**](AgentAdherenceDayMetrics) | Adherence and conformance metrics for days in query range | |
| **Actuals** | [**List&lt;HistoricalAdherenceActuals&gt;**](HistoricalAdherenceActuals) | List of actual activity with offset for this user | [optional] |
| **ScheduledActivities** | [**List&lt;AgentAdherenceScheduledActivity&gt;**](AgentAdherenceScheduledActivity) | List of scheduled activities for this user | [optional] |
| **SecondaryPresenceLookupItems** | [**List&lt;SecondaryPresenceLookupItem&gt;**](SecondaryPresenceLookupItem) | List of secondary presence lookup ID to corresponding secondary presence ID item | |



_PureCloudPlatform.Client.V2 255.0.0_
