# LearningApi

## PureCloudPlatform.Client.V2.Api.LearningApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteLearningAssignment**](#DeleteLearningAssignment) | **Delete** /api/v2/learning/assignments/{assignmentId} | Delete a learning assignment |
| [**DeleteLearningModule**](#DeleteLearningModule) | **Delete** /api/v2/learning/modules/{moduleId} | Delete a learning module |
| [**GetLearningAssignment**](#GetLearningAssignment) | **Get** /api/v2/learning/assignments/{assignmentId} | Get Learning Assignment |
| [**GetLearningAssignmentStep**](#GetLearningAssignmentStep) | **Get** /api/v2/learning/assignments/{assignmentId}/steps/{stepId} | Get Learning Assignment Step |
| [**GetLearningAssignments**](#GetLearningAssignments) | **Get** /api/v2/learning/assignments | List of Learning module Assignments |
| [**GetLearningAssignmentsMe**](#GetLearningAssignmentsMe) | **Get** /api/v2/learning/assignments/me | List of Learning Assignments assigned to current user |
| [**GetLearningModule**](#GetLearningModule) | **Get** /api/v2/learning/modules/{moduleId} | Get a learning module |
| [**GetLearningModuleJob**](#GetLearningModuleJob) | **Get** /api/v2/learning/modules/{moduleId}/jobs/{jobId} | Get a specific Learning Module job status |
| [**GetLearningModulePreview**](#GetLearningModulePreview) | **Get** /api/v2/learning/modules/{moduleId}/preview | Get a learning module preview |
| [**GetLearningModuleRule**](#GetLearningModuleRule) | **Get** /api/v2/learning/modules/{moduleId}/rule | Get a learning module rule |
| [**GetLearningModuleVersion**](#GetLearningModuleVersion) | **Get** /api/v2/learning/modules/{moduleId}/versions/{versionId} | Get specific version of a published module |
| [**GetLearningModules**](#GetLearningModules) | **Get** /api/v2/learning/modules | Get all learning modules of an organization |
| [**GetLearningModulesAssignments**](#GetLearningModulesAssignments) | **Get** /api/v2/learning/modules/assignments | Get all learning modules of an organization including assignments for a specific user |
| [**GetLearningModulesCoverartCoverArtId**](#GetLearningModulesCoverartCoverArtId) | **Get** /api/v2/learning/modules/coverart/{coverArtId} | Get a specific Learning Module cover art using ID |
| [**GetLearningScheduleslotsJob**](#GetLearningScheduleslotsJob) | **Get** /api/v2/learning/scheduleslots/jobs/{jobId} | Retrieve the status of the job for the slots where a learning activity can be scheduled. |
| [**GetLearningScormScormId**](#GetLearningScormScormId) | **Get** /api/v2/learning/scorm/{scormId} | Get Learning SCORM Result |
| [**PatchLearningAssignment**](#PatchLearningAssignment) | **Patch** /api/v2/learning/assignments/{assignmentId} | Update Learning Assignment |
| [**PatchLearningAssignmentReschedule**](#PatchLearningAssignmentReschedule) | **Patch** /api/v2/learning/assignments/{assignmentId}/reschedule | Reschedule Learning Assignment |
| [**PatchLearningAssignmentStep**](#PatchLearningAssignmentStep) | **Patch** /api/v2/learning/assignments/{assignmentId}/steps/{stepId} | Update Learning Assignment Step |
| [**PatchLearningModuleUserAssignments**](#PatchLearningModuleUserAssignments) | **Patch** /api/v2/learning/modules/{moduleId}/users/{userId}/assignments | Update an external assignment for a specific user |
| [**PostLearningAssessmentsScoring**](#PostLearningAssessmentsScoring) | **Post** /api/v2/learning/assessments/scoring | Score learning assessment for preview |
| [**PostLearningAssignmentReassign**](#PostLearningAssignmentReassign) | **Post** /api/v2/learning/assignments/{assignmentId}/reassign | Reassign Learning Assignment |
| [**PostLearningAssignmentReset**](#PostLearningAssignmentReset) | **Post** /api/v2/learning/assignments/{assignmentId}/reset | Reset Learning Assignment |
| [**PostLearningAssignments**](#PostLearningAssignments) | **Post** /api/v2/learning/assignments | Create Learning Assignment |
| [**PostLearningAssignmentsAggregatesQuery**](#PostLearningAssignmentsAggregatesQuery) | **Post** /api/v2/learning/assignments/aggregates/query | Retrieve aggregated assignment data |
| [**PostLearningAssignmentsBulkadd**](#PostLearningAssignmentsBulkadd) | **Post** /api/v2/learning/assignments/bulkadd | Add multiple learning assignments |
| [**PostLearningAssignmentsBulkremove**](#PostLearningAssignmentsBulkremove) | **Post** /api/v2/learning/assignments/bulkremove | Remove multiple Learning Assignments |
| [**PostLearningModuleJobs**](#PostLearningModuleJobs) | **Post** /api/v2/learning/modules/{moduleId}/jobs | Starts a specified operation on learning module |
| [**PostLearningModulePublish**](#PostLearningModulePublish) | **Post** /api/v2/learning/modules/{moduleId}/publish | Publish a Learning module |
| [**PostLearningModuleRuleMigrate**](#PostLearningModuleRuleMigrate) | **Post** /api/v2/learning/modules/{moduleId}/rule/migrate | Migrate a legacy learning module rule to a users rule. |
| [**PostLearningModules**](#PostLearningModules) | **Post** /api/v2/learning/modules | Create a new learning module |
| [**PostLearningRulesQuery**](#PostLearningRulesQuery) | **Post** /api/v2/learning/rules/query | Get users for learning module rule |
| [**PostLearningScheduleslotsJobs**](#PostLearningScheduleslotsJobs) | **Post** /api/v2/learning/scheduleslots/jobs | Start job to retrieve slots where a learning activity can be scheduled. |
| [**PostLearningScheduleslotsQuery**](#PostLearningScheduleslotsQuery) | **Post** /api/v2/learning/scheduleslots/query | Get list of possible slots where a learning activity can be scheduled. |
| [**PostLearningScorm**](#PostLearningScorm) | **Post** /api/v2/learning/scorm | Create a SCORM package upload request |
| [**PutLearningModule**](#PutLearningModule) | **Put** /api/v2/learning/modules/{moduleId} | Update a learning module |
| [**PutLearningModulePreview**](#PutLearningModulePreview) | **Put** /api/v2/learning/modules/{moduleId}/preview | Update a learning module preview |
| [**PutLearningModuleRule**](#PutLearningModuleRule) | **Put** /api/v2/learning/modules/{moduleId}/rule | Update a learning module rule |



## DeleteLearningAssignment

> void DeleteLearningAssignment (string assignmentId)


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

### Return type

void (empty response body)


## DeleteLearningModule

> void DeleteLearningModule (string moduleId)


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

### Return type

void (empty response body)


## GetLearningAssignment

> [**LearningAssignment**](LearningAssignment) GetLearningAssignment (string assignmentId, List<string> expand = null)


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
| **expand** | [**List<string>**](string)| Fields to expand in response | [optional] <br />**Values**: module, assessment, assessmentForm, module.coverArt, step, step.moduleStep |

### Return type

[**LearningAssignment**](LearningAssignment)


## GetLearningAssignmentStep

> [**LearningAssignmentStep**](LearningAssignmentStep) GetLearningAssignmentStep (string assignmentId, string stepId, string shareableContentObjectId = null, string defaultShareableContentObject = null, List<string> expand = null)


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
| **expand** | [**List<string>**](string)| Fields to expand in response | [optional] <br />**Values**: moduleStep |

### Return type

[**LearningAssignmentStep**](LearningAssignmentStep)


## GetLearningAssignments

> [**LearningAssignmentsDomainEntity**](LearningAssignmentsDomainEntity) GetLearningAssignments (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string pass = null, float? minPercentageScore = null, float? maxPercentageScore = null, string sortOrder = null, string sortBy = null, List<string> userId = null, List<string> types = null, List<string> states = null, List<string> expand = null)


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
| **userId** | [**List<string>**](string)| Specifies the list of user IDs to be queried, up to 100 user IDs. | [optional]  |
| **types** | [**List<string>**](string)| Specifies the module types to filter by. Informational, AssessedContent and Assessment are deprecated | [optional] <br />**Values**: Informational, AssessedContent, Assessment, External, Native |
| **states** | [**List<string>**](string)| Specifies the assignment states to filter by | [optional] <br />**Values**: Assigned, InProgress, Completed, NotCompleted, InvalidSchedule |
| **expand** | [**List<string>**](string)| Specifies the expand option for returning additional information | [optional] <br />**Values**: ModuleSummary |

### Return type

[**LearningAssignmentsDomainEntity**](LearningAssignmentsDomainEntity)


## GetLearningAssignmentsMe

> [**LearningAssignmentsDomainEntity**](LearningAssignmentsDomainEntity) GetLearningAssignmentsMe (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string pass = null, float? minPercentageScore = null, float? maxPercentageScore = null, string sortOrder = null, string sortBy = null, List<string> types = null, List<string> states = null, List<string> expand = null)


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
| **types** | [**List<string>**](string)| Specifies the module types to filter by. Informational, AssessedContent and Assessment are deprecated | [optional] <br />**Values**: Informational, AssessedContent, Assessment, External, Native |
| **states** | [**List<string>**](string)| Specifies the assignment states to filter by | [optional] <br />**Values**: Assigned, InProgress, Completed, NotCompleted, InvalidSchedule |
| **expand** | [**List<string>**](string)| Specifies the expand option for returning additional information | [optional] <br />**Values**: ModuleSummary |

### Return type

[**LearningAssignmentsDomainEntity**](LearningAssignmentsDomainEntity)


## GetLearningModule

> [**LearningModule**](LearningModule) GetLearningModule (string moduleId, List<string> expand = null)


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
| **expand** | [**List<string>**](string)| Fields to expand in response(case insensitive) | [optional] <br />**Values**: assessmentForm, coverArt |

### Return type

[**LearningModule**](LearningModule)


## GetLearningModuleJob

> [**LearningModuleJobResponse**](LearningModuleJobResponse) GetLearningModuleJob (string moduleId, string jobId)


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

### Return type

[**LearningModuleJobResponse**](LearningModuleJobResponse)


## GetLearningModulePreview

> [**LearningModulePreviewGetResponse**](LearningModulePreviewGetResponse) GetLearningModulePreview (string moduleId)


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

### Return type

[**LearningModulePreviewGetResponse**](LearningModulePreviewGetResponse)


## GetLearningModuleRule

> [**LearningModuleRule**](LearningModuleRule) GetLearningModuleRule (string moduleId)


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

### Return type

[**LearningModuleRule**](LearningModuleRule)


## GetLearningModuleVersion

> [**LearningModule**](LearningModule) GetLearningModuleVersion (string moduleId, string versionId, List<string> expand = null)


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
| **expand** | [**List<string>**](string)| Fields to expand in response(case insensitive) | [optional] <br />**Values**: assessmentForm, coverArt |

### Return type

[**LearningModule**](LearningModule)


## GetLearningModules

> [**LearningModuleList**](LearningModuleList) GetLearningModules (bool? isArchived = null, List<string> types = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, string searchTerm = null, List<string> expand = null, string isPublished = null, List<string> statuses = null, List<string> externalIds = null)


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
                LearningModuleList result = apiInstance.GetLearningModules(isArchived, types, pageSize, pageNumber, sortOrder, sortBy, searchTerm, expand, isPublished, statuses, externalIds);
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
| **types** | [**List<string>**](string)| Specifies the module types. Informational, AssessedContent and Assessment are deprecated | [optional] <br />**Values**: Informational, AssessedContent, Assessment, External, Native |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortOrder** | **string**| Sort order | [optional] [default to ascending]<br />**Values**: ascending, descending |
| **sortBy** | **string**| Sort by | [optional] [default to name]<br />**Values**: name, createddate, percentpassed, averagescore |
| **searchTerm** | **string**| Search Term (searchable by name) | [optional]  |
| **expand** | [**List<string>**](string)| Fields to expand in response(case insensitive) | [optional] <br />**Values**: rule, summaryData |
| **isPublished** | **string**| Specifies if only the Unpublished (isPublished is \&quot;False\&quot;) or Published (isPublished is \&quot;True\&quot;) modules are returned. If isPublished is \&quot;Any\&quot; or omitted, both types are returned | [optional] [default to Any]<br />**Values**: True, False, Any |
| **statuses** | [**List<string>**](string)| Specifies the module statuses to filter by | [optional] <br />**Values**: Unpublished, Published, Archived |
| **externalIds** | [**List<string>**](string)| Specifies the module external IDs to filter by. Only one ID is allowed | [optional]  |

### Return type

[**LearningModuleList**](LearningModuleList)


## GetLearningModulesAssignments

> [**AssignedLearningModuleDomainEntityListing**](AssignedLearningModuleDomainEntityListing) GetLearningModulesAssignments (List<string> userIds, int? pageSize = null, int? pageNumber = null, string searchTerm = null, string overdue = null, List<string> assignmentStates = null, List<string> expand = null)


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
| **userIds** | [**List<string>**](string)| The IDs of the users to include |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **searchTerm** | **string**| Search Term (searches by name and description) | [optional]  |
| **overdue** | **string**| Specifies if only modules with overdue/not overdue (overdue is \&quot;True\&quot; or \&quot;False\&quot;) assignments are returned. If overdue is \&quot;Any\&quot; or omitted, both are returned and can including modules that are unassigned. | [optional] [default to Any]<br />**Values**: True, False, Any |
| **assignmentStates** | [**List<string>**](string)| Specifies the assignment states to return. | [optional] <br />**Values**: NotAssigned, Assigned, InProgress, Completed, InvalidSchedule |
| **expand** | [**List<string>**](string)| Fields to expand in response(case insensitive) | [optional] <br />**Values**: coverArt |

### Return type

[**AssignedLearningModuleDomainEntityListing**](AssignedLearningModuleDomainEntityListing)


## GetLearningModulesCoverartCoverArtId

> [**LearningModuleCoverArtResponse**](LearningModuleCoverArtResponse) GetLearningModulesCoverartCoverArtId (string coverArtId)


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

### Return type

[**LearningModuleCoverArtResponse**](LearningModuleCoverArtResponse)


## GetLearningScheduleslotsJob

> [**LearningScheduleSlotsJobResponse**](LearningScheduleSlotsJobResponse) GetLearningScheduleslotsJob (string jobId)


Retrieve the status of the job for the slots where a learning activity can be scheduled.

Requires ANY permissions: 

* learning:scheduleSlotJob:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLearningScheduleslotsJobExample
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
            var jobId = jobId_example;  // string | The ID of the job

            try
            { 
                // Retrieve the status of the job for the slots where a learning activity can be scheduled.
                LearningScheduleSlotsJobResponse result = apiInstance.GetLearningScheduleslotsJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.GetLearningScheduleslotsJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| The ID of the job |  |

### Return type

[**LearningScheduleSlotsJobResponse**](LearningScheduleSlotsJobResponse)


## GetLearningScormScormId

> [**LearningScormResponse**](LearningScormResponse) GetLearningScormScormId (string scormId)


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

### Return type

[**LearningScormResponse**](LearningScormResponse)


## PatchLearningAssignment

> [**LearningAssignment**](LearningAssignment) PatchLearningAssignment (string assignmentId, LearningAssignmentUpdate body = null)


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
| **body** | [**LearningAssignmentUpdate**](LearningAssignmentUpdate)| The Learning Assignment to be updated | [optional]  |

### Return type

[**LearningAssignment**](LearningAssignment)


## PatchLearningAssignmentReschedule

> [**LearningAssignment**](LearningAssignment) PatchLearningAssignmentReschedule (string assignmentId, LearningAssignmentReschedule body = null)


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
| **body** | [**LearningAssignmentReschedule**](LearningAssignmentReschedule)| The Learning assignment reschedule model | [optional]  |

### Return type

[**LearningAssignment**](LearningAssignment)


## PatchLearningAssignmentStep

> [**LearningAssignmentStep**](LearningAssignmentStep) PatchLearningAssignmentStep (string assignmentId, string stepId, LearningAssignmentStep body = null)


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
| **body** | [**LearningAssignmentStep**](LearningAssignmentStep)| The Learning Assignment Step to be updated | [optional]  |

### Return type

[**LearningAssignmentStep**](LearningAssignmentStep)


## PatchLearningModuleUserAssignments

> [**LearningAssignment**](LearningAssignment) PatchLearningModuleUserAssignments (string moduleId, string userId, LearningAssignmentExternalUpdate body)


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
| **body** | [**LearningAssignmentExternalUpdate**](LearningAssignmentExternalUpdate)| The learning request for updating the assignment |  |

### Return type

[**LearningAssignment**](LearningAssignment)


## PostLearningAssessmentsScoring

> [**AssessmentScoringSet**](AssessmentScoringSet) PostLearningAssessmentsScoring (LearningAssessmentScoringRequest body)


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
| **body** | [**LearningAssessmentScoringRequest**](LearningAssessmentScoringRequest)| Assessment form and answers to score |  |

### Return type

[**AssessmentScoringSet**](AssessmentScoringSet)


## PostLearningAssignmentReassign

> [**LearningAssignment**](LearningAssignment) PostLearningAssignmentReassign (string assignmentId)


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

### Return type

[**LearningAssignment**](LearningAssignment)


## PostLearningAssignmentReset

> [**LearningAssignment**](LearningAssignment) PostLearningAssignmentReset (string assignmentId)


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

### Return type

[**LearningAssignment**](LearningAssignment)


## PostLearningAssignments

> [**LearningAssignment**](LearningAssignment) PostLearningAssignments (LearningAssignmentCreate body = null)


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
| **body** | [**LearningAssignmentCreate**](LearningAssignmentCreate)| The Learning Assignment to be created | [optional]  |

### Return type

[**LearningAssignment**](LearningAssignment)


## PostLearningAssignmentsAggregatesQuery

> [**LearningAssignmentAggregateResponse**](LearningAssignmentAggregateResponse) PostLearningAssignmentsAggregatesQuery (LearningAssignmentAggregateParam body)


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
| **body** | [**LearningAssignmentAggregateParam**](LearningAssignmentAggregateParam)| Aggregate Request |  |

### Return type

[**LearningAssignmentAggregateResponse**](LearningAssignmentAggregateResponse)


## PostLearningAssignmentsBulkadd

> [**LearningAssignmentBulkAddResponse**](LearningAssignmentBulkAddResponse) PostLearningAssignmentsBulkadd (List<LearningAssignmentItem> body = null)


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
| **body** | [**List<LearningAssignmentItem>**](LearningAssignmentItem)| The learning assignments to be created | [optional]  |

### Return type

[**LearningAssignmentBulkAddResponse**](LearningAssignmentBulkAddResponse)


## PostLearningAssignmentsBulkremove

> [**LearningAssignmentBulkRemoveResponse**](LearningAssignmentBulkRemoveResponse) PostLearningAssignmentsBulkremove (List<string> body = null)


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
| **body** | [**List<string>**](string)| The IDs of the learning assignments to be removed | [optional]  |

### Return type

[**LearningAssignmentBulkRemoveResponse**](LearningAssignmentBulkRemoveResponse)


## PostLearningModuleJobs

> [**LearningModuleJobResponse**](LearningModuleJobResponse) PostLearningModuleJobs (string moduleId, LearningModuleJobRequest body)


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
| **body** | [**LearningModuleJobRequest**](LearningModuleJobRequest)| The learning module job request |  |

### Return type

[**LearningModuleJobResponse**](LearningModuleJobResponse)


## PostLearningModulePublish

> [**LearningModulePublishResponse**](LearningModulePublishResponse) PostLearningModulePublish (string moduleId, LearningModulePublishRequest body = null)


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
| **body** | [**LearningModulePublishRequest**](LearningModulePublishRequest)| The request body | [optional]  |

### Return type

[**LearningModulePublishResponse**](LearningModulePublishResponse)


## PostLearningModuleRuleMigrate

> [**LearningModuleMigrateResponse**](LearningModuleMigrateResponse) PostLearningModuleRuleMigrate (string moduleId)


Migrate a legacy learning module rule to a users rule.

PostLearningModuleRuleMigrate is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
    public class PostLearningModuleRuleMigrateExample
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
                // Migrate a legacy learning module rule to a users rule.
                LearningModuleMigrateResponse result = apiInstance.PostLearningModuleRuleMigrate(moduleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.PostLearningModuleRuleMigrate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **moduleId** | **string**| The ID of the learning module |  |

### Return type

[**LearningModuleMigrateResponse**](LearningModuleMigrateResponse)


## PostLearningModules

> [**LearningModule**](LearningModule) PostLearningModules (LearningModuleRequest body)


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
| **body** | [**LearningModuleRequest**](LearningModuleRequest)| The learning module to be created |  |

### Return type

[**LearningModule**](LearningModule)


## PostLearningRulesQuery

> [**LearningAssignmentUserListing**](LearningAssignmentUserListing) PostLearningRulesQuery (int? pageSize, int? pageNumber, LearningAssignmentUserQuery body)


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
| **body** | [**LearningAssignmentUserQuery**](LearningAssignmentUserQuery)| The learning module rule to fetch users |  |

### Return type

[**LearningAssignmentUserListing**](LearningAssignmentUserListing)


## PostLearningScheduleslotsJobs

> [**LearningScheduleSlotsJobResponse**](LearningScheduleSlotsJobResponse) PostLearningScheduleslotsJobs (LearningScheduleSlotsJobRequest body)


Start job to retrieve slots where a learning activity can be scheduled.

Requires ANY permissions: 

* learning:scheduleSlotJob:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostLearningScheduleslotsJobsExample
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
            var body = new LearningScheduleSlotsJobRequest(); // LearningScheduleSlotsJobRequest | The slots search request

            try
            { 
                // Start job to retrieve slots where a learning activity can be scheduled.
                LearningScheduleSlotsJobResponse result = apiInstance.PostLearningScheduleslotsJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningApi.PostLearningScheduleslotsJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**LearningScheduleSlotsJobRequest**](LearningScheduleSlotsJobRequest)| The slots search request |  |

### Return type

[**LearningScheduleSlotsJobResponse**](LearningScheduleSlotsJobResponse)


## PostLearningScheduleslotsQuery

> [**LearningScheduleSlotsQueryResponse**](LearningScheduleSlotsQueryResponse) PostLearningScheduleslotsQuery (LearningScheduleSlotsQueryRequest body)


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
| **body** | [**LearningScheduleSlotsQueryRequest**](LearningScheduleSlotsQueryRequest)| The slot search request |  |

### Return type

[**LearningScheduleSlotsQueryResponse**](LearningScheduleSlotsQueryResponse)


## PostLearningScorm

> [**LearningScormUploadResponse**](LearningScormUploadResponse) PostLearningScorm (LearningScormUploadRequest body = null)


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
| **body** | [**LearningScormUploadRequest**](LearningScormUploadRequest)| The SCORM package to be uploaded | [optional]  |

### Return type

[**LearningScormUploadResponse**](LearningScormUploadResponse)


## PutLearningModule

> [**LearningModule**](LearningModule) PutLearningModule (string moduleId, LearningModuleRequest body)


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
| **body** | [**LearningModuleRequest**](LearningModuleRequest)| The learning module to be updated |  |

### Return type

[**LearningModule**](LearningModule)


## PutLearningModulePreview

> [**LearningModulePreviewUpdateResponse**](LearningModulePreviewUpdateResponse) PutLearningModulePreview (string moduleId, LearningModulePreviewUpdateRequest body)


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
| **body** | [**LearningModulePreviewUpdateRequest**](LearningModulePreviewUpdateRequest)| The learning module to be updated |  |

### Return type

[**LearningModulePreviewUpdateResponse**](LearningModulePreviewUpdateResponse)


## PutLearningModuleRule

> [**LearningModuleRule**](LearningModuleRule) PutLearningModuleRule (string moduleId, LearningModuleRule body, bool? assign = null)


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
            var assign = true;  // bool? | Whether to assign the module to users or not (optional)  (default to true)

            try
            { 
                // Update a learning module rule
                LearningModuleRule result = apiInstance.PutLearningModuleRule(moduleId, body, assign);
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
| **body** | [**LearningModuleRule**](LearningModuleRule)| The learning module rule to be updated |  |
| **assign** | **bool?**| Whether to assign the module to users or not | [optional] [default to true] |

### Return type

[**LearningModuleRule**](LearningModuleRule)


_PureCloudPlatform.Client.V2 253.0.0_
