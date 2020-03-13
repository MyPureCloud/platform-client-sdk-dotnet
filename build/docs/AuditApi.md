---
title: AuditApi
---
## PureCloudPlatform.Client.V2.Api.AuditApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetAuditsQueryTransactionId**](AuditApi.html#getauditsquerytransactionid) | **GET** /api/v2/audits/query/{transactionId} | Get status of audit query execution |
| [**GetAuditsQueryTransactionIdResults**](AuditApi.html#getauditsquerytransactionidresults) | **GET** /api/v2/audits/query/{transactionId}/results | Get results of audit query |
| [**PostAuditsQuery**](AuditApi.html#postauditsquery) | **POST** /api/v2/audits/query | Create audit query execution |
{: class="table table-striped"}

<a name="getauditsquerytransactionid"></a>

## [**AuditQueryExecutionStatusResponse**](AuditQueryExecutionStatusResponse.html) GetAuditsQueryTransactionId (string transactionId)



Get status of audit query execution



Requires ANY permissions: 

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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
{: class="table table-striped"}

### Return type

[**AuditQueryExecutionStatusResponse**](AuditQueryExecutionStatusResponse.html)

<a name="getauditsquerytransactionidresults"></a>

## [**AuditQueryExecutionResultsResponse**](AuditQueryExecutionResultsResponse.html) GetAuditsQueryTransactionIdResults (string transactionId, string cursor = null, int? pageSize = null, List<string> expand = null)



Get results of audit query



Requires ANY permissions: 

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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuditApi();
            var transactionId = transactionId_example;  // string | Transaction ID
            var cursor = cursor_example;  // string | Indicates where to resume query results (not required for first page) (optional) 
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            { 
                // Get results of audit query
                AuditQueryExecutionResultsResponse result = apiInstance.GetAuditsQueryTransactionIdResults(transactionId, cursor, pageSize, expand);
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
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: user |
{: class="table table-striped"}

### Return type

[**AuditQueryExecutionResultsResponse**](AuditQueryExecutionResultsResponse.html)

<a name="postauditsquery"></a>

## [**AuditQueryExecutionStatusResponse**](AuditQueryExecutionStatusResponse.html) PostAuditsQuery (AuditQueryRequest body)



Create audit query execution



Requires ANY permissions: 

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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
| **body** | [**AuditQueryRequest**](AuditQueryRequest.html)| query |  |
{: class="table table-striped"}

### Return type

[**AuditQueryExecutionStatusResponse**](AuditQueryExecutionStatusResponse.html)

