---
title: KnowledgeSearchRequest
---
## ININ.PureCloudApi.Model.KnowledgeSearchRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Query** | **string** | Input query to search content in the knowledge base | |
| **PageSize** | **int?** | Page size of the returned results | |
| **PageNumber** | **int?** | Page number of the returned results | |
| **DocumentType** | **string** | Document type to be used while searching | |
| **LanguageCode** | **string** | query search for specific languageCode | |
| **SearchOnDraftDocuments** | **bool?** | If true the search query will be executed on draft documents, else it will be on active documents | [optional] |
{: class="table table-striped"}


