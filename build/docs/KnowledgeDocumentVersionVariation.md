---
title: KnowledgeDocumentVersionVariation
---
## ININ.PureCloudApi.Model.KnowledgeDocumentVersionVariation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the variation. | [optional] |
| **Body** | [**DocumentBody**](DocumentBody.html) | The content for the variation. | [optional] |
| **DateCreated** | **DateTime?** | The creation date-time for the document variation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The last modification date-time for the document variation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Contexts** | [**List&lt;DocumentVariationContext&gt;**](DocumentVariationContext.html) | The context values associated with the variation. | |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **DocumentVersion** | [**AddressableEntityRef**](AddressableEntityRef.html) | Reference to the document version to which the variation is associated with. | [optional] |
{: class="table table-striped"}


