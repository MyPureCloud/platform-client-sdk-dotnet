# FlowLogLevelCharacteristicsDefinition

## ININ.PureCloudApi.Model.FlowLogLevelCharacteristicsDefinition

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **MinimumLevel** | **string** | The minimum level required for this characteristic to be enabled. | [optional] |
| **DependsOn** | [**FlowCharacteristics**](FlowCharacteristics) | If set, this is the id of the characteristic that this one depends on and it must be enabled for this to be enabled. | [optional] |



_PureCloudPlatform.Client.V2 234.0.0_
