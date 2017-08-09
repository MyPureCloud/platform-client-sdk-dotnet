---
title: WorkforceManagementApi
---
## PureCloudPlatform.Client.V2.Api.WorkforceManagementApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetWorkforcemanagementAdherence**](WorkforceManagementApi.html#getworkforcemanagementadherence) | **GET** /api/v2/workforcemanagement/adherence | Get a list of UserScheduleAdherence records for the requested users |
| [**GetWorkforcemanagementManagementunitActivitycodes**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitactivitycodes) | **GET** /api/v2/workforcemanagement/managementunits/{muId}/activitycodes | Get activity codes corresponding to a management unit |
| [**GetWorkforcemanagementManagementunitIntradayQueues**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitintradayqueues) | **GET** /api/v2/workforcemanagement/managementunits/{muId}/intraday/queues | Get intraday queues for the given date |
| [**GetWorkforcemanagementManagementunitUserTimeoffrequest**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitusertimeoffrequest) | **GET** /api/v2/workforcemanagement/managementunits/{muId}/users/{userId}/timeoffrequests/{timeOffRequestId} | Get a time off request by id |
| [**GetWorkforcemanagementManagementunitUserTimeoffrequests**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitusertimeoffrequests) | **GET** /api/v2/workforcemanagement/managementunits/{muId}/users/{userId}/timeoffrequests | Get a list of time off requests for any user |
| [**GetWorkforcemanagementManagementunitUsers**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitusers) | **GET** /api/v2/workforcemanagement/managementunits/{muId}/users | Get agents in the management unit |
| [**GetWorkforcemanagementManagementunits**](WorkforceManagementApi.html#getworkforcemanagementmanagementunits) | **GET** /api/v2/workforcemanagement/managementunits | Get management units |
| [**GetWorkforcemanagementTimeoffrequest**](WorkforceManagementApi.html#getworkforcemanagementtimeoffrequest) | **GET** /api/v2/workforcemanagement/timeoffrequests/{timeOffRequestId} | Get a time off request for the current user by id |
| [**GetWorkforcemanagementTimeoffrequests**](WorkforceManagementApi.html#getworkforcemanagementtimeoffrequests) | **GET** /api/v2/workforcemanagement/timeoffrequests | Get a list of time off requests for the current user |
| [**PatchWorkforcemanagementTimeoffrequest**](WorkforceManagementApi.html#patchworkforcemanagementtimeoffrequest) | **PATCH** /api/v2/workforcemanagement/timeoffrequests/{timeOffRequestId} | Mark a time off request for the current user as read or unread |
| [**PostWorkforcemanagementManagementunitHistoricaladherencequery**](WorkforceManagementApi.html#postworkforcemanagementmanagementunithistoricaladherencequery) | **POST** /api/v2/workforcemanagement/managementunits/{muId}/historicaladherencequery | Request a historical adherence report |
| [**PostWorkforcemanagementManagementunitIntraday**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitintraday) | **POST** /api/v2/workforcemanagement/managementunits/{muId}/intraday | Get intraday data for the given date for the requested queueIds |
| [**PostWorkforcemanagementManagementunitSchedulesSearch**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitschedulessearch) | **POST** /api/v2/workforcemanagement/managementunits/{muId}/schedules/search | Get user schedules within the given time range |
| [**PostWorkforcemanagementSchedules**](WorkforceManagementApi.html#postworkforcemanagementschedules) | **POST** /api/v2/workforcemanagement/schedules | Get a schedule for the current user |
{: class="table table-striped"}

<a name="getworkforcemanagementadherence"></a>

## [**List&lt;UserScheduleAdherence&gt;**](UserScheduleAdherence.html) GetWorkforcemanagementAdherence (List<string> userId)

Get a list of UserScheduleAdherence records for the requested users



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | [**List<string>**](string.html)| User Id(s) for which to fetch current schedule adherence information.  Min 1, Max of 100 userIds per request |  |
{: class="table table-striped"}

### Return type

[**List<UserScheduleAdherence>**](UserScheduleAdherence.html)

<a name="getworkforcemanagementmanagementunitactivitycodes"></a>

## [**ActivityCodeContainer**](ActivityCodeContainer.html) GetWorkforcemanagementManagementunitActivitycodes (string muId)

Get activity codes corresponding to a management unit



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new WorkforceManagementApi();
            
            
            var muId = muId_example;  // string | The muId of the management unit, or 'mine' for the management unit of the logged-in user.
            
            
            

            try
            {
                
                // Get activity codes corresponding to a management unit
                
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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
{: class="table table-striped"}

### Return type

[**ActivityCodeContainer**](ActivityCodeContainer.html)

<a name="getworkforcemanagementmanagementunitintradayqueues"></a>

## [**WfmIntradayQueueListing**](WfmIntradayQueueListing.html) GetWorkforcemanagementManagementunitIntradayQueues (string muId, string date)

Get intraday queues for the given date



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new WorkforceManagementApi();
            
            
            var muId = muId_example;  // string | The muId of the management unit, or 'mine' for the management unit of the logged-in user.
            
            
            
            
            var date = date_example;  // string | ISO-8601 date string with no time or timezone component, interpreted in the configured management unit time zone, e.g. 2017-01-23
            
            
            

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **date** | **string**| ISO-8601 date string with no time or timezone component, interpreted in the configured management unit time zone, e.g. 2017-01-23 |  |
{: class="table table-striped"}

### Return type

[**WfmIntradayQueueListing**](WfmIntradayQueueListing.html)

<a name="getworkforcemanagementmanagementunitusertimeoffrequest"></a>

## [**TimeOffRequest**](TimeOffRequest.html) GetWorkforcemanagementManagementunitUserTimeoffrequest (string muId, string userId, string timeOffRequestId)

Get a time off request by id



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new WorkforceManagementApi();
            
            
            var muId = muId_example;  // string | The muId of the management unit, or 'mine' for the management unit of the logged-in user.
            
            
            
            
            var userId = userId_example;  // string | The userId to whom the Time Off Request applies.
            
            
            
            
            var timeOffRequestId = timeOffRequestId_example;  // string | Time Off Request Id
            
            
            

            try
            {
                
                // Get a time off request by id
                
                TimeOffRequest result = apiInstance.GetWorkforcemanagementManagementunitUserTimeoffrequest(muId, userId, timeOffRequestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunitUserTimeoffrequest: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **userId** | **string**| The userId to whom the Time Off Request applies. |  |
| **timeOffRequestId** | **string**| Time Off Request Id |  |
{: class="table table-striped"}

### Return type

[**TimeOffRequest**](TimeOffRequest.html)

<a name="getworkforcemanagementmanagementunitusertimeoffrequests"></a>

## [**TimeOffRequestList**](TimeOffRequestList.html) GetWorkforcemanagementManagementunitUserTimeoffrequests (string muId, string userId, bool? recentlyReviewed = null)

Get a list of time off requests for any user



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new WorkforceManagementApi();
            
            
            var muId = muId_example;  // string | The muId of the management unit, or 'mine' for the management unit of the logged-in user.
            
            
            
            
            var userId = userId_example;  // string | The userId to whom the Time Off Request applies.
            
            
            
            
            var recentlyReviewed = true;  // bool? | Limit results to requests that have been reviewed within the preceding 30 days (optional)  (default to false)
            
            
            

            try
            {
                
                // Get a list of time off requests for any user
                
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
~~~

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

Get agents in the management unit



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new WorkforceManagementApi();
            
            
            var muId = muId_example;  // string | The muId of the management unit, or 'mine' for the management unit of the logged-in user.
            
            
            

            try
            {
                
                // Get agents in the management unit
                
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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
{: class="table table-striped"}

### Return type

[**WfmUserEntityListing**](WfmUserEntityListing.html)

<a name="getworkforcemanagementmanagementunits"></a>

## [**List&lt;ManagementUnit&gt;**](ManagementUnit.html) GetWorkforcemanagementManagementunits (string selector = null, int? pageSize = null, int? pageNumber = null)

Get management units



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new WorkforceManagementApi();
            
            
            var selector = selector_example;  // string | Selector (optional) 
            
            
            
            
            var pageSize = 56;  // int? |  (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? |  (optional)  (default to 1)
            
            
            

            try
            {
                
                // Get management units
                
                List&lt;ManagementUnit&gt; result = apiInstance.GetWorkforcemanagementManagementunits(selector, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementManagementunits: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **selector** | **string**| Selector | [optional]  |
| **pageSize** | **int?**|  | [optional] [default to 25] |
| **pageNumber** | **int?**|  | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**List<ManagementUnit>**](ManagementUnit.html)

<a name="getworkforcemanagementtimeoffrequest"></a>

## [**TimeOffRequest**](TimeOffRequest.html) GetWorkforcemanagementTimeoffrequest (string timeOffRequestId)

Get a time off request for the current user by id



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new WorkforceManagementApi();
            
            
            var timeOffRequestId = timeOffRequestId_example;  // string | Time Off Request Id
            
            
            

            try
            {
                
                // Get a time off request for the current user by id
                
                TimeOffRequest result = apiInstance.GetWorkforcemanagementTimeoffrequest(timeOffRequestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetWorkforcemanagementTimeoffrequest: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **timeOffRequestId** | **string**| Time Off Request Id |  |
{: class="table table-striped"}

### Return type

[**TimeOffRequest**](TimeOffRequest.html)

<a name="getworkforcemanagementtimeoffrequests"></a>

## [**TimeOffRequestList**](TimeOffRequestList.html) GetWorkforcemanagementTimeoffrequests (bool? recentlyReviewed = null)

Get a list of time off requests for the current user



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **recentlyReviewed** | **bool?**| Limit results to requests that have been reviewed within the preceding 30 days | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**TimeOffRequestList**](TimeOffRequestList.html)

<a name="patchworkforcemanagementtimeoffrequest"></a>

## void PatchWorkforcemanagementTimeoffrequest (string timeOffRequestId, TimeOffRequestPatch body = null)

Mark a time off request for the current user as read or unread



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new WorkforceManagementApi();
            
            
            var timeOffRequestId = timeOffRequestId_example;  // string | Time Off Request Id
            
            
            
            
            
            var body = new TimeOffRequestPatch(); // TimeOffRequestPatch |  (optional) 
            
            

            try
            {
                
                // Mark a time off request for the current user as read or unread
                
                apiInstance.PatchWorkforcemanagementTimeoffrequest(timeOffRequestId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchWorkforcemanagementTimeoffrequest: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **timeOffRequestId** | **string**| Time Off Request Id |  |
| **body** | [**TimeOffRequestPatch**](TimeOffRequestPatch.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postworkforcemanagementmanagementunithistoricaladherencequery"></a>

## [**WfmHistoricalAdherenceResponse**](WfmHistoricalAdherenceResponse.html) PostWorkforcemanagementManagementunitHistoricaladherencequery (string muId, WfmHistoricalAdherenceQuery body = null)

Request a historical adherence report



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new WorkforceManagementApi();
            
            
            var muId = muId_example;  // string | The muId of the management unit, or 'mine' for the management unit of the logged-in user.
            
            
            
            
            
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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **body** | [**WfmHistoricalAdherenceQuery**](WfmHistoricalAdherenceQuery.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**WfmHistoricalAdherenceResponse**](WfmHistoricalAdherenceResponse.html)

<a name="postworkforcemanagementmanagementunitintraday"></a>

## [**IntradayResponse**](IntradayResponse.html) PostWorkforcemanagementManagementunitIntraday (string muId, IntradayQueryDataCommand body = null)

Get intraday data for the given date for the requested queueIds



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new WorkforceManagementApi();
            
            
            var muId = muId_example;  // string | The muId of the management unit, or 'mine' for the management unit of the logged-in user.
            
            
            
            
            
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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **body** | [**IntradayQueryDataCommand**](IntradayQueryDataCommand.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**IntradayResponse**](IntradayResponse.html)

<a name="postworkforcemanagementmanagementunitschedulessearch"></a>

## [**UserScheduleContainer**](UserScheduleContainer.html) PostWorkforcemanagementManagementunitSchedulesSearch (string muId, UserListScheduleRequestBody body = null)

Get user schedules within the given time range



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new WorkforceManagementApi();
            
            
            var muId = muId_example;  // string | The muId of the management unit, or 'mine' for the management unit of the logged-in user.
            
            
            
            
            
            var body = new UserListScheduleRequestBody(); // UserListScheduleRequestBody | body (optional) 
            
            

            try
            {
                
                // Get user schedules within the given time range
                
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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **body** | [**UserListScheduleRequestBody**](UserListScheduleRequestBody.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**UserScheduleContainer**](UserScheduleContainer.html)

<a name="postworkforcemanagementschedules"></a>

## [**UserScheduleContainer**](UserScheduleContainer.html) PostWorkforcemanagementSchedules (CurrentUserScheduleRequestBody body = null)

Get a schedule for the current user



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new WorkforceManagementApi();
            
            
            
            var body = new CurrentUserScheduleRequestBody(); // CurrentUserScheduleRequestBody | body (optional) 
            
            

            try
            {
                
                // Get a schedule for the current user
                
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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CurrentUserScheduleRequestBody**](CurrentUserScheduleRequestBody.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**UserScheduleContainer**](UserScheduleContainer.html)

