---
title: MessagingApi
---
## PureCloudPlatform.Client.V2.Api.MessagingApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteMessagingSupportedcontentSupportedContentId**](MessagingApi.html#deletemessagingsupportedcontentsupportedcontentid) | **DELETE** /api/v2/messaging/supportedcontent/{supportedContentId} | Delete a supported content profile |
| [**GetMessagingSupportedcontent**](MessagingApi.html#getmessagingsupportedcontent) | **GET** /api/v2/messaging/supportedcontent | Get a list of Supported Content profiles |
| [**GetMessagingSupportedcontentSupportedContentId**](MessagingApi.html#getmessagingsupportedcontentsupportedcontentid) | **GET** /api/v2/messaging/supportedcontent/{supportedContentId} | Get a supported content profile |
| [**PatchMessagingSupportedcontentSupportedContentId**](MessagingApi.html#patchmessagingsupportedcontentsupportedcontentid) | **PATCH** /api/v2/messaging/supportedcontent/{supportedContentId} | Update a supported content profile |
| [**PostMessagingSupportedcontent**](MessagingApi.html#postmessagingsupportedcontent) | **POST** /api/v2/messaging/supportedcontent | Create a Supported Content profile |
{: class="table table-striped"}

<a name="deletemessagingsupportedcontentsupportedcontentid"></a>

## void DeleteMessagingSupportedcontentSupportedContentId (string supportedContentId)



Delete a supported content profile



Requires ALL permissions: 

* messaging:supportedContent:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteMessagingSupportedcontentSupportedContentIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new MessagingApi();
            var supportedContentId = supportedContentId_example;  // string | Supported Content ID

            try
            { 
                // Delete a supported content profile
                apiInstance.DeleteMessagingSupportedcontentSupportedContentId(supportedContentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.DeleteMessagingSupportedcontentSupportedContentId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **supportedContentId** | **string**| Supported Content ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getmessagingsupportedcontent"></a>

## [**SupportedContentListing**](SupportedContentListing.html) GetMessagingSupportedcontent (int? pageSize = null, int? pageNumber = null)



Get a list of Supported Content profiles



Requires ALL permissions: 

* messaging:supportedContent:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetMessagingSupportedcontentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new MessagingApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get a list of Supported Content profiles
                SupportedContentListing result = apiInstance.GetMessagingSupportedcontent(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.GetMessagingSupportedcontent: " + e.Message );
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

[**SupportedContentListing**](SupportedContentListing.html)

<a name="getmessagingsupportedcontentsupportedcontentid"></a>

## [**SupportedContent**](SupportedContent.html) GetMessagingSupportedcontentSupportedContentId (string supportedContentId)



Get a supported content profile



Requires ALL permissions: 

* messaging:supportedContent:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetMessagingSupportedcontentSupportedContentIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new MessagingApi();
            var supportedContentId = supportedContentId_example;  // string | Supported Content ID

            try
            { 
                // Get a supported content profile
                SupportedContent result = apiInstance.GetMessagingSupportedcontentSupportedContentId(supportedContentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.GetMessagingSupportedcontentSupportedContentId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **supportedContentId** | **string**| Supported Content ID |  |
{: class="table table-striped"}

### Return type

[**SupportedContent**](SupportedContent.html)

<a name="patchmessagingsupportedcontentsupportedcontentid"></a>

## [**SupportedContent**](SupportedContent.html) PatchMessagingSupportedcontentSupportedContentId (string supportedContentId, SupportedContent body)



Update a supported content profile



Requires ALL permissions: 

* messaging:supportedContent:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchMessagingSupportedcontentSupportedContentIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new MessagingApi();
            var supportedContentId = supportedContentId_example;  // string | Supported Content ID
            var body = new SupportedContent(); // SupportedContent | SupportedContent

            try
            { 
                // Update a supported content profile
                SupportedContent result = apiInstance.PatchMessagingSupportedcontentSupportedContentId(supportedContentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.PatchMessagingSupportedcontentSupportedContentId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **supportedContentId** | **string**| Supported Content ID |  |
| **body** | [**SupportedContent**](SupportedContent.html)| SupportedContent |  |
{: class="table table-striped"}

### Return type

[**SupportedContent**](SupportedContent.html)

<a name="postmessagingsupportedcontent"></a>

## [**SupportedContent**](SupportedContent.html) PostMessagingSupportedcontent (SupportedContent body)



Create a Supported Content profile



Requires ANY permissions: 

* messaging:supportedContent:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostMessagingSupportedcontentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new MessagingApi();
            var body = new SupportedContent(); // SupportedContent | SupportedContent

            try
            { 
                // Create a Supported Content profile
                SupportedContent result = apiInstance.PostMessagingSupportedcontent(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.PostMessagingSupportedcontent: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SupportedContent**](SupportedContent.html)| SupportedContent |  |
{: class="table table-striped"}

### Return type

[**SupportedContent**](SupportedContent.html)

