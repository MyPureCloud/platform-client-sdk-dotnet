# ScriptsApi

## PureCloudPlatform.Client.V2.Api.ScriptsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetScript**](#GetScript) | **Get** /api/v2/scripts/{scriptId} | Get a script |
| [**GetScriptPage**](#GetScriptPage) | **Get** /api/v2/scripts/{scriptId}/pages/{pageId} | Get a page |
| [**GetScriptPages**](#GetScriptPages) | **Get** /api/v2/scripts/{scriptId}/pages | Get the list of pages |
| [**GetScripts**](#GetScripts) | **Get** /api/v2/scripts | Get the list of scripts |
| [**GetScriptsDivisionviews**](#GetScriptsDivisionviews) | **Get** /api/v2/scripts/divisionviews | Get the metadata for a list of scripts |
| [**GetScriptsPublished**](#GetScriptsPublished) | **Get** /api/v2/scripts/published | Get the published scripts. |
| [**GetScriptsPublishedDivisionviewVariables**](#GetScriptsPublishedDivisionviewVariables) | **Get** /api/v2/scripts/published/divisionviews/{scriptId}/variables | Get the published variables |
| [**GetScriptsPublishedDivisionviews**](#GetScriptsPublishedDivisionviews) | **Get** /api/v2/scripts/published/divisionviews | Get the published scripts metadata. |
| [**GetScriptsPublishedScriptId**](#GetScriptsPublishedScriptId) | **Get** /api/v2/scripts/published/{scriptId} | Get the published script. |
| [**GetScriptsPublishedScriptIdPage**](#GetScriptsPublishedScriptIdPage) | **Get** /api/v2/scripts/published/{scriptId}/pages/{pageId} | Get the published page. |
| [**GetScriptsPublishedScriptIdPages**](#GetScriptsPublishedScriptIdPages) | **Get** /api/v2/scripts/published/{scriptId}/pages | Get the list of published pages |
| [**GetScriptsPublishedScriptIdVariables**](#GetScriptsPublishedScriptIdVariables) | **Get** /api/v2/scripts/published/{scriptId}/variables | Get the published variables |
| [**GetScriptsUploadStatus**](#GetScriptsUploadStatus) | **Get** /api/v2/scripts/uploads/{uploadId}/status | Get the upload status of an imported script |
| [**PostScriptExport**](#PostScriptExport) | **Post** /api/v2/scripts/{scriptId}/export | Export a script via download service. |
| [**PostScriptsPublished**](#PostScriptsPublished) | **Post** /api/v2/scripts/published | Publish a script. |



## GetScript

> [**Script**](Script) GetScript (string scriptId)


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

### Return type

[**Script**](Script)


## GetScriptPage

> [**Page**](Page) GetScriptPage (string scriptId, string pageId, string scriptDataVersion = null)


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

### Return type

[**Page**](Page)


## GetScriptPages

> [**List&lt;Page&gt;**](Page) GetScriptPages (string scriptId, string scriptDataVersion = null)


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

### Return type

[**List<Page>**](Page)


## GetScripts

> [**ScriptEntityListing**](ScriptEntityListing) GetScripts (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null, string scriptDataVersion = null, string divisionIds = null)


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
            var divisionIds = divisionIds_example;  // string | Filters scripts to requested divisionIds (optional) 

            try
            { 
                // Get the list of scripts
                ScriptEntityListing result = apiInstance.GetScripts(pageSize, pageNumber, expand, name, feature, flowId, sortBy, sortOrder, scriptDataVersion, divisionIds);
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
| **sortBy** | **string**| SortBy | [optional] <br />**Values**: modifiedDate, createdDate, name |
| **sortOrder** | **string**| SortOrder | [optional] <br />**Values**: ascending, descending |
| **scriptDataVersion** | **string**| Advanced usage - controls the data version of the script | [optional]  |
| **divisionIds** | **string**| Filters scripts to requested divisionIds | [optional]  |

### Return type

[**ScriptEntityListing**](ScriptEntityListing)


## GetScriptsDivisionviews

> [**ScriptEntityListing**](ScriptEntityListing) GetScriptsDivisionviews (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null, string scriptDataVersion = null, string divisionIds = null)


Get the metadata for a list of scripts

Requires ANY permissions: 

* scripter:script:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetScriptsDivisionviewsExample
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
            var divisionIds = divisionIds_example;  // string | Filters scripts to requested divisionIds (optional) 

            try
            { 
                // Get the metadata for a list of scripts
                ScriptEntityListing result = apiInstance.GetScriptsDivisionviews(pageSize, pageNumber, expand, name, feature, flowId, sortBy, sortOrder, scriptDataVersion, divisionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetScriptsDivisionviews: " + e.Message );
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
| **sortBy** | **string**| SortBy | [optional] <br />**Values**: modifiedDate, createdDate, name |
| **sortOrder** | **string**| SortOrder | [optional] <br />**Values**: ascending, descending |
| **scriptDataVersion** | **string**| Advanced usage - controls the data version of the script | [optional]  |
| **divisionIds** | **string**| Filters scripts to requested divisionIds | [optional]  |

### Return type

[**ScriptEntityListing**](ScriptEntityListing)


## GetScriptsPublished

> [**ScriptEntityListing**](ScriptEntityListing) GetScriptsPublished (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string scriptDataVersion = null, string divisionIds = null)


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
            var divisionIds = divisionIds_example;  // string | Filters scripts to requested divisionIds (optional) 

            try
            { 
                // Get the published scripts.
                ScriptEntityListing result = apiInstance.GetScriptsPublished(pageSize, pageNumber, expand, name, feature, flowId, scriptDataVersion, divisionIds);
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
| **divisionIds** | **string**| Filters scripts to requested divisionIds | [optional]  |

### Return type

[**ScriptEntityListing**](ScriptEntityListing)


## GetScriptsPublishedDivisionviewVariables

> **Object** GetScriptsPublishedDivisionviewVariables (string scriptId, string input = null, string output = null, string type = null, string scriptDataVersion = null)


Get the published variables

Requires ANY permissions: 

* scripter:publishedScript:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetScriptsPublishedDivisionviewVariablesExample
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
                Object result = apiInstance.GetScriptsPublishedDivisionviewVariables(scriptId, input, output, type, scriptDataVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetScriptsPublishedDivisionviewVariables: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scriptId** | **string**| Script ID |  |
| **input** | **string**| input | [optional] <br />**Values**: true, false |
| **output** | **string**| output | [optional] <br />**Values**: true, false |
| **type** | **string**| type | [optional] <br />**Values**: string, number, boolean |
| **scriptDataVersion** | **string**| Advanced usage - controls the data version of the script | [optional]  |

### Return type

**Object**


## GetScriptsPublishedDivisionviews

> [**ScriptEntityListing**](ScriptEntityListing) GetScriptsPublishedDivisionviews (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string scriptDataVersion = null, string divisionIds = null)


Get the published scripts metadata.

Requires ANY permissions: 

* scripter:publishedScript:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetScriptsPublishedDivisionviewsExample
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
            var divisionIds = divisionIds_example;  // string | Filters scripts to requested divisionIds (optional) 

            try
            { 
                // Get the published scripts metadata.
                ScriptEntityListing result = apiInstance.GetScriptsPublishedDivisionviews(pageSize, pageNumber, expand, name, feature, flowId, scriptDataVersion, divisionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetScriptsPublishedDivisionviews: " + e.Message );
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
| **divisionIds** | **string**| Filters scripts to requested divisionIds | [optional]  |

### Return type

[**ScriptEntityListing**](ScriptEntityListing)


## GetScriptsPublishedScriptId

> [**Script**](Script) GetScriptsPublishedScriptId (string scriptId, string scriptDataVersion = null)


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

### Return type

[**Script**](Script)


## GetScriptsPublishedScriptIdPage

> [**Page**](Page) GetScriptsPublishedScriptIdPage (string scriptId, string pageId, string scriptDataVersion = null)


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

### Return type

[**Page**](Page)


## GetScriptsPublishedScriptIdPages

> [**List&lt;Page&gt;**](Page) GetScriptsPublishedScriptIdPages (string scriptId, string scriptDataVersion = null)


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

### Return type

[**List<Page>**](Page)


## GetScriptsPublishedScriptIdVariables

> **Object** GetScriptsPublishedScriptIdVariables (string scriptId, string input = null, string output = null, string type = null, string scriptDataVersion = null)


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
| **input** | **string**| input | [optional] <br />**Values**: true, false |
| **output** | **string**| output | [optional] <br />**Values**: true, false |
| **type** | **string**| type | [optional] <br />**Values**: string, number, boolean |
| **scriptDataVersion** | **string**| Advanced usage - controls the data version of the script | [optional]  |

### Return type

**Object**


## GetScriptsUploadStatus

> [**ImportScriptStatusResponse**](ImportScriptStatusResponse) GetScriptsUploadStatus (string uploadId, bool? longPoll = null)


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

### Return type

[**ImportScriptStatusResponse**](ImportScriptStatusResponse)


## PostScriptExport

> [**ExportScriptResponse**](ExportScriptResponse) PostScriptExport (string scriptId, ExportScriptRequest body = null)


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
| **body** | [**ExportScriptRequest**](ExportScriptRequest)|  | [optional]  |

### Return type

[**ExportScriptResponse**](ExportScriptResponse)


## PostScriptsPublished

> [**Script**](Script) PostScriptsPublished (string scriptDataVersion = null, PublishScriptRequestData body = null)


Publish a script.

Requires ANY permissions: 

* scripter:publishedScript:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostScriptsPublishedExample
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
            var scriptDataVersion = scriptDataVersion_example;  // string | Advanced usage - controls the data version of the script (optional) 
            var body = new PublishScriptRequestData(); // PublishScriptRequestData | body (optional) 

            try
            { 
                // Publish a script.
                Script result = apiInstance.PostScriptsPublished(scriptDataVersion, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.PostScriptsPublished: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scriptDataVersion** | **string**| Advanced usage - controls the data version of the script | [optional]  |
| **body** | [**PublishScriptRequestData**](PublishScriptRequestData)| body | [optional]  |

### Return type

[**Script**](Script)


_PureCloudPlatform.Client.V2 249.0.0_
