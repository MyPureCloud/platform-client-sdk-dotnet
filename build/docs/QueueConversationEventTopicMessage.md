---
title: QueueConversationEventTopicMessage
---
## ININ.PureCloudApi.Model.QueueConversationEventTopicMessage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** |  | [optional] |
| **State** | **string** |  | [optional] |
| **Held** | **bool?** |  | [optional] |
| **ErrorInfo** | [**QueueConversationEventTopicErrorDetails**](QueueConversationEventTopicErrorDetails.html) |  | [optional] |
| **Provider** | **string** |  | [optional] |
| **ScriptId** | **string** |  | [optional] |
| **PeerId** | **string** |  | [optional] |
| **DisconnectType** | **string** |  | [optional] |
| **StartHoldTime** | **DateTime?** |  | [optional] |
| **ConnectedTime** | **DateTime?** |  | [optional] |
| **DisconnectedTime** | **DateTime?** |  | [optional] |
| **ToAddress** | [**QueueConversationEventTopicAddress**](QueueConversationEventTopicAddress.html) |  | [optional] |
| **FromAddress** | [**QueueConversationEventTopicAddress**](QueueConversationEventTopicAddress.html) |  | [optional] |
| **Messages** | [**List&lt;QueueConversationEventTopicMessageDetails&gt;**](QueueConversationEventTopicMessageDetails.html) |  | [optional] |
| **MessagesTranscriptUri** | **string** |  | [optional] |
| **Type** | **string** |  | [optional] |
| **RecipientCountry** | **string** |  | [optional] |
| **RecipientType** | **string** |  | [optional] |
| **Wrapup** | [**QueueConversationEventTopicWrapup**](QueueConversationEventTopicWrapup.html) |  | [optional] |
| **AfterCallWork** | [**QueueConversationEventTopicAfterCallWork**](QueueConversationEventTopicAfterCallWork.html) |  | [optional] |
| **AdditionalProperties** | **Object** |  | [optional] |
{: class="table table-striped"}


