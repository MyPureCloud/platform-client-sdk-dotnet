---
title: WebChatDeployment
---
## ININ.PureCloudApi.Model.WebChatDeployment

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Description** | **string** |  | [optional] |
| **AuthenticationRequired** | **bool?** |  | [optional] |
| **AuthenticationUrl** | **string** | URL for third party service authenticating web chat clients. See https://github.com/MyPureCloud/authenticated-web-chat-server-examples | [optional] |
| **Disabled** | **bool?** |  | [optional] |
| **WebChatConfig** | [**WebChatConfig**](WebChatConfig.html) |  | [optional] |
| **AllowedDomains** | **List&lt;string&gt;** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


