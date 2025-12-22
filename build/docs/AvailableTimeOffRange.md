# AvailableTimeOffRange

## ININ.PureCloudApi.Model.AvailableTimeOffRange

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **TimeOffLimit** | [**TimeOffLimitReference**](TimeOffLimitReference) | The time off limit | [optional] |
| **StartDate** | **String** | Start date of the requested date range. The end date is determined by the size of interval list. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **Granularity** | **string** | Granularity choice for time off limit | [optional] |
| **AvailableMinutesPerInterval** | **List&lt;int?&gt;** | The list of available time off values in minutes per granularity interval | [optional] |
| **WaitlistedRequestsPerInterval** | **List&lt;int?&gt;** | The current number of waitlisted time off requests for every interval per granularity | [optional] |
| **WaitlistEnabled** | **bool?** | Whether the time off request can be waitlisted | [optional] |



_PureCloudPlatform.Client.V2 252.1.0_
