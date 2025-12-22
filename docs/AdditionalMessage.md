# AdditionalMessage

## ININ.PureCloudApi.Model.AdditionalMessage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **TextBody** | **string** | The body of the text message.  Maximum character counts are: SMS - 765 characters, other channels - 2000 characters. | |
| **MediaIds** | **List&lt;string&gt;** | The media ids associated with the text message. See https://developer.genesys.cloud/api/rest/v2/conversations/messaging-media-upload for example usage. | [optional] |
| **MessagingTemplate** | [**SendMessagingTemplateRequest**](SendMessagingTemplateRequest) | Pre-defined message templates for structured communications. Supports various template types including WhatsApp business messaging template and form | [optional] |



_PureCloudPlatform.Client.V2 252.1.0_
