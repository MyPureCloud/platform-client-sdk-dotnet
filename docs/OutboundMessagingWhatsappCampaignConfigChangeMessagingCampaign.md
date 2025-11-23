# OutboundMessagingWhatsappCampaignConfigChangeMessagingCampaign

## ININ.PureCloudApi.Model.OutboundMessagingWhatsappCampaignConfigChangeMessagingCampaign

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **CampaignStatus** | **string** |  | [optional] |
| **CallableTimeSet** | [**OutboundMessagingWhatsappCampaignConfigChangeUriReference**](OutboundMessagingWhatsappCampaignConfigChangeUriReference) |  | [optional] |
| **ContactList** | [**OutboundMessagingWhatsappCampaignConfigChangeUriReference**](OutboundMessagingWhatsappCampaignConfigChangeUriReference) | A UriReference for a resource | [optional] |
| **DncLists** | [**List&lt;OutboundMessagingWhatsappCampaignConfigChangeUriReference&gt;**](OutboundMessagingWhatsappCampaignConfigChangeUriReference) | The dnc lists to check before sending a message for this messaging campaign. | [optional] |
| **ContactListFilters** | [**List&lt;OutboundMessagingWhatsappCampaignConfigChangeUriReference&gt;**](OutboundMessagingWhatsappCampaignConfigChangeUriReference) | The contact list filters to check before sending a message for this messaging campaign. | [optional] |
| **AlwaysRunning** | **bool?** | Whether this messaging campaign is always running. | [optional] |
| **ContactSorts** | [**List&lt;OutboundMessagingWhatsappCampaignConfigChangeContactSort&gt;**](OutboundMessagingWhatsappCampaignConfigChangeContactSort) | The order in which to sort contacts for dialing, based on up to four columns. | [optional] |
| **MessagesPerMinute** | **long?** | How many messages this messaging campaign will send per minute. | [optional] |
| **RuleSets** | [**List&lt;OutboundMessagingWhatsappCampaignConfigChangeUriReference&gt;**](OutboundMessagingWhatsappCampaignConfigChangeUriReference) |  | [optional] |
| **SmsConfig** | [**OutboundMessagingWhatsappCampaignConfigChangeSmsConfig**](OutboundMessagingWhatsappCampaignConfigChangeSmsConfig) |  | [optional] |
| **EmailConfig** | [**OutboundMessagingWhatsappCampaignConfigChangeEmailConfig**](OutboundMessagingWhatsappCampaignConfigChangeEmailConfig) |  | [optional] |
| **WhatsAppConfig** | [**OutboundMessagingWhatsappCampaignConfigChangeWhatsAppConfig**](OutboundMessagingWhatsappCampaignConfigChangeWhatsAppConfig) |  | [optional] |
| **Errors** | [**List&lt;OutboundMessagingWhatsappCampaignConfigChangeErrorDetail&gt;**](OutboundMessagingWhatsappCampaignConfigChangeErrorDetail) | A list of current error conditions associated with this messaging campaign | [optional] |
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The UI-visible name of the object | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity | [optional] |
| **Version** | **long?** | Required for updates, must match the version number of the most recent update | [optional] |
| **Division** | [**OutboundMessagingWhatsappCampaignConfigChangeUriReference**](OutboundMessagingWhatsappCampaignConfigChangeUriReference) | A UriReference for a resource | [optional] |



_PureCloudPlatform.Client.V2 249.0.0_
