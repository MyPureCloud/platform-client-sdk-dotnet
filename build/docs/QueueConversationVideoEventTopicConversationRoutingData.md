---
title: QueueConversationVideoEventTopicConversationRoutingData
---
## ININ.PureCloudApi.Model.QueueConversationVideoEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**QueueConversationVideoEventTopicUriReference**](QueueConversationVideoEventTopicUriReference.html) |  | [optional] |
| **Language** | [**QueueConversationVideoEventTopicUriReference**](QueueConversationVideoEventTopicUriReference.html) | A UriReference for a resource | [optional] |
| **Priority** | **int?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;QueueConversationVideoEventTopicUriReference&gt;**](QueueConversationVideoEventTopicUriReference.html) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;QueueConversationVideoEventTopicScoredAgent&gt;**](QueueConversationVideoEventTopicScoredAgent.html) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |
{: class="table table-striped"}


