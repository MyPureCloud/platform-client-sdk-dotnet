# CampaignRuleParameters

## ININ.PureCloudApi.Model.CampaignRuleParameters

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Operator** | **string** | The operator for comparison. Required for a CampaignRuleCondition. | [optional] |
| **Value** | **string** | The value for comparison. Required for a CampaignRuleCondition. | [optional] |
| **Priority** | **string** | The priority to set a campaign to. Required for the &#39;setCampaignPriority&#39; action. | [optional] |
| **DialingMode** | **string** | The dialing mode to set a campaign to. Required for the &#39;setCampaignDialingMode&#39; action. | [optional] |
| **AbandonRate** | **double?** | The abandon rate to set a campaign to. Required for the &#39;setCampaignAbandonRate&#39; action. | [optional] |
| **OutboundLineCount** | **int?** | The  number of outbound lines to set a campaign to. Required for the &#39;setCampaignNumberOfLines&#39; action. | [optional] |
| **RelativeWeight** | **int?** | The relative weight to set a campaign to. Required for the &#39;setCampaignWeight&#39; action. | [optional] |
| **MaxCallsPerAgent** | **double?** | The maximum number of calls per agent to set a campaign to. Required for the &#39;setCampaignMaxCallsPerAgent&#39; action. | [optional] |
| **Queue** | [**DomainEntityRef**](DomainEntityRef) | The queue a campaign to. Required for the &#39;changeCampaignQueue&#39; action. | [optional] |



_PureCloudPlatform.Client.V2 215.1.0_
