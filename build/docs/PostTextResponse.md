# PostTextResponse

## ININ.PureCloudApi.Model.PostTextResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **BotState** | **string** | The state of the bot after completion of the request | |
| **ReplyMessages** | [**List&lt;PostTextMessage&gt;**](PostTextMessage) | The list of messages to respond with, if any | [optional] |
| **IntentName** | **string** | The name of the intent the bot is either processing or has processed, this will be blank if no intent could be detected. | [optional] |
| **Slots** | **Dictionary&lt;string, string&gt;** | Data parameters detected and filled by the bot. | [optional] |
| **BotCorrelationId** | **string** | The optional ID specified in the request | [optional] |
| **AmazonLex** | **Dictionary&lt;string, Object&gt;** | Raw data response from AWS (if called) | [optional] |
| **GoogleDialogFlow** | **Dictionary&lt;string, Object&gt;** | Raw data response from Google Dialogflow (if called) | [optional] |
| **GenesysDialogEngine** | **Dictionary&lt;string, Object&gt;** | Raw data response from Genesys&#39; Dialogengine (if called) | [optional] |
| **GenesysBotConnector** | **Dictionary&lt;string, Object&gt;** | Raw data response from Genesys&#39; BotConnector (if called) | [optional] |
| **NuanceMixDlg** | **Dictionary&lt;string, Object&gt;** | Raw data response from Nuance Mix Dlg (if called) | [optional] |



_PureCloudPlatform.Client.V2 223.0.0_
