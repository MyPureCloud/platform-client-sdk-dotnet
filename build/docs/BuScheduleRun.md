---
title: BuScheduleRun
---
## ININ.PureCloudApi.Model.BuScheduleRun

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **SchedulerRunId** | **string** | The scheduler run ID.  Reference this value for support | [optional] |
| **IntradayRescheduling** | **bool?** | Whether this is an intraday rescheduling run | [optional] |
| **State** | **string** | The state of the generation run | [optional] |
| **WeekCount** | **int?** | The number of weeks spanned by the schedule | [optional] |
| **PercentComplete** | **double?** | Percent completion of the schedule run | [optional] |
| **TargetWeek** | **DateTime?** | The start date of the target week. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **Schedule** | [**BuScheduleReference**](BuScheduleReference.html) | The generated schedule.  Null unless the schedule run is complete | [optional] |
| **ScheduleDescription** | **string** | The description of the generated schedule | [optional] |
| **SchedulingStartTime** | **DateTime?** | When the schedule generation run started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **SchedulingStartedBy** | [**UserReference**](UserReference.html) | The user who started the scheduling run | [optional] |
| **SchedulingCanceledBy** | [**UserReference**](UserReference.html) | The user who canceled the scheduling run, if applicable | [optional] |
| **SchedulingCompletedTime** | **DateTime?** | When the scheduling run was completed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **MessageCount** | **int?** | The number of schedule generation messages for this schedule generation run | [optional] |
| **ReschedulingOptions** | [**ReschedulingOptionsRunResponse**](ReschedulingOptionsRunResponse.html) | Rescheduling options for this run.  Null unless intradayRescheduling is true | [optional] |
| **ReschedulingResultExpiration** | **DateTime?** | When the reschedule result will expire.  Null unless intradayRescheduling is true. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


