# CreateCapacityPlanStaffingGroupMetricChangeRequest

## ININ.PureCloudApi.Model.CreateCapacityPlanStaffingGroupMetricChangeRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **NumberOfWeeks** | **int?** | The number of weeks to which the metric change applies | |
| **WeekStartNumber** | **int?** | The start number of the week (starting from 1) to which the metric change applies, related to numberOfWeeks | |
| **Value** | **double?** | The value of the metric | |
| **Metric** | **string** | The metric which is going to be modified for the selected staffing groups | |
| **Notes** | **string** | Notes about the staffing groups metric changes | [optional] |
| **StaffingGroupIds** | **List&lt;string&gt;** | The IDs of the staffing groups affected by the metric change | |
| **Version** | **int?** | The version of the capacity plan | |



_PureCloudPlatform.Client.V2 249.0.0_
