# UpdateScheduleUploadSchema

## ININ.PureCloudApi.Model.UpdateScheduleUploadSchema

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Description** | **string** | The description to set for the schedule | [optional] |
| **Published** | **bool?** | Whether to publish the schedule. Note: a schedule cannot be un-published unless another schedule is published over it | [optional] |
| **ShortTermForecast** | [**BuShortTermForecastReference**](BuShortTermForecastReference) | The short term forecast to associate with the schedule | [optional] |
| **HeadcountForecast** | [**BuHeadcountForecastBuPlanningGroupHeadcountForecastUploadSchema**](BuHeadcountForecastBuPlanningGroupHeadcountForecastUploadSchema) | The headcount forecast to associate with the schedule | [optional] |
| **AgentSchedules** | [**List&lt;BuUpdateAgentScheduleUploadSchema&gt;**](BuUpdateAgentScheduleUploadSchema) | Individual agent schedules | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Version metadata for this schedule | |



_PureCloudPlatform.Client.V2 246.0.0_
