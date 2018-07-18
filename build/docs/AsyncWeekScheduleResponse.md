---
title: AsyncWeekScheduleResponse
---
## ININ.PureCloudApi.Model.AsyncWeekScheduleResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Status** | **string** | The status of the request | [optional] |
| **Result** | [**WeekSchedule**](WeekSchedule.html) | Week schedule result. The value will be null if the data is sent through notification or if response is large. | [optional] |
| **OperationId** | **string** | The operation id to watch for on the notification topic if status == Processing | [optional] |
| **DownloadUrl** | **string** | The url to fetch the result for large responses. The value will be null if result contains the data | [optional] |
{: class="table table-striped"}


