# CapacityPlanningPlanningGroupAllocation

## ININ.PureCloudApi.Model.CapacityPlanningPlanningGroupAllocation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PlanningGroupId** | **string** | The planning group ID to which the capacity planning allocations apply | |
| **RequiredStaffFullTimeEquivalentCount** | **List&lt;double?&gt;** | The weekly required staff to this planning group | |
| **StaffingGroupFullTimeEquivalentContributions** | [**List&lt;StaffingGroupFullTimeEquivalentContribution&gt;**](StaffingGroupFullTimeEquivalentContribution) | The weekly planned full time equivalent contributions from associated staffing groups | |
| **TotalPlannedFullTimeEquivalentCount** | **List&lt;double?&gt;** | The total weekly full time equivalent planned for this planning group, based on the associated staffing groups | |
| **OverUnderFullTimeEquivalentCount** | **List&lt;double?&gt;** | The weekly difference between the total planned full time equivalent and the required staff | |



_PureCloudPlatform.Client.V2 252.1.0_
