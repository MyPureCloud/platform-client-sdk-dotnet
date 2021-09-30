---
title: TextBotDisconnectAction
---
## ININ.PureCloudApi.Model.TextBotDisconnectAction

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Reason** | **string** | The reason for the disconnect. | |
| **ReasonExtendedInfo** | **string** | Extended information related to the reason, if available. | [optional] |
| **FlowLocation** | [**TextBotFlowLocation**](TextBotFlowLocation.html) | Describes where in the Bot Flow the user was when the disconnect occurred. | [optional] |
| **FlowOutcomes** | [**List&lt;TextBotFlowOutcome&gt;**](TextBotFlowOutcome.html) | The list of Flow Outcomes for the bot flow and their details. | [optional] |
{: class="table table-striped"}


