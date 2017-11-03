---
title: IntegrationsApi
---
## PureCloudPlatform.Client.V2.Api.IntegrationsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteIntegrationsAction**](IntegrationsApi.html#deleteintegrationsaction) | **DELETE** /api/v2/integrations/actions/{actionId} | Delete an Action |
| [**DeleteIntegrationsActionDraft**](IntegrationsApi.html#deleteintegrationsactiondraft) | **DELETE** /api/v2/integrations/actions/{actionId}/draft | Delete a Draft |
| [**GetIntegrationsAction**](IntegrationsApi.html#getintegrationsaction) | **GET** /api/v2/integrations/actions/{actionId} | Retrieves a single Action matching id. |
| [**GetIntegrationsActionDraft**](IntegrationsApi.html#getintegrationsactiondraft) | **GET** /api/v2/integrations/actions/{actionId}/draft | Retrieve a Draft |
| [**GetIntegrationsActionDraftSchema**](IntegrationsApi.html#getintegrationsactiondraftschema) | **GET** /api/v2/integrations/actions/{actionId}/draft/schemas/{fileName} | Retrieve schema for a Draft based on filename. |
| [**GetIntegrationsActionDraftTemplate**](IntegrationsApi.html#getintegrationsactiondrafttemplate) | **GET** /api/v2/integrations/actions/{actionId}/draft/templates/{fileName} | Retrieve templates for a Draft based on filename. |
| [**GetIntegrationsActionDraftValidation**](IntegrationsApi.html#getintegrationsactiondraftvalidation) | **GET** /api/v2/integrations/actions/{actionId}/draft/validation | Validate current Draft configuration. |
| [**GetIntegrationsActionSchema**](IntegrationsApi.html#getintegrationsactionschema) | **GET** /api/v2/integrations/actions/{actionId}/schemas/{fileName} | Retrieve schema for an action based on filename. |
| [**GetIntegrationsActionTemplate**](IntegrationsApi.html#getintegrationsactiontemplate) | **GET** /api/v2/integrations/actions/{actionId}/templates/{fileName} | Retrieve text of templates for an action based on filename. |
| [**GetIntegrationsActions**](IntegrationsApi.html#getintegrationsactions) | **GET** /api/v2/integrations/actions | Retrieves all actions associated with filters passed in via query param. |
| [**GetIntegrationsActionsCategories**](IntegrationsApi.html#getintegrationsactionscategories) | **GET** /api/v2/integrations/actions/categories | Retrieves all categories of available Actions |
| [**GetIntegrationsActionsDrafts**](IntegrationsApi.html#getintegrationsactionsdrafts) | **GET** /api/v2/integrations/actions/drafts | Retrieves all action drafts associated with the filters passed in via query param. |
| [**PatchIntegrationsAction**](IntegrationsApi.html#patchintegrationsaction) | **PATCH** /api/v2/integrations/actions/{actionId} | Patch an Action |
| [**PatchIntegrationsActionDraft**](IntegrationsApi.html#patchintegrationsactiondraft) | **PATCH** /api/v2/integrations/actions/{actionId}/draft | Update an existing Draft |
| [**PostIntegrationsActionDraft**](IntegrationsApi.html#postintegrationsactiondraft) | **POST** /api/v2/integrations/actions/{actionId}/draft | Create a new Draft from existing Action |
| [**PostIntegrationsActionDraftPublish**](IntegrationsApi.html#postintegrationsactiondraftpublish) | **POST** /api/v2/integrations/actions/{actionId}/draft/publish | Publish a Draft and make it the active Action configuration |
| [**PostIntegrationsActionDraftTest**](IntegrationsApi.html#postintegrationsactiondrafttest) | **POST** /api/v2/integrations/actions/{actionId}/draft/test | Test the execution of a draft. Responses will show execution steps broken out with intermediate results to help in debugging. |
| [**PostIntegrationsActionExecute**](IntegrationsApi.html#postintegrationsactionexecute) | **POST** /api/v2/integrations/actions/{actionId}/execute | Execute Action and return response from 3rd party.  Responses will follow the schemas defined on the Action for success and error. |
| [**PostIntegrationsActionTest**](IntegrationsApi.html#postintegrationsactiontest) | **POST** /api/v2/integrations/actions/{actionId}/test | Test the execution of an action. Responses will show execution steps broken out with intermediate results to help in debugging. |
| [**PostIntegrationsActions**](IntegrationsApi.html#postintegrationsactions) | **POST** /api/v2/integrations/actions | Create a new Action |
| [**PostIntegrationsActionsDrafts**](IntegrationsApi.html#postintegrationsactionsdrafts) | **POST** /api/v2/integrations/actions/drafts | Create a new Draft |
{: class="table table-striped"}

<a name="deleteintegrationsaction"></a>

## void DeleteIntegrationsAction (string actionId)

Delete an Action



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteIntegrationsActionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new IntegrationsApi();
            
            
            var actionId = actionId_example;  // string | actionId
            
            
            

            try
            {
                
                // Delete an Action
                
                apiInstance.DeleteIntegrationsAction(actionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.DeleteIntegrationsAction: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteintegrationsactiondraft"></a>

## void DeleteIntegrationsActionDraft (string actionId)

Delete a Draft



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteIntegrationsActionDraftExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new IntegrationsApi();
            
            
            var actionId = actionId_example;  // string | actionId
            
            
            

            try
            {
                
                // Delete a Draft
                
                apiInstance.DeleteIntegrationsActionDraft(actionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.DeleteIntegrationsActionDraft: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getintegrationsaction"></a>

## [**PureCloudPlatform.Client.V2.Model.Action**](Action.html) GetIntegrationsAction (string actionId, string expand = null, bool? includeConfig = null)

Retrieves a single Action matching id.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsActionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new IntegrationsApi();
            
            
            var actionId = actionId_example;  // string | actionId
            
            
            
            
            var expand = expand_example;  // string | Indicates fields of the response which should be expanded. (optional) 
            
            
            
            
            var includeConfig = true;  // bool? | Show config when available (optional)  (default to false)
            
            
            

            try
            {
                
                // Retrieves a single Action matching id.
                
                PureCloudPlatform.Client.V2.Model.Action result = apiInstance.GetIntegrationsAction(actionId, expand, includeConfig);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsAction: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |
| **expand** | **string**| Indicates fields of the response which should be expanded. | [optional] <br />**Values**: contract |
| **includeConfig** | **bool?**| Show config when available | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**PureCloudPlatform.Client.V2.Model.Action**](Action.html)

<a name="getintegrationsactiondraft"></a>

## [**PureCloudPlatform.Client.V2.Model.Action**](Action.html) GetIntegrationsActionDraft (string actionId, string expand = null, bool? includeConfig = null)

Retrieve a Draft



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsActionDraftExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new IntegrationsApi();
            
            
            var actionId = actionId_example;  // string | actionId
            
            
            
            
            var expand = expand_example;  // string | Indicates fields of the response which should be expanded. (optional) 
            
            
            
            
            var includeConfig = true;  // bool? | Show config when available (optional)  (default to false)
            
            
            

            try
            {
                
                // Retrieve a Draft
                
                PureCloudPlatform.Client.V2.Model.Action result = apiInstance.GetIntegrationsActionDraft(actionId, expand, includeConfig);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsActionDraft: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |
| **expand** | **string**| Indicates fields of the response which should be expanded. | [optional] <br />**Values**: contract |
| **includeConfig** | **bool?**| Show config when available | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**PureCloudPlatform.Client.V2.Model.Action**](Action.html)

<a name="getintegrationsactiondraftschema"></a>

## [**JsonSchemaDocument**](JsonSchemaDocument.html) GetIntegrationsActionDraftSchema (string actionId, string fileName)

Retrieve schema for a Draft based on filename.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsActionDraftSchemaExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new IntegrationsApi();
            
            
            var actionId = actionId_example;  // string | actionId
            
            
            
            
            var fileName = fileName_example;  // string | Name of schema file to be retrieved for this draft.
            
            
            

            try
            {
                
                // Retrieve schema for a Draft based on filename.
                
                JsonSchemaDocument result = apiInstance.GetIntegrationsActionDraftSchema(actionId, fileName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsActionDraftSchema: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |
| **fileName** | **string**| Name of schema file to be retrieved for this draft. |  |
{: class="table table-striped"}

### Return type

[**JsonSchemaDocument**](JsonSchemaDocument.html)

<a name="getintegrationsactiondrafttemplate"></a>

## **string** GetIntegrationsActionDraftTemplate (string actionId, string fileName)

Retrieve templates for a Draft based on filename.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsActionDraftTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new IntegrationsApi();
            
            
            var actionId = actionId_example;  // string | actionId
            
            
            
            
            var fileName = fileName_example;  // string | Name of template file to be retrieved for this action draft.
            
            
            

            try
            {
                
                // Retrieve templates for a Draft based on filename.
                
                string result = apiInstance.GetIntegrationsActionDraftTemplate(actionId, fileName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsActionDraftTemplate: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |
| **fileName** | **string**| Name of template file to be retrieved for this action draft. |  |
{: class="table table-striped"}

### Return type

**string**

<a name="getintegrationsactiondraftvalidation"></a>

## [**DraftValidationResult**](DraftValidationResult.html) GetIntegrationsActionDraftValidation (string actionId)

Validate current Draft configuration.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsActionDraftValidationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new IntegrationsApi();
            
            
            var actionId = actionId_example;  // string | actionId
            
            
            

            try
            {
                
                // Validate current Draft configuration.
                
                DraftValidationResult result = apiInstance.GetIntegrationsActionDraftValidation(actionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsActionDraftValidation: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |
{: class="table table-striped"}

### Return type

[**DraftValidationResult**](DraftValidationResult.html)

<a name="getintegrationsactionschema"></a>

## [**JsonSchemaDocument**](JsonSchemaDocument.html) GetIntegrationsActionSchema (string actionId, string fileName)

Retrieve schema for an action based on filename.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsActionSchemaExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new IntegrationsApi();
            
            
            var actionId = actionId_example;  // string | actionId
            
            
            
            
            var fileName = fileName_example;  // string | Name of schema file to be retrieved for this action.
            
            
            

            try
            {
                
                // Retrieve schema for an action based on filename.
                
                JsonSchemaDocument result = apiInstance.GetIntegrationsActionSchema(actionId, fileName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsActionSchema: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |
| **fileName** | **string**| Name of schema file to be retrieved for this action. |  |
{: class="table table-striped"}

### Return type

[**JsonSchemaDocument**](JsonSchemaDocument.html)

<a name="getintegrationsactiontemplate"></a>

## **string** GetIntegrationsActionTemplate (string actionId, string fileName)

Retrieve text of templates for an action based on filename.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsActionTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new IntegrationsApi();
            
            
            var actionId = actionId_example;  // string | actionId
            
            
            
            
            var fileName = fileName_example;  // string | Name of template file to be retrieved for this action.
            
            
            

            try
            {
                
                // Retrieve text of templates for an action based on filename.
                
                string result = apiInstance.GetIntegrationsActionTemplate(actionId, fileName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsActionTemplate: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |
| **fileName** | **string**| Name of template file to be retrieved for this action. |  |
{: class="table table-striped"}

### Return type

**string**

<a name="getintegrationsactions"></a>

## [**ActionEntityListing**](ActionEntityListing.html) GetIntegrationsActions (string category = null, string secure = null, string includeAuthActions = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null)

Retrieves all actions associated with filters passed in via query param.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsActionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new IntegrationsApi();
            
            
            var category = category_example;  // string | Filter by category name (optional) 
            
            
            
            
            var secure = secure_example;  // string | Filter to only include secure actions. True will only include actions marked secured. False will include only unsecure actions. Do not use filter if you want all Actions. (optional) 
            
            
            
            
            var includeAuthActions = includeAuthActions_example;  // string | Whether or not to include authentication actions in the response. These actions are not directly executable. Some integrations create them and will run them as needed to refresh authentication information for other actions. (optional) 
            
            
            
            
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            
            
            
            
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            
            
            
            
            
            var expand = new List<Object>(); // List<Object> | variable name requested by expand list (optional) 
            
            
            
            var nextPage = nextPage_example;  // string | next page token (optional) 
            
            
            
            
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            
            
            

            try
            {
                
                // Retrieves all actions associated with filters passed in via query param.
                
                ActionEntityListing result = apiInstance.GetIntegrationsActions(category, secure, includeAuthActions, pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsActions: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **category** | **string**| Filter by category name | [optional]  |
| **secure** | **string**| Filter to only include secure actions. True will only include actions marked secured. False will include only unsecure actions. Do not use filter if you want all Actions. | [optional] <br />**Values**: true, false |
| **includeAuthActions** | **string**| Whether or not to include authentication actions in the response. These actions are not directly executable. Some integrations create them and will run them as needed to refresh authentication information for other actions. | [optional] <br />**Values**: true, false |
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<Object>**](Object.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
{: class="table table-striped"}

### Return type

[**ActionEntityListing**](ActionEntityListing.html)

<a name="getintegrationsactionscategories"></a>

## [**CategoryEntityListing**](CategoryEntityListing.html) GetIntegrationsActionsCategories (string secure = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null)

Retrieves all categories of available Actions



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsActionsCategoriesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new IntegrationsApi();
            
            
            var secure = secure_example;  // string | Filter to only include/exclude Action categories based on if they are considered secure. True will only include categories with Actions marked secured. False will only include categories of unsecured Actions. (optional) 
            
            
            
            
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            
            
            
            
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            
            
            
            
            
            var expand = new List<Object>(); // List<Object> | variable name requested by expand list (optional) 
            
            
            
            var nextPage = nextPage_example;  // string | next page token (optional) 
            
            
            
            
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            
            
            

            try
            {
                
                // Retrieves all categories of available Actions
                
                CategoryEntityListing result = apiInstance.GetIntegrationsActionsCategories(secure, pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsActionsCategories: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **secure** | **string**| Filter to only include/exclude Action categories based on if they are considered secure. True will only include categories with Actions marked secured. False will only include categories of unsecured Actions. | [optional] <br />**Values**: true, false |
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<Object>**](Object.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
{: class="table table-striped"}

### Return type

[**CategoryEntityListing**](CategoryEntityListing.html)

<a name="getintegrationsactionsdrafts"></a>

## [**ActionEntityListing**](ActionEntityListing.html) GetIntegrationsActionsDrafts (string category = null, string secure = null, string includeAuthActions = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null)

Retrieves all action drafts associated with the filters passed in via query param.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetIntegrationsActionsDraftsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new IntegrationsApi();
            
            
            var category = category_example;  // string | Filter by category name (optional) 
            
            
            
            
            var secure = secure_example;  // string | Filter to only include secure actions. True will only include actions marked secured. False will include only unsecure actions. Do not use filter if you want all Actions. (optional) 
            
            
            
            
            var includeAuthActions = includeAuthActions_example;  // string | Whether or not to include authentication actions in the response. These actions are not directly executable. Some integrations create them and will run them as needed to refresh authentication information for other actions. (optional) 
            
            
            
            
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            
            
            
            
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            
            
            
            
            
            var expand = new List<Object>(); // List<Object> | variable name requested by expand list (optional) 
            
            
            
            var nextPage = nextPage_example;  // string | next page token (optional) 
            
            
            
            
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            
            
            

            try
            {
                
                // Retrieves all action drafts associated with the filters passed in via query param.
                
                ActionEntityListing result = apiInstance.GetIntegrationsActionsDrafts(category, secure, includeAuthActions, pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationsActionsDrafts: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **category** | **string**| Filter by category name | [optional]  |
| **secure** | **string**| Filter to only include secure actions. True will only include actions marked secured. False will include only unsecure actions. Do not use filter if you want all Actions. | [optional] <br />**Values**: true, false |
| **includeAuthActions** | **string**| Whether or not to include authentication actions in the response. These actions are not directly executable. Some integrations create them and will run them as needed to refresh authentication information for other actions. | [optional] <br />**Values**: true, false |
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<Object>**](Object.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
{: class="table table-striped"}

### Return type

[**ActionEntityListing**](ActionEntityListing.html)

<a name="patchintegrationsaction"></a>

## [**PureCloudPlatform.Client.V2.Model.Action**](Action.html) PatchIntegrationsAction (string actionId, UpdateActionInput body)

Patch an Action



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchIntegrationsActionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new IntegrationsApi();
            
            
            var actionId = actionId_example;  // string | actionId
            
            
            
            
            
            var body = new UpdateActionInput(); // UpdateActionInput | Input used to patch the Action.
            
            

            try
            {
                
                // Patch an Action
                
                PureCloudPlatform.Client.V2.Model.Action result = apiInstance.PatchIntegrationsAction(actionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PatchIntegrationsAction: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |
| **body** | [**UpdateActionInput**](UpdateActionInput.html)| Input used to patch the Action. |  |
{: class="table table-striped"}

### Return type

[**PureCloudPlatform.Client.V2.Model.Action**](Action.html)

<a name="patchintegrationsactiondraft"></a>

## [**PureCloudPlatform.Client.V2.Model.Action**](Action.html) PatchIntegrationsActionDraft (string actionId, UpdateDraftInput body)

Update an existing Draft



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchIntegrationsActionDraftExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new IntegrationsApi();
            
            
            var actionId = actionId_example;  // string | actionId
            
            
            
            
            
            var body = new UpdateDraftInput(); // UpdateDraftInput | Input used to patch the Action Draft.
            
            

            try
            {
                
                // Update an existing Draft
                
                PureCloudPlatform.Client.V2.Model.Action result = apiInstance.PatchIntegrationsActionDraft(actionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PatchIntegrationsActionDraft: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |
| **body** | [**UpdateDraftInput**](UpdateDraftInput.html)| Input used to patch the Action Draft. |  |
{: class="table table-striped"}

### Return type

[**PureCloudPlatform.Client.V2.Model.Action**](Action.html)

<a name="postintegrationsactiondraft"></a>

## [**PureCloudPlatform.Client.V2.Model.Action**](Action.html) PostIntegrationsActionDraft (string actionId)

Create a new Draft from existing Action



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostIntegrationsActionDraftExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new IntegrationsApi();
            
            
            var actionId = actionId_example;  // string | actionId
            
            
            

            try
            {
                
                // Create a new Draft from existing Action
                
                PureCloudPlatform.Client.V2.Model.Action result = apiInstance.PostIntegrationsActionDraft(actionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PostIntegrationsActionDraft: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |
{: class="table table-striped"}

### Return type

[**PureCloudPlatform.Client.V2.Model.Action**](Action.html)

<a name="postintegrationsactiondraftpublish"></a>

## [**PureCloudPlatform.Client.V2.Model.Action**](Action.html) PostIntegrationsActionDraftPublish (string actionId, PublishDraftInput body)

Publish a Draft and make it the active Action configuration



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostIntegrationsActionDraftPublishExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new IntegrationsApi();
            
            
            var actionId = actionId_example;  // string | actionId
            
            
            
            
            
            var body = new PublishDraftInput(); // PublishDraftInput | Input used to patch the Action.
            
            

            try
            {
                
                // Publish a Draft and make it the active Action configuration
                
                PureCloudPlatform.Client.V2.Model.Action result = apiInstance.PostIntegrationsActionDraftPublish(actionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PostIntegrationsActionDraftPublish: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |
| **body** | [**PublishDraftInput**](PublishDraftInput.html)| Input used to patch the Action. |  |
{: class="table table-striped"}

### Return type

[**PureCloudPlatform.Client.V2.Model.Action**](Action.html)

<a name="postintegrationsactiondrafttest"></a>

## [**TestExecutionResult**](TestExecutionResult.html) PostIntegrationsActionDraftTest (string actionId, Object body)

Test the execution of a draft. Responses will show execution steps broken out with intermediate results to help in debugging.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostIntegrationsActionDraftTestExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new IntegrationsApi();
            
            
            var actionId = actionId_example;  // string | actionId
            
            
            
            
            var body = ;  // Object | Map of parameters used for variable substitution.
            
            
            

            try
            {
                
                // Test the execution of a draft. Responses will show execution steps broken out with intermediate results to help in debugging.
                
                TestExecutionResult result = apiInstance.PostIntegrationsActionDraftTest(actionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PostIntegrationsActionDraftTest: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |
| **body** | **Object**| Map of parameters used for variable substitution. |  |
{: class="table table-striped"}

### Return type

[**TestExecutionResult**](TestExecutionResult.html)

<a name="postintegrationsactionexecute"></a>

## **Object** PostIntegrationsActionExecute (string actionId, Object body)

Execute Action and return response from 3rd party.  Responses will follow the schemas defined on the Action for success and error.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostIntegrationsActionExecuteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new IntegrationsApi();
            
            
            var actionId = actionId_example;  // string | actionId
            
            
            
            
            var body = ;  // Object | Map of parameters used for variable substitution.
            
            
            

            try
            {
                
                // Execute Action and return response from 3rd party.  Responses will follow the schemas defined on the Action for success and error.
                
                Object result = apiInstance.PostIntegrationsActionExecute(actionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PostIntegrationsActionExecute: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |
| **body** | **Object**| Map of parameters used for variable substitution. |  |
{: class="table table-striped"}

### Return type

**Object**

<a name="postintegrationsactiontest"></a>

## [**TestExecutionResult**](TestExecutionResult.html) PostIntegrationsActionTest (string actionId, Object body)

Test the execution of an action. Responses will show execution steps broken out with intermediate results to help in debugging.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostIntegrationsActionTestExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new IntegrationsApi();
            
            
            var actionId = actionId_example;  // string | actionId
            
            
            
            
            var body = ;  // Object | Map of parameters used for variable substitution.
            
            
            

            try
            {
                
                // Test the execution of an action. Responses will show execution steps broken out with intermediate results to help in debugging.
                
                TestExecutionResult result = apiInstance.PostIntegrationsActionTest(actionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PostIntegrationsActionTest: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |
| **body** | **Object**| Map of parameters used for variable substitution. |  |
{: class="table table-striped"}

### Return type

[**TestExecutionResult**](TestExecutionResult.html)

<a name="postintegrationsactions"></a>

## [**PureCloudPlatform.Client.V2.Model.Action**](Action.html) PostIntegrationsActions (PostActionInput body)

Create a new Action



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostIntegrationsActionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new IntegrationsApi();
            
            
            
            var body = new PostActionInput(); // PostActionInput | Input used to create Action.
            
            

            try
            {
                
                // Create a new Action
                
                PureCloudPlatform.Client.V2.Model.Action result = apiInstance.PostIntegrationsActions(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PostIntegrationsActions: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**PostActionInput**](PostActionInput.html)| Input used to create Action. |  |
{: class="table table-striped"}

### Return type

[**PureCloudPlatform.Client.V2.Model.Action**](Action.html)

<a name="postintegrationsactionsdrafts"></a>

## [**PureCloudPlatform.Client.V2.Model.Action**](Action.html) PostIntegrationsActionsDrafts (PostActionInput body)

Create a new Draft



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostIntegrationsActionsDraftsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new IntegrationsApi();
            
            
            
            var body = new PostActionInput(); // PostActionInput | Input used to create Action Draft.
            
            

            try
            {
                
                // Create a new Draft
                
                PureCloudPlatform.Client.V2.Model.Action result = apiInstance.PostIntegrationsActionsDrafts(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PostIntegrationsActionsDrafts: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**PostActionInput**](PostActionInput.html)| Input used to create Action Draft. |  |
{: class="table table-striped"}

### Return type

[**PureCloudPlatform.Client.V2.Model.Action**](Action.html)

