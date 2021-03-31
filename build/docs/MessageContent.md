---
title: MessageContent
---
## ININ.PureCloudApi.Model.MessageContent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ContentType** | **string** | Type of this content element. If contentType = \&quot;Attachment\&quot; only one item is allowed. | |
| **Location** | [**ContentLocation**](ContentLocation.html) | Location object | [optional] |
| **Attachment** | [**ContentAttachment**](ContentAttachment.html) | Attachment object | [optional] |
| **QuickReply** | [**ContentQuickReply**](ContentQuickReply.html) | Quick reply object | [optional] |
| **ButtonResponse** | [**ContentButtonResponse**](ContentButtonResponse.html) | Button response object | [optional] |
| **Generic** | [**ContentGeneric**](ContentGeneric.html) | Generic content object | [optional] |
| **List** | [**ContentList**](ContentList.html) | List content object | [optional] |
| **Template** | [**ContentNotificationTemplate**](ContentNotificationTemplate.html) | Template notification object | [optional] |
| **Reactions** | [**List&lt;ContentReaction&gt;**](ContentReaction.html) | A list of reactions | [optional] |
| **Mention** | [**MessagingRecipient**](MessagingRecipient.html) | This is used to identify who the message is sent to, as well as who it was sent from. This information is channel specific - depends on capabilities to describe party by the platform | [optional] |
| **Postback** | [**ContentPostback**](ContentPostback.html) | The postback object result of a user clicking in a button | [optional] |
{: class="table table-striped"}


