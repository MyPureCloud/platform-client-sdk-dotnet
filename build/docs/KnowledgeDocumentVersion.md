# KnowledgeDocumentVersion

## ININ.PureCloudApi.Model.KnowledgeDocumentVersion

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Globally unique identifier for the document version. | [optional] |
| **DatePublished** | **DateTime?** | Published date of document version. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Document** | [**KnowledgeDocumentResponse**](KnowledgeDocumentResponse) | The document which is versioned. | [optional] |
| **RestoreFromVersionId** | **string** | The globally unique identifier for the document version. If the value is provided, the document is restored to the given version. If not, it publishes the draft changes as a new version of the document. | |
| **VersionNumber** | **int?** | Version Number of the document. | [optional] |
| **DateExpires** | **DateTime?** | Expiry date of document version, applicable only to the &#39;Archived&#39; version of the document. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 216.0.0_
