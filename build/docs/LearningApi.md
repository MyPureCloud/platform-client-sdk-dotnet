---
title: LearningApi
---
## PureCloudPlatform.Client.V2.Api.LearningApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteLearningAssignment**](LearningApi.html#deletelearningassignment) | **Delete** /api/v2/learning/assignments/{assignmentId} | Delete a learning assignment |
| [**DeleteLearningModule**](LearningApi.html#deletelearningmodule) | **Delete** /api/v2/learning/modules/{moduleId} | Delete a learning module |
| [**GetLearningAssignment**](LearningApi.html#getlearningassignment) | **Get** /api/v2/learning/assignments/{assignmentId} | Get Learning Assignment |
| [**GetLearningAssignmentStep**](LearningApi.html#getlearningassignmentstep) | **Get** /api/v2/learning/assignments/{assignmentId}/steps/{stepId} | Get Learning Assignment Step |
| [**GetLearningAssignments**](LearningApi.html#getlearningassignments) | **Get** /api/v2/learning/assignments | List of Learning module Assignments |
| [**GetLearningAssignmentsMe**](LearningApi.html#getlearningassignmentsme) | **Get** /api/v2/learning/assignments/me | List of Learning Assignments assigned to current user |
| [**GetLearningModule**](LearningApi.html#getlearningmodule) | **Get** /api/v2/learning/modules/{moduleId} | Get a learning module |
| [**GetLearningModuleJob**](LearningApi.html#getlearningmodulejob) | **Get** /api/v2/learning/modules/{moduleId}/jobs/{jobId} | Get a specific Learning Module job status |
| [**GetLearningModulePreview**](LearningApi.html#getlearningmodulepreview) | **Get** /api/v2/learning/modules/{moduleId}/preview | Get a learning module preview |
| [**GetLearningModuleRule**](LearningApi.html#getlearningmodulerule) | **Get** /api/v2/learning/modules/{moduleId}/rule | Get a learning module rule |
| [**GetLearningModuleVersion**](LearningApi.html#getlearningmoduleversion) | **Get** /api/v2/learning/modules/{moduleId}/versions/{versionId} | Get specific version of a published module |
| [**GetLearningModules**](LearningApi.html#getlearningmodules) | **Get** /api/v2/learning/modules | Get all learning modules of an organization |
| [**GetLearningModulesAssignments**](LearningApi.html#getlearningmodulesassignments) | **Get** /api/v2/learning/modules/assignments | Get all learning modules of an organization including assignments for a specific user |
| [**GetLearningModulesCoverartCoverArtId**](LearningApi.html#getlearningmodulescoverartcoverartid) | **Get** /api/v2/learning/modules/coverart/{coverArtId} | Get a specific Learning Module cover art using ID |
| [**GetLearningScormScormId**](LearningApi.html#getlearningscormscormid) | **Get** /api/v2/learning/scorm/{scormId} | Get Learning SCORM Result |
| [**PatchLearningAssignment**](LearningApi.html#patchlearningassignment) | **Patch** /api/v2/learning/assignments/{assignmentId} | Update Learning Assignment |
| [**PatchLearningAssignmentReschedule**](LearningApi.html#patchlearningassignmentreschedule) | **Patch** /api/v2/learning/assignments/{assignmentId}/reschedule | Reschedule Learning Assignment |
| [**PatchLearningAssignmentStep**](LearningApi.html#patchlearningassignmentstep) | **Patch** /api/v2/learning/assignments/{assignmentId}/steps/{stepId} | Update Learning Assignment Step |
| [**PatchLearningModuleUserAssignments**](LearningApi.html#patchlearningmoduleuserassignments) | **Patch** /api/v2/learning/modules/{moduleId}/users/{userId}/assignments | Update an external assignment for a specific user |
| [**PostLearningAssessmentsScoring**](LearningApi.html#postlearningassessmentsscoring) | **Post** /api/v2/learning/assessments/scoring | Score learning assessment for preview |
| [**PostLearningAssignmentReassign**](LearningApi.html#postlearningassignmentreassign) | **Post** /api/v2/learning/assignments/{assignmentId}/reassign | Reassign Learning Assignment |
| [**PostLearningAssignmentReset**](LearningApi.html#postlearningassignmentreset) | **Post** /api/v2/learning/assignments/{assignmentId}/reset | Reset Learning Assignment |
| [**PostLearningAssignments**](LearningApi.html#postlearningassignments) | **Post** /api/v2/learning/assignments | Create Learning Assignment |
| [**PostLearningAssignmentsAggregatesQuery**](LearningApi.html#postlearningassignmentsaggregatesquery) | **Post** /api/v2/learning/assignments/aggregates/query | Retrieve aggregated assignment data |
| [**PostLearningAssignmentsBulkadd**](LearningApi.html#postlearningassignmentsbulkadd) | **Post** /api/v2/learning/assignments/bulkadd | Add multiple learning assignments |
| [**PostLearningAssignmentsBulkremove**](LearningApi.html#postlearningassignmentsbulkremove) | **Post** /api/v2/learning/assignments/bulkremove | Remove multiple Learning Assignments |
| [**PostLearningModuleJobs**](LearningApi.html#postlearningmodulejobs) | **Post** /api/v2/learning/modules/{moduleId}/jobs | Starts a specified operation on learning module |
| [**PostLearningModulePublish**](LearningApi.html#postlearningmodulepublish) | **Post** /api/v2/learning/modules/{moduleId}/publish | Publish a Learning module |
| [**PostLearningModules**](LearningApi.html#postlearningmodules) | **Post** /api/v2/learning/modules | Create a new learning module |
| [**PostLearningRulesQuery**](LearningApi.html#postlearningrulesquery) | **Post** /api/v2/learning/rules/query | Get users for learning module rule |
| [**PostLearningScheduleslotsQuery**](LearningApi.html#postlearningscheduleslotsquery) | **Post** /api/v2/learning/scheduleslots/query | Get list of possible slots where a learning activity can be scheduled. |
| [**PostLearningScorm**](LearningApi.html#postlearningscorm) | **Post** /api/v2/learning/scorm | Create a SCORM package upload request |
| [**PutLearningModule**](LearningApi.html#putlearningmodule) | **Put** /api/v2/learning/modules/{moduleId} | Update a learning module |
| [**PutLearningModulePreview**](LearningApi.html#putlearningmodulepreview) | **Put** /api/v2/learning/modules/{moduleId}/preview | Update a learning module preview |
| [**PutLearningModuleRule**](LearningApi.html#putlearningmodulerule) | **Put** /api/v2/learning/modules/{moduleId}/rule | Update a learning module rule |
{: class="table table-striped"}

<a name="deletelearningassignment"></a>

## void DeleteLearningAssignment (string assignmentId)



Delete a learning assignment

Requires ANY permissions: 

* learning:assignment:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteLearningAssignmentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var assignmentId = assignmentId_example;  // string | The Learning Assignment ID

            try
            { 
                // Delete a learning assignment
                apiInstance.DeleteLearningAssignment(assignmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.DeleteLearningAssignment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **assignmentId** | **string**| The Learning Assignment ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletelearningmodule"></a>

## void DeleteLearningModule (string moduleId)



Delete a learning module

This will delete a learning module if it is unpublished or it will delete a published and archived learning module

Requires ANY permissions: 

* learning:module:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteLearningModuleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var moduleId = moduleId_example;  // string | The ID of the learning module

            try
            { 
                // Delete a learning module
                apiInstance.DeleteLearningModule(moduleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.DeleteLearningModule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **moduleId** | **string**| The ID of the learning module |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getlearningassignment"></a>

## [**LearningAssignment**](LearningAssignment.html) GetLearningAssignment (string assignmentId, List<string> expand = null)



Get Learning Assignment

Permission not required if you are the assigned user of the learning assignment

Requires ANY permissions: 

* learning:assignment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLearningAssignmentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var assignmentId = assignmentId_example;  // string | The ID of Learning Assignment
            var expand = new List<string>(); // List<string> | Fields to expand in response (optional) 

            try
            { 
                // Get Learning Assignment
                LearningAssignment result = apiInstance.GetLearningAssignment(assignmentId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.GetLearningAssignment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **assignmentId** | **string**| The ID of Learning Assignment |  |
| **expand** | [**List<string>**](string.html)| Fields to expand in response | [optional] <br />**Values**: module, assessment, assessmentForm, module.coverArt, step, step.moduleStep |
{: class="table table-striped"}

### Return type

[**LearningAssignment**](LearningAssignment.html)

<a name="getlearningassignmentstep"></a>

## [**LearningAssignmentStep**](LearningAssignmentStep.html) GetLearningAssignmentStep (string assignmentId, string stepId, string shareableContentObjectId = null, string defaultShareableContentObject = null, List<string> expand = null)



Get Learning Assignment Step

Permission not required if you are the assigned user of the learning assignment

Requires ANY permissions: 

* learning:assignment:viewOwn

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLearningAssignmentStepExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var assignmentId = assignmentId_example;  // string | The ID of Learning Assignment
            var stepId = stepId_example;  // string | The ID of Learning Assignment Step
            var shareableContentObjectId = shareableContentObjectId_example;  // string | The ID of SCO to load (optional) 
            var defaultShareableContentObject = defaultShareableContentObject_example;  // string | The default SCO to retrieve (optional) 
            var expand = new List<string>(); // List<string> | Fields to expand in response (optional) 

            try
            { 
                // Get Learning Assignment Step
                LearningAssignmentStep result = apiInstance.GetLearningAssignmentStep(assignmentId, stepId, shareableContentObjectId, defaultShareableContentObject, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.GetLearningAssignmentStep: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **assignmentId** | **string**| The ID of Learning Assignment |  |
| **stepId** | **string**| The ID of Learning Assignment Step |  |
| **shareableContentObjectId** | **string**| The ID of SCO to load | [optional]  |
| **defaultShareableContentObject** | **string**| The default SCO to retrieve | [optional] <br />**Values**: First, Last, Next |
| **expand** | [**List<string>**](string.html)| Fields to expand in response | [optional] <br />**Values**: moduleStep |
{: class="table table-striped"}

### Return type

[**LearningAssignmentStep**](LearningAssignmentStep.html)

<a name="getlearningassignments"></a>

## [**LearningAssignmentsDomainEntity**](LearningAssignmentsDomainEntity.html) GetLearningAssignments (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string pass = null, float? minPercentageScore = null, float? maxPercentageScore = null, string sortOrder = null, string sortBy = null, List<string> userId = null, List<string> types = null, List<string> states = null, List<string> expand = null)



List of Learning module Assignments

Either moduleId or user value is required

Requires ANY permissions: 

* learning:assignment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLearningAssignmentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var moduleId = moduleId_example;  // string | Specifies the ID of the learning module. Fetch assignments for learning module ID (optional) 
            var interval = interval_example;  // string | Specifies the range of dueDates to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional) 
            var completionInterval = completionInterval_example;  // string | Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional) 
            var overdue = overdue_example;  // string | Specifies if only the non-overdue (overdue is \"False\") or overdue (overdue is \"True\") assignments are returned. If overdue is \"Any\" or if the overdue parameter is not supplied, all assignments are returned (optional)  (default to Any)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pass = pass_example;  // string | Specifies if only the failed (pass is \"False\") or passed (pass is \"True\") assignments (completed with assessment)are returned. If pass is \"Any\" or if the pass parameter is not supplied, all assignments are returned (optional)  (default to Any)
            var minPercentageScore = 3.4F;  // float? | The minimum assessment score for an assignment (completed with assessment) to be included in the results (inclusive) (optional) 
            var maxPercentageScore = 3.4F;  // float? | The maximum assessment score for an assignment (completed with assessment) to be included in the results (inclusive) (optional) 
            var sortOrder = sortOrder_example;  // string | Specifies result set sort order; if not specified, default sort order is descending (Desc) (optional)  (default to Desc)
            var sortBy = sortBy_example;  // string | Specifies which field to sort the results by, default sort is by recommendedCompletionDate (optional) 
            var userId = new List<string>(); // List<string> | Specifies the list of user IDs to be queried, up to 100 user IDs. (optional) 
            var types = new List<string>(); // List<string> | Specifies the module types to filter by. Informational, AssessedContent and Assessment are deprecated (optional) 
            var states = new List<string>(); // List<string> | Specifies the assignment states to filter by (optional) 
            var expand = new List<string>(); // List<string> | Specifies the expand option for returning additional information (optional) 

            try
            { 
                // List of Learning module Assignments
                LearningAssignmentsDomainEntity result = apiInstance.GetLearningAssignments(moduleId, interval, completionInterval, overdue, pageSize, pageNumber, pass, minPercentageScore, maxPercentageScore, sortOrder, sortBy, userId, types, states, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.GetLearningAssignments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **moduleId** | **string**| Specifies the ID of the learning module. Fetch assignments for learning module ID | [optional]  |
| **interval** | **string**| Specifies the range of dueDates to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional]  |
| **completionInterval** | **string**| Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional]  |
| **overdue** | **string**| Specifies if only the non-overdue (overdue is \&quot;False\&quot;) or overdue (overdue is \&quot;True\&quot;) assignments are returned. If overdue is \&quot;Any\&quot; or if the overdue parameter is not supplied, all assignments are returned | [optional] [default to Any]<br />**Values**: True, False, Any |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pass** | **string**| Specifies if only the failed (pass is \&quot;False\&quot;) or passed (pass is \&quot;True\&quot;) assignments (completed with assessment)are returned. If pass is \&quot;Any\&quot; or if the pass parameter is not supplied, all assignments are returned | [optional] [default to Any]<br />**Values**: True, False, Any |
| **minPercentageScore** | **float?**| The minimum assessment score for an assignment (completed with assessment) to be included in the results (inclusive) | [optional]  |
| **maxPercentageScore** | **float?**| The maximum assessment score for an assignment (completed with assessment) to be included in the results (inclusive) | [optional]  |
| **sortOrder** | **string**| Specifies result set sort order; if not specified, default sort order is descending (Desc) | [optional] [default to Desc]<br />**Values**: Asc, Desc |
| **sortBy** | **string**| Specifies which field to sort the results by, default sort is by recommendedCompletionDate | [optional] <br />**Values**: RecommendedCompletionDate, DateModified |
| **userId** | [**List<string>**](string.html)| Specifies the list of user IDs to be queried, up to 100 user IDs. | [optional]  |
| **types** | [**List<string>**](string.html)| Specifies the module types to filter by. Informational, AssessedContent and Assessment are deprecated | [optional] <br />**Values**: Informational, AssessedContent, Assessment, External, Native |
| **states** | [**List<string>**](string.html)| Specifies the assignment states to filter by | [optional] <br />**Values**: Assigned, InProgress, Completed, NotCompleted, InvalidSchedule |
| **expand** | [**List<string>**](string.html)| Specifies the expand option for returning additional information | [optional] <br />**Values**: ModuleSummary |
{: class="table table-striped"}

### Return type

[**LearningAssignmentsDomainEntity**](LearningAssignmentsDomainEntity.html)

<a name="getlearningassignmentsme"></a>

## [**LearningAssignmentsDomainEntity**](LearningAssignmentsDomainEntity.html) GetLearningAssignmentsMe (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string pass = null, float? minPercentageScore = null, float? maxPercentageScore = null, string sortOrder = null, string sortBy = null, List<string> types = null, List<string> states = null, List<string> expand = null)



List of Learning Assignments assigned to current user

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLearningAssignmentsMeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var moduleId = moduleId_example;  // string | Specifies the ID of the learning module. Fetch assignments for learning module ID (optional) 
            var interval = interval_example;  // string | Specifies the range of dueDates to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional) 
            var completionInterval = completionInterval_example;  // string | Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional) 
            var overdue = overdue_example;  // string | Specifies if only the non-overdue (overdue is \"False\") or overdue (overdue is \"True\") assignments are returned. If overdue is \"Any\" or if the overdue parameter is not supplied, all assignments are returned (optional)  (default to Any)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pass = pass_example;  // string | Specifies if only the failed (pass is \"False\") or passed (pass is \"True\") assignments (completed with assessment)are returned. If pass is \"Any\" or if the pass parameter is not supplied, all assignments are returned (optional)  (default to Any)
            var minPercentageScore = 3.4F;  // float? | The minimum assessment score for an assignment (completed with assessment) to be included in the results (inclusive) (optional) 
            var maxPercentageScore = 3.4F;  // float? | The maximum assessment score for an assignment (completed with assessment) to be included in the results (inclusive) (optional) 
            var sortOrder = sortOrder_example;  // string | Specifies result set sort order; if not specified, default sort order is descending (Desc) (optional)  (default to Desc)
            var sortBy = sortBy_example;  // string | Specifies which field to sort the results by, default sort is by recommendedCompletionDate (optional) 
            var types = new List<string>(); // List<string> | Specifies the module types to filter by. Informational, AssessedContent and Assessment are deprecated (optional) 
            var states = new List<string>(); // List<string> | Specifies the assignment states to filter by (optional) 
            var expand = new List<string>(); // List<string> | Specifies the expand option for returning additional information (optional) 

            try
            { 
                // List of Learning Assignments assigned to current user
                LearningAssignmentsDomainEntity result = apiInstance.GetLearningAssignmentsMe(moduleId, interval, completionInterval, overdue, pageSize, pageNumber, pass, minPercentageScore, maxPercentageScore, sortOrder, sortBy, types, states, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.GetLearningAssignmentsMe: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **moduleId** | **string**| Specifies the ID of the learning module. Fetch assignments for learning module ID | [optional]  |
| **interval** | **string**| Specifies the range of dueDates to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional]  |
| **completionInterval** | **string**| Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional]  |
| **overdue** | **string**| Specifies if only the non-overdue (overdue is \&quot;False\&quot;) or overdue (overdue is \&quot;True\&quot;) assignments are returned. If overdue is \&quot;Any\&quot; or if the overdue parameter is not supplied, all assignments are returned | [optional] [default to Any]<br />**Values**: True, False, Any |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pass** | **string**| Specifies if only the failed (pass is \&quot;False\&quot;) or passed (pass is \&quot;True\&quot;) assignments (completed with assessment)are returned. If pass is \&quot;Any\&quot; or if the pass parameter is not supplied, all assignments are returned | [optional] [default to Any]<br />**Values**: True, False, Any |
| **minPercentageScore** | **float?**| The minimum assessment score for an assignment (completed with assessment) to be included in the results (inclusive) | [optional]  |
| **maxPercentageScore** | **float?**| The maximum assessment score for an assignment (completed with assessment) to be included in the results (inclusive) | [optional]  |
| **sortOrder** | **string**| Specifies result set sort order; if not specified, default sort order is descending (Desc) | [optional] [default to Desc]<br />**Values**: Asc, Desc |
| **sortBy** | **string**| Specifies which field to sort the results by, default sort is by recommendedCompletionDate | [optional] <br />**Values**: RecommendedCompletionDate, DateModified |
| **types** | [**List<string>**](string.html)| Specifies the module types to filter by. Informational, AssessedContent and Assessment are deprecated | [optional] <br />**Values**: Informational, AssessedContent, Assessment, External, Native |
| **states** | [**List<string>**](string.html)| Specifies the assignment states to filter by | [optional] <br />**Values**: Assigned, InProgress, Completed, NotCompleted, InvalidSchedule |
| **expand** | [**List<string>**](string.html)| Specifies the expand option for returning additional information | [optional] <br />**Values**: ModuleSummary |
{: class="table table-striped"}

### Return type

[**LearningAssignmentsDomainEntity**](LearningAssignmentsDomainEntity.html)

<a name="getlearningmodule"></a>

## [**LearningModule**](LearningModule.html) GetLearningModule (string moduleId, List<string> expand = null)



Get a learning module

Requires ANY permissions: 

* learning:module:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLearningModuleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var moduleId = moduleId_example;  // string | The ID of the learning module
            var expand = new List<string>(); // List<string> | Fields to expand in response(case insensitive) (optional) 

            try
            { 
                // Get a learning module
                LearningModule result = apiInstance.GetLearningModule(moduleId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.GetLearningModule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **moduleId** | **string**| The ID of the learning module |  |
| **expand** | [**List<string>**](string.html)| Fields to expand in response(case insensitive) | [optional] <br />**Values**: assessmentForm, coverArt |
{: class="table table-striped"}

### Return type

[**LearningModule**](LearningModule.html)

<a name="getlearningmodulejob"></a>

## [**LearningModuleJobResponse**](LearningModuleJobResponse.html) GetLearningModuleJob (string moduleId, string jobId)



Get a specific Learning Module job status

Requires ANY permissions: 

* learning:module:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLearningModuleJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var moduleId = moduleId_example;  // string | The ID of the learning module
            var jobId = jobId_example;  // string | The ID of the learning module job

            try
            { 
                // Get a specific Learning Module job status
                LearningModuleJobResponse result = apiInstance.GetLearningModuleJob(moduleId, jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.GetLearningModuleJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **moduleId** | **string**| The ID of the learning module |  |
| **jobId** | **string**| The ID of the learning module job |  |
{: class="table table-striped"}

### Return type

[**LearningModuleJobResponse**](LearningModuleJobResponse.html)

<a name="getlearningmodulepreview"></a>

## [**LearningModulePreviewGetResponse**](LearningModulePreviewGetResponse.html) GetLearningModulePreview (string moduleId)



Get a learning module preview

Requires ANY permissions: 

* learning:module:preview

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLearningModulePreviewExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var moduleId = moduleId_example;  // string | The ID of the learning module

            try
            { 
                // Get a learning module preview
                LearningModulePreviewGetResponse result = apiInstance.GetLearningModulePreview(moduleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.GetLearningModulePreview: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **moduleId** | **string**| The ID of the learning module |  |
{: class="table table-striped"}

### Return type

[**LearningModulePreviewGetResponse**](LearningModulePreviewGetResponse.html)

<a name="getlearningmodulerule"></a>

## [**LearningModuleRule**](LearningModuleRule.html) GetLearningModuleRule (string moduleId)



Get a learning module rule

Requires ANY permissions: 

* learning:rule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLearningModuleRuleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var moduleId = moduleId_example;  // string | The ID of the learning module

            try
            { 
                // Get a learning module rule
                LearningModuleRule result = apiInstance.GetLearningModuleRule(moduleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.GetLearningModuleRule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **moduleId** | **string**| The ID of the learning module |  |
{: class="table table-striped"}

### Return type

[**LearningModuleRule**](LearningModuleRule.html)

<a name="getlearningmoduleversion"></a>

## [**LearningModule**](LearningModule.html) GetLearningModuleVersion (string moduleId, string versionId, List<string> expand = null)



Get specific version of a published module

Requires ANY permissions: 

* learning:module:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLearningModuleVersionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var moduleId = moduleId_example;  // string | The ID of the learning module
            var versionId = versionId_example;  // string | The version of learning module
            var expand = new List<string>(); // List<string> | Fields to expand in response(case insensitive) (optional) 

            try
            { 
                // Get specific version of a published module
                LearningModule result = apiInstance.GetLearningModuleVersion(moduleId, versionId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.GetLearningModuleVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **moduleId** | **string**| The ID of the learning module |  |
| **versionId** | **string**| The version of learning module |  |
| **expand** | [**List<string>**](string.html)| Fields to expand in response(case insensitive) | [optional] <br />**Values**: assessmentForm, coverArt |
{: class="table table-striped"}

### Return type

[**LearningModule**](LearningModule.html)

<a name="getlearningmodules"></a>

## [**LearningModulesDomainEntityListing**](LearningModulesDomainEntityListing.html) GetLearningModules (bool? isArchived = null, List<string> types = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, string searchTerm = null, List<string> expand = null, string isPublished = null, List<string> statuses = null, List<string> externalIds = null)



Get all learning modules of an organization

Requires ANY permissions: 

* learning:module:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLearningModulesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var isArchived = true;  // bool? | Archive status (optional)  (default to false)
            var types = new List<string>(); // List<string> | Specifies the module types. Informational, AssessedContent and Assessment are deprecated (optional) 
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ascending)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)
            var searchTerm = searchTerm_example;  // string | Search Term (searchable by name) (optional) 
            var expand = new List<string>(); // List<string> | Fields to expand in response(case insensitive) (optional) 
            var isPublished = isPublished_example;  // string | Specifies if only the Unpublished (isPublished is \"False\") or Published (isPublished is \"True\") modules are returned. If isPublished is \"Any\" or omitted, both types are returned (optional)  (default to Any)
            var statuses = new List<string>(); // List<string> | Specifies the module statuses to filter by (optional) 
            var externalIds = new List<string>(); // List<string> | Specifies the module external IDs to filter by. Only one ID is allowed (optional) 

            try
            { 
                // Get all learning modules of an organization
                LearningModulesDomainEntityListing result = apiInstance.GetLearningModules(isArchived, types, pageSize, pageNumber, sortOrder, sortBy, searchTerm, expand, isPublished, statuses, externalIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.GetLearningModules: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **isArchived** | **bool?**| Archive status | [optional] [default to false] |
| **types** | [**List<string>**](string.html)| Specifies the module types. Informational, AssessedContent and Assessment are deprecated | [optional] <br />**Values**: Informational, AssessedContent, Assessment, External, Native |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortOrder** | **string**| Sort order | [optional] [default to ascending]<br />**Values**: ascending, descending |
| **sortBy** | **string**| Sort by | [optional] [default to name]<br />**Values**: name, createddate, percentpassed, averagescore |
| **searchTerm** | **string**| Search Term (searchable by name) | [optional]  |
| **expand** | [**List<string>**](string.html)| Fields to expand in response(case insensitive) | [optional] <br />**Values**: rule, summaryData |
| **isPublished** | **string**| Specifies if only the Unpublished (isPublished is \&quot;False\&quot;) or Published (isPublished is \&quot;True\&quot;) modules are returned. If isPublished is \&quot;Any\&quot; or omitted, both types are returned | [optional] [default to Any]<br />**Values**: True, False, Any |
| **statuses** | [**List<string>**](string.html)| Specifies the module statuses to filter by | [optional] <br />**Values**: Unpublished, Published, Archived |
| **externalIds** | [**List<string>**](string.html)| Specifies the module external IDs to filter by. Only one ID is allowed | [optional]  |
{: class="table table-striped"}

### Return type

[**LearningModulesDomainEntityListing**](LearningModulesDomainEntityListing.html)

<a name="getlearningmodulesassignments"></a>

## [**AssignedLearningModuleDomainEntityListing**](AssignedLearningModuleDomainEntityListing.html) GetLearningModulesAssignments (List<string> userIds, int? pageSize = null, int? pageNumber = null, string searchTerm = null, string overdue = null, List<string> assignmentStates = null, List<string> expand = null)



Get all learning modules of an organization including assignments for a specific user

Requires ALL permissions: 

* learning:module:view
* learning:assignment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLearningModulesAssignmentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var userIds = new List<string>(); // List<string> | The IDs of the users to include
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var searchTerm = searchTerm_example;  // string | Search Term (searches by name and description) (optional) 
            var overdue = overdue_example;  // string | Specifies if only modules with overdue/not overdue (overdue is \"True\" or \"False\") assignments are returned. If overdue is \"Any\" or omitted, both are returned and can including modules that are unassigned. (optional)  (default to Any)
            var assignmentStates = new List<string>(); // List<string> | Specifies the assignment states to return. (optional) 
            var expand = new List<string>(); // List<string> | Fields to expand in response(case insensitive) (optional) 

            try
            { 
                // Get all learning modules of an organization including assignments for a specific user
                AssignedLearningModuleDomainEntityListing result = apiInstance.GetLearningModulesAssignments(userIds, pageSize, pageNumber, searchTerm, overdue, assignmentStates, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.GetLearningModulesAssignments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userIds** | [**List<string>**](string.html)| The IDs of the users to include |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **searchTerm** | **string**| Search Term (searches by name and description) | [optional]  |
| **overdue** | **string**| Specifies if only modules with overdue/not overdue (overdue is \&quot;True\&quot; or \&quot;False\&quot;) assignments are returned. If overdue is \&quot;Any\&quot; or omitted, both are returned and can including modules that are unassigned. | [optional] [default to Any]<br />**Values**: True, False, Any |
| **assignmentStates** | [**List<string>**](string.html)| Specifies the assignment states to return. | [optional] <br />**Values**: NotAssigned, Assigned, InProgress, Completed, InvalidSchedule |
| **expand** | [**List<string>**](string.html)| Fields to expand in response(case insensitive) | [optional] <br />**Values**: coverArt |
{: class="table table-striped"}

### Return type

[**AssignedLearningModuleDomainEntityListing**](AssignedLearningModuleDomainEntityListing.html)

<a name="getlearningmodulescoverartcoverartid"></a>

## [**LearningModuleCoverArtResponse**](LearningModuleCoverArtResponse.html) GetLearningModulesCoverartCoverArtId (string coverArtId)



Get a specific Learning Module cover art using ID

Requires ANY permissions: 

* learning:coverart:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLearningModulesCoverartCoverArtIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var coverArtId = coverArtId_example;  // string | Key identifier for the cover art

            try
            { 
                // Get a specific Learning Module cover art using ID
                LearningModuleCoverArtResponse result = apiInstance.GetLearningModulesCoverartCoverArtId(coverArtId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.GetLearningModulesCoverartCoverArtId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **coverArtId** | **string**| Key identifier for the cover art |  |
{: class="table table-striped"}

### Return type

[**LearningModuleCoverArtResponse**](LearningModuleCoverArtResponse.html)

<a name="getlearningscormscormid"></a>

## [**LearningScormResponse**](LearningScormResponse.html) GetLearningScormScormId (string scormId)



Get Learning SCORM Result

Requires ANY permissions: 

* learning:scorm:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLearningScormScormIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var scormId = scormId_example;  // string | The ID of the SCORM package

            try
            { 
                // Get Learning SCORM Result
                LearningScormResponse result = apiInstance.GetLearningScormScormId(scormId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.GetLearningScormScormId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scormId** | **string**| The ID of the SCORM package |  |
{: class="table table-striped"}

### Return type

[**LearningScormResponse**](LearningScormResponse.html)

<a name="patchlearningassignment"></a>

## [**LearningAssignment**](LearningAssignment.html) PatchLearningAssignment (string assignmentId, LearningAssignmentUpdate body = null)



Update Learning Assignment

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchLearningAssignmentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var assignmentId = assignmentId_example;  // string | The ID of Learning Assignment
            var body = new LearningAssignmentUpdate(); // LearningAssignmentUpdate | The Learning Assignment to be updated (optional) 

            try
            { 
                // Update Learning Assignment
                LearningAssignment result = apiInstance.PatchLearningAssignment(assignmentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.PatchLearningAssignment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **assignmentId** | **string**| The ID of Learning Assignment |  |
| **body** | [**LearningAssignmentUpdate**](LearningAssignmentUpdate.html)| The Learning Assignment to be updated | [optional]  |
{: class="table table-striped"}

### Return type

[**LearningAssignment**](LearningAssignment.html)

<a name="patchlearningassignmentreschedule"></a>

## [**LearningAssignment**](LearningAssignment.html) PatchLearningAssignmentReschedule (string assignmentId, LearningAssignmentReschedule body = null)



Reschedule Learning Assignment

Requires ANY permissions: 

* learning:assignment:reschedule

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchLearningAssignmentRescheduleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var assignmentId = assignmentId_example;  // string | The ID of Learning Assignment
            var body = new LearningAssignmentReschedule(); // LearningAssignmentReschedule | The Learning assignment reschedule model (optional) 

            try
            { 
                // Reschedule Learning Assignment
                LearningAssignment result = apiInstance.PatchLearningAssignmentReschedule(assignmentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.PatchLearningAssignmentReschedule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **assignmentId** | **string**| The ID of Learning Assignment |  |
| **body** | [**LearningAssignmentReschedule**](LearningAssignmentReschedule.html)| The Learning assignment reschedule model | [optional]  |
{: class="table table-striped"}

### Return type

[**LearningAssignment**](LearningAssignment.html)

<a name="patchlearningassignmentstep"></a>

## [**LearningAssignmentStep**](LearningAssignmentStep.html) PatchLearningAssignmentStep (string assignmentId, string stepId, LearningAssignmentStep body = null)



Update Learning Assignment Step

Permission not required if you are the assigned user of the learning assignment

Requires ANY permissions: 

* learning:assignment:editOwn

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchLearningAssignmentStepExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var assignmentId = assignmentId_example;  // string | The ID of Learning Assignment
            var stepId = stepId_example;  // string | The ID of Learning Assignment Step
            var body = new LearningAssignmentStep(); // LearningAssignmentStep | The Learning Assignment Step to be updated (optional) 

            try
            { 
                // Update Learning Assignment Step
                LearningAssignmentStep result = apiInstance.PatchLearningAssignmentStep(assignmentId, stepId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.PatchLearningAssignmentStep: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **assignmentId** | **string**| The ID of Learning Assignment |  |
| **stepId** | **string**| The ID of Learning Assignment Step |  |
| **body** | [**LearningAssignmentStep**](LearningAssignmentStep.html)| The Learning Assignment Step to be updated | [optional]  |
{: class="table table-striped"}

### Return type

[**LearningAssignmentStep**](LearningAssignmentStep.html)

<a name="patchlearningmoduleuserassignments"></a>

## [**LearningAssignment**](LearningAssignment.html) PatchLearningModuleUserAssignments (string moduleId, string userId, LearningAssignmentExternalUpdate body)



Update an external assignment for a specific user

Requires ALL permissions: 

* learning:externalAssignment:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchLearningModuleUserAssignmentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var moduleId = moduleId_example;  // string | Key identifier for the module
            var userId = userId_example;  // string | Key identifier for the user
            var body = new LearningAssignmentExternalUpdate(); // LearningAssignmentExternalUpdate | The learning request for updating the assignment

            try
            { 
                // Update an external assignment for a specific user
                LearningAssignment result = apiInstance.PatchLearningModuleUserAssignments(moduleId, userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.PatchLearningModuleUserAssignments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **moduleId** | **string**| Key identifier for the module |  |
| **userId** | **string**| Key identifier for the user |  |
| **body** | [**LearningAssignmentExternalUpdate**](LearningAssignmentExternalUpdate.html)| The learning request for updating the assignment |  |
{: class="table table-striped"}

### Return type

[**LearningAssignment**](LearningAssignment.html)

<a name="postlearningassessmentsscoring"></a>

## [**AssessmentScoringSet**](AssessmentScoringSet.html) PostLearningAssessmentsScoring (LearningAssessmentScoringRequest body)



Score learning assessment for preview

Requires ANY permissions: 

* learning:module:view
* learning:module:add
* learning:module:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostLearningAssessmentsScoringExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var body = new LearningAssessmentScoringRequest(); // LearningAssessmentScoringRequest | Assessment form and answers to score

            try
            { 
                // Score learning assessment for preview
                AssessmentScoringSet result = apiInstance.PostLearningAssessmentsScoring(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.PostLearningAssessmentsScoring: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**LearningAssessmentScoringRequest**](LearningAssessmentScoringRequest.html)| Assessment form and answers to score |  |
{: class="table table-striped"}

### Return type

[**AssessmentScoringSet**](AssessmentScoringSet.html)

<a name="postlearningassignmentreassign"></a>

## [**LearningAssignment**](LearningAssignment.html) PostLearningAssignmentReassign (string assignmentId)



Reassign Learning Assignment

This will reassign the state of the assignment to 'Assigned' and update the assignment to the latest version of the module

Requires ANY permissions: 

* learning:assignment:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostLearningAssignmentReassignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var assignmentId = assignmentId_example;  // string | The Learning Assignment ID

            try
            { 
                // Reassign Learning Assignment
                LearningAssignment result = apiInstance.PostLearningAssignmentReassign(assignmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.PostLearningAssignmentReassign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **assignmentId** | **string**| The Learning Assignment ID |  |
{: class="table table-striped"}

### Return type

[**LearningAssignment**](LearningAssignment.html)

<a name="postlearningassignmentreset"></a>

## [**LearningAssignment**](LearningAssignment.html) PostLearningAssignmentReset (string assignmentId)



Reset Learning Assignment

This will reset the state of the assignment to 'Assigned' and remove the version of Learning module associated with the assignment

Requires ANY permissions: 

* learning:assignment:reset

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostLearningAssignmentResetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var assignmentId = assignmentId_example;  // string | The Learning Assignment ID

            try
            { 
                // Reset Learning Assignment
                LearningAssignment result = apiInstance.PostLearningAssignmentReset(assignmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.PostLearningAssignmentReset: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **assignmentId** | **string**| The Learning Assignment ID |  |
{: class="table table-striped"}

### Return type

[**LearningAssignment**](LearningAssignment.html)

<a name="postlearningassignments"></a>

## [**LearningAssignment**](LearningAssignment.html) PostLearningAssignments (LearningAssignmentCreate body = null)



Create Learning Assignment

Requires ANY permissions: 

* learning:assignment:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostLearningAssignmentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var body = new LearningAssignmentCreate(); // LearningAssignmentCreate | The Learning Assignment to be created (optional) 

            try
            { 
                // Create Learning Assignment
                LearningAssignment result = apiInstance.PostLearningAssignments(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.PostLearningAssignments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**LearningAssignmentCreate**](LearningAssignmentCreate.html)| The Learning Assignment to be created | [optional]  |
{: class="table table-striped"}

### Return type

[**LearningAssignment**](LearningAssignment.html)

<a name="postlearningassignmentsaggregatesquery"></a>

## [**LearningAssignmentAggregateResponse**](LearningAssignmentAggregateResponse.html) PostLearningAssignmentsAggregatesQuery (LearningAssignmentAggregateParam body)



Retrieve aggregated assignment data

Requires ANY permissions: 

* learning:assignment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostLearningAssignmentsAggregatesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var body = new LearningAssignmentAggregateParam(); // LearningAssignmentAggregateParam | Aggregate Request

            try
            { 
                // Retrieve aggregated assignment data
                LearningAssignmentAggregateResponse result = apiInstance.PostLearningAssignmentsAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.PostLearningAssignmentsAggregatesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**LearningAssignmentAggregateParam**](LearningAssignmentAggregateParam.html)| Aggregate Request |  |
{: class="table table-striped"}

### Return type

[**LearningAssignmentAggregateResponse**](LearningAssignmentAggregateResponse.html)

<a name="postlearningassignmentsbulkadd"></a>

## [**LearningAssignmentBulkAddResponse**](LearningAssignmentBulkAddResponse.html) PostLearningAssignmentsBulkadd (List<LearningAssignmentItem> body = null)



Add multiple learning assignments

Requires ANY permissions: 

* learning:assignment:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostLearningAssignmentsBulkaddExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var body = new List<LearningAssignmentItem>(); // List<LearningAssignmentItem> | The learning assignments to be created (optional) 

            try
            { 
                // Add multiple learning assignments
                LearningAssignmentBulkAddResponse result = apiInstance.PostLearningAssignmentsBulkadd(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.PostLearningAssignmentsBulkadd: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**List<LearningAssignmentItem>**](LearningAssignmentItem.html)| The learning assignments to be created | [optional]  |
{: class="table table-striped"}

### Return type

[**LearningAssignmentBulkAddResponse**](LearningAssignmentBulkAddResponse.html)

<a name="postlearningassignmentsbulkremove"></a>

## [**LearningAssignmentBulkRemoveResponse**](LearningAssignmentBulkRemoveResponse.html) PostLearningAssignmentsBulkremove (List<string> body = null)



Remove multiple Learning Assignments

Requires ANY permissions: 

* learning:assignment:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostLearningAssignmentsBulkremoveExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var body = new List<string>(); // List<string> | The IDs of the learning assignments to be removed (optional) 

            try
            { 
                // Remove multiple Learning Assignments
                LearningAssignmentBulkRemoveResponse result = apiInstance.PostLearningAssignmentsBulkremove(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.PostLearningAssignmentsBulkremove: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**List<string>**](string.html)| The IDs of the learning assignments to be removed | [optional]  |
{: class="table table-striped"}

### Return type

[**LearningAssignmentBulkRemoveResponse**](LearningAssignmentBulkRemoveResponse.html)

<a name="postlearningmodulejobs"></a>

## [**LearningModuleJobResponse**](LearningModuleJobResponse.html) PostLearningModuleJobs (string moduleId, LearningModuleJobRequest body)



Starts a specified operation on learning module

This will initiate operation specified in the request body for a learning module

Requires ANY permissions: 

* learning:module:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostLearningModuleJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var moduleId = moduleId_example;  // string | The ID of the learning module
            var body = new LearningModuleJobRequest(); // LearningModuleJobRequest | The learning module job request

            try
            { 
                // Starts a specified operation on learning module
                LearningModuleJobResponse result = apiInstance.PostLearningModuleJobs(moduleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.PostLearningModuleJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **moduleId** | **string**| The ID of the learning module |  |
| **body** | [**LearningModuleJobRequest**](LearningModuleJobRequest.html)| The learning module job request |  |
{: class="table table-striped"}

### Return type

[**LearningModuleJobResponse**](LearningModuleJobResponse.html)

<a name="postlearningmodulepublish"></a>

## [**LearningModulePublishResponse**](LearningModulePublishResponse.html) PostLearningModulePublish (string moduleId, LearningModulePublishRequest body = null)



Publish a Learning module

Requires ANY permissions: 

* learning:module:publish

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostLearningModulePublishExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var moduleId = moduleId_example;  // string | The ID of the learning module
            var body = new LearningModulePublishRequest(); // LearningModulePublishRequest | The request body (optional) 

            try
            { 
                // Publish a Learning module
                LearningModulePublishResponse result = apiInstance.PostLearningModulePublish(moduleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.PostLearningModulePublish: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **moduleId** | **string**| The ID of the learning module |  |
| **body** | [**LearningModulePublishRequest**](LearningModulePublishRequest.html)| The request body | [optional]  |
{: class="table table-striped"}

### Return type

[**LearningModulePublishResponse**](LearningModulePublishResponse.html)

<a name="postlearningmodules"></a>

## [**LearningModule**](LearningModule.html) PostLearningModules (LearningModuleRequest body)



Create a new learning module

This will create a new unpublished learning module with the specified fields.

Requires ANY permissions: 

* learning:module:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostLearningModulesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var body = new LearningModuleRequest(); // LearningModuleRequest | The learning module to be created

            try
            { 
                // Create a new learning module
                LearningModule result = apiInstance.PostLearningModules(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.PostLearningModules: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**LearningModuleRequest**](LearningModuleRequest.html)| The learning module to be created |  |
{: class="table table-striped"}

### Return type

[**LearningModule**](LearningModule.html)

<a name="postlearningrulesquery"></a>

## [**LearningAssignmentUserListing**](LearningAssignmentUserListing.html) PostLearningRulesQuery (int? pageSize, int? pageNumber, LearningAssignmentUserQuery body)



Get users for learning module rule

This will get the users who matches the given rule.

Requires ANY permissions: 

* learning:rule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostLearningRulesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var pageSize = 56;  // int? | Page size (default to 50)
            var pageNumber = 56;  // int? | Page number (default to 1)
            var body = new LearningAssignmentUserQuery(); // LearningAssignmentUserQuery | The learning module rule to fetch users

            try
            { 
                // Get users for learning module rule
                LearningAssignmentUserListing result = apiInstance.PostLearningRulesQuery(pageSize, pageNumber, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.PostLearningRulesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [default to 50] |
| **pageNumber** | **int?**| Page number | [default to 1] |
| **body** | [**LearningAssignmentUserQuery**](LearningAssignmentUserQuery.html)| The learning module rule to fetch users |  |
{: class="table table-striped"}

### Return type

[**LearningAssignmentUserListing**](LearningAssignmentUserListing.html)

<a name="postlearningscheduleslotsquery"></a>

## [**LearningScheduleSlotsQueryResponse**](LearningScheduleSlotsQueryResponse.html) PostLearningScheduleslotsQuery (LearningScheduleSlotsQueryRequest body)



Get list of possible slots where a learning activity can be scheduled.

Requires ANY permissions: 

* learning:scheduleSlot:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostLearningScheduleslotsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var body = new LearningScheduleSlotsQueryRequest(); // LearningScheduleSlotsQueryRequest | The slot search request

            try
            { 
                // Get list of possible slots where a learning activity can be scheduled.
                LearningScheduleSlotsQueryResponse result = apiInstance.PostLearningScheduleslotsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.PostLearningScheduleslotsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**LearningScheduleSlotsQueryRequest**](LearningScheduleSlotsQueryRequest.html)| The slot search request |  |
{: class="table table-striped"}

### Return type

[**LearningScheduleSlotsQueryResponse**](LearningScheduleSlotsQueryResponse.html)

<a name="postlearningscorm"></a>

## [**LearningScormUploadResponse**](LearningScormUploadResponse.html) PostLearningScorm (LearningScormUploadRequest body = null)



Create a SCORM package upload request

Requires ANY permissions: 

* learning:scorm:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostLearningScormExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var body = new LearningScormUploadRequest(); // LearningScormUploadRequest | The SCORM package to be uploaded (optional) 

            try
            { 
                // Create a SCORM package upload request
                LearningScormUploadResponse result = apiInstance.PostLearningScorm(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.PostLearningScorm: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**LearningScormUploadRequest**](LearningScormUploadRequest.html)| The SCORM package to be uploaded | [optional]  |
{: class="table table-striped"}

### Return type

[**LearningScormUploadResponse**](LearningScormUploadResponse.html)

<a name="putlearningmodule"></a>

## [**LearningModule**](LearningModule.html) PutLearningModule (string moduleId, LearningModuleRequest body)



Update a learning module

This will update the name, description, completion time in days and inform steps for a learning module

Requires ANY permissions: 

* learning:module:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutLearningModuleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var moduleId = moduleId_example;  // string | The ID of the learning module
            var body = new LearningModuleRequest(); // LearningModuleRequest | The learning module to be updated

            try
            { 
                // Update a learning module
                LearningModule result = apiInstance.PutLearningModule(moduleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.PutLearningModule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **moduleId** | **string**| The ID of the learning module |  |
| **body** | [**LearningModuleRequest**](LearningModuleRequest.html)| The learning module to be updated |  |
{: class="table table-striped"}

### Return type

[**LearningModule**](LearningModule.html)

<a name="putlearningmodulepreview"></a>

## [**LearningModulePreviewUpdateResponse**](LearningModulePreviewUpdateResponse.html) PutLearningModulePreview (string moduleId, LearningModulePreviewUpdateRequest body)



Update a learning module preview

This will update a learning module preview

Requires ANY permissions: 

* learning:module:preview

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutLearningModulePreviewExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var moduleId = moduleId_example;  // string | The ID of the learning module
            var body = new LearningModulePreviewUpdateRequest(); // LearningModulePreviewUpdateRequest | The learning module to be updated

            try
            { 
                // Update a learning module preview
                LearningModulePreviewUpdateResponse result = apiInstance.PutLearningModulePreview(moduleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.PutLearningModulePreview: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **moduleId** | **string**| The ID of the learning module |  |
| **body** | [**LearningModulePreviewUpdateRequest**](LearningModulePreviewUpdateRequest.html)| The learning module to be updated |  |
{: class="table table-striped"}

### Return type

[**LearningModulePreviewUpdateResponse**](LearningModulePreviewUpdateResponse.html)

<a name="putlearningmodulerule"></a>

## [**LearningModuleRule**](LearningModuleRule.html) PutLearningModuleRule (string moduleId, LearningModuleRule body)



Update a learning module rule

This will update a learning module rule with the specified fields.

Requires ANY permissions: 

* learning:rule:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutLearningModuleRuleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LearningApi();
            var moduleId = moduleId_example;  // string | The ID of the learning module
            var body = new LearningModuleRule(); // LearningModuleRule | The learning module rule to be updated

            try
            { 
                // Update a learning module rule
                LearningModuleRule result = apiInstance.PutLearningModuleRule(moduleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.PutLearningModuleRule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **moduleId** | **string**| The ID of the learning module |  |
| **body** | [**LearningModuleRule**](LearningModuleRule.html)| The learning module rule to be updated |  |
{: class="table table-striped"}

### Return type

[**LearningModuleRule**](LearningModuleRule.html)

