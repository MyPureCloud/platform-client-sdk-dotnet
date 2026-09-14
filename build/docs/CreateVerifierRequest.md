# CreateVerifierRequest

## ININ.PureCloudApi.Model.CreateVerifierRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Algorithm** | **string** | The hashing algorithm for the TOTP verifier. | [optional] |
| **Digits** | **int?** | The number of digits in the TOTP code. Must be between 6 and 12. | [optional] |
| **Enabled** | **bool?** | Indicates whether this verifier will be enabled. | [optional] |
| **Name** | **string** | The name of the verifier. Maximum length is 100 characters. | |
| **Period** | **int?** | The time period in seconds for the TOTP code. | [optional] |
| **SecretSize** | **int?** | The size of the shared secret in bytes. Must be between 10 and 64. | [optional] |
| **Default** | **bool?** | Indicates whether this will be the default verifier. | [optional] |



_PureCloudPlatform.Client.V2 273.0.0_
