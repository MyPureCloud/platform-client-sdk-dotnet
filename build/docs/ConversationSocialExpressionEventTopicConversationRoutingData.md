---
title: ConversationSocialExpressionEventTopicConversationRoutingData
---
## ININ.PureCloudApi.Model.ConversationSocialExpressionEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**ConversationSocialExpressionEventTopicUriReference**](ConversationSocialExpressionEventTopicUriReference.html) | A UriReference for a resource | [optional] |
| **Language** | [**ConversationSocialExpressionEventTopicUriReference**](ConversationSocialExpressionEventTopicUriReference.html) | A UriReference for a resource | [optional] |
| **Priority** | **int?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;ConversationSocialExpressionEventTopicUriReference&gt;**](ConversationSocialExpressionEventTopicUriReference.html) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;ConversationSocialExpressionEventTopicScoredAgent&gt;**](ConversationSocialExpressionEventTopicScoredAgent.html) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |
{: class="table table-striped"}


