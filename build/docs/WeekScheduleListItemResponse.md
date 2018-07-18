---
title: WeekScheduleListItemResponse
---
## ININ.PureCloudApi.Model.WeekScheduleListItemResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **WeekDate** | **string** | First day of this week schedule in week in yyyy-MM-dd format | [optional] |
| **Description** | **string** | Description of the week schedule | [optional] |
| **Published** | **bool?** | Whether the week schedule is published | [optional] |
| **GenerationResults** | [**WeekScheduleGenerationResult**](WeekScheduleGenerationResult.html) | Summary of the results from the schedule run | [optional] |
| **ShortTermForecast** | [**ShortTermForecastReference**](ShortTermForecastReference.html) | Short term forecast associated with this schedule | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata.html) | Version metadata for this work plan | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


