# AuthenticatorAttestationResponse

## ININ.PureCloudApi.Model.AuthenticatorAttestationResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ClientDataJSON** | **string** | The JSON-serialized client data passed to the authenticator (base64url-encoded). | |
| **AttestationObject** | **string** | The attestation object containing the credential public key and attestation statement (base64url-encoded CBOR). | |
| **Transports** | **List&lt;string&gt;** | The transports the authenticator is believed to support. | [optional] |



_PureCloudPlatform.Client.V2 269.0.0_
