# KnowledgeDocumentCopy

## ININ.PureCloudApi.Model.KnowledgeDocumentCopy

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **DocumentVariationId** | **string** | The variation of the document whose content was copied. | |
| **DocumentVersionId** | **string** | The version of the document whose content was copied. | |
| **SearchId** | **string** | The search that surfaced the document whose content was copied. | [optional] |
| **QueryType** | **string** | The type of the query that surfaced the document. | [optional] |
| **SurfacingMethod** | **string** | The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown. | [optional] |
| **SessionId** | **string** | Knowledge session ID. | [optional] |
| **ConversationContext** | [**KnowledgeConversationContext**](KnowledgeConversationContext) | Conversation context information, if the document content is copied in the context of a conversation. | [optional] |
| **Application** | [**KnowledgeSearchClientApplication**](KnowledgeSearchClientApplication) | The client application in which the document content was copied. | |



_PureCloudPlatform.Client.V2 231.1.0_
