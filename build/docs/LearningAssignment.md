# LearningAssignment

## ININ.PureCloudApi.Model.LearningAssignment

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Assessment** | [**LearningAssessment**](LearningAssessment) | The assessment associated with this assignment | [optional] |
| **CreatedBy** | [**UserReference**](UserReference) | The user who created the assignment | [optional] |
| **DateCreated** | **DateTime?** | The date when the assignment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference) | The user who modified the assignment | [optional] |
| **DateModified** | **DateTime?** | The date when the assignment was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **IsOverdue** | **bool?** | True if the assignment is overdue | [optional] |
| **PercentageScore** | **float?** | The user&#39;s percentage score for this assignment | [optional] |
| **AssessmentPercentageScore** | **float?** | The user&#39;s percentage score for this assignment&#39;s assessment | [optional] |
| **IsRule** | **bool?** | True if this assignment was created by a Rule | [optional] |
| **IsManual** | **bool?** | True if this assignment was created manually | [optional] |
| **IsPassed** | **bool?** | True if the assessment was passed | [optional] |
| **IsLatest** | **bool?** | True if the assignment is based on latest module | [optional] |
| **AssessmentCompletionPercentage** | **float?** | The assessment completion percentage of assignment | [optional] |
| **CompletionPercentage** | **float?** | The overall completion percentage of assignment | [optional] |
| **Steps** | [**List&lt;LearningAssignmentStep&gt;**](LearningAssignmentStep) | List of assignment steps | [optional] |
| **NextStep** | [**LearningAssignmentStep**](LearningAssignmentStep) | The next assignment step | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **State** | **string** | The Learning Assignment state | [optional] |
| **DateRecommendedForCompletion** | **DateTime?** | The recommended completion date of the assignment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Version** | **int?** | The version of Learning module assigned | [optional] |
| **Module** | [**LearningModule**](LearningModule) | The Learning module object associated with this assignment | [optional] |
| **User** | [**UserReference**](UserReference) | The user to whom the assignment is assigned | [optional] |
| **AssessmentForm** | [**AssessmentForm**](AssessmentForm) | The assessment form associated with this assignment | [optional] |
| **LengthInMinutes** | **int?** | The length in minutes of the assignment | [optional] |



_PureCloudPlatform.Client.V2 255.0.0_
