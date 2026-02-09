# KnowledgeGuestDocumentPresentation

## ININ.PureCloudApi.Model.KnowledgeGuestDocumentPresentation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Documents** | [**List&lt;PresentedKnowledgeDocument&gt;**](PresentedKnowledgeDocument) | The presented documents | |
| **SearchId** | **string** | The search that surfaced the documents that were presented. | [optional] |
| **QueryType** | **string** | The type of the query that surfaced the documents. | [optional] |
| **SurfacingMethod** | **string** | The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown.Generative: A generated answer in a snippet was shown. | [optional] |
| **SessionId** | **string** | Knowledge session ID. | [optional] |
| **Application** | [**KnowledgeGuestSearchClientApplication**](KnowledgeGuestSearchClientApplication) | The client application in which the documents were presented. | [optional] |



_PureCloudPlatform.Client.V2 256.0.0_
