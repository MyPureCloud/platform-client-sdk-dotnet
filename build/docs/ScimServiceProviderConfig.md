# ScimServiceProviderConfig

## ININ.PureCloudApi.Model.ScimServiceProviderConfig

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Schemas** | **List&lt;string&gt;** | The list of supported schemas. | [optional] |
| **DocumentationUri** | **string** | The HTTP-addressable URL that points to the service provider&#39;s documentation. | [optional] |
| **Patch** | [**ScimServiceProviderConfigSimpleFeature**](ScimServiceProviderConfigSimpleFeature) | The \&quot;patch\&quot; configuration options. | [optional] |
| **Filter** | [**ScimServiceProviderConfigFilterFeature**](ScimServiceProviderConfigFilterFeature) | The \&quot;filter\&quot; configuration options. | [optional] |
| **Etag** | [**ScimServiceProviderConfigSimpleFeature**](ScimServiceProviderConfigSimpleFeature) | The \&quot;etag\&quot; configuration options. | [optional] |
| **Sort** | [**ScimServiceProviderConfigSimpleFeature**](ScimServiceProviderConfigSimpleFeature) | The \&quot;sort\&quot; configuration options. | [optional] |
| **Bulk** | [**ScimServiceProviderConfigBulkFeature**](ScimServiceProviderConfigBulkFeature) | The \&quot;bulk\&quot; configuration options. | [optional] |
| **ChangePassword** | [**ScimServiceProviderConfigSimpleFeature**](ScimServiceProviderConfigSimpleFeature) | The \&quot;changePassword\&quot; configuration options. | [optional] |
| **AuthenticationSchemes** | [**List&lt;ScimServiceProviderConfigAuthenticationScheme&gt;**](ScimServiceProviderConfigAuthenticationScheme) | The list of supported authentication schemes. | [optional] |
| **Meta** | [**ScimMetadata**](ScimMetadata) | The metadata of the SCIM resource. Metadata is defined as immutable per SCIM RFC. | [optional] |



_PureCloudPlatform.Client.V2 236.0.0_
