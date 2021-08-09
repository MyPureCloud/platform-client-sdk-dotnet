---
title: TextBotFlowLaunchRequest
---
## ININ.PureCloudApi.Model.TextBotFlowLaunchRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Flow** | [**TextBotFlow**](TextBotFlow.html) | Specifies which Bot Flow to launch. | |
| **ExternalSessionId** | **string** | The ID of the external session that is associated with the bot flow. | |
| **ConversationId** | **string** | A conversation ID to associate with the bot flow, if available. | [optional] |
| **InputData** | [**TextBotInputOutputData**](TextBotInputOutputData.html) | Input values to the flow. Valid values are defined by the flow&#39;s input JSON schema. | [optional] |
| **Channel** | [**TextBotChannel**](TextBotChannel.html) | Channel information relevant to the bot flow. | |
{: class="table table-striped"}


