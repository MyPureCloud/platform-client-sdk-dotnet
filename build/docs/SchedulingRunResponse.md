---
title: SchedulingRunResponse
---
## ININ.PureCloudApi.Model.SchedulingRunResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **RunId** | **string** | ID of the schedule run | [optional] |
| **State** | **string** | Status of the schedule run | [optional] |
| **PercentComplete** | **double?** | Completion percentage of the schedule run | [optional] |
| **TargetWeek** | **string** | The start date of the week for which the scheduling is done in yyyy-MM-dd format | [optional] |
| **ScheduleId** | **string** | ID of the schedule | [optional] |
| **ScheduleDescription** | **string** | Description of the schedule run | [optional] |
| **SchedulingStartTime** | **DateTime?** | Start time of the schedule run. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **SchedulingStartedBy** | [**UserReference**](UserReference.html) | User that started the schedule run | [optional] |
| **SchedulingCanceledBy** | [**UserReference**](UserReference.html) | User that canceled the schedule run | [optional] |
| **SchedulingCompletedTime** | **DateTime?** | Time at which the scheduling run was completed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
{: class="table table-striped"}


