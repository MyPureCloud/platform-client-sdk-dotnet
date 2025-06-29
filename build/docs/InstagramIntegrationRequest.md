# InstagramIntegrationRequest

## ININ.PureCloudApi.Model.InstagramIntegrationRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the Instagram Integration | |
| **SupportedContent** | [**SupportedContentReference**](SupportedContentReference) | Defines the SupportedContent profile configured for an integration | [optional] |
| **MessagingSetting** | [**MessagingSettingRequestReference**](MessagingSettingRequestReference) | Defines the message settings to be applied for this integration | [optional] |
| **PageAccessToken** | **string** | The long-lived Page Access Token of Instagram page.  See https://developers.facebook.com/docs/facebook-login/access-tokens.  When a pageAccessToken is provided, pageId and userAccessToken are not required. | [optional] |
| **UserAccessToken** | **string** | The short-lived User Access Token of Instagram user logged into Facebook app.  See https://developers.facebook.com/docs/facebook-login/access-tokens.  When userAccessToken is provided, pageId is mandatory.  When userAccessToken/pageId combination is provided, pageAccessToken is not required. | [optional] |
| **PageId** | **string** | The page ID of Instagram page. The pageId is required when userAccessToken is provided. | [optional] |
| **AppId** | **string** | The app ID of Facebook app. The appId is required when a customer wants to use their own approved Facebook app. | [optional] |
| **AppSecret** | **string** | The app Secret of Facebook app. The appSecret is required when appId is provided. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 237.0.0_
