---
title: KnowledgeDocumentSuggestionRequest
---
## ININ.PureCloudApi.Model.KnowledgeDocumentSuggestionRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Query** | **string** | Query to get autocomplete suggestions for the matching knowledge documents. | |
| **PageSize** | **int?** | Page size of the returned results. | [optional] |
| **IncludeDraftDocuments** | **bool?** | Indicates whether the suggestion results would also include draft documents. | [optional] |
| **Interval** | [**DocumentQueryInterval**](DocumentQueryInterval.html) | Retrieves the documents created/modified/published in specified date and time range. | [optional] |
| **Filter** | [**DocumentQuery**](DocumentQuery.html) | Filter for the document suggestions. | [optional] |
{: class="table table-striped"}


