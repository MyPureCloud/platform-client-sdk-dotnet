# WorkPlanConfigurationViolationMessage

## ININ.PureCloudApi.Model.WorkPlanConfigurationViolationMessage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | Type of configuration violation message for this work plan | [optional] |
| **Arguments** | [**List&lt;WorkPlanValidationMessageArgument&gt;**](WorkPlanValidationMessageArgument) | Arguments of the message that provide information about the misconfigured value or the threshold that is exceeded by the misconfigured value | [optional] |
| **Severity** | **string** | Severity of the message. A message with Error severity indicates the scheduler won&#39;t be able to produce schedules and thus the work plan is invalid. | [optional] |



_PureCloudPlatform.Client.V2 238.0.0_
