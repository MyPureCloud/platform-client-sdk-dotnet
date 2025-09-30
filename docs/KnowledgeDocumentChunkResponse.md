# KnowledgeDocumentChunkResponse

## ININ.PureCloudApi.Model.KnowledgeDocumentChunkResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Query** | **string** | Query to search chunks in the knowledge base. | [optional] |
| **Total** | **int?** | The total number of chunks matching the query. | [optional] |
| **PageCount** | **int?** | Number of pages returned in the result calculated according to the pageSize and the total | [optional] |
| **PageSize** | **int?** | Page size of the returned results. | [optional] |
| **PageNumber** | **int?** | Page number of the returned results. | [optional] |
| **QueryType** | **string** | The type of the query that initiates the chunks search. | [optional] |
| **SearchId** | **string** | The globally unique identifier for the chunks search. | [optional] |
| **PreprocessQuery** | **bool?** | Indicates whether the chunks search query should be preprocessed. | [optional] |
| **ConfidenceThreshold** | **float?** | The confidence threshold for the chunk results. If applied, the returned results will have an equal or higher chunk confidence than the threshold. | [optional] |
| **Results** | [**List&lt;DocumentChunkBlock&gt;**](DocumentChunkBlock) | Chunks matching the search query. | [optional] |
| **Application** | [**KnowledgeSearchClientApplication**](KnowledgeSearchClientApplication) | The client application details from which chunks search happened. | [optional] |
| **ConversationContext** | [**KnowledgeConversationContextResponse**](KnowledgeConversationContextResponse) | Conversation context information if the chunks search is initiated in the context of a conversation. | [optional] |



_PureCloudPlatform.Client.V2 244.0.0_
