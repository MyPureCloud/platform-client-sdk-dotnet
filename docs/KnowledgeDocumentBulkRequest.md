# KnowledgeDocumentBulkRequest

## ININ.PureCloudApi.Model.KnowledgeDocumentBulkRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | Document type according to assigned template | |
| **ExternalUrl** | **string** | External Url to the document | [optional] |
| **Faq** | [**DocumentFaq**](DocumentFaq) | Faq document details | [optional] |
| **Categories** | [**List&lt;DocumentCategoryInput&gt;**](DocumentCategoryInput) | Document categories | [optional] |
| **Article** | [**DocumentArticle**](DocumentArticle) | Article details | [optional] |
| **Id** | **string** | Identifier of document for update. Omit for create new Document. | [optional] |



_PureCloudPlatform.Client.V2 234.0.0_
