# Survey

## ININ.PureCloudApi.Model.Survey

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Conversation** | [**ConversationReference**](ConversationReference) |  | [optional] |
| **SurveyForm** | [**SurveyForm**](SurveyForm) | Survey form used for this survey. | [optional] |
| **Agent** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **Status** | **string** |  | [optional] |
| **Queue** | [**QueueReference**](QueueReference) |  | [optional] |
| **Answers** | [**SurveyScoringSet**](SurveyScoringSet) |  | [optional] |
| **CompletedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SurveyErrorDetails** | [**SurveyErrorDetails**](SurveyErrorDetails) | Additional information about what happened when the survey is in Error status. | [optional] |
| **AgentTeam** | [**Team**](Team) | The team that the agent belongs to | [optional] |
| **SurveyType** | **string** | Type of the survey | [optional] |
| **MissingRequiredAnswer** | **bool?** | True if any of the required questions for the survey form have not been answered. Null if survey is not finished. | [optional] |
| **Flow** | [**AddressableEntityRef**](AddressableEntityRef) | An Architect flow that executed in order to collect the answers for this survey. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 252.0.0_
