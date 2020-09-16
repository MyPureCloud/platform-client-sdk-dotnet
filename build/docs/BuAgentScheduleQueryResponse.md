---
title: BuAgentScheduleQueryResponse
---
## ININ.PureCloudApi.Model.BuAgentScheduleQueryResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **User** | [**UserReference**](UserReference.html) | The user to whom this agent schedule applies | [optional] |
| **Shifts** | [**List&lt;BuAgentScheduleShift&gt;**](BuAgentScheduleShift.html) | The shift definitions for this agent schedule | [optional] |
| **FullDayTimeOffMarkers** | [**List&lt;BuFullDayTimeOffMarker&gt;**](BuFullDayTimeOffMarker.html) | Full day time off markers which apply to this agent schedule | [optional] |
| **WorkPlan** | [**WorkPlanReference**](WorkPlanReference.html) | The work plan for this user | [optional] |
| **WorkPlansPerWeek** | [**List&lt;WorkPlanReference&gt;**](WorkPlanReference.html) | The work plans per week for this user from the work plan rotation. Null values in the list denotes that user is not part of any work plan for that week | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata.html) | Versioned entity metadata for this agent schedule | [optional] |
{: class="table table-striped"}


