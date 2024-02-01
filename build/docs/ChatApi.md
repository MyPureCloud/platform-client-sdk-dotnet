---
title: ChatApi
---
## PureCloudPlatform.Client.V2.Api.ChatApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteChatsRoomMessage**](ChatApi.html#deletechatsroommessage) | **Delete** /api/v2/chats/rooms/{roomJid}/messages/{messageId} | Delete a message in a room |
| [**DeleteChatsRoomParticipant**](ChatApi.html#deletechatsroomparticipant) | **Delete** /api/v2/chats/rooms/{roomJid}/participants/{userId} | Remove a user from a room. |
| [**DeleteChatsRoomPinnedmessage**](ChatApi.html#deletechatsroompinnedmessage) | **Delete** /api/v2/chats/rooms/{roomJid}/pinnedmessages/{pinnedMessageId} | Remove a pinned message from a room |
| [**DeleteChatsUserMessage**](ChatApi.html#deletechatsusermessage) | **Delete** /api/v2/chats/users/{userId}/messages/{messageId} | Delete a message to a user |
| [**GetChatsMessage**](ChatApi.html#getchatsmessage) | **Get** /api/v2/chats/messages/{messageId} | Get a message |
| [**GetChatsRoom**](ChatApi.html#getchatsroom) | **Get** /api/v2/chats/rooms/{roomJid} | Get a room |
| [**GetChatsRoomMessage**](ChatApi.html#getchatsroommessage) | **Get** /api/v2/chats/rooms/{roomJid}/messages/{messageIds} | Get messages by id(s) from a room |
| [**GetChatsRoomMessages**](ChatApi.html#getchatsroommessages) | **Get** /api/v2/chats/rooms/{roomJid}/messages | Get a room&#39;s message history |
| [**GetChatsSettings**](ChatApi.html#getchatssettings) | **Get** /api/v2/chats/settings | Get Chat Settings. |
| [**GetChatsThreadMessages**](ChatApi.html#getchatsthreadmessages) | **Get** /api/v2/chats/threads/{threadId}/messages | Get history by thread |
| [**GetChatsUserMessage**](ChatApi.html#getchatsusermessage) | **Get** /api/v2/chats/users/{userId}/messages/{messageIds} | Get messages by id(s) from a 1on1 |
| [**GetChatsUserMessages**](ChatApi.html#getchatsusermessages) | **Get** /api/v2/chats/users/{userId}/messages | Get 1on1 History between a user |
| [**GetChatsUserSettings**](ChatApi.html#getchatsusersettings) | **Get** /api/v2/chats/users/{userId}/settings | Get a user&#39;s chat settings |
| [**PatchChatsRoom**](ChatApi.html#patchchatsroom) | **Patch** /api/v2/chats/rooms/{roomJid} | Set properties for a room |
| [**PatchChatsRoomMessage**](ChatApi.html#patchchatsroommessage) | **Patch** /api/v2/chats/rooms/{roomJid}/messages/{messageId} | Edit a message in a room |
| [**PatchChatsSettings**](ChatApi.html#patchchatssettings) | **Patch** /api/v2/chats/settings | Patch Chat Settings. |
| [**PatchChatsUserMessage**](ChatApi.html#patchchatsusermessage) | **Patch** /api/v2/chats/users/{userId}/messages/{messageId} | Edit a message to a user |
| [**PatchChatsUserSettings**](ChatApi.html#patchchatsusersettings) | **Patch** /api/v2/chats/users/{userId}/settings | Update a user&#39;s chat settings |
| [**PostChatsRoomMessages**](ChatApi.html#postchatsroommessages) | **Post** /api/v2/chats/rooms/{roomJid}/messages | Send a message to a room |
| [**PostChatsRoomParticipant**](ChatApi.html#postchatsroomparticipant) | **Post** /api/v2/chats/rooms/{roomJid}/participants/{userId} | Join a room |
| [**PostChatsRoomPinnedmessages**](ChatApi.html#postchatsroompinnedmessages) | **Post** /api/v2/chats/rooms/{roomJid}/pinnedmessages | Add pinned messages for a room, up to a maximum of 5 pinned messages |
| [**PostChatsRooms**](ChatApi.html#postchatsrooms) | **Post** /api/v2/chats/rooms | Create an adhoc room |
| [**PostChatsUserMessages**](ChatApi.html#postchatsusermessages) | **Post** /api/v2/chats/users/{userId}/messages | Send a message to a user |
| [**PutChatsSettings**](ChatApi.html#putchatssettings) | **Put** /api/v2/chats/settings | Update Chat Settings. |
{: class="table table-striped"}

<a name="deletechatsroommessage"></a>

## void DeleteChatsRoomMessage (string roomJid, string messageId)



Delete a message in a room

DeleteChatsRoomMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* chat:chat:access
* chat:roomMessage:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteChatsRoomMessageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ChatApi();
            var roomJid = roomJid_example;  // string | roomId
            var messageId = messageId_example;  // string | messageId

            try
            { 
                // Delete a message in a room
                apiInstance.DeleteChatsRoomMessage(roomJid, messageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.DeleteChatsRoomMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roomJid** | **string**| roomId |  |
| **messageId** | **string**| messageId |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletechatsroomparticipant"></a>

## void DeleteChatsRoomParticipant (string roomJid, string userId)



Remove a user from a room.

DeleteChatsRoomParticipant is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* chat:chat:access
* chat:participant:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteChatsRoomParticipantExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ChatApi();
            var roomJid = roomJid_example;  // string | roomJid
            var userId = userId_example;  // string | userId

            try
            { 
                // Remove a user from a room.
                apiInstance.DeleteChatsRoomParticipant(roomJid, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.DeleteChatsRoomParticipant: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roomJid** | **string**| roomJid |  |
| **userId** | **string**| userId |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletechatsroompinnedmessage"></a>

## void DeleteChatsRoomPinnedmessage (string roomJid, string pinnedMessageId)



Remove a pinned message from a room

DeleteChatsRoomPinnedmessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* chat:chat:access
* chat:room:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteChatsRoomPinnedmessageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ChatApi();
            var roomJid = roomJid_example;  // string | roomJid
            var pinnedMessageId = pinnedMessageId_example;  // string | pinnedMessageId

            try
            { 
                // Remove a pinned message from a room
                apiInstance.DeleteChatsRoomPinnedmessage(roomJid, pinnedMessageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.DeleteChatsRoomPinnedmessage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roomJid** | **string**| roomJid |  |
| **pinnedMessageId** | **string**| pinnedMessageId |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletechatsusermessage"></a>

## void DeleteChatsUserMessage (string userId, string messageId)



Delete a message to a user

DeleteChatsUserMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* chat:chat:access
* chat:1on1Message:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteChatsUserMessageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ChatApi();
            var userId = userId_example;  // string | userId
            var messageId = messageId_example;  // string | messageId

            try
            { 
                // Delete a message to a user
                apiInstance.DeleteChatsUserMessage(userId, messageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.DeleteChatsUserMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| userId |  |
| **messageId** | **string**| messageId |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getchatsmessage"></a>

## [**ChatMessageResponse**](ChatMessageResponse.html) GetChatsMessage (string messageId)



Get a message

GetChatsMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* chat:chat:access
* chat:1on1Message:view
* chat:room:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetChatsMessageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ChatApi();
            var messageId = messageId_example;  // string | messageId

            try
            { 
                // Get a message
                ChatMessageResponse result = apiInstance.GetChatsMessage(messageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.GetChatsMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messageId** | **string**| messageId |  |
{: class="table table-striped"}

### Return type

[**ChatMessageResponse**](ChatMessageResponse.html)

<a name="getchatsroom"></a>

## [**Room**](Room.html) GetChatsRoom (string roomJid)



Get a room

GetChatsRoom is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* chat:chat:access
* chat:room:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetChatsRoomExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ChatApi();
            var roomJid = roomJid_example;  // string | roomJid

            try
            { 
                // Get a room
                Room result = apiInstance.GetChatsRoom(roomJid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.GetChatsRoom: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roomJid** | **string**| roomJid |  |
{: class="table table-striped"}

### Return type

[**Room**](Room.html)

<a name="getchatsroommessage"></a>

## [**ChatMessageEntityListing**](ChatMessageEntityListing.html) GetChatsRoomMessage (string roomJid, string messageIds)



Get messages by id(s) from a room

GetChatsRoomMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* chat:chat:access
* chat:room:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetChatsRoomMessageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ChatApi();
            var roomJid = roomJid_example;  // string | roomJid
            var messageIds = messageIds_example;  // string | messageIds, comma separated

            try
            { 
                // Get messages by id(s) from a room
                ChatMessageEntityListing result = apiInstance.GetChatsRoomMessage(roomJid, messageIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.GetChatsRoomMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roomJid** | **string**| roomJid |  |
| **messageIds** | **string**| messageIds, comma separated |  |
{: class="table table-striped"}

### Return type

[**ChatMessageEntityListing**](ChatMessageEntityListing.html)

<a name="getchatsroommessages"></a>

## [**ChatMessageEntityListing**](ChatMessageEntityListing.html) GetChatsRoomMessages (string roomJid, string limit = null, string before = null, string after = null)



Get a room's message history

GetChatsRoomMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* chat:chat:access
* chat:room:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetChatsRoomMessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ChatApi();
            var roomJid = roomJid_example;  // string | roomJid
            var limit = limit_example;  // string | The maximum number of messages to retrieve (optional) 
            var before = before_example;  // string | The cutoff date for messages to retrieve (optional) 
            var after = after_example;  // string | The beginning date for messages to retrieve (optional) 

            try
            { 
                // Get a room's message history
                ChatMessageEntityListing result = apiInstance.GetChatsRoomMessages(roomJid, limit, before, after);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.GetChatsRoomMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roomJid** | **string**| roomJid |  |
| **limit** | **string**| The maximum number of messages to retrieve | [optional]  |
| **before** | **string**| The cutoff date for messages to retrieve | [optional]  |
| **after** | **string**| The beginning date for messages to retrieve | [optional]  |
{: class="table table-striped"}

### Return type

[**ChatMessageEntityListing**](ChatMessageEntityListing.html)

<a name="getchatssettings"></a>

## [**ChatSettings**](ChatSettings.html) GetChatsSettings ()



Get Chat Settings.

Requires ANY permissions: 

* chat:setting:view
* chat:setting:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetChatsSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ChatApi();

            try
            { 
                // Get Chat Settings.
                ChatSettings result = apiInstance.GetChatsSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.GetChatsSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**ChatSettings**](ChatSettings.html)

<a name="getchatsthreadmessages"></a>

## [**ChatMessageEntityListing**](ChatMessageEntityListing.html) GetChatsThreadMessages (string threadId, string limit = null, string before = null, string after = null)



Get history by thread

GetChatsThreadMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* chat:chat:access
* chat:room:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetChatsThreadMessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ChatApi();
            var threadId = threadId_example;  // string | threadId
            var limit = limit_example;  // string | The maximum number of messages to retrieve (optional) 
            var before = before_example;  // string | The cutoff date for messages to retrieve (optional) 
            var after = after_example;  // string | The beginning date for messages to retrieve (optional) 

            try
            { 
                // Get history by thread
                ChatMessageEntityListing result = apiInstance.GetChatsThreadMessages(threadId, limit, before, after);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.GetChatsThreadMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **threadId** | **string**| threadId |  |
| **limit** | **string**| The maximum number of messages to retrieve | [optional]  |
| **before** | **string**| The cutoff date for messages to retrieve | [optional]  |
| **after** | **string**| The beginning date for messages to retrieve | [optional]  |
{: class="table table-striped"}

### Return type

[**ChatMessageEntityListing**](ChatMessageEntityListing.html)

<a name="getchatsusermessage"></a>

## [**ChatMessageEntityListing**](ChatMessageEntityListing.html) GetChatsUserMessage (string userId, string messageIds)



Get messages by id(s) from a 1on1

GetChatsUserMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* chat:chat:access
* chat:1on1Message:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetChatsUserMessageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ChatApi();
            var userId = userId_example;  // string | userId
            var messageIds = messageIds_example;  // string | messageIds, comma separated

            try
            { 
                // Get messages by id(s) from a 1on1
                ChatMessageEntityListing result = apiInstance.GetChatsUserMessage(userId, messageIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.GetChatsUserMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| userId |  |
| **messageIds** | **string**| messageIds, comma separated |  |
{: class="table table-striped"}

### Return type

[**ChatMessageEntityListing**](ChatMessageEntityListing.html)

<a name="getchatsusermessages"></a>

## [**ChatMessageResponse**](ChatMessageResponse.html) GetChatsUserMessages (string userId, string limit = null, string before = null, string after = null)



Get 1on1 History between a user

GetChatsUserMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* chat:chat:access
* chat:1on1Message:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetChatsUserMessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ChatApi();
            var userId = userId_example;  // string | userId
            var limit = limit_example;  // string | The maximum number of messages to retrieve (optional) 
            var before = before_example;  // string | The cutoff date for messages to retrieve (optional) 
            var after = after_example;  // string | The beginning date for messages to retrieve (optional) 

            try
            { 
                // Get 1on1 History between a user
                ChatMessageResponse result = apiInstance.GetChatsUserMessages(userId, limit, before, after);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.GetChatsUserMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| userId |  |
| **limit** | **string**| The maximum number of messages to retrieve | [optional]  |
| **before** | **string**| The cutoff date for messages to retrieve | [optional]  |
| **after** | **string**| The beginning date for messages to retrieve | [optional]  |
{: class="table table-striped"}

### Return type

[**ChatMessageResponse**](ChatMessageResponse.html)

<a name="getchatsusersettings"></a>

## [**ChatUserSettings**](ChatUserSettings.html) GetChatsUserSettings (string userId)



Get a user's chat settings

GetChatsUserSettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* chat:usersettings:view
* chat:setting:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetChatsUserSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ChatApi();
            var userId = userId_example;  // string | User ID

            try
            { 
                // Get a user's chat settings
                ChatUserSettings result = apiInstance.GetChatsUserSettings(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.GetChatsUserSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
{: class="table table-striped"}

### Return type

[**ChatUserSettings**](ChatUserSettings.html)

<a name="patchchatsroom"></a>

## void PatchChatsRoom (string roomJid, RoomUpdateRequest body)



Set properties for a room

PatchChatsRoom is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* chat:chat:access
* chat:room:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchChatsRoomExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ChatApi();
            var roomJid = roomJid_example;  // string | roomJid
            var body = new RoomUpdateRequest(); // RoomUpdateRequest | Room properties

            try
            { 
                // Set properties for a room
                apiInstance.PatchChatsRoom(roomJid, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.PatchChatsRoom: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roomJid** | **string**| roomJid |  |
| **body** | [**RoomUpdateRequest**](RoomUpdateRequest.html)| Room properties |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchchatsroommessage"></a>

## [**ChatSendMessageResponse**](ChatSendMessageResponse.html) PatchChatsRoomMessage (string roomJid, string messageId, SendMessageBody body)



Edit a message in a room

PatchChatsRoomMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* chat:chat:access
* chat:roomMessage:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchChatsRoomMessageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ChatApi();
            var roomJid = roomJid_example;  // string | roomId
            var messageId = messageId_example;  // string | messageId
            var body = new SendMessageBody(); // SendMessageBody | messageBody

            try
            { 
                // Edit a message in a room
                ChatSendMessageResponse result = apiInstance.PatchChatsRoomMessage(roomJid, messageId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.PatchChatsRoomMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roomJid** | **string**| roomId |  |
| **messageId** | **string**| messageId |  |
| **body** | [**SendMessageBody**](SendMessageBody.html)| messageBody |  |
{: class="table table-striped"}

### Return type

[**ChatSendMessageResponse**](ChatSendMessageResponse.html)

<a name="patchchatssettings"></a>

## [**ChatSettings**](ChatSettings.html) PatchChatsSettings (ChatSettings body)



Patch Chat Settings.

Requires ANY permissions: 

* chat:setting:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchChatsSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ChatApi();
            var body = new ChatSettings(); // ChatSettings | Chat

            try
            { 
                // Patch Chat Settings.
                ChatSettings result = apiInstance.PatchChatsSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.PatchChatsSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ChatSettings**](ChatSettings.html)| Chat |  |
{: class="table table-striped"}

### Return type

[**ChatSettings**](ChatSettings.html)

<a name="patchchatsusermessage"></a>

## [**ChatSendMessageResponse**](ChatSendMessageResponse.html) PatchChatsUserMessage (string userId, string messageId, SendMessageBody body)



Edit a message to a user

PatchChatsUserMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* chat:chat:access
* chat:1on1Message:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchChatsUserMessageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ChatApi();
            var userId = userId_example;  // string | userId
            var messageId = messageId_example;  // string | messageId
            var body = new SendMessageBody(); // SendMessageBody | message body

            try
            { 
                // Edit a message to a user
                ChatSendMessageResponse result = apiInstance.PatchChatsUserMessage(userId, messageId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.PatchChatsUserMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| userId |  |
| **messageId** | **string**| messageId |  |
| **body** | [**SendMessageBody**](SendMessageBody.html)| message body |  |
{: class="table table-striped"}

### Return type

[**ChatSendMessageResponse**](ChatSendMessageResponse.html)

<a name="patchchatsusersettings"></a>

## [**ChatUserSettings**](ChatUserSettings.html) PatchChatsUserSettings (string userId, ChatUserSettings body)



Update a user's chat settings

PatchChatsUserSettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* chat:usersettings:edit
* chat:setting:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchChatsUserSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ChatApi();
            var userId = userId_example;  // string | User ID
            var body = new ChatUserSettings(); // ChatUserSettings | 

            try
            { 
                // Update a user's chat settings
                ChatUserSettings result = apiInstance.PatchChatsUserSettings(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.PatchChatsUserSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**ChatUserSettings**](ChatUserSettings.html)|  |  |
{: class="table table-striped"}

### Return type

[**ChatUserSettings**](ChatUserSettings.html)

<a name="postchatsroommessages"></a>

## [**ChatSendMessageResponse**](ChatSendMessageResponse.html) PostChatsRoomMessages (string roomJid, SendMessageBody body)



Send a message to a room

PostChatsRoomMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* chat:chat:access
* chat:roomMessage:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostChatsRoomMessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ChatApi();
            var roomJid = roomJid_example;  // string | roomId
            var body = new SendMessageBody(); // SendMessageBody | messageBody

            try
            { 
                // Send a message to a room
                ChatSendMessageResponse result = apiInstance.PostChatsRoomMessages(roomJid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.PostChatsRoomMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roomJid** | **string**| roomId |  |
| **body** | [**SendMessageBody**](SendMessageBody.html)| messageBody |  |
{: class="table table-striped"}

### Return type

[**ChatSendMessageResponse**](ChatSendMessageResponse.html)

<a name="postchatsroomparticipant"></a>

## void PostChatsRoomParticipant (string roomJid, string userId)



Join a room

PostChatsRoomParticipant is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* chat:chat:access
* chat:participant:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostChatsRoomParticipantExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ChatApi();
            var roomJid = roomJid_example;  // string | roomJid
            var userId = userId_example;  // string | userId

            try
            { 
                // Join a room
                apiInstance.PostChatsRoomParticipant(roomJid, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.PostChatsRoomParticipant: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roomJid** | **string**| roomJid |  |
| **userId** | **string**| userId |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postchatsroompinnedmessages"></a>

## void PostChatsRoomPinnedmessages (string roomJid, PinnedMessageRequest body)



Add pinned messages for a room, up to a maximum of 5 pinned messages

PostChatsRoomPinnedmessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* chat:chat:access
* chat:room:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostChatsRoomPinnedmessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ChatApi();
            var roomJid = roomJid_example;  // string | roomJid
            var body = new PinnedMessageRequest(); // PinnedMessageRequest | Pinned Message Ids

            try
            { 
                // Add pinned messages for a room, up to a maximum of 5 pinned messages
                apiInstance.PostChatsRoomPinnedmessages(roomJid, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.PostChatsRoomPinnedmessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roomJid** | **string**| roomJid |  |
| **body** | [**PinnedMessageRequest**](PinnedMessageRequest.html)| Pinned Message Ids |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postchatsrooms"></a>

## [**CreateRoomResponse**](CreateRoomResponse.html) PostChatsRooms (CreateRoomRequest body)



Create an adhoc room

PostChatsRooms is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* chat:chat:access
* chat:room:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostChatsRoomsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ChatApi();
            var body = new CreateRoomRequest(); // CreateRoomRequest | Room properties

            try
            { 
                // Create an adhoc room
                CreateRoomResponse result = apiInstance.PostChatsRooms(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.PostChatsRooms: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateRoomRequest**](CreateRoomRequest.html)| Room properties |  |
{: class="table table-striped"}

### Return type

[**CreateRoomResponse**](CreateRoomResponse.html)

<a name="postchatsusermessages"></a>

## [**ChatSendMessageResponse**](ChatSendMessageResponse.html) PostChatsUserMessages (string userId, SendMessageBody body)



Send a message to a user

PostChatsUserMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* chat:chat:access
* chat:1on1Message:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostChatsUserMessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ChatApi();
            var userId = userId_example;  // string | userId
            var body = new SendMessageBody(); // SendMessageBody | message body

            try
            { 
                // Send a message to a user
                ChatSendMessageResponse result = apiInstance.PostChatsUserMessages(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.PostChatsUserMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| userId |  |
| **body** | [**SendMessageBody**](SendMessageBody.html)| message body |  |
{: class="table table-striped"}

### Return type

[**ChatSendMessageResponse**](ChatSendMessageResponse.html)

<a name="putchatssettings"></a>

## [**ChatSettings**](ChatSettings.html) PutChatsSettings (ChatSettings body)



Update Chat Settings.

Requires ANY permissions: 

* chat:setting:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutChatsSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ChatApi();
            var body = new ChatSettings(); // ChatSettings | Chat

            try
            { 
                // Update Chat Settings.
                ChatSettings result = apiInstance.PutChatsSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.PutChatsSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ChatSettings**](ChatSettings.html)| Chat |  |
{: class="table table-striped"}

### Return type

[**ChatSettings**](ChatSettings.html)

