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
| **Generic** | [**ContentGeneric**](ContentGeneric.html) | Generic content object | [optional] |
| **List** | [**ContentList**](ContentList.html) | List content object | [optional] |
| **Template** | [**ContentNotificationTemplate**](ContentNotificationTemplate.html) | Template notification object | [optional] |
{: class="table table-striped"}


