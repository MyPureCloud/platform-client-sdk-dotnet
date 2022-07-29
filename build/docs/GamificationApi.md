---
title: GamificationApi
---
## PureCloudPlatform.Client.V2.Api.GamificationApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteEmployeeperformanceExternalmetricsDefinition**](GamificationApi.html#deleteemployeeperformanceexternalmetricsdefinition) | **DELETE** /api/v2/employeeperformance/externalmetrics/definitions/{metricId} | Delete an External Metric Definition |
| [**GetEmployeeperformanceExternalmetricsDefinition**](GamificationApi.html#getemployeeperformanceexternalmetricsdefinition) | **GET** /api/v2/employeeperformance/externalmetrics/definitions/{metricId} | Get an External Metric Definition |
| [**GetEmployeeperformanceExternalmetricsDefinitions**](GamificationApi.html#getemployeeperformanceexternalmetricsdefinitions) | **GET** /api/v2/employeeperformance/externalmetrics/definitions | Get a list of External Metric Definitions of an organization, sorted by name in ascending order |
| [**GetGamificationLeaderboard**](GamificationApi.html#getgamificationleaderboard) | **GET** /api/v2/gamification/leaderboard | Leaderboard of the requesting user&#39;s division or performance profile |
| [**GetGamificationLeaderboardAll**](GamificationApi.html#getgamificationleaderboardall) | **GET** /api/v2/gamification/leaderboard/all | Leaderboard by filter type |
| [**GetGamificationLeaderboardAllBestpoints**](GamificationApi.html#getgamificationleaderboardallbestpoints) | **GET** /api/v2/gamification/leaderboard/all/bestpoints | Best Points by division or performance profile |
| [**GetGamificationLeaderboardBestpoints**](GamificationApi.html#getgamificationleaderboardbestpoints) | **GET** /api/v2/gamification/leaderboard/bestpoints | Best Points of the requesting user&#39;s current performance profile or division |
| [**GetGamificationMetric**](GamificationApi.html#getgamificationmetric) | **GET** /api/v2/gamification/metrics/{metricId} | Gamified metric by id |
| [**GetGamificationMetricdefinition**](GamificationApi.html#getgamificationmetricdefinition) | **GET** /api/v2/gamification/metricdefinitions/{metricDefinitionId} | Metric definition by id |
| [**GetGamificationMetricdefinitions**](GamificationApi.html#getgamificationmetricdefinitions) | **GET** /api/v2/gamification/metricdefinitions | All metric definitions |
| [**GetGamificationMetrics**](GamificationApi.html#getgamificationmetrics) | **GET** /api/v2/gamification/metrics | All gamified metrics for a given profile |
| [**GetGamificationProfile**](GamificationApi.html#getgamificationprofile) | **GET** /api/v2/gamification/profiles/{profileId} | Performance profile by id |
| [**GetGamificationProfileMembers**](GamificationApi.html#getgamificationprofilemembers) | **GET** /api/v2/gamification/profiles/{profileId}/members | Members of a given performance profile |
| [**GetGamificationProfileMetric**](GamificationApi.html#getgamificationprofilemetric) | **GET** /api/v2/gamification/profiles/{profileId}/metrics/{metricId} | Performance profile gamified metric by id |
| [**GetGamificationProfileMetrics**](GamificationApi.html#getgamificationprofilemetrics) | **GET** /api/v2/gamification/profiles/{profileId}/metrics | All gamified metrics for a given performance profile |
| [**GetGamificationProfileMetricsObjectivedetails**](GamificationApi.html#getgamificationprofilemetricsobjectivedetails) | **GET** /api/v2/gamification/profiles/{profileId}/metrics/objectivedetails | All metrics for a given performance profile with objective details such as order and maxPoints |
| [**GetGamificationProfiles**](GamificationApi.html#getgamificationprofiles) | **GET** /api/v2/gamification/profiles | All performance profiles |
| [**GetGamificationProfilesUser**](GamificationApi.html#getgamificationprofilesuser) | **GET** /api/v2/gamification/profiles/users/{userId} | Performance profile of a user |
| [**GetGamificationProfilesUsersMe**](GamificationApi.html#getgamificationprofilesusersme) | **GET** /api/v2/gamification/profiles/users/me | Performance profile of the requesting user |
| [**GetGamificationScorecards**](GamificationApi.html#getgamificationscorecards) | **GET** /api/v2/gamification/scorecards | Workday performance metrics of the requesting user |
| [**GetGamificationScorecardsAttendance**](GamificationApi.html#getgamificationscorecardsattendance) | **GET** /api/v2/gamification/scorecards/attendance | Attendance status metrics of the requesting user |
| [**GetGamificationScorecardsBestpoints**](GamificationApi.html#getgamificationscorecardsbestpoints) | **GET** /api/v2/gamification/scorecards/bestpoints | Best points of the requesting user |
| [**GetGamificationScorecardsPointsAlltime**](GamificationApi.html#getgamificationscorecardspointsalltime) | **GET** /api/v2/gamification/scorecards/points/alltime | All-time points of the requesting user |
| [**GetGamificationScorecardsPointsAverage**](GamificationApi.html#getgamificationscorecardspointsaverage) | **GET** /api/v2/gamification/scorecards/points/average | Average points of the requesting user&#39;s division or performance profile |
| [**GetGamificationScorecardsPointsTrends**](GamificationApi.html#getgamificationscorecardspointstrends) | **GET** /api/v2/gamification/scorecards/points/trends | Points trends of the requesting user |
| [**GetGamificationScorecardsProfileMetricUserValuesTrends**](GamificationApi.html#getgamificationscorecardsprofilemetricuservaluestrends) | **GET** /api/v2/gamification/scorecards/profiles/{profileId}/metrics/{metricId}/users/{userId}/values/trends | Average performance values trends by metric of a user |
| [**GetGamificationScorecardsProfileMetricUsersValuesTrends**](GamificationApi.html#getgamificationscorecardsprofilemetricusersvaluestrends) | **GET** /api/v2/gamification/scorecards/profiles/{profileId}/metrics/{metricId}/users/values/trends | Average performance values trends by metric of a division or a performance profile |
| [**GetGamificationScorecardsProfileMetricValuesTrends**](GamificationApi.html#getgamificationscorecardsprofilemetricvaluestrends) | **GET** /api/v2/gamification/scorecards/profiles/{profileId}/metrics/{metricId}/values/trends | Average performance values trends by metric of the requesting user |
| [**GetGamificationScorecardsUser**](GamificationApi.html#getgamificationscorecardsuser) | **GET** /api/v2/gamification/scorecards/users/{userId} | Workday performance metrics for a user |
| [**GetGamificationScorecardsUserAttendance**](GamificationApi.html#getgamificationscorecardsuserattendance) | **GET** /api/v2/gamification/scorecards/users/{userId}/attendance | Attendance status metrics for a user |
| [**GetGamificationScorecardsUserBestpoints**](GamificationApi.html#getgamificationscorecardsuserbestpoints) | **GET** /api/v2/gamification/scorecards/users/{userId}/bestpoints | Best points of a user |
| [**GetGamificationScorecardsUserPointsAlltime**](GamificationApi.html#getgamificationscorecardsuserpointsalltime) | **GET** /api/v2/gamification/scorecards/users/{userId}/points/alltime | All-time points for a user |
| [**GetGamificationScorecardsUserPointsTrends**](GamificationApi.html#getgamificationscorecardsuserpointstrends) | **GET** /api/v2/gamification/scorecards/users/{userId}/points/trends | Points trend for a user |
| [**GetGamificationScorecardsUserValuesTrends**](GamificationApi.html#getgamificationscorecardsuservaluestrends) | **GET** /api/v2/gamification/scorecards/users/{userId}/values/trends | Values trends of a user |
| [**GetGamificationScorecardsUsersPointsAverage**](GamificationApi.html#getgamificationscorecardsuserspointsaverage) | **GET** /api/v2/gamification/scorecards/users/points/average | Workday average points by target group |
| [**GetGamificationScorecardsUsersValuesAverage**](GamificationApi.html#getgamificationscorecardsusersvaluesaverage) | **GET** /api/v2/gamification/scorecards/users/values/average | Workday average values by target group |
| [**GetGamificationScorecardsUsersValuesTrends**](GamificationApi.html#getgamificationscorecardsusersvaluestrends) | **GET** /api/v2/gamification/scorecards/users/values/trends | Values trend by target group |
| [**GetGamificationScorecardsValuesAverage**](GamificationApi.html#getgamificationscorecardsvaluesaverage) | **GET** /api/v2/gamification/scorecards/values/average | Average values of the requesting user&#39;s division or performance profile |
| [**GetGamificationScorecardsValuesTrends**](GamificationApi.html#getgamificationscorecardsvaluestrends) | **GET** /api/v2/gamification/scorecards/values/trends | Values trends of the requesting user or group |
| [**GetGamificationStatus**](GamificationApi.html#getgamificationstatus) | **GET** /api/v2/gamification/status | Gamification activation status |
| [**GetGamificationTemplate**](GamificationApi.html#getgamificationtemplate) | **GET** /api/v2/gamification/templates/{templateId} | Objective template by id |
| [**GetGamificationTemplates**](GamificationApi.html#getgamificationtemplates) | **GET** /api/v2/gamification/templates | All objective templates |
| [**PatchEmployeeperformanceExternalmetricsDefinition**](GamificationApi.html#patchemployeeperformanceexternalmetricsdefinition) | **PATCH** /api/v2/employeeperformance/externalmetrics/definitions/{metricId} | Update External Metric Definition |
| [**PostEmployeeperformanceExternalmetricsData**](GamificationApi.html#postemployeeperformanceexternalmetricsdata) | **POST** /api/v2/employeeperformance/externalmetrics/data | Write External Metric Data |
| [**PostEmployeeperformanceExternalmetricsDefinitions**](GamificationApi.html#postemployeeperformanceexternalmetricsdefinitions) | **POST** /api/v2/employeeperformance/externalmetrics/definitions | Create External Metric Definition |
| [**PostGamificationMetrics**](GamificationApi.html#postgamificationmetrics) | **POST** /api/v2/gamification/metrics | Creates a gamified metric with a given metric definition and metric objective |
| [**PostGamificationProfileActivate**](GamificationApi.html#postgamificationprofileactivate) | **POST** /api/v2/gamification/profiles/{profileId}/activate | Activate a performance profile |
| [**PostGamificationProfileDeactivate**](GamificationApi.html#postgamificationprofiledeactivate) | **POST** /api/v2/gamification/profiles/{profileId}/deactivate | Deactivate a performance profile |
| [**PostGamificationProfileMembers**](GamificationApi.html#postgamificationprofilemembers) | **POST** /api/v2/gamification/profiles/{profileId}/members | Assign members to a given performance profile |
| [**PostGamificationProfileMembersValidate**](GamificationApi.html#postgamificationprofilemembersvalidate) | **POST** /api/v2/gamification/profiles/{profileId}/members/validate | Validate member assignment |
| [**PostGamificationProfileMetricLink**](GamificationApi.html#postgamificationprofilemetriclink) | **POST** /api/v2/gamification/profiles/{sourceProfileId}/metrics/{sourceMetricId}/link | Creates a linked metric |
| [**PostGamificationProfileMetrics**](GamificationApi.html#postgamificationprofilemetrics) | **POST** /api/v2/gamification/profiles/{profileId}/metrics | Creates a gamified metric with a given metric definition and metric objective under in a performance profile |
| [**PostGamificationProfiles**](GamificationApi.html#postgamificationprofiles) | **POST** /api/v2/gamification/profiles | Create a new custom performance profile |
| [**PutGamificationMetric**](GamificationApi.html#putgamificationmetric) | **PUT** /api/v2/gamification/metrics/{metricId} | Updates a metric |
| [**PutGamificationProfile**](GamificationApi.html#putgamificationprofile) | **PUT** /api/v2/gamification/profiles/{profileId} | Updates a performance profile |
| [**PutGamificationProfileMetric**](GamificationApi.html#putgamificationprofilemetric) | **PUT** /api/v2/gamification/profiles/{profileId}/metrics/{metricId} | Updates a metric in performance profile |
| [**PutGamificationStatus**](GamificationApi.html#putgamificationstatus) | **PUT** /api/v2/gamification/status | Update gamification activation status |
{: class="table table-striped"}

<a name="deleteemployeeperformanceexternalmetricsdefinition"></a>

## void DeleteEmployeeperformanceExternalmetricsDefinition (string metricId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getemployeeperformanceexternalmetricsdefinition"></a>

## [**ExternalMetricDefinition**](ExternalMetricDefinition.html) GetEmployeeperformanceExternalmetricsDefinition (string metricId)



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
{: class="table table-striped"}

### Return type

[**ExternalMetricDefinition**](ExternalMetricDefinition.html)

<a name="getemployeeperformanceexternalmetricsdefinitions"></a>

## [**ExternalMetricDefinitionListing**](ExternalMetricDefinitionListing.html) GetEmployeeperformanceExternalmetricsDefinitions (int? pageSize = null, int? pageNumber = null)



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
{: class="table table-striped"}

### Return type

[**ExternalMetricDefinitionListing**](ExternalMetricDefinitionListing.html)

<a name="getgamificationleaderboard"></a>

## [**Leaderboard**](Leaderboard.html) GetGamificationLeaderboard (String startWorkday, String endWorkday, string metricId = null)



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
{: class="table table-striped"}

### Return type

[**Leaderboard**](Leaderboard.html)

<a name="getgamificationleaderboardall"></a>

## [**Leaderboard**](Leaderboard.html) GetGamificationLeaderboardAll (string filterType, string filterId, String startWorkday, String endWorkday, string metricId = null)



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
{: class="table table-striped"}

### Return type

[**Leaderboard**](Leaderboard.html)

<a name="getgamificationleaderboardallbestpoints"></a>

## [**OverallBestPoints**](OverallBestPoints.html) GetGamificationLeaderboardAllBestpoints (string filterType, string filterId)



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
{: class="table table-striped"}

### Return type

[**OverallBestPoints**](OverallBestPoints.html)

<a name="getgamificationleaderboardbestpoints"></a>

## [**OverallBestPoints**](OverallBestPoints.html) GetGamificationLeaderboardBestpoints ()



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

[**OverallBestPoints**](OverallBestPoints.html)

<a name="getgamificationmetric"></a>

## [**Metric**](Metric.html) GetGamificationMetric (string metricId, String workday = null, string performanceProfileId = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gamified metric by id

This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics/{metricId} instead.



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
    public class GetGamificationMetricExample
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
            var metricId = metricId_example;  // string | metric Id
            var workday = 2013-10-20;  // String | The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional) 
            var performanceProfileId = performanceProfileId_example;  // string | The profile id of the metrics you are trying to retrieve. The DEFAULT profile is used if nothing is given. (optional) 

            try
            { 
                // Gamified metric by id
                Metric result = apiInstance.GetGamificationMetric(metricId, workday, performanceProfileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationMetric: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **metricId** | **string**| metric Id |  |
| **workday** | **String**| The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional]  |
| **performanceProfileId** | **string**| The profile id of the metrics you are trying to retrieve. The DEFAULT profile is used if nothing is given. | [optional]  |
{: class="table table-striped"}

### Return type

[**Metric**](Metric.html)

<a name="getgamificationmetricdefinition"></a>

## [**MetricDefinition**](MetricDefinition.html) GetGamificationMetricdefinition (string metricDefinitionId)



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
{: class="table table-striped"}

### Return type

[**MetricDefinition**](MetricDefinition.html)

<a name="getgamificationmetricdefinitions"></a>

## [**GetMetricDefinitionsResponse**](GetMetricDefinitionsResponse.html) GetGamificationMetricdefinitions ()



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

[**GetMetricDefinitionsResponse**](GetMetricDefinitionsResponse.html)

<a name="getgamificationmetrics"></a>

## [**GetMetricsResponse**](GetMetricsResponse.html) GetGamificationMetrics (string performanceProfileId = null, String workday = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

All gamified metrics for a given profile

This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics instead.



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
    public class GetGamificationMetricsExample
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
            var performanceProfileId = performanceProfileId_example;  // string | The profile id of the metrics you are trying to retrieve. The DEFAULT profile is used if nothing is given. (optional) 
            var workday = 2013-10-20;  // String | The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional) 

            try
            { 
                // All gamified metrics for a given profile
                GetMetricsResponse result = apiInstance.GetGamificationMetrics(performanceProfileId, workday);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.GetGamificationMetrics: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **performanceProfileId** | **string**| The profile id of the metrics you are trying to retrieve. The DEFAULT profile is used if nothing is given. | [optional]  |
| **workday** | **String**| The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional]  |
{: class="table table-striped"}

### Return type

[**GetMetricsResponse**](GetMetricsResponse.html)

<a name="getgamificationprofile"></a>

## [**PerformanceProfile**](PerformanceProfile.html) GetGamificationProfile (string profileId)



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
{: class="table table-striped"}

### Return type

[**PerformanceProfile**](PerformanceProfile.html)

<a name="getgamificationprofilemembers"></a>

## [**MemberListing**](MemberListing.html) GetGamificationProfileMembers (string profileId)



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
{: class="table table-striped"}

### Return type

[**MemberListing**](MemberListing.html)

<a name="getgamificationprofilemetric"></a>

## [**Metric**](Metric.html) GetGamificationProfileMetric (string profileId, string metricId, String workday = null)



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
{: class="table table-striped"}

### Return type

[**Metric**](Metric.html)

<a name="getgamificationprofilemetrics"></a>

## [**GetMetricResponse**](GetMetricResponse.html) GetGamificationProfileMetrics (string profileId, List<string> expand = null, String workday = null, string metricIds = null)



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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional] <br />**Values**: objective |
| **workday** | **String**| The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional]  |
| **metricIds** | **string**| List of metric ids to filter the response (Optional, comma-separated). | [optional]  |
{: class="table table-striped"}

### Return type

[**GetMetricResponse**](GetMetricResponse.html)

<a name="getgamificationprofilemetricsobjectivedetails"></a>

## [**GetMetricsResponse**](GetMetricsResponse.html) GetGamificationProfileMetricsObjectivedetails (string profileId, String workday = null)



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
{: class="table table-striped"}

### Return type

[**GetMetricsResponse**](GetMetricsResponse.html)

<a name="getgamificationprofiles"></a>

## [**GetProfilesResponse**](GetProfilesResponse.html) GetGamificationProfiles ()



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

[**GetProfilesResponse**](GetProfilesResponse.html)

<a name="getgamificationprofilesuser"></a>

## [**PerformanceProfile**](PerformanceProfile.html) GetGamificationProfilesUser (string userId, String workday = null)



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
{: class="table table-striped"}

### Return type

[**PerformanceProfile**](PerformanceProfile.html)

<a name="getgamificationprofilesusersme"></a>

## [**PerformanceProfile**](PerformanceProfile.html) GetGamificationProfilesUsersMe (String workday = null)



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
{: class="table table-striped"}

### Return type

[**PerformanceProfile**](PerformanceProfile.html)

<a name="getgamificationscorecards"></a>

## [**WorkdayMetricListing**](WorkdayMetricListing.html) GetGamificationScorecards (String workday, List<string> expand = null)



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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional] <br />**Values**: objective |
{: class="table table-striped"}

### Return type

[**WorkdayMetricListing**](WorkdayMetricListing.html)

<a name="getgamificationscorecardsattendance"></a>

## [**AttendanceStatusListing**](AttendanceStatusListing.html) GetGamificationScorecardsAttendance (String startWorkday, String endWorkday)



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
{: class="table table-striped"}

### Return type

[**AttendanceStatusListing**](AttendanceStatusListing.html)

<a name="getgamificationscorecardsbestpoints"></a>

## [**UserBestPoints**](UserBestPoints.html) GetGamificationScorecardsBestpoints ()



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

[**UserBestPoints**](UserBestPoints.html)

<a name="getgamificationscorecardspointsalltime"></a>

## [**AllTimePoints**](AllTimePoints.html) GetGamificationScorecardsPointsAlltime (String endWorkday)



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
{: class="table table-striped"}

### Return type

[**AllTimePoints**](AllTimePoints.html)

<a name="getgamificationscorecardspointsaverage"></a>

## [**SingleWorkdayAveragePoints**](SingleWorkdayAveragePoints.html) GetGamificationScorecardsPointsAverage (String workday)



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
{: class="table table-striped"}

### Return type

[**SingleWorkdayAveragePoints**](SingleWorkdayAveragePoints.html)

<a name="getgamificationscorecardspointstrends"></a>

## [**WorkdayPointsTrend**](WorkdayPointsTrend.html) GetGamificationScorecardsPointsTrends (String startWorkday, String endWorkday, string dayOfWeek = null)



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
{: class="table table-striped"}

### Return type

[**WorkdayPointsTrend**](WorkdayPointsTrend.html)

<a name="getgamificationscorecardsprofilemetricuservaluestrends"></a>

## [**MetricValueTrendAverage**](MetricValueTrendAverage.html) GetGamificationScorecardsProfileMetricUserValuesTrends (string profileId, string metricId, string userId, String startWorkday, String endWorkday, String referenceWorkday = null, string timeZone = null)



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
{: class="table table-striped"}

### Return type

[**MetricValueTrendAverage**](MetricValueTrendAverage.html)

<a name="getgamificationscorecardsprofilemetricusersvaluestrends"></a>

## [**MetricValueTrendAverage**](MetricValueTrendAverage.html) GetGamificationScorecardsProfileMetricUsersValuesTrends (string profileId, string metricId, string filterType, String startWorkday, String endWorkday, string filterId = null, String referenceWorkday = null, string timeZone = null)



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
{: class="table table-striped"}

### Return type

[**MetricValueTrendAverage**](MetricValueTrendAverage.html)

<a name="getgamificationscorecardsprofilemetricvaluestrends"></a>

## [**MetricValueTrendAverage**](MetricValueTrendAverage.html) GetGamificationScorecardsProfileMetricValuesTrends (string profileId, string metricId, String startWorkday, String endWorkday, string filterType = null, String referenceWorkday = null, string timeZone = null)



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
{: class="table table-striped"}

### Return type

[**MetricValueTrendAverage**](MetricValueTrendAverage.html)

<a name="getgamificationscorecardsuser"></a>

## [**WorkdayMetricListing**](WorkdayMetricListing.html) GetGamificationScorecardsUser (string userId, String workday, List<string> expand = null)



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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional] <br />**Values**: objective |
{: class="table table-striped"}

### Return type

[**WorkdayMetricListing**](WorkdayMetricListing.html)

<a name="getgamificationscorecardsuserattendance"></a>

## [**AttendanceStatusListing**](AttendanceStatusListing.html) GetGamificationScorecardsUserAttendance (string userId, String startWorkday, String endWorkday)



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
{: class="table table-striped"}

### Return type

[**AttendanceStatusListing**](AttendanceStatusListing.html)

<a name="getgamificationscorecardsuserbestpoints"></a>

## [**UserBestPoints**](UserBestPoints.html) GetGamificationScorecardsUserBestpoints (string userId)



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
{: class="table table-striped"}

### Return type

[**UserBestPoints**](UserBestPoints.html)

<a name="getgamificationscorecardsuserpointsalltime"></a>

## [**AllTimePoints**](AllTimePoints.html) GetGamificationScorecardsUserPointsAlltime (string userId, String endWorkday)



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
{: class="table table-striped"}

### Return type

[**AllTimePoints**](AllTimePoints.html)

<a name="getgamificationscorecardsuserpointstrends"></a>

## [**WorkdayPointsTrend**](WorkdayPointsTrend.html) GetGamificationScorecardsUserPointsTrends (string userId, String startWorkday, String endWorkday, string dayOfWeek = null)



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
{: class="table table-striped"}

### Return type

[**WorkdayPointsTrend**](WorkdayPointsTrend.html)

<a name="getgamificationscorecardsuservaluestrends"></a>

## [**WorkdayValuesTrend**](WorkdayValuesTrend.html) GetGamificationScorecardsUserValuesTrends (string userId, String startWorkday, String endWorkday, string timeZone = null)



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
{: class="table table-striped"}

### Return type

[**WorkdayValuesTrend**](WorkdayValuesTrend.html)

<a name="getgamificationscorecardsuserspointsaverage"></a>

## [**SingleWorkdayAveragePoints**](SingleWorkdayAveragePoints.html) GetGamificationScorecardsUsersPointsAverage (string filterType, string filterId, String workday)



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
{: class="table table-striped"}

### Return type

[**SingleWorkdayAveragePoints**](SingleWorkdayAveragePoints.html)

<a name="getgamificationscorecardsusersvaluesaverage"></a>

## [**SingleWorkdayAverageValues**](SingleWorkdayAverageValues.html) GetGamificationScorecardsUsersValuesAverage (string filterType, string filterId, String workday, string timeZone = null)



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
{: class="table table-striped"}

### Return type

[**SingleWorkdayAverageValues**](SingleWorkdayAverageValues.html)

<a name="getgamificationscorecardsusersvaluestrends"></a>

## [**WorkdayValuesTrend**](WorkdayValuesTrend.html) GetGamificationScorecardsUsersValuesTrends (string filterType, string filterId, String startWorkday, String endWorkday, string timeZone = null)



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
{: class="table table-striped"}

### Return type

[**WorkdayValuesTrend**](WorkdayValuesTrend.html)

<a name="getgamificationscorecardsvaluesaverage"></a>

## [**SingleWorkdayAverageValues**](SingleWorkdayAverageValues.html) GetGamificationScorecardsValuesAverage (String workday, string timeZone = null)



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
{: class="table table-striped"}

### Return type

[**SingleWorkdayAverageValues**](SingleWorkdayAverageValues.html)

<a name="getgamificationscorecardsvaluestrends"></a>

## [**WorkdayValuesTrend**](WorkdayValuesTrend.html) GetGamificationScorecardsValuesTrends (String startWorkday, String endWorkday, string filterType = null, String referenceWorkday = null, string timeZone = null)



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
{: class="table table-striped"}

### Return type

[**WorkdayValuesTrend**](WorkdayValuesTrend.html)

<a name="getgamificationstatus"></a>

## [**GamificationStatus**](GamificationStatus.html) GetGamificationStatus ()



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

[**GamificationStatus**](GamificationStatus.html)

<a name="getgamificationtemplate"></a>

## [**ObjectiveTemplate**](ObjectiveTemplate.html) GetGamificationTemplate (string templateId)



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
{: class="table table-striped"}

### Return type

[**ObjectiveTemplate**](ObjectiveTemplate.html)

<a name="getgamificationtemplates"></a>

## [**GetTemplatesResponse**](GetTemplatesResponse.html) GetGamificationTemplates ()



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

[**GetTemplatesResponse**](GetTemplatesResponse.html)

<a name="patchemployeeperformanceexternalmetricsdefinition"></a>

## [**ExternalMetricDefinition**](ExternalMetricDefinition.html) PatchEmployeeperformanceExternalmetricsDefinition (string metricId, ExternalMetricDefinitionUpdateRequest body)



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
| **body** | [**ExternalMetricDefinitionUpdateRequest**](ExternalMetricDefinitionUpdateRequest.html)| The External Metric Definition parameters to be updated |  |
{: class="table table-striped"}

### Return type

[**ExternalMetricDefinition**](ExternalMetricDefinition.html)

<a name="postemployeeperformanceexternalmetricsdata"></a>

## [**ExternalMetricDataWriteResponse**](ExternalMetricDataWriteResponse.html) PostEmployeeperformanceExternalmetricsData (ExternalMetricDataWriteRequest body = null)



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
| **body** | [**ExternalMetricDataWriteRequest**](ExternalMetricDataWriteRequest.html)| The External Metric Data to be added | [optional]  |
{: class="table table-striped"}

### Return type

[**ExternalMetricDataWriteResponse**](ExternalMetricDataWriteResponse.html)

<a name="postemployeeperformanceexternalmetricsdefinitions"></a>

## [**ExternalMetricDefinition**](ExternalMetricDefinition.html) PostEmployeeperformanceExternalmetricsDefinitions (ExternalMetricDefinitionCreateRequest body = null)



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
| **body** | [**ExternalMetricDefinitionCreateRequest**](ExternalMetricDefinitionCreateRequest.html)| The External Metric Definition to be created | [optional]  |
{: class="table table-striped"}

### Return type

[**ExternalMetricDefinition**](ExternalMetricDefinition.html)

<a name="postgamificationmetrics"></a>

## [**Metric**](Metric.html) PostGamificationMetrics (CreateMetric body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Creates a gamified metric with a given metric definition and metric objective

This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics instead.



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
    public class PostGamificationMetricsExample
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
            var body = new CreateMetric(); // CreateMetric | Metric

            try
            { 
                // Creates a gamified metric with a given metric definition and metric objective
                Metric result = apiInstance.PostGamificationMetrics(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.PostGamificationMetrics: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateMetric**](CreateMetric.html)| Metric |  |
{: class="table table-striped"}

### Return type

[**Metric**](Metric.html)

<a name="postgamificationprofileactivate"></a>

## [**PerformanceProfile**](PerformanceProfile.html) PostGamificationProfileActivate (string profileId)



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
{: class="table table-striped"}

### Return type

[**PerformanceProfile**](PerformanceProfile.html)

<a name="postgamificationprofiledeactivate"></a>

## [**PerformanceProfile**](PerformanceProfile.html) PostGamificationProfileDeactivate (string profileId)



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
{: class="table table-striped"}

### Return type

[**PerformanceProfile**](PerformanceProfile.html)

<a name="postgamificationprofilemembers"></a>

## [**Assignment**](Assignment.html) PostGamificationProfileMembers (string profileId, AssignUsers body)



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
| **body** | [**AssignUsers**](AssignUsers.html)| assignUsers |  |
{: class="table table-striped"}

### Return type

[**Assignment**](Assignment.html)

<a name="postgamificationprofilemembersvalidate"></a>

## [**AssignmentValidation**](AssignmentValidation.html) PostGamificationProfileMembersValidate (string profileId, ValidateAssignUsers body)



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
| **body** | [**ValidateAssignUsers**](ValidateAssignUsers.html)| memberAssignments |  |
{: class="table table-striped"}

### Return type

[**AssignmentValidation**](AssignmentValidation.html)

<a name="postgamificationprofilemetriclink"></a>

## [**Metric**](Metric.html) PostGamificationProfileMetricLink (string sourceProfileId, string sourceMetricId, TargetPerformanceProfile body)



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
| **body** | [**TargetPerformanceProfile**](TargetPerformanceProfile.html)| linkedMetric |  |
{: class="table table-striped"}

### Return type

[**Metric**](Metric.html)

<a name="postgamificationprofilemetrics"></a>

## [**Metric**](Metric.html) PostGamificationProfileMetrics (string profileId, CreateMetric body)



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
| **body** | [**CreateMetric**](CreateMetric.html)| Metric |  |
{: class="table table-striped"}

### Return type

[**Metric**](Metric.html)

<a name="postgamificationprofiles"></a>

## [**PerformanceProfile**](PerformanceProfile.html) PostGamificationProfiles (CreatePerformanceProfile body, bool? copyMetrics = null)



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
| **body** | [**CreatePerformanceProfile**](CreatePerformanceProfile.html)| performanceProfile |  |
| **copyMetrics** | **bool?**| Flag to copy metrics. If set to false, there will be no metrics associated with the new profile. If set to true or is absent (the default behavior), all metrics from the default profile will be copied over into the new profile. | [optional] [default to true] |
{: class="table table-striped"}

### Return type

[**PerformanceProfile**](PerformanceProfile.html)

<a name="putgamificationmetric"></a>

## [**Metric**](Metric.html) PutGamificationMetric (string metricId, CreateMetric body, string performanceProfileId = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Updates a metric

This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics/{metricId} instead.



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
    public class PutGamificationMetricExample
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
            var metricId = metricId_example;  // string | metric Id
            var body = new CreateMetric(); // CreateMetric | Metric
            var performanceProfileId = performanceProfileId_example;  // string | The profile id of the metrics you are trying to retrieve. The DEFAULT profile is used if nothing is given. (optional) 

            try
            { 
                // Updates a metric
                Metric result = apiInstance.PutGamificationMetric(metricId, body, performanceProfileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationApi.PutGamificationMetric: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **metricId** | **string**| metric Id |  |
| **body** | [**CreateMetric**](CreateMetric.html)| Metric |  |
| **performanceProfileId** | **string**| The profile id of the metrics you are trying to retrieve. The DEFAULT profile is used if nothing is given. | [optional]  |
{: class="table table-striped"}

### Return type

[**Metric**](Metric.html)

<a name="putgamificationprofile"></a>

## [**PerformanceProfile**](PerformanceProfile.html) PutGamificationProfile (string profileId, PerformanceProfile body = null)



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
| **body** | [**PerformanceProfile**](PerformanceProfile.html)| performanceProfile | [optional]  |
{: class="table table-striped"}

### Return type

[**PerformanceProfile**](PerformanceProfile.html)

<a name="putgamificationprofilemetric"></a>

## [**Metric**](Metric.html) PutGamificationProfileMetric (string profileId, string metricId, CreateMetric body)



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
| **body** | [**CreateMetric**](CreateMetric.html)| Metric |  |
{: class="table table-striped"}

### Return type

[**Metric**](Metric.html)

<a name="putgamificationstatus"></a>

## [**GamificationStatus**](GamificationStatus.html) PutGamificationStatus (GamificationStatus status)



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
| **status** | [**GamificationStatus**](GamificationStatus.html)| Gamification status |  |
{: class="table table-striped"}

### Return type

[**GamificationStatus**](GamificationStatus.html)

