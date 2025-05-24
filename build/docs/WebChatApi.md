# WebChatApi

## PureCloudPlatform.Client.V2.Api.WebChatApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteWebchatDeployment**](#DeleteWebchatDeployment) | **Delete** /api/v2/webchat/deployments/{deploymentId} | Delete a WebChat deployment |
| [**DeleteWebchatGuestConversationMember**](#DeleteWebchatGuestConversationMember) | **Delete** /api/v2/webchat/guest/conversations/{conversationId}/members/{memberId} | Remove a member from a chat conversation |
| [**DeleteWebchatSettings**](#DeleteWebchatSettings) | **Delete** /api/v2/webchat/settings | Remove WebChat deployment settings |
| [**GetWebchatDeployment**](#GetWebchatDeployment) | **Get** /api/v2/webchat/deployments/{deploymentId} | Get a WebChat deployment |
| [**GetWebchatDeployments**](#GetWebchatDeployments) | **Get** /api/v2/webchat/deployments | List WebChat deployments |
| [**GetWebchatGuestConversationMediarequest**](#GetWebchatGuestConversationMediarequest) | **Get** /api/v2/webchat/guest/conversations/{conversationId}/mediarequests/{mediaRequestId} | Get a media request in the conversation |
| [**GetWebchatGuestConversationMediarequests**](#GetWebchatGuestConversationMediarequests) | **Get** /api/v2/webchat/guest/conversations/{conversationId}/mediarequests | Get all media requests to the guest in the conversation |
| [**GetWebchatGuestConversationMember**](#GetWebchatGuestConversationMember) | **Get** /api/v2/webchat/guest/conversations/{conversationId}/members/{memberId} | Get a web chat conversation member |
| [**GetWebchatGuestConversationMembers**](#GetWebchatGuestConversationMembers) | **Get** /api/v2/webchat/guest/conversations/{conversationId}/members | Get the members of a chat conversation. |
| [**GetWebchatGuestConversationMessage**](#GetWebchatGuestConversationMessage) | **Get** /api/v2/webchat/guest/conversations/{conversationId}/messages/{messageId} | Get a web chat conversation message |
| [**GetWebchatGuestConversationMessages**](#GetWebchatGuestConversationMessages) | **Get** /api/v2/webchat/guest/conversations/{conversationId}/messages | Get the messages of a chat conversation. |
| [**GetWebchatSettings**](#GetWebchatSettings) | **Get** /api/v2/webchat/settings | Get WebChat deployment settings |
| [**PatchWebchatGuestConversationMediarequest**](#PatchWebchatGuestConversationMediarequest) | **Patch** /api/v2/webchat/guest/conversations/{conversationId}/mediarequests/{mediaRequestId} | Update a media request in the conversation, setting the state to ACCEPTED/DECLINED/ERRORED |
| [**PostWebchatDeployments**](#PostWebchatDeployments) | **Post** /api/v2/webchat/deployments | Create WebChat deployment |
| [**PostWebchatGuestConversationMemberMessages**](#PostWebchatGuestConversationMemberMessages) | **Post** /api/v2/webchat/guest/conversations/{conversationId}/members/{memberId}/messages | Send a message in a chat conversation. |
| [**PostWebchatGuestConversationMemberTyping**](#PostWebchatGuestConversationMemberTyping) | **Post** /api/v2/webchat/guest/conversations/{conversationId}/members/{memberId}/typing | Send a typing-indicator in a chat conversation. |
| [**PostWebchatGuestConversations**](#PostWebchatGuestConversations) | **Post** /api/v2/webchat/guest/conversations | Create an ACD chat conversation from an external customer. |
| [**PutWebchatDeployment**](#PutWebchatDeployment) | **Put** /api/v2/webchat/deployments/{deploymentId} | Update a WebChat deployment |
| [**PutWebchatSettings**](#PutWebchatSettings) | **Put** /api/v2/webchat/settings | Update WebChat deployment settings |



## DeleteWebchatDeployment

> void DeleteWebchatDeployment (string deploymentId)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Delete a WebChat deployment

Requires ANY permissions: 

* webchat:deployment:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteWebchatDeploymentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebChatApi();
            var deploymentId = deploymentId_example;  // string | Deployment Id

            try
            { 
                // Delete a WebChat deployment
                apiInstance.DeleteWebchatDeployment(deploymentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebChatApi.DeleteWebchatDeployment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deploymentId** | **string**| Deployment Id |  |

### Return type

void (empty response body)


## DeleteWebchatGuestConversationMember

> void DeleteWebchatGuestConversationMember (string conversationId, string memberId)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Remove a member from a chat conversation

This endpoint is deprecated. Please see the article https://help.mypurecloud.com/articles/deprecation-removal-of-acd-web-chat-version-2/

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteWebchatGuestConversationMemberExample
    {
        public void main()
        { 
            // Configure API key authorization: Guest Chat JWT
            Configuration.Default.ApiKey.Add('Authorization', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. BEARER) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('Authorization', 'BEARER');

            var apiInstance = new WebChatApi();
            var conversationId = conversationId_example;  // string | conversationId
            var memberId = memberId_example;  // string | memberId

            try
            { 
                // Remove a member from a chat conversation
                apiInstance.DeleteWebchatGuestConversationMember(conversationId, memberId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebChatApi.DeleteWebchatGuestConversationMember: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **memberId** | **string**| memberId |  |

### Return type

void (empty response body)


## DeleteWebchatSettings

> void DeleteWebchatSettings ()


Remove WebChat deployment settings

Requires ANY permissions: 

* webchat:deployment:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteWebchatSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebChatApi();

            try
            { 
                // Remove WebChat deployment settings
                apiInstance.DeleteWebchatSettings();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebChatApi.DeleteWebchatSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

void (empty response body)


## GetWebchatDeployment

> [**WebChatDeployment**](WebChatDeployment) GetWebchatDeployment (string deploymentId)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Get a WebChat deployment

Requires ANY permissions: 

* webchat:deployment:read

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWebchatDeploymentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebChatApi();
            var deploymentId = deploymentId_example;  // string | Deployment Id

            try
            { 
                // Get a WebChat deployment
                WebChatDeployment result = apiInstance.GetWebchatDeployment(deploymentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebChatApi.GetWebchatDeployment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deploymentId** | **string**| Deployment Id |  |

### Return type

[**WebChatDeployment**](WebChatDeployment)


## GetWebchatDeployments

> [**WebChatDeploymentEntityListing**](WebChatDeploymentEntityListing) GetWebchatDeployments ()

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

List WebChat deployments

Requires ANY permissions: 

* webchat:deployment:read

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWebchatDeploymentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebChatApi();

            try
            { 
                // List WebChat deployments
                WebChatDeploymentEntityListing result = apiInstance.GetWebchatDeployments();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebChatApi.GetWebchatDeployments: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**WebChatDeploymentEntityListing**](WebChatDeploymentEntityListing)


## GetWebchatGuestConversationMediarequest

> [**WebChatGuestMediaRequest**](WebChatGuestMediaRequest) GetWebchatGuestConversationMediarequest (string conversationId, string mediaRequestId)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Get a media request in the conversation

This endpoint is deprecated. Please see the article https://help.mypurecloud.com/articles/deprecation-legacy-co-browse-and-screenshare/

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWebchatGuestConversationMediarequestExample
    {
        public void main()
        { 
            // Configure API key authorization: Guest Chat JWT
            Configuration.Default.ApiKey.Add('Authorization', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. BEARER) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('Authorization', 'BEARER');

            var apiInstance = new WebChatApi();
            var conversationId = conversationId_example;  // string | conversationId
            var mediaRequestId = mediaRequestId_example;  // string | mediaRequestId

            try
            { 
                // Get a media request in the conversation
                WebChatGuestMediaRequest result = apiInstance.GetWebchatGuestConversationMediarequest(conversationId, mediaRequestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebChatApi.GetWebchatGuestConversationMediarequest: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **mediaRequestId** | **string**| mediaRequestId |  |

### Return type

[**WebChatGuestMediaRequest**](WebChatGuestMediaRequest)


## GetWebchatGuestConversationMediarequests

> [**WebChatGuestMediaRequestEntityList**](WebChatGuestMediaRequestEntityList) GetWebchatGuestConversationMediarequests (string conversationId)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Get all media requests to the guest in the conversation

This endpoint is deprecated. Please see the article https://help.mypurecloud.com/articles/deprecation-removal-of-acd-web-chat-version-2/

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWebchatGuestConversationMediarequestsExample
    {
        public void main()
        { 
            // Configure API key authorization: Guest Chat JWT
            Configuration.Default.ApiKey.Add('Authorization', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. BEARER) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('Authorization', 'BEARER');

            var apiInstance = new WebChatApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            { 
                // Get all media requests to the guest in the conversation
                WebChatGuestMediaRequestEntityList result = apiInstance.GetWebchatGuestConversationMediarequests(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebChatApi.GetWebchatGuestConversationMediarequests: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |

### Return type

[**WebChatGuestMediaRequestEntityList**](WebChatGuestMediaRequestEntityList)


## GetWebchatGuestConversationMember

> [**WebChatMemberInfo**](WebChatMemberInfo) GetWebchatGuestConversationMember (string conversationId, string memberId)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Get a web chat conversation member

This endpoint is deprecated. Please see the article https://help.mypurecloud.com/articles/deprecation-removal-of-acd-web-chat-version-2/

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWebchatGuestConversationMemberExample
    {
        public void main()
        { 
            // Configure API key authorization: Guest Chat JWT
            Configuration.Default.ApiKey.Add('Authorization', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. BEARER) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('Authorization', 'BEARER');

            var apiInstance = new WebChatApi();
            var conversationId = conversationId_example;  // string | conversationId
            var memberId = memberId_example;  // string | memberId

            try
            { 
                // Get a web chat conversation member
                WebChatMemberInfo result = apiInstance.GetWebchatGuestConversationMember(conversationId, memberId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebChatApi.GetWebchatGuestConversationMember: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **memberId** | **string**| memberId |  |

### Return type

[**WebChatMemberInfo**](WebChatMemberInfo)


## GetWebchatGuestConversationMembers

> [**WebChatMemberInfoEntityList**](WebChatMemberInfoEntityList) GetWebchatGuestConversationMembers (string conversationId, int? pageSize = null, int? pageNumber = null, bool? excludeDisconnectedMembers = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Get the members of a chat conversation.

This endpoint is deprecated. Please see the article https://help.mypurecloud.com/articles/deprecation-removal-of-acd-web-chat-version-2/

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWebchatGuestConversationMembersExample
    {
        public void main()
        { 
            // Configure API key authorization: Guest Chat JWT
            Configuration.Default.ApiKey.Add('Authorization', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. BEARER) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('Authorization', 'BEARER');

            var apiInstance = new WebChatApi();
            var conversationId = conversationId_example;  // string | conversationId
            var pageSize = 56;  // int? | The number of entries to return per page, or omitted for the default. (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number to return, or omitted for the first page. (optional)  (default to 1)
            var excludeDisconnectedMembers = true;  // bool? | If true, the results will not contain members who have a DISCONNECTED state. (optional)  (default to false)

            try
            { 
                // Get the members of a chat conversation.
                WebChatMemberInfoEntityList result = apiInstance.GetWebchatGuestConversationMembers(conversationId, pageSize, pageNumber, excludeDisconnectedMembers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebChatApi.GetWebchatGuestConversationMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **pageSize** | **int?**| The number of entries to return per page, or omitted for the default. | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number to return, or omitted for the first page. | [optional] [default to 1] |
| **excludeDisconnectedMembers** | **bool?**| If true, the results will not contain members who have a DISCONNECTED state. | [optional] [default to false] |

### Return type

[**WebChatMemberInfoEntityList**](WebChatMemberInfoEntityList)


## GetWebchatGuestConversationMessage

> [**WebChatMessage**](WebChatMessage) GetWebchatGuestConversationMessage (string conversationId, string messageId)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Get a web chat conversation message

This endpoint is deprecated. Please see the article https://help.mypurecloud.com/articles/deprecation-removal-of-acd-web-chat-version-2/

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWebchatGuestConversationMessageExample
    {
        public void main()
        { 
            // Configure API key authorization: Guest Chat JWT
            Configuration.Default.ApiKey.Add('Authorization', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. BEARER) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('Authorization', 'BEARER');

            var apiInstance = new WebChatApi();
            var conversationId = conversationId_example;  // string | conversationId
            var messageId = messageId_example;  // string | messageId

            try
            { 
                // Get a web chat conversation message
                WebChatMessage result = apiInstance.GetWebchatGuestConversationMessage(conversationId, messageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebChatApi.GetWebchatGuestConversationMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **messageId** | **string**| messageId |  |

### Return type

[**WebChatMessage**](WebChatMessage)


## GetWebchatGuestConversationMessages

> [**WebChatMessageEntityList**](WebChatMessageEntityList) GetWebchatGuestConversationMessages (string conversationId, string after = null, string before = null, string sortOrder = null, int? maxResults = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Get the messages of a chat conversation.

This endpoint is deprecated. Please see the article https://help.mypurecloud.com/articles/deprecation-removal-of-acd-web-chat-version-2/

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWebchatGuestConversationMessagesExample
    {
        public void main()
        { 
            // Configure API key authorization: Guest Chat JWT
            Configuration.Default.ApiKey.Add('Authorization', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. BEARER) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('Authorization', 'BEARER');

            var apiInstance = new WebChatApi();
            var conversationId = conversationId_example;  // string | conversationId
            var after = after_example;  // string | If available, get the messages chronologically after the id of this message (optional) 
            var before = before_example;  // string | If available, get the messages chronologically before the id of this message (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ascending)
            var maxResults = 56;  // int? | Limit the returned number of messages, up to a maximum of 100 (optional)  (default to 100)

            try
            { 
                // Get the messages of a chat conversation.
                WebChatMessageEntityList result = apiInstance.GetWebchatGuestConversationMessages(conversationId, after, before, sortOrder, maxResults);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebChatApi.GetWebchatGuestConversationMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **after** | **string**| If available, get the messages chronologically after the id of this message | [optional]  |
| **before** | **string**| If available, get the messages chronologically before the id of this message | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to ascending]<br />**Values**: ascending, descending |
| **maxResults** | **int?**| Limit the returned number of messages, up to a maximum of 100 | [optional] [default to 100] |

### Return type

[**WebChatMessageEntityList**](WebChatMessageEntityList)


## GetWebchatSettings

> [**WebChatSettings**](WebChatSettings) GetWebchatSettings ()


Get WebChat deployment settings

Requires ANY permissions: 

* webchat:deployment:read

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetWebchatSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebChatApi();

            try
            { 
                // Get WebChat deployment settings
                WebChatSettings result = apiInstance.GetWebchatSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebChatApi.GetWebchatSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**WebChatSettings**](WebChatSettings)


## PatchWebchatGuestConversationMediarequest

> [**WebChatGuestMediaRequest**](WebChatGuestMediaRequest) PatchWebchatGuestConversationMediarequest (string conversationId, string mediaRequestId, WebChatGuestMediaRequest body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Update a media request in the conversation, setting the state to ACCEPTED/DECLINED/ERRORED

This endpoint is deprecated. Please see the article https://help.mypurecloud.com/articles/deprecation-legacy-co-browse-and-screenshare/

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchWebchatGuestConversationMediarequestExample
    {
        public void main()
        { 
            // Configure API key authorization: Guest Chat JWT
            Configuration.Default.ApiKey.Add('Authorization', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. BEARER) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('Authorization', 'BEARER');

            var apiInstance = new WebChatApi();
            var conversationId = conversationId_example;  // string | conversationId
            var mediaRequestId = mediaRequestId_example;  // string | mediaRequestId
            var body = new WebChatGuestMediaRequest(); // WebChatGuestMediaRequest | Request

            try
            { 
                // Update a media request in the conversation, setting the state to ACCEPTED/DECLINED/ERRORED
                WebChatGuestMediaRequest result = apiInstance.PatchWebchatGuestConversationMediarequest(conversationId, mediaRequestId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebChatApi.PatchWebchatGuestConversationMediarequest: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **mediaRequestId** | **string**| mediaRequestId |  |
| **body** | [**WebChatGuestMediaRequest**](WebChatGuestMediaRequest)| Request |  |

### Return type

[**WebChatGuestMediaRequest**](WebChatGuestMediaRequest)


## PostWebchatDeployments

> [**WebChatDeployment**](WebChatDeployment) PostWebchatDeployments (WebChatDeployment body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Create WebChat deployment

Requires ANY permissions: 

* webchat:deployment:create

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWebchatDeploymentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebChatApi();
            var body = new WebChatDeployment(); // WebChatDeployment | Deployment

            try
            { 
                // Create WebChat deployment
                WebChatDeployment result = apiInstance.PostWebchatDeployments(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebChatApi.PostWebchatDeployments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**WebChatDeployment**](WebChatDeployment)| Deployment |  |

### Return type

[**WebChatDeployment**](WebChatDeployment)


## PostWebchatGuestConversationMemberMessages

> [**WebChatMessage**](WebChatMessage) PostWebchatGuestConversationMemberMessages (string conversationId, string memberId, CreateWebChatMessageRequest body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Send a message in a chat conversation.

This endpoint is deprecated. Please see the article https://help.mypurecloud.com/articles/deprecation-removal-of-acd-web-chat-version-2/

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWebchatGuestConversationMemberMessagesExample
    {
        public void main()
        { 
            // Configure API key authorization: Guest Chat JWT
            Configuration.Default.ApiKey.Add('Authorization', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. BEARER) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('Authorization', 'BEARER');

            var apiInstance = new WebChatApi();
            var conversationId = conversationId_example;  // string | conversationId
            var memberId = memberId_example;  // string | memberId
            var body = new CreateWebChatMessageRequest(); // CreateWebChatMessageRequest | Message

            try
            { 
                // Send a message in a chat conversation.
                WebChatMessage result = apiInstance.PostWebchatGuestConversationMemberMessages(conversationId, memberId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebChatApi.PostWebchatGuestConversationMemberMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **memberId** | **string**| memberId |  |
| **body** | [**CreateWebChatMessageRequest**](CreateWebChatMessageRequest)| Message |  |

### Return type

[**WebChatMessage**](WebChatMessage)


## PostWebchatGuestConversationMemberTyping

> [**WebChatTyping**](WebChatTyping) PostWebchatGuestConversationMemberTyping (string conversationId, string memberId)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Send a typing-indicator in a chat conversation.

This endpoint is deprecated. Please see the article https://help.mypurecloud.com/articles/deprecation-removal-of-acd-web-chat-version-2/

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWebchatGuestConversationMemberTypingExample
    {
        public void main()
        { 
            // Configure API key authorization: Guest Chat JWT
            Configuration.Default.ApiKey.Add('Authorization', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. BEARER) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('Authorization', 'BEARER');

            var apiInstance = new WebChatApi();
            var conversationId = conversationId_example;  // string | conversationId
            var memberId = memberId_example;  // string | memberId

            try
            { 
                // Send a typing-indicator in a chat conversation.
                WebChatTyping result = apiInstance.PostWebchatGuestConversationMemberTyping(conversationId, memberId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebChatApi.PostWebchatGuestConversationMemberTyping: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **memberId** | **string**| memberId |  |

### Return type

[**WebChatTyping**](WebChatTyping)


## PostWebchatGuestConversations

> [**CreateWebChatConversationResponse**](CreateWebChatConversationResponse) PostWebchatGuestConversations (CreateWebChatConversationRequest body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Create an ACD chat conversation from an external customer.

This endpoint is deprecated. Please see the article https://help.mypurecloud.com/articles/deprecation-removal-of-acd-web-chat-version-2/. This endpoint will create a new ACD Chat conversation under the specified Chat Deployment. The conversation will begin with a guest member in it (with a role=CUSTOMER) according to the customer information that is supplied. If the guest member is authenticated, the 'memberAuthToken' field should include his JWT as generated by the 'POST /api/v2/signeddata' resource; if the guest member is anonymous (and the Deployment permits it) this field can be omitted. The returned data includes the IDs of the conversation created, along with a newly-create JWT token that you can supply to all future endpoints as authentication to perform operations against that conversation. After successfully creating a conversation, you should connect a websocket to the event stream named in the 'eventStreamUri' field of the response; the conversation is not routed until the event stream is attached.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostWebchatGuestConversationsExample
    {
        public void main()
        { 

            var apiInstance = new WebChatApi();
            var body = new CreateWebChatConversationRequest(); // CreateWebChatConversationRequest | CreateConversationRequest

            try
            { 
                // Create an ACD chat conversation from an external customer.
                CreateWebChatConversationResponse result = apiInstance.PostWebchatGuestConversations(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebChatApi.PostWebchatGuestConversations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateWebChatConversationRequest**](CreateWebChatConversationRequest)| CreateConversationRequest |  |

### Return type

[**CreateWebChatConversationResponse**](CreateWebChatConversationResponse)


## PutWebchatDeployment

> [**WebChatDeployment**](WebChatDeployment) PutWebchatDeployment (string deploymentId, WebChatDeployment body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Update a WebChat deployment

Requires ANY permissions: 

* webchat:deployment:update

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutWebchatDeploymentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebChatApi();
            var deploymentId = deploymentId_example;  // string | Deployment Id
            var body = new WebChatDeployment(); // WebChatDeployment | Deployment

            try
            { 
                // Update a WebChat deployment
                WebChatDeployment result = apiInstance.PutWebchatDeployment(deploymentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebChatApi.PutWebchatDeployment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deploymentId** | **string**| Deployment Id |  |
| **body** | [**WebChatDeployment**](WebChatDeployment)| Deployment |  |

### Return type

[**WebChatDeployment**](WebChatDeployment)


## PutWebchatSettings

> [**WebChatSettings**](WebChatSettings) PutWebchatSettings (WebChatSettings body)


Update WebChat deployment settings

Requires ANY permissions: 

* webchat:deployment:update

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutWebchatSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new WebChatApi();
            var body = new WebChatSettings(); // WebChatSettings | webChatSettings

            try
            { 
                // Update WebChat deployment settings
                WebChatSettings result = apiInstance.PutWebchatSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebChatApi.PutWebchatSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**WebChatSettings**](WebChatSettings)| webChatSettings |  |

### Return type

[**WebChatSettings**](WebChatSettings)


_PureCloudPlatform.Client.V2 234.0.0_
