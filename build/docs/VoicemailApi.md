# VoicemailApi

## PureCloudPlatform.Client.V2.Api.VoicemailApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteVoicemailMessage**](#DeleteVoicemailMessage) | **Delete** /api/v2/voicemail/messages/{messageId} | Delete a voicemail message. |
| [**DeleteVoicemailMessages**](#DeleteVoicemailMessages) | **Delete** /api/v2/voicemail/messages | Delete all voicemail messages |
| [**GetVoicemailGroupMailbox**](#GetVoicemailGroupMailbox) | **Get** /api/v2/voicemail/groups/{groupId}/mailbox | Get the group&#39;s mailbox information |
| [**GetVoicemailGroupMessages**](#GetVoicemailGroupMessages) | **Get** /api/v2/voicemail/groups/{groupId}/messages | List voicemail messages |
| [**GetVoicemailGroupPolicy**](#GetVoicemailGroupPolicy) | **Get** /api/v2/voicemail/groups/{groupId}/policy | Get a group&#39;s voicemail policy |
| [**GetVoicemailMailbox**](#GetVoicemailMailbox) | **Get** /api/v2/voicemail/mailbox | Get the current user&#39;s mailbox information |
| [**GetVoicemailMeMailbox**](#GetVoicemailMeMailbox) | **Get** /api/v2/voicemail/me/mailbox | Get the current user&#39;s mailbox information |
| [**GetVoicemailMeMessages**](#GetVoicemailMeMessages) | **Get** /api/v2/voicemail/me/messages | List voicemail messages |
| [**GetVoicemailMePolicy**](#GetVoicemailMePolicy) | **Get** /api/v2/voicemail/me/policy | Get the current user&#39;s voicemail policy |
| [**GetVoicemailMessage**](#GetVoicemailMessage) | **Get** /api/v2/voicemail/messages/{messageId} | Get a voicemail message |
| [**GetVoicemailMessageMedia**](#GetVoicemailMessageMedia) | **Get** /api/v2/voicemail/messages/{messageId}/media | Get media playback URI for this voicemail message |
| [**GetVoicemailMessages**](#GetVoicemailMessages) | **Get** /api/v2/voicemail/messages | List voicemail messages |
| [**GetVoicemailPolicy**](#GetVoicemailPolicy) | **Get** /api/v2/voicemail/policy | Get a policy |
| [**GetVoicemailQueueMessages**](#GetVoicemailQueueMessages) | **Get** /api/v2/voicemail/queues/{queueId}/messages | List voicemail messages |
| [**GetVoicemailSearch**](#GetVoicemailSearch) | **Get** /api/v2/voicemail/search | Search voicemails using the q64 value returned from a previous search |
| [**GetVoicemailUserMailbox**](#GetVoicemailUserMailbox) | **Get** /api/v2/voicemail/users/{userId}/mailbox | Get a user&#39;s mailbox information |
| [**GetVoicemailUserMessages**](#GetVoicemailUserMessages) | **Get** /api/v2/voicemail/users/{userId}/messages | List voicemail messages |
| [**GetVoicemailUserpolicy**](#GetVoicemailUserpolicy) | **Get** /api/v2/voicemail/userpolicies/{userId} | Get a user&#39;s voicemail policy |
| [**PatchVoicemailGroupPolicy**](#PatchVoicemailGroupPolicy) | **Patch** /api/v2/voicemail/groups/{groupId}/policy | Update a group&#39;s voicemail policy |
| [**PatchVoicemailMePolicy**](#PatchVoicemailMePolicy) | **Patch** /api/v2/voicemail/me/policy | Update the current user&#39;s voicemail policy |
| [**PatchVoicemailMessage**](#PatchVoicemailMessage) | **Patch** /api/v2/voicemail/messages/{messageId} | Update a voicemail message |
| [**PatchVoicemailUserpolicy**](#PatchVoicemailUserpolicy) | **Patch** /api/v2/voicemail/userpolicies/{userId} | Update a user&#39;s voicemail policy |
| [**PostVoicemailMessages**](#PostVoicemailMessages) | **Post** /api/v2/voicemail/messages | Copy a voicemail message to a user or group |
| [**PostVoicemailSearch**](#PostVoicemailSearch) | **Post** /api/v2/voicemail/search | Search voicemails |
| [**PutVoicemailMessage**](#PutVoicemailMessage) | **Put** /api/v2/voicemail/messages/{messageId} | Update a voicemail message |
| [**PutVoicemailPolicy**](#PutVoicemailPolicy) | **Put** /api/v2/voicemail/policy | Update a policy |
| [**PutVoicemailUserpolicy**](#PutVoicemailUserpolicy) | **Put** /api/v2/voicemail/userpolicies/{userId} | Update a user&#39;s voicemail policy |



## DeleteVoicemailMessage

> void DeleteVoicemailMessage (string messageId)


Delete a voicemail message.

A user voicemail can only be deleted by its associated user. A group voicemail can only be deleted by a user that is a member of the group. A queue voicemail can only be deleted by a user with the acd voicemail delete permission.

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
    public class DeleteVoicemailMessageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VoicemailApi();
            var messageId = messageId_example;  // string | Message ID

            try
            { 
                // Delete a voicemail message.
                apiInstance.DeleteVoicemailMessage(messageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.DeleteVoicemailMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messageId** | **string**| Message ID |  |

### Return type

void (empty response body)


## DeleteVoicemailMessages

> void DeleteVoicemailMessages ()


Delete all voicemail messages

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
    public class DeleteVoicemailMessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VoicemailApi();

            try
            { 
                // Delete all voicemail messages
                apiInstance.DeleteVoicemailMessages();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.DeleteVoicemailMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

void (empty response body)


## GetVoicemailGroupMailbox

> [**VoicemailMailboxInfo**](VoicemailMailboxInfo) GetVoicemailGroupMailbox (string groupId)


Get the group's mailbox information

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
    public class GetVoicemailGroupMailboxExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VoicemailApi();
            var groupId = groupId_example;  // string | groupId

            try
            { 
                // Get the group's mailbox information
                VoicemailMailboxInfo result = apiInstance.GetVoicemailGroupMailbox(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetVoicemailGroupMailbox: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| groupId |  |

### Return type

[**VoicemailMailboxInfo**](VoicemailMailboxInfo)


## GetVoicemailGroupMessages

> [**VoicemailMessageEntityListing**](VoicemailMessageEntityListing) GetVoicemailGroupMessages (string groupId, int? pageSize = null, int? pageNumber = null)


List voicemail messages

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
    public class GetVoicemailGroupMessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VoicemailApi();
            var groupId = groupId_example;  // string | Group ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // List voicemail messages
                VoicemailMessageEntityListing result = apiInstance.GetVoicemailGroupMessages(groupId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetVoicemailGroupMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |

### Return type

[**VoicemailMessageEntityListing**](VoicemailMessageEntityListing)


## GetVoicemailGroupPolicy

> [**VoicemailGroupPolicy**](VoicemailGroupPolicy) GetVoicemailGroupPolicy (string groupId)


Get a group's voicemail policy

Requires ANY permissions: 

* directory:group:add
* directory:group:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetVoicemailGroupPolicyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VoicemailApi();
            var groupId = groupId_example;  // string | Group ID

            try
            { 
                // Get a group's voicemail policy
                VoicemailGroupPolicy result = apiInstance.GetVoicemailGroupPolicy(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetVoicemailGroupPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |

### Return type

[**VoicemailGroupPolicy**](VoicemailGroupPolicy)


## GetVoicemailMailbox

> [**VoicemailMailboxInfo**](VoicemailMailboxInfo) GetVoicemailMailbox ()


Get the current user's mailbox information

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
    public class GetVoicemailMailboxExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VoicemailApi();

            try
            { 
                // Get the current user's mailbox information
                VoicemailMailboxInfo result = apiInstance.GetVoicemailMailbox();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetVoicemailMailbox: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**VoicemailMailboxInfo**](VoicemailMailboxInfo)


## GetVoicemailMeMailbox

> [**VoicemailMailboxInfo**](VoicemailMailboxInfo) GetVoicemailMeMailbox ()


Get the current user's mailbox information

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
    public class GetVoicemailMeMailboxExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VoicemailApi();

            try
            { 
                // Get the current user's mailbox information
                VoicemailMailboxInfo result = apiInstance.GetVoicemailMeMailbox();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetVoicemailMeMailbox: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**VoicemailMailboxInfo**](VoicemailMailboxInfo)


## GetVoicemailMeMessages

> [**VoicemailMessageEntityListing**](VoicemailMessageEntityListing) GetVoicemailMeMessages (int? pageSize = null, int? pageNumber = null)


List voicemail messages

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
    public class GetVoicemailMeMessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VoicemailApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // List voicemail messages
                VoicemailMessageEntityListing result = apiInstance.GetVoicemailMeMessages(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetVoicemailMeMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |

### Return type

[**VoicemailMessageEntityListing**](VoicemailMessageEntityListing)


## GetVoicemailMePolicy

> [**VoicemailUserPolicy**](VoicemailUserPolicy) GetVoicemailMePolicy ()


Get the current user's voicemail policy

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
    public class GetVoicemailMePolicyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VoicemailApi();

            try
            { 
                // Get the current user's voicemail policy
                VoicemailUserPolicy result = apiInstance.GetVoicemailMePolicy();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetVoicemailMePolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**VoicemailUserPolicy**](VoicemailUserPolicy)


## GetVoicemailMessage

> [**VoicemailMessage**](VoicemailMessage) GetVoicemailMessage (string messageId, List<string> expand = null)


Get a voicemail message

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
    public class GetVoicemailMessageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VoicemailApi();
            var messageId = messageId_example;  // string | Message ID
            var expand = new List<string>(); // List<string> | If the caller is a known user, which fields, if any, to expand (optional) 

            try
            { 
                // Get a voicemail message
                VoicemailMessage result = apiInstance.GetVoicemailMessage(messageId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetVoicemailMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messageId** | **string**| Message ID |  |
| **expand** | [**List<string>**](string)| If the caller is a known user, which fields, if any, to expand | [optional] <br />**Values**: callerUser.routingStatus, callerUser.primaryPresence, callerUser.conversationSummary, callerUser.outOfOffice, callerUser.geolocation, conversations, transcription |

### Return type

[**VoicemailMessage**](VoicemailMessage)


## GetVoicemailMessageMedia

> [**VoicemailMediaInfo**](VoicemailMediaInfo) GetVoicemailMessageMedia (string messageId, string formatId = null)


Get media playback URI for this voicemail message

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
    public class GetVoicemailMessageMediaExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VoicemailApi();
            var messageId = messageId_example;  // string | Message ID
            var formatId = formatId_example;  // string | The desired media format. (optional)  (default to WEBM)

            try
            { 
                // Get media playback URI for this voicemail message
                VoicemailMediaInfo result = apiInstance.GetVoicemailMessageMedia(messageId, formatId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetVoicemailMessageMedia: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messageId** | **string**| Message ID |  |
| **formatId** | **string**| The desired media format. | [optional] [default to WEBM]<br />**Values**: WAV, WEBM, WAV_ULAW, OGG_VORBIS, OGG_OPUS, MP3, NONE |

### Return type

[**VoicemailMediaInfo**](VoicemailMediaInfo)


## GetVoicemailMessages

> [**VoicemailMessageEntityListing**](VoicemailMessageEntityListing) GetVoicemailMessages (string ids = null, List<string> expand = null)


List voicemail messages

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
    public class GetVoicemailMessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VoicemailApi();
            var ids = ids_example;  // string | An optional comma separated list of VoicemailMessage ids (optional) 
            var expand = new List<string>(); // List<string> | If the caller is a known user, which fields, if any, to expand (optional) 

            try
            { 
                // List voicemail messages
                VoicemailMessageEntityListing result = apiInstance.GetVoicemailMessages(ids, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetVoicemailMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ids** | **string**| An optional comma separated list of VoicemailMessage ids | [optional]  |
| **expand** | [**List<string>**](string)| If the caller is a known user, which fields, if any, to expand | [optional] <br />**Values**: callerUser.routingStatus, callerUser.primaryPresence, callerUser.conversationSummary, callerUser.outOfOffice, callerUser.geolocation, conversations, transcription |

### Return type

[**VoicemailMessageEntityListing**](VoicemailMessageEntityListing)


## GetVoicemailPolicy

> [**VoicemailOrganizationPolicy**](VoicemailOrganizationPolicy) GetVoicemailPolicy ()


Get a policy

Requires ALL permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetVoicemailPolicyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VoicemailApi();

            try
            { 
                // Get a policy
                VoicemailOrganizationPolicy result = apiInstance.GetVoicemailPolicy();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetVoicemailPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**VoicemailOrganizationPolicy**](VoicemailOrganizationPolicy)


## GetVoicemailQueueMessages

> [**VoicemailMessageEntityListing**](VoicemailMessageEntityListing) GetVoicemailQueueMessages (string queueId, int? pageSize = null, int? pageNumber = null)


List voicemail messages

Requires ANY permissions: 

* voicemail:acdvoicemail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetVoicemailQueueMessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VoicemailApi();
            var queueId = queueId_example;  // string | Queue ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // List voicemail messages
                VoicemailMessageEntityListing result = apiInstance.GetVoicemailQueueMessages(queueId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetVoicemailQueueMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |

### Return type

[**VoicemailMessageEntityListing**](VoicemailMessageEntityListing)


## GetVoicemailSearch

> [**VoicemailsSearchResponse**](VoicemailsSearchResponse) GetVoicemailSearch (string q64, List<string> expand = null)


Search voicemails using the q64 value returned from a previous search

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
    public class GetVoicemailSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VoicemailApi();
            var q64 = q64_example;  // string | q64
            var expand = new List<string>(); // List<string> | expand (optional) 

            try
            { 
                // Search voicemails using the q64 value returned from a previous search
                VoicemailsSearchResponse result = apiInstance.GetVoicemailSearch(q64, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetVoicemailSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **q64** | **string**| q64 |  |
| **expand** | [**List<string>**](string)| expand | [optional]  |

### Return type

[**VoicemailsSearchResponse**](VoicemailsSearchResponse)


## GetVoicemailUserMailbox

> [**VoicemailMailboxInfo**](VoicemailMailboxInfo) GetVoicemailUserMailbox (string userId)


Get a user's mailbox information

Requires ANY permissions: 

* voicemail:mailbox:viewOther

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetVoicemailUserMailboxExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VoicemailApi();
            var userId = userId_example;  // string | userId

            try
            { 
                // Get a user's mailbox information
                VoicemailMailboxInfo result = apiInstance.GetVoicemailUserMailbox(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetVoicemailUserMailbox: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| userId |  |

### Return type

[**VoicemailMailboxInfo**](VoicemailMailboxInfo)


## GetVoicemailUserMessages

> [**VoicemailMessageEntityListing**](VoicemailMessageEntityListing) GetVoicemailUserMessages (string userId, int? pageSize = null, int? pageNumber = null)


List voicemail messages

Requires ANY permissions: 

* voicemail:voicemail:viewOther

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetVoicemailUserMessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VoicemailApi();
            var userId = userId_example;  // string | User ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // List voicemail messages
                VoicemailMessageEntityListing result = apiInstance.GetVoicemailUserMessages(userId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetVoicemailUserMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |

### Return type

[**VoicemailMessageEntityListing**](VoicemailMessageEntityListing)


## GetVoicemailUserpolicy

> [**VoicemailUserPolicy**](VoicemailUserPolicy) GetVoicemailUserpolicy (string userId)


Get a user's voicemail policy

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
    public class GetVoicemailUserpolicyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VoicemailApi();
            var userId = userId_example;  // string | User ID

            try
            { 
                // Get a user's voicemail policy
                VoicemailUserPolicy result = apiInstance.GetVoicemailUserpolicy(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetVoicemailUserpolicy: " + e.Message );
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

[**VoicemailUserPolicy**](VoicemailUserPolicy)


## PatchVoicemailGroupPolicy

> [**VoicemailGroupPolicy**](VoicemailGroupPolicy) PatchVoicemailGroupPolicy (string groupId, VoicemailGroupPolicy body)


Update a group's voicemail policy

Requires ANY permissions: 

* directory:group:add
* directory:group:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchVoicemailGroupPolicyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VoicemailApi();
            var groupId = groupId_example;  // string | Group ID
            var body = new VoicemailGroupPolicy(); // VoicemailGroupPolicy | The group's voicemail policy

            try
            { 
                // Update a group's voicemail policy
                VoicemailGroupPolicy result = apiInstance.PatchVoicemailGroupPolicy(groupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.PatchVoicemailGroupPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
| **body** | [**VoicemailGroupPolicy**](VoicemailGroupPolicy)| The group&#39;s voicemail policy |  |

### Return type

[**VoicemailGroupPolicy**](VoicemailGroupPolicy)


## PatchVoicemailMePolicy

> [**VoicemailUserPolicy**](VoicemailUserPolicy) PatchVoicemailMePolicy (VoicemailUserPolicy body)


Update the current user's voicemail policy

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
    public class PatchVoicemailMePolicyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VoicemailApi();
            var body = new VoicemailUserPolicy(); // VoicemailUserPolicy | The user's voicemail policy

            try
            { 
                // Update the current user's voicemail policy
                VoicemailUserPolicy result = apiInstance.PatchVoicemailMePolicy(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.PatchVoicemailMePolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**VoicemailUserPolicy**](VoicemailUserPolicy)| The user&#39;s voicemail policy |  |

### Return type

[**VoicemailUserPolicy**](VoicemailUserPolicy)


## PatchVoicemailMessage

> [**VoicemailMessage**](VoicemailMessage) PatchVoicemailMessage (string messageId, VoicemailMessage body)


Update a voicemail message

A user voicemail can only be modified by its associated user. A group voicemail can only be modified by a user that is a member of the group. A queue voicemail can only be modified by a participant of the conversation the voicemail is associated with.

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
    public class PatchVoicemailMessageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VoicemailApi();
            var messageId = messageId_example;  // string | Message ID
            var body = new VoicemailMessage(); // VoicemailMessage | VoicemailMessage

            try
            { 
                // Update a voicemail message
                VoicemailMessage result = apiInstance.PatchVoicemailMessage(messageId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.PatchVoicemailMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messageId** | **string**| Message ID |  |
| **body** | [**VoicemailMessage**](VoicemailMessage)| VoicemailMessage |  |

### Return type

[**VoicemailMessage**](VoicemailMessage)


## PatchVoicemailUserpolicy

> [**VoicemailUserPolicy**](VoicemailUserPolicy) PatchVoicemailUserpolicy (string userId, VoicemailUserPolicy body)


Update a user's voicemail policy

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
    public class PatchVoicemailUserpolicyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VoicemailApi();
            var userId = userId_example;  // string | User ID
            var body = new VoicemailUserPolicy(); // VoicemailUserPolicy | The user's voicemail policy

            try
            { 
                // Update a user's voicemail policy
                VoicemailUserPolicy result = apiInstance.PatchVoicemailUserpolicy(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.PatchVoicemailUserpolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**VoicemailUserPolicy**](VoicemailUserPolicy)| The user&#39;s voicemail policy |  |

### Return type

[**VoicemailUserPolicy**](VoicemailUserPolicy)


## PostVoicemailMessages

> [**VoicemailMessage**](VoicemailMessage) PostVoicemailMessages (CopyVoicemailMessage body = null)


Copy a voicemail message to a user or group

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
    public class PostVoicemailMessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VoicemailApi();
            var body = new CopyVoicemailMessage(); // CopyVoicemailMessage |  (optional) 

            try
            { 
                // Copy a voicemail message to a user or group
                VoicemailMessage result = apiInstance.PostVoicemailMessages(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.PostVoicemailMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CopyVoicemailMessage**](CopyVoicemailMessage)|  | [optional]  |

### Return type

[**VoicemailMessage**](VoicemailMessage)


## PostVoicemailSearch

> [**VoicemailsSearchResponse**](VoicemailsSearchResponse) PostVoicemailSearch (VoicemailSearchRequest body)


Search voicemails

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
    public class PostVoicemailSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VoicemailApi();
            var body = new VoicemailSearchRequest(); // VoicemailSearchRequest | Search request options

            try
            { 
                // Search voicemails
                VoicemailsSearchResponse result = apiInstance.PostVoicemailSearch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.PostVoicemailSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**VoicemailSearchRequest**](VoicemailSearchRequest)| Search request options |  |

### Return type

[**VoicemailsSearchResponse**](VoicemailsSearchResponse)


## PutVoicemailMessage

> [**VoicemailMessage**](VoicemailMessage) PutVoicemailMessage (string messageId, VoicemailMessage body)


Update a voicemail message

A user voicemail can only be modified by its associated user. A group voicemail can only be modified by a user that is a member of the group. A queue voicemail can only be modified by a participant of the conversation the voicemail is associated with.

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
    public class PutVoicemailMessageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VoicemailApi();
            var messageId = messageId_example;  // string | Message ID
            var body = new VoicemailMessage(); // VoicemailMessage | VoicemailMessage

            try
            { 
                // Update a voicemail message
                VoicemailMessage result = apiInstance.PutVoicemailMessage(messageId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.PutVoicemailMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messageId** | **string**| Message ID |  |
| **body** | [**VoicemailMessage**](VoicemailMessage)| VoicemailMessage |  |

### Return type

[**VoicemailMessage**](VoicemailMessage)


## PutVoicemailPolicy

> [**VoicemailOrganizationPolicy**](VoicemailOrganizationPolicy) PutVoicemailPolicy (VoicemailOrganizationPolicy body)


Update a policy

Requires ALL permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutVoicemailPolicyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VoicemailApi();
            var body = new VoicemailOrganizationPolicy(); // VoicemailOrganizationPolicy | Policy

            try
            { 
                // Update a policy
                VoicemailOrganizationPolicy result = apiInstance.PutVoicemailPolicy(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.PutVoicemailPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**VoicemailOrganizationPolicy**](VoicemailOrganizationPolicy)| Policy |  |

### Return type

[**VoicemailOrganizationPolicy**](VoicemailOrganizationPolicy)


## PutVoicemailUserpolicy

> [**VoicemailUserPolicy**](VoicemailUserPolicy) PutVoicemailUserpolicy (string userId, VoicemailUserPolicy body)


Update a user's voicemail policy

Requires ALL permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutVoicemailUserpolicyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new VoicemailApi();
            var userId = userId_example;  // string | User ID
            var body = new VoicemailUserPolicy(); // VoicemailUserPolicy | The user's voicemail policy

            try
            { 
                // Update a user's voicemail policy
                VoicemailUserPolicy result = apiInstance.PutVoicemailUserpolicy(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.PutVoicemailUserpolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**VoicemailUserPolicy**](VoicemailUserPolicy)| The user&#39;s voicemail policy |  |

### Return type

[**VoicemailUserPolicy**](VoicemailUserPolicy)


_PureCloudPlatform.Client.V2 223.0.0_
