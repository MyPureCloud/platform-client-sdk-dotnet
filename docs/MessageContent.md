# MessageContent

## ININ.PureCloudApi.Model.MessageContent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ContentType** | **string** | Type of this content element. | |
| **Location** | [**ContentLocation**](ContentLocation) | Location content. | [optional] |
| **Attachment** | [**ContentAttachment**](ContentAttachment) | Attachment content. | [optional] |
| **QuickReply** | [**ContentQuickReply**](ContentQuickReply) | Quick reply content. | [optional] |
| **ButtonResponse** | [**ContentButtonResponse**](ContentButtonResponse) | Button response content. | [optional] |
| **Generic** | [**ContentGeneric**](ContentGeneric) | Generic content (Deprecated). | [optional] |
| **List** | [**ContentList**](ContentList) | List content (Deprecated). | [optional] |
| **Template** | [**ContentNotificationTemplate**](ContentNotificationTemplate) | Template notification content. | [optional] |
| **Reactions** | [**List&lt;ContentReaction&gt;**](ContentReaction) | A set of reactions to a message. | [optional] |
| **Mention** | [**MessagingRecipient**](MessagingRecipient) | Mention content. | [optional] |
| **Postback** | [**ContentPostback**](ContentPostback) | Structured message postback (Deprecated). | [optional] |
| **Story** | [**ContentStory**](ContentStory) | Ephemeral story content. | [optional] |
| **Card** | [**ContentCard**](ContentCard) | Card content | [optional] |
| **Carousel** | [**ContentCarousel**](ContentCarousel) | Carousel content | [optional] |
| **Text** | [**ContentText**](ContentText) | Text content. | [optional] |
| **QuickReplyV2** | [**ContentQuickReplyV2**](ContentQuickReplyV2) | Quick reply V2 content. | [optional] |



_PureCloudPlatform.Client.V2 222.0.0_
