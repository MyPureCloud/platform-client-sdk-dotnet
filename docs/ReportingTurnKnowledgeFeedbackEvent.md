# ReportingTurnKnowledgeFeedbackEvent

## ININ.PureCloudApi.Model.ReportingTurnKnowledgeFeedbackEvent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SearchId** | **string** | The ID of this knowledge search. | [optional] |
| **KnowledgeBaseId** | **string** | The Knowledge Base ID that the captured knowledge data relates to. | [optional] |
| **Documents** | [**List&lt;ReportingTurnKnowledgeDocument&gt;**](ReportingTurnKnowledgeDocument) | The list of search documents that the feedback applies to. | [optional] |
| **FeedbackRating** | **int?** | The feedback rating for the search (1.0 - 5.0). 1 &#x3D; Negative, 5 &#x3D; Positive. | [optional] |
| **DocumentVariationId** | **string** | The variation of the document. | [optional] |
| **DocumentVersionId** | **string** | The version of the document. | [optional] |



_PureCloudPlatform.Client.V2 254.0.0_
