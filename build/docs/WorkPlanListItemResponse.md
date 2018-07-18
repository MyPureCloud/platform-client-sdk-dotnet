---
title: WorkPlanListItemResponse
---
## ININ.PureCloudApi.Model.WorkPlanListItemResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **AgentCount** | **int?** | Number of agents in this work plan | [optional] |
| **WeeklyMinimumPaidMinutes** | **int?** | Minimum weekly paid time in minutes defined in this work plan | [optional] |
| **WeeklyMaximumPaidMinutes** | **int?** | Maximum weekly paid time in minutes defined in this work plan | [optional] |
| **MaximumDays** | **int?** | Maximum number of days in a week that can be scheduled using this work plan | [optional] |
| **Enabled** | **bool?** | Whether the work plan is enabled for scheduling | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata.html) | Version metadata for this work plan | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


