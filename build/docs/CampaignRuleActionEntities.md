# CampaignRuleActionEntities

## ININ.PureCloudApi.Model.CampaignRuleActionEntities

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Campaigns** | [**List&lt;DomainEntityRef&gt;**](DomainEntityRef) | The list of campaigns for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a campaign. | [optional] |
| **Sequences** | [**List&lt;DomainEntityRef&gt;**](DomainEntityRef) | The list of sequences for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a sequence. | [optional] |
| **UseTriggeringEntity** | **bool?** | If true, the CampaignRuleAction will apply to the same entity that triggered the CampaignRuleCondition. | [optional] |



_PureCloudPlatform.Client.V2 224.1.0_
