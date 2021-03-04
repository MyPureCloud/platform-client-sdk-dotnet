---
title: WorkPlanActivity
---
## ININ.PureCloudApi.Model.WorkPlanActivity

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ActivityCodeId** | **string** | ID of the activity code associated with this activity | [optional] |
| **Description** | **string** | Description of the activity | [optional] |
| **LengthMinutes** | **int?** | Length of the activity in minutes | [optional] |
| **StartTimeIsRelativeToShiftStart** | **bool?** | Whether the start time of the activity is relative to the start time of the shift it belongs to | [optional] |
| **FlexibleStartTime** | **bool?** | Whether the start time of the activity is flexible | [optional] |
| **EarliestStartTimeMinutes** | **int?** | Earliest activity start in offset minutes relative to shift start time if startTimeIsRelativeToShiftStart == true else its based on midnight. Used if flexibleStartTime == true | [optional] |
| **LatestStartTimeMinutes** | **int?** | Latest activity start in offset minutes relative to shift start time if startTimeIsRelativeToShiftStart == true else its based on midnight. Used if flexibleStartTime == true | [optional] |
| **ExactStartTimeMinutes** | **int?** | Exact activity start in offset minutes relative to shift start time if startTimeIsRelativeToShiftStart == true else its based on midnight. Used if flexibleStartTime == false | [optional] |
| **StartTimeIncrementMinutes** | **int?** | Increment in offset minutes that would contribute to different possible start times for the activity | [optional] |
| **CountsAsPaidTime** | **bool?** | Whether the activity is paid | [optional] |
| **CountsAsContiguousWorkTime** | **bool?** | Whether the activity duration is counted towards contiguous work time | [optional] |
| **MinimumLengthFromShiftStartMinutes** | **int?** | The minimum duration between shift start and shift item (e.g., break or meal) start in minutes | [optional] |
| **MinimumLengthFromShiftEndMinutes** | **int?** | The minimum duration between shift item (e.g., break or meal) end and shift end in minutes | [optional] |
| **Id** | **string** | ID of the activity. This is required only for the case of updating an existing activity | [optional] |
| **Delete** | **bool?** | If marked true for updating an existing activity, the activity will be permanently deleted | [optional] |
{: class="table table-striped"}


