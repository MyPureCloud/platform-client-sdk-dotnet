---
title: DialerRule
---
## ININ.PureCloudApi.Model.DialerRule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The identifier of the rule. | [optional] |
| **Name** | **string** | The name of the rule. | |
| **Order** | **int?** | The ranked order of the rule. Rules are processed from lowest number to highest. | [optional] |
| **Category** | **string** | The category of the rule. | |
| **Conditions** | [**List&lt;Condition&gt;**](Condition.html) | A list of Conditions. All of the Conditions must evaluate to true to trigger the actions. | |
| **Actions** | [**List&lt;DialerAction&gt;**](DialerAction.html) | The list of actions to be taken if the conditions are true. | [optional] |
{: class="table table-striped"}


