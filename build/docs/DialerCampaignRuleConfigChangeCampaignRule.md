# DialerCampaignRuleConfigChangeCampaignRule

## ININ.PureCloudApi.Model.DialerCampaignRuleConfigChangeCampaignRule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **CampaignRuleEntities** | [**DialerCampaignRuleConfigChangeCampaignRuleEntities**](DialerCampaignRuleConfigChangeCampaignRuleEntities) |  | [optional] |
| **CampaignRuleConditions** | [**List&lt;DialerCampaignRuleConfigChangeCampaignRuleCondition&gt;**](DialerCampaignRuleConfigChangeCampaignRuleCondition) | The list of conditions that will trigger this Campaign Rule | [optional] |
| **CampaignRuleActions** | [**List&lt;DialerCampaignRuleConfigChangeCampaignRuleAction&gt;**](DialerCampaignRuleConfigChangeCampaignRuleAction) | The list of actions that will be taken when this Campaign Rule&#39;s conditions are met | [optional] |
| **MatchAnyConditions** | **bool?** | Whether this Campaign Rule should match any conditions (inclusive OR) or match all conditions (ALL) | [optional] |
| **Enabled** | **bool?** | Whether this campaign rule is enabled | [optional] |
| **AdditionalProperties** | **Dictionary&lt;string, Object&gt;** |  | [optional] |
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The UI-visible name of the object | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity | [optional] |
| **Version** | **long?** | Required for updates, must match the version number of the most recent update | [optional] |
| **GetAdditionalProperties** | **Dictionary&lt;string, Object&gt;** |  | [optional] |



_PureCloudPlatform.Client.V2 252.0.0_
