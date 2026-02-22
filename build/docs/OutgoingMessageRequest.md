# OutgoingMessageRequest

## ININ.PureCloudApi.Model.OutgoingMessageRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **BotId** | **string** | The unique id of the bot. | |
| **BotVersion** | **string** | The version of the bot. | |
| **BotSessionId** | **string** | The id of the session. This id will be used for an entire conversation with the bot (a series of back and forth between the bot until the bot has fulfilled its intent). | |
| **BotState** | **string** | The state of the bot reported | |
| **LanguageCode** | **string** | The language used for this message. EG &#39;en-us&#39; or &#39;es&#39;, etc; These language codes are W3C language identification tags (ISO 639-1 for the language name and ISO 3166 for the country code). | |
| **ReplyMessages** | [**List&lt;ReplyMessage&gt;**](ReplyMessage) | This is a list of messages to send back to the user, this field can be null or an empty list. | [optional] |
| **Intent** | **string** | The name of the intent the bot is either processing or has processed, this will be blank if no intent could be detected. | [optional] |
| **Confidence** | **double?** | A value between 0 and 1.0 denoting the confidence of the discovered intent (if found) this is optional and if left null genesys assumes a confidence of 1.0 on success and 0 on fail. | [optional] |
| **ErrorInfo** | [**ErrorInfo**](ErrorInfo) | If the botState is Failed the bot can add this error object with more details about the error. | [optional] |
| **Parameters** | **Dictionary&lt;string, string&gt;** | This is a map of string-string key, value pairs containing optional fields that can be passed from the bot for custom behavior, tracking, etc, which can be used by the flow. | [optional] |
| **Entities** | [**List&lt;BotEntityValue&gt;**](BotEntityValue) | A set of entity values that go along with the intent. | [optional] |



_PureCloudPlatform.Client.V2 257.0.0_
