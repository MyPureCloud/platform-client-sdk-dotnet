---
title: ConversationEmailEventTopicConversationRoutingData
---
## ININ.PureCloudApi.Model.ConversationEmailEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**ConversationEmailEventTopicUriReference**](ConversationEmailEventTopicUriReference.html) | A UriReference for a resource | [optional] |
| **Language** | [**ConversationEmailEventTopicUriReference**](ConversationEmailEventTopicUriReference.html) | A UriReference for a resource | [optional] |
| **Priority** | **int?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;ConversationEmailEventTopicUriReference&gt;**](ConversationEmailEventTopicUriReference.html) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;ConversationEmailEventTopicScoredAgent&gt;**](ConversationEmailEventTopicScoredAgent.html) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |
{: class="table table-striped"}


