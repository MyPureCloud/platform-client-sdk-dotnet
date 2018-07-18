---
title: WorkPlanShift
---
## ININ.PureCloudApi.Model.WorkPlanShift

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | Name of the shift | |
| **Days** | [**SetWrapperDayOfWeek**](SetWrapperDayOfWeek.html) | Days of the week applicable for this shift | [optional] |
| **FlexibleStartTime** | **bool?** | Whether the start time of the shift is flexible | [optional] |
| **ExactStartTimeMinutesFromMidnight** | **int?** | Exact start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime == false | [optional] |
| **EarliestStartTimeMinutesFromMidnight** | **int?** | Earliest start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime == true | [optional] |
| **LatestStartTimeMinutesFromMidnight** | **int?** | Latest start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime == true | [optional] |
| **ConstrainStopTime** | **bool?** | Whether the latest stop time constraint for the shift is enabled | [optional] |
| **LatestStopTimeMinutesFromMidnight** | **int?** | Latest stop time of the shift defined as offset minutes from midnight. Used if constrainStopTime == true | [optional] |
| **StartIncrementMinutes** | **int?** | Increment in offset minutes that would contribute to different possible start times for the shift. Used if flexibleStartTime == true | [optional] |
| **FlexiblePaidTime** | **bool?** | Whether the paid time setting for the shift is flexible | [optional] |
| **ExactPaidTimeMinutes** | **int?** | Exact paid time in minutes configured for the shift. Used if flexiblePaidTime == false | [optional] |
| **MinimumPaidTimeMinutes** | **int?** | Minimum paid time in minutes configured for the shift. Used if flexiblePaidTime == true | [optional] |
| **MaximumPaidTimeMinutes** | **int?** | Maximum paid time in minutes configured for the shift. Used if flexiblePaidTime == true | [optional] |
| **ConstrainContiguousWorkTime** | **bool?** | Whether the contiguous time constraint for the shift is enabled | [optional] |
| **MinimumContiguousWorkTimeMinutes** | **int?** | Minimum contiguous time in minutes configured for the shift. Used if constrainContiguousWorkTime == true | [optional] |
| **MaximumContiguousWorkTimeMinutes** | **int?** | Maximum contiguous time in minutes configured for the shift. Used if constrainContiguousWorkTime == true | [optional] |
| **Activities** | [**List&lt;WorkPlanActivity&gt;**](WorkPlanActivity.html) | Activities configured for this shift | [optional] |
| **Id** | **string** | ID of the shift. This is required only for the case of updating an existing shift | [optional] |
| **Delete** | **bool?** | If marked true for updating an existing shift, the shift will be permanently deleted | [optional] |
{: class="table table-striped"}


