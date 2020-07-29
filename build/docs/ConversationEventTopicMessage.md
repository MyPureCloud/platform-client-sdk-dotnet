---
title: ConversationEventTopicMessage
---
## ININ.PureCloudApi.Model.ConversationEventTopicMessage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** |  | [optional] |
| **State** | **string** |  | [optional] |
| **Held** | **bool?** |  | [optional] |
| **ErrorInfo** | [**ConversationEventTopicErrorDetails**](ConversationEventTopicErrorDetails.html) |  | [optional] |
| **Provider** | **string** |  | [optional] |
| **ScriptId** | **string** |  | [optional] |
| **PeerId** | **string** |  | [optional] |
| **DisconnectType** | **string** |  | [optional] |
| **StartHoldTime** | **DateTime?** |  | [optional] |
| **ConnectedTime** | **DateTime?** |  | [optional] |
| **DisconnectedTime** | **DateTime?** |  | [optional] |
| **ToAddress** | [**ConversationEventTopicAddress**](ConversationEventTopicAddress.html) |  | [optional] |
| **FromAddress** | [**ConversationEventTopicAddress**](ConversationEventTopicAddress.html) |  | [optional] |
| **Messages** | [**List&lt;ConversationEventTopicMessageDetails&gt;**](ConversationEventTopicMessageDetails.html) |  | [optional] |
| **MessagesTranscriptUri** | **string** |  | [optional] |
| **Type** | **string** |  | [optional] |
| **RecipientCountry** | **string** |  | [optional] |
| **RecipientType** | **string** |  | [optional] |
| **Wrapup** | [**ConversationEventTopicWrapup**](ConversationEventTopicWrapup.html) |  | [optional] |
| **AdditionalProperties** | **Object** |  | [optional] |
{: class="table table-striped"}


