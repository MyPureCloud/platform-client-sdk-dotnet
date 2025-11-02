# CampaignRuleEntities

## ININ.PureCloudApi.Model.CampaignRuleEntities

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Campaigns** | [**List&lt;DomainEntityRef&gt;**](DomainEntityRef) | The list of campaigns for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a campaign. | [optional] |
| **Sequences** | [**List&lt;DomainEntityRef&gt;**](DomainEntityRef) | The list of sequences for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a sequence. | [optional] |
| **EmailCampaigns** | [**List&lt;DomainEntityRef&gt;**](DomainEntityRef) | The list of Email campaigns for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a Email campaign. | [optional] |
| **SmsCampaigns** | [**List&lt;DomainEntityRef&gt;**](DomainEntityRef) | The list of SMS campaigns for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a SMS campaign. | [optional] |



_PureCloudPlatform.Client.V2 247.0.0_
