# WebDeployment

## ININ.PureCloudApi.Model.WebDeployment

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The deployment ID | [optional] |
| **Name** | **string** | The deployment name | |
| **Description** | **string** | The description of the config | [optional] |
| **AllowAllDomains** | **bool?** | Property indicates whether all domains are allowed or not. allowedDomains must be empty when this is set as true. | [optional] |
| **AllowedDomains** | **List&lt;string&gt;** | The list of domains that are approved to use this deployment; the list will be added to CORS headers for ease of web use. | [optional] |
| **SupportedContent** | [**SupportedContentReference**](SupportedContentReference) | The supported content profile for a deployment | [optional] |
| **Snippet** | **string** | Javascript snippet used to load the config | [optional] |
| **DateCreated** | **DateTime?** | The date the deployment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The date the deployment was most recently modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **LastModifiedUser** | [**AddressableEntityRef**](AddressableEntityRef) | A reference to the user who most recently modified the deployment | [optional] |
| **Flow** | [**WebDeploymentFlowEntityRef**](WebDeploymentFlowEntityRef) | A reference to the inboundshortmessage flow used by this deployment | [optional] |
| **Status** | **string** | The current status of the deployment | [optional] |
| **Configuration** | [**WebDeploymentConfigurationVersionEntityRef**](WebDeploymentConfigurationVersionEntityRef) | The config version this deployment uses | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 226.0.0_
