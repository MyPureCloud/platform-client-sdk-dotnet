---
title: CampaignRuleEntities
---
## ININ.PureCloudApi.Model.CampaignRuleEntities

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Campaigns** | [**List&lt;UriReference&gt;**](UriReference.html) | The list of campaigns for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a campaign. | [optional] |
| **Sequences** | [**List&lt;UriReference&gt;**](UriReference.html) | The list of sequences for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a sequence. | [optional] |
{: class="table table-striped"}


