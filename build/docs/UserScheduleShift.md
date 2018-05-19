---
title: UserScheduleShift
---
## ININ.PureCloudApi.Model.UserScheduleShift

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | ID of the schedule shift. This is only for the case of updating and deleting an existing shift | [optional] |
| **StartDate** | **DateTime?** | Start time in UTC for this shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **LengthInMinutes** | **int?** | Length of this shift in minutes | [optional] |
| **Activities** | [**List&lt;UserScheduleActivity&gt;**](UserScheduleActivity.html) | List of activities in this shift | [optional] |
| **Delete** | **bool?** | If marked true for updating this schedule shift, it will be deleted | [optional] |
| **ManuallyEdited** | **bool?** | Whether the shift was set as manually edited | [optional] |
{: class="table table-striped"}


