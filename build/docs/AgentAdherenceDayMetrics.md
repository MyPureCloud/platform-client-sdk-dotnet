# AgentAdherenceDayMetrics

## ININ.PureCloudApi.Model.AgentAdherenceDayMetrics

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **DayStartOffsetSeconds** | **int?** | Start of day offset in seconds relative to query start time | |
| **AdherenceScheduleSeconds** | **int?** | Duration of schedule in seconds included for adherence percentage calculation | |
| **ConformanceScheduleSeconds** | **int?** | Total scheduled duration in seconds for OnQueue activities | [optional] |
| **ConformanceActualSeconds** | **int?** | Total actually worked duration in seconds for OnQueue activities | [optional] |
| **ExceptionCount** | **int?** | Total number of adherence exceptions for this user | |
| **ExceptionDurationSeconds** | **int?** | Total duration in seconds of adherence exceptions for this user | |
| **ImpactSeconds** | **int?** | The impact duration in seconds of current adherence state for this user | |
| **ScheduleLengthSeconds** | **int?** | Total duration in seconds for all scheduled activities | |
| **ActualLengthSeconds** | **int?** | Total duration in seconds for all actually worked activities | |
| **AdherencePercentage** | **double?** | Total adherence percentage for this user, in the scale of 0 - 100 | [optional] |
| **ConformancePercentage** | **double?** | Total conformance percentage for this user, in the scale of 0 - 100. Conformance percentage can be greater than 100 when the actual on queue time is greater than the scheduled on queue time for the same period. | [optional] |



_PureCloudPlatform.Client.V2 253.0.0_
