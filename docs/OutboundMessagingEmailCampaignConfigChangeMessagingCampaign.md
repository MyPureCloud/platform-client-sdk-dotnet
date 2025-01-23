# OutboundMessagingEmailCampaignConfigChangeMessagingCampaign

## ININ.PureCloudApi.Model.OutboundMessagingEmailCampaignConfigChangeMessagingCampaign

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **CampaignStatus** | **string** |  | [optional] |
| **CallableTimeSet** | [**OutboundMessagingEmailCampaignConfigChangeUriReference**](OutboundMessagingEmailCampaignConfigChangeUriReference) |  | [optional] |
| **ContactList** | [**OutboundMessagingEmailCampaignConfigChangeUriReference**](OutboundMessagingEmailCampaignConfigChangeUriReference) | A UriReference for a resource | [optional] |
| **DncLists** | [**List&lt;OutboundMessagingEmailCampaignConfigChangeUriReference&gt;**](OutboundMessagingEmailCampaignConfigChangeUriReference) | The dnc lists to check before sending a message for this messaging campaign. | [optional] |
| **ContactListFilters** | [**List&lt;OutboundMessagingEmailCampaignConfigChangeUriReference&gt;**](OutboundMessagingEmailCampaignConfigChangeUriReference) | The contact list filters to check before sending a message for this messaging campaign. | [optional] |
| **AlwaysRunning** | **bool?** | Whether this messaging campaign is always running. | [optional] |
| **ContactSorts** | [**List&lt;OutboundMessagingEmailCampaignConfigChangeContactSort&gt;**](OutboundMessagingEmailCampaignConfigChangeContactSort) | The order in which to sort contacts for dialing, based on up to four columns. | [optional] |
| **MessagesPerMinute** | **int?** | How many messages this messaging campaign will send per minute. | [optional] |
| **RuleSets** | [**List&lt;OutboundMessagingEmailCampaignConfigChangeUriReference&gt;**](OutboundMessagingEmailCampaignConfigChangeUriReference) |  | [optional] |
| **SmsConfig** | [**OutboundMessagingEmailCampaignConfigChangeSmsConfig**](OutboundMessagingEmailCampaignConfigChangeSmsConfig) |  | [optional] |
| **EmailConfig** | [**OutboundMessagingEmailCampaignConfigChangeEmailConfig**](OutboundMessagingEmailCampaignConfigChangeEmailConfig) |  | [optional] |
| **Errors** | [**List&lt;OutboundMessagingEmailCampaignConfigChangeErrorDetail&gt;**](OutboundMessagingEmailCampaignConfigChangeErrorDetail) | A list of current error conditions associated with this messaging campaign | [optional] |
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The UI-visible name of the object | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **Division** | [**OutboundMessagingEmailCampaignConfigChangeUriReference**](OutboundMessagingEmailCampaignConfigChangeUriReference) | A UriReference for a resource | [optional] |



_PureCloudPlatform.Client.V2 225.0.0_
