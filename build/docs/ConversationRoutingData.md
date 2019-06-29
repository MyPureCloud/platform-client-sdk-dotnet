---
title: ConversationRoutingData
---
## ININ.PureCloudApi.Model.ConversationRoutingData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Queue** | [**Queue**](Queue.html) | The queue to use for routing decisions | [optional] |
| **Language** | [**Language**](Language.html) | The language to use for routing decisions | [optional] |
| **Priority** | **int?** | The priority of the conversation to use for routing decisions | [optional] |
| **Skills** | [**List&lt;Skill&gt;**](Skill.html) | The skills to use for routing decisions | [optional] |
| **ScoredAgents** | [**List&lt;ScoredAgent&gt;**](ScoredAgent.html) | A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents | [optional] |
{: class="table table-striped"}


