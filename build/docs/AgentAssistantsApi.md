---
title: AgentAssistantsApi
---
## PureCloudPlatform.Client.V2.Api.AgentAssistantsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteAssistant**](AgentAssistantsApi.html#deleteassistant) | **Delete** /api/v2/assistants/{assistantId} | Delete an assistant. |
| [**DeleteAssistantQueue**](AgentAssistantsApi.html#deleteassistantqueue) | **Delete** /api/v2/assistants/{assistantId}/queues/{queueId} | Disassociate a queue from an assistant. |
| [**DeleteAssistantQueues**](AgentAssistantsApi.html#deleteassistantqueues) | **Delete** /api/v2/assistants/{assistantId}/queues | Disassociate the queues from an assistant for the given assistant ID and queue IDs. |
| [**GetAssistant**](AgentAssistantsApi.html#getassistant) | **Get** /api/v2/assistants/{assistantId} | Get an assistant. |
| [**GetAssistantQueue**](AgentAssistantsApi.html#getassistantqueue) | **Get** /api/v2/assistants/{assistantId}/queues/{queueId} | Get queue Information for an assistant. |
| [**GetAssistantQueues**](AgentAssistantsApi.html#getassistantqueues) | **Get** /api/v2/assistants/{assistantId}/queues | Get all the queues associated with an assistant. |
| [**GetAssistants**](AgentAssistantsApi.html#getassistants) | **Get** /api/v2/assistants | Get all assistants. |
| [**GetAssistantsQueues**](AgentAssistantsApi.html#getassistantsqueues) | **Get** /api/v2/assistants/queues | Get all queues assigned to any assistant. |
| [**PatchAssistant**](AgentAssistantsApi.html#patchassistant) | **Patch** /api/v2/assistants/{assistantId} | Update an assistant. |
| [**PatchAssistantQueues**](AgentAssistantsApi.html#patchassistantqueues) | **Patch** /api/v2/assistants/{assistantId}/queues | Update Queues for an Assistant. |
| [**PostAssistants**](AgentAssistantsApi.html#postassistants) | **Post** /api/v2/assistants | Create an Assistant. |
| [**PutAssistantQueue**](AgentAssistantsApi.html#putassistantqueue) | **Put** /api/v2/assistants/{assistantId}/queues/{queueId} | Create a queue assistant association. |
{: class="table table-striped"}

<a name="deleteassistant"></a>

## void DeleteAssistant (string assistantId)



Delete an assistant.

Requires ALL permissions: 

* assistants:assistant:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteAssistantExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AgentAssistantsApi();
            var assistantId = assistantId_example;  // string | Assistant ID

            try
            { 
                // Delete an assistant.
                apiInstance.DeleteAssistant(assistantId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentAssistantsApi.DeleteAssistant: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **assistantId** | **string**| Assistant ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteassistantqueue"></a>

## void DeleteAssistantQueue (string assistantId, string queueId)



Disassociate a queue from an assistant.

Requires ALL permissions: 

* assistants:queue:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteAssistantQueueExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AgentAssistantsApi();
            var assistantId = assistantId_example;  // string | Assistant ID
            var queueId = queueId_example;  // string | Queue ID

            try
            { 
                // Disassociate a queue from an assistant.
                apiInstance.DeleteAssistantQueue(assistantId, queueId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentAssistantsApi.DeleteAssistantQueue: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **assistantId** | **string**| Assistant ID |  |
| **queueId** | **string**| Queue ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteassistantqueues"></a>

## void DeleteAssistantQueues (string assistantId, string queueIds = null)



Disassociate the queues from an assistant for the given assistant ID and queue IDs.

Requires ALL permissions: 

* assistants:queue:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteAssistantQueuesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AgentAssistantsApi();
            var assistantId = assistantId_example;  // string | Assistant ID
            var queueIds = queueIds_example;  // string | Comma-separated identifiers of the queues that need to be deleted. (optional) 

            try
            { 
                // Disassociate the queues from an assistant for the given assistant ID and queue IDs.
                apiInstance.DeleteAssistantQueues(assistantId, queueIds);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentAssistantsApi.DeleteAssistantQueues: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **assistantId** | **string**| Assistant ID |  |
| **queueIds** | **string**| Comma-separated identifiers of the queues that need to be deleted. | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getassistant"></a>

## [**Assistant**](Assistant.html) GetAssistant (string assistantId, string expand = null)



Get an assistant.

Requires ALL permissions: 

* assistants:assistant:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAssistantExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AgentAssistantsApi();
            var assistantId = assistantId_example;  // string | Assistant ID
            var expand = expand_example;  // string | Which fields, if any, to expand. (optional) 

            try
            { 
                // Get an assistant.
                Assistant result = apiInstance.GetAssistant(assistantId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentAssistantsApi.GetAssistant: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **assistantId** | **string**| Assistant ID |  |
| **expand** | **string**| Which fields, if any, to expand. | [optional] <br />**Values**: copilot |
{: class="table table-striped"}

### Return type

[**Assistant**](Assistant.html)

<a name="getassistantqueue"></a>

## [**AssistantQueue**](AssistantQueue.html) GetAssistantQueue (string assistantId, string queueId, string expand = null)



Get queue Information for an assistant.

Requires ALL permissions: 

* assistants:queue:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAssistantQueueExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AgentAssistantsApi();
            var assistantId = assistantId_example;  // string | Assistant ID
            var queueId = queueId_example;  // string | Queue ID
            var expand = expand_example;  // string | Which fields, if any, to expand. (optional) 

            try
            { 
                // Get queue Information for an assistant.
                AssistantQueue result = apiInstance.GetAssistantQueue(assistantId, queueId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentAssistantsApi.GetAssistantQueue: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **assistantId** | **string**| Assistant ID |  |
| **queueId** | **string**| Queue ID |  |
| **expand** | **string**| Which fields, if any, to expand. | [optional] <br />**Values**: assistant |
{: class="table table-striped"}

### Return type

[**AssistantQueue**](AssistantQueue.html)

<a name="getassistantqueues"></a>

## [**AssistantQueueListing**](AssistantQueueListing.html) GetAssistantQueues (string assistantId, string before = null, string after = null, string pageSize = null, string expand = null)



Get all the queues associated with an assistant.

Requires ALL permissions: 

* assistants:queue:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAssistantQueuesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AgentAssistantsApi();
            var assistantId = assistantId_example;  // string | Assistant ID
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var expand = expand_example;  // string | Which fields, if any, to expand. (optional) 

            try
            { 
                // Get all the queues associated with an assistant.
                AssistantQueueListing result = apiInstance.GetAssistantQueues(assistantId, before, after, pageSize, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentAssistantsApi.GetAssistantQueues: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **assistantId** | **string**| Assistant ID |  |
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **expand** | **string**| Which fields, if any, to expand. | [optional] <br />**Values**: assistant |
{: class="table table-striped"}

### Return type

[**AssistantQueueListing**](AssistantQueueListing.html)

<a name="getassistants"></a>

## [**AssistantListing**](AssistantListing.html) GetAssistants (string before = null, string after = null, string limit = null, string pageSize = null, string name = null)



Get all assistants.

Requires ALL permissions: 

* assistants:assistant:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAssistantsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AgentAssistantsApi();
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var limit = limit_example;  // string | Number of entities to return. Maximum of 200. Deprecated in favour of pageSize (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var name = name_example;  // string | Return the assistant by the given name. (optional) 

            try
            { 
                // Get all assistants.
                AssistantListing result = apiInstance.GetAssistants(before, after, limit, pageSize, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentAssistantsApi.GetAssistants: " + e.Message );
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
| **limit** | **string**| Number of entities to return. Maximum of 200. Deprecated in favour of pageSize | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **name** | **string**| Return the assistant by the given name. | [optional]  |
{: class="table table-striped"}

### Return type

[**AssistantListing**](AssistantListing.html)

<a name="getassistantsqueues"></a>

## [**AssistantQueueListing**](AssistantQueueListing.html) GetAssistantsQueues (string before = null, string after = null, string pageSize = null, string queueIds = null, string expand = null)



Get all queues assigned to any assistant.

Requires ALL permissions: 

* assistants:queue:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAssistantsQueuesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AgentAssistantsApi();
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var queueIds = queueIds_example;  // string | Comma-separated identifiers of the queues that need to be retrieved. (optional) 
            var expand = expand_example;  // string | Which fields, if any, to expand. (optional) 

            try
            { 
                // Get all queues assigned to any assistant.
                AssistantQueueListing result = apiInstance.GetAssistantsQueues(before, after, pageSize, queueIds, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentAssistantsApi.GetAssistantsQueues: " + e.Message );
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
| **queueIds** | **string**| Comma-separated identifiers of the queues that need to be retrieved. | [optional]  |
| **expand** | **string**| Which fields, if any, to expand. | [optional] <br />**Values**: assistant |
{: class="table table-striped"}

### Return type

[**AssistantQueueListing**](AssistantQueueListing.html)

<a name="patchassistant"></a>

## [**Assistant**](Assistant.html) PatchAssistant (string assistantId, Assistant body)



Update an assistant.

Requires ALL permissions: 

* assistants:assistant:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchAssistantExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AgentAssistantsApi();
            var assistantId = assistantId_example;  // string | Assistant ID
            var body = new Assistant(); // Assistant | 

            try
            { 
                // Update an assistant.
                Assistant result = apiInstance.PatchAssistant(assistantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentAssistantsApi.PatchAssistant: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **assistantId** | **string**| Assistant ID |  |
| **body** | [**Assistant**](Assistant.html)|  |  |
{: class="table table-striped"}

### Return type

[**Assistant**](Assistant.html)

<a name="patchassistantqueues"></a>

## [**AssistantQueueListing**](AssistantQueueListing.html) PatchAssistantQueues (string assistantId, List<AssistantQueue> body)



Update Queues for an Assistant.

Requires ALL permissions: 

* assistants:queue:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchAssistantQueuesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AgentAssistantsApi();
            var assistantId = assistantId_example;  // string | Assistant ID
            var body = new List<AssistantQueue>(); // List<AssistantQueue> | 

            try
            { 
                // Update Queues for an Assistant.
                AssistantQueueListing result = apiInstance.PatchAssistantQueues(assistantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentAssistantsApi.PatchAssistantQueues: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **assistantId** | **string**| Assistant ID |  |
| **body** | [**List<AssistantQueue>**](AssistantQueue.html)|  |  |
{: class="table table-striped"}

### Return type

[**AssistantQueueListing**](AssistantQueueListing.html)

<a name="postassistants"></a>

## [**Assistant**](Assistant.html) PostAssistants (Assistant body)



Create an Assistant.

Requires ALL permissions: 

* assistants:assistant:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAssistantsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AgentAssistantsApi();
            var body = new Assistant(); // Assistant | 

            try
            { 
                // Create an Assistant.
                Assistant result = apiInstance.PostAssistants(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentAssistantsApi.PostAssistants: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Assistant**](Assistant.html)|  |  |
{: class="table table-striped"}

### Return type

[**Assistant**](Assistant.html)

<a name="putassistantqueue"></a>

## [**AssistantQueue**](AssistantQueue.html) PutAssistantQueue (string assistantId, string queueId, AssistantQueue body)



Create a queue assistant association.

Requires ALL permissions: 

* assistants:queue:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutAssistantQueueExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AgentAssistantsApi();
            var assistantId = assistantId_example;  // string | Assistant ID
            var queueId = queueId_example;  // string | Queue ID
            var body = new AssistantQueue(); // AssistantQueue | 

            try
            { 
                // Create a queue assistant association.
                AssistantQueue result = apiInstance.PutAssistantQueue(assistantId, queueId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentAssistantsApi.PutAssistantQueue: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **assistantId** | **string**| Assistant ID |  |
| **queueId** | **string**| Queue ID |  |
| **body** | [**AssistantQueue**](AssistantQueue.html)|  |  |
{: class="table table-striped"}

### Return type

[**AssistantQueue**](AssistantQueue.html)

