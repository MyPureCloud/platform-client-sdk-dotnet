# DeploymentIdentityResolutionConfig

## ININ.PureCloudApi.Model.DeploymentIdentityResolutionConfig

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Division** | [**WritableStarrableDivision**](WritableStarrableDivision) | The division to use when performing identity resolution. | [optional] |
| **ResolveIdentities** | **bool?** | Whether the channel should resolve identities | |
| **ExternalSource** | [**IdentityResolutionExternalSource**](IdentityResolutionExternalSource) | The external source used for stitching this channel. | [optional] |
| **Automerge** | [**IdentityResolutionAutomergeConfig**](IdentityResolutionAutomergeConfig) | Whether automerging of contacts should be enabled for each channel. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 258.0.0_
