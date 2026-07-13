# KnowledgeSearchPreviewResponse

## ININ.PureCloudApi.Model.KnowledgeSearchPreviewResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Query** | **string** | Query to search content in the knowledge base. | [optional] |
| **SearchId** | **string** | The globally unique identifier for the search. | [optional] |
| **SessionId** | **string** | The sessionId for search request. | [optional] |
| **Result** | [**KnowledgeSearchResult**](KnowledgeSearchResult) | Content matching the search query. | [optional] |
| **Application** | [**V3KnowledgeSearchPreviewClientApplication**](V3KnowledgeSearchPreviewClientApplication) | The touchpoint application used for the preview. | [optional] |
| **ConversationContext** | [**KnowledgeV3PreviewConversationContext**](KnowledgeV3PreviewConversationContext) | The channel context used for the preview. | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
