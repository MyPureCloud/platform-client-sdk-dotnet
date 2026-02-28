# LearningAssessment

## ININ.PureCloudApi.Model.LearningAssessment

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **AssessmentId** | **string** | The Id of the assessment | [optional] |
| **ContextId** | **string** | The context Id of the related assessment form | [optional] |
| **AssessmentFormId** | **string** | The Id of the related assessment form | [optional] |
| **Status** | **string** | Status of the assessment | [optional] |
| **Answers** | [**AssessmentScoringSet**](AssessmentScoringSet) | Answers for the assessment | [optional] |
| **DateCreated** | **DateTime?** | Date the assessment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date the assessment was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateSubmitted** | **DateTime?** | Date the assessment was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |



_PureCloudPlatform.Client.V2 258.0.0_
