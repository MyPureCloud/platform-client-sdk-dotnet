---
title: GamificationApi
---
## PureCloudPlatform.Client.V2.Api.GamificationApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetGamificationLeaderboard**](GamificationApi.html#getgamificationleaderboard) | **GET** /api/v2/gamification/leaderboard | Leaderboard of the requesting user&#39;s division |
| [**GetGamificationLeaderboardAll**](GamificationApi.html#getgamificationleaderboardall) | **GET** /api/v2/gamification/leaderboard/all | Leaderboard by division |
| [**GetGamificationLeaderboardAllBestpoints**](GamificationApi.html#getgamificationleaderboardallbestpoints) | **GET** /api/v2/gamification/leaderboard/all/bestpoints | Best Points by division |
| [**GetGamificationLeaderboardBestpoints**](GamificationApi.html#getgamificationleaderboardbestpoints) | **GET** /api/v2/gamification/leaderboard/bestpoints | Best Points of the requesting user&#39;s division |
| [**GetGamificationMetric**](GamificationApi.html#getgamificationmetric) | **GET** /api/v2/gamification/metrics/{metricId} | Gamified metric by id |
| [**GetGamificationMetricdefinition**](GamificationApi.html#getgamificationmetricdefinition) | **GET** /api/v2/gamification/metricdefinitions/{metricDefinitionId} | Metric definition by id |
| [**GetGamificationMetricdefinitions**](GamificationApi.html#getgamificationmetricdefinitions) | **GET** /api/v2/gamification/metricdefinitions | All metric definitions |
| [**GetGamificationMetrics**](GamificationApi.html#getgamificationmetrics) | **GET** /api/v2/gamification/metrics | All gamified metrics for a given profile |
| [**GetGamificationProfile**](GamificationApi.html#getgamificationprofile) | **GET** /api/v2/gamification/profiles/{performanceProfileId} | Performance profile by id |
| [**GetGamificationProfiles**](GamificationApi.html#getgamificationprofiles) | **GET** /api/v2/gamification/profiles | All performance profiles |
| [**GetGamificationScorecards**](GamificationApi.html#getgamificationscorecards) | **GET** /api/v2/gamification/scorecards | Workday performance metrics of the requesting user |
| [**GetGamificationScorecardsAttendance**](GamificationApi.html#getgamificationscorecardsattendance) | **GET** /api/v2/gamification/scorecards/attendance | Attendance status metrics of the requesting user |
| [**GetGamificationScorecardsBestpoints**](GamificationApi.html#getgamificationscorecardsbestpoints) | **GET** /api/v2/gamification/scorecards/bestpoints | Best points of the requesting user |
| [**GetGamificationScorecardsPointsAlltime**](GamificationApi.html#getgamificationscorecardspointsalltime) | **GET** /api/v2/gamification/scorecards/points/alltime | All-time points of the requesting user |
| [**GetGamificationScorecardsPointsAverage**](GamificationApi.html#getgamificationscorecardspointsaverage) | **GET** /api/v2/gamification/scorecards/points/average | Average points of the requesting user&#39;s division |
| [**GetGamificationScorecardsPointsTrends**](GamificationApi.html#getgamificationscorecardspointstrends) | **GET** /api/v2/gamification/scorecards/points/trends | Points trends of the requesting user |
| [**GetGamificationScorecardsUser**](GamificationApi.html#getgamificationscorecardsuser) | **GET** /api/v2/gamification/scorecards/users/{userId} | Workday performance metrics for a user |
| [**GetGamificationScorecardsUserAttendance**](GamificationApi.html#getgamificationscorecardsuserattendance) | **GET** /api/v2/gamification/scorecards/users/{userId}/attendance | Attendance status metrics for a user |
| [**GetGamificationScorecardsUserBestpoints**](GamificationApi.html#getgamificationscorecardsuserbestpoints) | **GET** /api/v2/gamification/scorecards/users/{userId}/bestpoints | Best points of a user |
| [**GetGamificationScorecardsUserPointsAlltime**](GamificationApi.html#getgamificationscorecardsuserpointsalltime) | **GET** /api/v2/gamification/scorecards/users/{userId}/points/alltime | All-time points for a user |
| [**GetGamificationScorecardsUserPointsTrends**](GamificationApi.html#getgamificationscorecardsuserpointstrends) | **GET** /api/v2/gamification/scorecards/users/{userId}/points/trends | Points trend for a user |
| [**GetGamificationScorecardsUserValuesTrends**](GamificationApi.html#getgamificationscorecardsuservaluestrends) | **GET** /api/v2/gamification/scorecards/users/{userId}/values/trends | Values Trends of a user |
| [**GetGamificationScorecardsUsersPointsAverage**](GamificationApi.html#getgamificationscorecardsuserspointsaverage) | **GET** /api/v2/gamification/scorecards/users/points/average | Workday average points by target group |
| [**GetGamificationScorecardsUsersValuesAverage**](GamificationApi.html#getgamificationscorecardsusersvaluesaverage) | **GET** /api/v2/gamification/scorecards/users/values/average | Workday average values by target group |
| [**GetGamificationScorecardsUsersValuesTrends**](GamificationApi.html#getgamificationscorecardsusersvaluestrends) | **GET** /api/v2/gamification/scorecards/users/values/trends | Values trend by target group |
| [**GetGamificationScorecardsValuesAverage**](GamificationApi.html#getgamificationscorecardsvaluesaverage) | **GET** /api/v2/gamification/scorecards/values/average | Average values of the requesting user&#39;s division |
| [**GetGamificationScorecardsValuesTrends**](GamificationApi.html#getgamificationscorecardsvaluestrends) | **GET** /api/v2/gamification/scorecards/values/trends | Values trends of the requesting user or group |
| [**GetGamificationStatus**](GamificationApi.html#getgamificationstatus) | **GET** /api/v2/gamification/status | Gamification activation status |
| [**GetGamificationTemplate**](GamificationApi.html#getgamificationtemplate) | **GET** /api/v2/gamification/templates/{templateId} | Objective template by id |
| [**GetGamificationTemplates**](GamificationApi.html#getgamificationtemplates) | **GET** /api/v2/gamification/templates | All objective templates |
| [**PostGamificationMetrics**](GamificationApi.html#postgamificationmetrics) | **POST** /api/v2/gamification/metrics | Creates a gamified metric with a given metric definition and metric objective |
| [**PutGamificationMetric**](GamificationApi.html#putgamificationmetric) | **PUT** /api/v2/gamification/metrics/{metricId} | Updates a metric |
| [**PutGamificationProfile**](GamificationApi.html#putgamificationprofile) | **PUT** /api/v2/gamification/profiles/{performanceProfileId} | Updates a performance profile |
| [**PutGamificationStatus**](GamificationApi.html#putgamificationstatus) | **PUT** /api/v2/gamification/status | Update gamification activation status |
{: class="table table-striped"}

<a name="getgamificationleaderboard"></a>

## [**Leaderboard**](Leaderboard.html) GetGamificationLeaderboard (String startWorkday, String endWorkday, string metricId = null)



Leaderboard of the requesting user's division



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
                // Leaderboard of the requesting user's division
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



Leaderboard by division



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
            var filterId = filterId_example;  // string | ID for the filter type. For example, division Id
            var startWorkday = 2013-10-20;  // String | Start workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var endWorkday = 2013-10-20;  // String | End workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
            var metricId = metricId_example;  // string | Metric Id for which the leaderboard is to be generated. The total points is used if nothing is given. (optional) 

            try
            { 
                // Leaderboard by division
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
| **filterType** | **string**| Filter type for the query request. | <br />**Values**: Division |
| **filterId** | **string**| ID for the filter type. For example, division Id |  |
| **startWorkday** | **String**| Start workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **endWorkday** | **String**| End workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **metricId** | **string**| Metric Id for which the leaderboard is to be generated. The total points is used if nothing is given. | [optional]  |
{: class="table table-striped"}

### Return type

[**Leaderboard**](Leaderboard.html)

<a name="getgamificationleaderboardallbestpoints"></a>

## [**OverallBestPoints**](OverallBestPoints.html) GetGamificationLeaderboardAllBestpoints (string filterType, string filterId)



Best Points by division



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
            var filterId = filterId_example;  // string | ID for the filter type. For example, division Id

            try
            { 
                // Best Points by division
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
| **filterType** | **string**| Filter type for the query request. | <br />**Values**: Division |
| **filterId** | **string**| ID for the filter type. For example, division Id |  |
{: class="table table-striped"}

### Return type

[**OverallBestPoints**](OverallBestPoints.html)

<a name="getgamificationleaderboardbestpoints"></a>

## [**OverallBestPoints**](OverallBestPoints.html) GetGamificationLeaderboardBestpoints ()



Best Points of the requesting user's division



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
                // Best Points of the requesting user's division
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
{: class="table table-striped"}

### Return type

[**OverallBestPoints**](OverallBestPoints.html)

<a name="getgamificationmetric"></a>

## [**Metric**](Metric.html) GetGamificationMetric (string metricId)



Gamified metric by id



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

            try
            { 
                // Gamified metric by id
                Metric result = apiInstance.GetGamificationMetric(metricId);
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
{: class="table table-striped"}

### Return type

[**GetMetricDefinitionsResponse**](GetMetricDefinitionsResponse.html)

<a name="getgamificationmetrics"></a>

## [**GetMetricsResponse**](GetMetricsResponse.html) GetGamificationMetrics (string performanceProfileId = null)



All gamified metrics for a given profile



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

            try
            { 
                // All gamified metrics for a given profile
                GetMetricsResponse result = apiInstance.GetGamificationMetrics(performanceProfileId);
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
{: class="table table-striped"}

### Return type

[**GetMetricsResponse**](GetMetricsResponse.html)

<a name="getgamificationprofile"></a>

## [**PerformanceProfile**](PerformanceProfile.html) GetGamificationProfile (string performanceProfileId)



Performance profile by id



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
            var performanceProfileId = performanceProfileId_example;  // string | Performance Profile Id

            try
            { 
                // Performance profile by id
                PerformanceProfile result = apiInstance.GetGamificationProfile(performanceProfileId);
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
| **performanceProfileId** | **string**| Performance Profile Id |  |
{: class="table table-striped"}

### Return type

[**PerformanceProfile**](PerformanceProfile.html)

<a name="getgamificationprofiles"></a>

## [**GetProfilesResponse**](GetProfilesResponse.html) GetGamificationProfiles ()



All performance profiles



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
{: class="table table-striped"}

### Return type

[**GetProfilesResponse**](GetProfilesResponse.html)

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
            var workday = 2013-10-20;  // String | Target querying workday. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd
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
| **workday** | **String**| Target querying workday. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
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
            var startWorkday = 2013-10-20;  // String | Start workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd
            var endWorkday = 2013-10-20;  // String | End workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd

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
| **startWorkday** | **String**| Start workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **endWorkday** | **String**| End workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
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
{: class="table table-striped"}

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
            var endWorkday = 2013-10-20;  // String | End workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd

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
| **endWorkday** | **String**| End workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
{: class="table table-striped"}

### Return type

[**AllTimePoints**](AllTimePoints.html)

<a name="getgamificationscorecardspointsaverage"></a>

## [**SingleWorkdayAveragePoints**](SingleWorkdayAveragePoints.html) GetGamificationScorecardsPointsAverage (String workday)



Average points of the requesting user's division



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
                // Average points of the requesting user's division
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
            var startWorkday = 2013-10-20;  // String | Start workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd
            var endWorkday = 2013-10-20;  // String | End workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd
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
| **startWorkday** | **String**| Start workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **endWorkday** | **String**| End workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **dayOfWeek** | **string**| Optional filter to specify which day of weeks to be included in the response | [optional] <br />**Values**: Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday |
{: class="table table-striped"}

### Return type

[**WorkdayPointsTrend**](WorkdayPointsTrend.html)

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
            var workday = 2013-10-20;  // String | Target querying workday. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd
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
| **workday** | **String**| Target querying workday. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
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
            var startWorkday = 2013-10-20;  // String | Start workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd
            var endWorkday = 2013-10-20;  // String | End workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd

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
| **startWorkday** | **String**| Start workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **endWorkday** | **String**| End workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
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
            var endWorkday = 2013-10-20;  // String | End workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd

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
| **endWorkday** | **String**| End workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
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
            var startWorkday = 2013-10-20;  // String | Start workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd
            var endWorkday = 2013-10-20;  // String | End workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd
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
| **startWorkday** | **String**| Start workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **endWorkday** | **String**| End workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **dayOfWeek** | **string**| Optional filter to specify which day of weeks to be included in the response | [optional] <br />**Values**: Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday |
{: class="table table-striped"}

### Return type

[**WorkdayPointsTrend**](WorkdayPointsTrend.html)

<a name="getgamificationscorecardsuservaluestrends"></a>

## [**WorkdayValuesTrend**](WorkdayValuesTrend.html) GetGamificationScorecardsUserValuesTrends (string userId, String startWorkday, String endWorkday, string timeZone = null)



Values Trends of a user



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
            var startWorkday = 2013-10-20;  // String | Start workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd
            var endWorkday = 2013-10-20;  // String | End workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd
            var timeZone = timeZone_example;  // string | Timezone for the workday. Defaults to UTC (optional)  (default to UTC)

            try
            { 
                // Values Trends of a user
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
| **startWorkday** | **String**| Start workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **endWorkday** | **String**| End workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **timeZone** | **string**| Timezone for the workday. Defaults to UTC | [optional] [default to UTC] |
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
| **filterType** | **string**| Filter type for the query request. | <br />**Values**: Division |
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
            var timeZone = timeZone_example;  // string | Timezone for the workday. Defaults to UTC (optional)  (default to UTC)

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
| **filterType** | **string**| Filter type for the query request. | <br />**Values**: Division |
| **filterId** | **string**| ID for the filter type. For example, division Id |  |
| **workday** | **String**| The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **timeZone** | **string**| Timezone for the workday. Defaults to UTC | [optional] [default to UTC] |
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
            var startWorkday = 2013-10-20;  // String | Start workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd
            var endWorkday = 2013-10-20;  // String | End workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd
            var timeZone = timeZone_example;  // string | Timezone for the workday. Defaults to UTC (optional)  (default to UTC)

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
| **filterType** | **string**| Filter type for the query request. | <br />**Values**: Division |
| **filterId** | **string**| ID for the filter type. |  |
| **startWorkday** | **String**| Start workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **endWorkday** | **String**| End workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **timeZone** | **string**| Timezone for the workday. Defaults to UTC | [optional] [default to UTC] |
{: class="table table-striped"}

### Return type

[**WorkdayValuesTrend**](WorkdayValuesTrend.html)

<a name="getgamificationscorecardsvaluesaverage"></a>

## [**SingleWorkdayAverageValues**](SingleWorkdayAverageValues.html) GetGamificationScorecardsValuesAverage (String workday, string timeZone = null)



Average values of the requesting user's division



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
            var timeZone = timeZone_example;  // string | Timezone for the workday. Defaults to UTC (optional)  (default to UTC)

            try
            { 
                // Average values of the requesting user's division
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
| **timeZone** | **string**| Timezone for the workday. Defaults to UTC | [optional] [default to UTC] |
{: class="table table-striped"}

### Return type

[**SingleWorkdayAverageValues**](SingleWorkdayAverageValues.html)

<a name="getgamificationscorecardsvaluestrends"></a>

## [**WorkdayValuesTrend**](WorkdayValuesTrend.html) GetGamificationScorecardsValuesTrends (String startWorkday, String endWorkday, string filterType = null, string timeZone = null)



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
            var startWorkday = 2013-10-20;  // String | Start workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd
            var endWorkday = 2013-10-20;  // String | End workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd
            var filterType = filterType_example;  // string | Filter type for the query request. If not set, then the request is for the requesting user. (optional) 
            var timeZone = timeZone_example;  // string | Timezone for the workday. Defaults to UTC (optional)  (default to UTC)

            try
            { 
                // Values trends of the requesting user or group
                WorkdayValuesTrend result = apiInstance.GetGamificationScorecardsValuesTrends(startWorkday, endWorkday, filterType, timeZone);
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
| **startWorkday** | **String**| Start workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **endWorkday** | **String**| End workday of querying workdays range. Workday is represented as an ISO-8601 string. For example: yyyy-MM-dd |  |
| **filterType** | **string**| Filter type for the query request. If not set, then the request is for the requesting user. | [optional] <br />**Values**: Division |
| **timeZone** | **string**| Timezone for the workday. Defaults to UTC | [optional] [default to UTC] |
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
{: class="table table-striped"}

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
{: class="table table-striped"}

### Return type

[**GetTemplatesResponse**](GetTemplatesResponse.html)

<a name="postgamificationmetrics"></a>

## [**Metric**](Metric.html) PostGamificationMetrics (Metric body)



Creates a gamified metric with a given metric definition and metric objective



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
            var body = new Metric(); // Metric | Metric

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
| **body** | [**Metric**](Metric.html)| Metric |  |
{: class="table table-striped"}

### Return type

[**Metric**](Metric.html)

<a name="putgamificationmetric"></a>

## [**Metric**](Metric.html) PutGamificationMetric (string metricId, Metric body)



Updates a metric



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
            var body = new Metric(); // Metric | Metric

            try
            { 
                // Updates a metric
                Metric result = apiInstance.PutGamificationMetric(metricId, body);
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
| **body** | [**Metric**](Metric.html)| Metric |  |
{: class="table table-striped"}

### Return type

[**Metric**](Metric.html)

<a name="putgamificationprofile"></a>

## [**PerformanceProfile**](PerformanceProfile.html) PutGamificationProfile (string performanceProfileId, PerformanceProfile body = null)



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
            var performanceProfileId = performanceProfileId_example;  // string | Performance Profile Id
            var body = new PerformanceProfile(); // PerformanceProfile | performanceProfile (optional) 

            try
            { 
                // Updates a performance profile
                PerformanceProfile result = apiInstance.PutGamificationProfile(performanceProfileId, body);
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
| **performanceProfileId** | **string**| Performance Profile Id |  |
| **body** | [**PerformanceProfile**](PerformanceProfile.html)| performanceProfile | [optional]  |
{: class="table table-striped"}

### Return type

[**PerformanceProfile**](PerformanceProfile.html)

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

