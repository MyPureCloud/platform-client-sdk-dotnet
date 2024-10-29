# ConversationChatEventTopicConversationRoutingData

## ININ.PureCloudApi.Model.ConversationChatEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**ConversationChatEventTopicUriReference**](ConversationChatEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Language** | [**ConversationChatEventTopicUriReference**](ConversationChatEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Priority** | **int?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;ConversationChatEventTopicUriReference&gt;**](ConversationChatEventTopicUriReference) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;ConversationChatEventTopicScoredAgent&gt;**](ConversationChatEventTopicScoredAgent) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |



_PureCloudPlatform.Client.V2 220.0.0_
