# DialerRulesetConfigChangeRule

## ININ.PureCloudApi.Model.DialerRulesetConfigChangeRule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Conditions** | [**List&lt;DialerRulesetConfigChangeCondition&gt;**](DialerRulesetConfigChangeCondition) | The list of rule conditions; all must evaluate to true to trigger the rule actions | [optional] |
| **AdditionalProperties** | **Dictionary&lt;string, Object&gt;** |  | [optional] |
| **Id** | **string** | The identifier of the rule | [optional] |
| **Name** | **string** | The name of the rule | [optional] |
| **Order** | **long?** | The ranked order of the rule; rules are processed from lowest number to highest | [optional] |
| **Category** | **string** | The category of the rule | [optional] |
| **Actions** | [**List&lt;DialerRulesetConfigChangeAction&gt;**](DialerRulesetConfigChangeAction) | The list of rule actions to be taken if the conditions are true | [optional] |



_PureCloudPlatform.Client.V2 233.0.0_
