# CreateAgentTimeOffRequest

## ININ.PureCloudApi.Model.CreateAgentTimeOffRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ActivityCodeId** | **string** | The ID of the activity code associated with this time off request. Activity code must be of the TimeOff category | |
| **Notes** | **string** | Notes about the time off request | [optional] |
| **FullDayManagementUnitDates** | **List&lt;string&gt;** | A set of dates in yyyy-MM-dd format.  Should be interpreted in the management unit&#39;s configured time zone. | [optional] |
| **PartialDayStartDateTimes** | **List&lt;DateTime?&gt;** | A set of start date-times in ISO-8601 format for partial day requests. | [optional] |
| **DailyDurationMinutes** | **int?** | The daily duration of this time off request in minutes | |
| **DurationMinutes** | **List&lt;int?&gt;** | Daily durations for each day of this time off request in minutes | [optional] |
| **PayableMinutes** | **List&lt;int?&gt;** | Payable minutes for each day of this time off request | [optional] |



_PureCloudPlatform.Client.V2 248.0.0_
