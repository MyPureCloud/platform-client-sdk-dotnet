# ConversationMessageEventTopicConversationRoutingData

## ININ.PureCloudApi.Model.ConversationMessageEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**ConversationMessageEventTopicUriReference**](ConversationMessageEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Language** | [**ConversationMessageEventTopicUriReference**](ConversationMessageEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Priority** | **int?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;ConversationMessageEventTopicUriReference&gt;**](ConversationMessageEventTopicUriReference) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;ConversationMessageEventTopicScoredAgent&gt;**](ConversationMessageEventTopicScoredAgent) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |



_PureCloudPlatform.Client.V2 219.0.0_
