---
title: LearningApi
---
## PureCloudPlatform.Client.V2.Api.LearningApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteLearningAssignment**](LearningApi.html#deletelearningassignment) | **DELETE** /api/v2/learning/assignments/{assignmentId} | Delete a learning assignment |
| [**DeleteLearningModule**](LearningApi.html#deletelearningmodule) | **DELETE** /api/v2/learning/modules/{moduleId} | Delete a learning module |
| [**GetLearningAssignment**](LearningApi.html#getlearningassignment) | **GET** /api/v2/learning/assignments/{assignmentId} | Get Learning Assignment |
| [**GetLearningAssignments**](LearningApi.html#getlearningassignments) | **GET** /api/v2/learning/assignments | List of Learning module Assignments |
| [**GetLearningAssignmentsMe**](LearningApi.html#getlearningassignmentsme) | **GET** /api/v2/learning/assignments/me | List of Learning Assignments assigned to current user |
| [**GetLearningModule**](LearningApi.html#getlearningmodule) | **GET** /api/v2/learning/modules/{moduleId} | Get a learning module |
| [**GetLearningModuleRule**](LearningApi.html#getlearningmodulerule) | **GET** /api/v2/learning/modules/{moduleId}/rule | Get a learning module rule |
| [**GetLearningModuleVersion**](LearningApi.html#getlearningmoduleversion) | **GET** /api/v2/learning/modules/{moduleId}/versions/{versionId} | Get specific version of a published module |
| [**GetLearningModules**](LearningApi.html#getlearningmodules) | **GET** /api/v2/learning/modules | Get all learning modules of an organization |
| [**PatchLearningAssignment**](LearningApi.html#patchlearningassignment) | **PATCH** /api/v2/learning/assignments/{assignmentId} | Update Learning Assignment |
| [**PostLearningAssignments**](LearningApi.html#postlearningassignments) | **POST** /api/v2/learning/assignments | Create Learning Assignment |
| [**PostLearningAssignmentsAggregatesQuery**](LearningApi.html#postlearningassignmentsaggregatesquery) | **POST** /api/v2/learning/assignments/aggregates/query | Retrieve aggregated assignment data |
| [**PostLearningAssignmentsBulkadd**](LearningApi.html#postlearningassignmentsbulkadd) | **POST** /api/v2/learning/assignments/bulkadd | Add multiple learning assignments |
| [**PostLearningAssignmentsBulkremove**](LearningApi.html#postlearningassignmentsbulkremove) | **POST** /api/v2/learning/assignments/bulkremove | Remove multiple Learning Assignments |
| [**PostLearningModulePublish**](LearningApi.html#postlearningmodulepublish) | **POST** /api/v2/learning/modules/{moduleId}/publish | Publish a Learning module |
| [**PostLearningModules**](LearningApi.html#postlearningmodules) | **POST** /api/v2/learning/modules | Create a new learning module |
| [**PostLearningRulesQuery**](LearningApi.html#postlearningrulesquery) | **POST** /api/v2/learning/rules/query | Get users for learning module rule |
| [**PutLearningModule**](LearningApi.html#putlearningmodule) | **PUT** /api/v2/learning/modules/{moduleId} | Update a learning module |
| [**PutLearningModuleRule**](LearningApi.html#putlearningmodulerule) | **PUT** /api/v2/learning/modules/{moduleId}/rule | Update a learning module rule |
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
| **expand** | [**List<string>**](string.html)| Fields to expand in response | [optional] <br />**Values**: module, assessment, assessmentForm |
{: class="table table-striped"}

### Return type

[**LearningAssignment**](LearningAssignment.html)

<a name="getlearningassignments"></a>

## [**LearningAssignmentsDomainEntity**](LearningAssignmentsDomainEntity.html) GetLearningAssignments (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, List<string> userId = null, List<string> types = null, List<string> states = null, List<string> expand = null)



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
            var sortOrder = sortOrder_example;  // string | Specifies result set sort order; if not specified, default sort order is descending (Desc) (optional)  (default to Desc)
            var sortBy = sortBy_example;  // string | Specifies which field to sort the results by, default sort is by recommendedCompletionDate (optional) 
            var userId = new List<string>(); // List<string> | Specifies the list of user IDs to be queried, up to 100 user IDs. (optional) 
            var types = new List<string>(); // List<string> | Specifies the assignment types, currently not supported and will be ignored. For now, all learning assignments regardless of types will be returned (optional) 
            var states = new List<string>(); // List<string> | Specifies the assignment states to filter by (optional) 
            var expand = new List<string>(); // List<string> | Specifies the expand option for returning additional information (optional) 

            try
            { 
                // List of Learning module Assignments
                LearningAssignmentsDomainEntity result = apiInstance.GetLearningAssignments(moduleId, interval, completionInterval, overdue, pageSize, pageNumber, sortOrder, sortBy, userId, types, states, expand);
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
| **sortOrder** | **string**| Specifies result set sort order; if not specified, default sort order is descending (Desc) | [optional] [default to Desc]<br />**Values**: Asc, Desc |
| **sortBy** | **string**| Specifies which field to sort the results by, default sort is by recommendedCompletionDate | [optional] <br />**Values**: RecommendedCompletionDate, DateModified |
| **userId** | [**List<string>**](string.html)| Specifies the list of user IDs to be queried, up to 100 user IDs. | [optional]  |
| **types** | [**List<string>**](string.html)| Specifies the assignment types, currently not supported and will be ignored. For now, all learning assignments regardless of types will be returned | [optional] <br />**Values**: Informational, AssessedContent, Questionnaire, Assessment |
| **states** | [**List<string>**](string.html)| Specifies the assignment states to filter by | [optional] <br />**Values**: Assigned, InProgress, Completed |
| **expand** | [**List<string>**](string.html)| Specifies the expand option for returning additional information | [optional] <br />**Values**: ModuleSummary |
{: class="table table-striped"}

### Return type

[**LearningAssignmentsDomainEntity**](LearningAssignmentsDomainEntity.html)

<a name="getlearningassignmentsme"></a>

## [**LearningAssignmentsDomainEntity**](LearningAssignmentsDomainEntity.html) GetLearningAssignmentsMe (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, List<string> types = null, List<string> states = null, List<string> expand = null)



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
            var sortOrder = sortOrder_example;  // string | Specifies result set sort order; if not specified, default sort order is descending (Desc) (optional)  (default to Desc)
            var sortBy = sortBy_example;  // string | Specifies which field to sort the results by, default sort is by recommendedCompletionDate (optional) 
            var types = new List<string>(); // List<string> | Specifies the assignment types, currently not supported and will be ignored. For now, all learning assignments regardless of types will be returned (optional) 
            var states = new List<string>(); // List<string> | Specifies the assignment states to filter by (optional) 
            var expand = new List<string>(); // List<string> | Specifies the expand option for returning additional information (optional) 

            try
            { 
                // List of Learning Assignments assigned to current user
                LearningAssignmentsDomainEntity result = apiInstance.GetLearningAssignmentsMe(moduleId, interval, completionInterval, overdue, pageSize, pageNumber, sortOrder, sortBy, types, states, expand);
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
| **sortOrder** | **string**| Specifies result set sort order; if not specified, default sort order is descending (Desc) | [optional] [default to Desc]<br />**Values**: Asc, Desc |
| **sortBy** | **string**| Specifies which field to sort the results by, default sort is by recommendedCompletionDate | [optional] <br />**Values**: RecommendedCompletionDate, DateModified |
| **types** | [**List<string>**](string.html)| Specifies the assignment types, currently not supported and will be ignored. For now, all learning assignments regardless of types will be returned | [optional] <br />**Values**: Informational, AssessedContent, Questionnaire, Assessment |
| **states** | [**List<string>**](string.html)| Specifies the assignment states to filter by | [optional] <br />**Values**: Assigned, InProgress, Completed |
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
| **expand** | [**List<string>**](string.html)| Fields to expand in response(case insensitive) | [optional] <br />**Values**: assessmentForm |
{: class="table table-striped"}

### Return type

[**LearningModule**](LearningModule.html)

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
| **expand** | [**List<string>**](string.html)| Fields to expand in response(case insensitive) | [optional] <br />**Values**: assessmentForm |
{: class="table table-striped"}

### Return type

[**LearningModule**](LearningModule.html)

<a name="getlearningmodules"></a>

## [**LearningModulesDomainEntityListing**](LearningModulesDomainEntityListing.html) GetLearningModules (bool? isArchived = null, List<string> types = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, string searchTerm = null, List<string> expand = null)



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
            var types = new List<string>(); // List<string> | Specifies the module types. (optional) 
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ascending)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)
            var searchTerm = searchTerm_example;  // string | Search Term (searchable by name) (optional) 
            var expand = new List<string>(); // List<string> | Fields to expand in response(case insensitive) (optional) 

            try
            { 
                // Get all learning modules of an organization
                LearningModulesDomainEntityListing result = apiInstance.GetLearningModules(isArchived, types, pageSize, pageNumber, sortOrder, sortBy, searchTerm, expand);
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
| **types** | [**List<string>**](string.html)| Specifies the module types. | [optional] <br />**Values**: Informational, AssessedContent, Questionnaire, Assessment |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortOrder** | **string**| Sort order | [optional] [default to ascending]<br />**Values**: ascending, descending |
| **sortBy** | **string**| Sort by | [optional] [default to name]<br />**Values**: name |
| **searchTerm** | **string**| Search Term (searchable by name) | [optional]  |
| **expand** | [**List<string>**](string.html)| Fields to expand in response(case insensitive) | [optional] <br />**Values**: rule, summaryData |
{: class="table table-striped"}

### Return type

[**LearningModulesDomainEntityListing**](LearningModulesDomainEntityListing.html)

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
            var body = ;  // List<string> | The IDs of the learning assignments to be removed (optional) 

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
| **body** | **List<string>**| The IDs of the learning assignments to be removed | [optional]  |
{: class="table table-striped"}

### Return type

[**LearningAssignmentBulkRemoveResponse**](LearningAssignmentBulkRemoveResponse.html)

<a name="postlearningmodulepublish"></a>

## [**LearningModulePublishResponse**](LearningModulePublishResponse.html) PostLearningModulePublish (string moduleId)



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

            try
            { 
                // Publish a Learning module
                LearningModulePublishResponse result = apiInstance.PostLearningModulePublish(moduleId);
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

