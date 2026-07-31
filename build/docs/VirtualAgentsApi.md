# VirtualAgentsApi

## PureCloudPlatform.Client.V2.Api.VirtualAgentsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteAgenticVirtualagentJobs**](#DeleteAgenticVirtualagentJobs) | **Delete** /api/v2/agentic/virtualagents/{virtualAgentId}/jobs | Start the deletion of a virtualAgent. |
| [**GetAgenticVirtualagent**](#GetAgenticVirtualagent) | **Get** /api/v2/agentic/virtualagents/{virtualAgentId} | Get virtual agent. |
| [**GetAgenticVirtualagentJob**](#GetAgenticVirtualagentJob) | **Get** /api/v2/agentic/virtualagents/{virtualAgentId}/jobs/{jobId} | Get a virtualAgent job. |
| [**GetAgenticVirtualagents**](#GetAgenticVirtualagents) | **Get** /api/v2/agentic/virtualagents | Get all virtual agents. |
| [**PatchAgenticVirtualagent**](#PatchAgenticVirtualagent) | **Patch** /api/v2/agentic/virtualagents/{virtualAgentId} | Update a virtual agent. |
| [**PostAgenticVirtualagentVersionJobs**](#PostAgenticVirtualagentVersionJobs) | **Post** /api/v2/agentic/virtualagents/{virtualAgentId}/versions/{versionId}/jobs | Start the publishing of a virtual agent version. |
| [**PostAgenticVirtualagents**](#PostAgenticVirtualagents) | **Post** /api/v2/agentic/virtualagents | Create a virtual agent. |



## DeleteAgenticVirtualagentJobs

> [**AgenticVirtualAgentJob**](AgenticVirtualAgentJob) DeleteAgenticVirtualagentJobs (string virtualAgentId)


Start the deletion of a virtualAgent.

Requires ALL permissions: 

* agentic:virtualAgentJob:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteAgenticVirtualagentJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VirtualAgentsApi();
            var virtualAgentId = virtualAgentId_example;  // string | Virtual Agent ID

            try
            { 
                // Start the deletion of a virtualAgent.
                AgenticVirtualAgentJob result = apiInstance.DeleteAgenticVirtualagentJobs(virtualAgentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VirtualAgentsApi.DeleteAgenticVirtualagentJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **virtualAgentId** | **string**| Virtual Agent ID |  |

### Return type

[**AgenticVirtualAgentJob**](AgenticVirtualAgentJob)


## GetAgenticVirtualagent

> [**AgenticVirtualAgent**](AgenticVirtualAgent) GetAgenticVirtualagent (string virtualAgentId)


Get virtual agent.

Requires ALL permissions: 

* agentic:virtualAgent:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAgenticVirtualagentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VirtualAgentsApi();
            var virtualAgentId = virtualAgentId_example;  // string | Virtual Agent ID

            try
            { 
                // Get virtual agent.
                AgenticVirtualAgent result = apiInstance.GetAgenticVirtualagent(virtualAgentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VirtualAgentsApi.GetAgenticVirtualagent: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **virtualAgentId** | **string**| Virtual Agent ID |  |

### Return type

[**AgenticVirtualAgent**](AgenticVirtualAgent)


## GetAgenticVirtualagentJob

> [**AgenticVirtualAgentJob**](AgenticVirtualAgentJob) GetAgenticVirtualagentJob (string virtualAgentId, string jobId)


Get a virtualAgent job.

Requires ALL permissions: 

* agentic:virtualAgentJob:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAgenticVirtualagentJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VirtualAgentsApi();
            var virtualAgentId = virtualAgentId_example;  // string | Virtual Agent ID
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get a virtualAgent job.
                AgenticVirtualAgentJob result = apiInstance.GetAgenticVirtualagentJob(virtualAgentId, jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VirtualAgentsApi.GetAgenticVirtualagentJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **virtualAgentId** | **string**| Virtual Agent ID |  |
| **jobId** | **string**| jobId |  |

### Return type

[**AgenticVirtualAgentJob**](AgenticVirtualAgentJob)


## GetAgenticVirtualagents

> [**AgenticVirtualAgentEntityListing**](AgenticVirtualAgentEntityListing) GetAgenticVirtualagents (string name = null, string nameContains = null, string status = null, string sortBy = null, string sortOrder = null, int? pageNumber = null, int? pageSize = null)


Get all virtual agents.

Requires ALL permissions: 

* agentic:virtualAgent:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAgenticVirtualagentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VirtualAgentsApi();
            var name = name_example;  // string | Filter by matching name - case insensitive. (optional) 
            var nameContains = nameContains_example;  // string | Filter by name contains - case insensitive. (optional) 
            var status = status_example;  // string | Filter by status. (optional) 
            var sortBy = sortBy_example;  // string | Sort by. Default value dateModified. (optional)  (default to dateModified)
            var sortOrder = sortOrder_example;  // string | Sort Order. Default value desc. (optional)  (default to desc)
            var pageNumber = 56;  // int? | Page number. (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size. The maximum page size is 100. (optional)  (default to 25)

            try
            { 
                // Get all virtual agents.
                AgenticVirtualAgentEntityListing result = apiInstance.GetAgenticVirtualagents(name, nameContains, status, sortBy, sortOrder, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VirtualAgentsApi.GetAgenticVirtualagents: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **name** | **string**| Filter by matching name - case insensitive. | [optional]  |
| **nameContains** | **string**| Filter by name contains - case insensitive. | [optional]  |
| **status** | **string**| Filter by status. | [optional] <br />**Values**: Draft, Published |
| **sortBy** | **string**| Sort by. Default value dateModified. | [optional] [default to dateModified]<br />**Values**: dateModified, name, status |
| **sortOrder** | **string**| Sort Order. Default value desc. | [optional] [default to desc]<br />**Values**: asc, desc |
| **pageNumber** | **int?**| Page number. | [optional] [default to 1] |
| **pageSize** | **int?**| Page size. The maximum page size is 100. | [optional] [default to 25] |

### Return type

[**AgenticVirtualAgentEntityListing**](AgenticVirtualAgentEntityListing)


## PatchAgenticVirtualagent

> [**AgenticVirtualAgent**](AgenticVirtualAgent) PatchAgenticVirtualagent (string virtualAgentId, UpdateAgenticVirtualAgent body)


Update a virtual agent.

Requires ALL permissions: 

* agentic:virtualAgent:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchAgenticVirtualagentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VirtualAgentsApi();
            var virtualAgentId = virtualAgentId_example;  // string | Virtual Agent ID
            var body = new UpdateAgenticVirtualAgent(); // UpdateAgenticVirtualAgent | 

            try
            { 
                // Update a virtual agent.
                AgenticVirtualAgent result = apiInstance.PatchAgenticVirtualagent(virtualAgentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VirtualAgentsApi.PatchAgenticVirtualagent: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **virtualAgentId** | **string**| Virtual Agent ID |  |
| **body** | [**UpdateAgenticVirtualAgent**](UpdateAgenticVirtualAgent)|  |  |

### Return type

[**AgenticVirtualAgent**](AgenticVirtualAgent)


## PostAgenticVirtualagentVersionJobs

> [**AgenticVirtualAgentVersionPublishJob**](AgenticVirtualAgentVersionPublishJob) PostAgenticVirtualagentVersionJobs (string virtualAgentId, string versionId, AgenticVirtualAgentVersionPublishJobRequest body)


Start the publishing of a virtual agent version.

Requires ALL permissions: 

* agentic:virtualAgentVersionJob:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAgenticVirtualagentVersionJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VirtualAgentsApi();
            var virtualAgentId = virtualAgentId_example;  // string | Virtual Agent ID
            var versionId = versionId_example;  // string | Version ID
            var body = new AgenticVirtualAgentVersionPublishJobRequest(); // AgenticVirtualAgentVersionPublishJobRequest | 

            try
            { 
                // Start the publishing of a virtual agent version.
                AgenticVirtualAgentVersionPublishJob result = apiInstance.PostAgenticVirtualagentVersionJobs(virtualAgentId, versionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VirtualAgentsApi.PostAgenticVirtualagentVersionJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **virtualAgentId** | **string**| Virtual Agent ID |  |
| **versionId** | **string**| Version ID |  |
| **body** | [**AgenticVirtualAgentVersionPublishJobRequest**](AgenticVirtualAgentVersionPublishJobRequest)|  |  |

### Return type

[**AgenticVirtualAgentVersionPublishJob**](AgenticVirtualAgentVersionPublishJob)


## PostAgenticVirtualagents

> [**AgenticVirtualAgent**](AgenticVirtualAgent) PostAgenticVirtualagents (CreateAgenticVirtualAgent body)


Create a virtual agent.

Requires ALL permissions: 

* agentic:virtualAgent:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAgenticVirtualagentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VirtualAgentsApi();
            var body = new CreateAgenticVirtualAgent(); // CreateAgenticVirtualAgent | 

            try
            { 
                // Create a virtual agent.
                AgenticVirtualAgent result = apiInstance.PostAgenticVirtualagents(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VirtualAgentsApi.PostAgenticVirtualagents: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateAgenticVirtualAgent**](CreateAgenticVirtualAgent)|  |  |

### Return type

[**AgenticVirtualAgent**](AgenticVirtualAgent)


_PureCloudPlatform.Client.V2 269.0.0_
