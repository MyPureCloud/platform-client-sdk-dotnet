---
title: ScimServiceProviderConfig
---
## ININ.PureCloudApi.Model.ScimServiceProviderConfig

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Schemas** | **List&lt;string&gt;** | schemas supported | [optional] |
| **DocumentationUri** | **string** | Documentation | [optional] |
| **Patch** | [**ScimServiceProviderConfigSimpleFeature**](ScimServiceProviderConfigSimpleFeature.html) | Patch support | [optional] |
| **Filter** | [**ScimServiceProviderConfigFilterFeature**](ScimServiceProviderConfigFilterFeature.html) | Filter support. Additional properties: maxResults | [optional] |
| **Etag** | [**ScimServiceProviderConfigSimpleFeature**](ScimServiceProviderConfigSimpleFeature.html) | Entity Tag support | [optional] |
| **Sort** | [**ScimServiceProviderConfigSimpleFeature**](ScimServiceProviderConfigSimpleFeature.html) | Sort support | [optional] |
| **Bulk** | [**ScimServiceProviderConfigBulkFeature**](ScimServiceProviderConfigBulkFeature.html) | Bulk support | [optional] |
| **ChangePassword** | [**ScimServiceProviderConfigSimpleFeature**](ScimServiceProviderConfigSimpleFeature.html) | Change password | [optional] |
| **AuthenticationSchemes** | [**List&lt;ScimServiceProviderConfigAuthenticationScheme&gt;**](ScimServiceProviderConfigAuthenticationScheme.html) | Authentication schemes supported. | [optional] |
| **Meta** | [**ScimMetadata**](ScimMetadata.html) | Resource SCIM meta | [optional] |
{: class="table table-striped"}


