# ReportingTurnKnowledgeMetadata

## ININ.PureCloudApi.Model.ReportingTurnKnowledgeMetadata

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **KnowledgeId** | **string** | The ID of the knowledge setting or knowledge base | [optional] |
| **KnowledgeName** | **string** | The name of the knowledge setting or knowledge base | [optional] |
| **SearchId** | **string** | SearchID used in the attempted search | [optional] |
| **Query** | **string** | The query used in the knowledge query | [optional] |
| **RetrievalStatus** | **string** | The result of the knowledge search | [optional] |
| **AnswerGenerationStatus** | **string** | The result of the knowledge generation | [optional] |
| **GeneratedAnswer** | **string** | The generated answer | [optional] |
| **FailureReason** | **string** | Failure reason if knowledge query failed | [optional] |
| **TopConfidence** | **double?** | Highest confidence score of returned knowledgeSources | [optional] |
| **RetrievedSources** | [**List&lt;KnowledgeSource&gt;**](KnowledgeSource) | List of the sources retrieved by the knowledge search | [optional] |



_PureCloudPlatform.Client.V2 270.0.0_
