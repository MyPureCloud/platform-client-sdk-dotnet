# KnowledgeDocumentView

## ININ.PureCloudApi.Model.KnowledgeDocumentView

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **DocumentVariationId** | **string** | The variation of the viewed document. | |
| **DocumentVersionId** | **string** | The version of the viewed document. | |
| **SearchId** | **string** | The search that surfaced the viewed document. | [optional] |
| **QueryType** | **string** | The type of the query that surfaced the document. | [optional] |
| **SurfacingMethod** | **string** | The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown.Generative: A generated answer in a snippet was shown. | [optional] |
| **Application** | [**KnowledgeSearchClientApplication**](KnowledgeSearchClientApplication) | The client application from which the document was viewed. | |
| **SessionId** | **string** | The unique identifier of the knowledge session in which the document was viewed. | [optional] |
| **ConversationContext** | [**KnowledgeConversationContext**](KnowledgeConversationContext) | Conversation context information if the document was viewed in the context of a conversation. | [optional] |



_PureCloudPlatform.Client.V2 254.0.0_
