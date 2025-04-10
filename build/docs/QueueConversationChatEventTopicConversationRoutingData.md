# QueueConversationChatEventTopicConversationRoutingData

## ININ.PureCloudApi.Model.QueueConversationChatEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**QueueConversationChatEventTopicUriReference**](QueueConversationChatEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Language** | [**QueueConversationChatEventTopicUriReference**](QueueConversationChatEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Priority** | **long?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;QueueConversationChatEventTopicUriReference&gt;**](QueueConversationChatEventTopicUriReference) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;QueueConversationChatEventTopicScoredAgent&gt;**](QueueConversationChatEventTopicScoredAgent) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |



_PureCloudPlatform.Client.V2 231.1.0_
