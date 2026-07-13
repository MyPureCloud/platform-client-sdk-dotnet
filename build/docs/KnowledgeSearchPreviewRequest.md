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
| **Filter** | [**V3SourceTagFilter**](V3SourceTagFilter) | Composite tag filter applied to the search preview. | [optional] |
| **Application** | [**V3KnowledgeSearchPreviewClientApplication**](V3KnowledgeSearchPreviewClientApplication) | The touchpoint application to simulate for the preview. | [optional] |
| **ConversationContext** | [**KnowledgeV3PreviewConversationContext**](KnowledgeV3PreviewConversationContext) | The channel context to simulate for the preview. | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
