# ScheduleSetError

## ININ.PureCloudApi.Model.ScheduleSetError

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ErrorCode** | **string** | Error code that indicates why schedule set optimization failed. At least one of workPlans or workPlanRotations is set if there is an error during optimization | |
| **WorkPlans** | [**List&lt;WorkPlanReference&gt;**](WorkPlanReference) | Work plans involved in the optimization failure | [optional] |
| **WorkPlanRotations** | [**List&lt;WorkPlanRotationReference&gt;**](WorkPlanRotationReference) | Work plan rotations involved in the optimization failure | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
