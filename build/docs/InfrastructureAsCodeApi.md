---
title: InfrastructureAsCodeApi
---
## PureCloudPlatform.Client.V2.Api.InfrastructureAsCodeApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetInfrastructureascodeJob**](InfrastructureAsCodeApi.html#getinfrastructureascodejob) | **GET** /api/v2/infrastructureascode/jobs/{jobId} | Get job status and results |
| [**GetInfrastructureascodeJobs**](InfrastructureAsCodeApi.html#getinfrastructureascodejobs) | **GET** /api/v2/infrastructureascode/jobs | Get job history |
| [**PostInfrastructureascodeJobs**](InfrastructureAsCodeApi.html#postinfrastructureascodejobs) | **POST** /api/v2/infrastructureascode/jobs | Create a Job |
{: class="table table-striped"}

<a name="getinfrastructureascodejob"></a>

## [**InfrastructureascodeJob**](InfrastructureascodeJob.html) GetInfrastructureascodeJob (string jobId, bool? details = null)



Get job status and results

Get the execution status of a submitted job, optionally including results and error details.



Requires ALL permissions: 

* infrastructureascode:job:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetInfrastructureascodeJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new InfrastructureAsCodeApi();
            var jobId = jobId_example;  // string | Job ID
            var details = true;  // bool? | Include details of execution, including job results or error information (optional)  (default to false)

            try
            { 
                // Get job status and results
                InfrastructureascodeJob result = apiInstance.GetInfrastructureascodeJob(jobId, details);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InfrastructureAsCodeApi.GetInfrastructureascodeJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| Job ID |  |
| **details** | **bool?**| Include details of execution, including job results or error information | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**InfrastructureascodeJob**](InfrastructureascodeJob.html)

<a name="getinfrastructureascodejobs"></a>

## [**InfrastructureascodeJob**](InfrastructureascodeJob.html) GetInfrastructureascodeJobs (int? maxResults = null, bool? includeErrors = null, string sortBy = null, string sortOrder = null)



Get job history

Get a history of submitted jobs, optionally including error messages.



Requires ANY permissions: 

* infrastructureascode:job:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetInfrastructureascodeJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new InfrastructureAsCodeApi();
            var maxResults = 56;  // int? | Number of jobs to show (optional)  (default to 1)
            var includeErrors = true;  // bool? | Include error messages (optional)  (default to false)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to id)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to asc)

            try
            { 
                // Get job history
                InfrastructureascodeJob result = apiInstance.GetInfrastructureascodeJobs(maxResults, includeErrors, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InfrastructureAsCodeApi.GetInfrastructureascodeJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **maxResults** | **int?**| Number of jobs to show | [optional] [default to 1] |
| **includeErrors** | **bool?**| Include error messages | [optional] [default to false] |
| **sortBy** | **string**| Sort by | [optional] [default to id]<br />**Values**: id, dateSubmitted, submittedBy, status |
| **sortOrder** | **string**| Sort order | [optional] [default to asc]<br />**Values**: asc, desc |
{: class="table table-striped"}

### Return type

[**InfrastructureascodeJob**](InfrastructureascodeJob.html)

<a name="postinfrastructureascodejobs"></a>

## [**InfrastructureascodeJob**](InfrastructureascodeJob.html) PostInfrastructureascodeJobs (AcceleratorInput body)



Create a Job

Create and submit a job for remote execution or see job planning results.



Requires ANY permissions: 

* infrastructureascode:job:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostInfrastructureascodeJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new InfrastructureAsCodeApi();
            var body = new AcceleratorInput(); // AcceleratorInput | 

            try
            { 
                // Create a Job
                InfrastructureascodeJob result = apiInstance.PostInfrastructureascodeJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InfrastructureAsCodeApi.PostInfrastructureascodeJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AcceleratorInput**](AcceleratorInput.html)|  |  |
{: class="table table-striped"}

### Return type

[**InfrastructureascodeJob**](InfrastructureascodeJob.html)

