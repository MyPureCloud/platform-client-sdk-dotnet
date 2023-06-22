---
title: WebChatApi
---
## PureCloudPlatform.Client.V2.Api.WebChatApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteWebchatDeployment**](WebChatApi.html#deletewebchatdeployment) | **DELETE** /api/v2/webchat/deployments/{deploymentId} | Delete a WebChat deployment |
| [**DeleteWebchatGuestConversationMember**](WebChatApi.html#deletewebchatguestconversationmember) | **DELETE** /api/v2/webchat/guest/conversations/{conversationId}/members/{memberId} | Remove a member from a chat conversation |
| [**DeleteWebchatSettings**](WebChatApi.html#deletewebchatsettings) | **DELETE** /api/v2/webchat/settings | Remove WebChat deployment settings |
| [**GetWebchatDeployment**](WebChatApi.html#getwebchatdeployment) | **GET** /api/v2/webchat/deployments/{deploymentId} | Get a WebChat deployment |
| [**GetWebchatDeployments**](WebChatApi.html#getwebchatdeployments) | **GET** /api/v2/webchat/deployments | List WebChat deployments |
| [**GetWebchatGuestConversationMediarequest**](WebChatApi.html#getwebchatguestconversationmediarequest) | **GET** /api/v2/webchat/guest/conversations/{conversationId}/mediarequests/{mediaRequestId} | Get a media request in the conversation |
| [**GetWebchatGuestConversationMediarequests**](WebChatApi.html#getwebchatguestconversationmediarequests) | **GET** /api/v2/webchat/guest/conversations/{conversationId}/mediarequests | Get all media requests to the guest in the conversation |
| [**GetWebchatGuestConversationMember**](WebChatApi.html#getwebchatguestconversationmember) | **GET** /api/v2/webchat/guest/conversations/{conversationId}/members/{memberId} | Get a web chat conversation member |
| [**GetWebchatGuestConversationMembers**](WebChatApi.html#getwebchatguestconversationmembers) | **GET** /api/v2/webchat/guest/conversations/{conversationId}/members | Get the members of a chat conversation. |
| [**GetWebchatGuestConversationMessage**](WebChatApi.html#getwebchatguestconversationmessage) | **GET** /api/v2/webchat/guest/conversations/{conversationId}/messages/{messageId} | Get a web chat conversation message |
| [**GetWebchatGuestConversationMessages**](WebChatApi.html#getwebchatguestconversationmessages) | **GET** /api/v2/webchat/guest/conversations/{conversationId}/messages | Get the messages of a chat conversation. |
| [**GetWebchatSettings**](WebChatApi.html#getwebchatsettings) | **GET** /api/v2/webchat/settings | Get WebChat deployment settings |
| [**PatchWebchatGuestConversationMediarequest**](WebChatApi.html#patchwebchatguestconversationmediarequest) | **PATCH** /api/v2/webchat/guest/conversations/{conversationId}/mediarequests/{mediaRequestId} | Update a media request in the conversation, setting the state to ACCEPTED/DECLINED/ERRORED |
| [**PostWebchatDeployments**](WebChatApi.html#postwebchatdeployments) | **POST** /api/v2/webchat/deployments | Create WebChat deployment |
| [**PostWebchatGuestConversationMemberMessages**](WebChatApi.html#postwebchatguestconversationmembermessages) | **POST** /api/v2/webchat/guest/conversations/{conversationId}/members/{memberId}/messages | Send a message in a chat conversation. |
| [**PostWebchatGuestConversationMemberTyping**](WebChatApi.html#postwebchatguestconversationmembertyping) | **POST** /api/v2/webchat/guest/conversations/{conversationId}/members/{memberId}/typing | Send a typing-indicator in a chat conversation. |
| [**PostWebchatGuestConversations**](WebChatApi.html#postwebchatguestconversations) | **POST** /api/v2/webchat/guest/conversations | Create an ACD chat conversation from an external customer. |
| [**PutWebchatDeployment**](WebChatApi.html#putwebchatdeployment) | **PUT** /api/v2/webchat/deployments/{deploymentId} | Update a WebChat deployment |
| [**PutWebchatSettings**](WebChatApi.html#putwebchatsettings) | **PUT** /api/v2/webchat/settings | Update WebChat deployment settings |
{: class="table table-striped"}

<a name="deletewebchatdeployment"></a>

## void DeleteWebchatDeployment (string deploymentId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletewebchatguestconversationmember"></a>

## void DeleteWebchatGuestConversationMember (string conversationId, string memberId)



Remove a member from a chat conversation

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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletewebchatsettings"></a>

## void DeleteWebchatSettings ()



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

<a name="getwebchatdeployment"></a>

## [**WebChatDeployment**](WebChatDeployment.html) GetWebchatDeployment (string deploymentId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

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
{: class="table table-striped"}

### Return type

[**WebChatDeployment**](WebChatDeployment.html)

<a name="getwebchatdeployments"></a>

## [**WebChatDeploymentEntityListing**](WebChatDeploymentEntityListing.html) GetWebchatDeployments ()

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

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

[**WebChatDeploymentEntityListing**](WebChatDeploymentEntityListing.html)

<a name="getwebchatguestconversationmediarequest"></a>

## [**WebChatGuestMediaRequest**](WebChatGuestMediaRequest.html) GetWebchatGuestConversationMediarequest (string conversationId, string mediaRequestId)



Get a media request in the conversation

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
{: class="table table-striped"}

### Return type

[**WebChatGuestMediaRequest**](WebChatGuestMediaRequest.html)

<a name="getwebchatguestconversationmediarequests"></a>

## [**WebChatGuestMediaRequestEntityList**](WebChatGuestMediaRequestEntityList.html) GetWebchatGuestConversationMediarequests (string conversationId)



Get all media requests to the guest in the conversation

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
{: class="table table-striped"}

### Return type

[**WebChatGuestMediaRequestEntityList**](WebChatGuestMediaRequestEntityList.html)

<a name="getwebchatguestconversationmember"></a>

## [**WebChatMemberInfo**](WebChatMemberInfo.html) GetWebchatGuestConversationMember (string conversationId, string memberId)



Get a web chat conversation member

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
{: class="table table-striped"}

### Return type

[**WebChatMemberInfo**](WebChatMemberInfo.html)

<a name="getwebchatguestconversationmembers"></a>

## [**WebChatMemberInfoEntityList**](WebChatMemberInfoEntityList.html) GetWebchatGuestConversationMembers (string conversationId, int? pageSize = null, int? pageNumber = null, bool? excludeDisconnectedMembers = null)



Get the members of a chat conversation.

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
{: class="table table-striped"}

### Return type

[**WebChatMemberInfoEntityList**](WebChatMemberInfoEntityList.html)

<a name="getwebchatguestconversationmessage"></a>

## [**WebChatMessage**](WebChatMessage.html) GetWebchatGuestConversationMessage (string conversationId, string messageId)



Get a web chat conversation message

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
{: class="table table-striped"}

### Return type

[**WebChatMessage**](WebChatMessage.html)

<a name="getwebchatguestconversationmessages"></a>

## [**WebChatMessageEntityList**](WebChatMessageEntityList.html) GetWebchatGuestConversationMessages (string conversationId, string after = null, string before = null, string sortOrder = null, int? maxResults = null)



Get the messages of a chat conversation.

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
{: class="table table-striped"}

### Return type

[**WebChatMessageEntityList**](WebChatMessageEntityList.html)

<a name="getwebchatsettings"></a>

## [**WebChatSettings**](WebChatSettings.html) GetWebchatSettings ()



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

[**WebChatSettings**](WebChatSettings.html)

<a name="patchwebchatguestconversationmediarequest"></a>

## [**WebChatGuestMediaRequest**](WebChatGuestMediaRequest.html) PatchWebchatGuestConversationMediarequest (string conversationId, string mediaRequestId, WebChatGuestMediaRequest body)



Update a media request in the conversation, setting the state to ACCEPTED/DECLINED/ERRORED

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
| **body** | [**WebChatGuestMediaRequest**](WebChatGuestMediaRequest.html)| Request |  |
{: class="table table-striped"}

### Return type

[**WebChatGuestMediaRequest**](WebChatGuestMediaRequest.html)

<a name="postwebchatdeployments"></a>

## [**WebChatDeployment**](WebChatDeployment.html) PostWebchatDeployments (WebChatDeployment body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

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
| **body** | [**WebChatDeployment**](WebChatDeployment.html)| Deployment |  |
{: class="table table-striped"}

### Return type

[**WebChatDeployment**](WebChatDeployment.html)

<a name="postwebchatguestconversationmembermessages"></a>

## [**WebChatMessage**](WebChatMessage.html) PostWebchatGuestConversationMemberMessages (string conversationId, string memberId, CreateWebChatMessageRequest body)



Send a message in a chat conversation.

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
| **body** | [**CreateWebChatMessageRequest**](CreateWebChatMessageRequest.html)| Message |  |
{: class="table table-striped"}

### Return type

[**WebChatMessage**](WebChatMessage.html)

<a name="postwebchatguestconversationmembertyping"></a>

## [**WebChatTyping**](WebChatTyping.html) PostWebchatGuestConversationMemberTyping (string conversationId, string memberId)



Send a typing-indicator in a chat conversation.

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
{: class="table table-striped"}

### Return type

[**WebChatTyping**](WebChatTyping.html)

<a name="postwebchatguestconversations"></a>

## [**CreateWebChatConversationResponse**](CreateWebChatConversationResponse.html) PostWebchatGuestConversations (CreateWebChatConversationRequest body)



Create an ACD chat conversation from an external customer.

This endpoint will create a new ACD Chat conversation under the specified Chat Deployment.  The conversation will begin with a guest member in it (with a role=CUSTOMER) according to the customer information that is supplied. If the guest member is authenticated, the 'memberAuthToken' field should include his JWT as generated by the 'POST /api/v2/signeddata' resource; if the guest member is anonymous (and the Deployment permits it) this field can be omitted.  The returned data includes the IDs of the conversation created, along with a newly-create JWT token that you can supply to all future endpoints as authentication to perform operations against that conversation. After successfully creating a conversation, you should connect a websocket to the event stream named in the 'eventStreamUri' field of the response; the conversation is not routed until the event stream is attached.

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
| **body** | [**CreateWebChatConversationRequest**](CreateWebChatConversationRequest.html)| CreateConversationRequest |  |
{: class="table table-striped"}

### Return type

[**CreateWebChatConversationResponse**](CreateWebChatConversationResponse.html)

<a name="putwebchatdeployment"></a>

## [**WebChatDeployment**](WebChatDeployment.html) PutWebchatDeployment (string deploymentId, WebChatDeployment body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

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
| **body** | [**WebChatDeployment**](WebChatDeployment.html)| Deployment |  |
{: class="table table-striped"}

### Return type

[**WebChatDeployment**](WebChatDeployment.html)

<a name="putwebchatsettings"></a>

## [**WebChatSettings**](WebChatSettings.html) PutWebchatSettings (WebChatSettings body)



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
| **body** | [**WebChatSettings**](WebChatSettings.html)| webChatSettings |  |
{: class="table table-striped"}

### Return type

[**WebChatSettings**](WebChatSettings.html)

