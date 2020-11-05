---
title: UpdateWorkPlanRotationRequest
---
## ININ.PureCloudApi.Model.UpdateWorkPlanRotationRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | Name of this work plan rotation | [optional] |
| **Enabled** | **bool?** | Whether the work plan rotation is enabled for scheduling | [optional] |
| **DateRange** | [**DateRangeWithOptionalEnd**](DateRangeWithOptionalEnd.html) | The date range to which this work plan rotation applies | [optional] |
| **Agents** | [**List&lt;UpdateWorkPlanRotationAgentRequest&gt;**](UpdateWorkPlanRotationAgentRequest.html) | Agents in this work plan rotation | [optional] |
| **Pattern** | [**WorkPlanPatternRequest**](WorkPlanPatternRequest.html) | Pattern with list of work plan IDs that rotate on a weekly basis | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata.html) | Version metadata for this work plan rotation | |
{: class="table table-striped"}


