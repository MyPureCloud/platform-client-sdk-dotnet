# EventsApi

## PureCloudPlatform.Client.V2.Api.EventsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**PostEventsConversations**](#PostEventsConversations) | **Post** /api/v2/events/conversations | Publish Conversation Batch Events |
| [**PostEventsUsersPresence**](#PostEventsUsersPresence) | **Post** /api/v2/events/users/presence | Publish User Presence Status Batch Events |
| [**PostEventsUsersRoutingstatus**](#PostEventsUsersRoutingstatus) | **Post** /api/v2/events/users/routingstatus | Publish Agent Routing Status Batch Events |



## PostEventsConversations

> [**BatchEventResponse**](BatchEventResponse) PostEventsConversations (BatchConversationEventRequest body)


Publish Conversation Batch Events

Requires ANY permissions: 

* conversation:conversation:inject

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostEventsConversationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new EventsApi();
            var body = new BatchConversationEventRequest(); // BatchConversationEventRequest | batchRequest

            try
            { 
                // Publish Conversation Batch Events
                BatchEventResponse result = apiInstance.PostEventsConversations(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventsApi.PostEventsConversations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**BatchConversationEventRequest**](BatchConversationEventRequest)| batchRequest |  |

### Return type

[**BatchEventResponse**](BatchEventResponse)


## PostEventsUsersPresence

> [**BatchEventResponse**](BatchEventResponse) PostEventsUsersPresence (BatchUserPresenceEventRequest body)


Publish User Presence Status Batch Events

Requires ANY permissions: 

* presence:userPresence:inject

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostEventsUsersPresenceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new EventsApi();
            var body = new BatchUserPresenceEventRequest(); // BatchUserPresenceEventRequest | batchRequest

            try
            { 
                // Publish User Presence Status Batch Events
                BatchEventResponse result = apiInstance.PostEventsUsersPresence(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventsApi.PostEventsUsersPresence: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**BatchUserPresenceEventRequest**](BatchUserPresenceEventRequest)| batchRequest |  |

### Return type

[**BatchEventResponse**](BatchEventResponse)


## PostEventsUsersRoutingstatus

> [**BatchEventResponse**](BatchEventResponse) PostEventsUsersRoutingstatus (BatchUserRoutingStatusEventRequest body)


Publish Agent Routing Status Batch Events

Requires ANY permissions: 

* routing:routingstatus:inject

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostEventsUsersRoutingstatusExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new EventsApi();
            var body = new BatchUserRoutingStatusEventRequest(); // BatchUserRoutingStatusEventRequest | batchRequest

            try
            { 
                // Publish Agent Routing Status Batch Events
                BatchEventResponse result = apiInstance.PostEventsUsersRoutingstatus(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventsApi.PostEventsUsersRoutingstatus: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**BatchUserRoutingStatusEventRequest**](BatchUserRoutingStatusEventRequest)| batchRequest |  |

### Return type

[**BatchEventResponse**](BatchEventResponse)


_PureCloudPlatform.Client.V2 254.0.0_
