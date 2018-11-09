---
title: AnalyticsApi
---
## PureCloudPlatform.Client.V2.Api.AnalyticsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteAnalyticsReportingSchedule**](AnalyticsApi.html#deleteanalyticsreportingschedule) | **DELETE** /api/v2/analytics/reporting/schedules/{scheduleId} | Delete a scheduled report job. |
| [**GetAnalyticsConversationDetails**](AnalyticsApi.html#getanalyticsconversationdetails) | **GET** /api/v2/analytics/conversations/{conversationId}/details | Get a conversation by id |
| [**GetAnalyticsConversationsDetails**](AnalyticsApi.html#getanalyticsconversationsdetails) | **GET** /api/v2/analytics/conversations/details | Gets multiple conversations by id |
| [**GetAnalyticsReportingExports**](AnalyticsApi.html#getanalyticsreportingexports) | **GET** /api/v2/analytics/reporting/exports | Get all view export requests for a user |
| [**GetAnalyticsReportingMetadata**](AnalyticsApi.html#getanalyticsreportingmetadata) | **GET** /api/v2/analytics/reporting/metadata | Get list of reporting metadata. |
| [**GetAnalyticsReportingReportIdMetadata**](AnalyticsApi.html#getanalyticsreportingreportidmetadata) | **GET** /api/v2/analytics/reporting/{reportId}/metadata | Get a reporting metadata. |
| [**GetAnalyticsReportingReportformats**](AnalyticsApi.html#getanalyticsreportingreportformats) | **GET** /api/v2/analytics/reporting/reportformats | Get a list of report formats |
| [**GetAnalyticsReportingSchedule**](AnalyticsApi.html#getanalyticsreportingschedule) | **GET** /api/v2/analytics/reporting/schedules/{scheduleId} | Get a scheduled report job. |
| [**GetAnalyticsReportingScheduleHistory**](AnalyticsApi.html#getanalyticsreportingschedulehistory) | **GET** /api/v2/analytics/reporting/schedules/{scheduleId}/history | Get list of completed scheduled report jobs. |
| [**GetAnalyticsReportingScheduleHistoryLatest**](AnalyticsApi.html#getanalyticsreportingschedulehistorylatest) | **GET** /api/v2/analytics/reporting/schedules/{scheduleId}/history/latest | Get most recently completed scheduled report job. |
| [**GetAnalyticsReportingScheduleHistoryRunId**](AnalyticsApi.html#getanalyticsreportingschedulehistoryrunid) | **GET** /api/v2/analytics/reporting/schedules/{scheduleId}/history/{runId} | A completed scheduled report job |
| [**GetAnalyticsReportingSchedules**](AnalyticsApi.html#getanalyticsreportingschedules) | **GET** /api/v2/analytics/reporting/schedules | Get a list of scheduled report jobs |
| [**GetAnalyticsReportingTimeperiods**](AnalyticsApi.html#getanalyticsreportingtimeperiods) | **GET** /api/v2/analytics/reporting/timeperiods | Get a list of report time periods. |
| [**PostAnalyticsConversationDetailsProperties**](AnalyticsApi.html#postanalyticsconversationdetailsproperties) | **POST** /api/v2/analytics/conversations/{conversationId}/details/properties | Index conversation properties |
| [**PostAnalyticsConversationsAggregatesQuery**](AnalyticsApi.html#postanalyticsconversationsaggregatesquery) | **POST** /api/v2/analytics/conversations/aggregates/query | Query for conversation aggregates |
| [**PostAnalyticsConversationsDetailsQuery**](AnalyticsApi.html#postanalyticsconversationsdetailsquery) | **POST** /api/v2/analytics/conversations/details/query | Query for conversation details |
| [**PostAnalyticsEvaluationsAggregatesQuery**](AnalyticsApi.html#postanalyticsevaluationsaggregatesquery) | **POST** /api/v2/analytics/evaluations/aggregates/query | Query for evaluation aggregates |
| [**PostAnalyticsFlowsAggregatesQuery**](AnalyticsApi.html#postanalyticsflowsaggregatesquery) | **POST** /api/v2/analytics/flows/aggregates/query | Query for flow aggregates |
| [**PostAnalyticsQueuesObservationsQuery**](AnalyticsApi.html#postanalyticsqueuesobservationsquery) | **POST** /api/v2/analytics/queues/observations/query | Query for queue observations |
| [**PostAnalyticsReportingExports**](AnalyticsApi.html#postanalyticsreportingexports) | **POST** /api/v2/analytics/reporting/exports | Generate a view export request |
| [**PostAnalyticsReportingScheduleRunreport**](AnalyticsApi.html#postanalyticsreportingschedulerunreport) | **POST** /api/v2/analytics/reporting/schedules/{scheduleId}/runreport | Place a scheduled report immediately into the reporting queue |
| [**PostAnalyticsReportingSchedules**](AnalyticsApi.html#postanalyticsreportingschedules) | **POST** /api/v2/analytics/reporting/schedules | Create a scheduled report job |
| [**PostAnalyticsUsersAggregatesQuery**](AnalyticsApi.html#postanalyticsusersaggregatesquery) | **POST** /api/v2/analytics/users/aggregates/query | Query for user aggregates |
| [**PostAnalyticsUsersDetailsQuery**](AnalyticsApi.html#postanalyticsusersdetailsquery) | **POST** /api/v2/analytics/users/details/query | Query for user details |
| [**PostAnalyticsUsersObservationsQuery**](AnalyticsApi.html#postanalyticsusersobservationsquery) | **POST** /api/v2/analytics/users/observations/query | Query for user observations |
| [**PutAnalyticsReportingSchedule**](AnalyticsApi.html#putanalyticsreportingschedule) | **PUT** /api/v2/analytics/reporting/schedules/{scheduleId} | Update a scheduled report job. |
{: class="table table-striped"}

<a name="deleteanalyticsreportingschedule"></a>

## void DeleteAnalyticsReportingSchedule (string scheduleId)



Delete a scheduled report job.



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
    public class DeleteAnalyticsReportingScheduleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AnalyticsApi();
            
            
            var scheduleId = scheduleId_example;  // string | Schedule ID
            
            
            

            try
            {
                
                // Delete a scheduled report job.
                
                apiInstance.DeleteAnalyticsReportingSchedule(scheduleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.DeleteAnalyticsReportingSchedule: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleId** | **string**| Schedule ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getanalyticsconversationdetails"></a>

## [**AnalyticsConversation**](AnalyticsConversation.html) GetAnalyticsConversationDetails (string conversationId)



Get a conversation by id



Requires ANY permissions: 

* analytics:conversationDetail:view

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AnalyticsApi();
            
            
            var conversationId = conversationId_example;  // string | conversationId
            
            
            

            try
            {
                
                // Get a conversation by id
                
                AnalyticsConversation result = apiInstance.GetAnalyticsConversationDetails(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsConversationDetails: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
{: class="table table-striped"}

### Return type

[**AnalyticsConversation**](AnalyticsConversation.html)

<a name="getanalyticsconversationsdetails"></a>

## [**AnalyticsConversation**](AnalyticsConversation.html) GetAnalyticsConversationsDetails (List<string> id = null)



Gets multiple conversations by id



Requires ANY permissions: 

* analytics:conversationDetail:view

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AnalyticsApi();
            
            
            
            var id = new List<string>(); // List<string> | Comma-separated conversation ids (optional) 
            
            

            try
            {
                
                // Gets multiple conversations by id
                
                AnalyticsConversation result = apiInstance.GetAnalyticsConversationsDetails(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsConversationsDetails: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | [**List<string>**](string.html)| Comma-separated conversation ids | [optional]  |
{: class="table table-striped"}

### Return type

[**AnalyticsConversation**](AnalyticsConversation.html)

<a name="getanalyticsreportingexports"></a>

## [**ReportingExportJobListing**](ReportingExportJobListing.html) GetAnalyticsReportingExports ()



Get all view export requests for a user



Requires ANY permissions: 

* analytics:dataExport:view

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AnalyticsApi();
            

            try
            {
                
                // Get all view export requests for a user
                
                ReportingExportJobListing result = apiInstance.GetAnalyticsReportingExports();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsReportingExports: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**ReportingExportJobListing**](ReportingExportJobListing.html)

<a name="getanalyticsreportingmetadata"></a>

## [**ReportMetaDataEntityListing**](ReportMetaDataEntityListing.html) GetAnalyticsReportingMetadata (int? pageNumber = null, int? pageSize = null, string locale = null)



Get list of reporting metadata.



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
    public class GetAnalyticsReportingMetadataExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AnalyticsApi();
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var locale = locale_example;  // string | Locale (optional) 
            
            
            

            try
            {
                
                // Get list of reporting metadata.
                
                ReportMetaDataEntityListing result = apiInstance.GetAnalyticsReportingMetadata(pageNumber, pageSize, locale);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsReportingMetadata: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **locale** | **string**| Locale | [optional]  |
{: class="table table-striped"}

### Return type

[**ReportMetaDataEntityListing**](ReportMetaDataEntityListing.html)

<a name="getanalyticsreportingreportidmetadata"></a>

## [**ReportMetaData**](ReportMetaData.html) GetAnalyticsReportingReportIdMetadata (string reportId, string locale = null)



Get a reporting metadata.



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
    public class GetAnalyticsReportingReportIdMetadataExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AnalyticsApi();
            
            
            var reportId = reportId_example;  // string | Report ID
            
            
            
            
            var locale = locale_example;  // string | Locale (optional) 
            
            
            

            try
            {
                
                // Get a reporting metadata.
                
                ReportMetaData result = apiInstance.GetAnalyticsReportingReportIdMetadata(reportId, locale);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsReportingReportIdMetadata: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **reportId** | **string**| Report ID |  |
| **locale** | **string**| Locale | [optional]  |
{: class="table table-striped"}

### Return type

[**ReportMetaData**](ReportMetaData.html)

<a name="getanalyticsreportingreportformats"></a>

## **List&lt;string&gt;** GetAnalyticsReportingReportformats ()



Get a list of report formats

Get a list of report formats.

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
    public class GetAnalyticsReportingReportformatsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AnalyticsApi();
            

            try
            {
                
                // Get a list of report formats
                
                List&lt;string&gt; result = apiInstance.GetAnalyticsReportingReportformats();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsReportingReportformats: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

**List<string>**

<a name="getanalyticsreportingschedule"></a>

## [**ReportSchedule**](ReportSchedule.html) GetAnalyticsReportingSchedule (string scheduleId)



Get a scheduled report job.



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
    public class GetAnalyticsReportingScheduleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AnalyticsApi();
            
            
            var scheduleId = scheduleId_example;  // string | Schedule ID
            
            
            

            try
            {
                
                // Get a scheduled report job.
                
                ReportSchedule result = apiInstance.GetAnalyticsReportingSchedule(scheduleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsReportingSchedule: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleId** | **string**| Schedule ID |  |
{: class="table table-striped"}

### Return type

[**ReportSchedule**](ReportSchedule.html)

<a name="getanalyticsreportingschedulehistory"></a>

## [**ReportRunEntryEntityDomainListing**](ReportRunEntryEntityDomainListing.html) GetAnalyticsReportingScheduleHistory (string scheduleId, int? pageNumber = null, int? pageSize = null)



Get list of completed scheduled report jobs.



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
    public class GetAnalyticsReportingScheduleHistoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AnalyticsApi();
            
            
            var scheduleId = scheduleId_example;  // string | Schedule ID
            
            
            
            
            var pageNumber = 56;  // int? |  (optional)  (default to 1)
            
            
            
            
            var pageSize = 56;  // int? |  (optional)  (default to 25)
            
            
            

            try
            {
                
                // Get list of completed scheduled report jobs.
                
                ReportRunEntryEntityDomainListing result = apiInstance.GetAnalyticsReportingScheduleHistory(scheduleId, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsReportingScheduleHistory: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleId** | **string**| Schedule ID |  |
| **pageNumber** | **int?**|  | [optional] [default to 1] |
| **pageSize** | **int?**|  | [optional] [default to 25] |
{: class="table table-striped"}

### Return type

[**ReportRunEntryEntityDomainListing**](ReportRunEntryEntityDomainListing.html)

<a name="getanalyticsreportingschedulehistorylatest"></a>

## [**ReportRunEntry**](ReportRunEntry.html) GetAnalyticsReportingScheduleHistoryLatest (string scheduleId)



Get most recently completed scheduled report job.



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
    public class GetAnalyticsReportingScheduleHistoryLatestExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AnalyticsApi();
            
            
            var scheduleId = scheduleId_example;  // string | Schedule ID
            
            
            

            try
            {
                
                // Get most recently completed scheduled report job.
                
                ReportRunEntry result = apiInstance.GetAnalyticsReportingScheduleHistoryLatest(scheduleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsReportingScheduleHistoryLatest: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleId** | **string**| Schedule ID |  |
{: class="table table-striped"}

### Return type

[**ReportRunEntry**](ReportRunEntry.html)

<a name="getanalyticsreportingschedulehistoryrunid"></a>

## [**ReportRunEntry**](ReportRunEntry.html) GetAnalyticsReportingScheduleHistoryRunId (string runId, string scheduleId)



A completed scheduled report job

A completed scheduled report job.

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
    public class GetAnalyticsReportingScheduleHistoryRunIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AnalyticsApi();
            
            
            var runId = runId_example;  // string | Run ID
            
            
            
            
            var scheduleId = scheduleId_example;  // string | Schedule ID
            
            
            

            try
            {
                
                // A completed scheduled report job
                
                ReportRunEntry result = apiInstance.GetAnalyticsReportingScheduleHistoryRunId(runId, scheduleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsReportingScheduleHistoryRunId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **runId** | **string**| Run ID |  |
| **scheduleId** | **string**| Schedule ID |  |
{: class="table table-striped"}

### Return type

[**ReportRunEntry**](ReportRunEntry.html)

<a name="getanalyticsreportingschedules"></a>

## [**ReportScheduleEntityListing**](ReportScheduleEntityListing.html) GetAnalyticsReportingSchedules (int? pageNumber = null, int? pageSize = null)



Get a list of scheduled report jobs

Get a list of scheduled report jobs.

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
    public class GetAnalyticsReportingSchedulesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AnalyticsApi();
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            

            try
            {
                
                // Get a list of scheduled report jobs
                
                ReportScheduleEntityListing result = apiInstance.GetAnalyticsReportingSchedules(pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsReportingSchedules: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
{: class="table table-striped"}

### Return type

[**ReportScheduleEntityListing**](ReportScheduleEntityListing.html)

<a name="getanalyticsreportingtimeperiods"></a>

## **List&lt;string&gt;** GetAnalyticsReportingTimeperiods ()



Get a list of report time periods.



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
    public class GetAnalyticsReportingTimeperiodsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AnalyticsApi();
            

            try
            {
                
                // Get a list of report time periods.
                
                List&lt;string&gt; result = apiInstance.GetAnalyticsReportingTimeperiods();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetAnalyticsReportingTimeperiods: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

**List<string>**

<a name="postanalyticsconversationdetailsproperties"></a>

## [**PropertyIndexRequest**](PropertyIndexRequest.html) PostAnalyticsConversationDetailsProperties (string conversationId, PropertyIndexRequest body)



Index conversation properties



Requires ANY permissions: 

* analytics:conversationProperties:index

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**PropertyIndexRequest**](PropertyIndexRequest.html)| request |  |
{: class="table table-striped"}

### Return type

[**PropertyIndexRequest**](PropertyIndexRequest.html)

<a name="postanalyticsconversationsaggregatesquery"></a>

## [**AggregateQueryResponse**](AggregateQueryResponse.html) PostAnalyticsConversationsAggregatesQuery (AggregationQuery body)



Query for conversation aggregates



Requires ANY permissions: 

* analytics:conversationAggregate:view

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AnalyticsApi();
            
            
            
            var body = new AggregationQuery(); // AggregationQuery | query
            
            

            try
            {
                
                // Query for conversation aggregates
                
                AggregateQueryResponse result = apiInstance.PostAnalyticsConversationsAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsConversationsAggregatesQuery: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AggregationQuery**](AggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AggregateQueryResponse**](AggregateQueryResponse.html)

<a name="postanalyticsconversationsdetailsquery"></a>

## [**AnalyticsConversationQueryResponse**](AnalyticsConversationQueryResponse.html) PostAnalyticsConversationsDetailsQuery (ConversationQuery body)



Query for conversation details



Requires ANY permissions: 

* analytics:conversationDetail:view

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ConversationQuery**](ConversationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AnalyticsConversationQueryResponse**](AnalyticsConversationQueryResponse.html)

<a name="postanalyticsevaluationsaggregatesquery"></a>

## [**AggregateQueryResponse**](AggregateQueryResponse.html) PostAnalyticsEvaluationsAggregatesQuery (AggregationQuery body)



Query for evaluation aggregates



Requires ANY permissions: 

* analytics:evaluationAggregate:view

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AnalyticsApi();
            
            
            
            var body = new AggregationQuery(); // AggregationQuery | query
            
            

            try
            {
                
                // Query for evaluation aggregates
                
                AggregateQueryResponse result = apiInstance.PostAnalyticsEvaluationsAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsEvaluationsAggregatesQuery: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AggregationQuery**](AggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AggregateQueryResponse**](AggregateQueryResponse.html)

<a name="postanalyticsflowsaggregatesquery"></a>

## [**AggregateQueryResponse**](AggregateQueryResponse.html) PostAnalyticsFlowsAggregatesQuery (AggregationQuery body)



Query for flow aggregates



Requires ANY permissions: 

* analytics:flowAggregate:view

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AnalyticsApi();
            
            
            
            var body = new AggregationQuery(); // AggregationQuery | query
            
            

            try
            {
                
                // Query for flow aggregates
                
                AggregateQueryResponse result = apiInstance.PostAnalyticsFlowsAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsFlowsAggregatesQuery: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AggregationQuery**](AggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AggregateQueryResponse**](AggregateQueryResponse.html)

<a name="postanalyticsqueuesobservationsquery"></a>

## [**QualifierMappingObservationQueryResponse**](QualifierMappingObservationQueryResponse.html) PostAnalyticsQueuesObservationsQuery (ObservationQuery body)



Query for queue observations



Requires ANY permissions: 

* analytics:queueObservation:view

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AnalyticsApi();
            
            
            
            var body = new ObservationQuery(); // ObservationQuery | query
            
            

            try
            {
                
                // Query for queue observations
                
                QualifierMappingObservationQueryResponse result = apiInstance.PostAnalyticsQueuesObservationsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsQueuesObservationsQuery: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ObservationQuery**](ObservationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**QualifierMappingObservationQueryResponse**](QualifierMappingObservationQueryResponse.html)

<a name="postanalyticsreportingexports"></a>

## [**ReportingExportJobResponse**](ReportingExportJobResponse.html) PostAnalyticsReportingExports (ReportingExportJobRequest body)



Generate a view export request



Requires ANY permissions: 

* analytics:dataExport:add

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ReportingExportJobRequest**](ReportingExportJobRequest.html)| ReportingExportJobRequest |  |
{: class="table table-striped"}

### Return type

[**ReportingExportJobResponse**](ReportingExportJobResponse.html)

<a name="postanalyticsreportingschedulerunreport"></a>

## [**RunNowResponse**](RunNowResponse.html) PostAnalyticsReportingScheduleRunreport (string scheduleId)



Place a scheduled report immediately into the reporting queue



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
    public class PostAnalyticsReportingScheduleRunreportExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AnalyticsApi();
            
            
            var scheduleId = scheduleId_example;  // string | Schedule ID
            
            
            

            try
            {
                
                // Place a scheduled report immediately into the reporting queue
                
                RunNowResponse result = apiInstance.PostAnalyticsReportingScheduleRunreport(scheduleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsReportingScheduleRunreport: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleId** | **string**| Schedule ID |  |
{: class="table table-striped"}

### Return type

[**RunNowResponse**](RunNowResponse.html)

<a name="postanalyticsreportingschedules"></a>

## [**ReportSchedule**](ReportSchedule.html) PostAnalyticsReportingSchedules (ReportSchedule body)



Create a scheduled report job

Create a scheduled report job.

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
    public class PostAnalyticsReportingSchedulesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AnalyticsApi();
            
            
            
            var body = new ReportSchedule(); // ReportSchedule | ReportSchedule
            
            

            try
            {
                
                // Create a scheduled report job
                
                ReportSchedule result = apiInstance.PostAnalyticsReportingSchedules(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsReportingSchedules: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ReportSchedule**](ReportSchedule.html)| ReportSchedule |  |
{: class="table table-striped"}

### Return type

[**ReportSchedule**](ReportSchedule.html)

<a name="postanalyticsusersaggregatesquery"></a>

## [**PresenceQueryResponse**](PresenceQueryResponse.html) PostAnalyticsUsersAggregatesQuery (AggregationQuery body)



Query for user aggregates



Requires ANY permissions: 

* analytics:userAggregate:view

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AnalyticsApi();
            
            
            
            var body = new AggregationQuery(); // AggregationQuery | query
            
            

            try
            {
                
                // Query for user aggregates
                
                PresenceQueryResponse result = apiInstance.PostAnalyticsUsersAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsUsersAggregatesQuery: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AggregationQuery**](AggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**PresenceQueryResponse**](PresenceQueryResponse.html)

<a name="postanalyticsusersdetailsquery"></a>

## [**AnalyticsUserDetailsQueryResponse**](AnalyticsUserDetailsQueryResponse.html) PostAnalyticsUsersDetailsQuery (UserDetailsQuery body)



Query for user details



Requires ANY permissions: 

* analytics:userObservation:view

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UserDetailsQuery**](UserDetailsQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AnalyticsUserDetailsQueryResponse**](AnalyticsUserDetailsQueryResponse.html)

<a name="postanalyticsusersobservationsquery"></a>

## [**ObservationQueryResponse**](ObservationQueryResponse.html) PostAnalyticsUsersObservationsQuery (ObservationQuery body)



Query for user observations



Requires ANY permissions: 

* analytics:userObservation:view

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AnalyticsApi();
            
            
            
            var body = new ObservationQuery(); // ObservationQuery | query
            
            

            try
            {
                
                // Query for user observations
                
                ObservationQueryResponse result = apiInstance.PostAnalyticsUsersObservationsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostAnalyticsUsersObservationsQuery: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ObservationQuery**](ObservationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**ObservationQueryResponse**](ObservationQueryResponse.html)

<a name="putanalyticsreportingschedule"></a>

## [**ReportSchedule**](ReportSchedule.html) PutAnalyticsReportingSchedule (string scheduleId, ReportSchedule body)



Update a scheduled report job.



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
    public class PutAnalyticsReportingScheduleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AnalyticsApi();
            
            
            var scheduleId = scheduleId_example;  // string | Schedule ID
            
            
            
            
            
            var body = new ReportSchedule(); // ReportSchedule | ReportSchedule
            
            

            try
            {
                
                // Update a scheduled report job.
                
                ReportSchedule result = apiInstance.PutAnalyticsReportingSchedule(scheduleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PutAnalyticsReportingSchedule: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleId** | **string**| Schedule ID |  |
| **body** | [**ReportSchedule**](ReportSchedule.html)| ReportSchedule |  |
{: class="table table-striped"}

### Return type

[**ReportSchedule**](ReportSchedule.html)

