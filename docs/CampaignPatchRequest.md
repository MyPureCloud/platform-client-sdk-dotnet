# CampaignPatchRequest

## ININ.PureCloudApi.Model.CampaignPatchRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **OutboundLineCount** | **int?** | The number of outbound lines to be concurrently dialed. | [optional] |
| **AbandonRate** | **double?** | The targeted compliance abandon rate percentage | [optional] |
| **MaxCallsPerAgent** | **double?** | The maximum number of calls that can be placed per agent on this campaign | [optional] |
| **DynamicLineBalancingSettings** | [**DynamicLineBalancingSettingsPatchRequest**](DynamicLineBalancingSettingsPatchRequest) | Dynamic line balancing settings | [optional] |
| **Queue** | [**AddressableEntityRef**](AddressableEntityRef) | The Queue for this Campaign to route calls to. | [optional] |



_PureCloudPlatform.Client.V2 230.0.0_
