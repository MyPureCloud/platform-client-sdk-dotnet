# WfmHistoricalAdherenceBulkUserDayMetrics

## ININ.PureCloudApi.Model.WfmHistoricalAdherenceBulkUserDayMetrics

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **DayStartOffsetSeconds** | **int?** | Start of day offset in seconds relative to query start time | [optional] |
| **AdherenceScheduleSeconds** | **int?** | Duration of schedule in seconds included for adherence percentage calculation | [optional] |
| **ConformanceScheduleSeconds** | **int?** | Total scheduled duration in seconds for OnQueue activities | [optional] |
| **ConformanceActualSeconds** | **int?** | Total actually worked duration in seconds for OnQueue activities | [optional] |
| **ExceptionCount** | **int?** | Total number of adherence exceptions for this user | [optional] |
| **ExceptionDurationSeconds** | **int?** | Total duration in seconds of adherence exceptions for this user | [optional] |
| **ImpactSeconds** | **int?** | The impact duration in seconds of current adherence state for this user | [optional] |
| **ScheduleLengthSeconds** | **int?** | Total duration in seconds for all scheduled activities | [optional] |
| **ActualLengthSeconds** | **int?** | Total duration in seconds for all actually worked activities | [optional] |
| **AdherencePercentage** | **double?** | Total adherence percentage for this user, in the scale of 0 - 100 | [optional] |
| **ConformancePercentage** | **double?** | Total conformance percentage for this user, in the scale of 0 - 100. Conformance percentage can be greater than 100 when the actual on queue time is greater than the scheduled on queue time for the same period. | [optional] |



_PureCloudPlatform.Client.V2 220.0.0_
