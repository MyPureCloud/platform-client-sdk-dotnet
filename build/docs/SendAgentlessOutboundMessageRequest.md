---
title: SendAgentlessOutboundMessageRequest
---
## ININ.PureCloudApi.Model.SendAgentlessOutboundMessageRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **FromAddress** | **string** | The messaging address of the sender of the message. For an SMS messenger type, this must be a currently provisioned SMS phone number. For a WhatsApp messenger type use the provisioned WhatsApp integration’s ID | |
| **ToAddress** | **string** | The messaging address of the recipient of the message. For an SMS messenger type, the phone number address must be in E.164 format. E.g. +13175555555 or +34234234234. | |
| **ToAddressMessengerType** | **string** | The recipient messaging address messenger type. Currently SMS and Open are the only supported types. WhatsApp will be supported in a future release | |
| **TextBody** | **string** | The text of the message to send. This field is required in the case of SMS messenger type. Maximum character counts are: SMS - 765 characters, other channels - 2000 characters. | [optional] |
| **MessagingTemplate** | [**MessagingTemplateRequest**](MessagingTemplateRequest.html) | The messaging template to use in the case of WhatsApp messenger type. This field is required when using WhatsApp messenger type | [optional] |
| **UseExistingActiveConversation** | **bool?** | Use an existing active conversation to send the agentless outbound message. Set this parameter to &#39;true&#39; to use active conversation. Default value: false | [optional] |
{: class="table table-striped"}


