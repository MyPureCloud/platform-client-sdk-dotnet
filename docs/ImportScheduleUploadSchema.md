# ImportScheduleUploadSchema

## ININ.PureCloudApi.Model.ImportScheduleUploadSchema

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Description** | **string** | The description for the imported schedule | |
| **WeekCount** | **int?** | The number of weeks the imported schedule will cover | |
| **Published** | **bool?** | Whether the imported schedule should be immediately published | [optional] |
| **ShortTermForecast** | [**BuShortTermForecastReference**](BuShortTermForecastReference) | The short term forecast to associate with the imported schedule | [optional] |
| **HeadcountForecast** | [**BuHeadcountForecastBuPlanningGroupHeadcountForecastUploadSchema**](BuHeadcountForecastBuPlanningGroupHeadcountForecastUploadSchema) | The headcount forecast to associate with the imported schedule | [optional] |
| **AgentSchedules** | [**List&lt;BuImportAgentScheduleUploadSchema&gt;**](BuImportAgentScheduleUploadSchema) | Individual agent schedules | [optional] |



_PureCloudPlatform.Client.V2 247.0.0_
