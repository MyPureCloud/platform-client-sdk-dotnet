# KnowledgeSourcesSearchRequest

## ININ.PureCloudApi.Model.KnowledgeSourcesSearchRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Query** | **string** | Input query to search content on the knowledge setting. | |
| **KnowledgeSettingId** | **string** | Knowledge Setting Id to use for search request. | |
| **Application** | [**V3KnowledgeSearchClientApplication**](V3KnowledgeSearchClientApplication) | The client application details from which search requested. | [optional] |
| **ConversationContext** | [**KnowledgeV3ConversationContext**](KnowledgeV3ConversationContext) | Conversation context information if the search is initiated in the context of a conversation. | [optional] |
| **SessionId** | **string** | The session id for search request. | [optional] |
| **QueryType** | **string** | The type of the query that initiates the search. | [optional] |
| **GenerationLanguage** | **string** | The language to use for answer generation. | [optional] |
| **ConversationTurns** | [**List&lt;KnowledgeConversationTurn&gt;**](KnowledgeConversationTurn) | List of conversation turns to use for stateful search. | [optional] |



_PureCloudPlatform.Client.V2 262.0.0_
