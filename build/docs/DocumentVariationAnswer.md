# DocumentVariationAnswer

## ININ.PureCloudApi.Model.DocumentVariationAnswer

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the variation. | [optional] |
| **DateCreated** | **DateTime?** | The creation date-time for the document variation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The last modification date-time for the document variation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DocumentVersion** | [**AddressableEntityRef**](AddressableEntityRef) | The version of the document. | [optional] |
| **Contexts** | [**List&lt;DocumentVariationContext&gt;**](DocumentVariationContext) | The context values associated with the variation. | |
| **Document** | [**KnowledgeDocumentReference**](KnowledgeDocumentReference) | The reference to document to which the variation is associated. | [optional] |
| **Priority** | **int?** | The priority of the variation. | [optional] |
| **Name** | **string** | The name of the variation. | [optional] |
| **Body** | [**DocumentBodyWithHighlight**](DocumentBodyWithHighlight) | The content for the variation. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 250.0.0_
