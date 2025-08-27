# TextBotExitAction

## ININ.PureCloudApi.Model.TextBotExitAction

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Reason** | **string** | The reason for the exit. | |
| **ReasonExtendedInfo** | **string** | Extended information related to the reason, if available. | [optional] |
| **ActiveIntent** | **string** | The active intent at the time of the exit. | [optional] |
| **FlowLocation** | [**TextBotFlowLocation**](TextBotFlowLocation) | Describes where in the Bot Flow the user was when the exit occurred. | [optional] |
| **OutputData** | [**TextBotInputOutputData**](TextBotInputOutputData) | The output data for the bot flow. | [optional] |
| **FlowOutcomes** | [**List&lt;TextBotFlowOutcome&gt;**](TextBotFlowOutcome) | The list of Flow Outcomes for the bot flow and their details. | [optional] |



_PureCloudPlatform.Client.V2 241.0.0_
