# QueryTimeOffLimitValuesRequest

## ININ.PureCloudApi.Model.QueryTimeOffLimitValuesRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **TimeOffLimitId** | **string** | Deprecated. The time off limit object id to retrieve values for. Required if activityCodeId is not specified | [optional] |
| **ActivityCodeId** | **string** | Deprecated. The ID of the activity code by which to filter the affected limit objects. Required if timeOffLimitId is not specified | [optional] |
| **DateRanges** | [**List&lt;LocalDateRange&gt;**](LocalDateRange) | Deprecated. The list of the date ranges to return time off limit, allocated and waitlisted minutes. The valid number of date ranges is between 1 and 30. Maximum total number of days in all ranges in 366. | |



_PureCloudPlatform.Client.V2 270.0.0_
