# BidGroupWorkPlanRequest

## ININ.PureCloudApi.Model.BidGroupWorkPlanRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **WorkPlanId** | **string** | The ID of the work plan used in the bid group | |
| **OverrideAgentCount** | **int?** | The modified agent count for this work plan | [optional] |
| **SuggestedAgentCount** | **int?** | The number of agents needed for this work plan to produce the optimal schedule | [optional] |
| **AgentCountRange** | [**AgentCountRange**](AgentCountRange) | The range of agent slot count per work plan. The suggested slot count must be in agent count range | [optional] |



_PureCloudPlatform.Client.V2 224.0.0_
