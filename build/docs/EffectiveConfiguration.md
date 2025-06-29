# EffectiveConfiguration

## ININ.PureCloudApi.Model.EffectiveConfiguration

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Properties** | **Dictionary&lt;string, Object&gt;** | Key-value configuration settings described by the schema in the propertiesSchemaUri field. | |
| **Advanced** | **Dictionary&lt;string, Object&gt;** | Advanced configuration described by the schema in the advancedSchemaUri field. | |
| **Name** | **string** | The name of the integration, used to distinguish this integration from others of the same type. | |
| **Notes** | **string** | Notes about the integration. | |
| **Credentials** | [**Dictionary&lt;string, CredentialInfo&gt;**](CredentialInfo) | Credentials required by the integration. The required keys are indicated in the credentials property of the Integration Type | |



_PureCloudPlatform.Client.V2 237.0.0_
