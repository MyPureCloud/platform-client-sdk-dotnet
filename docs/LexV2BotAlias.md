# LexV2BotAlias

## ININ.PureCloudApi.Model.LexV2BotAlias

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Region** | **string** | The Lex V2 bot region | |
| **AliasId** | **string** | The Lex V2 bot alias Id | |
| **Bot** | [**LexV2Bot**](LexV2Bot) | The Lex V2 bot this is an alias for | [optional] |
| **BotVersion** | **string** | The version of the Lex V2 bot this alias points at | [optional] |
| **Status** | **string** | The status of the Lex V2 bot alias | [optional] |
| **Language** | **string** | The target language of the Lex V2 bot | [optional] |
| **Intents** | [**List&lt;LexV2Intent&gt;**](LexV2Intent) | An array of Intents associated with this bot alias | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 224.0.0_
