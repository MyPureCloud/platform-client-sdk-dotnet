# KnowledgeDocument

## ININ.PureCloudApi.Model.KnowledgeDocument

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **LanguageCode** | **string** | Language of the document | |
| **Type** | **string** | Document type | |
| **Faq** | [**DocumentFaq**](DocumentFaq) | FAQ document details | [optional] |
| **DateCreated** | **DateTime?** | Document creation date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Document last modification date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Categories** | [**List&lt;KnowledgeCategory&gt;**](KnowledgeCategory) | Document categories | [optional] |
| **KnowledgeBase** | [**KnowledgeBase**](KnowledgeBase) | Knowledge base which document does belong to | [optional] |
| **ExternalUrl** | **string** | External URL to the document | [optional] |
| **Article** | [**DocumentArticle**](DocumentArticle) | Article | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 234.0.0_
