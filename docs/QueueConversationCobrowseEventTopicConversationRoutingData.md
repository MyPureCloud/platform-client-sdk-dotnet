# QueueConversationCobrowseEventTopicConversationRoutingData

## ININ.PureCloudApi.Model.QueueConversationCobrowseEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**QueueConversationCobrowseEventTopicUriReference**](QueueConversationCobrowseEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Language** | [**QueueConversationCobrowseEventTopicUriReference**](QueueConversationCobrowseEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Priority** | **long?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;QueueConversationCobrowseEventTopicUriReference&gt;**](QueueConversationCobrowseEventTopicUriReference) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;QueueConversationCobrowseEventTopicScoredAgent&gt;**](QueueConversationCobrowseEventTopicScoredAgent) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |



_PureCloudPlatform.Client.V2 252.1.0_
