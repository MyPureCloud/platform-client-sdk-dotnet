# UnansweredGroup

## ININ.PureCloudApi.Model.UnansweredGroup

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Label** | **string** | Knowledge base unanswered group label | [optional] |
| **PhraseGroups** | [**List&lt;UnansweredPhraseGroup&gt;**](UnansweredPhraseGroup) | Represents a list of phrase groups inside an unanswered group | [optional] |
| **SuggestedDocuments** | [**List&lt;UnansweredGroupSuggestedDocument&gt;**](UnansweredGroupSuggestedDocument) | Represents a list of documents that may be linked to an unanswered group | [optional] |
| **Statistics** | [**KnowledgeGroupStatistics**](KnowledgeGroupStatistics) | Statistics object containing the various hit counts for an unanswered group | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 226.0.0_
