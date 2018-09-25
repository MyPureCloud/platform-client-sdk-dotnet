---
title: SchedulingRunResponse
---
## ININ.PureCloudApi.Model.SchedulingRunResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **RunId** | **string** | ID of the schedule run | [optional] |
| **SchedulerRunId** | **string** | The runId from scheduler service.  Useful for debugging schedule errors | [optional] |
| **IntradayRescheduling** | **bool?** | Whether this is the result of a rescheduling request | [optional] |
| **State** | **string** | Status of the schedule run | [optional] |
| **PercentComplete** | **double?** | Completion percentage of the schedule run | [optional] |
| **TargetWeek** | **string** | The start date of the week for which the scheduling is done in yyyy-MM-dd format | [optional] |
| **ScheduleId** | **string** | ID of the schedule. Does not apply to reschedule, see reschedulingOptions.existingScheduleId | [optional] |
| **ScheduleDescription** | **string** | Description of the schedule | [optional] |
| **SchedulingStartTime** | **DateTime?** | Start time of the schedule run. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **SchedulingStartedBy** | [**UserReference**](UserReference.html) | User that started the schedule run | [optional] |
| **SchedulingCanceledBy** | [**UserReference**](UserReference.html) | User that canceled the schedule run | [optional] |
| **SchedulingCompletedTime** | **DateTime?** | Time at which the scheduling run was completed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ReschedulingOptions** | [**ReschedulingOptionsResponse**](ReschedulingOptionsResponse.html) | The selected options for the reschedule request. Will always be null if intradayRescheduling is false | [optional] |
| **ReschedulingResultExpiration** | **DateTime?** | When the rescheduling result data will expire. Results are kept temporarily as they should be applied as soon as possible after the run finishes.  Will always be null if intradayRescheduling is false. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Applied** | **bool?** | Whether the rescheduling run has been marked applied | [optional] |
| **UnscheduledAgents** | [**List&lt;UnscheduledAgentWarning&gt;**](UnscheduledAgentWarning.html) | Agents that were not scheduled in the rescheduling operation. Will always be null if intradayRescheduling is false | [optional] |
{: class="table table-striped"}


