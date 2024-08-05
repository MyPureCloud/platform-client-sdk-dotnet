---
title: TaskManagementApi
---
## PureCloudPlatform.Client.V2.Api.TaskManagementApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteTaskmanagementWorkbin**](TaskManagementApi.html#deletetaskmanagementworkbin) | **Delete** /api/v2/taskmanagement/workbins/{workbinId} | Delete a workbin |
| [**DeleteTaskmanagementWorkitem**](TaskManagementApi.html#deletetaskmanagementworkitem) | **Delete** /api/v2/taskmanagement/workitems/{workitemId} | Delete a workitem |
| [**DeleteTaskmanagementWorkitemsSchema**](TaskManagementApi.html#deletetaskmanagementworkitemsschema) | **Delete** /api/v2/taskmanagement/workitems/schemas/{schemaId} | Delete a schema |
| [**DeleteTaskmanagementWorktype**](TaskManagementApi.html#deletetaskmanagementworktype) | **Delete** /api/v2/taskmanagement/worktypes/{worktypeId} | Delete a worktype |
| [**DeleteTaskmanagementWorktypeStatus**](TaskManagementApi.html#deletetaskmanagementworktypestatus) | **Delete** /api/v2/taskmanagement/worktypes/{worktypeId}/statuses/{statusId} | Delete a status |
| [**GetTaskmanagementWorkbin**](TaskManagementApi.html#gettaskmanagementworkbin) | **Get** /api/v2/taskmanagement/workbins/{workbinId} | Get a workbin |
| [**GetTaskmanagementWorkbinHistory**](TaskManagementApi.html#gettaskmanagementworkbinhistory) | **Get** /api/v2/taskmanagement/workbins/{workbinId}/history | Get a listing of a workbin&#39;s attribute change history |
| [**GetTaskmanagementWorkbinVersion**](TaskManagementApi.html#gettaskmanagementworkbinversion) | **Get** /api/v2/taskmanagement/workbins/{workbinId}/versions/{entityVersion} | Get a version of a workbin |
| [**GetTaskmanagementWorkbinVersions**](TaskManagementApi.html#gettaskmanagementworkbinversions) | **Get** /api/v2/taskmanagement/workbins/{workbinId}/versions | Get all versions of a workbin |
| [**GetTaskmanagementWorkitem**](TaskManagementApi.html#gettaskmanagementworkitem) | **Get** /api/v2/taskmanagement/workitems/{workitemId} | Get a workitem |
| [**GetTaskmanagementWorkitemHistory**](TaskManagementApi.html#gettaskmanagementworkitemhistory) | **Get** /api/v2/taskmanagement/workitems/{workitemId}/history | Get a listing of a workitem&#39;s attribute change history |
| [**GetTaskmanagementWorkitemUserWrapups**](TaskManagementApi.html#gettaskmanagementworkitemuserwrapups) | **Get** /api/v2/taskmanagement/workitems/{workitemId}/users/{userId}/wrapups | Get all wrapup codes added for the given user for a workitem. |
| [**GetTaskmanagementWorkitemVersion**](TaskManagementApi.html#gettaskmanagementworkitemversion) | **Get** /api/v2/taskmanagement/workitems/{workitemId}/versions/{entityVersion} | Get a version of a workitem |
| [**GetTaskmanagementWorkitemVersions**](TaskManagementApi.html#gettaskmanagementworkitemversions) | **Get** /api/v2/taskmanagement/workitems/{workitemId}/versions | Get all versions of a workitem |
| [**GetTaskmanagementWorkitemWrapups**](TaskManagementApi.html#gettaskmanagementworkitemwrapups) | **Get** /api/v2/taskmanagement/workitems/{workitemId}/wrapups | Get all wrapup codes added for all users for a workitem. |
| [**GetTaskmanagementWorkitemsQueryJob**](TaskManagementApi.html#gettaskmanagementworkitemsqueryjob) | **Get** /api/v2/taskmanagement/workitems/query/jobs/{jobId} | Get the workitem query job associated with the job id. |
| [**GetTaskmanagementWorkitemsQueryJobResults**](TaskManagementApi.html#gettaskmanagementworkitemsqueryjobresults) | **Get** /api/v2/taskmanagement/workitems/query/jobs/{jobId}/results | Get results from for workitem query job  |
| [**GetTaskmanagementWorkitemsSchema**](TaskManagementApi.html#gettaskmanagementworkitemsschema) | **Get** /api/v2/taskmanagement/workitems/schemas/{schemaId} | Get a schema |
| [**GetTaskmanagementWorkitemsSchemaVersion**](TaskManagementApi.html#gettaskmanagementworkitemsschemaversion) | **Get** /api/v2/taskmanagement/workitems/schemas/{schemaId}/versions/{versionId} | Get a specific version of a schema |
| [**GetTaskmanagementWorkitemsSchemaVersions**](TaskManagementApi.html#gettaskmanagementworkitemsschemaversions) | **Get** /api/v2/taskmanagement/workitems/schemas/{schemaId}/versions | Get all versions of a schema |
| [**GetTaskmanagementWorkitemsSchemas**](TaskManagementApi.html#gettaskmanagementworkitemsschemas) | **Get** /api/v2/taskmanagement/workitems/schemas | Get a list of schemas. |
| [**GetTaskmanagementWorktype**](TaskManagementApi.html#gettaskmanagementworktype) | **Get** /api/v2/taskmanagement/worktypes/{worktypeId} | Get a worktype |
| [**GetTaskmanagementWorktypeHistory**](TaskManagementApi.html#gettaskmanagementworktypehistory) | **Get** /api/v2/taskmanagement/worktypes/{worktypeId}/history | Get a listing of a worktype&#39;s attribute change history |
| [**GetTaskmanagementWorktypeStatus**](TaskManagementApi.html#gettaskmanagementworktypestatus) | **Get** /api/v2/taskmanagement/worktypes/{worktypeId}/statuses/{statusId} | Get a status |
| [**GetTaskmanagementWorktypeStatuses**](TaskManagementApi.html#gettaskmanagementworktypestatuses) | **Get** /api/v2/taskmanagement/worktypes/{worktypeId}/statuses | Get list of statuses for this worktype. |
| [**GetTaskmanagementWorktypeVersion**](TaskManagementApi.html#gettaskmanagementworktypeversion) | **Get** /api/v2/taskmanagement/worktypes/{worktypeId}/versions/{entityVersion} | Get a version of a worktype |
| [**GetTaskmanagementWorktypeVersions**](TaskManagementApi.html#gettaskmanagementworktypeversions) | **Get** /api/v2/taskmanagement/worktypes/{worktypeId}/versions | Get all versions of a worktype |
| [**PatchTaskmanagementWorkbin**](TaskManagementApi.html#patchtaskmanagementworkbin) | **Patch** /api/v2/taskmanagement/workbins/{workbinId} | Update the attributes of a workbin |
| [**PatchTaskmanagementWorkitem**](TaskManagementApi.html#patchtaskmanagementworkitem) | **Patch** /api/v2/taskmanagement/workitems/{workitemId} | Update the attributes of a workitem |
| [**PatchTaskmanagementWorkitemAssignment**](TaskManagementApi.html#patchtaskmanagementworkitemassignment) | **Patch** /api/v2/taskmanagement/workitems/{workitemId}/assignment | Attempts to manually assign a specified workitem to a specified user.  Ignores bullseye ring, PAR score, skills, and languages. |
| [**PatchTaskmanagementWorkitemUserWrapups**](TaskManagementApi.html#patchtaskmanagementworkitemuserwrapups) | **Patch** /api/v2/taskmanagement/workitems/{workitemId}/users/{userId}/wrapups | Add/Remove a wrapup code for a given user in a workitem. |
| [**PatchTaskmanagementWorkitemUsersMeWrapups**](TaskManagementApi.html#patchtaskmanagementworkitemusersmewrapups) | **Patch** /api/v2/taskmanagement/workitems/{workitemId}/users/me/wrapups | Add/Remove a wrapup code for the current user in a workitem. |
| [**PatchTaskmanagementWorktype**](TaskManagementApi.html#patchtaskmanagementworktype) | **Patch** /api/v2/taskmanagement/worktypes/{worktypeId} | Update the attributes of a worktype |
| [**PatchTaskmanagementWorktypeStatus**](TaskManagementApi.html#patchtaskmanagementworktypestatus) | **Patch** /api/v2/taskmanagement/worktypes/{worktypeId}/statuses/{statusId} | Update the attributes of a status |
| [**PostTaskmanagementWorkbins**](TaskManagementApi.html#posttaskmanagementworkbins) | **Post** /api/v2/taskmanagement/workbins | Create a workbin |
| [**PostTaskmanagementWorkbinsQuery**](TaskManagementApi.html#posttaskmanagementworkbinsquery) | **Post** /api/v2/taskmanagement/workbins/query | Query for workbins |
| [**PostTaskmanagementWorkitemAcdCancel**](TaskManagementApi.html#posttaskmanagementworkitemacdcancel) | **Post** /api/v2/taskmanagement/workitems/{workitemId}/acd/cancel | Cancel the assignment process for a workitem that is currently queued for assignment through ACD. |
| [**PostTaskmanagementWorkitemDisconnect**](TaskManagementApi.html#posttaskmanagementworkitemdisconnect) | **Post** /api/v2/taskmanagement/workitems/{workitemId}/disconnect | Disconnect the assignee of the workitem |
| [**PostTaskmanagementWorkitemTerminate**](TaskManagementApi.html#posttaskmanagementworkitemterminate) | **Post** /api/v2/taskmanagement/workitems/{workitemId}/terminate | Terminate a workitem |
| [**PostTaskmanagementWorkitems**](TaskManagementApi.html#posttaskmanagementworkitems) | **Post** /api/v2/taskmanagement/workitems | Create a workitem |
| [**PostTaskmanagementWorkitemsQuery**](TaskManagementApi.html#posttaskmanagementworkitemsquery) | **Post** /api/v2/taskmanagement/workitems/query | Query for workitems |
| [**PostTaskmanagementWorkitemsQueryJobs**](TaskManagementApi.html#posttaskmanagementworkitemsqueryjobs) | **Post** /api/v2/taskmanagement/workitems/query/jobs | Create a workitem query job |
| [**PostTaskmanagementWorkitemsSchemas**](TaskManagementApi.html#posttaskmanagementworkitemsschemas) | **Post** /api/v2/taskmanagement/workitems/schemas | Create a schema |
| [**PostTaskmanagementWorktypeStatuses**](TaskManagementApi.html#posttaskmanagementworktypestatuses) | **Post** /api/v2/taskmanagement/worktypes/{worktypeId}/statuses | Add a status to a worktype |
| [**PostTaskmanagementWorktypes**](TaskManagementApi.html#posttaskmanagementworktypes) | **Post** /api/v2/taskmanagement/worktypes | Create a worktype |
| [**PostTaskmanagementWorktypesQuery**](TaskManagementApi.html#posttaskmanagementworktypesquery) | **Post** /api/v2/taskmanagement/worktypes/query | Query for worktypes |
| [**PutTaskmanagementWorkitemsSchema**](TaskManagementApi.html#puttaskmanagementworkitemsschema) | **Put** /api/v2/taskmanagement/workitems/schemas/{schemaId} | Update a schema |
{: class="table table-striped"}

<a name="deletetaskmanagementworkbin"></a>

## void DeleteTaskmanagementWorkbin (string workbinId)



Delete a workbin

Requires ANY permissions: 

* workitems:workbin:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTaskmanagementWorkbinExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var workbinId = workbinId_example;  // string | Workbin ID

            try
            { 
                // Delete a workbin
                apiInstance.DeleteTaskmanagementWorkbin(workbinId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.DeleteTaskmanagementWorkbin: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workbinId** | **string**| Workbin ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletetaskmanagementworkitem"></a>

## void DeleteTaskmanagementWorkitem (string workitemId)



Delete a workitem

Requires ANY permissions: 

* workitems:workitem:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTaskmanagementWorkitemExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var workitemId = workitemId_example;  // string | Workitem ID

            try
            { 
                // Delete a workitem
                apiInstance.DeleteTaskmanagementWorkitem(workitemId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.DeleteTaskmanagementWorkitem: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workitemId** | **string**| Workitem ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletetaskmanagementworkitemsschema"></a>

## void DeleteTaskmanagementWorkitemsSchema (string schemaId)



Delete a schema

Requires ANY permissions: 

* workitems:workitemSchema:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTaskmanagementWorkitemsSchemaExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var schemaId = schemaId_example;  // string | Schema ID

            try
            { 
                // Delete a schema
                apiInstance.DeleteTaskmanagementWorkitemsSchema(schemaId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.DeleteTaskmanagementWorkitemsSchema: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **schemaId** | **string**| Schema ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletetaskmanagementworktype"></a>

## void DeleteTaskmanagementWorktype (string worktypeId)



Delete a worktype

Requires ANY permissions: 

* workitems:worktype:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTaskmanagementWorktypeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var worktypeId = worktypeId_example;  // string | Worktype id

            try
            { 
                // Delete a worktype
                apiInstance.DeleteTaskmanagementWorktype(worktypeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.DeleteTaskmanagementWorktype: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **worktypeId** | **string**| Worktype id |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletetaskmanagementworktypestatus"></a>

## void DeleteTaskmanagementWorktypeStatus (string worktypeId, string statusId)



Delete a status

Requires ANY permissions: 

* workitems:status:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTaskmanagementWorktypeStatusExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var worktypeId = worktypeId_example;  // string | Worktype id
            var statusId = statusId_example;  // string | Status id

            try
            { 
                // Delete a status
                apiInstance.DeleteTaskmanagementWorktypeStatus(worktypeId, statusId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.DeleteTaskmanagementWorktypeStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **worktypeId** | **string**| Worktype id |  |
| **statusId** | **string**| Status id |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="gettaskmanagementworkbin"></a>

## [**Workbin**](Workbin.html) GetTaskmanagementWorkbin (string workbinId)



Get a workbin

Requires ANY permissions: 

* workitems:workbin:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorkbinExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var workbinId = workbinId_example;  // string | Workbin ID

            try
            { 
                // Get a workbin
                Workbin result = apiInstance.GetTaskmanagementWorkbin(workbinId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorkbin: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workbinId** | **string**| Workbin ID |  |
{: class="table table-striped"}

### Return type

[**Workbin**](Workbin.html)

<a name="gettaskmanagementworkbinhistory"></a>

## [**WorkbinChangeListing**](WorkbinChangeListing.html) GetTaskmanagementWorkbinHistory (string workbinId, string after = null, int? pageSize = null, string sortOrder = null)



Get a listing of a workbin's attribute change history

GetTaskmanagementWorkbinHistory is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* workitems:workbin:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorkbinHistoryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var workbinId = workbinId_example;  // string | Workbin ID
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = 56;  // int? | Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an `after` key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional)  (default to 25)
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to descending)

            try
            { 
                // Get a listing of a workbin's attribute change history
                WorkbinChangeListing result = apiInstance.GetTaskmanagementWorkbinHistory(workbinId, after, pageSize, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorkbinHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workbinId** | **string**| Workbin ID |  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **int?**| Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. | [optional] [default to 25] |
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to descending]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**WorkbinChangeListing**](WorkbinChangeListing.html)

<a name="gettaskmanagementworkbinversion"></a>

## [**WorkbinVersion**](WorkbinVersion.html) GetTaskmanagementWorkbinVersion (string workbinId, int? entityVersion)



Get a version of a workbin

GetTaskmanagementWorkbinVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* workitems:workbin:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorkbinVersionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var workbinId = workbinId_example;  // string | Workbin ID
            var entityVersion = 56;  // int? | Workbin version

            try
            { 
                // Get a version of a workbin
                WorkbinVersion result = apiInstance.GetTaskmanagementWorkbinVersion(workbinId, entityVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorkbinVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workbinId** | **string**| Workbin ID |  |
| **entityVersion** | **int?**| Workbin version |  |
{: class="table table-striped"}

### Return type

[**WorkbinVersion**](WorkbinVersion.html)

<a name="gettaskmanagementworkbinversions"></a>

## [**WorkbinVersionListing**](WorkbinVersionListing.html) GetTaskmanagementWorkbinVersions (string workbinId, string after = null, int? pageSize = null, string sortOrder = null)



Get all versions of a workbin

GetTaskmanagementWorkbinVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* workitems:workbin:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorkbinVersionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var workbinId = workbinId_example;  // string | Workbin ID
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = 56;  // int? | Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an `after` key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional)  (default to 25)
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to descending)

            try
            { 
                // Get all versions of a workbin
                WorkbinVersionListing result = apiInstance.GetTaskmanagementWorkbinVersions(workbinId, after, pageSize, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorkbinVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workbinId** | **string**| Workbin ID |  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **int?**| Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. | [optional] [default to 25] |
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to descending]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**WorkbinVersionListing**](WorkbinVersionListing.html)

<a name="gettaskmanagementworkitem"></a>

## [**Workitem**](Workitem.html) GetTaskmanagementWorkitem (string workitemId, string expands = null)



Get a workitem

Requires ANY permissions: 

* workitems:workitem:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorkitemExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var workitemId = workitemId_example;  // string | Workitem ID
            var expands = expands_example;  // string | Which fields to expand. Comma separated if more than one. (optional) 

            try
            { 
                // Get a workitem
                Workitem result = apiInstance.GetTaskmanagementWorkitem(workitemId, expands);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorkitem: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workitemId** | **string**| Workitem ID |  |
| **expands** | **string**| Which fields to expand. Comma separated if more than one. | [optional] <br />**Values**: type, workbin, status, queue, assignee |
{: class="table table-striped"}

### Return type

[**Workitem**](Workitem.html)

<a name="gettaskmanagementworkitemhistory"></a>

## [**WorkitemChangeListing**](WorkitemChangeListing.html) GetTaskmanagementWorkitemHistory (string workitemId, string after = null, int? pageSize = null, string sortOrder = null)



Get a listing of a workitem's attribute change history

GetTaskmanagementWorkitemHistory is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* workitems:workitem:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorkitemHistoryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var workitemId = workitemId_example;  // string | Workitem ID
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = 56;  // int? | Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an `after` key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional)  (default to 25)
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to descending)

            try
            { 
                // Get a listing of a workitem's attribute change history
                WorkitemChangeListing result = apiInstance.GetTaskmanagementWorkitemHistory(workitemId, after, pageSize, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorkitemHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workitemId** | **string**| Workitem ID |  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **int?**| Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. | [optional] [default to 25] |
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to descending]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**WorkitemChangeListing**](WorkitemChangeListing.html)

<a name="gettaskmanagementworkitemuserwrapups"></a>

## [**WorkitemWrapup**](WorkitemWrapup.html) GetTaskmanagementWorkitemUserWrapups (string workitemId, string userId, string expands = null, string after = null, int? pageSize = null, string sortOrder = null)



Get all wrapup codes added for the given user for a workitem.

Requires ANY permissions: 

* workitems:wrapup:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorkitemUserWrapupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var workitemId = workitemId_example;  // string | The ID of the Workitem.
            var userId = userId_example;  // string | The ID of the user
            var expands = expands_example;  // string | Which fields, if any, to expand. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = 56;  // int? | Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an `after` key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 50. (optional)  (default to 25)
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to descending)

            try
            { 
                // Get all wrapup codes added for the given user for a workitem.
                WorkitemWrapup result = apiInstance.GetTaskmanagementWorkitemUserWrapups(workitemId, userId, expands, after, pageSize, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorkitemUserWrapups: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workitemId** | **string**| The ID of the Workitem. |  |
| **userId** | **string**| The ID of the user |  |
| **expands** | **string**| Which fields, if any, to expand. | [optional] <br />**Values**: wrapupCode |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **int?**| Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 50. | [optional] [default to 25] |
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to descending]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**WorkitemWrapup**](WorkitemWrapup.html)

<a name="gettaskmanagementworkitemversion"></a>

## [**WorkitemVersion**](WorkitemVersion.html) GetTaskmanagementWorkitemVersion (string workitemId, int? entityVersion)



Get a version of a workitem

GetTaskmanagementWorkitemVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* workitems:workitem:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorkitemVersionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var workitemId = workitemId_example;  // string | Workitem ID
            var entityVersion = 56;  // int? | Workitem version

            try
            { 
                // Get a version of a workitem
                WorkitemVersion result = apiInstance.GetTaskmanagementWorkitemVersion(workitemId, entityVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorkitemVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workitemId** | **string**| Workitem ID |  |
| **entityVersion** | **int?**| Workitem version |  |
{: class="table table-striped"}

### Return type

[**WorkitemVersion**](WorkitemVersion.html)

<a name="gettaskmanagementworkitemversions"></a>

## [**WorkitemVersionListing**](WorkitemVersionListing.html) GetTaskmanagementWorkitemVersions (string workitemId, string after = null, int? pageSize = null, string sortOrder = null)



Get all versions of a workitem

GetTaskmanagementWorkitemVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* workitems:workitem:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorkitemVersionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var workitemId = workitemId_example;  // string | Workitem ID
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = 56;  // int? | Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an `after` key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional)  (default to 25)
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to descending)

            try
            { 
                // Get all versions of a workitem
                WorkitemVersionListing result = apiInstance.GetTaskmanagementWorkitemVersions(workitemId, after, pageSize, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorkitemVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workitemId** | **string**| Workitem ID |  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **int?**| Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. | [optional] [default to 25] |
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to descending]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**WorkitemVersionListing**](WorkitemVersionListing.html)

<a name="gettaskmanagementworkitemwrapups"></a>

## [**WorkitemWrapupEntityListing**](WorkitemWrapupEntityListing.html) GetTaskmanagementWorkitemWrapups (string workitemId, string expands = null, string after = null, int? pageSize = null, string sortOrder = null)



Get all wrapup codes added for all users for a workitem.

Requires ANY permissions: 

* workitems:wrapup:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorkitemWrapupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var workitemId = workitemId_example;  // string | The ID of the Workitem.
            var expands = expands_example;  // string | Which fields, if any, to expand. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = 56;  // int? | Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an `after` key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 50. (optional)  (default to 25)
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to descending)

            try
            { 
                // Get all wrapup codes added for all users for a workitem.
                WorkitemWrapupEntityListing result = apiInstance.GetTaskmanagementWorkitemWrapups(workitemId, expands, after, pageSize, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorkitemWrapups: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workitemId** | **string**| The ID of the Workitem. |  |
| **expands** | **string**| Which fields, if any, to expand. | [optional] <br />**Values**: wrapupCode |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **int?**| Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 50. | [optional] [default to 25] |
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to descending]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**WorkitemWrapupEntityListing**](WorkitemWrapupEntityListing.html)

<a name="gettaskmanagementworkitemsqueryjob"></a>

## [**WorkitemQueryJobResponse**](WorkitemQueryJobResponse.html) GetTaskmanagementWorkitemsQueryJob (string jobId)



Get the workitem query job associated with the job id.

Requires ALL permissions: 

* workitems:queryJob:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorkitemsQueryJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get the workitem query job associated with the job id.
                WorkitemQueryJobResponse result = apiInstance.GetTaskmanagementWorkitemsQueryJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorkitemsQueryJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
{: class="table table-striped"}

### Return type

[**WorkitemQueryJobResponse**](WorkitemQueryJobResponse.html)

<a name="gettaskmanagementworkitemsqueryjobresults"></a>

## [**WorkitemPagedEntityListing**](WorkitemPagedEntityListing.html) GetTaskmanagementWorkitemsQueryJobResults (string jobId)



Get results from for workitem query job 

Requires ALL permissions: 

* workitems:queryJobResults:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorkitemsQueryJobResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get results from for workitem query job 
                WorkitemPagedEntityListing result = apiInstance.GetTaskmanagementWorkitemsQueryJobResults(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorkitemsQueryJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
{: class="table table-striped"}

### Return type

[**WorkitemPagedEntityListing**](WorkitemPagedEntityListing.html)

<a name="gettaskmanagementworkitemsschema"></a>

## [**DataSchema**](DataSchema.html) GetTaskmanagementWorkitemsSchema (string schemaId)



Get a schema

Requires ANY permissions: 

* workitems:workitemSchema:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorkitemsSchemaExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var schemaId = schemaId_example;  // string | Schema ID

            try
            { 
                // Get a schema
                DataSchema result = apiInstance.GetTaskmanagementWorkitemsSchema(schemaId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorkitemsSchema: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **schemaId** | **string**| Schema ID |  |
{: class="table table-striped"}

### Return type

[**DataSchema**](DataSchema.html)

<a name="gettaskmanagementworkitemsschemaversion"></a>

## [**DataSchema**](DataSchema.html) GetTaskmanagementWorkitemsSchemaVersion (string schemaId, string versionId)



Get a specific version of a schema

Requires ANY permissions: 

* workitems:workitemSchema:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorkitemsSchemaVersionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var schemaId = schemaId_example;  // string | Schema ID
            var versionId = versionId_example;  // string | Schema version

            try
            { 
                // Get a specific version of a schema
                DataSchema result = apiInstance.GetTaskmanagementWorkitemsSchemaVersion(schemaId, versionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorkitemsSchemaVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **schemaId** | **string**| Schema ID |  |
| **versionId** | **string**| Schema version |  |
{: class="table table-striped"}

### Return type

[**DataSchema**](DataSchema.html)

<a name="gettaskmanagementworkitemsschemaversions"></a>

## [**DataSchema**](DataSchema.html) GetTaskmanagementWorkitemsSchemaVersions (string schemaId)



Get all versions of a schema

Requires ANY permissions: 

* workitems:workitemSchema:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorkitemsSchemaVersionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var schemaId = schemaId_example;  // string | Schema ID

            try
            { 
                // Get all versions of a schema
                DataSchema result = apiInstance.GetTaskmanagementWorkitemsSchemaVersions(schemaId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorkitemsSchemaVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **schemaId** | **string**| Schema ID |  |
{: class="table table-striped"}

### Return type

[**DataSchema**](DataSchema.html)

<a name="gettaskmanagementworkitemsschemas"></a>

## [**DataSchemaListing**](DataSchemaListing.html) GetTaskmanagementWorkitemsSchemas ()



Get a list of schemas.

Requires ANY permissions: 

* workitems:workitemSchema:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorkitemsSchemasExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();

            try
            { 
                // Get a list of schemas.
                DataSchemaListing result = apiInstance.GetTaskmanagementWorkitemsSchemas();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorkitemsSchemas: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**DataSchemaListing**](DataSchemaListing.html)

<a name="gettaskmanagementworktype"></a>

## [**Worktype**](Worktype.html) GetTaskmanagementWorktype (string worktypeId, List<string> expands = null)



Get a worktype

Requires ANY permissions: 

* workitems:worktype:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorktypeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var worktypeId = worktypeId_example;  // string | Worktype id
            var expands = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 

            try
            { 
                // Get a worktype
                Worktype result = apiInstance.GetTaskmanagementWorktype(worktypeId, expands);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorktype: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **worktypeId** | **string**| Worktype id |  |
| **expands** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional] <br />**Values**: defaultQueue, defaultSkills, defaultLanguage, schema |
{: class="table table-striped"}

### Return type

[**Worktype**](Worktype.html)

<a name="gettaskmanagementworktypehistory"></a>

## [**WorktypeChangeListing**](WorktypeChangeListing.html) GetTaskmanagementWorktypeHistory (string worktypeId, string after = null, int? pageSize = null, string sortOrder = null, List<string> fields = null)



Get a listing of a worktype's attribute change history

GetTaskmanagementWorktypeHistory is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* workitems:worktype:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorktypeHistoryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var worktypeId = worktypeId_example;  // string | Worktype id
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = 56;  // int? | Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an `after` key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional)  (default to 25)
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to descending)
            var fields = new List<string>(); // List<string> | Comma-separated list of fields. The response will contain only versions created as a result of changes to these fields. (optional) 

            try
            { 
                // Get a listing of a worktype's attribute change history
                WorktypeChangeListing result = apiInstance.GetTaskmanagementWorktypeHistory(worktypeId, after, pageSize, sortOrder, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorktypeHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **worktypeId** | **string**| Worktype id |  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **int?**| Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. | [optional] [default to 25] |
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to descending]<br />**Values**: ascending, descending |
| **fields** | [**List<string>**](string.html)| Comma-separated list of fields. The response will contain only versions created as a result of changes to these fields. | [optional] <br />**Values**: name, serviceLevelTarget, defaultWorkbinId, defaultDueDurationSeconds, defaultExpirationSeconds, defaultPriority, defaultLanguageId, defaultSkillIds, defaultQueueId, assignmentEnabled, defaultStatusId, statuses |
{: class="table table-striped"}

### Return type

[**WorktypeChangeListing**](WorktypeChangeListing.html)

<a name="gettaskmanagementworktypestatus"></a>

## [**WorkitemStatus**](WorkitemStatus.html) GetTaskmanagementWorktypeStatus (string worktypeId, string statusId)



Get a status

Requires ANY permissions: 

* workitems:status:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorktypeStatusExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var worktypeId = worktypeId_example;  // string | Worktype id
            var statusId = statusId_example;  // string | Status id

            try
            { 
                // Get a status
                WorkitemStatus result = apiInstance.GetTaskmanagementWorktypeStatus(worktypeId, statusId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorktypeStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **worktypeId** | **string**| Worktype id |  |
| **statusId** | **string**| Status id |  |
{: class="table table-striped"}

### Return type

[**WorkitemStatus**](WorkitemStatus.html)

<a name="gettaskmanagementworktypestatuses"></a>

## [**WorkitemStatusListing**](WorkitemStatusListing.html) GetTaskmanagementWorktypeStatuses (string worktypeId)



Get list of statuses for this worktype.

Requires ANY permissions: 

* workitems:status:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorktypeStatusesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var worktypeId = worktypeId_example;  // string | Worktype id

            try
            { 
                // Get list of statuses for this worktype.
                WorkitemStatusListing result = apiInstance.GetTaskmanagementWorktypeStatuses(worktypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorktypeStatuses: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **worktypeId** | **string**| Worktype id |  |
{: class="table table-striped"}

### Return type

[**WorkitemStatusListing**](WorkitemStatusListing.html)

<a name="gettaskmanagementworktypeversion"></a>

## [**WorktypeVersion**](WorktypeVersion.html) GetTaskmanagementWorktypeVersion (string worktypeId, int? entityVersion)



Get a version of a worktype

GetTaskmanagementWorktypeVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* workitems:worktype:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorktypeVersionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var worktypeId = worktypeId_example;  // string | Worktype id
            var entityVersion = 56;  // int? | Worktype version

            try
            { 
                // Get a version of a worktype
                WorktypeVersion result = apiInstance.GetTaskmanagementWorktypeVersion(worktypeId, entityVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorktypeVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **worktypeId** | **string**| Worktype id |  |
| **entityVersion** | **int?**| Worktype version |  |
{: class="table table-striped"}

### Return type

[**WorktypeVersion**](WorktypeVersion.html)

<a name="gettaskmanagementworktypeversions"></a>

## [**WorktypeVersionListing**](WorktypeVersionListing.html) GetTaskmanagementWorktypeVersions (string worktypeId, string after = null, int? pageSize = null, string sortOrder = null)



Get all versions of a worktype

GetTaskmanagementWorktypeVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* workitems:worktype:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorktypeVersionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var worktypeId = worktypeId_example;  // string | Worktype id
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = 56;  // int? | Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an `after` key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional)  (default to 25)
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to descending)

            try
            { 
                // Get all versions of a worktype
                WorktypeVersionListing result = apiInstance.GetTaskmanagementWorktypeVersions(worktypeId, after, pageSize, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorktypeVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **worktypeId** | **string**| Worktype id |  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **int?**| Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. | [optional] [default to 25] |
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to descending]<br />**Values**: ascending, descending |
{: class="table table-striped"}

### Return type

[**WorktypeVersionListing**](WorktypeVersionListing.html)

<a name="patchtaskmanagementworkbin"></a>

## [**Workbin**](Workbin.html) PatchTaskmanagementWorkbin (string workbinId, WorkbinUpdate body)



Update the attributes of a workbin

Requires ANY permissions: 

* workitems:workbin:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchTaskmanagementWorkbinExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var workbinId = workbinId_example;  // string | Workbin ID
            var body = new WorkbinUpdate(); // WorkbinUpdate | Json with attributes and their new values: {\"description\":\"new description\", \"name\":\"new name\"}.

            try
            { 
                // Update the attributes of a workbin
                Workbin result = apiInstance.PatchTaskmanagementWorkbin(workbinId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.PatchTaskmanagementWorkbin: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workbinId** | **string**| Workbin ID |  |
| **body** | [**WorkbinUpdate**](WorkbinUpdate.html)| Json with attributes and their new values: {\&quot;description\&quot;:\&quot;new description\&quot;, \&quot;name\&quot;:\&quot;new name\&quot;}. |  |
{: class="table table-striped"}

### Return type

[**Workbin**](Workbin.html)

<a name="patchtaskmanagementworkitem"></a>

## [**Workitem**](Workitem.html) PatchTaskmanagementWorkitem (string workitemId, WorkitemUpdate body)



Update the attributes of a workitem

Requires ANY permissions: 

* workitems:workitem:edit
* workitems:workitem:accept

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchTaskmanagementWorkitemExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var workitemId = workitemId_example;  // string | Workitem ID
            var body = new WorkitemUpdate(); // WorkitemUpdate | Workitem

            try
            { 
                // Update the attributes of a workitem
                Workitem result = apiInstance.PatchTaskmanagementWorkitem(workitemId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.PatchTaskmanagementWorkitem: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workitemId** | **string**| Workitem ID |  |
| **body** | [**WorkitemUpdate**](WorkitemUpdate.html)| Workitem |  |
{: class="table table-striped"}

### Return type

[**Workitem**](Workitem.html)

<a name="patchtaskmanagementworkitemassignment"></a>

## void PatchTaskmanagementWorkitemAssignment (string workitemId, WorkitemManualAssign body)



Attempts to manually assign a specified workitem to a specified user.  Ignores bullseye ring, PAR score, skills, and languages.

Requires ANY permissions: 

* workitems:workitem:pull
* workitems:workitem:assign

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchTaskmanagementWorkitemAssignmentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var workitemId = workitemId_example;  // string | Workitem ID
            var body = new WorkitemManualAssign(); // WorkitemManualAssign | Targeted user

            try
            { 
                // Attempts to manually assign a specified workitem to a specified user.  Ignores bullseye ring, PAR score, skills, and languages.
                apiInstance.PatchTaskmanagementWorkitemAssignment(workitemId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.PatchTaskmanagementWorkitemAssignment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workitemId** | **string**| Workitem ID |  |
| **body** | [**WorkitemManualAssign**](WorkitemManualAssign.html)| Targeted user |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchtaskmanagementworkitemuserwrapups"></a>

## [**WorkitemWrapup**](WorkitemWrapup.html) PatchTaskmanagementWorkitemUserWrapups (string workitemId, string userId, WorkitemWrapupUpdate body)



Add/Remove a wrapup code for a given user in a workitem.

Requires ANY permissions: 

* workitems:wrapup:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchTaskmanagementWorkitemUserWrapupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var workitemId = workitemId_example;  // string | The ID of the Workitem.
            var userId = userId_example;  // string | The ID of the user
            var body = new WorkitemWrapupUpdate(); // WorkitemWrapupUpdate | Request body to add/remove a wrapup code for a workitem

            try
            { 
                // Add/Remove a wrapup code for a given user in a workitem.
                WorkitemWrapup result = apiInstance.PatchTaskmanagementWorkitemUserWrapups(workitemId, userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.PatchTaskmanagementWorkitemUserWrapups: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workitemId** | **string**| The ID of the Workitem. |  |
| **userId** | **string**| The ID of the user |  |
| **body** | [**WorkitemWrapupUpdate**](WorkitemWrapupUpdate.html)| Request body to add/remove a wrapup code for a workitem |  |
{: class="table table-striped"}

### Return type

[**WorkitemWrapup**](WorkitemWrapup.html)

<a name="patchtaskmanagementworkitemusersmewrapups"></a>

## [**WorkitemWrapup**](WorkitemWrapup.html) PatchTaskmanagementWorkitemUsersMeWrapups (string workitemId, WorkitemWrapupUpdate body)



Add/Remove a wrapup code for the current user in a workitem.

Requires ANY permissions: 

* workitems:wrapupSelf:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchTaskmanagementWorkitemUsersMeWrapupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var workitemId = workitemId_example;  // string | The ID of the Workitem.
            var body = new WorkitemWrapupUpdate(); // WorkitemWrapupUpdate | Request body to add/remove the wrapup code for workitem

            try
            { 
                // Add/Remove a wrapup code for the current user in a workitem.
                WorkitemWrapup result = apiInstance.PatchTaskmanagementWorkitemUsersMeWrapups(workitemId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.PatchTaskmanagementWorkitemUsersMeWrapups: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workitemId** | **string**| The ID of the Workitem. |  |
| **body** | [**WorkitemWrapupUpdate**](WorkitemWrapupUpdate.html)| Request body to add/remove the wrapup code for workitem |  |
{: class="table table-striped"}

### Return type

[**WorkitemWrapup**](WorkitemWrapup.html)

<a name="patchtaskmanagementworktype"></a>

## [**Worktype**](Worktype.html) PatchTaskmanagementWorktype (string worktypeId, WorktypeUpdate body)



Update the attributes of a worktype

Requires ALL permissions: 

* workitems:worktype:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchTaskmanagementWorktypeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var worktypeId = worktypeId_example;  // string | Worktype id
            var body = new WorktypeUpdate(); // WorktypeUpdate | Worktype

            try
            { 
                // Update the attributes of a worktype
                Worktype result = apiInstance.PatchTaskmanagementWorktype(worktypeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.PatchTaskmanagementWorktype: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **worktypeId** | **string**| Worktype id |  |
| **body** | [**WorktypeUpdate**](WorktypeUpdate.html)| Worktype |  |
{: class="table table-striped"}

### Return type

[**Worktype**](Worktype.html)

<a name="patchtaskmanagementworktypestatus"></a>

## [**WorkitemStatus**](WorkitemStatus.html) PatchTaskmanagementWorktypeStatus (string worktypeId, string statusId, WorkitemStatusUpdate body)



Update the attributes of a status

Requires ANY permissions: 

* workitems:status:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchTaskmanagementWorktypeStatusExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var worktypeId = worktypeId_example;  // string | Worktype id
            var statusId = statusId_example;  // string | Status id
            var body = new WorkitemStatusUpdate(); // WorkitemStatusUpdate | Status

            try
            { 
                // Update the attributes of a status
                WorkitemStatus result = apiInstance.PatchTaskmanagementWorktypeStatus(worktypeId, statusId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.PatchTaskmanagementWorktypeStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **worktypeId** | **string**| Worktype id |  |
| **statusId** | **string**| Status id |  |
| **body** | [**WorkitemStatusUpdate**](WorkitemStatusUpdate.html)| Status |  |
{: class="table table-striped"}

### Return type

[**WorkitemStatus**](WorkitemStatus.html)

<a name="posttaskmanagementworkbins"></a>

## [**Workbin**](Workbin.html) PostTaskmanagementWorkbins (WorkbinCreate body)



Create a workbin

Requires ANY permissions: 

* workitems:workbin:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTaskmanagementWorkbinsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var body = new WorkbinCreate(); // WorkbinCreate | Workbin

            try
            { 
                // Create a workbin
                Workbin result = apiInstance.PostTaskmanagementWorkbins(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.PostTaskmanagementWorkbins: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**WorkbinCreate**](WorkbinCreate.html)| Workbin |  |
{: class="table table-striped"}

### Return type

[**Workbin**](Workbin.html)

<a name="posttaskmanagementworkbinsquery"></a>

## [**WorkbinQueryEntityListing**](WorkbinQueryEntityListing.html) PostTaskmanagementWorkbinsQuery (WorkbinQueryRequest body)



Query for workbins

Requires ALL permissions: 

* workitems:workbin:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTaskmanagementWorkbinsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var body = new WorkbinQueryRequest(); // WorkbinQueryRequest | QueryPostRequest

            try
            { 
                // Query for workbins
                WorkbinQueryEntityListing result = apiInstance.PostTaskmanagementWorkbinsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.PostTaskmanagementWorkbinsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**WorkbinQueryRequest**](WorkbinQueryRequest.html)| QueryPostRequest |  |
{: class="table table-striped"}

### Return type

[**WorkbinQueryEntityListing**](WorkbinQueryEntityListing.html)

<a name="posttaskmanagementworkitemacdcancel"></a>

## [**Workitem**](Workitem.html) PostTaskmanagementWorkitemAcdCancel (string workitemId)



Cancel the assignment process for a workitem that is currently queued for assignment through ACD.

Requires ANY permissions: 

* workitems:workitem:cancelRouting

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTaskmanagementWorkitemAcdCancelExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var workitemId = workitemId_example;  // string | Workitem ID

            try
            { 
                // Cancel the assignment process for a workitem that is currently queued for assignment through ACD.
                Workitem result = apiInstance.PostTaskmanagementWorkitemAcdCancel(workitemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.PostTaskmanagementWorkitemAcdCancel: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workitemId** | **string**| Workitem ID |  |
{: class="table table-striped"}

### Return type

[**Workitem**](Workitem.html)

<a name="posttaskmanagementworkitemdisconnect"></a>

## [**Workitem**](Workitem.html) PostTaskmanagementWorkitemDisconnect (string workitemId)



Disconnect the assignee of the workitem

Requires ANY permissions: 

* workitems:workitem:disconnect

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTaskmanagementWorkitemDisconnectExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var workitemId = workitemId_example;  // string | Workitem ID

            try
            { 
                // Disconnect the assignee of the workitem
                Workitem result = apiInstance.PostTaskmanagementWorkitemDisconnect(workitemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.PostTaskmanagementWorkitemDisconnect: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workitemId** | **string**| Workitem ID |  |
{: class="table table-striped"}

### Return type

[**Workitem**](Workitem.html)

<a name="posttaskmanagementworkitemterminate"></a>

## [**Workitem**](Workitem.html) PostTaskmanagementWorkitemTerminate (string workitemId, WorkitemTerminate body = null)



Terminate a workitem

Requires ANY permissions: 

* workitems:workitem:terminate

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTaskmanagementWorkitemTerminateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var workitemId = workitemId_example;  // string | Workitem ID
            var body = new WorkitemTerminate(); // WorkitemTerminate | Terminated request (optional) 

            try
            { 
                // Terminate a workitem
                Workitem result = apiInstance.PostTaskmanagementWorkitemTerminate(workitemId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.PostTaskmanagementWorkitemTerminate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workitemId** | **string**| Workitem ID |  |
| **body** | [**WorkitemTerminate**](WorkitemTerminate.html)| Terminated request | [optional]  |
{: class="table table-striped"}

### Return type

[**Workitem**](Workitem.html)

<a name="posttaskmanagementworkitems"></a>

## [**Workitem**](Workitem.html) PostTaskmanagementWorkitems (WorkitemCreate body)



Create a workitem

Requires ANY permissions: 

* workitems:workitem:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTaskmanagementWorkitemsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var body = new WorkitemCreate(); // WorkitemCreate | Workitem

            try
            { 
                // Create a workitem
                Workitem result = apiInstance.PostTaskmanagementWorkitems(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.PostTaskmanagementWorkitems: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**WorkitemCreate**](WorkitemCreate.html)| Workitem |  |
{: class="table table-striped"}

### Return type

[**Workitem**](Workitem.html)

<a name="posttaskmanagementworkitemsquery"></a>

## [**WorkitemPostQueryEntityListing**](WorkitemPostQueryEntityListing.html) PostTaskmanagementWorkitemsQuery (WorkitemQueryPostRequest body)



Query for workitems

This query requires at least one EQ filter on the workbinId, assigneeId or typeId attributes.

PostTaskmanagementWorkitemsQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* workitems:workitem:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTaskmanagementWorkitemsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var body = new WorkitemQueryPostRequest(); // WorkitemQueryPostRequest | WorkitemQueryPostRequest

            try
            { 
                // Query for workitems
                WorkitemPostQueryEntityListing result = apiInstance.PostTaskmanagementWorkitemsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.PostTaskmanagementWorkitemsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**WorkitemQueryPostRequest**](WorkitemQueryPostRequest.html)| WorkitemQueryPostRequest |  |
{: class="table table-striped"}

### Return type

[**WorkitemPostQueryEntityListing**](WorkitemPostQueryEntityListing.html)

<a name="posttaskmanagementworkitemsqueryjobs"></a>

## [**WorkitemQueryJobResponse**](WorkitemQueryJobResponse.html) PostTaskmanagementWorkitemsQueryJobs (WorkitemQueryJobCreate body)



Create a workitem query job

Requires ANY permissions: 

* workitems:queryJob:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTaskmanagementWorkitemsQueryJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var body = new WorkitemQueryJobCreate(); // WorkitemQueryJobCreate | WorkitemQueryJobCreate

            try
            { 
                // Create a workitem query job
                WorkitemQueryJobResponse result = apiInstance.PostTaskmanagementWorkitemsQueryJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.PostTaskmanagementWorkitemsQueryJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**WorkitemQueryJobCreate**](WorkitemQueryJobCreate.html)| WorkitemQueryJobCreate |  |
{: class="table table-striped"}

### Return type

[**WorkitemQueryJobResponse**](WorkitemQueryJobResponse.html)

<a name="posttaskmanagementworkitemsschemas"></a>

## [**DataSchema**](DataSchema.html) PostTaskmanagementWorkitemsSchemas (DataSchema body)



Create a schema

Requires ANY permissions: 

* workitems:workitemSchema:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTaskmanagementWorkitemsSchemasExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var body = new DataSchema(); // DataSchema | Schema

            try
            { 
                // Create a schema
                DataSchema result = apiInstance.PostTaskmanagementWorkitemsSchemas(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.PostTaskmanagementWorkitemsSchemas: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DataSchema**](DataSchema.html)| Schema |  |
{: class="table table-striped"}

### Return type

[**DataSchema**](DataSchema.html)

<a name="posttaskmanagementworktypestatuses"></a>

## [**WorkitemStatus**](WorkitemStatus.html) PostTaskmanagementWorktypeStatuses (string worktypeId, WorkitemStatusCreate body)



Add a status to a worktype

Requires ANY permissions: 

* workitems:status:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTaskmanagementWorktypeStatusesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var worktypeId = worktypeId_example;  // string | Worktype id
            var body = new WorkitemStatusCreate(); // WorkitemStatusCreate | Status

            try
            { 
                // Add a status to a worktype
                WorkitemStatus result = apiInstance.PostTaskmanagementWorktypeStatuses(worktypeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.PostTaskmanagementWorktypeStatuses: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **worktypeId** | **string**| Worktype id |  |
| **body** | [**WorkitemStatusCreate**](WorkitemStatusCreate.html)| Status |  |
{: class="table table-striped"}

### Return type

[**WorkitemStatus**](WorkitemStatus.html)

<a name="posttaskmanagementworktypes"></a>

## [**Worktype**](Worktype.html) PostTaskmanagementWorktypes (WorktypeCreate body)



Create a worktype

Requires ANY permissions: 

* workitems:worktype:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTaskmanagementWorktypesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var body = new WorktypeCreate(); // WorktypeCreate | Worktype

            try
            { 
                // Create a worktype
                Worktype result = apiInstance.PostTaskmanagementWorktypes(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.PostTaskmanagementWorktypes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**WorktypeCreate**](WorktypeCreate.html)| Worktype |  |
{: class="table table-striped"}

### Return type

[**Worktype**](Worktype.html)

<a name="posttaskmanagementworktypesquery"></a>

## [**WorktypeQueryEntityListing**](WorktypeQueryEntityListing.html) PostTaskmanagementWorktypesQuery (WorktypeQueryRequest body)



Query for worktypes

Requires ALL permissions: 

* workitems:worktype:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTaskmanagementWorktypesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var body = new WorktypeQueryRequest(); // WorktypeQueryRequest | QueryPostRequest

            try
            { 
                // Query for worktypes
                WorktypeQueryEntityListing result = apiInstance.PostTaskmanagementWorktypesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.PostTaskmanagementWorktypesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**WorktypeQueryRequest**](WorktypeQueryRequest.html)| QueryPostRequest |  |
{: class="table table-striped"}

### Return type

[**WorktypeQueryEntityListing**](WorktypeQueryEntityListing.html)

<a name="puttaskmanagementworkitemsschema"></a>

## [**DataSchema**](DataSchema.html) PutTaskmanagementWorkitemsSchema (string schemaId, DataSchema body)



Update a schema

Requires ANY permissions: 

* workitems:workitemSchema:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutTaskmanagementWorkitemsSchemaExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TaskManagementApi();
            var schemaId = schemaId_example;  // string | Schema ID
            var body = new DataSchema(); // DataSchema | Data Schema

            try
            { 
                // Update a schema
                DataSchema result = apiInstance.PutTaskmanagementWorkitemsSchema(schemaId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.PutTaskmanagementWorkitemsSchema: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **schemaId** | **string**| Schema ID |  |
| **body** | [**DataSchema**](DataSchema.html)| Data Schema |  |
{: class="table table-striped"}

### Return type

[**DataSchema**](DataSchema.html)

