# KnowledgeDocumentGuestSearch

## ININ.PureCloudApi.Model.KnowledgeDocumentGuestSearch

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
| **Results** | [**List&lt;KnowledgeDocumentGuestSearchResult&gt;**](KnowledgeDocumentGuestSearchResult) | Documents that matched the search query. | [optional] |



_PureCloudPlatform.Client.V2 222.0.0_
