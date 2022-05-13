---
title: WorkPlanRotationResponse
---
## ININ.PureCloudApi.Model.WorkPlanRotationResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Enabled** | **bool?** | Whether the work plan rotation is enabled for scheduling | [optional] |
| **DateRange** | [**DateRangeWithOptionalEnd**](DateRangeWithOptionalEnd.html) | The date range to which this work plan rotation applies | [optional] |
| **Pattern** | [**WorkPlanPatternResponse**](WorkPlanPatternResponse.html) | Pattern with ordered list of work plans that rotate on a weekly basis | [optional] |
| **AgentCount** | **int?** | Number of agents in this work plan rotation | [optional] |
| **Agents** | [**List&lt;WorkPlanRotationAgentResponse&gt;**](WorkPlanRotationAgentResponse.html) | Agents in this work plan rotation. Populate with expand&#x3D;agents for GET WorkPlanRotationsList (defaults to empty list) | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata.html) | Version metadata for this work plan rotation | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


