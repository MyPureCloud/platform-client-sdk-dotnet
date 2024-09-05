# EncryptionKey

## ININ.PureCloudApi.Model.EncryptionKey

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **CreateDate** | **DateTime?** | create date of the key pair. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **KeydataSummary** | **string** | key data summary (base 64 encoded public key) | [optional] |
| **User** | [**User**](User) | user that requested generation of public key | [optional] |
| **LocalEncryptionConfiguration** | [**LocalEncryptionConfiguration**](LocalEncryptionConfiguration) | Local configuration | [optional] |
| **KeyConfigurationType** | **string** | Key type used in this configuration | [optional] |
| **KmsKeyArn** | **string** | ARN of internal key to be wrapped by AWS KMS Symmetric key | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 214.0.0_
