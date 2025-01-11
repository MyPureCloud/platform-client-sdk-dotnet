# WeekSchedule

## ININ.PureCloudApi.Model.WeekSchedule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **WeekDate** | **string** | First day of this week schedule in yyyy-MM-dd format | [optional] |
| **Description** | **string** | Description of the week schedule | [optional] |
| **Published** | **bool?** | Whether the week schedule is published | [optional] |
| **GenerationResults** | [**WeekScheduleGenerationResult**](WeekScheduleGenerationResult) | Summary of the results from the schedule run | [optional] |
| **ShortTermForecast** | [**ShortTermForecastReference**](ShortTermForecastReference) | Short term forecast associated with this schedule | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Version metadata for this work plan | [optional] |
| **UserSchedules** | [**Dictionary&lt;string, UserSchedule&gt;**](UserSchedule) | User schedules in the week | [optional] |
| **HeadcountForecast** | [**HeadcountForecast**](HeadcountForecast) | Headcount information for the week schedule | [optional] |
| **AgentSchedulesVersion** | **int?** | Version of agent schedules in the week schedule | [optional] |



_PureCloudPlatform.Client.V2 224.1.0_
