# KnowledgeDocumentSearch

## ININ.PureCloudApi.Model.KnowledgeDocumentSearch

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Query** | **string** | Query to search content in the knowledge base. Maximum of 30 records per query can be fetched. | |
| **PageSize** | **int?** | Page size of the returned results. | [optional] |
| **PageNumber** | **int?** | Page number of the returned results. | [optional] |
| **SearchId** | **string** | The globally unique identifier for the search. | [optional] |
| **Total** | **int?** | The total number of documents matching the query. | [optional] |
| **PageCount** | **int?** | Number of pages returned in the result calculated according to the pageSize and the total | [optional] |
| **QueryType** | **string** | The type of the query that initiates the search. | [optional] |
| **Results** | [**List&lt;KnowledgeDocumentSearchResult&gt;**](KnowledgeDocumentSearchResult) | Documents matching the search query. | [optional] |
| **Application** | [**KnowledgeSearchClientApplication**](KnowledgeSearchClientApplication) | The client application details from which search happened. | [optional] |
| **ConversationContext** | [**KnowledgeConversationContextResponse**](KnowledgeConversationContextResponse) | Conversation context information if the search is initiated in the context of a conversation. | [optional] |
| **ConfidenceThreshold** | **float?** | The confidence threshold for the search results. If applied, the returned results will have an equal or higher confidence than the threshold. | [optional] |
| **AnswerGeneration** | [**KnowledgeAnswerGenerationResponse**](KnowledgeAnswerGenerationResponse) | The results with AI-generated answer if the answerMode request property contains \&quot;AnswerGeneration\&quot;. | [optional] |
| **PreprocessQuery** | **bool?** | Indicates whether the search query should be preprocessed. | [optional] |



_PureCloudPlatform.Client.V2 246.0.0_
