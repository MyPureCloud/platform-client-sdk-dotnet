# CategoryResponse

## ININ.PureCloudApi.Model.CategoryResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the category. | |
| **Description** | **string** |  | [optional] |
| **ExternalId** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ParentCategory** | [**CategoryReference**](CategoryReference) | The reference to category to which this category belongs to. | [optional] |
| **DocumentCount** | **int?** | Number of documents assigned to this category. | [optional] |
| **KnowledgeBase** | [**KnowledgeBaseReference**](KnowledgeBaseReference) | The reference to knowledge base to which the category belongs to. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 227.0.0_
