# ConversationScreenShareEventTopicConversationRoutingData

## ININ.PureCloudApi.Model.ConversationScreenShareEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**ConversationScreenShareEventTopicUriReference**](ConversationScreenShareEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Language** | [**ConversationScreenShareEventTopicUriReference**](ConversationScreenShareEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Priority** | **int?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;ConversationScreenShareEventTopicUriReference&gt;**](ConversationScreenShareEventTopicUriReference) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;ConversationScreenShareEventTopicScoredAgent&gt;**](ConversationScreenShareEventTopicScoredAgent) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |



_PureCloudPlatform.Client.V2 219.0.0_
