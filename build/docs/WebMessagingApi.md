---
title: WebMessagingApi
---
## PureCloudPlatform.Client.V2.Api.WebMessagingApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetWebmessagingMessages**](WebMessagingApi.html#getwebmessagingmessages) | **GET** /api/v2/webmessaging/messages | Get the messages for a web messaging session. |
{: class="table table-striped"}

<a name="getwebmessagingmessages"></a>

## [**WebMessagingMessageEntityList**](WebMessagingMessageEntityList.html) GetWebmessagingMessages (int? pageSize = null, int? pageNumber = null)



Get the messages for a web messaging session.



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
    public class GetWebmessagingMessagesExample
    {
        public void main()
        { 

            var apiInstance = new WebMessagingApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get the messages for a web messaging session.
                WebMessagingMessageEntityList result = apiInstance.GetWebmessagingMessages(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebMessagingApi.GetWebmessagingMessages: " + e.Message );
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
{: class="table table-striped"}

### Return type

[**WebMessagingMessageEntityList**](WebMessagingMessageEntityList.html)

