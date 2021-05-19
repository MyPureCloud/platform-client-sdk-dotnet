---
title: KnowledgeBase
---
## ININ.PureCloudApi.Model.KnowledgeBase

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Description** | **string** | Knowledge base description | [optional] |
| **CoreLanguage** | **string** | Core language for knowledge base in which initial content must be created first | |
| **DateCreated** | **DateTime?** | Knowledge base creation date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Knowledge base last modification date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **FaqCount** | **int?** | The count representing the number of documents of type FAQ in the KnowledgeBase | [optional] |
| **DateDocumentLastModified** | **DateTime?** | The date representing when the last document is modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ArticleCount** | **int?** | The count representing the number of documents of type Article in the KnowledgeBase | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


