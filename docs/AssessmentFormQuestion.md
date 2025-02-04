# AssessmentFormQuestion

## ININ.PureCloudApi.Model.AssessmentFormQuestion

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** |  | [optional] |
| **Type** | **string** |  | [optional] |
| **Text** | **string** | The question text | |
| **HelpText** | **string** |  | [optional] |
| **NaEnabled** | **bool?** |  | [optional] |
| **CommentsRequired** | **bool?** |  | [optional] |
| **VisibilityCondition** | [**VisibilityCondition**](VisibilityCondition) |  | [optional] |
| **AnswerOptions** | [**List&lt;AnswerOption&gt;**](AnswerOption) | Options from which to choose an answer for this question. Only used by Multiple Choice type questions. | [optional] |
| **MaxResponseCharacters** | **int?** | How many characters are allowed in the text response to this question. Used by Free Text question types. | [optional] |
| **IsKill** | **bool?** | Does an incorrect answer to this question mark the form as having a failed kill question. Only used by Multiple Choice type questions. | [optional] |
| **IsCritical** | **bool?** | Does this question contribute to the critical score. Only used by Multiple Choice type questions. | [optional] |



_PureCloudPlatform.Client.V2 226.0.0_
