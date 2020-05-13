---
title: KnowledgeTraining
---
## ININ.PureCloudApi.Model.KnowledgeTraining

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateTriggered** | **DateTime?** | Trigger date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateCompleted** | **DateTime?** | Training completed date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Status** | **string** | Training status | [optional] |
| **LanguageCode** | **string** | Actual language of the Training | [optional] |
| **KnowledgeBase** | [**KnowledgeBase**](KnowledgeBase.html) | Knowledge base which Training does belong to | [optional] |
| **ErrorMessage** | **string** | Any error message during the Training or Promote action. | [optional] |
| **KnowledgeDocumentsState** | **string** | State of the Trained Documents, which can be one of these Draft, Active, Discarded, Archived. | [optional] |
| **DatePromoted** | **DateTime?** | Trained Documents Promoted date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


