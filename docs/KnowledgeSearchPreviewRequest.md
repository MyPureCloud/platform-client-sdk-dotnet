# KnowledgeSearchPreviewRequest

## ININ.PureCloudApi.Model.KnowledgeSearchPreviewRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Query** | **string** | Query to search content in the knowledge sources. | |
| **Sources** | [**List&lt;V3SourceRef&gt;**](V3SourceRef) | Source information to search upon. | |
| **GenerationSetting** | [**KnowledgeGenerationSetting**](KnowledgeGenerationSetting) | Setting for answer generation. | |
| **Stateful** | **bool?** | Indicates if stateful search and generation is enabled for the knowledge setting. | [optional] |
| **ConversationTurns** | [**List&lt;KnowledgeConversationTurn&gt;**](KnowledgeConversationTurn) | List of conversation turns to use for stateful search. | [optional] |



_PureCloudPlatform.Client.V2 258.0.0_
