---
title: ArchitectApi
---
## PureCloudPlatform.Client.V2.Api.ArchitectApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteArchitectIvr**](ArchitectApi.html#deletearchitectivr) | **DELETE** /api/v2/architect/ivrs/{ivrId} | Delete an IVR Config. |
| [**DeleteArchitectPrompt**](ArchitectApi.html#deletearchitectprompt) | **DELETE** /api/v2/architect/prompts/{promptId} | Delete specified user prompt |
| [**DeleteArchitectPromptResource**](ArchitectApi.html#deletearchitectpromptresource) | **DELETE** /api/v2/architect/prompts/{promptId}/resources/{languageCode} | Delete specified user prompt resource |
| [**DeleteArchitectPrompts**](ArchitectApi.html#deletearchitectprompts) | **DELETE** /api/v2/architect/prompts | Batch-delete a list of prompts |
| [**DeleteArchitectSchedule**](ArchitectApi.html#deletearchitectschedule) | **DELETE** /api/v2/architect/schedules/{scheduleId} | Delete a schedule by id |
| [**DeleteArchitectSchedulegroup**](ArchitectApi.html#deletearchitectschedulegroup) | **DELETE** /api/v2/architect/schedulegroups/{scheduleGroupId} | Deletes a schedule group by ID |
| [**DeleteArchitectSystempromptResource**](ArchitectApi.html#deletearchitectsystempromptresource) | **DELETE** /api/v2/architect/systemprompts/{promptId}/resources/{languageCode} | Delete a system prompt resource override. |
| [**DeleteFlow**](ArchitectApi.html#deleteflow) | **DELETE** /api/v2/flows/{flowId} | Delete flow |
| [**DeleteFlows**](ArchitectApi.html#deleteflows) | **DELETE** /api/v2/flows | Batch-delete a list of flows |
| [**GetArchitectDependencytracking**](ArchitectApi.html#getarchitectdependencytracking) | **GET** /api/v2/architect/dependencytracking | Get Dependency Tracking objects that have a given display name |
| [**GetArchitectDependencytrackingBuild**](ArchitectApi.html#getarchitectdependencytrackingbuild) | **GET** /api/v2/architect/dependencytracking/build | Get Dependency Tracking build status for an organization |
| [**GetArchitectDependencytrackingConsumedresources**](ArchitectApi.html#getarchitectdependencytrackingconsumedresources) | **GET** /api/v2/architect/dependencytracking/consumedresources | Get resources that are consumed by a given Dependency Tracking object |
| [**GetArchitectDependencytrackingConsumingresources**](ArchitectApi.html#getarchitectdependencytrackingconsumingresources) | **GET** /api/v2/architect/dependencytracking/consumingresources | Get resources that consume a given Dependency Tracking object |
| [**GetArchitectDependencytrackingDeletedresourceconsumers**](ArchitectApi.html#getarchitectdependencytrackingdeletedresourceconsumers) | **GET** /api/v2/architect/dependencytracking/deletedresourceconsumers | Get Dependency Tracking objects that consume deleted resources |
| [**GetArchitectDependencytrackingObject**](ArchitectApi.html#getarchitectdependencytrackingobject) | **GET** /api/v2/architect/dependencytracking/object | Get a Dependency Tracking object |
| [**GetArchitectDependencytrackingType**](ArchitectApi.html#getarchitectdependencytrackingtype) | **GET** /api/v2/architect/dependencytracking/types/{typeId} | Get a Dependency Tracking type. |
| [**GetArchitectDependencytrackingTypes**](ArchitectApi.html#getarchitectdependencytrackingtypes) | **GET** /api/v2/architect/dependencytracking/types | Get Dependency Tracking types. |
| [**GetArchitectDependencytrackingUpdatedresourceconsumers**](ArchitectApi.html#getarchitectdependencytrackingupdatedresourceconsumers) | **GET** /api/v2/architect/dependencytracking/updatedresourceconsumers | Get Dependency Tracking objects that depend on updated resources |
| [**GetArchitectIvr**](ArchitectApi.html#getarchitectivr) | **GET** /api/v2/architect/ivrs/{ivrId} | Get an IVR config. |
| [**GetArchitectIvrs**](ArchitectApi.html#getarchitectivrs) | **GET** /api/v2/architect/ivrs | Get IVR configs. |
| [**GetArchitectPrompt**](ArchitectApi.html#getarchitectprompt) | **GET** /api/v2/architect/prompts/{promptId} | Get specified user prompt |
| [**GetArchitectPromptResource**](ArchitectApi.html#getarchitectpromptresource) | **GET** /api/v2/architect/prompts/{promptId}/resources/{languageCode} | Get specified user prompt resource |
| [**GetArchitectPromptResources**](ArchitectApi.html#getarchitectpromptresources) | **GET** /api/v2/architect/prompts/{promptId}/resources | Get a pageable list of user prompt resources |
| [**GetArchitectPrompts**](ArchitectApi.html#getarchitectprompts) | **GET** /api/v2/architect/prompts | Get a pageable list of user prompts |
| [**GetArchitectSchedule**](ArchitectApi.html#getarchitectschedule) | **GET** /api/v2/architect/schedules/{scheduleId} | Get a schedule by ID |
| [**GetArchitectSchedulegroup**](ArchitectApi.html#getarchitectschedulegroup) | **GET** /api/v2/architect/schedulegroups/{scheduleGroupId} | Gets a schedule group by ID |
| [**GetArchitectSchedulegroups**](ArchitectApi.html#getarchitectschedulegroups) | **GET** /api/v2/architect/schedulegroups | Get a list of schedule groups. |
| [**GetArchitectSchedules**](ArchitectApi.html#getarchitectschedules) | **GET** /api/v2/architect/schedules | Get a list of schedules. |
| [**GetArchitectSystemprompt**](ArchitectApi.html#getarchitectsystemprompt) | **GET** /api/v2/architect/systemprompts/{promptId} | Get a system prompt |
| [**GetArchitectSystempromptResource**](ArchitectApi.html#getarchitectsystempromptresource) | **GET** /api/v2/architect/systemprompts/{promptId}/resources/{languageCode} | Get a system prompt resource. |
| [**GetArchitectSystempromptResources**](ArchitectApi.html#getarchitectsystempromptresources) | **GET** /api/v2/architect/systemprompts/{promptId}/resources | Get system prompt resources. |
| [**GetArchitectSystemprompts**](ArchitectApi.html#getarchitectsystemprompts) | **GET** /api/v2/architect/systemprompts | Get System Prompts |
| [**GetFlow**](ArchitectApi.html#getflow) | **GET** /api/v2/flows/{flowId} | Get flow |
| [**GetFlowHistoryHistoryId**](ArchitectApi.html#getflowhistoryhistoryid) | **GET** /api/v2/flows/{flowId}/history/{historyId} | Get generated flow history |
| [**GetFlowLatestconfiguration**](ArchitectApi.html#getflowlatestconfiguration) | **GET** /api/v2/flows/{flowId}/latestconfiguration | Get the latest configuration for flow |
| [**GetFlowVersion**](ArchitectApi.html#getflowversion) | **GET** /api/v2/flows/{flowId}/versions/{versionId} | Get flow version |
| [**GetFlowVersionConfiguration**](ArchitectApi.html#getflowversionconfiguration) | **GET** /api/v2/flows/{flowId}/versions/{versionId}/configuration | Create flow version configuration |
| [**GetFlowVersions**](ArchitectApi.html#getflowversions) | **GET** /api/v2/flows/{flowId}/versions | Get flow version list |
| [**GetFlows**](ArchitectApi.html#getflows) | **GET** /api/v2/flows | Get a pageable list of flows, filtered by query parameters |
| [**PostArchitectDependencytrackingBuild**](ArchitectApi.html#postarchitectdependencytrackingbuild) | **POST** /api/v2/architect/dependencytracking/build | Rebuild Dependency Tracking data for an organization |
| [**PostArchitectIvrs**](ArchitectApi.html#postarchitectivrs) | **POST** /api/v2/architect/ivrs | Create IVR config. |
| [**PostArchitectPromptResources**](ArchitectApi.html#postarchitectpromptresources) | **POST** /api/v2/architect/prompts/{promptId}/resources | Create a new user prompt resource |
| [**PostArchitectPrompts**](ArchitectApi.html#postarchitectprompts) | **POST** /api/v2/architect/prompts | Create a new user prompt |
| [**PostArchitectSchedulegroups**](ArchitectApi.html#postarchitectschedulegroups) | **POST** /api/v2/architect/schedulegroups | Creates a new schedule group |
| [**PostArchitectSchedules**](ArchitectApi.html#postarchitectschedules) | **POST** /api/v2/architect/schedules | Create a new schedule. |
| [**PostArchitectSystempromptResources**](ArchitectApi.html#postarchitectsystempromptresources) | **POST** /api/v2/architect/systemprompts/{promptId}/resources | Create system prompt resource override. |
| [**PostFlowVersions**](ArchitectApi.html#postflowversions) | **POST** /api/v2/flows/{flowId}/versions | Create flow version |
| [**PostFlows**](ArchitectApi.html#postflows) | **POST** /api/v2/flows | Create flow |
| [**PostFlowsActionsCheckin**](ArchitectApi.html#postflowsactionscheckin) | **POST** /api/v2/flows/actions/checkin | Check-in flow |
| [**PostFlowsActionsCheckout**](ArchitectApi.html#postflowsactionscheckout) | **POST** /api/v2/flows/actions/checkout | Check-out flow |
| [**PostFlowsActionsDeactivate**](ArchitectApi.html#postflowsactionsdeactivate) | **POST** /api/v2/flows/actions/deactivate | Deactivate flow |
| [**PostFlowsActionsPublish**](ArchitectApi.html#postflowsactionspublish) | **POST** /api/v2/flows/actions/publish | Publish flow |
| [**PostFlowsActionsRevert**](ArchitectApi.html#postflowsactionsrevert) | **POST** /api/v2/flows/actions/revert | Revert flow |
| [**PostFlowsActionsUnlock**](ArchitectApi.html#postflowsactionsunlock) | **POST** /api/v2/flows/actions/unlock | Unlock flow |
| [**PutArchitectIvr**](ArchitectApi.html#putarchitectivr) | **PUT** /api/v2/architect/ivrs/{ivrId} | Update an IVR Config. |
| [**PutArchitectPrompt**](ArchitectApi.html#putarchitectprompt) | **PUT** /api/v2/architect/prompts/{promptId} | Update specified user prompt |
| [**PutArchitectPromptResource**](ArchitectApi.html#putarchitectpromptresource) | **PUT** /api/v2/architect/prompts/{promptId}/resources/{languageCode} | Update specified user prompt resource |
| [**PutArchitectSchedule**](ArchitectApi.html#putarchitectschedule) | **PUT** /api/v2/architect/schedules/{scheduleId} | Update schedule by ID |
| [**PutArchitectSchedulegroup**](ArchitectApi.html#putarchitectschedulegroup) | **PUT** /api/v2/architect/schedulegroups/{scheduleGroupId} | Updates a schedule group by ID |
| [**PutArchitectSystempromptResource**](ArchitectApi.html#putarchitectsystempromptresource) | **PUT** /api/v2/architect/systemprompts/{promptId}/resources/{languageCode} | Updates a system prompt resource override. |
| [**PutFlow**](ArchitectApi.html#putflow) | **PUT** /api/v2/flows/{flowId} | Update flow |
{: class="table table-striped"}

<a name="deletearchitectivr"></a>

## void DeleteArchitectIvr (string ivrId)

Delete an IVR Config.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteArchitectIvrExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var ivrId = ivrId_example;  // string | IVR id
            
            
            

            try
            {
                
                // Delete an IVR Config.
                
                apiInstance.DeleteArchitectIvr(ivrId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteArchitectIvr: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ivrId** | **string**| IVR id |  |
{: class="table table-striped"}

### Return type

void (empty response body)

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

Batch-delete a list of prompts

Multiple IDs can be specified, in which case all specified prompts will be deleted.  Asynchronous.  Notification topic: v2.architect.prompts.{promptId}

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
                
                // Batch-delete a list of prompts
                
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

<a name="deletearchitectschedule"></a>

## void DeleteArchitectSchedule (string scheduleId)

Delete a schedule by id



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteArchitectScheduleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var scheduleId = scheduleId_example;  // string | Schedule ID
            
            
            

            try
            {
                
                // Delete a schedule by id
                
                apiInstance.DeleteArchitectSchedule(scheduleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteArchitectSchedule: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleId** | **string**| Schedule ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletearchitectschedulegroup"></a>

## void DeleteArchitectSchedulegroup (string scheduleGroupId)

Deletes a schedule group by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteArchitectSchedulegroupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var scheduleGroupId = scheduleGroupId_example;  // string | Schedule group ID
            
            
            

            try
            {
                
                // Deletes a schedule group by ID
                
                apiInstance.DeleteArchitectSchedulegroup(scheduleGroupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteArchitectSchedulegroup: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleGroupId** | **string**| Schedule group ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletearchitectsystempromptresource"></a>

## void DeleteArchitectSystempromptResource (string promptId, string languageCode)

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
                
                apiInstance.DeleteArchitectSystempromptResource(promptId, languageCode);
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

void (empty response body)

<a name="deleteflow"></a>

## void DeleteFlow (string flowId)

Delete flow



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteFlowExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var flowId = flowId_example;  // string | Flow ID
            
            
            

            try
            {
                
                // Delete flow
                
                apiInstance.DeleteFlow(flowId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteFlow: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowId** | **string**| Flow ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteflows"></a>

## [**Operation**](Operation.html) DeleteFlows (List<string> id)

Batch-delete a list of flows

Multiple IDs can be specified, in which case all specified flows will be deleted.  Asynchronous.  Notification topic: v2.flows.{flowId}

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteFlowsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            
            var id = new List<string>(); // List<string> | List of Flow IDs
            
            

            try
            {
                
                // Batch-delete a list of flows
                
                Operation result = apiInstance.DeleteFlows(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteFlows: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | [**List<string>**](string.html)| List of Flow IDs |  |
{: class="table table-striped"}

### Return type

[**Operation**](Operation.html)

<a name="getarchitectdependencytracking"></a>

## [**DependencyObjectEntityListing**](DependencyObjectEntityListing.html) GetArchitectDependencytracking (string name, int? pageNumber = null, int? pageSize = null, List<string> objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null)

Get Dependency Tracking objects that have a given display name



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectDependencytrackingExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var name = name_example;  // string | Object name to search for
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            
            var objectType = new List<string>(); // List<string> | Object type(s) to search for (optional) 
            
            
            
            var consumedResources = true;  // bool? | Include resources each result item consumes (optional) 
            
            
            
            
            var consumingResources = true;  // bool? | Include resources that consume each result item (optional) 
            
            
            
            
            
            var consumedResourceType = new List<string>(); // List<string> | Types of consumed resources to return, if consumed resources are requested (optional) 
            
            
            
            
            var consumingResourceType = new List<string>(); // List<string> | Types of consuming resources to return, if consuming resources are requested (optional) 
            
            

            try
            {
                
                // Get Dependency Tracking objects that have a given display name
                
                DependencyObjectEntityListing result = apiInstance.GetArchitectDependencytracking(name, pageNumber, pageSize, objectType, consumedResources, consumingResources, consumedResourceType, consumingResourceType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectDependencytracking: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **name** | **string**| Object name to search for |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **objectType** | [**List<string>**](string.html)| Object type(s) to search for | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, BRIDGEACTION, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, EMAILROUTE, GROUP, INBOUNDCALLFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, IVRCONFIGURATION, LANGUAGE, OUTBOUNDCALLFLOW, QUEUE, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SURVEYINVITEFLOW, SYSTEMPROMPT, USER, USERPROMPT, VOICEXML, WORKFLOW |
| **consumedResources** | **bool?**| Include resources each result item consumes | [optional]  |
| **consumingResources** | **bool?**| Include resources that consume each result item | [optional]  |
| **consumedResourceType** | [**List<string>**](string.html)| Types of consumed resources to return, if consumed resources are requested | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, BRIDGEACTION, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, EMAILROUTE, GROUP, INBOUNDCALLFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, IVRCONFIGURATION, LANGUAGE, OUTBOUNDCALLFLOW, QUEUE, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SURVEYINVITEFLOW, SYSTEMPROMPT, USER, USERPROMPT, VOICEXML, WORKFLOW |
| **consumingResourceType** | [**List<string>**](string.html)| Types of consuming resources to return, if consuming resources are requested | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, BRIDGEACTION, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, EMAILROUTE, GROUP, INBOUNDCALLFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, IVRCONFIGURATION, LANGUAGE, OUTBOUNDCALLFLOW, QUEUE, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SURVEYINVITEFLOW, SYSTEMPROMPT, USER, USERPROMPT, VOICEXML, WORKFLOW |
{: class="table table-striped"}

### Return type

[**DependencyObjectEntityListing**](DependencyObjectEntityListing.html)

<a name="getarchitectdependencytrackingbuild"></a>

## [**DependencyStatus**](DependencyStatus.html) GetArchitectDependencytrackingBuild ()

Get Dependency Tracking build status for an organization



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectDependencytrackingBuildExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            

            try
            {
                
                // Get Dependency Tracking build status for an organization
                
                DependencyStatus result = apiInstance.GetArchitectDependencytrackingBuild();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectDependencytrackingBuild: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**DependencyStatus**](DependencyStatus.html)

<a name="getarchitectdependencytrackingconsumedresources"></a>

## [**ConsumedResourcesEntityListing**](ConsumedResourcesEntityListing.html) GetArchitectDependencytrackingConsumedresources (string id, string version, string objectType, List<string> resourceType = null)

Get resources that are consumed by a given Dependency Tracking object



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectDependencytrackingConsumedresourcesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var id = id_example;  // string | Consuming object ID
            
            
            
            
            var version = version_example;  // string | Consuming object version
            
            
            
            
            var objectType = objectType_example;  // string | Consuming object type.  Only versioned types are allowed here.
            
            
            
            
            
            var resourceType = new List<string>(); // List<string> | Types of consumed resources to show (optional) 
            
            

            try
            {
                
                // Get resources that are consumed by a given Dependency Tracking object
                
                ConsumedResourcesEntityListing result = apiInstance.GetArchitectDependencytrackingConsumedresources(id, version, objectType, resourceType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectDependencytrackingConsumedresources: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | **string**| Consuming object ID |  |
| **version** | **string**| Consuming object version |  |
| **objectType** | **string**| Consuming object type.  Only versioned types are allowed here. | <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, BRIDGEACTION, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, EMAILROUTE, GROUP, INBOUNDCALLFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, IVRCONFIGURATION, LANGUAGE, OUTBOUNDCALLFLOW, QUEUE, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SURVEYINVITEFLOW, SYSTEMPROMPT, USER, USERPROMPT, VOICEXML, WORKFLOW |
| **resourceType** | [**List<string>**](string.html)| Types of consumed resources to show | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, BRIDGEACTION, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, EMAILROUTE, GROUP, INBOUNDCALLFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, IVRCONFIGURATION, LANGUAGE, OUTBOUNDCALLFLOW, QUEUE, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SURVEYINVITEFLOW, SYSTEMPROMPT, USER, USERPROMPT, VOICEXML, WORKFLOW |
{: class="table table-striped"}

### Return type

[**ConsumedResourcesEntityListing**](ConsumedResourcesEntityListing.html)

<a name="getarchitectdependencytrackingconsumingresources"></a>

## [**ConsumingResourcesEntityListing**](ConsumingResourcesEntityListing.html) GetArchitectDependencytrackingConsumingresources (string id, string objectType, List<string> resourceType = null)

Get resources that consume a given Dependency Tracking object



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectDependencytrackingConsumingresourcesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var id = id_example;  // string | Consumed object ID
            
            
            
            
            var objectType = objectType_example;  // string | Consumed object type
            
            
            
            
            
            var resourceType = new List<string>(); // List<string> | Types of consuming resources to show.  Only versioned types are allowed here. (optional) 
            
            

            try
            {
                
                // Get resources that consume a given Dependency Tracking object
                
                ConsumingResourcesEntityListing result = apiInstance.GetArchitectDependencytrackingConsumingresources(id, objectType, resourceType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectDependencytrackingConsumingresources: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | **string**| Consumed object ID |  |
| **objectType** | **string**| Consumed object type | <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, BRIDGEACTION, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, EMAILROUTE, GROUP, INBOUNDCALLFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, IVRCONFIGURATION, LANGUAGE, OUTBOUNDCALLFLOW, QUEUE, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SURVEYINVITEFLOW, SYSTEMPROMPT, USER, USERPROMPT, VOICEXML, WORKFLOW |
| **resourceType** | [**List<string>**](string.html)| Types of consuming resources to show.  Only versioned types are allowed here. | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, BRIDGEACTION, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, EMAILROUTE, GROUP, INBOUNDCALLFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, IVRCONFIGURATION, LANGUAGE, OUTBOUNDCALLFLOW, QUEUE, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SURVEYINVITEFLOW, SYSTEMPROMPT, USER, USERPROMPT, VOICEXML, WORKFLOW |
{: class="table table-striped"}

### Return type

[**ConsumingResourcesEntityListing**](ConsumingResourcesEntityListing.html)

<a name="getarchitectdependencytrackingdeletedresourceconsumers"></a>

## [**DependencyObjectEntityListing**](DependencyObjectEntityListing.html) GetArchitectDependencytrackingDeletedresourceconsumers (string name = null, List<string> objectType = null, string flowFilter = null, bool? consumedResources = null, List<string> consumedResourceType = null, int? pageNumber = null, int? pageSize = null)

Get Dependency Tracking objects that consume deleted resources



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectDependencytrackingDeletedresourceconsumersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var name = name_example;  // string | Name to search for (optional) 
            
            
            
            
            
            var objectType = new List<string>(); // List<string> | Object type(s) to search for (optional) 
            
            
            
            var flowFilter = flowFilter_example;  // string | Show only checkedIn or published flows (optional) 
            
            
            
            
            var consumedResources = true;  // bool? | Return consumed resources? (optional)  (default to false)
            
            
            
            
            
            var consumedResourceType = new List<string>(); // List<string> | Resource type(s) to return (optional) 
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            

            try
            {
                
                // Get Dependency Tracking objects that consume deleted resources
                
                DependencyObjectEntityListing result = apiInstance.GetArchitectDependencytrackingDeletedresourceconsumers(name, objectType, flowFilter, consumedResources, consumedResourceType, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectDependencytrackingDeletedresourceconsumers: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **name** | **string**| Name to search for | [optional]  |
| **objectType** | [**List<string>**](string.html)| Object type(s) to search for | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, BRIDGEACTION, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, EMAILROUTE, GROUP, INBOUNDCALLFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, IVRCONFIGURATION, LANGUAGE, OUTBOUNDCALLFLOW, QUEUE, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SURVEYINVITEFLOW, SYSTEMPROMPT, USER, USERPROMPT, VOICEXML, WORKFLOW |
| **flowFilter** | **string**| Show only checkedIn or published flows | [optional] <br />**Values**: checkedIn, published |
| **consumedResources** | **bool?**| Return consumed resources? | [optional] [default to false] |
| **consumedResourceType** | [**List<string>**](string.html)| Resource type(s) to return | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, BRIDGEACTION, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, EMAILROUTE, GROUP, INBOUNDCALLFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, IVRCONFIGURATION, LANGUAGE, OUTBOUNDCALLFLOW, QUEUE, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SURVEYINVITEFLOW, SYSTEMPROMPT, USER, USERPROMPT, VOICEXML, WORKFLOW |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
{: class="table table-striped"}

### Return type

[**DependencyObjectEntityListing**](DependencyObjectEntityListing.html)

<a name="getarchitectdependencytrackingobject"></a>

## [**DependencyObject**](DependencyObject.html) GetArchitectDependencytrackingObject (string id, string version = null, string objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null)

Get a Dependency Tracking object



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectDependencytrackingObjectExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var id = id_example;  // string | Object ID
            
            
            
            
            var version = version_example;  // string | Object version (optional) 
            
            
            
            
            var objectType = objectType_example;  // string | Object type (optional) 
            
            
            
            
            var consumedResources = true;  // bool? | Include resources this item consumes (optional) 
            
            
            
            
            var consumingResources = true;  // bool? | Include resources that consume this item (optional) 
            
            
            
            
            
            var consumedResourceType = new List<string>(); // List<string> | Types of consumed resources to return, if consumed resources are requested (optional) 
            
            
            
            
            var consumingResourceType = new List<string>(); // List<string> | Types of consuming resources to return, if consuming resources are requested (optional) 
            
            

            try
            {
                
                // Get a Dependency Tracking object
                
                DependencyObject result = apiInstance.GetArchitectDependencytrackingObject(id, version, objectType, consumedResources, consumingResources, consumedResourceType, consumingResourceType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectDependencytrackingObject: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | **string**| Object ID |  |
| **version** | **string**| Object version | [optional]  |
| **objectType** | **string**| Object type | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, BRIDGEACTION, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, EMAILROUTE, GROUP, INBOUNDCALLFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, IVRCONFIGURATION, LANGUAGE, OUTBOUNDCALLFLOW, QUEUE, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SURVEYINVITEFLOW, SYSTEMPROMPT, USER, USERPROMPT, VOICEXML, WORKFLOW |
| **consumedResources** | **bool?**| Include resources this item consumes | [optional]  |
| **consumingResources** | **bool?**| Include resources that consume this item | [optional]  |
| **consumedResourceType** | [**List<string>**](string.html)| Types of consumed resources to return, if consumed resources are requested | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, BRIDGEACTION, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, EMAILROUTE, GROUP, INBOUNDCALLFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, IVRCONFIGURATION, LANGUAGE, OUTBOUNDCALLFLOW, QUEUE, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SURVEYINVITEFLOW, SYSTEMPROMPT, USER, USERPROMPT, VOICEXML, WORKFLOW |
| **consumingResourceType** | [**List<string>**](string.html)| Types of consuming resources to return, if consuming resources are requested | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, BRIDGEACTION, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, EMAILROUTE, GROUP, INBOUNDCALLFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, IVRCONFIGURATION, LANGUAGE, OUTBOUNDCALLFLOW, QUEUE, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SURVEYINVITEFLOW, SYSTEMPROMPT, USER, USERPROMPT, VOICEXML, WORKFLOW |
{: class="table table-striped"}

### Return type

[**DependencyObject**](DependencyObject.html)

<a name="getarchitectdependencytrackingtype"></a>

## [**DependencyType**](DependencyType.html) GetArchitectDependencytrackingType (string typeId)

Get a Dependency Tracking type.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectDependencytrackingTypeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var typeId = typeId_example;  // string | Type ID
            
            
            

            try
            {
                
                // Get a Dependency Tracking type.
                
                DependencyType result = apiInstance.GetArchitectDependencytrackingType(typeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectDependencytrackingType: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **typeId** | **string**| Type ID |  |
{: class="table table-striped"}

### Return type

[**DependencyType**](DependencyType.html)

<a name="getarchitectdependencytrackingtypes"></a>

## [**DependencyTypeEntityListing**](DependencyTypeEntityListing.html) GetArchitectDependencytrackingTypes (int? pageNumber = null, int? pageSize = null)

Get Dependency Tracking types.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectDependencytrackingTypesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            

            try
            {
                
                // Get Dependency Tracking types.
                
                DependencyTypeEntityListing result = apiInstance.GetArchitectDependencytrackingTypes(pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectDependencytrackingTypes: " + e.Message );
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
{: class="table table-striped"}

### Return type

[**DependencyTypeEntityListing**](DependencyTypeEntityListing.html)

<a name="getarchitectdependencytrackingupdatedresourceconsumers"></a>

## [**DependencyObjectEntityListing**](DependencyObjectEntityListing.html) GetArchitectDependencytrackingUpdatedresourceconsumers (string name = null, List<string> objectType = null, bool? consumedResources = null, List<string> consumedResourceType = null, int? pageNumber = null, int? pageSize = null)

Get Dependency Tracking objects that depend on updated resources



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectDependencytrackingUpdatedresourceconsumersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var name = name_example;  // string | Name to search for (optional) 
            
            
            
            
            
            var objectType = new List<string>(); // List<string> | Object type(s) to search for (optional) 
            
            
            
            var consumedResources = true;  // bool? | Return consumed resources? (optional)  (default to false)
            
            
            
            
            
            var consumedResourceType = new List<string>(); // List<string> | Resource type(s) to return (optional) 
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            

            try
            {
                
                // Get Dependency Tracking objects that depend on updated resources
                
                DependencyObjectEntityListing result = apiInstance.GetArchitectDependencytrackingUpdatedresourceconsumers(name, objectType, consumedResources, consumedResourceType, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectDependencytrackingUpdatedresourceconsumers: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **name** | **string**| Name to search for | [optional]  |
| **objectType** | [**List<string>**](string.html)| Object type(s) to search for | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, BRIDGEACTION, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, EMAILROUTE, GROUP, INBOUNDCALLFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, IVRCONFIGURATION, LANGUAGE, OUTBOUNDCALLFLOW, QUEUE, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SURVEYINVITEFLOW, SYSTEMPROMPT, USER, USERPROMPT, VOICEXML, WORKFLOW |
| **consumedResources** | **bool?**| Return consumed resources? | [optional] [default to false] |
| **consumedResourceType** | [**List<string>**](string.html)| Resource type(s) to return | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, BRIDGEACTION, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, EMAILROUTE, GROUP, INBOUNDCALLFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, IVRCONFIGURATION, LANGUAGE, OUTBOUNDCALLFLOW, QUEUE, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SURVEYINVITEFLOW, SYSTEMPROMPT, USER, USERPROMPT, VOICEXML, WORKFLOW |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
{: class="table table-striped"}

### Return type

[**DependencyObjectEntityListing**](DependencyObjectEntityListing.html)

<a name="getarchitectivr"></a>

## [**IVR**](IVR.html) GetArchitectIvr (string ivrId)

Get an IVR config.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectIvrExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var ivrId = ivrId_example;  // string | IVR id
            
            
            

            try
            {
                
                // Get an IVR config.
                
                IVR result = apiInstance.GetArchitectIvr(ivrId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectIvr: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ivrId** | **string**| IVR id |  |
{: class="table table-striped"}

### Return type

[**IVR**](IVR.html)

<a name="getarchitectivrs"></a>

## [**IVREntityListing**](IVREntityListing.html) GetArchitectIvrs (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null)

Get IVR configs.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectIvrsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)
            
            
            
            
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ASC)
            
            
            
            
            var name = name_example;  // string | Name of the IVR to filter by. (optional) 
            
            
            

            try
            {
                
                // Get IVR configs.
                
                IVREntityListing result = apiInstance.GetArchitectIvrs(pageNumber, pageSize, sortBy, sortOrder, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectIvrs: " + e.Message );
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
| **sortBy** | **string**| Sort by | [optional] [default to name] |
| **sortOrder** | **string**| Sort order | [optional] [default to ASC] |
| **name** | **string**| Name of the IVR to filter by. | [optional]  |
{: class="table table-striped"}

### Return type

[**IVREntityListing**](IVREntityListing.html)

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

<a name="getarchitectschedule"></a>

## [**Schedule**](Schedule.html) GetArchitectSchedule (string scheduleId)

Get a schedule by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectScheduleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var scheduleId = scheduleId_example;  // string | Schedule ID
            
            
            

            try
            {
                
                // Get a schedule by ID
                
                Schedule result = apiInstance.GetArchitectSchedule(scheduleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectSchedule: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleId** | **string**| Schedule ID |  |
{: class="table table-striped"}

### Return type

[**Schedule**](Schedule.html)

<a name="getarchitectschedulegroup"></a>

## [**ScheduleGroup**](ScheduleGroup.html) GetArchitectSchedulegroup (string scheduleGroupId)

Gets a schedule group by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectSchedulegroupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var scheduleGroupId = scheduleGroupId_example;  // string | Schedule group ID
            
            
            

            try
            {
                
                // Gets a schedule group by ID
                
                ScheduleGroup result = apiInstance.GetArchitectSchedulegroup(scheduleGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectSchedulegroup: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleGroupId** | **string**| Schedule group ID |  |
{: class="table table-striped"}

### Return type

[**ScheduleGroup**](ScheduleGroup.html)

<a name="getarchitectschedulegroups"></a>

## [**ScheduleGroupEntityListing**](ScheduleGroupEntityListing.html) GetArchitectSchedulegroups (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null)

Get a list of schedule groups.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectSchedulegroupsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)
            
            
            
            
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ASC)
            
            
            
            
            var name = name_example;  // string | Name of the Schedule Group to filter by. (optional) 
            
            
            

            try
            {
                
                // Get a list of schedule groups.
                
                ScheduleGroupEntityListing result = apiInstance.GetArchitectSchedulegroups(pageNumber, pageSize, sortBy, sortOrder, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectSchedulegroups: " + e.Message );
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
| **sortBy** | **string**| Sort by | [optional] [default to name] |
| **sortOrder** | **string**| Sort order | [optional] [default to ASC] |
| **name** | **string**| Name of the Schedule Group to filter by. | [optional]  |
{: class="table table-striped"}

### Return type

[**ScheduleGroupEntityListing**](ScheduleGroupEntityListing.html)

<a name="getarchitectschedules"></a>

## [**ScheduleEntityListing**](ScheduleEntityListing.html) GetArchitectSchedules (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null)

Get a list of schedules.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectSchedulesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)
            
            
            
            
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ASC)
            
            
            
            
            var name = name_example;  // string | Name of the Schedule to filter by. (optional) 
            
            
            

            try
            {
                
                // Get a list of schedules.
                
                ScheduleEntityListing result = apiInstance.GetArchitectSchedules(pageNumber, pageSize, sortBy, sortOrder, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectSchedules: " + e.Message );
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
| **sortBy** | **string**| Sort by | [optional] [default to name] |
| **sortOrder** | **string**| Sort order | [optional] [default to ASC] |
| **name** | **string**| Name of the Schedule to filter by. | [optional]  |
{: class="table table-striped"}

### Return type

[**ScheduleEntityListing**](ScheduleEntityListing.html)

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

Get system prompt resources.



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
                
                // Get system prompt resources.
                
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

<a name="getflow"></a>

## [**Flow**](Flow.html) GetFlow (string flowId, bool? deleted = null)

Get flow



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var flowId = flowId_example;  // string | Flow ID
            
            
            
            
            var deleted = true;  // bool? | Include deleted flows (optional)  (default to false)
            
            
            

            try
            {
                
                // Get flow
                
                Flow result = apiInstance.GetFlow(flowId, deleted);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlow: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowId** | **string**| Flow ID |  |
| **deleted** | **bool?**| Include deleted flows | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**Flow**](Flow.html)

<a name="getflowhistoryhistoryid"></a>

## [**HistoryListing**](HistoryListing.html) GetFlowHistoryHistoryId (string flowId, string historyId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, string sortBy = null, List<string> action = null)

Get generated flow history



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowHistoryHistoryIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var flowId = flowId_example;  // string | Flow ID
            
            
            
            
            var historyId = historyId_example;  // string | History ID (generated history)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to desc)
            
            
            
            
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to timestamp)
            
            
            
            
            
            var action = new List<string>(); // List<string> | Flow actions to include (omit to include all) (optional) 
            
            

            try
            {
                
                // Get generated flow history
                
                HistoryListing result = apiInstance.GetFlowHistoryHistoryId(flowId, historyId, pageNumber, pageSize, sortOrder, sortBy, action);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowHistoryHistoryId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowId** | **string**| Flow ID |  |
| **historyId** | **string**| History ID (generated history) |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortOrder** | **string**| Sort order | [optional] [default to desc] |
| **sortBy** | **string**| Sort by | [optional] [default to timestamp]<br />**Values**: action, timestamp, user |
| **action** | [**List<string>**](string.html)| Flow actions to include (omit to include all) | [optional] <br />**Values**: checkin, checkout, create, deactivate, debug, delete, publish, revert, save |
{: class="table table-striped"}

### Return type

[**HistoryListing**](HistoryListing.html)

<a name="getflowlatestconfiguration"></a>

## **Object** GetFlowLatestconfiguration (string flowId, bool? deleted = null)

Get the latest configuration for flow



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowLatestconfigurationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var flowId = flowId_example;  // string | Flow ID
            
            
            
            
            var deleted = true;  // bool? | Include deleted flows (optional)  (default to false)
            
            
            

            try
            {
                
                // Get the latest configuration for flow
                
                Object result = apiInstance.GetFlowLatestconfiguration(flowId, deleted);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowLatestconfiguration: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowId** | **string**| Flow ID |  |
| **deleted** | **bool?**| Include deleted flows | [optional] [default to false] |
{: class="table table-striped"}

### Return type

**Object**

<a name="getflowversion"></a>

## [**FlowVersion**](FlowVersion.html) GetFlowVersion (string flowId, string versionId, string deleted = null)

Get flow version



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowVersionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var flowId = flowId_example;  // string | Flow ID
            
            
            
            
            var versionId = versionId_example;  // string | Version ID
            
            
            
            
            var deleted = deleted_example;  // string | Include deleted flows (optional) 
            
            
            

            try
            {
                
                // Get flow version
                
                FlowVersion result = apiInstance.GetFlowVersion(flowId, versionId, deleted);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowVersion: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowId** | **string**| Flow ID |  |
| **versionId** | **string**| Version ID |  |
| **deleted** | **string**| Include deleted flows | [optional]  |
{: class="table table-striped"}

### Return type

[**FlowVersion**](FlowVersion.html)

<a name="getflowversionconfiguration"></a>

## **Object** GetFlowVersionConfiguration (string flowId, string versionId, string deleted = null)

Create flow version configuration



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowVersionConfigurationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var flowId = flowId_example;  // string | Flow ID
            
            
            
            
            var versionId = versionId_example;  // string | Version ID
            
            
            
            
            var deleted = deleted_example;  // string | Include deleted flows (optional) 
            
            
            

            try
            {
                
                // Create flow version configuration
                
                Object result = apiInstance.GetFlowVersionConfiguration(flowId, versionId, deleted);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowVersionConfiguration: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowId** | **string**| Flow ID |  |
| **versionId** | **string**| Version ID |  |
| **deleted** | **string**| Include deleted flows | [optional]  |
{: class="table table-striped"}

### Return type

**Object**

<a name="getflowversions"></a>

## [**FlowVersionEntityListing**](FlowVersionEntityListing.html) GetFlowVersions (string flowId, int? pageNumber = null, int? pageSize = null, bool? deleted = null)

Get flow version list



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowVersionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var flowId = flowId_example;  // string | Flow ID
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var deleted = true;  // bool? | Include deleted flows (optional) 
            
            
            

            try
            {
                
                // Get flow version list
                
                FlowVersionEntityListing result = apiInstance.GetFlowVersions(flowId, pageNumber, pageSize, deleted);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowVersions: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowId** | **string**| Flow ID |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **deleted** | **bool?**| Include deleted flows | [optional]  |
{: class="table table-striped"}

### Return type

[**FlowVersionEntityListing**](FlowVersionEntityListing.html)

<a name="getflows"></a>

## [**FlowEntityListing**](FlowEntityListing.html) GetFlows (string type, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string editableBy = null, string lockedBy = null, string secure = null, bool? deleted = null, bool? includeSchemas = null, string publishedAfter = null, string publishedBefore = null)

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
            
            
            
            
            var publishedAfter = 2015-01-01T12:00:00-0600, 2015-01-01T18:00:00Z, 2015-01-01T12:00:00.000-0600, 2015-01-01T18:00:00.000Z, 2015-01-01;  // string | Published after (optional) 
            
            
            
            
            var publishedBefore = 2015-01-01T12:00:00-0600, 2015-01-01T18:00:00Z, 2015-01-01T12:00:00.000-0600, 2015-01-01T18:00:00.000Z, 2015-01-01;  // string | Published before (optional) 
            
            
            

            try
            {
                
                // Get a pageable list of flows, filtered by query parameters
                
                FlowEntityListing result = apiInstance.GetFlows(type, pageNumber, pageSize, sortBy, sortOrder, id, name, description, nameOrDescription, publishVersionId, editableBy, lockedBy, secure, deleted, includeSchemas, publishedAfter, publishedBefore);
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
| **type** | **string**| Type | <br />**Values**: inboundcall, inboundemail, inboundshortmessage, outboundcall, inqueuecall, speech, securecall, surveyinvite, workflow |
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
| **secure** | **string**| Secure | [optional] <br />**Values**: any, checkedin, published |
| **deleted** | **bool?**| Include deleted | [optional] [default to false] |
| **includeSchemas** | **bool?**| Include variable schemas | [optional] [default to false] |
| **publishedAfter** | **string**| Published after | [optional]  |
| **publishedBefore** | **string**| Published before | [optional]  |
{: class="table table-striped"}

### Return type

[**FlowEntityListing**](FlowEntityListing.html)

<a name="postarchitectdependencytrackingbuild"></a>

## void PostArchitectDependencytrackingBuild ()

Rebuild Dependency Tracking data for an organization

Asynchronous.  Notification topic: v2.architect.dependencytracking.build

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostArchitectDependencytrackingBuildExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            

            try
            {
                
                // Rebuild Dependency Tracking data for an organization
                
                apiInstance.PostArchitectDependencytrackingBuild();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostArchitectDependencytrackingBuild: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postarchitectivrs"></a>

## [**IVR**](IVR.html) PostArchitectIvrs (IVR body = null)

Create IVR config.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostArchitectIvrsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            
            var body = new IVR(); // IVR |  (optional) 
            
            

            try
            {
                
                // Create IVR config.
                
                IVR result = apiInstance.PostArchitectIvrs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostArchitectIvrs: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**IVR**](IVR.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**IVR**](IVR.html)

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

<a name="postarchitectschedulegroups"></a>

## [**ScheduleGroup**](ScheduleGroup.html) PostArchitectSchedulegroups (ScheduleGroup body = null)

Creates a new schedule group



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostArchitectSchedulegroupsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            
            var body = new ScheduleGroup(); // ScheduleGroup |  (optional) 
            
            

            try
            {
                
                // Creates a new schedule group
                
                ScheduleGroup result = apiInstance.PostArchitectSchedulegroups(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostArchitectSchedulegroups: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ScheduleGroup**](ScheduleGroup.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**ScheduleGroup**](ScheduleGroup.html)

<a name="postarchitectschedules"></a>

## [**Schedule**](Schedule.html) PostArchitectSchedules (Schedule body = null)

Create a new schedule.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostArchitectSchedulesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            
            var body = new Schedule(); // Schedule |  (optional) 
            
            

            try
            {
                
                // Create a new schedule.
                
                Schedule result = apiInstance.PostArchitectSchedules(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostArchitectSchedules: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Schedule**](Schedule.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**Schedule**](Schedule.html)

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

<a name="postflowversions"></a>

## [**FlowVersion**](FlowVersion.html) PostFlowVersions (string flowId, Object body = null)

Create flow version



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowVersionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var flowId = flowId_example;  // string | Flow ID
            
            
            
            
            var body = ;  // Object |  (optional) 
            
            
            

            try
            {
                
                // Create flow version
                
                FlowVersion result = apiInstance.PostFlowVersions(flowId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlowVersions: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowId** | **string**| Flow ID |  |
| **body** | **Object**|  | [optional]  |
{: class="table table-striped"}

### Return type

[**FlowVersion**](FlowVersion.html)

<a name="postflows"></a>

## [**Flow**](Flow.html) PostFlows (Flow body = null)

Create flow



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            
            var body = new Flow(); // Flow |  (optional) 
            
            

            try
            {
                
                // Create flow
                
                Flow result = apiInstance.PostFlows(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlows: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Flow**](Flow.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**Flow**](Flow.html)

<a name="postflowsactionscheckin"></a>

## [**Flow**](Flow.html) PostFlowsActionsCheckin (string flow)

Check-in flow

Asynchronous.  Notification topic: v2.flows.{flowId}

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowsActionsCheckinExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var flow = flow_example;  // string | Flow ID
            
            
            

            try
            {
                
                // Check-in flow
                
                Flow result = apiInstance.PostFlowsActionsCheckin(flow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlowsActionsCheckin: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flow** | **string**| Flow ID |  |
{: class="table table-striped"}

### Return type

[**Flow**](Flow.html)

<a name="postflowsactionscheckout"></a>

## [**Flow**](Flow.html) PostFlowsActionsCheckout (string flow)

Check-out flow



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowsActionsCheckoutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var flow = flow_example;  // string | Flow ID
            
            
            

            try
            {
                
                // Check-out flow
                
                Flow result = apiInstance.PostFlowsActionsCheckout(flow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlowsActionsCheckout: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flow** | **string**| Flow ID |  |
{: class="table table-striped"}

### Return type

[**Flow**](Flow.html)

<a name="postflowsactionsdeactivate"></a>

## [**Flow**](Flow.html) PostFlowsActionsDeactivate (string flow)

Deactivate flow



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowsActionsDeactivateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var flow = flow_example;  // string | Flow ID
            
            
            

            try
            {
                
                // Deactivate flow
                
                Flow result = apiInstance.PostFlowsActionsDeactivate(flow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlowsActionsDeactivate: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flow** | **string**| Flow ID |  |
{: class="table table-striped"}

### Return type

[**Flow**](Flow.html)

<a name="postflowsactionspublish"></a>

## [**Operation**](Operation.html) PostFlowsActionsPublish (string flow, string version = null)

Publish flow

Asynchronous.  Notification topic: v2.flows.{flowId}

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowsActionsPublishExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var flow = flow_example;  // string | Flow ID
            
            
            
            
            var version = version_example;  // string | version (optional) 
            
            
            

            try
            {
                
                // Publish flow
                
                Operation result = apiInstance.PostFlowsActionsPublish(flow, version);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlowsActionsPublish: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flow** | **string**| Flow ID |  |
| **version** | **string**| version | [optional]  |
{: class="table table-striped"}

### Return type

[**Operation**](Operation.html)

<a name="postflowsactionsrevert"></a>

## [**Flow**](Flow.html) PostFlowsActionsRevert (string flow)

Revert flow



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowsActionsRevertExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var flow = flow_example;  // string | Flow ID
            
            
            

            try
            {
                
                // Revert flow
                
                Flow result = apiInstance.PostFlowsActionsRevert(flow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlowsActionsRevert: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flow** | **string**| Flow ID |  |
{: class="table table-striped"}

### Return type

[**Flow**](Flow.html)

<a name="postflowsactionsunlock"></a>

## [**Flow**](Flow.html) PostFlowsActionsUnlock (string flow)

Unlock flow

Allows for unlocking a flow in the case where there is no flow configuration available, and thus a check-in will not unlock the flow. The user must have Architect Admin permissions to perform this action.

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowsActionsUnlockExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var flow = flow_example;  // string | Flow ID
            
            
            

            try
            {
                
                // Unlock flow
                
                Flow result = apiInstance.PostFlowsActionsUnlock(flow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlowsActionsUnlock: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flow** | **string**| Flow ID |  |
{: class="table table-striped"}

### Return type

[**Flow**](Flow.html)

<a name="putarchitectivr"></a>

## [**IVR**](IVR.html) PutArchitectIvr (string ivrId, IVR body = null)

Update an IVR Config.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutArchitectIvrExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var ivrId = ivrId_example;  // string | IVR id
            
            
            
            
            
            var body = new IVR(); // IVR |  (optional) 
            
            

            try
            {
                
                // Update an IVR Config.
                
                IVR result = apiInstance.PutArchitectIvr(ivrId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PutArchitectIvr: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ivrId** | **string**| IVR id |  |
| **body** | [**IVR**](IVR.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**IVR**](IVR.html)

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

<a name="putarchitectschedule"></a>

## [**Schedule**](Schedule.html) PutArchitectSchedule (string scheduleId, Schedule body = null)

Update schedule by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutArchitectScheduleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var scheduleId = scheduleId_example;  // string | Schedule ID
            
            
            
            
            
            var body = new Schedule(); // Schedule |  (optional) 
            
            

            try
            {
                
                // Update schedule by ID
                
                Schedule result = apiInstance.PutArchitectSchedule(scheduleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PutArchitectSchedule: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleId** | **string**| Schedule ID |  |
| **body** | [**Schedule**](Schedule.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**Schedule**](Schedule.html)

<a name="putarchitectschedulegroup"></a>

## [**ScheduleGroup**](ScheduleGroup.html) PutArchitectSchedulegroup (string scheduleGroupId, ScheduleGroup body = null)

Updates a schedule group by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutArchitectSchedulegroupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var scheduleGroupId = scheduleGroupId_example;  // string | Schedule group ID
            
            
            
            
            
            var body = new ScheduleGroup(); // ScheduleGroup |  (optional) 
            
            

            try
            {
                
                // Updates a schedule group by ID
                
                ScheduleGroup result = apiInstance.PutArchitectSchedulegroup(scheduleGroupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PutArchitectSchedulegroup: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleGroupId** | **string**| Schedule group ID |  |
| **body** | [**ScheduleGroup**](ScheduleGroup.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**ScheduleGroup**](ScheduleGroup.html)

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

<a name="putflow"></a>

## [**Flow**](Flow.html) PutFlow (string flowId, Flow body = null)

Update flow



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutFlowExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ArchitectApi();
            
            
            var flowId = flowId_example;  // string | Flow ID
            
            
            
            
            
            var body = new Flow(); // Flow |  (optional) 
            
            

            try
            {
                
                // Update flow
                
                Flow result = apiInstance.PutFlow(flowId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PutFlow: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowId** | **string**| Flow ID |  |
| **body** | [**Flow**](Flow.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**Flow**](Flow.html)

