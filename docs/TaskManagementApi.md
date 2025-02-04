# TaskManagementApi

## PureCloudPlatform.Client.V2.Api.TaskManagementApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteTaskmanagementWorkbin**](#DeleteTaskmanagementWorkbin) | **Delete** /api/v2/taskmanagement/workbins/{workbinId} | Delete a workbin |
| [**DeleteTaskmanagementWorkitem**](#DeleteTaskmanagementWorkitem) | **Delete** /api/v2/taskmanagement/workitems/{workitemId} | Delete a workitem |
| [**DeleteTaskmanagementWorkitemsBulkAddJob**](#DeleteTaskmanagementWorkitemsBulkAddJob) | **Delete** /api/v2/taskmanagement/workitems/bulk/add/jobs/{bulkJobId} | Delete a bulk add job |
| [**DeleteTaskmanagementWorkitemsBulkTerminateJob**](#DeleteTaskmanagementWorkitemsBulkTerminateJob) | **Delete** /api/v2/taskmanagement/workitems/bulk/terminate/jobs/{bulkJobId} | Delete a Bulk job |
| [**DeleteTaskmanagementWorkitemsSchema**](#DeleteTaskmanagementWorkitemsSchema) | **Delete** /api/v2/taskmanagement/workitems/schemas/{schemaId} | Delete a schema |
| [**DeleteTaskmanagementWorktype**](#DeleteTaskmanagementWorktype) | **Delete** /api/v2/taskmanagement/worktypes/{worktypeId} | Delete a worktype |
| [**DeleteTaskmanagementWorktypeFlowsDatebasedRule**](#DeleteTaskmanagementWorktypeFlowsDatebasedRule) | **Delete** /api/v2/taskmanagement/worktypes/{worktypeId}/flows/datebased/rules/{ruleId} | Delete a date based rule |
| [**DeleteTaskmanagementWorktypeFlowsOnattributechangeRule**](#DeleteTaskmanagementWorktypeFlowsOnattributechangeRule) | **Delete** /api/v2/taskmanagement/worktypes/{worktypeId}/flows/onattributechange/rules/{ruleId} | Delete a rule |
| [**DeleteTaskmanagementWorktypeFlowsOncreateRule**](#DeleteTaskmanagementWorktypeFlowsOncreateRule) | **Delete** /api/v2/taskmanagement/worktypes/{worktypeId}/flows/oncreate/rules/{ruleId} | Delete a rule |
| [**DeleteTaskmanagementWorktypeStatus**](#DeleteTaskmanagementWorktypeStatus) | **Delete** /api/v2/taskmanagement/worktypes/{worktypeId}/statuses/{statusId} | Delete a status |
| [**GetTaskmanagementWorkbin**](#GetTaskmanagementWorkbin) | **Get** /api/v2/taskmanagement/workbins/{workbinId} | Get a workbin |
| [**GetTaskmanagementWorkbinHistory**](#GetTaskmanagementWorkbinHistory) | **Get** /api/v2/taskmanagement/workbins/{workbinId}/history | Get a listing of a workbin&#39;s attribute change history |
| [**GetTaskmanagementWorkbinVersion**](#GetTaskmanagementWorkbinVersion) | **Get** /api/v2/taskmanagement/workbins/{workbinId}/versions/{entityVersion} | Get a version of a workbin |
| [**GetTaskmanagementWorkbinVersions**](#GetTaskmanagementWorkbinVersions) | **Get** /api/v2/taskmanagement/workbins/{workbinId}/versions | Get all versions of a workbin |
| [**GetTaskmanagementWorkitem**](#GetTaskmanagementWorkitem) | **Get** /api/v2/taskmanagement/workitems/{workitemId} | Get a workitem |
| [**GetTaskmanagementWorkitemHistory**](#GetTaskmanagementWorkitemHistory) | **Get** /api/v2/taskmanagement/workitems/{workitemId}/history | Get a listing of a workitem&#39;s attribute change history |
| [**GetTaskmanagementWorkitemUserWrapups**](#GetTaskmanagementWorkitemUserWrapups) | **Get** /api/v2/taskmanagement/workitems/{workitemId}/users/{userId}/wrapups | Get all wrapup codes added for the given user for a workitem. |
| [**GetTaskmanagementWorkitemVersion**](#GetTaskmanagementWorkitemVersion) | **Get** /api/v2/taskmanagement/workitems/{workitemId}/versions/{entityVersion} | Get a version of a workitem |
| [**GetTaskmanagementWorkitemVersions**](#GetTaskmanagementWorkitemVersions) | **Get** /api/v2/taskmanagement/workitems/{workitemId}/versions | Get all versions of a workitem |
| [**GetTaskmanagementWorkitemWrapups**](#GetTaskmanagementWorkitemWrapups) | **Get** /api/v2/taskmanagement/workitems/{workitemId}/wrapups | Get all wrapup codes added for all users for a workitem. |
| [**GetTaskmanagementWorkitemsBulkAddJob**](#GetTaskmanagementWorkitemsBulkAddJob) | **Get** /api/v2/taskmanagement/workitems/bulk/add/jobs/{bulkJobId} | Get the bulk add job associated with the job id. |
| [**GetTaskmanagementWorkitemsBulkAddJobResults**](#GetTaskmanagementWorkitemsBulkAddJobResults) | **Get** /api/v2/taskmanagement/workitems/bulk/add/jobs/{bulkJobId}/results | Get bulk add job results. |
| [**GetTaskmanagementWorkitemsBulkJobsUsersMe**](#GetTaskmanagementWorkitemsBulkJobsUsersMe) | **Get** /api/v2/taskmanagement/workitems/bulk/jobs/users/me | Get bulk jobs created by the currently logged in user. |
| [**GetTaskmanagementWorkitemsBulkTerminateJob**](#GetTaskmanagementWorkitemsBulkTerminateJob) | **Get** /api/v2/taskmanagement/workitems/bulk/terminate/jobs/{bulkJobId} | Get the bulk job associated with the job id. |
| [**GetTaskmanagementWorkitemsBulkTerminateJobResults**](#GetTaskmanagementWorkitemsBulkTerminateJobResults) | **Get** /api/v2/taskmanagement/workitems/bulk/terminate/jobs/{bulkJobId}/results | Get bulk terminate job results. |
| [**GetTaskmanagementWorkitemsQueryJob**](#GetTaskmanagementWorkitemsQueryJob) | **Get** /api/v2/taskmanagement/workitems/query/jobs/{jobId} | Get the workitem query job associated with the job id. |
| [**GetTaskmanagementWorkitemsQueryJobResults**](#GetTaskmanagementWorkitemsQueryJobResults) | **Get** /api/v2/taskmanagement/workitems/query/jobs/{jobId}/results | Get results from for workitem query job  |
| [**GetTaskmanagementWorkitemsSchema**](#GetTaskmanagementWorkitemsSchema) | **Get** /api/v2/taskmanagement/workitems/schemas/{schemaId} | Get a schema |
| [**GetTaskmanagementWorkitemsSchemaVersion**](#GetTaskmanagementWorkitemsSchemaVersion) | **Get** /api/v2/taskmanagement/workitems/schemas/{schemaId}/versions/{versionId} | Get a specific version of a schema |
| [**GetTaskmanagementWorkitemsSchemaVersions**](#GetTaskmanagementWorkitemsSchemaVersions) | **Get** /api/v2/taskmanagement/workitems/schemas/{schemaId}/versions | Get all versions of a schema |
| [**GetTaskmanagementWorkitemsSchemas**](#GetTaskmanagementWorkitemsSchemas) | **Get** /api/v2/taskmanagement/workitems/schemas | Get a list of schemas. |
| [**GetTaskmanagementWorktype**](#GetTaskmanagementWorktype) | **Get** /api/v2/taskmanagement/worktypes/{worktypeId} | Get a worktype |
| [**GetTaskmanagementWorktypeFlowsDatebasedRule**](#GetTaskmanagementWorktypeFlowsDatebasedRule) | **Get** /api/v2/taskmanagement/worktypes/{worktypeId}/flows/datebased/rules/{ruleId} | Get a date based rule |
| [**GetTaskmanagementWorktypeFlowsDatebasedRules**](#GetTaskmanagementWorktypeFlowsDatebasedRules) | **Get** /api/v2/taskmanagement/worktypes/{worktypeId}/flows/datebased/rules | Get all date based rules for a worktype |
| [**GetTaskmanagementWorktypeFlowsOnattributechangeRule**](#GetTaskmanagementWorktypeFlowsOnattributechangeRule) | **Get** /api/v2/taskmanagement/worktypes/{worktypeId}/flows/onattributechange/rules/{ruleId} | Get an attribute change rule |
| [**GetTaskmanagementWorktypeFlowsOnattributechangeRules**](#GetTaskmanagementWorktypeFlowsOnattributechangeRules) | **Get** /api/v2/taskmanagement/worktypes/{worktypeId}/flows/onattributechange/rules | Get all attribute-change rules for a worktype |
| [**GetTaskmanagementWorktypeFlowsOncreateRule**](#GetTaskmanagementWorktypeFlowsOncreateRule) | **Get** /api/v2/taskmanagement/worktypes/{worktypeId}/flows/oncreate/rules/{ruleId} | Get an on-create rule |
| [**GetTaskmanagementWorktypeFlowsOncreateRules**](#GetTaskmanagementWorktypeFlowsOncreateRules) | **Get** /api/v2/taskmanagement/worktypes/{worktypeId}/flows/oncreate/rules | Get all on-create rules for a worktype |
| [**GetTaskmanagementWorktypeHistory**](#GetTaskmanagementWorktypeHistory) | **Get** /api/v2/taskmanagement/worktypes/{worktypeId}/history | Get a listing of a worktype&#39;s attribute change history |
| [**GetTaskmanagementWorktypeStatus**](#GetTaskmanagementWorktypeStatus) | **Get** /api/v2/taskmanagement/worktypes/{worktypeId}/statuses/{statusId} | Get a status |
| [**GetTaskmanagementWorktypeStatuses**](#GetTaskmanagementWorktypeStatuses) | **Get** /api/v2/taskmanagement/worktypes/{worktypeId}/statuses | Get list of statuses for this worktype. |
| [**GetTaskmanagementWorktypeVersion**](#GetTaskmanagementWorktypeVersion) | **Get** /api/v2/taskmanagement/worktypes/{worktypeId}/versions/{entityVersion} | Get a version of a worktype |
| [**GetTaskmanagementWorktypeVersions**](#GetTaskmanagementWorktypeVersions) | **Get** /api/v2/taskmanagement/worktypes/{worktypeId}/versions | Get all versions of a worktype |
| [**PatchTaskmanagementWorkbin**](#PatchTaskmanagementWorkbin) | **Patch** /api/v2/taskmanagement/workbins/{workbinId} | Update the attributes of a workbin |
| [**PatchTaskmanagementWorkitem**](#PatchTaskmanagementWorkitem) | **Patch** /api/v2/taskmanagement/workitems/{workitemId} | Update the attributes of a workitem |
| [**PatchTaskmanagementWorkitemAssignment**](#PatchTaskmanagementWorkitemAssignment) | **Patch** /api/v2/taskmanagement/workitems/{workitemId}/assignment | Attempts to manually assign a specified workitem to a specified user.  Ignores bullseye ring, PAR score, skills, and languages. |
| [**PatchTaskmanagementWorkitemUserWrapups**](#PatchTaskmanagementWorkitemUserWrapups) | **Patch** /api/v2/taskmanagement/workitems/{workitemId}/users/{userId}/wrapups | Add/Remove a wrapup code for a given user in a workitem. |
| [**PatchTaskmanagementWorkitemUsersMeWrapups**](#PatchTaskmanagementWorkitemUsersMeWrapups) | **Patch** /api/v2/taskmanagement/workitems/{workitemId}/users/me/wrapups | Add/Remove a wrapup code for the current user in a workitem. |
| [**PatchTaskmanagementWorkitemsBulkAddJob**](#PatchTaskmanagementWorkitemsBulkAddJob) | **Patch** /api/v2/taskmanagement/workitems/bulk/add/jobs/{bulkJobId} | Update workitem bulk add job. |
| [**PatchTaskmanagementWorkitemsBulkTerminateJob**](#PatchTaskmanagementWorkitemsBulkTerminateJob) | **Patch** /api/v2/taskmanagement/workitems/bulk/terminate/jobs/{bulkJobId} | Update workitem bulk terminate job. |
| [**PatchTaskmanagementWorktype**](#PatchTaskmanagementWorktype) | **Patch** /api/v2/taskmanagement/worktypes/{worktypeId} | Update the attributes of a worktype |
| [**PatchTaskmanagementWorktypeFlowsDatebasedRule**](#PatchTaskmanagementWorktypeFlowsDatebasedRule) | **Patch** /api/v2/taskmanagement/worktypes/{worktypeId}/flows/datebased/rules/{ruleId} | Update the attributes of a date based rule |
| [**PatchTaskmanagementWorktypeFlowsOnattributechangeRule**](#PatchTaskmanagementWorktypeFlowsOnattributechangeRule) | **Patch** /api/v2/taskmanagement/worktypes/{worktypeId}/flows/onattributechange/rules/{ruleId} | Update the attributes of a rule |
| [**PatchTaskmanagementWorktypeFlowsOncreateRule**](#PatchTaskmanagementWorktypeFlowsOncreateRule) | **Patch** /api/v2/taskmanagement/worktypes/{worktypeId}/flows/oncreate/rules/{ruleId} | Update the attributes of a rule |
| [**PatchTaskmanagementWorktypeStatus**](#PatchTaskmanagementWorktypeStatus) | **Patch** /api/v2/taskmanagement/worktypes/{worktypeId}/statuses/{statusId} | Update the attributes of a status |
| [**PostTaskmanagementWorkbins**](#PostTaskmanagementWorkbins) | **Post** /api/v2/taskmanagement/workbins | Create a workbin |
| [**PostTaskmanagementWorkbinsQuery**](#PostTaskmanagementWorkbinsQuery) | **Post** /api/v2/taskmanagement/workbins/query | Query for workbins |
| [**PostTaskmanagementWorkitemAcdCancel**](#PostTaskmanagementWorkitemAcdCancel) | **Post** /api/v2/taskmanagement/workitems/{workitemId}/acd/cancel | Cancel the assignment process for a workitem that is currently queued for assignment through ACD. |
| [**PostTaskmanagementWorkitemDisconnect**](#PostTaskmanagementWorkitemDisconnect) | **Post** /api/v2/taskmanagement/workitems/{workitemId}/disconnect | Disconnect the assignee of the workitem |
| [**PostTaskmanagementWorkitemTerminate**](#PostTaskmanagementWorkitemTerminate) | **Post** /api/v2/taskmanagement/workitems/{workitemId}/terminate | Terminate a workitem |
| [**PostTaskmanagementWorkitems**](#PostTaskmanagementWorkitems) | **Post** /api/v2/taskmanagement/workitems | Create a workitem |
| [**PostTaskmanagementWorkitemsBulkAddJobs**](#PostTaskmanagementWorkitemsBulkAddJobs) | **Post** /api/v2/taskmanagement/workitems/bulk/add/jobs | Create a workitem bulk add job. |
| [**PostTaskmanagementWorkitemsBulkTerminateJobs**](#PostTaskmanagementWorkitemsBulkTerminateJobs) | **Post** /api/v2/taskmanagement/workitems/bulk/terminate/jobs | Create a workitem bulk terminate job. |
| [**PostTaskmanagementWorkitemsQuery**](#PostTaskmanagementWorkitemsQuery) | **Post** /api/v2/taskmanagement/workitems/query | Query for workitems |
| [**PostTaskmanagementWorkitemsQueryJobs**](#PostTaskmanagementWorkitemsQueryJobs) | **Post** /api/v2/taskmanagement/workitems/query/jobs | Create a workitem query job |
| [**PostTaskmanagementWorkitemsSchemas**](#PostTaskmanagementWorkitemsSchemas) | **Post** /api/v2/taskmanagement/workitems/schemas | Create a schema |
| [**PostTaskmanagementWorktypeFlowsDatebasedRules**](#PostTaskmanagementWorktypeFlowsDatebasedRules) | **Post** /api/v2/taskmanagement/worktypes/{worktypeId}/flows/datebased/rules | Add a date based rule to a worktype |
| [**PostTaskmanagementWorktypeFlowsOnattributechangeRules**](#PostTaskmanagementWorktypeFlowsOnattributechangeRules) | **Post** /api/v2/taskmanagement/worktypes/{worktypeId}/flows/onattributechange/rules | Add an attribute-change rule to a worktype |
| [**PostTaskmanagementWorktypeFlowsOncreateRules**](#PostTaskmanagementWorktypeFlowsOncreateRules) | **Post** /api/v2/taskmanagement/worktypes/{worktypeId}/flows/oncreate/rules | Add an on-create rule to a worktype |
| [**PostTaskmanagementWorktypeStatuses**](#PostTaskmanagementWorktypeStatuses) | **Post** /api/v2/taskmanagement/worktypes/{worktypeId}/statuses | Add a status to a worktype |
| [**PostTaskmanagementWorktypes**](#PostTaskmanagementWorktypes) | **Post** /api/v2/taskmanagement/worktypes | Create a worktype |
| [**PostTaskmanagementWorktypesQuery**](#PostTaskmanagementWorktypesQuery) | **Post** /api/v2/taskmanagement/worktypes/query | Query for worktypes |
| [**PutTaskmanagementWorkitemsSchema**](#PutTaskmanagementWorkitemsSchema) | **Put** /api/v2/taskmanagement/workitems/schemas/{schemaId} | Update a schema |



## DeleteTaskmanagementWorkbin

> void DeleteTaskmanagementWorkbin (string workbinId)


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

### Return type

void (empty response body)


## DeleteTaskmanagementWorkitem

> void DeleteTaskmanagementWorkitem (string workitemId)


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

### Return type

void (empty response body)


## DeleteTaskmanagementWorkitemsBulkAddJob

> void DeleteTaskmanagementWorkitemsBulkAddJob (string bulkJobId)


Delete a bulk add job

Requires ANY permissions: 

* workitems:bulkAddJob:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTaskmanagementWorkitemsBulkAddJobExample
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
            var bulkJobId = bulkJobId_example;  // string | Bulk job id

            try
            { 
                // Delete a bulk add job
                apiInstance.DeleteTaskmanagementWorkitemsBulkAddJob(bulkJobId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.DeleteTaskmanagementWorkitemsBulkAddJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **bulkJobId** | **string**| Bulk job id |  |

### Return type

void (empty response body)


## DeleteTaskmanagementWorkitemsBulkTerminateJob

> void DeleteTaskmanagementWorkitemsBulkTerminateJob (string bulkJobId)


Delete a Bulk job

Requires ALL permissions: 

* workitems:bulkTerminateJob:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTaskmanagementWorkitemsBulkTerminateJobExample
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
            var bulkJobId = bulkJobId_example;  // string | Bulk job id

            try
            { 
                // Delete a Bulk job
                apiInstance.DeleteTaskmanagementWorkitemsBulkTerminateJob(bulkJobId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.DeleteTaskmanagementWorkitemsBulkTerminateJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **bulkJobId** | **string**| Bulk job id |  |

### Return type

void (empty response body)


## DeleteTaskmanagementWorkitemsSchema

> void DeleteTaskmanagementWorkitemsSchema (string schemaId)


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

### Return type

void (empty response body)


## DeleteTaskmanagementWorktype

> void DeleteTaskmanagementWorktype (string worktypeId)


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

### Return type

void (empty response body)


## DeleteTaskmanagementWorktypeFlowsDatebasedRule

> void DeleteTaskmanagementWorktypeFlowsDatebasedRule (string worktypeId, string ruleId)


Delete a date based rule

Requires ANY permissions: 

* workitems:flowRuleDateBased:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTaskmanagementWorktypeFlowsDatebasedRuleExample
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
            var ruleId = ruleId_example;  // string | ruleId

            try
            { 
                // Delete a date based rule
                apiInstance.DeleteTaskmanagementWorktypeFlowsDatebasedRule(worktypeId, ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.DeleteTaskmanagementWorktypeFlowsDatebasedRule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **worktypeId** | **string**| Worktype id |  |
| **ruleId** | **string**| ruleId |  |

### Return type

void (empty response body)


## DeleteTaskmanagementWorktypeFlowsOnattributechangeRule

> void DeleteTaskmanagementWorktypeFlowsOnattributechangeRule (string worktypeId, string ruleId)


Delete a rule

Requires ANY permissions: 

* workitems:flowRuleOnAttributeChange:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTaskmanagementWorktypeFlowsOnattributechangeRuleExample
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
            var ruleId = ruleId_example;  // string | ruleId

            try
            { 
                // Delete a rule
                apiInstance.DeleteTaskmanagementWorktypeFlowsOnattributechangeRule(worktypeId, ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.DeleteTaskmanagementWorktypeFlowsOnattributechangeRule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **worktypeId** | **string**| Worktype id |  |
| **ruleId** | **string**| ruleId |  |

### Return type

void (empty response body)


## DeleteTaskmanagementWorktypeFlowsOncreateRule

> void DeleteTaskmanagementWorktypeFlowsOncreateRule (string worktypeId, string ruleId)


Delete a rule

Requires ANY permissions: 

* workitems:flowRuleOnCreate:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTaskmanagementWorktypeFlowsOncreateRuleExample
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
            var ruleId = ruleId_example;  // string | ruleId

            try
            { 
                // Delete a rule
                apiInstance.DeleteTaskmanagementWorktypeFlowsOncreateRule(worktypeId, ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.DeleteTaskmanagementWorktypeFlowsOncreateRule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **worktypeId** | **string**| Worktype id |  |
| **ruleId** | **string**| ruleId |  |

### Return type

void (empty response body)


## DeleteTaskmanagementWorktypeStatus

> void DeleteTaskmanagementWorktypeStatus (string worktypeId, string statusId)


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

### Return type

void (empty response body)


## GetTaskmanagementWorkbin

> [**Workbin**](Workbin) GetTaskmanagementWorkbin (string workbinId)


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

### Return type

[**Workbin**](Workbin)


## GetTaskmanagementWorkbinHistory

> [**WorkbinChangeListing**](WorkbinChangeListing) GetTaskmanagementWorkbinHistory (string workbinId, string after = null, int? pageSize = null, string sortOrder = null)


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

### Return type

[**WorkbinChangeListing**](WorkbinChangeListing)


## GetTaskmanagementWorkbinVersion

> [**WorkbinVersion**](WorkbinVersion) GetTaskmanagementWorkbinVersion (string workbinId, int? entityVersion)


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

### Return type

[**WorkbinVersion**](WorkbinVersion)


## GetTaskmanagementWorkbinVersions

> [**WorkbinVersionListing**](WorkbinVersionListing) GetTaskmanagementWorkbinVersions (string workbinId, string after = null, int? pageSize = null, string sortOrder = null)


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

### Return type

[**WorkbinVersionListing**](WorkbinVersionListing)


## GetTaskmanagementWorkitem

> [**Workitem**](Workitem) GetTaskmanagementWorkitem (string workitemId, string expands = null)


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

### Return type

[**Workitem**](Workitem)


## GetTaskmanagementWorkitemHistory

> [**WorkitemChangeListing**](WorkitemChangeListing) GetTaskmanagementWorkitemHistory (string workitemId, string after = null, int? pageSize = null, string sortOrder = null)


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

### Return type

[**WorkitemChangeListing**](WorkitemChangeListing)


## GetTaskmanagementWorkitemUserWrapups

> [**WorkitemWrapup**](WorkitemWrapup) GetTaskmanagementWorkitemUserWrapups (string workitemId, string userId, string expands = null, string after = null, int? pageSize = null, string sortOrder = null)


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

### Return type

[**WorkitemWrapup**](WorkitemWrapup)


## GetTaskmanagementWorkitemVersion

> [**WorkitemVersion**](WorkitemVersion) GetTaskmanagementWorkitemVersion (string workitemId, int? entityVersion)


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

### Return type

[**WorkitemVersion**](WorkitemVersion)


## GetTaskmanagementWorkitemVersions

> [**WorkitemVersionListing**](WorkitemVersionListing) GetTaskmanagementWorkitemVersions (string workitemId, string after = null, int? pageSize = null, string sortOrder = null)


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

### Return type

[**WorkitemVersionListing**](WorkitemVersionListing)


## GetTaskmanagementWorkitemWrapups

> [**WorkitemWrapupEntityListing**](WorkitemWrapupEntityListing) GetTaskmanagementWorkitemWrapups (string workitemId, string expands = null, string after = null, int? pageSize = null, string sortOrder = null)


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

### Return type

[**WorkitemWrapupEntityListing**](WorkitemWrapupEntityListing)


## GetTaskmanagementWorkitemsBulkAddJob

> [**BulkJob**](BulkJob) GetTaskmanagementWorkitemsBulkAddJob (string bulkJobId)


Get the bulk add job associated with the job id.

Requires ANY permissions: 

* workitems:bulkAddJob:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorkitemsBulkAddJobExample
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
            var bulkJobId = bulkJobId_example;  // string | Bulk job id

            try
            { 
                // Get the bulk add job associated with the job id.
                BulkJob result = apiInstance.GetTaskmanagementWorkitemsBulkAddJob(bulkJobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorkitemsBulkAddJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **bulkJobId** | **string**| Bulk job id |  |

### Return type

[**BulkJob**](BulkJob)


## GetTaskmanagementWorkitemsBulkAddJobResults

> [**BulkJobAddResponse**](BulkJobAddResponse) GetTaskmanagementWorkitemsBulkAddJobResults (string bulkJobId)


Get bulk add job results.

Requires ANY permissions: 

* workitems:bulkAddJobResults:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorkitemsBulkAddJobResultsExample
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
            var bulkJobId = bulkJobId_example;  // string | Bulk job id

            try
            { 
                // Get bulk add job results.
                BulkJobAddResponse result = apiInstance.GetTaskmanagementWorkitemsBulkAddJobResults(bulkJobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorkitemsBulkAddJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **bulkJobId** | **string**| Bulk job id |  |

### Return type

[**BulkJobAddResponse**](BulkJobAddResponse)


## GetTaskmanagementWorkitemsBulkJobsUsersMe

> [**BulkJobsListing**](BulkJobsListing) GetTaskmanagementWorkitemsBulkJobsUsersMe (string after = null, int? pageSize = null, string sortOrder = null, string action = null)


Get bulk jobs created by the currently logged in user.

Requires ANY permissions: 

* workitems:bulkJob:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorkitemsBulkJobsUsersMeExample
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
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = 56;  // int? | Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an `after` key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. (optional)  (default to 25)
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to descending)
            var action = action_example;  // string | The bulk job action. (optional) 

            try
            { 
                // Get bulk jobs created by the currently logged in user.
                BulkJobsListing result = apiInstance.GetTaskmanagementWorkitemsBulkJobsUsersMe(after, pageSize, sortOrder, action);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorkitemsBulkJobsUsersMe: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **int?**| Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. | [optional] [default to 25] |
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to descending]<br />**Values**: ascending, descending |
| **action** | **string**| The bulk job action. | [optional] <br />**Values**: TerminateWorkitems, AddWorkitems |

### Return type

[**BulkJobsListing**](BulkJobsListing)


## GetTaskmanagementWorkitemsBulkTerminateJob

> [**BulkJob**](BulkJob) GetTaskmanagementWorkitemsBulkTerminateJob (string bulkJobId)


Get the bulk job associated with the job id.

Requires ALL permissions: 

* workitems:bulkTerminateJob:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorkitemsBulkTerminateJobExample
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
            var bulkJobId = bulkJobId_example;  // string | Bulk job id

            try
            { 
                // Get the bulk job associated with the job id.
                BulkJob result = apiInstance.GetTaskmanagementWorkitemsBulkTerminateJob(bulkJobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorkitemsBulkTerminateJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **bulkJobId** | **string**| Bulk job id |  |

### Return type

[**BulkJob**](BulkJob)


## GetTaskmanagementWorkitemsBulkTerminateJobResults

> [**BulkJobTerminateResultsResponse**](BulkJobTerminateResultsResponse) GetTaskmanagementWorkitemsBulkTerminateJobResults (string bulkJobId)


Get bulk terminate job results.

Requires ALL permissions: 

* workitems:bulkTerminateJobResults:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorkitemsBulkTerminateJobResultsExample
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
            var bulkJobId = bulkJobId_example;  // string | Bulk job id

            try
            { 
                // Get bulk terminate job results.
                BulkJobTerminateResultsResponse result = apiInstance.GetTaskmanagementWorkitemsBulkTerminateJobResults(bulkJobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorkitemsBulkTerminateJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **bulkJobId** | **string**| Bulk job id |  |

### Return type

[**BulkJobTerminateResultsResponse**](BulkJobTerminateResultsResponse)


## GetTaskmanagementWorkitemsQueryJob

> [**WorkitemQueryJobResponse**](WorkitemQueryJobResponse) GetTaskmanagementWorkitemsQueryJob (string jobId)


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

### Return type

[**WorkitemQueryJobResponse**](WorkitemQueryJobResponse)


## GetTaskmanagementWorkitemsQueryJobResults

> [**WorkitemPagedEntityListing**](WorkitemPagedEntityListing) GetTaskmanagementWorkitemsQueryJobResults (string jobId)


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

### Return type

[**WorkitemPagedEntityListing**](WorkitemPagedEntityListing)


## GetTaskmanagementWorkitemsSchema

> [**DataSchema**](DataSchema) GetTaskmanagementWorkitemsSchema (string schemaId)


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

### Return type

[**DataSchema**](DataSchema)


## GetTaskmanagementWorkitemsSchemaVersion

> [**DataSchema**](DataSchema) GetTaskmanagementWorkitemsSchemaVersion (string schemaId, string versionId)


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

### Return type

[**DataSchema**](DataSchema)


## GetTaskmanagementWorkitemsSchemaVersions

> [**DataSchema**](DataSchema) GetTaskmanagementWorkitemsSchemaVersions (string schemaId)


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

### Return type

[**DataSchema**](DataSchema)


## GetTaskmanagementWorkitemsSchemas

> [**DataSchemaListing**](DataSchemaListing) GetTaskmanagementWorkitemsSchemas ()


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

[**DataSchemaListing**](DataSchemaListing)


## GetTaskmanagementWorktype

> [**Worktype**](Worktype) GetTaskmanagementWorktype (string worktypeId, List<string> expands = null)


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
| **expands** | [**List<string>**](string)| Which fields, if any, to expand. | [optional] <br />**Values**: defaultQueue, defaultSkills, defaultLanguage, schema, flow, defaultScript |

### Return type

[**Worktype**](Worktype)


## GetTaskmanagementWorktypeFlowsDatebasedRule

> [**WorkitemDateBasedRule**](WorkitemDateBasedRule) GetTaskmanagementWorktypeFlowsDatebasedRule (string worktypeId, string ruleId)


Get a date based rule

Requires ANY permissions: 

* workitems:flowRuleDateBased:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorktypeFlowsDatebasedRuleExample
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
            var ruleId = ruleId_example;  // string | ruleId

            try
            { 
                // Get a date based rule
                WorkitemDateBasedRule result = apiInstance.GetTaskmanagementWorktypeFlowsDatebasedRule(worktypeId, ruleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorktypeFlowsDatebasedRule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **worktypeId** | **string**| Worktype id |  |
| **ruleId** | **string**| ruleId |  |

### Return type

[**WorkitemDateBasedRule**](WorkitemDateBasedRule)


## GetTaskmanagementWorktypeFlowsDatebasedRules

> [**WorkitemDateBasedRuleListing**](WorkitemDateBasedRuleListing) GetTaskmanagementWorktypeFlowsDatebasedRules (string worktypeId, string after = null, int? pageSize = null)


Get all date based rules for a worktype

Requires ANY permissions: 

* workitems:flowRuleDateBased:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorktypeFlowsDatebasedRulesExample
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

            try
            { 
                // Get all date based rules for a worktype
                WorkitemDateBasedRuleListing result = apiInstance.GetTaskmanagementWorktypeFlowsDatebasedRules(worktypeId, after, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorktypeFlowsDatebasedRules: " + e.Message );
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

### Return type

[**WorkitemDateBasedRuleListing**](WorkitemDateBasedRuleListing)


## GetTaskmanagementWorktypeFlowsOnattributechangeRule

> [**WorkitemOnAttributeChangeRule**](WorkitemOnAttributeChangeRule) GetTaskmanagementWorktypeFlowsOnattributechangeRule (string worktypeId, string ruleId)


Get an attribute change rule

Requires ANY permissions: 

* workitems:flowRuleOnAttributeChange:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorktypeFlowsOnattributechangeRuleExample
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
            var ruleId = ruleId_example;  // string | ruleId

            try
            { 
                // Get an attribute change rule
                WorkitemOnAttributeChangeRule result = apiInstance.GetTaskmanagementWorktypeFlowsOnattributechangeRule(worktypeId, ruleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorktypeFlowsOnattributechangeRule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **worktypeId** | **string**| Worktype id |  |
| **ruleId** | **string**| ruleId |  |

### Return type

[**WorkitemOnAttributeChangeRule**](WorkitemOnAttributeChangeRule)


## GetTaskmanagementWorktypeFlowsOnattributechangeRules

> [**WorkitemOnAttributeChangeRuleListing**](WorkitemOnAttributeChangeRuleListing) GetTaskmanagementWorktypeFlowsOnattributechangeRules (string worktypeId, string after = null, int? pageSize = null)


Get all attribute-change rules for a worktype

Requires ANY permissions: 

* workitems:flowRuleOnAttributeChange:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorktypeFlowsOnattributechangeRulesExample
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

            try
            { 
                // Get all attribute-change rules for a worktype
                WorkitemOnAttributeChangeRuleListing result = apiInstance.GetTaskmanagementWorktypeFlowsOnattributechangeRules(worktypeId, after, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorktypeFlowsOnattributechangeRules: " + e.Message );
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

### Return type

[**WorkitemOnAttributeChangeRuleListing**](WorkitemOnAttributeChangeRuleListing)


## GetTaskmanagementWorktypeFlowsOncreateRule

> [**WorkitemOnCreateRule**](WorkitemOnCreateRule) GetTaskmanagementWorktypeFlowsOncreateRule (string worktypeId, string ruleId)


Get an on-create rule

Requires ANY permissions: 

* workitems:flowRuleOnCreate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorktypeFlowsOncreateRuleExample
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
            var ruleId = ruleId_example;  // string | ruleId

            try
            { 
                // Get an on-create rule
                WorkitemOnCreateRule result = apiInstance.GetTaskmanagementWorktypeFlowsOncreateRule(worktypeId, ruleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorktypeFlowsOncreateRule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **worktypeId** | **string**| Worktype id |  |
| **ruleId** | **string**| ruleId |  |

### Return type

[**WorkitemOnCreateRule**](WorkitemOnCreateRule)


## GetTaskmanagementWorktypeFlowsOncreateRules

> [**WorkitemOnCreateRuleListing**](WorkitemOnCreateRuleListing) GetTaskmanagementWorktypeFlowsOncreateRules (string worktypeId, string after = null, int? pageSize = null)


Get all on-create rules for a worktype

Requires ANY permissions: 

* workitems:flowRuleOnCreate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTaskmanagementWorktypeFlowsOncreateRulesExample
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

            try
            { 
                // Get all on-create rules for a worktype
                WorkitemOnCreateRuleListing result = apiInstance.GetTaskmanagementWorktypeFlowsOncreateRules(worktypeId, after, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.GetTaskmanagementWorktypeFlowsOncreateRules: " + e.Message );
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

### Return type

[**WorkitemOnCreateRuleListing**](WorkitemOnCreateRuleListing)


## GetTaskmanagementWorktypeHistory

> [**WorktypeChangeListing**](WorktypeChangeListing) GetTaskmanagementWorktypeHistory (string worktypeId, string after = null, int? pageSize = null, string sortOrder = null, List<string> fields = null)


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
| **fields** | [**List<string>**](string)| Comma-separated list of fields. The response will contain only versions created as a result of changes to these fields. | [optional] <br />**Values**: name, serviceLevelTarget, defaultWorkbinId, defaultDueDurationSeconds, defaultExpirationSeconds, defaultPriority, defaultLanguageId, defaultSkillIds, defaultQueueId, assignmentEnabled, defaultStatusId, statuses |

### Return type

[**WorktypeChangeListing**](WorktypeChangeListing)


## GetTaskmanagementWorktypeStatus

> [**WorkitemStatus**](WorkitemStatus) GetTaskmanagementWorktypeStatus (string worktypeId, string statusId)


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

### Return type

[**WorkitemStatus**](WorkitemStatus)


## GetTaskmanagementWorktypeStatuses

> [**WorkitemStatusListing**](WorkitemStatusListing) GetTaskmanagementWorktypeStatuses (string worktypeId)


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

### Return type

[**WorkitemStatusListing**](WorkitemStatusListing)


## GetTaskmanagementWorktypeVersion

> [**WorktypeVersion**](WorktypeVersion) GetTaskmanagementWorktypeVersion (string worktypeId, int? entityVersion)


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

### Return type

[**WorktypeVersion**](WorktypeVersion)


## GetTaskmanagementWorktypeVersions

> [**WorktypeVersionListing**](WorktypeVersionListing) GetTaskmanagementWorktypeVersions (string worktypeId, string after = null, int? pageSize = null, string sortOrder = null)


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

### Return type

[**WorktypeVersionListing**](WorktypeVersionListing)


## PatchTaskmanagementWorkbin

> [**Workbin**](Workbin) PatchTaskmanagementWorkbin (string workbinId, WorkbinUpdate body)


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
| **body** | [**WorkbinUpdate**](WorkbinUpdate)| Json with attributes and their new values: {\&quot;description\&quot;:\&quot;new description\&quot;, \&quot;name\&quot;:\&quot;new name\&quot;}. |  |

### Return type

[**Workbin**](Workbin)


## PatchTaskmanagementWorkitem

> [**Workitem**](Workitem) PatchTaskmanagementWorkitem (string workitemId, WorkitemUpdate body)


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
| **body** | [**WorkitemUpdate**](WorkitemUpdate)| Workitem |  |

### Return type

[**Workitem**](Workitem)


## PatchTaskmanagementWorkitemAssignment

> void PatchTaskmanagementWorkitemAssignment (string workitemId, WorkitemManualAssign body)


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
| **body** | [**WorkitemManualAssign**](WorkitemManualAssign)| Targeted user |  |

### Return type

void (empty response body)


## PatchTaskmanagementWorkitemUserWrapups

> [**WorkitemWrapup**](WorkitemWrapup) PatchTaskmanagementWorkitemUserWrapups (string workitemId, string userId, WorkitemWrapupUpdate body)


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
| **body** | [**WorkitemWrapupUpdate**](WorkitemWrapupUpdate)| Request body to add/remove a wrapup code for a workitem |  |

### Return type

[**WorkitemWrapup**](WorkitemWrapup)


## PatchTaskmanagementWorkitemUsersMeWrapups

> [**WorkitemWrapup**](WorkitemWrapup) PatchTaskmanagementWorkitemUsersMeWrapups (string workitemId, WorkitemWrapupUpdate body)


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
| **body** | [**WorkitemWrapupUpdate**](WorkitemWrapupUpdate)| Request body to add/remove the wrapup code for workitem |  |

### Return type

[**WorkitemWrapup**](WorkitemWrapup)


## PatchTaskmanagementWorkitemsBulkAddJob

> [**BulkJob**](BulkJob) PatchTaskmanagementWorkitemsBulkAddJob (string bulkJobId, BulkJobUpdate body)


Update workitem bulk add job.

Requires ANY permissions: 

* workitems:bulkAddJob:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchTaskmanagementWorkitemsBulkAddJobExample
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
            var bulkJobId = bulkJobId_example;  // string | Bulk job id
            var body = new BulkJobUpdate(); // BulkJobUpdate | Bulk add job update request

            try
            { 
                // Update workitem bulk add job.
                BulkJob result = apiInstance.PatchTaskmanagementWorkitemsBulkAddJob(bulkJobId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.PatchTaskmanagementWorkitemsBulkAddJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **bulkJobId** | **string**| Bulk job id |  |
| **body** | [**BulkJobUpdate**](BulkJobUpdate)| Bulk add job update request |  |

### Return type

[**BulkJob**](BulkJob)


## PatchTaskmanagementWorkitemsBulkTerminateJob

> [**BulkJob**](BulkJob) PatchTaskmanagementWorkitemsBulkTerminateJob (string bulkJobId, BulkJobUpdate body)


Update workitem bulk terminate job.

Requires ALL permissions: 

* workitems:bulkTerminateJob:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchTaskmanagementWorkitemsBulkTerminateJobExample
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
            var bulkJobId = bulkJobId_example;  // string | Bulk job id
            var body = new BulkJobUpdate(); // BulkJobUpdate | Bulk job update request

            try
            { 
                // Update workitem bulk terminate job.
                BulkJob result = apiInstance.PatchTaskmanagementWorkitemsBulkTerminateJob(bulkJobId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.PatchTaskmanagementWorkitemsBulkTerminateJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **bulkJobId** | **string**| Bulk job id |  |
| **body** | [**BulkJobUpdate**](BulkJobUpdate)| Bulk job update request |  |

### Return type

[**BulkJob**](BulkJob)


## PatchTaskmanagementWorktype

> [**Worktype**](Worktype) PatchTaskmanagementWorktype (string worktypeId, WorktypeUpdate body)


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
| **body** | [**WorktypeUpdate**](WorktypeUpdate)| Worktype |  |

### Return type

[**Worktype**](Worktype)


## PatchTaskmanagementWorktypeFlowsDatebasedRule

> [**WorkitemDateBasedRule**](WorkitemDateBasedRule) PatchTaskmanagementWorktypeFlowsDatebasedRule (string worktypeId, string ruleId, WorkitemDateBasedRuleUpdate body)


Update the attributes of a date based rule

Requires ANY permissions: 

* workitems:flowRuleDateBased:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchTaskmanagementWorktypeFlowsDatebasedRuleExample
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
            var ruleId = ruleId_example;  // string | ruleId
            var body = new WorkitemDateBasedRuleUpdate(); // WorkitemDateBasedRuleUpdate | Rule

            try
            { 
                // Update the attributes of a date based rule
                WorkitemDateBasedRule result = apiInstance.PatchTaskmanagementWorktypeFlowsDatebasedRule(worktypeId, ruleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.PatchTaskmanagementWorktypeFlowsDatebasedRule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **worktypeId** | **string**| Worktype id |  |
| **ruleId** | **string**| ruleId |  |
| **body** | [**WorkitemDateBasedRuleUpdate**](WorkitemDateBasedRuleUpdate)| Rule |  |

### Return type

[**WorkitemDateBasedRule**](WorkitemDateBasedRule)


## PatchTaskmanagementWorktypeFlowsOnattributechangeRule

> [**WorkitemOnAttributeChangeRule**](WorkitemOnAttributeChangeRule) PatchTaskmanagementWorktypeFlowsOnattributechangeRule (string worktypeId, string ruleId, WorkitemOnAttributeChangeRuleUpdate body)


Update the attributes of a rule

Requires ANY permissions: 

* workitems:flowRuleOnAttributeChange:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchTaskmanagementWorktypeFlowsOnattributechangeRuleExample
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
            var ruleId = ruleId_example;  // string | ruleId
            var body = new WorkitemOnAttributeChangeRuleUpdate(); // WorkitemOnAttributeChangeRuleUpdate | Rule

            try
            { 
                // Update the attributes of a rule
                WorkitemOnAttributeChangeRule result = apiInstance.PatchTaskmanagementWorktypeFlowsOnattributechangeRule(worktypeId, ruleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.PatchTaskmanagementWorktypeFlowsOnattributechangeRule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **worktypeId** | **string**| Worktype id |  |
| **ruleId** | **string**| ruleId |  |
| **body** | [**WorkitemOnAttributeChangeRuleUpdate**](WorkitemOnAttributeChangeRuleUpdate)| Rule |  |

### Return type

[**WorkitemOnAttributeChangeRule**](WorkitemOnAttributeChangeRule)


## PatchTaskmanagementWorktypeFlowsOncreateRule

> [**WorkitemOnCreateRule**](WorkitemOnCreateRule) PatchTaskmanagementWorktypeFlowsOncreateRule (string worktypeId, string ruleId, WorkitemOnCreateRuleUpdate body)


Update the attributes of a rule

Requires ANY permissions: 

* workitems:flowRuleOnCreate:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchTaskmanagementWorktypeFlowsOncreateRuleExample
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
            var ruleId = ruleId_example;  // string | ruleId
            var body = new WorkitemOnCreateRuleUpdate(); // WorkitemOnCreateRuleUpdate | Rule

            try
            { 
                // Update the attributes of a rule
                WorkitemOnCreateRule result = apiInstance.PatchTaskmanagementWorktypeFlowsOncreateRule(worktypeId, ruleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.PatchTaskmanagementWorktypeFlowsOncreateRule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **worktypeId** | **string**| Worktype id |  |
| **ruleId** | **string**| ruleId |  |
| **body** | [**WorkitemOnCreateRuleUpdate**](WorkitemOnCreateRuleUpdate)| Rule |  |

### Return type

[**WorkitemOnCreateRule**](WorkitemOnCreateRule)


## PatchTaskmanagementWorktypeStatus

> [**WorkitemStatus**](WorkitemStatus) PatchTaskmanagementWorktypeStatus (string worktypeId, string statusId, WorkitemStatusUpdate body)


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
| **body** | [**WorkitemStatusUpdate**](WorkitemStatusUpdate)| Status |  |

### Return type

[**WorkitemStatus**](WorkitemStatus)


## PostTaskmanagementWorkbins

> [**Workbin**](Workbin) PostTaskmanagementWorkbins (WorkbinCreate body)


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
| **body** | [**WorkbinCreate**](WorkbinCreate)| Workbin |  |

### Return type

[**Workbin**](Workbin)


## PostTaskmanagementWorkbinsQuery

> [**WorkbinQueryEntityListing**](WorkbinQueryEntityListing) PostTaskmanagementWorkbinsQuery (WorkbinQueryRequest body)


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
| **body** | [**WorkbinQueryRequest**](WorkbinQueryRequest)| QueryPostRequest |  |

### Return type

[**WorkbinQueryEntityListing**](WorkbinQueryEntityListing)


## PostTaskmanagementWorkitemAcdCancel

> [**Workitem**](Workitem) PostTaskmanagementWorkitemAcdCancel (string workitemId)


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

### Return type

[**Workitem**](Workitem)


## PostTaskmanagementWorkitemDisconnect

> [**Workitem**](Workitem) PostTaskmanagementWorkitemDisconnect (string workitemId)


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

### Return type

[**Workitem**](Workitem)


## PostTaskmanagementWorkitemTerminate

> [**Workitem**](Workitem) PostTaskmanagementWorkitemTerminate (string workitemId, WorkitemTerminate body = null)


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
| **body** | [**WorkitemTerminate**](WorkitemTerminate)| Terminated request | [optional]  |

### Return type

[**Workitem**](Workitem)


## PostTaskmanagementWorkitems

> [**Workitem**](Workitem) PostTaskmanagementWorkitems (WorkitemCreate body)


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
| **body** | [**WorkitemCreate**](WorkitemCreate)| Workitem |  |

### Return type

[**Workitem**](Workitem)


## PostTaskmanagementWorkitemsBulkAddJobs

> [**BulkJob**](BulkJob) PostTaskmanagementWorkitemsBulkAddJobs (BulkJobAddRequest body)


Create a workitem bulk add job.

Requires ANY permissions: 

* workitems:bulkAddJob:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTaskmanagementWorkitemsBulkAddJobsExample
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
            var body = new BulkJobAddRequest(); // BulkJobAddRequest | Bulk job definition.

            try
            { 
                // Create a workitem bulk add job.
                BulkJob result = apiInstance.PostTaskmanagementWorkitemsBulkAddJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.PostTaskmanagementWorkitemsBulkAddJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**BulkJobAddRequest**](BulkJobAddRequest)| Bulk job definition. |  |

### Return type

[**BulkJob**](BulkJob)


## PostTaskmanagementWorkitemsBulkTerminateJobs

> [**BulkJob**](BulkJob) PostTaskmanagementWorkitemsBulkTerminateJobs (BulkJobTerminateRequest body)


Create a workitem bulk terminate job.

Requires ALL permissions: 

* workitems:bulkTerminateJob:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTaskmanagementWorkitemsBulkTerminateJobsExample
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
            var body = new BulkJobTerminateRequest(); // BulkJobTerminateRequest | Bulk job definition.

            try
            { 
                // Create a workitem bulk terminate job.
                BulkJob result = apiInstance.PostTaskmanagementWorkitemsBulkTerminateJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.PostTaskmanagementWorkitemsBulkTerminateJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**BulkJobTerminateRequest**](BulkJobTerminateRequest)| Bulk job definition. |  |

### Return type

[**BulkJob**](BulkJob)


## PostTaskmanagementWorkitemsQuery

> [**WorkitemPostQueryEntityListing**](WorkitemPostQueryEntityListing) PostTaskmanagementWorkitemsQuery (WorkitemQueryPostRequest body)


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
| **body** | [**WorkitemQueryPostRequest**](WorkitemQueryPostRequest)| WorkitemQueryPostRequest |  |

### Return type

[**WorkitemPostQueryEntityListing**](WorkitemPostQueryEntityListing)


## PostTaskmanagementWorkitemsQueryJobs

> [**WorkitemQueryJobResponse**](WorkitemQueryJobResponse) PostTaskmanagementWorkitemsQueryJobs (WorkitemQueryJobCreate body)


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
| **body** | [**WorkitemQueryJobCreate**](WorkitemQueryJobCreate)| WorkitemQueryJobCreate |  |

### Return type

[**WorkitemQueryJobResponse**](WorkitemQueryJobResponse)


## PostTaskmanagementWorkitemsSchemas

> [**DataSchema**](DataSchema) PostTaskmanagementWorkitemsSchemas (DataSchema body)


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
| **body** | [**DataSchema**](DataSchema)| Schema |  |

### Return type

[**DataSchema**](DataSchema)


## PostTaskmanagementWorktypeFlowsDatebasedRules

> [**WorkitemDateBasedRule**](WorkitemDateBasedRule) PostTaskmanagementWorktypeFlowsDatebasedRules (string worktypeId, WorkitemDateBasedRuleCreate body)


Add a date based rule to a worktype

Requires ANY permissions: 

* workitems:flowRuleDateBased:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTaskmanagementWorktypeFlowsDatebasedRulesExample
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
            var body = new WorkitemDateBasedRuleCreate(); // WorkitemDateBasedRuleCreate | Rule

            try
            { 
                // Add a date based rule to a worktype
                WorkitemDateBasedRule result = apiInstance.PostTaskmanagementWorktypeFlowsDatebasedRules(worktypeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.PostTaskmanagementWorktypeFlowsDatebasedRules: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **worktypeId** | **string**| Worktype id |  |
| **body** | [**WorkitemDateBasedRuleCreate**](WorkitemDateBasedRuleCreate)| Rule |  |

### Return type

[**WorkitemDateBasedRule**](WorkitemDateBasedRule)


## PostTaskmanagementWorktypeFlowsOnattributechangeRules

> [**WorkitemOnAttributeChangeRule**](WorkitemOnAttributeChangeRule) PostTaskmanagementWorktypeFlowsOnattributechangeRules (string worktypeId, WorkitemOnAttributeChangeRuleCreate body)


Add an attribute-change rule to a worktype

Requires ANY permissions: 

* workitems:flowRuleOnAttributeChange:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTaskmanagementWorktypeFlowsOnattributechangeRulesExample
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
            var body = new WorkitemOnAttributeChangeRuleCreate(); // WorkitemOnAttributeChangeRuleCreate | Rule

            try
            { 
                // Add an attribute-change rule to a worktype
                WorkitemOnAttributeChangeRule result = apiInstance.PostTaskmanagementWorktypeFlowsOnattributechangeRules(worktypeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.PostTaskmanagementWorktypeFlowsOnattributechangeRules: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **worktypeId** | **string**| Worktype id |  |
| **body** | [**WorkitemOnAttributeChangeRuleCreate**](WorkitemOnAttributeChangeRuleCreate)| Rule |  |

### Return type

[**WorkitemOnAttributeChangeRule**](WorkitemOnAttributeChangeRule)


## PostTaskmanagementWorktypeFlowsOncreateRules

> [**WorkitemOnCreateRule**](WorkitemOnCreateRule) PostTaskmanagementWorktypeFlowsOncreateRules (string worktypeId, WorkitemOnCreateRuleCreate body)


Add an on-create rule to a worktype

Requires ANY permissions: 

* workitems:flowRuleOnCreate:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostTaskmanagementWorktypeFlowsOncreateRulesExample
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
            var body = new WorkitemOnCreateRuleCreate(); // WorkitemOnCreateRuleCreate | Rule

            try
            { 
                // Add an on-create rule to a worktype
                WorkitemOnCreateRule result = apiInstance.PostTaskmanagementWorktypeFlowsOncreateRules(worktypeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskManagementApi.PostTaskmanagementWorktypeFlowsOncreateRules: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **worktypeId** | **string**| Worktype id |  |
| **body** | [**WorkitemOnCreateRuleCreate**](WorkitemOnCreateRuleCreate)| Rule |  |

### Return type

[**WorkitemOnCreateRule**](WorkitemOnCreateRule)


## PostTaskmanagementWorktypeStatuses

> [**WorkitemStatus**](WorkitemStatus) PostTaskmanagementWorktypeStatuses (string worktypeId, WorkitemStatusCreate body)


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
| **body** | [**WorkitemStatusCreate**](WorkitemStatusCreate)| Status |  |

### Return type

[**WorkitemStatus**](WorkitemStatus)


## PostTaskmanagementWorktypes

> [**Worktype**](Worktype) PostTaskmanagementWorktypes (WorktypeCreate body)


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
| **body** | [**WorktypeCreate**](WorktypeCreate)| Worktype |  |

### Return type

[**Worktype**](Worktype)


## PostTaskmanagementWorktypesQuery

> [**WorktypeQueryEntityListing**](WorktypeQueryEntityListing) PostTaskmanagementWorktypesQuery (WorktypeQueryRequest body)


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
| **body** | [**WorktypeQueryRequest**](WorktypeQueryRequest)| QueryPostRequest |  |

### Return type

[**WorktypeQueryEntityListing**](WorktypeQueryEntityListing)


## PutTaskmanagementWorkitemsSchema

> [**DataSchema**](DataSchema) PutTaskmanagementWorkitemsSchema (string schemaId, DataSchema body)


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
| **body** | [**DataSchema**](DataSchema)| Data Schema |  |

### Return type

[**DataSchema**](DataSchema)


_PureCloudPlatform.Client.V2 226.0.0_
