# GuideSessionTurnRequestContext

## ININ.PureCloudApi.Model.GuideSessionTurnRequestContext

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **CustomConversationAttributes** | [**List&lt;CustomConversationAttributeInput&gt;**](CustomConversationAttributeInput) | The Conversation Custom Attributes schemas and records available for this turn. | [optional] |
| **Messages** | [**List&lt;GuideSessionMessage&gt;**](GuideSessionMessage) | The conversation history that occurred before this guide session. | [optional] |
| **KnowledgeQueryDetected** | **bool?** | Whether a knowledge query was detected in the previous conversation turns. | [optional] |



_PureCloudPlatform.Client.V2 275.0.0_
