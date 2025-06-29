# QueueConversationEmailEventTopicConversationRoutingData

## ININ.PureCloudApi.Model.QueueConversationEmailEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**QueueConversationEmailEventTopicUriReference**](QueueConversationEmailEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Language** | [**QueueConversationEmailEventTopicUriReference**](QueueConversationEmailEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Priority** | **long?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;QueueConversationEmailEventTopicUriReference&gt;**](QueueConversationEmailEventTopicUriReference) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;QueueConversationEmailEventTopicScoredAgent&gt;**](QueueConversationEmailEventTopicScoredAgent) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |



_PureCloudPlatform.Client.V2 237.0.0_
