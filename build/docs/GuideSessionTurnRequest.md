# GuideSessionTurnRequest

## ININ.PureCloudApi.Model.GuideSessionTurnRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **InputEvent** | [**GuideSessionInputEvent**](GuideSessionInputEvent) | The input event for this turn. | |
| **LanguageCode** | **string** | The language code for this turn. | |
| **Version** | **string** | The version for this turn. | |
| **InputVariables** | [**List&lt;GuideSessionVariable&gt;**](GuideSessionVariable) | The input variables for this turn. | [optional] |
| **KnowledgeSettings** | [**KnowledgeSettings**](KnowledgeSettings) | The knowledge settings for this turn. | [optional] |
| **Context** | [**GuideSessionTurnRequestContext**](GuideSessionTurnRequestContext) | The context for this turn, including conversation custom attributes and messages. | [optional] |



_PureCloudPlatform.Client.V2 275.0.0_
