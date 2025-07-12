# DailyPossibleShift

## ININ.PureCloudApi.Model.DailyPossibleShift

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **DayOfWeek** | **string** | Day of the shift | [optional] |
| **EarliestShiftStartMinutesFromMidnight** | **int?** | Minutes of the earliest shift start from midnight. Note that midnight is 12:00 am in the time zone specified in the timeZone field (in the top level of the response) | [optional] |
| **Required** | **bool?** | Whether this is a required shift | [optional] |
| **MinimumPaidTimeMinutes** | **int?** | Minimum paid time in minutes of this daily shift | [optional] |
| **MaximumPaidTimeMinutes** | **int?** | Maximum paid time in minutes of this daily shift | [optional] |
| **IntervalScheduleProbabilities** | **List&lt;int?&gt;** | The percentage of being scheduled in each interval between the earliest shift start and latest shift end. Range of the values: [0, 100]. | [optional] |



_PureCloudPlatform.Client.V2 238.0.0_
