# KnowledgeDocumentQuery

## ININ.PureCloudApi.Model.KnowledgeDocumentQuery

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PageSize** | **int?** | Page size of the returned results. | [optional] |
| **PageNumber** | **int?** | Page number of the returned results. | [optional] |
| **IncludeDraftDocuments** | **bool?** | Indicates whether the results would also include draft documents. | [optional] |
| **Interval** | [**DocumentQueryInterval**](DocumentQueryInterval) | Retrieves the documents created/modified/published in specified date and time range. | [optional] |
| **Filter** | [**DocumentQuery**](DocumentQuery) | Filter for the document query. | |
| **IncludeVariations** | **string** | Indicates which document variations to include in returned documents. All: all variations regardless of the filter expression; AllMatching: all variations that match the filter expression; SingleMostRelevant: single variation that matches the filter expression and has the highest priority. The default is All. | [optional] |
| **SortOrder** | **string** | The sort order for results. | [optional] |
| **SortBy** | **string** | The field in the documents that you want to sort the results by. | [optional] |



_PureCloudPlatform.Client.V2 249.0.0_
