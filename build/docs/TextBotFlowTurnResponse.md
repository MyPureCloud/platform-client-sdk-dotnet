# TextBotFlowTurnResponse

## ININ.PureCloudApi.Model.TextBotFlowTurnResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The ID of the bot flow turn. If additional turns are needed, supply this ID as the previous turn in your next turn request. | |
| **PreviousTurn** | [**TextBotTurnReference**](TextBotTurnReference) | The reference to a previous turn, if applicable. | [optional] |
| **Prompts** | [**TextBotOutputPrompts**](TextBotOutputPrompts) | The output prompts for this turn. | [optional] |
| **NextActionType** | **string** | Indicates the suggested next action. If appropriate, the matching output event object includes additional information. | |
| **NextActionDisconnect** | [**TextBotDisconnectAction**](TextBotDisconnectAction) | The next action directive for this turn if it is a Disconnect type. | [optional] |
| **NextActionWaitForInput** | [**TextBotWaitForInputAction**](TextBotWaitForInputAction) | The next action directive for this turn if it is a WaitForInput type. | [optional] |
| **NextActionExit** | [**TextBotExitAction**](TextBotExitAction) | The next action directive for this turn if it is an Exit type. | [optional] |



_PureCloudPlatform.Client.V2 253.0.0_
