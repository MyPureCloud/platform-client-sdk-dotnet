# ScheduleBidScheduledShift

## ININ.PureCloudApi.Model.ScheduleBidScheduledShift

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **WorkPlanShiftId** | **string** | The ID of the work plan shift that was used in schedule generation | [optional] |
| **WorkPlanId** | **string** | The ID of the work plan from which the shift comes | [optional] |
| **StartDate** | **DateTime?** | The start date of the scheduled shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **LengthMinutes** | **int?** | The length of the shift in minutes | |
| **Activities** | [**List&lt;ScheduleBidScheduledActivity&gt;**](ScheduleBidScheduledActivity) | The activities associated with this shift | |



_PureCloudPlatform.Client.V2 268.0.0_
