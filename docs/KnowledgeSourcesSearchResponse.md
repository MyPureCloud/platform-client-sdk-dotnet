# KnowledgeSourcesSearchResponse

## ININ.PureCloudApi.Model.KnowledgeSourcesSearchResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Query** | **string** | Query to search content in the knowledge base. | [optional] |
| **SearchId** | **string** | The globally unique identifier for the search. | [optional] |
| **SessionId** | **string** | The sessionId for search request. | [optional] |
| **Result** | [**KnowledgeSearchResult**](KnowledgeSearchResult) | Content matching the search query. | [optional] |
| **KnowledgeSettingId** | **string** | Knowledge Setting Id used for the search request. | [optional] |
| **ConversationContext** | [**KnowledgeV3ConversationContextResponse**](KnowledgeV3ConversationContextResponse) | Conversation context information if the search is initiated in the context of a conversation. | [optional] |
| **Application** | [**V3KnowledgeSearchClientApplication**](V3KnowledgeSearchClientApplication) | The client application details from which search happened. | [optional] |
| **QueryType** | **string** | The type of the query that initiates the search. | [optional] |
| **GenerationLanguage** | **string** | The language used for answer generation. | [optional] |
| **AnswerGeneration** | **bool?** | Indicates if answer generation was enabled for the setting. | [optional] |



_PureCloudPlatform.Client.V2 261.0.0_
