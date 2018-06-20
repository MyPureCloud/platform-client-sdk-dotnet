---
title: WorkforceManagementApi
---
## PureCloudPlatform.Client.V2.Api.WorkforceManagementApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetWorkforcemanagementAdherence**](WorkforceManagementApi.html#getworkforcemanagementadherence) | **GET** /api/v2/workforcemanagement/adherence | Get a list of UserScheduleAdherence records for the requested users |
| [**GetWorkforcemanagementManagementunitActivitycodes**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitactivitycodes) | **GET** /api/v2/workforcemanagement/managementunits/{muId}/activitycodes | Get activity codes |
| [**GetWorkforcemanagementManagementunitIntradayQueues**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitintradayqueues) | **GET** /api/v2/workforcemanagement/managementunits/{muId}/intraday/queues | Get intraday queues for the given date |
| [**GetWorkforcemanagementManagementunitUserTimeoffrequest**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitusertimeoffrequest) | **GET** /api/v2/workforcemanagement/managementunits/{muId}/users/{userId}/timeoffrequests/{timeOffRequestId} | Get a time off request |
| [**GetWorkforcemanagementManagementunitUserTimeoffrequests**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitusertimeoffrequests) | **GET** /api/v2/workforcemanagement/managementunits/{muId}/users/{userId}/timeoffrequests | Get a list of time off requests for a given user |
| [**GetWorkforcemanagementManagementunitUsers**](WorkforceManagementApi.html#getworkforcemanagementmanagementunitusers) | **GET** /api/v2/workforcemanagement/managementunits/{muId}/users | Get agents in the management unit |
| [**GetWorkforcemanagementManagementunits**](WorkforceManagementApi.html#getworkforcemanagementmanagementunits) | **GET** /api/v2/workforcemanagement/managementunits | Get management units |
| [**PatchWorkforcemanagementManagementunitUserTimeoffrequest**](WorkforceManagementApi.html#patchworkforcemanagementmanagementunitusertimeoffrequest) | **PATCH** /api/v2/workforcemanagement/managementunits/{muId}/users/{userId}/timeoffrequests/{timeOffRequestId} | Update a time off request |
| [**PostWorkforcemanagementManagementunitActivitycodes**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitactivitycodes) | **POST** /api/v2/workforcemanagement/managementunits/{muId}/activitycodes | Create a new activity code |
| [**PostWorkforcemanagementManagementunitHistoricaladherencequery**](WorkforceManagementApi.html#postworkforcemanagementmanagementunithistoricaladherencequery) | **POST** /api/v2/workforcemanagement/managementunits/{muId}/historicaladherencequery | Request a historical adherence report |
| [**PostWorkforcemanagementManagementunitIntraday**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitintraday) | **POST** /api/v2/workforcemanagement/managementunits/{muId}/intraday | Get intraday data for the given date for the requested queueIds |
| [**PostWorkforcemanagementManagementunitSchedulesSearch**](WorkforceManagementApi.html#postworkforcemanagementmanagementunitschedulessearch) | **POST** /api/v2/workforcemanagement/managementunits/{muId}/schedules/search | Query published schedules for given given time range for set of users |
{: class="table table-striped"}

<a name="getworkforcemanagementadherence"></a>

## [**List&lt;UserScheduleAdherence&gt;**](UserScheduleAdherence.html) GetWorkforcemanagementAdherence (List<string> userId)



Get a list of UserScheduleAdherence records for the requested users



Requires ANY permissions: 

* wfm:realtimeAdherence:view

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



Get activity codes



Requires ANY permissions: 

* wfm:activityCode:administer
* wfm:agent:administer
* wfm:agentSchedule:view
* wfm:historicalAdherence:view
* wfm:intraday:view
* wfm:managementUnit:administer
* wfm:publishedSchedule:view
* wfm:realtimeAdherence:view
* wfm:schedule:administer
* wfm:schedule:generate
* wfm:serviceGoalGroup:administer
* wfm:shortTermForecast:administer
* wfm:agentTimeOffRequest:submit
* wfm:timeOffRequest:administer
* wfm:workPlan:administer

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
{: class="table table-striped"}

### Return type

[**ActivityCodeContainer**](ActivityCodeContainer.html)

<a name="getworkforcemanagementmanagementunitintradayqueues"></a>

## [**WfmIntradayQueueListing**](WfmIntradayQueueListing.html) GetWorkforcemanagementManagementunitIntradayQueues (string muId, string date)



Get intraday queues for the given date



Requires ANY permissions: 

* wfm:intraday:view

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
            
            
            var muId = muId_example;  // string | The management unit ID of the management unit, or 'mine' for the management unit of the logged-in user.
            
            
            
            
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
| **muId** | **string**| The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **date** | **string**| ISO-8601 date string with no time or timezone component, interpreted in the configured management unit time zone, e.g. 2017-01-23 |  |
{: class="table table-striped"}

### Return type

[**WfmIntradayQueueListing**](WfmIntradayQueueListing.html)

<a name="getworkforcemanagementmanagementunitusertimeoffrequest"></a>

## [**TimeOffRequestResponse**](TimeOffRequestResponse.html) GetWorkforcemanagementManagementunitUserTimeoffrequest (string muId, string userId, string timeOffRequestId)



Get a time off request



Requires ANY permissions: 

* wfm:timeOffRequest:administer

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
~~~

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

* wfm:timeOffRequest:administer

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



Requires ANY permissions: 

* wfm:agent:administer
* wfm:timeOffRequest:administer
* wfm:realtimeAdherence:view
* wfm:historicalAdherence:view

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
            
            
            var muId = muId_example;  // string | The management unit ID of the management unit, or 'mine' for the management unit of the logged-in user.
            
            
            

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
| **muId** | **string**| The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
{: class="table table-striped"}

### Return type

[**WfmUserEntityListing**](WfmUserEntityListing.html)

<a name="getworkforcemanagementmanagementunits"></a>

## [**ManagementUnitListing**](ManagementUnitListing.html) GetWorkforcemanagementManagementunits (int? pageSize = null, int? pageNumber = null, string expand = null, string feature = null, string divisionId = null)



Get management units



Requires NO permissions: 


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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**|  | [optional]  |
| **pageNumber** | **int?**|  | [optional]  |
| **expand** | **string**|  | [optional] <br />**Values**: details |
| **feature** | **string**|  | [optional] <br />**Values**: Agents, ActivityCodes, HistoricalAdherence, IntradayMonitoring, ManagementUnits, RealTimeAdherence, Schedules, ServiceGoalGroups, ShortTermForecasts, TimeOffRequests, WorkPlans |
| **divisionId** | **string**|  | [optional]  |
{: class="table table-striped"}

### Return type

[**ManagementUnitListing**](ManagementUnitListing.html)

<a name="patchworkforcemanagementmanagementunitusertimeoffrequest"></a>

## [**TimeOffRequestResponse**](TimeOffRequestResponse.html) PatchWorkforcemanagementManagementunitUserTimeoffrequest (string muId, string userId, string timeOffRequestId, AdminTimeOffRequestPatch body = null)



Update a time off request



Requires ANY permissions: 

* wfm:timeOffRequest:administer

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

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

<a name="postworkforcemanagementmanagementunitactivitycodes"></a>

## [**ActivityCode**](ActivityCode.html) PostWorkforcemanagementManagementunitActivitycodes (string muId, CreateActivityCodeRequest body = null)



Create a new activity code



Requires ANY permissions: 

* wfm:activityCode:administer

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **body** | [**CreateActivityCodeRequest**](CreateActivityCodeRequest.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**ActivityCode**](ActivityCode.html)

<a name="postworkforcemanagementmanagementunithistoricaladherencequery"></a>

## [**WfmHistoricalAdherenceResponse**](WfmHistoricalAdherenceResponse.html) PostWorkforcemanagementManagementunitHistoricaladherencequery (string muId, WfmHistoricalAdherenceQuery body = null)



Request a historical adherence report



Requires ANY permissions: 

* wfm:historicalAdherence:view

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
            
            
            var muId = muId_example;  // string | The management unit ID of the management unit, or 'mine' for the management unit of the logged-in user.
            
            
            
            
            
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
| **muId** | **string**| The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
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
            
            
            var muId = muId_example;  // string | The management unit ID of the management unit, or 'mine' for the management unit of the logged-in user.
            
            
            
            
            
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
| **muId** | **string**| The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **body** | [**IntradayQueryDataCommand**](IntradayQueryDataCommand.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**IntradayResponse**](IntradayResponse.html)

<a name="postworkforcemanagementmanagementunitschedulessearch"></a>

## [**UserScheduleContainer**](UserScheduleContainer.html) PostWorkforcemanagementManagementunitSchedulesSearch (string muId, UserListScheduleRequestBody body = null)



Query published schedules for given given time range for set of users



Requires ANY permissions: 

* wfm:schedule:administer
* wfm:publishedSchedule:view

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user. |  |
| **body** | [**UserListScheduleRequestBody**](UserListScheduleRequestBody.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**UserScheduleContainer**](UserScheduleContainer.html)

