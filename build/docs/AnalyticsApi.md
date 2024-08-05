---
title: AnalyticsApi
---
## PureCloudPlatform.Client.V2.Api.AnalyticsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteAnalyticsConversationsDetailsJob**](AnalyticsApi.html#deleteanalyticsconversationsdetailsjob) | **Delete** /api/v2/analytics/conversations/details/jobs/{jobId} | Delete/cancel an async details job |
| [**DeleteAnalyticsUsersDetailsJob**](AnalyticsApi.html#deleteanalyticsusersdetailsjob) | **Delete** /api/v2/analytics/users/details/jobs/{jobId} | Delete/cancel an async request |
| [**GetAnalyticsActionsAggregatesJob**](AnalyticsApi.html#getanalyticsactionsaggregatesjob) | **Get** /api/v2/analytics/actions/aggregates/jobs/{jobId} | Get status for async query for action aggregates |
| [**GetAnalyticsActionsAggregatesJobResults**](AnalyticsApi.html#getanalyticsactionsaggregatesjobresults) | **Get** /api/v2/analytics/actions/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetAnalyticsAgentcopilotsAggregatesJob**](AnalyticsApi.html#getanalyticsagentcopilotsaggregatesjob) | **Get** /api/v2/analytics/agentcopilots/aggregates/jobs/{jobId} | Get status for async query for agent copilot aggregates |
| [**GetAnalyticsAgentcopilotsAggregatesJobResults**](AnalyticsApi.html#getanalyticsagentcopilotsaggregatesjobresults) | **Get** /api/v2/analytics/agentcopilots/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetAnalyticsBotflowDivisionsReportingturns**](AnalyticsApi.html#getanalyticsbotflowdivisionsreportingturns) | **Get** /api/v2/analytics/botflows/{botFlowId}/divisions/reportingturns | Get Reporting Turns (division aware). |
| [**GetAnalyticsBotflowReportingturns**](AnalyticsApi.html#getanalyticsbotflowreportingturns) | **Get** /api/v2/analytics/botflows/{botFlowId}/reportingturns | Get Reporting Turns. |
| [**GetAnalyticsBotflowSessions**](AnalyticsApi.html#getanalyticsbotflowsessions) | **Get** /api/v2/analytics/botflows/{botFlowId}/sessions | Get Bot Flow Sessions. |
| [**GetAnalyticsBotsAggregatesJob**](AnalyticsApi.html#getanalyticsbotsaggregatesjob) | **Get** /api/v2/analytics/bots/aggregates/jobs/{jobId} | Get status for async query for bot aggregates |
| [**GetAnalyticsBotsAggregatesJobResults**](AnalyticsApi.html#getanalyticsbotsaggregatesjobresults) | **Get** /api/v2/analytics/bots/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetAnalyticsConversationDetails**](AnalyticsApi.html#getanalyticsconversationdetails) | **Get** /api/v2/analytics/conversations/{conversationId}/details | Get a conversation by id |
| [**GetAnalyticsConversationsAggregatesJob**](AnalyticsApi.html#getanalyticsconversationsaggregatesjob) | **Get** /api/v2/analytics/conversations/aggregates/jobs/{jobId} | Get status for async query for conversation aggregates |
| [**GetAnalyticsConversationsAggregatesJobResults**](AnalyticsApi.html#getanalyticsconversationsaggregatesjobresults) | **Get** /api/v2/analytics/conversations/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetAnalyticsConversationsDetails**](AnalyticsApi.html#getanalyticsconversationsdetails) | **Get** /api/v2/analytics/conversations/details | Gets multiple conversations by id |
| [**GetAnalyticsConversationsDetailsJob**](AnalyticsApi.html#getanalyticsconversationsdetailsjob) | **Get** /api/v2/analytics/conversations/details/jobs/{jobId} | Get status for async query for conversation details |
| [**GetAnalyticsConversationsDetailsJobResults**](AnalyticsApi.html#getanalyticsconversationsdetailsjobresults) | **Get** /api/v2/analytics/conversations/details/jobs/{jobId}/results | Fetch a page of results for an async details job |
| [**GetAnalyticsConversationsDetailsJobsAvailability**](AnalyticsApi.html#getanalyticsconversationsdetailsjobsavailability) | **Get** /api/v2/analytics/conversations/details/jobs/availability | Lookup the datalake availability date and time |
| [**GetAnalyticsDataretentionSettings**](AnalyticsApi.html#getanalyticsdataretentionsettings) | **Get** /api/v2/analytics/dataretention/settings | Get analytics data retention setting |
| [**GetAnalyticsEvaluationsAggregatesJob**](AnalyticsApi.html#getanalyticsevaluationsaggregatesjob) | **Get** /api/v2/analytics/evaluations/aggregates/jobs/{jobId} | Get status for async query for evaluation aggregates |
| [**GetAnalyticsEvaluationsAggregatesJobResults**](AnalyticsApi.html#getanalyticsevaluationsaggregatesjobresults) | **Get** /api/v2/analytics/evaluations/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetAnalyticsFlowexecutionsAggregatesJob**](AnalyticsApi.html#getanalyticsflowexecutionsaggregatesjob) | **Get** /api/v2/analytics/flowexecutions/aggregates/jobs/{jobId} | Get status for async query for flow execution aggregates |
| [**GetAnalyticsFlowexecutionsAggregatesJobResults**](AnalyticsApi.html#getanalyticsflowexecutionsaggregatesjobresults) | **Get** /api/v2/analytics/flowexecutions/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetAnalyticsFlowsAggregatesJob**](AnalyticsApi.html#getanalyticsflowsaggregatesjob) | **Get** /api/v2/analytics/flows/aggregates/jobs/{jobId} | Get status for async query for Flow aggregates |
| [**GetAnalyticsFlowsAggregatesJobResults**](AnalyticsApi.html#getanalyticsflowsaggregatesjobresults) | **Get** /api/v2/analytics/flows/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetAnalyticsJourneysAggregatesJob**](AnalyticsApi.html#getanalyticsjourneysaggregatesjob) | **Get** /api/v2/analytics/journeys/aggregates/jobs/{jobId} | Get status for async query for journey aggregates |
| [**GetAnalyticsJourneysAggregatesJobResults**](AnalyticsApi.html#getanalyticsjourneysaggregatesjobresults) | **Get** /api/v2/analytics/journeys/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetAnalyticsKnowledgeAggregatesJob**](AnalyticsApi.html#getanalyticsknowledgeaggregatesjob) | **Get** /api/v2/analytics/knowledge/aggregates/jobs/{jobId} | Get status for async query for knowledge aggregates |
| [**GetAnalyticsKnowledgeAggregatesJobResults**](AnalyticsApi.html#getanalyticsknowledgeaggregatesjobresults) | **Get** /api/v2/analytics/knowledge/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetAnalyticsReportingDashboardsUser**](AnalyticsApi.html#getanalyticsreportingdashboardsuser) | **Get** /api/v2/analytics/reporting/dashboards/users/{userId} | Get dashboards summary for a user |
| [**GetAnalyticsReportingDashboardsUsers**](AnalyticsApi.html#getanalyticsreportingdashboardsusers) | **Get** /api/v2/analytics/reporting/dashboards/users | Get dashboards summary for users in a org |
| [**GetAnalyticsReportingExports**](AnalyticsApi.html#getanalyticsreportingexports) | **Get** /api/v2/analytics/reporting/exports | Get all view export requests for a user |
| [**GetAnalyticsReportingExportsMetadata**](AnalyticsApi.html#getanalyticsreportingexportsmetadata) | **Get** /api/v2/analytics/reporting/exports/metadata | Get all export metadata |
| [**GetAnalyticsReportingSettings**](AnalyticsApi.html#getanalyticsreportingsettings) | **Get** /api/v2/analytics/reporting/settings | Get AnalyticsReportingSettings for an organization |
| [**GetAnalyticsReportingSettingsDashboardsQuery**](AnalyticsApi.html#getanalyticsreportingsettingsdashboardsquery) | **Get** /api/v2/analytics/reporting/settings/dashboards/query | Get list of dashboard configurations |
| [**GetAnalyticsReportingSettingsUserDashboards**](AnalyticsApi.html#getanalyticsreportingsettingsuserdashboards) | **Get** /api/v2/analytics/reporting/settings/users/{userId}/dashboards | Get list of dashboards for an user |
| [**GetAnalyticsResolutionsAggregatesJob**](AnalyticsApi.html#getanalyticsresolutionsaggregatesjob) | **Get** /api/v2/analytics/resolutions/aggregates/jobs/{jobId} | Get status for async query for resolution aggregates |
| [**GetAnalyticsResolutionsAggregatesJobResults**](AnalyticsApi.html#getanalyticsresolutionsaggregatesjobresults) | **Get** /api/v2/analytics/resolutions/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetAnalyticsSurveysAggregatesJob**](AnalyticsApi.html#getanalyticssurveysaggregatesjob) | **Get** /api/v2/analytics/surveys/aggregates/jobs/{jobId} | Get status for async query for survey aggregates |
| [**GetAnalyticsSurveysAggregatesJobResults**](AnalyticsApi.html#getanalyticssurveysaggregatesjobresults) | **Get** /api/v2/analytics/surveys/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetAnalyticsTaskmanagementAggregatesJob**](AnalyticsApi.html#getanalyticstaskmanagementaggregatesjob) | **Get** /api/v2/analytics/taskmanagement/aggregates/jobs/{jobId} | Get status for async query for task management aggregates |
| [**GetAnalyticsTaskmanagementAggregatesJobResults**](AnalyticsApi.html#getanalyticstaskmanagementaggregatesjobresults) | **Get** /api/v2/analytics/taskmanagement/aggregates/jobs/{jobId}/results | Fetch a page of results for an async task management query |
| [**GetAnalyticsTranscriptsAggregatesJob**](AnalyticsApi.html#getanalyticstranscriptsaggregatesjob) | **Get** /api/v2/analytics/transcripts/aggregates/jobs/{jobId} | Get status for async query for transcript aggregates |
| [**GetAnalyticsTranscriptsAggregatesJobResults**](AnalyticsApi.html#getanalyticstranscriptsaggregatesjobresults) | **Get** /api/v2/analytics/transcripts/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetAnalyticsUsersAggregatesJob**](AnalyticsApi.html#getanalyticsusersaggregatesjob) | **Get** /api/v2/analytics/users/aggregates/jobs/{jobId} | Get status for async query for user aggregates |
| [**GetAnalyticsUsersAggregatesJobResults**](AnalyticsApi.html#getanalyticsusersaggregatesjobresults) | **Get** /api/v2/analytics/users/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetAnalyticsUsersDetailsJob**](AnalyticsApi.html#getanalyticsusersdetailsjob) | **Get** /api/v2/analytics/users/details/jobs/{jobId} | Get status for async query for user details |
| [**GetAnalyticsUsersDetailsJobResults**](AnalyticsApi.html#getanalyticsusersdetailsjobresults) | **Get** /api/v2/analytics/users/details/jobs/{jobId}/results | Fetch a page of results for an async query |
| [**GetAnalyticsUsersDetailsJobsAvailability**](AnalyticsApi.html#getanalyticsusersdetailsjobsavailability) | **Get** /api/v2/analytics/users/details/jobs/availability | Lookup the datalake availability date and time |
| [**PatchAnalyticsReportingSettings**](AnalyticsApi.html#patchanalyticsreportingsettings) | **Patch** /api/v2/analytics/reporting/settings | Patch AnalyticsReportingSettings values for an organization |
| [**PostAnalyticsActionsAggregatesJobs**](AnalyticsApi.html#postanalyticsactionsaggregatesjobs) | **Post** /api/v2/analytics/actions/aggregates/jobs | Query for action aggregates asynchronously |
| [**PostAnalyticsActionsAggregatesQuery**](AnalyticsApi.html#postanalyticsactionsaggregatesquery) | **Post** /api/v2/analytics/actions/aggregates/query | Query for action aggregates |
| [**PostAnalyticsAgentcopilotsAggregatesJobs**](AnalyticsApi.html#postanalyticsagentcopilotsaggregatesjobs) | **Post** /api/v2/analytics/agentcopilots/aggregates/jobs | Query for agent copilot aggregates asynchronously |
| [**PostAnalyticsAgentcopilotsAggregatesQuery**](AnalyticsApi.html#postanalyticsagentcopilotsaggregatesquery) | **Post** /api/v2/analytics/agentcopilots/aggregates/query | Query for agent copilot aggregates |
| [**PostAnalyticsBotsAggregatesJobs**](AnalyticsApi.html#postanalyticsbotsaggregatesjobs) | **Post** /api/v2/analytics/bots/aggregates/jobs | Query for bot aggregates asynchronously |
| [**PostAnalyticsBotsAggregatesQuery**](AnalyticsApi.html#postanalyticsbotsaggregatesquery) | **Post** /api/v2/analytics/bots/aggregates/query | Query for bot aggregates |
| [**PostAnalyticsConversationDetailsProperties**](AnalyticsApi.html#postanalyticsconversationdetailsproperties) | **Post** /api/v2/analytics/conversations/{conversationId}/details/properties | Index conversation properties |
| [**PostAnalyticsConversationsActivityQuery**](AnalyticsApi.html#postanalyticsconversationsactivityquery) | **Post** /api/v2/analytics/conversations/activity/query | Query for conversation activity observations |
| [**PostAnalyticsConversationsAggregatesJobs**](AnalyticsApi.html#postanalyticsconversationsaggregatesjobs) | **Post** /api/v2/analytics/conversations/aggregates/jobs | Query for conversation aggregates asynchronously |
| [**PostAnalyticsConversationsAggregatesQuery**](AnalyticsApi.html#postanalyticsconversationsaggregatesquery) | **Post** /api/v2/analytics/conversations/aggregates/query | Query for conversation aggregates |
| [**PostAnalyticsConversationsDetailsJobs**](AnalyticsApi.html#postanalyticsconversationsdetailsjobs) | **Post** /api/v2/analytics/conversations/details/jobs | Query for conversation details asynchronously |
| [**PostAnalyticsConversationsDetailsQuery**](AnalyticsApi.html#postanalyticsconversationsdetailsquery) | **Post** /api/v2/analytics/conversations/details/query | Query for conversation details |
| [**PostAnalyticsConversationsTranscriptsQuery**](AnalyticsApi.html#postanalyticsconversationstranscriptsquery) | **Post** /api/v2/analytics/conversations/transcripts/query | Search resources. |
| [**PostAnalyticsEvaluationsAggregatesJobs**](AnalyticsApi.html#postanalyticsevaluationsaggregatesjobs) | **Post** /api/v2/analytics/evaluations/aggregates/jobs | Query for evaluation aggregates asynchronously |
| [**PostAnalyticsEvaluationsAggregatesQuery**](AnalyticsApi.html#postanalyticsevaluationsaggregatesquery) | **Post** /api/v2/analytics/evaluations/aggregates/query | Query for evaluation aggregates |
| [**PostAnalyticsFlowexecutionsAggregatesJobs**](AnalyticsApi.html#postanalyticsflowexecutionsaggregatesjobs) | **Post** /api/v2/analytics/flowexecutions/aggregates/jobs | Query for flow execution aggregates asynchronously |
| [**PostAnalyticsFlowexecutionsAggregatesQuery**](AnalyticsApi.html#postanalyticsflowexecutionsaggregatesquery) | **Post** /api/v2/analytics/flowexecutions/aggregates/query | Query for flow execution aggregates |
| [**PostAnalyticsFlowsActivityQuery**](AnalyticsApi.html#postanalyticsflowsactivityquery) | **Post** /api/v2/analytics/flows/activity/query | Query for flow activity observations |
| [**PostAnalyticsFlowsAggregatesJobs**](AnalyticsApi.html#postanalyticsflowsaggregatesjobs) | **Post** /api/v2/analytics/flows/aggregates/jobs | Query for flow aggregates asynchronously |
| [**PostAnalyticsFlowsAggregatesQuery**](AnalyticsApi.html#postanalyticsflowsaggregatesquery) | **Post** /api/v2/analytics/flows/aggregates/query | Query for flow aggregates |
| [**PostAnalyticsFlowsObservationsQuery**](AnalyticsApi.html#postanalyticsflowsobservationsquery) | **Post** /api/v2/analytics/flows/observations/query | Query for flow observations |
| [**PostAnalyticsJourneysAggregatesJobs**](AnalyticsApi.html#postanalyticsjourneysaggregatesjobs) | **Post** /api/v2/analytics/journeys/aggregates/jobs | Query for journey aggregates asynchronously |
| [**PostAnalyticsJourneysAggregatesQuery**](AnalyticsApi.html#postanalyticsjourneysaggregatesquery) | **Post** /api/v2/analytics/journeys/aggregates/query | Query for journey aggregates |
| [**PostAnalyticsKnowledgeAggregatesJobs**](AnalyticsApi.html#postanalyticsknowledgeaggregatesjobs) | **Post** /api/v2/analytics/knowledge/aggregates/jobs | Query for knowledge aggregates asynchronously |
| [**PostAnalyticsKnowledgeAggregatesQuery**](AnalyticsApi.html#postanalyticsknowledgeaggregatesquery) | **Post** /api/v2/analytics/knowledge/aggregates/query | Query for knowledge aggregates |
| [**PostAnalyticsQueuesObservationsQuery**](AnalyticsApi.html#postanalyticsqueuesobservationsquery) | **Post** /api/v2/analytics/queues/observations/query | Query for queue observations |
| [**PostAnalyticsRatelimitsAggregatesQuery**](AnalyticsApi.html#postanalyticsratelimitsaggregatesquery) | **Post** /api/v2/analytics/ratelimits/aggregates/query | Query for limits rate limit aggregates. Data populated when limits reach 90% of the maximum. Not a source of truth for limits hit but a best effort estimate. |
| [**PostAnalyticsReportingDashboardsUsersBulkRemove**](AnalyticsApi.html#postanalyticsreportingdashboardsusersbulkremove) | **Post** /api/v2/analytics/reporting/dashboards/users/bulk/remove | Bulk delete dashboards owned by other user(s) |
| [**PostAnalyticsReportingExports**](AnalyticsApi.html#postanalyticsreportingexports) | **Post** /api/v2/analytics/reporting/exports | Generate a view export request |
| [**PostAnalyticsReportingSettingsDashboardsBulkRemove**](AnalyticsApi.html#postanalyticsreportingsettingsdashboardsbulkremove) | **Post** /api/v2/analytics/reporting/settings/dashboards/bulk/remove | Bulk remove dashboard configurations |
| [**PostAnalyticsReportingSettingsDashboardsQuery**](AnalyticsApi.html#postanalyticsreportingsettingsdashboardsquery) | **Post** /api/v2/analytics/reporting/settings/dashboards/query | Query dashboard configurations |
| [**PostAnalyticsResolutionsAggregatesJobs**](AnalyticsApi.html#postanalyticsresolutionsaggregatesjobs) | **Post** /api/v2/analytics/resolutions/aggregates/jobs | Query for resolution aggregates asynchronously |
| [**PostAnalyticsRoutingActivityQuery**](AnalyticsApi.html#postanalyticsroutingactivityquery) | **Post** /api/v2/analytics/routing/activity/query | Query for user activity observations |
| [**PostAnalyticsSurveysAggregatesJobs**](AnalyticsApi.html#postanalyticssurveysaggregatesjobs) | **Post** /api/v2/analytics/surveys/aggregates/jobs | Query for survey aggregates asynchronously |
| [**PostAnalyticsSurveysAggregatesQuery**](AnalyticsApi.html#postanalyticssurveysaggregatesquery) | **Post** /api/v2/analytics/surveys/aggregates/query | Query for survey aggregates |
| [**PostAnalyticsTaskmanagementAggregatesJobs**](AnalyticsApi.html#postanalyticstaskmanagementaggregatesjobs) | **Post** /api/v2/analytics/taskmanagement/aggregates/jobs | Query for task management aggregates asynchronously |
| [**PostAnalyticsTaskmanagementAggregatesQuery**](AnalyticsApi.html#postanalyticstaskmanagementaggregatesquery) | **Post** /api/v2/analytics/taskmanagement/aggregates/query | Query for task management aggregates |
| [**PostAnalyticsTeamsActivityQuery**](AnalyticsApi.html#postanalyticsteamsactivityquery) | **Post** /api/v2/analytics/teams/activity/query | Query for team activity observations |
| [**PostAnalyticsTranscriptsAggregatesJobs**](AnalyticsApi.html#postanalyticstranscriptsaggregatesjobs) | **Post** /api/v2/analytics/transcripts/aggregates/jobs | Query for transcript aggregates asynchronously |
| [**PostAnalyticsTranscriptsAggregatesQuery**](AnalyticsApi.html#postanalyticstranscriptsaggregatesquery) | **Post** /api/v2/analytics/transcripts/aggregates/query | Query for transcript aggregates |
| [**PostAnalyticsUsersActivityQuery**](AnalyticsApi.html#postanalyticsusersactivityquery) | **Post** /api/v2/analytics/users/activity/query | Query for user activity observations |
| [**PostAnalyticsUsersAggregatesJobs**](AnalyticsApi.html#postanalyticsusersaggregatesjobs) | **Post** /api/v2/analytics/users/aggregates/jobs | Query for user aggregates asynchronously |
| [**PostAnalyticsUsersAggregatesQuery**](AnalyticsApi.html#postanalyticsusersaggregatesquery) | **Post** /api/v2/analytics/users/aggregates/query | Query for user aggregates |
| [**PostAnalyticsUsersDetailsJobs**](AnalyticsApi.html#postanalyticsusersdetailsjobs) | **Post** /api/v2/analytics/users/details/jobs | Query for user details asynchronously |
| [**PostAnalyticsUsersDetailsQuery**](AnalyticsApi.html#postanalyticsusersdetailsquery) | **Post** /api/v2/analytics/users/details/query | Query for user details |
| [**PostAnalyticsUsersObservationsQuery**](AnalyticsApi.html#postanalyticsusersobservationsquery) | **Post** /api/v2/analytics/users/observations/query | Query for user observations |
| [**PutAnalyticsDataretentionSettings**](AnalyticsApi.html#putanalyticsdataretentionsettings) | **Put** /api/v2/analytics/dataretention/settings | Update analytics data retention setting |
{: class="table table-striped"}

<a name="deleteanalyticsconversationsdetailsjob"></a>

## void DeleteAnalyticsConversationsDetailsJob (string jobId)



Delete/cancel an async details job

Requires ANY permissions: 

* analytics:conversationDetail:view
* analytics:agentConversationDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteAnalyticsConversationsDetailsJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Delete/cancel an async details job
                apiInstance.DeleteAnalyticsConversationsDetailsJob(jobId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.DeleteAnalyticsConversationsDetailsJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteanalyticsusersdetailsjob"></a>

## void DeleteAnalyticsUsersDetailsJob (string jobId)



Delete/cancel an async request

Requires ANY permissions: 

* analytics:userDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteAnalyticsUsersDetailsJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Delete/cancel an async request
                apiInstance.DeleteAnalyticsUsersDetailsJob(jobId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.DeleteAnalyticsUsersDetailsJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getanalyticsactionsaggregatesjob"></a>

## [**AsyncQueryStatus**](AsyncQueryStatus.html) GetAnalyticsActionsAggregatesJob (string jobId)



Get status for async query for action aggregates

GetAnalyticsActionsAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* integrations:action:view
* bridge:actions:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsActionsAggregatesJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get status for async query for action aggregates
                AsyncQueryStatus result = apiInstance.GetAnalyticsActionsAggregatesJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsActionsAggregatesJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus.html)

<a name="getanalyticsactionsaggregatesjobresults"></a>

## [**ActionAsyncAggregateQueryResponse**](ActionAsyncAggregateQueryResponse.html) GetAnalyticsActionsAggregatesJobResults (string jobId, string cursor = null)



Fetch a page of results for an async aggregates query

GetAnalyticsActionsAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* integrations:action:view
* bridge:actions:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsActionsAggregatesJobResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId
            var cursor = cursor_example;  // string | Cursor token to retrieve next page (optional) 

            try
            { 
                // Fetch a page of results for an async aggregates query
                ActionAsyncAggregateQueryResponse result = apiInstance.GetAnalyticsActionsAggregatesJobResults(jobId, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsActionsAggregatesJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
| **cursor** | **string**| Cursor token to retrieve next page | [optional]  |
{: class="table table-striped"}

### Return type

[**ActionAsyncAggregateQueryResponse**](ActionAsyncAggregateQueryResponse.html)

<a name="getanalyticsagentcopilotsaggregatesjob"></a>

## [**AsyncQueryStatus**](AsyncQueryStatus.html) GetAnalyticsAgentcopilotsAggregatesJob (string jobId)



Get status for async query for agent copilot aggregates

GetAnalyticsAgentcopilotsAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:agentCopilotAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsAgentcopilotsAggregatesJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get status for async query for agent copilot aggregates
                AsyncQueryStatus result = apiInstance.GetAnalyticsAgentcopilotsAggregatesJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsAgentcopilotsAggregatesJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus.html)

<a name="getanalyticsagentcopilotsaggregatesjobresults"></a>

## [**AgentCopilotAsyncAggregateQueryResponse**](AgentCopilotAsyncAggregateQueryResponse.html) GetAnalyticsAgentcopilotsAggregatesJobResults (string jobId, string cursor = null)



Fetch a page of results for an async aggregates query

GetAnalyticsAgentcopilotsAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:agentCopilotAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsAgentcopilotsAggregatesJobResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId
            var cursor = cursor_example;  // string | Cursor token to retrieve next page (optional) 

            try
            { 
                // Fetch a page of results for an async aggregates query
                AgentCopilotAsyncAggregateQueryResponse result = apiInstance.GetAnalyticsAgentcopilotsAggregatesJobResults(jobId, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsAgentcopilotsAggregatesJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
| **cursor** | **string**| Cursor token to retrieve next page | [optional]  |
{: class="table table-striped"}

### Return type

[**AgentCopilotAsyncAggregateQueryResponse**](AgentCopilotAsyncAggregateQueryResponse.html)

<a name="getanalyticsbotflowdivisionsreportingturns"></a>

## [**ReportingTurnsResponse**](ReportingTurnsResponse.html) GetAnalyticsBotflowDivisionsReportingturns (string botFlowId, string after = null, string pageSize = null, string interval = null, string actionId = null, string sessionId = null, string language = null, string askActionResults = null)



Get Reporting Turns (division aware).

Returns the reporting turns for the specified flow, filtered by the clients divisions and grouped by session, in reverse chronological order from the date the session was created, with the reporting turns from the most recent session appearing at the start of the list. For pagination, clients should keep sending requests using the value of 'nextUri' in the response, until it's no longer present, only then have all items have been returned. Note: resources returned by this endpoint are not persisted indefinitely, as they are deleted after approximately, but not before, 10 days.

Requires ANY permissions: 

* analytics:botFlowDivisionAwareReportingTurn:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsBotflowDivisionsReportingturnsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var botFlowId = botFlowId_example;  // string | ID of the bot flow.
            var after = after_example;  // string | The cursor that points to the ID of the last item in the list of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Max number of entities to return. Maximum of 250 (optional)  (default to "50")
            var interval = 2023-07-17T08:15:44.586Z/2023-07-26T09:22:33.111Z;  // string | Date range filter based on the date the individual resources were completed. UTC is the default if no TZ is supplied, however alternate timezones can be used e.g: '2022-11-22T09:11:11.111+08:00/2022-11-30T07:17:44.586-07'. . Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional) 
            var actionId = actionId_example;  // string | Optional action ID to get the reporting turns associated to a particular flow action (optional) 
            var sessionId = sessionId_example;  // string | Optional session ID to get the reporting turns for a particular session. Specifying a session ID alongside an action ID or a language or any ask action results is not allowed. (optional) 
            var language = en-us;  // string | Optional language code to get the reporting turns for a particular language (optional) 
            var askActionResults = askActionResults_example;  // string | Optional case-insensitive comma separated list of ask action results to filter the reporting turns. (optional) 

            try
            { 
                // Get Reporting Turns (division aware).
                ReportingTurnsResponse result = apiInstance.GetAnalyticsBotflowDivisionsReportingturns(botFlowId, after, pageSize, interval, actionId, sessionId, language, askActionResults);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsBotflowDivisionsReportingturns: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **botFlowId** | **string**| ID of the bot flow. |  |
| **after** | **string**| The cursor that points to the ID of the last item in the list of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Max number of entities to return. Maximum of 250 | [optional] [default to "50"] |
| **interval** | **string**| Date range filter based on the date the individual resources were completed. UTC is the default if no TZ is supplied, however alternate timezones can be used e.g: &#39;2022-11-22T09:11:11.111+08:00/2022-11-30T07:17:44.586-07&#39;. . Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional]  |
| **actionId** | **string**| Optional action ID to get the reporting turns associated to a particular flow action | [optional]  |
| **sessionId** | **string**| Optional session ID to get the reporting turns for a particular session. Specifying a session ID alongside an action ID or a language or any ask action results is not allowed. | [optional]  |
| **language** | **string**| Optional language code to get the reporting turns for a particular language | [optional]  |
| **askActionResults** | **string**| Optional case-insensitive comma separated list of ask action results to filter the reporting turns. | [optional] <br />**Values**: AgentRequestedByUser, ConfirmationRequired, DisambiguationRequired, Error, ExpressionError, NoInputCollection, NoInputConfirmation, NoInputDisambiguation, NoMatchCollection, NoMatchConfirmation, NoMatchDisambiguation, SuccessCollection, SuccessConfirmationNo, SuccessConfirmationYes, SuccessDisambiguation, SuccessDisambiguationNone |
{: class="table table-striped"}

### Return type

[**ReportingTurnsResponse**](ReportingTurnsResponse.html)

<a name="getanalyticsbotflowreportingturns"></a>

## [**ReportingTurnsResponse**](ReportingTurnsResponse.html) GetAnalyticsBotflowReportingturns (string botFlowId, string after = null, string pageSize = null, string interval = null, string actionId = null, string sessionId = null, string language = null, string askActionResults = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get Reporting Turns.

Deprecated: Please use GET /analytics/botflows/{botFlowId}/divisions/reportingturns instead. Returns the reporting turns grouped by session, in reverse chronological order from the date the session was created, with the reporting turns from the most recent session appearing at the start of the list. For pagination, clients should keep sending requests using the value of 'nextUri' in the response, until it's no longer present, only then have all items have been returned. Note: resources returned by this endpoint are not persisted indefinitely, as they are deleted after approximately, but not before, 10 days.

Requires ANY permissions: 

* analytics:botFlowReportingTurn:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsBotflowReportingturnsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var botFlowId = botFlowId_example;  // string | ID of the bot flow.
            var after = after_example;  // string | The cursor that points to the ID of the last item in the list of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Max number of entities to return. Maximum of 250 (optional)  (default to "50")
            var interval = 2023-07-17T08:15:44.586Z/2023-07-26T09:22:33.111Z;  // string | Date range filter based on the date the individual resources were completed. UTC is the default if no TZ is supplied, however alternate timezones can be used e.g: '2022-11-22T09:11:11.111+08:00/2022-11-30T07:17:44.586-07'. . Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional) 
            var actionId = actionId_example;  // string | Optional action ID to get the reporting turns associated to a particular flow action (optional) 
            var sessionId = sessionId_example;  // string | Optional session ID to get the reporting turns for a particular session. Specifying a session ID alongside an action ID or a language or any ask action results is not allowed. (optional) 
            var language = en-us;  // string | Optional language code to get the reporting turns for a particular language (optional) 
            var askActionResults = askActionResults_example;  // string | Optional case-insensitive comma separated list of ask action results to filter the reporting turns. (optional) 

            try
            { 
                // Get Reporting Turns.
                ReportingTurnsResponse result = apiInstance.GetAnalyticsBotflowReportingturns(botFlowId, after, pageSize, interval, actionId, sessionId, language, askActionResults);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsBotflowReportingturns: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **botFlowId** | **string**| ID of the bot flow. |  |
| **after** | **string**| The cursor that points to the ID of the last item in the list of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Max number of entities to return. Maximum of 250 | [optional] [default to "50"] |
| **interval** | **string**| Date range filter based on the date the individual resources were completed. UTC is the default if no TZ is supplied, however alternate timezones can be used e.g: &#39;2022-11-22T09:11:11.111+08:00/2022-11-30T07:17:44.586-07&#39;. . Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional]  |
| **actionId** | **string**| Optional action ID to get the reporting turns associated to a particular flow action | [optional]  |
| **sessionId** | **string**| Optional session ID to get the reporting turns for a particular session. Specifying a session ID alongside an action ID or a language or any ask action results is not allowed. | [optional]  |
| **language** | **string**| Optional language code to get the reporting turns for a particular language | [optional]  |
| **askActionResults** | **string**| Optional case-insensitive comma separated list of ask action results to filter the reporting turns. | [optional] <br />**Values**: AgentRequestedByUser, ConfirmationRequired, DisambiguationRequired, Error, ExpressionError, NoInputCollection, NoInputConfirmation, NoInputDisambiguation, NoMatchCollection, NoMatchConfirmation, NoMatchDisambiguation, SuccessCollection, SuccessConfirmationNo, SuccessConfirmationYes, SuccessDisambiguation, SuccessDisambiguationNone |
{: class="table table-striped"}

### Return type

[**ReportingTurnsResponse**](ReportingTurnsResponse.html)

<a name="getanalyticsbotflowsessions"></a>

## [**SessionsResponse**](SessionsResponse.html) GetAnalyticsBotflowSessions (string botFlowId, string after = null, string pageSize = null, string interval = null, string botResultCategories = null, string endLanguage = null)



Get Bot Flow Sessions.

Returns the bot flow sessions in reverse chronological order from the date they were created. For pagination, clients should keep sending requests using the value of 'nextUri' in the response, until it's no longer present, only then have all items have been returned. Note: resources returned by this endpoint are not persisted indefinitely, as they are deleted after approximately, but not before, 10 days.

Requires ANY permissions: 

* analytics:botFlowSession:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsBotflowSessionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var botFlowId = botFlowId_example;  // string | ID of the bot flow.
            var after = after_example;  // string | The cursor that points to the ID of the last item in the list of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Max number of entities to return. Maximum of 250 (optional)  (default to "50")
            var interval = 2023-07-17T08:15:44.586Z/2023-07-26T09:22:33.111Z;  // string | Date range filter based on the date the individual resources were completed. UTC is the default if no TZ is supplied, however alternate timezones can be used e.g: '2022-11-22T09:11:11.111+08:00/2022-11-30T07:17:44.586-07'. . Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional) 
            var botResultCategories = botResultCategories_example;  // string | Optional case-insensitive comma separated list of Bot Result Categories to filter sessions by. (optional) 
            var endLanguage = endLanguage_example;  // string | Optional case-insensitive language code to filter sessions by the language the sessions ended in. (optional) 

            try
            { 
                // Get Bot Flow Sessions.
                SessionsResponse result = apiInstance.GetAnalyticsBotflowSessions(botFlowId, after, pageSize, interval, botResultCategories, endLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsBotflowSessions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **botFlowId** | **string**| ID of the bot flow. |  |
| **after** | **string**| The cursor that points to the ID of the last item in the list of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Max number of entities to return. Maximum of 250 | [optional] [default to "50"] |
| **interval** | **string**| Date range filter based on the date the individual resources were completed. UTC is the default if no TZ is supplied, however alternate timezones can be used e.g: &#39;2022-11-22T09:11:11.111+08:00/2022-11-30T07:17:44.586-07&#39;. . Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional]  |
| **botResultCategories** | **string**| Optional case-insensitive comma separated list of Bot Result Categories to filter sessions by. | [optional] <br />**Values**: Unknown, UserExit, BotExit, Error, RecognitionFailure, UserDisconnect, BotDisconnect, SessionExpired, Transfer |
| **endLanguage** | **string**| Optional case-insensitive language code to filter sessions by the language the sessions ended in. | [optional]  |
{: class="table table-striped"}

### Return type

[**SessionsResponse**](SessionsResponse.html)

<a name="getanalyticsbotsaggregatesjob"></a>

## [**AsyncQueryStatus**](AsyncQueryStatus.html) GetAnalyticsBotsAggregatesJob (string jobId)



Get status for async query for bot aggregates

GetAnalyticsBotsAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:botAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsBotsAggregatesJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get status for async query for bot aggregates
                AsyncQueryStatus result = apiInstance.GetAnalyticsBotsAggregatesJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsBotsAggregatesJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus.html)

<a name="getanalyticsbotsaggregatesjobresults"></a>

## [**BotAsyncAggregateQueryResponse**](BotAsyncAggregateQueryResponse.html) GetAnalyticsBotsAggregatesJobResults (string jobId, string cursor = null)



Fetch a page of results for an async aggregates query

GetAnalyticsBotsAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:botAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsBotsAggregatesJobResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId
            var cursor = cursor_example;  // string | Cursor token to retrieve next page (optional) 

            try
            { 
                // Fetch a page of results for an async aggregates query
                BotAsyncAggregateQueryResponse result = apiInstance.GetAnalyticsBotsAggregatesJobResults(jobId, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsBotsAggregatesJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
| **cursor** | **string**| Cursor token to retrieve next page | [optional]  |
{: class="table table-striped"}

### Return type

[**BotAsyncAggregateQueryResponse**](BotAsyncAggregateQueryResponse.html)

<a name="getanalyticsconversationdetails"></a>

## [**AnalyticsConversationWithoutAttributes**](AnalyticsConversationWithoutAttributes.html) GetAnalyticsConversationDetails (string conversationId)



Get a conversation by id

Requires ANY permissions: 

* analytics:conversationDetail:view
* analytics:agentConversationDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsConversationDetailsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            { 
                // Get a conversation by id
                AnalyticsConversationWithoutAttributes result = apiInstance.GetAnalyticsConversationDetails(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsConversationDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
{: class="table table-striped"}

### Return type

[**AnalyticsConversationWithoutAttributes**](AnalyticsConversationWithoutAttributes.html)

<a name="getanalyticsconversationsaggregatesjob"></a>

## [**AsyncQueryStatus**](AsyncQueryStatus.html) GetAnalyticsConversationsAggregatesJob (string jobId)



Get status for async query for conversation aggregates

GetAnalyticsConversationsAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:conversationAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsConversationsAggregatesJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get status for async query for conversation aggregates
                AsyncQueryStatus result = apiInstance.GetAnalyticsConversationsAggregatesJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsConversationsAggregatesJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus.html)

<a name="getanalyticsconversationsaggregatesjobresults"></a>

## [**ConversationAsyncAggregateQueryResponse**](ConversationAsyncAggregateQueryResponse.html) GetAnalyticsConversationsAggregatesJobResults (string jobId, string cursor = null)



Fetch a page of results for an async aggregates query

GetAnalyticsConversationsAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:conversationAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsConversationsAggregatesJobResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId
            var cursor = cursor_example;  // string | Cursor token to retrieve next page (optional) 

            try
            { 
                // Fetch a page of results for an async aggregates query
                ConversationAsyncAggregateQueryResponse result = apiInstance.GetAnalyticsConversationsAggregatesJobResults(jobId, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsConversationsAggregatesJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
| **cursor** | **string**| Cursor token to retrieve next page | [optional]  |
{: class="table table-striped"}

### Return type

[**ConversationAsyncAggregateQueryResponse**](ConversationAsyncAggregateQueryResponse.html)

<a name="getanalyticsconversationsdetails"></a>

## [**AnalyticsConversationWithoutAttributesMultiGetResponse**](AnalyticsConversationWithoutAttributesMultiGetResponse.html) GetAnalyticsConversationsDetails (List<string> id = null)



Gets multiple conversations by id

Requires ANY permissions: 

* analytics:conversationDetail:view
* analytics:agentConversationDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsConversationsDetailsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var id = new List<string>(); // List<string> | Comma-separated conversation ids (optional) 

            try
            { 
                // Gets multiple conversations by id
                AnalyticsConversationWithoutAttributesMultiGetResponse result = apiInstance.GetAnalyticsConversationsDetails(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsConversationsDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | [**List<string>**](string.html)| Comma-separated conversation ids | [optional]  |
{: class="table table-striped"}

### Return type

[**AnalyticsConversationWithoutAttributesMultiGetResponse**](AnalyticsConversationWithoutAttributesMultiGetResponse.html)

<a name="getanalyticsconversationsdetailsjob"></a>

## [**AsyncQueryStatus**](AsyncQueryStatus.html) GetAnalyticsConversationsDetailsJob (string jobId)



Get status for async query for conversation details

Requires ANY permissions: 

* analytics:conversationDetail:view
* analytics:agentConversationDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsConversationsDetailsJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get status for async query for conversation details
                AsyncQueryStatus result = apiInstance.GetAnalyticsConversationsDetailsJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsConversationsDetailsJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus.html)

<a name="getanalyticsconversationsdetailsjobresults"></a>

## [**AnalyticsConversationAsyncQueryResponse**](AnalyticsConversationAsyncQueryResponse.html) GetAnalyticsConversationsDetailsJobResults (string jobId, string cursor = null, int? pageSize = null)



Fetch a page of results for an async details job

Requires ANY permissions: 

* analytics:conversationDetail:view
* analytics:agentConversationDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsConversationsDetailsJobResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId
            var cursor = cursor_example;  // string | Indicates where to resume query results (not required for first page) (optional) 
            var pageSize = 56;  // int? | The desired maximum number of results (optional) 

            try
            { 
                // Fetch a page of results for an async details job
                AnalyticsConversationAsyncQueryResponse result = apiInstance.GetAnalyticsConversationsDetailsJobResults(jobId, cursor, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsConversationsDetailsJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
| **cursor** | **string**| Indicates where to resume query results (not required for first page) | [optional]  |
| **pageSize** | **int?**| The desired maximum number of results | [optional]  |
{: class="table table-striped"}

### Return type

[**AnalyticsConversationAsyncQueryResponse**](AnalyticsConversationAsyncQueryResponse.html)

<a name="getanalyticsconversationsdetailsjobsavailability"></a>

## [**DataAvailabilityResponse**](DataAvailabilityResponse.html) GetAnalyticsConversationsDetailsJobsAvailability ()



Lookup the datalake availability date and time

Requires ANY permissions: 

* analytics:conversationDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsConversationsDetailsJobsAvailabilityExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();

            try
            { 
                // Lookup the datalake availability date and time
                DataAvailabilityResponse result = apiInstance.GetAnalyticsConversationsDetailsJobsAvailability();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsConversationsDetailsJobsAvailability: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**DataAvailabilityResponse**](DataAvailabilityResponse.html)

<a name="getanalyticsdataretentionsettings"></a>

## [**AnalyticsDataRetentionResponse**](AnalyticsDataRetentionResponse.html) GetAnalyticsDataretentionSettings ()



Get analytics data retention setting

Requires ANY permissions: 

* analytics:dataRetention:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsDataretentionSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();

            try
            { 
                // Get analytics data retention setting
                AnalyticsDataRetentionResponse result = apiInstance.GetAnalyticsDataretentionSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsDataretentionSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**AnalyticsDataRetentionResponse**](AnalyticsDataRetentionResponse.html)

<a name="getanalyticsevaluationsaggregatesjob"></a>

## [**AsyncQueryStatus**](AsyncQueryStatus.html) GetAnalyticsEvaluationsAggregatesJob (string jobId)



Get status for async query for evaluation aggregates

GetAnalyticsEvaluationsAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:evaluationAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsEvaluationsAggregatesJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get status for async query for evaluation aggregates
                AsyncQueryStatus result = apiInstance.GetAnalyticsEvaluationsAggregatesJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsEvaluationsAggregatesJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus.html)

<a name="getanalyticsevaluationsaggregatesjobresults"></a>

## [**EvaluationAsyncAggregateQueryResponse**](EvaluationAsyncAggregateQueryResponse.html) GetAnalyticsEvaluationsAggregatesJobResults (string jobId, string cursor = null)



Fetch a page of results for an async aggregates query

GetAnalyticsEvaluationsAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:evaluationAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsEvaluationsAggregatesJobResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId
            var cursor = cursor_example;  // string | Cursor token to retrieve next page (optional) 

            try
            { 
                // Fetch a page of results for an async aggregates query
                EvaluationAsyncAggregateQueryResponse result = apiInstance.GetAnalyticsEvaluationsAggregatesJobResults(jobId, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsEvaluationsAggregatesJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
| **cursor** | **string**| Cursor token to retrieve next page | [optional]  |
{: class="table table-striped"}

### Return type

[**EvaluationAsyncAggregateQueryResponse**](EvaluationAsyncAggregateQueryResponse.html)

<a name="getanalyticsflowexecutionsaggregatesjob"></a>

## [**AsyncQueryStatus**](AsyncQueryStatus.html) GetAnalyticsFlowexecutionsAggregatesJob (string jobId)



Get status for async query for flow execution aggregates

GetAnalyticsFlowexecutionsAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:flowExecutionAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsFlowexecutionsAggregatesJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get status for async query for flow execution aggregates
                AsyncQueryStatus result = apiInstance.GetAnalyticsFlowexecutionsAggregatesJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsFlowexecutionsAggregatesJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus.html)

<a name="getanalyticsflowexecutionsaggregatesjobresults"></a>

## [**FlowExecutionAsyncAggregateQueryResponse**](FlowExecutionAsyncAggregateQueryResponse.html) GetAnalyticsFlowexecutionsAggregatesJobResults (string jobId, string cursor = null)



Fetch a page of results for an async aggregates query

GetAnalyticsFlowexecutionsAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:flowExecutionAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsFlowexecutionsAggregatesJobResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId
            var cursor = cursor_example;  // string | Cursor token to retrieve next page (optional) 

            try
            { 
                // Fetch a page of results for an async aggregates query
                FlowExecutionAsyncAggregateQueryResponse result = apiInstance.GetAnalyticsFlowexecutionsAggregatesJobResults(jobId, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsFlowexecutionsAggregatesJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
| **cursor** | **string**| Cursor token to retrieve next page | [optional]  |
{: class="table table-striped"}

### Return type

[**FlowExecutionAsyncAggregateQueryResponse**](FlowExecutionAsyncAggregateQueryResponse.html)

<a name="getanalyticsflowsaggregatesjob"></a>

## [**AsyncQueryStatus**](AsyncQueryStatus.html) GetAnalyticsFlowsAggregatesJob (string jobId)



Get status for async query for Flow aggregates

GetAnalyticsFlowsAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:flowAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsFlowsAggregatesJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get status for async query for Flow aggregates
                AsyncQueryStatus result = apiInstance.GetAnalyticsFlowsAggregatesJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsFlowsAggregatesJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus.html)

<a name="getanalyticsflowsaggregatesjobresults"></a>

## [**FlowAsyncAggregateQueryResponse**](FlowAsyncAggregateQueryResponse.html) GetAnalyticsFlowsAggregatesJobResults (string jobId, string cursor = null)



Fetch a page of results for an async aggregates query

GetAnalyticsFlowsAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:flowAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsFlowsAggregatesJobResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId
            var cursor = cursor_example;  // string | Cursor token to retrieve next page (optional) 

            try
            { 
                // Fetch a page of results for an async aggregates query
                FlowAsyncAggregateQueryResponse result = apiInstance.GetAnalyticsFlowsAggregatesJobResults(jobId, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsFlowsAggregatesJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
| **cursor** | **string**| Cursor token to retrieve next page | [optional]  |
{: class="table table-striped"}

### Return type

[**FlowAsyncAggregateQueryResponse**](FlowAsyncAggregateQueryResponse.html)

<a name="getanalyticsjourneysaggregatesjob"></a>

## [**AsyncQueryStatus**](AsyncQueryStatus.html) GetAnalyticsJourneysAggregatesJob (string jobId)



Get status for async query for journey aggregates

GetAnalyticsJourneysAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:journeyAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsJourneysAggregatesJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get status for async query for journey aggregates
                AsyncQueryStatus result = apiInstance.GetAnalyticsJourneysAggregatesJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsJourneysAggregatesJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus.html)

<a name="getanalyticsjourneysaggregatesjobresults"></a>

## [**JourneyAsyncAggregateQueryResponse**](JourneyAsyncAggregateQueryResponse.html) GetAnalyticsJourneysAggregatesJobResults (string jobId, string cursor = null)



Fetch a page of results for an async aggregates query

GetAnalyticsJourneysAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:journeyAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsJourneysAggregatesJobResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId
            var cursor = cursor_example;  // string | Cursor token to retrieve next page (optional) 

            try
            { 
                // Fetch a page of results for an async aggregates query
                JourneyAsyncAggregateQueryResponse result = apiInstance.GetAnalyticsJourneysAggregatesJobResults(jobId, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsJourneysAggregatesJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
| **cursor** | **string**| Cursor token to retrieve next page | [optional]  |
{: class="table table-striped"}

### Return type

[**JourneyAsyncAggregateQueryResponse**](JourneyAsyncAggregateQueryResponse.html)

<a name="getanalyticsknowledgeaggregatesjob"></a>

## [**AsyncQueryStatus**](AsyncQueryStatus.html) GetAnalyticsKnowledgeAggregatesJob (string jobId)



Get status for async query for knowledge aggregates

GetAnalyticsKnowledgeAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:knowledgeAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsKnowledgeAggregatesJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get status for async query for knowledge aggregates
                AsyncQueryStatus result = apiInstance.GetAnalyticsKnowledgeAggregatesJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsKnowledgeAggregatesJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus.html)

<a name="getanalyticsknowledgeaggregatesjobresults"></a>

## [**KnowledgeAsyncAggregateQueryResponse**](KnowledgeAsyncAggregateQueryResponse.html) GetAnalyticsKnowledgeAggregatesJobResults (string jobId, string cursor = null)



Fetch a page of results for an async aggregates query

GetAnalyticsKnowledgeAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:knowledgeAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsKnowledgeAggregatesJobResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId
            var cursor = cursor_example;  // string | Cursor token to retrieve next page (optional) 

            try
            { 
                // Fetch a page of results for an async aggregates query
                KnowledgeAsyncAggregateQueryResponse result = apiInstance.GetAnalyticsKnowledgeAggregatesJobResults(jobId, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsKnowledgeAggregatesJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
| **cursor** | **string**| Cursor token to retrieve next page | [optional]  |
{: class="table table-striped"}

### Return type

[**KnowledgeAsyncAggregateQueryResponse**](KnowledgeAsyncAggregateQueryResponse.html)

<a name="getanalyticsreportingdashboardsuser"></a>

## [**DashboardUser**](DashboardUser.html) GetAnalyticsReportingDashboardsUser (string userId)



Get dashboards summary for a user

Requires ALL permissions: 

* analytics:dashboardConfigurations:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsReportingDashboardsUserExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var userId = userId_example;  // string | User ID

            try
            { 
                // Get dashboards summary for a user
                DashboardUser result = apiInstance.GetAnalyticsReportingDashboardsUser(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsReportingDashboardsUser: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
{: class="table table-striped"}

### Return type

[**DashboardUser**](DashboardUser.html)

<a name="getanalyticsreportingdashboardsusers"></a>

## [**DashboardUserListing**](DashboardUserListing.html) GetAnalyticsReportingDashboardsUsers (string sortBy = null, int? pageNumber = null, int? pageSize = null, List<string> id = null, string state = null)



Get dashboards summary for users in a org

Requires ALL permissions: 

* analytics:dashboardConfigurations:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsReportingDashboardsUsersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var sortBy = sortBy_example;  // string |  (optional)  (default to "asc")
            var pageNumber = 56;  // int? |  (optional)  (default to 1)
            var pageSize = 56;  // int? |  (optional)  (default to 25)
            var id = new List<string>(); // List<string> | A list of user IDs to fetch by bulk (optional) 
            var state = state_example;  // string | Only list users of this state (optional) 

            try
            { 
                // Get dashboards summary for users in a org
                DashboardUserListing result = apiInstance.GetAnalyticsReportingDashboardsUsers(sortBy, pageNumber, pageSize, id, state);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsReportingDashboardsUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sortBy** | **string**|  | [optional] [default to "asc"] |
| **pageNumber** | **int?**|  | [optional] [default to 1] |
| **pageSize** | **int?**|  | [optional] [default to 25] |
| **id** | [**List<string>**](string.html)| A list of user IDs to fetch by bulk | [optional]  |
| **state** | **string**| Only list users of this state | [optional] <br />**Values**: active, inactive |
{: class="table table-striped"}

### Return type

[**DashboardUserListing**](DashboardUserListing.html)

<a name="getanalyticsreportingexports"></a>

## [**ReportingExportJobListing**](ReportingExportJobListing.html) GetAnalyticsReportingExports (int? pageNumber = null, int? pageSize = null)



Get all view export requests for a user

Requires ALL permissions: 

* analytics:dataExport:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsReportingExportsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            { 
                // Get all view export requests for a user
                ReportingExportJobListing result = apiInstance.GetAnalyticsReportingExports(pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsReportingExports: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
{: class="table table-striped"}

### Return type

[**ReportingExportJobListing**](ReportingExportJobListing.html)

<a name="getanalyticsreportingexportsmetadata"></a>

## [**ReportingExportMetadataJobListing**](ReportingExportMetadataJobListing.html) GetAnalyticsReportingExportsMetadata ()



Get all export metadata

Requires ALL permissions: 

* analytics:dataExport:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsReportingExportsMetadataExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();

            try
            { 
                // Get all export metadata
                ReportingExportMetadataJobListing result = apiInstance.GetAnalyticsReportingExportsMetadata();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsReportingExportsMetadata: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**ReportingExportMetadataJobListing**](ReportingExportMetadataJobListing.html)

<a name="getanalyticsreportingsettings"></a>

## [**AnalyticsReportingSettings**](AnalyticsReportingSettings.html) GetAnalyticsReportingSettings ()



Get AnalyticsReportingSettings for an organization

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
    public class GetAnalyticsReportingSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();

            try
            { 
                // Get AnalyticsReportingSettings for an organization
                AnalyticsReportingSettings result = apiInstance.GetAnalyticsReportingSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsReportingSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**AnalyticsReportingSettings**](AnalyticsReportingSettings.html)

<a name="getanalyticsreportingsettingsdashboardsquery"></a>

## [**DashboardConfigurationListing**](DashboardConfigurationListing.html) GetAnalyticsReportingSettingsDashboardsQuery (string dashboardType, string dashboardAccessFilter, string sortBy = null, int? pageNumber = null, int? pageSize = null)



Get list of dashboard configurations

Requires ALL permissions: 

* analytics:dashboardConfigurations:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsReportingSettingsDashboardsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var dashboardType = dashboardType_example;  // string | List dashboard of given type
            var dashboardAccessFilter = dashboardAccessFilter_example;  // string | Filter dashboard based on the owner of dashboard
            var sortBy = sortBy_example;  // string |  (optional)  (default to "desc")
            var pageNumber = 56;  // int? |  (optional)  (default to 1)
            var pageSize = 56;  // int? |  (optional)  (default to 9)

            try
            { 
                // Get list of dashboard configurations
                DashboardConfigurationListing result = apiInstance.GetAnalyticsReportingSettingsDashboardsQuery(dashboardType, dashboardAccessFilter, sortBy, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsReportingSettingsDashboardsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dashboardType** | **string**| List dashboard of given type | <br />**Values**: All, Public, Private, Shared, Favorites |
| **dashboardAccessFilter** | **string**| Filter dashboard based on the owner of dashboard | <br />**Values**: OwnedByMe, OwnedByAnyone, NotOwnedByMe |
| **sortBy** | **string**|  | [optional] [default to "desc"] |
| **pageNumber** | **int?**|  | [optional] [default to 1] |
| **pageSize** | **int?**|  | [optional] [default to 9] |
{: class="table table-striped"}

### Return type

[**DashboardConfigurationListing**](DashboardConfigurationListing.html)

<a name="getanalyticsreportingsettingsuserdashboards"></a>

## [**DashboardConfigurationListing**](DashboardConfigurationListing.html) GetAnalyticsReportingSettingsUserDashboards (string userId, string sortBy = null, int? pageNumber = null, int? pageSize = null, bool? publicOnly = null, bool? favoriteOnly = null, string name = null)



Get list of dashboards for an user

Requires ALL permissions: 

* analytics:dashboardConfigurations:viewPrivate

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsReportingSettingsUserDashboardsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var userId = userId_example;  // string | User ID
            var sortBy = sortBy_example;  // string |  (optional)  (default to "asc")
            var pageNumber = 56;  // int? |  (optional)  (default to 1)
            var pageSize = 56;  // int? |  (optional)  (default to 50)
            var publicOnly = true;  // bool? | If true, retrieve only public dashboards (optional) 
            var favoriteOnly = true;  // bool? | If true, retrieve only favorite dashboards (optional) 
            var name = name_example;  // string | retrieve dashboards that match with given name (optional) 

            try
            { 
                // Get list of dashboards for an user
                DashboardConfigurationListing result = apiInstance.GetAnalyticsReportingSettingsUserDashboards(userId, sortBy, pageNumber, pageSize, publicOnly, favoriteOnly, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsReportingSettingsUserDashboards: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **sortBy** | **string**|  | [optional] [default to "asc"] |
| **pageNumber** | **int?**|  | [optional] [default to 1] |
| **pageSize** | **int?**|  | [optional] [default to 50] |
| **publicOnly** | **bool?**| If true, retrieve only public dashboards | [optional]  |
| **favoriteOnly** | **bool?**| If true, retrieve only favorite dashboards | [optional]  |
| **name** | **string**| retrieve dashboards that match with given name | [optional]  |
{: class="table table-striped"}

### Return type

[**DashboardConfigurationListing**](DashboardConfigurationListing.html)

<a name="getanalyticsresolutionsaggregatesjob"></a>

## [**AsyncQueryStatus**](AsyncQueryStatus.html) GetAnalyticsResolutionsAggregatesJob (string jobId)



Get status for async query for resolution aggregates

GetAnalyticsResolutionsAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:resolutionAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsResolutionsAggregatesJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get status for async query for resolution aggregates
                AsyncQueryStatus result = apiInstance.GetAnalyticsResolutionsAggregatesJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsResolutionsAggregatesJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus.html)

<a name="getanalyticsresolutionsaggregatesjobresults"></a>

## [**ResolutionAsyncAggregateQueryResponse**](ResolutionAsyncAggregateQueryResponse.html) GetAnalyticsResolutionsAggregatesJobResults (string jobId, string cursor = null)



Fetch a page of results for an async aggregates query

GetAnalyticsResolutionsAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:resolutionAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsResolutionsAggregatesJobResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId
            var cursor = cursor_example;  // string | Cursor token to retrieve next page (optional) 

            try
            { 
                // Fetch a page of results for an async aggregates query
                ResolutionAsyncAggregateQueryResponse result = apiInstance.GetAnalyticsResolutionsAggregatesJobResults(jobId, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsResolutionsAggregatesJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
| **cursor** | **string**| Cursor token to retrieve next page | [optional]  |
{: class="table table-striped"}

### Return type

[**ResolutionAsyncAggregateQueryResponse**](ResolutionAsyncAggregateQueryResponse.html)

<a name="getanalyticssurveysaggregatesjob"></a>

## [**AsyncQueryStatus**](AsyncQueryStatus.html) GetAnalyticsSurveysAggregatesJob (string jobId)



Get status for async query for survey aggregates

GetAnalyticsSurveysAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:surveyAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsSurveysAggregatesJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get status for async query for survey aggregates
                AsyncQueryStatus result = apiInstance.GetAnalyticsSurveysAggregatesJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsSurveysAggregatesJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus.html)

<a name="getanalyticssurveysaggregatesjobresults"></a>

## [**SurveyAsyncAggregateQueryResponse**](SurveyAsyncAggregateQueryResponse.html) GetAnalyticsSurveysAggregatesJobResults (string jobId, string cursor = null)



Fetch a page of results for an async aggregates query

GetAnalyticsSurveysAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:surveyAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsSurveysAggregatesJobResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId
            var cursor = cursor_example;  // string | Cursor token to retrieve next page (optional) 

            try
            { 
                // Fetch a page of results for an async aggregates query
                SurveyAsyncAggregateQueryResponse result = apiInstance.GetAnalyticsSurveysAggregatesJobResults(jobId, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsSurveysAggregatesJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
| **cursor** | **string**| Cursor token to retrieve next page | [optional]  |
{: class="table table-striped"}

### Return type

[**SurveyAsyncAggregateQueryResponse**](SurveyAsyncAggregateQueryResponse.html)

<a name="getanalyticstaskmanagementaggregatesjob"></a>

## [**AsyncQueryStatus**](AsyncQueryStatus.html) GetAnalyticsTaskmanagementAggregatesJob (string jobId)



Get status for async query for task management aggregates

GetAnalyticsTaskmanagementAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:taskManagementAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsTaskmanagementAggregatesJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get status for async query for task management aggregates
                AsyncQueryStatus result = apiInstance.GetAnalyticsTaskmanagementAggregatesJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsTaskmanagementAggregatesJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus.html)

<a name="getanalyticstaskmanagementaggregatesjobresults"></a>

## [**TaskManagementAsyncAggregateQueryResponse**](TaskManagementAsyncAggregateQueryResponse.html) GetAnalyticsTaskmanagementAggregatesJobResults (string jobId, string cursor = null)



Fetch a page of results for an async task management query

GetAnalyticsTaskmanagementAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:taskManagementAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsTaskmanagementAggregatesJobResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId
            var cursor = cursor_example;  // string | Cursor token to retrieve next page (optional) 

            try
            { 
                // Fetch a page of results for an async task management query
                TaskManagementAsyncAggregateQueryResponse result = apiInstance.GetAnalyticsTaskmanagementAggregatesJobResults(jobId, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsTaskmanagementAggregatesJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
| **cursor** | **string**| Cursor token to retrieve next page | [optional]  |
{: class="table table-striped"}

### Return type

[**TaskManagementAsyncAggregateQueryResponse**](TaskManagementAsyncAggregateQueryResponse.html)

<a name="getanalyticstranscriptsaggregatesjob"></a>

## [**AsyncQueryStatus**](AsyncQueryStatus.html) GetAnalyticsTranscriptsAggregatesJob (string jobId)



Get status for async query for transcript aggregates

GetAnalyticsTranscriptsAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:speechAndTextAnalyticsAggregates:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsTranscriptsAggregatesJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get status for async query for transcript aggregates
                AsyncQueryStatus result = apiInstance.GetAnalyticsTranscriptsAggregatesJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsTranscriptsAggregatesJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus.html)

<a name="getanalyticstranscriptsaggregatesjobresults"></a>

## [**TranscriptAsyncAggregateQueryResponse**](TranscriptAsyncAggregateQueryResponse.html) GetAnalyticsTranscriptsAggregatesJobResults (string jobId, string cursor = null)



Fetch a page of results for an async aggregates query

GetAnalyticsTranscriptsAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:speechAndTextAnalyticsAggregates:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsTranscriptsAggregatesJobResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId
            var cursor = cursor_example;  // string | Cursor token to retrieve next page (optional) 

            try
            { 
                // Fetch a page of results for an async aggregates query
                TranscriptAsyncAggregateQueryResponse result = apiInstance.GetAnalyticsTranscriptsAggregatesJobResults(jobId, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsTranscriptsAggregatesJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
| **cursor** | **string**| Cursor token to retrieve next page | [optional]  |
{: class="table table-striped"}

### Return type

[**TranscriptAsyncAggregateQueryResponse**](TranscriptAsyncAggregateQueryResponse.html)

<a name="getanalyticsusersaggregatesjob"></a>

## [**AsyncQueryStatus**](AsyncQueryStatus.html) GetAnalyticsUsersAggregatesJob (string jobId)



Get status for async query for user aggregates

GetAnalyticsUsersAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:userAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsUsersAggregatesJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get status for async query for user aggregates
                AsyncQueryStatus result = apiInstance.GetAnalyticsUsersAggregatesJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsUsersAggregatesJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus.html)

<a name="getanalyticsusersaggregatesjobresults"></a>

## [**UserAsyncAggregateQueryResponse**](UserAsyncAggregateQueryResponse.html) GetAnalyticsUsersAggregatesJobResults (string jobId, string cursor = null)



Fetch a page of results for an async aggregates query

GetAnalyticsUsersAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:userAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsUsersAggregatesJobResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId
            var cursor = cursor_example;  // string | Cursor token to retrieve next page (optional) 

            try
            { 
                // Fetch a page of results for an async aggregates query
                UserAsyncAggregateQueryResponse result = apiInstance.GetAnalyticsUsersAggregatesJobResults(jobId, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsUsersAggregatesJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
| **cursor** | **string**| Cursor token to retrieve next page | [optional]  |
{: class="table table-striped"}

### Return type

[**UserAsyncAggregateQueryResponse**](UserAsyncAggregateQueryResponse.html)

<a name="getanalyticsusersdetailsjob"></a>

## [**AsyncQueryStatus**](AsyncQueryStatus.html) GetAnalyticsUsersDetailsJob (string jobId)



Get status for async query for user details

Requires ANY permissions: 

* analytics:userDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsUsersDetailsJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get status for async query for user details
                AsyncQueryStatus result = apiInstance.GetAnalyticsUsersDetailsJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsUsersDetailsJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus.html)

<a name="getanalyticsusersdetailsjobresults"></a>

## [**AnalyticsUserDetailsAsyncQueryResponse**](AnalyticsUserDetailsAsyncQueryResponse.html) GetAnalyticsUsersDetailsJobResults (string jobId, string cursor = null, int? pageSize = null)



Fetch a page of results for an async query

Requires ANY permissions: 

* analytics:userDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsUsersDetailsJobResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var jobId = jobId_example;  // string | jobId
            var cursor = cursor_example;  // string | Indicates where to resume query results (not required for first page) (optional) 
            var pageSize = 56;  // int? | The desired maximum number of results (optional) 

            try
            { 
                // Fetch a page of results for an async query
                AnalyticsUserDetailsAsyncQueryResponse result = apiInstance.GetAnalyticsUsersDetailsJobResults(jobId, cursor, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsUsersDetailsJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
| **cursor** | **string**| Indicates where to resume query results (not required for first page) | [optional]  |
| **pageSize** | **int?**| The desired maximum number of results | [optional]  |
{: class="table table-striped"}

### Return type

[**AnalyticsUserDetailsAsyncQueryResponse**](AnalyticsUserDetailsAsyncQueryResponse.html)

<a name="getanalyticsusersdetailsjobsavailability"></a>

## [**DataAvailabilityResponse**](DataAvailabilityResponse.html) GetAnalyticsUsersDetailsJobsAvailability ()



Lookup the datalake availability date and time

Requires ANY permissions: 

* analytics:userDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsUsersDetailsJobsAvailabilityExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();

            try
            { 
                // Lookup the datalake availability date and time
                DataAvailabilityResponse result = apiInstance.GetAnalyticsUsersDetailsJobsAvailability();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsUsersDetailsJobsAvailability: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**DataAvailabilityResponse**](DataAvailabilityResponse.html)

<a name="patchanalyticsreportingsettings"></a>

## [**AnalyticsReportingSettings**](AnalyticsReportingSettings.html) PatchAnalyticsReportingSettings (AnalyticsReportingSettings body)



Patch AnalyticsReportingSettings values for an organization

Requires ANY permissions: 

* analytics:reportingSettings:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchAnalyticsReportingSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new AnalyticsReportingSettings(); // AnalyticsReportingSettings | AnalyticsReportingSettingsRequest

            try
            { 
                // Patch AnalyticsReportingSettings values for an organization
                AnalyticsReportingSettings result = apiInstance.PatchAnalyticsReportingSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PatchAnalyticsReportingSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AnalyticsReportingSettings**](AnalyticsReportingSettings.html)| AnalyticsReportingSettingsRequest |  |
{: class="table table-striped"}

### Return type

[**AnalyticsReportingSettings**](AnalyticsReportingSettings.html)

<a name="postanalyticsactionsaggregatesjobs"></a>

## [**AsyncQueryResponse**](AsyncQueryResponse.html) PostAnalyticsActionsAggregatesJobs (ActionAsyncAggregationQuery body)



Query for action aggregates asynchronously

PostAnalyticsActionsAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* integrations:action:view
* bridge:actions:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsActionsAggregatesJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new ActionAsyncAggregationQuery(); // ActionAsyncAggregationQuery | query

            try
            { 
                // Query for action aggregates asynchronously
                AsyncQueryResponse result = apiInstance.PostAnalyticsActionsAggregatesJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsActionsAggregatesJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ActionAsyncAggregationQuery**](ActionAsyncAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse.html)

<a name="postanalyticsactionsaggregatesquery"></a>

## [**ActionAggregateQueryResponse**](ActionAggregateQueryResponse.html) PostAnalyticsActionsAggregatesQuery (ActionAggregationQuery body)



Query for action aggregates

Requires ANY permissions: 

* integrations:action:view
* bridge:actions:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsActionsAggregatesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new ActionAggregationQuery(); // ActionAggregationQuery | query

            try
            { 
                // Query for action aggregates
                ActionAggregateQueryResponse result = apiInstance.PostAnalyticsActionsAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsActionsAggregatesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ActionAggregationQuery**](ActionAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**ActionAggregateQueryResponse**](ActionAggregateQueryResponse.html)

<a name="postanalyticsagentcopilotsaggregatesjobs"></a>

## [**AsyncQueryResponse**](AsyncQueryResponse.html) PostAnalyticsAgentcopilotsAggregatesJobs (AgentCopilotAsyncAggregationQuery body)



Query for agent copilot aggregates asynchronously

PostAnalyticsAgentcopilotsAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:agentCopilotAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsAgentcopilotsAggregatesJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new AgentCopilotAsyncAggregationQuery(); // AgentCopilotAsyncAggregationQuery | query

            try
            { 
                // Query for agent copilot aggregates asynchronously
                AsyncQueryResponse result = apiInstance.PostAnalyticsAgentcopilotsAggregatesJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsAgentcopilotsAggregatesJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AgentCopilotAsyncAggregationQuery**](AgentCopilotAsyncAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse.html)

<a name="postanalyticsagentcopilotsaggregatesquery"></a>

## [**AgentCopilotAggregateQueryResponse**](AgentCopilotAggregateQueryResponse.html) PostAnalyticsAgentcopilotsAggregatesQuery (AgentCopilotAggregationQuery body)



Query for agent copilot aggregates

PostAnalyticsAgentcopilotsAggregatesQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:agentCopilotAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsAgentcopilotsAggregatesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new AgentCopilotAggregationQuery(); // AgentCopilotAggregationQuery | query

            try
            { 
                // Query for agent copilot aggregates
                AgentCopilotAggregateQueryResponse result = apiInstance.PostAnalyticsAgentcopilotsAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsAgentcopilotsAggregatesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AgentCopilotAggregationQuery**](AgentCopilotAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AgentCopilotAggregateQueryResponse**](AgentCopilotAggregateQueryResponse.html)

<a name="postanalyticsbotsaggregatesjobs"></a>

## [**AsyncQueryResponse**](AsyncQueryResponse.html) PostAnalyticsBotsAggregatesJobs (BotAsyncAggregationQuery body)



Query for bot aggregates asynchronously

PostAnalyticsBotsAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:botAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsBotsAggregatesJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new BotAsyncAggregationQuery(); // BotAsyncAggregationQuery | query

            try
            { 
                // Query for bot aggregates asynchronously
                AsyncQueryResponse result = apiInstance.PostAnalyticsBotsAggregatesJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsBotsAggregatesJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**BotAsyncAggregationQuery**](BotAsyncAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse.html)

<a name="postanalyticsbotsaggregatesquery"></a>

## [**BotAggregateQueryResponse**](BotAggregateQueryResponse.html) PostAnalyticsBotsAggregatesQuery (BotAggregationQuery body)



Query for bot aggregates

Requires ANY permissions: 

* analytics:botAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsBotsAggregatesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new BotAggregationQuery(); // BotAggregationQuery | query

            try
            { 
                // Query for bot aggregates
                BotAggregateQueryResponse result = apiInstance.PostAnalyticsBotsAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsBotsAggregatesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**BotAggregationQuery**](BotAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**BotAggregateQueryResponse**](BotAggregateQueryResponse.html)

<a name="postanalyticsconversationdetailsproperties"></a>

## [**PropertyIndexRequest**](PropertyIndexRequest.html) PostAnalyticsConversationDetailsProperties (string conversationId, PropertyIndexRequest body)



Index conversation properties

Requires ANY permissions: 

* analytics:conversationProperties:index

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsConversationDetailsPropertiesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new PropertyIndexRequest(); // PropertyIndexRequest | request

            try
            { 
                // Index conversation properties
                PropertyIndexRequest result = apiInstance.PostAnalyticsConversationDetailsProperties(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsConversationDetailsProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**PropertyIndexRequest**](PropertyIndexRequest.html)| request |  |
{: class="table table-striped"}

### Return type

[**PropertyIndexRequest**](PropertyIndexRequest.html)

<a name="postanalyticsconversationsactivityquery"></a>

## [**ConversationActivityResponse**](ConversationActivityResponse.html) PostAnalyticsConversationsActivityQuery (ConversationActivityQuery body, int? pageSize = null, int? pageNumber = null)



Query for conversation activity observations

Requires ANY permissions: 

* analytics:queueObservation:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsConversationsActivityQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new ConversationActivityQuery(); // ConversationActivityQuery | query
            var pageSize = 56;  // int? | The desired page size (optional) 
            var pageNumber = 56;  // int? | The desired page number (optional) 

            try
            { 
                // Query for conversation activity observations
                ConversationActivityResponse result = apiInstance.PostAnalyticsConversationsActivityQuery(body, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsConversationsActivityQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ConversationActivityQuery**](ConversationActivityQuery.html)| query |  |
| **pageSize** | **int?**| The desired page size | [optional]  |
| **pageNumber** | **int?**| The desired page number | [optional]  |
{: class="table table-striped"}

### Return type

[**ConversationActivityResponse**](ConversationActivityResponse.html)

<a name="postanalyticsconversationsaggregatesjobs"></a>

## [**AsyncQueryResponse**](AsyncQueryResponse.html) PostAnalyticsConversationsAggregatesJobs (ConversationAsyncAggregationQuery body)



Query for conversation aggregates asynchronously

PostAnalyticsConversationsAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:conversationAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsConversationsAggregatesJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new ConversationAsyncAggregationQuery(); // ConversationAsyncAggregationQuery | query

            try
            { 
                // Query for conversation aggregates asynchronously
                AsyncQueryResponse result = apiInstance.PostAnalyticsConversationsAggregatesJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsConversationsAggregatesJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ConversationAsyncAggregationQuery**](ConversationAsyncAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse.html)

<a name="postanalyticsconversationsaggregatesquery"></a>

## [**ConversationAggregateQueryResponse**](ConversationAggregateQueryResponse.html) PostAnalyticsConversationsAggregatesQuery (ConversationAggregationQuery body)



Query for conversation aggregates

Requires ANY permissions: 

* analytics:conversationAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsConversationsAggregatesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new ConversationAggregationQuery(); // ConversationAggregationQuery | query

            try
            { 
                // Query for conversation aggregates
                ConversationAggregateQueryResponse result = apiInstance.PostAnalyticsConversationsAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsConversationsAggregatesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ConversationAggregationQuery**](ConversationAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**ConversationAggregateQueryResponse**](ConversationAggregateQueryResponse.html)

<a name="postanalyticsconversationsdetailsjobs"></a>

## [**AsyncQueryResponse**](AsyncQueryResponse.html) PostAnalyticsConversationsDetailsJobs (AsyncConversationQuery body)



Query for conversation details asynchronously

Requires ANY permissions: 

* analytics:conversationDetail:view
* analytics:agentConversationDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsConversationsDetailsJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new AsyncConversationQuery(); // AsyncConversationQuery | query

            try
            { 
                // Query for conversation details asynchronously
                AsyncQueryResponse result = apiInstance.PostAnalyticsConversationsDetailsJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsConversationsDetailsJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AsyncConversationQuery**](AsyncConversationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse.html)

<a name="postanalyticsconversationsdetailsquery"></a>

## [**AnalyticsConversationQueryResponse**](AnalyticsConversationQueryResponse.html) PostAnalyticsConversationsDetailsQuery (ConversationQuery body)



Query for conversation details

Requires ANY permissions: 

* analytics:conversationDetail:view
* analytics:agentConversationDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsConversationsDetailsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new ConversationQuery(); // ConversationQuery | query

            try
            { 
                // Query for conversation details
                AnalyticsConversationQueryResponse result = apiInstance.PostAnalyticsConversationsDetailsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsConversationsDetailsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ConversationQuery**](ConversationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AnalyticsConversationQueryResponse**](AnalyticsConversationQueryResponse.html)

<a name="postanalyticsconversationstranscriptsquery"></a>

## [**AnalyticsConversationWithoutAttributesMultiGetResponse**](AnalyticsConversationWithoutAttributesMultiGetResponse.html) PostAnalyticsConversationsTranscriptsQuery (TranscriptConversationDetailSearchRequest body)



Search resources.

Requires ANY permissions: 

* analytics:conversationDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsConversationsTranscriptsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new TranscriptConversationDetailSearchRequest(); // TranscriptConversationDetailSearchRequest | Search request options

            try
            { 
                // Search resources.
                AnalyticsConversationWithoutAttributesMultiGetResponse result = apiInstance.PostAnalyticsConversationsTranscriptsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsConversationsTranscriptsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TranscriptConversationDetailSearchRequest**](TranscriptConversationDetailSearchRequest.html)| Search request options |  |
{: class="table table-striped"}

### Return type

[**AnalyticsConversationWithoutAttributesMultiGetResponse**](AnalyticsConversationWithoutAttributesMultiGetResponse.html)

<a name="postanalyticsevaluationsaggregatesjobs"></a>

## [**AsyncQueryResponse**](AsyncQueryResponse.html) PostAnalyticsEvaluationsAggregatesJobs (EvaluationAsyncAggregationQuery body)



Query for evaluation aggregates asynchronously

PostAnalyticsEvaluationsAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:evaluationAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsEvaluationsAggregatesJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new EvaluationAsyncAggregationQuery(); // EvaluationAsyncAggregationQuery | query

            try
            { 
                // Query for evaluation aggregates asynchronously
                AsyncQueryResponse result = apiInstance.PostAnalyticsEvaluationsAggregatesJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsEvaluationsAggregatesJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**EvaluationAsyncAggregationQuery**](EvaluationAsyncAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse.html)

<a name="postanalyticsevaluationsaggregatesquery"></a>

## [**EvaluationAggregateQueryResponse**](EvaluationAggregateQueryResponse.html) PostAnalyticsEvaluationsAggregatesQuery (EvaluationAggregationQuery body)



Query for evaluation aggregates

Requires ANY permissions: 

* analytics:evaluationAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsEvaluationsAggregatesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new EvaluationAggregationQuery(); // EvaluationAggregationQuery | query

            try
            { 
                // Query for evaluation aggregates
                EvaluationAggregateQueryResponse result = apiInstance.PostAnalyticsEvaluationsAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsEvaluationsAggregatesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**EvaluationAggregationQuery**](EvaluationAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**EvaluationAggregateQueryResponse**](EvaluationAggregateQueryResponse.html)

<a name="postanalyticsflowexecutionsaggregatesjobs"></a>

## [**AsyncQueryResponse**](AsyncQueryResponse.html) PostAnalyticsFlowexecutionsAggregatesJobs (FlowExecutionAsyncAggregationQuery body)



Query for flow execution aggregates asynchronously

PostAnalyticsFlowexecutionsAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:flowExecutionAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsFlowexecutionsAggregatesJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new FlowExecutionAsyncAggregationQuery(); // FlowExecutionAsyncAggregationQuery | query

            try
            { 
                // Query for flow execution aggregates asynchronously
                AsyncQueryResponse result = apiInstance.PostAnalyticsFlowexecutionsAggregatesJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsFlowexecutionsAggregatesJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**FlowExecutionAsyncAggregationQuery**](FlowExecutionAsyncAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse.html)

<a name="postanalyticsflowexecutionsaggregatesquery"></a>

## [**FlowExecutionAggregateQueryResponse**](FlowExecutionAggregateQueryResponse.html) PostAnalyticsFlowexecutionsAggregatesQuery (FlowExecutionAggregationQuery body)



Query for flow execution aggregates

Requires ANY permissions: 

* analytics:flowExecutionAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsFlowexecutionsAggregatesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new FlowExecutionAggregationQuery(); // FlowExecutionAggregationQuery | query

            try
            { 
                // Query for flow execution aggregates
                FlowExecutionAggregateQueryResponse result = apiInstance.PostAnalyticsFlowexecutionsAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsFlowexecutionsAggregatesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**FlowExecutionAggregationQuery**](FlowExecutionAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**FlowExecutionAggregateQueryResponse**](FlowExecutionAggregateQueryResponse.html)

<a name="postanalyticsflowsactivityquery"></a>

## [**FlowActivityResponse**](FlowActivityResponse.html) PostAnalyticsFlowsActivityQuery (FlowActivityQuery body, int? pageSize = null, int? pageNumber = null)



Query for flow activity observations

Requires ANY permissions: 

* analytics:flowObservation:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsFlowsActivityQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new FlowActivityQuery(); // FlowActivityQuery | query
            var pageSize = 56;  // int? | The desired page size (optional) 
            var pageNumber = 56;  // int? | The desired page number (optional) 

            try
            { 
                // Query for flow activity observations
                FlowActivityResponse result = apiInstance.PostAnalyticsFlowsActivityQuery(body, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsFlowsActivityQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**FlowActivityQuery**](FlowActivityQuery.html)| query |  |
| **pageSize** | **int?**| The desired page size | [optional]  |
| **pageNumber** | **int?**| The desired page number | [optional]  |
{: class="table table-striped"}

### Return type

[**FlowActivityResponse**](FlowActivityResponse.html)

<a name="postanalyticsflowsaggregatesjobs"></a>

## [**AsyncQueryResponse**](AsyncQueryResponse.html) PostAnalyticsFlowsAggregatesJobs (FlowAsyncAggregationQuery body)



Query for flow aggregates asynchronously

PostAnalyticsFlowsAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:flowAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsFlowsAggregatesJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new FlowAsyncAggregationQuery(); // FlowAsyncAggregationQuery | query

            try
            { 
                // Query for flow aggregates asynchronously
                AsyncQueryResponse result = apiInstance.PostAnalyticsFlowsAggregatesJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsFlowsAggregatesJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**FlowAsyncAggregationQuery**](FlowAsyncAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse.html)

<a name="postanalyticsflowsaggregatesquery"></a>

## [**FlowAggregateQueryResponse**](FlowAggregateQueryResponse.html) PostAnalyticsFlowsAggregatesQuery (FlowAggregationQuery body)



Query for flow aggregates

Requires ANY permissions: 

* analytics:flowAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsFlowsAggregatesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new FlowAggregationQuery(); // FlowAggregationQuery | query

            try
            { 
                // Query for flow aggregates
                FlowAggregateQueryResponse result = apiInstance.PostAnalyticsFlowsAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsFlowsAggregatesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**FlowAggregationQuery**](FlowAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**FlowAggregateQueryResponse**](FlowAggregateQueryResponse.html)

<a name="postanalyticsflowsobservationsquery"></a>

## [**FlowObservationQueryResponse**](FlowObservationQueryResponse.html) PostAnalyticsFlowsObservationsQuery (FlowObservationQuery body)



Query for flow observations

Requires ANY permissions: 

* analytics:flowObservation:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsFlowsObservationsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new FlowObservationQuery(); // FlowObservationQuery | query

            try
            { 
                // Query for flow observations
                FlowObservationQueryResponse result = apiInstance.PostAnalyticsFlowsObservationsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsFlowsObservationsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**FlowObservationQuery**](FlowObservationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**FlowObservationQueryResponse**](FlowObservationQueryResponse.html)

<a name="postanalyticsjourneysaggregatesjobs"></a>

## [**AsyncQueryResponse**](AsyncQueryResponse.html) PostAnalyticsJourneysAggregatesJobs (JourneyAsyncAggregationQuery body)



Query for journey aggregates asynchronously

PostAnalyticsJourneysAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:journeyAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsJourneysAggregatesJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new JourneyAsyncAggregationQuery(); // JourneyAsyncAggregationQuery | query

            try
            { 
                // Query for journey aggregates asynchronously
                AsyncQueryResponse result = apiInstance.PostAnalyticsJourneysAggregatesJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsJourneysAggregatesJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**JourneyAsyncAggregationQuery**](JourneyAsyncAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse.html)

<a name="postanalyticsjourneysaggregatesquery"></a>

## [**JourneyAggregateQueryResponse**](JourneyAggregateQueryResponse.html) PostAnalyticsJourneysAggregatesQuery (JourneyAggregationQuery body)



Query for journey aggregates

Requires ANY permissions: 

* analytics:journeyAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsJourneysAggregatesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new JourneyAggregationQuery(); // JourneyAggregationQuery | query

            try
            { 
                // Query for journey aggregates
                JourneyAggregateQueryResponse result = apiInstance.PostAnalyticsJourneysAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsJourneysAggregatesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**JourneyAggregationQuery**](JourneyAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**JourneyAggregateQueryResponse**](JourneyAggregateQueryResponse.html)

<a name="postanalyticsknowledgeaggregatesjobs"></a>

## [**AsyncQueryResponse**](AsyncQueryResponse.html) PostAnalyticsKnowledgeAggregatesJobs (KnowledgeAsyncAggregationQuery body)



Query for knowledge aggregates asynchronously

PostAnalyticsKnowledgeAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:knowledgeAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsKnowledgeAggregatesJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new KnowledgeAsyncAggregationQuery(); // KnowledgeAsyncAggregationQuery | query

            try
            { 
                // Query for knowledge aggregates asynchronously
                AsyncQueryResponse result = apiInstance.PostAnalyticsKnowledgeAggregatesJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsKnowledgeAggregatesJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**KnowledgeAsyncAggregationQuery**](KnowledgeAsyncAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse.html)

<a name="postanalyticsknowledgeaggregatesquery"></a>

## [**KnowledgeAggregateQueryResponse**](KnowledgeAggregateQueryResponse.html) PostAnalyticsKnowledgeAggregatesQuery (KnowledgeAggregationQuery body)



Query for knowledge aggregates

Requires ANY permissions: 

* analytics:knowledgeAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsKnowledgeAggregatesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new KnowledgeAggregationQuery(); // KnowledgeAggregationQuery | query

            try
            { 
                // Query for knowledge aggregates
                KnowledgeAggregateQueryResponse result = apiInstance.PostAnalyticsKnowledgeAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsKnowledgeAggregatesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**KnowledgeAggregationQuery**](KnowledgeAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**KnowledgeAggregateQueryResponse**](KnowledgeAggregateQueryResponse.html)

<a name="postanalyticsqueuesobservationsquery"></a>

## [**QueueObservationQueryResponse**](QueueObservationQueryResponse.html) PostAnalyticsQueuesObservationsQuery (QueueObservationQuery body)



Query for queue observations

Requires ANY permissions: 

* analytics:queueObservation:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsQueuesObservationsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new QueueObservationQuery(); // QueueObservationQuery | query

            try
            { 
                // Query for queue observations
                QueueObservationQueryResponse result = apiInstance.PostAnalyticsQueuesObservationsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsQueuesObservationsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**QueueObservationQuery**](QueueObservationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**QueueObservationQueryResponse**](QueueObservationQueryResponse.html)

<a name="postanalyticsratelimitsaggregatesquery"></a>

## [**RateLimitAggregateQueryResponse**](RateLimitAggregateQueryResponse.html) PostAnalyticsRatelimitsAggregatesQuery (RateLimitAggregationQuery body)



Query for limits rate limit aggregates. Data populated when limits reach 90% of the maximum. Not a source of truth for limits hit but a best effort estimate.

The 'max' property can be used to determine estimated rate limit value hit. See https://developer.genesys.cloud/organization/organization/limits#available-limits for limits that are trackable (Operational Events Enabled).

Requires ANY permissions: 

* analytics:rateLimitAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsRatelimitsAggregatesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new RateLimitAggregationQuery(); // RateLimitAggregationQuery | query

            try
            { 
                // Query for limits rate limit aggregates. Data populated when limits reach 90% of the maximum. Not a source of truth for limits hit but a best effort estimate.
                RateLimitAggregateQueryResponse result = apiInstance.PostAnalyticsRatelimitsAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsRatelimitsAggregatesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**RateLimitAggregationQuery**](RateLimitAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**RateLimitAggregateQueryResponse**](RateLimitAggregateQueryResponse.html)

<a name="postanalyticsreportingdashboardsusersbulkremove"></a>

## void PostAnalyticsReportingDashboardsUsersBulkRemove (List<string> body)



Bulk delete dashboards owned by other user(s)

Requires ANY permissions: 

* analytics:dashboardConfigurations:deleteActive
* analytics:dashboardConfigurations:deleteInactive

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsReportingDashboardsUsersBulkRemoveExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new List<string>(); // List<string> | List of userIds

            try
            { 
                // Bulk delete dashboards owned by other user(s)
                apiInstance.PostAnalyticsReportingDashboardsUsersBulkRemove(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsReportingDashboardsUsersBulkRemove: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**List<string>**](string.html)| List of userIds |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postanalyticsreportingexports"></a>

## [**ReportingExportJobResponse**](ReportingExportJobResponse.html) PostAnalyticsReportingExports (ReportingExportJobRequest body)



Generate a view export request

This API creates a reporting export but the desired way to export analytics data is to use the analytics query APIs instead

Requires ALL permissions: 

* analytics:dataExport:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsReportingExportsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new ReportingExportJobRequest(); // ReportingExportJobRequest | ReportingExportJobRequest

            try
            { 
                // Generate a view export request
                ReportingExportJobResponse result = apiInstance.PostAnalyticsReportingExports(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsReportingExports: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ReportingExportJobRequest**](ReportingExportJobRequest.html)| ReportingExportJobRequest |  |
{: class="table table-striped"}

### Return type

[**ReportingExportJobResponse**](ReportingExportJobResponse.html)

<a name="postanalyticsreportingsettingsdashboardsbulkremove"></a>

## void PostAnalyticsReportingSettingsDashboardsBulkRemove (DashboardConfigurationBulkRequest body)



Bulk remove dashboard configurations

Requires ALL permissions: 

* analytics:dashboardConfigurations:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsReportingSettingsDashboardsBulkRemoveExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new DashboardConfigurationBulkRequest(); // DashboardConfigurationBulkRequest | 

            try
            { 
                // Bulk remove dashboard configurations
                apiInstance.PostAnalyticsReportingSettingsDashboardsBulkRemove(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsReportingSettingsDashboardsBulkRemove: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DashboardConfigurationBulkRequest**](DashboardConfigurationBulkRequest.html)|  |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postanalyticsreportingsettingsdashboardsquery"></a>

## [**DashboardConfigurationListing**](DashboardConfigurationListing.html) PostAnalyticsReportingSettingsDashboardsQuery (DashboardConfigurationQueryRequest body)



Query dashboard configurations

Requires ALL permissions: 

* analytics:dashboardConfigurations:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsReportingSettingsDashboardsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new DashboardConfigurationQueryRequest(); // DashboardConfigurationQueryRequest | 

            try
            { 
                // Query dashboard configurations
                DashboardConfigurationListing result = apiInstance.PostAnalyticsReportingSettingsDashboardsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsReportingSettingsDashboardsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DashboardConfigurationQueryRequest**](DashboardConfigurationQueryRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**DashboardConfigurationListing**](DashboardConfigurationListing.html)

<a name="postanalyticsresolutionsaggregatesjobs"></a>

## [**AsyncQueryResponse**](AsyncQueryResponse.html) PostAnalyticsResolutionsAggregatesJobs (ResolutionAsyncAggregationQuery body)



Query for resolution aggregates asynchronously

PostAnalyticsResolutionsAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:resolutionAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsResolutionsAggregatesJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new ResolutionAsyncAggregationQuery(); // ResolutionAsyncAggregationQuery | query

            try
            { 
                // Query for resolution aggregates asynchronously
                AsyncQueryResponse result = apiInstance.PostAnalyticsResolutionsAggregatesJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsResolutionsAggregatesJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ResolutionAsyncAggregationQuery**](ResolutionAsyncAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse.html)

<a name="postanalyticsroutingactivityquery"></a>

## [**RoutingActivityResponse**](RoutingActivityResponse.html) PostAnalyticsRoutingActivityQuery (RoutingActivityQuery body, int? pageSize = null, int? pageNumber = null)



Query for user activity observations

Requires ANY permissions: 

* analytics:queueObservation:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsRoutingActivityQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new RoutingActivityQuery(); // RoutingActivityQuery | query
            var pageSize = 56;  // int? | The desired page size (optional) 
            var pageNumber = 56;  // int? | The desired page number (optional) 

            try
            { 
                // Query for user activity observations
                RoutingActivityResponse result = apiInstance.PostAnalyticsRoutingActivityQuery(body, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsRoutingActivityQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**RoutingActivityQuery**](RoutingActivityQuery.html)| query |  |
| **pageSize** | **int?**| The desired page size | [optional]  |
| **pageNumber** | **int?**| The desired page number | [optional]  |
{: class="table table-striped"}

### Return type

[**RoutingActivityResponse**](RoutingActivityResponse.html)

<a name="postanalyticssurveysaggregatesjobs"></a>

## [**AsyncQueryResponse**](AsyncQueryResponse.html) PostAnalyticsSurveysAggregatesJobs (SurveyAsyncAggregationQuery body)



Query for survey aggregates asynchronously

PostAnalyticsSurveysAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:surveyAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsSurveysAggregatesJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new SurveyAsyncAggregationQuery(); // SurveyAsyncAggregationQuery | query

            try
            { 
                // Query for survey aggregates asynchronously
                AsyncQueryResponse result = apiInstance.PostAnalyticsSurveysAggregatesJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsSurveysAggregatesJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SurveyAsyncAggregationQuery**](SurveyAsyncAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse.html)

<a name="postanalyticssurveysaggregatesquery"></a>

## [**SurveyAggregateQueryResponse**](SurveyAggregateQueryResponse.html) PostAnalyticsSurveysAggregatesQuery (SurveyAggregationQuery body)



Query for survey aggregates

Requires ANY permissions: 

* analytics:surveyAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsSurveysAggregatesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new SurveyAggregationQuery(); // SurveyAggregationQuery | query

            try
            { 
                // Query for survey aggregates
                SurveyAggregateQueryResponse result = apiInstance.PostAnalyticsSurveysAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsSurveysAggregatesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SurveyAggregationQuery**](SurveyAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**SurveyAggregateQueryResponse**](SurveyAggregateQueryResponse.html)

<a name="postanalyticstaskmanagementaggregatesjobs"></a>

## [**AsyncQueryResponse**](AsyncQueryResponse.html) PostAnalyticsTaskmanagementAggregatesJobs (TaskManagementAsyncAggregationQuery body)



Query for task management aggregates asynchronously

PostAnalyticsTaskmanagementAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:taskManagementAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsTaskmanagementAggregatesJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new TaskManagementAsyncAggregationQuery(); // TaskManagementAsyncAggregationQuery | query

            try
            { 
                // Query for task management aggregates asynchronously
                AsyncQueryResponse result = apiInstance.PostAnalyticsTaskmanagementAggregatesJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsTaskmanagementAggregatesJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TaskManagementAsyncAggregationQuery**](TaskManagementAsyncAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse.html)

<a name="postanalyticstaskmanagementaggregatesquery"></a>

## [**TaskManagementAggregateQueryResponse**](TaskManagementAggregateQueryResponse.html) PostAnalyticsTaskmanagementAggregatesQuery (TaskManagementAggregationQuery body)



Query for task management aggregates

PostAnalyticsTaskmanagementAggregatesQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:taskManagementAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsTaskmanagementAggregatesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new TaskManagementAggregationQuery(); // TaskManagementAggregationQuery | query

            try
            { 
                // Query for task management aggregates
                TaskManagementAggregateQueryResponse result = apiInstance.PostAnalyticsTaskmanagementAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsTaskmanagementAggregatesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TaskManagementAggregationQuery**](TaskManagementAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**TaskManagementAggregateQueryResponse**](TaskManagementAggregateQueryResponse.html)

<a name="postanalyticsteamsactivityquery"></a>

## [**TeamActivityResponse**](TeamActivityResponse.html) PostAnalyticsTeamsActivityQuery (TeamActivityQuery body, int? pageSize = null, int? pageNumber = null)



Query for team activity observations

Requires ANY permissions: 

* analytics:teamObservation:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsTeamsActivityQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new TeamActivityQuery(); // TeamActivityQuery | query
            var pageSize = 56;  // int? | The desired page size (optional) 
            var pageNumber = 56;  // int? | The desired page number (optional) 

            try
            { 
                // Query for team activity observations
                TeamActivityResponse result = apiInstance.PostAnalyticsTeamsActivityQuery(body, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsTeamsActivityQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TeamActivityQuery**](TeamActivityQuery.html)| query |  |
| **pageSize** | **int?**| The desired page size | [optional]  |
| **pageNumber** | **int?**| The desired page number | [optional]  |
{: class="table table-striped"}

### Return type

[**TeamActivityResponse**](TeamActivityResponse.html)

<a name="postanalyticstranscriptsaggregatesjobs"></a>

## [**AsyncQueryResponse**](AsyncQueryResponse.html) PostAnalyticsTranscriptsAggregatesJobs (TranscriptAsyncAggregationQuery body)



Query for transcript aggregates asynchronously

PostAnalyticsTranscriptsAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:speechAndTextAnalyticsAggregates:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsTranscriptsAggregatesJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new TranscriptAsyncAggregationQuery(); // TranscriptAsyncAggregationQuery | query

            try
            { 
                // Query for transcript aggregates asynchronously
                AsyncQueryResponse result = apiInstance.PostAnalyticsTranscriptsAggregatesJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsTranscriptsAggregatesJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TranscriptAsyncAggregationQuery**](TranscriptAsyncAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse.html)

<a name="postanalyticstranscriptsaggregatesquery"></a>

## [**TranscriptAggregateQueryResponse**](TranscriptAggregateQueryResponse.html) PostAnalyticsTranscriptsAggregatesQuery (TranscriptAggregationQuery body)



Query for transcript aggregates

Requires ANY permissions: 

* analytics:speechAndTextAnalyticsAggregates:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsTranscriptsAggregatesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new TranscriptAggregationQuery(); // TranscriptAggregationQuery | query

            try
            { 
                // Query for transcript aggregates
                TranscriptAggregateQueryResponse result = apiInstance.PostAnalyticsTranscriptsAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsTranscriptsAggregatesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TranscriptAggregationQuery**](TranscriptAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**TranscriptAggregateQueryResponse**](TranscriptAggregateQueryResponse.html)

<a name="postanalyticsusersactivityquery"></a>

## [**UserActivityResponse**](UserActivityResponse.html) PostAnalyticsUsersActivityQuery (UserActivityQuery body, int? pageSize = null, int? pageNumber = null)



Query for user activity observations

Requires ANY permissions: 

* analytics:userObservation:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsUsersActivityQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new UserActivityQuery(); // UserActivityQuery | query
            var pageSize = 56;  // int? | The desired page size (optional) 
            var pageNumber = 56;  // int? | The desired page number (optional) 

            try
            { 
                // Query for user activity observations
                UserActivityResponse result = apiInstance.PostAnalyticsUsersActivityQuery(body, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsUsersActivityQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UserActivityQuery**](UserActivityQuery.html)| query |  |
| **pageSize** | **int?**| The desired page size | [optional]  |
| **pageNumber** | **int?**| The desired page number | [optional]  |
{: class="table table-striped"}

### Return type

[**UserActivityResponse**](UserActivityResponse.html)

<a name="postanalyticsusersaggregatesjobs"></a>

## [**AsyncQueryResponse**](AsyncQueryResponse.html) PostAnalyticsUsersAggregatesJobs (UserAsyncAggregationQuery body)



Query for user aggregates asynchronously

PostAnalyticsUsersAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:userAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsUsersAggregatesJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new UserAsyncAggregationQuery(); // UserAsyncAggregationQuery | query

            try
            { 
                // Query for user aggregates asynchronously
                AsyncQueryResponse result = apiInstance.PostAnalyticsUsersAggregatesJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsUsersAggregatesJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UserAsyncAggregationQuery**](UserAsyncAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse.html)

<a name="postanalyticsusersaggregatesquery"></a>

## [**UserAggregateQueryResponse**](UserAggregateQueryResponse.html) PostAnalyticsUsersAggregatesQuery (UserAggregationQuery body)



Query for user aggregates

Requires ANY permissions: 

* analytics:userAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsUsersAggregatesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new UserAggregationQuery(); // UserAggregationQuery | query

            try
            { 
                // Query for user aggregates
                UserAggregateQueryResponse result = apiInstance.PostAnalyticsUsersAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsUsersAggregatesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UserAggregationQuery**](UserAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**UserAggregateQueryResponse**](UserAggregateQueryResponse.html)

<a name="postanalyticsusersdetailsjobs"></a>

## [**AsyncQueryResponse**](AsyncQueryResponse.html) PostAnalyticsUsersDetailsJobs (AsyncUserDetailsQuery body)



Query for user details asynchronously

Requires ANY permissions: 

* analytics:userDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsUsersDetailsJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new AsyncUserDetailsQuery(); // AsyncUserDetailsQuery | query

            try
            { 
                // Query for user details asynchronously
                AsyncQueryResponse result = apiInstance.PostAnalyticsUsersDetailsJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsUsersDetailsJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AsyncUserDetailsQuery**](AsyncUserDetailsQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse.html)

<a name="postanalyticsusersdetailsquery"></a>

## [**AnalyticsUserDetailsQueryResponse**](AnalyticsUserDetailsQueryResponse.html) PostAnalyticsUsersDetailsQuery (UserDetailsQuery body)



Query for user details

Requires ANY permissions: 

* analytics:userDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsUsersDetailsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new UserDetailsQuery(); // UserDetailsQuery | query

            try
            { 
                // Query for user details
                AnalyticsUserDetailsQueryResponse result = apiInstance.PostAnalyticsUsersDetailsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsUsersDetailsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UserDetailsQuery**](UserDetailsQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AnalyticsUserDetailsQueryResponse**](AnalyticsUserDetailsQueryResponse.html)

<a name="postanalyticsusersobservationsquery"></a>

## [**UserObservationQueryResponse**](UserObservationQueryResponse.html) PostAnalyticsUsersObservationsQuery (UserObservationQuery body)



Query for user observations

Requires ANY permissions: 

* analytics:userObservation:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsUsersObservationsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new UserObservationQuery(); // UserObservationQuery | query

            try
            { 
                // Query for user observations
                UserObservationQueryResponse result = apiInstance.PostAnalyticsUsersObservationsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsUsersObservationsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UserObservationQuery**](UserObservationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**UserObservationQueryResponse**](UserObservationQueryResponse.html)

<a name="putanalyticsdataretentionsettings"></a>

## [**AnalyticsDataRetentionResponse**](AnalyticsDataRetentionResponse.html) PutAnalyticsDataretentionSettings (UpdateAnalyticsDataRetentionRequest body)



Update analytics data retention setting

Requires ANY permissions: 

* analytics:dataRetention:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutAnalyticsDataretentionSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AnalyticsApi();
            var body = new UpdateAnalyticsDataRetentionRequest(); // UpdateAnalyticsDataRetentionRequest | retentionDays

            try
            { 
                // Update analytics data retention setting
                AnalyticsDataRetentionResponse result = apiInstance.PutAnalyticsDataretentionSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PutAnalyticsDataretentionSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UpdateAnalyticsDataRetentionRequest**](UpdateAnalyticsDataRetentionRequest.html)| retentionDays |  |
{: class="table table-striped"}

### Return type

[**AnalyticsDataRetentionResponse**](AnalyticsDataRetentionResponse.html)

