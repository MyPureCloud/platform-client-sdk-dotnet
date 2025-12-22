# RoutingData

## ININ.PureCloudApi.Model.RoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **QueueId** | **string** | The identifier of the routing queue | |
| **LanguageId** | **string** | The identifier of a language to be considered in routing | [optional] |
| **Label** | **string** | An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level | [optional] |
| **Priority** | **int?** | The priority for routing | [optional] |
| **SkillIds** | **List&lt;string&gt;** | A list of skill identifiers to be considered in routing | [optional] |
| **PreferredAgentIds** | **List&lt;string&gt;** | A list of agents to be preferred in routing | [optional] |
| **ScoredAgents** | [**List&lt;ScoredAgent&gt;**](ScoredAgent) | A list of scored agents for routing decisions. For Agent Owned Callbacks use one scored agent with a score of 100. | [optional] |
| **RoutingFlags** | **List&lt;string&gt;** | An array of flags indicating how the conversation should be routed. Use \&quot;AGENT_OWNED_CALLBACK\&quot; when creating an Agent Owned Callback. | [optional] |



_PureCloudPlatform.Client.V2 252.1.0_
