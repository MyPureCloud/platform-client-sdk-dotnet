---
title: WorkforceManagementApi
---
## PureCloudPlatform.Client.V2.Api.WorkforceManagementApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteWorkforcemanagementBusinessunit**](WorkforceManagementApi.html#deleteworkforcemanagementbusinessunit) | **DELETE** /api/v2/workforcemanagement/businessunits/{businessUnitId} | Delete business unit |
| [**DeleteWorkforcemanagementBusinessunitActivitycode**](WorkforceManagementApi.html#deleteworkforcemanagementbusinessunitactivitycode) | **DELETE** /api/v2/workforcemanagement/businessunits/{buId}/activitycodes/{acId} | Deletes an activity code |
| [**DeleteWorkforcemanagementBusinessunitPlanninggroup**](WorkforceManagementApi.html#deleteworkforcemanagementbusinessunitplanninggroup) | **DELETE** /api/v2/workforcemanagement/businessunits/{businessUnitId}/planninggroups/{planningGroupId} | Deletes the planning group |
| [**DeleteWorkforcemanagementBusinessunitSchedulingRun**](WorkforceManagementApi.html#deleteworkforcemanagementbusinessunitschedulingrun) | **DELETE** /api/v2/workforcemanagement/businessunits/{businessUnitId}/scheduling/runs/{runId} | Cancel a scheduling run |
| [**DeleteWorkforcemanagementBusinessunitServicegoaltemplate**](WorkforceManagementApi.html#deleteworkforcemanagementbusinessunitservicegoaltemplate) | **DELETE** /api/v2/workforcemanagement/businessunits/{businessUnitId}/servicegoaltemplates/{serviceGoalTemplateId} | Delete a service goal template |
| [**DeleteWorkforcemanagementBusinessunitWeekSchedule**](WorkforceManagementApi.html#deleteworkforcemanagementbusinessunitweekschedule) | **DELETE** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId} | Delete a schedule |
| [**DeleteWorkforcemanagementBusinessunitWeekShorttermforecast**](WorkforceManagementApi.html#deleteworkforcemanagementbusinessunitweekshorttermforecast) | **DELETE** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId} | Delete a short term forecast |
| [**DeleteWorkforcemanagementManagementunit**](WorkforceManagementApi.html#deleteworkforcemanagementmanagementunit) | **DELETE** /api/v2/workforcemanagement/managementunits/{muId} | Delete management unit |
| [**DeleteWorkforcemanagementManagementunitActivitycode**](WorkforceManagementApi.html#deleteworkforcemanagementmanagementunitactivitycode) | **DELETE** /api/v2/workforcemanagement/managementunits/{muId}/activitycodes/{acId} | Deprecated/Gone: Use the new business unit activity code resources |
| [**DeleteWorkforcemanagementManagementunitSchedulingRun**](WorkforceManagementApi.html#deleteworkforcemanagementmanagementunitschedulingrun) | **DELETE** /api/v2/workforcemanagement/managementunits/{managementUnitId}/scheduling/runs/{runId} | Gone.  Scheduling has moved under business units |
| [**DeleteWorkforcemanagementManagementunitServicegoalgroup**](WorkforceManagementApi.html#deleteworkforcemanagementmanagementunitservicegoalgroup) | **DELETE** /api/v2/workforcemanagement/managementunits/{managementUnitId}/servicegoalgroups/{serviceGoalGroupId} | Gone. Replaced with service goal templates and planning groups under business units |
| [**DeleteWorkforcemanagementManagementunitWeekSchedule**](WorkforceManagementApi.html#deleteworkforcemanagementmanagementunitweekschedule) | **DELETE** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/{scheduleId} | Gone.  Scheduling has moved under business units |
| [**DeleteWorkforcemanagementManagementunitWeekShorttermforecast**](WorkforceManagementApi.html#deleteworkforcemanagementmanagementunitweekshorttermforecast) | **DELETE** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId} | Gone. Use equivalent business unit resource instead |
| [**DeleteWorkforcemanagementManagementunitWorkplan**](WorkforceManagementApi.html#deleteworkforcemanagementmanagementunitworkplan) | **DELETE** /api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId} | Delete a work plan |
| [**GetWorkforcemanagementAdherence**](WorkforceManagementApi.html#getworkforcemanagementadherence) | **GET** /api/v2/workforcemanagement/adherence | Get a list of UserScheduleAdherence records for the requested users |
| [**GetWorkforcemanagementAdhocmodelingjob**](WorkforceManagementApi.html#getworkforcemanagementadhocmodelingjob) | **GET** /api/v2/workforcemanagement/adhocmodelingjobs/{jobId} | Get status of the modeling job |
| [**GetWorkforcemanagementBusinessunit**](WorkforceManagementApi.html#getworkforcemanagementbusinessunit) | **GET** /api/v2/workforcemanagement/businessunits/{businessUnitId} | Get business unit |
| [**GetWorkforcemanagementBusinessunitActivitycode**](WorkforceManagementApi.html#getworkforcemanagementbusinessunitactivitycode) | **GET** /api/v2/workforcemanagement/businessunits/{buId}/activitycodes/{acId} | Get an activity code |
| [**GetWorkforcemanagementBusinessunitActivitycodes**](WorkforceManagementApi.html#getworkforcemanagementbusinessunitactivitycodes) | **GET** /api/v2/workforcemanagement/businessunits/{buId}/activitycodes | Get activity codes |
| [**GetWorkforcemanagementBusinessunitIntradayPlanninggroups**](WorkforceManagementApi.html#getworkforcemanagementbusinessunitintradayplanninggroups) | **GET** /api/v2/workforcemanagement/businessunits/{businessUnitId}/intraday/planninggroups | Get intraday planning groups for the given date |
| [**GetWorkforcemanagementBusinessunitManagementunits**](WorkforceManagementApi.html#getworkforcemanagementbusinessunitmanagementunits) | **GET** /api/v2/workforcemanagement/businessunits/{businessUnitId}/managementunits | Get all authorized management units in the business unit |
| [**GetWorkforcemanagementBusinessunitPlanninggroup**](WorkforceManagementApi.html#getworkforcemanagementbusinessunitplanninggroup) | **GET** /api/v2/workforcemanagement/businessunits/{businessUnitId}/planninggroups/{planningGroupId} | Get a planning group |
| [**GetWorkforcemanagementBusinessunitPlanninggroups**](WorkforceManagementApi.html#getworkforcemanagementbusinessunitplanninggroups) | **GET** /api/v2/workforcemanagement/businessunits/{businessUnitId}/planninggroups | Gets list of planning groups |
| [**GetWorkforcemanagementBusinessunitSchedulingRun**](WorkforceManagementApi.html#getworkforcemanagementbusinessunitschedulingrun) | **GET** /api/v2/workforcemanagement/businessunits/{businessUnitId}/scheduling/runs/{runId} | Get a scheduling run |
| [**GetWorkforcemanagementBusinessunitSchedulingRunResult**](WorkforceManagementApi.html#getworkforcemanagementbusinessunitschedulingrunresult) | **GET** /api/v2/workforcemanagement/businessunits/{businessUnitId}/scheduling/runs/{runId}/result | Get the result of a rescheduling operation |
| [**GetWorkforcemanagementBusinessunitSchedulingRuns**](WorkforceManagementApi.html#getworkforcemanagementbusinessunitschedulingruns) | **GET** /api/v2/workforcemanagement/businessunits/{businessUnitId}/scheduling/runs | Get the list of scheduling runs |
| [**GetWorkforcemanagementBusinessunitServicegoaltemplate**](WorkforceManagementApi.html#getworkforcemanagementbusinessunitservicegoaltemplate) | **GET** /api/v2/workforcemanagement/businessunits/{businessUnitId}/servicegoaltemplates/{serviceGoalTemplateId} | Get a service goal template |
| [**GetWorkforcemanagementBusinessunitServicegoaltemplates**](WorkforceManagementApi.html#getworkforcemanagementbusinessunitservicegoaltemplates) | **GET** /api/v2/workforcemanagement/businessunits/{businessUnitId}/servicegoaltemplates | Gets list of service goal templates |
| [**GetWorkforcemanagementBusinessunitWeekSchedule**](WorkforceManagementApi.html#getworkforcemanagementbusinessunitweekschedule) | **GET** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId} | Get the metadata for the schedule, describing which management units and agents are in the scheduleSchedule data can then be loaded with the query route |
| [**GetWorkforcemanagementBusinessunitWeekScheduleGenerationresults**](WorkforceManagementApi.html#getworkforcemanagementbusinessunitweekschedulegenerationresults) | **GET** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/generationresults | Get the generation results for a generated schedule |
| [**GetWorkforcemanagementBusinessunitWeekScheduleHeadcountforecast**](WorkforceManagementApi.html#getworkforcemanagementbusinessunitweekscheduleheadcountforecast) | **GET** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/headcountforecast | Get the headcount forecast by planning group for the schedule |
| [**GetWorkforcemanagementBusinessunitWeekSchedules**](WorkforceManagementApi.html#getworkforcemanagementbusinessunitweekschedules) | **GET** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules | Get the list of week schedules for the specified week |
| [**GetWorkforcemanagementBusinessunitWeekShorttermforecast**](WorkforceManagementApi.html#getworkforcemanagementbusinessunitweekshorttermforecast) | **GET** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId} | Get a short term forecast |
| [**GetWorkforcemanagementBusinessunitWeekShorttermforecastData**](WorkforceManagementApi.html#getworkforcemanagementbusinessunitweekshorttermforecastdata) | **GET** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}/data | Get the result of a short term forecast calculation |
| [**GetWorkforcemanagementBusinessunitWeekShorttermforecastGenerationresults**](WorkforceManagementApi.html#getworkforcemanagementbusinessunitweekshorttermforecastgenerationresults) | **GET** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}/generationresults | Gets the forecast generation results |
| [**GetWorkforcemanagementBusinessunitWeekShorttermforecastPlanninggroups**](WorkforceManagementApi.html#getworkforcemanagementbusinessunitweekshorttermforecastplanninggroups) | **GET** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}/planninggroups | Gets the forecast planning group snapshot |
| [**GetWorkforcemanagementBusinessunitWeekShorttermforecasts**](WorkforceManagementApi.html#getworkforcemanagementbusinessunitweekshorttermforecasts) | **GET** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts | Get short term forecasts |
| [**GetWorkforcemanagementBusinessunits**](WorkforceManagementApi.html#getworkforcemanagementbusinessunits) | **GET** /api/v2/workforcemanagement/businessunits | Get business units |
| [**GetWorkforcemanagementBusinessunitsDivisionviews**](WorkforceManagementApi.html#getworkforcemanagementbusinessunitsdivisionviews) | **GET** /api/v2/workforcemanagement/businessunits/divisionviews | Get business units across divisions |
| [**GetWorkforcemanagementManagementunit**](WorkforceManagementApi.html#getworkforcemanagementmanagementunit) | **GET** /api/v2/workforcemanagement/managementunits/{muId} | Get management unit |
| [**GetWorkforcemanagementManagementunitActivitycode**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitactivitycode) | **GET** /api/v2/workforcemanagement/managementunits/{muId}/activitycodes/{acId} | Get an activity code |
| [**GetWorkforcemanagementManagementunitActivitycodes**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitactivitycodes) | **GET** /api/v2/workforcemanagement/managementunits/{muId}/activitycodes | Get activity codes |
| [**GetWorkforcemanagementManagementunitAdherence**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitadherence) | **GET** /api/v2/workforcemanagement/managementunits/{managementUnitId}/adherence | Get a list of user schedule adherence records for the requested management unit |
| [**GetWorkforcemanagementManagementunitAgent**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitagent) | **GET** /api/v2/workforcemanagement/managementunits/{managementUnitId}/agents/{agentId} | Get data for agent in the management unit |
| [**GetWorkforcemanagementManagementunitAgentShifttrades**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitagentshifttrades) | **GET** /api/v2/workforcemanagement/managementunits/{managementUnitId}/agents/{agentId}/shifttrades | Gets all the shift trades for a given agent |
| [**GetWorkforcemanagementManagementunitIntradayQueues**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitintradayqueues) | **GET** /api/v2/workforcemanagement/managementunits/{muId}/intraday/queues | Gone.  Moved under business units |
| [**GetWorkforcemanagementManagementunitSchedulingRun**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitschedulingrun) | **GET** /api/v2/workforcemanagement/managementunits/{managementUnitId}/scheduling/runs/{runId} | Gone.  Scheduling has moved under business units |
| [**GetWorkforcemanagementManagementunitSchedulingRunResult**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitschedulingrunresult) | **GET** /api/v2/workforcemanagement/managementunits/{managementUnitId}/scheduling/runs/{runId}/result | Gone.  Scheduling has moved under business units |
| [**GetWorkforcemanagementManagementunitSchedulingRuns**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitschedulingruns) | **GET** /api/v2/workforcemanagement/managementunits/{managementUnitId}/scheduling/runs | Gone.  Scheduling has moved under business units |
| [**GetWorkforcemanagementManagementunitServicegoalgroup**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitservicegoalgroup) | **GET** /api/v2/workforcemanagement/managementunits/{managementUnitId}/servicegoalgroups/{serviceGoalGroupId} | Gone. Replaced with service goal templates and planning groups under business units |
| [**GetWorkforcemanagementManagementunitServicegoalgroups**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitservicegoalgroups) | **GET** /api/v2/workforcemanagement/managementunits/{managementUnitId}/servicegoalgroups | Gone. Replaced with service goal templates and planning groups under business units |
| [**GetWorkforcemanagementManagementunitSettings**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitsettings) | **GET** /api/v2/workforcemanagement/managementunits/{muId}/settings | Gone. Get management unit settings via expand parameters on the GET management unit |
| [**GetWorkforcemanagementManagementunitShifttradesMatched**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitshifttradesmatched) | **GET** /api/v2/workforcemanagement/managementunits/{muId}/shifttrades/matched | Gets a summary of all shift trades in the matched state |
| [**GetWorkforcemanagementManagementunitShifttradesUsers**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitshifttradesusers) | **GET** /api/v2/workforcemanagement/managementunits/{muId}/shifttrades/users | Gets list of users available for whom you can send direct shift trade requests |
| [**GetWorkforcemanagementManagementunitUserTimeoffrequest**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitusertimeoffrequest) | **GET** /api/v2/workforcemanagement/managementunits/{muId}/users/{userId}/timeoffrequests/{timeOffRequestId} | Get a time off request |
| [**GetWorkforcemanagementManagementunitUserTimeoffrequests**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitusertimeoffrequests) | **GET** /api/v2/workforcemanagement/managementunits/{muId}/users/{userId}/timeoffrequests | Get a list of time off requests for a given user |
| [**GetWorkforcemanagementManagementunitUsers**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitusers) | **GET** /api/v2/workforcemanagement/managementunits/{muId}/users | Get users in the management unit |
| [**GetWorkforcemanagementManagementunitWeekSchedule**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitweekschedule) | **GET** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/{scheduleId} | Deprecated.  Use the equivalent business unit resource instead. Get a week schedule |
| [**GetWorkforcemanagementManagementunitWeekScheduleGenerationresults**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitweekschedulegenerationresults) | **GET** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/{scheduleId}/generationresults | Gone.  Scheduling has moved under business units |
| [**GetWorkforcemanagementManagementunitWeekSchedules**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitweekschedules) | **GET** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules | Deprecated.  Use the equivalent business unit resource instead. Get the list of schedules in a week in management unit |
| [**GetWorkforcemanagementManagementunitWeekShifttrades**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitweekshifttrades) | **GET** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shifttrades | Gets all the shift trades for a given week |
| [**GetWorkforcemanagementManagementunitWeekShorttermforecastFinal**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitweekshorttermforecastfinal) | **GET** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}/final | Gone. Use equivalent business unit resource instead |
| [**GetWorkforcemanagementManagementunitWeekShorttermforecasts**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitweekshorttermforecasts) | **GET** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shorttermforecasts | Gone. Use equivalent business unit resource instead |
| [**GetWorkforcemanagementManagementunitWorkplan**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitworkplan) | **GET** /api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId} | Get a work plan |
| [**GetWorkforcemanagementManagementunitWorkplans**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitworkplans) | **GET** /api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans | Get work plans |
| [**GetWorkforcemanagementManagementunits**](WorkforceManagementApi.html#getworkforcemanagementmanagementunits) | **GET** /api/v2/workforcemanagement/managementunits | Get management units |
| [**GetWorkforcemanagementManagementunitsDivisionviews**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitsdivisionviews) | **GET** /api/v2/workforcemanagement/managementunits/divisionviews | Get management units across divisions |
| [**GetWorkforcemanagementNotifications**](WorkforceManagementApi.html#getworkforcemanagementnotifications) | **GET** /api/v2/workforcemanagement/notifications | Get a list of notifications for the current user |
| [**GetWorkforcemanagementSchedulingjob**](WorkforceManagementApi.html#getworkforcemanagementschedulingjob) | **GET** /api/v2/workforcemanagement/schedulingjobs/{jobId} | Get status of the scheduling job |
| [**GetWorkforcemanagementShifttrades**](WorkforceManagementApi.html#getworkforcemanagementshifttrades) | **GET** /api/v2/workforcemanagement/shifttrades | Gets all of my shift trades |
| [**GetWorkforcemanagementTimeoffrequest**](WorkforceManagementApi.html#getworkforcemanagementtimeoffrequest) | **GET** /api/v2/workforcemanagement/timeoffrequests/{timeOffRequestId} | Get a time off request for the current user |
| [**GetWorkforcemanagementTimeoffrequests**](WorkforceManagementApi.html#getworkforcemanagementtimeoffrequests) | **GET** /api/v2/workforcemanagement/timeoffrequests | Get a list of time off requests for the current user |
| [**PatchWorkforcemanagementBusinessunit**](WorkforceManagementApi.html#patchworkforcemanagementbusinessunit) | **PATCH** /api/v2/workforcemanagement/businessunits/{businessUnitId} | Update business unit |
| [**PatchWorkforcemanagementBusinessunitActivitycode**](WorkforceManagementApi.html#patchworkforcemanagementbusinessunitactivitycode) | **PATCH** /api/v2/workforcemanagement/businessunits/{buId}/activitycodes/{acId} | Update an activity code |
| [**PatchWorkforcemanagementBusinessunitPlanninggroup**](WorkforceManagementApi.html#patchworkforcemanagementbusinessunitplanninggroup) | **PATCH** /api/v2/workforcemanagement/businessunits/{businessUnitId}/planninggroups/{planningGroupId} | Updates the planning group |
| [**PatchWorkforcemanagementBusinessunitSchedulingRun**](WorkforceManagementApi.html#patchworkforcemanagementbusinessunitschedulingrun) | **PATCH** /api/v2/workforcemanagement/businessunits/{businessUnitId}/scheduling/runs/{runId} | Mark a schedule run as applied |
| [**PatchWorkforcemanagementBusinessunitServicegoaltemplate**](WorkforceManagementApi.html#patchworkforcemanagementbusinessunitservicegoaltemplate) | **PATCH** /api/v2/workforcemanagement/businessunits/{businessUnitId}/servicegoaltemplates/{serviceGoalTemplateId} | Updates a service goal template |
| [**PatchWorkforcemanagementManagementunit**](WorkforceManagementApi.html#patchworkforcemanagementmanagementunit) | **PATCH** /api/v2/workforcemanagement/managementunits/{muId} | Update the requested management unit |
| [**PatchWorkforcemanagementManagementunitActivitycode**](WorkforceManagementApi.html#patchworkforcemanagementmanagementunitactivitycode) | **PATCH** /api/v2/workforcemanagement/managementunits/{muId}/activitycodes/{acId} | Deprecated/Gone: Use the new business unit activity code resources |
| [**PatchWorkforcemanagementManagementunitSchedulingRun**](WorkforceManagementApi.html#patchworkforcemanagementmanagementunitschedulingrun) | **PATCH** /api/v2/workforcemanagement/managementunits/{managementUnitId}/scheduling/runs/{runId} | Gone.  Scheduling has moved under business units |
| [**PatchWorkforcemanagementManagementunitServicegoalgroup**](WorkforceManagementApi.html#patchworkforcemanagementmanagementunitservicegoalgroup) | **PATCH** /api/v2/workforcemanagement/managementunits/{managementUnitId}/servicegoalgroups/{serviceGoalGroupId} | Gone. Replaced with service goal templates and planning groups under business units |
| [**PatchWorkforcemanagementManagementunitSettings**](WorkforceManagementApi.html#patchworkforcemanagementmanagementunitsettings) | **PATCH** /api/v2/workforcemanagement/managementunits/{muId}/settings | Gone. Update settings by PATCHing the management unit |
| [**PatchWorkforcemanagementManagementunitUserTimeoffrequest**](WorkforceManagementApi.html#patchworkforcemanagementmanagementunitusertimeoffrequest) | **PATCH** /api/v2/workforcemanagement/managementunits/{muId}/users/{userId}/timeoffrequests/{timeOffRequestId} | Update a time off request |
| [**PatchWorkforcemanagementManagementunitWeekSchedule**](WorkforceManagementApi.html#patchworkforcemanagementmanagementunitweekschedule) | **PATCH** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/{scheduleId} | Gone.  Scheduling has moved under business units |
| [**PatchWorkforcemanagementManagementunitWeekShifttrade**](WorkforceManagementApi.html#patchworkforcemanagementmanagementunitweekshifttrade) | **PATCH** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shifttrades/{tradeId} | Updates a shift trade. This route can only be called by the initiating agent |
| [**PatchWorkforcemanagementManagementunitWorkplan**](WorkforceManagementApi.html#patchworkforcemanagementmanagementunitworkplan) | **PATCH** /api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId} | Update a work plan |
| [**PatchWorkforcemanagementTimeoffrequest**](WorkforceManagementApi.html#patchworkforcemanagementtimeoffrequest) | **PATCH** /api/v2/workforcemanagement/timeoffrequests/{timeOffRequestId} | Update a time off request for the current user |
| [**PostWorkforcemanagementAdherenceHistorical**](WorkforceManagementApi.html#postworkforcemanagementadherencehistorical) | **POST** /api/v2/workforcemanagement/adherence/historical | Request a historical adherence report for users across management units |
| [**PostWorkforcemanagementAgentschedulesMine**](WorkforceManagementApi.html#postworkforcemanagementagentschedulesmine) | **POST** /api/v2/workforcemanagement/agentschedules/mine | Get published schedule for the current user |
| [**PostWorkforcemanagementBusinessunitActivitycodes**](WorkforceManagementApi.html#postworkforcemanagementbusinessunitactivitycodes) | **POST** /api/v2/workforcemanagement/businessunits/{buId}/activitycodes | Create a new activity code |
| [**PostWorkforcemanagementBusinessunitAgentschedulesSearch**](WorkforceManagementApi.html#postworkforcemanagementbusinessunitagentschedulessearch) | **POST** /api/v2/workforcemanagement/businessunits/{businessUnitId}/agentschedules/search | Search published schedules |
| [**PostWorkforcemanagementBusinessunitIntraday**](WorkforceManagementApi.html#postworkforcemanagementbusinessunitintraday) | **POST** /api/v2/workforcemanagement/businessunits/{businessUnitId}/intraday | Get intraday data for the given date for the requested planningGroupIds |
| [**PostWorkforcemanagementBusinessunitPlanninggroups**](WorkforceManagementApi.html#postworkforcemanagementbusinessunitplanninggroups) | **POST** /api/v2/workforcemanagement/businessunits/{businessUnitId}/planninggroups | Adds a new planning group |
| [**PostWorkforcemanagementBusinessunitServicegoaltemplates**](WorkforceManagementApi.html#postworkforcemanagementbusinessunitservicegoaltemplates) | **POST** /api/v2/workforcemanagement/businessunits/{businessUnitId}/servicegoaltemplates | Adds a new service goal template |
| [**PostWorkforcemanagementBusinessunitWeekScheduleAgentschedulesQuery**](WorkforceManagementApi.html#postworkforcemanagementbusinessunitweekscheduleagentschedulesquery) | **POST** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/agentschedules/query | Loads agent schedule data from the schedule. Used in combination with the metadata route |
| [**PostWorkforcemanagementBusinessunitWeekScheduleCopy**](WorkforceManagementApi.html#postworkforcemanagementbusinessunitweekschedulecopy) | **POST** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/copy | Copy a schedule |
| [**PostWorkforcemanagementBusinessunitWeekScheduleReschedule**](WorkforceManagementApi.html#postworkforcemanagementbusinessunitweekschedulereschedule) | **POST** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/reschedule | Start a rescheduling run |
| [**PostWorkforcemanagementBusinessunitWeekSchedules**](WorkforceManagementApi.html#postworkforcemanagementbusinessunitweekschedules) | **POST** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules | Create a blank schedule |
| [**PostWorkforcemanagementBusinessunitWeekSchedulesGenerate**](WorkforceManagementApi.html#postworkforcemanagementbusinessunitweekschedulesgenerate) | **POST** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/generate | Generate a schedule |
| [**PostWorkforcemanagementBusinessunitWeekShorttermforecastCopy**](WorkforceManagementApi.html#postworkforcemanagementbusinessunitweekshorttermforecastcopy) | **POST** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}/copy | Copy a short term forecast |
| [**PostWorkforcemanagementBusinessunitWeekShorttermforecastsGenerate**](WorkforceManagementApi.html#postworkforcemanagementbusinessunitweekshorttermforecastsgenerate) | **POST** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/generate | Generate a short term forecast |
| [**PostWorkforcemanagementBusinessunits**](WorkforceManagementApi.html#postworkforcemanagementbusinessunits) | **POST** /api/v2/workforcemanagement/businessunits | Add a new business unit |
| [**PostWorkforcemanagementManagementunitActivitycodes**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitactivitycodes) | **POST** /api/v2/workforcemanagement/managementunits/{muId}/activitycodes | Deprecated/Gone: Use the new business unit activity code resources |
| [**PostWorkforcemanagementManagementunitAgentschedulesSearch**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitagentschedulessearch) | **POST** /api/v2/workforcemanagement/managementunits/{muId}/agentschedules/search | Query published schedules for given given time range for set of users |
| [**PostWorkforcemanagementManagementunitHistoricaladherencequery**](WorkforceManagementApi.html#postworkforcemanagementmanagementunithistoricaladherencequery) | **POST** /api/v2/workforcemanagement/managementunits/{muId}/historicaladherencequery | Request a historical adherence report |
| [**PostWorkforcemanagementManagementunitIntraday**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitintraday) | **POST** /api/v2/workforcemanagement/managementunits/{muId}/intraday | Gone.  Moved under business units |
| [**PostWorkforcemanagementManagementunitMove**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitmove) | **POST** /api/v2/workforcemanagement/managementunits/{muId}/move | Move the requested management unit to a new business unit |
| [**PostWorkforcemanagementManagementunitSchedulesSearch**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitschedulessearch) | **POST** /api/v2/workforcemanagement/managementunits/{muId}/schedules/search | Query published schedules for given given time range for set of users |
| [**PostWorkforcemanagementManagementunitServicegoalgroups**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitservicegoalgroups) | **POST** /api/v2/workforcemanagement/managementunits/{managementUnitId}/servicegoalgroups | Gone. Replaced with service goal templates and planning groups under business units |
| [**PostWorkforcemanagementManagementunitTimeoffrequests**](WorkforceManagementApi.html#postworkforcemanagementmanagementunittimeoffrequests) | **POST** /api/v2/workforcemanagement/managementunits/{muId}/timeoffrequests | Create a new time off request |
| [**PostWorkforcemanagementManagementunitTimeoffrequestsFetchdetails**](WorkforceManagementApi.html#postworkforcemanagementmanagementunittimeoffrequestsfetchdetails) | **POST** /api/v2/workforcemanagement/managementunits/{muId}/timeoffrequests/fetchdetails | Gone.  All data is now returned in the query route |
| [**PostWorkforcemanagementManagementunitTimeoffrequestsQuery**](WorkforceManagementApi.html#postworkforcemanagementmanagementunittimeoffrequestsquery) | **POST** /api/v2/workforcemanagement/managementunits/{muId}/timeoffrequests/query | Gets the lookup ids to fetch the specified set of requests |
| [**PostWorkforcemanagementManagementunitWeekScheduleCopy**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitweekschedulecopy) | **POST** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/{scheduleId}/copy | Gone.  Scheduling has moved under business units |
| [**PostWorkforcemanagementManagementunitWeekScheduleReschedule**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitweekschedulereschedule) | **POST** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/{scheduleId}/reschedule | Gone.  Scheduling has moved under business units |
| [**PostWorkforcemanagementManagementunitWeekSchedules**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitweekschedules) | **POST** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules | Gone.  Scheduling has moved under business units |
| [**PostWorkforcemanagementManagementunitWeekSchedulesGenerate**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitweekschedulesgenerate) | **POST** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/generate | Gone.  Scheduling has moved under business units |
| [**PostWorkforcemanagementManagementunitWeekSchedulesPartialupload**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitweekschedulespartialupload) | **POST** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/partialupload | Gone.  Scheduling has moved under business units |
| [**PostWorkforcemanagementManagementunitWeekShifttradeMatch**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitweekshifttradematch) | **POST** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shifttrades/{tradeId}/match | Matches a shift trade. This route can only be called by the receiving agent |
| [**PostWorkforcemanagementManagementunitWeekShifttrades**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitweekshifttrades) | **POST** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shifttrades | Adds a shift trade |
| [**PostWorkforcemanagementManagementunitWeekShifttradesSearch**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitweekshifttradessearch) | **POST** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shifttrades/search | Searches for potential shift trade matches for the current agent |
| [**PostWorkforcemanagementManagementunitWeekShifttradesStateBulk**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitweekshifttradesstatebulk) | **POST** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shifttrades/state/bulk | Updates the state of a batch of shift trades |
| [**PostWorkforcemanagementManagementunitWeekShorttermforecastCopy**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitweekshorttermforecastcopy) | **POST** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}/copy | Gone. Use equivalent business unit resource instead |
| [**PostWorkforcemanagementManagementunitWeekShorttermforecasts**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitweekshorttermforecasts) | **POST** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shorttermforecasts | Gone. Use equivalent business unit resource instead |
| [**PostWorkforcemanagementManagementunitWeekShorttermforecastsGenerate**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitweekshorttermforecastsgenerate) | **POST** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shorttermforecasts/generate | Gone. Use equivalent business unit resource instead |
| [**PostWorkforcemanagementManagementunitWeekShorttermforecastsPartialupload**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitweekshorttermforecastspartialupload) | **POST** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shorttermforecasts/partialupload | Gone. Use equivalent business unit resource instead |
| [**PostWorkforcemanagementManagementunitWorkplanCopy**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitworkplancopy) | **POST** /api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId}/copy | Create a copy of work plan |
| [**PostWorkforcemanagementManagementunitWorkplans**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitworkplans) | **POST** /api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans | Create a new work plan |
| [**PostWorkforcemanagementManagementunits**](WorkforceManagementApi.html#postworkforcemanagementmanagementunits) | **POST** /api/v2/workforcemanagement/managementunits | Add a management unit |
| [**PostWorkforcemanagementNotificationsUpdate**](WorkforceManagementApi.html#postworkforcemanagementnotificationsupdate) | **POST** /api/v2/workforcemanagement/notifications/update | Mark a list of notifications as read or unread |
| [**PostWorkforcemanagementSchedules**](WorkforceManagementApi.html#postworkforcemanagementschedules) | **POST** /api/v2/workforcemanagement/schedules | Get published schedule for the current user |
| [**PostWorkforcemanagementTimeoffrequests**](WorkforceManagementApi.html#postworkforcemanagementtimeoffrequests) | **POST** /api/v2/workforcemanagement/timeoffrequests | Create a time off request for the current user |
{: class="table table-striped"}

<a name="deleteworkforcemanagementbusinessunit"></a>

## void DeleteWorkforcemanagementBusinessunit (string businessUnitId)



Delete business unit

A business unit cannot be deleted if it contains one or more management units

Requires ANY permissions: 

* wfm:businessUnit:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteWorkforcemanagementBusinessunitExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit, or 'mine' for the business unit of the logged-in user.

            try
            { 
                // Delete business unit
                apiInstance.DeleteWorkforcemanagementBusinessunit(businessUnitId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.DeleteWorkforcemanagementBusinessunit: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit, or &#39;mine&#39; for the business unit of the logged-in user. |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteworkforcemanagementbusinessunitactivitycode"></a>

## void DeleteWorkforcemanagementBusinessunitActivitycode (string buId, string acId)



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
    public class DeleteWorkforcemanagementBusinessunitActivitycodeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var buId = buId_example;  // string | The ID of the business unit, or 'mine' for the business unit of the logged-in user.
            var acId = acId_example;  // string | The ID of the activity code to delete

            try
            { 
                // Deletes an activity code
                apiInstance.DeleteWorkforcemanagementBusinessunitActivitycode(buId, acId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.DeleteWorkforcemanagementBusinessunitActivitycode: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **buId** | **string**| The ID of the business unit, or &#39;mine&#39; for the business unit of the logged-in user. |  |
| **acId** | **string**| The ID of the activity code to delete |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteworkforcemanagementbusinessunitplanninggroup"></a>

## void DeleteWorkforcemanagementBusinessunitPlanninggroup (string businessUnitId, string planningGroupId)



Deletes the planning group



Requires ANY permissions: 

* wfm:planningGroup:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteWorkforcemanagementBusinessunitPlanninggroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit.
            var planningGroupId = planningGroupId_example;  // string | The ID of a planning group to delete

            try
            { 
                // Deletes the planning group
                apiInstance.DeleteWorkforcemanagementBusinessunitPlanninggroup(businessUnitId, planningGroupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.DeleteWorkforcemanagementBusinessunitPlanninggroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit. |  |
| **planningGroupId** | **string**| The ID of a planning group to delete |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteworkforcemanagementbusinessunitschedulingrun"></a>

## void DeleteWorkforcemanagementBusinessunitSchedulingRun (string businessUnitId, string runId)



Cancel a scheduling run



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
    public class DeleteWorkforcemanagementBusinessunitSchedulingRunExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var runId = runId_example;  // string | The ID of the schedule run

            try
            { 
                // Cancel a scheduling run
                apiInstance.DeleteWorkforcemanagementBusinessunitSchedulingRun(businessUnitId, runId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.DeleteWorkforcemanagementBusinessunitSchedulingRun: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **runId** | **string**| The ID of the schedule run |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteworkforcemanagementbusinessunitservicegoaltemplate"></a>

## void DeleteWorkforcemanagementBusinessunitServicegoaltemplate (string businessUnitId, string serviceGoalTemplateId)



Delete a service goal template



Requires ANY permissions: 

* wfm:serviceGoalTemplate:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteWorkforcemanagementBusinessunitServicegoaltemplateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit.
            var serviceGoalTemplateId = serviceGoalTemplateId_example;  // string | The ID of the service goal template to delete

            try
            { 
                // Delete a service goal template
                apiInstance.DeleteWorkforcemanagementBusinessunitServicegoaltemplate(businessUnitId, serviceGoalTemplateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.DeleteWorkforcemanagementBusinessunitServicegoaltemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit. |  |
| **serviceGoalTemplateId** | **string**| The ID of the service goal template to delete |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteworkforcemanagementbusinessunitweekschedule"></a>

## [**BuAsyncScheduleResponse**](BuAsyncScheduleResponse.html) DeleteWorkforcemanagementBusinessunitWeekSchedule (string businessUnitId, DateTime? weekId, string scheduleId)



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
    public class DeleteWorkforcemanagementBusinessunitWeekScheduleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var weekId = 2013-10-20;  // DateTime? | First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var scheduleId = scheduleId_example;  // string | The ID of the schedule

            try
            { 
                // Delete a schedule
                BuAsyncScheduleResponse result = apiInstance.DeleteWorkforcemanagementBusinessunitWeekSchedule(businessUnitId, weekId, scheduleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.DeleteWorkforcemanagementBusinessunitWeekSchedule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **weekId** | **DateTime?**| First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **scheduleId** | **string**| The ID of the schedule |  |
{: class="table table-striped"}

### Return type

[**BuAsyncScheduleResponse**](BuAsyncScheduleResponse.html)

<a name="deleteworkforcemanagementbusinessunitweekshorttermforecast"></a>

## void DeleteWorkforcemanagementBusinessunitWeekShorttermforecast (string businessUnitId, DateTime? weekDateId, string forecastId)



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
    public class DeleteWorkforcemanagementBusinessunitWeekShorttermforecastExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The business unit ID of the business unit to which the forecast belongs
            var weekDateId = 2013-10-20;  // DateTime? | The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var forecastId = forecastId_example;  // string | The ID of the forecast

            try
            { 
                // Delete a short term forecast
                apiInstance.DeleteWorkforcemanagementBusinessunitWeekShorttermforecast(businessUnitId, weekDateId, forecastId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.DeleteWorkforcemanagementBusinessunitWeekShorttermforecast: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The business unit ID of the business unit to which the forecast belongs |  |
| **weekDateId** | **DateTime?**| The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **forecastId** | **string**| The ID of the forecast |  |
{: class="table table-striped"}

### Return type

void (empty response body)

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

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Deprecated/Gone: Use the new business unit activity code resources



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
                // Deprecated/Gone: Use the new business unit activity code resources
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

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gone.  Scheduling has moved under business units



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
    public class DeleteWorkforcemanagementManagementunitSchedulingRunExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | (Deprecated/gone): The ID of the management unit.
            var runId = runId_example;  // string | The ID of the schedule run

            try
            { 
                // Gone.  Scheduling has moved under business units
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
| **managementUnitId** | **string**| (Deprecated/gone): The ID of the management unit. |  |
| **runId** | **string**| The ID of the schedule run |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteworkforcemanagementmanagementunitservicegoalgroup"></a>

## void DeleteWorkforcemanagementManagementunitServicegoalgroup (string managementUnitId, string serviceGoalGroupId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gone. Replaced with service goal templates and planning groups under business units



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
    public class DeleteWorkforcemanagementManagementunitServicegoalgroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | (Deprecated/gone): The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var serviceGoalGroupId = serviceGoalGroupId_example;  // string | Gone. The ID of the service goal group to delete

            try
            { 
                // Gone. Replaced with service goal templates and planning groups under business units
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
| **managementUnitId** | **string**| (Deprecated/gone): The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **serviceGoalGroupId** | **string**| Gone. The ID of the service goal group to delete |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteworkforcemanagementmanagementunitweekschedule"></a>

## void DeleteWorkforcemanagementManagementunitWeekSchedule (string managementUnitId, string weekId, string scheduleId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gone.  Scheduling has moved under business units



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
    public class DeleteWorkforcemanagementManagementunitWeekScheduleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var weekId = weekId_example;  // string | First day of schedule week in yyyy-MM-dd format.
            var scheduleId = scheduleId_example;  // string | Gone/deprecated. The ID of the schedule to delete

            try
            { 
                // Gone.  Scheduling has moved under business units
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
| **scheduleId** | **string**| Gone/deprecated. The ID of the schedule to delete |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteworkforcemanagementmanagementunitweekshorttermforecast"></a>

## void DeleteWorkforcemanagementManagementunitWeekShorttermforecast (string managementUnitId, string weekDateId, string forecastId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gone. Use equivalent business unit resource instead



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
    public class DeleteWorkforcemanagementManagementunitWeekShorttermforecastExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | (Deprecated/gone): The id of the management unit.
            var weekDateId = weekDateId_example;  // string | (Deprecated/gone): The week start date of the forecast in yyyy-MM-dd format
            var forecastId = forecastId_example;  // string | (Gone/Deprecated): The ID of the forecast

            try
            { 
                // Gone. Use equivalent business unit resource instead
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
| **managementUnitId** | **string**| (Deprecated/gone): The id of the management unit. |  |
| **weekDateId** | **string**| (Deprecated/gone): The week start date of the forecast in yyyy-MM-dd format |  |
| **forecastId** | **string**| (Gone/Deprecated): The ID of the forecast |  |
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

<a name="getworkforcemanagementbusinessunit"></a>

## [**BusinessUnit**](BusinessUnit.html) GetWorkforcemanagementBusinessunit (string businessUnitId, List<string> expand = null)



Get business unit

Expanding \"settings\" will retrieve all settings.  All other expands will retrieve only the requested settings field(s).

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
* wfm:serviceGoalTemplate:add
* wfm:serviceGoalTemplate:delete
* wfm:serviceGoalTemplate:edit
* wfm:serviceGoalTemplate:view
* wfm:planningGroup:add
* wfm:planningGroup:delete
* wfm:planningGroup:edit
* wfm:planningGroup:view
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
    public class GetWorkforcemanagementBusinessunitExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit, or 'mine' for the business unit of the logged-in user.
            var expand = new List<string>(); // List<string> |  (optional) 

            try
            { 
                // Get business unit
                BusinessUnit result = apiInstance.GetWorkforcemanagementBusinessunit(businessUnitId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunit: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit, or &#39;mine&#39; for the business unit of the logged-in user. |  |
| **expand** | [**List<string>**](string.html)|  | [optional] <br />**Values**: settings, settings.timeZone, settings.startDayOfWeek, settings.shortTermForecasting |
{: class="table table-striped"}

### Return type

[**BusinessUnit**](BusinessUnit.html)

<a name="getworkforcemanagementbusinessunitactivitycode"></a>

## [**BusinessUnitActivityCode**](BusinessUnitActivityCode.html) GetWorkforcemanagementBusinessunitActivitycode (string buId, string acId)



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
    public class GetWorkforcemanagementBusinessunitActivitycodeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var buId = buId_example;  // string | The ID of the business unit, or 'mine' for the business unit of the logged-in user.
            var acId = acId_example;  // string | The ID of the activity code to fetch

            try
            { 
                // Get an activity code
                BusinessUnitActivityCode result = apiInstance.GetWorkforcemanagementBusinessunitActivitycode(buId, acId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitActivitycode: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **buId** | **string**| The ID of the business unit, or &#39;mine&#39; for the business unit of the logged-in user. |  |
| **acId** | **string**| The ID of the activity code to fetch |  |
{: class="table table-striped"}

### Return type

[**BusinessUnitActivityCode**](BusinessUnitActivityCode.html)

<a name="getworkforcemanagementbusinessunitactivitycodes"></a>

## [**BusinessUnitActivityCodeListing**](BusinessUnitActivityCodeListing.html) GetWorkforcemanagementBusinessunitActivitycodes (string buId)



Get activity codes



Requires ANY permissions: 

* wfm:agentSchedule:view
* wfm:agentTimeOffRequest:submit
* wfm:activityCode:add
* wfm:activityCode:delete
* wfm:activityCode:edit
* wfm:activityCode:view
* wfm:agent:edit
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
* wfm:realtimeAdherence:view
* wfm:schedule:add
* wfm:schedule:delete
* wfm:schedule:edit
* wfm:schedule:generate
* wfm:schedule:view
* wfm:publishedSchedule:view
* wfm:serviceGoalTemplate:add
* wfm:serviceGoalTemplate:delete
* wfm:serviceGoalTemplate:edit
* wfm:serviceGoalTemplate:view
* wfm:planningGroup:add
* wfm:planningGroup:delete
* wfm:planningGroup:edit
* wfm:planningGroup:view
* wfm:shiftTradeRequest:edit
* wfm:shiftTradeRequest:view
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
    public class GetWorkforcemanagementBusinessunitActivitycodesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var buId = buId_example;  // string | The ID of the business unit, or 'mine' for the business unit of the logged-in user.

            try
            { 
                // Get activity codes
                BusinessUnitActivityCodeListing result = apiInstance.GetWorkforcemanagementBusinessunitActivitycodes(buId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitActivitycodes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **buId** | **string**| The ID of the business unit, or &#39;mine&#39; for the business unit of the logged-in user. |  |
{: class="table table-striped"}

### Return type

[**BusinessUnitActivityCodeListing**](BusinessUnitActivityCodeListing.html)

<a name="getworkforcemanagementbusinessunitintradayplanninggroups"></a>

## [**WfmIntradayPlanningGroupListing**](WfmIntradayPlanningGroupListing.html) GetWorkforcemanagementBusinessunitIntradayPlanninggroups (string businessUnitId, DateTime? date)



Get intraday planning groups for the given date



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
    public class GetWorkforcemanagementBusinessunitIntradayPlanninggroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The business unit ID of the business unit
            var date = 2013-10-20;  // DateTime? | yyyy-MM-dd date string interpreted in the configured business unit time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd

            try
            { 
                // Get intraday planning groups for the given date
                WfmIntradayPlanningGroupListing result = apiInstance.GetWorkforcemanagementBusinessunitIntradayPlanninggroups(businessUnitId, date);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitIntradayPlanninggroups: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The business unit ID of the business unit |  |
| **date** | **DateTime?**| yyyy-MM-dd date string interpreted in the configured business unit time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
{: class="table table-striped"}

### Return type

[**WfmIntradayPlanningGroupListing**](WfmIntradayPlanningGroupListing.html)

<a name="getworkforcemanagementbusinessunitmanagementunits"></a>

## [**ManagementUnitListing**](ManagementUnitListing.html) GetWorkforcemanagementBusinessunitManagementunits (string businessUnitId, string feature = null, string divisionId = null)



Get all authorized management units in the business unit



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
    public class GetWorkforcemanagementBusinessunitManagementunitsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit, or 'mine' for the business unit of the logged-in user.
            var feature = feature_example;  // string |  (optional) 
            var divisionId = divisionId_example;  // string |  (optional) 

            try
            { 
                // Get all authorized management units in the business unit
                ManagementUnitListing result = apiInstance.GetWorkforcemanagementBusinessunitManagementunits(businessUnitId, feature, divisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitManagementunits: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit, or &#39;mine&#39; for the business unit of the logged-in user. |  |
| **feature** | **string**|  | [optional] <br />**Values**: AgentSchedule, AgentTimeOffRequest, ActivityCodes, Agents, BusinessUnitActivityCodes, BusinessUnits, HistoricalAdherence, IntradayMonitoring, BuIntradayMonitoring, ManagementUnits, RealTimeAdherence, Schedules, BuSchedules, ServiceGoalGroups, ServiceGoalTemplates, PlanningGroups, ShiftTrading, ShortTermForecasts, BuShortTermForecasts, TimeOffRequests, WorkPlans |
| **divisionId** | **string**|  | [optional]  |
{: class="table table-striped"}

### Return type

[**ManagementUnitListing**](ManagementUnitListing.html)

<a name="getworkforcemanagementbusinessunitplanninggroup"></a>

## [**PlanningGroup**](PlanningGroup.html) GetWorkforcemanagementBusinessunitPlanninggroup (string businessUnitId, string planningGroupId)



Get a planning group



Requires ANY permissions: 

* wfm:planningGroup:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementBusinessunitPlanninggroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit.
            var planningGroupId = planningGroupId_example;  // string | The ID of a planning group to fetch

            try
            { 
                // Get a planning group
                PlanningGroup result = apiInstance.GetWorkforcemanagementBusinessunitPlanninggroup(businessUnitId, planningGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitPlanninggroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit. |  |
| **planningGroupId** | **string**| The ID of a planning group to fetch |  |
{: class="table table-striped"}

### Return type

[**PlanningGroup**](PlanningGroup.html)

<a name="getworkforcemanagementbusinessunitplanninggroups"></a>

## [**PlanningGroupList**](PlanningGroupList.html) GetWorkforcemanagementBusinessunitPlanninggroups (string businessUnitId)



Gets list of planning groups



Requires ANY permissions: 

* wfm:planningGroup:view
* wfm:shortTermForecast:view
* wfm:intraday:view
* wfm:agent:view
* wfm:schedule:view
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
    public class GetWorkforcemanagementBusinessunitPlanninggroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit.

            try
            { 
                // Gets list of planning groups
                PlanningGroupList result = apiInstance.GetWorkforcemanagementBusinessunitPlanninggroups(businessUnitId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitPlanninggroups: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit. |  |
{: class="table table-striped"}

### Return type

[**PlanningGroupList**](PlanningGroupList.html)

<a name="getworkforcemanagementbusinessunitschedulingrun"></a>

## [**BuScheduleRun**](BuScheduleRun.html) GetWorkforcemanagementBusinessunitSchedulingRun (string businessUnitId, string runId)



Get a scheduling run



Requires ANY permissions: 

* wfm:schedule:generate
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
    public class GetWorkforcemanagementBusinessunitSchedulingRunExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var runId = runId_example;  // string | The ID of the schedule run

            try
            { 
                // Get a scheduling run
                BuScheduleRun result = apiInstance.GetWorkforcemanagementBusinessunitSchedulingRun(businessUnitId, runId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitSchedulingRun: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **runId** | **string**| The ID of the schedule run |  |
{: class="table table-striped"}

### Return type

[**BuScheduleRun**](BuScheduleRun.html)

<a name="getworkforcemanagementbusinessunitschedulingrunresult"></a>

## [**BuRescheduleResult**](BuRescheduleResult.html) GetWorkforcemanagementBusinessunitSchedulingRunResult (string businessUnitId, string runId, List<string> managementUnitIds, List<string> expand)



Get the result of a rescheduling operation



Requires ANY permissions: 

* wfm:schedule:edit
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
    public class GetWorkforcemanagementBusinessunitSchedulingRunResultExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var runId = runId_example;  // string | The ID of the schedule run
            var managementUnitIds = new List<string>(); // List<string> | The IDs of the management units for which to fetch the reschedule results
            var expand = new List<string>(); // List<string> | The fields to expand. Omitting will return an empty response

            try
            { 
                // Get the result of a rescheduling operation
                BuRescheduleResult result = apiInstance.GetWorkforcemanagementBusinessunitSchedulingRunResult(businessUnitId, runId, managementUnitIds, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitSchedulingRunResult: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **runId** | **string**| The ID of the schedule run |  |
| **managementUnitIds** | [**List<string>**](string.html)| The IDs of the management units for which to fetch the reschedule results |  |
| **expand** | [**List<string>**](string.html)| The fields to expand. Omitting will return an empty response | <br />**Values**: headcountForecast, generationResults, agentSchedules |
{: class="table table-striped"}

### Return type

[**BuRescheduleResult**](BuRescheduleResult.html)

<a name="getworkforcemanagementbusinessunitschedulingruns"></a>

## [**BuScheduleRunListing**](BuScheduleRunListing.html) GetWorkforcemanagementBusinessunitSchedulingRuns (string businessUnitId)



Get the list of scheduling runs



Requires ANY permissions: 

* wfm:schedule:generate
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
    public class GetWorkforcemanagementBusinessunitSchedulingRunsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit

            try
            { 
                // Get the list of scheduling runs
                BuScheduleRunListing result = apiInstance.GetWorkforcemanagementBusinessunitSchedulingRuns(businessUnitId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitSchedulingRuns: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
{: class="table table-striped"}

### Return type

[**BuScheduleRunListing**](BuScheduleRunListing.html)

<a name="getworkforcemanagementbusinessunitservicegoaltemplate"></a>

## [**ServiceGoalTemplate**](ServiceGoalTemplate.html) GetWorkforcemanagementBusinessunitServicegoaltemplate (string businessUnitId, string serviceGoalTemplateId)



Get a service goal template



Requires ANY permissions: 

* wfm:serviceGoalTemplate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementBusinessunitServicegoaltemplateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit.
            var serviceGoalTemplateId = serviceGoalTemplateId_example;  // string | The ID of a service goal template to fetch

            try
            { 
                // Get a service goal template
                ServiceGoalTemplate result = apiInstance.GetWorkforcemanagementBusinessunitServicegoaltemplate(businessUnitId, serviceGoalTemplateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitServicegoaltemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit. |  |
| **serviceGoalTemplateId** | **string**| The ID of a service goal template to fetch |  |
{: class="table table-striped"}

### Return type

[**ServiceGoalTemplate**](ServiceGoalTemplate.html)

<a name="getworkforcemanagementbusinessunitservicegoaltemplates"></a>

## [**ServiceGoalTemplateList**](ServiceGoalTemplateList.html) GetWorkforcemanagementBusinessunitServicegoaltemplates (string businessUnitId)



Gets list of service goal templates



Requires ANY permissions: 

* wfm:serviceGoalTemplate:view
* wfm:planningGroup:view
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
    public class GetWorkforcemanagementBusinessunitServicegoaltemplatesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit.

            try
            { 
                // Gets list of service goal templates
                ServiceGoalTemplateList result = apiInstance.GetWorkforcemanagementBusinessunitServicegoaltemplates(businessUnitId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitServicegoaltemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit. |  |
{: class="table table-striped"}

### Return type

[**ServiceGoalTemplateList**](ServiceGoalTemplateList.html)

<a name="getworkforcemanagementbusinessunitweekschedule"></a>

## [**BuScheduleMetadata**](BuScheduleMetadata.html) GetWorkforcemanagementBusinessunitWeekSchedule (string businessUnitId, DateTime? weekId, string scheduleId)



Get the metadata for the schedule, describing which management units and agents are in the scheduleSchedule data can then be loaded with the query route



Requires ANY permissions: 

* wfm:schedule:view
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
    public class GetWorkforcemanagementBusinessunitWeekScheduleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var weekId = 2013-10-20;  // DateTime? | First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var scheduleId = scheduleId_example;  // string | The ID of the schedule

            try
            { 
                // Get the metadata for the schedule, describing which management units and agents are in the scheduleSchedule data can then be loaded with the query route
                BuScheduleMetadata result = apiInstance.GetWorkforcemanagementBusinessunitWeekSchedule(businessUnitId, weekId, scheduleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitWeekSchedule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **weekId** | **DateTime?**| First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **scheduleId** | **string**| The ID of the schedule |  |
{: class="table table-striped"}

### Return type

[**BuScheduleMetadata**](BuScheduleMetadata.html)

<a name="getworkforcemanagementbusinessunitweekschedulegenerationresults"></a>

## [**ScheduleGenerationResult**](ScheduleGenerationResult.html) GetWorkforcemanagementBusinessunitWeekScheduleGenerationresults (string businessUnitId, DateTime? weekId, string scheduleId)



Get the generation results for a generated schedule



Requires ANY permissions: 

* wfm:schedule:view
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
    public class GetWorkforcemanagementBusinessunitWeekScheduleGenerationresultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var weekId = 2013-10-20;  // DateTime? | First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var scheduleId = scheduleId_example;  // string | The ID of the schedule

            try
            { 
                // Get the generation results for a generated schedule
                ScheduleGenerationResult result = apiInstance.GetWorkforcemanagementBusinessunitWeekScheduleGenerationresults(businessUnitId, weekId, scheduleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitWeekScheduleGenerationresults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **weekId** | **DateTime?**| First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **scheduleId** | **string**| The ID of the schedule |  |
{: class="table table-striped"}

### Return type

[**ScheduleGenerationResult**](ScheduleGenerationResult.html)

<a name="getworkforcemanagementbusinessunitweekscheduleheadcountforecast"></a>

## [**BuHeadcountForecastResponse**](BuHeadcountForecastResponse.html) GetWorkforcemanagementBusinessunitWeekScheduleHeadcountforecast (string businessUnitId, DateTime? weekId, string scheduleId, bool? forceDownload = null)



Get the headcount forecast by planning group for the schedule



Requires ANY permissions: 

* wfm:schedule:view
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
    public class GetWorkforcemanagementBusinessunitWeekScheduleHeadcountforecastExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var weekId = 2013-10-20;  // DateTime? | First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var scheduleId = scheduleId_example;  // string | The ID of the schedule
            var forceDownload = true;  // bool? | Whether to force the result to come via download url.  For testing purposes only (optional) 

            try
            { 
                // Get the headcount forecast by planning group for the schedule
                BuHeadcountForecastResponse result = apiInstance.GetWorkforcemanagementBusinessunitWeekScheduleHeadcountforecast(businessUnitId, weekId, scheduleId, forceDownload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitWeekScheduleHeadcountforecast: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **weekId** | **DateTime?**| First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **scheduleId** | **string**| The ID of the schedule |  |
| **forceDownload** | **bool?**| Whether to force the result to come via download url.  For testing purposes only | [optional]  |
{: class="table table-striped"}

### Return type

[**BuHeadcountForecastResponse**](BuHeadcountForecastResponse.html)

<a name="getworkforcemanagementbusinessunitweekschedules"></a>

## [**BuScheduleListing**](BuScheduleListing.html) GetWorkforcemanagementBusinessunitWeekSchedules (string businessUnitId, string weekId, bool? includeOnlyPublished = null, string expand = null)



Get the list of week schedules for the specified week

Use \"recent\" for the `weekId` path parameter to fetch all forecasts for +/- 26 weeks from the current date. Response will include any schedule which spans the specified week

Requires ANY permissions: 

* wfm:schedule:view
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
    public class GetWorkforcemanagementBusinessunitWeekSchedulesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var weekId = weekId_example;  // string | First day of schedule week in yyyy-MM-dd format, or 'recent' to get recent schedules
            var includeOnlyPublished = true;  // bool? | includeOnlyPublished (optional) 
            var expand = expand_example;  // string | expand (optional) 

            try
            { 
                // Get the list of week schedules for the specified week
                BuScheduleListing result = apiInstance.GetWorkforcemanagementBusinessunitWeekSchedules(businessUnitId, weekId, includeOnlyPublished, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitWeekSchedules: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **weekId** | **string**| First day of schedule week in yyyy-MM-dd format, or &#39;recent&#39; to get recent schedules |  |
| **includeOnlyPublished** | **bool?**| includeOnlyPublished | [optional]  |
| **expand** | **string**| expand | [optional] <br />**Values**: forecast.description |
{: class="table table-striped"}

### Return type

[**BuScheduleListing**](BuScheduleListing.html)

<a name="getworkforcemanagementbusinessunitweekshorttermforecast"></a>

## [**BuShortTermForecast**](BuShortTermForecast.html) GetWorkforcemanagementBusinessunitWeekShorttermforecast (string businessUnitId, DateTime? weekDateId, string forecastId, List<string> expand = null)



Get a short term forecast



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
    public class GetWorkforcemanagementBusinessunitWeekShorttermforecastExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The business unit ID of the business unit to which the forecast belongs
            var weekDateId = 2013-10-20;  // DateTime? | The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var forecastId = forecastId_example;  // string | The ID of the forecast
            var expand = new List<string>(); // List<string> |  (optional) 

            try
            { 
                // Get a short term forecast
                BuShortTermForecast result = apiInstance.GetWorkforcemanagementBusinessunitWeekShorttermforecast(businessUnitId, weekDateId, forecastId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitWeekShorttermforecast: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The business unit ID of the business unit to which the forecast belongs |  |
| **weekDateId** | **DateTime?**| The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **forecastId** | **string**| The ID of the forecast |  |
| **expand** | [**List<string>**](string.html)|  | [optional] <br />**Values**: planningGroups, generationResults |
{: class="table table-striped"}

### Return type

[**BuShortTermForecast**](BuShortTermForecast.html)

<a name="getworkforcemanagementbusinessunitweekshorttermforecastdata"></a>

## [**BuForecastResultResponse**](BuForecastResultResponse.html) GetWorkforcemanagementBusinessunitWeekShorttermforecastData (string businessUnitId, DateTime? weekDateId, string forecastId, int? weekNumber = null, bool? forceDownloadService = null)



Get the result of a short term forecast calculation

Includes modifications unless you pass the doNotApplyModifications query parameter

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
    public class GetWorkforcemanagementBusinessunitWeekShorttermforecastDataExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The business unit ID of the business unit to which the forecast belongs
            var weekDateId = 2013-10-20;  // DateTime? | The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var forecastId = forecastId_example;  // string | The ID of the forecast
            var weekNumber = 56;  // int? | The week number to fetch (for multi-week forecasts) (optional) 
            var forceDownloadService = true;  // bool? | Force the result of this operation to be sent via download service.  For testing/app development purposes (optional) 

            try
            { 
                // Get the result of a short term forecast calculation
                BuForecastResultResponse result = apiInstance.GetWorkforcemanagementBusinessunitWeekShorttermforecastData(businessUnitId, weekDateId, forecastId, weekNumber, forceDownloadService);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitWeekShorttermforecastData: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The business unit ID of the business unit to which the forecast belongs |  |
| **weekDateId** | **DateTime?**| The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **forecastId** | **string**| The ID of the forecast |  |
| **weekNumber** | **int?**| The week number to fetch (for multi-week forecasts) | [optional]  |
| **forceDownloadService** | **bool?**| Force the result of this operation to be sent via download service.  For testing/app development purposes | [optional]  |
{: class="table table-striped"}

### Return type

[**BuForecastResultResponse**](BuForecastResultResponse.html)

<a name="getworkforcemanagementbusinessunitweekshorttermforecastgenerationresults"></a>

## [**BuForecastGenerationResult**](BuForecastGenerationResult.html) GetWorkforcemanagementBusinessunitWeekShorttermforecastGenerationresults (string businessUnitId, DateTime? weekDateId, string forecastId)



Gets the forecast generation results



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
    public class GetWorkforcemanagementBusinessunitWeekShorttermforecastGenerationresultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The business unit ID of the business unit to which the forecast belongs
            var weekDateId = 2013-10-20;  // DateTime? | The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var forecastId = forecastId_example;  // string | The ID of the forecast

            try
            { 
                // Gets the forecast generation results
                BuForecastGenerationResult result = apiInstance.GetWorkforcemanagementBusinessunitWeekShorttermforecastGenerationresults(businessUnitId, weekDateId, forecastId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitWeekShorttermforecastGenerationresults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The business unit ID of the business unit to which the forecast belongs |  |
| **weekDateId** | **DateTime?**| The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **forecastId** | **string**| The ID of the forecast |  |
{: class="table table-striped"}

### Return type

[**BuForecastGenerationResult**](BuForecastGenerationResult.html)

<a name="getworkforcemanagementbusinessunitweekshorttermforecastplanninggroups"></a>

## [**ForecastPlanningGroupsResponse**](ForecastPlanningGroupsResponse.html) GetWorkforcemanagementBusinessunitWeekShorttermforecastPlanninggroups (string businessUnitId, DateTime? weekDateId, string forecastId)



Gets the forecast planning group snapshot



Requires ANY permissions: 

* wfm:shortTermForecast:view
* wfm:schedule:view
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
    public class GetWorkforcemanagementBusinessunitWeekShorttermforecastPlanninggroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The business unit ID of the business unit to which the forecast belongs
            var weekDateId = 2013-10-20;  // DateTime? | The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var forecastId = forecastId_example;  // string | The ID of the forecast

            try
            { 
                // Gets the forecast planning group snapshot
                ForecastPlanningGroupsResponse result = apiInstance.GetWorkforcemanagementBusinessunitWeekShorttermforecastPlanninggroups(businessUnitId, weekDateId, forecastId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitWeekShorttermforecastPlanninggroups: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The business unit ID of the business unit to which the forecast belongs |  |
| **weekDateId** | **DateTime?**| The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **forecastId** | **string**| The ID of the forecast |  |
{: class="table table-striped"}

### Return type

[**ForecastPlanningGroupsResponse**](ForecastPlanningGroupsResponse.html)

<a name="getworkforcemanagementbusinessunitweekshorttermforecasts"></a>

## [**BuShortTermForecastListing**](BuShortTermForecastListing.html) GetWorkforcemanagementBusinessunitWeekShorttermforecasts (string businessUnitId, string weekDateId)



Get short term forecasts

Use \"recent\" for the `weekDateId` path parameter to fetch all forecasts for +/- 26 weeks from the current date. Response will include any forecast which spans the specified week

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
    public class GetWorkforcemanagementBusinessunitWeekShorttermforecastsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The business unit ID of the business unit to which the forecast belongs
            var weekDateId = weekDateId_example;  // string | The week start date of the forecast in yyyy-MM-dd format or 'recent' to fetch recent forecasts

            try
            { 
                // Get short term forecasts
                BuShortTermForecastListing result = apiInstance.GetWorkforcemanagementBusinessunitWeekShorttermforecasts(businessUnitId, weekDateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitWeekShorttermforecasts: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The business unit ID of the business unit to which the forecast belongs |  |
| **weekDateId** | **string**| The week start date of the forecast in yyyy-MM-dd format or &#39;recent&#39; to fetch recent forecasts |  |
{: class="table table-striped"}

### Return type

[**BuShortTermForecastListing**](BuShortTermForecastListing.html)

<a name="getworkforcemanagementbusinessunits"></a>

## [**BusinessUnitListing**](BusinessUnitListing.html) GetWorkforcemanagementBusinessunits (string feature = null, string divisionId = null)



Get business units



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
    public class GetWorkforcemanagementBusinessunitsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var feature = feature_example;  // string |  (optional) 
            var divisionId = divisionId_example;  // string |  (optional) 

            try
            { 
                // Get business units
                BusinessUnitListing result = apiInstance.GetWorkforcemanagementBusinessunits(feature, divisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunits: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **feature** | **string**|  | [optional] <br />**Values**: AgentSchedule, AgentTimeOffRequest, ActivityCodes, Agents, BusinessUnitActivityCodes, BusinessUnits, HistoricalAdherence, IntradayMonitoring, BuIntradayMonitoring, ManagementUnits, RealTimeAdherence, Schedules, BuSchedules, ServiceGoalGroups, ServiceGoalTemplates, PlanningGroups, ShiftTrading, ShortTermForecasts, BuShortTermForecasts, TimeOffRequests, WorkPlans |
| **divisionId** | **string**|  | [optional]  |
{: class="table table-striped"}

### Return type

[**BusinessUnitListing**](BusinessUnitListing.html)

<a name="getworkforcemanagementbusinessunitsdivisionviews"></a>

## [**BusinessUnitListing**](BusinessUnitListing.html) GetWorkforcemanagementBusinessunitsDivisionviews (List<string> divisionId = null)



Get business units across divisions



Requires ANY permissions: 

* wfm:businessUnit:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementBusinessunitsDivisionviewsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var divisionId = new List<string>(); // List<string> | The divisionIds to filter by. If omitted, will return business units in all divisions (optional) 

            try
            { 
                // Get business units across divisions
                BusinessUnitListing result = apiInstance.GetWorkforcemanagementBusinessunitsDivisionviews(divisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitsDivisionviews: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **divisionId** | [**List<string>**](string.html)| The divisionIds to filter by. If omitted, will return business units in all divisions | [optional]  |
{: class="table table-striped"}

### Return type

[**BusinessUnitListing**](BusinessUnitListing.html)

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
* wfm:serviceGoalTemplate:add
* wfm:serviceGoalTemplate:delete
* wfm:serviceGoalTemplate:edit
* wfm:serviceGoalTemplate:view
* wfm:planningGroup:add
* wfm:planningGroup:delete
* wfm:planningGroup:edit
* wfm:planningGroup:view
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

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

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

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

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

<a name="getworkforcemanagementmanagementunitadherence"></a>

## [**UserScheduleAdherenceListing**](UserScheduleAdherenceListing.html) GetWorkforcemanagementManagementunitAdherence (string managementUnitId, bool? forceDownloadService = null)



Get a list of user schedule adherence records for the requested management unit



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
    public class GetWorkforcemanagementManagementunitAdherenceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The management unit ID of the management unit.
            var forceDownloadService = true;  // bool? | Force the result of this operation to be sent via download service.  For testing/app development purposes (optional) 

            try
            { 
                // Get a list of user schedule adherence records for the requested management unit
                UserScheduleAdherenceListing result = apiInstance.GetWorkforcemanagementManagementunitAdherence(managementUnitId, forceDownloadService);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitAdherence: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The management unit ID of the management unit. |  |
| **forceDownloadService** | **bool?**| Force the result of this operation to be sent via download service.  For testing/app development purposes | [optional]  |
{: class="table table-striped"}

### Return type

[**UserScheduleAdherenceListing**](UserScheduleAdherenceListing.html)

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

<a name="getworkforcemanagementmanagementunitagentshifttrades"></a>

## [**ShiftTradeListResponse**](ShiftTradeListResponse.html) GetWorkforcemanagementManagementunitAgentShifttrades (string managementUnitId, string agentId)



Gets all the shift trades for a given agent



Requires ANY permissions: 

* wfm:shiftTradeRequest:edit
* wfm:shiftTradeRequest:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitAgentShifttradesExample
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
                // Gets all the shift trades for a given agent
                ShiftTradeListResponse result = apiInstance.GetWorkforcemanagementManagementunitAgentShifttrades(managementUnitId, agentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitAgentShifttrades: " + e.Message );
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

[**ShiftTradeListResponse**](ShiftTradeListResponse.html)

<a name="getworkforcemanagementmanagementunitintradayqueues"></a>

## void GetWorkforcemanagementManagementunitIntradayQueues (string muId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gone.  Moved under business units



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
    public class GetWorkforcemanagementManagementunitIntradayQueuesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The management unit ID of the management unit

            try
            { 
                // Gone.  Moved under business units
                apiInstance.GetWorkforcemanagementManagementunitIntradayQueues(muId);
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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getworkforcemanagementmanagementunitschedulingrun"></a>

## void GetWorkforcemanagementManagementunitSchedulingRun (string managementUnitId, string runId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gone.  Scheduling has moved under business units



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
    public class GetWorkforcemanagementManagementunitSchedulingRunExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | (Deprecated/gone): The ID of the management unit.
            var runId = runId_example;  // string | The ID of the schedule run

            try
            { 
                // Gone.  Scheduling has moved under business units
                apiInstance.GetWorkforcemanagementManagementunitSchedulingRun(managementUnitId, runId);
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
| **managementUnitId** | **string**| (Deprecated/gone): The ID of the management unit. |  |
| **runId** | **string**| The ID of the schedule run |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getworkforcemanagementmanagementunitschedulingrunresult"></a>

## void GetWorkforcemanagementManagementunitSchedulingRunResult (string managementUnitId, string runId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gone.  Scheduling has moved under business units



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
    public class GetWorkforcemanagementManagementunitSchedulingRunResultExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | (Deprecated/gone): The ID of the management unit.
            var runId = runId_example;  // string | The ID of the schedule run

            try
            { 
                // Gone.  Scheduling has moved under business units
                apiInstance.GetWorkforcemanagementManagementunitSchedulingRunResult(managementUnitId, runId);
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
| **managementUnitId** | **string**| (Deprecated/gone): The ID of the management unit. |  |
| **runId** | **string**| The ID of the schedule run |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getworkforcemanagementmanagementunitschedulingruns"></a>

## void GetWorkforcemanagementManagementunitSchedulingRuns (string managementUnitId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gone.  Scheduling has moved under business units



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
    public class GetWorkforcemanagementManagementunitSchedulingRunsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | (Deprecated/gone): The ID of the management unit.

            try
            { 
                // Gone.  Scheduling has moved under business units
                apiInstance.GetWorkforcemanagementManagementunitSchedulingRuns(managementUnitId);
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
| **managementUnitId** | **string**| (Deprecated/gone): The ID of the management unit. |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getworkforcemanagementmanagementunitservicegoalgroup"></a>

## void GetWorkforcemanagementManagementunitServicegoalgroup (string managementUnitId, string serviceGoalGroupId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gone. Replaced with service goal templates and planning groups under business units



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
    public class GetWorkforcemanagementManagementunitServicegoalgroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | (Deprecated/gone): The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var serviceGoalGroupId = serviceGoalGroupId_example;  // string | Gone.  The ID of the service goal group to fetch

            try
            { 
                // Gone. Replaced with service goal templates and planning groups under business units
                apiInstance.GetWorkforcemanagementManagementunitServicegoalgroup(managementUnitId, serviceGoalGroupId);
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
| **managementUnitId** | **string**| (Deprecated/gone): The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **serviceGoalGroupId** | **string**| Gone.  The ID of the service goal group to fetch |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getworkforcemanagementmanagementunitservicegoalgroups"></a>

## void GetWorkforcemanagementManagementunitServicegoalgroups (string managementUnitId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gone. Replaced with service goal templates and planning groups under business units



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
    public class GetWorkforcemanagementManagementunitServicegoalgroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | (Deprecated/gone): The ID of the management unit, or 'mine' for the management unit of the logged-in user.

            try
            { 
                // Gone. Replaced with service goal templates and planning groups under business units
                apiInstance.GetWorkforcemanagementManagementunitServicegoalgroups(managementUnitId);
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
| **managementUnitId** | **string**| (Deprecated/gone): The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getworkforcemanagementmanagementunitsettings"></a>

## void GetWorkforcemanagementManagementunitSettings (string muId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gone. Get management unit settings via expand parameters on the GET management unit



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
                // Gone. Get management unit settings via expand parameters on the GET management unit
                apiInstance.GetWorkforcemanagementManagementunitSettings(muId);
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

void (empty response body)

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

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Deprecated.  Use the equivalent business unit resource instead. Get a week schedule



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
                // Deprecated.  Use the equivalent business unit resource instead. Get a week schedule
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

## void GetWorkforcemanagementManagementunitWeekScheduleGenerationresults (string managementUnitId, string weekId, string scheduleId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gone.  Scheduling has moved under business units



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
    public class GetWorkforcemanagementManagementunitWeekScheduleGenerationresultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var weekId = weekId_example;  // string | First day of schedule week in yyyy-MM-dd format.
            var scheduleId = scheduleId_example;  // string | Gone/deprecated. The ID of the schedule to fetch generation results

            try
            { 
                // Gone.  Scheduling has moved under business units
                apiInstance.GetWorkforcemanagementManagementunitWeekScheduleGenerationresults(managementUnitId, weekId, scheduleId);
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
| **scheduleId** | **string**| Gone/deprecated. The ID of the schedule to fetch generation results |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getworkforcemanagementmanagementunitweekschedules"></a>

## [**WeekScheduleListResponse**](WeekScheduleListResponse.html) GetWorkforcemanagementManagementunitWeekSchedules (string managementUnitId, string weekId, bool? includeOnlyPublished = null, string earliestWeekDate = null, string latestWeekDate = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Deprecated.  Use the equivalent business unit resource instead. Get the list of schedules in a week in management unit



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
                // Deprecated.  Use the equivalent business unit resource instead. Get the list of schedules in a week in management unit
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

<a name="getworkforcemanagementmanagementunitweekshifttrades"></a>

## [**WeekShiftTradeListResponse**](WeekShiftTradeListResponse.html) GetWorkforcemanagementManagementunitWeekShifttrades (string managementUnitId, DateTime? weekDateId, bool? evaluateMatches = null)



Gets all the shift trades for a given week



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
    public class GetWorkforcemanagementManagementunitWeekShifttradesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The management unit ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var weekDateId = 2013-10-20;  // DateTime? | The start date of the week schedule in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var evaluateMatches = true;  // bool? | Whether to evaluate the matches for violations (optional)  (default to true)

            try
            { 
                // Gets all the shift trades for a given week
                WeekShiftTradeListResponse result = apiInstance.GetWorkforcemanagementManagementunitWeekShifttrades(managementUnitId, weekDateId, evaluateMatches);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitWeekShifttrades: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **weekDateId** | **DateTime?**| The start date of the week schedule in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **evaluateMatches** | **bool?**| Whether to evaluate the matches for violations | [optional] [default to true] |
{: class="table table-striped"}

### Return type

[**WeekShiftTradeListResponse**](WeekShiftTradeListResponse.html)

<a name="getworkforcemanagementmanagementunitweekshorttermforecastfinal"></a>

## void GetWorkforcemanagementManagementunitWeekShorttermforecastFinal (string managementUnitId, string weekDateId, string forecastId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gone. Use equivalent business unit resource instead



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
    public class GetWorkforcemanagementManagementunitWeekShorttermforecastFinalExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | (Deprecated/gone): The id of the management unit.
            var weekDateId = weekDateId_example;  // string | (Deprecated/gone): The week start date of the forecast in yyyy-MM-dd format
            var forecastId = forecastId_example;  // string | (Gone/Deprecated): The ID of the forecast

            try
            { 
                // Gone. Use equivalent business unit resource instead
                apiInstance.GetWorkforcemanagementManagementunitWeekShorttermforecastFinal(managementUnitId, weekDateId, forecastId);
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
| **managementUnitId** | **string**| (Deprecated/gone): The id of the management unit. |  |
| **weekDateId** | **string**| (Deprecated/gone): The week start date of the forecast in yyyy-MM-dd format |  |
| **forecastId** | **string**| (Gone/Deprecated): The ID of the forecast |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getworkforcemanagementmanagementunitweekshorttermforecasts"></a>

## void GetWorkforcemanagementManagementunitWeekShorttermforecasts (string managementUnitId, string weekDateId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gone. Use equivalent business unit resource instead



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
    public class GetWorkforcemanagementManagementunitWeekShorttermforecastsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | (Deprecated/gone): The id of the management unit.
            var weekDateId = weekDateId_example;  // string | (Deprecated/gone): The week start date of the forecast in yyyy-MM-dd format

            try
            { 
                // Gone. Use equivalent business unit resource instead
                apiInstance.GetWorkforcemanagementManagementunitWeekShorttermforecasts(managementUnitId, weekDateId);
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
| **managementUnitId** | **string**| (Deprecated/gone): The id of the management unit. |  |
| **weekDateId** | **string**| (Deprecated/gone): The week start date of the forecast in yyyy-MM-dd format |  |
{: class="table table-striped"}

### Return type

void (empty response body)

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
| **feature** | **string**|  | [optional] <br />**Values**: AgentSchedule, AgentTimeOffRequest, ActivityCodes, Agents, BusinessUnitActivityCodes, BusinessUnits, HistoricalAdherence, IntradayMonitoring, BuIntradayMonitoring, ManagementUnits, RealTimeAdherence, Schedules, BuSchedules, ServiceGoalGroups, ServiceGoalTemplates, PlanningGroups, ShiftTrading, ShortTermForecasts, BuShortTermForecasts, TimeOffRequests, WorkPlans |
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

<a name="patchworkforcemanagementbusinessunit"></a>

## [**BusinessUnit**](BusinessUnit.html) PatchWorkforcemanagementBusinessunit (string businessUnitId, UpdateBusinessUnitRequest body = null)



Update business unit



Requires ANY permissions: 

* wfm:businessUnit:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchWorkforcemanagementBusinessunitExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit, or 'mine' for the business unit of the logged-in user.
            var body = new UpdateBusinessUnitRequest(); // UpdateBusinessUnitRequest | body (optional) 

            try
            { 
                // Update business unit
                BusinessUnit result = apiInstance.PatchWorkforcemanagementBusinessunit(businessUnitId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementBusinessunit: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit, or &#39;mine&#39; for the business unit of the logged-in user. |  |
| **body** | [**UpdateBusinessUnitRequest**](UpdateBusinessUnitRequest.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**BusinessUnit**](BusinessUnit.html)

<a name="patchworkforcemanagementbusinessunitactivitycode"></a>

## [**BusinessUnitActivityCode**](BusinessUnitActivityCode.html) PatchWorkforcemanagementBusinessunitActivitycode (string buId, string acId, UpdateActivityCodeRequest body = null)



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
    public class PatchWorkforcemanagementBusinessunitActivitycodeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var buId = buId_example;  // string | The ID of the business unit, or 'mine' for the business unit of the logged-in user.
            var acId = acId_example;  // string | The ID of the activity code to update
            var body = new UpdateActivityCodeRequest(); // UpdateActivityCodeRequest | body (optional) 

            try
            { 
                // Update an activity code
                BusinessUnitActivityCode result = apiInstance.PatchWorkforcemanagementBusinessunitActivitycode(buId, acId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementBusinessunitActivitycode: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **buId** | **string**| The ID of the business unit, or &#39;mine&#39; for the business unit of the logged-in user. |  |
| **acId** | **string**| The ID of the activity code to update |  |
| **body** | [**UpdateActivityCodeRequest**](UpdateActivityCodeRequest.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**BusinessUnitActivityCode**](BusinessUnitActivityCode.html)

<a name="patchworkforcemanagementbusinessunitplanninggroup"></a>

## [**PlanningGroup**](PlanningGroup.html) PatchWorkforcemanagementBusinessunitPlanninggroup (string businessUnitId, string planningGroupId, UpdatePlanningGroupRequest body = null)



Updates the planning group



Requires ANY permissions: 

* wfm:planningGroup:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchWorkforcemanagementBusinessunitPlanninggroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit.
            var planningGroupId = planningGroupId_example;  // string | The ID of a planning group to update
            var body = new UpdatePlanningGroupRequest(); // UpdatePlanningGroupRequest | body (optional) 

            try
            { 
                // Updates the planning group
                PlanningGroup result = apiInstance.PatchWorkforcemanagementBusinessunitPlanninggroup(businessUnitId, planningGroupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementBusinessunitPlanninggroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit. |  |
| **planningGroupId** | **string**| The ID of a planning group to update |  |
| **body** | [**UpdatePlanningGroupRequest**](UpdatePlanningGroupRequest.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**PlanningGroup**](PlanningGroup.html)

<a name="patchworkforcemanagementbusinessunitschedulingrun"></a>

## void PatchWorkforcemanagementBusinessunitSchedulingRun (string businessUnitId, string runId, PatchBuScheduleRunRequest body = null)



Mark a schedule run as applied



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
    public class PatchWorkforcemanagementBusinessunitSchedulingRunExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var runId = runId_example;  // string | The ID of the schedule run
            var body = new PatchBuScheduleRunRequest(); // PatchBuScheduleRunRequest | body (optional) 

            try
            { 
                // Mark a schedule run as applied
                apiInstance.PatchWorkforcemanagementBusinessunitSchedulingRun(businessUnitId, runId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementBusinessunitSchedulingRun: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **runId** | **string**| The ID of the schedule run |  |
| **body** | [**PatchBuScheduleRunRequest**](PatchBuScheduleRunRequest.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchworkforcemanagementbusinessunitservicegoaltemplate"></a>

## [**ServiceGoalTemplate**](ServiceGoalTemplate.html) PatchWorkforcemanagementBusinessunitServicegoaltemplate (string businessUnitId, string serviceGoalTemplateId, UpdateServiceGoalTemplate body = null)



Updates a service goal template



Requires ANY permissions: 

* wfm:serviceGoalTemplate:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchWorkforcemanagementBusinessunitServicegoaltemplateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit.
            var serviceGoalTemplateId = serviceGoalTemplateId_example;  // string | The ID of a service goal template to update
            var body = new UpdateServiceGoalTemplate(); // UpdateServiceGoalTemplate | body (optional) 

            try
            { 
                // Updates a service goal template
                ServiceGoalTemplate result = apiInstance.PatchWorkforcemanagementBusinessunitServicegoaltemplate(businessUnitId, serviceGoalTemplateId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementBusinessunitServicegoaltemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit. |  |
| **serviceGoalTemplateId** | **string**| The ID of a service goal template to update |  |
| **body** | [**UpdateServiceGoalTemplate**](UpdateServiceGoalTemplate.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**ServiceGoalTemplate**](ServiceGoalTemplate.html)

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

## void PatchWorkforcemanagementManagementunitActivitycode (string muId, string acId, UpdateActivityCodeRequest body = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Deprecated/Gone: Use the new business unit activity code resources



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
                // Deprecated/Gone: Use the new business unit activity code resources
                apiInstance.PatchWorkforcemanagementManagementunitActivitycode(muId, acId, body);
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

void (empty response body)

<a name="patchworkforcemanagementmanagementunitschedulingrun"></a>

## void PatchWorkforcemanagementManagementunitSchedulingRun (string managementUnitId, string runId, UpdateSchedulingRunRequest body = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gone.  Scheduling has moved under business units



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
    public class PatchWorkforcemanagementManagementunitSchedulingRunExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | (Deprecated/gone): The ID of the management unit.
            var runId = runId_example;  // string | The ID of the schedule run
            var body = new UpdateSchedulingRunRequest(); // UpdateSchedulingRunRequest | body (optional) 

            try
            { 
                // Gone.  Scheduling has moved under business units
                apiInstance.PatchWorkforcemanagementManagementunitSchedulingRun(managementUnitId, runId, body);
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
| **managementUnitId** | **string**| (Deprecated/gone): The ID of the management unit. |  |
| **runId** | **string**| The ID of the schedule run |  |
| **body** | [**UpdateSchedulingRunRequest**](UpdateSchedulingRunRequest.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchworkforcemanagementmanagementunitservicegoalgroup"></a>

## void PatchWorkforcemanagementManagementunitServicegoalgroup (string managementUnitId, string serviceGoalGroupId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gone. Replaced with service goal templates and planning groups under business units



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
    public class PatchWorkforcemanagementManagementunitServicegoalgroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | (Deprecated/gone): The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var serviceGoalGroupId = serviceGoalGroupId_example;  // string | Gone. The ID of the service goal group to update

            try
            { 
                // Gone. Replaced with service goal templates and planning groups under business units
                apiInstance.PatchWorkforcemanagementManagementunitServicegoalgroup(managementUnitId, serviceGoalGroupId);
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
| **managementUnitId** | **string**| (Deprecated/gone): The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **serviceGoalGroupId** | **string**| Gone. The ID of the service goal group to update |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchworkforcemanagementmanagementunitsettings"></a>

## void PatchWorkforcemanagementManagementunitSettings (string muId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gone. Update settings by PATCHing the management unit



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
    public class PatchWorkforcemanagementManagementunitSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.

            try
            { 
                // Gone. Update settings by PATCHing the management unit
                apiInstance.PatchWorkforcemanagementManagementunitSettings(muId);
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
{: class="table table-striped"}

### Return type

void (empty response body)

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

## void PatchWorkforcemanagementManagementunitWeekSchedule (string managementUnitId, string weekId, string scheduleId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gone.  Scheduling has moved under business units



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
    public class PatchWorkforcemanagementManagementunitWeekScheduleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var weekId = weekId_example;  // string | First day of schedule week in yyyy-MM-dd format.
            var scheduleId = scheduleId_example;  // string | Gone/deprecated. The ID of the schedule to update. Use partial uploads of user schedules if activity count in schedule is greater than 17500

            try
            { 
                // Gone.  Scheduling has moved under business units
                apiInstance.PatchWorkforcemanagementManagementunitWeekSchedule(managementUnitId, weekId, scheduleId);
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
| **scheduleId** | **string**| Gone/deprecated. The ID of the schedule to update. Use partial uploads of user schedules if activity count in schedule is greater than 17500 |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchworkforcemanagementmanagementunitweekshifttrade"></a>

## [**ShiftTradeResponse**](ShiftTradeResponse.html) PatchWorkforcemanagementManagementunitWeekShifttrade (string managementUnitId, DateTime? weekDateId, PatchShiftTradeRequest body, string tradeId)



Updates a shift trade. This route can only be called by the initiating agent



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
    public class PatchWorkforcemanagementManagementunitWeekShifttradeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The management unit ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var weekDateId = 2013-10-20;  // DateTime? | The start date of the week schedule in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var body = new PatchShiftTradeRequest(); // PatchShiftTradeRequest | body
            var tradeId = tradeId_example;  // string | The ID of the shift trade to update

            try
            { 
                // Updates a shift trade. This route can only be called by the initiating agent
                ShiftTradeResponse result = apiInstance.PatchWorkforcemanagementManagementunitWeekShifttrade(managementUnitId, weekDateId, body, tradeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementManagementunitWeekShifttrade: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **weekDateId** | **DateTime?**| The start date of the week schedule in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **body** | [**PatchShiftTradeRequest**](PatchShiftTradeRequest.html)| body |  |
| **tradeId** | **string**| The ID of the shift trade to update |  |
{: class="table table-striped"}

### Return type

[**ShiftTradeResponse**](ShiftTradeResponse.html)

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

<a name="postworkforcemanagementagentschedulesmine"></a>

## [**BuCurrentAgentScheduleSearchResponse**](BuCurrentAgentScheduleSearchResponse.html) PostWorkforcemanagementAgentschedulesMine (BuGetCurrentAgentScheduleRequest body = null)



Get published schedule for the current user



Requires ANY permissions: 

* wfm:agentSchedule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementAgentschedulesMineExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var body = new BuGetCurrentAgentScheduleRequest(); // BuGetCurrentAgentScheduleRequest | body (optional) 

            try
            { 
                // Get published schedule for the current user
                BuCurrentAgentScheduleSearchResponse result = apiInstance.PostWorkforcemanagementAgentschedulesMine(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementAgentschedulesMine: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**BuGetCurrentAgentScheduleRequest**](BuGetCurrentAgentScheduleRequest.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**BuCurrentAgentScheduleSearchResponse**](BuCurrentAgentScheduleSearchResponse.html)

<a name="postworkforcemanagementbusinessunitactivitycodes"></a>

## [**BusinessUnitActivityCode**](BusinessUnitActivityCode.html) PostWorkforcemanagementBusinessunitActivitycodes (string buId, CreateActivityCodeRequest body = null)



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
    public class PostWorkforcemanagementBusinessunitActivitycodesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var buId = buId_example;  // string | The ID of the business unit, or 'mine' for the business unit of the logged-in user.
            var body = new CreateActivityCodeRequest(); // CreateActivityCodeRequest | body (optional) 

            try
            { 
                // Create a new activity code
                BusinessUnitActivityCode result = apiInstance.PostWorkforcemanagementBusinessunitActivitycodes(buId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitActivitycodes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **buId** | **string**| The ID of the business unit, or &#39;mine&#39; for the business unit of the logged-in user. |  |
| **body** | [**CreateActivityCodeRequest**](CreateActivityCodeRequest.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**BusinessUnitActivityCode**](BusinessUnitActivityCode.html)

<a name="postworkforcemanagementbusinessunitagentschedulessearch"></a>

## [**BuAsyncAgentSchedulesSearchResponse**](BuAsyncAgentSchedulesSearchResponse.html) PostWorkforcemanagementBusinessunitAgentschedulesSearch (string businessUnitId, BuSearchAgentSchedulesRequest body = null, bool? forceAsync = null, bool? forceDownloadService = null)



Search published schedules



Requires ANY permissions: 

* wfm:schedule:view
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
    public class PostWorkforcemanagementBusinessunitAgentschedulesSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var body = new BuSearchAgentSchedulesRequest(); // BuSearchAgentSchedulesRequest | body (optional) 
            var forceAsync = true;  // bool? | Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional) 
            var forceDownloadService = true;  // bool? | Force the result of this operation to be sent via download service.  For testing/app development purposes (optional) 

            try
            { 
                // Search published schedules
                BuAsyncAgentSchedulesSearchResponse result = apiInstance.PostWorkforcemanagementBusinessunitAgentschedulesSearch(businessUnitId, body, forceAsync, forceDownloadService);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitAgentschedulesSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **body** | [**BuSearchAgentSchedulesRequest**](BuSearchAgentSchedulesRequest.html)| body | [optional]  |
| **forceAsync** | **bool?**| Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes | [optional]  |
| **forceDownloadService** | **bool?**| Force the result of this operation to be sent via download service.  For testing/app development purposes | [optional]  |
{: class="table table-striped"}

### Return type

[**BuAsyncAgentSchedulesSearchResponse**](BuAsyncAgentSchedulesSearchResponse.html)

<a name="postworkforcemanagementbusinessunitintraday"></a>

## [**AsyncIntradayResponse**](AsyncIntradayResponse.html) PostWorkforcemanagementBusinessunitIntraday (string businessUnitId, bool? forceAsync = null, IntradayPlanningGroupRequest body = null)



Get intraday data for the given date for the requested planningGroupIds



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
    public class PostWorkforcemanagementBusinessunitIntradayExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The business unit ID of the business unit
            var forceAsync = true;  // bool? | Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional) 
            var body = new IntradayPlanningGroupRequest(); // IntradayPlanningGroupRequest | body (optional) 

            try
            { 
                // Get intraday data for the given date for the requested planningGroupIds
                AsyncIntradayResponse result = apiInstance.PostWorkforcemanagementBusinessunitIntraday(businessUnitId, forceAsync, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitIntraday: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The business unit ID of the business unit |  |
| **forceAsync** | **bool?**| Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes | [optional]  |
| **body** | [**IntradayPlanningGroupRequest**](IntradayPlanningGroupRequest.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**AsyncIntradayResponse**](AsyncIntradayResponse.html)

<a name="postworkforcemanagementbusinessunitplanninggroups"></a>

## [**PlanningGroup**](PlanningGroup.html) PostWorkforcemanagementBusinessunitPlanninggroups (string businessUnitId, CreatePlanningGroupRequest body = null)



Adds a new planning group



Requires ANY permissions: 

* wfm:planningGroup:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementBusinessunitPlanninggroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit.
            var body = new CreatePlanningGroupRequest(); // CreatePlanningGroupRequest | body (optional) 

            try
            { 
                // Adds a new planning group
                PlanningGroup result = apiInstance.PostWorkforcemanagementBusinessunitPlanninggroups(businessUnitId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitPlanninggroups: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit. |  |
| **body** | [**CreatePlanningGroupRequest**](CreatePlanningGroupRequest.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**PlanningGroup**](PlanningGroup.html)

<a name="postworkforcemanagementbusinessunitservicegoaltemplates"></a>

## [**ServiceGoalTemplate**](ServiceGoalTemplate.html) PostWorkforcemanagementBusinessunitServicegoaltemplates (string businessUnitId, CreateServiceGoalTemplate body = null)



Adds a new service goal template



Requires ANY permissions: 

* wfm:serviceGoalTemplate:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementBusinessunitServicegoaltemplatesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit.
            var body = new CreateServiceGoalTemplate(); // CreateServiceGoalTemplate | body (optional) 

            try
            { 
                // Adds a new service goal template
                ServiceGoalTemplate result = apiInstance.PostWorkforcemanagementBusinessunitServicegoaltemplates(businessUnitId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitServicegoaltemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit. |  |
| **body** | [**CreateServiceGoalTemplate**](CreateServiceGoalTemplate.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**ServiceGoalTemplate**](ServiceGoalTemplate.html)

<a name="postworkforcemanagementbusinessunitweekscheduleagentschedulesquery"></a>

## [**BuAsyncAgentSchedulesQueryResponse**](BuAsyncAgentSchedulesQueryResponse.html) PostWorkforcemanagementBusinessunitWeekScheduleAgentschedulesQuery (string businessUnitId, DateTime? weekId, string scheduleId, BuQueryAgentSchedulesRequest body, bool? forceAsync = null, bool? forceDownloadService = null)



Loads agent schedule data from the schedule. Used in combination with the metadata route



Requires ANY permissions: 

* wfm:schedule:view
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
    public class PostWorkforcemanagementBusinessunitWeekScheduleAgentschedulesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var weekId = 2013-10-20;  // DateTime? | First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var scheduleId = scheduleId_example;  // string | The ID of the schedule
            var body = new BuQueryAgentSchedulesRequest(); // BuQueryAgentSchedulesRequest | body
            var forceAsync = true;  // bool? | Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional) 
            var forceDownloadService = true;  // bool? | Force the result of this operation to be sent via download service.  For testing/app development purposes (optional) 

            try
            { 
                // Loads agent schedule data from the schedule. Used in combination with the metadata route
                BuAsyncAgentSchedulesQueryResponse result = apiInstance.PostWorkforcemanagementBusinessunitWeekScheduleAgentschedulesQuery(businessUnitId, weekId, scheduleId, body, forceAsync, forceDownloadService);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitWeekScheduleAgentschedulesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **weekId** | **DateTime?**| First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **scheduleId** | **string**| The ID of the schedule |  |
| **body** | [**BuQueryAgentSchedulesRequest**](BuQueryAgentSchedulesRequest.html)| body |  |
| **forceAsync** | **bool?**| Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes | [optional]  |
| **forceDownloadService** | **bool?**| Force the result of this operation to be sent via download service.  For testing/app development purposes | [optional]  |
{: class="table table-striped"}

### Return type

[**BuAsyncAgentSchedulesQueryResponse**](BuAsyncAgentSchedulesQueryResponse.html)

<a name="postworkforcemanagementbusinessunitweekschedulecopy"></a>

## [**BuAsyncScheduleResponse**](BuAsyncScheduleResponse.html) PostWorkforcemanagementBusinessunitWeekScheduleCopy (string businessUnitId, DateTime? weekId, string scheduleId, BuCopyScheduleRequest body)



Copy a schedule



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
    public class PostWorkforcemanagementBusinessunitWeekScheduleCopyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var weekId = 2013-10-20;  // DateTime? | First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var scheduleId = scheduleId_example;  // string | The ID of the schedule to copy
            var body = new BuCopyScheduleRequest(); // BuCopyScheduleRequest | body

            try
            { 
                // Copy a schedule
                BuAsyncScheduleResponse result = apiInstance.PostWorkforcemanagementBusinessunitWeekScheduleCopy(businessUnitId, weekId, scheduleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitWeekScheduleCopy: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **weekId** | **DateTime?**| First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **scheduleId** | **string**| The ID of the schedule to copy |  |
| **body** | [**BuCopyScheduleRequest**](BuCopyScheduleRequest.html)| body |  |
{: class="table table-striped"}

### Return type

[**BuAsyncScheduleResponse**](BuAsyncScheduleResponse.html)

<a name="postworkforcemanagementbusinessunitweekschedulereschedule"></a>

## [**BuAsyncScheduleRunResponse**](BuAsyncScheduleRunResponse.html) PostWorkforcemanagementBusinessunitWeekScheduleReschedule (string businessUnitId, DateTime? weekId, string scheduleId, BuRescheduleRequest body)



Start a rescheduling run



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
    public class PostWorkforcemanagementBusinessunitWeekScheduleRescheduleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var weekId = 2013-10-20;  // DateTime? | First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var scheduleId = scheduleId_example;  // string | The ID of the schedule
            var body = new BuRescheduleRequest(); // BuRescheduleRequest | body

            try
            { 
                // Start a rescheduling run
                BuAsyncScheduleRunResponse result = apiInstance.PostWorkforcemanagementBusinessunitWeekScheduleReschedule(businessUnitId, weekId, scheduleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitWeekScheduleReschedule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **weekId** | **DateTime?**| First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **scheduleId** | **string**| The ID of the schedule |  |
| **body** | [**BuRescheduleRequest**](BuRescheduleRequest.html)| body |  |
{: class="table table-striped"}

### Return type

[**BuAsyncScheduleRunResponse**](BuAsyncScheduleRunResponse.html)

<a name="postworkforcemanagementbusinessunitweekschedules"></a>

## [**BuScheduleMetadata**](BuScheduleMetadata.html) PostWorkforcemanagementBusinessunitWeekSchedules (string businessUnitId, DateTime? weekId, BuCreateBlankScheduleRequest body)



Create a blank schedule



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
    public class PostWorkforcemanagementBusinessunitWeekSchedulesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var weekId = 2013-10-20;  // DateTime? | First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var body = new BuCreateBlankScheduleRequest(); // BuCreateBlankScheduleRequest | body

            try
            { 
                // Create a blank schedule
                BuScheduleMetadata result = apiInstance.PostWorkforcemanagementBusinessunitWeekSchedules(businessUnitId, weekId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitWeekSchedules: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **weekId** | **DateTime?**| First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **body** | [**BuCreateBlankScheduleRequest**](BuCreateBlankScheduleRequest.html)| body |  |
{: class="table table-striped"}

### Return type

[**BuScheduleMetadata**](BuScheduleMetadata.html)

<a name="postworkforcemanagementbusinessunitweekschedulesgenerate"></a>

## [**BuAsyncScheduleRunResponse**](BuAsyncScheduleRunResponse.html) PostWorkforcemanagementBusinessunitWeekSchedulesGenerate (string businessUnitId, DateTime? weekId, BuGenerateScheduleRequest body)



Generate a schedule



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
    public class PostWorkforcemanagementBusinessunitWeekSchedulesGenerateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var weekId = 2013-10-20;  // DateTime? | First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var body = new BuGenerateScheduleRequest(); // BuGenerateScheduleRequest | body

            try
            { 
                // Generate a schedule
                BuAsyncScheduleRunResponse result = apiInstance.PostWorkforcemanagementBusinessunitWeekSchedulesGenerate(businessUnitId, weekId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitWeekSchedulesGenerate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **weekId** | **DateTime?**| First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **body** | [**BuGenerateScheduleRequest**](BuGenerateScheduleRequest.html)| body |  |
{: class="table table-striped"}

### Return type

[**BuAsyncScheduleRunResponse**](BuAsyncScheduleRunResponse.html)

<a name="postworkforcemanagementbusinessunitweekshorttermforecastcopy"></a>

## [**AsyncForecastOperationResult**](AsyncForecastOperationResult.html) PostWorkforcemanagementBusinessunitWeekShorttermforecastCopy (string businessUnitId, DateTime? weekDateId, string forecastId, CopyBuForecastRequest body, bool? forceAsync = null)



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
    public class PostWorkforcemanagementBusinessunitWeekShorttermforecastCopyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The business unit ID of the business unit to which the forecast belongs
            var weekDateId = 2013-10-20;  // DateTime? | The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var forecastId = forecastId_example;  // string | The ID of the forecast to copy
            var body = new CopyBuForecastRequest(); // CopyBuForecastRequest | body
            var forceAsync = true;  // bool? | Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional) 

            try
            { 
                // Copy a short term forecast
                AsyncForecastOperationResult result = apiInstance.PostWorkforcemanagementBusinessunitWeekShorttermforecastCopy(businessUnitId, weekDateId, forecastId, body, forceAsync);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitWeekShorttermforecastCopy: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The business unit ID of the business unit to which the forecast belongs |  |
| **weekDateId** | **DateTime?**| The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **forecastId** | **string**| The ID of the forecast to copy |  |
| **body** | [**CopyBuForecastRequest**](CopyBuForecastRequest.html)| body |  |
| **forceAsync** | **bool?**| Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes | [optional]  |
{: class="table table-striped"}

### Return type

[**AsyncForecastOperationResult**](AsyncForecastOperationResult.html)

<a name="postworkforcemanagementbusinessunitweekshorttermforecastsgenerate"></a>

## [**AsyncForecastOperationResult**](AsyncForecastOperationResult.html) PostWorkforcemanagementBusinessunitWeekShorttermforecastsGenerate (string businessUnitId, DateTime? weekDateId, GenerateBuForecastRequest body, bool? forceAsync = null)



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
    public class PostWorkforcemanagementBusinessunitWeekShorttermforecastsGenerateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The business unit ID of the business unit to which the forecast belongs
            var weekDateId = 2013-10-20;  // DateTime? | The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var body = new GenerateBuForecastRequest(); // GenerateBuForecastRequest | 
            var forceAsync = true;  // bool? | Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional) 

            try
            { 
                // Generate a short term forecast
                AsyncForecastOperationResult result = apiInstance.PostWorkforcemanagementBusinessunitWeekShorttermforecastsGenerate(businessUnitId, weekDateId, body, forceAsync);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitWeekShorttermforecastsGenerate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The business unit ID of the business unit to which the forecast belongs |  |
| **weekDateId** | **DateTime?**| The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **body** | [**GenerateBuForecastRequest**](GenerateBuForecastRequest.html)|  |  |
| **forceAsync** | **bool?**| Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes | [optional]  |
{: class="table table-striped"}

### Return type

[**AsyncForecastOperationResult**](AsyncForecastOperationResult.html)

<a name="postworkforcemanagementbusinessunits"></a>

## [**BusinessUnit**](BusinessUnit.html) PostWorkforcemanagementBusinessunits (CreateBusinessUnitRequest body = null)



Add a new business unit

It may take a minute or two for a new business unit to be available for api operations

Requires ANY permissions: 

* wfm:businessUnit:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementBusinessunitsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var body = new CreateBusinessUnitRequest(); // CreateBusinessUnitRequest | body (optional) 

            try
            { 
                // Add a new business unit
                BusinessUnit result = apiInstance.PostWorkforcemanagementBusinessunits(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunits: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateBusinessUnitRequest**](CreateBusinessUnitRequest.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**BusinessUnit**](BusinessUnit.html)

<a name="postworkforcemanagementmanagementunitactivitycodes"></a>

## void PostWorkforcemanagementManagementunitActivitycodes (string muId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Deprecated/Gone: Use the new business unit activity code resources



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
    public class PostWorkforcemanagementManagementunitActivitycodesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.

            try
            { 
                // Deprecated/Gone: Use the new business unit activity code resources
                apiInstance.PostWorkforcemanagementManagementunitActivitycodes(muId);
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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postworkforcemanagementmanagementunitagentschedulessearch"></a>

## [**BuAsyncAgentSchedulesSearchResponse**](BuAsyncAgentSchedulesSearchResponse.html) PostWorkforcemanagementManagementunitAgentschedulesSearch (string muId, BuSearchAgentSchedulesRequest body = null, bool? forceAsync = null, bool? forceDownloadService = null)



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
                BuAsyncAgentSchedulesSearchResponse result = apiInstance.PostWorkforcemanagementManagementunitAgentschedulesSearch(muId, body, forceAsync, forceDownloadService);
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

[**BuAsyncAgentSchedulesSearchResponse**](BuAsyncAgentSchedulesSearchResponse.html)

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

## void PostWorkforcemanagementManagementunitIntraday (string muId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gone.  Moved under business units



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
    public class PostWorkforcemanagementManagementunitIntradayExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The management unit ID of the management unit

            try
            { 
                // Gone.  Moved under business units
                apiInstance.PostWorkforcemanagementManagementunitIntraday(muId);
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
{: class="table table-striped"}

### Return type

void (empty response body)

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

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

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

## void PostWorkforcemanagementManagementunitServicegoalgroups (string managementUnitId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gone. Replaced with service goal templates and planning groups under business units



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
    public class PostWorkforcemanagementManagementunitServicegoalgroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | (Deprecated/gone): The ID of the management unit, or 'mine' for the management unit of the logged-in user.

            try
            { 
                // Gone. Replaced with service goal templates and planning groups under business units
                apiInstance.PostWorkforcemanagementManagementunitServicegoalgroups(managementUnitId);
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
| **managementUnitId** | **string**| (Deprecated/gone): The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
{: class="table table-striped"}

### Return type

void (empty response body)

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

## void PostWorkforcemanagementManagementunitTimeoffrequestsFetchdetails (string muId, TimeOffRequestListing body = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gone.  All data is now returned in the query route



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
    public class PostWorkforcemanagementManagementunitTimeoffrequestsFetchdetailsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The muId of the management unit, or 'mine' for the management unit of the logged-in user.
            var body = new TimeOffRequestListing(); // TimeOffRequestListing | body (optional) 

            try
            { 
                // Gone.  All data is now returned in the query route
                apiInstance.PostWorkforcemanagementManagementunitTimeoffrequestsFetchdetails(muId, body);
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
| **body** | [**TimeOffRequestListing**](TimeOffRequestListing.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postworkforcemanagementmanagementunittimeoffrequestsquery"></a>

## [**TimeOffRequestListing**](TimeOffRequestListing.html) PostWorkforcemanagementManagementunitTimeoffrequestsQuery (string muId, TimeOffRequestQueryBody body = null)



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
                TimeOffRequestListing result = apiInstance.PostWorkforcemanagementManagementunitTimeoffrequestsQuery(muId, body);
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

[**TimeOffRequestListing**](TimeOffRequestListing.html)

<a name="postworkforcemanagementmanagementunitweekschedulecopy"></a>

## void PostWorkforcemanagementManagementunitWeekScheduleCopy (string managementUnitId, string weekId, string scheduleId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gone.  Scheduling has moved under business units



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
    public class PostWorkforcemanagementManagementunitWeekScheduleCopyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var weekId = weekId_example;  // string | First day of schedule week in yyyy-MM-dd format.
            var scheduleId = scheduleId_example;  // string | Gone/deprecated. The ID of the schedule to copy from

            try
            { 
                // Gone.  Scheduling has moved under business units
                apiInstance.PostWorkforcemanagementManagementunitWeekScheduleCopy(managementUnitId, weekId, scheduleId);
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
| **scheduleId** | **string**| Gone/deprecated. The ID of the schedule to copy from |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postworkforcemanagementmanagementunitweekschedulereschedule"></a>

## void PostWorkforcemanagementManagementunitWeekScheduleReschedule (string managementUnitId, string weekId, string scheduleId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gone.  Scheduling has moved under business units



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
    public class PostWorkforcemanagementManagementunitWeekScheduleRescheduleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var weekId = weekId_example;  // string | First day of schedule week in yyyy-MM-dd format.
            var scheduleId = scheduleId_example;  // string | Gone/deprecated. The ID of the schedule to re-optimize

            try
            { 
                // Gone.  Scheduling has moved under business units
                apiInstance.PostWorkforcemanagementManagementunitWeekScheduleReschedule(managementUnitId, weekId, scheduleId);
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
| **scheduleId** | **string**| Gone/deprecated. The ID of the schedule to re-optimize |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postworkforcemanagementmanagementunitweekschedules"></a>

## void PostWorkforcemanagementManagementunitWeekSchedules (string managementUnitId, string weekId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gone.  Scheduling has moved under business units



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
    public class PostWorkforcemanagementManagementunitWeekSchedulesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var weekId = weekId_example;  // string | First day of schedule week in yyyy-MM-dd format.

            try
            { 
                // Gone.  Scheduling has moved under business units
                apiInstance.PostWorkforcemanagementManagementunitWeekSchedules(managementUnitId, weekId);
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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postworkforcemanagementmanagementunitweekschedulesgenerate"></a>

## void PostWorkforcemanagementManagementunitWeekSchedulesGenerate (string managementUnitId, string weekId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gone.  Scheduling has moved under business units



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

            try
            { 
                // Gone.  Scheduling has moved under business units
                apiInstance.PostWorkforcemanagementManagementunitWeekSchedulesGenerate(managementUnitId, weekId);
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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postworkforcemanagementmanagementunitweekschedulespartialupload"></a>

## void PostWorkforcemanagementManagementunitWeekSchedulesPartialupload (string managementUnitId, string weekId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gone.  Scheduling has moved under business units



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
    public class PostWorkforcemanagementManagementunitWeekSchedulesPartialuploadExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var weekId = weekId_example;  // string | First day of schedule week in yyyy-MM-dd format.

            try
            { 
                // Gone.  Scheduling has moved under business units
                apiInstance.PostWorkforcemanagementManagementunitWeekSchedulesPartialupload(managementUnitId, weekId);
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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postworkforcemanagementmanagementunitweekshifttradematch"></a>

## [**MatchShiftTradeResponse**](MatchShiftTradeResponse.html) PostWorkforcemanagementManagementunitWeekShifttradeMatch (string managementUnitId, DateTime? weekDateId, MatchShiftTradeRequest body, string tradeId)



Matches a shift trade. This route can only be called by the receiving agent



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
    public class PostWorkforcemanagementManagementunitWeekShifttradeMatchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The management unit ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var weekDateId = 2013-10-20;  // DateTime? | The start date of the week schedule in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var body = new MatchShiftTradeRequest(); // MatchShiftTradeRequest | body
            var tradeId = tradeId_example;  // string | The ID of the shift trade to update

            try
            { 
                // Matches a shift trade. This route can only be called by the receiving agent
                MatchShiftTradeResponse result = apiInstance.PostWorkforcemanagementManagementunitWeekShifttradeMatch(managementUnitId, weekDateId, body, tradeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitWeekShifttradeMatch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **weekDateId** | **DateTime?**| The start date of the week schedule in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **body** | [**MatchShiftTradeRequest**](MatchShiftTradeRequest.html)| body |  |
| **tradeId** | **string**| The ID of the shift trade to update |  |
{: class="table table-striped"}

### Return type

[**MatchShiftTradeResponse**](MatchShiftTradeResponse.html)

<a name="postworkforcemanagementmanagementunitweekshifttrades"></a>

## [**ShiftTradeResponse**](ShiftTradeResponse.html) PostWorkforcemanagementManagementunitWeekShifttrades (string managementUnitId, DateTime? weekDateId, AddShiftTradeRequest body)



Adds a shift trade



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
    public class PostWorkforcemanagementManagementunitWeekShifttradesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The management unit ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var weekDateId = 2013-10-20;  // DateTime? | The start date of the week schedule in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var body = new AddShiftTradeRequest(); // AddShiftTradeRequest | body

            try
            { 
                // Adds a shift trade
                ShiftTradeResponse result = apiInstance.PostWorkforcemanagementManagementunitWeekShifttrades(managementUnitId, weekDateId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitWeekShifttrades: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **weekDateId** | **DateTime?**| The start date of the week schedule in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **body** | [**AddShiftTradeRequest**](AddShiftTradeRequest.html)| body |  |
{: class="table table-striped"}

### Return type

[**ShiftTradeResponse**](ShiftTradeResponse.html)

<a name="postworkforcemanagementmanagementunitweekshifttradessearch"></a>

## [**SearchShiftTradesResponse**](SearchShiftTradesResponse.html) PostWorkforcemanagementManagementunitWeekShifttradesSearch (string managementUnitId, DateTime? weekDateId, SearchShiftTradesRequest body)



Searches for potential shift trade matches for the current agent



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
    public class PostWorkforcemanagementManagementunitWeekShifttradesSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The management unit ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var weekDateId = 2013-10-20;  // DateTime? | The start date of the week schedule in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var body = new SearchShiftTradesRequest(); // SearchShiftTradesRequest | body

            try
            { 
                // Searches for potential shift trade matches for the current agent
                SearchShiftTradesResponse result = apiInstance.PostWorkforcemanagementManagementunitWeekShifttradesSearch(managementUnitId, weekDateId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitWeekShifttradesSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **weekDateId** | **DateTime?**| The start date of the week schedule in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **body** | [**SearchShiftTradesRequest**](SearchShiftTradesRequest.html)| body |  |
{: class="table table-striped"}

### Return type

[**SearchShiftTradesResponse**](SearchShiftTradesResponse.html)

<a name="postworkforcemanagementmanagementunitweekshifttradesstatebulk"></a>

## [**BulkUpdateShiftTradeStateResponse**](BulkUpdateShiftTradeStateResponse.html) PostWorkforcemanagementManagementunitWeekShifttradesStateBulk (string managementUnitId, DateTime? weekDateId, BulkShiftTradeStateUpdateRequest body, bool? forceAsync = null)



Updates the state of a batch of shift trades

Admin functionality is not supported with \"mine\".

Requires ANY permissions: 

* wfm:agentShiftTradeRequest:participate
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
    public class PostWorkforcemanagementManagementunitWeekShifttradesStateBulkExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The management unit ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var weekDateId = 2013-10-20;  // DateTime? | The start date of the week schedule in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var body = new BulkShiftTradeStateUpdateRequest(); // BulkShiftTradeStateUpdateRequest | body
            var forceAsync = true;  // bool? | Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional) 

            try
            { 
                // Updates the state of a batch of shift trades
                BulkUpdateShiftTradeStateResponse result = apiInstance.PostWorkforcemanagementManagementunitWeekShifttradesStateBulk(managementUnitId, weekDateId, body, forceAsync);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitWeekShifttradesStateBulk: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **weekDateId** | **DateTime?**| The start date of the week schedule in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **body** | [**BulkShiftTradeStateUpdateRequest**](BulkShiftTradeStateUpdateRequest.html)| body |  |
| **forceAsync** | **bool?**| Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes | [optional]  |
{: class="table table-striped"}

### Return type

[**BulkUpdateShiftTradeStateResponse**](BulkUpdateShiftTradeStateResponse.html)

<a name="postworkforcemanagementmanagementunitweekshorttermforecastcopy"></a>

## void PostWorkforcemanagementManagementunitWeekShorttermforecastCopy (string managementUnitId, string weekDateId, string forecastId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gone. Use equivalent business unit resource instead



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
    public class PostWorkforcemanagementManagementunitWeekShorttermforecastCopyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | (Deprecated/gone): The id of the management unit.
            var weekDateId = weekDateId_example;  // string | (Deprecated/gone): The week start date of the forecast in yyyy-MM-dd format
            var forecastId = forecastId_example;  // string | (Gone/Deprecated): The ID of the forecast

            try
            { 
                // Gone. Use equivalent business unit resource instead
                apiInstance.PostWorkforcemanagementManagementunitWeekShorttermforecastCopy(managementUnitId, weekDateId, forecastId);
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
| **managementUnitId** | **string**| (Deprecated/gone): The id of the management unit. |  |
| **weekDateId** | **string**| (Deprecated/gone): The week start date of the forecast in yyyy-MM-dd format |  |
| **forecastId** | **string**| (Gone/Deprecated): The ID of the forecast |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postworkforcemanagementmanagementunitweekshorttermforecasts"></a>

## void PostWorkforcemanagementManagementunitWeekShorttermforecasts (string managementUnitId, string weekDateId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gone. Use equivalent business unit resource instead



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
    public class PostWorkforcemanagementManagementunitWeekShorttermforecastsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | (Deprecated/gone): The id of the management unit.
            var weekDateId = weekDateId_example;  // string | (Deprecated/gone): The week start date of the forecast in yyyy-MM-dd format

            try
            { 
                // Gone. Use equivalent business unit resource instead
                apiInstance.PostWorkforcemanagementManagementunitWeekShorttermforecasts(managementUnitId, weekDateId);
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
| **managementUnitId** | **string**| (Deprecated/gone): The id of the management unit. |  |
| **weekDateId** | **string**| (Deprecated/gone): The week start date of the forecast in yyyy-MM-dd format |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postworkforcemanagementmanagementunitweekshorttermforecastsgenerate"></a>

## void PostWorkforcemanagementManagementunitWeekShorttermforecastsGenerate (string managementUnitId, string weekDateId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gone. Use equivalent business unit resource instead



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
    public class PostWorkforcemanagementManagementunitWeekShorttermforecastsGenerateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | (Deprecated/gone): The id of the management unit.
            var weekDateId = weekDateId_example;  // string | (Deprecated/gone): The week start date of the forecast in yyyy-MM-dd format

            try
            { 
                // Gone. Use equivalent business unit resource instead
                apiInstance.PostWorkforcemanagementManagementunitWeekShorttermforecastsGenerate(managementUnitId, weekDateId);
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
| **managementUnitId** | **string**| (Deprecated/gone): The id of the management unit. |  |
| **weekDateId** | **string**| (Deprecated/gone): The week start date of the forecast in yyyy-MM-dd format |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postworkforcemanagementmanagementunitweekshorttermforecastspartialupload"></a>

## void PostWorkforcemanagementManagementunitWeekShorttermforecastsPartialupload (string managementUnitId, string weekDateId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gone. Use equivalent business unit resource instead



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
    public class PostWorkforcemanagementManagementunitWeekShorttermforecastsPartialuploadExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | (Deprecated/gone): The id of the management unit.
            var weekDateId = weekDateId_example;  // string | (Deprecated/gone): The week start date of the forecast in yyyy-MM-dd format

            try
            { 
                // Gone. Use equivalent business unit resource instead
                apiInstance.PostWorkforcemanagementManagementunitWeekShorttermforecastsPartialupload(managementUnitId, weekDateId);
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
| **managementUnitId** | **string**| (Deprecated/gone): The id of the management unit. |  |
| **weekDateId** | **string**| (Deprecated/gone): The week start date of the forecast in yyyy-MM-dd format |  |
{: class="table table-striped"}

### Return type

void (empty response body)

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

It may take a minute or two for a new management unit to be available for api operations

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

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get published schedule for the current user



Requires ANY permissions: 

* wfm:agentSchedule:view

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

