# NotificationsApi

## PureCloudPlatform.Client.V2.Api.NotificationsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteNotificationsChannelSubscriptions**](#DeleteNotificationsChannelSubscriptions) | **Delete** /api/v2/notifications/channels/{channelId}/subscriptions | Remove all subscriptions |
| [**GetNotificationsAvailabletopics**](#GetNotificationsAvailabletopics) | **Get** /api/v2/notifications/availabletopics | Get available notification topics. |
| [**GetNotificationsChannelSubscriptions**](#GetNotificationsChannelSubscriptions) | **Get** /api/v2/notifications/channels/{channelId}/subscriptions | The list of all subscriptions for this channel |
| [**GetNotificationsChannels**](#GetNotificationsChannels) | **Get** /api/v2/notifications/channels | The list of existing channels |
| [**HeadNotificationsChannel**](#HeadNotificationsChannel) | **Head** /api/v2/notifications/channels/{channelId} | Verify a channel still exists and is valid |
| [**PostNotificationsChannelSubscriptions**](#PostNotificationsChannelSubscriptions) | **Post** /api/v2/notifications/channels/{channelId}/subscriptions | Add a list of subscriptions to the existing list of subscriptions |
| [**PostNotificationsChannels**](#PostNotificationsChannels) | **Post** /api/v2/notifications/channels | Create a new channel |
| [**PutNotificationsChannelSubscriptions**](#PutNotificationsChannelSubscriptions) | **Put** /api/v2/notifications/channels/{channelId}/subscriptions | Replace the current list of subscriptions with a new list. |



## DeleteNotificationsChannelSubscriptions

> void DeleteNotificationsChannelSubscriptions (string channelId)


Remove all subscriptions

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
    public class DeleteNotificationsChannelSubscriptionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new NotificationsApi();
            var channelId = channelId_example;  // string | Channel ID

            try
            { 
                // Remove all subscriptions
                apiInstance.DeleteNotificationsChannelSubscriptions(channelId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.DeleteNotificationsChannelSubscriptions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **channelId** | **string**| Channel ID |  |

### Return type

void (empty response body)


## GetNotificationsAvailabletopics

> [**AvailableTopicEntityListing**](AvailableTopicEntityListing) GetNotificationsAvailabletopics (List<string> expand = null, bool? includePreview = null)


Get available notification topics.

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
    public class GetNotificationsAvailabletopicsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new NotificationsApi();
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 
            var includePreview = true;  // bool? | Whether or not to include Preview topics (optional)  (default to true)

            try
            { 
                // Get available notification topics.
                AvailableTopicEntityListing result = apiInstance.GetNotificationsAvailabletopics(expand, includePreview);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetNotificationsAvailabletopics: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expand** | [**List<string>**](string)| Which fields, if any, to expand | [optional] <br />**Values**: description, enforced, schema, visibility, transports, publicApiTemplateUriPaths, requiresPermissions, permissionDetails, topicParameters |
| **includePreview** | **bool?**| Whether or not to include Preview topics | [optional] [default to true] |

### Return type

[**AvailableTopicEntityListing**](AvailableTopicEntityListing)


## GetNotificationsChannelSubscriptions

> [**ChannelTopicEntityListing**](ChannelTopicEntityListing) GetNotificationsChannelSubscriptions (string channelId)


The list of all subscriptions for this channel

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
    public class GetNotificationsChannelSubscriptionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new NotificationsApi();
            var channelId = channelId_example;  // string | Channel ID

            try
            { 
                // The list of all subscriptions for this channel
                ChannelTopicEntityListing result = apiInstance.GetNotificationsChannelSubscriptions(channelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetNotificationsChannelSubscriptions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **channelId** | **string**| Channel ID |  |

### Return type

[**ChannelTopicEntityListing**](ChannelTopicEntityListing)


## GetNotificationsChannels

> [**ChannelEntityListing**](ChannelEntityListing) GetNotificationsChannels (string includechannels = null)


The list of existing channels

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
    public class GetNotificationsChannelsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new NotificationsApi();
            var includechannels = includechannels_example;  // string | Show user's channels for this specific token or across all tokens for this user and app.  Channel Ids for other access tokens will not be shown, but will be presented to show their existence. (optional)  (default to token)

            try
            { 
                // The list of existing channels
                ChannelEntityListing result = apiInstance.GetNotificationsChannels(includechannels);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetNotificationsChannels: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **includechannels** | **string**| Show user&#39;s channels for this specific token or across all tokens for this user and app.  Channel Ids for other access tokens will not be shown, but will be presented to show their existence. | [optional] [default to token]<br />**Values**: token, oauthclient |

### Return type

[**ChannelEntityListing**](ChannelEntityListing)


## HeadNotificationsChannel

> void HeadNotificationsChannel (string channelId)


Verify a channel still exists and is valid

Returns a 200 OK if channel exists, and a 404 Not Found if it doesn't

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
    public class HeadNotificationsChannelExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new NotificationsApi();
            var channelId = channelId_example;  // string | Channel ID

            try
            { 
                // Verify a channel still exists and is valid
                apiInstance.HeadNotificationsChannel(channelId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.HeadNotificationsChannel: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **channelId** | **string**| Channel ID |  |

### Return type

void (empty response body)


## PostNotificationsChannelSubscriptions

> [**ChannelTopicEntityListing**](ChannelTopicEntityListing) PostNotificationsChannelSubscriptions (string channelId, List<ChannelTopic> body, bool? ignoreErrors = null)


Add a list of subscriptions to the existing list of subscriptions

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
    public class PostNotificationsChannelSubscriptionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new NotificationsApi();
            var channelId = channelId_example;  // string | Channel ID
            var body = new List<ChannelTopic>(); // List<ChannelTopic> | Body
            var ignoreErrors = true;  // bool? | Optionally prevent throwing of errors for failed permissions checks. (optional)  (default to false)

            try
            { 
                // Add a list of subscriptions to the existing list of subscriptions
                ChannelTopicEntityListing result = apiInstance.PostNotificationsChannelSubscriptions(channelId, body, ignoreErrors);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.PostNotificationsChannelSubscriptions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **channelId** | **string**| Channel ID |  |
| **body** | [**List<ChannelTopic>**](ChannelTopic)| Body |  |
| **ignoreErrors** | **bool?**| Optionally prevent throwing of errors for failed permissions checks. | [optional] [default to false] |

### Return type

[**ChannelTopicEntityListing**](ChannelTopicEntityListing)


## PostNotificationsChannels

> [**Channel**](Channel) PostNotificationsChannels ()


Create a new channel

There is a limit of 20 channels per user/app combination. Creating a 21st channel will remove the channel with oldest last used date. Channels without an active connection will be removed first.

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
    public class PostNotificationsChannelsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new NotificationsApi();

            try
            { 
                // Create a new channel
                Channel result = apiInstance.PostNotificationsChannels();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.PostNotificationsChannels: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**Channel**](Channel)


## PutNotificationsChannelSubscriptions

> [**ChannelTopicEntityListing**](ChannelTopicEntityListing) PutNotificationsChannelSubscriptions (string channelId, List<ChannelTopic> body, bool? ignoreErrors = null)


Replace the current list of subscriptions with a new list.

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
    public class PutNotificationsChannelSubscriptionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new NotificationsApi();
            var channelId = channelId_example;  // string | Channel ID
            var body = new List<ChannelTopic>(); // List<ChannelTopic> | Body
            var ignoreErrors = true;  // bool? | Optionally prevent throwing of errors for failed permissions checks. (optional)  (default to false)

            try
            { 
                // Replace the current list of subscriptions with a new list.
                ChannelTopicEntityListing result = apiInstance.PutNotificationsChannelSubscriptions(channelId, body, ignoreErrors);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.PutNotificationsChannelSubscriptions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **channelId** | **string**| Channel ID |  |
| **body** | [**List<ChannelTopic>**](ChannelTopic)| Body |  |
| **ignoreErrors** | **bool?**| Optionally prevent throwing of errors for failed permissions checks. | [optional] [default to false] |

### Return type

[**ChannelTopicEntityListing**](ChannelTopicEntityListing)


_PureCloudPlatform.Client.V2 249.0.0_
