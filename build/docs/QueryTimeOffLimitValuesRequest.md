# QueryTimeOffLimitValuesRequest

## ININ.PureCloudApi.Model.QueryTimeOffLimitValuesRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **TimeOffLimitId** | **string** | The time off limit object id to retrieve values for. Required if activityCodeId is not specified | [optional] |
| **ActivityCodeId** | **string** | The activity code id to filter the affected limit objects by. Required if timeOffLimitId is not specified | [optional] |
| **DateRanges** | [**List&lt;LocalDateRange&gt;**](LocalDateRange) | The list of the date ranges to return time off limit, allocated and waitlisted minutes. The valid number of date ranges is between 1 and 30. Maximum total number of days in all ranges in 366. | |



_PureCloudPlatform.Client.V2 223.0.0_
