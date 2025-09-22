# WidgetDeployment

## ININ.PureCloudApi.Model.WidgetDeployment

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Description** | **string** | A human-readable description of this Deployment. | [optional] |
| **AuthenticationRequired** | **bool?** | When true, the customer members starting a chat must be authenticated by supplying their JWT to the create operation. | [optional] |
| **Disabled** | **bool?** | When true, all create chat operations using this Deployment will be rejected. | [optional] |
| **Flow** | [**DomainEntityRef**](DomainEntityRef) | The URI of the Inbound Chat Flow to run when new chats are initiated under this Deployment. | [optional] |
| **AllowedDomains** | **List&lt;string&gt;** | The list of domains that are approved to use this Deployment; the list will be added to CORS headers for ease of web use. | [optional] |
| **ClientType** | **string** | The type of display widget for which this Deployment is configured, which controls the administrator settings shown. | [optional] |
| **ClientConfig** | [**WidgetClientConfig**](WidgetClientConfig) | The client configuration options that should be made available to the clients of this Deployment. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 242.0.0_
