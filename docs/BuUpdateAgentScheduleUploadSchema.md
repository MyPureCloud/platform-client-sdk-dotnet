# BuUpdateAgentScheduleUploadSchema

## ININ.PureCloudApi.Model.BuUpdateAgentScheduleUploadSchema

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **UserId** | **string** | The ID of the user to whom this agent schedule applies | |
| **WorkPlanId** | [**ValueWrapperString**](ValueWrapperString) | The ID of the work plan for this user.  Mutually exclusive with workPlanIdsPerWeek | [optional] |
| **WorkPlanIdsPerWeek** | [**ListWrapperString**](ListWrapperString) | The IDs of the work plans per week for this user.  Mutually exclusive with workPlanId | [optional] |
| **Shifts** | [**List&lt;BuUpdateAgentScheduleShift&gt;**](BuUpdateAgentScheduleShift) | The shift definitions for this agent schedule | [optional] |
| **FullDayTimeOffMarkers** | [**List&lt;BuFullDayTimeOffMarker&gt;**](BuFullDayTimeOffMarker) | Any full day time off markers that apply to this agent schedule | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Version metadata for this agent schedule. Required if updating or deleting an existing agent schedule, otherwise should be omitted | [optional] |
| **Delete** | **bool?** | Whether to delete this agent&#39;s schedule. Defaults to false if not set | [optional] |



_PureCloudPlatform.Client.V2 251.0.0_
