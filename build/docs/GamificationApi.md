# GamificationApi

## PureCloudPlatform.Client.V2.Api.GamificationApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteEmployeeperformanceExternalmetricsDefinition**](#DeleteEmployeeperformanceExternalmetricsDefinition) | **Delete** /api/v2/employeeperformance/externalmetrics/definitions/{metricId} | Delete an External Metric Definition |
| [**DeleteGamificationContest**](#DeleteGamificationContest) | **Delete** /api/v2/gamification/contests/{contestId} | Delete a Contest by Id |
| [**GetEmployeeperformanceExternalmetricsDefinition**](#GetEmployeeperformanceExternalmetricsDefinition) | **Get** /api/v2/employeeperformance/externalmetrics/definitions/{metricId} | Get an External Metric Definition |
| [**GetEmployeeperformanceExternalmetricsDefinitions**](#GetEmployeeperformanceExternalmetricsDefinitions) | **Get** /api/v2/employeeperformance/externalmetrics/definitions | Get a list of External Metric Definitions of an organization, sorted by name in ascending order |
| [**GetGamificationContest**](#GetGamificationContest) | **Get** /api/v2/gamification/contests/{contestId} | Get a Contest by Id |
| [**GetGamificationContestAgentsScores**](#GetGamificationContestAgentsScores) | **Get** /api/v2/gamification/contests/{contestId}/agents/scores | Get Contest Scores (Admin) |
| [**GetGamificationContestAgentsScoresMe**](#GetGamificationContestAgentsScoresMe) | **Get** /api/v2/gamification/contests/{contestId}/agents/scores/me | Get Contest Scores for the requesting Agent/Supervisor |
| [**GetGamificationContestAgentsScoresTrends**](#GetGamificationContestAgentsScoresTrends) | **Get** /api/v2/gamification/contests/{contestId}/agents/scores/trends | Get a Contest Score Trend (Average Trend) |
| [**GetGamificationContestAgentsScoresTrendsMe**](#GetGamificationContestAgentsScoresTrendsMe) | **Get** /api/v2/gamification/contests/{contestId}/agents/scores/trends/me | Get a Contest Score Trend for the requesting Agent |
| [**GetGamificationContestPrizeimage**](#GetGamificationContestPrizeimage) | **Get** /api/v2/gamification/contests/{contestId}/prizeimages/{prizeImageId} | Get a Contest Prize Image by Id |
| [**GetGamificationContests**](#GetGamificationContests) | **Get** /api/v2/gamification/contests | Get a List of Contests (Admin) |
| [**GetGamificationContestsMe**](#GetGamificationContestsMe) | **Get** /api/v2/gamification/contests/me | Get a List of Contests (Agent/Supervisor) |
| [**GetGamificationInsights**](#GetGamificationInsights) | **Get** /api/v2/gamification/insights | Get insights summary |
| [**GetGamificationInsightsDetails**](#GetGamificationInsightsDetails) | **Get** /api/v2/gamification/insights/details | Get insights details for the current user |
| [**GetGamificationInsightsGroupsTrends**](#GetGamificationInsightsGroupsTrends) | **Get** /api/v2/gamification/insights/groups/trends | Get insights overall trend for the current user |
| [**GetGamificationInsightsGroupsTrendsAll**](#GetGamificationInsightsGroupsTrendsAll) | **Get** /api/v2/gamification/insights/groups/trends/all | Get insights overall trend |
| [**GetGamificationInsightsManagers**](#GetGamificationInsightsManagers) | **Get** /api/v2/gamification/insights/managers | Query managers in a profile during a period of time |
| [**GetGamificationInsightsMembers**](#GetGamificationInsightsMembers) | **Get** /api/v2/gamification/insights/members | Query users in a profile during a period of time |
| [**GetGamificationInsightsRankings**](#GetGamificationInsightsRankings) | **Get** /api/v2/gamification/insights/rankings | Get insights rankings |
| [**GetGamificationInsightsTrends**](#GetGamificationInsightsTrends) | **Get** /api/v2/gamification/insights/trends | Get insights user trend for the current user |
| [**GetGamificationInsightsUserDetails**](#GetGamificationInsightsUserDetails) | **Get** /api/v2/gamification/insights/users/{userId}/details | Get insights details for the user |
| [**GetGamificationInsightsUserTrends**](#GetGamificationInsightsUserTrends) | **Get** /api/v2/gamification/insights/users/{userId}/trends | Get insights user trend for the user |
| [**GetGamificationLeaderboard**](#GetGamificationLeaderboard) | **Get** /api/v2/gamification/leaderboard | Leaderboard of the requesting user&#39;s division or performance profile |
| [**GetGamificationLeaderboardAll**](#GetGamificationLeaderboardAll) | **Get** /api/v2/gamification/leaderboard/all | Leaderboard by filter type |
| [**GetGamificationLeaderboardAllBestpoints**](#GetGamificationLeaderboardAllBestpoints) | **Get** /api/v2/gamification/leaderboard/all/bestpoints | Best Points by division or performance profile |
| [**GetGamificationLeaderboardBestpoints**](#GetGamificationLeaderboardBestpoints) | **Get** /api/v2/gamification/leaderboard/bestpoints | Best Points of the requesting user&#39;s current performance profile or division |
| [**GetGamificationMetricdefinition**](#GetGamificationMetricdefinition) | **Get** /api/v2/gamification/metricdefinitions/{metricDefinitionId} | Metric definition by id |
| [**GetGamificationMetricdefinitions**](#GetGamificationMetricdefinitions) | **Get** /api/v2/gamification/metricdefinitions | All metric definitions |
| [**GetGamificationProfile**](#GetGamificationProfile) | **Get** /api/v2/gamification/profiles/{profileId} | Performance profile by id |
| [**GetGamificationProfileMembers**](#GetGamificationProfileMembers) | **Get** /api/v2/gamification/profiles/{profileId}/members | Members of a given performance profile |
| [**GetGamificationProfileMetric**](#GetGamificationProfileMetric) | **Get** /api/v2/gamification/profiles/{profileId}/metrics/{metricId} | Performance profile gamified metric by id |
| [**GetGamificationProfileMetrics**](#GetGamificationProfileMetrics) | **Get** /api/v2/gamification/profiles/{profileId}/metrics | All gamified metrics for a given performance profile |
| [**GetGamificationProfileMetricsObjectivedetails**](#GetGamificationProfileMetricsObjectivedetails) | **Get** /api/v2/gamification/profiles/{profileId}/metrics/objectivedetails | All metrics for a given performance profile with objective details such as order and maxPoints |
| [**GetGamificationProfiles**](#GetGamificationProfiles) | **Get** /api/v2/gamification/profiles | All performance profiles |
| [**GetGamificationProfilesUser**](#GetGamificationProfilesUser) | **Get** /api/v2/gamification/profiles/users/{userId} | Performance profile of a user |
| [**GetGamificationProfilesUsersMe**](#GetGamificationProfilesUsersMe) | **Get** /api/v2/gamification/profiles/users/me | Performance profile of the requesting user |
| [**GetGamificationScorecards**](#GetGamificationScorecards) | **Get** /api/v2/gamification/scorecards | Workday performance metrics of the requesting user |
| [**GetGamificationScorecardsAttendance**](#GetGamificationScorecardsAttendance) | **Get** /api/v2/gamification/scorecards/attendance | Attendance status metrics of the requesting user |
| [**GetGamificationScorecardsBestpoints**](#GetGamificationScorecardsBestpoints) | **Get** /api/v2/gamification/scorecards/bestpoints | Best points of the requesting user |
| [**GetGamificationScorecardsPointsAlltime**](#GetGamificationScorecardsPointsAlltime) | **Get** /api/v2/gamification/scorecards/points/alltime | All-time points of the requesting user |
| [**GetGamificationScorecardsPointsAverage**](#GetGamificationScorecardsPointsAverage) | **Get** /api/v2/gamification/scorecards/points/average | Average points of the requesting user&#39;s division or performance profile |
| [**GetGamificationScorecardsPointsTrends**](#GetGamificationScorecardsPointsTrends) | **Get** /api/v2/gamification/scorecards/points/trends | Points trends of the requesting user |
| [**GetGamificationScorecardsProfileMetricUserValuesTrends**](#GetGamificationScorecardsProfileMetricUserValuesTrends) | **Get** /api/v2/gamification/scorecards/profiles/{profileId}/metrics/{metricId}/users/{userId}/values/trends | Average performance values trends by metric of a user |
| [**GetGamificationScorecardsProfileMetricUsersValuesTrends**](#GetGamificationScorecardsProfileMetricUsersValuesTrends) | **Get** /api/v2/gamification/scorecards/profiles/{profileId}/metrics/{metricId}/users/values/trends | Average performance values trends by metric of a division or a performance profile |
| [**GetGamificationScorecardsProfileMetricValuesTrends**](#GetGamificationScorecardsProfileMetricValuesTrends) | **Get** /api/v2/gamification/scorecards/profiles/{profileId}/metrics/{metricId}/values/trends | Average performance values trends by metric of the requesting user |
| [**GetGamificationScorecardsUser**](#GetGamificationScorecardsUser) | **Get** /api/v2/gamification/scorecards/users/{userId} | Workday performance metrics for a user |
| [**GetGamificationScorecardsUserAttendance**](#GetGamificationScorecardsUserAttendance) | **Get** /api/v2/gamification/scorecards/users/{userId}/attendance | Attendance status metrics for a user |
| [**GetGamificationScorecardsUserBestpoints**](#GetGamificationScorecardsUserBestpoints) | **Get** /api/v2/gamification/scorecards/users/{userId}/bestpoints | Best points of a user |
| [**GetGamificationScorecardsUserPointsAlltime**](#GetGamificationScorecardsUserPointsAlltime) | **Get** /api/v2/gamification/scorecards/users/{userId}/points/alltime | All-time points for a user |
| [**GetGamificationScorecardsUserPointsTrends**](#GetGamificationScorecardsUserPointsTrends) | **Get** /api/v2/gamification/scorecards/users/{userId}/points/trends | Points trend for a user |
| [**GetGamificationScorecardsUserValuesTrends**](#GetGamificationScorecardsUserValuesTrends) | **Get** /api/v2/gamification/scorecards/users/{userId}/values/trends | Values trends of a user |
| [**GetGamificationScorecardsUsersPointsAverage**](#GetGamificationScorecardsUsersPointsAverage) | **Get** /api/v2/gamification/scorecards/users/points/average | Workday average points by target group |
| [**GetGamificationScorecardsUsersValuesAverage**](#GetGamificationScorecardsUsersValuesAverage) | **Get** /api/v2/gamification/scorecards/users/values/average | Workday average values by target group |
| [**GetGamificationScorecardsUsersValuesTrends**](#GetGamificationScorecardsUsersValuesTrends) | **Get** /api/v2/gamification/scorecards/users/values/trends | Values trend by target group |
| [**GetGamificationScorecardsValuesAverage**](#GetGamificationScorecardsValuesAverage) | **Get** /api/v2/gamification/scorecards/values/average | Average values of the requesting user&#39;s division or performance profile |
| [**GetGamificationScorecardsValuesTrends**](#GetGamificationScorecardsValuesTrends) | **Get** /api/v2/gamification/scorecards/values/trends | Values trends of the requesting user or group |
| [**GetGamificationStatus**](#GetGamificationStatus) | **Get** /api/v2/gamification/status | Gamification activation status |
| [**GetGamificationTemplate**](#GetGamificationTemplate) | **Get** /api/v2/gamification/templates/{templateId} | Objective template by id |
| [**GetGamificationTemplates**](#GetGamificationTemplates) | **Get** /api/v2/gamification/templates | All objective templates |
| [**PatchEmployeeperformanceExternalmetricsDefinition**](#PatchEmployeeperformanceExternalmetricsDefinition) | **Patch** /api/v2/employeeperformance/externalmetrics/definitions/{metricId} | Update External Metric Definition |
| [**PatchGamificationContest**](#PatchGamificationContest) | **Patch** /api/v2/gamification/contests/{contestId} | Finalize a Contest by Id |
| [**PostEmployeeperformanceExternalmetricsData**](#PostEmployeeperformanceExternalmetricsData) | **Post** /api/v2/employeeperformance/externalmetrics/data | Write External Metric Data |
| [**PostEmployeeperformanceExternalmetricsDefinitions**](#PostEmployeeperformanceExternalmetricsDefinitions) | **Post** /api/v2/employeeperformance/externalmetrics/definitions | Create External Metric Definition |
| [**PostGamificationContests**](#PostGamificationContests) | **Post** /api/v2/gamification/contests | Creates a Contest |
| [**PostGamificationContestsUploadsPrizeimages**](#PostGamificationContestsUploadsPrizeimages) | **Post** /api/v2/gamification/contests/uploads/prizeimages | Generates pre-signed URL to upload a prize image for gamification contests |
| [**PostGamificationProfileActivate**](#PostGamificationProfileActivate) | **Post** /api/v2/gamification/profiles/{profileId}/activate | Activate a performance profile |
| [**PostGamificationProfileDeactivate**](#PostGamificationProfileDeactivate) | **Post** /api/v2/gamification/profiles/{profileId}/deactivate | Deactivate a performance profile |
| [**PostGamificationProfileMembers**](#PostGamificationProfileMembers) | **Post** /api/v2/gamification/profiles/{profileId}/members | Assign members to a given performance profile |
| [**PostGamificationProfileMembersValidate**](#PostGamificationProfileMembersValidate) | **Post** /api/v2/gamification/profiles/{profileId}/members/validate | Validate member assignment |
| [**PostGamificationProfileMetricLink**](#PostGamificationProfileMetricLink) | **Post** /api/v2/gamification/profiles/{sourceProfileId}/metrics/{sourceMetricId}/link | Creates a linked metric |
| [**PostGamificationProfileMetrics**](#PostGamificationProfileMetrics) | **Post** /api/v2/gamification/profiles/{profileId}/metrics | Creates a gamified metric with a given metric definition and metric objective under in a performance profile |
| [**PostGamificationProfiles**](#PostGamificationProfiles) | **Post** /api/v2/gamification/profiles | Create a new custom performance profile |
| [**PostGamificationProfilesUserQuery**](#PostGamificationProfilesUserQuery) | **Post** /api/v2/gamification/profiles/users/{userId}/query | Query performance profiles in date range for a user |
| [**PostGamificationProfilesUsersMeQuery**](#PostGamificationProfilesUsersMeQuery) | **Post** /api/v2/gamification/profiles/users/me/query | Query performance profiles in date range for the current user |
| [**PutGamificationContest**](#PutGamificationContest) | **Put** /api/v2/gamification/contests/{contestId} | Update a Contest by Id |
| [**PutGamificationProfile**](#PutGamificationProfile) | **Put** /api/v2/gamification/profiles/{profileId} | Updates a performance profile |
| [**PutGamificationProfileMetric**](#PutGamificationProfileMetric) | **Put** /api/v2/gamification/profiles/{profileId}/metrics/{metricId} | Updates a metric in performance profile |
| [**PutGamificationStatus**](#PutGamificationStatus) | **Put** /api/v2/gamification/status | Update gamification activation status |



## DeleteEmployeeperformanceExternalmetricsDefinition

> void DeleteEmployeeperformanceExternalmetricsDefinition (string metricId)


Delete an External Metric Definition

Requires ANY permissions: 

* employeePerformance:externalMetricDefinition:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteEmployeeperformanceExternalmetricsDefinitionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var metricId = metricId_example;  // string | Specifies the External Metric Definition ID

            try
            { 
                // Delete an External Metric Definition
                apiInstance.DeleteEmployeeperformanceExternalmetricsDefinition(metricId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.DeleteEmployeeperformanceExternalmetricsDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **metricId** | **string**| Specifies the External Metric Definition ID |  |

### Return type

void (empty response body)


## DeleteGamificationContest

> void DeleteGamificationContest (string contestId)


Delete a Contest by Id

Requires ANY permissions: 

* gamification:contest:delete
* gamification:contest:deleteAll

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteGamificationContestExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var contestId = contestId_example;  // string | The ID of the contest

            try
            { 
                // Delete a Contest by Id
                apiInstance.DeleteGamificationContest(contestId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.DeleteGamificationContest: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contestId** | **string**| The ID of the contest |  |

### Return type

void (empty response body)


## GetEmployeeperformanceExternalmetricsDefinition

> [**ExternalMetricDefinition**](ExternalMetricDefinition) GetEmployeeperformanceExternalmetricsDefinition (string metricId)


Get an External Metric Definition

Requires ANY permissions: 

* employeePerformance:externalMetricDefinition:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetEmployeeperformanceExternalmetricsDefinitionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var metricId = metricId_example;  // string | Specifies the External Metric Definition ID

            try
            { 
                // Get an External Metric Definition
                ExternalMetricDefinition result = apiInstance.GetEmployeeperformanceExternalmetricsDefinition(metricId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetEmployeeperformanceExternalmetricsDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **metricId** | **string**| Specifies the External Metric Definition ID |  |

### Return type

[**ExternalMetricDefinition**](ExternalMetricDefinition)


## GetEmployeeperformanceExternalmetricsDefinitions

> [**ExternalMetricDefinitionListing**](ExternalMetricDefinitionListing) GetEmployeeperformanceExternalmetricsDefinitions (int? pageSize = null, int? pageNumber = null)


Get a list of External Metric Definitions of an organization, sorted by name in ascending order

Requires ANY permissions: 

* employeePerformance:externalMetricDefinition:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetEmployeeperformanceExternalmetricsDefinitionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get a list of External Metric Definitions of an organization, sorted by name in ascending order
                ExternalMetricDefinitionListing result = apiInstance.GetEmployeeperformanceExternalmetricsDefinitions(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetEmployeeperformanceExternalmetricsDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |

### Return type

[**ExternalMetricDefinitionListing**](ExternalMetricDefinitionListing)


## GetGamificationContest

> [**ContestsResponse**](ContestsResponse) GetGamificationContest (string contestId)


Get a Contest by Id

Requires ANY permissions: 

* gamification:contest:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationContestExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var contestId = contestId_example;  // string | The ID of the contest

            try
            { 
                // Get a Contest by Id
                ContestsResponse result = apiInstance.GetGamificationContest(contestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationContest: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contestId** | **string**| The ID of the contest |  |

### Return type

[**ContestsResponse**](ContestsResponse)


## GetGamificationContestAgentsScores

> [**ContestScoresAgentsPagedList**](ContestScoresAgentsPagedList) GetGamificationContestAgentsScores (string contestId, int? pageNumber = null, int? pageSize = null, String workday = null, string returnsView = null)


Get Contest Scores (Admin)

Requires ANY permissions: 

* gamification:contest:viewAll

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationContestAgentsScoresExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var contestId = contestId_example;  // string | The ID of the contest
            var pageNumber = 56;  // int? |  (optional)  (default to 1)
            var pageSize = 56;  // int? |  (optional)  (default to 25)
            var workday = 2013-10-20;  // String | Target querying workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional) 
            var returnsView = returnsView_example;  // string | Desired response results (optional)  (default to All)

            try
            { 
                // Get Contest Scores (Admin)
                ContestScoresAgentsPagedList result = apiInstance.GetGamificationContestAgentsScores(contestId, pageNumber, pageSize, workday, returnsView);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationContestAgentsScores: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contestId** | **string**| The ID of the contest |  |
| **pageNumber** | **int?**|  | [optional] [default to 1] |
| **pageSize** | **int?**|  | [optional] [default to 25] |
| **workday** | **String**| Target querying workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional]  |
| **returnsView** | **string**| Desired response results | [optional] [default to All]<br />**Values**: All, TopAndBottom |

### Return type

[**ContestScoresAgentsPagedList**](ContestScoresAgentsPagedList)


## GetGamificationContestAgentsScoresMe

> [**ContestScoresAgentsPagedList**](ContestScoresAgentsPagedList) GetGamificationContestAgentsScoresMe (string contestId, int? pageNumber = null, int? pageSize = null, String workday = null, string returnsView = null)


Get Contest Scores for the requesting Agent/Supervisor

Requires ALL permissions: 

* gamification:contest:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationContestAgentsScoresMeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var contestId = contestId_example;  // string | The ID of the contest
            var pageNumber = 56;  // int? |  (optional)  (default to 1)
            var pageSize = 56;  // int? |  (optional)  (default to 25)
            var workday = 2013-10-20;  // String | Target querying workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional) 
            var returnsView = returnsView_example;  // string | Desired response results (Supervisor Only) (optional)  (default to All)

            try
            { 
                // Get Contest Scores for the requesting Agent/Supervisor
                ContestScoresAgentsPagedList result = apiInstance.GetGamificationContestAgentsScoresMe(contestId, pageNumber, pageSize, workday, returnsView);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationContestAgentsScoresMe: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contestId** | **string**| The ID of the contest |  |
| **pageNumber** | **int?**|  | [optional] [default to 1] |
| **pageSize** | **int?**|  | [optional] [default to 25] |
| **workday** | **String**| Target querying workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional]  |
| **returnsView** | **string**| Desired response results (Supervisor Only) | [optional] [default to All]<br />**Values**: All, TopAndBottom |

### Return type

[**ContestScoresAgentsPagedList**](ContestScoresAgentsPagedList)


## GetGamificationContestAgentsScoresTrends

> [**ContestScoresGroupTrendList**](ContestScoresGroupTrendList) GetGamificationContestAgentsScoresTrends (string contestId)


Get a Contest Score Trend (Average Trend)

Requires ANY permissions: 

* gamification:contest:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationContestAgentsScoresTrendsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var contestId = contestId_example;  // string | The ID of the contest

            try
            { 
                // Get a Contest Score Trend (Average Trend)
                ContestScoresGroupTrendList result = apiInstance.GetGamificationContestAgentsScoresTrends(contestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationContestAgentsScoresTrends: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contestId** | **string**| The ID of the contest |  |

### Return type

[**ContestScoresGroupTrendList**](ContestScoresGroupTrendList)


## GetGamificationContestAgentsScoresTrendsMe

> [**ContestScoresAgentTrendList**](ContestScoresAgentTrendList) GetGamificationContestAgentsScoresTrendsMe (string contestId)


Get a Contest Score Trend for the requesting Agent

Requires ANY permissions: 

* gamification:contest:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationContestAgentsScoresTrendsMeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var contestId = contestId_example;  // string | The ID of the contest

            try
            { 
                // Get a Contest Score Trend for the requesting Agent
                ContestScoresAgentTrendList result = apiInstance.GetGamificationContestAgentsScoresTrendsMe(contestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationContestAgentsScoresTrendsMe: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contestId** | **string**| The ID of the contest |  |

### Return type

[**ContestScoresAgentTrendList**](ContestScoresAgentTrendList)


## GetGamificationContestPrizeimage

> [**PrizeImages**](PrizeImages) GetGamificationContestPrizeimage (string contestId, string prizeImageId)


Get a Contest Prize Image by Id

Requires ANY permissions: 

* gamification:contest:view
* gamification:contest:viewAll

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationContestPrizeimageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var contestId = contestId_example;  // string | The ID of the contest
            var prizeImageId = prizeImageId_example;  // string | The ID of the prize image

            try
            { 
                // Get a Contest Prize Image by Id
                PrizeImages result = apiInstance.GetGamificationContestPrizeimage(contestId, prizeImageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationContestPrizeimage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contestId** | **string**| The ID of the contest |  |
| **prizeImageId** | **string**| The ID of the prize image |  |

### Return type

[**PrizeImages**](PrizeImages)


## GetGamificationContests

> [**GetContestsEssentialsListing**](GetContestsEssentialsListing) GetGamificationContests (int? pageNumber = null, int? pageSize = null, String dateStart = null, String dateEnd = null, List<string> status = null, string sortBy = null, string sortOrder = null)


Get a List of Contests (Admin)

Requires ANY permissions: 

* gamification:contest:viewAll

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationContestsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var pageNumber = 56;  // int? |  (optional)  (default to 1)
            var pageSize = 56;  // int? |  (optional)  (default to 25)
            var dateStart = 2013-10-20;  // String | Start date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional) 
            var dateEnd = 2013-10-20;  // String | End date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional) 
            var status = new List<string>(); // List<string> |  (optional) 
            var sortBy = sortBy_example;  // string |  (optional)  (default to dateStart)
            var sortOrder = sortOrder_example;  // string |  (optional)  (default to desc)

            try
            { 
                // Get a List of Contests (Admin)
                GetContestsEssentialsListing result = apiInstance.GetGamificationContests(pageNumber, pageSize, dateStart, dateEnd, status, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationContests: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**|  | [optional] [default to 1] |
| **pageSize** | **int?**|  | [optional] [default to 25] |
| **dateStart** | **String**| Start date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional]  |
| **dateEnd** | **String**| End date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional]  |
| **status** | [**List<string>**](string)|  | [optional] <br />**Values**: Upcoming, Ongoing, Pending, RecentlyCompleted, Completed, Cancelled |
| **sortBy** | **string**|  | [optional] [default to dateStart]<br />**Values**: title, dateStart, dateEnd, dateFinalized, status, profile, participantCount |
| **sortOrder** | **string**|  | [optional] [default to desc]<br />**Values**: asc, desc |

### Return type

[**GetContestsEssentialsListing**](GetContestsEssentialsListing)


## GetGamificationContestsMe

> [**GetContestsEssentialsListing**](GetContestsEssentialsListing) GetGamificationContestsMe (int? pageNumber = null, int? pageSize = null, String dateStart = null, String dateEnd = null, List<string> status = null, string sortBy = null, string sortOrder = null, string view = null)


Get a List of Contests (Agent/Supervisor)

Requires ALL permissions: 

* gamification:contest:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationContestsMeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var pageNumber = 56;  // int? |  (optional)  (default to 1)
            var pageSize = 56;  // int? |  (optional)  (default to 25)
            var dateStart = 2013-10-20;  // String | Start date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional) 
            var dateEnd = 2013-10-20;  // String | End date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional) 
            var status = new List<string>(); // List<string> |  (optional) 
            var sortBy = sortBy_example;  // string |  (optional)  (default to dateStart)
            var sortOrder = sortOrder_example;  // string |  (optional)  (default to desc)
            var view = view_example;  // string |  (optional)  (default to participant)

            try
            { 
                // Get a List of Contests (Agent/Supervisor)
                GetContestsEssentialsListing result = apiInstance.GetGamificationContestsMe(pageNumber, pageSize, dateStart, dateEnd, status, sortBy, sortOrder, view);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationContestsMe: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**|  | [optional] [default to 1] |
| **pageSize** | **int?**|  | [optional] [default to 25] |
| **dateStart** | **String**| Start date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional]  |
| **dateEnd** | **String**| End date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional]  |
| **status** | [**List<string>**](string)|  | [optional] <br />**Values**: Upcoming, Ongoing, Pending, RecentlyCompleted, Completed, Cancelled |
| **sortBy** | **string**|  | [optional] [default to dateStart]<br />**Values**: title, dateStart, dateEnd, dateFinalized, status, profile, participantCount |
| **sortOrder** | **string**|  | [optional] [default to desc]<br />**Values**: asc, desc |
| **view** | **string**|  | [optional] [default to participant]<br />**Values**: participant, creator |

### Return type

[**GetContestsEssentialsListing**](GetContestsEssentialsListing)


## GetGamificationInsights

> [**InsightsSummary**](InsightsSummary) GetGamificationInsights (string filterType, string filterId, string granularity, String comparativePeriodStartWorkday, String primaryPeriodStartWorkday, int? pageSize = null, int? pageNumber = null, string sortKey = null, string sortMetricId = null, string sortOrder = null, string userIds = null, string reportsTo = null)


Get insights summary

Requires ANY permissions: 

* gamification:insights:viewAll

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationInsightsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var filterType = filterType_example;  // string | Filter type for the query request.
            var filterId = filterId_example;  // string | ID for the filter type.
            var granularity = granularity_example;  // string | Granularity
            var comparativePeriodStartWorkday = 2013-10-20;  // String | The start work day of comparative period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var primaryPeriodStartWorkday = 2013-10-20;  // String | The start work day of primary period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortKey = sortKey_example;  // string | Sort key (optional) 
            var sortMetricId = sortMetricId_example;  // string | Sort Metric Id (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to asc)
            var userIds = userIds_example;  // string | A list of up to 100 comma-separated user Ids (optional) 
            var reportsTo = reportsTo_example;  // string | The reportsTo used by ABAC policies. (optional) 

            try
            { 
                // Get insights summary
                InsightsSummary result = apiInstance.GetGamificationInsights(filterType, filterId, granularity, comparativePeriodStartWorkday, primaryPeriodStartWorkday, pageSize, pageNumber, sortKey, sortMetricId, sortOrder, userIds, reportsTo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationInsights: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **filterType** | **string**| Filter type for the query request. | <br />**Values**: PerformanceProfile, Division |
| **filterId** | **string**| ID for the filter type. |  |
| **granularity** | **string**| Granularity | <br />**Values**: Weekly, Monthly |
| **comparativePeriodStartWorkday** | **String**| The start work day of comparative period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **primaryPeriodStartWorkday** | **String**| The start work day of primary period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortKey** | **string**| Sort key | [optional] <br />**Values**: percentOfGoal, percentOfGoalChange, overallPercentOfGoal, overallPercentOfGoalChange, value, valueChange |
| **sortMetricId** | **string**| Sort Metric Id | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to asc]<br />**Values**: asc, desc |
| **userIds** | **string**| A list of up to 100 comma-separated user Ids | [optional]  |
| **reportsTo** | **string**| The reportsTo used by ABAC policies. | [optional]  |

### Return type

[**InsightsSummary**](InsightsSummary)


## GetGamificationInsightsDetails

> [**InsightsDetails**](InsightsDetails) GetGamificationInsightsDetails (string filterType, string filterId, string granularity, String comparativePeriodStartWorkday, String primaryPeriodStartWorkday)


Get insights details for the current user

Requires ANY permissions: 

* gamification:insights:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationInsightsDetailsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var filterType = filterType_example;  // string | Filter type for the query request.
            var filterId = filterId_example;  // string | ID for the filter type.
            var granularity = granularity_example;  // string | Granularity
            var comparativePeriodStartWorkday = 2013-10-20;  // String | The start work day of comparative period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var primaryPeriodStartWorkday = 2013-10-20;  // String | The start work day of primary period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd

            try
            { 
                // Get insights details for the current user
                InsightsDetails result = apiInstance.GetGamificationInsightsDetails(filterType, filterId, granularity, comparativePeriodStartWorkday, primaryPeriodStartWorkday);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationInsightsDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **filterType** | **string**| Filter type for the query request. | <br />**Values**: PerformanceProfile, Division |
| **filterId** | **string**| ID for the filter type. |  |
| **granularity** | **string**| Granularity | <br />**Values**: Weekly, Monthly |
| **comparativePeriodStartWorkday** | **String**| The start work day of comparative period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **primaryPeriodStartWorkday** | **String**| The start work day of primary period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |

### Return type

[**InsightsDetails**](InsightsDetails)


## GetGamificationInsightsGroupsTrends

> [**InsightsTrend**](InsightsTrend) GetGamificationInsightsGroupsTrends (string filterType, string filterId, string granularity, String comparativePeriodStartWorkday, String comparativePeriodEndWorkday, String primaryPeriodStartWorkday, String primaryPeriodEndWorkday)


Get insights overall trend for the current user

Requires ANY permissions: 

* gamification:insights:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationInsightsGroupsTrendsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var filterType = filterType_example;  // string | Filter type for the query request.
            var filterId = filterId_example;  // string | ID for the filter type.
            var granularity = granularity_example;  // string | Granularity
            var comparativePeriodStartWorkday = 2013-10-20;  // String | The start work day of comparative period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var comparativePeriodEndWorkday = 2013-10-20;  // String | The end work day of comparative period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var primaryPeriodStartWorkday = 2013-10-20;  // String | The start work day of primary period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var primaryPeriodEndWorkday = 2013-10-20;  // String | The end work day of primary period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd

            try
            { 
                // Get insights overall trend for the current user
                InsightsTrend result = apiInstance.GetGamificationInsightsGroupsTrends(filterType, filterId, granularity, comparativePeriodStartWorkday, comparativePeriodEndWorkday, primaryPeriodStartWorkday, primaryPeriodEndWorkday);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationInsightsGroupsTrends: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **filterType** | **string**| Filter type for the query request. | <br />**Values**: PerformanceProfile, Division |
| **filterId** | **string**| ID for the filter type. |  |
| **granularity** | **string**| Granularity | <br />**Values**: Daily, Weekly, Monthly |
| **comparativePeriodStartWorkday** | **String**| The start work day of comparative period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **comparativePeriodEndWorkday** | **String**| The end work day of comparative period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **primaryPeriodStartWorkday** | **String**| The start work day of primary period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **primaryPeriodEndWorkday** | **String**| The end work day of primary period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |

### Return type

[**InsightsTrend**](InsightsTrend)


## GetGamificationInsightsGroupsTrendsAll

> [**InsightsTrend**](InsightsTrend) GetGamificationInsightsGroupsTrendsAll (string filterType, string filterId, string granularity, String comparativePeriodStartWorkday, String comparativePeriodEndWorkday, String primaryPeriodStartWorkday, String primaryPeriodEndWorkday)


Get insights overall trend

Requires ANY permissions: 

* gamification:insights:viewAll

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationInsightsGroupsTrendsAllExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var filterType = filterType_example;  // string | Filter type for the query request.
            var filterId = filterId_example;  // string | ID for the filter type.
            var granularity = granularity_example;  // string | Granularity
            var comparativePeriodStartWorkday = 2013-10-20;  // String | The start work day of comparative period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var comparativePeriodEndWorkday = 2013-10-20;  // String | The end work day of comparative period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var primaryPeriodStartWorkday = 2013-10-20;  // String | The start work day of primary period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var primaryPeriodEndWorkday = 2013-10-20;  // String | The end work day of primary period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd

            try
            { 
                // Get insights overall trend
                InsightsTrend result = apiInstance.GetGamificationInsightsGroupsTrendsAll(filterType, filterId, granularity, comparativePeriodStartWorkday, comparativePeriodEndWorkday, primaryPeriodStartWorkday, primaryPeriodEndWorkday);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationInsightsGroupsTrendsAll: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **filterType** | **string**| Filter type for the query request. | <br />**Values**: PerformanceProfile, Division |
| **filterId** | **string**| ID for the filter type. |  |
| **granularity** | **string**| Granularity | <br />**Values**: Daily, Weekly, Monthly |
| **comparativePeriodStartWorkday** | **String**| The start work day of comparative period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **comparativePeriodEndWorkday** | **String**| The end work day of comparative period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **primaryPeriodStartWorkday** | **String**| The start work day of primary period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **primaryPeriodEndWorkday** | **String**| The end work day of primary period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |

### Return type

[**InsightsTrend**](InsightsTrend)


## GetGamificationInsightsManagers

> [**InsightsAgents**](InsightsAgents) GetGamificationInsightsManagers (string filterType, string filterId, string granularity, String startWorkday, int? pageSize = null, int? pageNumber = null)


Query managers in a profile during a period of time

Requires ANY permissions: 

* gamification:insights:viewAll

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationInsightsManagersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var filterType = filterType_example;  // string | Filter type for the query request.
            var filterId = filterId_example;  // string | ID for the filter type.
            var granularity = granularity_example;  // string | Granularity
            var startWorkday = 2013-10-20;  // String | The start work day. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var pageSize = 56;  // int? | Page size (optional)  (default to 100)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Query managers in a profile during a period of time
                InsightsAgents result = apiInstance.GetGamificationInsightsManagers(filterType, filterId, granularity, startWorkday, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationInsightsManagers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **filterType** | **string**| Filter type for the query request. | <br />**Values**: PerformanceProfile, Division |
| **filterId** | **string**| ID for the filter type. |  |
| **granularity** | **string**| Granularity | <br />**Values**: Weekly, Monthly |
| **startWorkday** | **String**| The start work day. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **pageSize** | **int?**| Page size | [optional] [default to 100] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |

### Return type

[**InsightsAgents**](InsightsAgents)


## GetGamificationInsightsMembers

> [**InsightsAgents**](InsightsAgents) GetGamificationInsightsMembers (string filterType, string filterId, string granularity, String startWorkday, string reportsTo = null)


Query users in a profile during a period of time

Requires ANY permissions: 

* gamification:insights:viewAll

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationInsightsMembersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var filterType = filterType_example;  // string | Filter type for the query request.
            var filterId = filterId_example;  // string | ID for the filter type.
            var granularity = granularity_example;  // string | Granularity
            var startWorkday = 2013-10-20;  // String | The start work day. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var reportsTo = reportsTo_example;  // string | The reportsTo used by ABAC policies. (optional) 

            try
            { 
                // Query users in a profile during a period of time
                InsightsAgents result = apiInstance.GetGamificationInsightsMembers(filterType, filterId, granularity, startWorkday, reportsTo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationInsightsMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **filterType** | **string**| Filter type for the query request. | <br />**Values**: PerformanceProfile, Division |
| **filterId** | **string**| ID for the filter type. |  |
| **granularity** | **string**| Granularity | <br />**Values**: Weekly, Monthly |
| **startWorkday** | **String**| The start work day. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **reportsTo** | **string**| The reportsTo used by ABAC policies. | [optional]  |

### Return type

[**InsightsAgents**](InsightsAgents)


## GetGamificationInsightsRankings

> [**InsightsRankings**](InsightsRankings) GetGamificationInsightsRankings (string filterType, string filterId, string granularity, String comparativePeriodStartWorkday, String primaryPeriodStartWorkday, string sortKey, string sortMetricId = null, int? sectionSize = null, string userIds = null, string reportsTo = null)


Get insights rankings

Requires ANY permissions: 

* gamification:insights:viewAll

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationInsightsRankingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var filterType = filterType_example;  // string | Filter type for the query request.
            var filterId = filterId_example;  // string | ID for the filter type.
            var granularity = granularity_example;  // string | Granularity
            var comparativePeriodStartWorkday = 2013-10-20;  // String | The start work day of comparative period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var primaryPeriodStartWorkday = 2013-10-20;  // String | The start work day of primary period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var sortKey = sortKey_example;  // string | Sort key
            var sortMetricId = sortMetricId_example;  // string | Sort Metric Id (optional) 
            var sectionSize = 56;  // int? | The number of top and bottom users to return before ties (optional) 
            var userIds = userIds_example;  // string | A list of up to 100 comma-separated user Ids (optional) 
            var reportsTo = reportsTo_example;  // string | The reportsTo used by ABAC policies. (optional) 

            try
            { 
                // Get insights rankings
                InsightsRankings result = apiInstance.GetGamificationInsightsRankings(filterType, filterId, granularity, comparativePeriodStartWorkday, primaryPeriodStartWorkday, sortKey, sortMetricId, sectionSize, userIds, reportsTo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationInsightsRankings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **filterType** | **string**| Filter type for the query request. | <br />**Values**: PerformanceProfile, Division |
| **filterId** | **string**| ID for the filter type. |  |
| **granularity** | **string**| Granularity | <br />**Values**: Weekly, Monthly |
| **comparativePeriodStartWorkday** | **String**| The start work day of comparative period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **primaryPeriodStartWorkday** | **String**| The start work day of primary period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **sortKey** | **string**| Sort key | <br />**Values**: percentOfGoal, percentOfGoalChange, overallPercentOfGoal, overallPercentOfGoalChange, value, valueChange |
| **sortMetricId** | **string**| Sort Metric Id | [optional]  |
| **sectionSize** | **int?**| The number of top and bottom users to return before ties | [optional]  |
| **userIds** | **string**| A list of up to 100 comma-separated user Ids | [optional]  |
| **reportsTo** | **string**| The reportsTo used by ABAC policies. | [optional]  |

### Return type

[**InsightsRankings**](InsightsRankings)


## GetGamificationInsightsTrends

> [**UserInsightsTrend**](UserInsightsTrend) GetGamificationInsightsTrends (string filterType, string filterId, string granularity, String comparativePeriodStartWorkday, String comparativePeriodEndWorkday, String primaryPeriodStartWorkday, String primaryPeriodEndWorkday)


Get insights user trend for the current user

Requires ANY permissions: 

* gamification:insights:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationInsightsTrendsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var filterType = filterType_example;  // string | Filter type for the query request.
            var filterId = filterId_example;  // string | ID for the filter type.
            var granularity = granularity_example;  // string | Granularity
            var comparativePeriodStartWorkday = 2013-10-20;  // String | The start work day of comparative period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var comparativePeriodEndWorkday = 2013-10-20;  // String | The end work day of comparative period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var primaryPeriodStartWorkday = 2013-10-20;  // String | The start work day of primary period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var primaryPeriodEndWorkday = 2013-10-20;  // String | The end work day of primary period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd

            try
            { 
                // Get insights user trend for the current user
                UserInsightsTrend result = apiInstance.GetGamificationInsightsTrends(filterType, filterId, granularity, comparativePeriodStartWorkday, comparativePeriodEndWorkday, primaryPeriodStartWorkday, primaryPeriodEndWorkday);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationInsightsTrends: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **filterType** | **string**| Filter type for the query request. | <br />**Values**: PerformanceProfile, Division |
| **filterId** | **string**| ID for the filter type. |  |
| **granularity** | **string**| Granularity | <br />**Values**: Daily, Weekly |
| **comparativePeriodStartWorkday** | **String**| The start work day of comparative period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **comparativePeriodEndWorkday** | **String**| The end work day of comparative period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **primaryPeriodStartWorkday** | **String**| The start work day of primary period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **primaryPeriodEndWorkday** | **String**| The end work day of primary period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |

### Return type

[**UserInsightsTrend**](UserInsightsTrend)


## GetGamificationInsightsUserDetails

> [**InsightsDetails**](InsightsDetails) GetGamificationInsightsUserDetails (string userId, string filterType, string filterId, string granularity, String comparativePeriodStartWorkday, String primaryPeriodStartWorkday)


Get insights details for the user

Requires ANY permissions: 

* gamification:insights:viewAll

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationInsightsUserDetailsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var userId = userId_example;  // string | The ID of a user.
            var filterType = filterType_example;  // string | Filter type for the query request.
            var filterId = filterId_example;  // string | ID for the filter type.
            var granularity = granularity_example;  // string | Granularity
            var comparativePeriodStartWorkday = 2013-10-20;  // String | The start work day of comparative period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var primaryPeriodStartWorkday = 2013-10-20;  // String | The start work day of primary period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd

            try
            { 
                // Get insights details for the user
                InsightsDetails result = apiInstance.GetGamificationInsightsUserDetails(userId, filterType, filterId, granularity, comparativePeriodStartWorkday, primaryPeriodStartWorkday);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationInsightsUserDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| The ID of a user. |  |
| **filterType** | **string**| Filter type for the query request. | <br />**Values**: PerformanceProfile, Division |
| **filterId** | **string**| ID for the filter type. |  |
| **granularity** | **string**| Granularity | <br />**Values**: Weekly, Monthly |
| **comparativePeriodStartWorkday** | **String**| The start work day of comparative period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **primaryPeriodStartWorkday** | **String**| The start work day of primary period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |

### Return type

[**InsightsDetails**](InsightsDetails)


## GetGamificationInsightsUserTrends

> [**UserInsightsTrend**](UserInsightsTrend) GetGamificationInsightsUserTrends (string userId, string filterType, string filterId, string granularity, String comparativePeriodStartWorkday, String comparativePeriodEndWorkday, String primaryPeriodStartWorkday, String primaryPeriodEndWorkday)


Get insights user trend for the user

Requires ANY permissions: 

* gamification:insights:viewAll

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationInsightsUserTrendsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var userId = userId_example;  // string | The ID of a user.
            var filterType = filterType_example;  // string | Filter type for the query request.
            var filterId = filterId_example;  // string | ID for the filter type.
            var granularity = granularity_example;  // string | Granularity
            var comparativePeriodStartWorkday = 2013-10-20;  // String | The start work day of comparative period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var comparativePeriodEndWorkday = 2013-10-20;  // String | The end work day of comparative period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var primaryPeriodStartWorkday = 2013-10-20;  // String | The start work day of primary period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var primaryPeriodEndWorkday = 2013-10-20;  // String | The end work day of primary period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd

            try
            { 
                // Get insights user trend for the user
                UserInsightsTrend result = apiInstance.GetGamificationInsightsUserTrends(userId, filterType, filterId, granularity, comparativePeriodStartWorkday, comparativePeriodEndWorkday, primaryPeriodStartWorkday, primaryPeriodEndWorkday);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationInsightsUserTrends: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| The ID of a user. |  |
| **filterType** | **string**| Filter type for the query request. | <br />**Values**: PerformanceProfile, Division |
| **filterId** | **string**| ID for the filter type. |  |
| **granularity** | **string**| Granularity | <br />**Values**: Daily, Weekly |
| **comparativePeriodStartWorkday** | **String**| The start work day of comparative period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **comparativePeriodEndWorkday** | **String**| The end work day of comparative period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **primaryPeriodStartWorkday** | **String**| The start work day of primary period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **primaryPeriodEndWorkday** | **String**| The end work day of primary period. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |

### Return type

[**UserInsightsTrend**](UserInsightsTrend)


## GetGamificationLeaderboard

> [**Leaderboard**](Leaderboard) GetGamificationLeaderboard (String startWorkday, String endWorkday, string metricId = null)


Leaderboard of the requesting user's division or performance profile

Requires ANY permissions: 

* gamification:leaderboard:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationLeaderboardExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var startWorkday = 2013-10-20;  // String | Start workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var endWorkday = 2013-10-20;  // String | End workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var metricId = metricId_example;  // string | Metric Id for which the leaderboard is to be generated. The total points is used if nothing is given. (optional) 

            try
            { 
                // Leaderboard of the requesting user's division or performance profile
                Leaderboard result = apiInstance.GetGamificationLeaderboard(startWorkday, endWorkday, metricId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationLeaderboard: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **startWorkday** | **String**| Start workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **endWorkday** | **String**| End workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **metricId** | **string**| Metric Id for which the leaderboard is to be generated. The total points is used if nothing is given. | [optional]  |

### Return type

[**Leaderboard**](Leaderboard)


## GetGamificationLeaderboardAll

> [**Leaderboard**](Leaderboard) GetGamificationLeaderboardAll (string filterType, string filterId, String startWorkday, String endWorkday, string metricId = null)


Leaderboard by filter type

Requires ANY permissions: 

* gamification:leaderboard:viewAll

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationLeaderboardAllExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var filterType = filterType_example;  // string | Filter type for the query request.
            var filterId = filterId_example;  // string | ID for the filter type. For example, division or performance profile Id
            var startWorkday = 2013-10-20;  // String | Start workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var endWorkday = 2013-10-20;  // String | End workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var metricId = metricId_example;  // string | Metric Id for which the leaderboard is to be generated. The total points is used if nothing is given. (optional) 

            try
            { 
                // Leaderboard by filter type
                Leaderboard result = apiInstance.GetGamificationLeaderboardAll(filterType, filterId, startWorkday, endWorkday, metricId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationLeaderboardAll: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **filterType** | **string**| Filter type for the query request. | <br />**Values**: PerformanceProfile, Division |
| **filterId** | **string**| ID for the filter type. For example, division or performance profile Id |  |
| **startWorkday** | **String**| Start workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **endWorkday** | **String**| End workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **metricId** | **string**| Metric Id for which the leaderboard is to be generated. The total points is used if nothing is given. | [optional]  |

### Return type

[**Leaderboard**](Leaderboard)


## GetGamificationLeaderboardAllBestpoints

> [**OverallBestPoints**](OverallBestPoints) GetGamificationLeaderboardAllBestpoints (string filterType, string filterId)


Best Points by division or performance profile

Requires ANY permissions: 

* gamification:leaderboard:viewAll

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationLeaderboardAllBestpointsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var filterType = filterType_example;  // string | Filter type for the query request.
            var filterId = filterId_example;  // string | ID for the filter type. For example, division or performance profile Id

            try
            { 
                // Best Points by division or performance profile
                OverallBestPoints result = apiInstance.GetGamificationLeaderboardAllBestpoints(filterType, filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationLeaderboardAllBestpoints: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **filterType** | **string**| Filter type for the query request. | <br />**Values**: PerformanceProfile, Division |
| **filterId** | **string**| ID for the filter type. For example, division or performance profile Id |  |

### Return type

[**OverallBestPoints**](OverallBestPoints)


## GetGamificationLeaderboardBestpoints

> [**OverallBestPoints**](OverallBestPoints) GetGamificationLeaderboardBestpoints ()


Best Points of the requesting user's current performance profile or division

Requires ANY permissions: 

* gamification:leaderboard:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationLeaderboardBestpointsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();

            try
            { 
                // Best Points of the requesting user's current performance profile or division
                OverallBestPoints result = apiInstance.GetGamificationLeaderboardBestpoints();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationLeaderboardBestpoints: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**OverallBestPoints**](OverallBestPoints)


## GetGamificationMetricdefinition

> [**MetricDefinition**](MetricDefinition) GetGamificationMetricdefinition (string metricDefinitionId)


Metric definition by id

Requires ANY permissions: 

* gamification:profile:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationMetricdefinitionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var metricDefinitionId = metricDefinitionId_example;  // string | metric definition id

            try
            { 
                // Metric definition by id
                MetricDefinition result = apiInstance.GetGamificationMetricdefinition(metricDefinitionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationMetricdefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **metricDefinitionId** | **string**| metric definition id |  |

### Return type

[**MetricDefinition**](MetricDefinition)


## GetGamificationMetricdefinitions

> [**GetMetricDefinitionsResponse**](GetMetricDefinitionsResponse) GetGamificationMetricdefinitions ()


All metric definitions

Retrieves the metric definitions and their corresponding default objectives used to create a gamified metric

Requires ANY permissions: 

* gamification:profile:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationMetricdefinitionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();

            try
            { 
                // All metric definitions
                GetMetricDefinitionsResponse result = apiInstance.GetGamificationMetricdefinitions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationMetricdefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**GetMetricDefinitionsResponse**](GetMetricDefinitionsResponse)


## GetGamificationProfile

> [**PerformanceProfile**](PerformanceProfile) GetGamificationProfile (string profileId)


Performance profile by id

Requires ANY permissions: 

* gamification:profile:view
* gamification:leaderboard:viewAll
* gamification:scorecard:viewAll

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationProfileExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var profileId = profileId_example;  // string | performanceProfileId

            try
            { 
                // Performance profile by id
                PerformanceProfile result = apiInstance.GetGamificationProfile(profileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **profileId** | **string**| performanceProfileId |  |

### Return type

[**PerformanceProfile**](PerformanceProfile)


## GetGamificationProfileMembers

> [**MemberListing**](MemberListing) GetGamificationProfileMembers (string profileId)


Members of a given performance profile

Requires ANY permissions: 

* gamification:profile:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationProfileMembersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var profileId = profileId_example;  // string | Profile Id

            try
            { 
                // Members of a given performance profile
                MemberListing result = apiInstance.GetGamificationProfileMembers(profileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationProfileMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **profileId** | **string**| Profile Id |  |

### Return type

[**MemberListing**](MemberListing)


## GetGamificationProfileMetric

> [**Metric**](Metric) GetGamificationProfileMetric (string profileId, string metricId, String workday = null)


Performance profile gamified metric by id

Requires ANY permissions: 

* gamification:profile:view
* gamification:leaderboard:view
* gamification:scorecard:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationProfileMetricExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var profileId = profileId_example;  // string | Performance Profile Id
            var metricId = metricId_example;  // string | Metric Id
            var workday = 2013-10-20;  // String | The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional) 

            try
            { 
                // Performance profile gamified metric by id
                Metric result = apiInstance.GetGamificationProfileMetric(profileId, metricId, workday);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationProfileMetric: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **profileId** | **string**| Performance Profile Id |  |
| **metricId** | **string**| Metric Id |  |
| **workday** | **String**| The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional]  |

### Return type

[**Metric**](Metric)


## GetGamificationProfileMetrics

> [**GetMetricResponse**](GetMetricResponse) GetGamificationProfileMetrics (string profileId, List<string> expand = null, String workday = null, string metricIds = null)


All gamified metrics for a given performance profile

Requires ANY permissions: 

* gamification:profile:view
* gamification:leaderboard:view
* gamification:scorecard:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationProfileMetricsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var profileId = profileId_example;  // string | Performance Profile Id
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 
            var workday = 2013-10-20;  // String | The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional) 
            var metricIds = metricIds_example;  // string | List of metric ids to filter the response (Optional, comma-separated). (optional) 

            try
            { 
                // All gamified metrics for a given performance profile
                GetMetricResponse result = apiInstance.GetGamificationProfileMetrics(profileId, expand, workday, metricIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationProfileMetrics: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **profileId** | **string**| Performance Profile Id |  |
| **expand** | [**List<string>**](string)| Which fields, if any, to expand. | [optional] <br />**Values**: objective |
| **workday** | **String**| The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional]  |
| **metricIds** | **string**| List of metric ids to filter the response (Optional, comma-separated). | [optional]  |

### Return type

[**GetMetricResponse**](GetMetricResponse)


## GetGamificationProfileMetricsObjectivedetails

> [**GetMetricsResponse**](GetMetricsResponse) GetGamificationProfileMetricsObjectivedetails (string profileId, String workday = null)


All metrics for a given performance profile with objective details such as order and maxPoints

Requires ANY permissions: 

* gamification:profile:view
* gamification:leaderboard:view
* gamification:scorecard:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationProfileMetricsObjectivedetailsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var profileId = profileId_example;  // string | Performance Profile Id
            var workday = 2013-10-20;  // String | The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional) 

            try
            { 
                // All metrics for a given performance profile with objective details such as order and maxPoints
                GetMetricsResponse result = apiInstance.GetGamificationProfileMetricsObjectivedetails(profileId, workday);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationProfileMetricsObjectivedetails: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **profileId** | **string**| Performance Profile Id |  |
| **workday** | **String**| The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional]  |

### Return type

[**GetMetricsResponse**](GetMetricsResponse)


## GetGamificationProfiles

> [**GetProfilesResponse**](GetProfilesResponse) GetGamificationProfiles ()


All performance profiles

Requires ANY permissions: 

* gamification:profile:view
* gamification:leaderboard:viewAll
* gamification:scorecard:viewAll

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationProfilesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();

            try
            { 
                // All performance profiles
                GetProfilesResponse result = apiInstance.GetGamificationProfiles();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationProfiles: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**GetProfilesResponse**](GetProfilesResponse)


## GetGamificationProfilesUser

> [**PerformanceProfile**](PerformanceProfile) GetGamificationProfilesUser (string userId, String workday = null)


Performance profile of a user

Requires ANY permissions: 

* gamification:profile:view
* gamification:scorecard:viewAll
* gamification:leaderboard:viewAll

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationProfilesUserExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var userId = userId_example;  // string | 
            var workday = 2013-10-20;  // String | Target querying workday. If not provided, then queries the current performance profile. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional) 

            try
            { 
                // Performance profile of a user
                PerformanceProfile result = apiInstance.GetGamificationProfilesUser(userId, workday);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationProfilesUser: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**|  |  |
| **workday** | **String**| Target querying workday. If not provided, then queries the current performance profile. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional]  |

### Return type

[**PerformanceProfile**](PerformanceProfile)


## GetGamificationProfilesUsersMe

> [**PerformanceProfile**](PerformanceProfile) GetGamificationProfilesUsersMe (String workday = null)


Performance profile of the requesting user

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
    public class GetGamificationProfilesUsersMeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var workday = 2013-10-20;  // String | Target querying workday. If not provided, then queries the current performance profile. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional) 

            try
            { 
                // Performance profile of the requesting user
                PerformanceProfile result = apiInstance.GetGamificationProfilesUsersMe(workday);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationProfilesUsersMe: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workday** | **String**| Target querying workday. If not provided, then queries the current performance profile. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional]  |

### Return type

[**PerformanceProfile**](PerformanceProfile)


## GetGamificationScorecards

> [**WorkdayMetricListing**](WorkdayMetricListing) GetGamificationScorecards (String workday, List<string> expand = null)


Workday performance metrics of the requesting user

Requires ANY permissions: 

* gamification:scorecard:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationScorecardsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var workday = 2013-10-20;  // String | Target querying workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 

            try
            { 
                // Workday performance metrics of the requesting user
                WorkdayMetricListing result = apiInstance.GetGamificationScorecards(workday, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationScorecards: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workday** | **String**| Target querying workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **expand** | [**List<string>**](string)| Which fields, if any, to expand. | [optional] <br />**Values**: objective |

### Return type

[**WorkdayMetricListing**](WorkdayMetricListing)


## GetGamificationScorecardsAttendance

> [**AttendanceStatusListing**](AttendanceStatusListing) GetGamificationScorecardsAttendance (String startWorkday, String endWorkday)


Attendance status metrics of the requesting user

Requires ANY permissions: 

* gamification:scorecard:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationScorecardsAttendanceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var startWorkday = 2013-10-20;  // String | Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var endWorkday = 2013-10-20;  // String | End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd

            try
            { 
                // Attendance status metrics of the requesting user
                AttendanceStatusListing result = apiInstance.GetGamificationScorecardsAttendance(startWorkday, endWorkday);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationScorecardsAttendance: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **startWorkday** | **String**| Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **endWorkday** | **String**| End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |

### Return type

[**AttendanceStatusListing**](AttendanceStatusListing)


## GetGamificationScorecardsBestpoints

> [**UserBestPoints**](UserBestPoints) GetGamificationScorecardsBestpoints ()


Best points of the requesting user

Requires ANY permissions: 

* gamification:scorecard:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationScorecardsBestpointsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();

            try
            { 
                // Best points of the requesting user
                UserBestPoints result = apiInstance.GetGamificationScorecardsBestpoints();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationScorecardsBestpoints: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**UserBestPoints**](UserBestPoints)


## GetGamificationScorecardsPointsAlltime

> [**AllTimePoints**](AllTimePoints) GetGamificationScorecardsPointsAlltime (String endWorkday)


All-time points of the requesting user

Requires ANY permissions: 

* gamification:scorecard:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationScorecardsPointsAlltimeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var endWorkday = 2013-10-20;  // String | End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd

            try
            { 
                // All-time points of the requesting user
                AllTimePoints result = apiInstance.GetGamificationScorecardsPointsAlltime(endWorkday);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationScorecardsPointsAlltime: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **endWorkday** | **String**| End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |

### Return type

[**AllTimePoints**](AllTimePoints)


## GetGamificationScorecardsPointsAverage

> [**SingleWorkdayAveragePoints**](SingleWorkdayAveragePoints) GetGamificationScorecardsPointsAverage (String workday)


Average points of the requesting user's division or performance profile

Requires ANY permissions: 

* gamification:scorecard:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationScorecardsPointsAverageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var workday = 2013-10-20;  // String | The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd

            try
            { 
                // Average points of the requesting user's division or performance profile
                SingleWorkdayAveragePoints result = apiInstance.GetGamificationScorecardsPointsAverage(workday);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationScorecardsPointsAverage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workday** | **String**| The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |

### Return type

[**SingleWorkdayAveragePoints**](SingleWorkdayAveragePoints)


## GetGamificationScorecardsPointsTrends

> [**WorkdayPointsTrend**](WorkdayPointsTrend) GetGamificationScorecardsPointsTrends (String startWorkday, String endWorkday, string dayOfWeek = null)


Points trends of the requesting user

Requires ANY permissions: 

* gamification:scorecard:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationScorecardsPointsTrendsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var startWorkday = 2013-10-20;  // String | Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var endWorkday = 2013-10-20;  // String | End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var dayOfWeek = dayOfWeek_example;  // string | Optional filter to specify which day of weeks to be included in the response (optional) 

            try
            { 
                // Points trends of the requesting user
                WorkdayPointsTrend result = apiInstance.GetGamificationScorecardsPointsTrends(startWorkday, endWorkday, dayOfWeek);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationScorecardsPointsTrends: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **startWorkday** | **String**| Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **endWorkday** | **String**| End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **dayOfWeek** | **string**| Optional filter to specify which day of weeks to be included in the response | [optional] <br />**Values**: Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday |

### Return type

[**WorkdayPointsTrend**](WorkdayPointsTrend)


## GetGamificationScorecardsProfileMetricUserValuesTrends

> [**MetricValueTrendAverage**](MetricValueTrendAverage) GetGamificationScorecardsProfileMetricUserValuesTrends (string profileId, string metricId, string userId, String startWorkday, String endWorkday, String referenceWorkday = null, string timeZone = null)


Average performance values trends by metric of a user

Requires ANY permissions: 

* gamification:scorecard:viewAll

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationScorecardsProfileMetricUserValuesTrendsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var profileId = profileId_example;  // string | performanceProfileId
            var metricId = metricId_example;  // string | metricId
            var userId = userId_example;  // string | 
            var startWorkday = 2013-10-20;  // String | Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var endWorkday = 2013-10-20;  // String | End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var referenceWorkday = 2013-10-20;  // String | Reference workday for the trend. Used to determine the associated metric definition. If not set, then the value of endWorkday is used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional) 
            var timeZone = timeZone_example;  // string | Timezone for the workday. Defaults to UTC (optional)  (default to "UTC")

            try
            { 
                // Average performance values trends by metric of a user
                MetricValueTrendAverage result = apiInstance.GetGamificationScorecardsProfileMetricUserValuesTrends(profileId, metricId, userId, startWorkday, endWorkday, referenceWorkday, timeZone);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationScorecardsProfileMetricUserValuesTrends: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **profileId** | **string**| performanceProfileId |  |
| **metricId** | **string**| metricId |  |
| **userId** | **string**|  |  |
| **startWorkday** | **String**| Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **endWorkday** | **String**| End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **referenceWorkday** | **String**| Reference workday for the trend. Used to determine the associated metric definition. If not set, then the value of endWorkday is used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional]  |
| **timeZone** | **string**| Timezone for the workday. Defaults to UTC | [optional] [default to "UTC"] |

### Return type

[**MetricValueTrendAverage**](MetricValueTrendAverage)


## GetGamificationScorecardsProfileMetricUsersValuesTrends

> [**MetricValueTrendAverage**](MetricValueTrendAverage) GetGamificationScorecardsProfileMetricUsersValuesTrends (string profileId, string metricId, string filterType, String startWorkday, String endWorkday, string filterId = null, String referenceWorkday = null, string timeZone = null)


Average performance values trends by metric of a division or a performance profile

Requires ANY permissions: 

* gamification:scorecard:viewAll

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationScorecardsProfileMetricUsersValuesTrendsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var profileId = profileId_example;  // string | performanceProfileId
            var metricId = metricId_example;  // string | metricId
            var filterType = filterType_example;  // string | Filter type for the query request.
            var startWorkday = 2013-10-20;  // String | Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var endWorkday = 2013-10-20;  // String | End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var filterId = filterId_example;  // string | ID for the filter type. Only required when filterType is Division. (optional) 
            var referenceWorkday = 2013-10-20;  // String | Reference workday for the trend. Used to determine the associated metric definition. If not set, then the value of endWorkday is used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional) 
            var timeZone = timeZone_example;  // string | Timezone for the workday. Defaults to UTC (optional)  (default to "UTC")

            try
            { 
                // Average performance values trends by metric of a division or a performance profile
                MetricValueTrendAverage result = apiInstance.GetGamificationScorecardsProfileMetricUsersValuesTrends(profileId, metricId, filterType, startWorkday, endWorkday, filterId, referenceWorkday, timeZone);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationScorecardsProfileMetricUsersValuesTrends: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **profileId** | **string**| performanceProfileId |  |
| **metricId** | **string**| metricId |  |
| **filterType** | **string**| Filter type for the query request. | <br />**Values**: PerformanceProfile, Division |
| **startWorkday** | **String**| Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **endWorkday** | **String**| End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **filterId** | **string**| ID for the filter type. Only required when filterType is Division. | [optional]  |
| **referenceWorkday** | **String**| Reference workday for the trend. Used to determine the associated metric definition. If not set, then the value of endWorkday is used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional]  |
| **timeZone** | **string**| Timezone for the workday. Defaults to UTC | [optional] [default to "UTC"] |

### Return type

[**MetricValueTrendAverage**](MetricValueTrendAverage)


## GetGamificationScorecardsProfileMetricValuesTrends

> [**MetricValueTrendAverage**](MetricValueTrendAverage) GetGamificationScorecardsProfileMetricValuesTrends (string profileId, string metricId, String startWorkday, String endWorkday, string filterType = null, String referenceWorkday = null, string timeZone = null)


Average performance values trends by metric of the requesting user

Requires ANY permissions: 

* gamification:scorecard:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationScorecardsProfileMetricValuesTrendsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var profileId = profileId_example;  // string | performanceProfileId
            var metricId = metricId_example;  // string | metricId
            var startWorkday = 2013-10-20;  // String | Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var endWorkday = 2013-10-20;  // String | End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var filterType = filterType_example;  // string | Filter type for the query request. If not set, returns the values trends of the requesting user (optional) 
            var referenceWorkday = 2013-10-20;  // String | Reference workday for the trend. Used to determine the associated metric definition. If not set, then the value of endWorkday is used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional) 
            var timeZone = timeZone_example;  // string | Timezone for the workday. Defaults to UTC (optional)  (default to "UTC")

            try
            { 
                // Average performance values trends by metric of the requesting user
                MetricValueTrendAverage result = apiInstance.GetGamificationScorecardsProfileMetricValuesTrends(profileId, metricId, startWorkday, endWorkday, filterType, referenceWorkday, timeZone);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationScorecardsProfileMetricValuesTrends: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **profileId** | **string**| performanceProfileId |  |
| **metricId** | **string**| metricId |  |
| **startWorkday** | **String**| Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **endWorkday** | **String**| End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **filterType** | **string**| Filter type for the query request. If not set, returns the values trends of the requesting user | [optional] <br />**Values**: PerformanceProfile, Division |
| **referenceWorkday** | **String**| Reference workday for the trend. Used to determine the associated metric definition. If not set, then the value of endWorkday is used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional]  |
| **timeZone** | **string**| Timezone for the workday. Defaults to UTC | [optional] [default to "UTC"] |

### Return type

[**MetricValueTrendAverage**](MetricValueTrendAverage)


## GetGamificationScorecardsUser

> [**WorkdayMetricListing**](WorkdayMetricListing) GetGamificationScorecardsUser (string userId, String workday, List<string> expand = null)


Workday performance metrics for a user

Requires ANY permissions: 

* gamification:scorecard:viewAll

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationScorecardsUserExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var userId = userId_example;  // string | 
            var workday = 2013-10-20;  // String | Target querying workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 

            try
            { 
                // Workday performance metrics for a user
                WorkdayMetricListing result = apiInstance.GetGamificationScorecardsUser(userId, workday, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationScorecardsUser: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**|  |  |
| **workday** | **String**| Target querying workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **expand** | [**List<string>**](string)| Which fields, if any, to expand. | [optional] <br />**Values**: objective |

### Return type

[**WorkdayMetricListing**](WorkdayMetricListing)


## GetGamificationScorecardsUserAttendance

> [**AttendanceStatusListing**](AttendanceStatusListing) GetGamificationScorecardsUserAttendance (string userId, String startWorkday, String endWorkday)


Attendance status metrics for a user

Requires ANY permissions: 

* gamification:scorecard:viewAll

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationScorecardsUserAttendanceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var userId = userId_example;  // string | 
            var startWorkday = 2013-10-20;  // String | Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var endWorkday = 2013-10-20;  // String | End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd

            try
            { 
                // Attendance status metrics for a user
                AttendanceStatusListing result = apiInstance.GetGamificationScorecardsUserAttendance(userId, startWorkday, endWorkday);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationScorecardsUserAttendance: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**|  |  |
| **startWorkday** | **String**| Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **endWorkday** | **String**| End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |

### Return type

[**AttendanceStatusListing**](AttendanceStatusListing)


## GetGamificationScorecardsUserBestpoints

> [**UserBestPoints**](UserBestPoints) GetGamificationScorecardsUserBestpoints (string userId)


Best points of a user

Requires ANY permissions: 

* gamification:scorecard:viewAll

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationScorecardsUserBestpointsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var userId = userId_example;  // string | 

            try
            { 
                // Best points of a user
                UserBestPoints result = apiInstance.GetGamificationScorecardsUserBestpoints(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationScorecardsUserBestpoints: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**|  |  |

### Return type

[**UserBestPoints**](UserBestPoints)


## GetGamificationScorecardsUserPointsAlltime

> [**AllTimePoints**](AllTimePoints) GetGamificationScorecardsUserPointsAlltime (string userId, String endWorkday)


All-time points for a user

Requires ANY permissions: 

* gamification:scorecard:viewAll

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationScorecardsUserPointsAlltimeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var userId = userId_example;  // string | 
            var endWorkday = 2013-10-20;  // String | End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd

            try
            { 
                // All-time points for a user
                AllTimePoints result = apiInstance.GetGamificationScorecardsUserPointsAlltime(userId, endWorkday);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationScorecardsUserPointsAlltime: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**|  |  |
| **endWorkday** | **String**| End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |

### Return type

[**AllTimePoints**](AllTimePoints)


## GetGamificationScorecardsUserPointsTrends

> [**WorkdayPointsTrend**](WorkdayPointsTrend) GetGamificationScorecardsUserPointsTrends (string userId, String startWorkday, String endWorkday, string dayOfWeek = null)


Points trend for a user

Requires ANY permissions: 

* gamification:scorecard:viewAll

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationScorecardsUserPointsTrendsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var userId = userId_example;  // string | 
            var startWorkday = 2013-10-20;  // String | Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var endWorkday = 2013-10-20;  // String | End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var dayOfWeek = dayOfWeek_example;  // string | Optional filter to specify which day of weeks to be included in the response (optional) 

            try
            { 
                // Points trend for a user
                WorkdayPointsTrend result = apiInstance.GetGamificationScorecardsUserPointsTrends(userId, startWorkday, endWorkday, dayOfWeek);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationScorecardsUserPointsTrends: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**|  |  |
| **startWorkday** | **String**| Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **endWorkday** | **String**| End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **dayOfWeek** | **string**| Optional filter to specify which day of weeks to be included in the response | [optional] <br />**Values**: Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday |

### Return type

[**WorkdayPointsTrend**](WorkdayPointsTrend)


## GetGamificationScorecardsUserValuesTrends

> [**WorkdayValuesTrend**](WorkdayValuesTrend) GetGamificationScorecardsUserValuesTrends (string userId, String startWorkday, String endWorkday, string timeZone = null)


Values trends of a user

Requires ANY permissions: 

* gamification:scorecard:viewAll

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationScorecardsUserValuesTrendsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var userId = userId_example;  // string | 
            var startWorkday = 2013-10-20;  // String | Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var endWorkday = 2013-10-20;  // String | End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var timeZone = timeZone_example;  // string | Timezone for the workday. Defaults to UTC (optional)  (default to "UTC")

            try
            { 
                // Values trends of a user
                WorkdayValuesTrend result = apiInstance.GetGamificationScorecardsUserValuesTrends(userId, startWorkday, endWorkday, timeZone);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationScorecardsUserValuesTrends: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**|  |  |
| **startWorkday** | **String**| Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **endWorkday** | **String**| End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **timeZone** | **string**| Timezone for the workday. Defaults to UTC | [optional] [default to "UTC"] |

### Return type

[**WorkdayValuesTrend**](WorkdayValuesTrend)


## GetGamificationScorecardsUsersPointsAverage

> [**SingleWorkdayAveragePoints**](SingleWorkdayAveragePoints) GetGamificationScorecardsUsersPointsAverage (string filterType, string filterId, String workday)


Workday average points by target group

Requires ANY permissions: 

* gamification:scorecard:viewAll

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationScorecardsUsersPointsAverageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var filterType = filterType_example;  // string | Filter type for the query request.
            var filterId = filterId_example;  // string | ID for the filter type.
            var workday = 2013-10-20;  // String | The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd

            try
            { 
                // Workday average points by target group
                SingleWorkdayAveragePoints result = apiInstance.GetGamificationScorecardsUsersPointsAverage(filterType, filterId, workday);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationScorecardsUsersPointsAverage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **filterType** | **string**| Filter type for the query request. | <br />**Values**: PerformanceProfile, Division |
| **filterId** | **string**| ID for the filter type. |  |
| **workday** | **String**| The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |

### Return type

[**SingleWorkdayAveragePoints**](SingleWorkdayAveragePoints)


## GetGamificationScorecardsUsersValuesAverage

> [**SingleWorkdayAverageValues**](SingleWorkdayAverageValues) GetGamificationScorecardsUsersValuesAverage (string filterType, string filterId, String workday, string timeZone = null)


Workday average values by target group

Requires ANY permissions: 

* gamification:scorecard:viewAll

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationScorecardsUsersValuesAverageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var filterType = filterType_example;  // string | Filter type for the query request.
            var filterId = filterId_example;  // string | ID for the filter type. For example, division Id
            var workday = 2013-10-20;  // String | The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var timeZone = timeZone_example;  // string | Timezone for the workday. Defaults to UTC (optional)  (default to "UTC")

            try
            { 
                // Workday average values by target group
                SingleWorkdayAverageValues result = apiInstance.GetGamificationScorecardsUsersValuesAverage(filterType, filterId, workday, timeZone);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationScorecardsUsersValuesAverage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **filterType** | **string**| Filter type for the query request. | <br />**Values**: PerformanceProfile, Division |
| **filterId** | **string**| ID for the filter type. For example, division Id |  |
| **workday** | **String**| The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **timeZone** | **string**| Timezone for the workday. Defaults to UTC | [optional] [default to "UTC"] |

### Return type

[**SingleWorkdayAverageValues**](SingleWorkdayAverageValues)


## GetGamificationScorecardsUsersValuesTrends

> [**WorkdayValuesTrend**](WorkdayValuesTrend) GetGamificationScorecardsUsersValuesTrends (string filterType, string filterId, String startWorkday, String endWorkday, string timeZone = null)


Values trend by target group

Requires ANY permissions: 

* gamification:scorecard:viewAll

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationScorecardsUsersValuesTrendsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var filterType = filterType_example;  // string | Filter type for the query request.
            var filterId = filterId_example;  // string | ID for the filter type.
            var startWorkday = 2013-10-20;  // String | Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var endWorkday = 2013-10-20;  // String | End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var timeZone = timeZone_example;  // string | Timezone for the workday. Defaults to UTC (optional)  (default to "UTC")

            try
            { 
                // Values trend by target group
                WorkdayValuesTrend result = apiInstance.GetGamificationScorecardsUsersValuesTrends(filterType, filterId, startWorkday, endWorkday, timeZone);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationScorecardsUsersValuesTrends: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **filterType** | **string**| Filter type for the query request. | <br />**Values**: PerformanceProfile, Division |
| **filterId** | **string**| ID for the filter type. |  |
| **startWorkday** | **String**| Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **endWorkday** | **String**| End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **timeZone** | **string**| Timezone for the workday. Defaults to UTC | [optional] [default to "UTC"] |

### Return type

[**WorkdayValuesTrend**](WorkdayValuesTrend)


## GetGamificationScorecardsValuesAverage

> [**SingleWorkdayAverageValues**](SingleWorkdayAverageValues) GetGamificationScorecardsValuesAverage (String workday, string timeZone = null)


Average values of the requesting user's division or performance profile

Requires ANY permissions: 

* gamification:scorecard:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationScorecardsValuesAverageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var workday = 2013-10-20;  // String | The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var timeZone = timeZone_example;  // string | Timezone for the workday. Defaults to UTC (optional)  (default to "UTC")

            try
            { 
                // Average values of the requesting user's division or performance profile
                SingleWorkdayAverageValues result = apiInstance.GetGamificationScorecardsValuesAverage(workday, timeZone);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationScorecardsValuesAverage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workday** | **String**| The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **timeZone** | **string**| Timezone for the workday. Defaults to UTC | [optional] [default to "UTC"] |

### Return type

[**SingleWorkdayAverageValues**](SingleWorkdayAverageValues)


## GetGamificationScorecardsValuesTrends

> [**WorkdayValuesTrend**](WorkdayValuesTrend) GetGamificationScorecardsValuesTrends (String startWorkday, String endWorkday, string filterType = null, String referenceWorkday = null, string timeZone = null)


Values trends of the requesting user or group

Requires ANY permissions: 

* gamification:scorecard:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationScorecardsValuesTrendsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var startWorkday = 2013-10-20;  // String | Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var endWorkday = 2013-10-20;  // String | End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var filterType = filterType_example;  // string | Filter type for the query request. If not set, then the request is for the requesting user. (optional) 
            var referenceWorkday = 2013-10-20;  // String | Reference workday for the trend. Used to determine the profile of the user as of this date. If not set, then the user's current profile will be used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional) 
            var timeZone = timeZone_example;  // string | Timezone for the workday. Defaults to UTC (optional)  (default to "UTC")

            try
            { 
                // Values trends of the requesting user or group
                WorkdayValuesTrend result = apiInstance.GetGamificationScorecardsValuesTrends(startWorkday, endWorkday, filterType, referenceWorkday, timeZone);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationScorecardsValuesTrends: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **startWorkday** | **String**| Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **endWorkday** | **String**| End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **filterType** | **string**| Filter type for the query request. If not set, then the request is for the requesting user. | [optional] <br />**Values**: PerformanceProfile, Division |
| **referenceWorkday** | **String**| Reference workday for the trend. Used to determine the profile of the user as of this date. If not set, then the user&#39;s current profile will be used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional]  |
| **timeZone** | **string**| Timezone for the workday. Defaults to UTC | [optional] [default to "UTC"] |

### Return type

[**WorkdayValuesTrend**](WorkdayValuesTrend)


## GetGamificationStatus

> [**GamificationStatus**](GamificationStatus) GetGamificationStatus ()


Gamification activation status

Requires ANY permissions: 

* gamification:profile:view
* gamification:profile:update
* gamification:scorecard:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationStatusExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();

            try
            { 
                // Gamification activation status
                GamificationStatus result = apiInstance.GetGamificationStatus();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**GamificationStatus**](GamificationStatus)


## GetGamificationTemplate

> [**ObjectiveTemplate**](ObjectiveTemplate) GetGamificationTemplate (string templateId)


Objective template by id

Requires ANY permissions: 

* gamification:profile:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationTemplateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var templateId = templateId_example;  // string | template id

            try
            { 
                // Objective template by id
                ObjectiveTemplate result = apiInstance.GetGamificationTemplate(templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **templateId** | **string**| template id |  |

### Return type

[**ObjectiveTemplate**](ObjectiveTemplate)


## GetGamificationTemplates

> [**GetTemplatesResponse**](GetTemplatesResponse) GetGamificationTemplates ()


All objective templates

Requires ANY permissions: 

* gamification:profile:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGamificationTemplatesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();

            try
            { 
                // All objective templates
                GetTemplatesResponse result = apiInstance.GetGamificationTemplates();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**GetTemplatesResponse**](GetTemplatesResponse)


## PatchEmployeeperformanceExternalmetricsDefinition

> [**ExternalMetricDefinition**](ExternalMetricDefinition) PatchEmployeeperformanceExternalmetricsDefinition (string metricId, ExternalMetricDefinitionUpdateRequest body)


Update External Metric Definition

Requires ANY permissions: 

* employeePerformance:externalMetricDefinition:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchEmployeeperformanceExternalmetricsDefinitionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var metricId = metricId_example;  // string | Specifies the metric definition ID
            var body = new ExternalMetricDefinitionUpdateRequest(); // ExternalMetricDefinitionUpdateRequest | The External Metric Definition parameters to be updated

            try
            { 
                // Update External Metric Definition
                ExternalMetricDefinition result = apiInstance.PatchEmployeeperformanceExternalmetricsDefinition(metricId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.PatchEmployeeperformanceExternalmetricsDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **metricId** | **string**| Specifies the metric definition ID |  |
| **body** | [**ExternalMetricDefinitionUpdateRequest**](ExternalMetricDefinitionUpdateRequest)| The External Metric Definition parameters to be updated |  |

### Return type

[**ExternalMetricDefinition**](ExternalMetricDefinition)


## PatchGamificationContest

> [**ContestsResponse**](ContestsResponse) PatchGamificationContest (string contestId, ContestsFinalizeRequest body)


Finalize a Contest by Id

Requires ANY permissions: 

* gamification:contestStatus:edit
* gamification:contestStatus:editAll

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchGamificationContestExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var contestId = contestId_example;  // string | The ID of the contest
            var body = new ContestsFinalizeRequest(); // ContestsFinalizeRequest | Finalize Contest

            try
            { 
                // Finalize a Contest by Id
                ContestsResponse result = apiInstance.PatchGamificationContest(contestId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.PatchGamificationContest: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contestId** | **string**| The ID of the contest |  |
| **body** | [**ContestsFinalizeRequest**](ContestsFinalizeRequest)| Finalize Contest |  |

### Return type

[**ContestsResponse**](ContestsResponse)


## PostEmployeeperformanceExternalmetricsData

> [**ExternalMetricDataWriteResponse**](ExternalMetricDataWriteResponse) PostEmployeeperformanceExternalmetricsData (ExternalMetricDataWriteRequest body = null)


Write External Metric Data

Requires ANY permissions: 

* employeePerformance:externalMetricData:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostEmployeeperformanceExternalmetricsDataExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var body = new ExternalMetricDataWriteRequest(); // ExternalMetricDataWriteRequest | The External Metric Data to be added (optional) 

            try
            { 
                // Write External Metric Data
                ExternalMetricDataWriteResponse result = apiInstance.PostEmployeeperformanceExternalmetricsData(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.PostEmployeeperformanceExternalmetricsData: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ExternalMetricDataWriteRequest**](ExternalMetricDataWriteRequest)| The External Metric Data to be added | [optional]  |

### Return type

[**ExternalMetricDataWriteResponse**](ExternalMetricDataWriteResponse)


## PostEmployeeperformanceExternalmetricsDefinitions

> [**ExternalMetricDefinition**](ExternalMetricDefinition) PostEmployeeperformanceExternalmetricsDefinitions (ExternalMetricDefinitionCreateRequest body = null)


Create External Metric Definition

Requires ANY permissions: 

* employeePerformance:externalMetricDefinition:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostEmployeeperformanceExternalmetricsDefinitionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var body = new ExternalMetricDefinitionCreateRequest(); // ExternalMetricDefinitionCreateRequest | The External Metric Definition to be created (optional) 

            try
            { 
                // Create External Metric Definition
                ExternalMetricDefinition result = apiInstance.PostEmployeeperformanceExternalmetricsDefinitions(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.PostEmployeeperformanceExternalmetricsDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ExternalMetricDefinitionCreateRequest**](ExternalMetricDefinitionCreateRequest)| The External Metric Definition to be created | [optional]  |

### Return type

[**ExternalMetricDefinition**](ExternalMetricDefinition)


## PostGamificationContests

> [**ContestsResponse**](ContestsResponse) PostGamificationContests (ContestsCreateRequest body)


Creates a Contest

Requires ANY permissions: 

* gamification:contest:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostGamificationContestsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var body = new ContestsCreateRequest(); // ContestsCreateRequest | Create Contest

            try
            { 
                // Creates a Contest
                ContestsResponse result = apiInstance.PostGamificationContests(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.PostGamificationContests: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ContestsCreateRequest**](ContestsCreateRequest)| Create Contest |  |

### Return type

[**ContestsResponse**](ContestsResponse)


## PostGamificationContestsUploadsPrizeimages

> [**UploadUrlResponse**](UploadUrlResponse) PostGamificationContestsUploadsPrizeimages (GamificationContestPrizeImageUploadUrlRequest body)


Generates pre-signed URL to upload a prize image for gamification contests

Requires ALL permissions: 

* gamification:contestPrizeImage:upload

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostGamificationContestsUploadsPrizeimagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var body = new GamificationContestPrizeImageUploadUrlRequest(); // GamificationContestPrizeImageUploadUrlRequest | query

            try
            { 
                // Generates pre-signed URL to upload a prize image for gamification contests
                UploadUrlResponse result = apiInstance.PostGamificationContestsUploadsPrizeimages(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.PostGamificationContestsUploadsPrizeimages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**GamificationContestPrizeImageUploadUrlRequest**](GamificationContestPrizeImageUploadUrlRequest)| query |  |

### Return type

[**UploadUrlResponse**](UploadUrlResponse)


## PostGamificationProfileActivate

> [**PerformanceProfile**](PerformanceProfile) PostGamificationProfileActivate (string profileId)


Activate a performance profile

Requires ANY permissions: 

* gamification:profile:update

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostGamificationProfileActivateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var profileId = profileId_example;  // string | performanceProfileId

            try
            { 
                // Activate a performance profile
                PerformanceProfile result = apiInstance.PostGamificationProfileActivate(profileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.PostGamificationProfileActivate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **profileId** | **string**| performanceProfileId |  |

### Return type

[**PerformanceProfile**](PerformanceProfile)


## PostGamificationProfileDeactivate

> [**PerformanceProfile**](PerformanceProfile) PostGamificationProfileDeactivate (string profileId)


Deactivate a performance profile

Requires ANY permissions: 

* gamification:profile:update

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostGamificationProfileDeactivateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var profileId = profileId_example;  // string | performanceProfileId

            try
            { 
                // Deactivate a performance profile
                PerformanceProfile result = apiInstance.PostGamificationProfileDeactivate(profileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.PostGamificationProfileDeactivate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **profileId** | **string**| performanceProfileId |  |

### Return type

[**PerformanceProfile**](PerformanceProfile)


## PostGamificationProfileMembers

> [**Assignment**](Assignment) PostGamificationProfileMembers (string profileId, AssignUsers body)


Assign members to a given performance profile

Requires ANY permissions: 

* gamification:profile:update

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostGamificationProfileMembersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var profileId = profileId_example;  // string | Profile Id
            var body = new AssignUsers(); // AssignUsers | assignUsers

            try
            { 
                // Assign members to a given performance profile
                Assignment result = apiInstance.PostGamificationProfileMembers(profileId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.PostGamificationProfileMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **profileId** | **string**| Profile Id |  |
| **body** | [**AssignUsers**](AssignUsers)| assignUsers |  |

### Return type

[**Assignment**](Assignment)


## PostGamificationProfileMembersValidate

> [**AssignmentValidation**](AssignmentValidation) PostGamificationProfileMembersValidate (string profileId, ValidateAssignUsers body)


Validate member assignment

Requires ANY permissions: 

* gamification:profile:update

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostGamificationProfileMembersValidateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var profileId = profileId_example;  // string | Profile Id
            var body = new ValidateAssignUsers(); // ValidateAssignUsers | memberAssignments

            try
            { 
                // Validate member assignment
                AssignmentValidation result = apiInstance.PostGamificationProfileMembersValidate(profileId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.PostGamificationProfileMembersValidate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **profileId** | **string**| Profile Id |  |
| **body** | [**ValidateAssignUsers**](ValidateAssignUsers)| memberAssignments |  |

### Return type

[**AssignmentValidation**](AssignmentValidation)


## PostGamificationProfileMetricLink

> [**Metric**](Metric) PostGamificationProfileMetricLink (string sourceProfileId, string sourceMetricId, TargetPerformanceProfile body)


Creates a linked metric

Requires ANY permissions: 

* gamification:profile:update

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostGamificationProfileMetricLinkExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var sourceProfileId = sourceProfileId_example;  // string | Source Performance Profile Id
            var sourceMetricId = sourceMetricId_example;  // string | Source Metric Id
            var body = new TargetPerformanceProfile(); // TargetPerformanceProfile | linkedMetric

            try
            { 
                // Creates a linked metric
                Metric result = apiInstance.PostGamificationProfileMetricLink(sourceProfileId, sourceMetricId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.PostGamificationProfileMetricLink: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sourceProfileId** | **string**| Source Performance Profile Id |  |
| **sourceMetricId** | **string**| Source Metric Id |  |
| **body** | [**TargetPerformanceProfile**](TargetPerformanceProfile)| linkedMetric |  |

### Return type

[**Metric**](Metric)


## PostGamificationProfileMetrics

> [**Metric**](Metric) PostGamificationProfileMetrics (string profileId, CreateMetric body)


Creates a gamified metric with a given metric definition and metric objective under in a performance profile

Requires ALL permissions: 

* gamification:profile:update

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostGamificationProfileMetricsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var profileId = profileId_example;  // string | Performance Profile Id
            var body = new CreateMetric(); // CreateMetric | Metric

            try
            { 
                // Creates a gamified metric with a given metric definition and metric objective under in a performance profile
                Metric result = apiInstance.PostGamificationProfileMetrics(profileId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.PostGamificationProfileMetrics: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **profileId** | **string**| Performance Profile Id |  |
| **body** | [**CreateMetric**](CreateMetric)| Metric |  |

### Return type

[**Metric**](Metric)


## PostGamificationProfiles

> [**PerformanceProfile**](PerformanceProfile) PostGamificationProfiles (CreatePerformanceProfile body, bool? copyMetrics = null)


Create a new custom performance profile

Requires ANY permissions: 

* gamification:profile:update

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostGamificationProfilesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var body = new CreatePerformanceProfile(); // CreatePerformanceProfile | performanceProfile
            var copyMetrics = true;  // bool? | Flag to copy metrics. If set to false, there will be no metrics associated with the new profile. If set to true or is absent (the default behavior), all metrics from the default profile will be copied over into the new profile. (optional)  (default to true)

            try
            { 
                // Create a new custom performance profile
                PerformanceProfile result = apiInstance.PostGamificationProfiles(body, copyMetrics);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.PostGamificationProfiles: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreatePerformanceProfile**](CreatePerformanceProfile)| performanceProfile |  |
| **copyMetrics** | **bool?**| Flag to copy metrics. If set to false, there will be no metrics associated with the new profile. If set to true or is absent (the default behavior), all metrics from the default profile will be copied over into the new profile. | [optional] [default to true] |

### Return type

[**PerformanceProfile**](PerformanceProfile)


## PostGamificationProfilesUserQuery

> [**UserProfilesInDateRange**](UserProfilesInDateRange) PostGamificationProfilesUserQuery (string userId, UserProfilesInDateRangeRequest body)


Query performance profiles in date range for a user

Requires ANY permissions: 

* gamification:agentProfileMembership:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostGamificationProfilesUserQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var userId = userId_example;  // string | The ID of a user.
            var body = new UserProfilesInDateRangeRequest(); // UserProfilesInDateRangeRequest | The date range of work day.

            try
            { 
                // Query performance profiles in date range for a user
                UserProfilesInDateRange result = apiInstance.PostGamificationProfilesUserQuery(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.PostGamificationProfilesUserQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| The ID of a user. |  |
| **body** | [**UserProfilesInDateRangeRequest**](UserProfilesInDateRangeRequest)| The date range of work day. |  |

### Return type

[**UserProfilesInDateRange**](UserProfilesInDateRange)


## PostGamificationProfilesUsersMeQuery

> [**UserProfilesInDateRange**](UserProfilesInDateRange) PostGamificationProfilesUsersMeQuery (UserProfilesInDateRangeRequest body)


Query performance profiles in date range for the current user

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
    public class PostGamificationProfilesUsersMeQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var body = new UserProfilesInDateRangeRequest(); // UserProfilesInDateRangeRequest | The date range of work day.

            try
            { 
                // Query performance profiles in date range for the current user
                UserProfilesInDateRange result = apiInstance.PostGamificationProfilesUsersMeQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.PostGamificationProfilesUsersMeQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UserProfilesInDateRangeRequest**](UserProfilesInDateRangeRequest)| The date range of work day. |  |

### Return type

[**UserProfilesInDateRange**](UserProfilesInDateRange)


## PutGamificationContest

> [**ContestsResponse**](ContestsResponse) PutGamificationContest (string contestId, ContestsCreateRequest body)


Update a Contest by Id

Requires ANY permissions: 

* gamification:contest:edit
* gamification:contest:editAll

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutGamificationContestExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var contestId = contestId_example;  // string | The ID of the contest
            var body = new ContestsCreateRequest(); // ContestsCreateRequest | Contest

            try
            { 
                // Update a Contest by Id
                ContestsResponse result = apiInstance.PutGamificationContest(contestId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.PutGamificationContest: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contestId** | **string**| The ID of the contest |  |
| **body** | [**ContestsCreateRequest**](ContestsCreateRequest)| Contest |  |

### Return type

[**ContestsResponse**](ContestsResponse)


## PutGamificationProfile

> [**PerformanceProfile**](PerformanceProfile) PutGamificationProfile (string profileId, PerformanceProfile body = null)


Updates a performance profile

Requires ANY permissions: 

* gamification:profile:update

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutGamificationProfileExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var profileId = profileId_example;  // string | performanceProfileId
            var body = new PerformanceProfile(); // PerformanceProfile | performanceProfile (optional) 

            try
            { 
                // Updates a performance profile
                PerformanceProfile result = apiInstance.PutGamificationProfile(profileId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.PutGamificationProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **profileId** | **string**| performanceProfileId |  |
| **body** | [**PerformanceProfile**](PerformanceProfile)| performanceProfile | [optional]  |

### Return type

[**PerformanceProfile**](PerformanceProfile)


## PutGamificationProfileMetric

> [**Metric**](Metric) PutGamificationProfileMetric (string profileId, string metricId, CreateMetric body)


Updates a metric in performance profile

Requires ALL permissions: 

* gamification:profile:update

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutGamificationProfileMetricExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var profileId = profileId_example;  // string | Performance Profile Id
            var metricId = metricId_example;  // string | Metric Id
            var body = new CreateMetric(); // CreateMetric | Metric

            try
            { 
                // Updates a metric in performance profile
                Metric result = apiInstance.PutGamificationProfileMetric(profileId, metricId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.PutGamificationProfileMetric: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **profileId** | **string**| Performance Profile Id |  |
| **metricId** | **string**| Metric Id |  |
| **body** | [**CreateMetric**](CreateMetric)| Metric |  |

### Return type

[**Metric**](Metric)


## PutGamificationStatus

> [**GamificationStatus**](GamificationStatus) PutGamificationStatus (GamificationStatus status)


Update gamification activation status

Requires ANY permissions: 

* gamification:profile:update

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutGamificationStatusExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new GamificationApi();
            var status = new GamificationStatus(); // GamificationStatus | Gamification status

            try
            { 
                // Update gamification activation status
                GamificationStatus result = apiInstance.PutGamificationStatus(status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.PutGamificationStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **status** | [**GamificationStatus**](GamificationStatus)| Gamification status |  |

### Return type

[**GamificationStatus**](GamificationStatus)


_PureCloudPlatform.Client.V2 251.0.0_
