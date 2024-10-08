# LearningModulePreviewGetResponseStep

## ININ.PureCloudApi.Model.LearningModulePreviewGetResponseStep

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The id of the step | [optional] |
| **ModuleStep** | [**LearningModuleInformStep**](LearningModuleInformStep) | The module step data for this step | [optional] |
| **Structure** | [**List&lt;LearningModulePreviewGetScoStructure&gt;**](LearningModulePreviewGetScoStructure) | The structure for any SCO associated with this step | [optional] |
| **SuccessStatus** | **string** | The success status of this step | [optional] |
| **CompletionStatus** | **string** | The completion status of the assignment step | [optional] |
| **CompletionPercentage** | **float?** | The completion percentage for this step | [optional] |
| **PercentageScore** | **float?** | The percentage score for this step | [optional] |
| **SignedCookie** | [**LearningAssignmentStepSignedCookie**](LearningAssignmentStepSignedCookie) | The signed cookie information needed to access the content of this step (if required) | [optional] |



_PureCloudPlatform.Client.V2 217.0.0_
