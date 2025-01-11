# ConversationEmailEventTopicConversationRoutingData

## ININ.PureCloudApi.Model.ConversationEmailEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**ConversationEmailEventTopicUriReference**](ConversationEmailEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Language** | [**ConversationEmailEventTopicUriReference**](ConversationEmailEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Priority** | **int?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;ConversationEmailEventTopicUriReference&gt;**](ConversationEmailEventTopicUriReference) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;ConversationEmailEventTopicScoredAgent&gt;**](ConversationEmailEventTopicScoredAgent) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |



_PureCloudPlatform.Client.V2 224.1.0_
