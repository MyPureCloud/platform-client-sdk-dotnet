---
title: WorkforceManagementApi
---
## PureCloudPlatform.Client.V2.Api.WorkforceManagementApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteWorkforcemanagementManagementunit**](WorkforceManagementApi.html#deleteworkforcemanagementmanagementunit) | **DELETE** /api/v2/workforcemanagement/managementunits/{muId} | Delete management unit |
| [**DeleteWorkforcemanagementManagementunitActivitycode**](WorkforceManagementApi.html#deleteworkforcemanagementmanagementunitactivitycode) | **DELETE** /api/v2/workforcemanagement/managementunits/{muId}/activitycodes/{acId} | Deletes an activity code |
| [**DeleteWorkforcemanagementManagementunitSchedulingRun**](WorkforceManagementApi.html#deleteworkforcemanagementmanagementunitschedulingrun) | **DELETE** /api/v2/workforcemanagement/managementunits/{managementUnitId}/scheduling/runs/{runId} | Cancel a schedule run |
| [**DeleteWorkforcemanagementManagementunitServicegoalgroup**](WorkforceManagementApi.html#deleteworkforcemanagementmanagementunitservicegoalgroup) | **DELETE** /api/v2/workforcemanagement/managementunits/{managementUnitId}/servicegoalgroups/{serviceGoalGroupId} | Delete a service goal group |
| [**DeleteWorkforcemanagementManagementunitWeekSchedule**](WorkforceManagementApi.html#deleteworkforcemanagementmanagementunitweekschedule) | **DELETE** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/{scheduleId} | Delete a schedule |
| [**DeleteWorkforcemanagementManagementunitWeekShorttermforecast**](WorkforceManagementApi.html#deleteworkforcemanagementmanagementunitweekshorttermforecast) | **DELETE** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId} | Delete a short term forecast |
| [**DeleteWorkforcemanagementManagementunitWorkplan**](WorkforceManagementApi.html#deleteworkforcemanagementmanagementunitworkplan) | **DELETE** /api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId} | Delete a work plan |
| [**GetWorkforcemanagementAdherence**](WorkforceManagementApi.html#getworkforcemanagementadherence) | **GET** /api/v2/workforcemanagement/adherence | Get a list of UserScheduleAdherence records for the requested users |
| [**GetWorkforcemanagementAdhocmodelingjob**](WorkforceManagementApi.html#getworkforcemanagementadhocmodelingjob) | **GET** /api/v2/workforcemanagement/adhocmodelingjobs/{jobId} | Get status of the modeling job |
| [**GetWorkforcemanagementManagementunit**](WorkforceManagementApi.html#getworkforcemanagementmanagementunit) | **GET** /api/v2/workforcemanagement/managementunits/{muId} | Get management unit |
| [**GetWorkforcemanagementManagementunitActivitycode**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitactivitycode) | **GET** /api/v2/workforcemanagement/managementunits/{muId}/activitycodes/{acId} | Get an activity code |
| [**GetWorkforcemanagementManagementunitActivitycodes**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitactivitycodes) | **GET** /api/v2/workforcemanagement/managementunits/{muId}/activitycodes | Get activity codes |
| [**GetWorkforcemanagementManagementunitAgent**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitagent) | **GET** /api/v2/workforcemanagement/managementunits/{managementUnitId}/agents/{agentId} | Get data for agent in the management unit |
| [**GetWorkforcemanagementManagementunitIntradayQueues**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitintradayqueues) | **GET** /api/v2/workforcemanagement/managementunits/{muId}/intraday/queues | Get intraday queues for the given date |
| [**GetWorkforcemanagementManagementunitSchedulingRun**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitschedulingrun) | **GET** /api/v2/workforcemanagement/managementunits/{managementUnitId}/scheduling/runs/{runId} | Gets the status for a specific scheduling run |
| [**GetWorkforcemanagementManagementunitSchedulingRunResult**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitschedulingrunresult) | **GET** /api/v2/workforcemanagement/managementunits/{managementUnitId}/scheduling/runs/{runId}/result | Gets the result of a specific scheduling run |
| [**GetWorkforcemanagementManagementunitSchedulingRuns**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitschedulingruns) | **GET** /api/v2/workforcemanagement/managementunits/{managementUnitId}/scheduling/runs | Get the status of all the ongoing schedule runs |
| [**GetWorkforcemanagementManagementunitServicegoalgroup**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitservicegoalgroup) | **GET** /api/v2/workforcemanagement/managementunits/{managementUnitId}/servicegoalgroups/{serviceGoalGroupId} | Get a service goal group |
| [**GetWorkforcemanagementManagementunitServicegoalgroups**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitservicegoalgroups) | **GET** /api/v2/workforcemanagement/managementunits/{managementUnitId}/servicegoalgroups | Get service goal groups |
| [**GetWorkforcemanagementManagementunitSettings**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitsettings) | **GET** /api/v2/workforcemanagement/managementunits/{muId}/settings | Get the settings for the requested management unit. Deprecated, use the GET management unit route instead |
| [**GetWorkforcemanagementManagementunitShifttradesMatched**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitshifttradesmatched) | **GET** /api/v2/workforcemanagement/managementunits/{muId}/shifttrades/matched | Gets a summary of all shift trades in the matched state |
| [**GetWorkforcemanagementManagementunitShifttradesUsers**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitshifttradesusers) | **GET** /api/v2/workforcemanagement/managementunits/{muId}/shifttrades/users | Gets list of users available for whom you can send direct shift trade requests |
| [**GetWorkforcemanagementManagementunitUserTimeoffrequest**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitusertimeoffrequest) | **GET** /api/v2/workforcemanagement/managementunits/{muId}/users/{userId}/timeoffrequests/{timeOffRequestId} | Get a time off request |
| [**GetWorkforcemanagementManagementunitUserTimeoffrequests**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitusertimeoffrequests) | **GET** /api/v2/workforcemanagement/managementunits/{muId}/users/{userId}/timeoffrequests | Get a list of time off requests for a given user |
| [**GetWorkforcemanagementManagementunitUsers**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitusers) | **GET** /api/v2/workforcemanagement/managementunits/{muId}/users | Get users in the management unit |
| [**GetWorkforcemanagementManagementunitWeekSchedule**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitweekschedule) | **GET** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/{scheduleId} | Get a week schedule |
| [**GetWorkforcemanagementManagementunitWeekScheduleGenerationresults**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitweekschedulegenerationresults) | **GET** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/{scheduleId}/generationresults | Get week schedule generation results |
| [**GetWorkforcemanagementManagementunitWeekSchedules**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitweekschedules) | **GET** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules | Get the list of schedules in a week in management unit |
| [**GetWorkforcemanagementManagementunitWeekShorttermforecastFinal**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitweekshorttermforecastfinal) | **GET** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}/final | Get the final result of a short term forecast calculation with modifications applied |
| [**GetWorkforcemanagementManagementunitWeekShorttermforecasts**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitweekshorttermforecasts) | **GET** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shorttermforecasts | Get short term forecasts |
| [**GetWorkforcemanagementManagementunitWorkplan**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitworkplan) | **GET** /api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId} | Get a work plan |
| [**GetWorkforcemanagementManagementunitWorkplans**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitworkplans) | **GET** /api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans | Get work plans |
| [**GetWorkforcemanagementManagementunits**](WorkforceManagementApi.html#getworkforcemanagementmanagementunits) | **GET** /api/v2/workforcemanagement/managementunits | Get management units |
| [**GetWorkforcemanagementManagementunitsDivisionviews**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitsdivisionviews) | **GET** /api/v2/workforcemanagement/managementunits/divisionviews | Get management units across divisions |
| [**GetWorkforcemanagementNotifications**](WorkforceManagementApi.html#getworkforcemanagementnotifications) | **GET** /api/v2/workforcemanagement/notifications | Get a list of notifications for the current user |
| [**GetWorkforcemanagementSchedulingjob**](WorkforceManagementApi.html#getworkforcemanagementschedulingjob) | **GET** /api/v2/workforcemanagement/schedulingjobs/{jobId} | Get status of the scheduling job |
| [**GetWorkforcemanagementShifttrades**](WorkforceManagementApi.html#getworkforcemanagementshifttrades) | **GET** /api/v2/workforcemanagement/shifttrades | Gets all of my shift trades |
| [**GetWorkforcemanagementTimeoffrequest**](WorkforceManagementApi.html#getworkforcemanagementtimeoffrequest) | **GET** /api/v2/workforcemanagement/timeoffrequests/{timeOffRequestId} | Get a time off request for the current user |
| [**GetWorkforcemanagementTimeoffrequests**](WorkforceManagementApi.html#getworkforcemanagementtimeoffrequests) | **GET** /api/v2/workforcemanagement/timeoffrequests | Get a list of time off requests for the current user |
| [**PatchWorkforcemanagementManagementunit**](WorkforceManagementApi.html#patchworkforcemanagementmanagementunit) | **PATCH** /api/v2/workforcemanagement/managementunits/{muId} | Update the requested management unit |
| [**PatchWorkforcemanagementManagementunitActivitycode**](WorkforceManagementApi.html#patchworkforcemanagementmanagementunitactivitycode) | **PATCH** /api/v2/workforcemanagement/managementunits/{muId}/activitycodes/{acId} | Update an activity code |
| [**PatchWorkforcemanagementManagementunitSchedulingRun**](WorkforceManagementApi.html#patchworkforcemanagementmanagementunitschedulingrun) | **PATCH** /api/v2/workforcemanagement/managementunits/{managementUnitId}/scheduling/runs/{runId} | Marks a specific scheduling run as applied, allowing a new rescheduling run to be started |
| [**PatchWorkforcemanagementManagementunitServicegoalgroup**](WorkforceManagementApi.html#patchworkforcemanagementmanagementunitservicegoalgroup) | **PATCH** /api/v2/workforcemanagement/managementunits/{managementUnitId}/servicegoalgroups/{serviceGoalGroupId} | Update a service goal group |
| [**PatchWorkforcemanagementManagementunitSettings**](WorkforceManagementApi.html#patchworkforcemanagementmanagementunitsettings) | **PATCH** /api/v2/workforcemanagement/managementunits/{muId}/settings | Update the settings for the requested management unit |
| [**PatchWorkforcemanagementManagementunitUserTimeoffrequest**](WorkforceManagementApi.html#patchworkforcemanagementmanagementunitusertimeoffrequest) | **PATCH** /api/v2/workforcemanagement/managementunits/{muId}/users/{userId}/timeoffrequests/{timeOffRequestId} | Update a time off request |
| [**PatchWorkforcemanagementManagementunitWeekSchedule**](WorkforceManagementApi.html#patchworkforcemanagementmanagementunitweekschedule) | **PATCH** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/{scheduleId} | Update a week schedule |
| [**PatchWorkforcemanagementManagementunitWorkplan**](WorkforceManagementApi.html#patchworkforcemanagementmanagementunitworkplan) | **PATCH** /api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId} | Update a work plan |
| [**PatchWorkforcemanagementTimeoffrequest**](WorkforceManagementApi.html#patchworkforcemanagementtimeoffrequest) | **PATCH** /api/v2/workforcemanagement/timeoffrequests/{timeOffRequestId} | Update a time off request for the current user |
| [**PostWorkforcemanagementAdherenceHistorical**](WorkforceManagementApi.html#postworkforcemanagementadherencehistorical) | **POST** /api/v2/workforcemanagement/adherence/historical | Request a historical adherence report for users across management units |
| [**PostWorkforcemanagementManagementunitActivitycodes**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitactivitycodes) | **POST** /api/v2/workforcemanagement/managementunits/{muId}/activitycodes | Create a new activity code |
| [**PostWorkforcemanagementManagementunitAgentschedulesSearch**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitagentschedulessearch) | **POST** /api/v2/workforcemanagement/managementunits/{muId}/agentschedules/search | Query published schedules for given given time range for set of users |
| [**PostWorkforcemanagementManagementunitHistoricaladherencequery**](WorkforceManagementApi.html#postworkforcemanagementmanagementunithistoricaladherencequery) | **POST** /api/v2/workforcemanagement/managementunits/{muId}/historicaladherencequery | Request a historical adherence report |
| [**PostWorkforcemanagementManagementunitIntraday**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitintraday) | **POST** /api/v2/workforcemanagement/managementunits/{muId}/intraday | Get intraday data for the given date for the requested queueIds |
| [**PostWorkforcemanagementManagementunitMove**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitmove) | **POST** /api/v2/workforcemanagement/managementunits/{muId}/move | Move the requested management unit to a new business unit |
| [**PostWorkforcemanagementManagementunitSchedulesSearch**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitschedulessearch) | **POST** /api/v2/workforcemanagement/managementunits/{muId}/schedules/search | Query published schedules for given given time range for set of users |
| [**PostWorkforcemanagementManagementunitServicegoalgroups**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitservicegoalgroups) | **POST** /api/v2/workforcemanagement/managementunits/{managementUnitId}/servicegoalgroups | Create a new service goal group |
| [**PostWorkforcemanagementManagementunitTimeoffrequests**](WorkforceManagementApi.html#postworkforcemanagementmanagementunittimeoffrequests) | **POST** /api/v2/workforcemanagement/managementunits/{muId}/timeoffrequests | Create a new time off request |
| [**PostWorkforcemanagementManagementunitTimeoffrequestsFetchdetails**](WorkforceManagementApi.html#postworkforcemanagementmanagementunittimeoffrequestsfetchdetails) | **POST** /api/v2/workforcemanagement/managementunits/{muId}/timeoffrequests/fetchdetails | Gets a list of time off requests from lookup ids |
| [**PostWorkforcemanagementManagementunitTimeoffrequestsQuery**](WorkforceManagementApi.html#postworkforcemanagementmanagementunittimeoffrequestsquery) | **POST** /api/v2/workforcemanagement/managementunits/{muId}/timeoffrequests/query | Gets the lookup ids to fetch the specified set of requests |
| [**PostWorkforcemanagementManagementunitWeekScheduleCopy**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitweekschedulecopy) | **POST** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/{scheduleId}/copy | Copy a week schedule |
| [**PostWorkforcemanagementManagementunitWeekScheduleReschedule**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitweekschedulereschedule) | **POST** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/{scheduleId}/reschedule | Start a scheduling run to compute the reschedule. When the scheduling run finishes, a client can get the reschedule changes and then the client can apply them to the schedule, save the schedule, and mark the scheduling run as applied |
| [**PostWorkforcemanagementManagementunitWeekSchedules**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitweekschedules) | **POST** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules | Add a schedule for a week in management unit using imported data. Use partial uploads of user schedules if activity count in schedule is greater than 17500 |
| [**PostWorkforcemanagementManagementunitWeekSchedulesGenerate**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitweekschedulesgenerate) | **POST** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/generate | Generate a week schedule |
| [**PostWorkforcemanagementManagementunitWeekSchedulesPartialupload**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitweekschedulespartialupload) | **POST** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/partialupload | Partial upload of user schedules where activity count is greater than 17500 |
| [**PostWorkforcemanagementManagementunitWeekShorttermforecastCopy**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitweekshorttermforecastcopy) | **POST** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}/copy | Copy a short term forecast |
| [**PostWorkforcemanagementManagementunitWeekShorttermforecasts**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitweekshorttermforecasts) | **POST** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shorttermforecasts | Import a short term forecast |
| [**PostWorkforcemanagementManagementunitWeekShorttermforecastsGenerate**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitweekshorttermforecastsgenerate) | **POST** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shorttermforecasts/generate | Generate a short term forecast |
| [**PostWorkforcemanagementManagementunitWeekShorttermforecastsPartialupload**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitweekshorttermforecastspartialupload) | **POST** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shorttermforecasts/partialupload | Import a short term forecast |
| [**PostWorkforcemanagementManagementunitWorkplanCopy**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitworkplancopy) | **POST** /api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId}/copy | Create a copy of work plan |
| [**PostWorkforcemanagementManagementunitWorkplans**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitworkplans) | **POST** /api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans | Create a new work plan |
| [**PostWorkforcemanagementManagementunits**](WorkforceManagementApi.html#postworkforcemanagementmanagementunits) | **POST** /api/v2/workforcemanagement/managementunits | Add a management unit |
| [**PostWorkforcemanagementNotificationsUpdate**](WorkforceManagementApi.html#postworkforcemanagementnotificationsupdate) | **POST** /api/v2/workforcemanagement/notifications/update | Mark a list of notifications as read or unread |
| [**PostWorkforcemanagementSchedules**](WorkforceManagementApi.html#postworkforcemanagementschedules) | **POST** /api/v2/workforcemanagement/schedules | Get published schedule for the current user |
| [**PostWorkforcemanagementTimeoffrequests**](WorkforceManagementApi.html#postworkforcemanagementtimeoffrequests) | **POST** /api/v2/workforcemanagement/timeoffrequests | Create a time off request for the current user |
{: class="table table-striped"}

<a name="deleteworkforcemanagementmanagementunit"></a>

## void DeleteWorkforcemanagementManagementunit (string muId)



Delete management unit



Requires ANY permissions: 

* wfm:managementUnit:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteWorkforcemanagementManagementunitExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.

            try
            { 
                // Delete management unit
                apiInstance.DeleteWorkforcemanagementManagementunit(muId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.DeleteWorkforcemanagementManagementunit: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteworkforcemanagementmanagementunitactivitycode"></a>

## void DeleteWorkforcemanagementManagementunitActivitycode (string muId, string acId)



Deletes an activity code



Requires ANY permissions: 

* wfm:activityCode:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteWorkforcemanagementManagementunitActivitycodeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var acId = acId_example;  // string | The ID of the activity code to delete

            try
            { 
                // Deletes an activity code
                apiInstance.DeleteWorkforcemanagementManagementunitActivitycode(muId, acId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.DeleteWorkforcemanagementManagementunitActivitycode: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **acId** | **string**| The ID of the activity code to delete |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteworkforcemanagementmanagementunitschedulingrun"></a>

## void DeleteWorkforcemanagementManagementunitSchedulingRun (string managementUnitId, string runId)



Cancel a schedule run



Requires ANY permissions: 

* wfm:schedule:generate

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteWorkforcemanagementManagementunitSchedulingRunExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit.
            var runId = runId_example;  // string | The ID of the schedule run

            try
            { 
                // Cancel a schedule run
                apiInstance.DeleteWorkforcemanagementManagementunitSchedulingRun(managementUnitId, runId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.DeleteWorkforcemanagementManagementunitSchedulingRun: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit. |  |
| **runId** | **string**| The ID of the schedule run |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteworkforcemanagementmanagementunitservicegoalgroup"></a>

## void DeleteWorkforcemanagementManagementunitServicegoalgroup (string managementUnitId, string serviceGoalGroupId)



Delete a service goal group



Requires ANY permissions: 

* wfm:serviceGoalGroup:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteWorkforcemanagementManagementunitServicegoalgroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var serviceGoalGroupId = serviceGoalGroupId_example;  // string | The ID of the service goal group to delete

            try
            { 
                // Delete a service goal group
                apiInstance.DeleteWorkforcemanagementManagementunitServicegoalgroup(managementUnitId, serviceGoalGroupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.DeleteWorkforcemanagementManagementunitServicegoalgroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **serviceGoalGroupId** | **string**| The ID of the service goal group to delete |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteworkforcemanagementmanagementunitweekschedule"></a>

## void DeleteWorkforcemanagementManagementunitWeekSchedule (string managementUnitId, string weekId, string scheduleId)



Delete a schedule



Requires ANY permissions: 

* wfm:schedule:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteWorkforcemanagementManagementunitWeekScheduleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var weekId = weekId_example;  // string | First day of schedule week in yyyy-MM-dd format.
            var scheduleId = scheduleId_example;  // string | The ID of theschedule to delete

            try
            { 
                // Delete a schedule
                apiInstance.DeleteWorkforcemanagementManagementunitWeekSchedule(managementUnitId, weekId, scheduleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.DeleteWorkforcemanagementManagementunitWeekSchedule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **weekId** | **string**| First day of schedule week in yyyy-MM-dd format. |  |
| **scheduleId** | **string**| The ID of theschedule to delete |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteworkforcemanagementmanagementunitweekshorttermforecast"></a>

## void DeleteWorkforcemanagementManagementunitWeekShorttermforecast (string managementUnitId, string weekDateId, string forecastId)



Delete a short term forecast

Must not be tied to any schedules

Requires ANY permissions: 

* wfm:shortTermForecast:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteWorkforcemanagementManagementunitWeekShorttermforecastExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The management unit ID of the management unit to which the forecast belongs
            var weekDateId = weekDateId_example;  // string | The week start date of the forecast in yyyy-MM-dd format
            var forecastId = forecastId_example;  // string | The ID of the forecast

            try
            { 
                // Delete a short term forecast
                apiInstance.DeleteWorkforcemanagementManagementunitWeekShorttermforecast(managementUnitId, weekDateId, forecastId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.DeleteWorkforcemanagementManagementunitWeekShorttermforecast: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The management unit ID of the management unit to which the forecast belongs |  |
| **weekDateId** | **string**| The week start date of the forecast in yyyy-MM-dd format |  |
| **forecastId** | **string**| The ID of the forecast |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteworkforcemanagementmanagementunitworkplan"></a>

## void DeleteWorkforcemanagementManagementunitWorkplan (string managementUnitId, string workPlanId)



Delete a work plan



Requires ANY permissions: 

* wfm:workPlan:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteWorkforcemanagementManagementunitWorkplanExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var workPlanId = workPlanId_example;  // string | The ID of the work plan to delete

            try
            { 
                // Delete a work plan
                apiInstance.DeleteWorkforcemanagementManagementunitWorkplan(managementUnitId, workPlanId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.DeleteWorkforcemanagementManagementunitWorkplan: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **workPlanId** | **string**| The ID of the work plan to delete |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getworkforcemanagementadherence"></a>

## [**List&lt;UserScheduleAdherence&gt;**](UserScheduleAdherence.html) GetWorkforcemanagementAdherence (List<string> userId)



Get a list of UserScheduleAdherence records for the requested users



Requires ANY permissions: 

* wfm:realtimeAdherence:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementAdherenceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var userId = new List<string>(); // List<string> | User Id(s) for which to fetch current schedule adherence information.  Min 1, Max of 100 userIds per request

            try
            { 
                // Get a list of UserScheduleAdherence records for the requested users
                List&lt;UserScheduleAdherence&gt; result = apiInstance.GetWorkforcemanagementAdherence(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementAdherence: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | [**List<string>**](string.html)| User Id(s) for which to fetch current schedule adherence information.  Min 1, Max of 100 userIds per request |  |
{: class="table table-striped"}

### Return type

[**List<UserScheduleAdherence>**](UserScheduleAdherence.html)

<a name="getworkforcemanagementadhocmodelingjob"></a>

## [**ModelingStatusResponse**](ModelingStatusResponse.html) GetWorkforcemanagementAdhocmodelingjob (string jobId)



Get status of the modeling job



Requires ANY permissions: 

* wfm:adhocModel:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementAdhocmodelingjobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var jobId = jobId_example;  // string | The id of the modeling job

            try
            { 
                // Get status of the modeling job
                ModelingStatusResponse result = apiInstance.GetWorkforcemanagementAdhocmodelingjob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementAdhocmodelingjob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| The id of the modeling job |  |
{: class="table table-striped"}

### Return type

[**ModelingStatusResponse**](ModelingStatusResponse.html)

<a name="getworkforcemanagementmanagementunit"></a>

## [**ManagementUnit**](ManagementUnit.html) GetWorkforcemanagementManagementunit (string muId, List<string> expand = null)



Get management unit



Requires ANY permissions: 

* wfm:activityCode:add
* wfm:activityCode:delete
* wfm:activityCode:edit
* wfm:activityCode:view
* wfm:agent:edit
* wfm:agentSchedule:view
* wfm:agentTimeOffRequest:submit
* wfm:agent:view
* wfm:businessUnit:add
* wfm:businessUnit:delete
* wfm:businessUnit:edit
* wfm:businessUnit:view
* wfm:historicalAdherence:view
* wfm:intraday:view
* wfm:managementUnit:add
* wfm:managementUnit:delete
* wfm:managementUnit:edit
* wfm:managementUnit:view
* wfm:publishedSchedule:view
* wfm:realtimeAdherence:view
* wfm:schedule:add
* wfm:schedule:delete
* wfm:schedule:edit
* wfm:schedule:generate
* wfm:schedule:view
* wfm:serviceGoalGroup:add
* wfm:serviceGoalGroup:delete
* wfm:serviceGoalGroup:edit
* wfm:serviceGoalGroup:view
* wfm:shiftTradeRequest:edit
* wfm:shiftTradeRequest:view
* wfm:agentShiftTradeRequest:participate
* wfm:shortTermForecast:add
* wfm:shortTermForecast:delete
* wfm:shortTermForecast:edit
* wfm:shortTermForecast:view
* wfm:timeOffRequest:add
* wfm:timeOffRequest:edit
* wfm:timeOffRequest:view
* wfm:workPlan:add
* wfm:workPlan:delete
* wfm:workPlan:edit
* wfm:workPlan:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var expand = new List<string>(); // List<string> |  (optional) 

            try
            { 
                // Get management unit
                ManagementUnit result = apiInstance.GetWorkforcemanagementManagementunit(muId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunit: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **expand** | [**List<string>**](string.html)|  | [optional] <br />**Values**: settings, settings.adherence, settings.timeOff, settings.scheduling, settings.shortTermForecasting, settings.shiftTrading |
{: class="table table-striped"}

### Return type

[**ManagementUnit**](ManagementUnit.html)

<a name="getworkforcemanagementmanagementunitactivitycode"></a>

## [**ActivityCode**](ActivityCode.html) GetWorkforcemanagementManagementunitActivitycode (string muId, string acId)



Get an activity code



Requires ANY permissions: 

* wfm:activityCode:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitActivitycodeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var acId = acId_example;  // string | The ID of the activity code to fetch

            try
            { 
                // Get an activity code
                ActivityCode result = apiInstance.GetWorkforcemanagementManagementunitActivitycode(muId, acId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitActivitycode: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **acId** | **string**| The ID of the activity code to fetch |  |
{: class="table table-striped"}

### Return type

[**ActivityCode**](ActivityCode.html)

<a name="getworkforcemanagementmanagementunitactivitycodes"></a>

## [**ActivityCodeContainer**](ActivityCodeContainer.html) GetWorkforcemanagementManagementunitActivitycodes (string muId)



Get activity codes



Requires ANY permissions: 

* wfm:activityCode:add
* wfm:activityCode:delete
* wfm:activityCode:edit
* wfm:activityCode:view
* wfm:agent:edit
* wfm:agentSchedule:view
* wfm:agentTimeOffRequest:submit
* wfm:agent:view
* wfm:businessUnit:add
* wfm:businessUnit:delete
* wfm:businessUnit:edit
* wfm:businessUnit:view
* wfm:historicalAdherence:view
* wfm:intraday:view
* wfm:managementUnit:add
* wfm:managementUnit:delete
* wfm:managementUnit:edit
* wfm:managementUnit:view
* wfm:publishedSchedule:view
* wfm:realtimeAdherence:view
* wfm:schedule:add
* wfm:schedule:delete
* wfm:schedule:edit
* wfm:schedule:generate
* wfm:schedule:view
* wfm:serviceGoalGroup:add
* wfm:serviceGoalGroup:delete
* wfm:serviceGoalGroup:edit
* wfm:serviceGoalGroup:view
* wfm:shortTermForecast:add
* wfm:shortTermForecast:delete
* wfm:shortTermForecast:edit
* wfm:shortTermForecast:view
* wfm:timeOffRequest:add
* wfm:timeOffRequest:edit
* wfm:timeOffRequest:view
* wfm:workPlan:add
* wfm:workPlan:delete
* wfm:workPlan:edit
* wfm:workPlan:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitActivitycodesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.

            try
            { 
                // Get activity codes
                ActivityCodeContainer result = apiInstance.GetWorkforcemanagementManagementunitActivitycodes(muId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitActivitycodes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
{: class="table table-striped"}

### Return type

[**ActivityCodeContainer**](ActivityCodeContainer.html)

<a name="getworkforcemanagementmanagementunitagent"></a>

## [**WfmAgent**](WfmAgent.html) GetWorkforcemanagementManagementunitAgent (string managementUnitId, string agentId)



Get data for agent in the management unit



Requires ANY permissions: 

* wfm:agent:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitAgentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The id of the management unit, or 'mine' for the management unit of the logged-in user.
            var agentId = agentId_example;  // string | The agent id

            try
            { 
                // Get data for agent in the management unit
                WfmAgent result = apiInstance.GetWorkforcemanagementManagementunitAgent(managementUnitId, agentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitAgent: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The id of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **agentId** | **string**| The agent id |  |
{: class="table table-striped"}

### Return type

[**WfmAgent**](WfmAgent.html)

<a name="getworkforcemanagementmanagementunitintradayqueues"></a>

## [**WfmIntradayQueueListing**](WfmIntradayQueueListing.html) GetWorkforcemanagementManagementunitIntradayQueues (string muId, string date)



Get intraday queues for the given date



Requires ANY permissions: 

* wfm:intraday:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitIntradayQueuesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The management unit ID of the management unit
            var date = date_example;  // string | yyyy-MM-dd date string interpreted in the configured management unit time zone

            try
            { 
                // Get intraday queues for the given date
                WfmIntradayQueueListing result = apiInstance.GetWorkforcemanagementManagementunitIntradayQueues(muId, date);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitIntradayQueues: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The management unit ID of the management unit |  |
| **date** | **string**| yyyy-MM-dd date string interpreted in the configured management unit time zone |  |
{: class="table table-striped"}

### Return type

[**WfmIntradayQueueListing**](WfmIntradayQueueListing.html)

<a name="getworkforcemanagementmanagementunitschedulingrun"></a>

## [**SchedulingRunResponse**](SchedulingRunResponse.html) GetWorkforcemanagementManagementunitSchedulingRun (string managementUnitId, string runId)



Gets the status for a specific scheduling run



Requires ANY permissions: 

* wfm:schedule:generate

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitSchedulingRunExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit.
            var runId = runId_example;  // string | The ID of the schedule run

            try
            { 
                // Gets the status for a specific scheduling run
                SchedulingRunResponse result = apiInstance.GetWorkforcemanagementManagementunitSchedulingRun(managementUnitId, runId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitSchedulingRun: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit. |  |
| **runId** | **string**| The ID of the schedule run |  |
{: class="table table-striped"}

### Return type

[**SchedulingRunResponse**](SchedulingRunResponse.html)

<a name="getworkforcemanagementmanagementunitschedulingrunresult"></a>

## [**RescheduleResult**](RescheduleResult.html) GetWorkforcemanagementManagementunitSchedulingRunResult (string managementUnitId, string runId)



Gets the result of a specific scheduling run



Requires ANY permissions: 

* wfm:schedule:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitSchedulingRunResultExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit.
            var runId = runId_example;  // string | The ID of the schedule run

            try
            { 
                // Gets the result of a specific scheduling run
                RescheduleResult result = apiInstance.GetWorkforcemanagementManagementunitSchedulingRunResult(managementUnitId, runId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitSchedulingRunResult: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit. |  |
| **runId** | **string**| The ID of the schedule run |  |
{: class="table table-striped"}

### Return type

[**RescheduleResult**](RescheduleResult.html)

<a name="getworkforcemanagementmanagementunitschedulingruns"></a>

## [**SchedulingRunListResponse**](SchedulingRunListResponse.html) GetWorkforcemanagementManagementunitSchedulingRuns (string managementUnitId)



Get the status of all the ongoing schedule runs



Requires ANY permissions: 

* wfm:schedule:generate

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitSchedulingRunsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit.

            try
            { 
                // Get the status of all the ongoing schedule runs
                SchedulingRunListResponse result = apiInstance.GetWorkforcemanagementManagementunitSchedulingRuns(managementUnitId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitSchedulingRuns: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit. |  |
{: class="table table-striped"}

### Return type

[**SchedulingRunListResponse**](SchedulingRunListResponse.html)

<a name="getworkforcemanagementmanagementunitservicegoalgroup"></a>

## [**ServiceGoalGroup**](ServiceGoalGroup.html) GetWorkforcemanagementManagementunitServicegoalgroup (string managementUnitId, string serviceGoalGroupId)



Get a service goal group



Requires ANY permissions: 

* wfm:serviceGoalGroup:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitServicegoalgroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var serviceGoalGroupId = serviceGoalGroupId_example;  // string | The ID of the service goal group to fetch

            try
            { 
                // Get a service goal group
                ServiceGoalGroup result = apiInstance.GetWorkforcemanagementManagementunitServicegoalgroup(managementUnitId, serviceGoalGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitServicegoalgroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **serviceGoalGroupId** | **string**| The ID of the service goal group to fetch |  |
{: class="table table-striped"}

### Return type

[**ServiceGoalGroup**](ServiceGoalGroup.html)

<a name="getworkforcemanagementmanagementunitservicegoalgroups"></a>

## [**ServiceGoalGroupList**](ServiceGoalGroupList.html) GetWorkforcemanagementManagementunitServicegoalgroups (string managementUnitId)



Get service goal groups



Requires ANY permissions: 

* wfm:serviceGoalGroup:view
* wfm:shortTermForecast:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitServicegoalgroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.

            try
            { 
                // Get service goal groups
                ServiceGoalGroupList result = apiInstance.GetWorkforcemanagementManagementunitServicegoalgroups(managementUnitId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitServicegoalgroups: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
{: class="table table-striped"}

### Return type

[**ServiceGoalGroupList**](ServiceGoalGroupList.html)

<a name="getworkforcemanagementmanagementunitsettings"></a>

## [**ManagementUnitSettingsResponse**](ManagementUnitSettingsResponse.html) GetWorkforcemanagementManagementunitSettings (string muId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get the settings for the requested management unit. Deprecated, use the GET management unit route instead



Requires ANY permissions: 

* wfm:managementUnit:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.

            try
            { 
                // Get the settings for the requested management unit. Deprecated, use the GET management unit route instead
                ManagementUnitSettingsResponse result = apiInstance.GetWorkforcemanagementManagementunitSettings(muId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
{: class="table table-striped"}

### Return type

[**ManagementUnitSettingsResponse**](ManagementUnitSettingsResponse.html)

<a name="getworkforcemanagementmanagementunitshifttradesmatched"></a>

## [**ShiftTradeMatchesSummaryResponse**](ShiftTradeMatchesSummaryResponse.html) GetWorkforcemanagementManagementunitShifttradesMatched (string muId)



Gets a summary of all shift trades in the matched state



Requires ANY permissions: 

* wfm:shiftTradeRequest:view
* wfm:shiftTradeRequest:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitShifttradesMatchedExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The management unit ID of the management unit, or 'mine' for the management unit of the logged-in user.

            try
            { 
                // Gets a summary of all shift trades in the matched state
                ShiftTradeMatchesSummaryResponse result = apiInstance.GetWorkforcemanagementManagementunitShifttradesMatched(muId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitShifttradesMatched: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
{: class="table table-striped"}

### Return type

[**ShiftTradeMatchesSummaryResponse**](ShiftTradeMatchesSummaryResponse.html)

<a name="getworkforcemanagementmanagementunitshifttradesusers"></a>

## [**WfmUserEntityListing**](WfmUserEntityListing.html) GetWorkforcemanagementManagementunitShifttradesUsers (string muId)



Gets list of users available for whom you can send direct shift trade requests



Requires ANY permissions: 

* wfm:agentShiftTradeRequest:participate

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitShifttradesUsersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The management unit ID of the management unit, or 'mine' for the management unit of the logged-in user.

            try
            { 
                // Gets list of users available for whom you can send direct shift trade requests
                WfmUserEntityListing result = apiInstance.GetWorkforcemanagementManagementunitShifttradesUsers(muId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitShifttradesUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
{: class="table table-striped"}

### Return type

[**WfmUserEntityListing**](WfmUserEntityListing.html)

<a name="getworkforcemanagementmanagementunitusertimeoffrequest"></a>

## [**TimeOffRequestResponse**](TimeOffRequestResponse.html) GetWorkforcemanagementManagementunitUserTimeoffrequest (string muId, string userId, string timeOffRequestId)



Get a time off request



Requires ANY permissions: 

* wfm:timeOffRequest:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitUserTimeoffrequestExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The muId of the management unit, or 'mine' for the management unit of the logged-in user.
            var userId = userId_example;  // string | The userId to whom the Time Off Request applies.
            var timeOffRequestId = timeOffRequestId_example;  // string | Time Off Request Id

            try
            { 
                // Get a time off request
                TimeOffRequestResponse result = apiInstance.GetWorkforcemanagementManagementunitUserTimeoffrequest(muId, userId, timeOffRequestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitUserTimeoffrequest: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **userId** | **string**| The userId to whom the Time Off Request applies. |  |
| **timeOffRequestId** | **string**| Time Off Request Id |  |
{: class="table table-striped"}

### Return type

[**TimeOffRequestResponse**](TimeOffRequestResponse.html)

<a name="getworkforcemanagementmanagementunitusertimeoffrequests"></a>

## [**TimeOffRequestList**](TimeOffRequestList.html) GetWorkforcemanagementManagementunitUserTimeoffrequests (string muId, string userId, bool? recentlyReviewed = null)



Get a list of time off requests for a given user



Requires ANY permissions: 

* wfm:timeOffRequest:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitUserTimeoffrequestsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The muId of the management unit, or 'mine' for the management unit of the logged-in user.
            var userId = userId_example;  // string | The userId to whom the Time Off Request applies.
            var recentlyReviewed = true;  // bool? | Limit results to requests that have been reviewed within the preceding 30 days (optional)  (default to false)

            try
            { 
                // Get a list of time off requests for a given user
                TimeOffRequestList result = apiInstance.GetWorkforcemanagementManagementunitUserTimeoffrequests(muId, userId, recentlyReviewed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitUserTimeoffrequests: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **userId** | **string**| The userId to whom the Time Off Request applies. |  |
| **recentlyReviewed** | **bool?**| Limit results to requests that have been reviewed within the preceding 30 days | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**TimeOffRequestList**](TimeOffRequestList.html)

<a name="getworkforcemanagementmanagementunitusers"></a>

## [**WfmUserEntityListing**](WfmUserEntityListing.html) GetWorkforcemanagementManagementunitUsers (string muId)



Get users in the management unit



Requires ANY permissions: 

* wfm:agent:view
* wfm:historicalAdherence:view
* wfm:publishedSchedule:view
* wfm:realtimeAdherence:view
* wfm:schedule:view
* wfm:timeOffRequest:view
* wfm:workPlan:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitUsersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The management unit ID of the management unit, or 'mine' for the management unit of the logged-in user.

            try
            { 
                // Get users in the management unit
                WfmUserEntityListing result = apiInstance.GetWorkforcemanagementManagementunitUsers(muId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
{: class="table table-striped"}

### Return type

[**WfmUserEntityListing**](WfmUserEntityListing.html)

<a name="getworkforcemanagementmanagementunitweekschedule"></a>

## [**WeekScheduleResponse**](WeekScheduleResponse.html) GetWorkforcemanagementManagementunitWeekSchedule (string managementUnitId, string weekId, string scheduleId, string expand = null, bool? forceDownloadService = null)



Get a week schedule



Requires ANY permissions: 

* wfm:publishedSchedule:view
* wfm:schedule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitWeekScheduleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var weekId = weekId_example;  // string | First day of schedule week in yyyy-MM-dd format.
            var scheduleId = scheduleId_example;  // string | The ID of the schedule to fetch
            var expand = expand_example;  // string | Which fields, if any, to expand (optional) 
            var forceDownloadService = true;  // bool? | Force the result of this operation to be sent via download service.  For testing/app development purposes (optional) 

            try
            { 
                // Get a week schedule
                WeekScheduleResponse result = apiInstance.GetWorkforcemanagementManagementunitWeekSchedule(managementUnitId, weekId, scheduleId, expand, forceDownloadService);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitWeekSchedule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **weekId** | **string**| First day of schedule week in yyyy-MM-dd format. |  |
| **scheduleId** | **string**| The ID of the schedule to fetch |  |
| **expand** | **string**| Which fields, if any, to expand | [optional] <br />**Values**: generationResults, headcountForecast |
| **forceDownloadService** | **bool?**| Force the result of this operation to be sent via download service.  For testing/app development purposes | [optional]  |
{: class="table table-striped"}

### Return type

[**WeekScheduleResponse**](WeekScheduleResponse.html)

<a name="getworkforcemanagementmanagementunitweekschedulegenerationresults"></a>

## [**WeekScheduleGenerationResult**](WeekScheduleGenerationResult.html) GetWorkforcemanagementManagementunitWeekScheduleGenerationresults (string managementUnitId, string weekId, string scheduleId)



Get week schedule generation results



Requires ANY permissions: 

* wfm:publishedSchedule:view
* wfm:schedule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitWeekScheduleGenerationresultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var weekId = weekId_example;  // string | First day of schedule week in yyyy-MM-dd format.
            var scheduleId = scheduleId_example;  // string | The ID of the schedule to fetch generation results

            try
            { 
                // Get week schedule generation results
                WeekScheduleGenerationResult result = apiInstance.GetWorkforcemanagementManagementunitWeekScheduleGenerationresults(managementUnitId, weekId, scheduleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitWeekScheduleGenerationresults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **weekId** | **string**| First day of schedule week in yyyy-MM-dd format. |  |
| **scheduleId** | **string**| The ID of the schedule to fetch generation results |  |
{: class="table table-striped"}

### Return type

[**WeekScheduleGenerationResult**](WeekScheduleGenerationResult.html)

<a name="getworkforcemanagementmanagementunitweekschedules"></a>

## [**WeekScheduleListResponse**](WeekScheduleListResponse.html) GetWorkforcemanagementManagementunitWeekSchedules (string managementUnitId, string weekId, bool? includeOnlyPublished = null, string earliestWeekDate = null, string latestWeekDate = null)



Get the list of schedules in a week in management unit



Requires ANY permissions: 

* wfm:publishedSchedule:view
* wfm:schedule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitWeekSchedulesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var weekId = weekId_example;  // string | First day of schedule week in yyyy-MM-dd format.
            var includeOnlyPublished = true;  // bool? | Return only published schedules (optional) 
            var earliestWeekDate = earliestWeekDate_example;  // string | The start date of the earliest week to query in yyyy-MM-dd format (optional) 
            var latestWeekDate = latestWeekDate_example;  // string | The start date of the latest week to query in yyyy-MM-dd format (optional) 

            try
            { 
                // Get the list of schedules in a week in management unit
                WeekScheduleListResponse result = apiInstance.GetWorkforcemanagementManagementunitWeekSchedules(managementUnitId, weekId, includeOnlyPublished, earliestWeekDate, latestWeekDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitWeekSchedules: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **weekId** | **string**| First day of schedule week in yyyy-MM-dd format. |  |
| **includeOnlyPublished** | **bool?**| Return only published schedules | [optional]  |
| **earliestWeekDate** | **string**| The start date of the earliest week to query in yyyy-MM-dd format | [optional]  |
| **latestWeekDate** | **string**| The start date of the latest week to query in yyyy-MM-dd format | [optional]  |
{: class="table table-striped"}

### Return type

[**WeekScheduleListResponse**](WeekScheduleListResponse.html)

<a name="getworkforcemanagementmanagementunitweekshorttermforecastfinal"></a>

## [**ForecastResultResponse**](ForecastResultResponse.html) GetWorkforcemanagementManagementunitWeekShorttermforecastFinal (string managementUnitId, string weekDateId, string forecastId, bool? forceDownloadService = null)



Get the final result of a short term forecast calculation with modifications applied



Requires ANY permissions: 

* wfm:shortTermForecast:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitWeekShorttermforecastFinalExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The management unit ID of the management unit to which the forecast belongs
            var weekDateId = weekDateId_example;  // string | The week start date of the forecast in yyyy-MM-dd format
            var forecastId = forecastId_example;  // string | The ID of the forecast
            var forceDownloadService = true;  // bool? | Force the result of this operation to be sent via download service.  For testing/app development purposes (optional) 

            try
            { 
                // Get the final result of a short term forecast calculation with modifications applied
                ForecastResultResponse result = apiInstance.GetWorkforcemanagementManagementunitWeekShorttermforecastFinal(managementUnitId, weekDateId, forecastId, forceDownloadService);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitWeekShorttermforecastFinal: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The management unit ID of the management unit to which the forecast belongs |  |
| **weekDateId** | **string**| The week start date of the forecast in yyyy-MM-dd format |  |
| **forecastId** | **string**| The ID of the forecast |  |
| **forceDownloadService** | **bool?**| Force the result of this operation to be sent via download service.  For testing/app development purposes | [optional]  |
{: class="table table-striped"}

### Return type

[**ForecastResultResponse**](ForecastResultResponse.html)

<a name="getworkforcemanagementmanagementunitweekshorttermforecasts"></a>

## [**ShortTermForecastListResponse**](ShortTermForecastListResponse.html) GetWorkforcemanagementManagementunitWeekShorttermforecasts (string managementUnitId, string weekDateId)



Get short term forecasts

Use \"recent\" for the `weekDateId` path parameter to fetch all forecasts for +/- 26 weeks from the current date

Requires ANY permissions: 

* wfm:schedule:generate
* wfm:shortTermForecast:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitWeekShorttermforecastsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The management unit ID of the management unit to which the forecast belongs
            var weekDateId = weekDateId_example;  // string | The week start date of the forecast in yyyy-MM-dd format

            try
            { 
                // Get short term forecasts
                ShortTermForecastListResponse result = apiInstance.GetWorkforcemanagementManagementunitWeekShorttermforecasts(managementUnitId, weekDateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitWeekShorttermforecasts: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The management unit ID of the management unit to which the forecast belongs |  |
| **weekDateId** | **string**| The week start date of the forecast in yyyy-MM-dd format |  |
{: class="table table-striped"}

### Return type

[**ShortTermForecastListResponse**](ShortTermForecastListResponse.html)

<a name="getworkforcemanagementmanagementunitworkplan"></a>

## [**WorkPlan**](WorkPlan.html) GetWorkforcemanagementManagementunitWorkplan (string managementUnitId, string workPlanId)



Get a work plan



Requires ANY permissions: 

* wfm:workPlan:view
* wfm:schedule:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitWorkplanExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var workPlanId = workPlanId_example;  // string | The ID of the work plan to fetch

            try
            { 
                // Get a work plan
                WorkPlan result = apiInstance.GetWorkforcemanagementManagementunitWorkplan(managementUnitId, workPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitWorkplan: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **workPlanId** | **string**| The ID of the work plan to fetch |  |
{: class="table table-striped"}

### Return type

[**WorkPlan**](WorkPlan.html)

<a name="getworkforcemanagementmanagementunitworkplans"></a>

## [**WorkPlanListResponse**](WorkPlanListResponse.html) GetWorkforcemanagementManagementunitWorkplans (string managementUnitId, List<string> expand = null)



Get work plans



Requires ANY permissions: 

* wfm:agent:view
* wfm:publishedSchedule:view
* wfm:schedule:view
* wfm:workPlan:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitWorkplansExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var expand = new List<string>(); // List<string> |  (optional) 

            try
            { 
                // Get work plans
                WorkPlanListResponse result = apiInstance.GetWorkforcemanagementManagementunitWorkplans(managementUnitId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitWorkplans: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **expand** | [**List<string>**](string.html)|  | [optional] <br />**Values**: agentCount, details |
{: class="table table-striped"}

### Return type

[**WorkPlanListResponse**](WorkPlanListResponse.html)

<a name="getworkforcemanagementmanagementunits"></a>

## [**ManagementUnitListing**](ManagementUnitListing.html) GetWorkforcemanagementManagementunits (int? pageSize = null, int? pageNumber = null, string expand = null, string feature = null, string divisionId = null)



Get management units



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var pageSize = 56;  // int? |  (optional) 
            var pageNumber = 56;  // int? |  (optional) 
            var expand = expand_example;  // string |  (optional) 
            var feature = feature_example;  // string |  (optional) 
            var divisionId = divisionId_example;  // string |  (optional) 

            try
            { 
                // Get management units
                ManagementUnitListing result = apiInstance.GetWorkforcemanagementManagementunits(pageSize, pageNumber, expand, feature, divisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunits: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**|  | [optional]  |
| **pageNumber** | **int?**|  | [optional]  |
| **expand** | **string**|  | [optional] <br />**Values**: details |
| **feature** | **string**|  | [optional] <br />**Values**: AgentSchedule, AgentTimeOffRequest, ActivityCodes, Agents, BusinessUnitActivityCodes, BusinessUnits, HistoricalAdherence, IntradayMonitoring, ManagementUnits, RealTimeAdherence, Schedules, BuSchedules, ServiceGoalGroups, ServiceGoalTemplates, PlanningGroups, ShiftTrading, ShortTermForecasts, BuShortTermForecasts, TimeOffRequests, WorkPlans |
| **divisionId** | **string**|  | [optional]  |
{: class="table table-striped"}

### Return type

[**ManagementUnitListing**](ManagementUnitListing.html)

<a name="getworkforcemanagementmanagementunitsdivisionviews"></a>

## [**ManagementUnitListing**](ManagementUnitListing.html) GetWorkforcemanagementManagementunitsDivisionviews (List<string> divisionId = null)



Get management units across divisions



Requires ANY permissions: 

* wfm:managementUnit:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitsDivisionviewsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var divisionId = new List<string>(); // List<string> | The divisionIds to filter by. If omitted, will return all divisions (optional) 

            try
            { 
                // Get management units across divisions
                ManagementUnitListing result = apiInstance.GetWorkforcemanagementManagementunitsDivisionviews(divisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitsDivisionviews: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **divisionId** | [**List<string>**](string.html)| The divisionIds to filter by. If omitted, will return all divisions | [optional]  |
{: class="table table-striped"}

### Return type

[**ManagementUnitListing**](ManagementUnitListing.html)

<a name="getworkforcemanagementnotifications"></a>

## [**NotificationsResponse**](NotificationsResponse.html) GetWorkforcemanagementNotifications ()



Get a list of notifications for the current user



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementNotificationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();

            try
            { 
                // Get a list of notifications for the current user
                NotificationsResponse result = apiInstance.GetWorkforcemanagementNotifications();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementNotifications: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**NotificationsResponse**](NotificationsResponse.html)

<a name="getworkforcemanagementschedulingjob"></a>

## [**SchedulingStatusResponse**](SchedulingStatusResponse.html) GetWorkforcemanagementSchedulingjob (string jobId)



Get status of the scheduling job



Requires ANY permissions: 

* wfm:schedulingrequest:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementSchedulingjobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var jobId = jobId_example;  // string | The id of the scheduling job

            try
            { 
                // Get status of the scheduling job
                SchedulingStatusResponse result = apiInstance.GetWorkforcemanagementSchedulingjob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementSchedulingjob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| The id of the scheduling job |  |
{: class="table table-striped"}

### Return type

[**SchedulingStatusResponse**](SchedulingStatusResponse.html)

<a name="getworkforcemanagementshifttrades"></a>

## [**ShiftTradeListResponse**](ShiftTradeListResponse.html) GetWorkforcemanagementShifttrades ()



Gets all of my shift trades



Requires ANY permissions: 

* wfm:shiftTradeRequest:edit
* wfm:shiftTradeRequest:view
* wfm:agentShiftTradeRequest:participate

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementShifttradesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();

            try
            { 
                // Gets all of my shift trades
                ShiftTradeListResponse result = apiInstance.GetWorkforcemanagementShifttrades();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementShifttrades: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**ShiftTradeListResponse**](ShiftTradeListResponse.html)

<a name="getworkforcemanagementtimeoffrequest"></a>

## [**TimeOffRequestResponse**](TimeOffRequestResponse.html) GetWorkforcemanagementTimeoffrequest (string timeOffRequestId)



Get a time off request for the current user



Requires ANY permissions: 

* wfm:agentSchedule:view
* wfm:agentTimeOffRequest:submit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementTimeoffrequestExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var timeOffRequestId = timeOffRequestId_example;  // string | Time Off Request Id

            try
            { 
                // Get a time off request for the current user
                TimeOffRequestResponse result = apiInstance.GetWorkforcemanagementTimeoffrequest(timeOffRequestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementTimeoffrequest: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **timeOffRequestId** | **string**| Time Off Request Id |  |
{: class="table table-striped"}

### Return type

[**TimeOffRequestResponse**](TimeOffRequestResponse.html)

<a name="getworkforcemanagementtimeoffrequests"></a>

## [**TimeOffRequestList**](TimeOffRequestList.html) GetWorkforcemanagementTimeoffrequests (bool? recentlyReviewed = null)



Get a list of time off requests for the current user



Requires ANY permissions: 

* wfm:agentSchedule:view
* wfm:agentTimeOffRequest:submit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementTimeoffrequestsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var recentlyReviewed = true;  // bool? | Limit results to requests that have been reviewed within the preceding 30 days (optional)  (default to false)

            try
            { 
                // Get a list of time off requests for the current user
                TimeOffRequestList result = apiInstance.GetWorkforcemanagementTimeoffrequests(recentlyReviewed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementTimeoffrequests: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **recentlyReviewed** | **bool?**| Limit results to requests that have been reviewed within the preceding 30 days | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**TimeOffRequestList**](TimeOffRequestList.html)

<a name="patchworkforcemanagementmanagementunit"></a>

## [**ManagementUnit**](ManagementUnit.html) PatchWorkforcemanagementManagementunit (string muId, UpdateManagementUnitRequest body = null)



Update the requested management unit



Requires ANY permissions: 

* wfm:managementUnit:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchWorkforcemanagementManagementunitExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var body = new UpdateManagementUnitRequest(); // UpdateManagementUnitRequest | body (optional) 

            try
            { 
                // Update the requested management unit
                ManagementUnit result = apiInstance.PatchWorkforcemanagementManagementunit(muId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementManagementunit: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **body** | [**UpdateManagementUnitRequest**](UpdateManagementUnitRequest.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**ManagementUnit**](ManagementUnit.html)

<a name="patchworkforcemanagementmanagementunitactivitycode"></a>

## [**ActivityCode**](ActivityCode.html) PatchWorkforcemanagementManagementunitActivitycode (string muId, string acId, UpdateActivityCodeRequest body = null)



Update an activity code



Requires ANY permissions: 

* wfm:activityCode:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchWorkforcemanagementManagementunitActivitycodeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var acId = acId_example;  // string | The ID of the activity code to update
            var body = new UpdateActivityCodeRequest(); // UpdateActivityCodeRequest | body (optional) 

            try
            { 
                // Update an activity code
                ActivityCode result = apiInstance.PatchWorkforcemanagementManagementunitActivitycode(muId, acId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementManagementunitActivitycode: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **acId** | **string**| The ID of the activity code to update |  |
| **body** | [**UpdateActivityCodeRequest**](UpdateActivityCodeRequest.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**ActivityCode**](ActivityCode.html)

<a name="patchworkforcemanagementmanagementunitschedulingrun"></a>

## [**RescheduleResult**](RescheduleResult.html) PatchWorkforcemanagementManagementunitSchedulingRun (string managementUnitId, string runId, UpdateSchedulingRunRequest body = null)



Marks a specific scheduling run as applied, allowing a new rescheduling run to be started



Requires ANY permissions: 

* wfm:schedule:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchWorkforcemanagementManagementunitSchedulingRunExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit.
            var runId = runId_example;  // string | The ID of the schedule run
            var body = new UpdateSchedulingRunRequest(); // UpdateSchedulingRunRequest | body (optional) 

            try
            { 
                // Marks a specific scheduling run as applied, allowing a new rescheduling run to be started
                RescheduleResult result = apiInstance.PatchWorkforcemanagementManagementunitSchedulingRun(managementUnitId, runId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementManagementunitSchedulingRun: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit. |  |
| **runId** | **string**| The ID of the schedule run |  |
| **body** | [**UpdateSchedulingRunRequest**](UpdateSchedulingRunRequest.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**RescheduleResult**](RescheduleResult.html)

<a name="patchworkforcemanagementmanagementunitservicegoalgroup"></a>

## [**ServiceGoalGroup**](ServiceGoalGroup.html) PatchWorkforcemanagementManagementunitServicegoalgroup (string managementUnitId, string serviceGoalGroupId, ServiceGoalGroup body = null)



Update a service goal group



Requires ANY permissions: 

* wfm:serviceGoalGroup:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchWorkforcemanagementManagementunitServicegoalgroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var serviceGoalGroupId = serviceGoalGroupId_example;  // string | The ID of the service goal group to update
            var body = new ServiceGoalGroup(); // ServiceGoalGroup | body (optional) 

            try
            { 
                // Update a service goal group
                ServiceGoalGroup result = apiInstance.PatchWorkforcemanagementManagementunitServicegoalgroup(managementUnitId, serviceGoalGroupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementManagementunitServicegoalgroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **serviceGoalGroupId** | **string**| The ID of the service goal group to update |  |
| **body** | [**ServiceGoalGroup**](ServiceGoalGroup.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**ServiceGoalGroup**](ServiceGoalGroup.html)

<a name="patchworkforcemanagementmanagementunitsettings"></a>

## [**ManagementUnitSettingsResponse**](ManagementUnitSettingsResponse.html) PatchWorkforcemanagementManagementunitSettings (string muId, ManagementUnitSettingsRequest body = null)



Update the settings for the requested management unit



Requires ANY permissions: 

* wfm:managementUnit:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchWorkforcemanagementManagementunitSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var body = new ManagementUnitSettingsRequest(); // ManagementUnitSettingsRequest | config (optional) 

            try
            { 
                // Update the settings for the requested management unit
                ManagementUnitSettingsResponse result = apiInstance.PatchWorkforcemanagementManagementunitSettings(muId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementManagementunitSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **body** | [**ManagementUnitSettingsRequest**](ManagementUnitSettingsRequest.html)| config | [optional]  |
{: class="table table-striped"}

### Return type

[**ManagementUnitSettingsResponse**](ManagementUnitSettingsResponse.html)

<a name="patchworkforcemanagementmanagementunitusertimeoffrequest"></a>

## [**TimeOffRequestResponse**](TimeOffRequestResponse.html) PatchWorkforcemanagementManagementunitUserTimeoffrequest (string muId, string userId, string timeOffRequestId, AdminTimeOffRequestPatch body = null)



Update a time off request



Requires ANY permissions: 

* wfm:timeOffRequest:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchWorkforcemanagementManagementunitUserTimeoffrequestExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The muId of the management unit, or 'mine' for the management unit of the logged-in user.
            var userId = userId_example;  // string | The id of the user the requested time off request belongs to
            var timeOffRequestId = timeOffRequestId_example;  // string | The id of the time off request to update
            var body = new AdminTimeOffRequestPatch(); // AdminTimeOffRequestPatch | body (optional) 

            try
            { 
                // Update a time off request
                TimeOffRequestResponse result = apiInstance.PatchWorkforcemanagementManagementunitUserTimeoffrequest(muId, userId, timeOffRequestId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementManagementunitUserTimeoffrequest: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **userId** | **string**| The id of the user the requested time off request belongs to |  |
| **timeOffRequestId** | **string**| The id of the time off request to update |  |
| **body** | [**AdminTimeOffRequestPatch**](AdminTimeOffRequestPatch.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**TimeOffRequestResponse**](TimeOffRequestResponse.html)

<a name="patchworkforcemanagementmanagementunitweekschedule"></a>

## [**AsyncWeekScheduleResponse**](AsyncWeekScheduleResponse.html) PatchWorkforcemanagementManagementunitWeekSchedule (string managementUnitId, string weekId, string scheduleId, bool? forceAsync = null, bool? forceDownloadService = null, UpdateWeekScheduleRequest body = null)



Update a week schedule



Requires ANY permissions: 

* wfm:schedule:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchWorkforcemanagementManagementunitWeekScheduleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var weekId = weekId_example;  // string | First day of schedule week in yyyy-MM-dd format.
            var scheduleId = scheduleId_example;  // string | The ID of the schedule to update. Use partial uploads of user schedules if activity count in schedule is greater than 17500
            var forceAsync = true;  // bool? | Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional) 
            var forceDownloadService = true;  // bool? | Force the result of this operation to be sent via download service.  For testing/app development purposes (optional) 
            var body = new UpdateWeekScheduleRequest(); // UpdateWeekScheduleRequest | body (optional) 

            try
            { 
                // Update a week schedule
                AsyncWeekScheduleResponse result = apiInstance.PatchWorkforcemanagementManagementunitWeekSchedule(managementUnitId, weekId, scheduleId, forceAsync, forceDownloadService, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementManagementunitWeekSchedule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **weekId** | **string**| First day of schedule week in yyyy-MM-dd format. |  |
| **scheduleId** | **string**| The ID of the schedule to update. Use partial uploads of user schedules if activity count in schedule is greater than 17500 |  |
| **forceAsync** | **bool?**| Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes | [optional]  |
| **forceDownloadService** | **bool?**| Force the result of this operation to be sent via download service.  For testing/app development purposes | [optional]  |
| **body** | [**UpdateWeekScheduleRequest**](UpdateWeekScheduleRequest.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**AsyncWeekScheduleResponse**](AsyncWeekScheduleResponse.html)

<a name="patchworkforcemanagementmanagementunitworkplan"></a>

## [**WorkPlan**](WorkPlan.html) PatchWorkforcemanagementManagementunitWorkplan (string managementUnitId, string workPlanId, WorkPlan body = null)



Update a work plan



Requires ANY permissions: 

* wfm:workPlan:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchWorkforcemanagementManagementunitWorkplanExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var workPlanId = workPlanId_example;  // string | The ID of the work plan to update
            var body = new WorkPlan(); // WorkPlan | body (optional) 

            try
            { 
                // Update a work plan
                WorkPlan result = apiInstance.PatchWorkforcemanagementManagementunitWorkplan(managementUnitId, workPlanId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementManagementunitWorkplan: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **workPlanId** | **string**| The ID of the work plan to update |  |
| **body** | [**WorkPlan**](WorkPlan.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**WorkPlan**](WorkPlan.html)

<a name="patchworkforcemanagementtimeoffrequest"></a>

## [**TimeOffRequestResponse**](TimeOffRequestResponse.html) PatchWorkforcemanagementTimeoffrequest (string timeOffRequestId, AgentTimeOffRequestPatch body = null)



Update a time off request for the current user



Requires ANY permissions: 

* wfm:agentTimeOffRequest:submit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchWorkforcemanagementTimeoffrequestExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var timeOffRequestId = timeOffRequestId_example;  // string | Time Off Request Id
            var body = new AgentTimeOffRequestPatch(); // AgentTimeOffRequestPatch | body (optional) 

            try
            { 
                // Update a time off request for the current user
                TimeOffRequestResponse result = apiInstance.PatchWorkforcemanagementTimeoffrequest(timeOffRequestId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementTimeoffrequest: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **timeOffRequestId** | **string**| Time Off Request Id |  |
| **body** | [**AgentTimeOffRequestPatch**](AgentTimeOffRequestPatch.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**TimeOffRequestResponse**](TimeOffRequestResponse.html)

<a name="postworkforcemanagementadherencehistorical"></a>

## [**WfmHistoricalAdherenceResponse**](WfmHistoricalAdherenceResponse.html) PostWorkforcemanagementAdherenceHistorical (WfmHistoricalAdherenceQueryForUsers body = null)



Request a historical adherence report for users across management units



Requires ANY permissions: 

* wfm:historicalAdherence:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementAdherenceHistoricalExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var body = new WfmHistoricalAdherenceQueryForUsers(); // WfmHistoricalAdherenceQueryForUsers | body (optional) 

            try
            { 
                // Request a historical adherence report for users across management units
                WfmHistoricalAdherenceResponse result = apiInstance.PostWorkforcemanagementAdherenceHistorical(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementAdherenceHistorical: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**WfmHistoricalAdherenceQueryForUsers**](WfmHistoricalAdherenceQueryForUsers.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**WfmHistoricalAdherenceResponse**](WfmHistoricalAdherenceResponse.html)

<a name="postworkforcemanagementmanagementunitactivitycodes"></a>

## [**ActivityCode**](ActivityCode.html) PostWorkforcemanagementManagementunitActivitycodes (string muId, CreateActivityCodeRequest body = null)



Create a new activity code



Requires ANY permissions: 

* wfm:activityCode:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementManagementunitActivitycodesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var body = new CreateActivityCodeRequest(); // CreateActivityCodeRequest | body (optional) 

            try
            { 
                // Create a new activity code
                ActivityCode result = apiInstance.PostWorkforcemanagementManagementunitActivitycodes(muId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitActivitycodes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **body** | [**CreateActivityCodeRequest**](CreateActivityCodeRequest.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**ActivityCode**](ActivityCode.html)

<a name="postworkforcemanagementmanagementunitagentschedulessearch"></a>

## [**UserScheduleContainer**](UserScheduleContainer.html) PostWorkforcemanagementManagementunitAgentschedulesSearch (string muId, BuSearchAgentSchedulesRequest body = null, bool? forceAsync = null, bool? forceDownloadService = null)



Query published schedules for given given time range for set of users



Requires ANY permissions: 

* wfm:publishedSchedule:view
* wfm:schedule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementManagementunitAgentschedulesSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The management unit ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var body = new BuSearchAgentSchedulesRequest(); // BuSearchAgentSchedulesRequest | body (optional) 
            var forceAsync = true;  // bool? | Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional) 
            var forceDownloadService = true;  // bool? | Force the result of this operation to be sent via download service.  For testing/app development purposes (optional) 

            try
            { 
                // Query published schedules for given given time range for set of users
                UserScheduleContainer result = apiInstance.PostWorkforcemanagementManagementunitAgentschedulesSearch(muId, body, forceAsync, forceDownloadService);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitAgentschedulesSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **body** | [**BuSearchAgentSchedulesRequest**](BuSearchAgentSchedulesRequest.html)| body | [optional]  |
| **forceAsync** | **bool?**| Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes | [optional]  |
| **forceDownloadService** | **bool?**| Force the result of this operation to be sent via download service.  For testing/app development purposes | [optional]  |
{: class="table table-striped"}

### Return type

[**UserScheduleContainer**](UserScheduleContainer.html)

<a name="postworkforcemanagementmanagementunithistoricaladherencequery"></a>

## [**WfmHistoricalAdherenceResponse**](WfmHistoricalAdherenceResponse.html) PostWorkforcemanagementManagementunitHistoricaladherencequery (string muId, WfmHistoricalAdherenceQuery body = null)



Request a historical adherence report

The maximum supported range for historical adherence queries is 31 days, or 7 days with includeExceptions = true

Requires ANY permissions: 

* wfm:historicalAdherence:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementManagementunitHistoricaladherencequeryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The management unit ID of the management unit
            var body = new WfmHistoricalAdherenceQuery(); // WfmHistoricalAdherenceQuery | body (optional) 

            try
            { 
                // Request a historical adherence report
                WfmHistoricalAdherenceResponse result = apiInstance.PostWorkforcemanagementManagementunitHistoricaladherencequery(muId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitHistoricaladherencequery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The management unit ID of the management unit |  |
| **body** | [**WfmHistoricalAdherenceQuery**](WfmHistoricalAdherenceQuery.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**WfmHistoricalAdherenceResponse**](WfmHistoricalAdherenceResponse.html)

<a name="postworkforcemanagementmanagementunitintraday"></a>

## [**IntradayResponse**](IntradayResponse.html) PostWorkforcemanagementManagementunitIntraday (string muId, IntradayQueryDataCommand body = null)



Get intraday data for the given date for the requested queueIds



Requires ANY permissions: 

* wfm:intraday:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementManagementunitIntradayExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The management unit ID of the management unit
            var body = new IntradayQueryDataCommand(); // IntradayQueryDataCommand | body (optional) 

            try
            { 
                // Get intraday data for the given date for the requested queueIds
                IntradayResponse result = apiInstance.PostWorkforcemanagementManagementunitIntraday(muId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitIntraday: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The management unit ID of the management unit |  |
| **body** | [**IntradayQueryDataCommand**](IntradayQueryDataCommand.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**IntradayResponse**](IntradayResponse.html)

<a name="postworkforcemanagementmanagementunitmove"></a>

## [**MoveManagementUnitResponse**](MoveManagementUnitResponse.html) PostWorkforcemanagementManagementunitMove (string muId, MoveManagementUnitRequest body = null)



Move the requested management unit to a new business unit

Returns status 200 if the management unit is already in the requested business unit

Requires ANY permissions: 

* wfm:managementUnit:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementManagementunitMoveExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var body = new MoveManagementUnitRequest(); // MoveManagementUnitRequest | body (optional) 

            try
            { 
                // Move the requested management unit to a new business unit
                MoveManagementUnitResponse result = apiInstance.PostWorkforcemanagementManagementunitMove(muId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitMove: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **body** | [**MoveManagementUnitRequest**](MoveManagementUnitRequest.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**MoveManagementUnitResponse**](MoveManagementUnitResponse.html)

<a name="postworkforcemanagementmanagementunitschedulessearch"></a>

## [**UserScheduleContainer**](UserScheduleContainer.html) PostWorkforcemanagementManagementunitSchedulesSearch (string muId, UserListScheduleRequestBody body = null)



Query published schedules for given given time range for set of users



Requires ANY permissions: 

* wfm:publishedSchedule:view
* wfm:schedule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementManagementunitSchedulesSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The management unit ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var body = new UserListScheduleRequestBody(); // UserListScheduleRequestBody | body (optional) 

            try
            { 
                // Query published schedules for given given time range for set of users
                UserScheduleContainer result = apiInstance.PostWorkforcemanagementManagementunitSchedulesSearch(muId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitSchedulesSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **body** | [**UserListScheduleRequestBody**](UserListScheduleRequestBody.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**UserScheduleContainer**](UserScheduleContainer.html)

<a name="postworkforcemanagementmanagementunitservicegoalgroups"></a>

## [**ServiceGoalGroup**](ServiceGoalGroup.html) PostWorkforcemanagementManagementunitServicegoalgroups (string managementUnitId, CreateServiceGoalGroupRequest body = null)



Create a new service goal group



Requires ANY permissions: 

* wfm:serviceGoalGroup:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementManagementunitServicegoalgroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var body = new CreateServiceGoalGroupRequest(); // CreateServiceGoalGroupRequest | body (optional) 

            try
            { 
                // Create a new service goal group
                ServiceGoalGroup result = apiInstance.PostWorkforcemanagementManagementunitServicegoalgroups(managementUnitId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitServicegoalgroups: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **body** | [**CreateServiceGoalGroupRequest**](CreateServiceGoalGroupRequest.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**ServiceGoalGroup**](ServiceGoalGroup.html)

<a name="postworkforcemanagementmanagementunittimeoffrequests"></a>

## [**TimeOffRequestList**](TimeOffRequestList.html) PostWorkforcemanagementManagementunitTimeoffrequests (string muId, CreateAdminTimeOffRequest body = null)



Create a new time off request



Requires ANY permissions: 

* wfm:timeOffRequest:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementManagementunitTimeoffrequestsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The muId of the management unit, or 'mine' for the management unit of the logged-in user.
            var body = new CreateAdminTimeOffRequest(); // CreateAdminTimeOffRequest | body (optional) 

            try
            { 
                // Create a new time off request
                TimeOffRequestList result = apiInstance.PostWorkforcemanagementManagementunitTimeoffrequests(muId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitTimeoffrequests: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **body** | [**CreateAdminTimeOffRequest**](CreateAdminTimeOffRequest.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**TimeOffRequestList**](TimeOffRequestList.html)

<a name="postworkforcemanagementmanagementunittimeoffrequestsfetchdetails"></a>

## [**TimeOffRequestEntityList**](TimeOffRequestEntityList.html) PostWorkforcemanagementManagementunitTimeoffrequestsFetchdetails (string muId, TimeOffRequestLookupList body = null)



Gets a list of time off requests from lookup ids



Requires ANY permissions: 

* wfm:timeOffRequest:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementManagementunitTimeoffrequestsFetchdetailsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The muId of the management unit, or 'mine' for the management unit of the logged-in user.
            var body = new TimeOffRequestLookupList(); // TimeOffRequestLookupList | body (optional) 

            try
            { 
                // Gets a list of time off requests from lookup ids
                TimeOffRequestEntityList result = apiInstance.PostWorkforcemanagementManagementunitTimeoffrequestsFetchdetails(muId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitTimeoffrequestsFetchdetails: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **body** | [**TimeOffRequestLookupList**](TimeOffRequestLookupList.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**TimeOffRequestEntityList**](TimeOffRequestEntityList.html)

<a name="postworkforcemanagementmanagementunittimeoffrequestsquery"></a>

## [**TimeOffRequestLookupList**](TimeOffRequestLookupList.html) PostWorkforcemanagementManagementunitTimeoffrequestsQuery (string muId, TimeOffRequestQueryBody body = null)



Gets the lookup ids to fetch the specified set of requests



Requires ANY permissions: 

* wfm:timeOffRequest:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementManagementunitTimeoffrequestsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The muId of the management unit, or 'mine' for the management unit of the logged-in user.
            var body = new TimeOffRequestQueryBody(); // TimeOffRequestQueryBody | body (optional) 

            try
            { 
                // Gets the lookup ids to fetch the specified set of requests
                TimeOffRequestLookupList result = apiInstance.PostWorkforcemanagementManagementunitTimeoffrequestsQuery(muId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitTimeoffrequestsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **body** | [**TimeOffRequestQueryBody**](TimeOffRequestQueryBody.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**TimeOffRequestLookupList**](TimeOffRequestLookupList.html)

<a name="postworkforcemanagementmanagementunitweekschedulecopy"></a>

## [**AsyncWeekScheduleResponse**](AsyncWeekScheduleResponse.html) PostWorkforcemanagementManagementunitWeekScheduleCopy (string managementUnitId, string weekId, string scheduleId, bool? forceAsync = null, bool? forceDownloadService = null, CopyWeekScheduleRequest body = null)



Copy a week schedule



Requires ANY permissions: 

* wfm:schedule:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementManagementunitWeekScheduleCopyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var weekId = weekId_example;  // string | First day of schedule week in yyyy-MM-dd format.
            var scheduleId = scheduleId_example;  // string | The ID of the schedule to copy from
            var forceAsync = true;  // bool? | Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional) 
            var forceDownloadService = true;  // bool? | Force the result of this operation to be sent via download service.  For testing/app development purposes (optional) 
            var body = new CopyWeekScheduleRequest(); // CopyWeekScheduleRequest | body (optional) 

            try
            { 
                // Copy a week schedule
                AsyncWeekScheduleResponse result = apiInstance.PostWorkforcemanagementManagementunitWeekScheduleCopy(managementUnitId, weekId, scheduleId, forceAsync, forceDownloadService, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitWeekScheduleCopy: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **weekId** | **string**| First day of schedule week in yyyy-MM-dd format. |  |
| **scheduleId** | **string**| The ID of the schedule to copy from |  |
| **forceAsync** | **bool?**| Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes | [optional]  |
| **forceDownloadService** | **bool?**| Force the result of this operation to be sent via download service.  For testing/app development purposes | [optional]  |
| **body** | [**CopyWeekScheduleRequest**](CopyWeekScheduleRequest.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**AsyncWeekScheduleResponse**](AsyncWeekScheduleResponse.html)

<a name="postworkforcemanagementmanagementunitweekschedulereschedule"></a>

## [**AsyncWeekScheduleResponse**](AsyncWeekScheduleResponse.html) PostWorkforcemanagementManagementunitWeekScheduleReschedule (string managementUnitId, string weekId, string scheduleId, RescheduleRequest body = null)



Start a scheduling run to compute the reschedule. When the scheduling run finishes, a client can get the reschedule changes and then the client can apply them to the schedule, save the schedule, and mark the scheduling run as applied



Requires ANY permissions: 

* wfm:schedule:generate

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementManagementunitWeekScheduleRescheduleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var weekId = weekId_example;  // string | First day of schedule week in yyyy-MM-dd format.
            var scheduleId = scheduleId_example;  // string | The ID of the schedule to re-optimize
            var body = new RescheduleRequest(); // RescheduleRequest | body (optional) 

            try
            { 
                // Start a scheduling run to compute the reschedule. When the scheduling run finishes, a client can get the reschedule changes and then the client can apply them to the schedule, save the schedule, and mark the scheduling run as applied
                AsyncWeekScheduleResponse result = apiInstance.PostWorkforcemanagementManagementunitWeekScheduleReschedule(managementUnitId, weekId, scheduleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitWeekScheduleReschedule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **weekId** | **string**| First day of schedule week in yyyy-MM-dd format. |  |
| **scheduleId** | **string**| The ID of the schedule to re-optimize |  |
| **body** | [**RescheduleRequest**](RescheduleRequest.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**AsyncWeekScheduleResponse**](AsyncWeekScheduleResponse.html)

<a name="postworkforcemanagementmanagementunitweekschedules"></a>

## [**AsyncWeekScheduleResponse**](AsyncWeekScheduleResponse.html) PostWorkforcemanagementManagementunitWeekSchedules (string managementUnitId, string weekId, bool? forceAsync = null, bool? forceDownloadService = null, ImportWeekScheduleRequest body = null)



Add a schedule for a week in management unit using imported data. Use partial uploads of user schedules if activity count in schedule is greater than 17500



Requires ANY permissions: 

* wfm:schedule:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementManagementunitWeekSchedulesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var weekId = weekId_example;  // string | First day of schedule week in yyyy-MM-dd format.
            var forceAsync = true;  // bool? | Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional) 
            var forceDownloadService = true;  // bool? | Force the result of this operation to be sent via download service.  For testing/app development purposes (optional) 
            var body = new ImportWeekScheduleRequest(); // ImportWeekScheduleRequest | body (optional) 

            try
            { 
                // Add a schedule for a week in management unit using imported data. Use partial uploads of user schedules if activity count in schedule is greater than 17500
                AsyncWeekScheduleResponse result = apiInstance.PostWorkforcemanagementManagementunitWeekSchedules(managementUnitId, weekId, forceAsync, forceDownloadService, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitWeekSchedules: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **weekId** | **string**| First day of schedule week in yyyy-MM-dd format. |  |
| **forceAsync** | **bool?**| Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes | [optional]  |
| **forceDownloadService** | **bool?**| Force the result of this operation to be sent via download service.  For testing/app development purposes | [optional]  |
| **body** | [**ImportWeekScheduleRequest**](ImportWeekScheduleRequest.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**AsyncWeekScheduleResponse**](AsyncWeekScheduleResponse.html)

<a name="postworkforcemanagementmanagementunitweekschedulesgenerate"></a>

## [**GenerateWeekScheduleResponse**](GenerateWeekScheduleResponse.html) PostWorkforcemanagementManagementunitWeekSchedulesGenerate (string managementUnitId, string weekId, GenerateWeekScheduleRequest body = null)



Generate a week schedule



Requires ANY permissions: 

* wfm:schedule:generate

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementManagementunitWeekSchedulesGenerateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var weekId = weekId_example;  // string | First day of schedule week in yyyy-MM-dd format.
            var body = new GenerateWeekScheduleRequest(); // GenerateWeekScheduleRequest | body (optional) 

            try
            { 
                // Generate a week schedule
                GenerateWeekScheduleResponse result = apiInstance.PostWorkforcemanagementManagementunitWeekSchedulesGenerate(managementUnitId, weekId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitWeekSchedulesGenerate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **weekId** | **string**| First day of schedule week in yyyy-MM-dd format. |  |
| **body** | [**GenerateWeekScheduleRequest**](GenerateWeekScheduleRequest.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**GenerateWeekScheduleResponse**](GenerateWeekScheduleResponse.html)

<a name="postworkforcemanagementmanagementunitweekschedulespartialupload"></a>

## [**PartialUploadResponse**](PartialUploadResponse.html) PostWorkforcemanagementManagementunitWeekSchedulesPartialupload (string managementUnitId, string weekId, UserSchedulesPartialUploadRequest body = null)



Partial upload of user schedules where activity count is greater than 17500



Requires ANY permissions: 

* wfm:schedule:add
* wfm:schedule:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementManagementunitWeekSchedulesPartialuploadExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var weekId = weekId_example;  // string | First day of schedule week in yyyy-MM-dd format.
            var body = new UserSchedulesPartialUploadRequest(); // UserSchedulesPartialUploadRequest | body (optional) 

            try
            { 
                // Partial upload of user schedules where activity count is greater than 17500
                PartialUploadResponse result = apiInstance.PostWorkforcemanagementManagementunitWeekSchedulesPartialupload(managementUnitId, weekId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitWeekSchedulesPartialupload: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **weekId** | **string**| First day of schedule week in yyyy-MM-dd format. |  |
| **body** | [**UserSchedulesPartialUploadRequest**](UserSchedulesPartialUploadRequest.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**PartialUploadResponse**](PartialUploadResponse.html)

<a name="postworkforcemanagementmanagementunitweekshorttermforecastcopy"></a>

## [**ShortTermForecastResponse**](ShortTermForecastResponse.html) PostWorkforcemanagementManagementunitWeekShorttermforecastCopy (string managementUnitId, string weekDateId, string forecastId, CopyShortTermForecastRequest body, bool? forceAsync = null)



Copy a short term forecast



Requires ANY permissions: 

* wfm:shortTermForecast:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementManagementunitWeekShorttermforecastCopyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The management unit ID of the management unit to which the forecast belongs
            var weekDateId = weekDateId_example;  // string | The week start date of the forecast in yyyy-MM-dd format
            var forecastId = forecastId_example;  // string | The ID of the forecast to copy
            var body = new CopyShortTermForecastRequest(); // CopyShortTermForecastRequest | body
            var forceAsync = true;  // bool? | Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional) 

            try
            { 
                // Copy a short term forecast
                ShortTermForecastResponse result = apiInstance.PostWorkforcemanagementManagementunitWeekShorttermforecastCopy(managementUnitId, weekDateId, forecastId, body, forceAsync);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitWeekShorttermforecastCopy: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The management unit ID of the management unit to which the forecast belongs |  |
| **weekDateId** | **string**| The week start date of the forecast in yyyy-MM-dd format |  |
| **forecastId** | **string**| The ID of the forecast to copy |  |
| **body** | [**CopyShortTermForecastRequest**](CopyShortTermForecastRequest.html)| body |  |
| **forceAsync** | **bool?**| Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes | [optional]  |
{: class="table table-striped"}

### Return type

[**ShortTermForecastResponse**](ShortTermForecastResponse.html)

<a name="postworkforcemanagementmanagementunitweekshorttermforecasts"></a>

## [**ShortTermForecastResponse**](ShortTermForecastResponse.html) PostWorkforcemanagementManagementunitWeekShorttermforecasts (string managementUnitId, string weekDateId, ImportShortTermForecastRequest body, bool? forceAsync = null)



Import a short term forecast



Requires ANY permissions: 

* wfm:shortTermForecast:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementManagementunitWeekShorttermforecastsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The management unit ID of the management unit to which the forecast belongs
            var weekDateId = weekDateId_example;  // string | The week start date of the forecast in yyyy-MM-dd format
            var body = new ImportShortTermForecastRequest(); // ImportShortTermForecastRequest | body
            var forceAsync = true;  // bool? | Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional) 

            try
            { 
                // Import a short term forecast
                ShortTermForecastResponse result = apiInstance.PostWorkforcemanagementManagementunitWeekShorttermforecasts(managementUnitId, weekDateId, body, forceAsync);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitWeekShorttermforecasts: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The management unit ID of the management unit to which the forecast belongs |  |
| **weekDateId** | **string**| The week start date of the forecast in yyyy-MM-dd format |  |
| **body** | [**ImportShortTermForecastRequest**](ImportShortTermForecastRequest.html)| body |  |
| **forceAsync** | **bool?**| Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes | [optional]  |
{: class="table table-striped"}

### Return type

[**ShortTermForecastResponse**](ShortTermForecastResponse.html)

<a name="postworkforcemanagementmanagementunitweekshorttermforecastsgenerate"></a>

## [**GenerateShortTermForecastResponse**](GenerateShortTermForecastResponse.html) PostWorkforcemanagementManagementunitWeekShorttermforecastsGenerate (string managementUnitId, string weekDateId, GenerateShortTermForecastRequest body, bool? forceAsync = null)



Generate a short term forecast



Requires ANY permissions: 

* wfm:shortTermForecast:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementManagementunitWeekShorttermforecastsGenerateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The management unit ID of the management unit to which the forecast belongs
            var weekDateId = weekDateId_example;  // string | The week start date of the forecast in yyyy-MM-dd format
            var body = new GenerateShortTermForecastRequest(); // GenerateShortTermForecastRequest | 
            var forceAsync = true;  // bool? | Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional) 

            try
            { 
                // Generate a short term forecast
                GenerateShortTermForecastResponse result = apiInstance.PostWorkforcemanagementManagementunitWeekShorttermforecastsGenerate(managementUnitId, weekDateId, body, forceAsync);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitWeekShorttermforecastsGenerate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The management unit ID of the management unit to which the forecast belongs |  |
| **weekDateId** | **string**| The week start date of the forecast in yyyy-MM-dd format |  |
| **body** | [**GenerateShortTermForecastRequest**](GenerateShortTermForecastRequest.html)|  |  |
| **forceAsync** | **bool?**| Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes | [optional]  |
{: class="table table-striped"}

### Return type

[**GenerateShortTermForecastResponse**](GenerateShortTermForecastResponse.html)

<a name="postworkforcemanagementmanagementunitweekshorttermforecastspartialupload"></a>

## [**PartialUploadResponse**](PartialUploadResponse.html) PostWorkforcemanagementManagementunitWeekShorttermforecastsPartialupload (string managementUnitId, string weekDateId, RouteGroupList body)



Import a short term forecast



Requires ANY permissions: 

* wfm:shortTermForecast:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementManagementunitWeekShorttermforecastsPartialuploadExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The management unit ID of the management unit to which the forecast belongs
            var weekDateId = weekDateId_example;  // string | The week start date of the forecast in yyyy-MM-dd format
            var body = new RouteGroupList(); // RouteGroupList | body

            try
            { 
                // Import a short term forecast
                PartialUploadResponse result = apiInstance.PostWorkforcemanagementManagementunitWeekShorttermforecastsPartialupload(managementUnitId, weekDateId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitWeekShorttermforecastsPartialupload: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The management unit ID of the management unit to which the forecast belongs |  |
| **weekDateId** | **string**| The week start date of the forecast in yyyy-MM-dd format |  |
| **body** | [**RouteGroupList**](RouteGroupList.html)| body |  |
{: class="table table-striped"}

### Return type

[**PartialUploadResponse**](PartialUploadResponse.html)

<a name="postworkforcemanagementmanagementunitworkplancopy"></a>

## [**WorkPlan**](WorkPlan.html) PostWorkforcemanagementManagementunitWorkplanCopy (string managementUnitId, string workPlanId, CopyWorkPlan body = null)



Create a copy of work plan



Requires ANY permissions: 

* wfm:workPlan:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementManagementunitWorkplanCopyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var workPlanId = workPlanId_example;  // string | The ID of the work plan to create a copy
            var body = new CopyWorkPlan(); // CopyWorkPlan | body (optional) 

            try
            { 
                // Create a copy of work plan
                WorkPlan result = apiInstance.PostWorkforcemanagementManagementunitWorkplanCopy(managementUnitId, workPlanId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitWorkplanCopy: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **workPlanId** | **string**| The ID of the work plan to create a copy |  |
| **body** | [**CopyWorkPlan**](CopyWorkPlan.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**WorkPlan**](WorkPlan.html)

<a name="postworkforcemanagementmanagementunitworkplans"></a>

## [**WorkPlan**](WorkPlan.html) PostWorkforcemanagementManagementunitWorkplans (string managementUnitId, CreateWorkPlan body = null)



Create a new work plan



Requires ANY permissions: 

* wfm:workPlan:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementManagementunitWorkplansExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var body = new CreateWorkPlan(); // CreateWorkPlan | body (optional) 

            try
            { 
                // Create a new work plan
                WorkPlan result = apiInstance.PostWorkforcemanagementManagementunitWorkplans(managementUnitId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitWorkplans: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **body** | [**CreateWorkPlan**](CreateWorkPlan.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**WorkPlan**](WorkPlan.html)

<a name="postworkforcemanagementmanagementunits"></a>

## [**ManagementUnit**](ManagementUnit.html) PostWorkforcemanagementManagementunits (CreateManagementUnitApiRequest body = null)



Add a management unit



Requires ANY permissions: 

* wfm:managementUnit:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementManagementunitsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var body = new CreateManagementUnitApiRequest(); // CreateManagementUnitApiRequest | body (optional) 

            try
            { 
                // Add a management unit
                ManagementUnit result = apiInstance.PostWorkforcemanagementManagementunits(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunits: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateManagementUnitApiRequest**](CreateManagementUnitApiRequest.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**ManagementUnit**](ManagementUnit.html)

<a name="postworkforcemanagementnotificationsupdate"></a>

## [**UpdateNotificationsResponse**](UpdateNotificationsResponse.html) PostWorkforcemanagementNotificationsUpdate (UpdateNotificationsRequest body = null)



Mark a list of notifications as read or unread



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementNotificationsUpdateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var body = new UpdateNotificationsRequest(); // UpdateNotificationsRequest | body (optional) 

            try
            { 
                // Mark a list of notifications as read or unread
                UpdateNotificationsResponse result = apiInstance.PostWorkforcemanagementNotificationsUpdate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementNotificationsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UpdateNotificationsRequest**](UpdateNotificationsRequest.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**UpdateNotificationsResponse**](UpdateNotificationsResponse.html)

<a name="postworkforcemanagementschedules"></a>

## [**UserScheduleContainer**](UserScheduleContainer.html) PostWorkforcemanagementSchedules (CurrentUserScheduleRequestBody body = null)



Get published schedule for the current user



Requires ANY permissions: 

* wfm:agentSchedule:view
* wfm:publishedSchedule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementSchedulesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var body = new CurrentUserScheduleRequestBody(); // CurrentUserScheduleRequestBody | body (optional) 

            try
            { 
                // Get published schedule for the current user
                UserScheduleContainer result = apiInstance.PostWorkforcemanagementSchedules(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementSchedules: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CurrentUserScheduleRequestBody**](CurrentUserScheduleRequestBody.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**UserScheduleContainer**](UserScheduleContainer.html)

<a name="postworkforcemanagementtimeoffrequests"></a>

## [**TimeOffRequestResponse**](TimeOffRequestResponse.html) PostWorkforcemanagementTimeoffrequests (CreateAgentTimeOffRequest body = null)



Create a time off request for the current user



Requires ANY permissions: 

* wfm:agentTimeOffRequest:submit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementTimeoffrequestsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var body = new CreateAgentTimeOffRequest(); // CreateAgentTimeOffRequest | body (optional) 

            try
            { 
                // Create a time off request for the current user
                TimeOffRequestResponse result = apiInstance.PostWorkforcemanagementTimeoffrequests(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementTimeoffrequests: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateAgentTimeOffRequest**](CreateAgentTimeOffRequest.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**TimeOffRequestResponse**](TimeOffRequestResponse.html)

