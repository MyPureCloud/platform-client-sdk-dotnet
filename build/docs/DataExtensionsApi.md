# DataExtensionsApi

## PureCloudPlatform.Client.V2.Api.DataExtensionsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetDataextensionsCoretype**](#GetDataextensionsCoretype) | **Get** /api/v2/dataextensions/coretypes/{coretypeName} | Get a specific named core type. |
| [**GetDataextensionsCoretypes**](#GetDataextensionsCoretypes) | **Get** /api/v2/dataextensions/coretypes | Get the core types from which all schemas are built. |
| [**GetDataextensionsLimits**](#GetDataextensionsLimits) | **Get** /api/v2/dataextensions/limits | Get quantitative limits on schemas |



## GetDataextensionsCoretype

> [**Coretype**](Coretype) GetDataextensionsCoretype (string coretypeName)


Get a specific named core type.

Requires ANY permissions: 

* externalContacts:customFields:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetDataextensionsCoretypeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new DataExtensionsApi();
            var coretypeName = coretypeName_example;  // string | The core type's name

            try
            { 
                // Get a specific named core type.
                Coretype result = apiInstance.GetDataextensionsCoretype(coretypeName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataExtensionsApi.GetDataextensionsCoretype: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **coretypeName** | **string**| The core type&#39;s name | <br />**Values**: text, longtext, url, identifier, enum, date, datetime, integer, number, checkbox, tag |

### Return type

[**Coretype**](Coretype)


## GetDataextensionsCoretypes

> [**CoretypeListing**](CoretypeListing) GetDataextensionsCoretypes ()


Get the core types from which all schemas are built.

Requires ANY permissions: 

* externalContacts:customFields:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetDataextensionsCoretypesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new DataExtensionsApi();

            try
            { 
                // Get the core types from which all schemas are built.
                CoretypeListing result = apiInstance.GetDataextensionsCoretypes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataExtensionsApi.GetDataextensionsCoretypes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**CoretypeListing**](CoretypeListing)


## GetDataextensionsLimits

> [**SchemaQuantityLimits**](SchemaQuantityLimits) GetDataextensionsLimits ()


Get quantitative limits on schemas

Requires ANY permissions: 

* externalContacts:customFields:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetDataextensionsLimitsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new DataExtensionsApi();

            try
            { 
                // Get quantitative limits on schemas
                SchemaQuantityLimits result = apiInstance.GetDataextensionsLimits();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataExtensionsApi.GetDataextensionsLimits: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**SchemaQuantityLimits**](SchemaQuantityLimits)


_PureCloudPlatform.Client.V2 249.0.0_
