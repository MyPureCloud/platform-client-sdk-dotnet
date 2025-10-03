# ConversationVideoEventTopicConversationRoutingData

## ININ.PureCloudApi.Model.ConversationVideoEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**ConversationVideoEventTopicUriReference**](ConversationVideoEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Language** | [**ConversationVideoEventTopicUriReference**](ConversationVideoEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Priority** | **long?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;ConversationVideoEventTopicUriReference&gt;**](ConversationVideoEventTopicUriReference) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;ConversationVideoEventTopicScoredAgent&gt;**](ConversationVideoEventTopicScoredAgent) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |



_PureCloudPlatform.Client.V2 245.0.0_
