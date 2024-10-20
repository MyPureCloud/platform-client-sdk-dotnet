# AdditionalMessage

## ININ.PureCloudApi.Model.AdditionalMessage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **TextBody** | **string** | The body of the text message.  Maximum character counts are: SMS - 765 characters, other channels - 2000 characters. | |
| **MediaIds** | **List&lt;string&gt;** | The media ids associated with the text message. See https://developer.genesys.cloud/api/rest/v2/conversations/messaging-media-upload for example usage. | [optional] |
| **StickerIds** | **List&lt;string&gt;** | The sticker ids associated with the text message. | [optional] |
| **MessagingTemplate** | [**MessagingTemplateRequest**](MessagingTemplateRequest) | The messaging template use to send a predefined canned response with the message | [optional] |



_PureCloudPlatform.Client.V2 219.0.0_
