# ConversationEventTopicConversationRoutingData

## ININ.PureCloudApi.Model.ConversationEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**ConversationEventTopicUriReference**](ConversationEventTopicUriReference) |  | [optional] |
| **Language** | [**ConversationEventTopicUriReference**](ConversationEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Priority** | **long?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;ConversationEventTopicUriReference&gt;**](ConversationEventTopicUriReference) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;ConversationEventTopicScoredAgent&gt;**](ConversationEventTopicScoredAgent) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |



_PureCloudPlatform.Client.V2 233.0.0_
