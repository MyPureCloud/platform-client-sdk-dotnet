# QueueConversationCallbackEventTopicConversationRoutingData

## ININ.PureCloudApi.Model.QueueConversationCallbackEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**QueueConversationCallbackEventTopicUriReference**](QueueConversationCallbackEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Language** | [**QueueConversationCallbackEventTopicUriReference**](QueueConversationCallbackEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Priority** | **int?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;QueueConversationCallbackEventTopicUriReference&gt;**](QueueConversationCallbackEventTopicUriReference) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;QueueConversationCallbackEventTopicScoredAgent&gt;**](QueueConversationCallbackEventTopicScoredAgent) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |



_PureCloudPlatform.Client.V2 228.0.0_
