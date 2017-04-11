---
title: IntradayQueryDataCommand
---
## ININ.PureCloudApi.Model.IntradayQueryDataCommand

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **StartDate** | **DateTime?** | Start date of the requested date range in ISO-8601 format | |
| **EndDate** | **DateTime?** | End date of the requested date range in ISO-8601 format.  Must be within the same 7 day schedule week as defined by the management unit&#39;s start day of week | |
| **Metrics** | [**List&lt;IntradayMetric&gt;**](IntradayMetric.html) | The metrics to validate | |
| **QueueIds** | **List&lt;string&gt;** | The queue IDs for which to fetch data.  Omitting or passing an empty list will return all available queues | [optional] |
| **IntervalLengthMinutes** | **int?** | The period/interval for which to aggregate the data.  Optional, defaults to 15 | [optional] |
{: class="table table-striped"}


