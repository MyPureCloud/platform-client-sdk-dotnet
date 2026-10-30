# WorkitemOnAttributeChangeRuleCreate

## ININ.PureCloudApi.Model.WorkitemOnAttributeChangeRuleCreate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the rule. | |
| **Condition** | [**WorkitemOnAttributeChangeCondition**](WorkitemOnAttributeChangeCondition) | The rules condition. If the condition criteria is met the rules action will be executed. Mutually exclusive with match; exactly one of condition or match must be provided. | [optional] |
| **Match** | [**WorkitemOnAttributeChangeMatch**](WorkitemOnAttributeChangeMatch) | Grouped match criteria combined with logical operators. Mutually exclusive with condition; exactly one of condition or match must be provided. | [optional] |



_PureCloudPlatform.Client.V2 276.0.0_
