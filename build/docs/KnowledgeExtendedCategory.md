# KnowledgeExtendedCategory

## ININ.PureCloudApi.Model.KnowledgeExtendedCategory

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | Category name | |
| **Description** | **string** | Category description | [optional] |
| **KnowledgeBase** | [**KnowledgeBase**](KnowledgeBase) | Knowledge base which category does belong to | [optional] |
| **LanguageCode** | **string** | Actual language of the category | [optional] |
| **DateCreated** | **DateTime?** | Category creation date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Category last modification date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Parent** | [**KnowledgeCategory**](KnowledgeCategory) | Category parent | [optional] |
| **Children** | [**List&lt;KnowledgeCategory&gt;**](KnowledgeCategory) | Category children | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 232.0.0_
