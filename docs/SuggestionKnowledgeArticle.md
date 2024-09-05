# SuggestionKnowledgeArticle

## ININ.PureCloudApi.Model.SuggestionKnowledgeArticle

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Title** | **string** | The article title. | [optional] |
| **Snippets** | **List&lt;string&gt;** | Snippets of text from the article matching the query. | [optional] |
| **Document** | [**AddressableEntityRef**](AddressableEntityRef) | The article. | [optional] |
| **Version** | [**AddressableEntityRef**](AddressableEntityRef) | The version of the article. | [optional] |
| **KnowledgeAnswer** | [**SuggestionKnowledgeAnswer**](SuggestionKnowledgeAnswer) | The most relevant answer within the suggested article. | [optional] |
| **Variations** | [**List&lt;AddressableEntityRef&gt;**](AddressableEntityRef) | The variations of the article. | [optional] |



_PureCloudPlatform.Client.V2 214.0.0_
