# ConversationEncryptionConfiguration

## ININ.PureCloudApi.Model.ConversationEncryptionConfiguration

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Url** | **string** | keyConfigurationType is always KmsSymmetric, and should be the arn to the key alias for the master key | |
| **KeyConfigurationType** | **string** | Type should be &#39;KmsSymmetric&#39; when create or update Key configurations, &#39;None&#39; to disable configuration. | |
| **LastError** | [**ErrorBody**](ErrorBody) | The error message related to the configuration | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 234.0.0_
