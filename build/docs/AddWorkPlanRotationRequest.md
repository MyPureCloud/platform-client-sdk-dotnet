---
title: AddWorkPlanRotationRequest
---
## ININ.PureCloudApi.Model.AddWorkPlanRotationRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | Name of this work plan rotation | |
| **DateRange** | [**DateRangeWithOptionalEnd**](DateRangeWithOptionalEnd.html) | The date range to which this work plan rotation applies | |
| **Agents** | [**List&lt;AddWorkPlanRotationAgentRequest&gt;**](AddWorkPlanRotationAgentRequest.html) | Agents in this work plan rotation | [optional] |
| **Pattern** | [**WorkPlanPatternRequest**](WorkPlanPatternRequest.html) | Pattern with list of work plan IDs that rotate on a weekly basis | |
{: class="table table-striped"}


