---
title: ScheduleGenerationResult
---
## ININ.PureCloudApi.Model.ScheduleGenerationResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Failed** | **bool?** | Whether the schedule generation run failed | [optional] |
| **RunId** | **string** | The ID of the schedule generation run. Reference this when requesting support | [optional] |
| **MessageCount** | **int?** | The number of schedule generation messages for this schedule generation run | [optional] |
| **Messages** | [**List&lt;ScheduleGenerationMessage&gt;**](ScheduleGenerationMessage.html) | User facing messages related to the schedule generation run | [optional] |
{: class="table table-striped"}


