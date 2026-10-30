# WorkitemOnAttributeChangeRule

## ININ.PureCloudApi.Model.WorkitemOnAttributeChangeRule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Type** | **string** | The type of the rule. | [optional] |
| **Action** | [**WorkitemRuleAction**](WorkitemRuleAction) | The rules action. If the condition criteria is met this action will be executed. | [optional] |
| **Worktype** | [**WorktypeReference**](WorktypeReference) | The Worktype containing the rule. | [optional] |
| **Condition** | [**WorkitemOnAttributeChangeCondition**](WorkitemOnAttributeChangeCondition) | The rules condition. If the condition criteria is met the rules action will be executed. Mutually exclusive with match; a rule carries exactly one of condition or match. | [optional] |
| **Match** | [**WorkitemOnAttributeChangeMatch**](WorkitemOnAttributeChangeMatch) | Grouped match criteria combined with logical operators. Mutually exclusive with condition; a rule carries exactly one of condition or match. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 276.0.0_
