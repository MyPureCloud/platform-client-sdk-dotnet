---
title: ConversationVideoEventTopicConversationRoutingData
---
## ININ.PureCloudApi.Model.ConversationVideoEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**ConversationVideoEventTopicUriReference**](ConversationVideoEventTopicUriReference.html) | A UriReference for a resource | [optional] |
| **Language** | [**ConversationVideoEventTopicUriReference**](ConversationVideoEventTopicUriReference.html) | A UriReference for a resource | [optional] |
| **Priority** | **int?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;ConversationVideoEventTopicUriReference&gt;**](ConversationVideoEventTopicUriReference.html) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;ConversationVideoEventTopicScoredAgent&gt;**](ConversationVideoEventTopicScoredAgent.html) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |
{: class="table table-striped"}


