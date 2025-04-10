# OutboundMessagingEmailCampaignProgressEventCampaignProgress

## ININ.PureCloudApi.Model.OutboundMessagingEmailCampaignProgressEventCampaignProgress

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Campaign** | [**OutboundMessagingEmailCampaignProgressEventUriReference**](OutboundMessagingEmailCampaignProgressEventUriReference) |  | [optional] |
| **NumberOfContactsCalled** | **double?** | The number of contacts that have been called so far | [optional] |
| **NumberOfContactsMessaged** | **double?** | The number of contacts that have been messaged so far | [optional] |
| **TotalNumberOfContacts** | **double?** | The total number of contacts in the contact list | [optional] |
| **Percentage** | **long?** | numberOfContactsContacted/totalNumberOfContacts*100 | [optional] |
| **NumberOfContactsSkipped** | **Dictionary&lt;string, long?&gt;** | A map of skipped reasons and the number of contacts associated with each. | [optional] |
| **AdditionalProperties** | **Dictionary&lt;string, Object&gt;** |  | [optional] |



_PureCloudPlatform.Client.V2 231.0.0_
