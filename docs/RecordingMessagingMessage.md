# RecordingMessagingMessage

## ININ.PureCloudApi.Model.RecordingMessagingMessage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **From** | **string** | The message sender session id. | [optional] |
| **FromUser** | [**User**](User) | The user who sent this message. | [optional] |
| **FromExternalContact** | [**ExternalContact**](ExternalContact) | The PureCloud external contact sender details. | [optional] |
| **To** | **string** | The message recipient. | [optional] |
| **Timestamp** | **DateTime?** | The time when the message was sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Id** | **string** | A globally unique identifier for this communication. | [optional] |
| **Purpose** | **string** | A well known string that specifies the purpose or type of the participant on this communication. | [optional] |
| **ParticipantId** | **string** | A globally unique identifier for the participant on this communication. | [optional] |
| **Queue** | [**AddressableEntityRef**](AddressableEntityRef) | A globally unique identifier for the queue involved in this communication. | [optional] |
| **Workflow** | [**AddressableEntityRef**](AddressableEntityRef) | A globally unique identifier for the workflow involved in this communication. | [optional] |
| **MessageText** | **string** | The content of this message. | [optional] |
| **MessageMediaAttachments** | [**List&lt;MessageMediaAttachment&gt;**](MessageMediaAttachment) | List of media objects attached  with this message. | [optional] |
| **MessageStickerAttachments** | [**List&lt;MessageStickerAttachment&gt;**](MessageStickerAttachment) | List of message stickers attached with this message. | [optional] |
| **QuickReplies** | [**List&lt;QuickReply&gt;**](QuickReply) | List of quick reply options offered with this message. | [optional] |
| **ButtonResponse** | [**ButtonResponse**](ButtonResponse) | Button Response selected by user for this message. | [optional] |
| **Story** | [**RecordingContentStory**](RecordingContentStory) | Ephemeral story content. | [optional] |
| **Cards** | [**List&lt;Card&gt;**](Card) | List of cards offered for this message | [optional] |
| **NotificationTemplate** | [**RecordingNotificationTemplate**](RecordingNotificationTemplate) | Template notification content. | [optional] |
| **ContentType** | **string** | Indicates the content type for this message | [optional] |
| **SocialVisibility** | **string** | For social media messages, the visibility of the message in the originating social platform | [optional] |
| **Events** | [**List&lt;ConversationMessageEvent&gt;**](ConversationMessageEvent) | List of event elements | [optional] |



_PureCloudPlatform.Client.V2 235.0.0_
