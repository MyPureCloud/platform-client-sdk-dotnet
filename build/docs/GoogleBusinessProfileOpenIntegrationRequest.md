# GoogleBusinessProfileOpenIntegrationRequest

## ININ.PureCloudApi.Model.GoogleBusinessProfileOpenIntegrationRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the Google Business Profile Open Integration. | |
| **SupportedContent** | [**SupportedContentReference**](SupportedContentReference) | Defines the SupportedContent profile configured for an integration | [optional] |
| **MessagingSetting** | [**MessagingSettingRequestReference**](MessagingSettingRequestReference) | Defines the message settings to be applied for this integration | [optional] |
| **Token** | [**GoogleAuthTokenReference**](GoogleAuthTokenReference) | Google OAuth 2 access token reference. The actual token cannot be accessed via Genesys API, only referenced by this property by its ID. When the token is not referenced by any integration, it is deleted after 24 hours. | |
| **Account** | [**GoogleBusinessProfileAccountReference**](GoogleBusinessProfileAccountReference) | Google Business Profile account accessible with the authorization token | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 258.0.0_
