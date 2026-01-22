# InfrastructureAsCodeApi

## PureCloudPlatform.Client.V2.Api.InfrastructureAsCodeApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetInfrastructureascodeAccelerator**](#GetInfrastructureascodeAccelerator) | **Get** /api/v2/infrastructureascode/accelerators/{acceleratorId} | Get information about an accelerator |
| [**GetInfrastructureascodeAccelerators**](#GetInfrastructureascodeAccelerators) | **Get** /api/v2/infrastructureascode/accelerators | Get a list of available accelerators |
| [**GetInfrastructureascodeJob**](#GetInfrastructureascodeJob) | **Get** /api/v2/infrastructureascode/jobs/{jobId} | Get job status and results |
| [**GetInfrastructureascodeJobs**](#GetInfrastructureascodeJobs) | **Get** /api/v2/infrastructureascode/jobs | Get job history |
| [**PostInfrastructureascodeJobs**](#PostInfrastructureascodeJobs) | **Post** /api/v2/infrastructureascode/jobs | Create a Job |



## GetInfrastructureascodeAccelerator

> [**AcceleratorSpecification**](AcceleratorSpecification) GetInfrastructureascodeAccelerator (string acceleratorId, string preferredLanguage = null)


Get information about an accelerator

Get the complete metadata specification for an accelerator, including requirements and parameters.

Requires ANY permissions: 

* infrastructureascode:accelerator:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetInfrastructureascodeAcceleratorExample
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
            var acceleratorId = acceleratorId_example;  // string | Accelerator ID
            var preferredLanguage = preferredLanguage_example;  // string | Preferred Language (optional)  (default to en-US)

            try
            { 
                // Get information about an accelerator
                AcceleratorSpecification result = apiInstance.GetInfrastructureascodeAccelerator(acceleratorId, preferredLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InfrastructureAsCodeApi.GetInfrastructureascodeAccelerator: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **acceleratorId** | **string**| Accelerator ID |  |
| **preferredLanguage** | **string**| Preferred Language | [optional] [default to en-US]<br />**Values**: ar, cs, da, de, en-US, es, fi, fr, it, iw, ko, ja, nl, no, pl, pt-BR, pt-PT, sv, th, tr, zh-CN, zh-TW |

### Return type

[**AcceleratorSpecification**](AcceleratorSpecification)


## GetInfrastructureascodeAccelerators

> [**AcceleratorList**](AcceleratorList) GetInfrastructureascodeAccelerators (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string origin = null, string type = null, string classification = null, string tags = null)


Get a list of available accelerators

Search for accelerators that can be run.

Requires ANY permissions: 

* infrastructureascode:accelerator:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetInfrastructureascodeAcceleratorsExample
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
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to asc)
            var name = name_example;  // string | Filter by name (optional) 
            var description = description_example;  // string | Filter by description (optional) 
            var origin = origin_example;  // string | Filter by origin (optional) 
            var type = type_example;  // string | Filter by type (optional) 
            var classification = classification_example;  // string | Filter by classification (optional) 
            var tags = tags_example;  // string | Filter by tags (optional) 

            try
            { 
                // Get a list of available accelerators
                AcceleratorList result = apiInstance.GetInfrastructureascodeAccelerators(pageSize, pageNumber, sortBy, sortOrder, name, description, origin, type, classification, tags);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InfrastructureAsCodeApi.GetInfrastructureascodeAccelerators: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to asc]<br />**Values**: asc, desc |
| **name** | **string**| Filter by name | [optional]  |
| **description** | **string**| Filter by description | [optional]  |
| **origin** | **string**| Filter by origin | [optional] <br />**Values**: community, partner, genesys |
| **type** | **string**| Filter by type | [optional] <br />**Values**: module, accelerator, blueprint |
| **classification** | **string**| Filter by classification | [optional]  |
| **tags** | **string**| Filter by tags | [optional]  |

### Return type

[**AcceleratorList**](AcceleratorList)


## GetInfrastructureascodeJob

> [**InfrastructureascodeJob**](InfrastructureascodeJob) GetInfrastructureascodeJob (string jobId, bool? details = null)


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

### Return type

[**InfrastructureascodeJob**](InfrastructureascodeJob)


## GetInfrastructureascodeJobs

> [**InfrastructureascodeJob**](InfrastructureascodeJob) GetInfrastructureascodeJobs (int? maxResults = null, bool? includeErrors = null, string sortBy = null, string sortOrder = null, string acceleratorId = null, string submittedBy = null, string status = null)


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
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to dateSubmitted)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to desc)
            var acceleratorId = acceleratorId_example;  // string | Find only jobs associated with this accelerator (optional) 
            var submittedBy = submittedBy_example;  // string | Find only jobs submitted by this user (optional) 
            var status = status_example;  // string | Find only jobs in this state (optional) 

            try
            { 
                // Get job history
                InfrastructureascodeJob result = apiInstance.GetInfrastructureascodeJobs(maxResults, includeErrors, sortBy, sortOrder, acceleratorId, submittedBy, status);
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
| **sortBy** | **string**| Sort by | [optional] [default to dateSubmitted]<br />**Values**: id, dateSubmitted, submittedBy, acceleratorId, status |
| **sortOrder** | **string**| Sort order | [optional] [default to desc]<br />**Values**: asc, desc |
| **acceleratorId** | **string**| Find only jobs associated with this accelerator | [optional]  |
| **submittedBy** | **string**| Find only jobs submitted by this user | [optional]  |
| **status** | **string**| Find only jobs in this state | [optional] <br />**Values**: Created, Queued, Running, Complete, Failed, Incomplete |

### Return type

[**InfrastructureascodeJob**](InfrastructureascodeJob)


## PostInfrastructureascodeJobs

> [**InfrastructureascodeJob**](InfrastructureascodeJob) PostInfrastructureascodeJobs (AcceleratorInput body)


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
| **body** | [**AcceleratorInput**](AcceleratorInput)|  |  |

### Return type

[**InfrastructureascodeJob**](InfrastructureascodeJob)


_PureCloudPlatform.Client.V2 255.0.0_
