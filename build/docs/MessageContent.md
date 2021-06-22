---
title: MessageContent
---
## ININ.PureCloudApi.Model.MessageContent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ContentType** | **string** | Type of this content element. If contentType = \&quot;Attachment\&quot; only one item is allowed. | |
| **Location** | [**ContentLocation**](ContentLocation.html) | Location content. | [optional] |
| **Attachment** | [**ContentAttachment**](ContentAttachment.html) | Attachment content. | [optional] |
| **QuickReply** | [**ContentQuickReply**](ContentQuickReply.html) | Quick reply content. | [optional] |
| **ButtonResponse** | [**ContentButtonResponse**](ContentButtonResponse.html) | Button response content. | [optional] |
| **Generic** | [**ContentGeneric**](ContentGeneric.html) | Generic content. | [optional] |
| **List** | [**ContentList**](ContentList.html) | List content. | [optional] |
| **Template** | [**ContentNotificationTemplate**](ContentNotificationTemplate.html) | Template notification content. | [optional] |
| **Reactions** | [**List&lt;ContentReaction&gt;**](ContentReaction.html) | A set of reactions to a message. | [optional] |
| **Mention** | [**MessagingRecipient**](MessagingRecipient.html) | Mention content. | [optional] |
| **Postback** | [**ContentPostback**](ContentPostback.html) | Structured message postback (Deprecated). | [optional] |
{: class="table table-striped"}


