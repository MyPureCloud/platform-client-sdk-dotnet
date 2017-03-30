---
title: ArchitectApi
---
## PureCloudPlatform.Client.V2.Api.ArchitectApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteArchitectPrompt**](ArchitectApi.html#deletearchitectprompt) | **DELETE** /api/v2/architect/prompts/{promptId} | Delete specified user prompt |
| [**DeleteArchitectPromptResource**](ArchitectApi.html#deletearchitectpromptresource) | **DELETE** /api/v2/architect/prompts/{promptId}/resources/{languageCode} | Delete specified user prompt resource |
| [**DeleteArchitectPrompts**](ArchitectApi.html#deletearchitectprompts) | **DELETE** /api/v2/architect/prompts | Batch-delete a list of prompts asynchronously |
| [**DeleteArchitectSystempromptResource**](ArchitectApi.html#deletearchitectsystempromptresource) | **DELETE** /api/v2/architect/systemprompts/{promptId}/resources/{languageCode} | Delete a system prompt resource override. |
| [**GetArchitectPrompt**](ArchitectApi.html#getarchitectprompt) | **GET** /api/v2/architect/prompts/{promptId} | Get specified user prompt |
| [**GetArchitectPromptResource**](ArchitectApi.html#getarchitectpromptresource) | **GET** /api/v2/architect/prompts/{promptId}/resources/{languageCode} | Get specified user prompt resource |
| [**GetArchitectPromptResources**](ArchitectApi.html#getarchitectpromptresources) | **GET** /api/v2/architect/prompts/{promptId}/resources | Get a pageable list of user prompt resources |
| [**GetArchitectPrompts**](ArchitectApi.html#getarchitectprompts) | **GET** /api/v2/architect/prompts | Get a pageable list of user prompts |
| [**GetArchitectSystemprompt**](ArchitectApi.html#getarchitectsystemprompt) | **GET** /api/v2/architect/systemprompts/{promptId} | Get a system prompt |
| [**GetArchitectSystempromptResource**](ArchitectApi.html#getarchitectsystempromptresource) | **GET** /api/v2/architect/systemprompts/{promptId}/resources/{languageCode} | Get a system prompt resource. |
| [**GetArchitectSystempromptResources**](ArchitectApi.html#getarchitectsystempromptresources) | **GET** /api/v2/architect/systemprompts/{promptId}/resources | Get IVR System Prompt resources. |
| [**GetArchitectSystemprompts**](ArchitectApi.html#getarchitectsystemprompts) | **GET** /api/v2/architect/systemprompts | Get System Prompts |
| [**GetFlows**](ArchitectApi.html#getflows) | **GET** /api/v2/flows | Get a pageable list of flows, filtered by query parameters |
| [**PostArchitectPromptResources**](ArchitectApi.html#postarchitectpromptresources) | **POST** /api/v2/architect/prompts/{promptId}/resources | Create a new user prompt resource |
| [**PostArchitectPrompts**](ArchitectApi.html#postarchitectprompts) | **POST** /api/v2/architect/prompts | Create a new user prompt |
| [**PostArchitectSystempromptResources**](ArchitectApi.html#postarchitectsystempromptresources) | **POST** /api/v2/architect/systemprompts/{promptId}/resources | Create system prompt resource override. |
| [**PutArchitectPrompt**](ArchitectApi.html#putarchitectprompt) | **PUT** /api/v2/architect/prompts/{promptId} | Update specified user prompt |
| [**PutArchitectPromptResource**](ArchitectApi.html#putarchitectpromptresource) | **PUT** /api/v2/architect/prompts/{promptId}/resources/{languageCode} | Update specified user prompt resource |
| [**PutArchitectSystempromptResource**](ArchitectApi.html#putarchitectsystempromptresource) | **PUT** /api/v2/architect/systemprompts/{promptId}/resources/{languageCode} | Updates a system prompt resource override. |
{: class="table table-striped"}

<a name="deletearchitectprompt"></a>

## void DeleteArchitectPrompt (string promptId, bool? allResources = null)

Delete specified user prompt



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteArchitectPromptExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var allResources = true;  // bool? | Whether or not to delete all the prompt resources (optional) 

            try
            {
                // Delete specified user prompt
                apiInstance.DeleteArchitectPrompt(promptId, allResources);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteArchitectPrompt: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **allResources** | **bool?**| Whether or not to delete all the prompt resources | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletearchitectpromptresource"></a>

## void DeleteArchitectPromptResource (string promptId, string languageCode)

Delete specified user prompt resource



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteArchitectPromptResourceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var languageCode = languageCode_example;  // string | Language

            try
            {
                // Delete specified user prompt resource
                apiInstance.DeleteArchitectPromptResource(promptId, languageCode);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteArchitectPromptResource: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **languageCode** | **string**| Language |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletearchitectprompts"></a>

## [**Operation**](Operation.html) DeleteArchitectPrompts (List<string> id)

Batch-delete a list of prompts asynchronously

Multiple IDs can be specified, in which case all specified prompts will be deleted.

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteArchitectPromptsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ArchitectApi();
            var id = new List<string>(); // List<string> | List of Prompt IDs

            try
            {
                // Batch-delete a list of prompts asynchronously
                Operation result = apiInstance.DeleteArchitectPrompts(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteArchitectPrompts: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | [**List<string>**](string.html)| List of Prompt IDs |  |
{: class="table table-striped"}

### Return type

[**Operation**](Operation.html)

<a name="deletearchitectsystempromptresource"></a>

## **string** DeleteArchitectSystempromptResource (string promptId, string languageCode)

Delete a system prompt resource override.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteArchitectSystempromptResourceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var languageCode = languageCode_example;  // string | Language

            try
            {
                // Delete a system prompt resource override.
                string result = apiInstance.DeleteArchitectSystempromptResource(promptId, languageCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteArchitectSystempromptResource: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **languageCode** | **string**| Language |  |
{: class="table table-striped"}

### Return type

**string**

<a name="getarchitectprompt"></a>

## [**Prompt**](Prompt.html) GetArchitectPrompt (string promptId)

Get specified user prompt



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectPromptExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID

            try
            {
                // Get specified user prompt
                Prompt result = apiInstance.GetArchitectPrompt(promptId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectPrompt: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
{: class="table table-striped"}

### Return type

[**Prompt**](Prompt.html)

<a name="getarchitectpromptresource"></a>

## [**PromptAsset**](PromptAsset.html) GetArchitectPromptResource (string promptId, string languageCode)

Get specified user prompt resource



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectPromptResourceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var languageCode = languageCode_example;  // string | Language

            try
            {
                // Get specified user prompt resource
                PromptAsset result = apiInstance.GetArchitectPromptResource(promptId, languageCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectPromptResource: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **languageCode** | **string**| Language |  |
{: class="table table-striped"}

### Return type

[**PromptAsset**](PromptAsset.html)

<a name="getarchitectpromptresources"></a>

## [**PromptAssetEntityListing**](PromptAssetEntityListing.html) GetArchitectPromptResources (string promptId, int? pageNumber = null, int? pageSize = null)

Get a pageable list of user prompt resources

The returned list is pageable, and query parameters can be used for filtering.

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectPromptResourcesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            {
                // Get a pageable list of user prompt resources
                PromptAssetEntityListing result = apiInstance.GetArchitectPromptResources(promptId, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectPromptResources: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
{: class="table table-striped"}

### Return type

[**PromptAssetEntityListing**](PromptAssetEntityListing.html)

<a name="getarchitectprompts"></a>

## [**PromptEntityListing**](PromptEntityListing.html) GetArchitectPrompts (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null)

Get a pageable list of user prompts

The returned list is pageable, and query parameters can be used for filtering.  Multiple names can be specified, in which case all matching prompts will be returned, and no other filters will be evaluated.

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectPromptsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ArchitectApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var name = name_example;  // string | Name (optional) 
            var description = description_example;  // string | Description (optional) 
            var nameOrDescription = nameOrDescription_example;  // string | Name or description (optional) 

            try
            {
                // Get a pageable list of user prompts
                PromptEntityListing result = apiInstance.GetArchitectPrompts(pageNumber, pageSize, name, description, nameOrDescription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectPrompts: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **name** | **string**| Name | [optional]  |
| **description** | **string**| Description | [optional]  |
| **nameOrDescription** | **string**| Name or description | [optional]  |
{: class="table table-striped"}

### Return type

[**PromptEntityListing**](PromptEntityListing.html)

<a name="getarchitectsystemprompt"></a>

## [**SystemPrompt**](SystemPrompt.html) GetArchitectSystemprompt (string promptId)

Get a system prompt



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectSystempromptExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | promptId

            try
            {
                // Get a system prompt
                SystemPrompt result = apiInstance.GetArchitectSystemprompt(promptId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectSystemprompt: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| promptId |  |
{: class="table table-striped"}

### Return type

[**SystemPrompt**](SystemPrompt.html)

<a name="getarchitectsystempromptresource"></a>

## [**SystemPromptAsset**](SystemPromptAsset.html) GetArchitectSystempromptResource (string promptId, string languageCode)

Get a system prompt resource.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectSystempromptResourceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var languageCode = languageCode_example;  // string | Language

            try
            {
                // Get a system prompt resource.
                SystemPromptAsset result = apiInstance.GetArchitectSystempromptResource(promptId, languageCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectSystempromptResource: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **languageCode** | **string**| Language |  |
{: class="table table-striped"}

### Return type

[**SystemPromptAsset**](SystemPromptAsset.html)

<a name="getarchitectsystempromptresources"></a>

## [**SystemPromptAssetEntityListing**](SystemPromptAssetEntityListing.html) GetArchitectSystempromptResources (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)

Get IVR System Prompt resources.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectSystempromptResourcesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to id)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to asc)

            try
            {
                // Get IVR System Prompt resources.
                SystemPromptAssetEntityListing result = apiInstance.GetArchitectSystempromptResources(promptId, pageNumber, pageSize, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectSystempromptResources: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Sort by | [optional] [default to id] |
| **sortOrder** | **string**| Sort order | [optional] [default to asc] |
{: class="table table-striped"}

### Return type

[**SystemPromptAssetEntityListing**](SystemPromptAssetEntityListing.html)

<a name="getarchitectsystemprompts"></a>

## [**SystemPromptEntityListing**](SystemPromptEntityListing.html) GetArchitectSystemprompts (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string nameOrDescription = null)

Get System Prompts



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectSystempromptsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ArchitectApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to id)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to asc)
            var name = name_example;  // string | Name (optional) 
            var description = description_example;  // string | Description (optional) 
            var nameOrDescription = nameOrDescription_example;  // string | Name or description (optional) 

            try
            {
                // Get System Prompts
                SystemPromptEntityListing result = apiInstance.GetArchitectSystemprompts(pageNumber, pageSize, sortBy, sortOrder, name, description, nameOrDescription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectSystemprompts: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Sort by | [optional] [default to id] |
| **sortOrder** | **string**| Sort order | [optional] [default to asc] |
| **name** | **string**| Name | [optional]  |
| **description** | **string**| Description | [optional]  |
| **nameOrDescription** | **string**| Name or description | [optional]  |
{: class="table table-striped"}

### Return type

[**SystemPromptEntityListing**](SystemPromptEntityListing.html)

<a name="getflows"></a>

## [**FlowEntityListing**](FlowEntityListing.html) GetFlows (string type, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string editableBy = null, string lockedBy = null, string secure = null, bool? deleted = null, bool? includeSchemas = null)

Get a pageable list of flows, filtered by query parameters

Multiple IDs can be specified, in which case all matching flows will be returned, and no other parameters will be evaluated.

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ArchitectApi();
            var type = type_example;  // string | Type
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to id)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to asc)
            var id = new List<string>(); // List<string> | ID (optional) 
            var name = name_example;  // string | Name (optional) 
            var description = description_example;  // string | Description (optional) 
            var nameOrDescription = nameOrDescription_example;  // string | Name or description (optional) 
            var publishVersionId = publishVersionId_example;  // string | Publish version ID (optional) 
            var editableBy = editableBy_example;  // string | Editable by (optional) 
            var lockedBy = lockedBy_example;  // string | Locked by (optional) 
            var secure = secure_example;  // string | Secure (optional) 
            var deleted = true;  // bool? | Include deleted (optional)  (default to false)
            var includeSchemas = true;  // bool? | Include variable schemas (optional)  (default to false)

            try
            {
                // Get a pageable list of flows, filtered by query parameters
                FlowEntityListing result = apiInstance.GetFlows(type, pageNumber, pageSize, sortBy, sortOrder, id, name, description, nameOrDescription, publishVersionId, editableBy, lockedBy, secure, deleted, includeSchemas);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlows: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **type** | **string**| Type |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Sort by | [optional] [default to id] |
| **sortOrder** | **string**| Sort order | [optional] [default to asc] |
| **id** | [**List<string>**](string.html)| ID | [optional]  |
| **name** | **string**| Name | [optional]  |
| **description** | **string**| Description | [optional]  |
| **nameOrDescription** | **string**| Name or description | [optional]  |
| **publishVersionId** | **string**| Publish version ID | [optional]  |
| **editableBy** | **string**| Editable by | [optional]  |
| **lockedBy** | **string**| Locked by | [optional]  |
| **secure** | **string**| Secure | [optional]  |
| **deleted** | **bool?**| Include deleted | [optional] [default to false] |
| **includeSchemas** | **bool?**| Include variable schemas | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**FlowEntityListing**](FlowEntityListing.html)

<a name="postarchitectpromptresources"></a>

## [**PromptAsset**](PromptAsset.html) PostArchitectPromptResources (string promptId, PromptAssetCreate body = null)

Create a new user prompt resource



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostArchitectPromptResourcesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var body = new PromptAssetCreate(); // PromptAssetCreate |  (optional) 

            try
            {
                // Create a new user prompt resource
                PromptAsset result = apiInstance.PostArchitectPromptResources(promptId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostArchitectPromptResources: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **body** | [**PromptAssetCreate**](PromptAssetCreate.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**PromptAsset**](PromptAsset.html)

<a name="postarchitectprompts"></a>

## [**Prompt**](Prompt.html) PostArchitectPrompts (Prompt body = null)

Create a new user prompt



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostArchitectPromptsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ArchitectApi();
            var body = new Prompt(); // Prompt |  (optional) 

            try
            {
                // Create a new user prompt
                Prompt result = apiInstance.PostArchitectPrompts(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostArchitectPrompts: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Prompt**](Prompt.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**Prompt**](Prompt.html)

<a name="postarchitectsystempromptresources"></a>

## [**SystemPromptAsset**](SystemPromptAsset.html) PostArchitectSystempromptResources (string promptId, SystemPromptAsset body = null)

Create system prompt resource override.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostArchitectSystempromptResourcesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var body = new SystemPromptAsset(); // SystemPromptAsset |  (optional) 

            try
            {
                // Create system prompt resource override.
                SystemPromptAsset result = apiInstance.PostArchitectSystempromptResources(promptId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostArchitectSystempromptResources: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **body** | [**SystemPromptAsset**](SystemPromptAsset.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**SystemPromptAsset**](SystemPromptAsset.html)

<a name="putarchitectprompt"></a>

## [**Prompt**](Prompt.html) PutArchitectPrompt (string promptId, Prompt body = null)

Update specified user prompt



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutArchitectPromptExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var body = new Prompt(); // Prompt |  (optional) 

            try
            {
                // Update specified user prompt
                Prompt result = apiInstance.PutArchitectPrompt(promptId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PutArchitectPrompt: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **body** | [**Prompt**](Prompt.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**Prompt**](Prompt.html)

<a name="putarchitectpromptresource"></a>

## [**PromptAsset**](PromptAsset.html) PutArchitectPromptResource (string promptId, string languageCode, PromptAsset body = null)

Update specified user prompt resource



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutArchitectPromptResourceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var languageCode = languageCode_example;  // string | Language
            var body = new PromptAsset(); // PromptAsset |  (optional) 

            try
            {
                // Update specified user prompt resource
                PromptAsset result = apiInstance.PutArchitectPromptResource(promptId, languageCode, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PutArchitectPromptResource: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **languageCode** | **string**| Language |  |
| **body** | [**PromptAsset**](PromptAsset.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**PromptAsset**](PromptAsset.html)

<a name="putarchitectsystempromptresource"></a>

## [**SystemPromptAsset**](SystemPromptAsset.html) PutArchitectSystempromptResource (string promptId, string languageCode, SystemPromptAsset body = null)

Updates a system prompt resource override.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutArchitectSystempromptResourceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var languageCode = languageCode_example;  // string | Language
            var body = new SystemPromptAsset(); // SystemPromptAsset |  (optional) 

            try
            {
                // Updates a system prompt resource override.
                SystemPromptAsset result = apiInstance.PutArchitectSystempromptResource(promptId, languageCode, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PutArchitectSystempromptResource: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **languageCode** | **string**| Language |  |
| **body** | [**SystemPromptAsset**](SystemPromptAsset.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**SystemPromptAsset**](SystemPromptAsset.html)

