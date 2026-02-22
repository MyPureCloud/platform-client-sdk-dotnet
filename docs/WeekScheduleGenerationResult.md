# WeekScheduleGenerationResult

## ININ.PureCloudApi.Model.WeekScheduleGenerationResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Failed** | **bool?** | Whether the schedule generation failed | [optional] |
| **RunId** | **string** | ID of the schedule run | [optional] |
| **AgentWarnings** | [**List&lt;ScheduleGenerationWarning&gt;**](ScheduleGenerationWarning) | Warning messages from the schedule run. This will be available only when requesting information for a single week schedule | [optional] |
| **AgentWarningCount** | **int?** | Count of warning messages from the schedule run. This will be available only when requesting multiple week schedules | [optional] |



_PureCloudPlatform.Client.V2 257.0.0_
