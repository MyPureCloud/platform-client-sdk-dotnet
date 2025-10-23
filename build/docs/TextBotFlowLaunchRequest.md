# TextBotFlowLaunchRequest

## ININ.PureCloudApi.Model.TextBotFlowLaunchRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Flow** | [**TextBotFlow**](TextBotFlow) | Specifies which Bot Flow to launch. | |
| **ExternalSessionId** | **string** | The ID of the external session that is associated with the bot flow. | |
| **ConversationId** | **string** | A conversation ID to associate with the bot flow, if available. | [optional] |
| **InputData** | [**TextBotInputOutputData**](TextBotInputOutputData) | Input values to the flow. Valid values are defined by the flow&#39;s input JSON schema. | [optional] |
| **Channel** | [**TextBotChannel**](TextBotChannel) | Channel information relevant to the bot flow. | |
| **Language** | **string** | The language that the bot will use in the session. Validated against list of supported languages and if the value is omitted or is invalid, the default language will be used. | [optional] |



_PureCloudPlatform.Client.V2 246.0.0_
