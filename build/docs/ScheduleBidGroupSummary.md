# ScheduleBidGroupSummary

## ININ.PureCloudApi.Model.ScheduleBidGroupSummary

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | |
| **Name** | **string** | The name assigned to this bid group | |
| **ManagementUnit** | [**ManagementUnitReference**](ManagementUnitReference) | The management unit to which this bid group belongs | |
| **AgentCount** | **int?** | The number of agents in this bid group | |
| **WorkPlanCount** | **int?** | The number of work plans in this bid group or the number of work plans in rotations | |
| **WorkPlanRotationCount** | **int?** | The number of work plan rotations used in this bid group | |
| **PlanningGroupCount** | **int?** | The number of planning groups in this bid group | |
| **ScheduleSetError** | [**ScheduleSetError**](ScheduleSetError) | Schedule set optimization error details for this bid group. Present only when optimization fails | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
