# KnowledgeTraining

## ININ.PureCloudApi.Model.KnowledgeTraining

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **DateTriggered** | **DateTime?** | Trigger date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateCompleted** | **DateTime?** | Training completed date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Status** | **string** | Training status. | [optional] |
| **LanguageCode** | **string** | Language of the documents that are trained. | [optional] |
| **KnowledgeBase** | [**KnowledgeBase**](KnowledgeBase) | Knowledge Base that the training belongs to. | [optional] |
| **ErrorMessage** | **string** | Any error message during the Training or Promote action. | [optional] |
| **KnowledgeDocumentsState** | **string** | State of the Trained Documents, which can be one of these Draft, Active, Discarded, Archived. | [optional] |
| **DatePromoted** | **DateTime?** | Trained Documents Promoted date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 245.0.0_
