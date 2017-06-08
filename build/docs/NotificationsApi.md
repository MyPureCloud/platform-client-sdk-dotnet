---
title: NotificationsApi
---
## PureCloudPlatform.Client.V2.Api.NotificationsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteNotificationsChannelSubscriptions**](NotificationsApi.html#deletenotificationschannelsubscriptions) | **DELETE** /api/v2/notifications/channels/{channelId}/subscriptions | Remove all subscriptions |
| [**GetNotificationsAvailabletopics**](NotificationsApi.html#getnotificationsavailabletopics) | **GET** /api/v2/notifications/availabletopics | Get available notification topics. |
| [**GetNotificationsChannelSubscriptions**](NotificationsApi.html#getnotificationschannelsubscriptions) | **GET** /api/v2/notifications/channels/{channelId}/subscriptions | The list of all subscriptions for this channel |
| [**GetNotificationsChannels**](NotificationsApi.html#getnotificationschannels) | **GET** /api/v2/notifications/channels | The list of existing channels |
| [**PostNotificationsChannelSubscriptions**](NotificationsApi.html#postnotificationschannelsubscriptions) | **POST** /api/v2/notifications/channels/{channelId}/subscriptions | Add a list of subscriptions to the existing list of subscriptions |
| [**PostNotificationsChannels**](NotificationsApi.html#postnotificationschannels) | **POST** /api/v2/notifications/channels | Create a new channel |
| [**PutNotificationsChannelSubscriptions**](NotificationsApi.html#putnotificationschannelsubscriptions) | **PUT** /api/v2/notifications/channels/{channelId}/subscriptions | Replace the current list of subscriptions with a new list. |
{: class="table table-striped"}

<a name="deletenotificationschannelsubscriptions"></a>

## void DeleteNotificationsChannelSubscriptions (string channelId)

Remove all subscriptions



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **channelId** | **string**| Channel ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getnotificationsavailabletopics"></a>

## [**AvailableTopicEntityListing**](AvailableTopicEntityListing.html) GetNotificationsAvailabletopics (List<string> expand = null)

Get available notification topics.



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new NotificationsApi();
            
            
            
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 
            
            

            try
            {
                
                // Get available notification topics.
                
                AvailableTopicEntityListing result = apiInstance.GetNotificationsAvailabletopics(expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetNotificationsAvailabletopics: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: description, requiresPermissions, schema |
{: class="table table-striped"}

### Return type

[**AvailableTopicEntityListing**](AvailableTopicEntityListing.html)

<a name="getnotificationschannelsubscriptions"></a>

## [**ChannelTopicEntityListing**](ChannelTopicEntityListing.html) GetNotificationsChannelSubscriptions (string channelId)

The list of all subscriptions for this channel



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **channelId** | **string**| Channel ID |  |
{: class="table table-striped"}

### Return type

[**ChannelTopicEntityListing**](ChannelTopicEntityListing.html)

<a name="getnotificationschannels"></a>

## [**ChannelEntityListing**](ChannelEntityListing.html) GetNotificationsChannels ()

The list of existing channels



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new NotificationsApi();
            

            try
            {
                
                // The list of existing channels
                
                ChannelEntityListing result = apiInstance.GetNotificationsChannels();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetNotificationsChannels: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**ChannelEntityListing**](ChannelEntityListing.html)

<a name="postnotificationschannelsubscriptions"></a>

## [**ChannelTopicEntityListing**](ChannelTopicEntityListing.html) PostNotificationsChannelSubscriptions (string channelId, List<ChannelTopic> body)

Add a list of subscriptions to the existing list of subscriptions



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new NotificationsApi();
            
            
            var channelId = channelId_example;  // string | Channel ID
            
            
            
            
            
            var body = new List<ChannelTopic>(); // List<ChannelTopic> | Body
            
            

            try
            {
                
                // Add a list of subscriptions to the existing list of subscriptions
                
                ChannelTopicEntityListing result = apiInstance.PostNotificationsChannelSubscriptions(channelId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.PostNotificationsChannelSubscriptions: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **channelId** | **string**| Channel ID |  |
| **body** | [**List<ChannelTopic>**](ChannelTopic.html)| Body |  |
{: class="table table-striped"}

### Return type

[**ChannelTopicEntityListing**](ChannelTopicEntityListing.html)

<a name="postnotificationschannels"></a>

## [**Channel**](Channel.html) PostNotificationsChannels ()

Create a new channel

There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.

### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**Channel**](Channel.html)

<a name="putnotificationschannelsubscriptions"></a>

## [**ChannelTopicEntityListing**](ChannelTopicEntityListing.html) PutNotificationsChannelSubscriptions (string channelId, List<ChannelTopic> body)

Replace the current list of subscriptions with a new list.



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new NotificationsApi();
            
            
            var channelId = channelId_example;  // string | Channel ID
            
            
            
            
            
            var body = new List<ChannelTopic>(); // List<ChannelTopic> | Body
            
            

            try
            {
                
                // Replace the current list of subscriptions with a new list.
                
                ChannelTopicEntityListing result = apiInstance.PutNotificationsChannelSubscriptions(channelId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.PutNotificationsChannelSubscriptions: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **channelId** | **string**| Channel ID |  |
| **body** | [**List<ChannelTopic>**](ChannelTopic.html)| Body |  |
{: class="table table-striped"}

### Return type

[**ChannelTopicEntityListing**](ChannelTopicEntityListing.html)

