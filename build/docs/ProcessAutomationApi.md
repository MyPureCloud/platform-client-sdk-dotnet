# ProcessAutomationApi

## PureCloudPlatform.Client.V2.Api.ProcessAutomationApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteProcessautomationTrigger**](#DeleteProcessautomationTrigger) | **Delete** /api/v2/processautomation/triggers/{triggerId} | Delete a Trigger |
| [**GetProcessautomationTrigger**](#GetProcessautomationTrigger) | **Get** /api/v2/processautomation/triggers/{triggerId} | Retrieve a single Trigger matching id |
| [**GetProcessautomationTriggers**](#GetProcessautomationTriggers) | **Get** /api/v2/processautomation/triggers | Retrieves all triggers, optionally filtered by query parameters. |
| [**GetProcessautomationTriggersTopics**](#GetProcessautomationTriggersTopics) | **Get** /api/v2/processautomation/triggers/topics | Get topics available for organization |
| [**PostProcessautomationTriggerTest**](#PostProcessautomationTriggerTest) | **Post** /api/v2/processautomation/triggers/{triggerId}/test | Test the matching of a Trigger based on provided event body |
| [**PostProcessautomationTriggers**](#PostProcessautomationTriggers) | **Post** /api/v2/processautomation/triggers | Create a Trigger |
| [**PostProcessautomationTriggersTopicTest**](#PostProcessautomationTriggersTopicTest) | **Post** /api/v2/processautomation/triggers/topics/{topicName}/test | Test the matching of all organization Triggers on given topic using provided event body |
| [**PutProcessautomationTrigger**](#PutProcessautomationTrigger) | **Put** /api/v2/processautomation/triggers/{triggerId} | Update a Trigger |



## DeleteProcessautomationTrigger

> void DeleteProcessautomationTrigger (string triggerId)


Delete a Trigger

Requires ANY permissions: 

* processautomation:trigger:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteProcessautomationTriggerExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ProcessAutomationApi();
            var triggerId = triggerId_example;  // string | triggerId

            try
            { 
                // Delete a Trigger
                apiInstance.DeleteProcessautomationTrigger(triggerId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessAutomationApi.DeleteProcessautomationTrigger: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **triggerId** | **string**| triggerId |  |

### Return type

void (empty response body)


## GetProcessautomationTrigger

> [**Trigger**](Trigger) GetProcessautomationTrigger (string triggerId)


Retrieve a single Trigger matching id

Requires ANY permissions: 

* processautomation:trigger:edit
* processautomation:trigger:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetProcessautomationTriggerExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ProcessAutomationApi();
            var triggerId = triggerId_example;  // string | triggerId

            try
            { 
                // Retrieve a single Trigger matching id
                Trigger result = apiInstance.GetProcessautomationTrigger(triggerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessAutomationApi.GetProcessautomationTrigger: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **triggerId** | **string**| triggerId |  |

### Return type

[**Trigger**](Trigger)


## GetProcessautomationTriggers

> [**TriggerEntityListing**](TriggerEntityListing) GetProcessautomationTriggers (string before = null, string after = null, string pageSize = null, string topicName = null, bool? enabled = null, bool? hasDelayBy = null)


Retrieves all triggers, optionally filtered by query parameters.

Requires ANY permissions: 

* processautomation:trigger:edit
* processautomation:trigger:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetProcessautomationTriggersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ProcessAutomationApi();
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var topicName = topicName_example;  // string | Topic name(s). Separated by commas (optional) 
            var enabled = true;  // bool? | Boolean indicating desired enabled state of triggers (optional) 
            var hasDelayBy = true;  // bool? | Boolean to filter based on delayBySeconds being set in triggers. Default returns all, true returns only those with delayBySeconds set, false returns those without delayBySeconds set. (optional) 

            try
            { 
                // Retrieves all triggers, optionally filtered by query parameters.
                TriggerEntityListing result = apiInstance.GetProcessautomationTriggers(before, after, pageSize, topicName, enabled, hasDelayBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessAutomationApi.GetProcessautomationTriggers: " + e.Message );
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
| **topicName** | **string**| Topic name(s). Separated by commas | [optional]  |
| **enabled** | **bool?**| Boolean indicating desired enabled state of triggers | [optional]  |
| **hasDelayBy** | **bool?**| Boolean to filter based on delayBySeconds being set in triggers. Default returns all, true returns only those with delayBySeconds set, false returns those without delayBySeconds set. | [optional]  |

### Return type

[**TriggerEntityListing**](TriggerEntityListing)


## GetProcessautomationTriggersTopics

> [**TopicCursorEntityListing**](TopicCursorEntityListing) GetProcessautomationTriggersTopics (string before = null, string after = null, string pageSize = null)


Get topics available for organization

Requires ANY permissions: 

* processautomation:trigger:edit
* processautomation:trigger:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetProcessautomationTriggersTopicsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ProcessAutomationApi();
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 

            try
            { 
                // Get topics available for organization
                TopicCursorEntityListing result = apiInstance.GetProcessautomationTriggersTopics(before, after, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessAutomationApi.GetProcessautomationTriggersTopics: " + e.Message );
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

### Return type

[**TopicCursorEntityListing**](TopicCursorEntityListing)


## PostProcessautomationTriggerTest

> [**TestModeResults**](TestModeResults) PostProcessautomationTriggerTest (string triggerId, string body = null)


Test the matching of a Trigger based on provided event body

Requires ANY permissions: 

* processautomation:trigger:test

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostProcessautomationTriggerTestExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ProcessAutomationApi();
            var triggerId = triggerId_example;  // string | triggerId
            var body = body_example;  // string | eventBody (optional) 

            try
            { 
                // Test the matching of a Trigger based on provided event body
                TestModeResults result = apiInstance.PostProcessautomationTriggerTest(triggerId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessAutomationApi.PostProcessautomationTriggerTest: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **triggerId** | **string**| triggerId |  |
| **body** | **string**| eventBody | [optional]  |

### Return type

[**TestModeResults**](TestModeResults)


## PostProcessautomationTriggers

> [**Trigger**](Trigger) PostProcessautomationTriggers (CreateTriggerRequest body)


Create a Trigger

Requires ANY permissions: 

* processautomation:trigger:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostProcessautomationTriggersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ProcessAutomationApi();
            var body = new CreateTriggerRequest(); // CreateTriggerRequest | Input used to create a Trigger.

            try
            { 
                // Create a Trigger
                Trigger result = apiInstance.PostProcessautomationTriggers(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessAutomationApi.PostProcessautomationTriggers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateTriggerRequest**](CreateTriggerRequest)| Input used to create a Trigger. |  |

### Return type

[**Trigger**](Trigger)


## PostProcessautomationTriggersTopicTest

> [**TestModeEventResults**](TestModeEventResults) PostProcessautomationTriggersTopicTest (string topicName, string body = null)


Test the matching of all organization Triggers on given topic using provided event body

Requires ANY permissions: 

* processautomation:trigger:test

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostProcessautomationTriggersTopicTestExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ProcessAutomationApi();
            var topicName = topicName_example;  // string | topicName
            var body = body_example;  // string | eventBody (optional) 

            try
            { 
                // Test the matching of all organization Triggers on given topic using provided event body
                TestModeEventResults result = apiInstance.PostProcessautomationTriggersTopicTest(topicName, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessAutomationApi.PostProcessautomationTriggersTopicTest: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **topicName** | **string**| topicName |  |
| **body** | **string**| eventBody | [optional]  |

### Return type

[**TestModeEventResults**](TestModeEventResults)


## PutProcessautomationTrigger

> [**Trigger**](Trigger) PutProcessautomationTrigger (string triggerId, UpdateTriggerRequest body)


Update a Trigger

Requires ANY permissions: 

* processautomation:trigger:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutProcessautomationTriggerExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ProcessAutomationApi();
            var triggerId = triggerId_example;  // string | triggerId
            var body = new UpdateTriggerRequest(); // UpdateTriggerRequest | Input to update Trigger. (topicName cannot be updated, a new trigger must be created to use a new topicName)

            try
            { 
                // Update a Trigger
                Trigger result = apiInstance.PutProcessautomationTrigger(triggerId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessAutomationApi.PutProcessautomationTrigger: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **triggerId** | **string**| triggerId |  |
| **body** | [**UpdateTriggerRequest**](UpdateTriggerRequest)| Input to update Trigger. (topicName cannot be updated, a new trigger must be created to use a new topicName) |  |

### Return type

[**Trigger**](Trigger)


_PureCloudPlatform.Client.V2 226.0.0_
