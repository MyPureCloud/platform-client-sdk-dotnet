# PostTextRequest

## ININ.PureCloudApi.Model.PostTextRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **BotId** | **string** | ID of the bot to send the text to. | |
| **BotAlias** | **string** | Alias/Version of the bot | [optional] |
| **IntegrationId** | **string** | the integration service id for the bot&#39;s credentials | |
| **BotSessionId** | **string** | GUID for this bot&#39;s session | |
| **PostTextMessage** | [**PostTextMessage**](PostTextMessage) | Message to send to the bot | |
| **LanguageCode** | **string** | The launguage code the bot will run under | [optional] |
| **BotSessionTimeoutMinutes** | **int?** | Override timeout for the bot session. This should be greater than 10 minutes. | [optional] |
| **BotChannels** | **List&lt;string&gt;** | The channels this bot is utilizing | [optional] |
| **BotCorrelationId** | **string** | Id for tracking the activity - this will be returned in the response | [optional] |
| **MessagingPlatformType** | **string** | If the channels list contains a &#39;Messaging&#39; item and the messaging platform is known, include it here to get accurate analytics | [optional] |
| **AmazonLexRequest** | [**AmazonLexRequest**](AmazonLexRequest) | Provider specific settings, if any | [optional] |
| **GoogleDialogflow** | [**GoogleDialogflowCustomSettings**](GoogleDialogflowCustomSettings) | Provider specific settings, if any | [optional] |
| **GenesysBotConnector** | [**GenesysBotConnector**](GenesysBotConnector) | Provider specific settings, if any | [optional] |
| **NuanceMixDlg** | [**NuanceMixDlgSettings**](NuanceMixDlgSettings) | Provider specific settings, if any | [optional] |



_PureCloudPlatform.Client.V2 225.0.0_
