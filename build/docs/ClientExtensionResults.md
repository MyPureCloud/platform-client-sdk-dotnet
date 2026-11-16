# ClientExtensionResults

## ININ.PureCloudApi.Model.ClientExtensionResults

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Appid** | **bool?** | App ID extension output (legacy U2F migration). | [optional] |
| **CredProps** | [**CredentialPropertiesOutput**](CredentialPropertiesOutput) | Credential properties extension output. | [optional] |
| **HmacCreateSecret** | **bool?** | HMAC secret extension output. | [optional] |
| **LargeBlob** | [**AuthenticationExtensionsLargeBlobOutputs**](AuthenticationExtensionsLargeBlobOutputs) | Large blob extension outputs. | [optional] |
| **Prf** | [**AuthenticationExtensionsPRFOutputs**](AuthenticationExtensionsPRFOutputs) | Pseudo-random function (PRF) extension outputs. | [optional] |



_PureCloudPlatform.Client.V2 277.0.0_
