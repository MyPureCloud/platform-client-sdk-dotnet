# BuAgentScheduleRescheduleResponse

## ININ.PureCloudApi.Model.BuAgentScheduleRescheduleResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **User** | [**UserReference**](UserReference) | The user to whom this agent schedule applies | [optional] |
| **Shifts** | [**List&lt;BuAgentScheduleShift&gt;**](BuAgentScheduleShift) | The shift definitions for this agent schedule | [optional] |
| **FullDayTimeOffMarkers** | [**List&lt;BuFullDayTimeOffMarker&gt;**](BuFullDayTimeOffMarker) | Full day time off markers which apply to this agent schedule | [optional] |
| **WorkPlan** | [**WorkPlanReference**](WorkPlanReference) | The work plan for this user | [optional] |
| **WorkPlansPerWeek** | [**List&lt;WorkPlanReference&gt;**](WorkPlanReference) | The work plans per week for this user from the work plan rotation. Null values in the list denotes that user is not part of any work plan for that week | [optional] |



_PureCloudPlatform.Client.V2 247.0.0_
