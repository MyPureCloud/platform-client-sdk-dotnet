---
title: BuShortTermForecast
---
## ININ.PureCloudApi.Model.BuShortTermForecast

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **WeekDate** | **String** | The start week date of this forecast in yyyy-MM-dd.  Must fall on the start day of week for the associated business unit. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **WeekCount** | **int?** | The number of weeks this forecast covers | [optional] |
| **CreationMethod** | **string** | The method by which this forecast was created | [optional] |
| **Description** | **string** | The description of this forecast | [optional] |
| **Legacy** | **bool?** | Whether this forecast contains modifications on legacy metrics | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata.html) | Metadata for this forecast | [optional] |
| **ReferenceStartDate** | **DateTime?** | The reference start date for interval-based data for this forecast. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SourceDays** | [**List&lt;ForecastSourceDayPointer&gt;**](ForecastSourceDayPointer.html) | The source day pointers for this forecast | [optional] |
| **Modifications** | [**List&lt;BuForecastModification&gt;**](BuForecastModification.html) | Any manual modifications applied to this forecast | [optional] |
| **GenerationResults** | [**BuForecastGenerationResult**](BuForecastGenerationResult.html) | Generation result metadata | [optional] |
| **TimeZone** | **string** | The time zone for this forecast | [optional] |
| **PlanningGroupsVersion** | **int?** | The version of the planning groups that was used for this forecast | [optional] |
| **PlanningGroups** | [**ForecastPlanningGroupsResponse**](ForecastPlanningGroupsResponse.html) | A snapshot of the planning groups used for this forecast as of the version number indicated | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


