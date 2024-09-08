---
title: KnowledgeAnswerDocumentsResponse
---
## ININ.PureCloudApi.Model.KnowledgeAnswerDocumentsResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Results** | [**List&lt;KnowledgeAnswerDocumentResponse&gt;**](KnowledgeAnswerDocumentResponse.html) | The results with answers if the answerMode request property is not set or contains \&quot;AnswerHighlight\&quot;. Empty array otherwise. | [optional] |
| **AnswerGeneration** | [**KnowledgeAnswerGenerationResponse**](KnowledgeAnswerGenerationResponse.html) | The results with AI-generated answer if the answerMode request property contains \&quot;AnswerGeneration\&quot;. | [optional] |
{: class="table table-striped"}


