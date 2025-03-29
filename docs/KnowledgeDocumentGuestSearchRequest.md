# KnowledgeDocumentGuestSearchRequest

## ININ.PureCloudApi.Model.KnowledgeDocumentGuestSearchRequest

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
| **SessionId** | **string** | Session ID of the search. | [optional] |
| **AnswerHighlightTopResults** | **int?** | The number of articles to be sent for answer-highlighting. Can range from 1-5. | [optional] |
| **IncludeDraftDocuments** | **bool?** | Indicates whether the search results would also include draft documents. | [optional] |



_PureCloudPlatform.Client.V2 230.0.0_
