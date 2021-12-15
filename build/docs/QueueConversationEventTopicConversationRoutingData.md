---
title: QueueConversationEventTopicConversationRoutingData
---
## ININ.PureCloudApi.Model.QueueConversationEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**QueueConversationEventTopicUriReference**](QueueConversationEventTopicUriReference.html) |  | [optional] |
| **Language** | [**QueueConversationEventTopicUriReference**](QueueConversationEventTopicUriReference.html) | A UriReference for a resource | [optional] |
| **Priority** | **int?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;QueueConversationEventTopicUriReference&gt;**](QueueConversationEventTopicUriReference.html) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;QueueConversationEventTopicScoredAgent&gt;**](QueueConversationEventTopicScoredAgent.html) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |
{: class="table table-striped"}


