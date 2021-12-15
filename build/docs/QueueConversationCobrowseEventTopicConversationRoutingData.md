---
title: QueueConversationCobrowseEventTopicConversationRoutingData
---
## ININ.PureCloudApi.Model.QueueConversationCobrowseEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**QueueConversationCobrowseEventTopicUriReference**](QueueConversationCobrowseEventTopicUriReference.html) | A UriReference for a resource | [optional] |
| **Language** | [**QueueConversationCobrowseEventTopicUriReference**](QueueConversationCobrowseEventTopicUriReference.html) | A UriReference for a resource | [optional] |
| **Priority** | **int?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;QueueConversationCobrowseEventTopicUriReference&gt;**](QueueConversationCobrowseEventTopicUriReference.html) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;QueueConversationCobrowseEventTopicScoredAgent&gt;**](QueueConversationCobrowseEventTopicScoredAgent.html) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |
{: class="table table-striped"}


