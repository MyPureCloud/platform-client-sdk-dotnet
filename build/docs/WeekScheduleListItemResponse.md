# WeekScheduleListItemResponse

## ININ.PureCloudApi.Model.WeekScheduleListItemResponse

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



_PureCloudPlatform.Client.V2 235.0.0_
