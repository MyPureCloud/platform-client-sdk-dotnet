# SurveyQuestion

## ININ.PureCloudApi.Model.SurveyQuestion

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** |  | [optional] |
| **Text** | **string** |  | [optional] |
| **HelpText** | **string** |  | [optional] |
| **Type** | **string** |  | [optional] |
| **NaEnabled** | **bool?** |  | [optional] |
| **VisibilityCondition** | [**VisibilityCondition**](VisibilityCondition) |  | [optional] |
| **AnswerOptions** | [**List&lt;AnswerOption&gt;**](AnswerOption) | Options from which to choose an answer for this question. Only used by Multiple Choice type questions. | [optional] |
| **MaxResponseCharacters** | **int?** | How many characters are allowed in the text response to this question. Used by NPS and Free Text question types. | [optional] |
| **ExplanationPrompt** | **string** | Prompt for details explaining the chosen NPS score. Used by NPS questions. | [optional] |



_PureCloudPlatform.Client.V2 218.0.0_
