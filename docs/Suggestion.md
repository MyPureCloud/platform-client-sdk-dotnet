# Suggestion

## ININ.PureCloudApi.Model.Suggestion

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Type** | **string** | The type of the documents for which the suggestion is. | [optional] |
| **Faq** | [**Faq**](Faq) | The Faq from the knowledgebase that was provided as the suggestion. | [optional] |
| **Article** | [**Article**](Article) | The article from the knowledgebase that was provided as the suggestion. | [optional] |
| **DateCreated** | **DateTime?** | Date when the suggestion was created. For example: yyyy-MM-ddTHH:mm:ss.SSZ. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **AnswerRecordId** | **string** | The ID of the knowledge search that provided the suggestion. | [optional] |
| **TriggerType** | **string** | The trigger type of the suggestion. | [optional] |
| **Context** | [**SuggestionContext**](SuggestionContext) | The conversation context in which the suggestion was raised. | [optional] |
| **State** | **string** | The state of the suggestion. | [optional] |
| **KnowledgeSearch** | [**SuggestionKnowledgeSearch**](SuggestionKnowledgeSearch) | The suggested knowledge search result that was provided as the suggestion. | [optional] |
| **KnowledgeArticle** | [**SuggestionKnowledgeArticle**](SuggestionKnowledgeArticle) | The suggested knowledge article that was provided as the suggestion. | [optional] |
| **CannedResponse** | [**SuggestionCannedResponse**](SuggestionCannedResponse) | The suggested canned response that was provided as the suggestion. | [optional] |
| **Script** | [**SuggestionScript**](SuggestionScript) | The suggested script that was provided as the suggestion. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **Conversation** | [**AddressableEntityRef**](AddressableEntityRef) | The conversation that the suggestions correspond to. | [optional] |
| **Assistant** | [**AddressableEntityRef**](AddressableEntityRef) | The assistant that was used to provide the suggestions. | [optional] |



_PureCloudPlatform.Client.V2 225.0.0_
