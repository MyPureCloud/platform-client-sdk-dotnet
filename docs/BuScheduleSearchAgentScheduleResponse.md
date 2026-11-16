# BuScheduleSearchAgentScheduleResponse

## ININ.PureCloudApi.Model.BuScheduleSearchAgentScheduleResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **User** | [**UserReference**](UserReference) | The user to whom this agent schedule applies | [optional] |
| **Shifts** | [**List&lt;BuAgentScheduleShift&gt;**](BuAgentScheduleShift) | The shift definitions for this agent schedule | [optional] |
| **FullDayTimeOffMarkers** | [**List&lt;BuFullDayTimeOffMarker&gt;**](BuFullDayTimeOffMarker) | Full day time off markers which apply to this agent schedule | [optional] |
| **WorkPlansPerWeek** | [**List&lt;WorkPlanReference&gt;**](WorkPlanReference) | The work plans per week for this user from the work plan rotation. Null values in the list denote that the user is not part of any work plan for that week. Populated only when expand&#x3D;agentSchedules.workPlansPerWeek is requested | [optional] |



_PureCloudPlatform.Client.V2 277.0.0_
