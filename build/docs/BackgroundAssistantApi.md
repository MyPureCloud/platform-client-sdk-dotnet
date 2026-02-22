# BackgroundAssistantApi

## PureCloudPlatform.Client.V2.Api.BackgroundAssistantApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**PostBackgroundassistantToken**](#PostBackgroundassistantToken) | **Post** /api/v2/backgroundassistant/token | Sign identifying information for Genesys Cloud Background Assistant |
| [**PostScreenrecordingToken**](#PostScreenrecordingToken) | **Post** /api/v2/screenrecording/token | Sign identifying information for screen recording |



## PostBackgroundassistantToken

> [**SignedData**](SignedData) PostBackgroundassistantToken (BackgroundAssistantUserAuthenticatedInfo body = null)


Sign identifying information for Genesys Cloud Background Assistant

PostBackgroundassistantToken is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
    public class PostBackgroundassistantTokenExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BackgroundAssistantApi();
            var body = new BackgroundAssistantUserAuthenticatedInfo(); // BackgroundAssistantUserAuthenticatedInfo |  (optional) 

            try
            { 
                // Sign identifying information for Genesys Cloud Background Assistant
                SignedData result = apiInstance.PostBackgroundassistantToken(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BackgroundAssistantApi.PostBackgroundassistantToken: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**BackgroundAssistantUserAuthenticatedInfo**](BackgroundAssistantUserAuthenticatedInfo)|  | [optional]  |

### Return type

[**SignedData**](SignedData)


## PostScreenrecordingToken

> [**SignedData**](SignedData) PostScreenrecordingToken (BackgroundAssistantUserAuthenticatedInfo body = null)


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

            var apiInstance = new BackgroundAssistantApi();
            var body = new BackgroundAssistantUserAuthenticatedInfo(); // BackgroundAssistantUserAuthenticatedInfo |  (optional) 

            try
            { 
                // Sign identifying information for screen recording
                SignedData result = apiInstance.PostScreenrecordingToken(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BackgroundAssistantApi.PostScreenrecordingToken: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**BackgroundAssistantUserAuthenticatedInfo**](BackgroundAssistantUserAuthenticatedInfo)|  | [optional]  |

### Return type

[**SignedData**](SignedData)


_PureCloudPlatform.Client.V2 257.0.0_
