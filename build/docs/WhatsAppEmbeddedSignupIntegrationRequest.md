---
title: WhatsAppEmbeddedSignupIntegrationRequest
---
## ININ.PureCloudApi.Model.WhatsAppEmbeddedSignupIntegrationRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the WhatsApp Integration | |
| **SupportedContent** | [**SupportedContentReference**](SupportedContentReference.html) | Defines the SupportedContent profile configured for an integration | [optional] |
| **MessagingSetting** | [**MessagingSettingRequestReference**](MessagingSettingRequestReference.html) | Defines the message settings to be applied for this integration | [optional] |
| **EmbeddedSignupAccessToken** | **string** | The access token returned from the embedded signup flow | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


