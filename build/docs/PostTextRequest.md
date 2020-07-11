---
title: PostTextRequest
---
## ININ.PureCloudApi.Model.PostTextRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **BotId** | **string** | ID of the bot to send the text to. | |
| **BotAlias** | **string** | Alias/Version of the bot | [optional] |
| **IntegrationId** | **string** | the integration service id for the bot&#39;s credentials | |
| **BotSessionId** | **string** | GUID for this bot&#39;s session | |
| **PostTextMessage** | [**PostTextMessage**](PostTextMessage.html) | Message to send to the bot | |
| **LanguageCode** | **string** | The launguage code the bot will run under | [optional] |
| **BotSessionTimeoutMinutes** | **int?** | Override timeout for the bot session. This should be greater than 10 minutes. | [optional] |
| **BotChannels** | **List&lt;string&gt;** | The channels this bot is utilizing | [optional] |
| **BotCorrelationId** | **string** | Id for tracking the activity - this will be returned in the response | [optional] |
| **AmazonLexRequest** | [**AmazonLexRequest**](AmazonLexRequest.html) |  | [optional] |
| **GoogleDialogflow** | [**GoogleDialogflowCustomSettings**](GoogleDialogflowCustomSettings.html) |  | [optional] |
{: class="table table-striped"}


