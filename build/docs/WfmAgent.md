# WfmAgent

## ININ.PureCloudApi.Model.WfmAgent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **User** | [**UserReference**](UserReference) | The user associated with this data | [optional] |
| **WorkPlan** | [**WorkPlanReference**](WorkPlanReference) | The work plan associated with this agent, if applicable | [optional] |
| **WorkPlanRotation** | [**WorkPlanRotationReference**](WorkPlanRotationReference) | The work plan rotation associated with this agent, if applicable | [optional] |
| **AcceptDirectShiftTrades** | **bool?** | Whether the agent accepts direct shift trade requests | [optional] |
| **WorkPlanOverrides** | [**List&lt;WorkPlanOverride&gt;**](WorkPlanOverride) | The work plan overrides associated with this agent. Populate with expand&#x3D;workPlanOverrides | [optional] |
| **Queues** | [**List&lt;QueueReference&gt;**](QueueReference) | List of queues to which this agent is capable of handling | [optional] |
| **Languages** | [**List&lt;LanguageReference&gt;**](LanguageReference) | The list of languages this agent is capable of handling | [optional] |
| **Skills** | [**List&lt;RoutingSkillReference&gt;**](RoutingSkillReference) | The list of skills this agent is capable of handling | [optional] |
| **Schedulable** | **bool?** | Whether the agent can be included in schedule generation | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Metadata for this agent | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 223.0.0_
