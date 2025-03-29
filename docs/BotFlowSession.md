# BotFlowSession

## ININ.PureCloudApi.Model.BotFlowSession

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The ID of the bot session. | [optional] |
| **Flow** | [**Entity**](Entity) | The flow associated to this bot session. | [optional] |
| **Channel** | [**BotChannel**](BotChannel) | Channel-specific information that describes the message channel/provider. | [optional] |
| **Language** | **string** | The initial language of operation for the session. | [optional] |
| **EndLanguage** | **string** | The language of the session at the time the session ended | [optional] |
| **BotResult** | **string** | The reason for session termination. | [optional] |
| **BotResultCategory** | **string** | The category of result for the session. | [optional] |
| **DateCreated** | **DateTime?** | Timestamp indicating when the session was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateCompleted** | **DateTime?** | Timestamp indicating when the session was completed. Note: The &#39;interval&#39; query param uses this timestamp to filter the output. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Conversation** | [**AddressableEntityRef**](AddressableEntityRef) | The conversation details, across potentially multiple Bot Flow sessions. | [optional] |



_PureCloudPlatform.Client.V2 230.0.0_
