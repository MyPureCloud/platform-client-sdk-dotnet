# QueueConversationSocialExpressionEventTopicCallback

## ININ.PureCloudApi.Model.QueueConversationSocialExpressionEventTopicCallback

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **State** | **string** |  | [optional] |
| **InitialState** | **string** |  | [optional] |
| **Id** | **string** | A globally unique identifier for this communication. | [optional] |
| **Direction** | **string** | The direction of the call | [optional] |
| **Held** | **bool?** | True if this call is held and the person on this side hears silence. | [optional] |
| **DisconnectType** | **string** | System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects. | [optional] |
| **StartHoldTime** | **DateTime?** | The timestamp the callback was placed on hold in the cloud clock if the callback is currently on hold. | [optional] |
| **DialerPreview** | [**QueueConversationSocialExpressionEventTopicDialerPreview**](QueueConversationSocialExpressionEventTopicDialerPreview) |  | [optional] |
| **Voicemail** | [**QueueConversationSocialExpressionEventTopicVoicemail**](QueueConversationSocialExpressionEventTopicVoicemail) |  | [optional] |
| **CallbackNumbers** | **List&lt;string&gt;** | The phone number(s) to use to place the callback. | [optional] |
| **CallbackUserName** | **string** | The name of the user requesting a callback. | [optional] |
| **ScriptId** | **string** | The UUID of the script to use. | [optional] |
| **PeerId** | **string** | The id of the peer communication corresponding to a matching leg for this communication. | [optional] |
| **ExternalCampaign** | **bool?** | True if the call for the callback uses external dialing. | [optional] |
| **SkipEnabled** | **bool?** | True if the ability to skip a callback should be enabled. | [optional] |
| **Provider** | **string** | The source provider of the callback. | [optional] |
| **TimeoutSeconds** | **long?** | The number of seconds before the system automatically places a call for a callback.  0 means the automatic placement is disabled. | [optional] |
| **ConnectedTime** | **DateTime?** | The timestamp when this communication was connected in the cloud clock. | [optional] |
| **DisconnectedTime** | **DateTime?** | The timestamp when this communication disconnected from the conversation in the provider clock. | [optional] |
| **CallbackScheduledTime** | **DateTime?** | The timestamp when this communication is scheduled in the provider clock. If this value is missing it indicates the callback will be placed immediately. | [optional] |
| **AutomatedCallbackConfigId** | **string** | The id of the config for automatically placing the callback (and handling the disposition). If null, the callback will not be placed automatically but routed to an agent as per normal. | [optional] |
| **Wrapup** | [**QueueConversationSocialExpressionEventTopicWrapup**](QueueConversationSocialExpressionEventTopicWrapup) | Call wrap up or disposition data. | [optional] |
| **AfterCallWork** | [**QueueConversationSocialExpressionEventTopicAfterCallWork**](QueueConversationSocialExpressionEventTopicAfterCallWork) | A communication&#39;s after-call work data. | [optional] |
| **AfterCallWorkRequired** | **bool?** | Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested. | [optional] |
| **CallerId** | **string** | The phone number displayed to recipients of the phone call. The value should conform to the E164 format. | [optional] |
| **CallerIdName** | **string** | The name displayed to recipients of the phone call. | [optional] |
| **QueueMediaSettings** | [**QueueConversationSocialExpressionEventTopicQueueMediaSettings**](QueueConversationSocialExpressionEventTopicQueueMediaSettings) | Represents the queue setting for this media. | [optional] |



_PureCloudPlatform.Client.V2 236.0.0_
