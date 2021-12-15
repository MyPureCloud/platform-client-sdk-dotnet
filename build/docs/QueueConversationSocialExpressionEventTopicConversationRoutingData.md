---
title: QueueConversationSocialExpressionEventTopicConversationRoutingData
---
## ININ.PureCloudApi.Model.QueueConversationSocialExpressionEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**QueueConversationSocialExpressionEventTopicUriReference**](QueueConversationSocialExpressionEventTopicUriReference.html) |  | [optional] |
| **Language** | [**QueueConversationSocialExpressionEventTopicUriReference**](QueueConversationSocialExpressionEventTopicUriReference.html) | A UriReference for a resource | [optional] |
| **Priority** | **int?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;QueueConversationSocialExpressionEventTopicUriReference&gt;**](QueueConversationSocialExpressionEventTopicUriReference.html) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;QueueConversationSocialExpressionEventTopicScoredAgent&gt;**](QueueConversationSocialExpressionEventTopicScoredAgent.html) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |
{: class="table table-striped"}


