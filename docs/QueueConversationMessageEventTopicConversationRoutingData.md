# QueueConversationMessageEventTopicConversationRoutingData

## ININ.PureCloudApi.Model.QueueConversationMessageEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**QueueConversationMessageEventTopicUriReference**](QueueConversationMessageEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Language** | [**QueueConversationMessageEventTopicUriReference**](QueueConversationMessageEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Priority** | **int?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;QueueConversationMessageEventTopicUriReference&gt;**](QueueConversationMessageEventTopicUriReference) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;QueueConversationMessageEventTopicScoredAgent&gt;**](QueueConversationMessageEventTopicScoredAgent) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |



_PureCloudPlatform.Client.V2 226.0.0_
