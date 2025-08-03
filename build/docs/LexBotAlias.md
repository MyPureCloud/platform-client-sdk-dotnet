# LexBotAlias

## ININ.PureCloudApi.Model.LexBotAlias

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Bot** | [**LexBot**](LexBot) | The Lex bot this is an alias for | [optional] |
| **BotVersion** | **string** | The version of the Lex bot this alias points at | [optional] |
| **Status** | **string** | The status of the Lex bot alias | |
| **FailureReason** | **string** | If the status is FAILED, Amazon Lex explains why it failed to build the bot | [optional] |
| **Language** | **string** | The target language of the Lex bot | [optional] |
| **Intents** | [**List&lt;LexIntent&gt;**](LexIntent) | An array of Intents associated with this bot alias | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 239.0.0_
