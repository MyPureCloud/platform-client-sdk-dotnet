---
title: KnowledgeDocumentSearchRequest
---
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
| **IncludeDraftDocuments** | **bool?** | Indicates whether the search results would also include draft documents. | [optional] |
| **Interval** | [**DocumentQueryInterval**](DocumentQueryInterval.html) | Retrieves the documents created/modified/published in specified date and time range. | [optional] |
| **Filter** | [**DocumentQuery**](DocumentQuery.html) | Filter for the document search. | [optional] |
| **SortOrder** | **string** | The sort order for search results. | [optional] |
| **SortBy** | **string** | The field in the documents that you want to sort the search results by. | [optional] |
| **Application** | [**KnowledgeSearchClientApplication**](KnowledgeSearchClientApplication.html) | The client application details from which search request was sent. | [optional] |
{: class="table table-striped"}


