# ChatMessageResponse

## ININ.PureCloudApi.Model.ChatMessageResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The id of the message | |
| **DateCreated** | **DateTime?** | Message&#39;s created time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **DateModified** | **DateTime?** | Message&#39;s last updated time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ToJid** | **string** | Jid of message&#39;s recipient (roomJid or userJid) | |
| **Jid** | **string** | Jid of message&#39;s sender (userJid) | |
| **Body** | **string** | Message&#39;s body | |
| **Mentions** | **Dictionary&lt;string, string&gt;** | Message&#39;s mentions | [optional] |
| **Edited** | **bool?** | If message was edited | [optional] |
| **AttachmentDeleted** | **bool?** | If message&#39;s attachment was deleted | [optional] |
| **FileUri** | **string** | URI of file attachment | [optional] |
| **Thread** | [**Entity**](Entity) | The id for a thread this message corresponds to | |
| **ParentThread** | [**Entity**](Entity) | Parent thread id for thread replies | [optional] |
| **User** | [**AddressableEntityRef**](AddressableEntityRef) | The user who sent the message | [optional] |
| **ToUser** | [**AddressableEntityRef**](AddressableEntityRef) | The receiving user of the message | [optional] |
| **Reactions** | [**List&lt;ChatReaction&gt;**](ChatReaction) | The emoji reactions to this message | [optional] |



_PureCloudPlatform.Client.V2 231.0.0_
