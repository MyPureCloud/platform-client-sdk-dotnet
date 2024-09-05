# IntegrationConfiguration

## ININ.PureCloudApi.Model.IntegrationConfiguration

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the integration, used to distinguish this integration from others of the same type. | |
| **Version** | **int?** | Version number required for updates. | |
| **Properties** | **Object** | Key-value configuration settings described by the schema in the propertiesSchemaUri field. | |
| **Advanced** | **Object** | Advanced configuration described by the schema in the advancedSchemaUri field. | |
| **Notes** | **string** | Notes about the integration. | |
| **Credentials** | [**Dictionary&lt;string, CredentialInfo&gt;**](CredentialInfo) | Credentials required by the integration. The required keys are indicated in the credentials property of the Integration Type | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 214.0.0_
