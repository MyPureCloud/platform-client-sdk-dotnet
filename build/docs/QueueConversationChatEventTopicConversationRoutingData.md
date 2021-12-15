---
title: QueueConversationChatEventTopicConversationRoutingData
---
## ININ.PureCloudApi.Model.QueueConversationChatEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**QueueConversationChatEventTopicUriReference**](QueueConversationChatEventTopicUriReference.html) | A UriReference for a resource | [optional] |
| **Language** | [**QueueConversationChatEventTopicUriReference**](QueueConversationChatEventTopicUriReference.html) | A UriReference for a resource | [optional] |
| **Priority** | **int?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;QueueConversationChatEventTopicUriReference&gt;**](QueueConversationChatEventTopicUriReference.html) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;QueueConversationChatEventTopicScoredAgent&gt;**](QueueConversationChatEventTopicScoredAgent.html) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |
{: class="table table-striped"}


