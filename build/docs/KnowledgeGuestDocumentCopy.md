# KnowledgeGuestDocumentCopy

## ININ.PureCloudApi.Model.KnowledgeGuestDocumentCopy

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **DocumentVariationId** | **string** | The variation of the document whose content was copied. | |
| **DocumentVersionId** | **string** | The version of the document whose content was copied. | |
| **SearchId** | **string** | The search that surfaced the document whose content was copied. | [optional] |
| **QueryType** | **string** | The type of the query that surfaced the document. | [optional] |
| **SurfacingMethod** | **string** | The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown. | [optional] |
| **SessionId** | **string** | Knowledge session ID. | [optional] |
| **Application** | [**KnowledgeGuestSearchClientApplication**](KnowledgeGuestSearchClientApplication) | The client application in which the document content was copied. | [optional] |



_PureCloudPlatform.Client.V2 228.0.0_
