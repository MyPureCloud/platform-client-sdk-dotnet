---
title: WebChatTyping
---
## ININ.PureCloudApi.Model.WebChatTyping

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The event identifier of this typing indicator event (useful to guard against event re-delivery | |
| **Conversation** | [**WebChatConversation**](WebChatConversation.html) | The identifier of the conversation | |
| **Sender** | [**WebChatMemberInfo**](WebChatMemberInfo.html) | The member who sent the message | |
| **Timestamp** | **DateTime?** | The timestamp of the message, in ISO-8601 format | |
{: class="table table-striped"}


