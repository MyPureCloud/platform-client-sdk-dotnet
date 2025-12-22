# KnowledgeDocumentChunkRequest

## ININ.PureCloudApi.Model.KnowledgeDocumentChunkRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Query** | **string** | Query to search chunks in the knowledge base. | |
| **PageSize** | **int?** | Page size of the returned results. | [optional] |
| **PageNumber** | **int?** | Page number of the returned results. | [optional] |
| **Filter** | [**DocumentQuery**](DocumentQuery) | Filter for the document chunks. | [optional] |
| **QueryType** | **string** | The type of the query that initiates the chunks search. | [optional] |
| **PreprocessQuery** | **bool?** | Indicates whether the chunks search query should be preprocessed. | [optional] |
| **IncludeDraftDocuments** | **bool?** | Indicates whether the chunk results would also include draft documents. | [optional] |
| **Application** | [**KnowledgeSearchClientApplication**](KnowledgeSearchClientApplication) | The client application details from which chunks request was sent. | [optional] |
| **ConversationContext** | [**KnowledgeConversationContext**](KnowledgeConversationContext) | Conversation context information if the chunks search is initiated in the context of a conversation. | [optional] |
| **ConfidenceThreshold** | **float?** | The confidence threshold for the chunk results. If applied, the returned results will have an equal or higher confidence than the threshold. The value should be between 0 to 1. | [optional] |



_PureCloudPlatform.Client.V2 252.0.0_
