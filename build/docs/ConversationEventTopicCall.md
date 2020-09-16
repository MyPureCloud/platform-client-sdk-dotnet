---
title: ConversationEventTopicCall
---
## ININ.PureCloudApi.Model.ConversationEventTopicCall

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** |  | [optional] |
| **State** | **string** |  | [optional] |
| **Recording** | **bool?** |  | [optional] |
| **RecordingState** | **string** |  | [optional] |
| **Muted** | **bool?** |  | [optional] |
| **Confined** | **bool?** |  | [optional] |
| **Held** | **bool?** |  | [optional] |
| **ErrorInfo** | [**ConversationEventTopicErrorDetails**](ConversationEventTopicErrorDetails.html) |  | [optional] |
| **DisconnectType** | **string** |  | [optional] |
| **StartHoldTime** | **DateTime?** |  | [optional] |
| **Direction** | **string** |  | [optional] |
| **DocumentId** | **string** |  | [optional] |
| **Self** | [**ConversationEventTopicAddress**](ConversationEventTopicAddress.html) |  | [optional] |
| **Other** | [**ConversationEventTopicAddress**](ConversationEventTopicAddress.html) |  | [optional] |
| **Provider** | **string** |  | [optional] |
| **ScriptId** | **string** |  | [optional] |
| **PeerId** | **string** |  | [optional] |
| **ConnectedTime** | **DateTime?** |  | [optional] |
| **DisconnectedTime** | **DateTime?** |  | [optional] |
| **DisconnectReasons** | [**List&lt;ConversationEventTopicDisconnectReason&gt;**](ConversationEventTopicDisconnectReason.html) |  | [optional] |
| **FaxStatus** | [**ConversationEventTopicFaxStatus**](ConversationEventTopicFaxStatus.html) |  | [optional] |
| **UuiData** | **string** |  | [optional] |
| **Wrapup** | [**ConversationEventTopicWrapup**](ConversationEventTopicWrapup.html) |  | [optional] |
| **AfterCallWork** | [**ConversationEventTopicAfterCallWork**](ConversationEventTopicAfterCallWork.html) |  | [optional] |
| **AfterCallWorkRequired** | **bool?** |  | [optional] |
| **AgentAssistantId** | **string** |  | [optional] |
| **AdditionalProperties** | **Object** |  | [optional] |
{: class="table table-striped"}


