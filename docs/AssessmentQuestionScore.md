# AssessmentQuestionScore

## ININ.PureCloudApi.Model.AssessmentQuestionScore

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **FailedKillQuestion** | **bool?** | True if this was a failed Kill question | [optional] |
| **Comments** | **string** | Comments provided for the answer | [optional] |
| **QuestionId** | **string** | The ID of the question | |
| **AnswerId** | **string** | The ID of the selected answer | [optional] |
| **Score** | **int?** | The score received for this question | [optional] |
| **MarkedNA** | **bool?** | True if this question was marked as NA | [optional] |
| **SystemMarkedNA** | **bool?** | If markedNA is true, systemMarkedNA indicates whether it was marked by a user or by the system due to visibility conditions. Always false if markedNA is false. | [optional] |
| **FreeTextAnswer** | **string** | Answer for free text answer type | [optional] |



_PureCloudPlatform.Client.V2 235.0.0_
