# AuditApi

## PureCloudPlatform.Client.V2.Api.AuditApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetAuditsQueryRealtimeServicemapping**](#GetAuditsQueryRealtimeServicemapping) | **Get** /api/v2/audits/query/realtime/servicemapping | Get service mapping information used in realtime audits. |
| [**GetAuditsQueryServicemapping**](#GetAuditsQueryServicemapping) | **Get** /api/v2/audits/query/servicemapping | Get service mapping information used in audits. |
| [**GetAuditsQueryTransactionId**](#GetAuditsQueryTransactionId) | **Get** /api/v2/audits/query/{transactionId} | Get status of audit query execution |
| [**GetAuditsQueryTransactionIdResults**](#GetAuditsQueryTransactionIdResults) | **Get** /api/v2/audits/query/{transactionId}/results | Get results of audit query |
| [**PostAuditsQuery**](#PostAuditsQuery) | **Post** /api/v2/audits/query | Create audit query execution |
| [**PostAuditsQueryRealtime**](#PostAuditsQueryRealtime) | **Post** /api/v2/audits/query/realtime | This endpoint will only retrieve 14 days worth of audits for certain services. Please use /query to get a full list and older audits. |
| [**PostAuditsQueryRealtimeRelated**](#PostAuditsQueryRealtimeRelated) | **Post** /api/v2/audits/query/realtime/related | Often a single action results in multiple audits. The endpoint retrieves all audits created by the same action as the given audit id. |



## GetAuditsQueryRealtimeServicemapping

> [**AuditQueryServiceMapping**](AuditQueryServiceMapping) GetAuditsQueryRealtimeServicemapping ()


Get service mapping information used in realtime audits.

Requires ALL permissions: 

* audits:audit:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAuditsQueryRealtimeServicemappingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuditApi();

            try
            { 
                // Get service mapping information used in realtime audits.
                AuditQueryServiceMapping result = apiInstance.GetAuditsQueryRealtimeServicemapping();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuditApi.GetAuditsQueryRealtimeServicemapping: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**AuditQueryServiceMapping**](AuditQueryServiceMapping)


## GetAuditsQueryServicemapping

> [**AuditQueryServiceMapping**](AuditQueryServiceMapping) GetAuditsQueryServicemapping ()


Get service mapping information used in audits.

Requires ALL permissions: 

* audits:audit:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAuditsQueryServicemappingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuditApi();

            try
            { 
                // Get service mapping information used in audits.
                AuditQueryServiceMapping result = apiInstance.GetAuditsQueryServicemapping();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuditApi.GetAuditsQueryServicemapping: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**AuditQueryServiceMapping**](AuditQueryServiceMapping)


## GetAuditsQueryTransactionId

> [**AuditQueryExecutionStatusResponse**](AuditQueryExecutionStatusResponse) GetAuditsQueryTransactionId (string transactionId)


Get status of audit query execution

Requires ALL permissions: 

* audits:audit:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAuditsQueryTransactionIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuditApi();
            var transactionId = transactionId_example;  // string | Transaction ID

            try
            { 
                // Get status of audit query execution
                AuditQueryExecutionStatusResponse result = apiInstance.GetAuditsQueryTransactionId(transactionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuditApi.GetAuditsQueryTransactionId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **transactionId** | **string**| Transaction ID |  |

### Return type

[**AuditQueryExecutionStatusResponse**](AuditQueryExecutionStatusResponse)


## GetAuditsQueryTransactionIdResults

> [**AuditQueryExecutionResultsResponse**](AuditQueryExecutionResultsResponse) GetAuditsQueryTransactionIdResults (string transactionId, string cursor = null, int? pageSize = null, List<string> expand = null, bool? allowRedirect = null)


Get results of audit query

Requires ALL permissions: 

* audits:audit:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAuditsQueryTransactionIdResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuditApi();
            var transactionId = transactionId_example;  // string | Transaction ID
            var cursor = cursor_example;  // string | Indicates where to resume query results (not required for first page) (optional) 
            var pageSize = 56;  // int? | Indicates maximum number of results in response. Default page size is 25 results. The maximum page size is 500. (optional)  (default to 25)
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 
            var allowRedirect = true;  // bool? | Result sets with large amounts of data will respond with a download url (optional) 

            try
            { 
                // Get results of audit query
                AuditQueryExecutionResultsResponse result = apiInstance.GetAuditsQueryTransactionIdResults(transactionId, cursor, pageSize, expand, allowRedirect);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuditApi.GetAuditsQueryTransactionIdResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **transactionId** | **string**| Transaction ID |  |
| **cursor** | **string**| Indicates where to resume query results (not required for first page) | [optional]  |
| **pageSize** | **int?**| Indicates maximum number of results in response. Default page size is 25 results. The maximum page size is 500. | [optional] [default to 25] |
| **expand** | [**List<string>**](string)| Which fields, if any, to expand | [optional] <br />**Values**: user |
| **allowRedirect** | **bool?**| Result sets with large amounts of data will respond with a download url | [optional]  |

### Return type

[**AuditQueryExecutionResultsResponse**](AuditQueryExecutionResultsResponse)


## PostAuditsQuery

> [**AuditQueryExecutionStatusResponse**](AuditQueryExecutionStatusResponse) PostAuditsQuery (AuditQueryRequest body)


Create audit query execution

Use /api/v2/audits/query/servicemapping endpoint for a list of valid values

Requires ALL permissions: 

* audits:audit:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAuditsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuditApi();
            var body = new AuditQueryRequest(); // AuditQueryRequest | query

            try
            { 
                // Create audit query execution
                AuditQueryExecutionStatusResponse result = apiInstance.PostAuditsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuditApi.PostAuditsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AuditQueryRequest**](AuditQueryRequest)| query |  |

### Return type

[**AuditQueryExecutionStatusResponse**](AuditQueryExecutionStatusResponse)


## PostAuditsQueryRealtime

> [**AuditRealtimeQueryResultsResponse**](AuditRealtimeQueryResultsResponse) PostAuditsQueryRealtime (AuditRealtimeQueryRequest body, List<string> expand = null)


This endpoint will only retrieve 14 days worth of audits for certain services. Please use /query to get a full list and older audits.

Use /api/v2/audits/query/realtime/servicemapping endpoint for a list of valid values

Requires ALL permissions: 

* audits:audit:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAuditsQueryRealtimeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuditApi();
            var body = new AuditRealtimeQueryRequest(); // AuditRealtimeQueryRequest | query
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            { 
                // This endpoint will only retrieve 14 days worth of audits for certain services. Please use /query to get a full list and older audits.
                AuditRealtimeQueryResultsResponse result = apiInstance.PostAuditsQueryRealtime(body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuditApi.PostAuditsQueryRealtime: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AuditRealtimeQueryRequest**](AuditRealtimeQueryRequest)| query |  |
| **expand** | [**List<string>**](string)| Which fields, if any, to expand | [optional] <br />**Values**: user |

### Return type

[**AuditRealtimeQueryResultsResponse**](AuditRealtimeQueryResultsResponse)


## PostAuditsQueryRealtimeRelated

> [**AuditRealtimeRelatedResultsResponse**](AuditRealtimeRelatedResultsResponse) PostAuditsQueryRealtimeRelated (AuditRealtimeRelatedRequest body, List<string> expand = null)


Often a single action results in multiple audits. The endpoint retrieves all audits created by the same action as the given audit id.

Requires ALL permissions: 

* audits:audit:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAuditsQueryRealtimeRelatedExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AuditApi();
            var body = new AuditRealtimeRelatedRequest(); // AuditRealtimeRelatedRequest | query
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            { 
                // Often a single action results in multiple audits. The endpoint retrieves all audits created by the same action as the given audit id.
                AuditRealtimeRelatedResultsResponse result = apiInstance.PostAuditsQueryRealtimeRelated(body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuditApi.PostAuditsQueryRealtimeRelated: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AuditRealtimeRelatedRequest**](AuditRealtimeRelatedRequest)| query |  |
| **expand** | [**List<string>**](string)| Which fields, if any, to expand | [optional] <br />**Values**: user |

### Return type

[**AuditRealtimeRelatedResultsResponse**](AuditRealtimeRelatedResultsResponse)


_PureCloudPlatform.Client.V2 257.0.0_
