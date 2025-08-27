# ConversationSocialExpressionEventTopicConversationRoutingData

## ININ.PureCloudApi.Model.ConversationSocialExpressionEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**ConversationSocialExpressionEventTopicUriReference**](ConversationSocialExpressionEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Language** | [**ConversationSocialExpressionEventTopicUriReference**](ConversationSocialExpressionEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Priority** | **long?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;ConversationSocialExpressionEventTopicUriReference&gt;**](ConversationSocialExpressionEventTopicUriReference) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;ConversationSocialExpressionEventTopicScoredAgent&gt;**](ConversationSocialExpressionEventTopicScoredAgent) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |



_PureCloudPlatform.Client.V2 241.0.0_
