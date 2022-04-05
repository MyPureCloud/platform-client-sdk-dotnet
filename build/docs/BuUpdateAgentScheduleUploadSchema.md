---
title: BuUpdateAgentScheduleUploadSchema
---
## ININ.PureCloudApi.Model.BuUpdateAgentScheduleUploadSchema

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **UserId** | **string** | The ID of the user to whom this agent schedule applies | |
| **WorkPlanId** | [**ValueWrapperString**](ValueWrapperString.html) | The ID of the work plan for this user.  Mutually exclusive with workPlanIdsPerWeek | [optional] |
| **WorkPlanIdsPerWeek** | [**ListWrapperString**](ListWrapperString.html) | The IDs of the work plans per week for this user.  Mutually exclusive with workPlanId | [optional] |
| **Shifts** | [**List&lt;BuAgentScheduleShift&gt;**](BuAgentScheduleShift.html) | The shift definitions for this agent schedule | [optional] |
| **FullDayTimeOffMarkers** | [**List&lt;BuFullDayTimeOffMarker&gt;**](BuFullDayTimeOffMarker.html) | Any full day time off markers that apply to this agent schedule | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata.html) | Version metadata for this agent schedule. Required if updating or deleting an existing agent schedule, otherwise should be omitted | [optional] |
| **Delete** | **bool?** | Whether to delete this agent&#39;s schedule. Defaults to false if not set | [optional] |
{: class="table table-striped"}


