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
{: class="table table-striped"}

<a name="getscript"></a>

## [**Script**](Script.html) GetScript (string scriptId)

Get a script



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scriptId** | **string**| Script ID |  |
{: class="table table-striped"}

### Return type

[**Script**](Script.html)

<a name="getscriptpage"></a>

## [**Page**](Page.html) GetScriptPage (string scriptId, string pageId)

Get a page



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ScriptsApi();
            var scriptId = scriptId_example;  // string | Script ID
            var pageId = pageId_example;  // string | Page ID

            try
            {
                // Get a page
                Page result = apiInstance.GetScriptPage(scriptId, pageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetScriptPage: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scriptId** | **string**| Script ID |  |
| **pageId** | **string**| Page ID |  |
{: class="table table-striped"}

### Return type

[**Page**](Page.html)

<a name="getscriptpages"></a>

## [**List&lt;Page&gt;**](Page.html) GetScriptPages (string scriptId)

Get the list of pages



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ScriptsApi();
            var scriptId = scriptId_example;  // string | Script ID

            try
            {
                // Get the list of pages
                List&lt;Page&gt; result = apiInstance.GetScriptPages(scriptId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetScriptPages: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scriptId** | **string**| Script ID |  |
{: class="table table-striped"}

### Return type

[**List<Page>**](Page.html)

<a name="getscripts"></a>

## [**ScriptEntityListing**](ScriptEntityListing.html) GetScripts (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null)

Get the list of scripts



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ScriptsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var expand = expand_example;  // string | Expand (optional) 
            var name = name_example;  // string | Name filter (optional) 
            var feature = feature_example;  // string | Feature filter (optional) 
            var flowId = flowId_example;  // string | Secure flow id filter (optional) 
            var sortBy = sortBy_example;  // string | SortBy (optional) 
            var sortOrder = sortOrder_example;  // string | SortOrder (optional) 

            try
            {
                // Get the list of scripts
                ScriptEntityListing result = apiInstance.GetScripts(pageSize, pageNumber, expand, name, feature, flowId, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetScripts: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **expand** | **string**| Expand | [optional]  |
| **name** | **string**| Name filter | [optional]  |
| **feature** | **string**| Feature filter | [optional]  |
| **flowId** | **string**| Secure flow id filter | [optional]  |
| **sortBy** | **string**| SortBy | [optional]  |
| **sortOrder** | **string**| SortOrder | [optional]  |
{: class="table table-striped"}

### Return type

[**ScriptEntityListing**](ScriptEntityListing.html)

<a name="getscriptspublished"></a>

## [**ScriptEntityListing**](ScriptEntityListing.html) GetScriptsPublished (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null)

Get the published scripts.



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ScriptsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var expand = expand_example;  // string | Expand (optional) 
            var name = name_example;  // string | Name filter (optional) 
            var feature = feature_example;  // string | Feature filter (optional) 
            var flowId = flowId_example;  // string | Secure flow id filter (optional) 

            try
            {
                // Get the published scripts.
                ScriptEntityListing result = apiInstance.GetScriptsPublished(pageSize, pageNumber, expand, name, feature, flowId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetScriptsPublished: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **expand** | **string**| Expand | [optional]  |
| **name** | **string**| Name filter | [optional]  |
| **feature** | **string**| Feature filter | [optional]  |
| **flowId** | **string**| Secure flow id filter | [optional]  |
{: class="table table-striped"}

### Return type

[**ScriptEntityListing**](ScriptEntityListing.html)

<a name="getscriptspublishedscriptid"></a>

## [**Script**](Script.html) GetScriptsPublishedScriptId (string scriptId)

Get the published script.



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ScriptsApi();
            var scriptId = scriptId_example;  // string | Script ID

            try
            {
                // Get the published script.
                Script result = apiInstance.GetScriptsPublishedScriptId(scriptId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetScriptsPublishedScriptId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scriptId** | **string**| Script ID |  |
{: class="table table-striped"}

### Return type

[**Script**](Script.html)

<a name="getscriptspublishedscriptidpage"></a>

## [**Page**](Page.html) GetScriptsPublishedScriptIdPage (string scriptId, string pageId)

Get the published page.



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ScriptsApi();
            var scriptId = scriptId_example;  // string | Script ID
            var pageId = pageId_example;  // string | Page ID

            try
            {
                // Get the published page.
                Page result = apiInstance.GetScriptsPublishedScriptIdPage(scriptId, pageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetScriptsPublishedScriptIdPage: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scriptId** | **string**| Script ID |  |
| **pageId** | **string**| Page ID |  |
{: class="table table-striped"}

### Return type

[**Page**](Page.html)

<a name="getscriptspublishedscriptidpages"></a>

## [**List&lt;Page&gt;**](Page.html) GetScriptsPublishedScriptIdPages (string scriptId)

Get the list of published pages



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ScriptsApi();
            var scriptId = scriptId_example;  // string | Script ID

            try
            {
                // Get the list of published pages
                List&lt;Page&gt; result = apiInstance.GetScriptsPublishedScriptIdPages(scriptId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetScriptsPublishedScriptIdPages: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scriptId** | **string**| Script ID |  |
{: class="table table-striped"}

### Return type

[**List<Page>**](Page.html)

<a name="getscriptspublishedscriptidvariables"></a>

## **Object** GetScriptsPublishedScriptIdVariables (string scriptId, string input = null, string output = null, string type = null)

Get the published variables



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ScriptsApi();
            var scriptId = scriptId_example;  // string | Script ID
            var input = input_example;  // string | input (optional) 
            var output = output_example;  // string | output (optional) 
            var type = type_example;  // string | type (optional) 

            try
            {
                // Get the published variables
                Object result = apiInstance.GetScriptsPublishedScriptIdVariables(scriptId, input, output, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetScriptsPublishedScriptIdVariables: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scriptId** | **string**| Script ID |  |
| **input** | **string**| input | [optional]  |
| **output** | **string**| output | [optional]  |
| **type** | **string**| type | [optional]  |
{: class="table table-striped"}

### Return type

**Object**

