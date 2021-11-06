---
title: ConversationMessageContent
---
## ININ.PureCloudApi.Model.ConversationMessageContent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ContentType** | **string** | Type of this content element. If contentType = \&quot;Attachment\&quot; only one item is allowed. | |
| **Location** | [**ConversationContentLocation**](ConversationContentLocation.html) | Location content. | [optional] |
| **Story** | [**ConversationContentStory**](ConversationContentStory.html) | Ephemeral story content. | [optional] |
| **Attachment** | [**ConversationContentAttachment**](ConversationContentAttachment.html) | Attachment content. | [optional] |
| **QuickReply** | [**ConversationContentQuickReply**](ConversationContentQuickReply.html) | Quick reply content. | [optional] |
| **Template** | [**ConversationContentNotificationTemplate**](ConversationContentNotificationTemplate.html) | Template notification content. | [optional] |
| **ButtonResponse** | [**ConversationContentButtonResponse**](ConversationContentButtonResponse.html) | Button response content. | [optional] |
| **Generic** | [**ConversationContentGeneric**](ConversationContentGeneric.html) | Generic Template Object | [optional] |
{: class="table table-striped"}


