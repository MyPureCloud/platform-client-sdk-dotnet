# AgentAssistantsApi

## PureCloudPlatform.Client.V2.Api.AgentAssistantsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteAssistant**](#DeleteAssistant) | **Delete** /api/v2/assistants/{assistantId} | Delete an assistant. |
| [**DeleteAssistantQueue**](#DeleteAssistantQueue) | **Delete** /api/v2/assistants/{assistantId}/queues/{queueId} | Disassociate a queue from an assistant. |
| [**DeleteAssistantQueues**](#DeleteAssistantQueues) | **Delete** /api/v2/assistants/{assistantId}/queues | Disassociate the queues from an assistant for the given assistant ID and queue IDs. |
| [**GetAssistant**](#GetAssistant) | **Get** /api/v2/assistants/{assistantId} | Get an assistant. |
| [**GetAssistantQueue**](#GetAssistantQueue) | **Get** /api/v2/assistants/{assistantId}/queues/{queueId} | Get queue Information for an assistant. |
| [**GetAssistantQueues**](#GetAssistantQueues) | **Get** /api/v2/assistants/{assistantId}/queues | Get all the queues associated with an assistant. |
| [**GetAssistants**](#GetAssistants) | **Get** /api/v2/assistants | Get all assistants. |
| [**GetAssistantsQueues**](#GetAssistantsQueues) | **Get** /api/v2/assistants/queues | Get all queues assigned to any assistant. |
| [**PatchAssistant**](#PatchAssistant) | **Patch** /api/v2/assistants/{assistantId} | Update an assistant. |
| [**PatchAssistantQueues**](#PatchAssistantQueues) | **Patch** /api/v2/assistants/{assistantId}/queues | Update Queues for an Assistant. |
| [**PostAssistantQueueUsersBulkAdd**](#PostAssistantQueueUsersBulkAdd) | **Post** /api/v2/assistants/{assistantId}/queues/{queueId}/users/bulk/add | Bulk add users to assistant-queue (requires manual assignment mode). |
| [**PostAssistantQueueUsersBulkRemove**](#PostAssistantQueueUsersBulkRemove) | **Post** /api/v2/assistants/{assistantId}/queues/{queueId}/users/bulk/remove | Bulk remove users from assistant-queue (requires manual assignment mode). |
| [**PostAssistantQueueUsersQuery**](#PostAssistantQueueUsersQuery) | **Post** /api/v2/assistants/{assistantId}/queues/{queueId}/users/query | Query for users in the assistant-queue (requires manual assignment mode). |
| [**PostAssistants**](#PostAssistants) | **Post** /api/v2/assistants | Create an Assistant. |
| [**PutAssistantQueue**](#PutAssistantQueue) | **Put** /api/v2/assistants/{assistantId}/queues/{queueId} | Create a queue assistant association. |



## DeleteAssistant

> void DeleteAssistant (string assistantId)


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

### Return type

void (empty response body)


## DeleteAssistantQueue

> void DeleteAssistantQueue (string assistantId, string queueId)


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

### Return type

void (empty response body)


## DeleteAssistantQueues

> void DeleteAssistantQueues (string assistantId, string queueIds = null)


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

### Return type

void (empty response body)


## GetAssistant

> [**Assistant**](Assistant) GetAssistant (string assistantId, string expand = null)


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

### Return type

[**Assistant**](Assistant)


## GetAssistantQueue

> [**AssistantQueue**](AssistantQueue) GetAssistantQueue (string assistantId, string queueId, string expand = null)


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

### Return type

[**AssistantQueue**](AssistantQueue)


## GetAssistantQueues

> [**AssistantQueueListing**](AssistantQueueListing) GetAssistantQueues (string assistantId, string before = null, string after = null, string pageSize = null, string expand = null)


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

### Return type

[**AssistantQueueListing**](AssistantQueueListing)


## GetAssistants

> [**AssistantListing**](AssistantListing) GetAssistants (string before = null, string after = null, string limit = null, string pageSize = null, string name = null, string expand = null)


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
            var expand = expand_example;  // string | Which fields, if any, to expand (optional) 

            try
            { 
                // Get all assistants.
                AssistantListing result = apiInstance.GetAssistants(before, after, limit, pageSize, name, expand);
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
| **expand** | **string**| Which fields, if any, to expand | [optional] <br />**Values**: copilot |

### Return type

[**AssistantListing**](AssistantListing)


## GetAssistantsQueues

> [**AssistantQueueListing**](AssistantQueueListing) GetAssistantsQueues (string before = null, string after = null, string pageSize = null, string queueIds = null, string expand = null)


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

### Return type

[**AssistantQueueListing**](AssistantQueueListing)


## PatchAssistant

> [**Assistant**](Assistant) PatchAssistant (string assistantId, Assistant body)


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
| **body** | [**Assistant**](Assistant)|  |  |

### Return type

[**Assistant**](Assistant)


## PatchAssistantQueues

> [**AssistantQueueListing**](AssistantQueueListing) PatchAssistantQueues (string assistantId, List<AssistantQueue> body)


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
| **body** | [**List<AssistantQueue>**](AssistantQueue)|  |  |

### Return type

[**AssistantQueueListing**](AssistantQueueListing)


## PostAssistantQueueUsersBulkAdd

> [**BulkResponse**](BulkResponse) PostAssistantQueueUsersBulkAdd (string assistantId, string queueId, AssistantQueueUsersBulkAddRequest body)


Bulk add users to assistant-queue (requires manual assignment mode).

Requires ANY permissions: 

* assistants:queueUserAssignment:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAssistantQueueUsersBulkAddExample
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
            var body = new AssistantQueueUsersBulkAddRequest(); // AssistantQueueUsersBulkAddRequest | 

            try
            { 
                // Bulk add users to assistant-queue (requires manual assignment mode).
                BulkResponse result = apiInstance.PostAssistantQueueUsersBulkAdd(assistantId, queueId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentAssistantsApi.PostAssistantQueueUsersBulkAdd: " + e.Message );
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
| **body** | [**AssistantQueueUsersBulkAddRequest**](AssistantQueueUsersBulkAddRequest)|  |  |

### Return type

[**BulkResponse**](BulkResponse)


## PostAssistantQueueUsersBulkRemove

> [**BulkResponse**](BulkResponse) PostAssistantQueueUsersBulkRemove (string assistantId, string queueId, AssistantQueueUsersBulkRemoveRequest body)


Bulk remove users from assistant-queue (requires manual assignment mode).

Requires ANY permissions: 

* assistants:queueUserAssignment:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAssistantQueueUsersBulkRemoveExample
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
            var body = new AssistantQueueUsersBulkRemoveRequest(); // AssistantQueueUsersBulkRemoveRequest | 

            try
            { 
                // Bulk remove users from assistant-queue (requires manual assignment mode).
                BulkResponse result = apiInstance.PostAssistantQueueUsersBulkRemove(assistantId, queueId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentAssistantsApi.PostAssistantQueueUsersBulkRemove: " + e.Message );
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
| **body** | [**AssistantQueueUsersBulkRemoveRequest**](AssistantQueueUsersBulkRemoveRequest)|  |  |

### Return type

[**BulkResponse**](BulkResponse)


## PostAssistantQueueUsersQuery

> [**AssistantQueueUsersQueryResponse**](AssistantQueueUsersQueryResponse) PostAssistantQueueUsersQuery (string assistantId, string queueId, AssistantQueueUsersQueryRequest body, List<string> expand = null)


Query for users in the assistant-queue (requires manual assignment mode).

Requires ANY permissions: 

* assistants:queueUserAssignment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAssistantQueueUsersQueryExample
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
            var body = new AssistantQueueUsersQueryRequest(); // AssistantQueueUsersQueryRequest | 
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand with. (optional) 

            try
            { 
                // Query for users in the assistant-queue (requires manual assignment mode).
                AssistantQueueUsersQueryResponse result = apiInstance.PostAssistantQueueUsersQuery(assistantId, queueId, body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentAssistantsApi.PostAssistantQueueUsersQuery: " + e.Message );
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
| **body** | [**AssistantQueueUsersQueryRequest**](AssistantQueueUsersQueryRequest)|  |  |
| **expand** | [**List<string>**](string)| Which fields, if any, to expand with. | [optional] <br />**Values**: assistant, copilot |

### Return type

[**AssistantQueueUsersQueryResponse**](AssistantQueueUsersQueryResponse)


## PostAssistants

> [**Assistant**](Assistant) PostAssistants (Assistant body)


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
| **body** | [**Assistant**](Assistant)|  |  |

### Return type

[**Assistant**](Assistant)


## PutAssistantQueue

> [**AssistantQueue**](AssistantQueue) PutAssistantQueue (string assistantId, string queueId, AssistantQueue body)


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
| **body** | [**AssistantQueue**](AssistantQueue)|  |  |

### Return type

[**AssistantQueue**](AssistantQueue)


_PureCloudPlatform.Client.V2 241.0.0_
