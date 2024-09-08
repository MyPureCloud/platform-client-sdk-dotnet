---
title: KnowledgeSuggestionConfig
---
## ININ.PureCloudApi.Model.KnowledgeSuggestionConfig

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **VendorName** | **string** | The name of vendor used for knowledge suggestions. | |
| **KnowledgeBase** | [**KnowledgeBaseReference**](KnowledgeBaseReference.html) | The ID of knowledge base to query when Genesys is the knowledge suggestions provider. | [optional] |
| **KnowledgeBases** | [**List&lt;KnowledgeBaseWithDialectReference&gt;**](KnowledgeBaseWithDialectReference.html) | The knowledge bases to query based on dialect, when Genesys is the knowledge suggestions provider. | [optional] |
{: class="table table-striped"}


