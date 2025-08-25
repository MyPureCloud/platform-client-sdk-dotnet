# WorkforceManagementApi

## PureCloudPlatform.Client.V2.Api.WorkforceManagementApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteWorkforcemanagementBusinessunit**](#DeleteWorkforcemanagementBusinessunit) | **Delete** /api/v2/workforcemanagement/businessunits/{businessUnitId} | Delete business unit |
| [**DeleteWorkforcemanagementBusinessunitActivitycode**](#DeleteWorkforcemanagementBusinessunitActivitycode) | **Delete** /api/v2/workforcemanagement/businessunits/{businessUnitId}/activitycodes/{activityCodeId} | Deletes an activity code |
| [**DeleteWorkforcemanagementBusinessunitCapacityplanStaffinggroupallocationshistory**](#DeleteWorkforcemanagementBusinessunitCapacityplanStaffinggroupallocationshistory) | **Delete** /api/v2/workforcemanagement/businessunits/{businessUnitId}/capacityplans/{capacityPlanId}/staffinggroupallocationshistory | Delete staffing group allocations history created for a capacity plan before the given date |
| [**DeleteWorkforcemanagementBusinessunitPlanninggroup**](#DeleteWorkforcemanagementBusinessunitPlanninggroup) | **Delete** /api/v2/workforcemanagement/businessunits/{businessUnitId}/planninggroups/{planningGroupId} | Deletes the planning group |
| [**DeleteWorkforcemanagementBusinessunitSchedulingRun**](#DeleteWorkforcemanagementBusinessunitSchedulingRun) | **Delete** /api/v2/workforcemanagement/businessunits/{businessUnitId}/scheduling/runs/{runId} | Cancel a scheduling run |
| [**DeleteWorkforcemanagementBusinessunitServicegoaltemplate**](#DeleteWorkforcemanagementBusinessunitServicegoaltemplate) | **Delete** /api/v2/workforcemanagement/businessunits/{businessUnitId}/servicegoaltemplates/{serviceGoalTemplateId} | Delete a service goal template |
| [**DeleteWorkforcemanagementBusinessunitStaffinggroup**](#DeleteWorkforcemanagementBusinessunitStaffinggroup) | **Delete** /api/v2/workforcemanagement/businessunits/{businessUnitId}/staffinggroups/{staffingGroupId} | Deletes a staffing group |
| [**DeleteWorkforcemanagementBusinessunitTimeofflimit**](#DeleteWorkforcemanagementBusinessunitTimeofflimit) | **Delete** /api/v2/workforcemanagement/businessunits/{businessUnitId}/timeofflimits/{timeOffLimitId} | Deletes a time-off limit object |
| [**DeleteWorkforcemanagementBusinessunitTimeoffplan**](#DeleteWorkforcemanagementBusinessunitTimeoffplan) | **Delete** /api/v2/workforcemanagement/businessunits/{businessUnitId}/timeoffplans/{timeOffPlanId} | Deletes a time-off plan |
| [**DeleteWorkforcemanagementBusinessunitWeekSchedule**](#DeleteWorkforcemanagementBusinessunitWeekSchedule) | **Delete** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId} | Delete a schedule |
| [**DeleteWorkforcemanagementBusinessunitWeekShorttermforecast**](#DeleteWorkforcemanagementBusinessunitWeekShorttermforecast) | **Delete** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId} | Delete a short term forecast |
| [**DeleteWorkforcemanagementBusinessunitWorkplanbid**](#DeleteWorkforcemanagementBusinessunitWorkplanbid) | **Delete** /api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId} | Delete a work plan bid |
| [**DeleteWorkforcemanagementBusinessunitWorkplanbidGroup**](#DeleteWorkforcemanagementBusinessunitWorkplanbidGroup) | **Delete** /api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId}/groups/{bidGroupId} | Delete a bid group by bid group Id |
| [**DeleteWorkforcemanagementCalendarUrlIcs**](#DeleteWorkforcemanagementCalendarUrlIcs) | **Delete** /api/v2/workforcemanagement/calendar/url/ics | Disable generated calendar link for the current user |
| [**DeleteWorkforcemanagementManagementunit**](#DeleteWorkforcemanagementManagementunit) | **Delete** /api/v2/workforcemanagement/managementunits/{managementUnitId} | Delete management unit |
| [**DeleteWorkforcemanagementManagementunitTimeofflimit**](#DeleteWorkforcemanagementManagementunitTimeofflimit) | **Delete** /api/v2/workforcemanagement/managementunits/{managementUnitId}/timeofflimits/{timeOffLimitId} | Deletes a time off limit object |
| [**DeleteWorkforcemanagementManagementunitTimeoffplan**](#DeleteWorkforcemanagementManagementunitTimeoffplan) | **Delete** /api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffplans/{timeOffPlanId} | Deletes a time off plan |
| [**DeleteWorkforcemanagementManagementunitWorkplan**](#DeleteWorkforcemanagementManagementunitWorkplan) | **Delete** /api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId} | Delete a work plan |
| [**DeleteWorkforcemanagementManagementunitWorkplanrotation**](#DeleteWorkforcemanagementManagementunitWorkplanrotation) | **Delete** /api/v2/workforcemanagement/managementunits/{managementUnitId}/workplanrotations/{workPlanRotationId} | Delete a work plan rotation |
| [**GetWorkforcemanagementAdherence**](#GetWorkforcemanagementAdherence) | **Get** /api/v2/workforcemanagement/adherence | Get a list of UserScheduleAdherence records for the requested users |
| [**GetWorkforcemanagementAdherenceExplanation**](#GetWorkforcemanagementAdherenceExplanation) | **Get** /api/v2/workforcemanagement/adherence/explanations/{explanationId} | Get an adherence explanation for the current user |
| [**GetWorkforcemanagementAdherenceExplanationsJob**](#GetWorkforcemanagementAdherenceExplanationsJob) | **Get** /api/v2/workforcemanagement/adherence/explanations/jobs/{jobId} | Query the status of an adherence explanation operation. Only the user who started the operation can query the status |
| [**GetWorkforcemanagementAdherenceHistoricalBulkJob**](#GetWorkforcemanagementAdherenceHistoricalBulkJob) | **Get** /api/v2/workforcemanagement/adherence/historical/bulk/jobs/{jobId} | Request to fetch the status of the historical adherence bulk job. Only the user who started the operation can query the status |
| [**GetWorkforcemanagementAdherenceHistoricalJob**](#GetWorkforcemanagementAdherenceHistoricalJob) | **Get** /api/v2/workforcemanagement/adherence/historical/jobs/{jobId} | Query the status of a historical adherence request operation. Only the user who started the operation can query the status |
| [**GetWorkforcemanagementAgentAdherenceExplanation**](#GetWorkforcemanagementAgentAdherenceExplanation) | **Get** /api/v2/workforcemanagement/agents/{agentId}/adherence/explanations/{explanationId} | Get an adherence explanation |
| [**GetWorkforcemanagementAgentManagementunit**](#GetWorkforcemanagementAgentManagementunit) | **Get** /api/v2/workforcemanagement/agents/{agentId}/managementunit | Get the management unit to which the agent belongs |
| [**GetWorkforcemanagementAgentsMeManagementunit**](#GetWorkforcemanagementAgentsMeManagementunit) | **Get** /api/v2/workforcemanagement/agents/me/managementunit | Get the management unit to which the currently logged in agent belongs |
| [**GetWorkforcemanagementAlternativeshiftsOffersJob**](#GetWorkforcemanagementAlternativeshiftsOffersJob) | **Get** /api/v2/workforcemanagement/alternativeshifts/offers/jobs/{jobId} | Query the status of an alternative shift offers operation. Only the user who started the operation can query the status |
| [**GetWorkforcemanagementAlternativeshiftsOffersSearchJob**](#GetWorkforcemanagementAlternativeshiftsOffersSearchJob) | **Get** /api/v2/workforcemanagement/alternativeshifts/offers/search/jobs/{jobId} | Query the status of an alternative shift search offers operation. Only the user who started the operation can query the status |
| [**GetWorkforcemanagementAlternativeshiftsSettings**](#GetWorkforcemanagementAlternativeshiftsSettings) | **Get** /api/v2/workforcemanagement/alternativeshifts/settings | Get alternative shifts settings from the current logged in agent’s business unit |
| [**GetWorkforcemanagementAlternativeshiftsTrade**](#GetWorkforcemanagementAlternativeshiftsTrade) | **Get** /api/v2/workforcemanagement/alternativeshifts/trades/{tradeId} | Get my alternative shift trade by trade ID |
| [**GetWorkforcemanagementAlternativeshiftsTrades**](#GetWorkforcemanagementAlternativeshiftsTrades) | **Get** /api/v2/workforcemanagement/alternativeshifts/trades | Get a list of my alternative shifts trades |
| [**GetWorkforcemanagementAlternativeshiftsTradesJob**](#GetWorkforcemanagementAlternativeshiftsTradesJob) | **Get** /api/v2/workforcemanagement/alternativeshifts/trades/jobs/{jobId} | Query the status of an alternative shift trades operation. Only the user who started the operation can query the status |
| [**GetWorkforcemanagementAlternativeshiftsTradesStateJob**](#GetWorkforcemanagementAlternativeshiftsTradesStateJob) | **Get** /api/v2/workforcemanagement/alternativeshifts/trades/state/jobs/{jobId} | Query the status of an alternative shift trade state operation. Only the user who started the operation can query the status |
| [**GetWorkforcemanagementBusinessunit**](#GetWorkforcemanagementBusinessunit) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId} | Get business unit |
| [**GetWorkforcemanagementBusinessunitActivitycode**](#GetWorkforcemanagementBusinessunitActivitycode) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/activitycodes/{activityCodeId} | Get an activity code |
| [**GetWorkforcemanagementBusinessunitActivitycodes**](#GetWorkforcemanagementBusinessunitActivitycodes) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/activitycodes | Get activity codes |
| [**GetWorkforcemanagementBusinessunitActivityplan**](#GetWorkforcemanagementBusinessunitActivityplan) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/activityplans/{activityPlanId} | Get an activity plan |
| [**GetWorkforcemanagementBusinessunitActivityplanRunsJob**](#GetWorkforcemanagementBusinessunitActivityplanRunsJob) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/activityplans/{activityPlanId}/runs/jobs/{jobId} | Gets an activity plan run job |
| [**GetWorkforcemanagementBusinessunitActivityplans**](#GetWorkforcemanagementBusinessunitActivityplans) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/activityplans | Get activity plans |
| [**GetWorkforcemanagementBusinessunitActivityplansJobs**](#GetWorkforcemanagementBusinessunitActivityplansJobs) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/activityplans/jobs | Gets the latest job for all activity plans in the business unit |
| [**GetWorkforcemanagementBusinessunitAlternativeshiftsSettings**](#GetWorkforcemanagementBusinessunitAlternativeshiftsSettings) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/alternativeshifts/settings | Get alternative shifts settings for a business unit |
| [**GetWorkforcemanagementBusinessunitAlternativeshiftsTrade**](#GetWorkforcemanagementBusinessunitAlternativeshiftsTrade) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/alternativeshifts/trades/{tradeId} | Get an alternative shifts trade in a business unit for a given trade ID |
| [**GetWorkforcemanagementBusinessunitAlternativeshiftsTradesSearchJob**](#GetWorkforcemanagementBusinessunitAlternativeshiftsTradesSearchJob) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/alternativeshifts/trades/search/jobs/{jobId} | Query the status of an alternative shift search trade operation. Only the user who started the operation can query the status |
| [**GetWorkforcemanagementBusinessunitCapacityplan**](#GetWorkforcemanagementBusinessunitCapacityplan) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/capacityplans/{capacityPlanId} | Get a capacity plan |
| [**GetWorkforcemanagementBusinessunitCapacityplanStaffinggroupallocations**](#GetWorkforcemanagementBusinessunitCapacityplanStaffinggroupallocations) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/capacityplans/{capacityPlanId}/staffinggroupallocations | Get a capacity plan&#39;s staffing group allocations |
| [**GetWorkforcemanagementBusinessunitCapacityplanStaffingrequirements**](#GetWorkforcemanagementBusinessunitCapacityplanStaffingrequirements) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/capacityplans/{capacityPlanId}/staffingrequirements | Get a capacity plan&#39;s staffing requirements |
| [**GetWorkforcemanagementBusinessunitCapacityplanningLongtermrequirementsAutomaticbestmethodWeekForecast**](#GetWorkforcemanagementBusinessunitCapacityplanningLongtermrequirementsAutomaticbestmethodWeekForecast) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/capacityplanning/longtermrequirements/automaticbestmethod/weeks/{weekDateId}/forecasts/{forecastId} | Get the latest long term staffing requirements for a business unit |
| [**GetWorkforcemanagementBusinessunitCapacityplans**](#GetWorkforcemanagementBusinessunitCapacityplans) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/capacityplans | Get list of capacity plans for a business unit |
| [**GetWorkforcemanagementBusinessunitIntradayPlanninggroups**](#GetWorkforcemanagementBusinessunitIntradayPlanninggroups) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/intraday/planninggroups | Get intraday planning groups for the given date |
| [**GetWorkforcemanagementBusinessunitMainforecastContinuousforecastSession**](#GetWorkforcemanagementBusinessunitMainforecastContinuousforecastSession) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/mainforecast/continuousforecast/session | Get the latest session for the business unit ID |
| [**GetWorkforcemanagementBusinessunitMainforecastContinuousforecastSessionSessionId**](#GetWorkforcemanagementBusinessunitMainforecastContinuousforecastSessionSessionId) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/mainforecast/continuousforecast/session/{sessionId} | Get the session details for the session ID |
| [**GetWorkforcemanagementBusinessunitMainforecastContinuousforecastSessionSessionIdSnapshotSnapshotId**](#GetWorkforcemanagementBusinessunitMainforecastContinuousforecastSessionSessionIdSnapshotSnapshotId) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/mainforecast/continuousforecast/session/{sessionId}/snapshot/{snapshotId} | Get the snapshot details for the snapshot ID |
| [**GetWorkforcemanagementBusinessunitManagementunits**](#GetWorkforcemanagementBusinessunitManagementunits) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/managementunits | Get all authorized management units in the business unit |
| [**GetWorkforcemanagementBusinessunitPlanninggroup**](#GetWorkforcemanagementBusinessunitPlanninggroup) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/planninggroups/{planningGroupId} | Get a planning group |
| [**GetWorkforcemanagementBusinessunitPlanninggroups**](#GetWorkforcemanagementBusinessunitPlanninggroups) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/planninggroups | Gets list of planning groups |
| [**GetWorkforcemanagementBusinessunitSchedulingRun**](#GetWorkforcemanagementBusinessunitSchedulingRun) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/scheduling/runs/{runId} | Get a scheduling run |
| [**GetWorkforcemanagementBusinessunitSchedulingRunResult**](#GetWorkforcemanagementBusinessunitSchedulingRunResult) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/scheduling/runs/{runId}/result | Get the result of a rescheduling operation |
| [**GetWorkforcemanagementBusinessunitSchedulingRuns**](#GetWorkforcemanagementBusinessunitSchedulingRuns) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/scheduling/runs | Get the list of scheduling runs |
| [**GetWorkforcemanagementBusinessunitServicegoaltemplate**](#GetWorkforcemanagementBusinessunitServicegoaltemplate) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/servicegoaltemplates/{serviceGoalTemplateId} | Get a service goal template |
| [**GetWorkforcemanagementBusinessunitServicegoaltemplates**](#GetWorkforcemanagementBusinessunitServicegoaltemplates) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/servicegoaltemplates | Gets list of service goal templates |
| [**GetWorkforcemanagementBusinessunitStaffinggroup**](#GetWorkforcemanagementBusinessunitStaffinggroup) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/staffinggroups/{staffingGroupId} | Gets a staffing group |
| [**GetWorkforcemanagementBusinessunitStaffinggroups**](#GetWorkforcemanagementBusinessunitStaffinggroups) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/staffinggroups | Gets a list of staffing groups |
| [**GetWorkforcemanagementBusinessunitTimeofflimit**](#GetWorkforcemanagementBusinessunitTimeofflimit) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/timeofflimits/{timeOffLimitId} | Gets a time-off limit object |
| [**GetWorkforcemanagementBusinessunitTimeofflimits**](#GetWorkforcemanagementBusinessunitTimeofflimits) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/timeofflimits | Gets a list of time-off limit objects |
| [**GetWorkforcemanagementBusinessunitTimeoffplan**](#GetWorkforcemanagementBusinessunitTimeoffplan) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/timeoffplans/{timeOffPlanId} | Gets a time-off plan |
| [**GetWorkforcemanagementBusinessunitTimeoffplans**](#GetWorkforcemanagementBusinessunitTimeoffplans) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/timeoffplans | Gets a list of time-off plans |
| [**GetWorkforcemanagementBusinessunitWeekSchedule**](#GetWorkforcemanagementBusinessunitWeekSchedule) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId} | Get the metadata for the schedule, describing which management units and agents are in the scheduleSchedule data can then be loaded with the query route |
| [**GetWorkforcemanagementBusinessunitWeekScheduleGenerationresults**](#GetWorkforcemanagementBusinessunitWeekScheduleGenerationresults) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/generationresults | Get the generation results for a generated schedule |
| [**GetWorkforcemanagementBusinessunitWeekScheduleHeadcountforecast**](#GetWorkforcemanagementBusinessunitWeekScheduleHeadcountforecast) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/headcountforecast | Get the headcount forecast by planning group for the schedule |
| [**GetWorkforcemanagementBusinessunitWeekScheduleHistoryAgent**](#GetWorkforcemanagementBusinessunitWeekScheduleHistoryAgent) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/history/agents/{agentId} | Loads agent&#39;s schedule history. |
| [**GetWorkforcemanagementBusinessunitWeekSchedulePerformancepredictions**](#GetWorkforcemanagementBusinessunitWeekSchedulePerformancepredictions) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/performancepredictions | Get the performance prediction for the associated schedule |
| [**GetWorkforcemanagementBusinessunitWeekSchedulePerformancepredictionsRecalculation**](#GetWorkforcemanagementBusinessunitWeekSchedulePerformancepredictionsRecalculation) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/performancepredictions/recalculations/{recalculationId} | Get recalculated performance prediction result |
| [**GetWorkforcemanagementBusinessunitWeekSchedules**](#GetWorkforcemanagementBusinessunitWeekSchedules) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules | Get the list of week schedules for the specified week |
| [**GetWorkforcemanagementBusinessunitWeekShorttermforecast**](#GetWorkforcemanagementBusinessunitWeekShorttermforecast) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId} | Get a short term forecast |
| [**GetWorkforcemanagementBusinessunitWeekShorttermforecastData**](#GetWorkforcemanagementBusinessunitWeekShorttermforecastData) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}/data | Get the result of a short term forecast calculation |
| [**GetWorkforcemanagementBusinessunitWeekShorttermforecastGenerationresults**](#GetWorkforcemanagementBusinessunitWeekShorttermforecastGenerationresults) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}/generationresults | Gets the forecast generation results |
| [**GetWorkforcemanagementBusinessunitWeekShorttermforecastLongtermforecastdata**](#GetWorkforcemanagementBusinessunitWeekShorttermforecastLongtermforecastdata) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}/longtermforecastdata | Get the result of a long term forecast calculation |
| [**GetWorkforcemanagementBusinessunitWeekShorttermforecastPlanninggroups**](#GetWorkforcemanagementBusinessunitWeekShorttermforecastPlanninggroups) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}/planninggroups | Gets the forecast planning group snapshot |
| [**GetWorkforcemanagementBusinessunitWeekShorttermforecastStaffingrequirement**](#GetWorkforcemanagementBusinessunitWeekShorttermforecastStaffingrequirement) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}/staffingrequirement | Get the staffing requirement by planning group for a forecast |
| [**GetWorkforcemanagementBusinessunitWeekShorttermforecasts**](#GetWorkforcemanagementBusinessunitWeekShorttermforecasts) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts | Get short term forecasts |
| [**GetWorkforcemanagementBusinessunitWorkplanbid**](#GetWorkforcemanagementBusinessunitWorkplanbid) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId} | Get a work plan bid |
| [**GetWorkforcemanagementBusinessunitWorkplanbidGroup**](#GetWorkforcemanagementBusinessunitWorkplanbidGroup) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId}/groups/{bidGroupId} | Get a bid group by bid group Id |
| [**GetWorkforcemanagementBusinessunitWorkplanbidGroupPreferences**](#GetWorkforcemanagementBusinessunitWorkplanbidGroupPreferences) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId}/groups/{bidGroupId}/preferences | Gets the work plan preferences of all the agents in the work plan bid group |
| [**GetWorkforcemanagementBusinessunitWorkplanbidGroupsSummary**](#GetWorkforcemanagementBusinessunitWorkplanbidGroupsSummary) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId}/groups/summary | Get summary of bid groups that belong to a work plan bid |
| [**GetWorkforcemanagementBusinessunitWorkplanbids**](#GetWorkforcemanagementBusinessunitWorkplanbids) | **Get** /api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids | Get list of work plan bids |
| [**GetWorkforcemanagementBusinessunits**](#GetWorkforcemanagementBusinessunits) | **Get** /api/v2/workforcemanagement/businessunits | Get business units |
| [**GetWorkforcemanagementBusinessunitsDivisionviews**](#GetWorkforcemanagementBusinessunitsDivisionviews) | **Get** /api/v2/workforcemanagement/businessunits/divisionviews | Get business units across divisions |
| [**GetWorkforcemanagementCalendarDataIcs**](#GetWorkforcemanagementCalendarDataIcs) | **Get** /api/v2/workforcemanagement/calendar/data/ics | Get ics formatted calendar based on shareable link |
| [**GetWorkforcemanagementCalendarUrlIcs**](#GetWorkforcemanagementCalendarUrlIcs) | **Get** /api/v2/workforcemanagement/calendar/url/ics | Get existing calendar link for the current user |
| [**GetWorkforcemanagementHistoricaldataBulkRemoveJob**](#GetWorkforcemanagementHistoricaldataBulkRemoveJob) | **Get** /api/v2/workforcemanagement/historicaldata/bulk/remove/jobs/{jobId} | Retrieves delete job status for historical data imports associated with the job id |
| [**GetWorkforcemanagementHistoricaldataBulkRemoveJobs**](#GetWorkforcemanagementHistoricaldataBulkRemoveJobs) | **Get** /api/v2/workforcemanagement/historicaldata/bulk/remove/jobs | Retrieves all delete job status for historical data |
| [**GetWorkforcemanagementHistoricaldataImportstatus**](#GetWorkforcemanagementHistoricaldataImportstatus) | **Get** /api/v2/workforcemanagement/historicaldata/importstatus | Retrieves status of the historical data imports of the organization |
| [**GetWorkforcemanagementHistoricaldataImportstatusJobId**](#GetWorkforcemanagementHistoricaldataImportstatusJobId) | **Get** /api/v2/workforcemanagement/historicaldata/importstatus/{jobId} | Retrieves status of the historical data imports associated with job id |
| [**GetWorkforcemanagementIntegrationsHris**](#GetWorkforcemanagementIntegrationsHris) | **Get** /api/v2/workforcemanagement/integrations/hris | Get integrations |
| [**GetWorkforcemanagementIntegrationsHrisTimeofftypesJob**](#GetWorkforcemanagementIntegrationsHrisTimeofftypesJob) | **Get** /api/v2/workforcemanagement/integrations/hris/timeofftypes/jobs/{jobId} | Query the results of time off types job |
| [**GetWorkforcemanagementManagementunit**](#GetWorkforcemanagementManagementunit) | **Get** /api/v2/workforcemanagement/managementunits/{managementUnitId} | Get management unit |
| [**GetWorkforcemanagementManagementunitActivitycodes**](#GetWorkforcemanagementManagementunitActivitycodes) | **Get** /api/v2/workforcemanagement/managementunits/{managementUnitId}/activitycodes | Deprecated: Instead use /api/v2/workforcemanagement/businessunits/{businessUnitId}/activitycodes. Get the list of activity codes |
| [**GetWorkforcemanagementManagementunitAdherence**](#GetWorkforcemanagementManagementunitAdherence) | **Get** /api/v2/workforcemanagement/managementunits/{managementUnitId}/adherence | Get a list of user schedule adherence records for the requested management unit |
| [**GetWorkforcemanagementManagementunitAgent**](#GetWorkforcemanagementManagementunitAgent) | **Get** /api/v2/workforcemanagement/managementunits/{managementUnitId}/agents/{agentId} | Get data for agent in the management unit |
| [**GetWorkforcemanagementManagementunitAgentShifttrades**](#GetWorkforcemanagementManagementunitAgentShifttrades) | **Get** /api/v2/workforcemanagement/managementunits/{managementUnitId}/agents/{agentId}/shifttrades | Gets all the shift trades for a given agent |
| [**GetWorkforcemanagementManagementunitShifttradesMatched**](#GetWorkforcemanagementManagementunitShifttradesMatched) | **Get** /api/v2/workforcemanagement/managementunits/{managementUnitId}/shifttrades/matched | Gets a summary of all shift trades in the matched state |
| [**GetWorkforcemanagementManagementunitShifttradesUsers**](#GetWorkforcemanagementManagementunitShifttradesUsers) | **Get** /api/v2/workforcemanagement/managementunits/{managementUnitId}/shifttrades/users | Gets list of users available for whom you can send direct shift trade requests |
| [**GetWorkforcemanagementManagementunitTimeofflimit**](#GetWorkforcemanagementManagementunitTimeofflimit) | **Get** /api/v2/workforcemanagement/managementunits/{managementUnitId}/timeofflimits/{timeOffLimitId} | Gets a time off limit object |
| [**GetWorkforcemanagementManagementunitTimeofflimits**](#GetWorkforcemanagementManagementunitTimeofflimits) | **Get** /api/v2/workforcemanagement/managementunits/{managementUnitId}/timeofflimits | Gets a list of time off limit objects under management unit. |
| [**GetWorkforcemanagementManagementunitTimeoffplan**](#GetWorkforcemanagementManagementunitTimeoffplan) | **Get** /api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffplans/{timeOffPlanId} | Gets a time off plan |
| [**GetWorkforcemanagementManagementunitTimeoffplans**](#GetWorkforcemanagementManagementunitTimeoffplans) | **Get** /api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffplans | Gets a list of time off plans |
| [**GetWorkforcemanagementManagementunitUserTimeoffrequest**](#GetWorkforcemanagementManagementunitUserTimeoffrequest) | **Get** /api/v2/workforcemanagement/managementunits/{managementUnitId}/users/{userId}/timeoffrequests/{timeOffRequestId} | Get a time off request |
| [**GetWorkforcemanagementManagementunitUserTimeoffrequestTimeofflimits**](#GetWorkforcemanagementManagementunitUserTimeoffrequestTimeofflimits) | **Get** /api/v2/workforcemanagement/managementunits/{managementUnitId}/users/{userId}/timeoffrequests/{timeOffRequestId}/timeofflimits | Retrieves time off limit, allocated and waitlisted values according to specific time off request |
| [**GetWorkforcemanagementManagementunitUserTimeoffrequests**](#GetWorkforcemanagementManagementunitUserTimeoffrequests) | **Get** /api/v2/workforcemanagement/managementunits/{managementUnitId}/users/{userId}/timeoffrequests | Get a list of time off requests for a given user |
| [**GetWorkforcemanagementManagementunitUsers**](#GetWorkforcemanagementManagementunitUsers) | **Get** /api/v2/workforcemanagement/managementunits/{managementUnitId}/users | Get users in the management unit |
| [**GetWorkforcemanagementManagementunitWeekSchedule**](#GetWorkforcemanagementManagementunitWeekSchedule) | **Get** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/{scheduleId} | Deprecated.  Use the equivalent business unit resource instead. Get a week schedule |
| [**GetWorkforcemanagementManagementunitWeekSchedules**](#GetWorkforcemanagementManagementunitWeekSchedules) | **Get** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules | Deprecated.  Use the equivalent business unit resource instead. Get the list of schedules in a week in management unit |
| [**GetWorkforcemanagementManagementunitWeekShifttrades**](#GetWorkforcemanagementManagementunitWeekShifttrades) | **Get** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shifttrades | Gets all the shift trades for a given week |
| [**GetWorkforcemanagementManagementunitWorkplan**](#GetWorkforcemanagementManagementunitWorkplan) | **Get** /api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId} | Get a work plan |
| [**GetWorkforcemanagementManagementunitWorkplanrotation**](#GetWorkforcemanagementManagementunitWorkplanrotation) | **Get** /api/v2/workforcemanagement/managementunits/{managementUnitId}/workplanrotations/{workPlanRotationId} | Get a work plan rotation |
| [**GetWorkforcemanagementManagementunitWorkplanrotations**](#GetWorkforcemanagementManagementunitWorkplanrotations) | **Get** /api/v2/workforcemanagement/managementunits/{managementUnitId}/workplanrotations | Get work plan rotations |
| [**GetWorkforcemanagementManagementunitWorkplans**](#GetWorkforcemanagementManagementunitWorkplans) | **Get** /api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans | Get work plans |
| [**GetWorkforcemanagementManagementunits**](#GetWorkforcemanagementManagementunits) | **Get** /api/v2/workforcemanagement/managementunits | Get management units |
| [**GetWorkforcemanagementManagementunitsDivisionviews**](#GetWorkforcemanagementManagementunitsDivisionviews) | **Get** /api/v2/workforcemanagement/managementunits/divisionviews | Get management units across divisions |
| [**GetWorkforcemanagementNotifications**](#GetWorkforcemanagementNotifications) | **Get** /api/v2/workforcemanagement/notifications | Get a list of notifications for the current user |
| [**GetWorkforcemanagementSchedulingjob**](#GetWorkforcemanagementSchedulingjob) | **Get** /api/v2/workforcemanagement/schedulingjobs/{jobId} | Get status of the scheduling job |
| [**GetWorkforcemanagementShifttrades**](#GetWorkforcemanagementShifttrades) | **Get** /api/v2/workforcemanagement/shifttrades | Gets all of my shift trades |
| [**GetWorkforcemanagementShrinkageJob**](#GetWorkforcemanagementShrinkageJob) | **Get** /api/v2/workforcemanagement/shrinkage/jobs/{jobId} | Request to fetch the status of the historical shrinkage query |
| [**GetWorkforcemanagementTeamAdherence**](#GetWorkforcemanagementTeamAdherence) | **Get** /api/v2/workforcemanagement/teams/{teamId}/adherence | Get a list of user schedule adherence records for the requested team |
| [**GetWorkforcemanagementTimeoffbalanceJob**](#GetWorkforcemanagementTimeoffbalanceJob) | **Get** /api/v2/workforcemanagement/timeoffbalance/jobs/{jobId} | Query the results of time off types job |
| [**GetWorkforcemanagementTimeoffrequest**](#GetWorkforcemanagementTimeoffrequest) | **Get** /api/v2/workforcemanagement/timeoffrequests/{timeOffRequestId} | Get a time off request for the current user |
| [**GetWorkforcemanagementTimeoffrequestWaitlistpositions**](#GetWorkforcemanagementTimeoffrequestWaitlistpositions) | **Get** /api/v2/workforcemanagement/timeoffrequests/{timeOffRequestId}/waitlistpositions | Get the daily waitlist positions of a time off request for the current user |
| [**GetWorkforcemanagementTimeoffrequests**](#GetWorkforcemanagementTimeoffrequests) | **Get** /api/v2/workforcemanagement/timeoffrequests | Get a list of time off requests for the current user |
| [**GetWorkforcemanagementUserWorkplanbidranks**](#GetWorkforcemanagementUserWorkplanbidranks) | **Get** /api/v2/workforcemanagement/users/{userId}/workplanbidranks | Get work plan bid ranks for a user |
| [**GetWorkforcemanagementWorkplanbidPreferences**](#GetWorkforcemanagementWorkplanbidPreferences) | **Get** /api/v2/workforcemanagement/workplanbids/{bidId}/preferences | Gets an agent&#39;s work plan bidding preference |
| [**GetWorkforcemanagementWorkplanbidWorkplans**](#GetWorkforcemanagementWorkplanbidWorkplans) | **Get** /api/v2/workforcemanagement/workplanbids/{bidId}/workplans | Gets an agent&#39;s work plans for a bid |
| [**GetWorkforcemanagementWorkplanbids**](#GetWorkforcemanagementWorkplanbids) | **Get** /api/v2/workforcemanagement/workplanbids | Gets the list of work plan bids that belong to an agent |
| [**PatchWorkforcemanagementAgentAdherenceExplanation**](#PatchWorkforcemanagementAgentAdherenceExplanation) | **Patch** /api/v2/workforcemanagement/agents/{agentId}/adherence/explanations/{explanationId} | Update an adherence explanation |
| [**PatchWorkforcemanagementAlternativeshiftsTrade**](#PatchWorkforcemanagementAlternativeshiftsTrade) | **Patch** /api/v2/workforcemanagement/alternativeshifts/trades/{tradeId} | Update my alternative shifts trade by trade ID |
| [**PatchWorkforcemanagementAlternativeshiftsTradesStateJobs**](#PatchWorkforcemanagementAlternativeshiftsTradesStateJobs) | **Patch** /api/v2/workforcemanagement/alternativeshifts/trades/state/jobs | Bulk update alternative shift trade states |
| [**PatchWorkforcemanagementBusinessunit**](#PatchWorkforcemanagementBusinessunit) | **Patch** /api/v2/workforcemanagement/businessunits/{businessUnitId} | Update business unit |
| [**PatchWorkforcemanagementBusinessunitActivitycode**](#PatchWorkforcemanagementBusinessunitActivitycode) | **Patch** /api/v2/workforcemanagement/businessunits/{businessUnitId}/activitycodes/{activityCodeId} | Update an activity code |
| [**PatchWorkforcemanagementBusinessunitActivityplan**](#PatchWorkforcemanagementBusinessunitActivityplan) | **Patch** /api/v2/workforcemanagement/businessunits/{businessUnitId}/activityplans/{activityPlanId} | Update an activity plan |
| [**PatchWorkforcemanagementBusinessunitAlternativeshiftsSettings**](#PatchWorkforcemanagementBusinessunitAlternativeshiftsSettings) | **Patch** /api/v2/workforcemanagement/businessunits/{businessUnitId}/alternativeshifts/settings | Update alternative shifts settings for a business unit |
| [**PatchWorkforcemanagementBusinessunitCapacityplan**](#PatchWorkforcemanagementBusinessunitCapacityplan) | **Patch** /api/v2/workforcemanagement/businessunits/{businessUnitId}/capacityplans/{capacityPlanId} | Update a capacity plan configuration |
| [**PatchWorkforcemanagementBusinessunitPlanninggroup**](#PatchWorkforcemanagementBusinessunitPlanninggroup) | **Patch** /api/v2/workforcemanagement/businessunits/{businessUnitId}/planninggroups/{planningGroupId} | Updates the planning group |
| [**PatchWorkforcemanagementBusinessunitSchedulingRun**](#PatchWorkforcemanagementBusinessunitSchedulingRun) | **Patch** /api/v2/workforcemanagement/businessunits/{businessUnitId}/scheduling/runs/{runId} | Mark a schedule run as applied |
| [**PatchWorkforcemanagementBusinessunitServicegoaltemplate**](#PatchWorkforcemanagementBusinessunitServicegoaltemplate) | **Patch** /api/v2/workforcemanagement/businessunits/{businessUnitId}/servicegoaltemplates/{serviceGoalTemplateId} | Updates a service goal template |
| [**PatchWorkforcemanagementBusinessunitStaffinggroup**](#PatchWorkforcemanagementBusinessunitStaffinggroup) | **Patch** /api/v2/workforcemanagement/businessunits/{businessUnitId}/staffinggroups/{staffingGroupId} | Updates a staffing group |
| [**PatchWorkforcemanagementBusinessunitTimeoffplan**](#PatchWorkforcemanagementBusinessunitTimeoffplan) | **Patch** /api/v2/workforcemanagement/businessunits/{businessUnitId}/timeoffplans/{timeOffPlanId} | Updates a time-off plan |
| [**PatchWorkforcemanagementBusinessunitWorkplanbid**](#PatchWorkforcemanagementBusinessunitWorkplanbid) | **Patch** /api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId} | Update work plan bid |
| [**PatchWorkforcemanagementBusinessunitWorkplanbidGroup**](#PatchWorkforcemanagementBusinessunitWorkplanbidGroup) | **Patch** /api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId}/groups/{bidGroupId} | Update a bid group by bid group Id |
| [**PatchWorkforcemanagementBusinessunitWorkplanbidGroupPreferences**](#PatchWorkforcemanagementBusinessunitWorkplanbidGroupPreferences) | **Patch** /api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId}/groups/{bidGroupId}/preferences | Overrides the assigned work plan for the specified agents |
| [**PatchWorkforcemanagementManagementunit**](#PatchWorkforcemanagementManagementunit) | **Patch** /api/v2/workforcemanagement/managementunits/{managementUnitId} | Update the requested management unit |
| [**PatchWorkforcemanagementManagementunitAgents**](#PatchWorkforcemanagementManagementunitAgents) | **Patch** /api/v2/workforcemanagement/managementunits/{managementUnitId}/agents | Update agent configurations |
| [**PatchWorkforcemanagementManagementunitAgentsWorkplansBulk**](#PatchWorkforcemanagementManagementunitAgentsWorkplansBulk) | **Patch** /api/v2/workforcemanagement/managementunits/{managementUnitId}/agents/workplans/bulk | Updates agent work plan configuration |
| [**PatchWorkforcemanagementManagementunitTimeofflimit**](#PatchWorkforcemanagementManagementunitTimeofflimit) | **Patch** /api/v2/workforcemanagement/managementunits/{managementUnitId}/timeofflimits/{timeOffLimitId} | Updates a time off limit object. |
| [**PatchWorkforcemanagementManagementunitTimeoffplan**](#PatchWorkforcemanagementManagementunitTimeoffplan) | **Patch** /api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffplans/{timeOffPlanId} | Updates a time off plan |
| [**PatchWorkforcemanagementManagementunitTimeoffrequestUserIntegrationstatus**](#PatchWorkforcemanagementManagementunitTimeoffrequestUserIntegrationstatus) | **Patch** /api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffrequests/{timeOffRequestId}/users/{userId}/integrationstatus | Set integration status for a time off request. |
| [**PatchWorkforcemanagementManagementunitUserTimeoffrequest**](#PatchWorkforcemanagementManagementunitUserTimeoffrequest) | **Patch** /api/v2/workforcemanagement/managementunits/{managementUnitId}/users/{userId}/timeoffrequests/{timeOffRequestId} | Update a time off request |
| [**PatchWorkforcemanagementManagementunitWeekShifttrade**](#PatchWorkforcemanagementManagementunitWeekShifttrade) | **Patch** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shifttrades/{tradeId} | Updates a shift trade. This route can only be called by the initiating agent |
| [**PatchWorkforcemanagementManagementunitWorkplan**](#PatchWorkforcemanagementManagementunitWorkplan) | **Patch** /api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId} | Update a work plan |
| [**PatchWorkforcemanagementManagementunitWorkplanrotation**](#PatchWorkforcemanagementManagementunitWorkplanrotation) | **Patch** /api/v2/workforcemanagement/managementunits/{managementUnitId}/workplanrotations/{workPlanRotationId} | Update a work plan rotation |
| [**PatchWorkforcemanagementTimeoffrequest**](#PatchWorkforcemanagementTimeoffrequest) | **Patch** /api/v2/workforcemanagement/timeoffrequests/{timeOffRequestId} | Update a time off request for the current user |
| [**PatchWorkforcemanagementUserWorkplanbidranks**](#PatchWorkforcemanagementUserWorkplanbidranks) | **Patch** /api/v2/workforcemanagement/users/{userId}/workplanbidranks | Update work plan bid ranks for a user |
| [**PatchWorkforcemanagementUsersWorkplanbidranksBulk**](#PatchWorkforcemanagementUsersWorkplanbidranksBulk) | **Patch** /api/v2/workforcemanagement/users/workplanbidranks/bulk | Update bulk work plan bid ranks on users. Max 50 users can be updated at a time. |
| [**PatchWorkforcemanagementWorkplanbidPreferences**](#PatchWorkforcemanagementWorkplanbidPreferences) | **Patch** /api/v2/workforcemanagement/workplanbids/{bidId}/preferences | Update an agent&#39;s work plan bidding preference |
| [**PostWorkforcemanagementAdherenceExplanations**](#PostWorkforcemanagementAdherenceExplanations) | **Post** /api/v2/workforcemanagement/adherence/explanations | Submit an adherence explanation for the current user |
| [**PostWorkforcemanagementAdherenceExplanationsQuery**](#PostWorkforcemanagementAdherenceExplanationsQuery) | **Post** /api/v2/workforcemanagement/adherence/explanations/query | Query adherence explanations for the current user |
| [**PostWorkforcemanagementAdherenceHistorical**](#PostWorkforcemanagementAdherenceHistorical) | **Post** /api/v2/workforcemanagement/adherence/historical | Deprecated. Use bulk routes instead (/adherence/historical/bulk) |
| [**PostWorkforcemanagementAdherenceHistoricalBulk**](#PostWorkforcemanagementAdherenceHistoricalBulk) | **Post** /api/v2/workforcemanagement/adherence/historical/bulk | Request a historical adherence report in bulk |
| [**PostWorkforcemanagementAgentAdherenceExplanations**](#PostWorkforcemanagementAgentAdherenceExplanations) | **Post** /api/v2/workforcemanagement/agents/{agentId}/adherence/explanations | Add an adherence explanation for the requested user |
| [**PostWorkforcemanagementAgentAdherenceExplanationsQuery**](#PostWorkforcemanagementAgentAdherenceExplanationsQuery) | **Post** /api/v2/workforcemanagement/agents/{agentId}/adherence/explanations/query | Query adherence explanations for the given agent across a specified range |
| [**PostWorkforcemanagementAgents**](#PostWorkforcemanagementAgents) | **Post** /api/v2/workforcemanagement/agents | Move agents in and out of management unit |
| [**PostWorkforcemanagementAgentsIntegrationsHrisQuery**](#PostWorkforcemanagementAgentsIntegrationsHrisQuery) | **Post** /api/v2/workforcemanagement/agents/integrations/hris/query | Query integrations for agents |
| [**PostWorkforcemanagementAgentsMePossibleworkshifts**](#PostWorkforcemanagementAgentsMePossibleworkshifts) | **Post** /api/v2/workforcemanagement/agents/me/possibleworkshifts | Get agent possible work shifts for requested time frame |
| [**PostWorkforcemanagementAgentschedulesMine**](#PostWorkforcemanagementAgentschedulesMine) | **Post** /api/v2/workforcemanagement/agentschedules/mine | Get published schedule for the current user |
| [**PostWorkforcemanagementAlternativeshiftsOffersJobs**](#PostWorkforcemanagementAlternativeshiftsOffersJobs) | **Post** /api/v2/workforcemanagement/alternativeshifts/offers/jobs | Request a list of alternative shift offers for a given schedule |
| [**PostWorkforcemanagementAlternativeshiftsOffersSearchJobs**](#PostWorkforcemanagementAlternativeshiftsOffersSearchJobs) | **Post** /api/v2/workforcemanagement/alternativeshifts/offers/search/jobs | Request a search of alternative shift offers for a given shift |
| [**PostWorkforcemanagementAlternativeshiftsTrades**](#PostWorkforcemanagementAlternativeshiftsTrades) | **Post** /api/v2/workforcemanagement/alternativeshifts/trades | Create my alternative shift trade using an existing offer&#39;s jobId |
| [**PostWorkforcemanagementBusinessunitActivitycodes**](#PostWorkforcemanagementBusinessunitActivitycodes) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/activitycodes | Create a new activity code |
| [**PostWorkforcemanagementBusinessunitActivityplanRunsJobs**](#PostWorkforcemanagementBusinessunitActivityplanRunsJobs) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/activityplans/{activityPlanId}/runs/jobs | Run an activity plan manually |
| [**PostWorkforcemanagementBusinessunitActivityplans**](#PostWorkforcemanagementBusinessunitActivityplans) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/activityplans | Create an activity plan |
| [**PostWorkforcemanagementBusinessunitAdherenceExplanationsQuery**](#PostWorkforcemanagementBusinessunitAdherenceExplanationsQuery) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/adherence/explanations/query | Query adherence explanations across an entire business unit for the requested period |
| [**PostWorkforcemanagementBusinessunitAgentschedulesSearch**](#PostWorkforcemanagementBusinessunitAgentschedulesSearch) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/agentschedules/search | Search published schedules |
| [**PostWorkforcemanagementBusinessunitAlternativeshiftsTradesSearch**](#PostWorkforcemanagementBusinessunitAlternativeshiftsTradesSearch) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/alternativeshifts/trades/search | List alternative shifts trades for a given management unit or agent |
| [**PostWorkforcemanagementBusinessunitCapacityplanCopy**](#PostWorkforcemanagementBusinessunitCapacityplanCopy) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/capacityplans/{capacityPlanId}/copy | Copy a capacity plan |
| [**PostWorkforcemanagementBusinessunitCapacityplanRequirementGenerate**](#PostWorkforcemanagementBusinessunitCapacityplanRequirementGenerate) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/capacityplans/{capacityPlanId}/requirement/generate | Regenerate requirements for capacity plan |
| [**PostWorkforcemanagementBusinessunitCapacityplanStaffinggroupallocations**](#PostWorkforcemanagementBusinessunitCapacityplanStaffinggroupallocations) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/capacityplans/{capacityPlanId}/staffinggroupallocations | Create staffing group allocations for a capacity plan |
| [**PostWorkforcemanagementBusinessunitCapacityplanStaffinggroupallocationshistoryQuery**](#PostWorkforcemanagementBusinessunitCapacityplanStaffinggroupallocationshistoryQuery) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/capacityplans/{capacityPlanId}/staffinggroupallocationshistory/query | Query staffing groups allocations history for a capacity plan |
| [**PostWorkforcemanagementBusinessunitCapacityplanningLongtermrequirementsAutomaticbestmethodWeekForecastForceregenerate**](#PostWorkforcemanagementBusinessunitCapacityplanningLongtermrequirementsAutomaticbestmethodWeekForecastForceregenerate) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/capacityplanning/longtermrequirements/automaticbestmethod/weeks/{weekDateId}/forecasts/{forecastId}/forceregenerate | Force regenerate the latest long term staffing requirements for a business unit |
| [**PostWorkforcemanagementBusinessunitCapacityplans**](#PostWorkforcemanagementBusinessunitCapacityplans) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/capacityplans | Create a new capacity plan |
| [**PostWorkforcemanagementBusinessunitCapacityplansBulkRemove**](#PostWorkforcemanagementBusinessunitCapacityplansBulkRemove) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/capacityplans/bulk/remove | Delete capacity plans in a business unit |
| [**PostWorkforcemanagementBusinessunitIntraday**](#PostWorkforcemanagementBusinessunitIntraday) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/intraday | Get intraday data for the given date for the requested planningGroupIds |
| [**PostWorkforcemanagementBusinessunitPlanninggroups**](#PostWorkforcemanagementBusinessunitPlanninggroups) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/planninggroups | Adds a new planning group |
| [**PostWorkforcemanagementBusinessunitServicegoaltemplates**](#PostWorkforcemanagementBusinessunitServicegoaltemplates) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/servicegoaltemplates | Adds a new service goal template |
| [**PostWorkforcemanagementBusinessunitStaffinggroups**](#PostWorkforcemanagementBusinessunitStaffinggroups) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/staffinggroups | Creates a new staffing group |
| [**PostWorkforcemanagementBusinessunitStaffinggroupsPlanninggroupsQuery**](#PostWorkforcemanagementBusinessunitStaffinggroupsPlanninggroupsQuery) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/staffinggroups/planninggroups/query | Gets a list of planning group to staffing groups list association |
| [**PostWorkforcemanagementBusinessunitStaffinggroupsQuery**](#PostWorkforcemanagementBusinessunitStaffinggroupsQuery) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/staffinggroups/query | Gets staffing group associations for a list of user IDs |
| [**PostWorkforcemanagementBusinessunitTimeofflimits**](#PostWorkforcemanagementBusinessunitTimeofflimits) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/timeofflimits | Creates a new time-off limit object |
| [**PostWorkforcemanagementBusinessunitTimeofflimitsValuesQuery**](#PostWorkforcemanagementBusinessunitTimeofflimitsValuesQuery) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/timeofflimits/values/query | Retrieves time-off limit related values based on a given set of filters. |
| [**PostWorkforcemanagementBusinessunitTimeoffplans**](#PostWorkforcemanagementBusinessunitTimeoffplans) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/timeoffplans | Creates a new time-off plan |
| [**PostWorkforcemanagementBusinessunitWeekScheduleAgentschedulesQuery**](#PostWorkforcemanagementBusinessunitWeekScheduleAgentschedulesQuery) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/agentschedules/query | Loads agent schedule data from the schedule. Used in combination with the metadata route |
| [**PostWorkforcemanagementBusinessunitWeekScheduleCopy**](#PostWorkforcemanagementBusinessunitWeekScheduleCopy) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/copy | Copy a schedule |
| [**PostWorkforcemanagementBusinessunitWeekSchedulePerformancepredictionsRecalculations**](#PostWorkforcemanagementBusinessunitWeekSchedulePerformancepredictionsRecalculations) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/performancepredictions/recalculations | Request a daily recalculation of the performance prediction for the associated schedule |
| [**PostWorkforcemanagementBusinessunitWeekSchedulePerformancepredictionsRecalculationsUploadurl**](#PostWorkforcemanagementBusinessunitWeekSchedulePerformancepredictionsRecalculationsUploadurl) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/performancepredictions/recalculations/uploadurl | Upload daily activity changes to be able to request a performance prediction recalculation |
| [**PostWorkforcemanagementBusinessunitWeekScheduleReschedule**](#PostWorkforcemanagementBusinessunitWeekScheduleReschedule) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/reschedule | Start a rescheduling run |
| [**PostWorkforcemanagementBusinessunitWeekScheduleUpdate**](#PostWorkforcemanagementBusinessunitWeekScheduleUpdate) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/update | Starts processing a schedule update |
| [**PostWorkforcemanagementBusinessunitWeekScheduleUpdateUploadurl**](#PostWorkforcemanagementBusinessunitWeekScheduleUpdateUploadurl) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/{scheduleId}/update/uploadurl | Creates a signed upload URL for updating a schedule |
| [**PostWorkforcemanagementBusinessunitWeekSchedules**](#PostWorkforcemanagementBusinessunitWeekSchedules) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules | Create a blank schedule |
| [**PostWorkforcemanagementBusinessunitWeekSchedulesGenerate**](#PostWorkforcemanagementBusinessunitWeekSchedulesGenerate) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/generate | Generate a schedule |
| [**PostWorkforcemanagementBusinessunitWeekSchedulesImport**](#PostWorkforcemanagementBusinessunitWeekSchedulesImport) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/import | Starts processing a schedule import |
| [**PostWorkforcemanagementBusinessunitWeekSchedulesImportUploadurl**](#PostWorkforcemanagementBusinessunitWeekSchedulesImportUploadurl) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekId}/schedules/import/uploadurl | Creates a signed upload URL for importing a schedule |
| [**PostWorkforcemanagementBusinessunitWeekShorttermforecastCopy**](#PostWorkforcemanagementBusinessunitWeekShorttermforecastCopy) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}/copy | Copy a short term forecast |
| [**PostWorkforcemanagementBusinessunitWeekShorttermforecastsGenerate**](#PostWorkforcemanagementBusinessunitWeekShorttermforecastsGenerate) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/generate | Generate a short term forecast |
| [**PostWorkforcemanagementBusinessunitWeekShorttermforecastsImport**](#PostWorkforcemanagementBusinessunitWeekShorttermforecastsImport) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/import | Starts importing the uploaded short term forecast |
| [**PostWorkforcemanagementBusinessunitWeekShorttermforecastsImportUploadurl**](#PostWorkforcemanagementBusinessunitWeekShorttermforecastsImportUploadurl) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/weeks/{weekDateId}/shorttermforecasts/import/uploadurl | Creates a signed upload URL for importing a short term forecast |
| [**PostWorkforcemanagementBusinessunitWorkplanbidCopy**](#PostWorkforcemanagementBusinessunitWorkplanbidCopy) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId}/copy | Copy a work plan bid |
| [**PostWorkforcemanagementBusinessunitWorkplanbidGroups**](#PostWorkforcemanagementBusinessunitWorkplanbidGroups) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids/{bidId}/groups | Add a bid group in a given work plan bid |
| [**PostWorkforcemanagementBusinessunitWorkplanbids**](#PostWorkforcemanagementBusinessunitWorkplanbids) | **Post** /api/v2/workforcemanagement/businessunits/{businessUnitId}/workplanbids | Create a new work plan bid |
| [**PostWorkforcemanagementBusinessunits**](#PostWorkforcemanagementBusinessunits) | **Post** /api/v2/workforcemanagement/businessunits | Add a new business unit |
| [**PostWorkforcemanagementCalendarUrlIcs**](#PostWorkforcemanagementCalendarUrlIcs) | **Post** /api/v2/workforcemanagement/calendar/url/ics | Create a newly generated calendar link for the current user; if the current user has previously generated one, the generated link will be returned |
| [**PostWorkforcemanagementHistoricaldataBulkRemoveJobs**](#PostWorkforcemanagementHistoricaldataBulkRemoveJobs) | **Post** /api/v2/workforcemanagement/historicaldata/bulk/remove/jobs | Delete the list of the historical data import entries |
| [**PostWorkforcemanagementHistoricaldataValidate**](#PostWorkforcemanagementHistoricaldataValidate) | **Post** /api/v2/workforcemanagement/historicaldata/validate | Trigger validation process for historical import |
| [**PostWorkforcemanagementIntegrationsHriTimeofftypesJobs**](#PostWorkforcemanagementIntegrationsHriTimeofftypesJobs) | **Post** /api/v2/workforcemanagement/integrations/hris/{hrisIntegrationId}/timeofftypes/jobs | Get list of time off types configured in integration |
| [**PostWorkforcemanagementManagementunitAgentsWorkplansQuery**](#PostWorkforcemanagementManagementunitAgentsWorkplansQuery) | **Post** /api/v2/workforcemanagement/managementunits/{managementUnitId}/agents/workplans/query | Get agents work plans configuration |
| [**PostWorkforcemanagementManagementunitAgentschedulesSearch**](#PostWorkforcemanagementManagementunitAgentschedulesSearch) | **Post** /api/v2/workforcemanagement/managementunits/{managementUnitId}/agentschedules/search | Query published schedules for given given time range for set of users |
| [**PostWorkforcemanagementManagementunitHistoricaladherencequery**](#PostWorkforcemanagementManagementunitHistoricaladherencequery) | **Post** /api/v2/workforcemanagement/managementunits/{managementUnitId}/historicaladherencequery | Request a historical adherence report |
| [**PostWorkforcemanagementManagementunitMove**](#PostWorkforcemanagementManagementunitMove) | **Post** /api/v2/workforcemanagement/managementunits/{managementUnitId}/move | Move the requested management unit to a new business unit |
| [**PostWorkforcemanagementManagementunitSchedulesSearch**](#PostWorkforcemanagementManagementunitSchedulesSearch) | **Post** /api/v2/workforcemanagement/managementunits/{managementUnitId}/schedules/search | Query published schedules for given given time range for set of users |
| [**PostWorkforcemanagementManagementunitShrinkageJobs**](#PostWorkforcemanagementManagementunitShrinkageJobs) | **Post** /api/v2/workforcemanagement/managementunits/{managementUnitId}/shrinkage/jobs | Request a historical shrinkage report |
| [**PostWorkforcemanagementManagementunitTimeofflimits**](#PostWorkforcemanagementManagementunitTimeofflimits) | **Post** /api/v2/workforcemanagement/managementunits/{managementUnitId}/timeofflimits | Creates a new time off limit object under management unit. |
| [**PostWorkforcemanagementManagementunitTimeofflimitsValuesQuery**](#PostWorkforcemanagementManagementunitTimeofflimitsValuesQuery) | **Post** /api/v2/workforcemanagement/managementunits/{managementUnitId}/timeofflimits/values/query | Retrieves time off limit related values based on a given set of filters. |
| [**PostWorkforcemanagementManagementunitTimeoffplans**](#PostWorkforcemanagementManagementunitTimeoffplans) | **Post** /api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffplans | Creates a new time off plan |
| [**PostWorkforcemanagementManagementunitTimeoffrequests**](#PostWorkforcemanagementManagementunitTimeoffrequests) | **Post** /api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffrequests | Create a new time off request |
| [**PostWorkforcemanagementManagementunitTimeoffrequestsIntegrationstatusQuery**](#PostWorkforcemanagementManagementunitTimeoffrequestsIntegrationstatusQuery) | **Post** /api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffrequests/integrationstatus/query | Retrieves integration statuses for a list of time off requests |
| [**PostWorkforcemanagementManagementunitTimeoffrequestsQuery**](#PostWorkforcemanagementManagementunitTimeoffrequestsQuery) | **Post** /api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffrequests/query | Fetches time off requests matching the conditions specified in the request body |
| [**PostWorkforcemanagementManagementunitTimeoffrequestsWaitlistpositionsQuery**](#PostWorkforcemanagementManagementunitTimeoffrequestsWaitlistpositionsQuery) | **Post** /api/v2/workforcemanagement/managementunits/{managementUnitId}/timeoffrequests/waitlistpositions/query | Retrieves daily waitlist position for a list of time off requests |
| [**PostWorkforcemanagementManagementunitUserTimeoffbalanceJobs**](#PostWorkforcemanagementManagementunitUserTimeoffbalanceJobs) | **Post** /api/v2/workforcemanagement/managementunits/{managementUnitId}/users/{userId}/timeoffbalance/jobs | Query time off balances for a given user for specified activity code and dates |
| [**PostWorkforcemanagementManagementunitUserTimeoffrequestTimeoffbalanceJobs**](#PostWorkforcemanagementManagementunitUserTimeoffrequestTimeoffbalanceJobs) | **Post** /api/v2/workforcemanagement/managementunits/{managementUnitId}/users/{userId}/timeoffrequests/{timeOffRequestId}/timeoffbalance/jobs | Query time off balances for dates spanned by a given time off request |
| [**PostWorkforcemanagementManagementunitUserTimeoffrequestsEstimate**](#PostWorkforcemanagementManagementunitUserTimeoffrequestsEstimate) | **Post** /api/v2/workforcemanagement/managementunits/{managementUnitId}/users/{userId}/timeoffrequests/estimate | Estimates available time off for an agent |
| [**PostWorkforcemanagementManagementunitWeekShifttradeMatch**](#PostWorkforcemanagementManagementunitWeekShifttradeMatch) | **Post** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shifttrades/{tradeId}/match | Matches a shift trade. This route can only be called by the receiving agent |
| [**PostWorkforcemanagementManagementunitWeekShifttrades**](#PostWorkforcemanagementManagementunitWeekShifttrades) | **Post** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shifttrades | Adds a shift trade |
| [**PostWorkforcemanagementManagementunitWeekShifttradesSearch**](#PostWorkforcemanagementManagementunitWeekShifttradesSearch) | **Post** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shifttrades/search | Searches for potential shift trade matches for the current agent |
| [**PostWorkforcemanagementManagementunitWeekShifttradesStateBulk**](#PostWorkforcemanagementManagementunitWeekShifttradesStateBulk) | **Post** /api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shifttrades/state/bulk | Updates the state of a batch of shift trades |
| [**PostWorkforcemanagementManagementunitWorkplanCopy**](#PostWorkforcemanagementManagementunitWorkplanCopy) | **Post** /api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId}/copy | Create a copy of work plan |
| [**PostWorkforcemanagementManagementunitWorkplanValidate**](#PostWorkforcemanagementManagementunitWorkplanValidate) | **Post** /api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId}/validate | Validate Work Plan |
| [**PostWorkforcemanagementManagementunitWorkplanrotationCopy**](#PostWorkforcemanagementManagementunitWorkplanrotationCopy) | **Post** /api/v2/workforcemanagement/managementunits/{managementUnitId}/workplanrotations/{workPlanRotationId}/copy | Create a copy of work plan rotation |
| [**PostWorkforcemanagementManagementunitWorkplanrotations**](#PostWorkforcemanagementManagementunitWorkplanrotations) | **Post** /api/v2/workforcemanagement/managementunits/{managementUnitId}/workplanrotations | Create a new work plan rotation |
| [**PostWorkforcemanagementManagementunitWorkplans**](#PostWorkforcemanagementManagementunitWorkplans) | **Post** /api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans | Create a new work plan |
| [**PostWorkforcemanagementManagementunits**](#PostWorkforcemanagementManagementunits) | **Post** /api/v2/workforcemanagement/managementunits | Add a management unit |
| [**PostWorkforcemanagementNotificationsUpdate**](#PostWorkforcemanagementNotificationsUpdate) | **Post** /api/v2/workforcemanagement/notifications/update | Mark a list of notifications as read or unread |
| [**PostWorkforcemanagementSchedules**](#PostWorkforcemanagementSchedules) | **Post** /api/v2/workforcemanagement/schedules | Get published schedule for the current user |
| [**PostWorkforcemanagementTeamAdherenceHistorical**](#PostWorkforcemanagementTeamAdherenceHistorical) | **Post** /api/v2/workforcemanagement/teams/{teamId}/adherence/historical | Request a teams historical adherence report |
| [**PostWorkforcemanagementTeamShrinkageJobs**](#PostWorkforcemanagementTeamShrinkageJobs) | **Post** /api/v2/workforcemanagement/teams/{teamId}/shrinkage/jobs | Request a historical shrinkage report |
| [**PostWorkforcemanagementTimeoffbalanceJobs**](#PostWorkforcemanagementTimeoffbalanceJobs) | **Post** /api/v2/workforcemanagement/timeoffbalance/jobs | Query time off balances for the current user for specified activity code and dates |
| [**PostWorkforcemanagementTimeofflimitsAvailableQuery**](#PostWorkforcemanagementTimeofflimitsAvailableQuery) | **Post** /api/v2/workforcemanagement/timeofflimits/available/query | Queries available time off for the current user |
| [**PostWorkforcemanagementTimeoffrequests**](#PostWorkforcemanagementTimeoffrequests) | **Post** /api/v2/workforcemanagement/timeoffrequests | Create a time off request for the current user |
| [**PostWorkforcemanagementTimeoffrequestsEstimate**](#PostWorkforcemanagementTimeoffrequestsEstimate) | **Post** /api/v2/workforcemanagement/timeoffrequests/estimate | Estimates available time off for current user |
| [**PostWorkforcemanagementTimeoffrequestsIntegrationstatusQuery**](#PostWorkforcemanagementTimeoffrequestsIntegrationstatusQuery) | **Post** /api/v2/workforcemanagement/timeoffrequests/integrationstatus/query | Retrieves integration statuses for a list of current user time off requests |
| [**PutWorkforcemanagementAgentIntegrationsHris**](#PutWorkforcemanagementAgentIntegrationsHris) | **Put** /api/v2/workforcemanagement/agents/{agentId}/integrations/hris | Update integrations for agent |
| [**PutWorkforcemanagementBusinessunitTimeofflimitValues**](#PutWorkforcemanagementBusinessunitTimeofflimitValues) | **Put** /api/v2/workforcemanagement/businessunits/{businessUnitId}/timeofflimits/{timeOffLimitId}/values | Sets daily values for a date range of time-off limit object |
| [**PutWorkforcemanagementManagementunitTimeofflimitValues**](#PutWorkforcemanagementManagementunitTimeofflimitValues) | **Put** /api/v2/workforcemanagement/managementunits/{managementUnitId}/timeofflimits/{timeOffLimitId}/values | Sets daily values for a date range of time off limit object |



## DeleteWorkforcemanagementBusinessunit

> void DeleteWorkforcemanagementBusinessunit (string businessUnitId)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

### Return type

void (empty response body)


## DeleteWorkforcemanagementBusinessunitActivitycode

> void DeleteWorkforcemanagementBusinessunitActivitycode (string businessUnitId, string activityCodeId)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit, or 'mine' for the business unit of the logged-in user.
            var activityCodeId = activityCodeId_example;  // string | The ID of the activity code to delete

            try
            { 
                // Deletes an activity code
                apiInstance.DeleteWorkforcemanagementBusinessunitActivitycode(businessUnitId, activityCodeId);
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
| **businessUnitId** | **string**| The ID of the business unit, or &#39;mine&#39; for the business unit of the logged-in user. |  |
| **activityCodeId** | **string**| The ID of the activity code to delete |  |

### Return type

void (empty response body)


## DeleteWorkforcemanagementBusinessunitCapacityplanStaffinggroupallocationshistory

> void DeleteWorkforcemanagementBusinessunitCapacityplanStaffinggroupallocationshistory (string businessUnitId, string capacityPlanId, String beforeDateId = null)


Delete staffing group allocations history created for a capacity plan before the given date

Requires ANY permissions: 

* wfm:capacityPlan:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteWorkforcemanagementBusinessunitCapacityplanStaffinggroupallocationshistoryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var capacityPlanId = capacityPlanId_example;  // string | The ID of the capacity plan
            var beforeDateId = 2013-10-20;  // String | The date to delete records that are created on or before this date in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional) 

            try
            { 
                // Delete staffing group allocations history created for a capacity plan before the given date
                apiInstance.DeleteWorkforcemanagementBusinessunitCapacityplanStaffinggroupallocationshistory(businessUnitId, capacityPlanId, beforeDateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.DeleteWorkforcemanagementBusinessunitCapacityplanStaffinggroupallocationshistory: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **capacityPlanId** | **string**| The ID of the capacity plan |  |
| **beforeDateId** | **String**| The date to delete records that are created on or before this date in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional]  |

### Return type

void (empty response body)


## DeleteWorkforcemanagementBusinessunitPlanninggroup

> void DeleteWorkforcemanagementBusinessunitPlanninggroup (string businessUnitId, string planningGroupId)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

### Return type

void (empty response body)


## DeleteWorkforcemanagementBusinessunitSchedulingRun

> void DeleteWorkforcemanagementBusinessunitSchedulingRun (string businessUnitId, string runId)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

### Return type

void (empty response body)


## DeleteWorkforcemanagementBusinessunitServicegoaltemplate

> void DeleteWorkforcemanagementBusinessunitServicegoaltemplate (string businessUnitId, string serviceGoalTemplateId)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

### Return type

void (empty response body)


## DeleteWorkforcemanagementBusinessunitStaffinggroup

> void DeleteWorkforcemanagementBusinessunitStaffinggroup (string businessUnitId, string staffingGroupId)


Deletes a staffing group

Requires ANY permissions: 

* wfm:staffingGroup:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteWorkforcemanagementBusinessunitStaffinggroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var staffingGroupId = staffingGroupId_example;  // string | The ID of the staffing group to delete

            try
            { 
                // Deletes a staffing group
                apiInstance.DeleteWorkforcemanagementBusinessunitStaffinggroup(businessUnitId, staffingGroupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.DeleteWorkforcemanagementBusinessunitStaffinggroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **staffingGroupId** | **string**| The ID of the staffing group to delete |  |

### Return type

void (empty response body)


## DeleteWorkforcemanagementBusinessunitTimeofflimit

> void DeleteWorkforcemanagementBusinessunitTimeofflimit (string businessUnitId, string timeOffLimitId)


Deletes a time-off limit object

Requires ANY permissions: 

* wfm:timeOffLimit:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteWorkforcemanagementBusinessunitTimeofflimitExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var timeOffLimitId = timeOffLimitId_example;  // string | The ID of the time-off limit object to delete

            try
            { 
                // Deletes a time-off limit object
                apiInstance.DeleteWorkforcemanagementBusinessunitTimeofflimit(businessUnitId, timeOffLimitId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.DeleteWorkforcemanagementBusinessunitTimeofflimit: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **timeOffLimitId** | **string**| The ID of the time-off limit object to delete |  |

### Return type

void (empty response body)


## DeleteWorkforcemanagementBusinessunitTimeoffplan

> void DeleteWorkforcemanagementBusinessunitTimeoffplan (string businessUnitId, string timeOffPlanId)


Deletes a time-off plan

Requires ANY permissions: 

* wfm:timeOffPlan:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteWorkforcemanagementBusinessunitTimeoffplanExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var timeOffPlanId = timeOffPlanId_example;  // string | The ID of the time-off plan to delete

            try
            { 
                // Deletes a time-off plan
                apiInstance.DeleteWorkforcemanagementBusinessunitTimeoffplan(businessUnitId, timeOffPlanId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.DeleteWorkforcemanagementBusinessunitTimeoffplan: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **timeOffPlanId** | **string**| The ID of the time-off plan to delete |  |

### Return type

void (empty response body)


## DeleteWorkforcemanagementBusinessunitWeekSchedule

> [**BuAsyncScheduleResponse**](BuAsyncScheduleResponse) DeleteWorkforcemanagementBusinessunitWeekSchedule (string businessUnitId, String weekId, string scheduleId)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var weekId = 2013-10-20;  // String | First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
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
| **weekId** | **String**| First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **scheduleId** | **string**| The ID of the schedule |  |

### Return type

[**BuAsyncScheduleResponse**](BuAsyncScheduleResponse)


## DeleteWorkforcemanagementBusinessunitWeekShorttermforecast

> void DeleteWorkforcemanagementBusinessunitWeekShorttermforecast (string businessUnitId, String weekDateId, string forecastId)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit to which the forecast belongs
            var weekDateId = 2013-10-20;  // String | The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
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
| **businessUnitId** | **string**| The ID of the business unit to which the forecast belongs |  |
| **weekDateId** | **String**| The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **forecastId** | **string**| The ID of the forecast |  |

### Return type

void (empty response body)


## DeleteWorkforcemanagementBusinessunitWorkplanbid

> void DeleteWorkforcemanagementBusinessunitWorkplanbid (string businessUnitId, string bidId)


Delete a work plan bid

Requires ANY permissions: 

* wfm:workPlanBid:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteWorkforcemanagementBusinessunitWorkplanbidExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var bidId = bidId_example;  // string | The ID of the work plan bid

            try
            { 
                // Delete a work plan bid
                apiInstance.DeleteWorkforcemanagementBusinessunitWorkplanbid(businessUnitId, bidId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.DeleteWorkforcemanagementBusinessunitWorkplanbid: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **bidId** | **string**| The ID of the work plan bid |  |

### Return type

void (empty response body)


## DeleteWorkforcemanagementBusinessunitWorkplanbidGroup

> void DeleteWorkforcemanagementBusinessunitWorkplanbidGroup (string businessUnitId, string bidId, string bidGroupId)


Delete a bid group by bid group Id

Requires ANY permissions: 

* wfm:workPlanBidGroup:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteWorkforcemanagementBusinessunitWorkplanbidGroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var bidId = bidId_example;  // string | The work plan bid id of the bid groups
            var bidGroupId = bidGroupId_example;  // string | Work Plan Bid Group id

            try
            { 
                // Delete a bid group by bid group Id
                apiInstance.DeleteWorkforcemanagementBusinessunitWorkplanbidGroup(businessUnitId, bidId, bidGroupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.DeleteWorkforcemanagementBusinessunitWorkplanbidGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **bidId** | **string**| The work plan bid id of the bid groups |  |
| **bidGroupId** | **string**| Work Plan Bid Group id |  |

### Return type

void (empty response body)


## DeleteWorkforcemanagementCalendarUrlIcs

> void DeleteWorkforcemanagementCalendarUrlIcs ()


Disable generated calendar link for the current user

Requires ALL permissions: 

* wfm:agentSchedule:sync

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteWorkforcemanagementCalendarUrlIcsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();

            try
            { 
                // Disable generated calendar link for the current user
                apiInstance.DeleteWorkforcemanagementCalendarUrlIcs();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.DeleteWorkforcemanagementCalendarUrlIcs: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

void (empty response body)


## DeleteWorkforcemanagementManagementunit

> void DeleteWorkforcemanagementManagementunit (string managementUnitId)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.

            try
            { 
                // Delete management unit
                apiInstance.DeleteWorkforcemanagementManagementunit(managementUnitId);
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
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |

### Return type

void (empty response body)


## DeleteWorkforcemanagementManagementunitTimeofflimit

> void DeleteWorkforcemanagementManagementunitTimeofflimit (string managementUnitId, string timeOffLimitId)


Deletes a time off limit object

Requires ANY permissions: 

* wfm:timeOffLimit:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteWorkforcemanagementManagementunitTimeofflimitExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit.
            var timeOffLimitId = timeOffLimitId_example;  // string | The ID of the time off limit object to delete

            try
            { 
                // Deletes a time off limit object
                apiInstance.DeleteWorkforcemanagementManagementunitTimeofflimit(managementUnitId, timeOffLimitId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.DeleteWorkforcemanagementManagementunitTimeofflimit: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit. |  |
| **timeOffLimitId** | **string**| The ID of the time off limit object to delete |  |

### Return type

void (empty response body)


## DeleteWorkforcemanagementManagementunitTimeoffplan

> void DeleteWorkforcemanagementManagementunitTimeoffplan (string managementUnitId, string timeOffPlanId)


Deletes a time off plan

Requires ANY permissions: 

* wfm:timeOffPlan:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteWorkforcemanagementManagementunitTimeoffplanExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit
            var timeOffPlanId = timeOffPlanId_example;  // string | The ID of the time off plan to delete

            try
            { 
                // Deletes a time off plan
                apiInstance.DeleteWorkforcemanagementManagementunitTimeoffplan(managementUnitId, timeOffPlanId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.DeleteWorkforcemanagementManagementunitTimeoffplan: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit |  |
| **timeOffPlanId** | **string**| The ID of the time off plan to delete |  |

### Return type

void (empty response body)


## DeleteWorkforcemanagementManagementunitWorkplan

> void DeleteWorkforcemanagementManagementunitWorkplan (string managementUnitId, string workPlanId)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

### Return type

void (empty response body)


## DeleteWorkforcemanagementManagementunitWorkplanrotation

> void DeleteWorkforcemanagementManagementunitWorkplanrotation (string managementUnitId, string workPlanRotationId)


Delete a work plan rotation

Requires ANY permissions: 

* wfm:workPlanRotation:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteWorkforcemanagementManagementunitWorkplanrotationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var workPlanRotationId = workPlanRotationId_example;  // string | The ID of the work plan rotation to be deleted

            try
            { 
                // Delete a work plan rotation
                apiInstance.DeleteWorkforcemanagementManagementunitWorkplanrotation(managementUnitId, workPlanRotationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.DeleteWorkforcemanagementManagementunitWorkplanrotation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **workPlanRotationId** | **string**| The ID of the work plan rotation to be deleted |  |

### Return type

void (empty response body)


## GetWorkforcemanagementAdherence

> [**List&lt;UserScheduleAdherence&gt;**](UserScheduleAdherence) GetWorkforcemanagementAdherence (List<string> userId)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var userId = new List<string>(); // List<string> | User Id(s) for which to fetch current schedule adherence information.  Min 1, Max of 100 userIds per request

            try
            { 
                // Get a list of UserScheduleAdherence records for the requested users
                List<UserScheduleAdherence> result = apiInstance.GetWorkforcemanagementAdherence(userId);
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
| **userId** | [**List<string>**](string)| User Id(s) for which to fetch current schedule adherence information.  Min 1, Max of 100 userIds per request |  |

### Return type

[**List<UserScheduleAdherence>**](UserScheduleAdherence)


## GetWorkforcemanagementAdherenceExplanation

> [**AdherenceExplanationResponse**](AdherenceExplanationResponse) GetWorkforcemanagementAdherenceExplanation (string explanationId)


Get an adherence explanation for the current user

Requires ANY permissions: 

* wfm:agentAdherenceExplanation:submit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementAdherenceExplanationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var explanationId = explanationId_example;  // string | The ID of the explanation to update

            try
            { 
                // Get an adherence explanation for the current user
                AdherenceExplanationResponse result = apiInstance.GetWorkforcemanagementAdherenceExplanation(explanationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementAdherenceExplanation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **explanationId** | **string**| The ID of the explanation to update |  |

### Return type

[**AdherenceExplanationResponse**](AdherenceExplanationResponse)


## GetWorkforcemanagementAdherenceExplanationsJob

> [**AdherenceExplanationJob**](AdherenceExplanationJob) GetWorkforcemanagementAdherenceExplanationsJob (string jobId)


Query the status of an adherence explanation operation. Only the user who started the operation can query the status

Job details are only retained if the initial request returned a 202 ACCEPTED response

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
    public class GetWorkforcemanagementAdherenceExplanationsJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var jobId = jobId_example;  // string | The ID of the job

            try
            { 
                // Query the status of an adherence explanation operation. Only the user who started the operation can query the status
                AdherenceExplanationJob result = apiInstance.GetWorkforcemanagementAdherenceExplanationsJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementAdherenceExplanationsJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| The ID of the job |  |

### Return type

[**AdherenceExplanationJob**](AdherenceExplanationJob)


## GetWorkforcemanagementAdherenceHistoricalBulkJob

> [**WfmHistoricalAdherenceBulkResponse**](WfmHistoricalAdherenceBulkResponse) GetWorkforcemanagementAdherenceHistoricalBulkJob (string jobId)


Request to fetch the status of the historical adherence bulk job. Only the user who started the operation can query the status

Job details are only retained if the initial request returned a 202 ACCEPTED response

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
    public class GetWorkforcemanagementAdherenceHistoricalBulkJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var jobId = jobId_example;  // string | ID of the job to get

            try
            { 
                // Request to fetch the status of the historical adherence bulk job. Only the user who started the operation can query the status
                WfmHistoricalAdherenceBulkResponse result = apiInstance.GetWorkforcemanagementAdherenceHistoricalBulkJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementAdherenceHistoricalBulkJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| ID of the job to get |  |

### Return type

[**WfmHistoricalAdherenceBulkResponse**](WfmHistoricalAdherenceBulkResponse)


## GetWorkforcemanagementAdherenceHistoricalJob

> [**WfmHistoricalAdherenceResponse**](WfmHistoricalAdherenceResponse) GetWorkforcemanagementAdherenceHistoricalJob (string jobId)


Query the status of a historical adherence request operation. Only the user who started the operation can query the status

Job details are only retained if the initial request returned a 202 ACCEPTED response

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
    public class GetWorkforcemanagementAdherenceHistoricalJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Query the status of a historical adherence request operation. Only the user who started the operation can query the status
                WfmHistoricalAdherenceResponse result = apiInstance.GetWorkforcemanagementAdherenceHistoricalJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementAdherenceHistoricalJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |

### Return type

[**WfmHistoricalAdherenceResponse**](WfmHistoricalAdherenceResponse)


## GetWorkforcemanagementAgentAdherenceExplanation

> [**AdherenceExplanationResponse**](AdherenceExplanationResponse) GetWorkforcemanagementAgentAdherenceExplanation (string agentId, string explanationId)


Get an adherence explanation

Requires ANY permissions: 

* wfm:adherenceExplanation:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementAgentAdherenceExplanationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var agentId = agentId_example;  // string | The ID of the agent to query
            var explanationId = explanationId_example;  // string | The ID of the explanation to update

            try
            { 
                // Get an adherence explanation
                AdherenceExplanationResponse result = apiInstance.GetWorkforcemanagementAgentAdherenceExplanation(agentId, explanationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementAgentAdherenceExplanation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **agentId** | **string**| The ID of the agent to query |  |
| **explanationId** | **string**| The ID of the explanation to update |  |

### Return type

[**AdherenceExplanationResponse**](AdherenceExplanationResponse)


## GetWorkforcemanagementAgentManagementunit

> [**AgentManagementUnitReference**](AgentManagementUnitReference) GetWorkforcemanagementAgentManagementunit (string agentId)


Get the management unit to which the agent belongs

Requires ANY permissions: 

* wfm:agent:view
* wfm:publishedSchedule:view
* wfm:schedule:view
* coaching:appointment:add
* coaching:appointment:edit
* learning:assignment:add
* learning:assignment:reschedule

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementAgentManagementunitExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var agentId = agentId_example;  // string | The ID of the agent to look up

            try
            { 
                // Get the management unit to which the agent belongs
                AgentManagementUnitReference result = apiInstance.GetWorkforcemanagementAgentManagementunit(agentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementAgentManagementunit: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **agentId** | **string**| The ID of the agent to look up |  |

### Return type

[**AgentManagementUnitReference**](AgentManagementUnitReference)


## GetWorkforcemanagementAgentsMeManagementunit

> [**AgentManagementUnitReference**](AgentManagementUnitReference) GetWorkforcemanagementAgentsMeManagementunit ()


Get the management unit to which the currently logged in agent belongs

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
* wfm:timeOffLimit:add
* wfm:timeOffLimit:delete
* wfm:timeOffLimit:edit
* wfm:timeOffLimit:view
* wfm:timeOffPlan:add
* wfm:timeOffPlan:delete
* wfm:timeOffPlan:edit
* wfm:timeOffPlan:view
* wfm:timeOffRequest:add
* wfm:timeOffRequest:edit
* wfm:timeOffRequest:view
* wfm:workPlan:add
* wfm:workPlan:delete
* wfm:workPlan:edit
* wfm:workPlan:view
* wfm:workPlanRotation:add
* wfm:workPlanRotation:delete
* wfm:workPlanRotation:edit
* wfm:workPlanRotation:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementAgentsMeManagementunitExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();

            try
            { 
                // Get the management unit to which the currently logged in agent belongs
                AgentManagementUnitReference result = apiInstance.GetWorkforcemanagementAgentsMeManagementunit();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementAgentsMeManagementunit: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**AgentManagementUnitReference**](AgentManagementUnitReference)


## GetWorkforcemanagementAlternativeshiftsOffersJob

> [**AlternativeShiftJobResponse**](AlternativeShiftJobResponse) GetWorkforcemanagementAlternativeshiftsOffersJob (string jobId)


Query the status of an alternative shift offers operation. Only the user who started the operation can query the status

Job details are only retained if the initial request returned a 202 ACCEPTED response

Requires ANY permissions: 

* wfm:agentAlternativeShift:submit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementAlternativeshiftsOffersJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var jobId = jobId_example;  // string | The ID of the job

            try
            { 
                // Query the status of an alternative shift offers operation. Only the user who started the operation can query the status
                AlternativeShiftJobResponse result = apiInstance.GetWorkforcemanagementAlternativeshiftsOffersJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementAlternativeshiftsOffersJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| The ID of the job |  |

### Return type

[**AlternativeShiftJobResponse**](AlternativeShiftJobResponse)


## GetWorkforcemanagementAlternativeshiftsOffersSearchJob

> [**AlternativeShiftJobResponse**](AlternativeShiftJobResponse) GetWorkforcemanagementAlternativeshiftsOffersSearchJob (string jobId)


Query the status of an alternative shift search offers operation. Only the user who started the operation can query the status

Job details are only retained if the initial request returned a 202 ACCEPTED response

Requires ANY permissions: 

* wfm:agentAlternativeShift:submit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementAlternativeshiftsOffersSearchJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var jobId = jobId_example;  // string | The ID of the job

            try
            { 
                // Query the status of an alternative shift search offers operation. Only the user who started the operation can query the status
                AlternativeShiftJobResponse result = apiInstance.GetWorkforcemanagementAlternativeshiftsOffersSearchJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementAlternativeshiftsOffersSearchJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| The ID of the job |  |

### Return type

[**AlternativeShiftJobResponse**](AlternativeShiftJobResponse)


## GetWorkforcemanagementAlternativeshiftsSettings

> [**AlternativeShiftBuSettingsResponse**](AlternativeShiftBuSettingsResponse) GetWorkforcemanagementAlternativeshiftsSettings ()


Get alternative shifts settings from the current logged in agent’s business unit

Requires ANY permissions: 

* wfm:agentAlternativeShift:submit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementAlternativeshiftsSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();

            try
            { 
                // Get alternative shifts settings from the current logged in agent’s business unit
                AlternativeShiftBuSettingsResponse result = apiInstance.GetWorkforcemanagementAlternativeshiftsSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementAlternativeshiftsSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**AlternativeShiftBuSettingsResponse**](AlternativeShiftBuSettingsResponse)


## GetWorkforcemanagementAlternativeshiftsTrade

> [**AlternativeShiftTradeResponse**](AlternativeShiftTradeResponse) GetWorkforcemanagementAlternativeshiftsTrade (string tradeId)


Get my alternative shift trade by trade ID

Requires ANY permissions: 

* wfm:agentAlternativeShift:submit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementAlternativeshiftsTradeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var tradeId = tradeId_example;  // string | The ID of the alternative shift trade

            try
            { 
                // Get my alternative shift trade by trade ID
                AlternativeShiftTradeResponse result = apiInstance.GetWorkforcemanagementAlternativeshiftsTrade(tradeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementAlternativeshiftsTrade: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **tradeId** | **string**| The ID of the alternative shift trade |  |

### Return type

[**AlternativeShiftTradeResponse**](AlternativeShiftTradeResponse)


## GetWorkforcemanagementAlternativeshiftsTrades

> [**ListAlternativeShiftTradesResponse**](ListAlternativeShiftTradesResponse) GetWorkforcemanagementAlternativeshiftsTrades (bool? forceAsync = null)


Get a list of my alternative shifts trades

Requires ANY permissions: 

* wfm:agentAlternativeShift:submit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementAlternativeshiftsTradesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var forceAsync = true;  // bool? | Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional) 

            try
            { 
                // Get a list of my alternative shifts trades
                ListAlternativeShiftTradesResponse result = apiInstance.GetWorkforcemanagementAlternativeshiftsTrades(forceAsync);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementAlternativeshiftsTrades: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **forceAsync** | **bool?**| Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes | [optional]  |

### Return type

[**ListAlternativeShiftTradesResponse**](ListAlternativeShiftTradesResponse)


## GetWorkforcemanagementAlternativeshiftsTradesJob

> [**AlternativeShiftJobResponse**](AlternativeShiftJobResponse) GetWorkforcemanagementAlternativeshiftsTradesJob (string jobId)


Query the status of an alternative shift trades operation. Only the user who started the operation can query the status

Job details are only retained if the initial request returned a 202 ACCEPTED response

Requires ANY permissions: 

* wfm:agentAlternativeShift:submit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementAlternativeshiftsTradesJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var jobId = jobId_example;  // string | The ID of the job

            try
            { 
                // Query the status of an alternative shift trades operation. Only the user who started the operation can query the status
                AlternativeShiftJobResponse result = apiInstance.GetWorkforcemanagementAlternativeshiftsTradesJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementAlternativeshiftsTradesJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| The ID of the job |  |

### Return type

[**AlternativeShiftJobResponse**](AlternativeShiftJobResponse)


## GetWorkforcemanagementAlternativeshiftsTradesStateJob

> [**AlternativeShiftJobResponse**](AlternativeShiftJobResponse) GetWorkforcemanagementAlternativeshiftsTradesStateJob (string jobId)


Query the status of an alternative shift trade state operation. Only the user who started the operation can query the status

Job details are only retained if the initial request returned a 202 ACCEPTED response

Requires ANY permissions: 

* wfm:alternativeShift:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementAlternativeshiftsTradesStateJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var jobId = jobId_example;  // string | The ID of the job

            try
            { 
                // Query the status of an alternative shift trade state operation. Only the user who started the operation can query the status
                AlternativeShiftJobResponse result = apiInstance.GetWorkforcemanagementAlternativeshiftsTradesStateJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementAlternativeshiftsTradesStateJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| The ID of the job |  |

### Return type

[**AlternativeShiftJobResponse**](AlternativeShiftJobResponse)


## GetWorkforcemanagementBusinessunit

> [**BusinessUnitResponse**](BusinessUnitResponse) GetWorkforcemanagementBusinessunit (string businessUnitId, List<string> expand = null, bool? includeSchedulingDefaultMessageSeverities = null)


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
* wfm:shrinkage:view
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
* wfm:staffingGroup:add
* wfm:staffingGroup:delete
* wfm:staffingGroup:edit
* wfm:staffingGroup:view
* wfm:timeOffRequest:add
* wfm:timeOffRequest:edit
* wfm:timeOffRequest:view
* wfm:timeOffLimit:add
* wfm:timeOffLimit:delete
* wfm:timeOffLimit:edit
* wfm:timeOffLimit:view
* wfm:timeOffPlan:add
* wfm:timeOffPlan:delete
* wfm:timeOffPlan:edit
* wfm:timeOffPlan:view
* wfm:timeOffRequest:add
* wfm:timeOffRequest:edit
* wfm:timeOffRequest:view
* wfm:workPlan:add
* wfm:workPlan:delete
* wfm:workPlan:edit
* wfm:workPlan:view
* wfm:workPlanRotation:add
* wfm:workPlanRotation:delete
* wfm:workPlanRotation:edit
* wfm:workPlanRotation:view
* coaching:appointment:add
* coaching:appointment:edit
* learning:assignment:add
* learning:assignment:reschedule

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit, or 'mine' for the business unit of the logged-in user.
            var expand = new List<string>(); // List<string> | Include to access additional data on the business unit (optional) 
            var includeSchedulingDefaultMessageSeverities = true;  // bool? | Whether to include scheduling default message severities (optional) 

            try
            { 
                // Get business unit
                BusinessUnitResponse result = apiInstance.GetWorkforcemanagementBusinessunit(businessUnitId, expand, includeSchedulingDefaultMessageSeverities);
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
| **expand** | [**List<string>**](string)| Include to access additional data on the business unit | [optional] <br />**Values**: settings, settings.timeZone, settings.startDayOfWeek, settings.shortTermForecasting, settings.scheduling, settings.notifications.scheduling, settings.learning, settings.coaching |
| **includeSchedulingDefaultMessageSeverities** | **bool?**| Whether to include scheduling default message severities | [optional]  |

### Return type

[**BusinessUnitResponse**](BusinessUnitResponse)


## GetWorkforcemanagementBusinessunitActivitycode

> [**BusinessUnitActivityCode**](BusinessUnitActivityCode) GetWorkforcemanagementBusinessunitActivitycode (string businessUnitId, string activityCodeId)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit, or 'mine' for the business unit of the logged-in user.
            var activityCodeId = activityCodeId_example;  // string | The ID of the activity code to fetch

            try
            { 
                // Get an activity code
                BusinessUnitActivityCode result = apiInstance.GetWorkforcemanagementBusinessunitActivitycode(businessUnitId, activityCodeId);
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
| **businessUnitId** | **string**| The ID of the business unit, or &#39;mine&#39; for the business unit of the logged-in user. |  |
| **activityCodeId** | **string**| The ID of the activity code to fetch |  |

### Return type

[**BusinessUnitActivityCode**](BusinessUnitActivityCode)


## GetWorkforcemanagementBusinessunitActivitycodes

> [**BusinessUnitActivityCodeListing**](BusinessUnitActivityCodeListing) GetWorkforcemanagementBusinessunitActivitycodes (string businessUnitId, bool? forceDownloadService = null)


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
* wfm:shrinkage:view
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
* wfm:timeOffLimit:add
* wfm:timeOffLimit:delete
* wfm:timeOffLimit:edit
* wfm:timeOffLimit:view
* wfm:timeOffPlan:add
* wfm:timeOffPlan:delete
* wfm:timeOffPlan:edit
* wfm:timeOffPlan:view
* wfm:timeOffRequest:add
* wfm:timeOffRequest:edit
* wfm:timeOffRequest:view
* wfm:workPlan:add
* wfm:workPlan:delete
* wfm:workPlan:edit
* wfm:workPlan:view
* wfm:workPlanRotation:add
* wfm:workPlanRotation:delete
* wfm:workPlanRotation:edit
* wfm:workPlanRotation:view

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit, or 'mine' for the business unit of the logged-in user.
            var forceDownloadService = true;  // bool? | Force the result of this operation to be sent via download service. For testing/app development purposes (optional) 

            try
            { 
                // Get activity codes
                BusinessUnitActivityCodeListing result = apiInstance.GetWorkforcemanagementBusinessunitActivitycodes(businessUnitId, forceDownloadService);
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
| **businessUnitId** | **string**| The ID of the business unit, or &#39;mine&#39; for the business unit of the logged-in user. |  |
| **forceDownloadService** | **bool?**| Force the result of this operation to be sent via download service. For testing/app development purposes | [optional]  |

### Return type

[**BusinessUnitActivityCodeListing**](BusinessUnitActivityCodeListing)


## GetWorkforcemanagementBusinessunitActivityplan

> [**ActivityPlanResponse**](ActivityPlanResponse) GetWorkforcemanagementBusinessunitActivityplan (string businessUnitId, string activityPlanId)


Get an activity plan

Requires ANY permissions: 

* wfm:activityPlan:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementBusinessunitActivityplanExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var activityPlanId = activityPlanId_example;  // string | The ID of the activity plan to fetch

            try
            { 
                // Get an activity plan
                ActivityPlanResponse result = apiInstance.GetWorkforcemanagementBusinessunitActivityplan(businessUnitId, activityPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitActivityplan: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **activityPlanId** | **string**| The ID of the activity plan to fetch |  |

### Return type

[**ActivityPlanResponse**](ActivityPlanResponse)


## GetWorkforcemanagementBusinessunitActivityplanRunsJob

> [**ActivityPlanRunJobResponse**](ActivityPlanRunJobResponse) GetWorkforcemanagementBusinessunitActivityplanRunsJob (string businessUnitId, string activityPlanId, string jobId)


Gets an activity plan run job

Requires ANY permissions: 

* wfm:activityPlanRunJob:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementBusinessunitActivityplanRunsJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var activityPlanId = activityPlanId_example;  // string | The ID of the activity plan associated with the run job
            var jobId = jobId_example;  // string | The ID of the activity plan run job

            try
            { 
                // Gets an activity plan run job
                ActivityPlanRunJobResponse result = apiInstance.GetWorkforcemanagementBusinessunitActivityplanRunsJob(businessUnitId, activityPlanId, jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitActivityplanRunsJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **activityPlanId** | **string**| The ID of the activity plan associated with the run job |  |
| **jobId** | **string**| The ID of the activity plan run job |  |

### Return type

[**ActivityPlanRunJobResponse**](ActivityPlanRunJobResponse)


## GetWorkforcemanagementBusinessunitActivityplans

> [**ActivityPlanListing**](ActivityPlanListing) GetWorkforcemanagementBusinessunitActivityplans (string businessUnitId, string state = null)


Get activity plans

Requires ANY permissions: 

* wfm:activityPlan:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementBusinessunitActivityplansExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var state = state_example;  // string | Optionally filter by activity plan state (optional) 

            try
            { 
                // Get activity plans
                ActivityPlanListing result = apiInstance.GetWorkforcemanagementBusinessunitActivityplans(businessUnitId, state);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitActivityplans: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **state** | **string**| Optionally filter by activity plan state | [optional] <br />**Values**: Active, Inactive |

### Return type

[**ActivityPlanListing**](ActivityPlanListing)


## GetWorkforcemanagementBusinessunitActivityplansJobs

> [**ActivityPlanJobListing**](ActivityPlanJobListing) GetWorkforcemanagementBusinessunitActivityplansJobs (string businessUnitId)


Gets the latest job for all activity plans in the business unit

Requires ANY permissions: 

* wfm:activityPlan:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementBusinessunitActivityplansJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit

            try
            { 
                // Gets the latest job for all activity plans in the business unit
                ActivityPlanJobListing result = apiInstance.GetWorkforcemanagementBusinessunitActivityplansJobs(businessUnitId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitActivityplansJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |

### Return type

[**ActivityPlanJobListing**](ActivityPlanJobListing)


## GetWorkforcemanagementBusinessunitAlternativeshiftsSettings

> [**AlternativeShiftBuSettingsResponse**](AlternativeShiftBuSettingsResponse) GetWorkforcemanagementBusinessunitAlternativeshiftsSettings (string businessUnitId)


Get alternative shifts settings for a business unit

Requires ANY permissions: 

* wfm:businessUnit:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementBusinessunitAlternativeshiftsSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit

            try
            { 
                // Get alternative shifts settings for a business unit
                AlternativeShiftBuSettingsResponse result = apiInstance.GetWorkforcemanagementBusinessunitAlternativeshiftsSettings(businessUnitId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitAlternativeshiftsSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |

### Return type

[**AlternativeShiftBuSettingsResponse**](AlternativeShiftBuSettingsResponse)


## GetWorkforcemanagementBusinessunitAlternativeshiftsTrade

> [**AlternativeShiftTradeResponse**](AlternativeShiftTradeResponse) GetWorkforcemanagementBusinessunitAlternativeshiftsTrade (string businessUnitId, string tradeId)


Get an alternative shifts trade in a business unit for a given trade ID

Requires ANY permissions: 

* wfm:alternativeShift:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementBusinessunitAlternativeshiftsTradeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var tradeId = tradeId_example;  // string | The ID of the alternative shift trade

            try
            { 
                // Get an alternative shifts trade in a business unit for a given trade ID
                AlternativeShiftTradeResponse result = apiInstance.GetWorkforcemanagementBusinessunitAlternativeshiftsTrade(businessUnitId, tradeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitAlternativeshiftsTrade: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **tradeId** | **string**| The ID of the alternative shift trade |  |

### Return type

[**AlternativeShiftTradeResponse**](AlternativeShiftTradeResponse)


## GetWorkforcemanagementBusinessunitAlternativeshiftsTradesSearchJob

> [**BuAlternativeShiftJobResponse**](BuAlternativeShiftJobResponse) GetWorkforcemanagementBusinessunitAlternativeshiftsTradesSearchJob (string businessUnitId, string jobId)


Query the status of an alternative shift search trade operation. Only the user who started the operation can query the status

Job details are only retained if the initial request returned a 202 ACCEPTED response

Requires ANY permissions: 

* wfm:alternativeShift:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementBusinessunitAlternativeshiftsTradesSearchJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var jobId = jobId_example;  // string | The ID of the job

            try
            { 
                // Query the status of an alternative shift search trade operation. Only the user who started the operation can query the status
                BuAlternativeShiftJobResponse result = apiInstance.GetWorkforcemanagementBusinessunitAlternativeshiftsTradesSearchJob(businessUnitId, jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitAlternativeshiftsTradesSearchJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **jobId** | **string**| The ID of the job |  |

### Return type

[**BuAlternativeShiftJobResponse**](BuAlternativeShiftJobResponse)


## GetWorkforcemanagementBusinessunitCapacityplan

> [**CapacityPlanResponse**](CapacityPlanResponse) GetWorkforcemanagementBusinessunitCapacityplan (string businessUnitId, string capacityPlanId)


Get a capacity plan

Requires ANY permissions: 

* wfm:capacityPlan:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementBusinessunitCapacityplanExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var capacityPlanId = capacityPlanId_example;  // string | The ID of the capacity plan

            try
            { 
                // Get a capacity plan
                CapacityPlanResponse result = apiInstance.GetWorkforcemanagementBusinessunitCapacityplan(businessUnitId, capacityPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitCapacityplan: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **capacityPlanId** | **string**| The ID of the capacity plan |  |

### Return type

[**CapacityPlanResponse**](CapacityPlanResponse)


## GetWorkforcemanagementBusinessunitCapacityplanStaffinggroupallocations

> [**CapacityPlanStaffingGroupAllocationsResponse**](CapacityPlanStaffingGroupAllocationsResponse) GetWorkforcemanagementBusinessunitCapacityplanStaffinggroupallocations (string businessUnitId, string capacityPlanId)


Get a capacity plan's staffing group allocations

Requires ANY permissions: 

* wfm:capacityPlan:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementBusinessunitCapacityplanStaffinggroupallocationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var capacityPlanId = capacityPlanId_example;  // string | The ID of the capacity plan

            try
            { 
                // Get a capacity plan's staffing group allocations
                CapacityPlanStaffingGroupAllocationsResponse result = apiInstance.GetWorkforcemanagementBusinessunitCapacityplanStaffinggroupallocations(businessUnitId, capacityPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitCapacityplanStaffinggroupallocations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **capacityPlanId** | **string**| The ID of the capacity plan |  |

### Return type

[**CapacityPlanStaffingGroupAllocationsResponse**](CapacityPlanStaffingGroupAllocationsResponse)


## GetWorkforcemanagementBusinessunitCapacityplanStaffingrequirements

> [**CapacityPlanStaffingRequirementResult**](CapacityPlanStaffingRequirementResult) GetWorkforcemanagementBusinessunitCapacityplanStaffingrequirements (string businessUnitId, string capacityPlanId)


Get a capacity plan's staffing requirements

Requires ANY permissions: 

* wfm:capacityPlan:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementBusinessunitCapacityplanStaffingrequirementsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var capacityPlanId = capacityPlanId_example;  // string | The ID of the capacity plan

            try
            { 
                // Get a capacity plan's staffing requirements
                CapacityPlanStaffingRequirementResult result = apiInstance.GetWorkforcemanagementBusinessunitCapacityplanStaffingrequirements(businessUnitId, capacityPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitCapacityplanStaffingrequirements: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **capacityPlanId** | **string**| The ID of the capacity plan |  |

### Return type

[**CapacityPlanStaffingRequirementResult**](CapacityPlanStaffingRequirementResult)


## GetWorkforcemanagementBusinessunitCapacityplanningLongtermrequirementsAutomaticbestmethodWeekForecast

> [**LongTermRequirementsResponse**](LongTermRequirementsResponse) GetWorkforcemanagementBusinessunitCapacityplanningLongtermrequirementsAutomaticbestmethodWeekForecast (string businessUnitId, String weekDateId, string forecastId)


Get the latest long term staffing requirements for a business unit

Requires ANY permissions: 

* wfm:longTermStaffing:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementBusinessunitCapacityplanningLongtermrequirementsAutomaticbestmethodWeekForecastExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | 
            var weekDateId = 2013-10-20;  // String | weekDateId of forecast, format yyyy-MM-dd. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var forecastId = forecastId_example;  // string | forecastId of forecast

            try
            { 
                // Get the latest long term staffing requirements for a business unit
                LongTermRequirementsResponse result = apiInstance.GetWorkforcemanagementBusinessunitCapacityplanningLongtermrequirementsAutomaticbestmethodWeekForecast(businessUnitId, weekDateId, forecastId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitCapacityplanningLongtermrequirementsAutomaticbestmethodWeekForecast: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**|  |  |
| **weekDateId** | **String**| weekDateId of forecast, format yyyy-MM-dd. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **forecastId** | **string**| forecastId of forecast |  |

### Return type

[**LongTermRequirementsResponse**](LongTermRequirementsResponse)


## GetWorkforcemanagementBusinessunitCapacityplans

> [**CapacityPlansListResponse**](CapacityPlansListResponse) GetWorkforcemanagementBusinessunitCapacityplans (string businessUnitId)


Get list of capacity plans for a business unit

Requires ANY permissions: 

* wfm:capacityPlan:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementBusinessunitCapacityplansExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit

            try
            { 
                // Get list of capacity plans for a business unit
                CapacityPlansListResponse result = apiInstance.GetWorkforcemanagementBusinessunitCapacityplans(businessUnitId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitCapacityplans: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |

### Return type

[**CapacityPlansListResponse**](CapacityPlansListResponse)


## GetWorkforcemanagementBusinessunitIntradayPlanninggroups

> [**WfmIntradayPlanningGroupListing**](WfmIntradayPlanningGroupListing) GetWorkforcemanagementBusinessunitIntradayPlanninggroups (string businessUnitId, String date)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var date = 2013-10-20;  // String | yyyy-MM-dd date string interpreted in the configured business unit time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd

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
| **businessUnitId** | **string**| The ID of the business unit |  |
| **date** | **String**| yyyy-MM-dd date string interpreted in the configured business unit time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |

### Return type

[**WfmIntradayPlanningGroupListing**](WfmIntradayPlanningGroupListing)


## GetWorkforcemanagementBusinessunitMainforecastContinuousforecastSession

> [**ContinuousForecastGetSessionResponse**](ContinuousForecastGetSessionResponse) GetWorkforcemanagementBusinessunitMainforecastContinuousforecastSession (string businessUnitId)


Get the latest session for the business unit ID

GetWorkforcemanagementBusinessunitMainforecastContinuousforecastSession is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* wfm:mainForecast:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementBusinessunitMainforecastContinuousforecastSessionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | 

            try
            { 
                // Get the latest session for the business unit ID
                ContinuousForecastGetSessionResponse result = apiInstance.GetWorkforcemanagementBusinessunitMainforecastContinuousforecastSession(businessUnitId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitMainforecastContinuousforecastSession: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**|  |  |

### Return type

[**ContinuousForecastGetSessionResponse**](ContinuousForecastGetSessionResponse)


## GetWorkforcemanagementBusinessunitMainforecastContinuousforecastSessionSessionId

> [**ContinuousForecastSessionResponse**](ContinuousForecastSessionResponse) GetWorkforcemanagementBusinessunitMainforecastContinuousforecastSessionSessionId (string businessUnitId, string sessionId)


Get the session details for the session ID

GetWorkforcemanagementBusinessunitMainforecastContinuousforecastSessionSessionId is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* wfm:mainForecast:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementBusinessunitMainforecastContinuousforecastSessionSessionIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | 
            var sessionId = sessionId_example;  // string | 

            try
            { 
                // Get the session details for the session ID
                ContinuousForecastSessionResponse result = apiInstance.GetWorkforcemanagementBusinessunitMainforecastContinuousforecastSessionSessionId(businessUnitId, sessionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitMainforecastContinuousforecastSessionSessionId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**|  |  |
| **sessionId** | **string**|  |  |

### Return type

[**ContinuousForecastSessionResponse**](ContinuousForecastSessionResponse)


## GetWorkforcemanagementBusinessunitMainforecastContinuousforecastSessionSessionIdSnapshotSnapshotId

> [**ContinuousForecastSnapshotResponse**](ContinuousForecastSnapshotResponse) GetWorkforcemanagementBusinessunitMainforecastContinuousforecastSessionSessionIdSnapshotSnapshotId (string businessUnitId, string sessionId, string snapshotId)


Get the snapshot details for the snapshot ID

GetWorkforcemanagementBusinessunitMainforecastContinuousforecastSessionSessionIdSnapshotSnapshotId is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* wfm:mainForecast:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementBusinessunitMainforecastContinuousforecastSessionSessionIdSnapshotSnapshotIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | 
            var sessionId = sessionId_example;  // string | 
            var snapshotId = snapshotId_example;  // string | 

            try
            { 
                // Get the snapshot details for the snapshot ID
                ContinuousForecastSnapshotResponse result = apiInstance.GetWorkforcemanagementBusinessunitMainforecastContinuousforecastSessionSessionIdSnapshotSnapshotId(businessUnitId, sessionId, snapshotId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitMainforecastContinuousforecastSessionSessionIdSnapshotSnapshotId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**|  |  |
| **sessionId** | **string**|  |  |
| **snapshotId** | **string**|  |  |

### Return type

[**ContinuousForecastSnapshotResponse**](ContinuousForecastSnapshotResponse)


## GetWorkforcemanagementBusinessunitManagementunits

> [**ManagementUnitListing**](ManagementUnitListing) GetWorkforcemanagementBusinessunitManagementunits (string businessUnitId, string feature = null, string divisionId = null)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit, or 'mine' for the business unit of the logged-in user.
            var feature = feature_example;  // string | If specified, the list of management units for which the user is authorized to use the requested feature will be returned (optional) 
            var divisionId = divisionId_example;  // string | If specified, the list of management units belonging to the specified division will be returned (optional) 

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
| **feature** | **string**| If specified, the list of management units for which the user is authorized to use the requested feature will be returned | [optional] <br />**Values**: AgentHistoricalAdherence, AgentHistoricalAdherenceConformance, AgentSchedule, AgentTimeOffRequest, AgentWorkPlanBid, AlternativeShift, Coaching, Learning, AgentUnavailableTimes, ActivityCodes, ActivityPlans, UnavailableTimes, Agents, BuActivityCodes, BusinessUnits, CapacityPlan, ContinuousForecast, HistoricalAdherence, HistoricalShrinkage, IntradayMonitoring, BuIntradayMonitoring, ManagementUnits, RealTimeAdherence, Schedules, BuSchedules, ServiceGoalTemplates, PlanningGroups, LongTermStaffing, ShiftTrading, ShortTermForecasts, BuShortTermForecasts, StaffingGroups, TimeOffPlans, TimeOffRequests, TimeOffLimits, WorkPlanBids, WorkPlanBidGroups, WorkPlanRotations, WorkPlans |
| **divisionId** | **string**| If specified, the list of management units belonging to the specified division will be returned | [optional]  |

### Return type

[**ManagementUnitListing**](ManagementUnitListing)


## GetWorkforcemanagementBusinessunitPlanninggroup

> [**PlanningGroup**](PlanningGroup) GetWorkforcemanagementBusinessunitPlanninggroup (string businessUnitId, string planningGroupId)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

### Return type

[**PlanningGroup**](PlanningGroup)


## GetWorkforcemanagementBusinessunitPlanninggroups

> [**PlanningGroupList**](PlanningGroupList) GetWorkforcemanagementBusinessunitPlanninggroups (string businessUnitId)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

### Return type

[**PlanningGroupList**](PlanningGroupList)


## GetWorkforcemanagementBusinessunitSchedulingRun

> [**BuScheduleRun**](BuScheduleRun) GetWorkforcemanagementBusinessunitSchedulingRun (string businessUnitId, string runId)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

### Return type

[**BuScheduleRun**](BuScheduleRun)


## GetWorkforcemanagementBusinessunitSchedulingRunResult

> [**BuRescheduleResult**](BuRescheduleResult) GetWorkforcemanagementBusinessunitSchedulingRunResult (string businessUnitId, string runId, List<string> managementUnitIds, List<string> expand)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
| **managementUnitIds** | [**List<string>**](string)| The IDs of the management units for which to fetch the reschedule results |  |
| **expand** | [**List<string>**](string)| The fields to expand. Omitting will return an empty response | <br />**Values**: headcountForecast, generationResults, agentSchedules |

### Return type

[**BuRescheduleResult**](BuRescheduleResult)


## GetWorkforcemanagementBusinessunitSchedulingRuns

> [**BuScheduleRunListing**](BuScheduleRunListing) GetWorkforcemanagementBusinessunitSchedulingRuns (string businessUnitId)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

### Return type

[**BuScheduleRunListing**](BuScheduleRunListing)


## GetWorkforcemanagementBusinessunitServicegoaltemplate

> [**ServiceGoalTemplate**](ServiceGoalTemplate) GetWorkforcemanagementBusinessunitServicegoaltemplate (string businessUnitId, string serviceGoalTemplateId, List<string> expand = null)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit.
            var serviceGoalTemplateId = serviceGoalTemplateId_example;  // string | The ID of a service goal template to fetch
            var expand = new List<string>(); // List<string> | Include to access additional data on the service goal template (optional) 

            try
            { 
                // Get a service goal template
                ServiceGoalTemplate result = apiInstance.GetWorkforcemanagementBusinessunitServicegoaltemplate(businessUnitId, serviceGoalTemplateId, expand);
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
| **expand** | [**List<string>**](string)| Include to access additional data on the service goal template | [optional] <br />**Values**: impactOverride |

### Return type

[**ServiceGoalTemplate**](ServiceGoalTemplate)


## GetWorkforcemanagementBusinessunitServicegoaltemplates

> [**ServiceGoalTemplateList**](ServiceGoalTemplateList) GetWorkforcemanagementBusinessunitServicegoaltemplates (string businessUnitId, List<string> expand = null)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit.
            var expand = new List<string>(); // List<string> | Include to access additional data on the service goal template (optional) 

            try
            { 
                // Gets list of service goal templates
                ServiceGoalTemplateList result = apiInstance.GetWorkforcemanagementBusinessunitServicegoaltemplates(businessUnitId, expand);
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
| **expand** | [**List<string>**](string)| Include to access additional data on the service goal template | [optional] <br />**Values**: impactOverride |

### Return type

[**ServiceGoalTemplateList**](ServiceGoalTemplateList)


## GetWorkforcemanagementBusinessunitStaffinggroup

> [**StaffingGroupResponse**](StaffingGroupResponse) GetWorkforcemanagementBusinessunitStaffinggroup (string businessUnitId, string staffingGroupId)


Gets a staffing group

Requires ANY permissions: 

* wfm:staffingGroup:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementBusinessunitStaffinggroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var staffingGroupId = staffingGroupId_example;  // string | The ID of the staffing group to fetch

            try
            { 
                // Gets a staffing group
                StaffingGroupResponse result = apiInstance.GetWorkforcemanagementBusinessunitStaffinggroup(businessUnitId, staffingGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitStaffinggroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **staffingGroupId** | **string**| The ID of the staffing group to fetch |  |

### Return type

[**StaffingGroupResponse**](StaffingGroupResponse)


## GetWorkforcemanagementBusinessunitStaffinggroups

> [**StaffingGroupListing**](StaffingGroupListing) GetWorkforcemanagementBusinessunitStaffinggroups (string businessUnitId, string managementUnitId = null, bool? forceDownloadService = null)


Gets a list of staffing groups

Requires ANY permissions: 

* wfm:staffingGroup:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementBusinessunitStaffinggroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit to get management unit specific staffing groups (optional) 
            var forceDownloadService = true;  // bool? | Force the result of this operation to be sent via download service. For testing/app development purposes (optional) 

            try
            { 
                // Gets a list of staffing groups
                StaffingGroupListing result = apiInstance.GetWorkforcemanagementBusinessunitStaffinggroups(businessUnitId, managementUnitId, forceDownloadService);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitStaffinggroups: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **managementUnitId** | **string**| The ID of the management unit to get management unit specific staffing groups | [optional]  |
| **forceDownloadService** | **bool?**| Force the result of this operation to be sent via download service. For testing/app development purposes | [optional]  |

### Return type

[**StaffingGroupListing**](StaffingGroupListing)


## GetWorkforcemanagementBusinessunitTimeofflimit

> [**BuTimeOffLimitResponse**](BuTimeOffLimitResponse) GetWorkforcemanagementBusinessunitTimeofflimit (string businessUnitId, string timeOffLimitId)


Gets a time-off limit object

Returns properties of time-off limit object, but not daily values

Requires ANY permissions: 

* wfm:timeOffLimit:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementBusinessunitTimeofflimitExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var timeOffLimitId = timeOffLimitId_example;  // string | The ID of the time-off limit to fetch

            try
            { 
                // Gets a time-off limit object
                BuTimeOffLimitResponse result = apiInstance.GetWorkforcemanagementBusinessunitTimeofflimit(businessUnitId, timeOffLimitId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitTimeofflimit: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **timeOffLimitId** | **string**| The ID of the time-off limit to fetch |  |

### Return type

[**BuTimeOffLimitResponse**](BuTimeOffLimitResponse)


## GetWorkforcemanagementBusinessunitTimeofflimits

> [**BuTimeOffLimitListing**](BuTimeOffLimitListing) GetWorkforcemanagementBusinessunitTimeofflimits (string businessUnitId, string managementUnitId = null)


Gets a list of time-off limit objects

Requires ANY permissions: 

* wfm:timeOffLimit:view
* wfm:timeOffPlan:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementBusinessunitTimeofflimitsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit to get management unit specific time-off limit objects (optional) 

            try
            { 
                // Gets a list of time-off limit objects
                BuTimeOffLimitListing result = apiInstance.GetWorkforcemanagementBusinessunitTimeofflimits(businessUnitId, managementUnitId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitTimeofflimits: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **managementUnitId** | **string**| The ID of the management unit to get management unit specific time-off limit objects | [optional]  |

### Return type

[**BuTimeOffLimitListing**](BuTimeOffLimitListing)


## GetWorkforcemanagementBusinessunitTimeoffplan

> [**BuTimeOffPlanResponse**](BuTimeOffPlanResponse) GetWorkforcemanagementBusinessunitTimeoffplan (string businessUnitId, string timeOffPlanId)


Gets a time-off plan

Requires ANY permissions: 

* wfm:timeOffPlan:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementBusinessunitTimeoffplanExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var timeOffPlanId = timeOffPlanId_example;  // string | The ID of the time-off plan to fetch

            try
            { 
                // Gets a time-off plan
                BuTimeOffPlanResponse result = apiInstance.GetWorkforcemanagementBusinessunitTimeoffplan(businessUnitId, timeOffPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitTimeoffplan: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **timeOffPlanId** | **string**| The ID of the time-off plan to fetch |  |

### Return type

[**BuTimeOffPlanResponse**](BuTimeOffPlanResponse)


## GetWorkforcemanagementBusinessunitTimeoffplans

> [**BuTimeOffPlanListing**](BuTimeOffPlanListing) GetWorkforcemanagementBusinessunitTimeoffplans (string businessUnitId, string managementUnitId = null, bool? forceDownloadService = null)


Gets a list of time-off plans

Requires ANY permissions: 

* wfm:timeOffPlan:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementBusinessunitTimeoffplansExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit to get management unit specific staffing groups (optional) 
            var forceDownloadService = true;  // bool? | Force the result of this operation to be sent via download service. For testing/app development purposes (optional) 

            try
            { 
                // Gets a list of time-off plans
                BuTimeOffPlanListing result = apiInstance.GetWorkforcemanagementBusinessunitTimeoffplans(businessUnitId, managementUnitId, forceDownloadService);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitTimeoffplans: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **managementUnitId** | **string**| The ID of the management unit to get management unit specific staffing groups | [optional]  |
| **forceDownloadService** | **bool?**| Force the result of this operation to be sent via download service. For testing/app development purposes | [optional]  |

### Return type

[**BuTimeOffPlanListing**](BuTimeOffPlanListing)


## GetWorkforcemanagementBusinessunitWeekSchedule

> [**BuScheduleMetadata**](BuScheduleMetadata) GetWorkforcemanagementBusinessunitWeekSchedule (string businessUnitId, String weekId, string scheduleId, string expand = null)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var weekId = 2013-10-20;  // String | First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var scheduleId = scheduleId_example;  // string | The ID of the schedule
            var expand = expand_example;  // string | expand (optional) 

            try
            { 
                // Get the metadata for the schedule, describing which management units and agents are in the scheduleSchedule data can then be loaded with the query route
                BuScheduleMetadata result = apiInstance.GetWorkforcemanagementBusinessunitWeekSchedule(businessUnitId, weekId, scheduleId, expand);
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
| **weekId** | **String**| First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **scheduleId** | **string**| The ID of the schedule |  |
| **expand** | **string**| expand | [optional] <br />**Values**: managementUnits.agents |

### Return type

[**BuScheduleMetadata**](BuScheduleMetadata)


## GetWorkforcemanagementBusinessunitWeekScheduleGenerationresults

> [**ScheduleGenerationResult**](ScheduleGenerationResult) GetWorkforcemanagementBusinessunitWeekScheduleGenerationresults (string businessUnitId, String weekId, string scheduleId)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var weekId = 2013-10-20;  // String | First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
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
| **weekId** | **String**| First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **scheduleId** | **string**| The ID of the schedule |  |

### Return type

[**ScheduleGenerationResult**](ScheduleGenerationResult)


## GetWorkforcemanagementBusinessunitWeekScheduleHeadcountforecast

> [**BuHeadcountForecastResponse**](BuHeadcountForecastResponse) GetWorkforcemanagementBusinessunitWeekScheduleHeadcountforecast (string businessUnitId, String weekId, string scheduleId, bool? forceDownload = null)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var weekId = 2013-10-20;  // String | First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
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
| **weekId** | **String**| First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **scheduleId** | **string**| The ID of the schedule |  |
| **forceDownload** | **bool?**| Whether to force the result to come via download url.  For testing purposes only | [optional]  |

### Return type

[**BuHeadcountForecastResponse**](BuHeadcountForecastResponse)


## GetWorkforcemanagementBusinessunitWeekScheduleHistoryAgent

> [**BuAgentScheduleHistoryResponse**](BuAgentScheduleHistoryResponse) GetWorkforcemanagementBusinessunitWeekScheduleHistoryAgent (string businessUnitId, String weekId, string scheduleId, string agentId)


Loads agent's schedule history.

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
    public class GetWorkforcemanagementBusinessunitWeekScheduleHistoryAgentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var weekId = 2013-10-20;  // String | First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var scheduleId = scheduleId_example;  // string | The ID of the schedule
            var agentId = agentId_example;  // string | THe ID of the agent

            try
            { 
                // Loads agent's schedule history.
                BuAgentScheduleHistoryResponse result = apiInstance.GetWorkforcemanagementBusinessunitWeekScheduleHistoryAgent(businessUnitId, weekId, scheduleId, agentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitWeekScheduleHistoryAgent: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **weekId** | **String**| First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **scheduleId** | **string**| The ID of the schedule |  |
| **agentId** | **string**| THe ID of the agent |  |

### Return type

[**BuAgentScheduleHistoryResponse**](BuAgentScheduleHistoryResponse)


## GetWorkforcemanagementBusinessunitWeekSchedulePerformancepredictions

> [**PerformancePredictionResponse**](PerformancePredictionResponse) GetWorkforcemanagementBusinessunitWeekSchedulePerformancepredictions (string businessUnitId, string weekId, string scheduleId)


Get the performance prediction for the associated schedule

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
    public class GetWorkforcemanagementBusinessunitWeekSchedulePerformancepredictionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit to which the performance prediction belongs
            var weekId = weekId_example;  // string | First day of schedule week in yyyy-MM-dd format
            var scheduleId = scheduleId_example;  // string | The ID of the schedule the performance prediction belongs to

            try
            { 
                // Get the performance prediction for the associated schedule
                PerformancePredictionResponse result = apiInstance.GetWorkforcemanagementBusinessunitWeekSchedulePerformancepredictions(businessUnitId, weekId, scheduleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitWeekSchedulePerformancepredictions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit to which the performance prediction belongs |  |
| **weekId** | **string**| First day of schedule week in yyyy-MM-dd format |  |
| **scheduleId** | **string**| The ID of the schedule the performance prediction belongs to |  |

### Return type

[**PerformancePredictionResponse**](PerformancePredictionResponse)


## GetWorkforcemanagementBusinessunitWeekSchedulePerformancepredictionsRecalculation

> [**PerformancePredictionRecalculationResponse**](PerformancePredictionRecalculationResponse) GetWorkforcemanagementBusinessunitWeekSchedulePerformancepredictionsRecalculation (string businessUnitId, string weekId, string scheduleId, string recalculationId)


Get recalculated performance prediction result

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
    public class GetWorkforcemanagementBusinessunitWeekSchedulePerformancepredictionsRecalculationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit to which the performance prediction belongs
            var weekId = weekId_example;  // string | First day of schedule week in yyyy-MM-dd format
            var scheduleId = scheduleId_example;  // string | The ID of the schedule the recalculation belongs to
            var recalculationId = recalculationId_example;  // string | The ID of the recalculation request

            try
            { 
                // Get recalculated performance prediction result
                PerformancePredictionRecalculationResponse result = apiInstance.GetWorkforcemanagementBusinessunitWeekSchedulePerformancepredictionsRecalculation(businessUnitId, weekId, scheduleId, recalculationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitWeekSchedulePerformancepredictionsRecalculation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit to which the performance prediction belongs |  |
| **weekId** | **string**| First day of schedule week in yyyy-MM-dd format |  |
| **scheduleId** | **string**| The ID of the schedule the recalculation belongs to |  |
| **recalculationId** | **string**| The ID of the recalculation request |  |

### Return type

[**PerformancePredictionRecalculationResponse**](PerformancePredictionRecalculationResponse)


## GetWorkforcemanagementBusinessunitWeekSchedules

> [**BuScheduleListing**](BuScheduleListing) GetWorkforcemanagementBusinessunitWeekSchedules (string businessUnitId, string weekId, bool? includeOnlyPublished = null, string expand = null)


Get the list of week schedules for the specified week

Use \"recent\" (without quotes) for the `weekId` path parameter to fetch all forecasts for +/- 26 weeks from the current date. Response will include any schedule which spans the specified week

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var weekId = weekId_example;  // string | First day of schedule week in yyyy-MM-dd format, or 'recent' (without quotes) to get recent schedules
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
| **weekId** | **string**| First day of schedule week in yyyy-MM-dd format, or &#39;recent&#39; (without quotes) to get recent schedules |  |
| **includeOnlyPublished** | **bool?**| includeOnlyPublished | [optional]  |
| **expand** | **string**| expand | [optional] <br />**Values**: forecast.description |

### Return type

[**BuScheduleListing**](BuScheduleListing)


## GetWorkforcemanagementBusinessunitWeekShorttermforecast

> [**BuShortTermForecast**](BuShortTermForecast) GetWorkforcemanagementBusinessunitWeekShorttermforecast (string businessUnitId, String weekDateId, string forecastId, List<string> expand = null)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit to which the forecast belongs
            var weekDateId = 2013-10-20;  // String | The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var forecastId = forecastId_example;  // string | The ID of the forecast
            var expand = new List<string>(); // List<string> | Include to access additional data on the forecast (optional) 

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
| **businessUnitId** | **string**| The ID of the business unit to which the forecast belongs |  |
| **weekDateId** | **String**| The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **forecastId** | **string**| The ID of the forecast |  |
| **expand** | [**List<string>**](string)| Include to access additional data on the forecast | [optional] <br />**Values**: planningGroups, generationResults |

### Return type

[**BuShortTermForecast**](BuShortTermForecast)


## GetWorkforcemanagementBusinessunitWeekShorttermforecastData

> [**BuForecastResultResponse**](BuForecastResultResponse) GetWorkforcemanagementBusinessunitWeekShorttermforecastData (string businessUnitId, String weekDateId, string forecastId, int? weekNumber = null, bool? forceDownloadService = null)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit to which the forecast belongs
            var weekDateId = 2013-10-20;  // String | The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
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
| **businessUnitId** | **string**| The ID of the business unit to which the forecast belongs |  |
| **weekDateId** | **String**| The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **forecastId** | **string**| The ID of the forecast |  |
| **weekNumber** | **int?**| The week number to fetch (for multi-week forecasts) | [optional]  |
| **forceDownloadService** | **bool?**| Force the result of this operation to be sent via download service.  For testing/app development purposes | [optional]  |

### Return type

[**BuForecastResultResponse**](BuForecastResultResponse)


## GetWorkforcemanagementBusinessunitWeekShorttermforecastGenerationresults

> [**BuForecastGenerationResult**](BuForecastGenerationResult) GetWorkforcemanagementBusinessunitWeekShorttermforecastGenerationresults (string businessUnitId, String weekDateId, string forecastId)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit to which the forecast belongs
            var weekDateId = 2013-10-20;  // String | The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
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
| **businessUnitId** | **string**| The ID of the business unit to which the forecast belongs |  |
| **weekDateId** | **String**| The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **forecastId** | **string**| The ID of the forecast |  |

### Return type

[**BuForecastGenerationResult**](BuForecastGenerationResult)


## GetWorkforcemanagementBusinessunitWeekShorttermforecastLongtermforecastdata

> [**LongTermForecastResultResponse**](LongTermForecastResultResponse) GetWorkforcemanagementBusinessunitWeekShorttermforecastLongtermforecastdata (string businessUnitId, String weekDateId, string forecastId, bool? forceDownloadService = null)


Get the result of a long term forecast calculation

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
    public class GetWorkforcemanagementBusinessunitWeekShorttermforecastLongtermforecastdataExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit to which the forecast belongs
            var weekDateId = 2013-10-20;  // String | The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var forecastId = forecastId_example;  // string | The ID of the forecast
            var forceDownloadService = true;  // bool? | Force the result of this operation to be sent via download service.  For testing/app development purposes (optional) 

            try
            { 
                // Get the result of a long term forecast calculation
                LongTermForecastResultResponse result = apiInstance.GetWorkforcemanagementBusinessunitWeekShorttermforecastLongtermforecastdata(businessUnitId, weekDateId, forecastId, forceDownloadService);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitWeekShorttermforecastLongtermforecastdata: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit to which the forecast belongs |  |
| **weekDateId** | **String**| The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **forecastId** | **string**| The ID of the forecast |  |
| **forceDownloadService** | **bool?**| Force the result of this operation to be sent via download service.  For testing/app development purposes | [optional]  |

### Return type

[**LongTermForecastResultResponse**](LongTermForecastResultResponse)


## GetWorkforcemanagementBusinessunitWeekShorttermforecastPlanninggroups

> [**ForecastPlanningGroupsResponse**](ForecastPlanningGroupsResponse) GetWorkforcemanagementBusinessunitWeekShorttermforecastPlanninggroups (string businessUnitId, String weekDateId, string forecastId)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit to which the forecast belongs
            var weekDateId = 2013-10-20;  // String | The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
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
| **businessUnitId** | **string**| The ID of the business unit to which the forecast belongs |  |
| **weekDateId** | **String**| The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **forecastId** | **string**| The ID of the forecast |  |

### Return type

[**ForecastPlanningGroupsResponse**](ForecastPlanningGroupsResponse)


## GetWorkforcemanagementBusinessunitWeekShorttermforecastStaffingrequirement

> [**BuForecastStaffingRequirementsResultResponse**](BuForecastStaffingRequirementsResultResponse) GetWorkforcemanagementBusinessunitWeekShorttermforecastStaffingrequirement (string businessUnitId, String weekDateId, string forecastId, List<string> weekNumbers = null)


Get the staffing requirement by planning group for a forecast

Requires ANY permissions: 

* wfm:staffingRequirement:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementBusinessunitWeekShorttermforecastStaffingrequirementExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit to which the forecast belongs
            var weekDateId = 2013-10-20;  // String | The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var forecastId = forecastId_example;  // string | The ID of the forecast
            var weekNumbers = new List<string>(); // List<string> | The week numbers to fetch (for multi-week forecasts) staffing requirements. Returns all week data if the list is not specified (optional) 

            try
            { 
                // Get the staffing requirement by planning group for a forecast
                BuForecastStaffingRequirementsResultResponse result = apiInstance.GetWorkforcemanagementBusinessunitWeekShorttermforecastStaffingrequirement(businessUnitId, weekDateId, forecastId, weekNumbers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitWeekShorttermforecastStaffingrequirement: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit to which the forecast belongs |  |
| **weekDateId** | **String**| The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **forecastId** | **string**| The ID of the forecast |  |
| **weekNumbers** | [**List<string>**](string)| The week numbers to fetch (for multi-week forecasts) staffing requirements. Returns all week data if the list is not specified | [optional]  |

### Return type

[**BuForecastStaffingRequirementsResultResponse**](BuForecastStaffingRequirementsResultResponse)


## GetWorkforcemanagementBusinessunitWeekShorttermforecasts

> [**BuShortTermForecastListing**](BuShortTermForecastListing) GetWorkforcemanagementBusinessunitWeekShorttermforecasts (string businessUnitId, string weekDateId)


Get short term forecasts

Use \"recent\" (without quotes) for the `weekDateId` path parameter to fetch all forecasts for +/- 26 weeks from the current date. Response will include any forecast which spans the specified week

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit to which the forecast belongs
            var weekDateId = weekDateId_example;  // string | The week start date of the forecast in yyyy-MM-dd format or 'recent' (without quotes) to fetch recent forecasts

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
| **businessUnitId** | **string**| The ID of the business unit to which the forecast belongs |  |
| **weekDateId** | **string**| The week start date of the forecast in yyyy-MM-dd format or &#39;recent&#39; (without quotes) to fetch recent forecasts |  |

### Return type

[**BuShortTermForecastListing**](BuShortTermForecastListing)


## GetWorkforcemanagementBusinessunitWorkplanbid

> [**WorkPlanBid**](WorkPlanBid) GetWorkforcemanagementBusinessunitWorkplanbid (string businessUnitId, string bidId)


Get a work plan bid

Requires ANY permissions: 

* wfm:workPlanBid:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementBusinessunitWorkplanbidExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var bidId = bidId_example;  // string | The id of the workplanbid

            try
            { 
                // Get a work plan bid
                WorkPlanBid result = apiInstance.GetWorkforcemanagementBusinessunitWorkplanbid(businessUnitId, bidId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitWorkplanbid: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **bidId** | **string**| The id of the workplanbid |  |

### Return type

[**WorkPlanBid**](WorkPlanBid)


## GetWorkforcemanagementBusinessunitWorkplanbidGroup

> [**WorkPlanBidGroupResponse**](WorkPlanBidGroupResponse) GetWorkforcemanagementBusinessunitWorkplanbidGroup (string businessUnitId, string bidId, string bidGroupId)


Get a bid group by bid group Id

Requires ANY permissions: 

* wfm:workPlanBidGroup:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementBusinessunitWorkplanbidGroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var bidId = bidId_example;  // string | The work plan bid id of the bid groups
            var bidGroupId = bidGroupId_example;  // string | Work Plan Bid Group id

            try
            { 
                // Get a bid group by bid group Id
                WorkPlanBidGroupResponse result = apiInstance.GetWorkforcemanagementBusinessunitWorkplanbidGroup(businessUnitId, bidId, bidGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitWorkplanbidGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **bidId** | **string**| The work plan bid id of the bid groups |  |
| **bidGroupId** | **string**| Work Plan Bid Group id |  |

### Return type

[**WorkPlanBidGroupResponse**](WorkPlanBidGroupResponse)


## GetWorkforcemanagementBusinessunitWorkplanbidGroupPreferences

> [**AdminAgentWorkPlanPreferenceResponse**](AdminAgentWorkPlanPreferenceResponse) GetWorkforcemanagementBusinessunitWorkplanbidGroupPreferences (string businessUnitId, string bidId, string bidGroupId)


Gets the work plan preferences of all the agents in the work plan bid group

Requires ANY permissions: 

* wfm:workPlanBidGroup:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementBusinessunitWorkplanbidGroupPreferencesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var bidId = bidId_example;  // string | The work plan bid id of the bid groups
            var bidGroupId = bidGroupId_example;  // string | The ID of the work plan bid group

            try
            { 
                // Gets the work plan preferences of all the agents in the work plan bid group
                AdminAgentWorkPlanPreferenceResponse result = apiInstance.GetWorkforcemanagementBusinessunitWorkplanbidGroupPreferences(businessUnitId, bidId, bidGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitWorkplanbidGroupPreferences: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **bidId** | **string**| The work plan bid id of the bid groups |  |
| **bidGroupId** | **string**| The ID of the work plan bid group |  |

### Return type

[**AdminAgentWorkPlanPreferenceResponse**](AdminAgentWorkPlanPreferenceResponse)


## GetWorkforcemanagementBusinessunitWorkplanbidGroupsSummary

> [**WorkPlanBidGroupSummaryList**](WorkPlanBidGroupSummaryList) GetWorkforcemanagementBusinessunitWorkplanbidGroupsSummary (string businessUnitId, string bidId)


Get summary of bid groups that belong to a work plan bid

Requires ANY permissions: 

* wfm:workPlanBidGroup:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementBusinessunitWorkplanbidGroupsSummaryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var bidId = bidId_example;  // string | The work plan bid id of the bid groups

            try
            { 
                // Get summary of bid groups that belong to a work plan bid
                WorkPlanBidGroupSummaryList result = apiInstance.GetWorkforcemanagementBusinessunitWorkplanbidGroupsSummary(businessUnitId, bidId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitWorkplanbidGroupsSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **bidId** | **string**| The work plan bid id of the bid groups |  |

### Return type

[**WorkPlanBidGroupSummaryList**](WorkPlanBidGroupSummaryList)


## GetWorkforcemanagementBusinessunitWorkplanbids

> [**WorkPlanBidListResponse**](WorkPlanBidListResponse) GetWorkforcemanagementBusinessunitWorkplanbids (string businessUnitId)


Get list of work plan bids

Requires ANY permissions: 

* wfm:workPlanBid:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementBusinessunitWorkplanbidsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit

            try
            { 
                // Get list of work plan bids
                WorkPlanBidListResponse result = apiInstance.GetWorkforcemanagementBusinessunitWorkplanbids(businessUnitId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementBusinessunitWorkplanbids: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |

### Return type

[**WorkPlanBidListResponse**](WorkPlanBidListResponse)


## GetWorkforcemanagementBusinessunits

> [**BusinessUnitListing**](BusinessUnitListing) GetWorkforcemanagementBusinessunits (string feature = null, string divisionId = null)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var feature = feature_example;  // string | If specified, the list of business units for which the user is authorized to use the requested feature will be returned (optional) 
            var divisionId = divisionId_example;  // string | If specified, the list of business units belonging to the specified division will be returned (optional) 

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
| **feature** | **string**| If specified, the list of business units for which the user is authorized to use the requested feature will be returned | [optional] <br />**Values**: AgentHistoricalAdherence, AgentHistoricalAdherenceConformance, AgentSchedule, AgentTimeOffRequest, AgentWorkPlanBid, AlternativeShift, Coaching, Learning, AgentUnavailableTimes, ActivityCodes, ActivityPlans, UnavailableTimes, Agents, BuActivityCodes, BusinessUnits, CapacityPlan, ContinuousForecast, HistoricalAdherence, HistoricalShrinkage, IntradayMonitoring, BuIntradayMonitoring, ManagementUnits, RealTimeAdherence, Schedules, BuSchedules, ServiceGoalTemplates, PlanningGroups, LongTermStaffing, ShiftTrading, ShortTermForecasts, BuShortTermForecasts, StaffingGroups, TimeOffPlans, TimeOffRequests, TimeOffLimits, WorkPlanBids, WorkPlanBidGroups, WorkPlanRotations, WorkPlans |
| **divisionId** | **string**| If specified, the list of business units belonging to the specified division will be returned | [optional]  |

### Return type

[**BusinessUnitListing**](BusinessUnitListing)


## GetWorkforcemanagementBusinessunitsDivisionviews

> [**BusinessUnitListing**](BusinessUnitListing) GetWorkforcemanagementBusinessunitsDivisionviews (List<string> divisionId = null)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
| **divisionId** | [**List<string>**](string)| The divisionIds to filter by. If omitted, will return business units in all divisions | [optional]  |

### Return type

[**BusinessUnitListing**](BusinessUnitListing)


## GetWorkforcemanagementCalendarDataIcs

> **string** GetWorkforcemanagementCalendarDataIcs (string calendarId)


Get ics formatted calendar based on shareable link

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
    public class GetWorkforcemanagementCalendarDataIcsExample
    {
        public void main()
        { 

            var apiInstance = new WorkforceManagementApi();
            var calendarId = calendarId_example;  // string | The id of the ics-formatted calendar

            try
            { 
                // Get ics formatted calendar based on shareable link
                string result = apiInstance.GetWorkforcemanagementCalendarDataIcs(calendarId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementCalendarDataIcs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **calendarId** | **string**| The id of the ics-formatted calendar |  |

### Return type

**string**


## GetWorkforcemanagementCalendarUrlIcs

> [**CalendarUrlResponse**](CalendarUrlResponse) GetWorkforcemanagementCalendarUrlIcs ()


Get existing calendar link for the current user

Requires ALL permissions: 

* wfm:agentSchedule:sync
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
    public class GetWorkforcemanagementCalendarUrlIcsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();

            try
            { 
                // Get existing calendar link for the current user
                CalendarUrlResponse result = apiInstance.GetWorkforcemanagementCalendarUrlIcs();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementCalendarUrlIcs: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**CalendarUrlResponse**](CalendarUrlResponse)


## GetWorkforcemanagementHistoricaldataBulkRemoveJob

> [**HistoricalImportDeleteFilesJobResponse**](HistoricalImportDeleteFilesJobResponse) GetWorkforcemanagementHistoricaldataBulkRemoveJob (string jobId)


Retrieves delete job status for historical data imports associated with the job id

Requires ALL permissions: 

* wfm:historicalData:upload

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementHistoricaldataBulkRemoveJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var jobId = jobId_example;  // string | The job ID of the historical data delete request

            try
            { 
                // Retrieves delete job status for historical data imports associated with the job id
                HistoricalImportDeleteFilesJobResponse result = apiInstance.GetWorkforcemanagementHistoricaldataBulkRemoveJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementHistoricaldataBulkRemoveJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| The job ID of the historical data delete request |  |

### Return type

[**HistoricalImportDeleteFilesJobResponse**](HistoricalImportDeleteFilesJobResponse)


## GetWorkforcemanagementHistoricaldataBulkRemoveJobs

> [**HistoricalImportOverallDeleteStatusResponse**](HistoricalImportOverallDeleteStatusResponse) GetWorkforcemanagementHistoricaldataBulkRemoveJobs ()


Retrieves all delete job status for historical data

Requires ALL permissions: 

* wfm:historicalData:upload

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementHistoricaldataBulkRemoveJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();

            try
            { 
                // Retrieves all delete job status for historical data
                HistoricalImportOverallDeleteStatusResponse result = apiInstance.GetWorkforcemanagementHistoricaldataBulkRemoveJobs();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementHistoricaldataBulkRemoveJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**HistoricalImportOverallDeleteStatusResponse**](HistoricalImportOverallDeleteStatusResponse)


## GetWorkforcemanagementHistoricaldataImportstatus

> [**HistoricalImportStatusListing**](HistoricalImportStatusListing) GetWorkforcemanagementHistoricaldataImportstatus ()


Retrieves status of the historical data imports of the organization

Requires ALL permissions: 

* wfm:historicalData:upload

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementHistoricaldataImportstatusExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();

            try
            { 
                // Retrieves status of the historical data imports of the organization
                HistoricalImportStatusListing result = apiInstance.GetWorkforcemanagementHistoricaldataImportstatus();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementHistoricaldataImportstatus: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**HistoricalImportStatusListing**](HistoricalImportStatusListing)


## GetWorkforcemanagementHistoricaldataImportstatusJobId

> [**HistoricalImportStatusJobResponse**](HistoricalImportStatusJobResponse) GetWorkforcemanagementHistoricaldataImportstatusJobId (string jobId)


Retrieves status of the historical data imports associated with job id

Requires ALL permissions: 

* wfm:historicalData:upload

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementHistoricaldataImportstatusJobIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var jobId = jobId_example;  // string | The job Id of the historical data import request

            try
            { 
                // Retrieves status of the historical data imports associated with job id
                HistoricalImportStatusJobResponse result = apiInstance.GetWorkforcemanagementHistoricaldataImportstatusJobId(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementHistoricaldataImportstatusJobId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| The job Id of the historical data import request |  |

### Return type

[**HistoricalImportStatusJobResponse**](HistoricalImportStatusJobResponse)


## GetWorkforcemanagementIntegrationsHris

> [**WfmIntegrationListing**](WfmIntegrationListing) GetWorkforcemanagementIntegrationsHris ()


Get integrations

Requires ANY permissions: 

* wfm:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementIntegrationsHrisExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();

            try
            { 
                // Get integrations
                WfmIntegrationListing result = apiInstance.GetWorkforcemanagementIntegrationsHris();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementIntegrationsHris: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**WfmIntegrationListing**](WfmIntegrationListing)


## GetWorkforcemanagementIntegrationsHrisTimeofftypesJob

> [**HrisTimeOffTypesJobResponse**](HrisTimeOffTypesJobResponse) GetWorkforcemanagementIntegrationsHrisTimeofftypesJob (string jobId)


Query the results of time off types job

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
    public class GetWorkforcemanagementIntegrationsHrisTimeofftypesJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var jobId = jobId_example;  // string | The ID of the job.

            try
            { 
                // Query the results of time off types job
                HrisTimeOffTypesJobResponse result = apiInstance.GetWorkforcemanagementIntegrationsHrisTimeofftypesJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementIntegrationsHrisTimeofftypesJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| The ID of the job. |  |

### Return type

[**HrisTimeOffTypesJobResponse**](HrisTimeOffTypesJobResponse)


## GetWorkforcemanagementManagementunit

> [**ManagementUnit**](ManagementUnit) GetWorkforcemanagementManagementunit (string managementUnitId, List<string> expand = null)


Get management unit

settings.shortTermForecasting is deprecated and now lives on the business unit

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
* wfm:shrinkage:view
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
* wfm:staffingGroup:add
* wfm:staffingGroup:delete
* wfm:staffingGroup:edit
* wfm:staffingGroup:view
* wfm:timeOffLimit:add
* wfm:timeOffLimit:delete
* wfm:timeOffLimit:edit
* wfm:timeOffLimit:view
* wfm:timeOffPlan:add
* wfm:timeOffPlan:delete
* wfm:timeOffPlan:edit
* wfm:timeOffPlan:view
* wfm:timeOffRequest:add
* wfm:timeOffRequest:edit
* wfm:timeOffRequest:view
* wfm:workPlan:add
* wfm:workPlan:delete
* wfm:workPlan:edit
* wfm:workPlan:view
* wfm:workPlanRotation:add
* wfm:workPlanRotation:delete
* wfm:workPlanRotation:edit
* wfm:workPlanRotation:view

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var expand = new List<string>(); // List<string> |  (optional) 

            try
            { 
                // Get management unit
                ManagementUnit result = apiInstance.GetWorkforcemanagementManagementunit(managementUnitId, expand);
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
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **expand** | [**List<string>**](string)|  | [optional] <br />**Values**: settings, settings.adherence, settings.timeOff, settings.scheduling, settings.shortTermForecasting, settings.shiftTrading |

### Return type

[**ManagementUnit**](ManagementUnit)


## GetWorkforcemanagementManagementunitActivitycodes

> [**ActivityCodeContainer**](ActivityCodeContainer) GetWorkforcemanagementManagementunitActivitycodes (string managementUnitId)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Deprecated: Instead use /api/v2/workforcemanagement/businessunits/{businessUnitId}/activitycodes. Get the list of activity codes

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
* wfm:shrinkage:view
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
* wfm:workPlanRotation:add
* wfm:workPlanRotation:delete
* wfm:workPlanRotation:edit
* wfm:workPlanRotation:view

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.

            try
            { 
                // Deprecated: Instead use /api/v2/workforcemanagement/businessunits/{businessUnitId}/activitycodes. Get the list of activity codes
                ActivityCodeContainer result = apiInstance.GetWorkforcemanagementManagementunitActivitycodes(managementUnitId);
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
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |

### Return type

[**ActivityCodeContainer**](ActivityCodeContainer)


## GetWorkforcemanagementManagementunitAdherence

> [**UserScheduleAdherenceListing**](UserScheduleAdherenceListing) GetWorkforcemanagementManagementunitAdherence (string managementUnitId, bool? forceDownloadService = null)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit
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
| **managementUnitId** | **string**| The ID of the management unit |  |
| **forceDownloadService** | **bool?**| Force the result of this operation to be sent via download service.  For testing/app development purposes | [optional]  |

### Return type

[**UserScheduleAdherenceListing**](UserScheduleAdherenceListing)


## GetWorkforcemanagementManagementunitAgent

> [**WfmAgent**](WfmAgent) GetWorkforcemanagementManagementunitAgent (string managementUnitId, string agentId, bool? excludeCapabilities = null, List<string> expand = null)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var agentId = agentId_example;  // string | The agent id
            var excludeCapabilities = true;  // bool? | Excludes all capabilities of the agent such as queues, languages, and skills (optional) 
            var expand = new List<string>(); // List<string> |  (optional) 

            try
            { 
                // Get data for agent in the management unit
                WfmAgent result = apiInstance.GetWorkforcemanagementManagementunitAgent(managementUnitId, agentId, excludeCapabilities, expand);
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
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **agentId** | **string**| The agent id |  |
| **excludeCapabilities** | **bool?**| Excludes all capabilities of the agent such as queues, languages, and skills | [optional]  |
| **expand** | [**List<string>**](string)|  | [optional] <br />**Values**: workPlanOverrides |

### Return type

[**WfmAgent**](WfmAgent)


## GetWorkforcemanagementManagementunitAgentShifttrades

> [**ShiftTradeListResponse**](ShiftTradeListResponse) GetWorkforcemanagementManagementunitAgentShifttrades (string managementUnitId, string agentId)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
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
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **agentId** | **string**| The agent id |  |

### Return type

[**ShiftTradeListResponse**](ShiftTradeListResponse)


## GetWorkforcemanagementManagementunitShifttradesMatched

> [**ShiftTradeMatchesSummaryResponse**](ShiftTradeMatchesSummaryResponse) GetWorkforcemanagementManagementunitShifttradesMatched (string managementUnitId)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.

            try
            { 
                // Gets a summary of all shift trades in the matched state
                ShiftTradeMatchesSummaryResponse result = apiInstance.GetWorkforcemanagementManagementunitShifttradesMatched(managementUnitId);
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
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |

### Return type

[**ShiftTradeMatchesSummaryResponse**](ShiftTradeMatchesSummaryResponse)


## GetWorkforcemanagementManagementunitShifttradesUsers

> [**WfmUserEntityListing**](WfmUserEntityListing) GetWorkforcemanagementManagementunitShifttradesUsers (string managementUnitId)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.

            try
            { 
                // Gets list of users available for whom you can send direct shift trade requests
                WfmUserEntityListing result = apiInstance.GetWorkforcemanagementManagementunitShifttradesUsers(managementUnitId);
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
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |

### Return type

[**WfmUserEntityListing**](WfmUserEntityListing)


## GetWorkforcemanagementManagementunitTimeofflimit

> [**TimeOffLimit**](TimeOffLimit) GetWorkforcemanagementManagementunitTimeofflimit (string managementUnitId, string timeOffLimitId)


Gets a time off limit object

Returns properties of time off limit object, but not daily values.

Requires ANY permissions: 

* wfm:timeOffLimit:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitTimeofflimitExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit.
            var timeOffLimitId = timeOffLimitId_example;  // string | The ID of the time off limit to fetch

            try
            { 
                // Gets a time off limit object
                TimeOffLimit result = apiInstance.GetWorkforcemanagementManagementunitTimeofflimit(managementUnitId, timeOffLimitId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitTimeofflimit: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit. |  |
| **timeOffLimitId** | **string**| The ID of the time off limit to fetch |  |

### Return type

[**TimeOffLimit**](TimeOffLimit)


## GetWorkforcemanagementManagementunitTimeofflimits

> [**TimeOffLimitListing**](TimeOffLimitListing) GetWorkforcemanagementManagementunitTimeofflimits (string managementUnitId)


Gets a list of time off limit objects under management unit.

Currently only one time off limit object is allowed under management unit, so the list contains either 0 or 1 element.

Requires ANY permissions: 

* wfm:timeOffLimit:view
* wfm:timeOffPlan:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitTimeofflimitsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit.

            try
            { 
                // Gets a list of time off limit objects under management unit.
                TimeOffLimitListing result = apiInstance.GetWorkforcemanagementManagementunitTimeofflimits(managementUnitId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitTimeofflimits: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit. |  |

### Return type

[**TimeOffLimitListing**](TimeOffLimitListing)


## GetWorkforcemanagementManagementunitTimeoffplan

> [**TimeOffPlan**](TimeOffPlan) GetWorkforcemanagementManagementunitTimeoffplan (string managementUnitId, string timeOffPlanId)


Gets a time off plan

Requires ANY permissions: 

* wfm:timeOffPlan:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitTimeoffplanExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit
            var timeOffPlanId = timeOffPlanId_example;  // string | The ID of the time off plan to fetch

            try
            { 
                // Gets a time off plan
                TimeOffPlan result = apiInstance.GetWorkforcemanagementManagementunitTimeoffplan(managementUnitId, timeOffPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitTimeoffplan: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit |  |
| **timeOffPlanId** | **string**| The ID of the time off plan to fetch |  |

### Return type

[**TimeOffPlan**](TimeOffPlan)


## GetWorkforcemanagementManagementunitTimeoffplans

> [**TimeOffPlanListing**](TimeOffPlanListing) GetWorkforcemanagementManagementunitTimeoffplans (string managementUnitId)


Gets a list of time off plans

Requires ANY permissions: 

* wfm:timeOffPlan:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitTimeoffplansExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit

            try
            { 
                // Gets a list of time off plans
                TimeOffPlanListing result = apiInstance.GetWorkforcemanagementManagementunitTimeoffplans(managementUnitId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitTimeoffplans: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit |  |

### Return type

[**TimeOffPlanListing**](TimeOffPlanListing)


## GetWorkforcemanagementManagementunitUserTimeoffrequest

> [**TimeOffRequestResponse**](TimeOffRequestResponse) GetWorkforcemanagementManagementunitUserTimeoffrequest (string managementUnitId, string userId, string timeOffRequestId)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var userId = userId_example;  // string | The userId to whom the Time Off Request applies.
            var timeOffRequestId = timeOffRequestId_example;  // string | Time Off Request Id

            try
            { 
                // Get a time off request
                TimeOffRequestResponse result = apiInstance.GetWorkforcemanagementManagementunitUserTimeoffrequest(managementUnitId, userId, timeOffRequestId);
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
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **userId** | **string**| The userId to whom the Time Off Request applies. |  |
| **timeOffRequestId** | **string**| Time Off Request Id |  |

### Return type

[**TimeOffRequestResponse**](TimeOffRequestResponse)


## GetWorkforcemanagementManagementunitUserTimeoffrequestTimeofflimits

> [**QueryTimeOffLimitValuesResponse**](QueryTimeOffLimitValuesResponse) GetWorkforcemanagementManagementunitUserTimeoffrequestTimeofflimits (string managementUnitId, string userId, string timeOffRequestId)


Retrieves time off limit, allocated and waitlisted values according to specific time off request

Requires ALL permissions: 

* wfm:timeOffRequest:view
* wfm:timeOffLimit:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitUserTimeoffrequestTimeofflimitsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit.
            var userId = userId_example;  // string | The userId to whom the time off request applies.
            var timeOffRequestId = timeOffRequestId_example;  // string | The ID of the time off request, which dates and activityCodeId determine limit values to retrieve

            try
            { 
                // Retrieves time off limit, allocated and waitlisted values according to specific time off request
                QueryTimeOffLimitValuesResponse result = apiInstance.GetWorkforcemanagementManagementunitUserTimeoffrequestTimeofflimits(managementUnitId, userId, timeOffRequestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitUserTimeoffrequestTimeofflimits: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit. |  |
| **userId** | **string**| The userId to whom the time off request applies. |  |
| **timeOffRequestId** | **string**| The ID of the time off request, which dates and activityCodeId determine limit values to retrieve |  |

### Return type

[**QueryTimeOffLimitValuesResponse**](QueryTimeOffLimitValuesResponse)


## GetWorkforcemanagementManagementunitUserTimeoffrequests

> [**TimeOffRequestList**](TimeOffRequestList) GetWorkforcemanagementManagementunitUserTimeoffrequests (string managementUnitId, string userId)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var userId = userId_example;  // string | The userId to whom the Time Off Request applies.

            try
            { 
                // Get a list of time off requests for a given user
                TimeOffRequestList result = apiInstance.GetWorkforcemanagementManagementunitUserTimeoffrequests(managementUnitId, userId);
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
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **userId** | **string**| The userId to whom the Time Off Request applies. |  |

### Return type

[**TimeOffRequestList**](TimeOffRequestList)


## GetWorkforcemanagementManagementunitUsers

> [**WfmUserEntityListing**](WfmUserEntityListing) GetWorkforcemanagementManagementunitUsers (string managementUnitId)


Get users in the management unit

Requires ANY permissions: 

* wfm:agent:view
* wfm:historicalAdherence:view
* wfm:publishedSchedule:view
* wfm:realtimeAdherence:view
* wfm:schedule:view
* wfm:staffingGroup:view
* wfm:timeOffRequest:view
* wfm:workPlanRotation:view
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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.

            try
            { 
                // Get users in the management unit
                WfmUserEntityListing result = apiInstance.GetWorkforcemanagementManagementunitUsers(managementUnitId);
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
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |

### Return type

[**WfmUserEntityListing**](WfmUserEntityListing)


## GetWorkforcemanagementManagementunitWeekSchedule

> [**WeekScheduleResponse**](WeekScheduleResponse) GetWorkforcemanagementManagementunitWeekSchedule (string managementUnitId, string weekId, string scheduleId, string expand = null, bool? forceDownloadService = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

### Return type

[**WeekScheduleResponse**](WeekScheduleResponse)


## GetWorkforcemanagementManagementunitWeekSchedules

> [**WeekScheduleListResponse**](WeekScheduleListResponse) GetWorkforcemanagementManagementunitWeekSchedules (string managementUnitId, string weekId, bool? includeOnlyPublished = null, string earliestWeekDate = null, string latestWeekDate = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

### Return type

[**WeekScheduleListResponse**](WeekScheduleListResponse)


## GetWorkforcemanagementManagementunitWeekShifttrades

> [**WeekShiftTradeListResponse**](WeekShiftTradeListResponse) GetWorkforcemanagementManagementunitWeekShifttrades (string managementUnitId, String weekDateId, bool? evaluateMatches = null, bool? includeCrossWeekShifts = null, bool? forceDownloadService = null)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var weekDateId = 2013-10-20;  // String | The start week date of the initiating shift in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var evaluateMatches = true;  // bool? | Whether to evaluate the matches for violations (optional)  (default to true)
            var includeCrossWeekShifts = true;  // bool? | Whether to include all shift trades with either the initiating shift or the receiving shift in the week (optional)  (default to false)
            var forceDownloadService = true;  // bool? | Force the result of this operation to be sent via download service. For testing/app development purposes (optional) 

            try
            { 
                // Gets all the shift trades for a given week
                WeekShiftTradeListResponse result = apiInstance.GetWorkforcemanagementManagementunitWeekShifttrades(managementUnitId, weekDateId, evaluateMatches, includeCrossWeekShifts, forceDownloadService);
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
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **weekDateId** | **String**| The start week date of the initiating shift in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **evaluateMatches** | **bool?**| Whether to evaluate the matches for violations | [optional] [default to true] |
| **includeCrossWeekShifts** | **bool?**| Whether to include all shift trades with either the initiating shift or the receiving shift in the week | [optional] [default to false] |
| **forceDownloadService** | **bool?**| Force the result of this operation to be sent via download service. For testing/app development purposes | [optional]  |

### Return type

[**WeekShiftTradeListResponse**](WeekShiftTradeListResponse)


## GetWorkforcemanagementManagementunitWorkplan

> [**WorkPlan**](WorkPlan) GetWorkforcemanagementManagementunitWorkplan (string managementUnitId, string workPlanId, List<string> includeOnly = null)


Get a work plan

Requires ANY permissions: 

* wfm:workPlanRotation:view
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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var workPlanId = workPlanId_example;  // string | The ID of the work plan to fetch
            var includeOnly = new List<string>(); // List<string> | limit response to the specified fields (optional) 

            try
            { 
                // Get a work plan
                WorkPlan result = apiInstance.GetWorkforcemanagementManagementunitWorkplan(managementUnitId, workPlanId, includeOnly);
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
| **includeOnly** | [**List<string>**](string)| limit response to the specified fields | [optional] <br />**Values**: agentCount, agents, optionalDays, shifts, shiftStartVariances |

### Return type

[**WorkPlan**](WorkPlan)


## GetWorkforcemanagementManagementunitWorkplanrotation

> [**WorkPlanRotationResponse**](WorkPlanRotationResponse) GetWorkforcemanagementManagementunitWorkplanrotation (string managementUnitId, string workPlanRotationId)


Get a work plan rotation

Requires ANY permissions: 

* wfm:workPlanRotation:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitWorkplanrotationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var workPlanRotationId = workPlanRotationId_example;  // string | The ID of the work plan rotation to fetch

            try
            { 
                // Get a work plan rotation
                WorkPlanRotationResponse result = apiInstance.GetWorkforcemanagementManagementunitWorkplanrotation(managementUnitId, workPlanRotationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitWorkplanrotation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **workPlanRotationId** | **string**| The ID of the work plan rotation to fetch |  |

### Return type

[**WorkPlanRotationResponse**](WorkPlanRotationResponse)


## GetWorkforcemanagementManagementunitWorkplanrotations

> [**WorkPlanRotationListResponse**](WorkPlanRotationListResponse) GetWorkforcemanagementManagementunitWorkplanrotations (string managementUnitId, List<string> expand = null)


Get work plan rotations

Requires ANY permissions: 

* wfm:agent:view
* wfm:workPlanRotation:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementManagementunitWorkplanrotationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var expand = new List<string>(); // List<string> |  (optional) 

            try
            { 
                // Get work plan rotations
                WorkPlanRotationListResponse result = apiInstance.GetWorkforcemanagementManagementunitWorkplanrotations(managementUnitId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitWorkplanrotations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **expand** | [**List<string>**](string)|  | [optional] <br />**Values**: agents |

### Return type

[**WorkPlanRotationListResponse**](WorkPlanRotationListResponse)


## GetWorkforcemanagementManagementunitWorkplans

> [**WorkPlanListResponse**](WorkPlanListResponse) GetWorkforcemanagementManagementunitWorkplans (string managementUnitId, List<string> expand = null, List<string> exclude = null)


Get work plans

\"expand=details\" is deprecated

Requires ANY permissions: 

* wfm:agent:view
* wfm:publishedSchedule:view
* wfm:schedule:view
* wfm:workPlanRotation:view
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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var expand = new List<string>(); // List<string> | Include to access additional data on the work plans (optional) 
            var exclude = new List<string>(); // List<string> | Exclude specific data on the work plans from the response (optional) 

            try
            { 
                // Get work plans
                WorkPlanListResponse result = apiInstance.GetWorkforcemanagementManagementunitWorkplans(managementUnitId, expand, exclude);
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
| **expand** | [**List<string>**](string)| Include to access additional data on the work plans | [optional] <br />**Values**: agentCount, agents, optionalDays, shifts, shiftStartVariances, details |
| **exclude** | [**List<string>**](string)| Exclude specific data on the work plans from the response | [optional] <br />**Values**: shifts.activities |

### Return type

[**WorkPlanListResponse**](WorkPlanListResponse)


## GetWorkforcemanagementManagementunits

> [**ManagementUnitListing**](ManagementUnitListing) GetWorkforcemanagementManagementunits (int? pageSize = null, int? pageNumber = null, string expand = null, string feature = null, string divisionId = null)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var pageSize = 56;  // int? | Deprecated, paging is not supported (optional) 
            var pageNumber = 56;  // int? | Deprecated, paging is not supported (optional) 
            var expand = expand_example;  // string | Deprecated, expand settings on the single MU route (optional) 
            var feature = feature_example;  // string | If specified, the list of management units for which the user is authorized to use the requested feature will be returned (optional) 
            var divisionId = divisionId_example;  // string | If specified, the list of management units belonging to the specified division will be returned (optional) 

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
| **pageSize** | **int?**| Deprecated, paging is not supported | [optional]  |
| **pageNumber** | **int?**| Deprecated, paging is not supported | [optional]  |
| **expand** | **string**| Deprecated, expand settings on the single MU route | [optional] <br />**Values**: details |
| **feature** | **string**| If specified, the list of management units for which the user is authorized to use the requested feature will be returned | [optional] <br />**Values**: AgentHistoricalAdherence, AgentHistoricalAdherenceConformance, AgentSchedule, AgentTimeOffRequest, AgentWorkPlanBid, AlternativeShift, Coaching, Learning, AgentUnavailableTimes, ActivityCodes, ActivityPlans, UnavailableTimes, Agents, BuActivityCodes, BusinessUnits, CapacityPlan, ContinuousForecast, HistoricalAdherence, HistoricalShrinkage, IntradayMonitoring, BuIntradayMonitoring, ManagementUnits, RealTimeAdherence, Schedules, BuSchedules, ServiceGoalTemplates, PlanningGroups, LongTermStaffing, ShiftTrading, ShortTermForecasts, BuShortTermForecasts, StaffingGroups, TimeOffPlans, TimeOffRequests, TimeOffLimits, WorkPlanBids, WorkPlanBidGroups, WorkPlanRotations, WorkPlans |
| **divisionId** | **string**| If specified, the list of management units belonging to the specified division will be returned | [optional]  |

### Return type

[**ManagementUnitListing**](ManagementUnitListing)


## GetWorkforcemanagementManagementunitsDivisionviews

> [**ManagementUnitListing**](ManagementUnitListing) GetWorkforcemanagementManagementunitsDivisionviews (List<string> divisionId = null)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
| **divisionId** | [**List<string>**](string)| The divisionIds to filter by. If omitted, will return all divisions | [optional]  |

### Return type

[**ManagementUnitListing**](ManagementUnitListing)


## GetWorkforcemanagementNotifications

> [**NotificationsResponse**](NotificationsResponse) GetWorkforcemanagementNotifications ()


Get a list of notifications for the current user

Notifications are only initially sent if you have the relevant Notify and Edit permissions

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

### Return type

[**NotificationsResponse**](NotificationsResponse)


## GetWorkforcemanagementSchedulingjob

> [**SchedulingStatusResponse**](SchedulingStatusResponse) GetWorkforcemanagementSchedulingjob (string jobId)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

### Return type

[**SchedulingStatusResponse**](SchedulingStatusResponse)


## GetWorkforcemanagementShifttrades

> [**ShiftTradeListResponse**](ShiftTradeListResponse) GetWorkforcemanagementShifttrades ()


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

### Return type

[**ShiftTradeListResponse**](ShiftTradeListResponse)


## GetWorkforcemanagementShrinkageJob

> [**WfmHistoricalShrinkageResponse**](WfmHistoricalShrinkageResponse) GetWorkforcemanagementShrinkageJob (string jobId)


Request to fetch the status of the historical shrinkage query

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
    public class GetWorkforcemanagementShrinkageJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Request to fetch the status of the historical shrinkage query
                WfmHistoricalShrinkageResponse result = apiInstance.GetWorkforcemanagementShrinkageJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementShrinkageJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |

### Return type

[**WfmHistoricalShrinkageResponse**](WfmHistoricalShrinkageResponse)


## GetWorkforcemanagementTeamAdherence

> [**UserScheduleAdherenceListing**](UserScheduleAdherenceListing) GetWorkforcemanagementTeamAdherence (string teamId)


Get a list of user schedule adherence records for the requested team

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
    public class GetWorkforcemanagementTeamAdherenceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var teamId = teamId_example;  // string | The ID of the team

            try
            { 
                // Get a list of user schedule adherence records for the requested team
                UserScheduleAdherenceListing result = apiInstance.GetWorkforcemanagementTeamAdherence(teamId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementTeamAdherence: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **teamId** | **string**| The ID of the team |  |

### Return type

[**UserScheduleAdherenceListing**](UserScheduleAdherenceListing)


## GetWorkforcemanagementTimeoffbalanceJob

> [**TimeOffBalanceJobResponse**](TimeOffBalanceJobResponse) GetWorkforcemanagementTimeoffbalanceJob (string jobId)


Query the results of time off types job

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
    public class GetWorkforcemanagementTimeoffbalanceJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var jobId = jobId_example;  // string | The ID of the job.

            try
            { 
                // Query the results of time off types job
                TimeOffBalanceJobResponse result = apiInstance.GetWorkforcemanagementTimeoffbalanceJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementTimeoffbalanceJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| The ID of the job. |  |

### Return type

[**TimeOffBalanceJobResponse**](TimeOffBalanceJobResponse)


## GetWorkforcemanagementTimeoffrequest

> [**TimeOffRequestResponse**](TimeOffRequestResponse) GetWorkforcemanagementTimeoffrequest (string timeOffRequestId)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var timeOffRequestId = timeOffRequestId_example;  // string | The ID of the time off request

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
| **timeOffRequestId** | **string**| The ID of the time off request |  |

### Return type

[**TimeOffRequestResponse**](TimeOffRequestResponse)


## GetWorkforcemanagementTimeoffrequestWaitlistpositions

> [**WaitlistPositionListing**](WaitlistPositionListing) GetWorkforcemanagementTimeoffrequestWaitlistpositions (string timeOffRequestId)


Get the daily waitlist positions of a time off request for the current user

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
    public class GetWorkforcemanagementTimeoffrequestWaitlistpositionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var timeOffRequestId = timeOffRequestId_example;  // string | The ID of the time off request

            try
            { 
                // Get the daily waitlist positions of a time off request for the current user
                WaitlistPositionListing result = apiInstance.GetWorkforcemanagementTimeoffrequestWaitlistpositions(timeOffRequestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementTimeoffrequestWaitlistpositions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **timeOffRequestId** | **string**| The ID of the time off request |  |

### Return type

[**WaitlistPositionListing**](WaitlistPositionListing)


## GetWorkforcemanagementTimeoffrequests

> [**TimeOffRequestList**](TimeOffRequestList) GetWorkforcemanagementTimeoffrequests ()


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();

            try
            { 
                // Get a list of time off requests for the current user
                TimeOffRequestList result = apiInstance.GetWorkforcemanagementTimeoffrequests();
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
This endpoint does require any parameters.

### Return type

[**TimeOffRequestList**](TimeOffRequestList)


## GetWorkforcemanagementUserWorkplanbidranks

> [**WorkPlanBidRanks**](WorkPlanBidRanks) GetWorkforcemanagementUserWorkplanbidranks (string userId)


Get work plan bid ranks for a user

Requires ANY permissions: 

* wfm:workPlanBid:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementUserWorkplanbidranksExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var userId = userId_example;  // string | The userId to whom the work plan bid ranks apply.

            try
            { 
                // Get work plan bid ranks for a user
                WorkPlanBidRanks result = apiInstance.GetWorkforcemanagementUserWorkplanbidranks(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementUserWorkplanbidranks: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| The userId to whom the work plan bid ranks apply. |  |

### Return type

[**WorkPlanBidRanks**](WorkPlanBidRanks)


## GetWorkforcemanagementWorkplanbidPreferences

> [**AgentWorkPlanBiddingPreferenceResponse**](AgentWorkPlanBiddingPreferenceResponse) GetWorkforcemanagementWorkplanbidPreferences (string bidId)


Gets an agent's work plan bidding preference

Requires ANY permissions: 

* wfm:agentWorkPlanBid:submit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementWorkplanbidPreferencesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var bidId = bidId_example;  // string | The ID of the work plan bid

            try
            { 
                // Gets an agent's work plan bidding preference
                AgentWorkPlanBiddingPreferenceResponse result = apiInstance.GetWorkforcemanagementWorkplanbidPreferences(bidId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementWorkplanbidPreferences: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **bidId** | **string**| The ID of the work plan bid |  |

### Return type

[**AgentWorkPlanBiddingPreferenceResponse**](AgentWorkPlanBiddingPreferenceResponse)


## GetWorkforcemanagementWorkplanbidWorkplans

> [**AgentWorkPlanListResponse**](AgentWorkPlanListResponse) GetWorkforcemanagementWorkplanbidWorkplans (string bidId)


Gets an agent's work plans for a bid

Requires ANY permissions: 

* wfm:agentWorkPlanBid:submit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementWorkplanbidWorkplansExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var bidId = bidId_example;  // string | The ID of the work plan bid

            try
            { 
                // Gets an agent's work plans for a bid
                AgentWorkPlanListResponse result = apiInstance.GetWorkforcemanagementWorkplanbidWorkplans(bidId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementWorkplanbidWorkplans: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **bidId** | **string**| The ID of the work plan bid |  |

### Return type

[**AgentWorkPlanListResponse**](AgentWorkPlanListResponse)


## GetWorkforcemanagementWorkplanbids

> [**AgentWorkPlanBids**](AgentWorkPlanBids) GetWorkforcemanagementWorkplanbids ()


Gets the list of work plan bids that belong to an agent

Requires ANY permissions: 

* wfm:agentWorkPlanBid:submit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWorkforcemanagementWorkplanbidsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();

            try
            { 
                // Gets the list of work plan bids that belong to an agent
                AgentWorkPlanBids result = apiInstance.GetWorkforcemanagementWorkplanbids();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementWorkplanbids: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**AgentWorkPlanBids**](AgentWorkPlanBids)


## PatchWorkforcemanagementAgentAdherenceExplanation

> [**AdherenceExplanationAsyncResponse**](AdherenceExplanationAsyncResponse) PatchWorkforcemanagementAgentAdherenceExplanation (string agentId, string explanationId, UpdateAdherenceExplanationStatusRequest body)


Update an adherence explanation

Requires ANY permissions: 

* wfm:adherenceExplanation:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchWorkforcemanagementAgentAdherenceExplanationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var agentId = agentId_example;  // string | The ID of the agent to query
            var explanationId = explanationId_example;  // string | The ID of the explanation to update
            var body = new UpdateAdherenceExplanationStatusRequest(); // UpdateAdherenceExplanationStatusRequest | The request body

            try
            { 
                // Update an adherence explanation
                AdherenceExplanationAsyncResponse result = apiInstance.PatchWorkforcemanagementAgentAdherenceExplanation(agentId, explanationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementAgentAdherenceExplanation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **agentId** | **string**| The ID of the agent to query |  |
| **explanationId** | **string**| The ID of the explanation to update |  |
| **body** | [**UpdateAdherenceExplanationStatusRequest**](UpdateAdherenceExplanationStatusRequest)| The request body |  |

### Return type

[**AdherenceExplanationAsyncResponse**](AdherenceExplanationAsyncResponse)


## PatchWorkforcemanagementAlternativeshiftsTrade

> [**AlternativeShiftTradeResponse**](AlternativeShiftTradeResponse) PatchWorkforcemanagementAlternativeshiftsTrade (string tradeId, AgentUpdateAlternativeShiftTradeRequest body)


Update my alternative shifts trade by trade ID

Requires ANY permissions: 

* wfm:agentAlternativeShift:submit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchWorkforcemanagementAlternativeshiftsTradeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var tradeId = tradeId_example;  // string | The ID of the alternative shift trade
            var body = new AgentUpdateAlternativeShiftTradeRequest(); // AgentUpdateAlternativeShiftTradeRequest | body

            try
            { 
                // Update my alternative shifts trade by trade ID
                AlternativeShiftTradeResponse result = apiInstance.PatchWorkforcemanagementAlternativeshiftsTrade(tradeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementAlternativeshiftsTrade: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **tradeId** | **string**| The ID of the alternative shift trade |  |
| **body** | [**AgentUpdateAlternativeShiftTradeRequest**](AgentUpdateAlternativeShiftTradeRequest)| body |  |

### Return type

[**AlternativeShiftTradeResponse**](AlternativeShiftTradeResponse)


## PatchWorkforcemanagementAlternativeshiftsTradesStateJobs

> [**AlternativeShiftAsyncResponse**](AlternativeShiftAsyncResponse) PatchWorkforcemanagementAlternativeshiftsTradesStateJobs (AdminBulkUpdateAlternativeShiftTradeStateRequest body)


Bulk update alternative shift trade states

Requires ANY permissions: 

* wfm:alternativeShift:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchWorkforcemanagementAlternativeshiftsTradesStateJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var body = new AdminBulkUpdateAlternativeShiftTradeStateRequest(); // AdminBulkUpdateAlternativeShiftTradeStateRequest | The request body

            try
            { 
                // Bulk update alternative shift trade states
                AlternativeShiftAsyncResponse result = apiInstance.PatchWorkforcemanagementAlternativeshiftsTradesStateJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementAlternativeshiftsTradesStateJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AdminBulkUpdateAlternativeShiftTradeStateRequest**](AdminBulkUpdateAlternativeShiftTradeStateRequest)| The request body |  |

### Return type

[**AlternativeShiftAsyncResponse**](AlternativeShiftAsyncResponse)


## PatchWorkforcemanagementBusinessunit

> [**BusinessUnitResponse**](BusinessUnitResponse) PatchWorkforcemanagementBusinessunit (string businessUnitId, UpdateBusinessUnitRequest body, bool? includeSchedulingDefaultMessageSeverities = null)


Update business unit

Requires ALL permissions: 

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit, or 'mine' for the business unit of the logged-in user.
            var body = new UpdateBusinessUnitRequest(); // UpdateBusinessUnitRequest | body
            var includeSchedulingDefaultMessageSeverities = true;  // bool? | Whether to include scheduling default message severities (optional) 

            try
            { 
                // Update business unit
                BusinessUnitResponse result = apiInstance.PatchWorkforcemanagementBusinessunit(businessUnitId, body, includeSchedulingDefaultMessageSeverities);
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
| **body** | [**UpdateBusinessUnitRequest**](UpdateBusinessUnitRequest)| body |  |
| **includeSchedulingDefaultMessageSeverities** | **bool?**| Whether to include scheduling default message severities | [optional]  |

### Return type

[**BusinessUnitResponse**](BusinessUnitResponse)


## PatchWorkforcemanagementBusinessunitActivitycode

> [**BusinessUnitActivityCode**](BusinessUnitActivityCode) PatchWorkforcemanagementBusinessunitActivitycode (string businessUnitId, string activityCodeId, UpdateActivityCodeRequest body)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit, or 'mine' for the business unit of the logged-in user.
            var activityCodeId = activityCodeId_example;  // string | The ID of the activity code to update
            var body = new UpdateActivityCodeRequest(); // UpdateActivityCodeRequest | body

            try
            { 
                // Update an activity code
                BusinessUnitActivityCode result = apiInstance.PatchWorkforcemanagementBusinessunitActivitycode(businessUnitId, activityCodeId, body);
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
| **businessUnitId** | **string**| The ID of the business unit, or &#39;mine&#39; for the business unit of the logged-in user. |  |
| **activityCodeId** | **string**| The ID of the activity code to update |  |
| **body** | [**UpdateActivityCodeRequest**](UpdateActivityCodeRequest)| body |  |

### Return type

[**BusinessUnitActivityCode**](BusinessUnitActivityCode)


## PatchWorkforcemanagementBusinessunitActivityplan

> [**ActivityPlanResponse**](ActivityPlanResponse) PatchWorkforcemanagementBusinessunitActivityplan (string businessUnitId, string activityPlanId, UpdateActivityPlanRequest body)


Update an activity plan

If a job associated with the activity plan is in 'Processing' state the activity plan cannot be updated

Requires ANY permissions: 

* wfm:activityPlan:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchWorkforcemanagementBusinessunitActivityplanExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var activityPlanId = activityPlanId_example;  // string | The ID of the activity plan to update
            var body = new UpdateActivityPlanRequest(); // UpdateActivityPlanRequest | body

            try
            { 
                // Update an activity plan
                ActivityPlanResponse result = apiInstance.PatchWorkforcemanagementBusinessunitActivityplan(businessUnitId, activityPlanId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementBusinessunitActivityplan: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **activityPlanId** | **string**| The ID of the activity plan to update |  |
| **body** | [**UpdateActivityPlanRequest**](UpdateActivityPlanRequest)| body |  |

### Return type

[**ActivityPlanResponse**](ActivityPlanResponse)


## PatchWorkforcemanagementBusinessunitAlternativeshiftsSettings

> [**AlternativeShiftBuSettingsResponse**](AlternativeShiftBuSettingsResponse) PatchWorkforcemanagementBusinessunitAlternativeshiftsSettings (string businessUnitId, UpdateAlternativeShiftBuSettingsRequest body)


Update alternative shifts settings for a business unit

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
    public class PatchWorkforcemanagementBusinessunitAlternativeshiftsSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var body = new UpdateAlternativeShiftBuSettingsRequest(); // UpdateAlternativeShiftBuSettingsRequest | body

            try
            { 
                // Update alternative shifts settings for a business unit
                AlternativeShiftBuSettingsResponse result = apiInstance.PatchWorkforcemanagementBusinessunitAlternativeshiftsSettings(businessUnitId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementBusinessunitAlternativeshiftsSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **body** | [**UpdateAlternativeShiftBuSettingsRequest**](UpdateAlternativeShiftBuSettingsRequest)| body |  |

### Return type

[**AlternativeShiftBuSettingsResponse**](AlternativeShiftBuSettingsResponse)


## PatchWorkforcemanagementBusinessunitCapacityplan

> [**CapacityPlanResponse**](CapacityPlanResponse) PatchWorkforcemanagementBusinessunitCapacityplan (string businessUnitId, string capacityPlanId, UpdateCapacityPlanRequest body)


Update a capacity plan configuration

Requires ANY permissions: 

* wfm:capacityPlan:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchWorkforcemanagementBusinessunitCapacityplanExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var capacityPlanId = capacityPlanId_example;  // string | The ID of the capacity plan
            var body = new UpdateCapacityPlanRequest(); // UpdateCapacityPlanRequest | body

            try
            { 
                // Update a capacity plan configuration
                CapacityPlanResponse result = apiInstance.PatchWorkforcemanagementBusinessunitCapacityplan(businessUnitId, capacityPlanId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementBusinessunitCapacityplan: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **capacityPlanId** | **string**| The ID of the capacity plan |  |
| **body** | [**UpdateCapacityPlanRequest**](UpdateCapacityPlanRequest)| body |  |

### Return type

[**CapacityPlanResponse**](CapacityPlanResponse)


## PatchWorkforcemanagementBusinessunitPlanninggroup

> [**PlanningGroup**](PlanningGroup) PatchWorkforcemanagementBusinessunitPlanninggroup (string businessUnitId, string planningGroupId, UpdatePlanningGroupRequest body)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit.
            var planningGroupId = planningGroupId_example;  // string | The ID of a planning group to update
            var body = new UpdatePlanningGroupRequest(); // UpdatePlanningGroupRequest | body

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
| **body** | [**UpdatePlanningGroupRequest**](UpdatePlanningGroupRequest)| body |  |

### Return type

[**PlanningGroup**](PlanningGroup)


## PatchWorkforcemanagementBusinessunitSchedulingRun

> void PatchWorkforcemanagementBusinessunitSchedulingRun (string businessUnitId, string runId, PatchBuScheduleRunRequest body)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var runId = runId_example;  // string | The ID of the schedule run
            var body = new PatchBuScheduleRunRequest(); // PatchBuScheduleRunRequest | body

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
| **body** | [**PatchBuScheduleRunRequest**](PatchBuScheduleRunRequest)| body |  |

### Return type

void (empty response body)


## PatchWorkforcemanagementBusinessunitServicegoaltemplate

> [**ServiceGoalTemplate**](ServiceGoalTemplate) PatchWorkforcemanagementBusinessunitServicegoaltemplate (string businessUnitId, string serviceGoalTemplateId, UpdateServiceGoalTemplate body)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit.
            var serviceGoalTemplateId = serviceGoalTemplateId_example;  // string | The ID of a service goal template to update
            var body = new UpdateServiceGoalTemplate(); // UpdateServiceGoalTemplate | body

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
| **body** | [**UpdateServiceGoalTemplate**](UpdateServiceGoalTemplate)| body |  |

### Return type

[**ServiceGoalTemplate**](ServiceGoalTemplate)


## PatchWorkforcemanagementBusinessunitStaffinggroup

> [**StaffingGroupResponse**](StaffingGroupResponse) PatchWorkforcemanagementBusinessunitStaffinggroup (string businessUnitId, string staffingGroupId, UpdateStaffingGroupRequest body)


Updates a staffing group

Requires ANY permissions: 

* wfm:staffingGroup:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchWorkforcemanagementBusinessunitStaffinggroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var staffingGroupId = staffingGroupId_example;  // string | The ID of the staffing group to update
            var body = new UpdateStaffingGroupRequest(); // UpdateStaffingGroupRequest | body

            try
            { 
                // Updates a staffing group
                StaffingGroupResponse result = apiInstance.PatchWorkforcemanagementBusinessunitStaffinggroup(businessUnitId, staffingGroupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementBusinessunitStaffinggroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **staffingGroupId** | **string**| The ID of the staffing group to update |  |
| **body** | [**UpdateStaffingGroupRequest**](UpdateStaffingGroupRequest)| body |  |

### Return type

[**StaffingGroupResponse**](StaffingGroupResponse)


## PatchWorkforcemanagementBusinessunitTimeoffplan

> [**BuTimeOffPlanResponse**](BuTimeOffPlanResponse) PatchWorkforcemanagementBusinessunitTimeoffplan (string businessUnitId, string timeOffPlanId, BuUpdateTimeOffPlanRequest body)


Updates a time-off plan

Requires ANY permissions: 

* wfm:timeOffPlan:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchWorkforcemanagementBusinessunitTimeoffplanExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var timeOffPlanId = timeOffPlanId_example;  // string | The ID of the time-off plan to update
            var body = new BuUpdateTimeOffPlanRequest(); // BuUpdateTimeOffPlanRequest | body

            try
            { 
                // Updates a time-off plan
                BuTimeOffPlanResponse result = apiInstance.PatchWorkforcemanagementBusinessunitTimeoffplan(businessUnitId, timeOffPlanId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementBusinessunitTimeoffplan: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **timeOffPlanId** | **string**| The ID of the time-off plan to update |  |
| **body** | [**BuUpdateTimeOffPlanRequest**](BuUpdateTimeOffPlanRequest)| body |  |

### Return type

[**BuTimeOffPlanResponse**](BuTimeOffPlanResponse)


## PatchWorkforcemanagementBusinessunitWorkplanbid

> [**WorkPlanBid**](WorkPlanBid) PatchWorkforcemanagementBusinessunitWorkplanbid (string businessUnitId, string bidId, UpdateWorkPlanBid body)


Update work plan bid

Requires ANY permissions: 

* wfm:workPlanBid:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchWorkforcemanagementBusinessunitWorkplanbidExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var bidId = bidId_example;  // string | The id of the workplanbid
            var body = new UpdateWorkPlanBid(); // UpdateWorkPlanBid | The work plan bid to be updated

            try
            { 
                // Update work plan bid
                WorkPlanBid result = apiInstance.PatchWorkforcemanagementBusinessunitWorkplanbid(businessUnitId, bidId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementBusinessunitWorkplanbid: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **bidId** | **string**| The id of the workplanbid |  |
| **body** | [**UpdateWorkPlanBid**](UpdateWorkPlanBid)| The work plan bid to be updated |  |

### Return type

[**WorkPlanBid**](WorkPlanBid)


## PatchWorkforcemanagementBusinessunitWorkplanbidGroup

> [**WorkPlanBidGroupResponse**](WorkPlanBidGroupResponse) PatchWorkforcemanagementBusinessunitWorkplanbidGroup (string businessUnitId, string bidId, string bidGroupId, WorkPlanBidGroupUpdate body)


Update a bid group by bid group Id

Requires ANY permissions: 

* wfm:workPlanBidGroup:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchWorkforcemanagementBusinessunitWorkplanbidGroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var bidId = bidId_example;  // string | The work plan bid id of the bid groups
            var bidGroupId = bidGroupId_example;  // string | Work Plan Bid Group id
            var body = new WorkPlanBidGroupUpdate(); // WorkPlanBidGroupUpdate | body

            try
            { 
                // Update a bid group by bid group Id
                WorkPlanBidGroupResponse result = apiInstance.PatchWorkforcemanagementBusinessunitWorkplanbidGroup(businessUnitId, bidId, bidGroupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementBusinessunitWorkplanbidGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **bidId** | **string**| The work plan bid id of the bid groups |  |
| **bidGroupId** | **string**| Work Plan Bid Group id |  |
| **body** | [**WorkPlanBidGroupUpdate**](WorkPlanBidGroupUpdate)| body |  |

### Return type

[**WorkPlanBidGroupResponse**](WorkPlanBidGroupResponse)


## PatchWorkforcemanagementBusinessunitWorkplanbidGroupPreferences

> [**AdminAgentWorkPlanPreferenceResponse**](AdminAgentWorkPlanPreferenceResponse) PatchWorkforcemanagementBusinessunitWorkplanbidGroupPreferences (string businessUnitId, string bidId, string bidGroupId, AgentsBidAssignedWorkPlanOverrideRequest body)


Overrides the assigned work plan for the specified agents

Requires ANY permissions: 

* wfm:workPlanBidGroup:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchWorkforcemanagementBusinessunitWorkplanbidGroupPreferencesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var bidId = bidId_example;  // string | The work plan bid id of the bid groups
            var bidGroupId = bidGroupId_example;  // string | The ID of the work plan bid group
            var body = new AgentsBidAssignedWorkPlanOverrideRequest(); // AgentsBidAssignedWorkPlanOverrideRequest | body

            try
            { 
                // Overrides the assigned work plan for the specified agents
                AdminAgentWorkPlanPreferenceResponse result = apiInstance.PatchWorkforcemanagementBusinessunitWorkplanbidGroupPreferences(businessUnitId, bidId, bidGroupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementBusinessunitWorkplanbidGroupPreferences: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **bidId** | **string**| The work plan bid id of the bid groups |  |
| **bidGroupId** | **string**| The ID of the work plan bid group |  |
| **body** | [**AgentsBidAssignedWorkPlanOverrideRequest**](AgentsBidAssignedWorkPlanOverrideRequest)| body |  |

### Return type

[**AdminAgentWorkPlanPreferenceResponse**](AdminAgentWorkPlanPreferenceResponse)


## PatchWorkforcemanagementManagementunit

> [**ManagementUnit**](ManagementUnit) PatchWorkforcemanagementManagementunit (string managementUnitId, UpdateManagementUnitRequest body)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var body = new UpdateManagementUnitRequest(); // UpdateManagementUnitRequest | body

            try
            { 
                // Update the requested management unit
                ManagementUnit result = apiInstance.PatchWorkforcemanagementManagementunit(managementUnitId, body);
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
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **body** | [**UpdateManagementUnitRequest**](UpdateManagementUnitRequest)| body |  |

### Return type

[**ManagementUnit**](ManagementUnit)


## PatchWorkforcemanagementManagementunitAgents

> void PatchWorkforcemanagementManagementunitAgents (string managementUnitId, UpdateMuAgentsRequest body)


Update agent configurations

Requires ANY permissions: 

* wfm:agent:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchWorkforcemanagementManagementunitAgentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var body = new UpdateMuAgentsRequest(); // UpdateMuAgentsRequest | body

            try
            { 
                // Update agent configurations
                apiInstance.PatchWorkforcemanagementManagementunitAgents(managementUnitId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementManagementunitAgents: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **body** | [**UpdateMuAgentsRequest**](UpdateMuAgentsRequest)| body |  |

### Return type

void (empty response body)


## PatchWorkforcemanagementManagementunitAgentsWorkplansBulk

> [**UpdateMuAgentWorkPlansBatchResponse**](UpdateMuAgentWorkPlansBatchResponse) PatchWorkforcemanagementManagementunitAgentsWorkplansBulk (string managementUnitId, UpdateMuAgentWorkPlansBatchRequest body)


Updates agent work plan configuration

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
    public class PatchWorkforcemanagementManagementunitAgentsWorkplansBulkExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var body = new UpdateMuAgentWorkPlansBatchRequest(); // UpdateMuAgentWorkPlansBatchRequest | body

            try
            { 
                // Updates agent work plan configuration
                UpdateMuAgentWorkPlansBatchResponse result = apiInstance.PatchWorkforcemanagementManagementunitAgentsWorkplansBulk(managementUnitId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementManagementunitAgentsWorkplansBulk: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **body** | [**UpdateMuAgentWorkPlansBatchRequest**](UpdateMuAgentWorkPlansBatchRequest)| body |  |

### Return type

[**UpdateMuAgentWorkPlansBatchResponse**](UpdateMuAgentWorkPlansBatchResponse)


## PatchWorkforcemanagementManagementunitTimeofflimit

> [**TimeOffLimit**](TimeOffLimit) PatchWorkforcemanagementManagementunitTimeofflimit (string managementUnitId, string timeOffLimitId, UpdateTimeOffLimitRequest body)


Updates a time off limit object.

Updates time off limit object properties, but not daily values.

Requires ANY permissions: 

* wfm:timeOffLimit:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchWorkforcemanagementManagementunitTimeofflimitExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit.
            var timeOffLimitId = timeOffLimitId_example;  // string | The id of time off limit object to update
            var body = new UpdateTimeOffLimitRequest(); // UpdateTimeOffLimitRequest | body

            try
            { 
                // Updates a time off limit object.
                TimeOffLimit result = apiInstance.PatchWorkforcemanagementManagementunitTimeofflimit(managementUnitId, timeOffLimitId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementManagementunitTimeofflimit: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit. |  |
| **timeOffLimitId** | **string**| The id of time off limit object to update |  |
| **body** | [**UpdateTimeOffLimitRequest**](UpdateTimeOffLimitRequest)| body |  |

### Return type

[**TimeOffLimit**](TimeOffLimit)


## PatchWorkforcemanagementManagementunitTimeoffplan

> [**TimeOffPlan**](TimeOffPlan) PatchWorkforcemanagementManagementunitTimeoffplan (string managementUnitId, string timeOffPlanId, UpdateTimeOffPlanRequest body)


Updates a time off plan

Requires ANY permissions: 

* wfm:timeOffPlan:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchWorkforcemanagementManagementunitTimeoffplanExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit
            var timeOffPlanId = timeOffPlanId_example;  // string | The ID of the time off plan to update
            var body = new UpdateTimeOffPlanRequest(); // UpdateTimeOffPlanRequest | body

            try
            { 
                // Updates a time off plan
                TimeOffPlan result = apiInstance.PatchWorkforcemanagementManagementunitTimeoffplan(managementUnitId, timeOffPlanId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementManagementunitTimeoffplan: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit |  |
| **timeOffPlanId** | **string**| The ID of the time off plan to update |  |
| **body** | [**UpdateTimeOffPlanRequest**](UpdateTimeOffPlanRequest)| body |  |

### Return type

[**TimeOffPlan**](TimeOffPlan)


## PatchWorkforcemanagementManagementunitTimeoffrequestUserIntegrationstatus

> [**UserTimeOffIntegrationStatusResponse**](UserTimeOffIntegrationStatusResponse) PatchWorkforcemanagementManagementunitTimeoffrequestUserIntegrationstatus (string managementUnitId, string timeOffRequestId, string userId, SetTimeOffIntegrationStatusRequest body)


Set integration status for a time off request.

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
    public class PatchWorkforcemanagementManagementunitTimeoffrequestUserIntegrationstatusExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit.
            var timeOffRequestId = timeOffRequestId_example;  // string | The ID of the time off request.
            var userId = userId_example;  // string | The ID of user to whom the time off request belongs.
            var body = new SetTimeOffIntegrationStatusRequest(); // SetTimeOffIntegrationStatusRequest | body

            try
            { 
                // Set integration status for a time off request.
                UserTimeOffIntegrationStatusResponse result = apiInstance.PatchWorkforcemanagementManagementunitTimeoffrequestUserIntegrationstatus(managementUnitId, timeOffRequestId, userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementManagementunitTimeoffrequestUserIntegrationstatus: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit. |  |
| **timeOffRequestId** | **string**| The ID of the time off request. |  |
| **userId** | **string**| The ID of user to whom the time off request belongs. |  |
| **body** | [**SetTimeOffIntegrationStatusRequest**](SetTimeOffIntegrationStatusRequest)| body |  |

### Return type

[**UserTimeOffIntegrationStatusResponse**](UserTimeOffIntegrationStatusResponse)


## PatchWorkforcemanagementManagementunitUserTimeoffrequest

> [**TimeOffRequestResponse**](TimeOffRequestResponse) PatchWorkforcemanagementManagementunitUserTimeoffrequest (string managementUnitId, string userId, string timeOffRequestId, AdminTimeOffRequestPatch body)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var userId = userId_example;  // string | The id of the user the requested time off request belongs to
            var timeOffRequestId = timeOffRequestId_example;  // string | The id of the time off request to update
            var body = new AdminTimeOffRequestPatch(); // AdminTimeOffRequestPatch | body

            try
            { 
                // Update a time off request
                TimeOffRequestResponse result = apiInstance.PatchWorkforcemanagementManagementunitUserTimeoffrequest(managementUnitId, userId, timeOffRequestId, body);
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
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **userId** | **string**| The id of the user the requested time off request belongs to |  |
| **timeOffRequestId** | **string**| The id of the time off request to update |  |
| **body** | [**AdminTimeOffRequestPatch**](AdminTimeOffRequestPatch)| body |  |

### Return type

[**TimeOffRequestResponse**](TimeOffRequestResponse)


## PatchWorkforcemanagementManagementunitWeekShifttrade

> [**ShiftTradeResponse**](ShiftTradeResponse) PatchWorkforcemanagementManagementunitWeekShifttrade (string managementUnitId, String weekDateId, string tradeId, PatchShiftTradeRequest body)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var weekDateId = 2013-10-20;  // String | The start week date of the initiating shift in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var tradeId = tradeId_example;  // string | The ID of the shift trade to update
            var body = new PatchShiftTradeRequest(); // PatchShiftTradeRequest | body

            try
            { 
                // Updates a shift trade. This route can only be called by the initiating agent
                ShiftTradeResponse result = apiInstance.PatchWorkforcemanagementManagementunitWeekShifttrade(managementUnitId, weekDateId, tradeId, body);
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
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **weekDateId** | **String**| The start week date of the initiating shift in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **tradeId** | **string**| The ID of the shift trade to update |  |
| **body** | [**PatchShiftTradeRequest**](PatchShiftTradeRequest)| body |  |

### Return type

[**ShiftTradeResponse**](ShiftTradeResponse)


## PatchWorkforcemanagementManagementunitWorkplan

> [**WorkPlan**](WorkPlan) PatchWorkforcemanagementManagementunitWorkplan (string managementUnitId, string workPlanId, WorkPlan body, string validationMode = null)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var workPlanId = workPlanId_example;  // string | The ID of the work plan to update
            var body = new WorkPlan(); // WorkPlan | body
            var validationMode = validationMode_example;  // string | Allows to update work plan even if validation result is invalid (optional) 

            try
            { 
                // Update a work plan
                WorkPlan result = apiInstance.PatchWorkforcemanagementManagementunitWorkplan(managementUnitId, workPlanId, body, validationMode);
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
| **body** | [**WorkPlan**](WorkPlan)| body |  |
| **validationMode** | **string**| Allows to update work plan even if validation result is invalid | [optional] <br />**Values**: Ignore |

### Return type

[**WorkPlan**](WorkPlan)


## PatchWorkforcemanagementManagementunitWorkplanrotation

> [**WorkPlanRotationResponse**](WorkPlanRotationResponse) PatchWorkforcemanagementManagementunitWorkplanrotation (string managementUnitId, string workPlanRotationId, UpdateWorkPlanRotationRequest body)


Update a work plan rotation

Requires ANY permissions: 

* wfm:workPlanRotation:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchWorkforcemanagementManagementunitWorkplanrotationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var workPlanRotationId = workPlanRotationId_example;  // string | The ID of the work plan rotation to update
            var body = new UpdateWorkPlanRotationRequest(); // UpdateWorkPlanRotationRequest | body

            try
            { 
                // Update a work plan rotation
                WorkPlanRotationResponse result = apiInstance.PatchWorkforcemanagementManagementunitWorkplanrotation(managementUnitId, workPlanRotationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementManagementunitWorkplanrotation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **workPlanRotationId** | **string**| The ID of the work plan rotation to update |  |
| **body** | [**UpdateWorkPlanRotationRequest**](UpdateWorkPlanRotationRequest)| body |  |

### Return type

[**WorkPlanRotationResponse**](WorkPlanRotationResponse)


## PatchWorkforcemanagementTimeoffrequest

> [**TimeOffRequestResponse**](TimeOffRequestResponse) PatchWorkforcemanagementTimeoffrequest (string timeOffRequestId, AgentTimeOffRequestPatch body)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var timeOffRequestId = timeOffRequestId_example;  // string | The ID of the time off request
            var body = new AgentTimeOffRequestPatch(); // AgentTimeOffRequestPatch | body

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
| **timeOffRequestId** | **string**| The ID of the time off request |  |
| **body** | [**AgentTimeOffRequestPatch**](AgentTimeOffRequestPatch)| body |  |

### Return type

[**TimeOffRequestResponse**](TimeOffRequestResponse)


## PatchWorkforcemanagementUserWorkplanbidranks

> [**WorkPlanBidRanks**](WorkPlanBidRanks) PatchWorkforcemanagementUserWorkplanbidranks (string userId, WorkPlanBidRanks body)


Update work plan bid ranks for a user

Requires ANY permissions: 

* wfm:workPlanBid:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchWorkforcemanagementUserWorkplanbidranksExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var userId = userId_example;  // string | The userId to whom the work plan bid ranks apply.
            var body = new WorkPlanBidRanks(); // WorkPlanBidRanks | body

            try
            { 
                // Update work plan bid ranks for a user
                WorkPlanBidRanks result = apiInstance.PatchWorkforcemanagementUserWorkplanbidranks(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementUserWorkplanbidranks: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| The userId to whom the work plan bid ranks apply. |  |
| **body** | [**WorkPlanBidRanks**](WorkPlanBidRanks)| body |  |

### Return type

[**WorkPlanBidRanks**](WorkPlanBidRanks)


## PatchWorkforcemanagementUsersWorkplanbidranksBulk

> [**EntityListing**](EntityListing) PatchWorkforcemanagementUsersWorkplanbidranksBulk (List<WorkPlanBidRanks> body)


Update bulk work plan bid ranks on users. Max 50 users can be updated at a time.

Requires ANY permissions: 

* wfm:workPlanBid:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchWorkforcemanagementUsersWorkplanbidranksBulkExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var body = new List<WorkPlanBidRanks>(); // List<WorkPlanBidRanks> | Users

            try
            { 
                // Update bulk work plan bid ranks on users. Max 50 users can be updated at a time.
                EntityListing result = apiInstance.PatchWorkforcemanagementUsersWorkplanbidranksBulk(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementUsersWorkplanbidranksBulk: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**List<WorkPlanBidRanks>**](WorkPlanBidRanks)| Users |  |

### Return type

[**EntityListing**](EntityListing)


## PatchWorkforcemanagementWorkplanbidPreferences

> [**AgentWorkPlanBiddingPreferenceResponse**](AgentWorkPlanBiddingPreferenceResponse) PatchWorkforcemanagementWorkplanbidPreferences (string bidId, UpdateAgentWorkPlanBiddingPreference body)


Update an agent's work plan bidding preference

Requires ANY permissions: 

* wfm:agentWorkPlanBid:submit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchWorkforcemanagementWorkplanbidPreferencesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var bidId = bidId_example;  // string | The ID of the work plan bid
            var body = new UpdateAgentWorkPlanBiddingPreference(); // UpdateAgentWorkPlanBiddingPreference | body

            try
            { 
                // Update an agent's work plan bidding preference
                AgentWorkPlanBiddingPreferenceResponse result = apiInstance.PatchWorkforcemanagementWorkplanbidPreferences(bidId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementWorkplanbidPreferences: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **bidId** | **string**| The ID of the work plan bid |  |
| **body** | [**UpdateAgentWorkPlanBiddingPreference**](UpdateAgentWorkPlanBiddingPreference)| body |  |

### Return type

[**AgentWorkPlanBiddingPreferenceResponse**](AgentWorkPlanBiddingPreferenceResponse)


## PostWorkforcemanagementAdherenceExplanations

> [**AdherenceExplanationAsyncResponse**](AdherenceExplanationAsyncResponse) PostWorkforcemanagementAdherenceExplanations (AddAdherenceExplanationAgentRequest body)


Submit an adherence explanation for the current user

Requires ANY permissions: 

* wfm:agentAdherenceExplanation:submit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementAdherenceExplanationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var body = new AddAdherenceExplanationAgentRequest(); // AddAdherenceExplanationAgentRequest | The request body

            try
            { 
                // Submit an adherence explanation for the current user
                AdherenceExplanationAsyncResponse result = apiInstance.PostWorkforcemanagementAdherenceExplanations(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementAdherenceExplanations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AddAdherenceExplanationAgentRequest**](AddAdherenceExplanationAgentRequest)| The request body |  |

### Return type

[**AdherenceExplanationAsyncResponse**](AdherenceExplanationAsyncResponse)


## PostWorkforcemanagementAdherenceExplanationsQuery

> [**QueryAdherenceExplanationsResponse**](QueryAdherenceExplanationsResponse) PostWorkforcemanagementAdherenceExplanationsQuery (AgentQueryAdherenceExplanationsRequest body, bool? forceAsync = null, bool? forceDownloadService = null)


Query adherence explanations for the current user

Requires ANY permissions: 

* wfm:agentAdherenceExplanation:submit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementAdherenceExplanationsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var body = new AgentQueryAdherenceExplanationsRequest(); // AgentQueryAdherenceExplanationsRequest | The request body
            var forceAsync = true;  // bool? | Force the result of this operation to be sent asynchronously via notification. For testing/app development purposes (optional) 
            var forceDownloadService = true;  // bool? | Force the result of this operation to be sent via download service. For testing/app development purposes (optional) 

            try
            { 
                // Query adherence explanations for the current user
                QueryAdherenceExplanationsResponse result = apiInstance.PostWorkforcemanagementAdherenceExplanationsQuery(body, forceAsync, forceDownloadService);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementAdherenceExplanationsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AgentQueryAdherenceExplanationsRequest**](AgentQueryAdherenceExplanationsRequest)| The request body |  |
| **forceAsync** | **bool?**| Force the result of this operation to be sent asynchronously via notification. For testing/app development purposes | [optional]  |
| **forceDownloadService** | **bool?**| Force the result of this operation to be sent via download service. For testing/app development purposes | [optional]  |

### Return type

[**QueryAdherenceExplanationsResponse**](QueryAdherenceExplanationsResponse)


## PostWorkforcemanagementAdherenceHistorical

> [**WfmHistoricalAdherenceResponse**](WfmHistoricalAdherenceResponse) PostWorkforcemanagementAdherenceHistorical (WfmHistoricalAdherenceQueryForUsers body = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Deprecated. Use bulk routes instead (/adherence/historical/bulk)

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var body = new WfmHistoricalAdherenceQueryForUsers(); // WfmHistoricalAdherenceQueryForUsers | body (optional) 

            try
            { 
                // Deprecated. Use bulk routes instead (/adherence/historical/bulk)
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
| **body** | [**WfmHistoricalAdherenceQueryForUsers**](WfmHistoricalAdherenceQueryForUsers)| body | [optional]  |

### Return type

[**WfmHistoricalAdherenceResponse**](WfmHistoricalAdherenceResponse)


## PostWorkforcemanagementAdherenceHistoricalBulk

> [**WfmHistoricalAdherenceBulkResponse**](WfmHistoricalAdherenceBulkResponse) PostWorkforcemanagementAdherenceHistoricalBulk (WfmHistoricalAdherenceBulkQuery body)


Request a historical adherence report in bulk

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
    public class PostWorkforcemanagementAdherenceHistoricalBulkExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var body = new WfmHistoricalAdherenceBulkQuery(); // WfmHistoricalAdherenceBulkQuery | body

            try
            { 
                // Request a historical adherence report in bulk
                WfmHistoricalAdherenceBulkResponse result = apiInstance.PostWorkforcemanagementAdherenceHistoricalBulk(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementAdherenceHistoricalBulk: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**WfmHistoricalAdherenceBulkQuery**](WfmHistoricalAdherenceBulkQuery)| body |  |

### Return type

[**WfmHistoricalAdherenceBulkResponse**](WfmHistoricalAdherenceBulkResponse)


## PostWorkforcemanagementAgentAdherenceExplanations

> [**AdherenceExplanationAsyncResponse**](AdherenceExplanationAsyncResponse) PostWorkforcemanagementAgentAdherenceExplanations (string agentId, AddAdherenceExplanationAdminRequest body)


Add an adherence explanation for the requested user

Requires ANY permissions: 

* wfm:adherenceExplanation:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementAgentAdherenceExplanationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var agentId = agentId_example;  // string | The ID of the agent to query
            var body = new AddAdherenceExplanationAdminRequest(); // AddAdherenceExplanationAdminRequest | The request body

            try
            { 
                // Add an adherence explanation for the requested user
                AdherenceExplanationAsyncResponse result = apiInstance.PostWorkforcemanagementAgentAdherenceExplanations(agentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementAgentAdherenceExplanations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **agentId** | **string**| The ID of the agent to query |  |
| **body** | [**AddAdherenceExplanationAdminRequest**](AddAdherenceExplanationAdminRequest)| The request body |  |

### Return type

[**AdherenceExplanationAsyncResponse**](AdherenceExplanationAsyncResponse)


## PostWorkforcemanagementAgentAdherenceExplanationsQuery

> [**AgentQueryAdherenceExplanationsResponse**](AgentQueryAdherenceExplanationsResponse) PostWorkforcemanagementAgentAdherenceExplanationsQuery (string agentId, AgentQueryAdherenceExplanationsRequest body, bool? forceAsync = null, bool? forceDownloadService = null)


Query adherence explanations for the given agent across a specified range

Requires ANY permissions: 

* wfm:adherenceExplanation:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementAgentAdherenceExplanationsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var agentId = agentId_example;  // string | The ID of the agent to query
            var body = new AgentQueryAdherenceExplanationsRequest(); // AgentQueryAdherenceExplanationsRequest | The request body
            var forceAsync = true;  // bool? | Force the result of this operation to be sent asynchronously via notification. For testing/app development purposes (optional) 
            var forceDownloadService = true;  // bool? | Force the result of this operation to be sent via download service. For testing/app development purposes (optional) 

            try
            { 
                // Query adherence explanations for the given agent across a specified range
                AgentQueryAdherenceExplanationsResponse result = apiInstance.PostWorkforcemanagementAgentAdherenceExplanationsQuery(agentId, body, forceAsync, forceDownloadService);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementAgentAdherenceExplanationsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **agentId** | **string**| The ID of the agent to query |  |
| **body** | [**AgentQueryAdherenceExplanationsRequest**](AgentQueryAdherenceExplanationsRequest)| The request body |  |
| **forceAsync** | **bool?**| Force the result of this operation to be sent asynchronously via notification. For testing/app development purposes | [optional]  |
| **forceDownloadService** | **bool?**| Force the result of this operation to be sent via download service. For testing/app development purposes | [optional]  |

### Return type

[**AgentQueryAdherenceExplanationsResponse**](AgentQueryAdherenceExplanationsResponse)


## PostWorkforcemanagementAgents

> [**MoveAgentsResponse**](MoveAgentsResponse) PostWorkforcemanagementAgents (MoveAgentsRequest body)


Move agents in and out of management unit

Requires ANY permissions: 

* wfm:agent:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementAgentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var body = new MoveAgentsRequest(); // MoveAgentsRequest | body

            try
            { 
                // Move agents in and out of management unit
                MoveAgentsResponse result = apiInstance.PostWorkforcemanagementAgents(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementAgents: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**MoveAgentsRequest**](MoveAgentsRequest)| body |  |

### Return type

[**MoveAgentsResponse**](MoveAgentsResponse)


## PostWorkforcemanagementAgentsIntegrationsHrisQuery

> [**AgentsIntegrationsListing**](AgentsIntegrationsListing) PostWorkforcemanagementAgentsIntegrationsHrisQuery (QueryAgentsIntegrationsRequest body)


Query integrations for agents

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
    public class PostWorkforcemanagementAgentsIntegrationsHrisQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var body = new QueryAgentsIntegrationsRequest(); // QueryAgentsIntegrationsRequest | body

            try
            { 
                // Query integrations for agents
                AgentsIntegrationsListing result = apiInstance.PostWorkforcemanagementAgentsIntegrationsHrisQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementAgentsIntegrationsHrisQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**QueryAgentsIntegrationsRequest**](QueryAgentsIntegrationsRequest)| body |  |

### Return type

[**AgentsIntegrationsListing**](AgentsIntegrationsListing)


## PostWorkforcemanagementAgentsMePossibleworkshifts

> [**AgentPossibleWorkShiftsResponse**](AgentPossibleWorkShiftsResponse) PostWorkforcemanagementAgentsMePossibleworkshifts (AgentPossibleWorkShiftsRequest body)


Get agent possible work shifts for requested time frame

Requires ANY permissions: 

* wfm:agentPossibleWorkShifts:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementAgentsMePossibleworkshiftsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var body = new AgentPossibleWorkShiftsRequest(); // AgentPossibleWorkShiftsRequest | body

            try
            { 
                // Get agent possible work shifts for requested time frame
                AgentPossibleWorkShiftsResponse result = apiInstance.PostWorkforcemanagementAgentsMePossibleworkshifts(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementAgentsMePossibleworkshifts: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AgentPossibleWorkShiftsRequest**](AgentPossibleWorkShiftsRequest)| body |  |

### Return type

[**AgentPossibleWorkShiftsResponse**](AgentPossibleWorkShiftsResponse)


## PostWorkforcemanagementAgentschedulesMine

> [**BuCurrentAgentScheduleSearchResponse**](BuCurrentAgentScheduleSearchResponse) PostWorkforcemanagementAgentschedulesMine (BuGetCurrentAgentScheduleRequest body)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var body = new BuGetCurrentAgentScheduleRequest(); // BuGetCurrentAgentScheduleRequest | body

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
| **body** | [**BuGetCurrentAgentScheduleRequest**](BuGetCurrentAgentScheduleRequest)| body |  |

### Return type

[**BuCurrentAgentScheduleSearchResponse**](BuCurrentAgentScheduleSearchResponse)


## PostWorkforcemanagementAlternativeshiftsOffersJobs

> [**AlternativeShiftAsyncResponse**](AlternativeShiftAsyncResponse) PostWorkforcemanagementAlternativeshiftsOffersJobs (AlternativeShiftOffersRequest body)


Request a list of alternative shift offers for a given schedule

Requires ANY permissions: 

* wfm:agentAlternativeShift:submit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementAlternativeshiftsOffersJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var body = new AlternativeShiftOffersRequest(); // AlternativeShiftOffersRequest | The request body

            try
            { 
                // Request a list of alternative shift offers for a given schedule
                AlternativeShiftAsyncResponse result = apiInstance.PostWorkforcemanagementAlternativeshiftsOffersJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementAlternativeshiftsOffersJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AlternativeShiftOffersRequest**](AlternativeShiftOffersRequest)| The request body |  |

### Return type

[**AlternativeShiftAsyncResponse**](AlternativeShiftAsyncResponse)


## PostWorkforcemanagementAlternativeshiftsOffersSearchJobs

> [**AlternativeShiftAsyncResponse**](AlternativeShiftAsyncResponse) PostWorkforcemanagementAlternativeshiftsOffersSearchJobs (AlternativeShiftSearchOffersRequest body)


Request a search of alternative shift offers for a given shift

Requires ANY permissions: 

* wfm:agentAlternativeShift:submit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementAlternativeshiftsOffersSearchJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var body = new AlternativeShiftSearchOffersRequest(); // AlternativeShiftSearchOffersRequest | The request body

            try
            { 
                // Request a search of alternative shift offers for a given shift
                AlternativeShiftAsyncResponse result = apiInstance.PostWorkforcemanagementAlternativeshiftsOffersSearchJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementAlternativeshiftsOffersSearchJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AlternativeShiftSearchOffersRequest**](AlternativeShiftSearchOffersRequest)| The request body |  |

### Return type

[**AlternativeShiftAsyncResponse**](AlternativeShiftAsyncResponse)


## PostWorkforcemanagementAlternativeshiftsTrades

> [**AlternativeShiftTradeResponse**](AlternativeShiftTradeResponse) PostWorkforcemanagementAlternativeshiftsTrades (CreateAlternativeShiftTradeRequest body)


Create my alternative shift trade using an existing offer's jobId

Requires ANY permissions: 

* wfm:agentAlternativeShift:submit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementAlternativeshiftsTradesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var body = new CreateAlternativeShiftTradeRequest(); // CreateAlternativeShiftTradeRequest | The request body

            try
            { 
                // Create my alternative shift trade using an existing offer's jobId
                AlternativeShiftTradeResponse result = apiInstance.PostWorkforcemanagementAlternativeshiftsTrades(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementAlternativeshiftsTrades: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateAlternativeShiftTradeRequest**](CreateAlternativeShiftTradeRequest)| The request body |  |

### Return type

[**AlternativeShiftTradeResponse**](AlternativeShiftTradeResponse)


## PostWorkforcemanagementBusinessunitActivitycodes

> [**BusinessUnitActivityCode**](BusinessUnitActivityCode) PostWorkforcemanagementBusinessunitActivitycodes (string businessUnitId, CreateActivityCodeRequest body)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit, or 'mine' for the business unit of the logged-in user.
            var body = new CreateActivityCodeRequest(); // CreateActivityCodeRequest | body

            try
            { 
                // Create a new activity code
                BusinessUnitActivityCode result = apiInstance.PostWorkforcemanagementBusinessunitActivitycodes(businessUnitId, body);
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
| **businessUnitId** | **string**| The ID of the business unit, or &#39;mine&#39; for the business unit of the logged-in user. |  |
| **body** | [**CreateActivityCodeRequest**](CreateActivityCodeRequest)| body |  |

### Return type

[**BusinessUnitActivityCode**](BusinessUnitActivityCode)


## PostWorkforcemanagementBusinessunitActivityplanRunsJobs

> [**ActivityPlanJobResponse**](ActivityPlanJobResponse) PostWorkforcemanagementBusinessunitActivityplanRunsJobs (string businessUnitId, string activityPlanId)


Run an activity plan manually

Triggers a job running the activity plan. The activity plan cannot be updated until the job completes

Requires ANY permissions: 

* wfm:activityPlanRunJob:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementBusinessunitActivityplanRunsJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var activityPlanId = activityPlanId_example;  // string | The ID of the activity plan to run

            try
            { 
                // Run an activity plan manually
                ActivityPlanJobResponse result = apiInstance.PostWorkforcemanagementBusinessunitActivityplanRunsJobs(businessUnitId, activityPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitActivityplanRunsJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **activityPlanId** | **string**| The ID of the activity plan to run |  |

### Return type

[**ActivityPlanJobResponse**](ActivityPlanJobResponse)


## PostWorkforcemanagementBusinessunitActivityplans

> [**ActivityPlanResponse**](ActivityPlanResponse) PostWorkforcemanagementBusinessunitActivityplans (string businessUnitId, CreateActivityPlanRequest body)


Create an activity plan

Requires ANY permissions: 

* wfm:activityPlan:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementBusinessunitActivityplansExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var body = new CreateActivityPlanRequest(); // CreateActivityPlanRequest | body

            try
            { 
                // Create an activity plan
                ActivityPlanResponse result = apiInstance.PostWorkforcemanagementBusinessunitActivityplans(businessUnitId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitActivityplans: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **body** | [**CreateActivityPlanRequest**](CreateActivityPlanRequest)| body |  |

### Return type

[**ActivityPlanResponse**](ActivityPlanResponse)


## PostWorkforcemanagementBusinessunitAdherenceExplanationsQuery

> [**BuQueryAdherenceExplanationsResponse**](BuQueryAdherenceExplanationsResponse) PostWorkforcemanagementBusinessunitAdherenceExplanationsQuery (string businessUnitId, BuQueryAdherenceExplanationsRequest body, bool? forceAsync = null, bool? forceDownloadService = null)


Query adherence explanations across an entire business unit for the requested period

Requires ANY permissions: 

* wfm:adherenceExplanation:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementBusinessunitAdherenceExplanationsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var body = new BuQueryAdherenceExplanationsRequest(); // BuQueryAdherenceExplanationsRequest | The request body
            var forceAsync = true;  // bool? | Force the result of this operation to be sent asynchronously via notification. For testing/app development purposes (optional) 
            var forceDownloadService = true;  // bool? | Force the result of this operation to be sent via download service. For testing/app development purposes (optional) 

            try
            { 
                // Query adherence explanations across an entire business unit for the requested period
                BuQueryAdherenceExplanationsResponse result = apiInstance.PostWorkforcemanagementBusinessunitAdherenceExplanationsQuery(businessUnitId, body, forceAsync, forceDownloadService);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitAdherenceExplanationsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **body** | [**BuQueryAdherenceExplanationsRequest**](BuQueryAdherenceExplanationsRequest)| The request body |  |
| **forceAsync** | **bool?**| Force the result of this operation to be sent asynchronously via notification. For testing/app development purposes | [optional]  |
| **forceDownloadService** | **bool?**| Force the result of this operation to be sent via download service. For testing/app development purposes | [optional]  |

### Return type

[**BuQueryAdherenceExplanationsResponse**](BuQueryAdherenceExplanationsResponse)


## PostWorkforcemanagementBusinessunitAgentschedulesSearch

> [**BuAsyncAgentSchedulesSearchResponse**](BuAsyncAgentSchedulesSearchResponse) PostWorkforcemanagementBusinessunitAgentschedulesSearch (string businessUnitId, BuSearchAgentSchedulesRequest body, bool? forceAsync = null, bool? forceDownloadService = null)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var body = new BuSearchAgentSchedulesRequest(); // BuSearchAgentSchedulesRequest | body
            var forceAsync = true;  // bool? | Force the result of this operation to be sent asynchronously via notification. For testing/app development purposes (optional) 
            var forceDownloadService = true;  // bool? | Force the result of this operation to be sent via download service. For testing/app development purposes (optional) 

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
| **body** | [**BuSearchAgentSchedulesRequest**](BuSearchAgentSchedulesRequest)| body |  |
| **forceAsync** | **bool?**| Force the result of this operation to be sent asynchronously via notification. For testing/app development purposes | [optional]  |
| **forceDownloadService** | **bool?**| Force the result of this operation to be sent via download service. For testing/app development purposes | [optional]  |

### Return type

[**BuAsyncAgentSchedulesSearchResponse**](BuAsyncAgentSchedulesSearchResponse)


## PostWorkforcemanagementBusinessunitAlternativeshiftsTradesSearch

> [**BuListAlternativeShiftTradesResponse**](BuListAlternativeShiftTradesResponse) PostWorkforcemanagementBusinessunitAlternativeshiftsTradesSearch (string businessUnitId, SearchAlternativeShiftTradesRequest body, bool? forceAsync = null)


List alternative shifts trades for a given management unit or agent

Requires ANY permissions: 

* wfm:alternativeShift:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementBusinessunitAlternativeshiftsTradesSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var body = new SearchAlternativeShiftTradesRequest(); // SearchAlternativeShiftTradesRequest | The request body
            var forceAsync = true;  // bool? | Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional) 

            try
            { 
                // List alternative shifts trades for a given management unit or agent
                BuListAlternativeShiftTradesResponse result = apiInstance.PostWorkforcemanagementBusinessunitAlternativeshiftsTradesSearch(businessUnitId, body, forceAsync);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitAlternativeshiftsTradesSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **body** | [**SearchAlternativeShiftTradesRequest**](SearchAlternativeShiftTradesRequest)| The request body |  |
| **forceAsync** | **bool?**| Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes | [optional]  |

### Return type

[**BuListAlternativeShiftTradesResponse**](BuListAlternativeShiftTradesResponse)


## PostWorkforcemanagementBusinessunitCapacityplanCopy

> [**CapacityPlanResponse**](CapacityPlanResponse) PostWorkforcemanagementBusinessunitCapacityplanCopy (string businessUnitId, string capacityPlanId, CopyCapacityPlanRequest body)


Copy a capacity plan

Requires ANY permissions: 

* wfm:capacityPlan:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementBusinessunitCapacityplanCopyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var capacityPlanId = capacityPlanId_example;  // string | The ID of the capacity plan
            var body = new CopyCapacityPlanRequest(); // CopyCapacityPlanRequest | body

            try
            { 
                // Copy a capacity plan
                CapacityPlanResponse result = apiInstance.PostWorkforcemanagementBusinessunitCapacityplanCopy(businessUnitId, capacityPlanId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitCapacityplanCopy: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **capacityPlanId** | **string**| The ID of the capacity plan |  |
| **body** | [**CopyCapacityPlanRequest**](CopyCapacityPlanRequest)| body |  |

### Return type

[**CapacityPlanResponse**](CapacityPlanResponse)


## PostWorkforcemanagementBusinessunitCapacityplanRequirementGenerate

> [**CapacityPlanStaffingRequirementResult**](CapacityPlanStaffingRequirementResult) PostWorkforcemanagementBusinessunitCapacityplanRequirementGenerate (string businessUnitId, string capacityPlanId)


Regenerate requirements for capacity plan

Requires ANY permissions: 

* wfm:capacityPlan:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementBusinessunitCapacityplanRequirementGenerateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var capacityPlanId = capacityPlanId_example;  // string | The ID of the capacity plan

            try
            { 
                // Regenerate requirements for capacity plan
                CapacityPlanStaffingRequirementResult result = apiInstance.PostWorkforcemanagementBusinessunitCapacityplanRequirementGenerate(businessUnitId, capacityPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitCapacityplanRequirementGenerate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **capacityPlanId** | **string**| The ID of the capacity plan |  |

### Return type

[**CapacityPlanStaffingRequirementResult**](CapacityPlanStaffingRequirementResult)


## PostWorkforcemanagementBusinessunitCapacityplanStaffinggroupallocations

> [**CapacityPlanStaffingGroupMetricChangeResponse**](CapacityPlanStaffingGroupMetricChangeResponse) PostWorkforcemanagementBusinessunitCapacityplanStaffinggroupallocations (string businessUnitId, string capacityPlanId, CreateCapacityPlanStaffingGroupMetricChangeRequest body)


Create staffing group allocations for a capacity plan

Requires ANY permissions: 

* wfm:capacityPlan:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementBusinessunitCapacityplanStaffinggroupallocationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var capacityPlanId = capacityPlanId_example;  // string | The ID of the capacity plan
            var body = new CreateCapacityPlanStaffingGroupMetricChangeRequest(); // CreateCapacityPlanStaffingGroupMetricChangeRequest | 

            try
            { 
                // Create staffing group allocations for a capacity plan
                CapacityPlanStaffingGroupMetricChangeResponse result = apiInstance.PostWorkforcemanagementBusinessunitCapacityplanStaffinggroupallocations(businessUnitId, capacityPlanId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitCapacityplanStaffinggroupallocations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **capacityPlanId** | **string**| The ID of the capacity plan |  |
| **body** | [**CreateCapacityPlanStaffingGroupMetricChangeRequest**](CreateCapacityPlanStaffingGroupMetricChangeRequest)|  |  |

### Return type

[**CapacityPlanStaffingGroupMetricChangeResponse**](CapacityPlanStaffingGroupMetricChangeResponse)


## PostWorkforcemanagementBusinessunitCapacityplanStaffinggroupallocationshistoryQuery

> [**CapacityPlanStaffingGroupMetricChangeHistoryListResponse**](CapacityPlanStaffingGroupMetricChangeHistoryListResponse) PostWorkforcemanagementBusinessunitCapacityplanStaffinggroupallocationshistoryQuery (string businessUnitId, string capacityPlanId, QueryCapacityPlanStaffingGroupMetricChangeHistory body)


Query staffing groups allocations history for a capacity plan

Requires ANY permissions: 

* wfm:capacityPlan:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementBusinessunitCapacityplanStaffinggroupallocationshistoryQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var capacityPlanId = capacityPlanId_example;  // string | The ID of the capacity plan
            var body = new QueryCapacityPlanStaffingGroupMetricChangeHistory(); // QueryCapacityPlanStaffingGroupMetricChangeHistory | 

            try
            { 
                // Query staffing groups allocations history for a capacity plan
                CapacityPlanStaffingGroupMetricChangeHistoryListResponse result = apiInstance.PostWorkforcemanagementBusinessunitCapacityplanStaffinggroupallocationshistoryQuery(businessUnitId, capacityPlanId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitCapacityplanStaffinggroupallocationshistoryQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **capacityPlanId** | **string**| The ID of the capacity plan |  |
| **body** | [**QueryCapacityPlanStaffingGroupMetricChangeHistory**](QueryCapacityPlanStaffingGroupMetricChangeHistory)|  |  |

### Return type

[**CapacityPlanStaffingGroupMetricChangeHistoryListResponse**](CapacityPlanStaffingGroupMetricChangeHistoryListResponse)


## PostWorkforcemanagementBusinessunitCapacityplanningLongtermrequirementsAutomaticbestmethodWeekForecastForceregenerate

> [**LongTermRequirementsResponse**](LongTermRequirementsResponse) PostWorkforcemanagementBusinessunitCapacityplanningLongtermrequirementsAutomaticbestmethodWeekForecastForceregenerate (string businessUnitId, String weekDateId, string forecastId)


Force regenerate the latest long term staffing requirements for a business unit

Requires ANY permissions: 

* wfm:longTermStaffing:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementBusinessunitCapacityplanningLongtermrequirementsAutomaticbestmethodWeekForecastForceregenerateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | 
            var weekDateId = 2013-10-20;  // String | weekDateId of forecast, format yyyy-MM-dd. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var forecastId = forecastId_example;  // string | forecastId of forecast

            try
            { 
                // Force regenerate the latest long term staffing requirements for a business unit
                LongTermRequirementsResponse result = apiInstance.PostWorkforcemanagementBusinessunitCapacityplanningLongtermrequirementsAutomaticbestmethodWeekForecastForceregenerate(businessUnitId, weekDateId, forecastId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitCapacityplanningLongtermrequirementsAutomaticbestmethodWeekForecastForceregenerate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**|  |  |
| **weekDateId** | **String**| weekDateId of forecast, format yyyy-MM-dd. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **forecastId** | **string**| forecastId of forecast |  |

### Return type

[**LongTermRequirementsResponse**](LongTermRequirementsResponse)


## PostWorkforcemanagementBusinessunitCapacityplans

> [**CapacityPlanResponse**](CapacityPlanResponse) PostWorkforcemanagementBusinessunitCapacityplans (string businessUnitId, CapacityPlanRequest body)


Create a new capacity plan

Requires ANY permissions: 

* wfm:capacityPlan:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementBusinessunitCapacityplansExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var body = new CapacityPlanRequest(); // CapacityPlanRequest | body

            try
            { 
                // Create a new capacity plan
                CapacityPlanResponse result = apiInstance.PostWorkforcemanagementBusinessunitCapacityplans(businessUnitId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitCapacityplans: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **body** | [**CapacityPlanRequest**](CapacityPlanRequest)| body |  |

### Return type

[**CapacityPlanResponse**](CapacityPlanResponse)


## PostWorkforcemanagementBusinessunitCapacityplansBulkRemove

> void PostWorkforcemanagementBusinessunitCapacityplansBulkRemove (string businessUnitId, CapacityPlanDeleteRequest body)


Delete capacity plans in a business unit

Requires ANY permissions: 

* wfm:capacityPlan:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementBusinessunitCapacityplansBulkRemoveExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var body = new CapacityPlanDeleteRequest(); // CapacityPlanDeleteRequest | body

            try
            { 
                // Delete capacity plans in a business unit
                apiInstance.PostWorkforcemanagementBusinessunitCapacityplansBulkRemove(businessUnitId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitCapacityplansBulkRemove: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **body** | [**CapacityPlanDeleteRequest**](CapacityPlanDeleteRequest)| body |  |

### Return type

void (empty response body)


## PostWorkforcemanagementBusinessunitIntraday

> [**AsyncIntradayResponse**](AsyncIntradayResponse) PostWorkforcemanagementBusinessunitIntraday (string businessUnitId, IntradayPlanningGroupRequest body, bool? forceAsync = null)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var body = new IntradayPlanningGroupRequest(); // IntradayPlanningGroupRequest | body
            var forceAsync = true;  // bool? | Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional) 

            try
            { 
                // Get intraday data for the given date for the requested planningGroupIds
                AsyncIntradayResponse result = apiInstance.PostWorkforcemanagementBusinessunitIntraday(businessUnitId, body, forceAsync);
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
| **businessUnitId** | **string**| The ID of the business unit |  |
| **body** | [**IntradayPlanningGroupRequest**](IntradayPlanningGroupRequest)| body |  |
| **forceAsync** | **bool?**| Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes | [optional]  |

### Return type

[**AsyncIntradayResponse**](AsyncIntradayResponse)


## PostWorkforcemanagementBusinessunitPlanninggroups

> [**PlanningGroup**](PlanningGroup) PostWorkforcemanagementBusinessunitPlanninggroups (string businessUnitId, CreatePlanningGroupRequest body)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit.
            var body = new CreatePlanningGroupRequest(); // CreatePlanningGroupRequest | body

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
| **body** | [**CreatePlanningGroupRequest**](CreatePlanningGroupRequest)| body |  |

### Return type

[**PlanningGroup**](PlanningGroup)


## PostWorkforcemanagementBusinessunitServicegoaltemplates

> [**ServiceGoalTemplate**](ServiceGoalTemplate) PostWorkforcemanagementBusinessunitServicegoaltemplates (string businessUnitId, CreateServiceGoalTemplate body)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit.
            var body = new CreateServiceGoalTemplate(); // CreateServiceGoalTemplate | body

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
| **body** | [**CreateServiceGoalTemplate**](CreateServiceGoalTemplate)| body |  |

### Return type

[**ServiceGoalTemplate**](ServiceGoalTemplate)


## PostWorkforcemanagementBusinessunitStaffinggroups

> [**StaffingGroupResponse**](StaffingGroupResponse) PostWorkforcemanagementBusinessunitStaffinggroups (string businessUnitId, CreateStaffingGroupRequest body)


Creates a new staffing group

Requires ANY permissions: 

* wfm:staffingGroup:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementBusinessunitStaffinggroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var body = new CreateStaffingGroupRequest(); // CreateStaffingGroupRequest | body

            try
            { 
                // Creates a new staffing group
                StaffingGroupResponse result = apiInstance.PostWorkforcemanagementBusinessunitStaffinggroups(businessUnitId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitStaffinggroups: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **body** | [**CreateStaffingGroupRequest**](CreateStaffingGroupRequest)| body |  |

### Return type

[**StaffingGroupResponse**](StaffingGroupResponse)


## PostWorkforcemanagementBusinessunitStaffinggroupsPlanninggroupsQuery

> [**PlanningGroupToStaffingGroupsListing**](PlanningGroupToStaffingGroupsListing) PostWorkforcemanagementBusinessunitStaffinggroupsPlanninggroupsQuery (string businessUnitId, QueryPlanningGroupToStaffingGroupsRequest body)


Gets a list of planning group to staffing groups list association

Requires ANY permissions: 

* wfm:staffingGroup:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementBusinessunitStaffinggroupsPlanninggroupsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var body = new QueryPlanningGroupToStaffingGroupsRequest(); // QueryPlanningGroupToStaffingGroupsRequest | body

            try
            { 
                // Gets a list of planning group to staffing groups list association
                PlanningGroupToStaffingGroupsListing result = apiInstance.PostWorkforcemanagementBusinessunitStaffinggroupsPlanninggroupsQuery(businessUnitId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitStaffinggroupsPlanninggroupsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **body** | [**QueryPlanningGroupToStaffingGroupsRequest**](QueryPlanningGroupToStaffingGroupsRequest)| body |  |

### Return type

[**PlanningGroupToStaffingGroupsListing**](PlanningGroupToStaffingGroupsListing)


## PostWorkforcemanagementBusinessunitStaffinggroupsQuery

> [**UserStaffingGroupListing**](UserStaffingGroupListing) PostWorkforcemanagementBusinessunitStaffinggroupsQuery (string businessUnitId, QueryUserStaffingGroupListRequest body, bool? forceDownloadService = null)


Gets staffing group associations for a list of user IDs

Requires ANY permissions: 

* wfm:staffingGroup:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementBusinessunitStaffinggroupsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var body = new QueryUserStaffingGroupListRequest(); // QueryUserStaffingGroupListRequest | body
            var forceDownloadService = true;  // bool? | Force the result of this operation to be sent via download service (optional) 

            try
            { 
                // Gets staffing group associations for a list of user IDs
                UserStaffingGroupListing result = apiInstance.PostWorkforcemanagementBusinessunitStaffinggroupsQuery(businessUnitId, body, forceDownloadService);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitStaffinggroupsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **body** | [**QueryUserStaffingGroupListRequest**](QueryUserStaffingGroupListRequest)| body |  |
| **forceDownloadService** | **bool?**| Force the result of this operation to be sent via download service | [optional]  |

### Return type

[**UserStaffingGroupListing**](UserStaffingGroupListing)


## PostWorkforcemanagementBusinessunitTimeofflimits

> [**BuTimeOffLimitResponse**](BuTimeOffLimitResponse) PostWorkforcemanagementBusinessunitTimeofflimits (string businessUnitId, BuCreateTimeOffLimitRequest body)


Creates a new time-off limit object

Requires ANY permissions: 

* wfm:timeOffLimit:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementBusinessunitTimeofflimitsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var body = new BuCreateTimeOffLimitRequest(); // BuCreateTimeOffLimitRequest | body

            try
            { 
                // Creates a new time-off limit object
                BuTimeOffLimitResponse result = apiInstance.PostWorkforcemanagementBusinessunitTimeofflimits(businessUnitId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitTimeofflimits: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **body** | [**BuCreateTimeOffLimitRequest**](BuCreateTimeOffLimitRequest)| body |  |

### Return type

[**BuTimeOffLimitResponse**](BuTimeOffLimitResponse)


## PostWorkforcemanagementBusinessunitTimeofflimitsValuesQuery

> [**BuTimeOffLimitValuesResponse**](BuTimeOffLimitValuesResponse) PostWorkforcemanagementBusinessunitTimeofflimitsValuesQuery (string businessUnitId, QueryTimeOffLimitValuesRequest body)


Retrieves time-off limit related values based on a given set of filters.

Requires ANY permissions: 

* wfm:timeOffLimit:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementBusinessunitTimeofflimitsValuesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var body = new QueryTimeOffLimitValuesRequest(); // QueryTimeOffLimitValuesRequest | body

            try
            { 
                // Retrieves time-off limit related values based on a given set of filters.
                BuTimeOffLimitValuesResponse result = apiInstance.PostWorkforcemanagementBusinessunitTimeofflimitsValuesQuery(businessUnitId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitTimeofflimitsValuesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **body** | [**QueryTimeOffLimitValuesRequest**](QueryTimeOffLimitValuesRequest)| body |  |

### Return type

[**BuTimeOffLimitValuesResponse**](BuTimeOffLimitValuesResponse)


## PostWorkforcemanagementBusinessunitTimeoffplans

> [**BuTimeOffPlanResponse**](BuTimeOffPlanResponse) PostWorkforcemanagementBusinessunitTimeoffplans (string businessUnitId, BuCreateTimeOffPlanRequest body)


Creates a new time-off plan

Requires ANY permissions: 

* wfm:timeOffPlan:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementBusinessunitTimeoffplansExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var body = new BuCreateTimeOffPlanRequest(); // BuCreateTimeOffPlanRequest | body

            try
            { 
                // Creates a new time-off plan
                BuTimeOffPlanResponse result = apiInstance.PostWorkforcemanagementBusinessunitTimeoffplans(businessUnitId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitTimeoffplans: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **body** | [**BuCreateTimeOffPlanRequest**](BuCreateTimeOffPlanRequest)| body |  |

### Return type

[**BuTimeOffPlanResponse**](BuTimeOffPlanResponse)


## PostWorkforcemanagementBusinessunitWeekScheduleAgentschedulesQuery

> [**BuAsyncAgentSchedulesQueryResponse**](BuAsyncAgentSchedulesQueryResponse) PostWorkforcemanagementBusinessunitWeekScheduleAgentschedulesQuery (string businessUnitId, String weekId, string scheduleId, BuQueryAgentSchedulesRequest body, bool? forceAsync = null, bool? forceDownloadService = null)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var weekId = 2013-10-20;  // String | First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var scheduleId = scheduleId_example;  // string | The ID of the schedule
            var body = new BuQueryAgentSchedulesRequest(); // BuQueryAgentSchedulesRequest | body
            var forceAsync = true;  // bool? | Force the result of this operation to be sent asynchronously via notification. For testing/app development purposes (optional) 
            var forceDownloadService = true;  // bool? | Force the result of this operation to be sent via download service. For testing/app development purposes (optional) 

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
| **weekId** | **String**| First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **scheduleId** | **string**| The ID of the schedule |  |
| **body** | [**BuQueryAgentSchedulesRequest**](BuQueryAgentSchedulesRequest)| body |  |
| **forceAsync** | **bool?**| Force the result of this operation to be sent asynchronously via notification. For testing/app development purposes | [optional]  |
| **forceDownloadService** | **bool?**| Force the result of this operation to be sent via download service. For testing/app development purposes | [optional]  |

### Return type

[**BuAsyncAgentSchedulesQueryResponse**](BuAsyncAgentSchedulesQueryResponse)


## PostWorkforcemanagementBusinessunitWeekScheduleCopy

> [**BuAsyncScheduleResponse**](BuAsyncScheduleResponse) PostWorkforcemanagementBusinessunitWeekScheduleCopy (string businessUnitId, String weekId, string scheduleId, BuCopyScheduleRequest body)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var weekId = 2013-10-20;  // String | First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
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
| **weekId** | **String**| First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **scheduleId** | **string**| The ID of the schedule to copy |  |
| **body** | [**BuCopyScheduleRequest**](BuCopyScheduleRequest)| body |  |

### Return type

[**BuAsyncScheduleResponse**](BuAsyncScheduleResponse)


## PostWorkforcemanagementBusinessunitWeekSchedulePerformancepredictionsRecalculations

> [**PerformancePredictionRecalculationResponse**](PerformancePredictionRecalculationResponse) PostWorkforcemanagementBusinessunitWeekSchedulePerformancepredictionsRecalculations (string businessUnitId, string weekId, string scheduleId, WfmProcessUploadRequest body)


Request a daily recalculation of the performance prediction for the associated schedule

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
    public class PostWorkforcemanagementBusinessunitWeekSchedulePerformancepredictionsRecalculationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit to which the performance prediction belongs
            var weekId = weekId_example;  // string | First day of schedule week in yyyy-MM-dd format
            var scheduleId = scheduleId_example;  // string | The ID of the schedule the performance prediction belongs to
            var body = new WfmProcessUploadRequest(); // WfmProcessUploadRequest | body

            try
            { 
                // Request a daily recalculation of the performance prediction for the associated schedule
                PerformancePredictionRecalculationResponse result = apiInstance.PostWorkforcemanagementBusinessunitWeekSchedulePerformancepredictionsRecalculations(businessUnitId, weekId, scheduleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitWeekSchedulePerformancepredictionsRecalculations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit to which the performance prediction belongs |  |
| **weekId** | **string**| First day of schedule week in yyyy-MM-dd format |  |
| **scheduleId** | **string**| The ID of the schedule the performance prediction belongs to |  |
| **body** | [**WfmProcessUploadRequest**](WfmProcessUploadRequest)| body |  |

### Return type

[**PerformancePredictionRecalculationResponse**](PerformancePredictionRecalculationResponse)


## PostWorkforcemanagementBusinessunitWeekSchedulePerformancepredictionsRecalculationsUploadurl

> [**PerformancePredictionRecalculationUploadResponse**](PerformancePredictionRecalculationUploadResponse) PostWorkforcemanagementBusinessunitWeekSchedulePerformancepredictionsRecalculationsUploadurl (string businessUnitId, string weekId, string scheduleId, UploadUrlRequestBody body)


Upload daily activity changes to be able to request a performance prediction recalculation

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
    public class PostWorkforcemanagementBusinessunitWeekSchedulePerformancepredictionsRecalculationsUploadurlExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit to which the performance prediction belongs
            var weekId = weekId_example;  // string | First day of schedule week in yyyy-MM-dd format
            var scheduleId = scheduleId_example;  // string | The ID of the schedule the performance prediction belongs to
            var body = new UploadUrlRequestBody(); // UploadUrlRequestBody | body

            try
            { 
                // Upload daily activity changes to be able to request a performance prediction recalculation
                PerformancePredictionRecalculationUploadResponse result = apiInstance.PostWorkforcemanagementBusinessunitWeekSchedulePerformancepredictionsRecalculationsUploadurl(businessUnitId, weekId, scheduleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitWeekSchedulePerformancepredictionsRecalculationsUploadurl: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit to which the performance prediction belongs |  |
| **weekId** | **string**| First day of schedule week in yyyy-MM-dd format |  |
| **scheduleId** | **string**| The ID of the schedule the performance prediction belongs to |  |
| **body** | [**UploadUrlRequestBody**](UploadUrlRequestBody)| body |  |

### Return type

[**PerformancePredictionRecalculationUploadResponse**](PerformancePredictionRecalculationUploadResponse)


## PostWorkforcemanagementBusinessunitWeekScheduleReschedule

> [**BuAsyncScheduleRunResponse**](BuAsyncScheduleRunResponse) PostWorkforcemanagementBusinessunitWeekScheduleReschedule (string businessUnitId, String weekId, string scheduleId, BuRescheduleRequest body)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var weekId = 2013-10-20;  // String | First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
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
| **weekId** | **String**| First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **scheduleId** | **string**| The ID of the schedule |  |
| **body** | [**BuRescheduleRequest**](BuRescheduleRequest)| body |  |

### Return type

[**BuAsyncScheduleRunResponse**](BuAsyncScheduleRunResponse)


## PostWorkforcemanagementBusinessunitWeekScheduleUpdate

> [**BuAsyncScheduleResponse**](BuAsyncScheduleResponse) PostWorkforcemanagementBusinessunitWeekScheduleUpdate (string businessUnitId, String weekId, string scheduleId, ProcessScheduleUpdateUploadRequest body)


Starts processing a schedule update

Call after uploading the schedule data to the url supplied by the /update/uploadurl route

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
    public class PostWorkforcemanagementBusinessunitWeekScheduleUpdateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var weekId = 2013-10-20;  // String | First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var scheduleId = scheduleId_example;  // string | The ID of the schedule
            var body = new ProcessScheduleUpdateUploadRequest(); // ProcessScheduleUpdateUploadRequest | body

            try
            { 
                // Starts processing a schedule update
                BuAsyncScheduleResponse result = apiInstance.PostWorkforcemanagementBusinessunitWeekScheduleUpdate(businessUnitId, weekId, scheduleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitWeekScheduleUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **weekId** | **String**| First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **scheduleId** | **string**| The ID of the schedule |  |
| **body** | [**ProcessScheduleUpdateUploadRequest**](ProcessScheduleUpdateUploadRequest)| body |  |

### Return type

[**BuAsyncScheduleResponse**](BuAsyncScheduleResponse)


## PostWorkforcemanagementBusinessunitWeekScheduleUpdateUploadurl

> [**UpdateScheduleUploadResponse**](UpdateScheduleUploadResponse) PostWorkforcemanagementBusinessunitWeekScheduleUpdateUploadurl (string businessUnitId, String weekId, string scheduleId, UploadUrlRequestBody body)


Creates a signed upload URL for updating a schedule

Once the upload is complete, call the /{scheduleId}/update route to start the schedule update process

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
    public class PostWorkforcemanagementBusinessunitWeekScheduleUpdateUploadurlExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var weekId = 2013-10-20;  // String | First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var scheduleId = scheduleId_example;  // string | The ID of the schedule
            var body = new UploadUrlRequestBody(); // UploadUrlRequestBody | body

            try
            { 
                // Creates a signed upload URL for updating a schedule
                UpdateScheduleUploadResponse result = apiInstance.PostWorkforcemanagementBusinessunitWeekScheduleUpdateUploadurl(businessUnitId, weekId, scheduleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitWeekScheduleUpdateUploadurl: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **weekId** | **String**| First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **scheduleId** | **string**| The ID of the schedule |  |
| **body** | [**UploadUrlRequestBody**](UploadUrlRequestBody)| body |  |

### Return type

[**UpdateScheduleUploadResponse**](UpdateScheduleUploadResponse)


## PostWorkforcemanagementBusinessunitWeekSchedules

> [**BuScheduleMetadata**](BuScheduleMetadata) PostWorkforcemanagementBusinessunitWeekSchedules (string businessUnitId, String weekId, BuCreateBlankScheduleRequest body)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var weekId = 2013-10-20;  // String | First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
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
| **weekId** | **String**| First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **body** | [**BuCreateBlankScheduleRequest**](BuCreateBlankScheduleRequest)| body |  |

### Return type

[**BuScheduleMetadata**](BuScheduleMetadata)


## PostWorkforcemanagementBusinessunitWeekSchedulesGenerate

> [**BuAsyncScheduleRunResponse**](BuAsyncScheduleRunResponse) PostWorkforcemanagementBusinessunitWeekSchedulesGenerate (string businessUnitId, String weekId, BuGenerateScheduleRequest body)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var weekId = 2013-10-20;  // String | First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
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
| **weekId** | **String**| First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **body** | [**BuGenerateScheduleRequest**](BuGenerateScheduleRequest)| body |  |

### Return type

[**BuAsyncScheduleRunResponse**](BuAsyncScheduleRunResponse)


## PostWorkforcemanagementBusinessunitWeekSchedulesImport

> [**ScheduleUploadProcessingResponse**](ScheduleUploadProcessingResponse) PostWorkforcemanagementBusinessunitWeekSchedulesImport (string businessUnitId, String weekId, WfmProcessUploadRequest body)


Starts processing a schedule import

Call after uploading the schedule data to the url supplied by the /import/uploadurl route

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
    public class PostWorkforcemanagementBusinessunitWeekSchedulesImportExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var weekId = 2013-10-20;  // String | First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var body = new WfmProcessUploadRequest(); // WfmProcessUploadRequest | 

            try
            { 
                // Starts processing a schedule import
                ScheduleUploadProcessingResponse result = apiInstance.PostWorkforcemanagementBusinessunitWeekSchedulesImport(businessUnitId, weekId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitWeekSchedulesImport: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **weekId** | **String**| First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **body** | [**WfmProcessUploadRequest**](WfmProcessUploadRequest)|  |  |

### Return type

[**ScheduleUploadProcessingResponse**](ScheduleUploadProcessingResponse)


## PostWorkforcemanagementBusinessunitWeekSchedulesImportUploadurl

> [**ImportScheduleUploadResponse**](ImportScheduleUploadResponse) PostWorkforcemanagementBusinessunitWeekSchedulesImportUploadurl (string businessUnitId, String weekId, UploadUrlRequestBody body)


Creates a signed upload URL for importing a schedule

Once the upload is complete, call the /import route to start the schedule import process

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
    public class PostWorkforcemanagementBusinessunitWeekSchedulesImportUploadurlExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var weekId = 2013-10-20;  // String | First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var body = new UploadUrlRequestBody(); // UploadUrlRequestBody | body

            try
            { 
                // Creates a signed upload URL for importing a schedule
                ImportScheduleUploadResponse result = apiInstance.PostWorkforcemanagementBusinessunitWeekSchedulesImportUploadurl(businessUnitId, weekId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitWeekSchedulesImportUploadurl: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **weekId** | **String**| First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **body** | [**UploadUrlRequestBody**](UploadUrlRequestBody)| body |  |

### Return type

[**ImportScheduleUploadResponse**](ImportScheduleUploadResponse)


## PostWorkforcemanagementBusinessunitWeekShorttermforecastCopy

> [**AsyncForecastOperationResult**](AsyncForecastOperationResult) PostWorkforcemanagementBusinessunitWeekShorttermforecastCopy (string businessUnitId, String weekDateId, string forecastId, CopyBuForecastRequest body, bool? forceAsync = null)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit to which the forecast belongs
            var weekDateId = 2013-10-20;  // String | The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
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
| **businessUnitId** | **string**| The ID of the business unit to which the forecast belongs |  |
| **weekDateId** | **String**| The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **forecastId** | **string**| The ID of the forecast to copy |  |
| **body** | [**CopyBuForecastRequest**](CopyBuForecastRequest)| body |  |
| **forceAsync** | **bool?**| Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes | [optional]  |

### Return type

[**AsyncForecastOperationResult**](AsyncForecastOperationResult)


## PostWorkforcemanagementBusinessunitWeekShorttermforecastsGenerate

> [**AsyncForecastOperationResult**](AsyncForecastOperationResult) PostWorkforcemanagementBusinessunitWeekShorttermforecastsGenerate (string businessUnitId, String weekDateId, GenerateBuForecastRequest body, bool? forceAsync = null)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit to which the forecast belongs
            var weekDateId = 2013-10-20;  // String | The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var body = new GenerateBuForecastRequest(); // GenerateBuForecastRequest | body
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
| **businessUnitId** | **string**| The ID of the business unit to which the forecast belongs |  |
| **weekDateId** | **String**| The week start date of the forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **body** | [**GenerateBuForecastRequest**](GenerateBuForecastRequest)| body |  |
| **forceAsync** | **bool?**| Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes | [optional]  |

### Return type

[**AsyncForecastOperationResult**](AsyncForecastOperationResult)


## PostWorkforcemanagementBusinessunitWeekShorttermforecastsImport

> [**ImportForecastResponse**](ImportForecastResponse) PostWorkforcemanagementBusinessunitWeekShorttermforecastsImport (string businessUnitId, String weekDateId, WfmProcessUploadRequest body)


Starts importing the uploaded short term forecast

Call after uploading the forecast data to the url supplied by the /import/uploadurl route

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
    public class PostWorkforcemanagementBusinessunitWeekShorttermforecastsImportExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit to which the forecast belongs
            var weekDateId = 2013-10-20;  // String | First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var body = new WfmProcessUploadRequest(); // WfmProcessUploadRequest | body

            try
            { 
                // Starts importing the uploaded short term forecast
                ImportForecastResponse result = apiInstance.PostWorkforcemanagementBusinessunitWeekShorttermforecastsImport(businessUnitId, weekDateId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitWeekShorttermforecastsImport: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit to which the forecast belongs |  |
| **weekDateId** | **String**| First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **body** | [**WfmProcessUploadRequest**](WfmProcessUploadRequest)| body |  |

### Return type

[**ImportForecastResponse**](ImportForecastResponse)


## PostWorkforcemanagementBusinessunitWeekShorttermforecastsImportUploadurl

> [**ImportForecastUploadResponse**](ImportForecastUploadResponse) PostWorkforcemanagementBusinessunitWeekShorttermforecastsImportUploadurl (string businessUnitId, String weekDateId, UploadUrlRequestBody body)


Creates a signed upload URL for importing a short term forecast

Once the upload is complete, call the /import route to start the short term forecast import process

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
    public class PostWorkforcemanagementBusinessunitWeekShorttermforecastsImportUploadurlExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit to which the forecast belongs
            var weekDateId = 2013-10-20;  // String | First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var body = new UploadUrlRequestBody(); // UploadUrlRequestBody | body

            try
            { 
                // Creates a signed upload URL for importing a short term forecast
                ImportForecastUploadResponse result = apiInstance.PostWorkforcemanagementBusinessunitWeekShorttermforecastsImportUploadurl(businessUnitId, weekDateId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitWeekShorttermforecastsImportUploadurl: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit to which the forecast belongs |  |
| **weekDateId** | **String**| First day of schedule week in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **body** | [**UploadUrlRequestBody**](UploadUrlRequestBody)| body |  |

### Return type

[**ImportForecastUploadResponse**](ImportForecastUploadResponse)


## PostWorkforcemanagementBusinessunitWorkplanbidCopy

> [**WorkPlanBid**](WorkPlanBid) PostWorkforcemanagementBusinessunitWorkplanbidCopy (string businessUnitId, string bidId, CopyWorkPlanBid body)


Copy a work plan bid

Requires ANY permissions: 

* wfm:workPlanBid:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementBusinessunitWorkplanbidCopyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var bidId = bidId_example;  // string | The ID of the work plan bid to copy
            var body = new CopyWorkPlanBid(); // CopyWorkPlanBid | body

            try
            { 
                // Copy a work plan bid
                WorkPlanBid result = apiInstance.PostWorkforcemanagementBusinessunitWorkplanbidCopy(businessUnitId, bidId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitWorkplanbidCopy: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **bidId** | **string**| The ID of the work plan bid to copy |  |
| **body** | [**CopyWorkPlanBid**](CopyWorkPlanBid)| body |  |

### Return type

[**WorkPlanBid**](WorkPlanBid)


## PostWorkforcemanagementBusinessunitWorkplanbidGroups

> [**WorkPlanBidGroupResponse**](WorkPlanBidGroupResponse) PostWorkforcemanagementBusinessunitWorkplanbidGroups (string businessUnitId, string bidId, WorkPlanBidGroupCreate body)


Add a bid group in a given work plan bid

Requires ANY permissions: 

* wfm:workPlanBidGroup:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementBusinessunitWorkplanbidGroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var bidId = bidId_example;  // string | The work plan bid id of the bid groups
            var body = new WorkPlanBidGroupCreate(); // WorkPlanBidGroupCreate | body

            try
            { 
                // Add a bid group in a given work plan bid
                WorkPlanBidGroupResponse result = apiInstance.PostWorkforcemanagementBusinessunitWorkplanbidGroups(businessUnitId, bidId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitWorkplanbidGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **bidId** | **string**| The work plan bid id of the bid groups |  |
| **body** | [**WorkPlanBidGroupCreate**](WorkPlanBidGroupCreate)| body |  |

### Return type

[**WorkPlanBidGroupResponse**](WorkPlanBidGroupResponse)


## PostWorkforcemanagementBusinessunitWorkplanbids

> [**WorkPlanBid**](WorkPlanBid) PostWorkforcemanagementBusinessunitWorkplanbids (string businessUnitId, CreateWorkPlanBid body)


Create a new work plan bid

Requires ANY permissions: 

* wfm:workPlanBid:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementBusinessunitWorkplanbidsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var body = new CreateWorkPlanBid(); // CreateWorkPlanBid | The work plan bid to be created

            try
            { 
                // Create a new work plan bid
                WorkPlanBid result = apiInstance.PostWorkforcemanagementBusinessunitWorkplanbids(businessUnitId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementBusinessunitWorkplanbids: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **body** | [**CreateWorkPlanBid**](CreateWorkPlanBid)| The work plan bid to be created |  |

### Return type

[**WorkPlanBid**](WorkPlanBid)


## PostWorkforcemanagementBusinessunits

> [**BusinessUnitResponse**](BusinessUnitResponse) PostWorkforcemanagementBusinessunits (CreateBusinessUnitRequest body, bool? includeSchedulingDefaultMessageSeverities = null)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var body = new CreateBusinessUnitRequest(); // CreateBusinessUnitRequest | body
            var includeSchedulingDefaultMessageSeverities = true;  // bool? | Whether to include scheduling default message severities (optional) 

            try
            { 
                // Add a new business unit
                BusinessUnitResponse result = apiInstance.PostWorkforcemanagementBusinessunits(body, includeSchedulingDefaultMessageSeverities);
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
| **body** | [**CreateBusinessUnitRequest**](CreateBusinessUnitRequest)| body |  |
| **includeSchedulingDefaultMessageSeverities** | **bool?**| Whether to include scheduling default message severities | [optional]  |

### Return type

[**BusinessUnitResponse**](BusinessUnitResponse)


## PostWorkforcemanagementCalendarUrlIcs

> [**CalendarUrlResponse**](CalendarUrlResponse) PostWorkforcemanagementCalendarUrlIcs (string language = null)


Create a newly generated calendar link for the current user; if the current user has previously generated one, the generated link will be returned

Requires ALL permissions: 

* wfm:agentSchedule:sync
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
    public class PostWorkforcemanagementCalendarUrlIcsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var language = en-US;  // string | A language tag (which is sometimes referred to as a \"locale identifier\") to use to localize default activity code names in the ics-formatted calendar (optional)  (default to "en-US")

            try
            { 
                // Create a newly generated calendar link for the current user; if the current user has previously generated one, the generated link will be returned
                CalendarUrlResponse result = apiInstance.PostWorkforcemanagementCalendarUrlIcs(language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementCalendarUrlIcs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **language** | **string**| A language tag (which is sometimes referred to as a \&quot;locale identifier\&quot;) to use to localize default activity code names in the ics-formatted calendar | [optional] [default to "en-US"] |

### Return type

[**CalendarUrlResponse**](CalendarUrlResponse)


## PostWorkforcemanagementHistoricaldataBulkRemoveJobs

> [**HistoricalImportDeleteFilesJobResponse**](HistoricalImportDeleteFilesJobResponse) PostWorkforcemanagementHistoricaldataBulkRemoveJobs (HistoricalImportDeleteFilesJobRequest body)


Delete the list of the historical data import entries

Requires ALL permissions: 

* wfm:historicalData:upload

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementHistoricaldataBulkRemoveJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var body = new HistoricalImportDeleteFilesJobRequest(); // HistoricalImportDeleteFilesJobRequest | body

            try
            { 
                // Delete the list of the historical data import entries
                HistoricalImportDeleteFilesJobResponse result = apiInstance.PostWorkforcemanagementHistoricaldataBulkRemoveJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementHistoricaldataBulkRemoveJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**HistoricalImportDeleteFilesJobRequest**](HistoricalImportDeleteFilesJobRequest)| body |  |

### Return type

[**HistoricalImportDeleteFilesJobResponse**](HistoricalImportDeleteFilesJobResponse)


## PostWorkforcemanagementHistoricaldataValidate

> [**ValidationServiceAsyncResponse**](ValidationServiceAsyncResponse) PostWorkforcemanagementHistoricaldataValidate (ValidationServiceRequest body)


Trigger validation process for historical import

Requires ALL permissions: 

* wfm:historicalData:upload

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementHistoricaldataValidateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var body = new ValidationServiceRequest(); // ValidationServiceRequest | body

            try
            { 
                // Trigger validation process for historical import
                ValidationServiceAsyncResponse result = apiInstance.PostWorkforcemanagementHistoricaldataValidate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementHistoricaldataValidate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ValidationServiceRequest**](ValidationServiceRequest)| body |  |

### Return type

[**ValidationServiceAsyncResponse**](ValidationServiceAsyncResponse)


## PostWorkforcemanagementIntegrationsHriTimeofftypesJobs

> [**HrisTimeOffTypesResponse**](HrisTimeOffTypesResponse) PostWorkforcemanagementIntegrationsHriTimeofftypesJobs (string hrisIntegrationId)


Get list of time off types configured in integration

Requires ANY permissions: 

* wfm:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementIntegrationsHriTimeofftypesJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var hrisIntegrationId = hrisIntegrationId_example;  // string | The ID of the HRIS integration for which time off types are queried.

            try
            { 
                // Get list of time off types configured in integration
                HrisTimeOffTypesResponse result = apiInstance.PostWorkforcemanagementIntegrationsHriTimeofftypesJobs(hrisIntegrationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementIntegrationsHriTimeofftypesJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **hrisIntegrationId** | **string**| The ID of the HRIS integration for which time off types are queried. |  |

### Return type

[**HrisTimeOffTypesResponse**](HrisTimeOffTypesResponse)


## PostWorkforcemanagementManagementunitAgentsWorkplansQuery

> [**AgentsWorkPlansResponse**](AgentsWorkPlansResponse) PostWorkforcemanagementManagementunitAgentsWorkplansQuery (string managementUnitId, GetAgentsWorkPlansRequest body, bool? forceDownloadService = null)


Get agents work plans configuration

Requires ANY permissions: 

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
    public class PostWorkforcemanagementManagementunitAgentsWorkplansQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var body = new GetAgentsWorkPlansRequest(); // GetAgentsWorkPlansRequest | body
            var forceDownloadService = true;  // bool? | Force the result of this operation to be sent via download service. For testing/app development purposes (optional) 

            try
            { 
                // Get agents work plans configuration
                AgentsWorkPlansResponse result = apiInstance.PostWorkforcemanagementManagementunitAgentsWorkplansQuery(managementUnitId, body, forceDownloadService);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitAgentsWorkplansQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **body** | [**GetAgentsWorkPlansRequest**](GetAgentsWorkPlansRequest)| body |  |
| **forceDownloadService** | **bool?**| Force the result of this operation to be sent via download service. For testing/app development purposes | [optional]  |

### Return type

[**AgentsWorkPlansResponse**](AgentsWorkPlansResponse)


## PostWorkforcemanagementManagementunitAgentschedulesSearch

> [**BuAsyncAgentSchedulesSearchResponse**](BuAsyncAgentSchedulesSearchResponse) PostWorkforcemanagementManagementunitAgentschedulesSearch (string managementUnitId, BuSearchAgentSchedulesRequest body, bool? forceAsync = null, bool? forceDownloadService = null)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var body = new BuSearchAgentSchedulesRequest(); // BuSearchAgentSchedulesRequest | body
            var forceAsync = true;  // bool? | Force the result of this operation to be sent asynchronously via notification. For testing/app development purposes (optional) 
            var forceDownloadService = true;  // bool? | Force the result of this operation to be sent via download service. For testing/app development purposes (optional) 

            try
            { 
                // Query published schedules for given given time range for set of users
                BuAsyncAgentSchedulesSearchResponse result = apiInstance.PostWorkforcemanagementManagementunitAgentschedulesSearch(managementUnitId, body, forceAsync, forceDownloadService);
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
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **body** | [**BuSearchAgentSchedulesRequest**](BuSearchAgentSchedulesRequest)| body |  |
| **forceAsync** | **bool?**| Force the result of this operation to be sent asynchronously via notification. For testing/app development purposes | [optional]  |
| **forceDownloadService** | **bool?**| Force the result of this operation to be sent via download service. For testing/app development purposes | [optional]  |

### Return type

[**BuAsyncAgentSchedulesSearchResponse**](BuAsyncAgentSchedulesSearchResponse)


## PostWorkforcemanagementManagementunitHistoricaladherencequery

> [**WfmHistoricalAdherenceResponse**](WfmHistoricalAdherenceResponse) PostWorkforcemanagementManagementunitHistoricaladherencequery (string managementUnitId, WfmHistoricalAdherenceQuery body)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit
            var body = new WfmHistoricalAdherenceQuery(); // WfmHistoricalAdherenceQuery | body

            try
            { 
                // Request a historical adherence report
                WfmHistoricalAdherenceResponse result = apiInstance.PostWorkforcemanagementManagementunitHistoricaladherencequery(managementUnitId, body);
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
| **managementUnitId** | **string**| The ID of the management unit |  |
| **body** | [**WfmHistoricalAdherenceQuery**](WfmHistoricalAdherenceQuery)| body |  |

### Return type

[**WfmHistoricalAdherenceResponse**](WfmHistoricalAdherenceResponse)


## PostWorkforcemanagementManagementunitMove

> [**MoveManagementUnitResponse**](MoveManagementUnitResponse) PostWorkforcemanagementManagementunitMove (string managementUnitId, MoveManagementUnitRequest body)


Move the requested management unit to a new business unit

Returns status 200 if the management unit is already in the requested business unit

Requires ALL permissions: 

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var body = new MoveManagementUnitRequest(); // MoveManagementUnitRequest | body

            try
            { 
                // Move the requested management unit to a new business unit
                MoveManagementUnitResponse result = apiInstance.PostWorkforcemanagementManagementunitMove(managementUnitId, body);
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
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **body** | [**MoveManagementUnitRequest**](MoveManagementUnitRequest)| body |  |

### Return type

[**MoveManagementUnitResponse**](MoveManagementUnitResponse)


## PostWorkforcemanagementManagementunitSchedulesSearch

> [**UserScheduleContainer**](UserScheduleContainer) PostWorkforcemanagementManagementunitSchedulesSearch (string managementUnitId, UserListScheduleRequestBody body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var body = new UserListScheduleRequestBody(); // UserListScheduleRequestBody | body

            try
            { 
                // Query published schedules for given given time range for set of users
                UserScheduleContainer result = apiInstance.PostWorkforcemanagementManagementunitSchedulesSearch(managementUnitId, body);
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
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **body** | [**UserListScheduleRequestBody**](UserListScheduleRequestBody)| body |  |

### Return type

[**UserScheduleContainer**](UserScheduleContainer)


## PostWorkforcemanagementManagementunitShrinkageJobs

> [**WfmHistoricalShrinkageResponse**](WfmHistoricalShrinkageResponse) PostWorkforcemanagementManagementunitShrinkageJobs (string managementUnitId, WfmHistoricalShrinkageRequest body)


Request a historical shrinkage report

The maximum supported range for historical shrinkage queries is up to 32 days. Historical Shrinkage for a given date range can be queried in two modes - granular and aggregated. To see granular shrinkage information, provide granularity in the request body. 

Requires ANY permissions: 

* wfm:shrinkage:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementManagementunitShrinkageJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit
            var body = new WfmHistoricalShrinkageRequest(); // WfmHistoricalShrinkageRequest | body

            try
            { 
                // Request a historical shrinkage report
                WfmHistoricalShrinkageResponse result = apiInstance.PostWorkforcemanagementManagementunitShrinkageJobs(managementUnitId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitShrinkageJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit |  |
| **body** | [**WfmHistoricalShrinkageRequest**](WfmHistoricalShrinkageRequest)| body |  |

### Return type

[**WfmHistoricalShrinkageResponse**](WfmHistoricalShrinkageResponse)


## PostWorkforcemanagementManagementunitTimeofflimits

> [**TimeOffLimit**](TimeOffLimit) PostWorkforcemanagementManagementunitTimeofflimits (string managementUnitId, CreateTimeOffLimitRequest body)


Creates a new time off limit object under management unit.

Only one limit object is allowed under management unit, so an attempt to create second object will fail.

Requires ANY permissions: 

* wfm:timeOffLimit:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementManagementunitTimeofflimitsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit.
            var body = new CreateTimeOffLimitRequest(); // CreateTimeOffLimitRequest | body

            try
            { 
                // Creates a new time off limit object under management unit.
                TimeOffLimit result = apiInstance.PostWorkforcemanagementManagementunitTimeofflimits(managementUnitId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitTimeofflimits: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit. |  |
| **body** | [**CreateTimeOffLimitRequest**](CreateTimeOffLimitRequest)| body |  |

### Return type

[**TimeOffLimit**](TimeOffLimit)


## PostWorkforcemanagementManagementunitTimeofflimitsValuesQuery

> [**QueryTimeOffLimitValuesResponse**](QueryTimeOffLimitValuesResponse) PostWorkforcemanagementManagementunitTimeofflimitsValuesQuery (string managementUnitId, QueryTimeOffLimitValuesRequest body)


Retrieves time off limit related values based on a given set of filters.

Requires ANY permissions: 

* wfm:timeOffLimit:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementManagementunitTimeofflimitsValuesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit.
            var body = new QueryTimeOffLimitValuesRequest(); // QueryTimeOffLimitValuesRequest | body

            try
            { 
                // Retrieves time off limit related values based on a given set of filters.
                QueryTimeOffLimitValuesResponse result = apiInstance.PostWorkforcemanagementManagementunitTimeofflimitsValuesQuery(managementUnitId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitTimeofflimitsValuesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit. |  |
| **body** | [**QueryTimeOffLimitValuesRequest**](QueryTimeOffLimitValuesRequest)| body |  |

### Return type

[**QueryTimeOffLimitValuesResponse**](QueryTimeOffLimitValuesResponse)


## PostWorkforcemanagementManagementunitTimeoffplans

> [**TimeOffPlan**](TimeOffPlan) PostWorkforcemanagementManagementunitTimeoffplans (string managementUnitId, CreateTimeOffPlanRequest body)


Creates a new time off plan

Requires ANY permissions: 

* wfm:timeOffPlan:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementManagementunitTimeoffplansExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit
            var body = new CreateTimeOffPlanRequest(); // CreateTimeOffPlanRequest | body

            try
            { 
                // Creates a new time off plan
                TimeOffPlan result = apiInstance.PostWorkforcemanagementManagementunitTimeoffplans(managementUnitId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitTimeoffplans: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit |  |
| **body** | [**CreateTimeOffPlanRequest**](CreateTimeOffPlanRequest)| body |  |

### Return type

[**TimeOffPlan**](TimeOffPlan)


## PostWorkforcemanagementManagementunitTimeoffrequests

> [**TimeOffRequestList**](TimeOffRequestList) PostWorkforcemanagementManagementunitTimeoffrequests (string managementUnitId, CreateAdminTimeOffRequest body)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var body = new CreateAdminTimeOffRequest(); // CreateAdminTimeOffRequest | body

            try
            { 
                // Create a new time off request
                TimeOffRequestList result = apiInstance.PostWorkforcemanagementManagementunitTimeoffrequests(managementUnitId, body);
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
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **body** | [**CreateAdminTimeOffRequest**](CreateAdminTimeOffRequest)| body |  |

### Return type

[**TimeOffRequestList**](TimeOffRequestList)


## PostWorkforcemanagementManagementunitTimeoffrequestsIntegrationstatusQuery

> [**UserTimeOffIntegrationStatusResponseListing**](UserTimeOffIntegrationStatusResponseListing) PostWorkforcemanagementManagementunitTimeoffrequestsIntegrationstatusQuery (string managementUnitId, QueryTimeOffIntegrationStatusRequest body)


Retrieves integration statuses for a list of time off requests

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
    public class PostWorkforcemanagementManagementunitTimeoffrequestsIntegrationstatusQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit.
            var body = new QueryTimeOffIntegrationStatusRequest(); // QueryTimeOffIntegrationStatusRequest | body

            try
            { 
                // Retrieves integration statuses for a list of time off requests
                UserTimeOffIntegrationStatusResponseListing result = apiInstance.PostWorkforcemanagementManagementunitTimeoffrequestsIntegrationstatusQuery(managementUnitId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitTimeoffrequestsIntegrationstatusQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit. |  |
| **body** | [**QueryTimeOffIntegrationStatusRequest**](QueryTimeOffIntegrationStatusRequest)| body |  |

### Return type

[**UserTimeOffIntegrationStatusResponseListing**](UserTimeOffIntegrationStatusResponseListing)


## PostWorkforcemanagementManagementunitTimeoffrequestsQuery

> [**TimeOffRequestListing**](TimeOffRequestListing) PostWorkforcemanagementManagementunitTimeoffrequestsQuery (string managementUnitId, TimeOffRequestQueryBody body, bool? forceDownloadService = null)


Fetches time off requests matching the conditions specified in the request body

Request body requires one of the following: User ID is specified, statuses == [Pending] or date range to be specified and less than or equal to 33 days.  All other fields are filters

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var body = new TimeOffRequestQueryBody(); // TimeOffRequestQueryBody | body
            var forceDownloadService = true;  // bool? | Force the result of this operation to be sent via download service. For testing/app development purposes (optional) 

            try
            { 
                // Fetches time off requests matching the conditions specified in the request body
                TimeOffRequestListing result = apiInstance.PostWorkforcemanagementManagementunitTimeoffrequestsQuery(managementUnitId, body, forceDownloadService);
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
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **body** | [**TimeOffRequestQueryBody**](TimeOffRequestQueryBody)| body |  |
| **forceDownloadService** | **bool?**| Force the result of this operation to be sent via download service. For testing/app development purposes | [optional]  |

### Return type

[**TimeOffRequestListing**](TimeOffRequestListing)


## PostWorkforcemanagementManagementunitTimeoffrequestsWaitlistpositionsQuery

> [**WaitlistPositionListing**](WaitlistPositionListing) PostWorkforcemanagementManagementunitTimeoffrequestsWaitlistpositionsQuery (string managementUnitId, QueryWaitlistPositionsRequest body)


Retrieves daily waitlist position for a list of time off requests

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
    public class PostWorkforcemanagementManagementunitTimeoffrequestsWaitlistpositionsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit.
            var body = new QueryWaitlistPositionsRequest(); // QueryWaitlistPositionsRequest | body

            try
            { 
                // Retrieves daily waitlist position for a list of time off requests
                WaitlistPositionListing result = apiInstance.PostWorkforcemanagementManagementunitTimeoffrequestsWaitlistpositionsQuery(managementUnitId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitTimeoffrequestsWaitlistpositionsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit. |  |
| **body** | [**QueryWaitlistPositionsRequest**](QueryWaitlistPositionsRequest)| body |  |

### Return type

[**WaitlistPositionListing**](WaitlistPositionListing)


## PostWorkforcemanagementManagementunitUserTimeoffbalanceJobs

> [**TimeOffBalancesResponse**](TimeOffBalancesResponse) PostWorkforcemanagementManagementunitUserTimeoffbalanceJobs (string managementUnitId, string userId, TimeOffBalanceRequest body)


Query time off balances for a given user for specified activity code and dates

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
    public class PostWorkforcemanagementManagementunitUserTimeoffbalanceJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit
            var userId = userId_example;  // string | The ID of the user
            var body = new TimeOffBalanceRequest(); // TimeOffBalanceRequest | The request body

            try
            { 
                // Query time off balances for a given user for specified activity code and dates
                TimeOffBalancesResponse result = apiInstance.PostWorkforcemanagementManagementunitUserTimeoffbalanceJobs(managementUnitId, userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitUserTimeoffbalanceJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit |  |
| **userId** | **string**| The ID of the user |  |
| **body** | [**TimeOffBalanceRequest**](TimeOffBalanceRequest)| The request body |  |

### Return type

[**TimeOffBalancesResponse**](TimeOffBalancesResponse)


## PostWorkforcemanagementManagementunitUserTimeoffrequestTimeoffbalanceJobs

> [**TimeOffBalancesResponse**](TimeOffBalancesResponse) PostWorkforcemanagementManagementunitUserTimeoffrequestTimeoffbalanceJobs (string managementUnitId, string userId, string timeOffRequestId)


Query time off balances for dates spanned by a given time off request

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
    public class PostWorkforcemanagementManagementunitUserTimeoffrequestTimeoffbalanceJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit.
            var userId = userId_example;  // string | The userId to whom the time off request applies.
            var timeOffRequestId = timeOffRequestId_example;  // string | The time off request id.

            try
            { 
                // Query time off balances for dates spanned by a given time off request
                TimeOffBalancesResponse result = apiInstance.PostWorkforcemanagementManagementunitUserTimeoffrequestTimeoffbalanceJobs(managementUnitId, userId, timeOffRequestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitUserTimeoffrequestTimeoffbalanceJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit. |  |
| **userId** | **string**| The userId to whom the time off request applies. |  |
| **timeOffRequestId** | **string**| The time off request id. |  |

### Return type

[**TimeOffBalancesResponse**](TimeOffBalancesResponse)


## PostWorkforcemanagementManagementunitUserTimeoffrequestsEstimate

> [**EstimateAvailableTimeOffResponse**](EstimateAvailableTimeOffResponse) PostWorkforcemanagementManagementunitUserTimeoffrequestsEstimate (string managementUnitId, string userId, EstimateAvailableTimeOffRequest body)


Estimates available time off for an agent

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
    public class PostWorkforcemanagementManagementunitUserTimeoffrequestsEstimateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit
            var userId = userId_example;  // string | The id of the user for whom the time off request estimate is requested
            var body = new EstimateAvailableTimeOffRequest(); // EstimateAvailableTimeOffRequest | body

            try
            { 
                // Estimates available time off for an agent
                EstimateAvailableTimeOffResponse result = apiInstance.PostWorkforcemanagementManagementunitUserTimeoffrequestsEstimate(managementUnitId, userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitUserTimeoffrequestsEstimate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit |  |
| **userId** | **string**| The id of the user for whom the time off request estimate is requested |  |
| **body** | [**EstimateAvailableTimeOffRequest**](EstimateAvailableTimeOffRequest)| body |  |

### Return type

[**EstimateAvailableTimeOffResponse**](EstimateAvailableTimeOffResponse)


## PostWorkforcemanagementManagementunitWeekShifttradeMatch

> [**MatchShiftTradeResponse**](MatchShiftTradeResponse) PostWorkforcemanagementManagementunitWeekShifttradeMatch (string managementUnitId, String weekDateId, string tradeId, MatchShiftTradeRequest body)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var weekDateId = 2013-10-20;  // String | The start week date of the initiating shift in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var tradeId = tradeId_example;  // string | The ID of the shift trade to update
            var body = new MatchShiftTradeRequest(); // MatchShiftTradeRequest | body

            try
            { 
                // Matches a shift trade. This route can only be called by the receiving agent
                MatchShiftTradeResponse result = apiInstance.PostWorkforcemanagementManagementunitWeekShifttradeMatch(managementUnitId, weekDateId, tradeId, body);
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
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **weekDateId** | **String**| The start week date of the initiating shift in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **tradeId** | **string**| The ID of the shift trade to update |  |
| **body** | [**MatchShiftTradeRequest**](MatchShiftTradeRequest)| body |  |

### Return type

[**MatchShiftTradeResponse**](MatchShiftTradeResponse)


## PostWorkforcemanagementManagementunitWeekShifttrades

> [**ShiftTradeResponse**](ShiftTradeResponse) PostWorkforcemanagementManagementunitWeekShifttrades (string managementUnitId, String weekDateId, AddShiftTradeRequest body)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var weekDateId = 2013-10-20;  // String | The start week date of the initiating shift in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
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
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **weekDateId** | **String**| The start week date of the initiating shift in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **body** | [**AddShiftTradeRequest**](AddShiftTradeRequest)| body |  |

### Return type

[**ShiftTradeResponse**](ShiftTradeResponse)


## PostWorkforcemanagementManagementunitWeekShifttradesSearch

> [**SearchShiftTradesResponse**](SearchShiftTradesResponse) PostWorkforcemanagementManagementunitWeekShifttradesSearch (string managementUnitId, String weekDateId, SearchShiftTradesRequest body, bool? forceDownloadService = null)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var weekDateId = 2013-10-20;  // String | The start week date of the initiating shift in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var body = new SearchShiftTradesRequest(); // SearchShiftTradesRequest | body
            var forceDownloadService = true;  // bool? | Force the result of this operation to be sent via download service. For testing/app development purposes (optional) 

            try
            { 
                // Searches for potential shift trade matches for the current agent
                SearchShiftTradesResponse result = apiInstance.PostWorkforcemanagementManagementunitWeekShifttradesSearch(managementUnitId, weekDateId, body, forceDownloadService);
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
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **weekDateId** | **String**| The start week date of the initiating shift in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **body** | [**SearchShiftTradesRequest**](SearchShiftTradesRequest)| body |  |
| **forceDownloadService** | **bool?**| Force the result of this operation to be sent via download service. For testing/app development purposes | [optional]  |

### Return type

[**SearchShiftTradesResponse**](SearchShiftTradesResponse)


## PostWorkforcemanagementManagementunitWeekShifttradesStateBulk

> [**BulkUpdateShiftTradeStateResponse**](BulkUpdateShiftTradeStateResponse) PostWorkforcemanagementManagementunitWeekShifttradesStateBulk (string managementUnitId, String weekDateId, BulkShiftTradeStateUpdateRequest body, bool? forceAsync = null)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var weekDateId = 2013-10-20;  // String | The start week date of the initiating shift in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
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
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **weekDateId** | **String**| The start week date of the initiating shift in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **body** | [**BulkShiftTradeStateUpdateRequest**](BulkShiftTradeStateUpdateRequest)| body |  |
| **forceAsync** | **bool?**| Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes | [optional]  |

### Return type

[**BulkUpdateShiftTradeStateResponse**](BulkUpdateShiftTradeStateResponse)


## PostWorkforcemanagementManagementunitWorkplanCopy

> [**WorkPlan**](WorkPlan) PostWorkforcemanagementManagementunitWorkplanCopy (string managementUnitId, string workPlanId, CopyWorkPlan body)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var workPlanId = workPlanId_example;  // string | The ID of the work plan to create a copy
            var body = new CopyWorkPlan(); // CopyWorkPlan | body

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
| **body** | [**CopyWorkPlan**](CopyWorkPlan)| body |  |

### Return type

[**WorkPlan**](WorkPlan)


## PostWorkforcemanagementManagementunitWorkplanValidate

> [**ValidateWorkPlanResponse**](ValidateWorkPlanResponse) PostWorkforcemanagementManagementunitWorkplanValidate (string managementUnitId, string workPlanId, WorkPlanValidationRequest body, List<string> expand = null)


Validate Work Plan

Requires ANY permissions: 

* wfm:workPlan:add
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
    public class PostWorkforcemanagementManagementunitWorkplanValidateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var workPlanId = workPlanId_example;  // string | The ID of the work plan to validate. For new work plan, use the word 'new' for the ID.
            var body = new WorkPlanValidationRequest(); // WorkPlanValidationRequest | body
            var expand = new List<string>(); // List<string> |  (optional) 

            try
            { 
                // Validate Work Plan
                ValidateWorkPlanResponse result = apiInstance.PostWorkforcemanagementManagementunitWorkplanValidate(managementUnitId, workPlanId, body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitWorkplanValidate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **workPlanId** | **string**| The ID of the work plan to validate. For new work plan, use the word &#39;new&#39; for the ID. |  |
| **body** | [**WorkPlanValidationRequest**](WorkPlanValidationRequest)| body |  |
| **expand** | [**List<string>**](string)|  | [optional] <br />**Values**: messages |

### Return type

[**ValidateWorkPlanResponse**](ValidateWorkPlanResponse)


## PostWorkforcemanagementManagementunitWorkplanrotationCopy

> [**WorkPlanRotationResponse**](WorkPlanRotationResponse) PostWorkforcemanagementManagementunitWorkplanrotationCopy (string managementUnitId, string workPlanRotationId, CopyWorkPlanRotationRequest body)


Create a copy of work plan rotation

Requires ANY permissions: 

* wfm:workPlanRotation:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementManagementunitWorkplanrotationCopyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var workPlanRotationId = workPlanRotationId_example;  // string | The ID of the work plan rotation to create a copy
            var body = new CopyWorkPlanRotationRequest(); // CopyWorkPlanRotationRequest | body

            try
            { 
                // Create a copy of work plan rotation
                WorkPlanRotationResponse result = apiInstance.PostWorkforcemanagementManagementunitWorkplanrotationCopy(managementUnitId, workPlanRotationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitWorkplanrotationCopy: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **workPlanRotationId** | **string**| The ID of the work plan rotation to create a copy |  |
| **body** | [**CopyWorkPlanRotationRequest**](CopyWorkPlanRotationRequest)| body |  |

### Return type

[**WorkPlanRotationResponse**](WorkPlanRotationResponse)


## PostWorkforcemanagementManagementunitWorkplanrotations

> [**WorkPlanRotationResponse**](WorkPlanRotationResponse) PostWorkforcemanagementManagementunitWorkplanrotations (string managementUnitId, AddWorkPlanRotationRequest body)


Create a new work plan rotation

Requires ANY permissions: 

* wfm:workPlanRotation:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementManagementunitWorkplanrotationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var body = new AddWorkPlanRotationRequest(); // AddWorkPlanRotationRequest | body

            try
            { 
                // Create a new work plan rotation
                WorkPlanRotationResponse result = apiInstance.PostWorkforcemanagementManagementunitWorkplanrotations(managementUnitId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementManagementunitWorkplanrotations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **body** | [**AddWorkPlanRotationRequest**](AddWorkPlanRotationRequest)| body |  |

### Return type

[**WorkPlanRotationResponse**](WorkPlanRotationResponse)


## PostWorkforcemanagementManagementunitWorkplans

> [**WorkPlan**](WorkPlan) PostWorkforcemanagementManagementunitWorkplans (string managementUnitId, CreateWorkPlan body, string validationMode = null)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit, or 'mine' for the management unit of the logged-in user.
            var body = new CreateWorkPlan(); // CreateWorkPlan | body
            var validationMode = validationMode_example;  // string | Allows to create work plan even if the validation result is invalid (optional) 

            try
            { 
                // Create a new work plan
                WorkPlan result = apiInstance.PostWorkforcemanagementManagementunitWorkplans(managementUnitId, body, validationMode);
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
| **body** | [**CreateWorkPlan**](CreateWorkPlan)| body |  |
| **validationMode** | **string**| Allows to create work plan even if the validation result is invalid | [optional] <br />**Values**: Ignore |

### Return type

[**WorkPlan**](WorkPlan)


## PostWorkforcemanagementManagementunits

> [**ManagementUnit**](ManagementUnit) PostWorkforcemanagementManagementunits (CreateManagementUnitApiRequest body)


Add a management unit

It may take a minute or two for a new management unit to be available for api operations

Requires ALL permissions: 

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var body = new CreateManagementUnitApiRequest(); // CreateManagementUnitApiRequest | body

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
| **body** | [**CreateManagementUnitApiRequest**](CreateManagementUnitApiRequest)| body |  |

### Return type

[**ManagementUnit**](ManagementUnit)


## PostWorkforcemanagementNotificationsUpdate

> [**UpdateNotificationsResponse**](UpdateNotificationsResponse) PostWorkforcemanagementNotificationsUpdate (UpdateNotificationsRequest body)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var body = new UpdateNotificationsRequest(); // UpdateNotificationsRequest | body

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
| **body** | [**UpdateNotificationsRequest**](UpdateNotificationsRequest)| body |  |

### Return type

[**UpdateNotificationsResponse**](UpdateNotificationsResponse)


## PostWorkforcemanagementSchedules

> [**UserScheduleContainer**](UserScheduleContainer) PostWorkforcemanagementSchedules (CurrentUserScheduleRequestBody body = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
| **body** | [**CurrentUserScheduleRequestBody**](CurrentUserScheduleRequestBody)| body | [optional]  |

### Return type

[**UserScheduleContainer**](UserScheduleContainer)


## PostWorkforcemanagementTeamAdherenceHistorical

> [**WfmHistoricalAdherenceResponse**](WfmHistoricalAdherenceResponse) PostWorkforcemanagementTeamAdherenceHistorical (string teamId, WfmHistoricalAdherenceQueryForTeams body)


Request a teams historical adherence report

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
    public class PostWorkforcemanagementTeamAdherenceHistoricalExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var teamId = teamId_example;  // string | The ID of the team
            var body = new WfmHistoricalAdherenceQueryForTeams(); // WfmHistoricalAdherenceQueryForTeams | body

            try
            { 
                // Request a teams historical adherence report
                WfmHistoricalAdherenceResponse result = apiInstance.PostWorkforcemanagementTeamAdherenceHistorical(teamId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementTeamAdherenceHistorical: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **teamId** | **string**| The ID of the team |  |
| **body** | [**WfmHistoricalAdherenceQueryForTeams**](WfmHistoricalAdherenceQueryForTeams)| body |  |

### Return type

[**WfmHistoricalAdherenceResponse**](WfmHistoricalAdherenceResponse)


## PostWorkforcemanagementTeamShrinkageJobs

> [**WfmHistoricalShrinkageResponse**](WfmHistoricalShrinkageResponse) PostWorkforcemanagementTeamShrinkageJobs (string teamId, WfmHistoricalShrinkageTeamsRequest body)


Request a historical shrinkage report

The maximum supported range for historical shrinkage queries is up to 32 days

Requires ANY permissions: 

* wfm:shrinkage:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWorkforcemanagementTeamShrinkageJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var teamId = teamId_example;  // string | The ID of the team
            var body = new WfmHistoricalShrinkageTeamsRequest(); // WfmHistoricalShrinkageTeamsRequest | body

            try
            { 
                // Request a historical shrinkage report
                WfmHistoricalShrinkageResponse result = apiInstance.PostWorkforcemanagementTeamShrinkageJobs(teamId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementTeamShrinkageJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **teamId** | **string**| The ID of the team |  |
| **body** | [**WfmHistoricalShrinkageTeamsRequest**](WfmHistoricalShrinkageTeamsRequest)| body |  |

### Return type

[**WfmHistoricalShrinkageResponse**](WfmHistoricalShrinkageResponse)


## PostWorkforcemanagementTimeoffbalanceJobs

> [**TimeOffBalancesResponse**](TimeOffBalancesResponse) PostWorkforcemanagementTimeoffbalanceJobs (TimeOffBalanceRequest body)


Query time off balances for the current user for specified activity code and dates

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
    public class PostWorkforcemanagementTimeoffbalanceJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var body = new TimeOffBalanceRequest(); // TimeOffBalanceRequest | The request body

            try
            { 
                // Query time off balances for the current user for specified activity code and dates
                TimeOffBalancesResponse result = apiInstance.PostWorkforcemanagementTimeoffbalanceJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementTimeoffbalanceJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TimeOffBalanceRequest**](TimeOffBalanceRequest)| The request body |  |

### Return type

[**TimeOffBalancesResponse**](TimeOffBalancesResponse)


## PostWorkforcemanagementTimeofflimitsAvailableQuery

> [**AvailableTimeOffResponse**](AvailableTimeOffResponse) PostWorkforcemanagementTimeofflimitsAvailableQuery (AvailableTimeOffRequest body)


Queries available time off for the current user

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
    public class PostWorkforcemanagementTimeofflimitsAvailableQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var body = new AvailableTimeOffRequest(); // AvailableTimeOffRequest | body

            try
            { 
                // Queries available time off for the current user
                AvailableTimeOffResponse result = apiInstance.PostWorkforcemanagementTimeofflimitsAvailableQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementTimeofflimitsAvailableQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AvailableTimeOffRequest**](AvailableTimeOffRequest)| body |  |

### Return type

[**AvailableTimeOffResponse**](AvailableTimeOffResponse)


## PostWorkforcemanagementTimeoffrequests

> [**TimeOffRequestResponse**](TimeOffRequestResponse) PostWorkforcemanagementTimeoffrequests (CreateAgentTimeOffRequest body)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var body = new CreateAgentTimeOffRequest(); // CreateAgentTimeOffRequest | body

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
| **body** | [**CreateAgentTimeOffRequest**](CreateAgentTimeOffRequest)| body |  |

### Return type

[**TimeOffRequestResponse**](TimeOffRequestResponse)


## PostWorkforcemanagementTimeoffrequestsEstimate

> [**EstimateAvailableTimeOffResponse**](EstimateAvailableTimeOffResponse) PostWorkforcemanagementTimeoffrequestsEstimate (EstimateAvailableTimeOffRequest body)


Estimates available time off for current user

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
    public class PostWorkforcemanagementTimeoffrequestsEstimateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var body = new EstimateAvailableTimeOffRequest(); // EstimateAvailableTimeOffRequest | body

            try
            { 
                // Estimates available time off for current user
                EstimateAvailableTimeOffResponse result = apiInstance.PostWorkforcemanagementTimeoffrequestsEstimate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementTimeoffrequestsEstimate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**EstimateAvailableTimeOffRequest**](EstimateAvailableTimeOffRequest)| body |  |

### Return type

[**EstimateAvailableTimeOffResponse**](EstimateAvailableTimeOffResponse)


## PostWorkforcemanagementTimeoffrequestsIntegrationstatusQuery

> [**TimeOffIntegrationStatusResponseListing**](TimeOffIntegrationStatusResponseListing) PostWorkforcemanagementTimeoffrequestsIntegrationstatusQuery (CurrentUserTimeOffIntegrationStatusRequest body)


Retrieves integration statuses for a list of current user time off requests

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
    public class PostWorkforcemanagementTimeoffrequestsIntegrationstatusQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var body = new CurrentUserTimeOffIntegrationStatusRequest(); // CurrentUserTimeOffIntegrationStatusRequest | body

            try
            { 
                // Retrieves integration statuses for a list of current user time off requests
                TimeOffIntegrationStatusResponseListing result = apiInstance.PostWorkforcemanagementTimeoffrequestsIntegrationstatusQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostWorkforcemanagementTimeoffrequestsIntegrationstatusQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CurrentUserTimeOffIntegrationStatusRequest**](CurrentUserTimeOffIntegrationStatusRequest)| body |  |

### Return type

[**TimeOffIntegrationStatusResponseListing**](TimeOffIntegrationStatusResponseListing)


## PutWorkforcemanagementAgentIntegrationsHris

> [**AgentIntegrationsResponse**](AgentIntegrationsResponse) PutWorkforcemanagementAgentIntegrationsHris (string agentId, AgentIntegrationsRequest body)


Update integrations for agent

Requires ANY permissions: 

* wfm:agent:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutWorkforcemanagementAgentIntegrationsHrisExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var agentId = agentId_example;  // string | The ID of the agent
            var body = new AgentIntegrationsRequest(); // AgentIntegrationsRequest | body

            try
            { 
                // Update integrations for agent
                AgentIntegrationsResponse result = apiInstance.PutWorkforcemanagementAgentIntegrationsHris(agentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PutWorkforcemanagementAgentIntegrationsHris: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **agentId** | **string**| The ID of the agent |  |
| **body** | [**AgentIntegrationsRequest**](AgentIntegrationsRequest)| body |  |

### Return type

[**AgentIntegrationsResponse**](AgentIntegrationsResponse)


## PutWorkforcemanagementBusinessunitTimeofflimitValues

> [**BuTimeOffLimitResponse**](BuTimeOffLimitResponse) PutWorkforcemanagementBusinessunitTimeofflimitValues (string businessUnitId, string timeOffLimitId, BuSetTimeOffLimitValuesRequest body)


Sets daily values for a date range of time-off limit object

Note that only limit daily values can be set through API, allocated and waitlisted values are read-only for time-off limit API

Requires ANY permissions: 

* wfm:timeOffLimit:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutWorkforcemanagementBusinessunitTimeofflimitValuesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var businessUnitId = businessUnitId_example;  // string | The ID of the business unit
            var timeOffLimitId = timeOffLimitId_example;  // string | The ID of the time-off limit object to set values for
            var body = new BuSetTimeOffLimitValuesRequest(); // BuSetTimeOffLimitValuesRequest | body

            try
            { 
                // Sets daily values for a date range of time-off limit object
                BuTimeOffLimitResponse result = apiInstance.PutWorkforcemanagementBusinessunitTimeofflimitValues(businessUnitId, timeOffLimitId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PutWorkforcemanagementBusinessunitTimeofflimitValues: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **businessUnitId** | **string**| The ID of the business unit |  |
| **timeOffLimitId** | **string**| The ID of the time-off limit object to set values for |  |
| **body** | [**BuSetTimeOffLimitValuesRequest**](BuSetTimeOffLimitValuesRequest)| body |  |

### Return type

[**BuTimeOffLimitResponse**](BuTimeOffLimitResponse)


## PutWorkforcemanagementManagementunitTimeofflimitValues

> [**TimeOffLimit**](TimeOffLimit) PutWorkforcemanagementManagementunitTimeofflimitValues (string managementUnitId, string timeOffLimitId, SetTimeOffLimitValuesRequest body)


Sets daily values for a date range of time off limit object

Note that only limit daily values can be set through API, allocated and waitlisted values are read-only for time off limit API

Requires ANY permissions: 

* wfm:timeOffLimit:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutWorkforcemanagementManagementunitTimeofflimitValuesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WorkforceManagementApi();
            var managementUnitId = managementUnitId_example;  // string | The ID of the management unit.
            var timeOffLimitId = timeOffLimitId_example;  // string | The ID of the time off limit object to set values for
            var body = new SetTimeOffLimitValuesRequest(); // SetTimeOffLimitValuesRequest | body

            try
            { 
                // Sets daily values for a date range of time off limit object
                TimeOffLimit result = apiInstance.PutWorkforcemanagementManagementunitTimeofflimitValues(managementUnitId, timeOffLimitId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PutWorkforcemanagementManagementunitTimeofflimitValues: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **managementUnitId** | **string**| The ID of the management unit. |  |
| **timeOffLimitId** | **string**| The ID of the time off limit object to set values for |  |
| **body** | [**SetTimeOffLimitValuesRequest**](SetTimeOffLimitValuesRequest)| body |  |

### Return type

[**TimeOffLimit**](TimeOffLimit)


_PureCloudPlatform.Client.V2 240.0.0_
