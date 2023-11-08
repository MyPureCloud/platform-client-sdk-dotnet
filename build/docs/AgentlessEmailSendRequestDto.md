---
title: AgentlessEmailSendRequestDto
---
## ININ.PureCloudApi.Model.AgentlessEmailSendRequestDto

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SenderType** | **string** | The direction of the message. | |
| **ConversationId** | **string** | The identifier of the conversation. This must be an email interaction. | [optional] |
| **FromAddress** | [**EmailAddress**](EmailAddress.html) | The sender of the message. | |
| **ToAddresses** | [**List&lt;EmailAddress&gt;**](EmailAddress.html) | The recipient of the message. We currently support one recipient only. | |
| **ReplyToAddress** | [**EmailAddress**](EmailAddress.html) | The address to use for reply. | [optional] |
| **Subject** | **string** | The subject of the message. | [optional] |
| **TextBody** | **string** | The Content of the message, in plain text. | [optional] |
| **HtmlBody** | **string** | The Content of the message, in HTML. Links, images and styles are allowed | [optional] |
{: class="table table-striped"}


