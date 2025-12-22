# AppleIntegrationRequest

## ININ.PureCloudApi.Model.AppleIntegrationRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the Apple messaging integration. | |
| **SupportedContent** | [**SupportedContentReference**](SupportedContentReference) | Defines the SupportedContent profile configured for an integration | [optional] |
| **MessagingSetting** | [**MessagingSettingRequestReference**](MessagingSettingRequestReference) | Defines the message settings to be applied for this integration | [optional] |
| **MessagesForBusinessId** | **string** | The Apple Messages for Business Id for the Apple messaging integration. | |
| **BusinessName** | **string** | The name of the business. | [optional] |
| **LogoUrl** | **string** | The url of the businesses logo. | [optional] |
| **AppleIMessageApp** | [**AppleIMessageApp**](AppleIMessageApp) | Interactive Application (iMessage App) Settings. | [optional] |
| **AppleAuthentication** | [**AppleAuthentication**](AppleAuthentication) | The Apple Messages for Business authentication setting. | [optional] |
| **ApplePay** | [**ApplePay**](ApplePay) | Apple Pay settings. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 252.1.0_
