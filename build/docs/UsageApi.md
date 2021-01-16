---
title: UsageApi
---
## PureCloudPlatform.Client.V2.Api.UsageApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetUsageQueryExecutionIdResults**](UsageApi.html#getusagequeryexecutionidresults) | **GET** /api/v2/usage/query/{executionId}/results | Get the results of a usage query |
| [**PostUsageQuery**](UsageApi.html#postusagequery) | **POST** /api/v2/usage/query | Query organization API Usage -  |
{: class="table table-striped"}

<a name="getusagequeryexecutionidresults"></a>

## [**ApiUsageQueryResult**](ApiUsageQueryResult.html) GetUsageQueryExecutionIdResults (string executionId)



Get the results of a usage query



Requires ANY permissions: 

* oauth:client:view

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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
{: class="table table-striped"}

### Return type

[**ApiUsageQueryResult**](ApiUsageQueryResult.html)

<a name="postusagequery"></a>

## [**UsageExecutionResult**](UsageExecutionResult.html) PostUsageQuery (ApiUsageQuery body)



Query organization API Usage - 

After calling this method, you will then need to poll for the query results based on the returned execution Id

Requires ANY permissions: 

* oauth:client:view

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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsageApi();
            var body = new ApiUsageQuery(); // ApiUsageQuery | Query

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
| **body** | [**ApiUsageQuery**](ApiUsageQuery.html)| Query |  |
{: class="table table-striped"}

### Return type

[**UsageExecutionResult**](UsageExecutionResult.html)

