# WhatsAppEmbeddedSignupIntegrationRequest

## ININ.PureCloudApi.Model.WhatsAppEmbeddedSignupIntegrationRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the WhatsApp Integration. Required for Embedded Signup v2; optional for v4 (set later via PATCH). | [optional] |
| **SupportedContent** | [**SupportedContentReference**](SupportedContentReference) | Defines the SupportedContent profile configured for an integration | [optional] |
| **MessagingSetting** | [**MessagingSettingRequestReference**](MessagingSettingRequestReference) | Defines the message settings to be applied for this integration | [optional] |
| **EmbeddedSignupAccessToken** | **string** | The access token returned from the embedded signup flow. Not required for versions v4 or later. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 273.0.0_
