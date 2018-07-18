---
title: WfmAgent
---
## ININ.PureCloudApi.Model.WfmAgent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **User** | [**UserReference**](UserReference.html) | The user associated with this data | [optional] |
| **Queues** | [**List&lt;QueueReference&gt;**](QueueReference.html) | List of queues to which the agent belongs and which are defined in the service goal groups in this management unit | [optional] |
| **Languages** | [**List&lt;LanguageReference&gt;**](LanguageReference.html) | The list of languages | [optional] |
| **Skills** | [**List&lt;RoutingSkillReference&gt;**](RoutingSkillReference.html) | The list of skills | [optional] |
| **WorkPlan** | [**WorkPlanReference**](WorkPlanReference.html) | The work plan associated with this agent | [optional] |
| **Schedulable** | **bool?** | Whether the agent has the permission to be included in schedule generation | [optional] |
| **TimeZone** | [**WfmTimeZone**](WfmTimeZone.html) | The time zone for this agent. Defaults to the time zone of the management unit to which the agent belongs | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata.html) | Metadata for this agent | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


