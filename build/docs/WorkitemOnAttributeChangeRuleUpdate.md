# WorkitemOnAttributeChangeRuleUpdate

## ININ.PureCloudApi.Model.WorkitemOnAttributeChangeRuleUpdate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the rule. | [optional] |
| **Condition** | [**WorkitemOnAttributeChangeConditionUpdate**](WorkitemOnAttributeChangeConditionUpdate) | The rules condition. If the condition criteria is met the rules action will be executed. Mutually exclusive with match; supplying either replaces the rule&#39;s existing match criteria in full. | [optional] |
| **Match** | [**WorkitemOnAttributeChangeMatch**](WorkitemOnAttributeChangeMatch) | Grouped match criteria combined with logical operators. Mutually exclusive with condition; the supplied object replaces the rule&#39;s existing match criteria in full. | [optional] |



_PureCloudPlatform.Client.V2 276.0.0_
