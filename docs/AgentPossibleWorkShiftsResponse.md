# AgentPossibleWorkShiftsResponse

## ININ.PureCloudApi.Model.AgentPossibleWorkShiftsResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **WeekStartDate** | **String** | Start date of requested effective work plan. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **Pattern** | **List&lt;int?&gt;** | Each element is the ID of an effective work plan for a specific week | [optional] |
| **WeeklyPossibleWorkShifts** | [**List&lt;PossibleWorkShiftsForWeek&gt;**](PossibleWorkShiftsForWeek) | Each element is a weekly effective work plan that can be used for multiple weeks | [optional] |
| **SchedulerIntervalLengthMinutes** | **int?** | Number of minutes in each interval in the intervalScheduleProbabilities | [optional] |
| **TimeZone** | **string** | The time zone of the business unit | [optional] |



_PureCloudPlatform.Client.V2 222.0.0_
