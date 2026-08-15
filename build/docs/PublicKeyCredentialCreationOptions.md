# PublicKeyCredentialCreationOptions

## ININ.PureCloudApi.Model.PublicKeyCredentialCreationOptions

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Challenge** | **string** | Cryptographic challenge from the relying party (base64url-encoded). Must be returned to the relying party in the authenticator&#39;s response. | |
| **Rp** | [**RelyingPartyEntity**](RelyingPartyEntity) | Information about the relying party. | |
| **User** | [**UserEntity**](UserEntity) | Information about the user being registered. | |
| **PubKeyCredParams** | [**List&lt;CredentialParameter&gt;**](CredentialParameter) | Public key credential parameters acceptable to the relying party, in order of preference. | |
| **Timeout** | **int?** | Time in milliseconds the relying party is willing to wait for the registration operation to complete. | [optional] |
| **ExcludeCredentials** | [**List&lt;CredentialDescriptor&gt;**](CredentialDescriptor) | Credentials that should be excluded from registration (e.g., to prevent re-registering an existing authenticator). | [optional] |
| **AuthenticatorSelection** | [**AuthenticatorSelection**](AuthenticatorSelection) | Constraints on the type of authenticator that can be used. | [optional] |
| **Hints** | **List&lt;string&gt;** | Hints about the type of authenticator the user should use (e.g., &#39;security-key&#39;, &#39;client-device&#39;, &#39;hybrid&#39;). | [optional] |
| **Attestation** | **string** | The relying party&#39;s attestation conveyance preference (&#39;none&#39;, &#39;indirect&#39;, &#39;direct&#39;, or &#39;enterprise&#39;). | [optional] |
| **AttestationFormats** | **List&lt;string&gt;** | Acceptable attestation statement formats, in order of preference. | [optional] |
| **Extensions** | **Dictionary&lt;string, Object&gt;** | Inputs to client-side WebAuthn extensions. | [optional] |



_PureCloudPlatform.Client.V2 270.0.0_
