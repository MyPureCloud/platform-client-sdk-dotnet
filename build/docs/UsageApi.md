# UsageApi

## PureCloudPlatform.Client.V2.Api.UsageApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetOauthClientUsageQueryResult**](#GetOauthClientUsageQueryResult) | **Get** /api/v2/oauth/clients/{clientId}/usage/query/results/{executionId} | Get the results of a usage query |
| [**GetOauthClientUsageSummary**](#GetOauthClientUsageSummary) | **Get** /api/v2/oauth/clients/{clientId}/usage/summary | Get a summary of OAuth client API usage |
| [**GetUsageQueryExecutionIdResults**](#GetUsageQueryExecutionIdResults) | **Get** /api/v2/usage/query/{executionId}/results | Get the results of a usage query |
| [**GetUsageSimplesearchExecutionIdResults**](#GetUsageSimplesearchExecutionIdResults) | **Get** /api/v2/usage/simplesearch/{executionId}/results | Get the results of a usage search. Number of records to be returned is limited to 20,000 results. |
| [**PostOauthClientUsageQuery**](#PostOauthClientUsageQuery) | **Post** /api/v2/oauth/clients/{clientId}/usage/query | Query for OAuth client API usage |
| [**PostUsageQuery**](#PostUsageQuery) | **Post** /api/v2/usage/query | Query organization API Usage -  |
| [**PostUsageSimplesearch**](#PostUsageSimplesearch) | **Post** /api/v2/usage/simplesearch | Search organization API Usage |



## GetOauthClientUsageQueryResult

> [**ApiUsageQueryResult**](ApiUsageQueryResult) GetOauthClientUsageQueryResult (string executionId, string clientId)


Get the results of a usage query

Requires ANY permissions: 

* oauth:client:view
* usage:client:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOauthClientUsageQueryResultExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsageApi();
            var executionId = executionId_example;  // string | ID of the query execution
            var clientId = clientId_example;  // string | Client ID

            try
            { 
                // Get the results of a usage query
                ApiUsageQueryResult result = apiInstance.GetOauthClientUsageQueryResult(executionId, clientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsageApi.GetOauthClientUsageQueryResult: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **executionId** | **string**| ID of the query execution |  |
| **clientId** | **string**| Client ID |  |

### Return type

[**ApiUsageQueryResult**](ApiUsageQueryResult)


## GetOauthClientUsageSummary

> [**UsageExecutionResult**](UsageExecutionResult) GetOauthClientUsageSummary (string clientId, string days = null)


Get a summary of OAuth client API usage

After calling this method, you will then need to poll for the query results based on the returned execution Id

Requires ANY permissions: 

* oauth:client:view
* usage:client:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOauthClientUsageSummaryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsageApi();
            var clientId = clientId_example;  // string | Client ID
            var days = days_example;  // string | Previous number of days to query (optional)  (default to "7")

            try
            { 
                // Get a summary of OAuth client API usage
                UsageExecutionResult result = apiInstance.GetOauthClientUsageSummary(clientId, days);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsageApi.GetOauthClientUsageSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **clientId** | **string**| Client ID |  |
| **days** | **string**| Previous number of days to query | [optional] [default to "7"] |

### Return type

[**UsageExecutionResult**](UsageExecutionResult)


## GetUsageQueryExecutionIdResults

> [**ApiUsageQueryResult**](ApiUsageQueryResult) GetUsageQueryExecutionIdResults (string executionId)


Get the results of a usage query

Requires ANY permissions: 

* oauth:client:view
* usage:organization:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUsageQueryExecutionIdResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsageApi();
            var executionId = executionId_example;  // string | ID of the query execution

            try
            { 
                // Get the results of a usage query
                ApiUsageQueryResult result = apiInstance.GetUsageQueryExecutionIdResults(executionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsageApi.GetUsageQueryExecutionIdResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **executionId** | **string**| ID of the query execution |  |

### Return type

[**ApiUsageQueryResult**](ApiUsageQueryResult)


## GetUsageSimplesearchExecutionIdResults

> [**ApiUsageQueryResult**](ApiUsageQueryResult) GetUsageSimplesearchExecutionIdResults (string executionId, string after = null, int? pageSize = null)


Get the results of a usage search. Number of records to be returned is limited to 20,000 results.

Requires ANY permissions: 

* oauth:client:view
* usage:simpleSearch:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUsageSimplesearchExecutionIdResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsageApi();
            var executionId = executionId_example;  // string | ID of the search execution
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned (optional) 
            var pageSize = 56;  // int? | The max number of entities to be returned per request. Maximum page size of 1000 (optional) 

            try
            { 
                // Get the results of a usage search. Number of records to be returned is limited to 20,000 results.
                ApiUsageQueryResult result = apiInstance.GetUsageSimplesearchExecutionIdResults(executionId, after, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsageApi.GetUsageSimplesearchExecutionIdResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **executionId** | **string**| ID of the search execution |  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned | [optional]  |
| **pageSize** | **int?**| The max number of entities to be returned per request. Maximum page size of 1000 | [optional]  |

### Return type

[**ApiUsageQueryResult**](ApiUsageQueryResult)


## PostOauthClientUsageQuery

> [**UsageExecutionResult**](UsageExecutionResult) PostOauthClientUsageQuery (string clientId, ApiUsageClientQuery body)


Query for OAuth client API usage

After calling this method, you will then need to poll for the query results based on the returned execution Id

Requires ANY permissions: 

* oauth:client:view
* usage:client:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOauthClientUsageQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsageApi();
            var clientId = clientId_example;  // string | Client ID
            var body = new ApiUsageClientQuery(); // ApiUsageClientQuery | Query

            try
            { 
                // Query for OAuth client API usage
                UsageExecutionResult result = apiInstance.PostOauthClientUsageQuery(clientId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsageApi.PostOauthClientUsageQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **clientId** | **string**| Client ID |  |
| **body** | [**ApiUsageClientQuery**](ApiUsageClientQuery)| Query |  |

### Return type

[**UsageExecutionResult**](UsageExecutionResult)


## PostUsageQuery

> [**UsageExecutionResult**](UsageExecutionResult) PostUsageQuery (ApiUsageOrganizationQuery body)


Query organization API Usage - 

After calling this method, you will then need to poll for the query results based on the returned execution Id

Requires ANY permissions: 

* oauth:client:view
* usage:organization:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUsageQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsageApi();
            var body = new ApiUsageOrganizationQuery(); // ApiUsageOrganizationQuery | Query

            try
            { 
                // Query organization API Usage - 
                UsageExecutionResult result = apiInstance.PostUsageQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsageApi.PostUsageQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ApiUsageOrganizationQuery**](ApiUsageOrganizationQuery)| Query |  |

### Return type

[**UsageExecutionResult**](UsageExecutionResult)


## PostUsageSimplesearch

> [**UsageExecutionResult**](UsageExecutionResult) PostUsageSimplesearch (ApiUsageSimpleSearch body)


Search organization API Usage

After calling this method, you will then need to poll for the query results based on the returned execution Id. The number of records is limited to 20,000 results

Requires ANY permissions: 

* oauth:client:view
* usage:simpleSearch:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUsageSimplesearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsageApi();
            var body = new ApiUsageSimpleSearch(); // ApiUsageSimpleSearch | SimpleSearch

            try
            { 
                // Search organization API Usage
                UsageExecutionResult result = apiInstance.PostUsageSimplesearch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsageApi.PostUsageSimplesearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ApiUsageSimpleSearch**](ApiUsageSimpleSearch)| SimpleSearch |  |

### Return type

[**UsageExecutionResult**](UsageExecutionResult)


_PureCloudPlatform.Client.V2 215.1.0_
