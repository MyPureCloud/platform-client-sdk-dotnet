# ChatApi

## PureCloudPlatform.Client.V2.Api.ChatApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteChatsRoomMessage**](#DeleteChatsRoomMessage) | **Delete** /api/v2/chats/rooms/{roomJid}/messages/{messageId} | Delete a message in a room |
| [**DeleteChatsRoomMessagesPin**](#DeleteChatsRoomMessagesPin) | **Delete** /api/v2/chats/rooms/{roomJid}/messages/pins/{pinnedMessageId} | Remove a pinned message from a room |
| [**DeleteChatsRoomParticipant**](#DeleteChatsRoomParticipant) | **Delete** /api/v2/chats/rooms/{roomJid}/participants/{userId} | Remove a user from a room. |
| [**DeleteChatsUserMessage**](#DeleteChatsUserMessage) | **Delete** /api/v2/chats/users/{userId}/messages/{messageId} | Delete a message to a user |
| [**DeleteChatsUserMessagesPin**](#DeleteChatsUserMessagesPin) | **Delete** /api/v2/chats/users/{userId}/messages/pins/{pinnedMessageId} | Remove a pinned message from a 1on1 |
| [**DeleteChatsUsersMeSettings**](#DeleteChatsUsersMeSettings) | **Delete** /api/v2/chats/users/me/settings | Delete a user&#39;s chat settings |
| [**GetChatsMessage**](#GetChatsMessage) | **Get** /api/v2/chats/messages/{messageId} | Get a message |
| [**GetChatsRoom**](#GetChatsRoom) | **Get** /api/v2/chats/rooms/{roomJid} | Get a room |
| [**GetChatsRoomMessage**](#GetChatsRoomMessage) | **Get** /api/v2/chats/rooms/{roomJid}/messages/{messageIds} | Get messages by id(s) from a room |
| [**GetChatsRoomMessages**](#GetChatsRoomMessages) | **Get** /api/v2/chats/rooms/{roomJid}/messages | Get a room&#39;s message history |
| [**GetChatsRoomParticipant**](#GetChatsRoomParticipant) | **Get** /api/v2/chats/rooms/{roomJid}/participants/{participantJid} | Get a room participant |
| [**GetChatsRoomParticipants**](#GetChatsRoomParticipants) | **Get** /api/v2/chats/rooms/{roomJid}/participants | Get room participants in a room |
| [**GetChatsSettings**](#GetChatsSettings) | **Get** /api/v2/chats/settings | Get Chat Settings. |
| [**GetChatsThreadMessages**](#GetChatsThreadMessages) | **Get** /api/v2/chats/threads/{threadId}/messages | Get history by thread |
| [**GetChatsUser**](#GetChatsUser) | **Get** /api/v2/chats/users/{userId} | Get information for a 1on1 |
| [**GetChatsUserMessage**](#GetChatsUserMessage) | **Get** /api/v2/chats/users/{userId}/messages/{messageIds} | Get messages by id(s) from a 1on1 |
| [**GetChatsUserMessages**](#GetChatsUserMessages) | **Get** /api/v2/chats/users/{userId}/messages | Get 1on1 History between a user |
| [**GetChatsUserSettings**](#GetChatsUserSettings) | **Get** /api/v2/chats/users/{userId}/settings | Get a user&#39;s chat settings |
| [**GetChatsUsersMeSettings**](#GetChatsUsersMeSettings) | **Get** /api/v2/chats/users/me/settings | Get a user&#39;s chat settings |
| [**PatchChatsRoom**](#PatchChatsRoom) | **Patch** /api/v2/chats/rooms/{roomJid} | Set properties for a room |
| [**PatchChatsRoomMessage**](#PatchChatsRoomMessage) | **Patch** /api/v2/chats/rooms/{roomJid}/messages/{messageId} | Edit a message in a room |
| [**PatchChatsSettings**](#PatchChatsSettings) | **Patch** /api/v2/chats/settings | Patch Chat Settings. |
| [**PatchChatsUserMessage**](#PatchChatsUserMessage) | **Patch** /api/v2/chats/users/{userId}/messages/{messageId} | Edit a message to a user |
| [**PatchChatsUserSettings**](#PatchChatsUserSettings) | **Patch** /api/v2/chats/users/{userId}/settings | Update a user&#39;s chat settings |
| [**PatchChatsUsersMeSettings**](#PatchChatsUsersMeSettings) | **Patch** /api/v2/chats/users/me/settings | Update a user&#39;s chat settings |
| [**PostChatsRoomMessages**](#PostChatsRoomMessages) | **Post** /api/v2/chats/rooms/{roomJid}/messages | Send a message to a room |
| [**PostChatsRoomMessagesPins**](#PostChatsRoomMessagesPins) | **Post** /api/v2/chats/rooms/{roomJid}/messages/pins | Add pinned messages for a room, up to a maximum of 5 pinned messages |
| [**PostChatsRoomParticipant**](#PostChatsRoomParticipant) | **Post** /api/v2/chats/rooms/{roomJid}/participants/{userId} | Join a room |
| [**PostChatsRooms**](#PostChatsRooms) | **Post** /api/v2/chats/rooms | Create an adhoc room |
| [**PostChatsUserMessages**](#PostChatsUserMessages) | **Post** /api/v2/chats/users/{userId}/messages | Send a message to a user |
| [**PostChatsUserMessagesPins**](#PostChatsUserMessagesPins) | **Post** /api/v2/chats/users/{userId}/messages/pins | Add pinned messages for a 1on1, up to a maximum of 5 pinned messages |
| [**PostChatsUsersMeSettings**](#PostChatsUsersMeSettings) | **Post** /api/v2/chats/users/me/settings | Create a user&#39;s chat settings |
| [**PutChatsMessageReactions**](#PutChatsMessageReactions) | **Put** /api/v2/chats/messages/{messageId}/reactions | Update reactions to a message |
| [**PutChatsSettings**](#PutChatsSettings) | **Put** /api/v2/chats/settings | Update Chat Settings. |



## DeleteChatsRoomMessage

> void DeleteChatsRoomMessage (string roomJid, string messageId)


Delete a message in a room

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

### Return type

void (empty response body)


## DeleteChatsRoomMessagesPin

> void DeleteChatsRoomMessagesPin (string roomJid, string pinnedMessageId)


Remove a pinned message from a room

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
    public class DeleteChatsRoomMessagesPinExample
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
                apiInstance.DeleteChatsRoomMessagesPin(roomJid, pinnedMessageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.DeleteChatsRoomMessagesPin: " + e.Message );
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

### Return type

void (empty response body)


## DeleteChatsRoomParticipant

> void DeleteChatsRoomParticipant (string roomJid, string userId)


Remove a user from a room.

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

### Return type

void (empty response body)


## DeleteChatsUserMessage

> void DeleteChatsUserMessage (string userId, string messageId)


Delete a message to a user

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

### Return type

void (empty response body)


## DeleteChatsUserMessagesPin

> void DeleteChatsUserMessagesPin (string userId, string pinnedMessageId)


Remove a pinned message from a 1on1

Requires ANY permissions: 

* chat:chat:access
* chat:1on1:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteChatsUserMessagesPinExample
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
            var pinnedMessageId = pinnedMessageId_example;  // string | pinnedMessageId

            try
            { 
                // Remove a pinned message from a 1on1
                apiInstance.DeleteChatsUserMessagesPin(userId, pinnedMessageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.DeleteChatsUserMessagesPin: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| userId |  |
| **pinnedMessageId** | **string**| pinnedMessageId |  |

### Return type

void (empty response body)


## DeleteChatsUsersMeSettings

> void DeleteChatsUsersMeSettings ()


Delete a user's chat settings

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
    public class DeleteChatsUsersMeSettingsExample
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
                // Delete a user's chat settings
                apiInstance.DeleteChatsUsersMeSettings();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.DeleteChatsUsersMeSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

void (empty response body)


## GetChatsMessage

> [**ChatMessageResponse**](ChatMessageResponse) GetChatsMessage (string messageId)


Get a message

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

### Return type

[**ChatMessageResponse**](ChatMessageResponse)


## GetChatsRoom

> [**Room**](Room) GetChatsRoom (string roomJid)


Get a room

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

### Return type

[**Room**](Room)


## GetChatsRoomMessage

> [**ChatMessageEntityListing**](ChatMessageEntityListing) GetChatsRoomMessage (string roomJid, string messageIds)


Get messages by id(s) from a room

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

### Return type

[**ChatMessageEntityListing**](ChatMessageEntityListing)


## GetChatsRoomMessages

> [**ChatMessageEntityListing**](ChatMessageEntityListing) GetChatsRoomMessages (string roomJid, string limit = null, string before = null, string after = null, bool? excludeMetadata = null)


Get a room's message history

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
            var excludeMetadata = true;  // bool? | Whether to exclude metadata for messages (optional) 

            try
            { 
                // Get a room's message history
                ChatMessageEntityListing result = apiInstance.GetChatsRoomMessages(roomJid, limit, before, after, excludeMetadata);
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
| **excludeMetadata** | **bool?**| Whether to exclude metadata for messages | [optional]  |

### Return type

[**ChatMessageEntityListing**](ChatMessageEntityListing)


## GetChatsRoomParticipant

> [**RoomParticipant**](RoomParticipant) GetChatsRoomParticipant (string roomJid, string participantJid)


Get a room participant

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
    public class GetChatsRoomParticipantExample
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
            var participantJid = participantJid_example;  // string | participantJid

            try
            { 
                // Get a room participant
                RoomParticipant result = apiInstance.GetChatsRoomParticipant(roomJid, participantJid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.GetChatsRoomParticipant: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roomJid** | **string**| roomJid |  |
| **participantJid** | **string**| participantJid |  |

### Return type

[**RoomParticipant**](RoomParticipant)


## GetChatsRoomParticipants

> [**RoomParticipantsResponse**](RoomParticipantsResponse) GetChatsRoomParticipants (string roomJid, bool? notify = null)


Get room participants in a room

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
    public class GetChatsRoomParticipantsExample
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
            var notify = true;  // bool? | Whether to get users to notify (optional) 

            try
            { 
                // Get room participants in a room
                RoomParticipantsResponse result = apiInstance.GetChatsRoomParticipants(roomJid, notify);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.GetChatsRoomParticipants: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roomJid** | **string**| roomJid |  |
| **notify** | **bool?**| Whether to get users to notify | [optional]  |

### Return type

[**RoomParticipantsResponse**](RoomParticipantsResponse)


## GetChatsSettings

> [**ChatSettings**](ChatSettings) GetChatsSettings ()


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

[**ChatSettings**](ChatSettings)


## GetChatsThreadMessages

> [**ChatMessageEntityListing**](ChatMessageEntityListing) GetChatsThreadMessages (string threadId, string limit = null, string before = null, string after = null, bool? excludeMetadata = null)


Get history by thread

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
            var excludeMetadata = true;  // bool? | Whether to exclude metadata for messages (optional) 

            try
            { 
                // Get history by thread
                ChatMessageEntityListing result = apiInstance.GetChatsThreadMessages(threadId, limit, before, after, excludeMetadata);
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
| **excludeMetadata** | **bool?**| Whether to exclude metadata for messages | [optional]  |

### Return type

[**ChatMessageEntityListing**](ChatMessageEntityListing)


## GetChatsUser

> [**OneOnOne**](OneOnOne) GetChatsUser (string userId)


Get information for a 1on1

Requires ANY permissions: 

* chat:chat:access
* chat:1on1:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetChatsUserExample
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

            try
            { 
                // Get information for a 1on1
                OneOnOne result = apiInstance.GetChatsUser(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.GetChatsUser: " + e.Message );
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

[**OneOnOne**](OneOnOne)


## GetChatsUserMessage

> [**ChatMessageEntityListing**](ChatMessageEntityListing) GetChatsUserMessage (string userId, string messageIds)


Get messages by id(s) from a 1on1

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

### Return type

[**ChatMessageEntityListing**](ChatMessageEntityListing)


## GetChatsUserMessages

> [**ChatMessageResponse**](ChatMessageResponse) GetChatsUserMessages (string userId, string limit = null, string before = null, string after = null, bool? excludeMetadata = null)


Get 1on1 History between a user

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
            var excludeMetadata = true;  // bool? | Whether to exclude metadata for messages (optional) 

            try
            { 
                // Get 1on1 History between a user
                ChatMessageResponse result = apiInstance.GetChatsUserMessages(userId, limit, before, after, excludeMetadata);
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
| **excludeMetadata** | **bool?**| Whether to exclude metadata for messages | [optional]  |

### Return type

[**ChatMessageResponse**](ChatMessageResponse)


## GetChatsUserSettings

> [**ChatUserSettings**](ChatUserSettings) GetChatsUserSettings (string userId)


Get a user's chat settings

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

### Return type

[**ChatUserSettings**](ChatUserSettings)


## GetChatsUsersMeSettings

> [**UserSettingsForChat**](UserSettingsForChat) GetChatsUsersMeSettings ()


Get a user's chat settings

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
    public class GetChatsUsersMeSettingsExample
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
                // Get a user's chat settings
                UserSettingsForChat result = apiInstance.GetChatsUsersMeSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.GetChatsUsersMeSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**UserSettingsForChat**](UserSettingsForChat)


## PatchChatsRoom

> void PatchChatsRoom (string roomJid, RoomUpdateRequest body)


Set properties for a room

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
| **body** | [**RoomUpdateRequest**](RoomUpdateRequest)| Room properties |  |

### Return type

void (empty response body)


## PatchChatsRoomMessage

> [**ChatSendMessageResponse**](ChatSendMessageResponse) PatchChatsRoomMessage (string roomJid, string messageId, SendMessageBody body)


Edit a message in a room

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
| **body** | [**SendMessageBody**](SendMessageBody)| messageBody |  |

### Return type

[**ChatSendMessageResponse**](ChatSendMessageResponse)


## PatchChatsSettings

> [**ChatSettings**](ChatSettings) PatchChatsSettings (ChatSettings body)


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
| **body** | [**ChatSettings**](ChatSettings)| Chat |  |

### Return type

[**ChatSettings**](ChatSettings)


## PatchChatsUserMessage

> [**ChatSendMessageResponse**](ChatSendMessageResponse) PatchChatsUserMessage (string userId, string messageId, SendMessageBody body)


Edit a message to a user

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
| **body** | [**SendMessageBody**](SendMessageBody)| message body |  |

### Return type

[**ChatSendMessageResponse**](ChatSendMessageResponse)


## PatchChatsUserSettings

> [**ChatUserSettings**](ChatUserSettings) PatchChatsUserSettings (string userId, ChatUserSettings body)


Update a user's chat settings

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
| **body** | [**ChatUserSettings**](ChatUserSettings)|  |  |

### Return type

[**ChatUserSettings**](ChatUserSettings)


## PatchChatsUsersMeSettings

> [**UserSettingsForChat**](UserSettingsForChat) PatchChatsUsersMeSettings (UserSettingsForChat body)


Update a user's chat settings

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
    public class PatchChatsUsersMeSettingsExample
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
            var body = new UserSettingsForChat(); // UserSettingsForChat | 

            try
            { 
                // Update a user's chat settings
                UserSettingsForChat result = apiInstance.PatchChatsUsersMeSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.PatchChatsUsersMeSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UserSettingsForChat**](UserSettingsForChat)|  |  |

### Return type

[**UserSettingsForChat**](UserSettingsForChat)


## PostChatsRoomMessages

> [**ChatSendMessageResponse**](ChatSendMessageResponse) PostChatsRoomMessages (string roomJid, SendMessageBody body)


Send a message to a room

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
| **body** | [**SendMessageBody**](SendMessageBody)| messageBody |  |

### Return type

[**ChatSendMessageResponse**](ChatSendMessageResponse)


## PostChatsRoomMessagesPins

> void PostChatsRoomMessagesPins (string roomJid, PinnedMessageRequest body)


Add pinned messages for a room, up to a maximum of 5 pinned messages

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
    public class PostChatsRoomMessagesPinsExample
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
                apiInstance.PostChatsRoomMessagesPins(roomJid, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.PostChatsRoomMessagesPins: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roomJid** | **string**| roomJid |  |
| **body** | [**PinnedMessageRequest**](PinnedMessageRequest)| Pinned Message Ids |  |

### Return type

void (empty response body)


## PostChatsRoomParticipant

> void PostChatsRoomParticipant (string roomJid, string userId)


Join a room

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

### Return type

void (empty response body)


## PostChatsRooms

> [**CreateRoomResponse**](CreateRoomResponse) PostChatsRooms (CreateRoomRequest body)


Create an adhoc room

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
| **body** | [**CreateRoomRequest**](CreateRoomRequest)| Room properties |  |

### Return type

[**CreateRoomResponse**](CreateRoomResponse)


## PostChatsUserMessages

> [**ChatSendMessageResponse**](ChatSendMessageResponse) PostChatsUserMessages (string userId, SendMessageBody body)


Send a message to a user

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
| **body** | [**SendMessageBody**](SendMessageBody)| message body |  |

### Return type

[**ChatSendMessageResponse**](ChatSendMessageResponse)


## PostChatsUserMessagesPins

> void PostChatsUserMessagesPins (string userId, PinnedMessageRequest body)


Add pinned messages for a 1on1, up to a maximum of 5 pinned messages

Requires ANY permissions: 

* chat:chat:access
* chat:1on1:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostChatsUserMessagesPinsExample
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
            var body = new PinnedMessageRequest(); // PinnedMessageRequest | Pinned Message Ids

            try
            { 
                // Add pinned messages for a 1on1, up to a maximum of 5 pinned messages
                apiInstance.PostChatsUserMessagesPins(userId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.PostChatsUserMessagesPins: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| userId |  |
| **body** | [**PinnedMessageRequest**](PinnedMessageRequest)| Pinned Message Ids |  |

### Return type

void (empty response body)


## PostChatsUsersMeSettings

> void PostChatsUsersMeSettings (UserChatSettingsPost body)


Create a user's chat settings

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
    public class PostChatsUsersMeSettingsExample
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
            var body = new UserChatSettingsPost(); // UserChatSettingsPost | 

            try
            { 
                // Create a user's chat settings
                apiInstance.PostChatsUsersMeSettings(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.PostChatsUsersMeSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UserChatSettingsPost**](UserChatSettingsPost)|  |  |

### Return type

void (empty response body)


## PutChatsMessageReactions

> void PutChatsMessageReactions (string messageId, ChatReactionUpdate body)


Update reactions to a message

Requires ANY permissions: 

* chat:chat:access
* chat:reactions:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutChatsMessageReactionsExample
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
            var body = new ChatReactionUpdate(); // ChatReactionUpdate | reactionUpdate

            try
            { 
                // Update reactions to a message
                apiInstance.PutChatsMessageReactions(messageId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.PutChatsMessageReactions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messageId** | **string**| messageId |  |
| **body** | [**ChatReactionUpdate**](ChatReactionUpdate)| reactionUpdate |  |

### Return type

void (empty response body)


## PutChatsSettings

> [**ChatSettings**](ChatSettings) PutChatsSettings (ChatSettings body)


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
| **body** | [**ChatSettings**](ChatSettings)| Chat |  |

### Return type

[**ChatSettings**](ChatSettings)


_PureCloudPlatform.Client.V2 251.0.0_
