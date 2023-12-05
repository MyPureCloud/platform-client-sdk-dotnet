---
title: Survey
---
## ININ.PureCloudApi.Model.Survey

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Conversation** | [**ConversationReference**](ConversationReference.html) |  | [optional] |
| **SurveyForm** | [**SurveyForm**](SurveyForm.html) | Survey form used for this survey. | [optional] |
| **Agent** | [**DomainEntityRef**](DomainEntityRef.html) |  | [optional] |
| **Status** | **string** |  | [optional] |
| **Queue** | [**QueueReference**](QueueReference.html) |  | [optional] |
| **Answers** | [**SurveyScoringSet**](SurveyScoringSet.html) |  | [optional] |
| **CompletedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SurveyErrorDetails** | [**SurveyErrorDetails**](SurveyErrorDetails.html) | Additional information about what happened when the survey is in Error status. | [optional] |
| **AgentTeam** | [**Team**](Team.html) | The team that the agent belongs to | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


