# ScheduleBidGroupCreate

## ININ.PureCloudApi.Model.ScheduleBidGroupCreate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the schedule bid group | |
| **ManagementUnitId** | **string** | The ID of the management unit to which this bid group belongs | |
| **AgentIds** | **List&lt;string&gt;** | The IDs of the agents who participate in this bid group | |
| **WorkPlanIds** | **List&lt;string&gt;** | The IDs of the work plans used in this bid group | [optional] |
| **WorkPlanRotations** | [**List&lt;BidGroupWorkPlanRotationRequest&gt;**](BidGroupWorkPlanRotationRequest) | The work plan rotations used in this bid group | [optional] |
| **PlanningGroupIds** | **List&lt;string&gt;** | The IDs of the planning groups selected in this bid group | |



_PureCloudPlatform.Client.V2 268.0.0_
