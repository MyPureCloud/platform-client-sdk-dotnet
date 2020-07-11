---
title: NluDomainVersion
---
## ININ.PureCloudApi.Model.NluDomainVersion

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Domain** | [**NluDomain**](NluDomain.html) | The NLU domain of the version. | [optional] |
| **Description** | **string** | The description of the NLU domain version. | [optional] |
| **Language** | **string** | The language that the NLU domain version supports. | |
| **Published** | **bool?** | Whether this NLU domain version has been published. | [optional] |
| **DateCreated** | **DateTime?** | The date when the NLU domain version was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | The date when the NLU domain version was updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateTrained** | **DateTime?** | The date when the NLU domain version was trained. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DatePublished** | **DateTime?** | The date when the NLU domain version was published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **TrainingStatus** | **string** | The training status of the NLU domain version. | [optional] |
| **EvaluationStatus** | **string** | The evaluation status of the NLU domain version. | [optional] |
| **Intents** | [**List&lt;IntentDefinition&gt;**](IntentDefinition.html) | The intents defined for this NLU domain version. | [optional] |
| **EntityTypes** | [**List&lt;NamedEntityTypeDefinition&gt;**](NamedEntityTypeDefinition.html) | The entity types defined for this NLU domain version. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


