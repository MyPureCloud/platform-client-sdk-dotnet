# BuImportAgentScheduleUploadSchema

## ININ.PureCloudApi.Model.BuImportAgentScheduleUploadSchema

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **UserId** | **string** | The ID of the user to whom this agent schedule applies | |
| **WorkPlanId** | [**ValueWrapperString**](ValueWrapperString) | The ID of the work plan for this user.  Mutually exclusive with workPlanIdsPerWeek | [optional] |
| **WorkPlanIdsPerWeek** | [**ListWrapperString**](ListWrapperString) | The IDs of the work plans per week for this user.  Mutually exclusive with workPlanId | [optional] |
| **Shifts** | [**List&lt;BuAgentScheduleShiftRequest&gt;**](BuAgentScheduleShiftRequest) | The shift definitions for this agent schedule | [optional] |
| **FullDayTimeOffMarkers** | [**List&lt;BuFullDayTimeOffMarker&gt;**](BuFullDayTimeOffMarker) | Any full day time off markers that apply to this agent schedule | [optional] |



_PureCloudPlatform.Client.V2 240.0.0_
