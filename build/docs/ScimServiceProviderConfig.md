---
title: ScimServiceProviderConfig
---
## ININ.PureCloudApi.Model.ScimServiceProviderConfig

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Schemas** | **List&lt;string&gt;** | The list of supported schemas. | [optional] |
| **DocumentationUri** | **string** | The HTTP-addressable URL that points to the service provider&#39;s documentation. | [optional] |
| **Patch** | [**ScimServiceProviderConfigSimpleFeature**](ScimServiceProviderConfigSimpleFeature.html) | \&quot;patch\&quot; configuration options. | [optional] |
| **Filter** | [**ScimServiceProviderConfigFilterFeature**](ScimServiceProviderConfigFilterFeature.html) | \&quot;filter\&quot; configuration options. | [optional] |
| **Etag** | [**ScimServiceProviderConfigSimpleFeature**](ScimServiceProviderConfigSimpleFeature.html) | \&quot;ETag\&quot; configuration options. | [optional] |
| **Sort** | [**ScimServiceProviderConfigSimpleFeature**](ScimServiceProviderConfigSimpleFeature.html) | \&quot;sort\&quot; configuration options. | [optional] |
| **Bulk** | [**ScimServiceProviderConfigBulkFeature**](ScimServiceProviderConfigBulkFeature.html) | \&quot;bulk\&quot; configuration options. | [optional] |
| **ChangePassword** | [**ScimServiceProviderConfigSimpleFeature**](ScimServiceProviderConfigSimpleFeature.html) | \&quot;changePassword\&quot; configuration options. | [optional] |
| **AuthenticationSchemes** | [**List&lt;ScimServiceProviderConfigAuthenticationScheme&gt;**](ScimServiceProviderConfigAuthenticationScheme.html) | The list of supported authentication schemes. | [optional] |
| **Meta** | [**ScimMetadata**](ScimMetadata.html) | Resource SCIM meta | [optional] |
{: class="table table-striped"}


