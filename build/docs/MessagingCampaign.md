# MessagingCampaign

## ININ.PureCloudApi.Model.MessagingCampaign

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **Division** | [**DomainEntityRef**](DomainEntityRef) | The division this entity belongs to. | [optional] |
| **CampaignStatus** | **string** | The current status of the messaging campaign. A messaging campaign may be turned &#39;on&#39; or &#39;off&#39;. | [optional] |
| **CallableTimeSet** | [**DomainEntityRef**](DomainEntityRef) | The callable time set for this messaging campaign. | [optional] |
| **ContactList** | [**DomainEntityRef**](DomainEntityRef) | The contact list that this messaging campaign will send messages for. | |
| **DncLists** | [**List&lt;DomainEntityRef&gt;**](DomainEntityRef) | The dnc lists to check before sending a message for this messaging campaign. | [optional] |
| **AlwaysRunning** | **bool?** | Whether this messaging campaign is always running | [optional] |
| **ContactSorts** | [**List&lt;ContactSort&gt;**](ContactSort) | The order in which to sort contacts for dialing, based on up to four columns. | [optional] |
| **MessagesPerMinute** | **int?** | How many messages this messaging campaign will send per minute. | |
| **RuleSets** | [**List&lt;DomainEntityRef&gt;**](DomainEntityRef) | Rule Sets to be applied while this campaign is sending messages | [optional] |
| **ContactListFilters** | [**List&lt;DomainEntityRef&gt;**](DomainEntityRef) | The contact list filter to check before sending a message for this messaging campaign. | [optional] |
| **Errors** | [**List&lt;RestErrorDetail&gt;**](RestErrorDetail) | A list of current error conditions associated with this messaging campaign. | [optional] |
| **DynamicContactQueueingSettings** | [**DynamicContactQueueingSettings**](DynamicContactQueueingSettings) | Indicates (when true) that the campaign supports dynamic queueing of the contact list at the time of a request for contacts. | [optional] |
| **EmailConfig** | [**EmailConfig**](EmailConfig) | Configuration for this messaging campaign to send Email messages. | [optional] |
| **SmsConfig** | [**SmsConfig**](SmsConfig) | Configuration for this messaging campaign to send SMS messages. | [optional] |
| **WhatsAppConfig** | [**WhatsAppConfig**](WhatsAppConfig) | Configuration for this messaging campaign to send WhatsApp messages. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 250.0.0_
