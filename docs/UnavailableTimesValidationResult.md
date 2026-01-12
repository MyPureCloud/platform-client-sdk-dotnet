# UnavailableTimesValidationResult

## ININ.PureCloudApi.Model.UnavailableTimesValidationResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Valid** | **bool?** | Indicates whether there are no violations in the given unavailable times | |
| **InvalidWorkPlans** | [**List&lt;WorkPlanReference&gt;**](WorkPlanReference) | Invalid work plans that were used when validating the agents unavailable times | |
| **WorkPlanConstraintsViolationMessage** | [**WorkPlanConstraintsViolationMessage**](WorkPlanConstraintsViolationMessage) | Message for set of agent unavailable times violating work plan constraints | [optional] |



_PureCloudPlatform.Client.V2 253.0.0_
