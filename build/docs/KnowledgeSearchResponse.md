---
title: KnowledgeSearchResponse
---
## ININ.PureCloudApi.Model.KnowledgeSearchResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Total** | **int?** | Total number of records returned | [optional] |
| **PageCount** | **int?** | Number of pages returned in the result calculated according to the pageSize and the total | [optional] |
| **PageSize** | **int?** | Number of records according to the page size | [optional] |
| **PageNumber** | **int?** | Current page number for the returned records | [optional] |
| **SearchId** | **string** | ID of the Search Response | [optional] |
| **Results** | [**List&lt;KnowledgeSearchDocument&gt;**](KnowledgeSearchDocument.html) | Results associated to the search response | [optional] |
{: class="table table-striped"}


