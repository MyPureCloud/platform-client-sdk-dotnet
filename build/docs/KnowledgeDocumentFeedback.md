---
title: KnowledgeDocumentFeedback
---
## ININ.PureCloudApi.Model.KnowledgeDocumentFeedback

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **DocumentVariation** | [**EntityReference**](EntityReference.html) | The variation of the document on which feedback was given. | |
| **Rating** | **string** | Feedback rating. | |
| **Reason** | **string** | Feedback reason. | [optional] |
| **Comment** | **string** | Free-text comment of the feedback. Maximum length: 2000 characters. | [optional] |
| **Search** | [**EntityReference**](EntityReference.html) | The search that surfaced the document on which feedback was given. | [optional] |
| **SessionId** | **string** | Knowledge guest session ID. | [optional] |
| **DateCreated** | **DateTime?** | The date and time of the feedback. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **QueryType** | **string** | The type of the query that surfaced the document on which the feedback was given. | [optional] |
| **State** | **string** | The state of the feedback. | [optional] |
| **Document** | [**KnowledgeDocumentVersionReference**](KnowledgeDocumentVersionReference.html) | The document on which feedback was given. | |
| **Application** | [**KnowledgeSearchClientApplication**](KnowledgeSearchClientApplication.html) | The client application from which feedback was given. | |
| **ConversationContext** | [**KnowledgeConversationContext**](KnowledgeConversationContext.html) | Conversation context information if the feedback is given in the context of a conversation. | [optional] |
| **UserId** | **string** | The ID of the user who created the feedback. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


