# CreateVerifierResponse

## ININ.PureCloudApi.Model.CreateVerifierResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The unique identifier of the verifier. | [optional] |
| **Name** | **string** | The name of the verifier. | [optional] |
| **Type** | **string** | The type of verifier. | [optional] |
| **Enabled** | **bool?** | Indicates whether this verifier is enabled. | [optional] |
| **KeyUri** | **string** | The key URI for TOTP authenticator app registration. | [optional] |
| **EncodedQuickResponseCode** | **string** | Base64-encoded PNG of the TOTP registration QR code. | [optional] |
| **Default** | **bool?** | Indicates whether this is the default verifier. | [optional] |



_PureCloudPlatform.Client.V2 273.0.0_
