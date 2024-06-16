---
title: RecordingMessagingMessage
---
## ININ.PureCloudApi.Model.RecordingMessagingMessage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **From** | **string** | The message sender session id. | [optional] |
| **FromUser** | [**User**](User.html) | The user who sent this message. | [optional] |
| **FromExternalContact** | [**ExternalContact**](ExternalContact.html) | The PureCloud external contact sender details. | [optional] |
| **To** | **string** | The message recipient. | [optional] |
| **Timestamp** | **DateTime?** | The time when the message was sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Id** | **string** | A globally unique identifier for this communication. | [optional] |
| **Purpose** | **string** | A well known string that specifies the purpose or type of the participant on this communication. | [optional] |
| **ParticipantId** | **string** | A globally unique identifier for the participant on this communication. | [optional] |
| **Queue** | [**AddressableEntityRef**](AddressableEntityRef.html) | A globally unique identifier for the queue involved in this communication. | [optional] |
| **Workflow** | [**AddressableEntityRef**](AddressableEntityRef.html) | A globally unique identifier for the workflow involved in this communication. | [optional] |
| **MessageText** | **string** | The content of this message. | [optional] |
| **MessageMediaAttachments** | [**List&lt;MessageMediaAttachment&gt;**](MessageMediaAttachment.html) | List of media objects attached  with this message. | [optional] |
| **MessageStickerAttachments** | [**List&lt;MessageStickerAttachment&gt;**](MessageStickerAttachment.html) | List of message stickers attached with this message. | [optional] |
| **QuickReplies** | [**List&lt;QuickReply&gt;**](QuickReply.html) | List of quick reply options offered with this message. | [optional] |
| **ButtonResponse** | [**ButtonResponse**](ButtonResponse.html) | Button Response selected by user for this message. | [optional] |
| **Story** | [**RecordingContentStory**](RecordingContentStory.html) | Ephemeral story content. | [optional] |
| **Cards** | [**List&lt;Card&gt;**](Card.html) | List of cards offered for this message | [optional] |
| **ContentType** | **string** | Indicates the content type for this message | [optional] |
{: class="table table-striped"}


