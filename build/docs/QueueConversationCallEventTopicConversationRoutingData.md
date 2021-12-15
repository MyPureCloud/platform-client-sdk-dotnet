---
title: QueueConversationCallEventTopicConversationRoutingData
---
## ININ.PureCloudApi.Model.QueueConversationCallEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**QueueConversationCallEventTopicUriReference**](QueueConversationCallEventTopicUriReference.html) | A UriReference for a resource | [optional] |
| **Language** | [**QueueConversationCallEventTopicUriReference**](QueueConversationCallEventTopicUriReference.html) | A UriReference for a resource | [optional] |
| **Priority** | **int?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;QueueConversationCallEventTopicUriReference&gt;**](QueueConversationCallEventTopicUriReference.html) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;QueueConversationCallEventTopicScoredAgent&gt;**](QueueConversationCallEventTopicScoredAgent.html) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |
{: class="table table-striped"}


