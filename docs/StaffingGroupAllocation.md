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
| **BaseStartingFullTimeEquivalentCount** | **List&lt;double?&gt;** | The weekly calculated starting full time equivalent count | [optional] |
| **AttritionFullTimeEquivalentCount** | **List&lt;double?&gt;** | The weekly projected attrition full time equivalent count | [optional] |
| **StaffingGroupPlannedFullTimeEquivalentCount** | **List&lt;double?&gt;** | The weekly calculated staffing group full time equivalent count | [optional] |
| **EndOfMonthPlannedFullTimeEquivalentCount** | **List&lt;double?&gt;** | The end of month planned full time equivalent count of this staffing group | [optional] |
| **ShrinkageFullTimeEquivalentCount** | **List&lt;double?&gt;** | The weekly projected shrinkage full time equivalent count of this staffing group | [optional] |
| **NetFullTimeEquivalentCount** | **List&lt;double?&gt;** | The weekly net full time equivalent count of this staffing group | [optional] |
| **ExtraTimeUnderTimeFullTimeEquivalentCount** | **List&lt;double?&gt;** | The weekly projected extra or under full time equivalent to the staffing group | [optional] |
| **TransfersFullTimeEquivalentCount** | **List&lt;double?&gt;** | The weekly projected full time equivalent transfers of agents into or out of this staffing group | [optional] |



_PureCloudPlatform.Client.V2 261.0.0_
