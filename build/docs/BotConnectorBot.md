# BotConnectorBot

## ININ.PureCloudApi.Model.BotConnectorBot

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The Botconnector Bot Id - this is configurable by the user when put | |
| **Name** | **string** |  | [optional] |
| **Description** | **string** | An optional description of the bot.  This can be up to 256 characters long and must be comprised of displayable characters without leading or trailing whitespace | [optional] |
| **Versions** | [**List&lt;BotConnectorBotVersion&gt;**](BotConnectorBotVersion) | This bots versions, limit of 50 per bot | |
| **BotCompositeTag** | **string** | A system-generated string that contains metadata about this bot. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 257.0.0_
