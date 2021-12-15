---
title: ConversationMessageEventTopicConversationRoutingData
---
## ININ.PureCloudApi.Model.ConversationMessageEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**ConversationMessageEventTopicUriReference**](ConversationMessageEventTopicUriReference.html) | A UriReference for a resource | [optional] |
| **Language** | [**ConversationMessageEventTopicUriReference**](ConversationMessageEventTopicUriReference.html) | A UriReference for a resource | [optional] |
| **Priority** | **int?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;ConversationMessageEventTopicUriReference&gt;**](ConversationMessageEventTopicUriReference.html) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;ConversationMessageEventTopicScoredAgent&gt;**](ConversationMessageEventTopicScoredAgent.html) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |
{: class="table table-striped"}


