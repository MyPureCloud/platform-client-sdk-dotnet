# LearningModuleRequest

## ININ.PureCloudApi.Model.LearningModuleRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of learning module | |
| **Description** | **string** | The description of learning module | [optional] |
| **CompletionTimeInDays** | **int?** | The completion time of learning module in days | |
| **InformSteps** | [**List&lt;LearningModuleInformStepRequest&gt;**](LearningModuleInformStepRequest) | The list of inform steps in a learning module | [optional] |
| **Type** | **string** | The type for the learning module. Informational, AssessedContent and Assessment are deprecated | [optional] |
| **AssessmentForm** | [**AssessmentForm**](AssessmentForm) | The assessment form for learning module | [optional] |
| **CoverArt** | [**LearningModuleCoverArtRequest**](LearningModuleCoverArtRequest) | The cover art for the learning module | [optional] |
| **LengthInMinutes** | **int?** | The recommended time in minutes to complete the module | [optional] |
| **ExcludedFromCatalog** | **bool?** | If true, learning module is excluded when retrieving modules for manual assignment | [optional] |
| **ExternalId** | **string** | The external ID of the learning module. Maximum length: 50 characters. | [optional] |
| **EnforceContentOrder** | **bool?** | If true, learning module content should be viewed one by one in order | [optional] |
| **ReviewAssessmentResults** | [**ReviewAssessmentResults**](ReviewAssessmentResults) | Allows to view Assessment results in detail | [optional] |



_PureCloudPlatform.Client.V2 220.0.0_
