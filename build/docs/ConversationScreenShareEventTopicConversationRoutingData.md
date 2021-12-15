---
title: ConversationScreenShareEventTopicConversationRoutingData
---
## ININ.PureCloudApi.Model.ConversationScreenShareEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**ConversationScreenShareEventTopicUriReference**](ConversationScreenShareEventTopicUriReference.html) | A UriReference for a resource | [optional] |
| **Language** | [**ConversationScreenShareEventTopicUriReference**](ConversationScreenShareEventTopicUriReference.html) | A UriReference for a resource | [optional] |
| **Priority** | **int?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;ConversationScreenShareEventTopicUriReference&gt;**](ConversationScreenShareEventTopicUriReference.html) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;ConversationScreenShareEventTopicScoredAgent&gt;**](ConversationScreenShareEventTopicScoredAgent.html) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |
{: class="table table-striped"}


