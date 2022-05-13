---
title: ResponseManagementApi
---
## PureCloudPlatform.Client.V2.Api.ResponseManagementApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteResponsemanagementLibrary**](ResponseManagementApi.html#deleteresponsemanagementlibrary) | **DELETE** /api/v2/responsemanagement/libraries/{libraryId} | Delete an existing response library. |
| [**DeleteResponsemanagementResponse**](ResponseManagementApi.html#deleteresponsemanagementresponse) | **DELETE** /api/v2/responsemanagement/responses/{responseId} | Delete an existing response. |
| [**DeleteResponsemanagementResponseasset**](ResponseManagementApi.html#deleteresponsemanagementresponseasset) | **DELETE** /api/v2/responsemanagement/responseassets/{responseAssetId} | Delete response asset |
| [**GetResponsemanagementLibraries**](ResponseManagementApi.html#getresponsemanagementlibraries) | **GET** /api/v2/responsemanagement/libraries | Gets a list of existing response libraries. |
| [**GetResponsemanagementLibrary**](ResponseManagementApi.html#getresponsemanagementlibrary) | **GET** /api/v2/responsemanagement/libraries/{libraryId} | Get details about an existing response library. |
| [**GetResponsemanagementResponse**](ResponseManagementApi.html#getresponsemanagementresponse) | **GET** /api/v2/responsemanagement/responses/{responseId} | Get details about an existing response. |
| [**GetResponsemanagementResponseasset**](ResponseManagementApi.html#getresponsemanagementresponseasset) | **GET** /api/v2/responsemanagement/responseassets/{responseAssetId} | Get response asset information |
| [**GetResponsemanagementResponseassetsStatusStatusId**](ResponseManagementApi.html#getresponsemanagementresponseassetsstatusstatusid) | **GET** /api/v2/responsemanagement/responseassets/status/{statusId} | Get response asset upload status |
| [**GetResponsemanagementResponses**](ResponseManagementApi.html#getresponsemanagementresponses) | **GET** /api/v2/responsemanagement/responses | Gets a list of existing responses. |
| [**PostResponsemanagementLibraries**](ResponseManagementApi.html#postresponsemanagementlibraries) | **POST** /api/v2/responsemanagement/libraries | Create a response library. |
| [**PostResponsemanagementResponseassetsSearch**](ResponseManagementApi.html#postresponsemanagementresponseassetssearch) | **POST** /api/v2/responsemanagement/responseassets/search | Search response assets |
| [**PostResponsemanagementResponseassetsUploads**](ResponseManagementApi.html#postresponsemanagementresponseassetsuploads) | **POST** /api/v2/responsemanagement/responseassets/uploads | Creates pre-signed url for uploading response asset |
| [**PostResponsemanagementResponses**](ResponseManagementApi.html#postresponsemanagementresponses) | **POST** /api/v2/responsemanagement/responses | Create a response. |
| [**PostResponsemanagementResponsesQuery**](ResponseManagementApi.html#postresponsemanagementresponsesquery) | **POST** /api/v2/responsemanagement/responses/query | Query responses |
| [**PutResponsemanagementLibrary**](ResponseManagementApi.html#putresponsemanagementlibrary) | **PUT** /api/v2/responsemanagement/libraries/{libraryId} | Update an existing response library. |
| [**PutResponsemanagementResponse**](ResponseManagementApi.html#putresponsemanagementresponse) | **PUT** /api/v2/responsemanagement/responses/{responseId} | Update an existing response. |
| [**PutResponsemanagementResponseasset**](ResponseManagementApi.html#putresponsemanagementresponseasset) | **PUT** /api/v2/responsemanagement/responseassets/{responseAssetId} | Update response asset |
{: class="table table-striped"}

<a name="deleteresponsemanagementlibrary"></a>

## void DeleteResponsemanagementLibrary (string libraryId)



Delete an existing response library.

This will remove any responses associated with the library.



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
    public class DeleteResponsemanagementLibraryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ResponseManagementApi();
            var libraryId = libraryId_example;  // string | Library ID

            try
            { 
                // Delete an existing response library.
                apiInstance.DeleteResponsemanagementLibrary(libraryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.DeleteResponsemanagementLibrary: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **libraryId** | **string**| Library ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteresponsemanagementresponse"></a>

## void DeleteResponsemanagementResponse (string responseId)



Delete an existing response.

This will remove the response from any libraries associated with it.



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
    public class DeleteResponsemanagementResponseExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ResponseManagementApi();
            var responseId = responseId_example;  // string | Response ID

            try
            { 
                // Delete an existing response.
                apiInstance.DeleteResponsemanagementResponse(responseId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.DeleteResponsemanagementResponse: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **responseId** | **string**| Response ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteresponsemanagementresponseasset"></a>

## void DeleteResponsemanagementResponseasset (string responseAssetId)



Delete response asset



Requires ANY permissions: 

* responseAssets:asset:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteResponsemanagementResponseassetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ResponseManagementApi();
            var responseAssetId = responseAssetId_example;  // string | Asset Id

            try
            { 
                // Delete response asset
                apiInstance.DeleteResponsemanagementResponseasset(responseAssetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.DeleteResponsemanagementResponseasset: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **responseAssetId** | **string**| Asset Id |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getresponsemanagementlibraries"></a>

## [**LibraryEntityListing**](LibraryEntityListing.html) GetResponsemanagementLibraries (int? pageNumber = null, int? pageSize = null, string messagingTemplateFilter = null)



Gets a list of existing response libraries.



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
    public class GetResponsemanagementLibrariesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ResponseManagementApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var messagingTemplateFilter = messagingTemplateFilter_example;  // string | Returns a list of libraries that contain responses with at least one messaging template defined for a specific message channel (optional) 

            try
            { 
                // Gets a list of existing response libraries.
                LibraryEntityListing result = apiInstance.GetResponsemanagementLibraries(pageNumber, pageSize, messagingTemplateFilter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.GetResponsemanagementLibraries: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **messagingTemplateFilter** | **string**| Returns a list of libraries that contain responses with at least one messaging template defined for a specific message channel | [optional] <br />**Values**: whatsapp |
{: class="table table-striped"}

### Return type

[**LibraryEntityListing**](LibraryEntityListing.html)

<a name="getresponsemanagementlibrary"></a>

## [**Library**](Library.html) GetResponsemanagementLibrary (string libraryId)



Get details about an existing response library.



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
    public class GetResponsemanagementLibraryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ResponseManagementApi();
            var libraryId = libraryId_example;  // string | Library ID

            try
            { 
                // Get details about an existing response library.
                Library result = apiInstance.GetResponsemanagementLibrary(libraryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.GetResponsemanagementLibrary: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **libraryId** | **string**| Library ID |  |
{: class="table table-striped"}

### Return type

[**Library**](Library.html)

<a name="getresponsemanagementresponse"></a>

## [**Response**](Response.html) GetResponsemanagementResponse (string responseId, string expand = null)



Get details about an existing response.



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
    public class GetResponsemanagementResponseExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ResponseManagementApi();
            var responseId = responseId_example;  // string | Response ID
            var expand = expand_example;  // string | Expand instructions for the return value. (optional) 

            try
            { 
                // Get details about an existing response.
                Response result = apiInstance.GetResponsemanagementResponse(responseId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.GetResponsemanagementResponse: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **responseId** | **string**| Response ID |  |
| **expand** | **string**| Expand instructions for the return value. | [optional] <br />**Values**: substitutionsSchema |
{: class="table table-striped"}

### Return type

[**Response**](Response.html)

<a name="getresponsemanagementresponseasset"></a>

## [**ResponseAsset**](ResponseAsset.html) GetResponsemanagementResponseasset (string responseAssetId)



Get response asset information



Requires ANY permissions: 

* responseAssets:asset:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetResponsemanagementResponseassetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ResponseManagementApi();
            var responseAssetId = responseAssetId_example;  // string | Asset Id

            try
            { 
                // Get response asset information
                ResponseAsset result = apiInstance.GetResponsemanagementResponseasset(responseAssetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.GetResponsemanagementResponseasset: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **responseAssetId** | **string**| Asset Id |  |
{: class="table table-striped"}

### Return type

[**ResponseAsset**](ResponseAsset.html)

<a name="getresponsemanagementresponseassetsstatusstatusid"></a>

## [**ResponseAssetStatus**](ResponseAssetStatus.html) GetResponsemanagementResponseassetsStatusStatusId (string statusId)



Get response asset upload status



Requires ANY permissions: 

* responseAssets:asset:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetResponsemanagementResponseassetsStatusStatusIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ResponseManagementApi();
            var statusId = statusId_example;  // string | Status Id

            try
            { 
                // Get response asset upload status
                ResponseAssetStatus result = apiInstance.GetResponsemanagementResponseassetsStatusStatusId(statusId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.GetResponsemanagementResponseassetsStatusStatusId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **statusId** | **string**| Status Id |  |
{: class="table table-striped"}

### Return type

[**ResponseAssetStatus**](ResponseAssetStatus.html)

<a name="getresponsemanagementresponses"></a>

## [**ResponseEntityListing**](ResponseEntityListing.html) GetResponsemanagementResponses (string libraryId, int? pageNumber = null, int? pageSize = null, string expand = null)



Gets a list of existing responses.



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
    public class GetResponsemanagementResponsesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ResponseManagementApi();
            var libraryId = libraryId_example;  // string | Library ID
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var expand = expand_example;  // string | Expand instructions for the return value. (optional) 

            try
            { 
                // Gets a list of existing responses.
                ResponseEntityListing result = apiInstance.GetResponsemanagementResponses(libraryId, pageNumber, pageSize, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.GetResponsemanagementResponses: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **libraryId** | **string**| Library ID |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **expand** | **string**| Expand instructions for the return value. | [optional] <br />**Values**: substitutionsSchema |
{: class="table table-striped"}

### Return type

[**ResponseEntityListing**](ResponseEntityListing.html)

<a name="postresponsemanagementlibraries"></a>

## [**Library**](Library.html) PostResponsemanagementLibraries (Library body)



Create a response library.



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
    public class PostResponsemanagementLibrariesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ResponseManagementApi();
            var body = new Library(); // Library | Library

            try
            { 
                // Create a response library.
                Library result = apiInstance.PostResponsemanagementLibraries(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.PostResponsemanagementLibraries: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Library**](Library.html)| Library |  |
{: class="table table-striped"}

### Return type

[**Library**](Library.html)

<a name="postresponsemanagementresponseassetssearch"></a>

## [**ResponseAssetSearchResults**](ResponseAssetSearchResults.html) PostResponsemanagementResponseassetsSearch (ResponseAssetSearchRequest body, List<string> expand = null)



Search response assets



Requires ALL permissions: 

* responseAssets:asset:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostResponsemanagementResponseassetsSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ResponseManagementApi();
            var body = new ResponseAssetSearchRequest(); // ResponseAssetSearchRequest | request
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            { 
                // Search response assets
                ResponseAssetSearchResults result = apiInstance.PostResponsemanagementResponseassetsSearch(body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.PostResponsemanagementResponseassetsSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ResponseAssetSearchRequest**](ResponseAssetSearchRequest.html)| request |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: user, division |
{: class="table table-striped"}

### Return type

[**ResponseAssetSearchResults**](ResponseAssetSearchResults.html)

<a name="postresponsemanagementresponseassetsuploads"></a>

## [**CreateResponseAssetResponse**](CreateResponseAssetResponse.html) PostResponsemanagementResponseassetsUploads (CreateResponseAssetRequest body)



Creates pre-signed url for uploading response asset



Requires ANY permissions: 

* responseAssets:asset:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostResponsemanagementResponseassetsUploadsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ResponseManagementApi();
            var body = new CreateResponseAssetRequest(); // CreateResponseAssetRequest | request

            try
            { 
                // Creates pre-signed url for uploading response asset
                CreateResponseAssetResponse result = apiInstance.PostResponsemanagementResponseassetsUploads(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.PostResponsemanagementResponseassetsUploads: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateResponseAssetRequest**](CreateResponseAssetRequest.html)| request |  |
{: class="table table-striped"}

### Return type

[**CreateResponseAssetResponse**](CreateResponseAssetResponse.html)

<a name="postresponsemanagementresponses"></a>

## [**Response**](Response.html) PostResponsemanagementResponses (Response body, string expand = null)



Create a response.



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
    public class PostResponsemanagementResponsesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ResponseManagementApi();
            var body = new Response(); // Response | Response
            var expand = expand_example;  // string | Expand instructions for the return value. (optional) 

            try
            { 
                // Create a response.
                Response result = apiInstance.PostResponsemanagementResponses(body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.PostResponsemanagementResponses: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Response**](Response.html)| Response |  |
| **expand** | **string**| Expand instructions for the return value. | [optional] <br />**Values**: substitutionsSchema |
{: class="table table-striped"}

### Return type

[**Response**](Response.html)

<a name="postresponsemanagementresponsesquery"></a>

## [**ResponseQueryResults**](ResponseQueryResults.html) PostResponsemanagementResponsesQuery (ResponseQueryRequest body)



Query responses



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
    public class PostResponsemanagementResponsesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ResponseManagementApi();
            var body = new ResponseQueryRequest(); // ResponseQueryRequest | Response

            try
            { 
                // Query responses
                ResponseQueryResults result = apiInstance.PostResponsemanagementResponsesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.PostResponsemanagementResponsesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ResponseQueryRequest**](ResponseQueryRequest.html)| Response |  |
{: class="table table-striped"}

### Return type

[**ResponseQueryResults**](ResponseQueryResults.html)

<a name="putresponsemanagementlibrary"></a>

## [**Library**](Library.html) PutResponsemanagementLibrary (string libraryId, Library body)



Update an existing response library.

Fields that can be updated: name. The most recent version is required for updates.



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
    public class PutResponsemanagementLibraryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ResponseManagementApi();
            var libraryId = libraryId_example;  // string | Library ID
            var body = new Library(); // Library | Library

            try
            { 
                // Update an existing response library.
                Library result = apiInstance.PutResponsemanagementLibrary(libraryId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.PutResponsemanagementLibrary: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **libraryId** | **string**| Library ID |  |
| **body** | [**Library**](Library.html)| Library |  |
{: class="table table-striped"}

### Return type

[**Library**](Library.html)

<a name="putresponsemanagementresponse"></a>

## [**Response**](Response.html) PutResponsemanagementResponse (string responseId, Response body, string expand = null)



Update an existing response.

Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.



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
    public class PutResponsemanagementResponseExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ResponseManagementApi();
            var responseId = responseId_example;  // string | Response ID
            var body = new Response(); // Response | Response
            var expand = expand_example;  // string | Expand instructions for the return value. (optional) 

            try
            { 
                // Update an existing response.
                Response result = apiInstance.PutResponsemanagementResponse(responseId, body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.PutResponsemanagementResponse: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **responseId** | **string**| Response ID |  |
| **body** | [**Response**](Response.html)| Response |  |
| **expand** | **string**| Expand instructions for the return value. | [optional] <br />**Values**: substitutionsSchema |
{: class="table table-striped"}

### Return type

[**Response**](Response.html)

<a name="putresponsemanagementresponseasset"></a>

## [**ResponseAsset**](ResponseAsset.html) PutResponsemanagementResponseasset (string responseAssetId, ResponseAssetRequest body)



Update response asset



Requires ALL permissions: 

* responseAssets:asset:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutResponsemanagementResponseassetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ResponseManagementApi();
            var responseAssetId = responseAssetId_example;  // string | Asset Id
            var body = new ResponseAssetRequest(); // ResponseAssetRequest | request

            try
            { 
                // Update response asset
                ResponseAsset result = apiInstance.PutResponsemanagementResponseasset(responseAssetId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.PutResponsemanagementResponseasset: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **responseAssetId** | **string**| Asset Id |  |
| **body** | [**ResponseAssetRequest**](ResponseAssetRequest.html)| request |  |
{: class="table table-striped"}

### Return type

[**ResponseAsset**](ResponseAsset.html)

