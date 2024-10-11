# OperationalEventsApi

## PureCloudPlatform.Client.V2.Api.OperationalEventsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetUsageEventsDefinition**](#GetUsageEventsDefinition) | **Get** /api/v2/usage/events/definitions/{eventDefinitionId} | Get an operational event definition by its id |
| [**GetUsageEventsDefinitions**](#GetUsageEventsDefinitions) | **Get** /api/v2/usage/events/definitions | Get all operational event definitions |



## GetUsageEventsDefinition

> [**EventDefinition**](EventDefinition) GetUsageEventsDefinition (string eventDefinitionId)


Get an operational event definition by its id

Requires ALL permissions: 

* usage:events:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUsageEventsDefinitionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OperationalEventsApi();
            var eventDefinitionId = eventDefinitionId_example;  // string | EventDefinition id

            try
            { 
                // Get an operational event definition by its id
                EventDefinition result = apiInstance.GetUsageEventsDefinition(eventDefinitionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationalEventsApi.GetUsageEventsDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **eventDefinitionId** | **string**| EventDefinition id |  |

### Return type

[**EventDefinition**](EventDefinition)


## GetUsageEventsDefinitions

> [**EventDefinitionListing**](EventDefinitionListing) GetUsageEventsDefinitions ()


Get all operational event definitions

Requires ALL permissions: 

* usage:events:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUsageEventsDefinitionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OperationalEventsApi();

            try
            { 
                // Get all operational event definitions
                EventDefinitionListing result = apiInstance.GetUsageEventsDefinitions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationalEventsApi.GetUsageEventsDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**EventDefinitionListing**](EventDefinitionListing)


_PureCloudPlatform.Client.V2 218.0.0_
