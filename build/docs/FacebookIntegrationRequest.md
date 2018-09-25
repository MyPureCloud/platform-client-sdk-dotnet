---
title: FacebookIntegrationRequest
---
## ININ.PureCloudApi.Model.FacebookIntegrationRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the Facebook Integration | |
| **PageAccessToken** | **string** | The long-lived Page Access Token of a facebook page.  See https://developers.facebook.com/docs/facebook-login/access-tokens.  When a pageAccessToken is provided, pageId and userAccessToken are not required. | [optional] |
| **UserAccessToken** | **string** | The short-lived User Access Token of the facebook user logged into the facebook app.  See https://developers.facebook.com/docs/facebook-login/access-tokens.  When userAccessToken is provided, pageId is mandatory.  When userAccessToken/pageId combination is provided, pageAccessToken is not required. | [optional] |
| **PageId** | **string** | The page Id of a facebook page. The pageId is required when userAccessToken is provided. | [optional] |
| **AppId** | **string** | The app Id of a facebook app | |
| **AppSecret** | **string** | The app Secret of a facebook app | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


