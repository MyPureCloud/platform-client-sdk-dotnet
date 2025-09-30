# WorkitemDateBasedRule

## ININ.PureCloudApi.Model.WorkitemDateBasedRule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Type** | **string** | The type of the rule. | [optional] |
| **Action** | [**WorkitemRuleAction**](WorkitemRuleAction) | The rules action. If the condition criteria is met this action will be executed. | [optional] |
| **Worktype** | [**WorktypeReference**](WorktypeReference) | The Worktype containing the rule. | [optional] |
| **Condition** | [**WorkitemDateBasedCondition**](WorkitemDateBasedCondition) | The rules condition. If the condition criteria is met the rules action will be executed. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 244.0.0_
