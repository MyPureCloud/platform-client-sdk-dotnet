# DownloadsApi

## PureCloudPlatform.Client.V2.Api.DownloadsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetDownload**](#GetDownload) | **Get** /api/v2/downloads/{downloadId} | Issues a redirect to a signed secure download URL for specified download |



## GetDownload

> [**UrlResponse**](UrlResponse) GetDownload (string downloadId, string contentDisposition = null, bool? issueRedirect = null, bool? redirectToAuth = null)


Issues a redirect to a signed secure download URL for specified download

this method will issue a redirect to the url to the content

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
    public class GetDownloadExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new DownloadsApi();
            var downloadId = downloadId_example;  // string | Download ID
            var contentDisposition = contentDisposition_example;  // string |  (optional) 
            var issueRedirect = true;  // bool? |  (optional)  (default to true)
            var redirectToAuth = true;  // bool? |  (optional)  (default to true)

            try
            { 
                // Issues a redirect to a signed secure download URL for specified download
                UrlResponse result = apiInstance.GetDownload(downloadId, contentDisposition, issueRedirect, redirectToAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DownloadsApi.GetDownload: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **downloadId** | **string**| Download ID |  |
| **contentDisposition** | **string**|  | [optional]  |
| **issueRedirect** | **bool?**|  | [optional] [default to true] |
| **redirectToAuth** | **bool?**|  | [optional] [default to true] |

### Return type

[**UrlResponse**](UrlResponse)


_PureCloudPlatform.Client.V2 222.0.0_
