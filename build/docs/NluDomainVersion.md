# NluDomainVersion

## ININ.PureCloudApi.Model.NluDomainVersion

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Domain** | [**NluDomain**](NluDomain) | The NLU domain of the version. | [optional] |
| **Description** | **string** | The description of the NLU domain version. | [optional] |
| **Language** | **string** | The language that the NLU domain version supports. | |
| **Published** | **bool?** | Whether this NLU domain version has been published. | [optional] |
| **DateCreated** | **DateTime?** | The date when the NLU domain version was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The date when the NLU domain version was updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateTrained** | **DateTime?** | The date when the NLU domain version was trained. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DatePublished** | **DateTime?** | The date when the NLU domain version was published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **TrainingStatus** | **string** | The training status of the NLU domain version. | [optional] |
| **EvaluationStatus** | **string** | The evaluation status of the NLU domain version. | [optional] |
| **Intents** | [**List&lt;IntentDefinition&gt;**](IntentDefinition) | The intents defined for this NLU domain version. | [optional] |
| **EntityTypes** | [**List&lt;NamedEntityTypeDefinition&gt;**](NamedEntityTypeDefinition) | The entity types defined for this NLU domain version. | [optional] |
| **Entities** | [**List&lt;NamedEntityDefinition&gt;**](NamedEntityDefinition) | The entities defined for this NLU domain version.This field is mutually exclusive with entityTypeBindings | [optional] |
| **LanguageVersions** | **Dictionary&lt;string, string&gt;** | Map of language code to NLU domain version UUID for multilingual domains. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 242.0.0_
