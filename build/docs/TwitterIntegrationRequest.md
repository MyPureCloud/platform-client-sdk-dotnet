---
title: TwitterIntegrationRequest
---
## ININ.PureCloudApi.Model.TwitterIntegrationRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the Twitter Integration | |
| **SupportedContent** | [**SupportedContentReference**](SupportedContentReference.html) | Defines the SupportedContent profile configured for an integration | [optional] |
| **MessagingSetting** | [**MessagingSettingReference**](MessagingSettingReference.html) |  | [optional] |
| **AccessTokenKey** | **string** | The Access Token Key from Twitter messenger | |
| **AccessTokenSecret** | **string** | The Access Token Secret from Twitter messenger | |
| **ConsumerKey** | **string** | The Consumer Key from Twitter messenger | |
| **ConsumerSecret** | **string** | The Consumer Secret from Twitter messenger | |
| **Tier** | **string** | The type of twitter account to be used for the integration | |
| **EnvName** | **string** | The Twitter environment name, e.g.: env-beta (required for premium tier) | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


