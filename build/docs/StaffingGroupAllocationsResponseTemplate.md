# StaffingGroupAllocationsResponseTemplate

## ININ.PureCloudApi.Model.StaffingGroupAllocationsResponseTemplate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **StaffingGroupAllocations** | [**List&lt;StaffingGroupAllocation&gt;**](StaffingGroupAllocation) | List of staffing group allocations | |
| **Months** | [**List&lt;YearMonth&gt;**](YearMonth) | The list of months covered by this capacity plan, formatted as yyyy-MM | [optional] |
| **PlanningGroupAllocations** | [**List&lt;CapacityPlanningPlanningGroupAllocation&gt;**](CapacityPlanningPlanningGroupAllocation) | The planning group allocations | [optional] |
| **CapacityPlanMetricsSummary** | [**CapacityPlanMetricsSummary**](CapacityPlanMetricsSummary) | The total summary of staffing allocation metrics for this capacity plan, for the selected granularity | [optional] |



_PureCloudPlatform.Client.V2 260.0.0_
