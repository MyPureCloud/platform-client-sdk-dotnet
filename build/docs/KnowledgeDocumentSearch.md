---
title: KnowledgeDocumentSearch
---
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
| **Results** | [**List&lt;KnowledgeDocumentSearchResult&gt;**](KnowledgeDocumentSearchResult.html) | Documents matching the search query. | [optional] |
{: class="table table-striped"}


