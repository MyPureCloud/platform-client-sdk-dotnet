---
title: KnowledgeDocumentBulkRequest
---
## ININ.PureCloudApi.Model.KnowledgeDocumentBulkRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | Document type according to assigned template | |
| **ExternalUrl** | **string** | External Url to the document | [optional] |
| **Faq** | [**DocumentFaq**](DocumentFaq.html) | Faq document details | [optional] |
| **Categories** | [**List&lt;DocumentCategoryInput&gt;**](DocumentCategoryInput.html) | Document categories | [optional] |
| **Id** | **string** | Identifier of document for update. Omit for create new Document. | [optional] |
{: class="table table-striped"}


