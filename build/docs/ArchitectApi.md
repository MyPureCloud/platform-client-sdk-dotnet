---
title: ArchitectApi
---
## PureCloudPlatform.Client.V2.Api.ArchitectApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteArchitectEmergencygroup**](ArchitectApi.html#deletearchitectemergencygroup) | **DELETE** /api/v2/architect/emergencygroups/{emergencyGroupId} | Deletes a emergency group by ID |
| [**DeleteArchitectIvr**](ArchitectApi.html#deletearchitectivr) | **DELETE** /api/v2/architect/ivrs/{ivrId} | Delete an IVR Config. |
| [**DeleteArchitectPrompt**](ArchitectApi.html#deletearchitectprompt) | **DELETE** /api/v2/architect/prompts/{promptId} | Delete specified user prompt |
| [**DeleteArchitectPromptResource**](ArchitectApi.html#deletearchitectpromptresource) | **DELETE** /api/v2/architect/prompts/{promptId}/resources/{languageCode} | Delete specified user prompt resource |
| [**DeleteArchitectPromptResourceAudio**](ArchitectApi.html#deletearchitectpromptresourceaudio) | **DELETE** /api/v2/architect/prompts/{promptId}/resources/{languageCode}/audio | Delete specified user prompt resource audio |
| [**DeleteArchitectPrompts**](ArchitectApi.html#deletearchitectprompts) | **DELETE** /api/v2/architect/prompts | Batch-delete a list of prompts |
| [**DeleteArchitectSchedule**](ArchitectApi.html#deletearchitectschedule) | **DELETE** /api/v2/architect/schedules/{scheduleId} | Delete a schedule by id |
| [**DeleteArchitectSchedulegroup**](ArchitectApi.html#deletearchitectschedulegroup) | **DELETE** /api/v2/architect/schedulegroups/{scheduleGroupId} | Deletes a schedule group by ID |
| [**DeleteArchitectSystempromptResource**](ArchitectApi.html#deletearchitectsystempromptresource) | **DELETE** /api/v2/architect/systemprompts/{promptId}/resources/{languageCode} | Delete a system prompt resource override. |
| [**DeleteFlow**](ArchitectApi.html#deleteflow) | **DELETE** /api/v2/flows/{flowId} | Delete flow |
| [**DeleteFlows**](ArchitectApi.html#deleteflows) | **DELETE** /api/v2/flows | Batch-delete a list of flows |
| [**DeleteFlowsDatatable**](ArchitectApi.html#deleteflowsdatatable) | **DELETE** /api/v2/flows/datatables/{datatableId} | deletes a specific datatable by id |
| [**DeleteFlowsDatatableRow**](ArchitectApi.html#deleteflowsdatatablerow) | **DELETE** /api/v2/flows/datatables/{datatableId}/rows/{rowId} | Delete a row entry |
| [**GetArchitectDependencytracking**](ArchitectApi.html#getarchitectdependencytracking) | **GET** /api/v2/architect/dependencytracking | Get Dependency Tracking objects that have a given display name |
| [**GetArchitectDependencytrackingBuild**](ArchitectApi.html#getarchitectdependencytrackingbuild) | **GET** /api/v2/architect/dependencytracking/build | Get Dependency Tracking build status for an organization |
| [**GetArchitectDependencytrackingConsumedresources**](ArchitectApi.html#getarchitectdependencytrackingconsumedresources) | **GET** /api/v2/architect/dependencytracking/consumedresources | Get resources that are consumed by a given Dependency Tracking object |
| [**GetArchitectDependencytrackingConsumingresources**](ArchitectApi.html#getarchitectdependencytrackingconsumingresources) | **GET** /api/v2/architect/dependencytracking/consumingresources | Get resources that consume a given Dependency Tracking object |
| [**GetArchitectDependencytrackingDeletedresourceconsumers**](ArchitectApi.html#getarchitectdependencytrackingdeletedresourceconsumers) | **GET** /api/v2/architect/dependencytracking/deletedresourceconsumers | Get Dependency Tracking objects that consume deleted resources |
| [**GetArchitectDependencytrackingObject**](ArchitectApi.html#getarchitectdependencytrackingobject) | **GET** /api/v2/architect/dependencytracking/object | Get a Dependency Tracking object |
| [**GetArchitectDependencytrackingType**](ArchitectApi.html#getarchitectdependencytrackingtype) | **GET** /api/v2/architect/dependencytracking/types/{typeId} | Get a Dependency Tracking type. |
| [**GetArchitectDependencytrackingTypes**](ArchitectApi.html#getarchitectdependencytrackingtypes) | **GET** /api/v2/architect/dependencytracking/types | Get Dependency Tracking types. |
| [**GetArchitectDependencytrackingUpdatedresourceconsumers**](ArchitectApi.html#getarchitectdependencytrackingupdatedresourceconsumers) | **GET** /api/v2/architect/dependencytracking/updatedresourceconsumers | Get Dependency Tracking objects that depend on updated resources |
| [**GetArchitectEmergencygroup**](ArchitectApi.html#getarchitectemergencygroup) | **GET** /api/v2/architect/emergencygroups/{emergencyGroupId} | Gets a emergency group by ID |
| [**GetArchitectEmergencygroups**](ArchitectApi.html#getarchitectemergencygroups) | **GET** /api/v2/architect/emergencygroups | Get a list of emergency groups. |
| [**GetArchitectIvr**](ArchitectApi.html#getarchitectivr) | **GET** /api/v2/architect/ivrs/{ivrId} | Get an IVR config. |
| [**GetArchitectIvrs**](ArchitectApi.html#getarchitectivrs) | **GET** /api/v2/architect/ivrs | Get IVR configs. |
| [**GetArchitectPrompt**](ArchitectApi.html#getarchitectprompt) | **GET** /api/v2/architect/prompts/{promptId} | Get specified user prompt |
| [**GetArchitectPromptHistoryHistoryId**](ArchitectApi.html#getarchitectprompthistoryhistoryid) | **GET** /api/v2/architect/prompts/{promptId}/history/{historyId} | Get generated prompt history |
| [**GetArchitectPromptResource**](ArchitectApi.html#getarchitectpromptresource) | **GET** /api/v2/architect/prompts/{promptId}/resources/{languageCode} | Get specified user prompt resource |
| [**GetArchitectPromptResources**](ArchitectApi.html#getarchitectpromptresources) | **GET** /api/v2/architect/prompts/{promptId}/resources | Get a pageable list of user prompt resources |
| [**GetArchitectPrompts**](ArchitectApi.html#getarchitectprompts) | **GET** /api/v2/architect/prompts | Get a pageable list of user prompts |
| [**GetArchitectSchedule**](ArchitectApi.html#getarchitectschedule) | **GET** /api/v2/architect/schedules/{scheduleId} | Get a schedule by ID |
| [**GetArchitectSchedulegroup**](ArchitectApi.html#getarchitectschedulegroup) | **GET** /api/v2/architect/schedulegroups/{scheduleGroupId} | Gets a schedule group by ID |
| [**GetArchitectSchedulegroups**](ArchitectApi.html#getarchitectschedulegroups) | **GET** /api/v2/architect/schedulegroups | Get a list of schedule groups. |
| [**GetArchitectSchedules**](ArchitectApi.html#getarchitectschedules) | **GET** /api/v2/architect/schedules | Get a list of schedules. |
| [**GetArchitectSystemprompt**](ArchitectApi.html#getarchitectsystemprompt) | **GET** /api/v2/architect/systemprompts/{promptId} | Get a system prompt |
| [**GetArchitectSystempromptHistoryHistoryId**](ArchitectApi.html#getarchitectsystemprompthistoryhistoryid) | **GET** /api/v2/architect/systemprompts/{promptId}/history/{historyId} | Get generated prompt history |
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
| [**GetFlowsDatatable**](ArchitectApi.html#getflowsdatatable) | **GET** /api/v2/flows/datatables/{datatableId} | Returns a specific datatable by id |
| [**GetFlowsDatatableRow**](ArchitectApi.html#getflowsdatatablerow) | **GET** /api/v2/flows/datatables/{datatableId}/rows/{rowId} | Returns a specific row for the datatable |
| [**GetFlowsDatatableRows**](ArchitectApi.html#getflowsdatatablerows) | **GET** /api/v2/flows/datatables/{datatableId}/rows | Returns the rows for the datatable with the given id |
| [**GetFlowsDatatables**](ArchitectApi.html#getflowsdatatables) | **GET** /api/v2/flows/datatables | Retrieve a list of datatables for the org |
| [**GetFlowsDivisionviews**](ArchitectApi.html#getflowsdivisionviews) | **GET** /api/v2/flows/divisionviews | Get a pageable list of basic flow information objects filterable by query parameters. |
| [**GetFlowsOutcome**](ArchitectApi.html#getflowsoutcome) | **GET** /api/v2/flows/outcomes/{flowOutcomeId} | Get a flow outcome |
| [**GetFlowsOutcomes**](ArchitectApi.html#getflowsoutcomes) | **GET** /api/v2/flows/outcomes | Get a pageable list of flow outcomes, filtered by query parameters |
| [**PostArchitectDependencytrackingBuild**](ArchitectApi.html#postarchitectdependencytrackingbuild) | **POST** /api/v2/architect/dependencytracking/build | Rebuild Dependency Tracking data for an organization |
| [**PostArchitectEmergencygroups**](ArchitectApi.html#postarchitectemergencygroups) | **POST** /api/v2/architect/emergencygroups | Creates a new emergency group |
| [**PostArchitectIvrs**](ArchitectApi.html#postarchitectivrs) | **POST** /api/v2/architect/ivrs | Create IVR config. |
| [**PostArchitectPromptHistory**](ArchitectApi.html#postarchitectprompthistory) | **POST** /api/v2/architect/prompts/{promptId}/history | Generate prompt history |
| [**PostArchitectPromptResources**](ArchitectApi.html#postarchitectpromptresources) | **POST** /api/v2/architect/prompts/{promptId}/resources | Create a new user prompt resource |
| [**PostArchitectPrompts**](ArchitectApi.html#postarchitectprompts) | **POST** /api/v2/architect/prompts | Create a new user prompt |
| [**PostArchitectSchedulegroups**](ArchitectApi.html#postarchitectschedulegroups) | **POST** /api/v2/architect/schedulegroups | Creates a new schedule group |
| [**PostArchitectSchedules**](ArchitectApi.html#postarchitectschedules) | **POST** /api/v2/architect/schedules | Create a new schedule. |
| [**PostArchitectSystempromptHistory**](ArchitectApi.html#postarchitectsystemprompthistory) | **POST** /api/v2/architect/systemprompts/{promptId}/history | Generate system prompt history |
| [**PostArchitectSystempromptResources**](ArchitectApi.html#postarchitectsystempromptresources) | **POST** /api/v2/architect/systemprompts/{promptId}/resources | Create system prompt resource override. |
| [**PostFlowVersions**](ArchitectApi.html#postflowversions) | **POST** /api/v2/flows/{flowId}/versions | Create flow version |
| [**PostFlows**](ArchitectApi.html#postflows) | **POST** /api/v2/flows | Create flow |
| [**PostFlowsActionsCheckin**](ArchitectApi.html#postflowsactionscheckin) | **POST** /api/v2/flows/actions/checkin | Check-in flow |
| [**PostFlowsActionsCheckout**](ArchitectApi.html#postflowsactionscheckout) | **POST** /api/v2/flows/actions/checkout | Check-out flow |
| [**PostFlowsActionsDeactivate**](ArchitectApi.html#postflowsactionsdeactivate) | **POST** /api/v2/flows/actions/deactivate | Deactivate flow |
| [**PostFlowsActionsPublish**](ArchitectApi.html#postflowsactionspublish) | **POST** /api/v2/flows/actions/publish | Publish flow |
| [**PostFlowsActionsRevert**](ArchitectApi.html#postflowsactionsrevert) | **POST** /api/v2/flows/actions/revert | Revert flow |
| [**PostFlowsActionsUnlock**](ArchitectApi.html#postflowsactionsunlock) | **POST** /api/v2/flows/actions/unlock | Unlock flow |
| [**PostFlowsDatatableRows**](ArchitectApi.html#postflowsdatatablerows) | **POST** /api/v2/flows/datatables/{datatableId}/rows | Create a new row entry for the datatable. |
| [**PostFlowsDatatables**](ArchitectApi.html#postflowsdatatables) | **POST** /api/v2/flows/datatables | Create a new datatable with the specified json-schema definition |
| [**PostFlowsOutcomes**](ArchitectApi.html#postflowsoutcomes) | **POST** /api/v2/flows/outcomes | Create a flow outcome |
| [**PutArchitectEmergencygroup**](ArchitectApi.html#putarchitectemergencygroup) | **PUT** /api/v2/architect/emergencygroups/{emergencyGroupId} | Updates a emergency group by ID |
| [**PutArchitectIvr**](ArchitectApi.html#putarchitectivr) | **PUT** /api/v2/architect/ivrs/{ivrId} | Update an IVR Config. |
| [**PutArchitectPrompt**](ArchitectApi.html#putarchitectprompt) | **PUT** /api/v2/architect/prompts/{promptId} | Update specified user prompt |
| [**PutArchitectPromptResource**](ArchitectApi.html#putarchitectpromptresource) | **PUT** /api/v2/architect/prompts/{promptId}/resources/{languageCode} | Update specified user prompt resource |
| [**PutArchitectSchedule**](ArchitectApi.html#putarchitectschedule) | **PUT** /api/v2/architect/schedules/{scheduleId} | Update schedule by ID |
| [**PutArchitectSchedulegroup**](ArchitectApi.html#putarchitectschedulegroup) | **PUT** /api/v2/architect/schedulegroups/{scheduleGroupId} | Updates a schedule group by ID |
| [**PutArchitectSystempromptResource**](ArchitectApi.html#putarchitectsystempromptresource) | **PUT** /api/v2/architect/systemprompts/{promptId}/resources/{languageCode} | Updates a system prompt resource override. |
| [**PutFlow**](ArchitectApi.html#putflow) | **PUT** /api/v2/flows/{flowId} | Update flow |
| [**PutFlowsDatatable**](ArchitectApi.html#putflowsdatatable) | **PUT** /api/v2/flows/datatables/{datatableId} | Updates a specific datatable by id |
| [**PutFlowsDatatableRow**](ArchitectApi.html#putflowsdatatablerow) | **PUT** /api/v2/flows/datatables/{datatableId}/rows/{rowId} | Update a row entry |
| [**PutFlowsOutcome**](ArchitectApi.html#putflowsoutcome) | **PUT** /api/v2/flows/outcomes/{flowOutcomeId} | Updates a flow outcome |
{: class="table table-striped"}

<a name="deletearchitectemergencygroup"></a>

## void DeleteArchitectEmergencygroup (string emergencyGroupId)



Deletes a emergency group by ID



Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteArchitectEmergencygroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var emergencyGroupId = emergencyGroupId_example;  // string | Emergency group ID

            try
            { 
                // Deletes a emergency group by ID
                apiInstance.DeleteArchitectEmergencygroup(emergencyGroupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteArchitectEmergencygroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emergencyGroupId** | **string**| Emergency group ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletearchitectivr"></a>

## void DeleteArchitectIvr (string ivrId)



Delete an IVR Config.



Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

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



Requires ANY permissions: 

* architect:userPrompt:delete

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

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



Requires ANY permissions: 

* architect:userPrompt:edit

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **languageCode** | **string**| Language |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletearchitectpromptresourceaudio"></a>

## void DeleteArchitectPromptResourceAudio (string promptId, string languageCode)



Delete specified user prompt resource audio



Requires ANY permissions: 

* architect:userPrompt:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteArchitectPromptResourceAudioExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var languageCode = languageCode_example;  // string | Language

            try
            { 
                // Delete specified user prompt resource audio
                apiInstance.DeleteArchitectPromptResourceAudio(promptId, languageCode);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteArchitectPromptResourceAudio: " + e.Message );
            }
        }
    }
}
```

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

Requires ANY permissions: 

* architect:userPrompt:delete

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

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



Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

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



Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

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



Requires ANY permissions: 

* architect:systemPrompt:edit

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

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



Requires ANY permissions: 

* architect:flow:delete

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

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

Requires ANY permissions: 

* architect:flow:delete

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | [**List<string>**](string.html)| List of Flow IDs |  |
{: class="table table-striped"}

### Return type

[**Operation**](Operation.html)

<a name="deleteflowsdatatable"></a>

## void DeleteFlowsDatatable (string datatableId, bool? force = null)



deletes a specific datatable by id

Deletes an entire datatable (including the schema and data) with a given datatableId

Requires ANY permissions: 

* architect:datatable:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteFlowsDatatableExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var datatableId = datatableId_example;  // string | id of datatable
            var force = true;  // bool? | force delete, even if in use (optional)  (default to false)

            try
            { 
                // deletes a specific datatable by id
                apiInstance.DeleteFlowsDatatable(datatableId, force);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteFlowsDatatable: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **datatableId** | **string**| id of datatable |  |
| **force** | **bool?**| force delete, even if in use | [optional] [default to false] |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteflowsdatatablerow"></a>

## void DeleteFlowsDatatableRow (string datatableId, string rowId)



Delete a row entry

Deletes a row with a given rowId (the value of the key field).

Requires ANY permissions: 

* architect:datatable:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteFlowsDatatableRowExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var datatableId = datatableId_example;  // string | id of datatable
            var rowId = rowId_example;  // string | the key for the row

            try
            { 
                // Delete a row entry
                apiInstance.DeleteFlowsDatatableRow(datatableId, rowId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteFlowsDatatableRow: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **datatableId** | **string**| id of datatable |  |
| **rowId** | **string**| the key for the row |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getarchitectdependencytracking"></a>

## [**DependencyObjectEntityListing**](DependencyObjectEntityListing.html) GetArchitectDependencytracking (string name, int? pageNumber = null, int? pageSize = null, List<string> objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null)



Get Dependency Tracking objects that have a given display name



Requires ANY permissions: 

* architect:dependencyTracking:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **name** | **string**| Object name to search for |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **objectType** | [**List<string>**](string.html)| Object type(s) to search for | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, BRIDGEACTION, COMMONMODULEFLOW, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, DATATABLE, DIALOGFLOWAGENT, EMAILROUTE, EMERGENCYGROUP, FLOWOUTCOME, GROUP, INBOUNDCALLFLOW, INBOUNDCHATFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, IVRCONFIGURATION, LANGUAGE, LEXBOT, LEXBOTALIAS, OUTBOUNDCALLFLOW, QUEUE, RECORDINGPOLICY, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SURVEYINVITEFLOW, SYSTEMPROMPT, TTSENGINE, TTSVOICE, USER, USERPROMPT, WIDGET |
| **consumedResources** | **bool?**| Include resources each result item consumes | [optional]  |
| **consumingResources** | **bool?**| Include resources that consume each result item | [optional]  |
| **consumedResourceType** | [**List<string>**](string.html)| Types of consumed resources to return, if consumed resources are requested | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, BRIDGEACTION, COMMONMODULEFLOW, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, DATATABLE, DIALOGFLOWAGENT, EMAILROUTE, EMERGENCYGROUP, FLOWOUTCOME, GROUP, INBOUNDCALLFLOW, INBOUNDCHATFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, IVRCONFIGURATION, LANGUAGE, LEXBOT, LEXBOTALIAS, OUTBOUNDCALLFLOW, QUEUE, RECORDINGPOLICY, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SURVEYINVITEFLOW, SYSTEMPROMPT, TTSENGINE, TTSVOICE, USER, USERPROMPT, WIDGET |
| **consumingResourceType** | [**List<string>**](string.html)| Types of consuming resources to return, if consuming resources are requested | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, BRIDGEACTION, COMMONMODULEFLOW, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, DATATABLE, DIALOGFLOWAGENT, EMAILROUTE, EMERGENCYGROUP, FLOWOUTCOME, GROUP, INBOUNDCALLFLOW, INBOUNDCHATFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, IVRCONFIGURATION, LANGUAGE, LEXBOT, LEXBOTALIAS, OUTBOUNDCALLFLOW, QUEUE, RECORDINGPOLICY, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SURVEYINVITEFLOW, SYSTEMPROMPT, TTSENGINE, TTSVOICE, USER, USERPROMPT, WIDGET |
{: class="table table-striped"}

### Return type

[**DependencyObjectEntityListing**](DependencyObjectEntityListing.html)

<a name="getarchitectdependencytrackingbuild"></a>

## [**DependencyStatus**](DependencyStatus.html) GetArchitectDependencytrackingBuild ()



Get Dependency Tracking build status for an organization



Requires ANY permissions: 

* architect:dependencyTracking:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**DependencyStatus**](DependencyStatus.html)

<a name="getarchitectdependencytrackingconsumedresources"></a>

## [**ConsumedResourcesEntityListing**](ConsumedResourcesEntityListing.html) GetArchitectDependencytrackingConsumedresources (string id, string version, string objectType, List<string> resourceType = null, int? pageNumber = null, int? pageSize = null)



Get resources that are consumed by a given Dependency Tracking object



Requires ANY permissions: 

* architect:dependencyTracking:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var id = id_example;  // string | Consuming object ID
            var version = version_example;  // string | Consuming object version
            var objectType = objectType_example;  // string | Consuming object type.  Only versioned types are allowed here.
            var resourceType = new List<string>(); // List<string> | Types of consumed resources to show (optional) 
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            { 
                // Get resources that are consumed by a given Dependency Tracking object
                ConsumedResourcesEntityListing result = apiInstance.GetArchitectDependencytrackingConsumedresources(id, version, objectType, resourceType, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectDependencytrackingConsumedresources: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | **string**| Consuming object ID |  |
| **version** | **string**| Consuming object version |  |
| **objectType** | **string**| Consuming object type.  Only versioned types are allowed here. | <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, BRIDGEACTION, COMMONMODULEFLOW, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, DATATABLE, DIALOGFLOWAGENT, EMAILROUTE, EMERGENCYGROUP, FLOWOUTCOME, GROUP, INBOUNDCALLFLOW, INBOUNDCHATFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, IVRCONFIGURATION, LANGUAGE, LEXBOT, LEXBOTALIAS, OUTBOUNDCALLFLOW, QUEUE, RECORDINGPOLICY, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SURVEYINVITEFLOW, SYSTEMPROMPT, TTSENGINE, TTSVOICE, USER, USERPROMPT, WIDGET |
| **resourceType** | [**List<string>**](string.html)| Types of consumed resources to show | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, BRIDGEACTION, COMMONMODULEFLOW, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, DATATABLE, DIALOGFLOWAGENT, EMAILROUTE, EMERGENCYGROUP, FLOWOUTCOME, GROUP, INBOUNDCALLFLOW, INBOUNDCHATFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, IVRCONFIGURATION, LANGUAGE, LEXBOT, LEXBOTALIAS, OUTBOUNDCALLFLOW, QUEUE, RECORDINGPOLICY, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SURVEYINVITEFLOW, SYSTEMPROMPT, TTSENGINE, TTSVOICE, USER, USERPROMPT, WIDGET |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
{: class="table table-striped"}

### Return type

[**ConsumedResourcesEntityListing**](ConsumedResourcesEntityListing.html)

<a name="getarchitectdependencytrackingconsumingresources"></a>

## [**ConsumingResourcesEntityListing**](ConsumingResourcesEntityListing.html) GetArchitectDependencytrackingConsumingresources (string id, string objectType, List<string> resourceType = null, int? pageNumber = null, int? pageSize = null, string flowFilter = null)



Get resources that consume a given Dependency Tracking object



Requires ANY permissions: 

* architect:dependencyTracking:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var id = id_example;  // string | Consumed object ID
            var objectType = objectType_example;  // string | Consumed object type
            var resourceType = new List<string>(); // List<string> | Types of consuming resources to show.  Only versioned types are allowed here. (optional) 
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var flowFilter = flowFilter_example;  // string | Show only checkedIn or published flows (optional) 

            try
            { 
                // Get resources that consume a given Dependency Tracking object
                ConsumingResourcesEntityListing result = apiInstance.GetArchitectDependencytrackingConsumingresources(id, objectType, resourceType, pageNumber, pageSize, flowFilter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectDependencytrackingConsumingresources: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | **string**| Consumed object ID |  |
| **objectType** | **string**| Consumed object type | <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, BRIDGEACTION, COMMONMODULEFLOW, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, DATATABLE, DIALOGFLOWAGENT, EMAILROUTE, EMERGENCYGROUP, FLOWOUTCOME, GROUP, INBOUNDCALLFLOW, INBOUNDCHATFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, IVRCONFIGURATION, LANGUAGE, LEXBOT, LEXBOTALIAS, OUTBOUNDCALLFLOW, QUEUE, RECORDINGPOLICY, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SURVEYINVITEFLOW, SYSTEMPROMPT, TTSENGINE, TTSVOICE, USER, USERPROMPT, WIDGET |
| **resourceType** | [**List<string>**](string.html)| Types of consuming resources to show.  Only versioned types are allowed here. | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, BRIDGEACTION, COMMONMODULEFLOW, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, DATATABLE, DIALOGFLOWAGENT, EMAILROUTE, EMERGENCYGROUP, FLOWOUTCOME, GROUP, INBOUNDCALLFLOW, INBOUNDCHATFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, IVRCONFIGURATION, LANGUAGE, LEXBOT, LEXBOTALIAS, OUTBOUNDCALLFLOW, QUEUE, RECORDINGPOLICY, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SURVEYINVITEFLOW, SYSTEMPROMPT, TTSENGINE, TTSVOICE, USER, USERPROMPT, WIDGET |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **flowFilter** | **string**| Show only checkedIn or published flows | [optional] <br />**Values**: checkedIn, published |
{: class="table table-striped"}

### Return type

[**ConsumingResourcesEntityListing**](ConsumingResourcesEntityListing.html)

<a name="getarchitectdependencytrackingdeletedresourceconsumers"></a>

## [**DependencyObjectEntityListing**](DependencyObjectEntityListing.html) GetArchitectDependencytrackingDeletedresourceconsumers (string name = null, List<string> objectType = null, string flowFilter = null, bool? consumedResources = null, List<string> consumedResourceType = null, int? pageNumber = null, int? pageSize = null)



Get Dependency Tracking objects that consume deleted resources



Requires ANY permissions: 

* architect:dependencyTracking:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **name** | **string**| Name to search for | [optional]  |
| **objectType** | [**List<string>**](string.html)| Object type(s) to search for | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, BRIDGEACTION, COMMONMODULEFLOW, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, DATATABLE, DIALOGFLOWAGENT, EMAILROUTE, EMERGENCYGROUP, FLOWOUTCOME, GROUP, INBOUNDCALLFLOW, INBOUNDCHATFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, IVRCONFIGURATION, LANGUAGE, LEXBOT, LEXBOTALIAS, OUTBOUNDCALLFLOW, QUEUE, RECORDINGPOLICY, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SURVEYINVITEFLOW, SYSTEMPROMPT, TTSENGINE, TTSVOICE, USER, USERPROMPT, WIDGET |
| **flowFilter** | **string**| Show only checkedIn or published flows | [optional] <br />**Values**: checkedIn, published |
| **consumedResources** | **bool?**| Return consumed resources? | [optional] [default to false] |
| **consumedResourceType** | [**List<string>**](string.html)| Resource type(s) to return | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, BRIDGEACTION, COMMONMODULEFLOW, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, DATATABLE, DIALOGFLOWAGENT, EMAILROUTE, EMERGENCYGROUP, FLOWOUTCOME, GROUP, INBOUNDCALLFLOW, INBOUNDCHATFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, IVRCONFIGURATION, LANGUAGE, LEXBOT, LEXBOTALIAS, OUTBOUNDCALLFLOW, QUEUE, RECORDINGPOLICY, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SURVEYINVITEFLOW, SYSTEMPROMPT, TTSENGINE, TTSVOICE, USER, USERPROMPT, WIDGET |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
{: class="table table-striped"}

### Return type

[**DependencyObjectEntityListing**](DependencyObjectEntityListing.html)

<a name="getarchitectdependencytrackingobject"></a>

## [**DependencyObject**](DependencyObject.html) GetArchitectDependencytrackingObject (string id, string version = null, string objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null)



Get a Dependency Tracking object



Requires ANY permissions: 

* architect:dependencyTracking:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | **string**| Object ID |  |
| **version** | **string**| Object version | [optional]  |
| **objectType** | **string**| Object type | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, BRIDGEACTION, COMMONMODULEFLOW, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, DATATABLE, DIALOGFLOWAGENT, EMAILROUTE, EMERGENCYGROUP, FLOWOUTCOME, GROUP, INBOUNDCALLFLOW, INBOUNDCHATFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, IVRCONFIGURATION, LANGUAGE, LEXBOT, LEXBOTALIAS, OUTBOUNDCALLFLOW, QUEUE, RECORDINGPOLICY, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SURVEYINVITEFLOW, SYSTEMPROMPT, TTSENGINE, TTSVOICE, USER, USERPROMPT, WIDGET |
| **consumedResources** | **bool?**| Include resources this item consumes | [optional]  |
| **consumingResources** | **bool?**| Include resources that consume this item | [optional]  |
| **consumedResourceType** | [**List<string>**](string.html)| Types of consumed resources to return, if consumed resources are requested | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, BRIDGEACTION, COMMONMODULEFLOW, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, DATATABLE, DIALOGFLOWAGENT, EMAILROUTE, EMERGENCYGROUP, FLOWOUTCOME, GROUP, INBOUNDCALLFLOW, INBOUNDCHATFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, IVRCONFIGURATION, LANGUAGE, LEXBOT, LEXBOTALIAS, OUTBOUNDCALLFLOW, QUEUE, RECORDINGPOLICY, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SURVEYINVITEFLOW, SYSTEMPROMPT, TTSENGINE, TTSVOICE, USER, USERPROMPT, WIDGET |
| **consumingResourceType** | [**List<string>**](string.html)| Types of consuming resources to return, if consuming resources are requested | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, BRIDGEACTION, COMMONMODULEFLOW, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, DATATABLE, DIALOGFLOWAGENT, EMAILROUTE, EMERGENCYGROUP, FLOWOUTCOME, GROUP, INBOUNDCALLFLOW, INBOUNDCHATFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, IVRCONFIGURATION, LANGUAGE, LEXBOT, LEXBOTALIAS, OUTBOUNDCALLFLOW, QUEUE, RECORDINGPOLICY, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SURVEYINVITEFLOW, SYSTEMPROMPT, TTSENGINE, TTSVOICE, USER, USERPROMPT, WIDGET |
{: class="table table-striped"}

### Return type

[**DependencyObject**](DependencyObject.html)

<a name="getarchitectdependencytrackingtype"></a>

## [**DependencyType**](DependencyType.html) GetArchitectDependencytrackingType (string typeId)



Get a Dependency Tracking type.



Requires ANY permissions: 

* architect:dependencyTracking:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

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



Requires ANY permissions: 

* architect:dependencyTracking:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

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



Requires ANY permissions: 

* architect:dependencyTracking:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **name** | **string**| Name to search for | [optional]  |
| **objectType** | [**List<string>**](string.html)| Object type(s) to search for | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, BRIDGEACTION, COMMONMODULEFLOW, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, DATATABLE, DIALOGFLOWAGENT, EMAILROUTE, EMERGENCYGROUP, FLOWOUTCOME, GROUP, INBOUNDCALLFLOW, INBOUNDCHATFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, IVRCONFIGURATION, LANGUAGE, LEXBOT, LEXBOTALIAS, OUTBOUNDCALLFLOW, QUEUE, RECORDINGPOLICY, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SURVEYINVITEFLOW, SYSTEMPROMPT, TTSENGINE, TTSVOICE, USER, USERPROMPT, WIDGET |
| **consumedResources** | **bool?**| Return consumed resources? | [optional] [default to false] |
| **consumedResourceType** | [**List<string>**](string.html)| Resource type(s) to return | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, BRIDGEACTION, COMMONMODULEFLOW, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, DATATABLE, DIALOGFLOWAGENT, EMAILROUTE, EMERGENCYGROUP, FLOWOUTCOME, GROUP, INBOUNDCALLFLOW, INBOUNDCHATFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, IVRCONFIGURATION, LANGUAGE, LEXBOT, LEXBOTALIAS, OUTBOUNDCALLFLOW, QUEUE, RECORDINGPOLICY, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SURVEYINVITEFLOW, SYSTEMPROMPT, TTSENGINE, TTSVOICE, USER, USERPROMPT, WIDGET |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
{: class="table table-striped"}

### Return type

[**DependencyObjectEntityListing**](DependencyObjectEntityListing.html)

<a name="getarchitectemergencygroup"></a>

## [**EmergencyGroup**](EmergencyGroup.html) GetArchitectEmergencygroup (string emergencyGroupId)



Gets a emergency group by ID



Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectEmergencygroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var emergencyGroupId = emergencyGroupId_example;  // string | Emergency group ID

            try
            { 
                // Gets a emergency group by ID
                EmergencyGroup result = apiInstance.GetArchitectEmergencygroup(emergencyGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectEmergencygroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emergencyGroupId** | **string**| Emergency group ID |  |
{: class="table table-striped"}

### Return type

[**EmergencyGroup**](EmergencyGroup.html)

<a name="getarchitectemergencygroups"></a>

## [**EmergencyGroupListing**](EmergencyGroupListing.html) GetArchitectEmergencygroups (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null)



Get a list of emergency groups.



Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectEmergencygroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ASC)
            var name = name_example;  // string | Name of the Emergency Group to filter by. (optional) 

            try
            { 
                // Get a list of emergency groups.
                EmergencyGroupListing result = apiInstance.GetArchitectEmergencygroups(pageNumber, pageSize, sortBy, sortOrder, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectEmergencygroups: " + e.Message );
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
| **sortBy** | **string**| Sort by | [optional] [default to name] |
| **sortOrder** | **string**| Sort order | [optional] [default to ASC] |
| **name** | **string**| Name of the Emergency Group to filter by. | [optional]  |
{: class="table table-striped"}

### Return type

[**EmergencyGroupListing**](EmergencyGroupListing.html)

<a name="getarchitectivr"></a>

## [**IVR**](IVR.html) GetArchitectIvr (string ivrId)



Get an IVR config.



Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

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



Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

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



Requires ANY permissions: 

* architect:userPrompt:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
{: class="table table-striped"}

### Return type

[**Prompt**](Prompt.html)

<a name="getarchitectprompthistoryhistoryid"></a>

## [**HistoryListing**](HistoryListing.html) GetArchitectPromptHistoryHistoryId (string promptId, string historyId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, string sortBy = null, List<string> action = null)



Get generated prompt history



Requires ANY permissions: 

* architect:userPrompt:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectPromptHistoryHistoryIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var historyId = historyId_example;  // string | History request ID
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to desc)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to timestamp)
            var action = new List<string>(); // List<string> | Flow actions to include (omit to include all) (optional) 

            try
            { 
                // Get generated prompt history
                HistoryListing result = apiInstance.GetArchitectPromptHistoryHistoryId(promptId, historyId, pageNumber, pageSize, sortOrder, sortBy, action);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectPromptHistoryHistoryId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **historyId** | **string**| History request ID |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortOrder** | **string**| Sort order | [optional] [default to desc] |
| **sortBy** | **string**| Sort by | [optional] [default to timestamp]<br />**Values**: action, timestamp, user |
| **action** | [**List<string>**](string.html)| Flow actions to include (omit to include all) | [optional] <br />**Values**: checkin, checkout, create, deactivate, debug, delete, publish, revert, save |
{: class="table table-striped"}

### Return type

[**HistoryListing**](HistoryListing.html)

<a name="getarchitectpromptresource"></a>

## [**PromptAsset**](PromptAsset.html) GetArchitectPromptResource (string promptId, string languageCode)



Get specified user prompt resource



Requires ANY permissions: 

* architect:userPrompt:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

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

Requires ANY permissions: 

* architect:userPrompt:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

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

## [**PromptEntityListing**](PromptEntityListing.html) GetArchitectPrompts (int? pageNumber = null, int? pageSize = null, List<string> name = null, string description = null, string nameOrDescription = null, string sortBy = null, string sortOrder = null)



Get a pageable list of user prompts

The returned list is pageable, and query parameters can be used for filtering.  Multiple names can be specified, in which case all matching prompts will be returned, and no other filters will be evaluated.

Requires ANY permissions: 

* architect:userPrompt:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var name = new List<string>(); // List<string> | Name (optional) 
            var description = description_example;  // string | Description (optional) 
            var nameOrDescription = nameOrDescription_example;  // string | Name or description (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to id)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to asc)

            try
            { 
                // Get a pageable list of user prompts
                PromptEntityListing result = apiInstance.GetArchitectPrompts(pageNumber, pageSize, name, description, nameOrDescription, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectPrompts: " + e.Message );
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
| **name** | [**List<string>**](string.html)| Name | [optional]  |
| **description** | **string**| Description | [optional]  |
| **nameOrDescription** | **string**| Name or description | [optional]  |
| **sortBy** | **string**| Sort by | [optional] [default to id] |
| **sortOrder** | **string**| Sort order | [optional] [default to asc] |
{: class="table table-striped"}

### Return type

[**PromptEntityListing**](PromptEntityListing.html)

<a name="getarchitectschedule"></a>

## [**Schedule**](Schedule.html) GetArchitectSchedule (string scheduleId)



Get a schedule by ID



Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

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



Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

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



Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

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



Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

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



Requires ANY permissions: 

* architect:systemPrompt:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| promptId |  |
{: class="table table-striped"}

### Return type

[**SystemPrompt**](SystemPrompt.html)

<a name="getarchitectsystemprompthistoryhistoryid"></a>

## [**HistoryListing**](HistoryListing.html) GetArchitectSystempromptHistoryHistoryId (string promptId, string historyId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, string sortBy = null, List<string> action = null)



Get generated prompt history



Requires ANY permissions: 

* architect:systemPrompt:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectSystempromptHistoryHistoryIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | promptId
            var historyId = historyId_example;  // string | History request ID
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to desc)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to timestamp)
            var action = new List<string>(); // List<string> | Flow actions to include (omit to include all) (optional) 

            try
            { 
                // Get generated prompt history
                HistoryListing result = apiInstance.GetArchitectSystempromptHistoryHistoryId(promptId, historyId, pageNumber, pageSize, sortOrder, sortBy, action);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectSystempromptHistoryHistoryId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| promptId |  |
| **historyId** | **string**| History request ID |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortOrder** | **string**| Sort order | [optional] [default to desc] |
| **sortBy** | **string**| Sort by | [optional] [default to timestamp]<br />**Values**: action, timestamp, user |
| **action** | [**List<string>**](string.html)| Flow actions to include (omit to include all) | [optional] <br />**Values**: checkin, checkout, create, deactivate, debug, delete, publish, revert, save |
{: class="table table-striped"}

### Return type

[**HistoryListing**](HistoryListing.html)

<a name="getarchitectsystempromptresource"></a>

## [**SystemPromptAsset**](SystemPromptAsset.html) GetArchitectSystempromptResource (string promptId, string languageCode)



Get a system prompt resource.



Requires ANY permissions: 

* architect:systemPrompt:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

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



Requires ANY permissions: 

* architect:systemPrompt:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

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



Requires ANY permissions: 

* architect:systemPrompt:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

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



Requires ANY permissions: 

* architect:flow:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

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



Requires ANY permissions: 

* architect:flow:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var flowId = flowId_example;  // string | Flow ID
            var historyId = historyId_example;  // string | History request ID
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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowId** | **string**| Flow ID |  |
| **historyId** | **string**| History request ID |  |
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



Requires ANY permissions: 

* architect:flow:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

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



Requires ANY permissions: 

* architect:flow:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

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



Requires ANY permissions: 

* architect:flow:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

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



Requires ANY permissions: 

* architect:flow:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

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

## [**FlowEntityListing**](FlowEntityListing.html) GetFlows (List<string> type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string editableBy = null, string lockedBy = null, string secure = null, bool? deleted = null, bool? includeSchemas = null, string publishedAfter = null, string publishedBefore = null, List<string> divisionId = null)



Get a pageable list of flows, filtered by query parameters

If one or more IDs are specified, the search will fetch flows that match the given ID(s) and not use any additional supplied query parameters in the search.

Requires ANY permissions: 

* architect:flow:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var type = new List<string>(); // List<string> | Type (optional) 
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
            var divisionId = new List<string>(); // List<string> | division ID(s) (optional) 

            try
            { 
                // Get a pageable list of flows, filtered by query parameters
                FlowEntityListing result = apiInstance.GetFlows(type, pageNumber, pageSize, sortBy, sortOrder, id, name, description, nameOrDescription, publishVersionId, editableBy, lockedBy, secure, deleted, includeSchemas, publishedAfter, publishedBefore, divisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlows: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **type** | [**List<string>**](string.html)| Type | [optional] <br />**Values**: commonmodule, inboundcall, inboundchat, inboundemail, inboundshortmessage, outboundcall, inqueuecall, speech, securecall, surveyinvite |
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
| **divisionId** | [**List<string>**](string.html)| division ID(s) | [optional]  |
{: class="table table-striped"}

### Return type

[**FlowEntityListing**](FlowEntityListing.html)

<a name="getflowsdatatable"></a>

## [**DataTable**](DataTable.html) GetFlowsDatatable (string datatableId, string expand = null)



Returns a specific datatable by id

Given a datatableId returns the datatable object and schema associated with it.

Requires ANY permissions: 

* architect:datatable:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsDatatableExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var datatableId = datatableId_example;  // string | id of datatable
            var expand = expand_example;  // string | Expand instructions for the result (optional) 

            try
            { 
                // Returns a specific datatable by id
                DataTable result = apiInstance.GetFlowsDatatable(datatableId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsDatatable: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **datatableId** | **string**| id of datatable |  |
| **expand** | **string**| Expand instructions for the result | [optional] <br />**Values**: schema |
{: class="table table-striped"}

### Return type

[**DataTable**](DataTable.html)

<a name="getflowsdatatablerow"></a>

## **Dictionary&lt;string, Object&gt;** GetFlowsDatatableRow (string datatableId, string rowId, bool? showbrief = null)



Returns a specific row for the datatable

Given a datatableId and a rowId (the value of the key field) this will return the full row contents for that rowId.

Requires ANY permissions: 

* architect:datatable:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsDatatableRowExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var datatableId = datatableId_example;  // string | id of datatable
            var rowId = rowId_example;  // string | The key for the row
            var showbrief = true;  // bool? | if true returns just the key field for the row (optional)  (default to true)

            try
            { 
                // Returns a specific row for the datatable
                Dictionary&lt;string, Object&gt; result = apiInstance.GetFlowsDatatableRow(datatableId, rowId, showbrief);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsDatatableRow: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **datatableId** | **string**| id of datatable |  |
| **rowId** | **string**| The key for the row |  |
| **showbrief** | **bool?**| if true returns just the key field for the row | [optional] [default to true] |
{: class="table table-striped"}

### Return type

**Dictionary<string, Object>**

<a name="getflowsdatatablerows"></a>

## [**DataTableRowEntityListing**](DataTableRowEntityListing.html) GetFlowsDatatableRows (string datatableId, int? pageNumber = null, int? pageSize = null, bool? showbrief = null)



Returns the rows for the datatable with the given id

Returns all of the rows for the datatable with the given datatableId.  By default this will just be a truncated list returning the key for each row. Set showBrief to false to return all of the row contents.

Requires ANY permissions: 

* architect:datatable:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsDatatableRowsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var datatableId = datatableId_example;  // string | id of datatable
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var showbrief = true;  // bool? | If true returns just the key value of the row (optional)  (default to true)

            try
            { 
                // Returns the rows for the datatable with the given id
                DataTableRowEntityListing result = apiInstance.GetFlowsDatatableRows(datatableId, pageNumber, pageSize, showbrief);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsDatatableRows: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **datatableId** | **string**| id of datatable |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **showbrief** | **bool?**| If true returns just the key value of the row | [optional] [default to true] |
{: class="table table-striped"}

### Return type

[**DataTableRowEntityListing**](DataTableRowEntityListing.html)

<a name="getflowsdatatables"></a>

## [**DataTablesDomainEntityListing**](DataTablesDomainEntityListing.html) GetFlowsDatatables (string expand = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)



Retrieve a list of datatables for the org

Returns a metadata list of the datatables associated with this org, including datatableId, name and description.

Requires ANY permissions: 

* architect:datatable:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsDatatablesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var expand = expand_example;  // string | Expand instructions for the result (optional) 
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to id)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ascending)

            try
            { 
                // Retrieve a list of datatables for the org
                DataTablesDomainEntityListing result = apiInstance.GetFlowsDatatables(expand, pageNumber, pageSize, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsDatatables: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expand** | **string**| Expand instructions for the result | [optional] <br />**Values**: schema |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Sort by | [optional] [default to id]<br />**Values**: id, name |
| **sortOrder** | **string**| Sort order | [optional] [default to ascending] |
{: class="table table-striped"}

### Return type

[**DataTablesDomainEntityListing**](DataTablesDomainEntityListing.html)

<a name="getflowsdivisionviews"></a>

## [**FlowDivisionViewEntityListing**](FlowDivisionViewEntityListing.html) GetFlowsDivisionviews (List<string> type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string publishVersionId = null, string publishedAfter = null, string publishedBefore = null, List<string> divisionId = null)



Get a pageable list of basic flow information objects filterable by query parameters.

This returns a simplified version of /flow consisting of name and type. If one or more IDs are specified, the search will fetch flows that match the given ID(s) and not use any additional supplied query parameters in the search.

Requires ANY permissions: 

* architect:flow:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsDivisionviewsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var type = new List<string>(); // List<string> | Type (optional) 
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to id)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to asc)
            var id = new List<string>(); // List<string> | ID (optional) 
            var name = name_example;  // string | Name (optional) 
            var publishVersionId = publishVersionId_example;  // string | Publish version ID (optional) 
            var publishedAfter = 2015-01-01T12:00:00-0600, 2015-01-01T18:00:00Z, 2015-01-01T12:00:00.000-0600, 2015-01-01T18:00:00.000Z, 2015-01-01;  // string | Published after (optional) 
            var publishedBefore = 2015-01-01T12:00:00-0600, 2015-01-01T18:00:00Z, 2015-01-01T12:00:00.000-0600, 2015-01-01T18:00:00.000Z, 2015-01-01;  // string | Published before (optional) 
            var divisionId = new List<string>(); // List<string> | division ID(s) (optional) 

            try
            { 
                // Get a pageable list of basic flow information objects filterable by query parameters.
                FlowDivisionViewEntityListing result = apiInstance.GetFlowsDivisionviews(type, pageNumber, pageSize, sortBy, sortOrder, id, name, publishVersionId, publishedAfter, publishedBefore, divisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsDivisionviews: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **type** | [**List<string>**](string.html)| Type | [optional] <br />**Values**: commonmodule, inboundcall, inboundchat, inboundemail, inboundshortmessage, outboundcall, inqueuecall, speech, securecall, surveyinvite |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Sort by | [optional] [default to id] |
| **sortOrder** | **string**| Sort order | [optional] [default to asc] |
| **id** | [**List<string>**](string.html)| ID | [optional]  |
| **name** | **string**| Name | [optional]  |
| **publishVersionId** | **string**| Publish version ID | [optional]  |
| **publishedAfter** | **string**| Published after | [optional]  |
| **publishedBefore** | **string**| Published before | [optional]  |
| **divisionId** | [**List<string>**](string.html)| division ID(s) | [optional]  |
{: class="table table-striped"}

### Return type

[**FlowDivisionViewEntityListing**](FlowDivisionViewEntityListing.html)

<a name="getflowsoutcome"></a>

## [**FlowOutcome**](FlowOutcome.html) GetFlowsOutcome (string flowOutcomeId)



Get a flow outcome

Returns a specified flow outcome

Requires ANY permissions: 

* architect:flowOutcome:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsOutcomeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var flowOutcomeId = flowOutcomeId_example;  // string | flow outcome ID

            try
            { 
                // Get a flow outcome
                FlowOutcome result = apiInstance.GetFlowsOutcome(flowOutcomeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsOutcome: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowOutcomeId** | **string**| flow outcome ID |  |
{: class="table table-striped"}

### Return type

[**FlowOutcome**](FlowOutcome.html)

<a name="getflowsoutcomes"></a>

## [**FlowOutcomeListing**](FlowOutcomeListing.html) GetFlowsOutcomes (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null)



Get a pageable list of flow outcomes, filtered by query parameters

Multiple IDs can be specified, in which case all matching flow outcomes will be returned, and no other parameters will be evaluated.

Requires ANY permissions: 

* architect:flowOutcome:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsOutcomesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to id)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to asc)
            var id = new List<string>(); // List<string> | ID (optional) 
            var name = name_example;  // string | Name (optional) 
            var description = description_example;  // string | Description (optional) 
            var nameOrDescription = nameOrDescription_example;  // string | Name or description (optional) 

            try
            { 
                // Get a pageable list of flow outcomes, filtered by query parameters
                FlowOutcomeListing result = apiInstance.GetFlowsOutcomes(pageNumber, pageSize, sortBy, sortOrder, id, name, description, nameOrDescription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsOutcomes: " + e.Message );
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
| **sortBy** | **string**| Sort by | [optional] [default to id] |
| **sortOrder** | **string**| Sort order | [optional] [default to asc] |
| **id** | [**List<string>**](string.html)| ID | [optional]  |
| **name** | **string**| Name | [optional]  |
| **description** | **string**| Description | [optional]  |
| **nameOrDescription** | **string**| Name or description | [optional]  |
{: class="table table-striped"}

### Return type

[**FlowOutcomeListing**](FlowOutcomeListing.html)

<a name="postarchitectdependencytrackingbuild"></a>

## void PostArchitectDependencytrackingBuild ()



Rebuild Dependency Tracking data for an organization

Asynchronous.  Notification topic: v2.architect.dependencytracking.build

Requires ANY permissions: 

* architect:dependencyTracking:rebuild

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postarchitectemergencygroups"></a>

## [**EmergencyGroup**](EmergencyGroup.html) PostArchitectEmergencygroups (EmergencyGroup body)



Creates a new emergency group



Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostArchitectEmergencygroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var body = new EmergencyGroup(); // EmergencyGroup | 

            try
            { 
                // Creates a new emergency group
                EmergencyGroup result = apiInstance.PostArchitectEmergencygroups(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostArchitectEmergencygroups: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**EmergencyGroup**](EmergencyGroup.html)|  |  |
{: class="table table-striped"}

### Return type

[**EmergencyGroup**](EmergencyGroup.html)

<a name="postarchitectivrs"></a>

## [**IVR**](IVR.html) PostArchitectIvrs (IVR body)



Create IVR config.



Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var body = new IVR(); // IVR | 

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**IVR**](IVR.html)|  |  |
{: class="table table-striped"}

### Return type

[**IVR**](IVR.html)

<a name="postarchitectprompthistory"></a>

## [**Operation**](Operation.html) PostArchitectPromptHistory (string promptId)



Generate prompt history

Asynchronous.  Notification topic: v2.architect.prompts.{promptId}

Requires ANY permissions: 

* architect:userPrompt:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostArchitectPromptHistoryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID

            try
            { 
                // Generate prompt history
                Operation result = apiInstance.PostArchitectPromptHistory(promptId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostArchitectPromptHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
{: class="table table-striped"}

### Return type

[**Operation**](Operation.html)

<a name="postarchitectpromptresources"></a>

## [**PromptAsset**](PromptAsset.html) PostArchitectPromptResources (string promptId, PromptAssetCreate body)



Create a new user prompt resource



Requires ANY permissions: 

* architect:userPrompt:edit

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var body = new PromptAssetCreate(); // PromptAssetCreate | 

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **body** | [**PromptAssetCreate**](PromptAssetCreate.html)|  |  |
{: class="table table-striped"}

### Return type

[**PromptAsset**](PromptAsset.html)

<a name="postarchitectprompts"></a>

## [**Prompt**](Prompt.html) PostArchitectPrompts (Prompt body)



Create a new user prompt



Requires ANY permissions: 

* architect:userPrompt:add

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var body = new Prompt(); // Prompt | 

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Prompt**](Prompt.html)|  |  |
{: class="table table-striped"}

### Return type

[**Prompt**](Prompt.html)

<a name="postarchitectschedulegroups"></a>

## [**ScheduleGroup**](ScheduleGroup.html) PostArchitectSchedulegroups (ScheduleGroup body)



Creates a new schedule group



Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var body = new ScheduleGroup(); // ScheduleGroup | 

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ScheduleGroup**](ScheduleGroup.html)|  |  |
{: class="table table-striped"}

### Return type

[**ScheduleGroup**](ScheduleGroup.html)

<a name="postarchitectschedules"></a>

## [**Schedule**](Schedule.html) PostArchitectSchedules (Schedule body)



Create a new schedule.



Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var body = new Schedule(); // Schedule | 

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Schedule**](Schedule.html)|  |  |
{: class="table table-striped"}

### Return type

[**Schedule**](Schedule.html)

<a name="postarchitectsystemprompthistory"></a>

## [**Operation**](Operation.html) PostArchitectSystempromptHistory (string promptId)



Generate system prompt history

Asynchronous.  Notification topic: v2.architect.systemprompts.{systemPromptId}

Requires ANY permissions: 

* architect:systemPrompt:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostArchitectSystempromptHistoryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | promptId

            try
            { 
                // Generate system prompt history
                Operation result = apiInstance.PostArchitectSystempromptHistory(promptId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostArchitectSystempromptHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| promptId |  |
{: class="table table-striped"}

### Return type

[**Operation**](Operation.html)

<a name="postarchitectsystempromptresources"></a>

## [**SystemPromptAsset**](SystemPromptAsset.html) PostArchitectSystempromptResources (string promptId, SystemPromptAsset body)



Create system prompt resource override.



Requires ANY permissions: 

* architect:systemPrompt:edit

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var body = new SystemPromptAsset(); // SystemPromptAsset | 

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **body** | [**SystemPromptAsset**](SystemPromptAsset.html)|  |  |
{: class="table table-striped"}

### Return type

[**SystemPromptAsset**](SystemPromptAsset.html)

<a name="postflowversions"></a>

## [**FlowVersion**](FlowVersion.html) PostFlowVersions (string flowId, Object body)



Create flow version



Requires ANY permissions: 

* architect:flow:edit

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var flowId = flowId_example;  // string | Flow ID
            var body = ;  // Object | 

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowId** | **string**| Flow ID |  |
| **body** | **Object**|  |  |
{: class="table table-striped"}

### Return type

[**FlowVersion**](FlowVersion.html)

<a name="postflows"></a>

## [**Flow**](Flow.html) PostFlows (Flow body)



Create flow



Requires ANY permissions: 

* architect:flow:add

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var body = new Flow(); // Flow | 

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Flow**](Flow.html)|  |  |
{: class="table table-striped"}

### Return type

[**Flow**](Flow.html)

<a name="postflowsactionscheckin"></a>

## [**Operation**](Operation.html) PostFlowsActionsCheckin (string flow)



Check-in flow

Asynchronous.  Notification topic: v2.flows.{flowId}

Requires ANY permissions: 

* architect:flow:edit
* architect:flow:unlock

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var flow = flow_example;  // string | Flow ID

            try
            { 
                // Check-in flow
                Operation result = apiInstance.PostFlowsActionsCheckin(flow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlowsActionsCheckin: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flow** | **string**| Flow ID |  |
{: class="table table-striped"}

### Return type

[**Operation**](Operation.html)

<a name="postflowsactionscheckout"></a>

## [**Flow**](Flow.html) PostFlowsActionsCheckout (string flow)



Check-out flow



Requires ANY permissions: 

* architect:flow:edit

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

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



Requires ANY permissions: 

* architect:flow:publish

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

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

Requires ANY permissions: 

* architect:flow:unlock
* architect:flow:publish

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

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



Requires ANY permissions: 

* architect:flow:edit

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

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

Requires ANY permissions: 

* architect:flow:unlock

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flow** | **string**| Flow ID |  |
{: class="table table-striped"}

### Return type

[**Flow**](Flow.html)

<a name="postflowsdatatablerows"></a>

## **Dictionary&lt;string, Object&gt;** PostFlowsDatatableRows (string datatableId, Object dataTableRow)



Create a new row entry for the datatable.

Will add the passed in row entry to the datatable with the given datatableId after verifying it against the schema.  The DataTableRow should be a json-ized' stream of key -> value pairs {      \"Field1\": \"XYZZY\",      \"Field2\": false,      \"KEY\": \"27272\"  }

Requires ANY permissions: 

* architect:datatable:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowsDatatableRowsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var datatableId = datatableId_example;  // string | id of datatable
            var dataTableRow = ;  // Object | 

            try
            { 
                // Create a new row entry for the datatable.
                Dictionary&lt;string, Object&gt; result = apiInstance.PostFlowsDatatableRows(datatableId, dataTableRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlowsDatatableRows: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **datatableId** | **string**| id of datatable |  |
| **dataTableRow** | **Object**|  |  |
{: class="table table-striped"}

### Return type

**Dictionary<string, Object>**

<a name="postflowsdatatables"></a>

## [**DataTable**](DataTable.html) PostFlowsDatatables (DataTable body)



Create a new datatable with the specified json-schema definition

This will create a new datatable with fields that match the property definitions in the JSON schema.  The schema's title field will be overridden by the name field in the DataTable object.  See also http://json-schema.org/

Requires ANY permissions: 

* architect:datatable:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowsDatatablesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var body = new DataTable(); // DataTable | datatable json-schema

            try
            { 
                // Create a new datatable with the specified json-schema definition
                DataTable result = apiInstance.PostFlowsDatatables(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlowsDatatables: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DataTable**](DataTable.html)| datatable json-schema |  |
{: class="table table-striped"}

### Return type

[**DataTable**](DataTable.html)

<a name="postflowsoutcomes"></a>

## [**FlowOutcome**](FlowOutcome.html) PostFlowsOutcomes (FlowOutcome body = null)



Create a flow outcome

Asynchronous.  Notification topic: v2.flows.outcomes.{flowOutcomeId}

Requires ANY permissions: 

* architect:flowOutcome:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowsOutcomesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var body = new FlowOutcome(); // FlowOutcome |  (optional) 

            try
            { 
                // Create a flow outcome
                FlowOutcome result = apiInstance.PostFlowsOutcomes(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlowsOutcomes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**FlowOutcome**](FlowOutcome.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**FlowOutcome**](FlowOutcome.html)

<a name="putarchitectemergencygroup"></a>

## [**EmergencyGroup**](EmergencyGroup.html) PutArchitectEmergencygroup (string emergencyGroupId, EmergencyGroup body)



Updates a emergency group by ID



Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutArchitectEmergencygroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var emergencyGroupId = emergencyGroupId_example;  // string | Emergency group ID
            var body = new EmergencyGroup(); // EmergencyGroup | 

            try
            { 
                // Updates a emergency group by ID
                EmergencyGroup result = apiInstance.PutArchitectEmergencygroup(emergencyGroupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PutArchitectEmergencygroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emergencyGroupId** | **string**| Emergency group ID |  |
| **body** | [**EmergencyGroup**](EmergencyGroup.html)|  |  |
{: class="table table-striped"}

### Return type

[**EmergencyGroup**](EmergencyGroup.html)

<a name="putarchitectivr"></a>

## [**IVR**](IVR.html) PutArchitectIvr (string ivrId, IVR body)



Update an IVR Config.



Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var ivrId = ivrId_example;  // string | IVR id
            var body = new IVR(); // IVR | 

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ivrId** | **string**| IVR id |  |
| **body** | [**IVR**](IVR.html)|  |  |
{: class="table table-striped"}

### Return type

[**IVR**](IVR.html)

<a name="putarchitectprompt"></a>

## [**Prompt**](Prompt.html) PutArchitectPrompt (string promptId, Prompt body)



Update specified user prompt



Requires ANY permissions: 

* architect:userPrompt:edit

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var body = new Prompt(); // Prompt | 

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **body** | [**Prompt**](Prompt.html)|  |  |
{: class="table table-striped"}

### Return type

[**Prompt**](Prompt.html)

<a name="putarchitectpromptresource"></a>

## [**PromptAsset**](PromptAsset.html) PutArchitectPromptResource (string promptId, string languageCode, PromptAsset body)



Update specified user prompt resource



Requires ANY permissions: 

* architect:userPrompt:edit

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var languageCode = languageCode_example;  // string | Language
            var body = new PromptAsset(); // PromptAsset | 

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **languageCode** | **string**| Language |  |
| **body** | [**PromptAsset**](PromptAsset.html)|  |  |
{: class="table table-striped"}

### Return type

[**PromptAsset**](PromptAsset.html)

<a name="putarchitectschedule"></a>

## [**Schedule**](Schedule.html) PutArchitectSchedule (string scheduleId, Schedule body)



Update schedule by ID



Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var scheduleId = scheduleId_example;  // string | Schedule ID
            var body = new Schedule(); // Schedule | 

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleId** | **string**| Schedule ID |  |
| **body** | [**Schedule**](Schedule.html)|  |  |
{: class="table table-striped"}

### Return type

[**Schedule**](Schedule.html)

<a name="putarchitectschedulegroup"></a>

## [**ScheduleGroup**](ScheduleGroup.html) PutArchitectSchedulegroup (string scheduleGroupId, ScheduleGroup body)



Updates a schedule group by ID



Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var scheduleGroupId = scheduleGroupId_example;  // string | Schedule group ID
            var body = new ScheduleGroup(); // ScheduleGroup | 

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleGroupId** | **string**| Schedule group ID |  |
| **body** | [**ScheduleGroup**](ScheduleGroup.html)|  |  |
{: class="table table-striped"}

### Return type

[**ScheduleGroup**](ScheduleGroup.html)

<a name="putarchitectsystempromptresource"></a>

## [**SystemPromptAsset**](SystemPromptAsset.html) PutArchitectSystempromptResource (string promptId, string languageCode, SystemPromptAsset body)



Updates a system prompt resource override.



Requires ANY permissions: 

* architect:systemPrompt:edit

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var languageCode = languageCode_example;  // string | Language
            var body = new SystemPromptAsset(); // SystemPromptAsset | 

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **languageCode** | **string**| Language |  |
| **body** | [**SystemPromptAsset**](SystemPromptAsset.html)|  |  |
{: class="table table-striped"}

### Return type

[**SystemPromptAsset**](SystemPromptAsset.html)

<a name="putflow"></a>

## [**Flow**](Flow.html) PutFlow (string flowId, Flow body)



Update flow



Requires ANY permissions: 

* architect:flow:edit

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var flowId = flowId_example;  // string | Flow ID
            var body = new Flow(); // Flow | 

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowId** | **string**| Flow ID |  |
| **body** | [**Flow**](Flow.html)|  |  |
{: class="table table-striped"}

### Return type

[**Flow**](Flow.html)

<a name="putflowsdatatable"></a>

## [**DataTable**](DataTable.html) PutFlowsDatatable (string datatableId, string expand = null, DataTable body = null)



Updates a specific datatable by id

Updates a schema for a datatable with the given datatableId -updates allow only new fields to be added in the schema, no changes or removals of existing fields.

Requires ANY permissions: 

* architect:datatable:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutFlowsDatatableExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var datatableId = datatableId_example;  // string | id of datatable
            var expand = expand_example;  // string | Expand instructions for the result (optional) 
            var body = new DataTable(); // DataTable | datatable json-schema (optional) 

            try
            { 
                // Updates a specific datatable by id
                DataTable result = apiInstance.PutFlowsDatatable(datatableId, expand, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PutFlowsDatatable: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **datatableId** | **string**| id of datatable |  |
| **expand** | **string**| Expand instructions for the result | [optional] <br />**Values**: schema |
| **body** | [**DataTable**](DataTable.html)| datatable json-schema | [optional]  |
{: class="table table-striped"}

### Return type

[**DataTable**](DataTable.html)

<a name="putflowsdatatablerow"></a>

## **Dictionary&lt;string, Object&gt;** PutFlowsDatatableRow (string datatableId, string rowId, Object body = null)



Update a row entry

Updates a row with the given rowId (the value of the key field) to the new values.  The DataTableRow should be a json-ized' stream of key -> value pairs {     \"Field1\": \"XYZZY\",     \"Field2\": false,     \"KEY\": \"27272\" }

Requires ANY permissions: 

* architect:datatable:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutFlowsDatatableRowExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var datatableId = datatableId_example;  // string | id of datatable
            var rowId = rowId_example;  // string | the key for the row
            var body = ;  // Object | datatable row (optional) 

            try
            { 
                // Update a row entry
                Dictionary&lt;string, Object&gt; result = apiInstance.PutFlowsDatatableRow(datatableId, rowId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PutFlowsDatatableRow: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **datatableId** | **string**| id of datatable |  |
| **rowId** | **string**| the key for the row |  |
| **body** | **Object**| datatable row | [optional]  |
{: class="table table-striped"}

### Return type

**Dictionary<string, Object>**

<a name="putflowsoutcome"></a>

## [**Operation**](Operation.html) PutFlowsOutcome (string flowOutcomeId, FlowOutcome body = null)



Updates a flow outcome

Updates a flow outcome.  Asynchronous.  Notification topic: v2.flowoutcomes.{flowoutcomeId}

Requires ANY permissions: 

* architect:flowOutcome:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutFlowsOutcomeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchitectApi();
            var flowOutcomeId = flowOutcomeId_example;  // string | flow outcome ID
            var body = new FlowOutcome(); // FlowOutcome |  (optional) 

            try
            { 
                // Updates a flow outcome
                Operation result = apiInstance.PutFlowsOutcome(flowOutcomeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PutFlowsOutcome: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowOutcomeId** | **string**| flow outcome ID |  |
| **body** | [**FlowOutcome**](FlowOutcome.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**Operation**](Operation.html)

