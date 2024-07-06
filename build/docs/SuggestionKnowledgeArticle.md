---
title: SuggestionKnowledgeArticle
---
## ININ.PureCloudApi.Model.SuggestionKnowledgeArticle

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Title** | **string** | The article title. | [optional] |
| **Snippets** | **List&lt;string&gt;** | Snippets of text from the article matching the query. | [optional] |
| **Document** | [**AddressableEntityRef**](AddressableEntityRef.html) | The article. | [optional] |
| **Version** | [**AddressableEntityRef**](AddressableEntityRef.html) | The version of the article. | [optional] |
| **KnowledgeAnswer** | [**SuggestionKnowledgeAnswer**](SuggestionKnowledgeAnswer.html) | The most relevant answer within the suggested article. | [optional] |
| **Variations** | [**List&lt;AddressableEntityRef&gt;**](AddressableEntityRef.html) | The variations of the article. | [optional] |
{: class="table table-striped"}


