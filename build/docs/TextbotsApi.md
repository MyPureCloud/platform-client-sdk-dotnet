---
title: TextbotsApi
---
## PureCloudPlatform.Client.V2.Api.TextbotsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**PostTextbotsBotsExecute**](TextbotsApi.html#posttextbotsbotsexecute) | **POST** /api/v2/textbots/bots/execute | Send an intent to a bot to start a dialog/interact with it via text |
{: class="table table-striped"}

<a name="posttextbotsbotsexecute"></a>

## [**PostTextResponse**](PostTextResponse.html) PostTextbotsBotsExecute (PostTextRequest postTextRequest)



Send an intent to a bot to start a dialog/interact with it via text

This will either start a bot with the given id or relay a communication to an existing bot session.

Requires ANY permissions: 

* textbots:session:execute

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTextbotsBotsExecuteExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TextbotsApi();
            var postTextRequest = new PostTextRequest(); // PostTextRequest | 

            try
            { 
                // Send an intent to a bot to start a dialog/interact with it via text
                PostTextResponse result = apiInstance.PostTextbotsBotsExecute(postTextRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TextbotsApi.PostTextbotsBotsExecute: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **postTextRequest** | [**PostTextRequest**](PostTextRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**PostTextResponse**](PostTextResponse.html)

