# QueueConversationSocialExpressionEventTopicConversationRoutingData

## ININ.PureCloudApi.Model.QueueConversationSocialExpressionEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**QueueConversationSocialExpressionEventTopicUriReference**](QueueConversationSocialExpressionEventTopicUriReference) |  | [optional] |
| **Language** | [**QueueConversationSocialExpressionEventTopicUriReference**](QueueConversationSocialExpressionEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Priority** | **long?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;QueueConversationSocialExpressionEventTopicUriReference&gt;**](QueueConversationSocialExpressionEventTopicUriReference) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;QueueConversationSocialExpressionEventTopicScoredAgent&gt;**](QueueConversationSocialExpressionEventTopicScoredAgent) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |



_PureCloudPlatform.Client.V2 238.0.0_
