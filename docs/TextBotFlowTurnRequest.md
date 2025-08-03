# TextBotFlowTurnRequest

## ININ.PureCloudApi.Model.TextBotFlowTurnRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PreviousTurn** | [**TextBotTurnReference**](TextBotTurnReference) | The reference to a previous turn if appropriate, used to avoid race conditions. | [optional] |
| **InputEventType** | **string** | Indicates the type of input event being requested. If appropriate, fill out the matching user input object details on this request. | |
| **InputEventUserInput** | [**TextBotUserInputEvent**](TextBotUserInputEvent) | The data for the input event of this turn if it is a user input event. Only one inputEvent may be set. | [optional] |
| **InputEventError** | [**TextBotErrorInputEvent**](TextBotErrorInputEvent) | The data for the input event of this turn if it is an error event. Only one inputEvent may be set. | [optional] |



_PureCloudPlatform.Client.V2 239.0.0_
