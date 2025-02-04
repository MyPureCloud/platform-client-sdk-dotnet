# LearningModulePreviewGetResponse

## ININ.PureCloudApi.Model.LearningModulePreviewGetResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of learning module | |
| **Description** | **string** | The description of learning module | [optional] |
| **CoverArt** | [**LearningModuleCoverArtResponse**](LearningModuleCoverArtResponse) | The cover art for the learning module | [optional] |
| **EnforceContentOrder** | **bool?** | If true, learning module content should be viewed one by one in order | [optional] |
| **ReviewAssessmentResults** | [**ReviewAssessmentResults**](ReviewAssessmentResults) | Allows to view Assessment results in detail | [optional] |
| **AssessmentForm** | [**AssessmentForm**](AssessmentForm) | The assessment form for learning module | [optional] |
| **Assignment** | [**LearningModulePreviewGetResponseAssignment**](LearningModulePreviewGetResponseAssignment) | the assignment preview | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 226.0.0_
