# OpenIntegrationRequest

## ININ.PureCloudApi.Model.OpenIntegrationRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the Open messaging integration. | |
| **SupportedContent** | [**SupportedContentReference**](SupportedContentReference) | Defines the SupportedContent profile configured for an integration | [optional] |
| **MessagingSetting** | [**MessagingSettingRequestReference**](MessagingSettingRequestReference) | Defines the message settings to be applied for this integration | [optional] |
| **OutboundNotificationWebhookUrl** | **string** | The outbound notification webhook URL for the Open messaging integration. | |
| **OutboundNotificationWebhookSignatureSecretToken** | **string** | The outbound notification webhook signature secret token. This token must be longer than 15 characters. | |
| **WebhookHeaders** | **Dictionary&lt;string, string&gt;** | The user specified headers for the Open messaging integration. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 257.0.0_
