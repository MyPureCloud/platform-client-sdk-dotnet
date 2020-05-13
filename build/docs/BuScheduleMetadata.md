---
title: BuScheduleMetadata
---
## ININ.PureCloudApi.Model.BuScheduleMetadata

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **WeekDate** | **DateTime?** | The start week date for this schedule. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **WeekCount** | **int?** | The number of weeks spanned by this schedule | [optional] |
| **Description** | **string** | The description of this schedule | [optional] |
| **Published** | **bool?** | Whether this schedule is published | [optional] |
| **ShortTermForecast** | [**BuShortTermForecastReference**](BuShortTermForecastReference.html) | The forecast used for this schedule, if applicable | [optional] |
| **GenerationResults** | [**ScheduleGenerationResultSummary**](ScheduleGenerationResultSummary.html) | Generation result summary for this schedule, if applicable | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata.html) | Version metadata for this schedule | [optional] |
| **ManagementUnits** | [**List&lt;BuManagementUnitScheduleSummary&gt;**](BuManagementUnitScheduleSummary.html) | High level per-management unit schedule metadata | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


