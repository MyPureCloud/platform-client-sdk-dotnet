---
title: LogCaptureApi
---
## PureCloudPlatform.Client.V2.Api.LogCaptureApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetDiagnosticsLogcaptureBrowserEntriesDownloadJob**](LogCaptureApi.html#getdiagnosticslogcapturebrowserentriesdownloadjob) | **Get** /api/v2/diagnostics/logcapture/browser/entries/download/jobs/{jobId} | Gets status of async download execution |
| [**PostDiagnosticsLogcaptureBrowserEntriesDownloadJobs**](LogCaptureApi.html#postdiagnosticslogcapturebrowserentriesdownloadjobs) | **Post** /api/v2/diagnostics/logcapture/browser/entries/download/jobs | Creates an async download execution |
{: class="table table-striped"}

<a name="getdiagnosticslogcapturebrowserentriesdownloadjob"></a>

## [**LogCaptureDownloadExecutionResponse**](LogCaptureDownloadExecutionResponse.html) GetDiagnosticsLogcaptureBrowserEntriesDownloadJob (string jobId)



Gets status of async download execution

Requires ALL permissions: 

* troubleshooting:logCapture:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetDiagnosticsLogcaptureBrowserEntriesDownloadJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LogCaptureApi();
            var jobId = jobId_example;  // string | Job ID

            try
            { 
                // Gets status of async download execution
                LogCaptureDownloadExecutionResponse result = apiInstance.GetDiagnosticsLogcaptureBrowserEntriesDownloadJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogCaptureApi.GetDiagnosticsLogcaptureBrowserEntriesDownloadJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| Job ID |  |
{: class="table table-striped"}

### Return type

[**LogCaptureDownloadExecutionResponse**](LogCaptureDownloadExecutionResponse.html)

<a name="postdiagnosticslogcapturebrowserentriesdownloadjobs"></a>

## [**LogCaptureDownloadExecutionResponse**](LogCaptureDownloadExecutionResponse.html) PostDiagnosticsLogcaptureBrowserEntriesDownloadJobs (LogCaptureQueryRequest body = null)



Creates an async download execution

Requires ANY permissions: 

* troubleshooting:logCapture:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostDiagnosticsLogcaptureBrowserEntriesDownloadJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LogCaptureApi();
            var body = new LogCaptureQueryRequest(); // LogCaptureQueryRequest |  (optional) 

            try
            { 
                // Creates an async download execution
                LogCaptureDownloadExecutionResponse result = apiInstance.PostDiagnosticsLogcaptureBrowserEntriesDownloadJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogCaptureApi.PostDiagnosticsLogcaptureBrowserEntriesDownloadJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**LogCaptureQueryRequest**](LogCaptureQueryRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**LogCaptureDownloadExecutionResponse**](LogCaptureDownloadExecutionResponse.html)

