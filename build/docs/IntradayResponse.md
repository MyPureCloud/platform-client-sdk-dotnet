---
title: IntradayResponse
---
## ININ.PureCloudApi.Model.IntradayResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **StartDate** | **DateTime?** | The start of the date range for which this data applies.  This is also the start reference point for the intervals represented in the various arrays. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **EndDate** | **DateTime?** | The end of the date range for which this data applies. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **IntervalLengthMinutes** | **int?** | The aggregation period in minutes, which determines the interval duration of the returned data | [optional] |
| **NumberOfIntervals** | **int?** | The total number of time intervals represented by this data | [optional] |
| **Metrics** | [**List&lt;IntradayMetric&gt;**](IntradayMetric.html) | The metrics to which this data corresponds | [optional] |
| **NoDataReason** | **string** | If not null, the reason there was no data for the request | [optional] |
| **QueueIds** | **List&lt;string&gt;** | The IDs of the queues this data corresponds to | [optional] |
| **IntradayDataGroupings** | [**List&lt;IntradayDataGroup&gt;**](IntradayDataGroup.html) | Intraday data grouped by a single media type and set of queue IDs | [optional] |
{: class="table table-striped"}


