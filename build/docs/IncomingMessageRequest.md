# IncomingMessageRequest

## ININ.PureCloudApi.Model.IncomingMessageRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **BotId** | **string** | The unique id of the bot. | |
| **BotName** | **string** | Name of the bot | |
| **BotVersion** | **string** | The version of the bot. | |
| **IntegrationId** | **string** | The Integration Id for the bot&#39;s configuration | |
| **BotSessionId** | **string** | The id of the session. This id will be used for an entire conversation with the bot (a series of back and forth between the bot until the bot has fulfilled its intent). | |
| **AutomateFlowExecId** | **string** | Execution ID of the Automate Flow. | |
| **ConversationId** | **string** | Genesys conversation ID. | |
| **LanguageCode** | **string** | Language code for the conversation (e.g., &#39;en-US&#39;). | |
| **InputMessage** | [**InputMessage**](InputMessage) | Message received from the user to send to the bot | |
| **MessagingPlatformType** | **string** | Type of messaging platform being used | |
| **Channels** | **List&lt;string&gt;** | The channels this bot is utilizing. | |
| **BotSessionTimeout** | **int?** | Timeout duration for bot session in minutes. | [optional] |
| **Parameters** | **Dictionary&lt;string, string&gt;** | This is a map of string-string key, value pairs containing optional fields that can be passed to the bot for custom behavior, tracking, etc. | [optional] |



_PureCloudPlatform.Client.V2 236.0.0_
