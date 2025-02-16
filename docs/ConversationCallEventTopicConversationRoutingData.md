# ConversationCallEventTopicConversationRoutingData

## ININ.PureCloudApi.Model.ConversationCallEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**ConversationCallEventTopicUriReference**](ConversationCallEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Language** | [**ConversationCallEventTopicUriReference**](ConversationCallEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Priority** | **int?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;ConversationCallEventTopicUriReference&gt;**](ConversationCallEventTopicUriReference) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;ConversationCallEventTopicScoredAgent&gt;**](ConversationCallEventTopicScoredAgent) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |



_PureCloudPlatform.Client.V2 227.0.0_
