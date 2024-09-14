# AvailableTimeOffRequest

## ININ.PureCloudApi.Model.AvailableTimeOffRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ActivityCodeId** | **string** | The ID for activity code to query available time off minutes | |
| **DateRanges** | [**List&lt;LocalDateRange&gt;**](LocalDateRange) | A list of date ranges of available time off minutes. A maximum number of date ranges is 30. The maximum total number of days in all ranges is 366. If no ranges are specified, then only the presence of the associated time off limit object will be checked. In such case, if the association exists, then the response will contain a list with of a single element filled with timeOffLimitId only. | [optional] |



_PureCloudPlatform.Client.V2 215.1.0_
