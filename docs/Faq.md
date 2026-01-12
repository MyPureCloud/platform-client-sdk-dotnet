# Faq

## ININ.PureCloudApi.Model.Faq

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Question** | **string** | Question from the knowledge base that was matched to user request. | [optional] |
| **Answer** | **string** | Answer from the knowledge base corresponding to the identified question. | [optional] |
| **SourceUri** | **string** | A URI uniquely identifying the document, e.g. projects/acme-inc/knowledgeBases/MTAyNjgxNDU1Nzc3NTM1NzU0MjQ/documents/MTI5ODc3NzQzOTQ5MTc5NzgxMTI. | [optional] |
| **DocumentUrl** | **string** | URL pointing to a web page if document was sourced from a URL. | [optional] |
| **DocumentDisplayName** | **string** | A human-readable description of the document, e.g. &#39;Sample store FAQ&#39; | [optional] |
| **Confidence** | **float?** | Value between 0 and 1. 1 corresponds to very confident, 0 to not confident at all | [optional] |



_PureCloudPlatform.Client.V2 253.0.0_
