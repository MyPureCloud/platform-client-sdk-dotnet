# WebMessagingContent

## ININ.PureCloudApi.Model.WebMessagingContent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ContentType** | **string** | Type of this content element. If contentType &#x3D; \&quot;Attachment\&quot; only one item is allowed. | [optional] |
| **Attachment** | [**WebMessagingAttachment**](WebMessagingAttachment) | Attachment content. | [optional] |
| **QuickReply** | [**WebMessagingQuickReply**](WebMessagingQuickReply) | Quick reply content. | [optional] |
| **ButtonResponse** | [**WebMessagingButtonResponse**](WebMessagingButtonResponse) | Button response content. | [optional] |
| **Generic** | [**WebMessagingGeneric**](WebMessagingGeneric) | Generic content (Deprecated). | [optional] |
| **Card** | [**ContentCard**](ContentCard) | Card content | [optional] |
| **Carousel** | [**ContentCarousel**](ContentCarousel) | Carousel content | [optional] |
| **DatePicker** | [**ContentDatePicker**](ContentDatePicker) | DatePicker content | [optional] |
| **ListPicker** | [**ConversationContentListPicker**](ConversationContentListPicker) | ListPicker content | [optional] |



_PureCloudPlatform.Client.V2 251.0.0_
