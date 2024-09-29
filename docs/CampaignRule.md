# CampaignRule

## ININ.PureCloudApi.Model.CampaignRule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the CampaignRule. | |
| **DateCreated** | **DateTime?** | Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **CampaignRuleEntities** | [**CampaignRuleEntities**](CampaignRuleEntities) | The list of entities that this CampaignRule monitors. | |
| **CampaignRuleConditions** | [**List&lt;CampaignRuleCondition&gt;**](CampaignRuleCondition) | The list of conditions that are evaluated on the entities. | |
| **CampaignRuleActions** | [**List&lt;CampaignRuleAction&gt;**](CampaignRuleAction) | The list of actions that are executed if the conditions are satisfied. | |
| **MatchAnyConditions** | **bool?** |  | [optional] |
| **Enabled** | **bool?** | Whether or not this CampaignRule is currently enabled. Required on updates. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 216.0.0_
