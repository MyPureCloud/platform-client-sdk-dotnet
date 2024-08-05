---
title: BidGroupWorkPlanResponse
---
## ININ.PureCloudApi.Model.BidGroupWorkPlanResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **ManagementUnit** | [**ManagementUnitReference**](ManagementUnitReference.html) | The management unit to which this work plan belongs.  Nullable in some routes | [optional] |
| **OverrideAgentCount** | **int?** | The modified agent count for this work plan | [optional] |
| **SuggestedAgentCount** | **int?** | The number of agents needed for this work plan to produce the optimal schedule | [optional] |
| **AgentCountRange** | [**AgentCountRange**](AgentCountRange.html) | The range of agent slot count per work plan. The suggested slot count must be in agent count range | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


