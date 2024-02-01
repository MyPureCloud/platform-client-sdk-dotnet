---
title: ScreenRecordingApi
---
## PureCloudPlatform.Client.V2.Api.ScreenRecordingApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**PostScreenrecordingToken**](ScreenRecordingApi.html#postscreenrecordingtoken) | **Post** /api/v2/screenrecording/token | Sign identifying information for screen recording |
{: class="table table-striped"}

<a name="postscreenrecordingtoken"></a>

## [**SignedData**](SignedData.html) PostScreenrecordingToken (ScreenRecordingUserAuthenticatedInfo body = null)



Sign identifying information for screen recording

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
    public class PostScreenrecordingTokenExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ScreenRecordingApi();
            var body = new ScreenRecordingUserAuthenticatedInfo(); // ScreenRecordingUserAuthenticatedInfo |  (optional) 

            try
            { 
                // Sign identifying information for screen recording
                SignedData result = apiInstance.PostScreenrecordingToken(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScreenRecordingApi.PostScreenrecordingToken: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ScreenRecordingUserAuthenticatedInfo**](ScreenRecordingUserAuthenticatedInfo.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**SignedData**](SignedData.html)

