# OutboundMessagingMessagingCampaignConfigChangeMessagingCampaign

## ININ.PureCloudApi.Model.OutboundMessagingMessagingCampaignConfigChangeMessagingCampaign

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **CampaignStatus** | **string** |  | [optional] |
| **CallableTimeSet** | [**OutboundMessagingMessagingCampaignConfigChangeUriReference**](OutboundMessagingMessagingCampaignConfigChangeUriReference) |  | [optional] |
| **ContactList** | [**OutboundMessagingMessagingCampaignConfigChangeUriReference**](OutboundMessagingMessagingCampaignConfigChangeUriReference) | A UriReference for a resource | [optional] |
| **DncLists** | [**List&lt;OutboundMessagingMessagingCampaignConfigChangeUriReference&gt;**](OutboundMessagingMessagingCampaignConfigChangeUriReference) | The dnc lists to check before sending a message for this messaging campaign. | [optional] |
| **ContactListFilters** | [**List&lt;OutboundMessagingMessagingCampaignConfigChangeUriReference&gt;**](OutboundMessagingMessagingCampaignConfigChangeUriReference) | The contact list filters to check before sending a message for this messaging campaign. | [optional] |
| **AlwaysRunning** | **bool?** | Whether this messaging campaign is always running. | [optional] |
| **ContactSorts** | [**List&lt;OutboundMessagingMessagingCampaignConfigChangeContactSort&gt;**](OutboundMessagingMessagingCampaignConfigChangeContactSort) | The order in which to sort contacts for dialing, based on up to four columns. | [optional] |
| **MessagesPerMinute** | **long?** | How many messages this messaging campaign will send per minute. | [optional] |
| **RuleSets** | [**List&lt;OutboundMessagingMessagingCampaignConfigChangeUriReference&gt;**](OutboundMessagingMessagingCampaignConfigChangeUriReference) |  | [optional] |
| **SmsConfig** | [**OutboundMessagingMessagingCampaignConfigChangeSmsConfig**](OutboundMessagingMessagingCampaignConfigChangeSmsConfig) |  | [optional] |
| **EmailConfig** | [**OutboundMessagingMessagingCampaignConfigChangeEmailConfig**](OutboundMessagingMessagingCampaignConfigChangeEmailConfig) |  | [optional] |
| **WhatsAppConfig** | [**OutboundMessagingMessagingCampaignConfigChangeWhatsAppConfig**](OutboundMessagingMessagingCampaignConfigChangeWhatsAppConfig) |  | [optional] |
| **Errors** | [**List&lt;OutboundMessagingMessagingCampaignConfigChangeErrorDetail&gt;**](OutboundMessagingMessagingCampaignConfigChangeErrorDetail) | A list of current error conditions associated with this messaging campaign | [optional] |
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The UI-visible name of the object | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity | [optional] |
| **Version** | **long?** | Required for updates, must match the version number of the most recent update | [optional] |
| **Division** | [**OutboundMessagingMessagingCampaignConfigChangeUriReference**](OutboundMessagingMessagingCampaignConfigChangeUriReference) | A UriReference for a resource | [optional] |



_PureCloudPlatform.Client.V2 254.0.0_
