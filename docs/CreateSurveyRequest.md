# CreateSurveyRequest

## ININ.PureCloudApi.Model.CreateSurveyRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ConversationId** | **string** | The conversation to create the survey for. | |
| **SurveyFormContextId** | **string** | The survey form context to use for the survey. | |
| **AgentId** | **string** | The agent to associate with the survey. If not specified, the last agent on the conversation will be selected. | [optional] |
| **QueueId** | **string** | The queue to associate with the survey. If not specified, the queue associated with the selected agent will be used. | [optional] |



_PureCloudPlatform.Client.V2 255.0.0_
