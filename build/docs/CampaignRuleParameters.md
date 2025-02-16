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
| **MessagesPerMinute** | **int?** | The number of messages per minute to set a messaging campaign to. | [optional] |
| **SmsMessagesPerMinute** | **int?** | The number of messages per minute to set a SMS messaging campaign to. | [optional] |
| **EmailMessagesPerMinute** | **int?** | The number of messages per minute to set a Email messaging campaign to. | [optional] |
| **SmsContentTemplate** | [**DomainEntityRef**](DomainEntityRef) | The content template to set a SMS campaign to. | [optional] |
| **EmailContentTemplate** | [**DomainEntityRef**](DomainEntityRef) | The content template to set a Email campaign to. | [optional] |



_PureCloudPlatform.Client.V2 227.0.0_
