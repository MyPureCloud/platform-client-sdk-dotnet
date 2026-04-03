# UtilizationRequest

## ININ.PureCloudApi.Model.UtilizationRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Utilization** | [**Dictionary&lt;string, MediaUtilization&gt;**](MediaUtilization) | Map of media type to utilization settings. | [optional] |
| **LabelUtilizations** | [**Dictionary&lt;string, LabelUtilizationRequest&gt;**](LabelUtilizationRequest) | Map of label ids to utilization settings. | [optional] |
| **MaxInboundCalls** | **int?** | Max number of inbound voice calls. | [optional] |



_PureCloudPlatform.Client.V2 261.0.0_
