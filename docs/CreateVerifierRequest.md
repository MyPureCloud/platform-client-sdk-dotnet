# CreateVerifierRequest

## ININ.PureCloudApi.Model.CreateVerifierRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Algorithm** | **string** | The hashing algorithm for the TOTP verifier. | |
| **Digits** | **int?** | The number of digits in the TOTP code. Must be between 6 and 12. | |
| **Enabled** | **bool?** | Indicates whether this verifier will be enabled. | |
| **Name** | **string** | The name of the verifier. Maximum length is 100 characters. | |
| **Period** | **int?** | The time period in seconds for the TOTP code. | |
| **SecretSize** | **int?** | The size of the shared secret in bytes. Must be between 10 and 64. | |
| **Default** | **bool?** | Indicates whether this will be the default verifier. | |



_PureCloudPlatform.Client.V2 269.0.0_
