---
title: CampaignRule
---
## ININ.PureCloudApi.Model.CampaignRule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **CampaignRuleEntities** | [**CampaignRuleEntities**](CampaignRuleEntities.html) | the list of entities the rule monitors | |
| **CampaignRuleConditions** | [**List&lt;CampaignRuleCondition&gt;**](CampaignRuleCondition.html) | the list of conditions the are evaluated | |
| **CampaignRuleActions** | [**List&lt;CampaignRuleAction&gt;**](CampaignRuleAction.html) | the list of actions that are executed if the conditions are satisfied | |
| **MatchAnyConditions** | **bool?** |  | [optional] |
| **Enabled** | **bool?** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


