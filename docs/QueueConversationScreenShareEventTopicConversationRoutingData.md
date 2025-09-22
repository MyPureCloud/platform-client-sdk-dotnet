# QueueConversationScreenShareEventTopicConversationRoutingData

## ININ.PureCloudApi.Model.QueueConversationScreenShareEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**QueueConversationScreenShareEventTopicUriReference**](QueueConversationScreenShareEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Language** | [**QueueConversationScreenShareEventTopicUriReference**](QueueConversationScreenShareEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Priority** | **long?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;QueueConversationScreenShareEventTopicUriReference&gt;**](QueueConversationScreenShareEventTopicUriReference) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;QueueConversationScreenShareEventTopicScoredAgent&gt;**](QueueConversationScreenShareEventTopicScoredAgent) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |



_PureCloudPlatform.Client.V2 242.0.0_
