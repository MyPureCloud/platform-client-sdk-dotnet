---
title: TextBotExitAction
---
## ININ.PureCloudApi.Model.TextBotExitAction

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Reason** | **string** | The reason for the exit. | |
| **ReasonExtendedInfo** | **string** | Extended information related to the reason, if available. | [optional] |
| **ActiveIntent** | **string** | The active intent at the time of the exit. | [optional] |
| **FlowLocation** | [**TextBotFlowLocation**](TextBotFlowLocation.html) | Describes where in the Bot Flow the user was when the exit occurred. | [optional] |
| **OutputData** | [**TextBotInputOutputData**](TextBotInputOutputData.html) | The output data for the bot flow. | [optional] |
| **FlowOutcomes** | [**List&lt;TextBotFlowOutcome&gt;**](TextBotFlowOutcome.html) | The list of Flow Outcomes for the bot flow and their details. | [optional] |
{: class="table table-striped"}


