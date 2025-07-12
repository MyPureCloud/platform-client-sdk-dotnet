# QueueConversationEventTopicConversationRoutingData

## ININ.PureCloudApi.Model.QueueConversationEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**QueueConversationEventTopicUriReference**](QueueConversationEventTopicUriReference) |  | [optional] |
| **Language** | [**QueueConversationEventTopicUriReference**](QueueConversationEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Priority** | **long?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;QueueConversationEventTopicUriReference&gt;**](QueueConversationEventTopicUriReference) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;QueueConversationEventTopicScoredAgent&gt;**](QueueConversationEventTopicScoredAgent) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |



_PureCloudPlatform.Client.V2 238.0.0_
