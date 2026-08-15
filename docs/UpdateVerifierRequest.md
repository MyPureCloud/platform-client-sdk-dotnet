# UpdateVerifierRequest

## ININ.PureCloudApi.Model.UpdateVerifierRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the verifier. Maximum length is 100 characters. | |
| **Enabled** | **bool?** | Indicates whether this verifier will be enabled. | [optional] |
| **Credential** | [**Credential**](Credential) | The WebAuthn credential associated with this verifier. | [optional] |
| **Default** | **bool?** | Indicates whether this will be the default verifier. | [optional] |



_PureCloudPlatform.Client.V2 270.0.0_
