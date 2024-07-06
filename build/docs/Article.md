---
title: Article
---
## ININ.PureCloudApi.Model.Article

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Title** | **string** | The article title. | [optional] |
| **Uri** | **string** | The URI for the article. | [optional] |
| **Snippets** | **List&lt;string&gt;** | This contains snippets of text from the article matching the query. | [optional] |
| **Confidence** | **float?** | Value between 0 and 1. 1 corresponds to very confident, 0 to not confident at all. | [optional] |
| **Metadata** | [**Dictionary&lt;string, MetadataAttribute&gt;**](MetadataAttribute.html) | A map that contains custom metadata about the article answer. | [optional] |
| **Version** | [**AddressableEntityRef**](AddressableEntityRef.html) | The version of the Article. | [optional] |
| **Variations** | [**List&lt;AddressableEntityRef&gt;**](AddressableEntityRef.html) | Variations of the Article. | [optional] |
{: class="table table-striped"}


