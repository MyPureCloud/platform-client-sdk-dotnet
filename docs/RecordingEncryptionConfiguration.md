# RecordingEncryptionConfiguration

## ININ.PureCloudApi.Model.RecordingEncryptionConfiguration

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Url** | **string** | When keyConfigurationType is LocalKeyManager, this should be the url for decryption and must specify the path to where GenesysCloud can requests decryption. When keyConfigurationType is KmsSymmetric, this should be the arn to the key alias for the master key | |
| **ApiId** | **string** | The api id for Hawk Authentication. Null if keyConfigurationType is KmsSymmetric | [optional] |
| **ApiKey** | **string** | The api shared symmetric key used for hawk authentication. Null if keyConfigurationType is KmsSymmetric | [optional] |
| **KeyConfigurationType** | **string** | Type should be LocalKeyManager or KmsSymmetric when create or update Key configurations; &#39;Native&#39; for disabling configuration. | |
| **LastError** | [**ErrorBody**](ErrorBody) | The error message related to the configuration | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 224.1.0_
