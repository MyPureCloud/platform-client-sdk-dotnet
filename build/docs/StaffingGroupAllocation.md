# StaffingGroupAllocation

## ININ.PureCloudApi.Model.StaffingGroupAllocation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **StaffingGroupId** | **string** | The staffing group to which the result allocation belongs | |
| **ShrinkagePercentages** | **List&lt;double?&gt;** | The weekly projected shrinkage percentage of staffing group, in the scale of 0 - 100 | |
| **AttritionPercentages** | **List&lt;double?&gt;** | The weekly projected attrition percentage of the staffing group, in the scale of 0 - 100 | |
| **NewHiresFullTimeEquivalentCount** | **List&lt;double?&gt;** | The weekly projected full time equivalent agents of new hire agents added to the staffing group | [optional] |
| **StartingWeeklyFullTimeEquivalentCount** | **double?** | The weekly count of full time equivalent agents that can be used for the first week of the capacity plan | |
| **PlanningGroupIds** | **List&lt;string&gt;** | The IDs of the planning groups associated with this staffing group | [optional] |



_PureCloudPlatform.Client.V2 245.0.0_
