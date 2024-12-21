# KnowledgeGuestDocumentResponse

## ININ.PureCloudApi.Model.KnowledgeGuestDocumentResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Title** | **string** | Document title, having a limit of 500 words. | [optional] |
| **Visible** | **bool?** | Indicates if the knowledge document should be included in search results. | [optional] |
| **Alternatives** | [**List&lt;KnowledgeDocumentAlternative&gt;**](KnowledgeDocumentAlternative) | List of alternate phrases related to the title which improves search results. | [optional] |
| **State** | **string** | State of the document. | [optional] |
| **DateCreated** | **DateTime?** | Document creation date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Document last modification date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateImported** | **DateTime?** | Document import date-time, or null if was not imported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **LastPublishedVersionNumber** | **int?** | The last published version number of the document. | [optional] |
| **DatePublished** | **DateTime?** | The date on which the document was last published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreatedBy** | [**UserReference**](UserReference) | The user who created the document. | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference) | The user who modified the document. | [optional] |
| **DocumentVersion** | [**AddressableEntityRef**](AddressableEntityRef) | The version of the document. | [optional] |
| **SessionId** | **string** | ID of the guest session. | [optional] |
| **Category** | [**GuestCategoryReference**](GuestCategoryReference) | The reference to category associated with the document. | [optional] |
| **Variations** | [**List&lt;KnowledgeGuestDocumentVariation&gt;**](KnowledgeGuestDocumentVariation) | Variations of the document. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 224.0.0_
