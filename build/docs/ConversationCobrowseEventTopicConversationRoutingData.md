# ConversationCobrowseEventTopicConversationRoutingData

## ININ.PureCloudApi.Model.ConversationCobrowseEventTopicConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**ConversationCobrowseEventTopicUriReference**](ConversationCobrowseEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Language** | [**ConversationCobrowseEventTopicUriReference**](ConversationCobrowseEventTopicUriReference) | A UriReference for a resource | [optional] |
| **Priority** | **long?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;ConversationCobrowseEventTopicUriReference&gt;**](ConversationCobrowseEventTopicUriReference) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;ConversationCobrowseEventTopicScoredAgent&gt;**](ConversationCobrowseEventTopicScoredAgent) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |



_PureCloudPlatform.Client.V2 256.0.0_
