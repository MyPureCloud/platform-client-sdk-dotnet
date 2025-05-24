# ScheduleGenerationResult

## ININ.PureCloudApi.Model.ScheduleGenerationResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Failed** | **bool?** | Whether the schedule generation run failed | [optional] |
| **RunId** | **string** | The ID of the schedule generation run. Reference this when requesting support | [optional] |
| **MessageCount** | **int?** | The number of schedule generation messages for this schedule generation run | [optional] |
| **Messages** | [**List&lt;ScheduleGenerationMessage&gt;**](ScheduleGenerationMessage) | User facing messages related to the schedule generation run | [optional] |
| **MessageSeverities** | [**List&lt;SchedulerMessageTypeSeverity&gt;**](SchedulerMessageTypeSeverity) | The list of messages by severity in this schedule generation run | [optional] |



_PureCloudPlatform.Client.V2 234.0.0_
