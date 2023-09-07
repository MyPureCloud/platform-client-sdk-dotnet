---
title: WfmAgent
---
## ININ.PureCloudApi.Model.WfmAgent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **User** | [**UserReference**](UserReference.html) | The user associated with this data | [optional] |
| **WorkPlan** | [**WorkPlanReference**](WorkPlanReference.html) | The work plan associated with this agent, if applicable | [optional] |
| **WorkPlanRotation** | [**WorkPlanRotationReference**](WorkPlanRotationReference.html) | The work plan rotation associated with this agent, if applicable | [optional] |
| **AcceptDirectShiftTrades** | **bool?** | Whether the agent accepts direct shift trade requests | [optional] |
| **Queues** | [**List&lt;QueueReference&gt;**](QueueReference.html) | List of queues to which this agent is capable of handling | [optional] |
| **Languages** | [**List&lt;LanguageReference&gt;**](LanguageReference.html) | The list of languages this agent is capable of handling | [optional] |
| **Skills** | [**List&lt;RoutingSkillReference&gt;**](RoutingSkillReference.html) | The list of skills this agent is capable of handling | [optional] |
| **Schedulable** | **bool?** | Whether the agent can be included in schedule generation | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata.html) | Metadata for this agent | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


