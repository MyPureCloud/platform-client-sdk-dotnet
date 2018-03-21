---
title: Question
---
## ININ.PureCloudApi.Model.Question

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** |  | [optional] |
| **Text** | **string** |  | [optional] |
| **HelpText** | **string** |  | [optional] |
| **Type** | **string** |  | [optional] |
| **NaEnabled** | **bool?** |  | [optional] |
| **CommentsRequired** | **bool?** |  | [optional] |
| **VisibilityCondition** | [**VisibilityCondition**](VisibilityCondition.html) |  | [optional] |
| **AnswerOptions** | [**List&lt;AnswerOption&gt;**](AnswerOption.html) | Options from which to choose an answer for this question. Only used by Multiple Choice type questions. | [optional] |
| **MaxResponseCharacters** | **int?** | How many characters are allowed in the text response to this question. Used by NPS and Free Text question types. | [optional] |
| **ExplanationPrompt** | **string** | Prompt for details explaining the chosen NPS score. Used by NPS questions. | [optional] |
| **IsKill** | **bool?** |  | [optional] |
| **IsCritical** | **bool?** |  | [optional] |
{: class="table table-striped"}


