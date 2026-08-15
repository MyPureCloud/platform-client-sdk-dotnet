# PublicKeyCredentialCreationResponse

## ININ.PureCloudApi.Model.PublicKeyCredentialCreationResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The credential identifier (base64url-encoded). | |
| **Type** | **string** | The credential type (must be &#39;public-key&#39;). | |
| **RawId** | **string** | The raw credential identifier as a binary value (base64url-encoded). | |
| **AuthenticatorAttachment** | **string** | The authenticator attachment modality used (&#39;platform&#39; or &#39;cross-platform&#39;). | [optional] |
| **ClientExtensionResults** | **Dictionary&lt;string, Object&gt;** | Outputs from client-side WebAuthn extensions. | [optional] |
| **Response** | [**AuthenticatorAttestationResponse**](AuthenticatorAttestationResponse) | The authenticator&#39;s attestation response. | |



_PureCloudPlatform.Client.V2 270.0.0_
