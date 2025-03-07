# BuRescheduleResult

## ININ.PureCloudApi.Model.BuRescheduleResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **GenerationResults** | [**ScheduleGenerationResult**](ScheduleGenerationResult) | The generation results.  Note the result will always be delivered via the generationResultsDownloadUrl; however the schema is included for documentation | [optional] |
| **GenerationResultsDownloadUrl** | **string** | The download URL from which to fetch the generation results for the rescheduling run | [optional] |
| **HeadcountForecast** | [**BuHeadcountForecast**](BuHeadcountForecast) | The headcount forecast.  Note the result will always be delivered via the headcountForecastDownloadUrl; however the schema is included for documentation | [optional] |
| **HeadcountForecastDownloadUrl** | **string** | The download URL from which to fetch the headcount forecast for the rescheduling run | [optional] |
| **AgentSchedules** | [**List&lt;BuRescheduleAgentScheduleResult&gt;**](BuRescheduleAgentScheduleResult) | List of download links for agent schedules produced by the rescheduling run | [optional] |



_PureCloudPlatform.Client.V2 228.0.0_
