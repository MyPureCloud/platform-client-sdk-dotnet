# KnowledgeDocumentSearchRequest

## ININ.PureCloudApi.Model.KnowledgeDocumentSearchRequest

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
| **IncludeDraftDocuments** | **bool?** | Indicates whether the search results would also include draft documents. | [optional] |
| **Interval** | [**DocumentQueryInterval**](DocumentQueryInterval) | Retrieves the documents created/modified/published in specified date and time range. | [optional] |
| **Filter** | [**DocumentQuery**](DocumentQuery) | Filter for the document search. | [optional] |
| **SortOrder** | **string** | The sort order for search results. | [optional] |
| **SortBy** | **string** | The field in the documents that you want to sort the search results by. | [optional] |
| **Application** | [**KnowledgeSearchClientApplication**](KnowledgeSearchClientApplication) | The client application details from which search request was sent. | [optional] |
| **ConversationContext** | [**KnowledgeConversationContext**](KnowledgeConversationContext) | Conversation context information if the search is initiated in the context of a conversation. | [optional] |
| **ConfidenceThreshold** | **float?** | The confidence threshold for the search results. If applied, the returned results will have an equal or higher confidence than the threshold. The value should be between 0 to 1. | [optional] |
| **AnswerHighlightTopResults** | **int?** | The number of articles to be sent for answer-highlighting. Can range from 1-5. | [optional] |
| **AnswerMode** | **List&lt;string&gt;** | Allows extracted answers from an article (AnswerHighlight) and/or AI-generated answers (AnswerGeneration). Default mode: AnswerHighlight. Use this property with answerHighlightTopResults. | [optional] |



_PureCloudPlatform.Client.V2 215.1.0_
