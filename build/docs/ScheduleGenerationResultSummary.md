---
title: ScheduleGenerationResultSummary
---
## ININ.PureCloudApi.Model.ScheduleGenerationResultSummary

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Failed** | **bool?** | Whether the schedule generation run failed | [optional] |
| **RunId** | **string** | The ID of the schedule generation run. Reference this when requesting support | [optional] |
| **MessageCount** | **int?** | The number of schedule generation messages for this schedule generation run | [optional] |
| **MessageSeverityCounts** | [**List&lt;SchedulerMessageSeverityCount&gt;**](SchedulerMessageSeverityCount.html) | The list of schedule generation message counts by severity for this schedule generation run | [optional] |
{: class="table table-striped"}


