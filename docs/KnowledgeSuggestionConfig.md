# KnowledgeSuggestionConfig

## ININ.PureCloudApi.Model.KnowledgeSuggestionConfig

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **VendorName** | **string** | The name of vendor used for knowledge suggestions. | |
| **KnowledgeBase** | [**KnowledgeBaseReference**](KnowledgeBaseReference) | The ID of knowledge base to query when Genesys is the knowledge suggestions provider. | [optional] |
| **KnowledgeBases** | [**List&lt;KnowledgeBaseWithDialectReference&gt;**](KnowledgeBaseWithDialectReference) | The knowledge bases to query based on dialect, when Genesys is the knowledge suggestions provider. | [optional] |
| **ReceiveSegmentedArticles** | **bool?** | Include segmented articles in knowledge suggestions. | [optional] |



_PureCloudPlatform.Client.V2 254.0.0_
