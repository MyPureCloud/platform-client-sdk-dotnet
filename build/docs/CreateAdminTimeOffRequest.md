# CreateAdminTimeOffRequest

## ININ.PureCloudApi.Model.CreateAdminTimeOffRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Status** | **string** | The status of this time off request | |
| **Users** | [**List&lt;UserReference&gt;**](UserReference) | A set of IDs for users to associate with this time off request | |
| **ActivityCodeId** | **string** | The ID of the activity code associated with this time off request. Activity code must be of the TimeOff category | |
| **Notes** | **string** | Notes about the time off request | [optional] |
| **FullDayManagementUnitDates** | **List&lt;string&gt;** | A set of dates in yyyy-MM-dd format.  Should be interpreted in the management unit&#39;s configured time zone | [optional] |
| **PartialDayStartDateTimes** | **List&lt;DateTime?&gt;** | A set of start date-times in ISO-8601 format for partial day requests | [optional] |
| **DailyDurationMinutes** | **int?** | Daily duration in minutes applied to all days of this time off request. Ignored if durationMinutes is specified. At least one of dailyDurationMinutes or durationMinutes is required | [optional] |
| **DurationMinutes** | **List&lt;int?&gt;** | Duration in minutes for each day of this time off request. Must match the size of fullDayManagementUnitDates or partialDayStartDateTimes. At least one of dailyDurationMinutes or durationMinutes is required | [optional] |
| **PayableMinutes** | **List&lt;int?&gt;** | Payable minutes for each day of this time off request, representing scheduled paid time displaced by this request. Defaults to dailyDurationMinutes if not specified | [optional] |
| **Paid** | **bool?** | Whether this is a paid time off request. Defaults to the activity code&#39;s paid value if not specified | [optional] |



_PureCloudPlatform.Client.V2 263.0.0_
