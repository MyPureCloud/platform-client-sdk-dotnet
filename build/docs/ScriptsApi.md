---
title: ScriptsApi
---
## PureCloudPlatform.Client.V2.Api.ScriptsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetScript**](ScriptsApi.html#getscript) | **GET** /api/v2/scripts/{scriptId} | Get a script |
| [**GetScriptPage**](ScriptsApi.html#getscriptpage) | **GET** /api/v2/scripts/{scriptId}/pages/{pageId} | Get a page |
| [**GetScriptPages**](ScriptsApi.html#getscriptpages) | **GET** /api/v2/scripts/{scriptId}/pages | Get the list of pages |
| [**GetScripts**](ScriptsApi.html#getscripts) | **GET** /api/v2/scripts | Get the list of scripts |
| [**GetScriptsPublished**](ScriptsApi.html#getscriptspublished) | **GET** /api/v2/scripts/published | Get the published scripts. |
| [**GetScriptsPublishedScriptId**](ScriptsApi.html#getscriptspublishedscriptid) | **GET** /api/v2/scripts/published/{scriptId} | Get the published script. |
| [**GetScriptsPublishedScriptIdPage**](ScriptsApi.html#getscriptspublishedscriptidpage) | **GET** /api/v2/scripts/published/{scriptId}/pages/{pageId} | Get the published page. |
| [**GetScriptsPublishedScriptIdPages**](ScriptsApi.html#getscriptspublishedscriptidpages) | **GET** /api/v2/scripts/published/{scriptId}/pages | Get the list of published pages |
| [**GetScriptsPublishedScriptIdVariables**](ScriptsApi.html#getscriptspublishedscriptidvariables) | **GET** /api/v2/scripts/published/{scriptId}/variables | Get the published variables |
| [**GetScriptsUploadStatus**](ScriptsApi.html#getscriptsuploadstatus) | **GET** /api/v2/scripts/uploads/{uploadId}/status | Get the upload status of an imported script |
| [**PostScriptExport**](ScriptsApi.html#postscriptexport) | **POST** /api/v2/scripts/{scriptId}/export | Export a script via download service. |
{: class="table table-striped"}

<a name="getscript"></a>

## [**Script**](Script.html) GetScript (string scriptId)



Get a script



Requires ANY permissions: 

* scripter:script:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetScriptExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ScriptsApi();
            var scriptId = scriptId_example;  // string | Script ID

            try
            { 
                // Get a script
                Script result = apiInstance.GetScript(scriptId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetScript: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scriptId** | **string**| Script ID |  |
{: class="table table-striped"}

### Return type

[**Script**](Script.html)

<a name="getscriptpage"></a>

## [**Page**](Page.html) GetScriptPage (string scriptId, string pageId, string scriptDataVersion = null)



Get a page



Requires ANY permissions: 

* scripter:script:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetScriptPageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ScriptsApi();
            var scriptId = scriptId_example;  // string | Script ID
            var pageId = pageId_example;  // string | Page ID
            var scriptDataVersion = scriptDataVersion_example;  // string | Advanced usage - controls the data version of the script (optional) 

            try
            { 
                // Get a page
                Page result = apiInstance.GetScriptPage(scriptId, pageId, scriptDataVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetScriptPage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scriptId** | **string**| Script ID |  |
| **pageId** | **string**| Page ID |  |
| **scriptDataVersion** | **string**| Advanced usage - controls the data version of the script | [optional]  |
{: class="table table-striped"}

### Return type

[**Page**](Page.html)

<a name="getscriptpages"></a>

## [**List&lt;Page&gt;**](Page.html) GetScriptPages (string scriptId, string scriptDataVersion = null)



Get the list of pages



Requires ANY permissions: 

* scripter:script:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetScriptPagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ScriptsApi();
            var scriptId = scriptId_example;  // string | Script ID
            var scriptDataVersion = scriptDataVersion_example;  // string | Advanced usage - controls the data version of the script (optional) 

            try
            { 
                // Get the list of pages
                List<Page> result = apiInstance.GetScriptPages(scriptId, scriptDataVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetScriptPages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scriptId** | **string**| Script ID |  |
| **scriptDataVersion** | **string**| Advanced usage - controls the data version of the script | [optional]  |
{: class="table table-striped"}

### Return type

[**List<Page>**](Page.html)

<a name="getscripts"></a>

## [**ScriptEntityListing**](ScriptEntityListing.html) GetScripts (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null, string scriptDataVersion = null)



Get the list of scripts



Requires ANY permissions: 

* scripter:script:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetScriptsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ScriptsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var expand = expand_example;  // string | Expand (optional) 
            var name = name_example;  // string | Name filter (optional) 
            var feature = feature_example;  // string | Feature filter (optional) 
            var flowId = flowId_example;  // string | Secure flow id filter (optional) 
            var sortBy = sortBy_example;  // string | SortBy (optional) 
            var sortOrder = sortOrder_example;  // string | SortOrder (optional) 
            var scriptDataVersion = scriptDataVersion_example;  // string | Advanced usage - controls the data version of the script (optional) 

            try
            { 
                // Get the list of scripts
                ScriptEntityListing result = apiInstance.GetScripts(pageSize, pageNumber, expand, name, feature, flowId, sortBy, sortOrder, scriptDataVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetScripts: " + e.Message );
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
| **expand** | **string**| Expand | [optional]  |
| **name** | **string**| Name filter | [optional]  |
| **feature** | **string**| Feature filter | [optional]  |
| **flowId** | **string**| Secure flow id filter | [optional]  |
| **sortBy** | **string**| SortBy | [optional] <br />**Values**: modifiedDate, createdDate |
| **sortOrder** | **string**| SortOrder | [optional] <br />**Values**: ascending, descending |
| **scriptDataVersion** | **string**| Advanced usage - controls the data version of the script | [optional]  |
{: class="table table-striped"}

### Return type

[**ScriptEntityListing**](ScriptEntityListing.html)

<a name="getscriptspublished"></a>

## [**ScriptEntityListing**](ScriptEntityListing.html) GetScriptsPublished (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string scriptDataVersion = null)



Get the published scripts.



Requires ANY permissions: 

* scripter:publishedScript:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetScriptsPublishedExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ScriptsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var expand = expand_example;  // string | Expand (optional) 
            var name = name_example;  // string | Name filter (optional) 
            var feature = feature_example;  // string | Feature filter (optional) 
            var flowId = flowId_example;  // string | Secure flow id filter (optional) 
            var scriptDataVersion = scriptDataVersion_example;  // string | Advanced usage - controls the data version of the script (optional) 

            try
            { 
                // Get the published scripts.
                ScriptEntityListing result = apiInstance.GetScriptsPublished(pageSize, pageNumber, expand, name, feature, flowId, scriptDataVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetScriptsPublished: " + e.Message );
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
| **expand** | **string**| Expand | [optional]  |
| **name** | **string**| Name filter | [optional]  |
| **feature** | **string**| Feature filter | [optional]  |
| **flowId** | **string**| Secure flow id filter | [optional]  |
| **scriptDataVersion** | **string**| Advanced usage - controls the data version of the script | [optional]  |
{: class="table table-striped"}

### Return type

[**ScriptEntityListing**](ScriptEntityListing.html)

<a name="getscriptspublishedscriptid"></a>

## [**Script**](Script.html) GetScriptsPublishedScriptId (string scriptId, string scriptDataVersion = null)



Get the published script.



Requires ANY permissions: 

* scripter:publishedScript:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetScriptsPublishedScriptIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ScriptsApi();
            var scriptId = scriptId_example;  // string | Script ID
            var scriptDataVersion = scriptDataVersion_example;  // string | Advanced usage - controls the data version of the script (optional) 

            try
            { 
                // Get the published script.
                Script result = apiInstance.GetScriptsPublishedScriptId(scriptId, scriptDataVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetScriptsPublishedScriptId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scriptId** | **string**| Script ID |  |
| **scriptDataVersion** | **string**| Advanced usage - controls the data version of the script | [optional]  |
{: class="table table-striped"}

### Return type

[**Script**](Script.html)

<a name="getscriptspublishedscriptidpage"></a>

## [**Page**](Page.html) GetScriptsPublishedScriptIdPage (string scriptId, string pageId, string scriptDataVersion = null)



Get the published page.



Requires ANY permissions: 

* scripter:publishedScript:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetScriptsPublishedScriptIdPageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ScriptsApi();
            var scriptId = scriptId_example;  // string | Script ID
            var pageId = pageId_example;  // string | Page ID
            var scriptDataVersion = scriptDataVersion_example;  // string | Advanced usage - controls the data version of the script (optional) 

            try
            { 
                // Get the published page.
                Page result = apiInstance.GetScriptsPublishedScriptIdPage(scriptId, pageId, scriptDataVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetScriptsPublishedScriptIdPage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scriptId** | **string**| Script ID |  |
| **pageId** | **string**| Page ID |  |
| **scriptDataVersion** | **string**| Advanced usage - controls the data version of the script | [optional]  |
{: class="table table-striped"}

### Return type

[**Page**](Page.html)

<a name="getscriptspublishedscriptidpages"></a>

## [**List&lt;Page&gt;**](Page.html) GetScriptsPublishedScriptIdPages (string scriptId, string scriptDataVersion = null)



Get the list of published pages



Requires ANY permissions: 

* scripter:publishedScript:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetScriptsPublishedScriptIdPagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ScriptsApi();
            var scriptId = scriptId_example;  // string | Script ID
            var scriptDataVersion = scriptDataVersion_example;  // string | Advanced usage - controls the data version of the script (optional) 

            try
            { 
                // Get the list of published pages
                List<Page> result = apiInstance.GetScriptsPublishedScriptIdPages(scriptId, scriptDataVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetScriptsPublishedScriptIdPages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scriptId** | **string**| Script ID |  |
| **scriptDataVersion** | **string**| Advanced usage - controls the data version of the script | [optional]  |
{: class="table table-striped"}

### Return type

[**List<Page>**](Page.html)

<a name="getscriptspublishedscriptidvariables"></a>

## **Object** GetScriptsPublishedScriptIdVariables (string scriptId, string input = null, string output = null, string type = null, string scriptDataVersion = null)



Get the published variables



Requires ANY permissions: 

* scripter:publishedScript:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetScriptsPublishedScriptIdVariablesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ScriptsApi();
            var scriptId = scriptId_example;  // string | Script ID
            var input = input_example;  // string | input (optional) 
            var output = output_example;  // string | output (optional) 
            var type = type_example;  // string | type (optional) 
            var scriptDataVersion = scriptDataVersion_example;  // string | Advanced usage - controls the data version of the script (optional) 

            try
            { 
                // Get the published variables
                Object result = apiInstance.GetScriptsPublishedScriptIdVariables(scriptId, input, output, type, scriptDataVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetScriptsPublishedScriptIdVariables: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scriptId** | **string**| Script ID |  |
| **input** | **string**| input | [optional]  |
| **output** | **string**| output | [optional]  |
| **type** | **string**| type | [optional]  |
| **scriptDataVersion** | **string**| Advanced usage - controls the data version of the script | [optional]  |
{: class="table table-striped"}

### Return type

**Object**

<a name="getscriptsuploadstatus"></a>

## [**ImportScriptStatusResponse**](ImportScriptStatusResponse.html) GetScriptsUploadStatus (string uploadId, bool? longPoll = null)



Get the upload status of an imported script



Requires ANY permissions: 

* scripter:script:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetScriptsUploadStatusExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ScriptsApi();
            var uploadId = uploadId_example;  // string | Upload ID
            var longPoll = true;  // bool? | Enable longPolling endpoint (optional)  (default to false)

            try
            { 
                // Get the upload status of an imported script
                ImportScriptStatusResponse result = apiInstance.GetScriptsUploadStatus(uploadId, longPoll);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetScriptsUploadStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **uploadId** | **string**| Upload ID |  |
| **longPoll** | **bool?**| Enable longPolling endpoint | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**ImportScriptStatusResponse**](ImportScriptStatusResponse.html)

<a name="postscriptexport"></a>

## [**ExportScriptResponse**](ExportScriptResponse.html) PostScriptExport (string scriptId, ExportScriptRequest body = null)



Export a script via download service.



Requires ANY permissions: 

* scripter:script:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostScriptExportExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ScriptsApi();
            var scriptId = scriptId_example;  // string | Script ID
            var body = new ExportScriptRequest(); // ExportScriptRequest |  (optional) 

            try
            { 
                // Export a script via download service.
                ExportScriptResponse result = apiInstance.PostScriptExport(scriptId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.PostScriptExport: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scriptId** | **string**| Script ID |  |
| **body** | [**ExportScriptRequest**](ExportScriptRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**ExportScriptResponse**](ExportScriptResponse.html)

