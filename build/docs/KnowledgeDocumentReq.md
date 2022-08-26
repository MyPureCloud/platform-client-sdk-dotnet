---
title: KnowledgeDocumentReq
---
## ININ.PureCloudApi.Model.KnowledgeDocumentReq

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Title** | **string** | Document title. | |
| **Visible** | **bool?** | Indicates if the knowledge document should be included in search results. | [optional] |
| **Alternatives** | [**List&lt;KnowledgeDocumentAlternative&gt;**](KnowledgeDocumentAlternative.html) | List of alternate phrases related to the title which improves search results. | [optional] |
| **CategoryId** | **string** | The category associated with the document. | [optional] |
| **LabelIds** | **List&lt;string&gt;** | The ids of labels associated with the document. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


