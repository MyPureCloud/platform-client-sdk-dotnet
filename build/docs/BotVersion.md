# BotVersion

## ININ.PureCloudApi.Model.BotVersion

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Version** | **string** | The name of the version. | [optional] |
| **SupportedLanguages** | **List&lt;string&gt;** | The supported languages for this bot. EG &#39;en-us&#39; or &#39;es&#39;, etc; These language codes are W3C language identification tags (ISO 639-1 for the language name and ISO 3166 for the country code) | [optional] |
| **Intents** | [**List&lt;BotConnectorIntent&gt;**](BotConnectorIntent) | A list of potential intents this bot will return, limit of 50 | [optional] |



_PureCloudPlatform.Client.V2 258.0.0_
