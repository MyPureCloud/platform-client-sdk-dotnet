---
title: AgentlessEmailSendResponseDto
---
## ININ.PureCloudApi.Model.AgentlessEmailSendResponseDto

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **ConversationId** | **string** | The identifier of the conversation. | |
| **SenderType** | **string** | The identifier of the external participant of the given conversation. | |
| **FromAddress** | [**EmailAddress**](EmailAddress.html) | The sender of the message. | |
| **ToAddresses** | [**List&lt;EmailAddress&gt;**](EmailAddress.html) | The recipient of the message. So far, only one recipient is allowed. This is a list, only for future usage. | |
| **ReplyToAddress** | [**EmailAddress**](EmailAddress.html) | The address to use for reply. | [optional] |
| **Subject** | **string** | The subject of the message. | [optional] |
| **DateCreated** | **DateTime?** | The message creation timestamp. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


