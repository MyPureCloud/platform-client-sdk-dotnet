---
title: AsyncWeekScheduleResponse
---
## ININ.PureCloudApi.Model.AsyncWeekScheduleResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Result** | [**WeekSchedule**](WeekSchedule.html) | Week schedule result. The value will be null if the data is sent through notification or if response is large. | [optional] |
| **DownloadUrl** | **string** | The url to fetch the result for large responses. The value is null if result contains the data | [optional] |
| **Status** | **string** | The status of the request | [optional] |
| **OperationId** | **string** | The operation id to watch for on the notification topic if status == Processing | [optional] |
{: class="table table-striped"}


