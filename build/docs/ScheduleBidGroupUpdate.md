# ScheduleBidGroupUpdate

## ININ.PureCloudApi.Model.ScheduleBidGroupUpdate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the schedule bid group | [optional] |
| **ManagementUnitId** | **string** | The ID of the management unit to which this bid group belongs | [optional] |
| **AgentIds** | [**SetWrapperString**](SetWrapperString) | The IDs of the agents who participate in this bid group | [optional] |
| **WorkPlanIds** | [**SetWrapperString**](SetWrapperString) | The IDs of the work plans used in this bid group | [optional] |
| **WorkPlanRotations** | [**ListWrapperBidGroupWorkPlanRotationRequest**](ListWrapperBidGroupWorkPlanRotationRequest) | The work plan rotations used in this bid group | [optional] |
| **PlanningGroupIds** | [**SetWrapperString**](SetWrapperString) | The IDs of the planning groups selected in this bid group | [optional] |
| **ScheduleSets** | [**ListWrapperScheduleSetRequest**](ListWrapperScheduleSetRequest) | The schedule sets generated for this bid group | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
