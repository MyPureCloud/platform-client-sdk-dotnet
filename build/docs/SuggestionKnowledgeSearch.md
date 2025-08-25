# SuggestionKnowledgeSearch

## ININ.PureCloudApi.Model.SuggestionKnowledgeSearch

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Title** | **string** | The article title. | [optional] |
| **Snippets** | **List&lt;string&gt;** | Snippets of text from the article matching the query. | [optional] |
| **Confidence** | **float?** | Value between 0 and 1. 1 corresponds to very confident, 0 to not confident at all. | [optional] |
| **SearchId** | **string** | The search id. | [optional] |
| **Document** | [**AddressableEntityRef**](AddressableEntityRef) | The article matching the query. | [optional] |
| **Version** | [**AddressableEntityRef**](AddressableEntityRef) | The version of the article. | [optional] |
| **KnowledgeAnswer** | [**SuggestionKnowledgeAnswer**](SuggestionKnowledgeAnswer) | The most relevant answer within a searched article for the searched query | [optional] |
| **Variations** | [**List&lt;AddressableEntityRef&gt;**](AddressableEntityRef) | Variations of the article. | [optional] |



_PureCloudPlatform.Client.V2 240.0.0_
