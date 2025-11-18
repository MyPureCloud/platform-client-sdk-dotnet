# ScheduleGenerationResultSummary

## ININ.PureCloudApi.Model.ScheduleGenerationResultSummary

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Failed** | **bool?** | Whether the schedule generation run failed | [optional] |
| **RunId** | **string** | The ID of the schedule generation run. Reference this when requesting support | [optional] |
| **MessageCount** | **int?** | The number of schedule generation messages for this schedule generation run | [optional] |
| **MessageSeverityCounts** | [**List&lt;SchedulerMessageSeverityCount&gt;**](SchedulerMessageSeverityCount) | The list of schedule generation message counts by severity for this schedule generation run | [optional] |



_PureCloudPlatform.Client.V2 248.0.0_
