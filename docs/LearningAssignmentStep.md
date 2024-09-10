# LearningAssignmentStep

## ININ.PureCloudApi.Model.LearningAssignmentStep

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The ID of the learning assignment step | [optional] |
| **ModuleStep** | [**LearningModuleInformStep**](LearningModuleInformStep) | The module step data for this step | [optional] |
| **Structure** | [**List&lt;LearningAssignmentStepScoStructure&gt;**](LearningAssignmentStepScoStructure) | The structure for any SCO associated with this step | [optional] |
| **SuccessStatus** | **string** | The success status of this step | [optional] |
| **CompletionStatus** | **string** | The completion status of the assignment step | [optional] |
| **CompletionPercentage** | **float?** | The completion percentage for this step | [optional] |
| **PercentageScore** | **float?** | The percentage score for this step | [optional] |
| **ShareableContentObject** | [**LearningShareableContentObject**](LearningShareableContentObject) | The SCO (Shareable Content Object) data | [optional] |
| **SignedCookie** | [**LearningAssignmentStepSignedCookie**](LearningAssignmentStepSignedCookie) | The signed cookie information needed to access the content of this step (if required) | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 215.0.0_
