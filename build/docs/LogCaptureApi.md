# LogCaptureApi

## PureCloudPlatform.Client.V2.Api.LogCaptureApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteDiagnosticsLogcaptureBrowserUser**](#DeleteDiagnosticsLogcaptureBrowserUser) | **Delete** /api/v2/diagnostics/logcapture/browser/users/{userId} | Disable browser log capture for the user |
| [**GetDiagnosticsLogcaptureBrowserEntriesDownloadJob**](#GetDiagnosticsLogcaptureBrowserEntriesDownloadJob) | **Get** /api/v2/diagnostics/logcapture/browser/entries/download/jobs/{jobId} | Gets status of async download execution |
| [**GetDiagnosticsLogcaptureBrowserUser**](#GetDiagnosticsLogcaptureBrowserUser) | **Get** /api/v2/diagnostics/logcapture/browser/users/{userId} | Get log capture configuration for the user |
| [**GetDiagnosticsLogcaptureBrowserUsers**](#GetDiagnosticsLogcaptureBrowserUsers) | **Get** /api/v2/diagnostics/logcapture/browser/users | Get all log capture enabled users for an org |
| [**PostDiagnosticsLogcaptureBrowserEntriesDownloadJobs**](#PostDiagnosticsLogcaptureBrowserEntriesDownloadJobs) | **Post** /api/v2/diagnostics/logcapture/browser/entries/download/jobs | Creates an async download execution |
| [**PostDiagnosticsLogcaptureBrowserEntriesQuery**](#PostDiagnosticsLogcaptureBrowserEntriesQuery) | **Post** /api/v2/diagnostics/logcapture/browser/entries/query | Query collected log entries. It returns a limited amount of records, to get all records use download endpoint. |
| [**PostDiagnosticsLogcaptureBrowserUser**](#PostDiagnosticsLogcaptureBrowserUser) | **Post** /api/v2/diagnostics/logcapture/browser/users/{userId} | Enable log capture for a user or update expiration |



## DeleteDiagnosticsLogcaptureBrowserUser

> void DeleteDiagnosticsLogcaptureBrowserUser (string userId)


Disable browser log capture for the user

Requires ANY permissions: 

* troubleshooting:logCapture:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteDiagnosticsLogcaptureBrowserUserExample
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
            var userId = userId_example;  // string | The id of the user to disable browser log capture

            try
            { 
                // Disable browser log capture for the user
                apiInstance.DeleteDiagnosticsLogcaptureBrowserUser(userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogCaptureApi.DeleteDiagnosticsLogcaptureBrowserUser: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| The id of the user to disable browser log capture |  |

### Return type

void (empty response body)


## GetDiagnosticsLogcaptureBrowserEntriesDownloadJob

> [**LogCaptureDownloadExecutionResponse**](LogCaptureDownloadExecutionResponse) GetDiagnosticsLogcaptureBrowserEntriesDownloadJob (string jobId)


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

### Return type

[**LogCaptureDownloadExecutionResponse**](LogCaptureDownloadExecutionResponse)


## GetDiagnosticsLogcaptureBrowserUser

> [**LogCaptureUserConfiguration**](LogCaptureUserConfiguration) GetDiagnosticsLogcaptureBrowserUser (string userId)


Get log capture configuration for the user

Requires ANY permissions: 

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
    public class GetDiagnosticsLogcaptureBrowserUserExample
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
            var userId = userId_example;  // string | The id of the user to get browser log capture configuration

            try
            { 
                // Get log capture configuration for the user
                LogCaptureUserConfiguration result = apiInstance.GetDiagnosticsLogcaptureBrowserUser(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogCaptureApi.GetDiagnosticsLogcaptureBrowserUser: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| The id of the user to get browser log capture configuration |  |

### Return type

[**LogCaptureUserConfiguration**](LogCaptureUserConfiguration)


## GetDiagnosticsLogcaptureBrowserUsers

> [**PagelessEntityListing**](PagelessEntityListing) GetDiagnosticsLogcaptureBrowserUsers (bool? includeExpired = null)


Get all log capture enabled users for an org

Requires ANY permissions: 

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
    public class GetDiagnosticsLogcaptureBrowserUsersExample
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
            var includeExpired = true;  // bool? | Include expired users with log captures still available for search or download (optional)  (default to false)

            try
            { 
                // Get all log capture enabled users for an org
                PagelessEntityListing result = apiInstance.GetDiagnosticsLogcaptureBrowserUsers(includeExpired);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogCaptureApi.GetDiagnosticsLogcaptureBrowserUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **includeExpired** | **bool?**| Include expired users with log captures still available for search or download | [optional] [default to false] |

### Return type

[**PagelessEntityListing**](PagelessEntityListing)


## PostDiagnosticsLogcaptureBrowserEntriesDownloadJobs

> [**LogCaptureDownloadExecutionResponse**](LogCaptureDownloadExecutionResponse) PostDiagnosticsLogcaptureBrowserEntriesDownloadJobs (LogCaptureQueryRequest body = null)


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
| **body** | [**LogCaptureQueryRequest**](LogCaptureQueryRequest)|  | [optional]  |

### Return type

[**LogCaptureDownloadExecutionResponse**](LogCaptureDownloadExecutionResponse)


## PostDiagnosticsLogcaptureBrowserEntriesQuery

> [**LogCaptureQueryResponse**](LogCaptureQueryResponse) PostDiagnosticsLogcaptureBrowserEntriesQuery (string before = null, string after = null, string pageSize = null, LogCaptureQueryRequest body = null)


Query collected log entries. It returns a limited amount of records, to get all records use download endpoint.

Requires ANY permissions: 

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
    public class PostDiagnosticsLogcaptureBrowserEntriesQueryExample
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
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var body = new LogCaptureQueryRequest(); // LogCaptureQueryRequest |  (optional) 

            try
            { 
                // Query collected log entries. It returns a limited amount of records, to get all records use download endpoint.
                LogCaptureQueryResponse result = apiInstance.PostDiagnosticsLogcaptureBrowserEntriesQuery(before, after, pageSize, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogCaptureApi.PostDiagnosticsLogcaptureBrowserEntriesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **body** | [**LogCaptureQueryRequest**](LogCaptureQueryRequest)|  | [optional]  |

### Return type

[**LogCaptureQueryResponse**](LogCaptureQueryResponse)


## PostDiagnosticsLogcaptureBrowserUser

> [**LogCaptureUserConfiguration**](LogCaptureUserConfiguration) PostDiagnosticsLogcaptureBrowserUser (string userId, LogCaptureUserConfiguration body = null)


Enable log capture for a user or update expiration

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
    public class PostDiagnosticsLogcaptureBrowserUserExample
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
            var userId = userId_example;  // string | The id of the user to enable browser log capture
            var body = new LogCaptureUserConfiguration(); // LogCaptureUserConfiguration |  (optional) 

            try
            { 
                // Enable log capture for a user or update expiration
                LogCaptureUserConfiguration result = apiInstance.PostDiagnosticsLogcaptureBrowserUser(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogCaptureApi.PostDiagnosticsLogcaptureBrowserUser: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| The id of the user to enable browser log capture |  |
| **body** | [**LogCaptureUserConfiguration**](LogCaptureUserConfiguration)|  | [optional]  |

### Return type

[**LogCaptureUserConfiguration**](LogCaptureUserConfiguration)


_PureCloudPlatform.Client.V2 224.1.0_
