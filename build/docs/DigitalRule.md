---
title: DigitalRule
---
## ININ.PureCloudApi.Model.DigitalRule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The identifier of the rule. | [optional] |
| **Name** | **string** | The name of the rule. | |
| **Order** | **int?** | The ranked order of the rule. Rules are processed from lowest number to highest. | |
| **Category** | **string** | The category of the rule. | |
| **Conditions** | [**List&lt;DigitalCondition&gt;**](DigitalCondition.html) | A list of conditions to evaluate. All of the Conditions must evaluate to true to trigger the actions. | |
| **Actions** | [**List&lt;DigitalAction&gt;**](DigitalAction.html) | The list of actions to be taken if all conditions are true. | |
{: class="table table-striped"}


