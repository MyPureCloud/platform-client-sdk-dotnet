---
title: ConversationCobrowseEventTopicConversationRoutingData
---
## ININ.PureCloudApi.Model.ConversationCobrowseEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**ConversationCobrowseEventTopicUriReference**](ConversationCobrowseEventTopicUriReference.html) | A UriReference for a resource | [optional] |
| **Language** | [**ConversationCobrowseEventTopicUriReference**](ConversationCobrowseEventTopicUriReference.html) | A UriReference for a resource | [optional] |
| **Priority** | **int?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;ConversationCobrowseEventTopicUriReference&gt;**](ConversationCobrowseEventTopicUriReference.html) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;ConversationCobrowseEventTopicScoredAgent&gt;**](ConversationCobrowseEventTopicScoredAgent.html) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |
{: class="table table-striped"}


