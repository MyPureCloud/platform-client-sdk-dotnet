# BuIntradayResponse

## ININ.PureCloudApi.Model.BuIntradayResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **StartDate** | **DateTime?** | The start of the date range for which this data applies.  This is also the start reference point for the intervals represented in the various arrays. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **EndDate** | **DateTime?** | The end of the date range for which this data applies. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **IntervalLengthMinutes** | **int?** | The aggregation period in minutes, which determines the interval duration of the returned data | [optional] |
| **NoDataReason** | **string** | If not null, the reason there was no data for the request | [optional] |
| **Categories** | **List&lt;string&gt;** | The categories to which this data corresponds | [optional] |
| **ShortTermForecast** | [**BuShortTermForecastReference**](BuShortTermForecastReference) | Short term forecast reference | [optional] |
| **Schedule** | [**BuScheduleReference**](BuScheduleReference) | Schedule reference | [optional] |
| **IntradayDataGroupings** | [**List&lt;BuIntradayDataGroup&gt;**](BuIntradayDataGroup) | Intraday data grouped by a single media type and set of planning group IDs | [optional] |



_PureCloudPlatform.Client.V2 231.1.0_
