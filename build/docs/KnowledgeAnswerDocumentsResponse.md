# KnowledgeAnswerDocumentsResponse

## ININ.PureCloudApi.Model.KnowledgeAnswerDocumentsResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Results** | [**List&lt;KnowledgeAnswerDocumentResponse&gt;**](KnowledgeAnswerDocumentResponse) | The results with answers if the answerMode request property is not set or contains \&quot;AnswerHighlight\&quot;. Empty array otherwise. | [optional] |
| **AnswerGeneration** | [**KnowledgeAnswerGenerationResponse**](KnowledgeAnswerGenerationResponse) | The results with AI-generated answer if the answerMode request property contains \&quot;AnswerGeneration\&quot;. | [optional] |



_PureCloudPlatform.Client.V2 229.0.0_
