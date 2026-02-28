# AnalyticsSurvey

## ININ.PureCloudApi.Model.AnalyticsSurvey

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EventTime** | **DateTime?** | Specifies when an event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **QueueId** | **string** | The ID of the associated queue | [optional] |
| **SurveyCompletedDate** | **DateTime?** | Completion datetime of the survey in ISO 8601 format | [optional] |
| **SurveyFormContextId** | **string** | Unique identifier for the survey form, regardless of version | [optional] |
| **SurveyFormId** | **string** | ID of the survey form used | [optional] |
| **SurveyFormName** | **string** | Name of the survey form used | [optional] |
| **SurveyId** | **string** | ID of the survey | [optional] |
| **SurveyPartialResponse** | **bool?** | Whether the survey was completed with any required questions unanswered. | [optional] |
| **SurveyPromoterScore** | **int?** | Score of the survey used with NPS | [optional] |
| **SurveyStatus** | **string** | The status of the survey | [optional] |
| **SurveyType** | **string** | The type of the survey | [optional] |
| **UserId** | **string** | ID of the agent the survey was performed against | [optional] |
| **OSurveyTotalScore** | **long?** |  | [optional] |



_PureCloudPlatform.Client.V2 258.0.0_
