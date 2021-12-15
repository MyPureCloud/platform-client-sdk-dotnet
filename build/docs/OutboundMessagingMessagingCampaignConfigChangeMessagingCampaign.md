---
title: OutboundMessagingMessagingCampaignConfigChangeMessagingCampaign
---
## ININ.PureCloudApi.Model.OutboundMessagingMessagingCampaignConfigChangeMessagingCampaign

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **CampaignStatus** | **string** |  | [optional] |
| **CallableTimeSet** | [**OutboundMessagingMessagingCampaignConfigChangeUriReference**](OutboundMessagingMessagingCampaignConfigChangeUriReference.html) |  | [optional] |
| **ContactList** | [**OutboundMessagingMessagingCampaignConfigChangeUriReference**](OutboundMessagingMessagingCampaignConfigChangeUriReference.html) | A UriReference for a resource | [optional] |
| **DncLists** | [**List&lt;OutboundMessagingMessagingCampaignConfigChangeUriReference&gt;**](OutboundMessagingMessagingCampaignConfigChangeUriReference.html) | The dnc lists to check before sending a message for this messaging campaign. | [optional] |
| **ContactListFilters** | [**List&lt;OutboundMessagingMessagingCampaignConfigChangeUriReference&gt;**](OutboundMessagingMessagingCampaignConfigChangeUriReference.html) | The contact list filters to check before sending a message for this messaging campaign. | [optional] |
| **AlwaysRunning** | **bool?** | Whether this messaging campaign is always running. | [optional] |
| **ContactSorts** | [**List&lt;OutboundMessagingMessagingCampaignConfigChangeContactSort&gt;**](OutboundMessagingMessagingCampaignConfigChangeContactSort.html) | The order in which to sort contacts for dialing, based on up to four columns. | [optional] |
| **MessagesPerMinute** | **int?** | How many messages this messaging campaign will send per minute. | [optional] |
| **SmsConfig** | [**OutboundMessagingMessagingCampaignConfigChangeSmsConfig**](OutboundMessagingMessagingCampaignConfigChangeSmsConfig.html) |  | [optional] |
| **EmailConfig** | [**OutboundMessagingMessagingCampaignConfigChangeEmailConfig**](OutboundMessagingMessagingCampaignConfigChangeEmailConfig.html) |  | [optional] |
| **Errors** | [**List&lt;OutboundMessagingMessagingCampaignConfigChangeErrorDetail&gt;**](OutboundMessagingMessagingCampaignConfigChangeErrorDetail.html) | A list of current error conditions associated with this messaging campaign | [optional] |
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Division** | [**OutboundMessagingMessagingCampaignConfigChangeUriReference**](OutboundMessagingMessagingCampaignConfigChangeUriReference.html) | A UriReference for a resource | [optional] |
| **Name** | **string** | The UI-visible name of the object | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
{: class="table table-striped"}


