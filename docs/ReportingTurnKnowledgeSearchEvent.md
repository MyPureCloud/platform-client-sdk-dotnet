# ReportingTurnKnowledgeSearchEvent

## ININ.PureCloudApi.Model.ReportingTurnKnowledgeSearchEvent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SearchId** | **string** | The ID of this knowledge search. | [optional] |
| **KnowledgeBaseId** | **string** | The Knowledge Base ID that the captured knowledge data relates to. | [optional] |
| **Documents** | [**List&lt;ReportingTurnKnowledgeDocument&gt;**](ReportingTurnKnowledgeDocument) | The list of search documents that the feedback applies to. | [optional] |
| **SearchQuery** | **string** | The search query that was used to search the Knowledge Base documents for a matching question. | [optional] |
| **AnswerDocumentId** | **string** | The document ID of the search answer. | [optional] |



_PureCloudPlatform.Client.V2 257.0.0_
