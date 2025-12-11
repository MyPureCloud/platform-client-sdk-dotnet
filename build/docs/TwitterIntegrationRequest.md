# TwitterIntegrationRequest

## ININ.PureCloudApi.Model.TwitterIntegrationRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the Twitter Integration | |
| **SupportedContent** | [**SupportedContentReference**](SupportedContentReference) | Defines the SupportedContent profile configured for an integration | [optional] |
| **MessagingSetting** | [**MessagingSettingRequestReference**](MessagingSettingRequestReference) | Defines the message settings to be applied for this integration | [optional] |
| **SignupCode** | **string** | The authorization code returned from the signup flow to request access tokens later on | |
| **AppId** | **string** | The appId of the Twitter app to register the integration on | |
| **CodeChallenge** | **string** | The codeChallenge used during the signup flow | |
| **RedirectUri** | **string** | The redirectUri used during the signup flow | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 251.0.0_
