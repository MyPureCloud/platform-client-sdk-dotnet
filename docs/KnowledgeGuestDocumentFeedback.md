# KnowledgeGuestDocumentFeedback

## ININ.PureCloudApi.Model.KnowledgeGuestDocumentFeedback

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **DocumentVariation** | [**EntityReference**](EntityReference) | The variation of the document on which feedback was given. | |
| **Rating** | **string** | Feedback rating. | |
| **Reason** | **string** | Feedback reason. | [optional] |
| **Comment** | **string** | Free-text comment of the feedback. Maximum length: 2000 characters. | [optional] |
| **Search** | [**EntityReference**](EntityReference) | The search that surfaced the document on which feedback was given. | [optional] |
| **SessionId** | **string** | Knowledge guest session ID. | [optional] |
| **DateCreated** | **DateTime?** | The date and time of the feedback. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **QueryType** | **string** | The type of the query that surfaced the document on which the feedback was given. | [optional] |
| **SurfacingMethod** | **string** | The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown. | [optional] |
| **State** | **string** | The state of the feedback. | [optional] |
| **Document** | [**KnowledgeGuestDocumentVersionReference**](KnowledgeGuestDocumentVersionReference) | The document on which feedback was given. | |
| **Application** | [**KnowledgeGuestSearchClientApplication**](KnowledgeGuestSearchClientApplication) | The client application from which feedback was given. | [optional] |



_PureCloudPlatform.Client.V2 224.1.0_
