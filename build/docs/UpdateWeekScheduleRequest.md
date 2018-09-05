---
title: UpdateWeekScheduleRequest
---
## ININ.PureCloudApi.Model.UpdateWeekScheduleRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Description** | **string** | Description of the week schedule | [optional] |
| **Published** | **bool?** | Whether the week schedule is published | [optional] |
| **UserSchedules** | [**Dictionary&lt;string, UserSchedule&gt;**](UserSchedule.html) | User schedules in the week | [optional] |
| **PartialUploadIds** | **List&lt;string&gt;** | IDs of partial uploads to include in this imported schedule. It is applicable only for large schedules where activity count in schedule is greater than 17500 | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata.html) | Version metadata for this work plan | |
| **AgentSchedulesVersion** | **int?** | Version of agent schedules in the week schedule | |
| **AgentUpdateFilter** | **string** | The condition to notify agents about schedule updates. Applicable to only published schedule | [optional] |
{: class="table table-striped"}


