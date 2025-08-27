# KnowledgeSearchResponse

## ININ.PureCloudApi.Model.KnowledgeSearchResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SearchId** | **string** | Search Id | [optional] |
| **Total** | **int?** | Total number of records returned | [optional] |
| **PageCount** | **int?** | Number of pages returned in the result calculated according to the pageSize and the total | [optional] |
| **PageSize** | **int?** | Number of records according to the page size | [optional] |
| **PageNumber** | **int?** | Current page number for the returned records | [optional] |
| **Results** | [**List&lt;KnowledgeSearchDocumentV1&gt;**](KnowledgeSearchDocumentV1) | Results associated to the search response | [optional] |



_PureCloudPlatform.Client.V2 241.0.0_
