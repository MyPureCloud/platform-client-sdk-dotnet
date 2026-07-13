# Domains

## ININ.PureCloudApi.Model.Domains

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **AuthorizedDomains** | [**AuthorizedDomains**](AuthorizedDomains) | The authorized domains settings for email processing. | [optional] |
| **AllowExistingEmailParticipants** | **bool?** | Allow reply and forward to recipients included in the previous email, ignoring the authorized domains list | [optional] |
| **AllowOutboundToAnyDomainAcd** | **bool?** | Allow new outbound email (no existing conversation) to be sent to any domain, ignoring the authorized domains list.This setting applies only to new outbound emails sent on behalf of queue or agentless, NOT campaigns.This setting can only be true if allowExistingEmailParticipants is also true. | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
