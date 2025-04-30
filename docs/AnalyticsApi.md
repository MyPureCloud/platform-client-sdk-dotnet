# AnalyticsApi

## PureCloudPlatform.Client.V2.Api.AnalyticsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteAnalyticsConversationsDetailsJob**](#DeleteAnalyticsConversationsDetailsJob) | **Delete** /api/v2/analytics/conversations/details/jobs/{jobId} | Delete/cancel an async details job |
| [**DeleteAnalyticsUsersDetailsJob**](#DeleteAnalyticsUsersDetailsJob) | **Delete** /api/v2/analytics/users/details/jobs/{jobId} | Delete/cancel an async request |
| [**GetAnalyticsActionsAggregatesJob**](#GetAnalyticsActionsAggregatesJob) | **Get** /api/v2/analytics/actions/aggregates/jobs/{jobId} | Get status for async query for action aggregates |
| [**GetAnalyticsActionsAggregatesJobResults**](#GetAnalyticsActionsAggregatesJobResults) | **Get** /api/v2/analytics/actions/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetAnalyticsAgentStatus**](#GetAnalyticsAgentStatus) | **Get** /api/v2/analytics/agents/{userId}/status | Get an agent and their active sessions by user ID |
| [**GetAnalyticsAgentcopilotsAggregatesJob**](#GetAnalyticsAgentcopilotsAggregatesJob) | **Get** /api/v2/analytics/agentcopilots/aggregates/jobs/{jobId} | Get status for async query for agent copilot aggregates |
| [**GetAnalyticsAgentcopilotsAggregatesJobResults**](#GetAnalyticsAgentcopilotsAggregatesJobResults) | **Get** /api/v2/analytics/agentcopilots/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetAnalyticsBotflowDivisionsReportingturns**](#GetAnalyticsBotflowDivisionsReportingturns) | **Get** /api/v2/analytics/botflows/{botFlowId}/divisions/reportingturns | Get Reporting Turns (division aware). |
| [**GetAnalyticsBotflowReportingturns**](#GetAnalyticsBotflowReportingturns) | **Get** /api/v2/analytics/botflows/{botFlowId}/reportingturns | Get Reporting Turns. |
| [**GetAnalyticsBotflowSessions**](#GetAnalyticsBotflowSessions) | **Get** /api/v2/analytics/botflows/{botFlowId}/sessions | Get Bot Flow Sessions. |
| [**GetAnalyticsBotsAggregatesJob**](#GetAnalyticsBotsAggregatesJob) | **Get** /api/v2/analytics/bots/aggregates/jobs/{jobId} | Get status for async query for bot aggregates |
| [**GetAnalyticsBotsAggregatesJobResults**](#GetAnalyticsBotsAggregatesJobResults) | **Get** /api/v2/analytics/bots/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetAnalyticsConversationDetails**](#GetAnalyticsConversationDetails) | **Get** /api/v2/analytics/conversations/{conversationId}/details | Get a conversation by id |
| [**GetAnalyticsConversationsAggregatesJob**](#GetAnalyticsConversationsAggregatesJob) | **Get** /api/v2/analytics/conversations/aggregates/jobs/{jobId} | Get status for async query for conversation aggregates |
| [**GetAnalyticsConversationsAggregatesJobResults**](#GetAnalyticsConversationsAggregatesJobResults) | **Get** /api/v2/analytics/conversations/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetAnalyticsConversationsDetails**](#GetAnalyticsConversationsDetails) | **Get** /api/v2/analytics/conversations/details | Gets multiple conversations by id |
| [**GetAnalyticsConversationsDetailsJob**](#GetAnalyticsConversationsDetailsJob) | **Get** /api/v2/analytics/conversations/details/jobs/{jobId} | Get status for async query for conversation details |
| [**GetAnalyticsConversationsDetailsJobResults**](#GetAnalyticsConversationsDetailsJobResults) | **Get** /api/v2/analytics/conversations/details/jobs/{jobId}/results | Fetch a page of results for an async details job |
| [**GetAnalyticsConversationsDetailsJobsAvailability**](#GetAnalyticsConversationsDetailsJobsAvailability) | **Get** /api/v2/analytics/conversations/details/jobs/availability | Lookup the datalake availability date and time |
| [**GetAnalyticsDataretentionSettings**](#GetAnalyticsDataretentionSettings) | **Get** /api/v2/analytics/dataretention/settings | Get analytics data retention setting |
| [**GetAnalyticsEvaluationsAggregatesJob**](#GetAnalyticsEvaluationsAggregatesJob) | **Get** /api/v2/analytics/evaluations/aggregates/jobs/{jobId} | Get status for async query for evaluation aggregates |
| [**GetAnalyticsEvaluationsAggregatesJobResults**](#GetAnalyticsEvaluationsAggregatesJobResults) | **Get** /api/v2/analytics/evaluations/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetAnalyticsFlowexecutionsAggregatesJob**](#GetAnalyticsFlowexecutionsAggregatesJob) | **Get** /api/v2/analytics/flowexecutions/aggregates/jobs/{jobId} | Get status for async query for flow execution aggregates |
| [**GetAnalyticsFlowexecutionsAggregatesJobResults**](#GetAnalyticsFlowexecutionsAggregatesJobResults) | **Get** /api/v2/analytics/flowexecutions/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetAnalyticsFlowsAggregatesJob**](#GetAnalyticsFlowsAggregatesJob) | **Get** /api/v2/analytics/flows/aggregates/jobs/{jobId} | Get status for async query for Flow aggregates |
| [**GetAnalyticsFlowsAggregatesJobResults**](#GetAnalyticsFlowsAggregatesJobResults) | **Get** /api/v2/analytics/flows/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetAnalyticsJourneysAggregatesJob**](#GetAnalyticsJourneysAggregatesJob) | **Get** /api/v2/analytics/journeys/aggregates/jobs/{jobId} | Get status for async query for journey aggregates |
| [**GetAnalyticsJourneysAggregatesJobResults**](#GetAnalyticsJourneysAggregatesJobResults) | **Get** /api/v2/analytics/journeys/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetAnalyticsKnowledgeAggregatesJob**](#GetAnalyticsKnowledgeAggregatesJob) | **Get** /api/v2/analytics/knowledge/aggregates/jobs/{jobId} | Get status for async query for knowledge aggregates |
| [**GetAnalyticsKnowledgeAggregatesJobResults**](#GetAnalyticsKnowledgeAggregatesJobResults) | **Get** /api/v2/analytics/knowledge/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetAnalyticsReportingDashboardsUser**](#GetAnalyticsReportingDashboardsUser) | **Get** /api/v2/analytics/reporting/dashboards/users/{userId} | Get dashboards summary for a user |
| [**GetAnalyticsReportingDashboardsUsers**](#GetAnalyticsReportingDashboardsUsers) | **Get** /api/v2/analytics/reporting/dashboards/users | Get dashboards summary for users in a org |
| [**GetAnalyticsReportingExports**](#GetAnalyticsReportingExports) | **Get** /api/v2/analytics/reporting/exports | Get all view export requests for a user |
| [**GetAnalyticsReportingExportsMetadata**](#GetAnalyticsReportingExportsMetadata) | **Get** /api/v2/analytics/reporting/exports/metadata | Get all export metadata |
| [**GetAnalyticsReportingSettings**](#GetAnalyticsReportingSettings) | **Get** /api/v2/analytics/reporting/settings | Get AnalyticsReportingSettings for an organization |
| [**GetAnalyticsReportingSettingsDashboardsQuery**](#GetAnalyticsReportingSettingsDashboardsQuery) | **Get** /api/v2/analytics/reporting/settings/dashboards/query | Get list of dashboard configurations |
| [**GetAnalyticsReportingSettingsUserDashboards**](#GetAnalyticsReportingSettingsUserDashboards) | **Get** /api/v2/analytics/reporting/settings/users/{userId}/dashboards | Get list of dashboards for an user |
| [**GetAnalyticsResolutionsAggregatesJob**](#GetAnalyticsResolutionsAggregatesJob) | **Get** /api/v2/analytics/resolutions/aggregates/jobs/{jobId} | Get status for async query for resolution aggregates |
| [**GetAnalyticsResolutionsAggregatesJobResults**](#GetAnalyticsResolutionsAggregatesJobResults) | **Get** /api/v2/analytics/resolutions/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetAnalyticsSummariesAggregatesJob**](#GetAnalyticsSummariesAggregatesJob) | **Get** /api/v2/analytics/summaries/aggregates/jobs/{jobId} | Get status for async query for summary aggregates |
| [**GetAnalyticsSummariesAggregatesJobResults**](#GetAnalyticsSummariesAggregatesJobResults) | **Get** /api/v2/analytics/summaries/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetAnalyticsSurveysAggregatesJob**](#GetAnalyticsSurveysAggregatesJob) | **Get** /api/v2/analytics/surveys/aggregates/jobs/{jobId} | Get status for async query for survey aggregates |
| [**GetAnalyticsSurveysAggregatesJobResults**](#GetAnalyticsSurveysAggregatesJobResults) | **Get** /api/v2/analytics/surveys/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetAnalyticsTaskmanagementAggregatesJob**](#GetAnalyticsTaskmanagementAggregatesJob) | **Get** /api/v2/analytics/taskmanagement/aggregates/jobs/{jobId} | Get status for async query for task management aggregates |
| [**GetAnalyticsTaskmanagementAggregatesJobResults**](#GetAnalyticsTaskmanagementAggregatesJobResults) | **Get** /api/v2/analytics/taskmanagement/aggregates/jobs/{jobId}/results | Fetch a page of results for an async task management query |
| [**GetAnalyticsTranscriptsAggregatesJob**](#GetAnalyticsTranscriptsAggregatesJob) | **Get** /api/v2/analytics/transcripts/aggregates/jobs/{jobId} | Get status for async query for transcript aggregates |
| [**GetAnalyticsTranscriptsAggregatesJobResults**](#GetAnalyticsTranscriptsAggregatesJobResults) | **Get** /api/v2/analytics/transcripts/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetAnalyticsUsersAggregatesJob**](#GetAnalyticsUsersAggregatesJob) | **Get** /api/v2/analytics/users/aggregates/jobs/{jobId} | Get status for async query for user aggregates |
| [**GetAnalyticsUsersAggregatesJobResults**](#GetAnalyticsUsersAggregatesJobResults) | **Get** /api/v2/analytics/users/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetAnalyticsUsersDetailsJob**](#GetAnalyticsUsersDetailsJob) | **Get** /api/v2/analytics/users/details/jobs/{jobId} | Get status for async query for user details |
| [**GetAnalyticsUsersDetailsJobResults**](#GetAnalyticsUsersDetailsJobResults) | **Get** /api/v2/analytics/users/details/jobs/{jobId}/results | Fetch a page of results for an async query |
| [**GetAnalyticsUsersDetailsJobsAvailability**](#GetAnalyticsUsersDetailsJobsAvailability) | **Get** /api/v2/analytics/users/details/jobs/availability | Lookup the datalake availability date and time |
| [**PatchAnalyticsReportingSettings**](#PatchAnalyticsReportingSettings) | **Patch** /api/v2/analytics/reporting/settings | Patch AnalyticsReportingSettings values for an organization |
| [**PostAnalyticsActionsAggregatesJobs**](#PostAnalyticsActionsAggregatesJobs) | **Post** /api/v2/analytics/actions/aggregates/jobs | Query for action aggregates asynchronously |
| [**PostAnalyticsActionsAggregatesQuery**](#PostAnalyticsActionsAggregatesQuery) | **Post** /api/v2/analytics/actions/aggregates/query | Query for action aggregates |
| [**PostAnalyticsAgentcopilotsAggregatesJobs**](#PostAnalyticsAgentcopilotsAggregatesJobs) | **Post** /api/v2/analytics/agentcopilots/aggregates/jobs | Query for agent copilot aggregates asynchronously |
| [**PostAnalyticsAgentcopilotsAggregatesQuery**](#PostAnalyticsAgentcopilotsAggregatesQuery) | **Post** /api/v2/analytics/agentcopilots/aggregates/query | Query for agent copilot aggregates |
| [**PostAnalyticsAgentsStatusCounts**](#PostAnalyticsAgentsStatusCounts) | **Post** /api/v2/analytics/agents/status/counts | Count agents by segment type |
| [**PostAnalyticsAgentsStatusQuery**](#PostAnalyticsAgentsStatusQuery) | **Post** /api/v2/analytics/agents/status/query | Retrieve the top 50 agents matching the query filters |
| [**PostAnalyticsBotsAggregatesJobs**](#PostAnalyticsBotsAggregatesJobs) | **Post** /api/v2/analytics/bots/aggregates/jobs | Query for bot aggregates asynchronously |
| [**PostAnalyticsBotsAggregatesQuery**](#PostAnalyticsBotsAggregatesQuery) | **Post** /api/v2/analytics/bots/aggregates/query | Query for bot aggregates |
| [**PostAnalyticsConversationDetailsProperties**](#PostAnalyticsConversationDetailsProperties) | **Post** /api/v2/analytics/conversations/{conversationId}/details/properties | Index conversation properties |
| [**PostAnalyticsConversationsActivityQuery**](#PostAnalyticsConversationsActivityQuery) | **Post** /api/v2/analytics/conversations/activity/query | Query for conversation activity observations |
| [**PostAnalyticsConversationsAggregatesJobs**](#PostAnalyticsConversationsAggregatesJobs) | **Post** /api/v2/analytics/conversations/aggregates/jobs | Query for conversation aggregates asynchronously |
| [**PostAnalyticsConversationsAggregatesQuery**](#PostAnalyticsConversationsAggregatesQuery) | **Post** /api/v2/analytics/conversations/aggregates/query | Query for conversation aggregates |
| [**PostAnalyticsConversationsDetailsJobs**](#PostAnalyticsConversationsDetailsJobs) | **Post** /api/v2/analytics/conversations/details/jobs | Query for conversation details asynchronously |
| [**PostAnalyticsConversationsDetailsQuery**](#PostAnalyticsConversationsDetailsQuery) | **Post** /api/v2/analytics/conversations/details/query | Query for conversation details |
| [**PostAnalyticsConversationsTranscriptsQuery**](#PostAnalyticsConversationsTranscriptsQuery) | **Post** /api/v2/analytics/conversations/transcripts/query | Search resources. |
| [**PostAnalyticsEvaluationsAggregatesJobs**](#PostAnalyticsEvaluationsAggregatesJobs) | **Post** /api/v2/analytics/evaluations/aggregates/jobs | Query for evaluation aggregates asynchronously |
| [**PostAnalyticsEvaluationsAggregatesQuery**](#PostAnalyticsEvaluationsAggregatesQuery) | **Post** /api/v2/analytics/evaluations/aggregates/query | Query for evaluation aggregates |
| [**PostAnalyticsFlowexecutionsAggregatesJobs**](#PostAnalyticsFlowexecutionsAggregatesJobs) | **Post** /api/v2/analytics/flowexecutions/aggregates/jobs | Query for flow execution aggregates asynchronously |
| [**PostAnalyticsFlowexecutionsAggregatesQuery**](#PostAnalyticsFlowexecutionsAggregatesQuery) | **Post** /api/v2/analytics/flowexecutions/aggregates/query | Query for flow execution aggregates |
| [**PostAnalyticsFlowsActivityQuery**](#PostAnalyticsFlowsActivityQuery) | **Post** /api/v2/analytics/flows/activity/query | Query for flow activity observations |
| [**PostAnalyticsFlowsAggregatesJobs**](#PostAnalyticsFlowsAggregatesJobs) | **Post** /api/v2/analytics/flows/aggregates/jobs | Query for flow aggregates asynchronously |
| [**PostAnalyticsFlowsAggregatesQuery**](#PostAnalyticsFlowsAggregatesQuery) | **Post** /api/v2/analytics/flows/aggregates/query | Query for flow aggregates |
| [**PostAnalyticsFlowsObservationsQuery**](#PostAnalyticsFlowsObservationsQuery) | **Post** /api/v2/analytics/flows/observations/query | Query for flow observations |
| [**PostAnalyticsJourneysAggregatesJobs**](#PostAnalyticsJourneysAggregatesJobs) | **Post** /api/v2/analytics/journeys/aggregates/jobs | Query for journey aggregates asynchronously |
| [**PostAnalyticsJourneysAggregatesQuery**](#PostAnalyticsJourneysAggregatesQuery) | **Post** /api/v2/analytics/journeys/aggregates/query | Query for journey aggregates |
| [**PostAnalyticsKnowledgeAggregatesJobs**](#PostAnalyticsKnowledgeAggregatesJobs) | **Post** /api/v2/analytics/knowledge/aggregates/jobs | Query for knowledge aggregates asynchronously |
| [**PostAnalyticsKnowledgeAggregatesQuery**](#PostAnalyticsKnowledgeAggregatesQuery) | **Post** /api/v2/analytics/knowledge/aggregates/query | Query for knowledge aggregates |
| [**PostAnalyticsQueuesObservationsQuery**](#PostAnalyticsQueuesObservationsQuery) | **Post** /api/v2/analytics/queues/observations/query | Query for queue observations |
| [**PostAnalyticsRatelimitsAggregatesQuery**](#PostAnalyticsRatelimitsAggregatesQuery) | **Post** /api/v2/analytics/ratelimits/aggregates/query | Query for limits rate limit aggregates. Data populated when limits reach 90% of the maximum. Not a source of truth for limits hit but a best effort estimate. |
| [**PostAnalyticsReportingDashboardsUsersBulkRemove**](#PostAnalyticsReportingDashboardsUsersBulkRemove) | **Post** /api/v2/analytics/reporting/dashboards/users/bulk/remove | Bulk soft delete dashboards owned by other user(s) |
| [**PostAnalyticsReportingExports**](#PostAnalyticsReportingExports) | **Post** /api/v2/analytics/reporting/exports | Generate a view export request |
| [**PostAnalyticsReportingSettingsDashboardsBulkRemove**](#PostAnalyticsReportingSettingsDashboardsBulkRemove) | **Post** /api/v2/analytics/reporting/settings/dashboards/bulk/remove | Bulk soft delete dashboard configurations |
| [**PostAnalyticsReportingSettingsDashboardsQuery**](#PostAnalyticsReportingSettingsDashboardsQuery) | **Post** /api/v2/analytics/reporting/settings/dashboards/query | Query dashboard configurations |
| [**PostAnalyticsResolutionsAggregatesJobs**](#PostAnalyticsResolutionsAggregatesJobs) | **Post** /api/v2/analytics/resolutions/aggregates/jobs | Query for resolution aggregates asynchronously |
| [**PostAnalyticsResolutionsAggregatesQuery**](#PostAnalyticsResolutionsAggregatesQuery) | **Post** /api/v2/analytics/resolutions/aggregates/query | Query for resolution aggregates |
| [**PostAnalyticsRoutingActivityQuery**](#PostAnalyticsRoutingActivityQuery) | **Post** /api/v2/analytics/routing/activity/query | Query for user activity observations |
| [**PostAnalyticsSummariesAggregatesJobs**](#PostAnalyticsSummariesAggregatesJobs) | **Post** /api/v2/analytics/summaries/aggregates/jobs | Query for summary aggregates asynchronously |
| [**PostAnalyticsSummariesAggregatesQuery**](#PostAnalyticsSummariesAggregatesQuery) | **Post** /api/v2/analytics/summaries/aggregates/query | Query for summary aggregates |
| [**PostAnalyticsSurveysAggregatesJobs**](#PostAnalyticsSurveysAggregatesJobs) | **Post** /api/v2/analytics/surveys/aggregates/jobs | Query for survey aggregates asynchronously |
| [**PostAnalyticsSurveysAggregatesQuery**](#PostAnalyticsSurveysAggregatesQuery) | **Post** /api/v2/analytics/surveys/aggregates/query | Query for survey aggregates |
| [**PostAnalyticsTaskmanagementAggregatesJobs**](#PostAnalyticsTaskmanagementAggregatesJobs) | **Post** /api/v2/analytics/taskmanagement/aggregates/jobs | Query for task management aggregates asynchronously |
| [**PostAnalyticsTaskmanagementAggregatesQuery**](#PostAnalyticsTaskmanagementAggregatesQuery) | **Post** /api/v2/analytics/taskmanagement/aggregates/query | Query for task management aggregates |
| [**PostAnalyticsTeamsActivityQuery**](#PostAnalyticsTeamsActivityQuery) | **Post** /api/v2/analytics/teams/activity/query | Query for team activity observations |
| [**PostAnalyticsTranscriptsAggregatesJobs**](#PostAnalyticsTranscriptsAggregatesJobs) | **Post** /api/v2/analytics/transcripts/aggregates/jobs | Query for transcript aggregates asynchronously |
| [**PostAnalyticsTranscriptsAggregatesQuery**](#PostAnalyticsTranscriptsAggregatesQuery) | **Post** /api/v2/analytics/transcripts/aggregates/query | Query for transcript aggregates |
| [**PostAnalyticsUsersActivityQuery**](#PostAnalyticsUsersActivityQuery) | **Post** /api/v2/analytics/users/activity/query | Query for user activity observations |
| [**PostAnalyticsUsersAggregatesJobs**](#PostAnalyticsUsersAggregatesJobs) | **Post** /api/v2/analytics/users/aggregates/jobs | Query for user aggregates asynchronously |
| [**PostAnalyticsUsersAggregatesQuery**](#PostAnalyticsUsersAggregatesQuery) | **Post** /api/v2/analytics/users/aggregates/query | Query for user aggregates |
| [**PostAnalyticsUsersDetailsJobs**](#PostAnalyticsUsersDetailsJobs) | **Post** /api/v2/analytics/users/details/jobs | Query for user details asynchronously |
| [**PostAnalyticsUsersDetailsQuery**](#PostAnalyticsUsersDetailsQuery) | **Post** /api/v2/analytics/users/details/query | Query for user details |
| [**PostAnalyticsUsersObservationsQuery**](#PostAnalyticsUsersObservationsQuery) | **Post** /api/v2/analytics/users/observations/query | Query for user observations |
| [**PutAnalyticsDataretentionSettings**](#PutAnalyticsDataretentionSettings) | **Put** /api/v2/analytics/dataretention/settings | Update analytics data retention setting |



## DeleteAnalyticsConversationsDetailsJob

> void DeleteAnalyticsConversationsDetailsJob (string jobId)


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

### Return type

void (empty response body)


## DeleteAnalyticsUsersDetailsJob

> void DeleteAnalyticsUsersDetailsJob (string jobId)


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

### Return type

void (empty response body)


## GetAnalyticsActionsAggregatesJob

> [**AsyncQueryStatus**](AsyncQueryStatus) GetAnalyticsActionsAggregatesJob (string jobId)


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

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus)


## GetAnalyticsActionsAggregatesJobResults

> [**ActionAsyncAggregateQueryResponse**](ActionAsyncAggregateQueryResponse) GetAnalyticsActionsAggregatesJobResults (string jobId, string cursor = null)


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

### Return type

[**ActionAsyncAggregateQueryResponse**](ActionAsyncAggregateQueryResponse)


## GetAnalyticsAgentStatus

> [**AnalyticsAgentStateAgentResponse**](AnalyticsAgentStateAgentResponse) GetAnalyticsAgentStatus (string userId)


Get an agent and their active sessions by user ID

Requires ANY permissions: 

* analytics:agentState:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsAgentStatusExample
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
            var userId = userId_example;  // string | userId

            try
            { 
                // Get an agent and their active sessions by user ID
                AnalyticsAgentStateAgentResponse result = apiInstance.GetAnalyticsAgentStatus(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsAgentStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| userId |  |

### Return type

[**AnalyticsAgentStateAgentResponse**](AnalyticsAgentStateAgentResponse)


## GetAnalyticsAgentcopilotsAggregatesJob

> [**AsyncQueryStatus**](AsyncQueryStatus) GetAnalyticsAgentcopilotsAggregatesJob (string jobId)


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

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus)


## GetAnalyticsAgentcopilotsAggregatesJobResults

> [**AgentCopilotAsyncAggregateQueryResponse**](AgentCopilotAsyncAggregateQueryResponse) GetAnalyticsAgentcopilotsAggregatesJobResults (string jobId, string cursor = null)


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

### Return type

[**AgentCopilotAsyncAggregateQueryResponse**](AgentCopilotAsyncAggregateQueryResponse)


## GetAnalyticsBotflowDivisionsReportingturns

> [**ReportingTurnsResponse**](ReportingTurnsResponse) GetAnalyticsBotflowDivisionsReportingturns (string botFlowId, string after = null, string pageSize = null, string interval = null, string actionId = null, string sessionId = null, string language = null, string askActionResults = null)


Get Reporting Turns (division aware).

Returns the reporting turns for the specified flow, filtered by the clients divisions and grouped by session, in reverse chronological order from the date the session was created, with the reporting turns from the most recent session appearing at the start of the list. It is expected that the client will URL encode the request URI once only. For pagination, clients should keep sending requests using the value of 'nextUri' in the response, until it's no longer present, only then have all items have been returned. The 'nextUri' value in the response is already URL encoded (so it doesn't need to be encoded again). Note: resources returned by this endpoint are not persisted indefinitely, as they are deleted after approximately, but not before, 10 days.

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
| **askActionResults** | **string**| Optional case-insensitive comma separated list of ask action results to filter the reporting turns. | [optional] <br />**Values**: AgentRequestedByUser, ConfirmationRequired, DisambiguationRequired, Error, ExpressionError, NoInputCollection, NoInputConfirmation, NoInputDisambiguation, NoMatchCollection, NoMatchConfirmation, NoMatchDisambiguation, SuccessCollection, SkippedCollection, SuccessConfirmationNo, SuccessConfirmationYes, SuccessDisambiguation, SuccessDisambiguationNone |

### Return type

[**ReportingTurnsResponse**](ReportingTurnsResponse)


## GetAnalyticsBotflowReportingturns

> [**ReportingTurnsResponse**](ReportingTurnsResponse) GetAnalyticsBotflowReportingturns (string botFlowId, string after = null, string pageSize = null, string interval = null, string actionId = null, string sessionId = null, string language = null, string askActionResults = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Get Reporting Turns.

Deprecated: Please use GET /analytics/botflows/{botFlowId}/divisions/reportingturns instead. Returns the reporting turns grouped by session, in reverse chronological order from the date the session was created, with the reporting turns from the most recent session appearing at the start of the list. It is expected that the client will URL encode the request URI once only. For pagination, clients should keep sending requests using the value of 'nextUri' in the response, until it's no longer present, only then have all items have been returned. The 'nextUri' value in the response is already URL encoded (so it doesn't need to be encoded again). Note: resources returned by this endpoint are not persisted indefinitely, as they are deleted after approximately, but not before, 10 days.

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
| **askActionResults** | **string**| Optional case-insensitive comma separated list of ask action results to filter the reporting turns. | [optional] <br />**Values**: AgentRequestedByUser, ConfirmationRequired, DisambiguationRequired, Error, ExpressionError, NoInputCollection, NoInputConfirmation, NoInputDisambiguation, NoMatchCollection, NoMatchConfirmation, NoMatchDisambiguation, SuccessCollection, SkippedCollection, SuccessConfirmationNo, SuccessConfirmationYes, SuccessDisambiguation, SuccessDisambiguationNone |

### Return type

[**ReportingTurnsResponse**](ReportingTurnsResponse)


## GetAnalyticsBotflowSessions

> [**SessionsResponse**](SessionsResponse) GetAnalyticsBotflowSessions (string botFlowId, string after = null, string pageSize = null, string interval = null, string botResultCategories = null, string endLanguage = null)


Get Bot Flow Sessions.

Returns the bot flow sessions in reverse chronological order from the date they were created. It is expected that the client will URL encode the request URI once only. For pagination, clients should keep sending requests using the value of 'nextUri' in the response, until it's no longer present, only then have all items have been returned. The 'nextUri' value in the response is already URL encoded (so it doesn't need to be encoded again). Note: resources returned by this endpoint are not persisted indefinitely, as they are deleted after approximately, but not before, 10 days.

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

### Return type

[**SessionsResponse**](SessionsResponse)


## GetAnalyticsBotsAggregatesJob

> [**AsyncQueryStatus**](AsyncQueryStatus) GetAnalyticsBotsAggregatesJob (string jobId)


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

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus)


## GetAnalyticsBotsAggregatesJobResults

> [**BotAsyncAggregateQueryResponse**](BotAsyncAggregateQueryResponse) GetAnalyticsBotsAggregatesJobResults (string jobId, string cursor = null)


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

### Return type

[**BotAsyncAggregateQueryResponse**](BotAsyncAggregateQueryResponse)


## GetAnalyticsConversationDetails

> [**AnalyticsConversationWithoutAttributes**](AnalyticsConversationWithoutAttributes) GetAnalyticsConversationDetails (string conversationId)


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

### Return type

[**AnalyticsConversationWithoutAttributes**](AnalyticsConversationWithoutAttributes)


## GetAnalyticsConversationsAggregatesJob

> [**AsyncQueryStatus**](AsyncQueryStatus) GetAnalyticsConversationsAggregatesJob (string jobId)


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

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus)


## GetAnalyticsConversationsAggregatesJobResults

> [**ConversationAsyncAggregateQueryResponse**](ConversationAsyncAggregateQueryResponse) GetAnalyticsConversationsAggregatesJobResults (string jobId, string cursor = null)


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

### Return type

[**ConversationAsyncAggregateQueryResponse**](ConversationAsyncAggregateQueryResponse)


## GetAnalyticsConversationsDetails

> [**AnalyticsConversationWithoutAttributesMultiGetResponse**](AnalyticsConversationWithoutAttributesMultiGetResponse) GetAnalyticsConversationsDetails (List<string> id = null)


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
| **id** | [**List<string>**](string)| Comma-separated conversation ids | [optional]  |

### Return type

[**AnalyticsConversationWithoutAttributesMultiGetResponse**](AnalyticsConversationWithoutAttributesMultiGetResponse)


## GetAnalyticsConversationsDetailsJob

> [**AsyncQueryStatus**](AsyncQueryStatus) GetAnalyticsConversationsDetailsJob (string jobId)


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

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus)


## GetAnalyticsConversationsDetailsJobResults

> [**AnalyticsConversationAsyncQueryResponse**](AnalyticsConversationAsyncQueryResponse) GetAnalyticsConversationsDetailsJobResults (string jobId, string cursor = null, int? pageSize = null)


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

### Return type

[**AnalyticsConversationAsyncQueryResponse**](AnalyticsConversationAsyncQueryResponse)


## GetAnalyticsConversationsDetailsJobsAvailability

> [**DataAvailabilityResponse**](DataAvailabilityResponse) GetAnalyticsConversationsDetailsJobsAvailability ()


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

[**DataAvailabilityResponse**](DataAvailabilityResponse)


## GetAnalyticsDataretentionSettings

> [**AnalyticsDataRetentionResponse**](AnalyticsDataRetentionResponse) GetAnalyticsDataretentionSettings ()


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

[**AnalyticsDataRetentionResponse**](AnalyticsDataRetentionResponse)


## GetAnalyticsEvaluationsAggregatesJob

> [**AsyncQueryStatus**](AsyncQueryStatus) GetAnalyticsEvaluationsAggregatesJob (string jobId)


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

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus)


## GetAnalyticsEvaluationsAggregatesJobResults

> [**EvaluationAsyncAggregateQueryResponse**](EvaluationAsyncAggregateQueryResponse) GetAnalyticsEvaluationsAggregatesJobResults (string jobId, string cursor = null)


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

### Return type

[**EvaluationAsyncAggregateQueryResponse**](EvaluationAsyncAggregateQueryResponse)


## GetAnalyticsFlowexecutionsAggregatesJob

> [**AsyncQueryStatus**](AsyncQueryStatus) GetAnalyticsFlowexecutionsAggregatesJob (string jobId)


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

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus)


## GetAnalyticsFlowexecutionsAggregatesJobResults

> [**FlowExecutionAsyncAggregateQueryResponse**](FlowExecutionAsyncAggregateQueryResponse) GetAnalyticsFlowexecutionsAggregatesJobResults (string jobId, string cursor = null)


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

### Return type

[**FlowExecutionAsyncAggregateQueryResponse**](FlowExecutionAsyncAggregateQueryResponse)


## GetAnalyticsFlowsAggregatesJob

> [**AsyncQueryStatus**](AsyncQueryStatus) GetAnalyticsFlowsAggregatesJob (string jobId)


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

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus)


## GetAnalyticsFlowsAggregatesJobResults

> [**FlowAsyncAggregateQueryResponse**](FlowAsyncAggregateQueryResponse) GetAnalyticsFlowsAggregatesJobResults (string jobId, string cursor = null)


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

### Return type

[**FlowAsyncAggregateQueryResponse**](FlowAsyncAggregateQueryResponse)


## GetAnalyticsJourneysAggregatesJob

> [**AsyncQueryStatus**](AsyncQueryStatus) GetAnalyticsJourneysAggregatesJob (string jobId)


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

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus)


## GetAnalyticsJourneysAggregatesJobResults

> [**JourneyAsyncAggregateQueryResponse**](JourneyAsyncAggregateQueryResponse) GetAnalyticsJourneysAggregatesJobResults (string jobId, string cursor = null)


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

### Return type

[**JourneyAsyncAggregateQueryResponse**](JourneyAsyncAggregateQueryResponse)


## GetAnalyticsKnowledgeAggregatesJob

> [**AsyncQueryStatus**](AsyncQueryStatus) GetAnalyticsKnowledgeAggregatesJob (string jobId)


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

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus)


## GetAnalyticsKnowledgeAggregatesJobResults

> [**KnowledgeAsyncAggregateQueryResponse**](KnowledgeAsyncAggregateQueryResponse) GetAnalyticsKnowledgeAggregatesJobResults (string jobId, string cursor = null)


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

### Return type

[**KnowledgeAsyncAggregateQueryResponse**](KnowledgeAsyncAggregateQueryResponse)


## GetAnalyticsReportingDashboardsUser

> [**DashboardUser**](DashboardUser) GetAnalyticsReportingDashboardsUser (string userId)


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

### Return type

[**DashboardUser**](DashboardUser)


## GetAnalyticsReportingDashboardsUsers

> [**DashboardUserListing**](DashboardUserListing) GetAnalyticsReportingDashboardsUsers (string sortBy = null, int? pageNumber = null, int? pageSize = null, List<string> id = null, string state = null, bool? deletedOnly = null)


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
            var deletedOnly = true;  // bool? | Only list users with deleted dashboards (optional) 

            try
            { 
                // Get dashboards summary for users in a org
                DashboardUserListing result = apiInstance.GetAnalyticsReportingDashboardsUsers(sortBy, pageNumber, pageSize, id, state, deletedOnly);
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
| **id** | [**List<string>**](string)| A list of user IDs to fetch by bulk | [optional]  |
| **state** | **string**| Only list users of this state | [optional] <br />**Values**: active, inactive |
| **deletedOnly** | **bool?**| Only list users with deleted dashboards | [optional]  |

### Return type

[**DashboardUserListing**](DashboardUserListing)


## GetAnalyticsReportingExports

> [**ReportingExportJobListing**](ReportingExportJobListing) GetAnalyticsReportingExports (int? pageNumber = null, int? pageSize = null)


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

### Return type

[**ReportingExportJobListing**](ReportingExportJobListing)


## GetAnalyticsReportingExportsMetadata

> [**ReportingExportMetadataJobListing**](ReportingExportMetadataJobListing) GetAnalyticsReportingExportsMetadata ()


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

[**ReportingExportMetadataJobListing**](ReportingExportMetadataJobListing)


## GetAnalyticsReportingSettings

> [**AnalyticsReportingSettings**](AnalyticsReportingSettings) GetAnalyticsReportingSettings ()


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

[**AnalyticsReportingSettings**](AnalyticsReportingSettings)


## GetAnalyticsReportingSettingsDashboardsQuery

> [**DashboardConfigurationListing**](DashboardConfigurationListing) GetAnalyticsReportingSettingsDashboardsQuery (string dashboardType, string dashboardAccessFilter, string name = null, string dashboardState = null, string sortBy = null, int? pageNumber = null, int? pageSize = null)


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
            var name = name_example;  // string | name of the dashboard (optional) 
            var dashboardState = dashboardState_example;  // string | List dashboard of given state (optional)  (default to Active)
            var sortBy = sortBy_example;  // string |  (optional)  (default to "desc")
            var pageNumber = 56;  // int? |  (optional)  (default to 1)
            var pageSize = 56;  // int? |  (optional)  (default to 9)

            try
            { 
                // Get list of dashboard configurations
                DashboardConfigurationListing result = apiInstance.GetAnalyticsReportingSettingsDashboardsQuery(dashboardType, dashboardAccessFilter, name, dashboardState, sortBy, pageNumber, pageSize);
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
| **name** | **string**| name of the dashboard | [optional]  |
| **dashboardState** | **string**| List dashboard of given state | [optional] [default to Active]<br />**Values**: Active, Deleted |
| **sortBy** | **string**|  | [optional] [default to "desc"] |
| **pageNumber** | **int?**|  | [optional] [default to 1] |
| **pageSize** | **int?**|  | [optional] [default to 9] |

### Return type

[**DashboardConfigurationListing**](DashboardConfigurationListing)


## GetAnalyticsReportingSettingsUserDashboards

> [**DashboardConfigurationListing**](DashboardConfigurationListing) GetAnalyticsReportingSettingsUserDashboards (string userId, string sortBy = null, int? pageNumber = null, int? pageSize = null, bool? publicOnly = null, bool? favoriteOnly = null, bool? deletedOnly = null, string name = null)


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
            var deletedOnly = true;  // bool? | If true, retrieve only deleted dashboards that are still recoverable (optional) 
            var name = name_example;  // string | retrieve dashboards that match with given name (optional) 

            try
            { 
                // Get list of dashboards for an user
                DashboardConfigurationListing result = apiInstance.GetAnalyticsReportingSettingsUserDashboards(userId, sortBy, pageNumber, pageSize, publicOnly, favoriteOnly, deletedOnly, name);
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
| **deletedOnly** | **bool?**| If true, retrieve only deleted dashboards that are still recoverable | [optional]  |
| **name** | **string**| retrieve dashboards that match with given name | [optional]  |

### Return type

[**DashboardConfigurationListing**](DashboardConfigurationListing)


## GetAnalyticsResolutionsAggregatesJob

> [**AsyncQueryStatus**](AsyncQueryStatus) GetAnalyticsResolutionsAggregatesJob (string jobId)


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

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus)


## GetAnalyticsResolutionsAggregatesJobResults

> [**ResolutionAsyncAggregateQueryResponse**](ResolutionAsyncAggregateQueryResponse) GetAnalyticsResolutionsAggregatesJobResults (string jobId, string cursor = null)


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

### Return type

[**ResolutionAsyncAggregateQueryResponse**](ResolutionAsyncAggregateQueryResponse)


## GetAnalyticsSummariesAggregatesJob

> [**AsyncQueryStatus**](AsyncQueryStatus) GetAnalyticsSummariesAggregatesJob (string jobId)


Get status for async query for summary aggregates

GetAnalyticsSummariesAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:summaryAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsSummariesAggregatesJobExample
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
                // Get status for async query for summary aggregates
                AsyncQueryStatus result = apiInstance.GetAnalyticsSummariesAggregatesJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsSummariesAggregatesJob: " + e.Message );
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

[**AsyncQueryStatus**](AsyncQueryStatus)


## GetAnalyticsSummariesAggregatesJobResults

> [**SummaryAsyncAggregateQueryResponse**](SummaryAsyncAggregateQueryResponse) GetAnalyticsSummariesAggregatesJobResults (string jobId, string cursor = null)


Fetch a page of results for an async aggregates query

GetAnalyticsSummariesAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:summaryAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsSummariesAggregatesJobResultsExample
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
                SummaryAsyncAggregateQueryResponse result = apiInstance.GetAnalyticsSummariesAggregatesJobResults(jobId, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsSummariesAggregatesJobResults: " + e.Message );
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

### Return type

[**SummaryAsyncAggregateQueryResponse**](SummaryAsyncAggregateQueryResponse)


## GetAnalyticsSurveysAggregatesJob

> [**AsyncQueryStatus**](AsyncQueryStatus) GetAnalyticsSurveysAggregatesJob (string jobId)


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

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus)


## GetAnalyticsSurveysAggregatesJobResults

> [**SurveyAsyncAggregateQueryResponse**](SurveyAsyncAggregateQueryResponse) GetAnalyticsSurveysAggregatesJobResults (string jobId, string cursor = null)


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

### Return type

[**SurveyAsyncAggregateQueryResponse**](SurveyAsyncAggregateQueryResponse)


## GetAnalyticsTaskmanagementAggregatesJob

> [**AsyncQueryStatus**](AsyncQueryStatus) GetAnalyticsTaskmanagementAggregatesJob (string jobId)


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

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus)


## GetAnalyticsTaskmanagementAggregatesJobResults

> [**TaskManagementAsyncAggregateQueryResponse**](TaskManagementAsyncAggregateQueryResponse) GetAnalyticsTaskmanagementAggregatesJobResults (string jobId, string cursor = null)


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

### Return type

[**TaskManagementAsyncAggregateQueryResponse**](TaskManagementAsyncAggregateQueryResponse)


## GetAnalyticsTranscriptsAggregatesJob

> [**AsyncQueryStatus**](AsyncQueryStatus) GetAnalyticsTranscriptsAggregatesJob (string jobId)


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

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus)


## GetAnalyticsTranscriptsAggregatesJobResults

> [**TranscriptAsyncAggregateQueryResponse**](TranscriptAsyncAggregateQueryResponse) GetAnalyticsTranscriptsAggregatesJobResults (string jobId, string cursor = null)


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

### Return type

[**TranscriptAsyncAggregateQueryResponse**](TranscriptAsyncAggregateQueryResponse)


## GetAnalyticsUsersAggregatesJob

> [**AsyncQueryStatus**](AsyncQueryStatus) GetAnalyticsUsersAggregatesJob (string jobId)


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

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus)


## GetAnalyticsUsersAggregatesJobResults

> [**UserAsyncAggregateQueryResponse**](UserAsyncAggregateQueryResponse) GetAnalyticsUsersAggregatesJobResults (string jobId, string cursor = null)


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

### Return type

[**UserAsyncAggregateQueryResponse**](UserAsyncAggregateQueryResponse)


## GetAnalyticsUsersDetailsJob

> [**AsyncQueryStatus**](AsyncQueryStatus) GetAnalyticsUsersDetailsJob (string jobId)


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

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus)


## GetAnalyticsUsersDetailsJobResults

> [**AnalyticsUserDetailsAsyncQueryResponse**](AnalyticsUserDetailsAsyncQueryResponse) GetAnalyticsUsersDetailsJobResults (string jobId, string cursor = null, int? pageSize = null)


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

### Return type

[**AnalyticsUserDetailsAsyncQueryResponse**](AnalyticsUserDetailsAsyncQueryResponse)


## GetAnalyticsUsersDetailsJobsAvailability

> [**DataAvailabilityResponse**](DataAvailabilityResponse) GetAnalyticsUsersDetailsJobsAvailability ()


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

[**DataAvailabilityResponse**](DataAvailabilityResponse)


## PatchAnalyticsReportingSettings

> [**AnalyticsReportingSettings**](AnalyticsReportingSettings) PatchAnalyticsReportingSettings (AnalyticsReportingSettings body)


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
| **body** | [**AnalyticsReportingSettings**](AnalyticsReportingSettings)| AnalyticsReportingSettingsRequest |  |

### Return type

[**AnalyticsReportingSettings**](AnalyticsReportingSettings)


## PostAnalyticsActionsAggregatesJobs

> [**AsyncQueryResponse**](AsyncQueryResponse) PostAnalyticsActionsAggregatesJobs (ActionAsyncAggregationQuery body)


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
| **body** | [**ActionAsyncAggregationQuery**](ActionAsyncAggregationQuery)| query |  |

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse)


## PostAnalyticsActionsAggregatesQuery

> [**ActionAggregateQueryResponse**](ActionAggregateQueryResponse) PostAnalyticsActionsAggregatesQuery (ActionAggregationQuery body)


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
| **body** | [**ActionAggregationQuery**](ActionAggregationQuery)| query |  |

### Return type

[**ActionAggregateQueryResponse**](ActionAggregateQueryResponse)


## PostAnalyticsAgentcopilotsAggregatesJobs

> [**AsyncQueryResponse**](AsyncQueryResponse) PostAnalyticsAgentcopilotsAggregatesJobs (AgentCopilotAsyncAggregationQuery body)


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
| **body** | [**AgentCopilotAsyncAggregationQuery**](AgentCopilotAsyncAggregationQuery)| query |  |

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse)


## PostAnalyticsAgentcopilotsAggregatesQuery

> [**AgentCopilotAggregateQueryResponse**](AgentCopilotAggregateQueryResponse) PostAnalyticsAgentcopilotsAggregatesQuery (AgentCopilotAggregationQuery body)


Query for agent copilot aggregates

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
| **body** | [**AgentCopilotAggregationQuery**](AgentCopilotAggregationQuery)| query |  |

### Return type

[**AgentCopilotAggregateQueryResponse**](AgentCopilotAggregateQueryResponse)


## PostAnalyticsAgentsStatusCounts

> [**AnalyticsAgentStateCountsResponse**](AnalyticsAgentStateCountsResponse) PostAnalyticsAgentsStatusCounts (AgentStateCountsRequest body)


Count agents by segment type

Requires ANY permissions: 

* analytics:agentState:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsAgentsStatusCountsExample
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
            var body = new AgentStateCountsRequest(); // AgentStateCountsRequest | query

            try
            { 
                // Count agents by segment type
                AnalyticsAgentStateCountsResponse result = apiInstance.PostAnalyticsAgentsStatusCounts(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsAgentsStatusCounts: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AgentStateCountsRequest**](AgentStateCountsRequest)| query |  |

### Return type

[**AnalyticsAgentStateCountsResponse**](AnalyticsAgentStateCountsResponse)


## PostAnalyticsAgentsStatusQuery

> [**AnalyticsAgentStateQueryResponse**](AnalyticsAgentStateQueryResponse) PostAnalyticsAgentsStatusQuery (AgentStateQueryRequest body)


Retrieve the top 50 agents matching the query filters

Requires ANY permissions: 

* analytics:agentState:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsAgentsStatusQueryExample
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
            var body = new AgentStateQueryRequest(); // AgentStateQueryRequest | query

            try
            { 
                // Retrieve the top 50 agents matching the query filters
                AnalyticsAgentStateQueryResponse result = apiInstance.PostAnalyticsAgentsStatusQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsAgentsStatusQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AgentStateQueryRequest**](AgentStateQueryRequest)| query |  |

### Return type

[**AnalyticsAgentStateQueryResponse**](AnalyticsAgentStateQueryResponse)


## PostAnalyticsBotsAggregatesJobs

> [**AsyncQueryResponse**](AsyncQueryResponse) PostAnalyticsBotsAggregatesJobs (BotAsyncAggregationQuery body)


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
| **body** | [**BotAsyncAggregationQuery**](BotAsyncAggregationQuery)| query |  |

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse)


## PostAnalyticsBotsAggregatesQuery

> [**BotAggregateQueryResponse**](BotAggregateQueryResponse) PostAnalyticsBotsAggregatesQuery (BotAggregationQuery body)


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
| **body** | [**BotAggregationQuery**](BotAggregationQuery)| query |  |

### Return type

[**BotAggregateQueryResponse**](BotAggregateQueryResponse)


## PostAnalyticsConversationDetailsProperties

> [**PropertyIndexRequest**](PropertyIndexRequest) PostAnalyticsConversationDetailsProperties (string conversationId, PropertyIndexRequest body)


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
| **body** | [**PropertyIndexRequest**](PropertyIndexRequest)| request |  |

### Return type

[**PropertyIndexRequest**](PropertyIndexRequest)


## PostAnalyticsConversationsActivityQuery

> [**ConversationActivityResponse**](ConversationActivityResponse) PostAnalyticsConversationsActivityQuery (ConversationActivityQuery body, int? pageSize = null, int? pageNumber = null)


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
| **body** | [**ConversationActivityQuery**](ConversationActivityQuery)| query |  |
| **pageSize** | **int?**| The desired page size | [optional]  |
| **pageNumber** | **int?**| The desired page number | [optional]  |

### Return type

[**ConversationActivityResponse**](ConversationActivityResponse)


## PostAnalyticsConversationsAggregatesJobs

> [**AsyncQueryResponse**](AsyncQueryResponse) PostAnalyticsConversationsAggregatesJobs (ConversationAsyncAggregationQuery body)


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
| **body** | [**ConversationAsyncAggregationQuery**](ConversationAsyncAggregationQuery)| query |  |

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse)


## PostAnalyticsConversationsAggregatesQuery

> [**ConversationAggregateQueryResponse**](ConversationAggregateQueryResponse) PostAnalyticsConversationsAggregatesQuery (ConversationAggregationQuery body)


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
| **body** | [**ConversationAggregationQuery**](ConversationAggregationQuery)| query |  |

### Return type

[**ConversationAggregateQueryResponse**](ConversationAggregateQueryResponse)


## PostAnalyticsConversationsDetailsJobs

> [**AsyncQueryResponse**](AsyncQueryResponse) PostAnalyticsConversationsDetailsJobs (AsyncConversationQuery body)


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
| **body** | [**AsyncConversationQuery**](AsyncConversationQuery)| query |  |

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse)


## PostAnalyticsConversationsDetailsQuery

> [**AnalyticsConversationQueryResponse**](AnalyticsConversationQueryResponse) PostAnalyticsConversationsDetailsQuery (ConversationQuery body)


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
| **body** | [**ConversationQuery**](ConversationQuery)| query |  |

### Return type

[**AnalyticsConversationQueryResponse**](AnalyticsConversationQueryResponse)


## PostAnalyticsConversationsTranscriptsQuery

> [**AnalyticsConversationWithoutAttributesMultiGetResponse**](AnalyticsConversationWithoutAttributesMultiGetResponse) PostAnalyticsConversationsTranscriptsQuery (TranscriptConversationDetailSearchRequest body)


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
| **body** | [**TranscriptConversationDetailSearchRequest**](TranscriptConversationDetailSearchRequest)| Search request options |  |

### Return type

[**AnalyticsConversationWithoutAttributesMultiGetResponse**](AnalyticsConversationWithoutAttributesMultiGetResponse)


## PostAnalyticsEvaluationsAggregatesJobs

> [**AsyncQueryResponse**](AsyncQueryResponse) PostAnalyticsEvaluationsAggregatesJobs (EvaluationAsyncAggregationQuery body)


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
| **body** | [**EvaluationAsyncAggregationQuery**](EvaluationAsyncAggregationQuery)| query |  |

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse)


## PostAnalyticsEvaluationsAggregatesQuery

> [**EvaluationAggregateQueryResponse**](EvaluationAggregateQueryResponse) PostAnalyticsEvaluationsAggregatesQuery (EvaluationAggregationQuery body)


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
| **body** | [**EvaluationAggregationQuery**](EvaluationAggregationQuery)| query |  |

### Return type

[**EvaluationAggregateQueryResponse**](EvaluationAggregateQueryResponse)


## PostAnalyticsFlowexecutionsAggregatesJobs

> [**AsyncQueryResponse**](AsyncQueryResponse) PostAnalyticsFlowexecutionsAggregatesJobs (FlowExecutionAsyncAggregationQuery body)


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
| **body** | [**FlowExecutionAsyncAggregationQuery**](FlowExecutionAsyncAggregationQuery)| query |  |

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse)


## PostAnalyticsFlowexecutionsAggregatesQuery

> [**FlowExecutionAggregateQueryResponse**](FlowExecutionAggregateQueryResponse) PostAnalyticsFlowexecutionsAggregatesQuery (FlowExecutionAggregationQuery body)


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
| **body** | [**FlowExecutionAggregationQuery**](FlowExecutionAggregationQuery)| query |  |

### Return type

[**FlowExecutionAggregateQueryResponse**](FlowExecutionAggregateQueryResponse)


## PostAnalyticsFlowsActivityQuery

> [**FlowActivityResponse**](FlowActivityResponse) PostAnalyticsFlowsActivityQuery (FlowActivityQuery body, int? pageSize = null, int? pageNumber = null)


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
| **body** | [**FlowActivityQuery**](FlowActivityQuery)| query |  |
| **pageSize** | **int?**| The desired page size | [optional]  |
| **pageNumber** | **int?**| The desired page number | [optional]  |

### Return type

[**FlowActivityResponse**](FlowActivityResponse)


## PostAnalyticsFlowsAggregatesJobs

> [**AsyncQueryResponse**](AsyncQueryResponse) PostAnalyticsFlowsAggregatesJobs (FlowAsyncAggregationQuery body)


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
| **body** | [**FlowAsyncAggregationQuery**](FlowAsyncAggregationQuery)| query |  |

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse)


## PostAnalyticsFlowsAggregatesQuery

> [**FlowAggregateQueryResponse**](FlowAggregateQueryResponse) PostAnalyticsFlowsAggregatesQuery (FlowAggregationQuery body)


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
| **body** | [**FlowAggregationQuery**](FlowAggregationQuery)| query |  |

### Return type

[**FlowAggregateQueryResponse**](FlowAggregateQueryResponse)


## PostAnalyticsFlowsObservationsQuery

> [**FlowObservationQueryResponse**](FlowObservationQueryResponse) PostAnalyticsFlowsObservationsQuery (FlowObservationQuery body)


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
| **body** | [**FlowObservationQuery**](FlowObservationQuery)| query |  |

### Return type

[**FlowObservationQueryResponse**](FlowObservationQueryResponse)


## PostAnalyticsJourneysAggregatesJobs

> [**AsyncQueryResponse**](AsyncQueryResponse) PostAnalyticsJourneysAggregatesJobs (JourneyAsyncAggregationQuery body)


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
| **body** | [**JourneyAsyncAggregationQuery**](JourneyAsyncAggregationQuery)| query |  |

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse)


## PostAnalyticsJourneysAggregatesQuery

> [**JourneyAggregateQueryResponse**](JourneyAggregateQueryResponse) PostAnalyticsJourneysAggregatesQuery (JourneyAggregationQuery body)


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
| **body** | [**JourneyAggregationQuery**](JourneyAggregationQuery)| query |  |

### Return type

[**JourneyAggregateQueryResponse**](JourneyAggregateQueryResponse)


## PostAnalyticsKnowledgeAggregatesJobs

> [**AsyncQueryResponse**](AsyncQueryResponse) PostAnalyticsKnowledgeAggregatesJobs (KnowledgeAsyncAggregationQuery body)


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
| **body** | [**KnowledgeAsyncAggregationQuery**](KnowledgeAsyncAggregationQuery)| query |  |

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse)


## PostAnalyticsKnowledgeAggregatesQuery

> [**KnowledgeAggregateQueryResponse**](KnowledgeAggregateQueryResponse) PostAnalyticsKnowledgeAggregatesQuery (KnowledgeAggregationQuery body)


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
| **body** | [**KnowledgeAggregationQuery**](KnowledgeAggregationQuery)| query |  |

### Return type

[**KnowledgeAggregateQueryResponse**](KnowledgeAggregateQueryResponse)


## PostAnalyticsQueuesObservationsQuery

> [**QueueObservationQueryResponse**](QueueObservationQueryResponse) PostAnalyticsQueuesObservationsQuery (QueueObservationQuery body)


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
| **body** | [**QueueObservationQuery**](QueueObservationQuery)| query |  |

### Return type

[**QueueObservationQueryResponse**](QueueObservationQueryResponse)


## PostAnalyticsRatelimitsAggregatesQuery

> [**RateLimitAggregateQueryResponse**](RateLimitAggregateQueryResponse) PostAnalyticsRatelimitsAggregatesQuery (RateLimitAggregationQuery body)


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
| **body** | [**RateLimitAggregationQuery**](RateLimitAggregationQuery)| query |  |

### Return type

[**RateLimitAggregateQueryResponse**](RateLimitAggregateQueryResponse)


## PostAnalyticsReportingDashboardsUsersBulkRemove

> void PostAnalyticsReportingDashboardsUsersBulkRemove (List<string> body)


Bulk soft delete dashboards owned by other user(s)

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
                // Bulk soft delete dashboards owned by other user(s)
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
| **body** | [**List<string>**](string)| List of userIds |  |

### Return type

void (empty response body)


## PostAnalyticsReportingExports

> [**ReportingExportJobResponse**](ReportingExportJobResponse) PostAnalyticsReportingExports (ReportingExportJobRequest body)


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
| **body** | [**ReportingExportJobRequest**](ReportingExportJobRequest)| ReportingExportJobRequest |  |

### Return type

[**ReportingExportJobResponse**](ReportingExportJobResponse)


## PostAnalyticsReportingSettingsDashboardsBulkRemove

> void PostAnalyticsReportingSettingsDashboardsBulkRemove (DashboardConfigurationBulkRequest body)


Bulk soft delete dashboard configurations

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
                // Bulk soft delete dashboard configurations
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
| **body** | [**DashboardConfigurationBulkRequest**](DashboardConfigurationBulkRequest)|  |  |

### Return type

void (empty response body)


## PostAnalyticsReportingSettingsDashboardsQuery

> [**DashboardConfigurationListing**](DashboardConfigurationListing) PostAnalyticsReportingSettingsDashboardsQuery (DashboardConfigurationQueryRequest body)


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
| **body** | [**DashboardConfigurationQueryRequest**](DashboardConfigurationQueryRequest)|  |  |

### Return type

[**DashboardConfigurationListing**](DashboardConfigurationListing)


## PostAnalyticsResolutionsAggregatesJobs

> [**AsyncQueryResponse**](AsyncQueryResponse) PostAnalyticsResolutionsAggregatesJobs (ResolutionAsyncAggregationQuery body)


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
| **body** | [**ResolutionAsyncAggregationQuery**](ResolutionAsyncAggregationQuery)| query |  |

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse)


## PostAnalyticsResolutionsAggregatesQuery

> [**ResolutionAggregateQueryResponse**](ResolutionAggregateQueryResponse) PostAnalyticsResolutionsAggregatesQuery (ResolutionAggregationQuery body)


Query for resolution aggregates

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
    public class PostAnalyticsResolutionsAggregatesQueryExample
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
            var body = new ResolutionAggregationQuery(); // ResolutionAggregationQuery | query

            try
            { 
                // Query for resolution aggregates
                ResolutionAggregateQueryResponse result = apiInstance.PostAnalyticsResolutionsAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsResolutionsAggregatesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ResolutionAggregationQuery**](ResolutionAggregationQuery)| query |  |

### Return type

[**ResolutionAggregateQueryResponse**](ResolutionAggregateQueryResponse)


## PostAnalyticsRoutingActivityQuery

> [**RoutingActivityResponse**](RoutingActivityResponse) PostAnalyticsRoutingActivityQuery (RoutingActivityQuery body, int? pageSize = null, int? pageNumber = null)


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
| **body** | [**RoutingActivityQuery**](RoutingActivityQuery)| query |  |
| **pageSize** | **int?**| The desired page size | [optional]  |
| **pageNumber** | **int?**| The desired page number | [optional]  |

### Return type

[**RoutingActivityResponse**](RoutingActivityResponse)


## PostAnalyticsSummariesAggregatesJobs

> [**AsyncQueryResponse**](AsyncQueryResponse) PostAnalyticsSummariesAggregatesJobs (SummaryAsyncAggregationQuery body)


Query for summary aggregates asynchronously

PostAnalyticsSummariesAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:summaryAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsSummariesAggregatesJobsExample
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
            var body = new SummaryAsyncAggregationQuery(); // SummaryAsyncAggregationQuery | query

            try
            { 
                // Query for summary aggregates asynchronously
                AsyncQueryResponse result = apiInstance.PostAnalyticsSummariesAggregatesJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsSummariesAggregatesJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SummaryAsyncAggregationQuery**](SummaryAsyncAggregationQuery)| query |  |

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse)


## PostAnalyticsSummariesAggregatesQuery

> [**SummaryAggregateQueryResponse**](SummaryAggregateQueryResponse) PostAnalyticsSummariesAggregatesQuery (SummaryAggregationQuery body)


Query for summary aggregates

Requires ANY permissions: 

* analytics:summaryAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsSummariesAggregatesQueryExample
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
            var body = new SummaryAggregationQuery(); // SummaryAggregationQuery | query

            try
            { 
                // Query for summary aggregates
                SummaryAggregateQueryResponse result = apiInstance.PostAnalyticsSummariesAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsSummariesAggregatesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SummaryAggregationQuery**](SummaryAggregationQuery)| query |  |

### Return type

[**SummaryAggregateQueryResponse**](SummaryAggregateQueryResponse)


## PostAnalyticsSurveysAggregatesJobs

> [**AsyncQueryResponse**](AsyncQueryResponse) PostAnalyticsSurveysAggregatesJobs (SurveyAsyncAggregationQuery body)


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
| **body** | [**SurveyAsyncAggregationQuery**](SurveyAsyncAggregationQuery)| query |  |

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse)


## PostAnalyticsSurveysAggregatesQuery

> [**SurveyAggregateQueryResponse**](SurveyAggregateQueryResponse) PostAnalyticsSurveysAggregatesQuery (SurveyAggregationQuery body)


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
| **body** | [**SurveyAggregationQuery**](SurveyAggregationQuery)| query |  |

### Return type

[**SurveyAggregateQueryResponse**](SurveyAggregateQueryResponse)


## PostAnalyticsTaskmanagementAggregatesJobs

> [**AsyncQueryResponse**](AsyncQueryResponse) PostAnalyticsTaskmanagementAggregatesJobs (TaskManagementAsyncAggregationQuery body)


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
| **body** | [**TaskManagementAsyncAggregationQuery**](TaskManagementAsyncAggregationQuery)| query |  |

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse)


## PostAnalyticsTaskmanagementAggregatesQuery

> [**TaskManagementAggregateQueryResponse**](TaskManagementAggregateQueryResponse) PostAnalyticsTaskmanagementAggregatesQuery (TaskManagementAggregationQuery body)


Query for task management aggregates

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
| **body** | [**TaskManagementAggregationQuery**](TaskManagementAggregationQuery)| query |  |

### Return type

[**TaskManagementAggregateQueryResponse**](TaskManagementAggregateQueryResponse)


## PostAnalyticsTeamsActivityQuery

> [**TeamActivityResponse**](TeamActivityResponse) PostAnalyticsTeamsActivityQuery (TeamActivityQuery body, int? pageSize = null, int? pageNumber = null)


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
| **body** | [**TeamActivityQuery**](TeamActivityQuery)| query |  |
| **pageSize** | **int?**| The desired page size | [optional]  |
| **pageNumber** | **int?**| The desired page number | [optional]  |

### Return type

[**TeamActivityResponse**](TeamActivityResponse)


## PostAnalyticsTranscriptsAggregatesJobs

> [**AsyncQueryResponse**](AsyncQueryResponse) PostAnalyticsTranscriptsAggregatesJobs (TranscriptAsyncAggregationQuery body)


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
| **body** | [**TranscriptAsyncAggregationQuery**](TranscriptAsyncAggregationQuery)| query |  |

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse)


## PostAnalyticsTranscriptsAggregatesQuery

> [**TranscriptAggregateQueryResponse**](TranscriptAggregateQueryResponse) PostAnalyticsTranscriptsAggregatesQuery (TranscriptAggregationQuery body)


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
| **body** | [**TranscriptAggregationQuery**](TranscriptAggregationQuery)| query |  |

### Return type

[**TranscriptAggregateQueryResponse**](TranscriptAggregateQueryResponse)


## PostAnalyticsUsersActivityQuery

> [**UserActivityResponse**](UserActivityResponse) PostAnalyticsUsersActivityQuery (UserActivityQuery body, int? pageSize = null, int? pageNumber = null)


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
| **body** | [**UserActivityQuery**](UserActivityQuery)| query |  |
| **pageSize** | **int?**| The desired page size | [optional]  |
| **pageNumber** | **int?**| The desired page number | [optional]  |

### Return type

[**UserActivityResponse**](UserActivityResponse)


## PostAnalyticsUsersAggregatesJobs

> [**AsyncQueryResponse**](AsyncQueryResponse) PostAnalyticsUsersAggregatesJobs (UserAsyncAggregationQuery body)


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
| **body** | [**UserAsyncAggregationQuery**](UserAsyncAggregationQuery)| query |  |

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse)


## PostAnalyticsUsersAggregatesQuery

> [**UserAggregateQueryResponse**](UserAggregateQueryResponse) PostAnalyticsUsersAggregatesQuery (UserAggregationQuery body)


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
| **body** | [**UserAggregationQuery**](UserAggregationQuery)| query |  |

### Return type

[**UserAggregateQueryResponse**](UserAggregateQueryResponse)


## PostAnalyticsUsersDetailsJobs

> [**AsyncQueryResponse**](AsyncQueryResponse) PostAnalyticsUsersDetailsJobs (AsyncUserDetailsQuery body)


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
| **body** | [**AsyncUserDetailsQuery**](AsyncUserDetailsQuery)| query |  |

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse)


## PostAnalyticsUsersDetailsQuery

> [**AnalyticsUserDetailsQueryResponse**](AnalyticsUserDetailsQueryResponse) PostAnalyticsUsersDetailsQuery (UserDetailsQuery body)


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
| **body** | [**UserDetailsQuery**](UserDetailsQuery)| query |  |

### Return type

[**AnalyticsUserDetailsQueryResponse**](AnalyticsUserDetailsQueryResponse)


## PostAnalyticsUsersObservationsQuery

> [**UserObservationQueryResponse**](UserObservationQueryResponse) PostAnalyticsUsersObservationsQuery (UserObservationQuery body)


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
| **body** | [**UserObservationQuery**](UserObservationQuery)| query |  |

### Return type

[**UserObservationQueryResponse**](UserObservationQueryResponse)


## PutAnalyticsDataretentionSettings

> [**AnalyticsDataRetentionResponse**](AnalyticsDataRetentionResponse) PutAnalyticsDataretentionSettings (UpdateAnalyticsDataRetentionRequest body)


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
| **body** | [**UpdateAnalyticsDataRetentionRequest**](UpdateAnalyticsDataRetentionRequest)| retentionDays |  |

### Return type

[**AnalyticsDataRetentionResponse**](AnalyticsDataRetentionResponse)


_PureCloudPlatform.Client.V2 232.0.0_
