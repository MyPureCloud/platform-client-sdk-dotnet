# SurveyQuestionScore

## ININ.PureCloudApi.Model.SurveyQuestionScore

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **QuestionId** | **string** |  | [optional] |
| **AnswerId** | **string** |  | [optional] |
| **Score** | **int?** | Unweighted score of the question | [optional] |
| **MarkedNA** | **bool?** | True when the evaluation is submitted with a question that does not have an answer. Only allowed when naEnabled is true or if set by the system | [optional] |
| **SystemMarkedNA** | **bool?** | If markedNA is true, systemMarkedNA indicates whether it was marked by a user or by the system due to visibility conditions. Always false if markedNA is false. | [optional] |
| **AssistedAnswerId** | **string** | AnswerId found with evaluation assistance conditions | [optional] |
| **NpsScore** | **int?** |  | [optional] |
| **NpsTextAnswer** | **string** |  | [optional] |
| **FreeTextAnswer** | **string** |  | [optional] |



_PureCloudPlatform.Client.V2 243.0.0_
