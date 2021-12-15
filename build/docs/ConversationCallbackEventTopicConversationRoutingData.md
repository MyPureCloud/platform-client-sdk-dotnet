---
title: ConversationCallbackEventTopicConversationRoutingData
---
## ININ.PureCloudApi.Model.ConversationCallbackEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**ConversationCallbackEventTopicUriReference**](ConversationCallbackEventTopicUriReference.html) | A UriReference for a resource | [optional] |
| **Language** | [**ConversationCallbackEventTopicUriReference**](ConversationCallbackEventTopicUriReference.html) | A UriReference for a resource | [optional] |
| **Priority** | **int?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;ConversationCallbackEventTopicUriReference&gt;**](ConversationCallbackEventTopicUriReference.html) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;ConversationCallbackEventTopicScoredAgent&gt;**](ConversationCallbackEventTopicScoredAgent.html) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |
{: class="table table-striped"}


