---
title: ConversationEventTopicConversationRoutingData
---
## ININ.PureCloudApi.Model.ConversationEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**ConversationEventTopicUriReference**](ConversationEventTopicUriReference.html) |  | [optional] |
| **Language** | [**ConversationEventTopicUriReference**](ConversationEventTopicUriReference.html) | A UriReference for a resource | [optional] |
| **Priority** | **int?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;ConversationEventTopicUriReference&gt;**](ConversationEventTopicUriReference.html) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;ConversationEventTopicScoredAgent&gt;**](ConversationEventTopicScoredAgent.html) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |
{: class="table table-striped"}


