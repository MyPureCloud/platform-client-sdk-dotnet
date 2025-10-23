# KnowledgeGuestDocumentVariation

## ININ.PureCloudApi.Model.KnowledgeGuestDocumentVariation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the variation. | [optional] |
| **DateCreated** | **DateTime?** | The creation date-time for the document variation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The last modification date-time for the document variation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DocumentVersion** | [**AddressableEntityRef**](AddressableEntityRef) | The version of the document. | [optional] |
| **Contexts** | [**List&lt;KnowledgeGuestDocumentVariationContext&gt;**](KnowledgeGuestDocumentVariationContext) | The context values associated with the variation. | |
| **Document** | [**AddressableEntityRef**](AddressableEntityRef) | The reference to document to which the variation is associated. | [optional] |
| **Body** | [**DocumentBodyResponse**](DocumentBodyResponse) | The content for the variation. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 246.0.0_
