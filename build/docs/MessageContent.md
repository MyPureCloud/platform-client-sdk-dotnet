---
title: MessageContent
---
## ININ.PureCloudApi.Model.MessageContent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ContentType** | **string** | Type of this content element. | |
| **Location** | [**ContentLocation**](ContentLocation.html) | Location content. | [optional] |
| **Attachment** | [**ContentAttachment**](ContentAttachment.html) | Attachment content. | [optional] |
| **QuickReply** | [**ContentQuickReply**](ContentQuickReply.html) | Quick reply content. | [optional] |
| **ButtonResponse** | [**ContentButtonResponse**](ContentButtonResponse.html) | Button response content. | [optional] |
| **Generic** | [**ContentGeneric**](ContentGeneric.html) | Generic content (Deprecated). | [optional] |
| **List** | [**ContentList**](ContentList.html) | List content (Deprecated). | [optional] |
| **Template** | [**ContentNotificationTemplate**](ContentNotificationTemplate.html) | Template notification content. | [optional] |
| **Reactions** | [**List&lt;ContentReaction&gt;**](ContentReaction.html) | A set of reactions to a message. | [optional] |
| **Mention** | [**MessagingRecipient**](MessagingRecipient.html) | Mention content. | [optional] |
| **Postback** | [**ContentPostback**](ContentPostback.html) | Structured message postback (Deprecated). | [optional] |
| **Story** | [**ContentStory**](ContentStory.html) | Ephemeral story content. | [optional] |
| **Card** | [**ContentCard**](ContentCard.html) | Card content | [optional] |
| **Carousel** | [**ContentCarousel**](ContentCarousel.html) | Carousel content | [optional] |
| **Text** | [**ContentText**](ContentText.html) | Text content. | [optional] |
| **QuickReplyV2** | [**ContentQuickReplyV2**](ContentQuickReplyV2.html) | Quick reply V2 content. | [optional] |
{: class="table table-striped"}


