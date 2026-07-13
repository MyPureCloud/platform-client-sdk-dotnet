# ScreenMonitoringApi

## PureCloudPlatform.Client.V2.Api.ScreenMonitoringApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteConversationParticipantScreenmonitorsSession**](#DeleteConversationParticipantScreenmonitorsSession) | **Delete** /api/v2/conversations/{conversationId}/participants/{participantId}/screenmonitors/sessions/{screenMonitoringId} | Stop a conversation-level screen monitoring session. |
| [**DeleteUserScreenmonitorsSession**](#DeleteUserScreenmonitorsSession) | **Delete** /api/v2/users/{userId}/screenmonitors/sessions/{screenMonitoringId} | Stop an agent-level screen monitoring session. |
| [**GetConversationParticipantScreenmonitorsSession**](#GetConversationParticipantScreenmonitorsSession) | **Get** /api/v2/conversations/{conversationId}/participants/{participantId}/screenmonitors/sessions/{screenMonitoringId} | Get a conversation-level screen monitoring session object using the supplied screenMonitoringId. |
| [**GetScreenmonitorsSessionsDetails**](#GetScreenmonitorsSessionsDetails) | **Get** /api/v2/screenmonitors/sessions/details | Get the details of all screen monitoring sessions for the current organization. |
| [**GetScreenmonitorsSettings**](#GetScreenmonitorsSettings) | **Get** /api/v2/screenmonitors/settings | Get the Screen Monitor Settings for the Organization |
| [**GetScreenmonitorsUserSessions**](#GetScreenmonitorsUserSessions) | **Get** /api/v2/screenmonitors/users/{userId}/sessions | Get all screen monitoring sessions for the supplied userId. |
| [**GetUserScreenmonitorsSession**](#GetUserScreenmonitorsSession) | **Get** /api/v2/users/{userId}/screenmonitors/sessions/{screenMonitoringId} | Get an agent-level screen monitoring session object using the supplied screenMonitoringId. |
| [**PostConversationParticipantScreenmonitorsSessions**](#PostConversationParticipantScreenmonitorsSessions) | **Post** /api/v2/conversations/{conversationId}/participants/{participantId}/screenmonitors/sessions | Start a conversation-level screen monitoring session. |
| [**PostScreenmonitorsSessionsUsersDetails**](#PostScreenmonitorsSessionsUsersDetails) | **Post** /api/v2/screenmonitors/sessions/users/details | Get screen monitor session details for one or more users. |
| [**PostUserScreenmonitorsSessions**](#PostUserScreenmonitorsSessions) | **Post** /api/v2/users/{userId}/screenmonitors/sessions | Start an agent-level screen monitoring session. |
| [**PutScreenmonitorsSettings**](#PutScreenmonitorsSettings) | **Put** /api/v2/screenmonitors/settings | Update the Screen Monitor Settings for the Organization |



## DeleteConversationParticipantScreenmonitorsSession

> void DeleteConversationParticipantScreenmonitorsSession (string conversationId, string participantId, string screenMonitoringId)


Stop a conversation-level screen monitoring session.

Requires ANY permissions: 

* realtimeMonitor:screen:monitorConversation

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteConversationParticipantScreenmonitorsSessionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ScreenMonitoringApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var participantId = participantId_example;  // string | Participant ID
            var screenMonitoringId = screenMonitoringId_example;  // string | Screen Monitoring ID

            try
            { 
                // Stop a conversation-level screen monitoring session.
                apiInstance.DeleteConversationParticipantScreenmonitorsSession(conversationId, participantId, screenMonitoringId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScreenMonitoringApi.DeleteConversationParticipantScreenmonitorsSession: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **participantId** | **string**| Participant ID |  |
| **screenMonitoringId** | **string**| Screen Monitoring ID |  |

### Return type

void (empty response body)


## DeleteUserScreenmonitorsSession

> void DeleteUserScreenmonitorsSession (string userId, string screenMonitoringId)


Stop an agent-level screen monitoring session.

Requires ANY permissions: 

* realtimeMonitor:screen:monitorAgent

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteUserScreenmonitorsSessionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ScreenMonitoringApi();
            var userId = userId_example;  // string | User ID
            var screenMonitoringId = screenMonitoringId_example;  // string | Screen Monitoring ID

            try
            { 
                // Stop an agent-level screen monitoring session.
                apiInstance.DeleteUserScreenmonitorsSession(userId, screenMonitoringId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScreenMonitoringApi.DeleteUserScreenmonitorsSession: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **screenMonitoringId** | **string**| Screen Monitoring ID |  |

### Return type

void (empty response body)


## GetConversationParticipantScreenmonitorsSession

> [**ScreenMonitoringSession**](ScreenMonitoringSession) GetConversationParticipantScreenmonitorsSession (string conversationId, string participantId, string screenMonitoringId)


Get a conversation-level screen monitoring session object using the supplied screenMonitoringId.

Requires ANY permissions: 

* realtimeMonitor:screen:monitorConversation

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationParticipantScreenmonitorsSessionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ScreenMonitoringApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var participantId = participantId_example;  // string | Participant ID
            var screenMonitoringId = screenMonitoringId_example;  // string | Screen Monitoring ID

            try
            { 
                // Get a conversation-level screen monitoring session object using the supplied screenMonitoringId.
                ScreenMonitoringSession result = apiInstance.GetConversationParticipantScreenmonitorsSession(conversationId, participantId, screenMonitoringId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScreenMonitoringApi.GetConversationParticipantScreenmonitorsSession: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **participantId** | **string**| Participant ID |  |
| **screenMonitoringId** | **string**| Screen Monitoring ID |  |

### Return type

[**ScreenMonitoringSession**](ScreenMonitoringSession)


## GetScreenmonitorsSessionsDetails

> [**ScreenMonitoringDetails**](ScreenMonitoringDetails) GetScreenmonitorsSessionsDetails ()


Get the details of all screen monitoring sessions for the current organization.

Requires ANY permissions: 

* realtimeMonitor:screenSession:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetScreenmonitorsSessionsDetailsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ScreenMonitoringApi();

            try
            { 
                // Get the details of all screen monitoring sessions for the current organization.
                ScreenMonitoringDetails result = apiInstance.GetScreenmonitorsSessionsDetails();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScreenMonitoringApi.GetScreenmonitorsSessionsDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**ScreenMonitoringDetails**](ScreenMonitoringDetails)


## GetScreenmonitorsSettings

> [**ScreenMonitorSettings**](ScreenMonitorSettings) GetScreenmonitorsSettings ()


Get the Screen Monitor Settings for the Organization

Requires ANY permissions: 

* realtimeMonitor:settings:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetScreenmonitorsSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ScreenMonitoringApi();

            try
            { 
                // Get the Screen Monitor Settings for the Organization
                ScreenMonitorSettings result = apiInstance.GetScreenmonitorsSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScreenMonitoringApi.GetScreenmonitorsSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**ScreenMonitorSettings**](ScreenMonitorSettings)


## GetScreenmonitorsUserSessions

> [**ScreenMonitoringSessionEntityListing**](ScreenMonitoringSessionEntityListing) GetScreenmonitorsUserSessions (string userId)


Get all screen monitoring sessions for the supplied userId.

Requires ANY permissions: 

* realtimeMonitor:screen:monitorConversation
* realtimeMonitor:screen:monitorAgent

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetScreenmonitorsUserSessionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ScreenMonitoringApi();
            var userId = userId_example;  // string | User ID

            try
            { 
                // Get all screen monitoring sessions for the supplied userId.
                ScreenMonitoringSessionEntityListing result = apiInstance.GetScreenmonitorsUserSessions(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScreenMonitoringApi.GetScreenmonitorsUserSessions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |

### Return type

[**ScreenMonitoringSessionEntityListing**](ScreenMonitoringSessionEntityListing)


## GetUserScreenmonitorsSession

> [**ScreenMonitoringSession**](ScreenMonitoringSession) GetUserScreenmonitorsSession (string userId, string screenMonitoringId)


Get an agent-level screen monitoring session object using the supplied screenMonitoringId.

Requires ANY permissions: 

* realtimeMonitor:screen:monitorAgent

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUserScreenmonitorsSessionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ScreenMonitoringApi();
            var userId = userId_example;  // string | User ID
            var screenMonitoringId = screenMonitoringId_example;  // string | Screen Monitoring ID

            try
            { 
                // Get an agent-level screen monitoring session object using the supplied screenMonitoringId.
                ScreenMonitoringSession result = apiInstance.GetUserScreenmonitorsSession(userId, screenMonitoringId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScreenMonitoringApi.GetUserScreenmonitorsSession: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **screenMonitoringId** | **string**| Screen Monitoring ID |  |

### Return type

[**ScreenMonitoringSession**](ScreenMonitoringSession)


## PostConversationParticipantScreenmonitorsSessions

> [**StartScreenMonitorResponseBody**](StartScreenMonitorResponseBody) PostConversationParticipantScreenmonitorsSessions (string conversationId, string participantId)


Start a conversation-level screen monitoring session.

Requires ANY permissions: 

* realtimeMonitor:screen:monitorConversation

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationParticipantScreenmonitorsSessionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ScreenMonitoringApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var participantId = participantId_example;  // string | Participant ID

            try
            { 
                // Start a conversation-level screen monitoring session.
                StartScreenMonitorResponseBody result = apiInstance.PostConversationParticipantScreenmonitorsSessions(conversationId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScreenMonitoringApi.PostConversationParticipantScreenmonitorsSessions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **participantId** | **string**| Participant ID |  |

### Return type

[**StartScreenMonitorResponseBody**](StartScreenMonitorResponseBody)


## PostScreenmonitorsSessionsUsersDetails

> [**ScreenMonitoringUserDetailsEntityListing**](ScreenMonitoringUserDetailsEntityListing) PostScreenmonitorsSessionsUsersDetails (List<string> body)


Get screen monitor session details for one or more users.

Requires ANY permissions: 

* realtimeMonitor:screenSession:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostScreenmonitorsSessionsUsersDetailsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ScreenMonitoringApi();
            var body = new List<string>(); // List<string> | List of target user IDs

            try
            { 
                // Get screen monitor session details for one or more users.
                ScreenMonitoringUserDetailsEntityListing result = apiInstance.PostScreenmonitorsSessionsUsersDetails(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScreenMonitoringApi.PostScreenmonitorsSessionsUsersDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**List<string>**](string)| List of target user IDs |  |

### Return type

[**ScreenMonitoringUserDetailsEntityListing**](ScreenMonitoringUserDetailsEntityListing)


## PostUserScreenmonitorsSessions

> [**StartScreenMonitorResponseBody**](StartScreenMonitorResponseBody) PostUserScreenmonitorsSessions (string userId)


Start an agent-level screen monitoring session.

Requires ANY permissions: 

* realtimeMonitor:screen:monitorAgent

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUserScreenmonitorsSessionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ScreenMonitoringApi();
            var userId = userId_example;  // string | User ID

            try
            { 
                // Start an agent-level screen monitoring session.
                StartScreenMonitorResponseBody result = apiInstance.PostUserScreenmonitorsSessions(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScreenMonitoringApi.PostUserScreenmonitorsSessions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |

### Return type

[**StartScreenMonitorResponseBody**](StartScreenMonitorResponseBody)


## PutScreenmonitorsSettings

> void PutScreenmonitorsSettings (ScreenMonitorSettings body)


Update the Screen Monitor Settings for the Organization

Requires ANY permissions: 

* realtimeMonitor:settings:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutScreenmonitorsSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ScreenMonitoringApi();
            var body = new ScreenMonitorSettings(); // ScreenMonitorSettings | Screen Monitor settings

            try
            { 
                // Update the Screen Monitor Settings for the Organization
                apiInstance.PutScreenmonitorsSettings(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScreenMonitoringApi.PutScreenmonitorsSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ScreenMonitorSettings**](ScreenMonitorSettings)| Screen Monitor settings |  |

### Return type

void (empty response body)


_PureCloudPlatform.Client.V2 268.0.0_
