# AuthenticatorSelection

## ININ.PureCloudApi.Model.AuthenticatorSelection

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **AuthenticatorAttachment** | **string** | Desired authenticator attachment modality (&#39;platform&#39; or &#39;cross-platform&#39;). | [optional] |
| **RequireResidentKey** | **bool?** | Whether a resident (discoverable) credential is required. Deprecated by the WebAuthn spec in favor of residentKey. | [optional] |
| **ResidentKey** | **string** | The relying party&#39;s requirement for resident (discoverable) credentials (&#39;discouraged&#39;, &#39;preferred&#39;, or &#39;required&#39;). | [optional] |
| **UserVerification** | **string** | The user verification requirement (&#39;discouraged&#39;, &#39;preferred&#39;, or &#39;required&#39;). | [optional] |



_PureCloudPlatform.Client.V2 269.0.0_
