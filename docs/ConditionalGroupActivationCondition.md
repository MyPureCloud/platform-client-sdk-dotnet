# ConditionalGroupActivationCondition

## ININ.PureCloudApi.Model.ConditionalGroupActivationCondition

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SimpleMetric** | [**ConditionalGroupActivationSimpleMetric**](ConditionalGroupActivationSimpleMetric) | Instructs this condition to evaluate a simple queue-level metric | [optional] |
| **Operator** | **string** | The operator used to compare the actual value against the threshold value | [optional] |
| **Value** | **double?** | The threshold value, beyond which a rule evaluates as true | [optional] |



_PureCloudPlatform.Client.V2 252.1.0_
