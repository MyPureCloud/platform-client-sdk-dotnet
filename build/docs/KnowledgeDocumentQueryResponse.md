# KnowledgeDocumentQueryResponse

## ININ.PureCloudApi.Model.KnowledgeDocumentQueryResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PageSize** | **int?** | Page size of the returned results. | [optional] |
| **PageNumber** | **int?** | Page number of the returned results. | [optional] |
| **Total** | **long?** | The total number of documents matching the query. | [optional] |
| **PageCount** | **int?** | The total number of pages of results, calculated according to the pageSize and the total matching documents. | [optional] |
| **Results** | [**List&lt;KnowledgeDocumentResponse&gt;**](KnowledgeDocumentResponse) | Documents matching the query. | [optional] |



_PureCloudPlatform.Client.V2 218.0.0_
