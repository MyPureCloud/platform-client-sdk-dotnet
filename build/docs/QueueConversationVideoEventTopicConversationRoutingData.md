# QueueConversationVideoEventTopicConversationRoutingData

## ININ.PureCloudApi.Model.QueueConversationVideoEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**QueueConversationVideoEventTopicUriReference**](QueueConversationVideoEventTopicUriReference) |  | [optional] |
| **Language** | [**QueueConversationVideoEventTopicUriReference**](QueueConversationVideoEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Priority** | **int?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;QueueConversationVideoEventTopicUriReference&gt;**](QueueConversationVideoEventTopicUriReference) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;QueueConversationVideoEventTopicScoredAgent&gt;**](QueueConversationVideoEventTopicScoredAgent) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |



_PureCloudPlatform.Client.V2 226.0.0_
