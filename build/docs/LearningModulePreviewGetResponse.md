---
title: LearningModulePreviewGetResponse
---
## ININ.PureCloudApi.Model.LearningModulePreviewGetResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of learning module | |
| **Description** | **string** | The description of learning module | [optional] |
| **CoverArt** | [**LearningModuleCoverArtResponse**](LearningModuleCoverArtResponse.html) | The cover art for the learning module | [optional] |
| **EnforceContentOrder** | **bool?** | If true, learning module content should be viewed one by one in order | [optional] |
| **ReviewAssessmentResults** | [**ReviewAssessmentResults**](ReviewAssessmentResults.html) | Allows to view Assessment results in detail | [optional] |
| **AssessmentForm** | [**AssessmentForm**](AssessmentForm.html) | The assessment form for learning module | [optional] |
| **Assignment** | [**LearningModulePreviewGetResponseAssignment**](LearningModulePreviewGetResponseAssignment.html) | the assignment preview | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


