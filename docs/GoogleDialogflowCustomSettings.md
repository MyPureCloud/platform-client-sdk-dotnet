# GoogleDialogflowCustomSettings

## ININ.PureCloudApi.Model.GoogleDialogflowCustomSettings

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Environment** | **string** | If set this environment will be used to initiate the dialogflow bot, otherwise the default configuration will be used.  See https://cloud.google.com/dialogflow/docs/agents-versions | [optional] |
| **EventName** | **string** | If set this eventName will be used to initiate the dialogflow bot rather than language processing on the input text.  See https://cloud.google.com/dialogflow/es/docs/events-overview | [optional] |
| **WebhookQueryParameters** | **Dictionary&lt;string, string&gt;** | Parameters passed to the fulfillment webhook of the bot (if any). | [optional] |
| **EventInputParameters** | **Dictionary&lt;string, string&gt;** | Parameters passed to the event input of the bot. | [optional] |



_PureCloudPlatform.Client.V2 253.0.0_
