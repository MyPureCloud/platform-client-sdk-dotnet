---
title: QueueConversationCallbackEventTopicConversationRoutingData
---
## ININ.PureCloudApi.Model.QueueConversationCallbackEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**QueueConversationCallbackEventTopicUriReference**](QueueConversationCallbackEventTopicUriReference.html) | A UriReference for a resource | [optional] |
| **Language** | [**QueueConversationCallbackEventTopicUriReference**](QueueConversationCallbackEventTopicUriReference.html) | A UriReference for a resource | [optional] |
| **Priority** | **int?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;QueueConversationCallbackEventTopicUriReference&gt;**](QueueConversationCallbackEventTopicUriReference.html) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;QueueConversationCallbackEventTopicScoredAgent&gt;**](QueueConversationCallbackEventTopicScoredAgent.html) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |
{: class="table table-striped"}


