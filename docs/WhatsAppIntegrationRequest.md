# WhatsAppIntegrationRequest

## ININ.PureCloudApi.Model.WhatsAppIntegrationRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the WhatsApp Integration | |
| **SupportedContent** | [**SupportedContentReference**](SupportedContentReference) | Defines the SupportedContent profile configured for an integration | [optional] |
| **MessagingSetting** | [**MessagingSettingRequestReference**](MessagingSettingRequestReference) | Defines the message settings to be applied for this integration | [optional] |
| **PhoneNumber** | **string** | The phone number associated to the whatsApp integration | |
| **WabaCertificate** | **string** | The waba(WhatsApp Business Manager) certificate associated to the WhatsApp integration phone number | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 217.0.0_
