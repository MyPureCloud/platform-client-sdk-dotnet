# WebChatDeployment

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
| **WebChatConfig** | [**WebChatConfig**](WebChatConfig) |  | [optional] |
| **AllowedDomains** | **List&lt;string&gt;** |  | [optional] |
| **Flow** | [**DomainEntityRef**](DomainEntityRef) | The URI of the Inbound Chat Flow to run when new chats are initiated under this Deployment. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 225.0.0_
