---
title: UserDevelopmentApi
---
## PureCloudPlatform.Client.V2.Api.UserDevelopmentApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetUsersDevelopmentActivities**](UserDevelopmentApi.html#getusersdevelopmentactivities) | **GET** /api/v2/users/development/activities | Get list of Development Activities |
| [**GetUsersDevelopmentActivitiesMe**](UserDevelopmentApi.html#getusersdevelopmentactivitiesme) | **GET** /api/v2/users/development/activities/me | Get list of Development Activities for current user |
| [**GetUsersDevelopmentActivity**](UserDevelopmentApi.html#getusersdevelopmentactivity) | **GET** /api/v2/users/development/activities/{activityId} | Get a Development Activity |
| [**PostUsersDevelopmentActivitiesAggregatesQuery**](UserDevelopmentApi.html#postusersdevelopmentactivitiesaggregatesquery) | **POST** /api/v2/users/development/activities/aggregates/query | Retrieve aggregated development activity data |
{: class="table table-striped"}

<a name="getusersdevelopmentactivities"></a>

## [**DevelopmentActivityListing**](DevelopmentActivityListing.html) GetUsersDevelopmentActivities (List<string> userId = null, string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> types = null, List<string> statuses = null, List<string> relationship = null)



Get list of Development Activities

Either moduleId or userId is required. Results are filtered based on the applicable permissions.

Requires ANY permissions: 

* learning:assignment:view
* coaching:appointment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUsersDevelopmentActivitiesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserDevelopmentApi();
            var userId = new List<string>(); // List<string> | Specifies the list of user IDs to be queried, up to 100 user IDs. It searches for any relationship for the userId. (optional) 
            var moduleId = moduleId_example;  // string | Specifies the ID of the learning module. (optional) 
            var interval = interval_example;  // string | Specifies the dateDue range to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional) 
            var completionInterval = completionInterval_example;  // string | Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional) 
            var overdue = overdue_example;  // string | Specifies if non-overdue, overdue, or all activities are returned. If not specified, all activities are returned (optional)  (default to Any)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Specifies result set sort order sorted by the date due; if not specified, default sort order is descending (Desc) (optional)  (default to Desc)
            var types = new List<string>(); // List<string> | Specifies the activity types. (optional) 
            var statuses = new List<string>(); // List<string> | Specifies the activity statuses to filter by (optional) 
            var relationship = new List<string>(); // List<string> | Specifies how the current user relation should be interpreted, and filters the activities returned to only those that have the specified relationship. If not specified, all relationships are returned. (optional) 

            try
            { 
                // Get list of Development Activities
                DevelopmentActivityListing result = apiInstance.GetUsersDevelopmentActivities(userId, moduleId, interval, completionInterval, overdue, pageSize, pageNumber, sortOrder, types, statuses, relationship);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserDevelopmentApi.GetUsersDevelopmentActivities: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | [**List<string>**](string.html)| Specifies the list of user IDs to be queried, up to 100 user IDs. It searches for any relationship for the userId. | [optional]  |
| **moduleId** | **string**| Specifies the ID of the learning module. | [optional]  |
| **interval** | **string**| Specifies the dateDue range to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional]  |
| **completionInterval** | **string**| Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional]  |
| **overdue** | **string**| Specifies if non-overdue, overdue, or all activities are returned. If not specified, all activities are returned | [optional] [default to Any]<br />**Values**: True, False, Any |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortOrder** | **string**| Specifies result set sort order sorted by the date due; if not specified, default sort order is descending (Desc) | [optional] [default to Desc]<br />**Values**: Asc, Desc |
| **types** | [**List<string>**](string.html)| Specifies the activity types. | [optional] <br />**Values**: Informational, Coaching |
| **statuses** | [**List<string>**](string.html)| Specifies the activity statuses to filter by | [optional] <br />**Values**: Planned, InProgress, Completed, InvalidSchedule |
| **relationship** | [**List<string>**](string.html)| Specifies how the current user relation should be interpreted, and filters the activities returned to only those that have the specified relationship. If not specified, all relationships are returned. | [optional] <br />**Values**: Creator, Facilitator, Attendee |
{: class="table table-striped"}

### Return type

[**DevelopmentActivityListing**](DevelopmentActivityListing.html)

<a name="getusersdevelopmentactivitiesme"></a>

## [**DevelopmentActivityListing**](DevelopmentActivityListing.html) GetUsersDevelopmentActivitiesMe (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> types = null, List<string> statuses = null, List<string> relationship = null)



Get list of Development Activities for current user

Results are filtered based on the applicable permissions.

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
    public class GetUsersDevelopmentActivitiesMeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserDevelopmentApi();
            var moduleId = moduleId_example;  // string | Specifies the ID of the learning module. (optional) 
            var interval = interval_example;  // string | Specifies the dateDue range to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional) 
            var completionInterval = completionInterval_example;  // string | Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional) 
            var overdue = overdue_example;  // string | Specifies if non-overdue, overdue, or all activities are returned. If not specified, all activities are returned (optional)  (default to Any)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Specifies result set sort order sorted by the date due; if not specified, default sort order is descending (Desc) (optional)  (default to Desc)
            var types = new List<string>(); // List<string> | Specifies the activity types. (optional) 
            var statuses = new List<string>(); // List<string> | Specifies the activity statuses to filter by (optional) 
            var relationship = new List<string>(); // List<string> | Specifies how the current user relation should be interpreted, and filters the activities returned to only those that have the specified relationship. If not specified, all relationships are returned. (optional) 

            try
            { 
                // Get list of Development Activities for current user
                DevelopmentActivityListing result = apiInstance.GetUsersDevelopmentActivitiesMe(moduleId, interval, completionInterval, overdue, pageSize, pageNumber, sortOrder, types, statuses, relationship);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserDevelopmentApi.GetUsersDevelopmentActivitiesMe: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **moduleId** | **string**| Specifies the ID of the learning module. | [optional]  |
| **interval** | **string**| Specifies the dateDue range to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional]  |
| **completionInterval** | **string**| Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional]  |
| **overdue** | **string**| Specifies if non-overdue, overdue, or all activities are returned. If not specified, all activities are returned | [optional] [default to Any]<br />**Values**: True, False, Any |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortOrder** | **string**| Specifies result set sort order sorted by the date due; if not specified, default sort order is descending (Desc) | [optional] [default to Desc]<br />**Values**: Asc, Desc |
| **types** | [**List<string>**](string.html)| Specifies the activity types. | [optional] <br />**Values**: Informational, Coaching |
| **statuses** | [**List<string>**](string.html)| Specifies the activity statuses to filter by | [optional] <br />**Values**: Planned, InProgress, Completed, InvalidSchedule |
| **relationship** | [**List<string>**](string.html)| Specifies how the current user relation should be interpreted, and filters the activities returned to only those that have the specified relationship. If not specified, all relationships are returned. | [optional] <br />**Values**: Creator, Facilitator, Attendee |
{: class="table table-striped"}

### Return type

[**DevelopmentActivityListing**](DevelopmentActivityListing.html)

<a name="getusersdevelopmentactivity"></a>

## [**DevelopmentActivity**](DevelopmentActivity.html) GetUsersDevelopmentActivity (string activityId, string type)



Get a Development Activity



Requires ANY permissions: 

* learning:assignment:view
* coaching:appointment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUsersDevelopmentActivityExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserDevelopmentApi();
            var activityId = activityId_example;  // string | Specifies the activity ID, maps to either assignment or appointment ID
            var type = type_example;  // string | Specifies the activity type.

            try
            { 
                // Get a Development Activity
                DevelopmentActivity result = apiInstance.GetUsersDevelopmentActivity(activityId, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserDevelopmentApi.GetUsersDevelopmentActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **activityId** | **string**| Specifies the activity ID, maps to either assignment or appointment ID |  |
| **type** | **string**| Specifies the activity type. | <br />**Values**: Informational, Coaching |
{: class="table table-striped"}

### Return type

[**DevelopmentActivity**](DevelopmentActivity.html)

<a name="postusersdevelopmentactivitiesaggregatesquery"></a>

## [**DevelopmentActivityAggregateResponse**](DevelopmentActivityAggregateResponse.html) PostUsersDevelopmentActivitiesAggregatesQuery (DevelopmentActivityAggregateParam body)



Retrieve aggregated development activity data

Results are filtered based on the applicable permissions.

Requires ANY permissions: 

* learning:assignment:view
* coaching:appointment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUsersDevelopmentActivitiesAggregatesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserDevelopmentApi();
            var body = new DevelopmentActivityAggregateParam(); // DevelopmentActivityAggregateParam | Aggregate Request

            try
            { 
                // Retrieve aggregated development activity data
                DevelopmentActivityAggregateResponse result = apiInstance.PostUsersDevelopmentActivitiesAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserDevelopmentApi.PostUsersDevelopmentActivitiesAggregatesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DevelopmentActivityAggregateParam**](DevelopmentActivityAggregateParam.html)| Aggregate Request |  |
{: class="table table-striped"}

### Return type

[**DevelopmentActivityAggregateResponse**](DevelopmentActivityAggregateResponse.html)

