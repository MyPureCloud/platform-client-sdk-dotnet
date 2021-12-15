---
title: DialerRulesetConfigChangeRule
---
## ININ.PureCloudApi.Model.DialerRulesetConfigChangeRule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Conditions** | [**List&lt;DialerRulesetConfigChangeCondition&gt;**](DialerRulesetConfigChangeCondition.html) | The list of rule conditions; all must evaluate to true to trigger the rule actions | [optional] |
| **Id** | **string** | The identifier of the rule | [optional] |
| **Name** | **string** | The name of the rule | [optional] |
| **Order** | **int?** | The ranked order of the rule; rules are processed from lowest number to highest | [optional] |
| **Category** | **string** | The category of the rule | [optional] |
| **Actions** | [**List&lt;DialerRulesetConfigChangeAction&gt;**](DialerRulesetConfigChangeAction.html) | The list of rule actions to be taken if the conditions are true | [optional] |
{: class="table table-striped"}


