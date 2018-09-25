---
title: CreateOutboundMessagingConversationRequest
---
## ININ.PureCloudApi.Model.CreateOutboundMessagingConversationRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **QueueId** | **string** | The ID of the queue to be associated with the message. This will determine the fromAddress of the message. | |
| **ToAddress** | **string** | The messaging address of the recipient of the message. | |
| **ToAddressMessengerType** | **string** | The messaging address messenger type. | |
| **UseExistingConversation** | **bool?** | An override to use an existing conversation.  If set to true, an existing conversation will be used if there is one within the conversation window.  If set to false, create request fails if there is a conversation within the conversation window. | [optional] |
| **ExternalContactId** | **string** | The external contact Id of the recipient of the message. | [optional] |
| **ExternalOrganizationId** | **string** | The external organization Id of the recipient of the message. | [optional] |
{: class="table table-striped"}


