# ConversationRoutingData

## ININ.PureCloudApi.Model.ConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**AddressableEntityRef**](AddressableEntityRef) | The queue to use for routing decisions | [optional] |
| **Language** | [**AddressableEntityRef**](AddressableEntityRef) | The language to use for routing decisions | [optional] |
| **Priority** | **int?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;AddressableEntityRef&gt;**](AddressableEntityRef) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;ScoredAgent&gt;**](ScoredAgent) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |
| **Label** | **string** | An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level | [optional] |



_PureCloudPlatform.Client.V2 254.0.0_
