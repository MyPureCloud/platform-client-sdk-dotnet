# ValidateWorkPlanMessages

## ININ.PureCloudApi.Model.ValidateWorkPlanMessages

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ViolationMessages** | [**List&lt;WorkPlanConfigurationViolationMessage&gt;**](WorkPlanConfigurationViolationMessage) | Messages for work plan violating some rules such as no shifts in a work plan | [optional] |
| **ConstraintConflictMessage** | [**ConstraintConflictMessage**](ConstraintConflictMessage) | This field is not null when there is a set of work plan constraints that conflict thus agent schedules cannot be generated | [optional] |



_PureCloudPlatform.Client.V2 221.0.0_
