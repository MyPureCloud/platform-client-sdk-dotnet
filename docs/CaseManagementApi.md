# CaseManagementApi

## PureCloudPlatform.Client.V2.Api.CaseManagementApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteCasemanagementCase**](#DeleteCasemanagementCase) | **Delete** /api/v2/casemanagement/cases/{caseId} | Delete a Case. |
| [**DeleteCasemanagementCaseplan**](#DeleteCasemanagementCaseplan) | **Delete** /api/v2/casemanagement/caseplans/{caseplanId} | Delete a Caseplan. |
| [**GetCasemanagementCase**](#GetCasemanagementCase) | **Get** /api/v2/casemanagement/cases/{caseId} | Get a Case. |
| [**GetCasemanagementCaseAssociation**](#GetCasemanagementCaseAssociation) | **Get** /api/v2/casemanagement/cases/{caseId}/associations/{associationId} | Get a Case Association. |
| [**GetCasemanagementCaseAssociations**](#GetCasemanagementCaseAssociations) | **Get** /api/v2/casemanagement/cases/{caseId}/associations | Get a list of case associations for a provided case. |
| [**GetCasemanagementCaseStage**](#GetCasemanagementCaseStage) | **Get** /api/v2/casemanagement/cases/{caseId}/stages/{stageId} | Get a Stage. |
| [**GetCasemanagementCaseStageStep**](#GetCasemanagementCaseStageStep) | **Get** /api/v2/casemanagement/cases/{caseId}/stages/{stageId}/steps/{stepId} | Get a Step. |
| [**GetCasemanagementCaseStageSteps**](#GetCasemanagementCaseStageSteps) | **Get** /api/v2/casemanagement/cases/{caseId}/stages/{stageId}/steps | Get a list of Steps. |
| [**GetCasemanagementCaseStages**](#GetCasemanagementCaseStages) | **Get** /api/v2/casemanagement/cases/{caseId}/stages | Get a list of Stages. |
| [**GetCasemanagementCaseTerminateJob**](#GetCasemanagementCaseTerminateJob) | **Get** /api/v2/casemanagement/cases/{caseId}/terminate/jobs/{jobId} | Get a Terminate Job for a Case. |
| [**GetCasemanagementCaseplan**](#GetCasemanagementCaseplan) | **Get** /api/v2/casemanagement/caseplans/{caseplanId} | Get a Caseplan. |
| [**GetCasemanagementCaseplanVersion**](#GetCasemanagementCaseplanVersion) | **Get** /api/v2/casemanagement/caseplans/{caseplanId}/versions/{versionId} | Get a Caseplan version. |
| [**GetCasemanagementCaseplanVersionDataschemas**](#GetCasemanagementCaseplanVersionDataschemas) | **Get** /api/v2/casemanagement/caseplans/{caseplanId}/versions/{versionId}/dataschemas | Get the dataSchemas for a caseplan version. |
| [**GetCasemanagementCaseplanVersionIntakesettings**](#GetCasemanagementCaseplanVersionIntakesettings) | **Get** /api/v2/casemanagement/caseplans/{caseplanId}/versions/{versionId}/intakesettings | Get the intake settings for a Caseplan version. |
| [**GetCasemanagementCaseplanVersionStageplan**](#GetCasemanagementCaseplanVersionStageplan) | **Get** /api/v2/casemanagement/caseplans/{caseplanId}/versions/{versionId}/stageplans/{stageplanId} | Get a Stageplan. |
| [**GetCasemanagementCaseplanVersionStageplanStepplan**](#GetCasemanagementCaseplanVersionStageplanStepplan) | **Get** /api/v2/casemanagement/caseplans/{caseplanId}/versions/{versionId}/stageplans/{stageplanId}/stepplans/{stepplanId} | Get a Stepplan. |
| [**GetCasemanagementCaseplanVersionStageplanStepplans**](#GetCasemanagementCaseplanVersionStageplanStepplans) | **Get** /api/v2/casemanagement/caseplans/{caseplanId}/versions/{versionId}/stageplans/{stageplanId}/stepplans | Get a list of Stepplans. |
| [**GetCasemanagementCaseplanVersionStageplans**](#GetCasemanagementCaseplanVersionStageplans) | **Get** /api/v2/casemanagement/caseplans/{caseplanId}/versions/{versionId}/stageplans | Get a list of Stageplans. |
| [**GetCasemanagementCaseplans**](#GetCasemanagementCaseplans) | **Get** /api/v2/casemanagement/caseplans | Get a list of Caseplans. |
| [**GetCasemanagementCasesExternalcontact**](#GetCasemanagementCasesExternalcontact) | **Get** /api/v2/casemanagement/cases/externalcontacts/{externalContactId} | Get a list of cases for provided external contact id. |
| [**GetCasemanagementCasesReference**](#GetCasemanagementCasesReference) | **Get** /api/v2/casemanagement/cases/references/{referenceId} | Get a Case by reference. |
| [**PatchCasemanagementCaseDatedue**](#PatchCasemanagementCaseDatedue) | **Patch** /api/v2/casemanagement/cases/{caseId}/datedue | Update date due of a Case. |
| [**PatchCasemanagementCasePriority**](#PatchCasemanagementCasePriority) | **Patch** /api/v2/casemanagement/cases/{caseId}/priority | Update priority of a Case. |
| [**PatchCasemanagementCaseSummary**](#PatchCasemanagementCaseSummary) | **Patch** /api/v2/casemanagement/cases/{caseId}/summary | Update summary of a Case. |
| [**PatchCasemanagementCaseplan**](#PatchCasemanagementCaseplan) | **Patch** /api/v2/casemanagement/caseplans/{caseplanId} | Update the attributes of a Caseplan. |
| [**PatchCasemanagementCaseplanStageplan**](#PatchCasemanagementCaseplanStageplan) | **Patch** /api/v2/casemanagement/caseplans/{caseplanId}/stageplans/{stageplanId} | Update the attributes of a Stageplan. |
| [**PatchCasemanagementCaseplanStageplanStepplan**](#PatchCasemanagementCaseplanStageplanStepplan) | **Patch** /api/v2/casemanagement/caseplans/{caseplanId}/stageplans/{stageplanId}/stepplans/{stepplanId} | Update the attributes of a Stepplan. |
| [**PostCasemanagementCaseAssociations**](#PostCasemanagementCaseAssociations) | **Post** /api/v2/casemanagement/cases/{caseId}/associations | Create a case association. |
| [**PostCasemanagementCaseTerminateJobs**](#PostCasemanagementCaseTerminateJobs) | **Post** /api/v2/casemanagement/cases/{caseId}/terminate/jobs | Create a Terminate Job for a Case. |
| [**PostCasemanagementCaseplanPublish**](#PostCasemanagementCaseplanPublish) | **Post** /api/v2/casemanagement/caseplans/{caseplanId}/publish | Publish Caseplan. |
| [**PostCasemanagementCaseplanVersions**](#PostCasemanagementCaseplanVersions) | **Post** /api/v2/casemanagement/caseplans/{caseplanId}/versions | Create Caseplan version. |
| [**PostCasemanagementCaseplans**](#PostCasemanagementCaseplans) | **Post** /api/v2/casemanagement/caseplans | Create a Caseplan. |
| [**PostCasemanagementCases**](#PostCasemanagementCases) | **Post** /api/v2/casemanagement/cases | Create a Case. |
| [**PostCasemanagementCasesAssociationsQuery**](#PostCasemanagementCasesAssociationsQuery) | **Post** /api/v2/casemanagement/cases/associations/query | Query for case associations |
| [**PutCasemanagementCaseplanIntakesettings**](#PutCasemanagementCaseplanIntakesettings) | **Put** /api/v2/casemanagement/caseplans/{caseplanId}/intakesettings | Update the intake settings for a Caseplan. |



## DeleteCasemanagementCase

> **Object** DeleteCasemanagementCase (string caseId)


Delete a Case.

DeleteCasemanagementCase is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* caseManagement:case:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteCasemanagementCaseExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var caseId = caseId_example;  // string | Case ID

            try
            { 
                // Delete a Case.
                Object result = apiInstance.DeleteCasemanagementCase(caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.DeleteCasemanagementCase: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **caseId** | **string**| Case ID |  |

### Return type

**Object**


## DeleteCasemanagementCaseplan

> **Object** DeleteCasemanagementCaseplan (string caseplanId)


Delete a Caseplan.

DeleteCasemanagementCaseplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* caseManagement:caseplan:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteCasemanagementCaseplanExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var caseplanId = caseplanId_example;  // string | Caseplan ID

            try
            { 
                // Delete a Caseplan.
                Object result = apiInstance.DeleteCasemanagementCaseplan(caseplanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.DeleteCasemanagementCaseplan: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **caseplanId** | **string**| Caseplan ID |  |

### Return type

**Object**


## GetCasemanagementCase

> [**Case**](Case) GetCasemanagementCase (string caseId, string expands = null)


Get a Case.

GetCasemanagementCase is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* caseManagement:case:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetCasemanagementCaseExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var caseId = caseId_example;  // string | Case ID
            var expands = expands_example;  // string | Which fields to expand. (optional) 

            try
            { 
                // Get a Case.
                Case result = apiInstance.GetCasemanagementCase(caseId, expands);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.GetCasemanagementCase: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **caseId** | **string**| Case ID |  |
| **expands** | **string**| Which fields to expand. | [optional] <br />**Values**: caseplan |

### Return type

[**Case**](Case)


## GetCasemanagementCaseAssociation

> [**CaseAssociation**](CaseAssociation) GetCasemanagementCaseAssociation (string caseId, string associationId)


Get a Case Association.

GetCasemanagementCaseAssociation is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* caseManagement:caseAssociation:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetCasemanagementCaseAssociationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var caseId = caseId_example;  // string | Case ID
            var associationId = associationId_example;  // string | Case Association ID

            try
            { 
                // Get a Case Association.
                CaseAssociation result = apiInstance.GetCasemanagementCaseAssociation(caseId, associationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.GetCasemanagementCaseAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **caseId** | **string**| Case ID |  |
| **associationId** | **string**| Case Association ID |  |

### Return type

[**CaseAssociation**](CaseAssociation)


## GetCasemanagementCaseAssociations

> [**CaseAssociationListing**](CaseAssociationListing) GetCasemanagementCaseAssociations (string caseId, string before = null, string after = null, string pageSize = null)


Get a list of case associations for a provided case.

GetCasemanagementCaseAssociations is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* caseManagement:caseAssociation:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetCasemanagementCaseAssociationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var caseId = caseId_example;  // string | Case ID.
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 

            try
            { 
                // Get a list of case associations for a provided case.
                CaseAssociationListing result = apiInstance.GetCasemanagementCaseAssociations(caseId, before, after, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.GetCasemanagementCaseAssociations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **caseId** | **string**| Case ID. |  |
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |

### Return type

[**CaseAssociationListing**](CaseAssociationListing)


## GetCasemanagementCaseStage

> [**Stage**](Stage) GetCasemanagementCaseStage (string caseId, string stageId)


Get a Stage.

GetCasemanagementCaseStage is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* caseManagement:stage:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetCasemanagementCaseStageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var caseId = caseId_example;  // string | Case ID
            var stageId = stageId_example;  // string | Stage ID

            try
            { 
                // Get a Stage.
                Stage result = apiInstance.GetCasemanagementCaseStage(caseId, stageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.GetCasemanagementCaseStage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **caseId** | **string**| Case ID |  |
| **stageId** | **string**| Stage ID |  |

### Return type

[**Stage**](Stage)


## GetCasemanagementCaseStageStep

> [**Step**](Step) GetCasemanagementCaseStageStep (string caseId, string stageId, string stepId)


Get a Step.

GetCasemanagementCaseStageStep is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* caseManagement:step:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetCasemanagementCaseStageStepExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var caseId = caseId_example;  // string | Case ID
            var stageId = stageId_example;  // string | Stage ID
            var stepId = stepId_example;  // string | Step ID

            try
            { 
                // Get a Step.
                Step result = apiInstance.GetCasemanagementCaseStageStep(caseId, stageId, stepId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.GetCasemanagementCaseStageStep: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **caseId** | **string**| Case ID |  |
| **stageId** | **string**| Stage ID |  |
| **stepId** | **string**| Step ID |  |

### Return type

[**Step**](Step)


## GetCasemanagementCaseStageSteps

> [**StepListing**](StepListing) GetCasemanagementCaseStageSteps (string caseId, string stageId, string before = null, string after = null, string pageSize = null)


Get a list of Steps.

GetCasemanagementCaseStageSteps is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* caseManagement:step:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetCasemanagementCaseStageStepsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var caseId = caseId_example;  // string | Case ID
            var stageId = stageId_example;  // string | Stage ID
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 

            try
            { 
                // Get a list of Steps.
                StepListing result = apiInstance.GetCasemanagementCaseStageSteps(caseId, stageId, before, after, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.GetCasemanagementCaseStageSteps: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **caseId** | **string**| Case ID |  |
| **stageId** | **string**| Stage ID |  |
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |

### Return type

[**StepListing**](StepListing)


## GetCasemanagementCaseStages

> [**StageListing**](StageListing) GetCasemanagementCaseStages (string caseId, string before = null, string after = null, string pageSize = null)


Get a list of Stages.

GetCasemanagementCaseStages is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* caseManagement:stage:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetCasemanagementCaseStagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var caseId = caseId_example;  // string | Case ID
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 

            try
            { 
                // Get a list of Stages.
                StageListing result = apiInstance.GetCasemanagementCaseStages(caseId, before, after, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.GetCasemanagementCaseStages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **caseId** | **string**| Case ID |  |
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |

### Return type

[**StageListing**](StageListing)


## GetCasemanagementCaseTerminateJob

> [**TerminateJob**](TerminateJob) GetCasemanagementCaseTerminateJob (string caseId, string jobId)


Get a Terminate Job for a Case.

GetCasemanagementCaseTerminateJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* caseManagement:terminateJob:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetCasemanagementCaseTerminateJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var caseId = caseId_example;  // string | Case ID
            var jobId = jobId_example;  // string | Job ID

            try
            { 
                // Get a Terminate Job for a Case.
                TerminateJob result = apiInstance.GetCasemanagementCaseTerminateJob(caseId, jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.GetCasemanagementCaseTerminateJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **caseId** | **string**| Case ID |  |
| **jobId** | **string**| Job ID |  |

### Return type

[**TerminateJob**](TerminateJob)


## GetCasemanagementCaseplan

> [**Caseplan**](Caseplan) GetCasemanagementCaseplan (string caseplanId)


Get a Caseplan.

GetCasemanagementCaseplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* caseManagement:caseplan:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetCasemanagementCaseplanExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var caseplanId = caseplanId_example;  // string | Caseplan ID

            try
            { 
                // Get a Caseplan.
                Caseplan result = apiInstance.GetCasemanagementCaseplan(caseplanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.GetCasemanagementCaseplan: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **caseplanId** | **string**| Caseplan ID |  |

### Return type

[**Caseplan**](Caseplan)


## GetCasemanagementCaseplanVersion

> [**Caseplan**](Caseplan) GetCasemanagementCaseplanVersion (string caseplanId, string versionId)


Get a Caseplan version.

GetCasemanagementCaseplanVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* caseManagement:caseplan:version

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetCasemanagementCaseplanVersionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var caseplanId = caseplanId_example;  // string | Caseplan ID
            var versionId = versionId_example;  // string | Version of the caseplan

            try
            { 
                // Get a Caseplan version.
                Caseplan result = apiInstance.GetCasemanagementCaseplanVersion(caseplanId, versionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.GetCasemanagementCaseplanVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **caseplanId** | **string**| Caseplan ID |  |
| **versionId** | **string**| Version of the caseplan |  |

### Return type

[**Caseplan**](Caseplan)


## GetCasemanagementCaseplanVersionDataschemas

> [**CaseplanDataSchemaListing**](CaseplanDataSchemaListing) GetCasemanagementCaseplanVersionDataschemas (string caseplanId, string versionId)


Get the dataSchemas for a caseplan version.

GetCasemanagementCaseplanVersionDataschemas is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* caseManagement:caseplanDataSchemas:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetCasemanagementCaseplanVersionDataschemasExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var caseplanId = caseplanId_example;  // string | Caseplan ID
            var versionId = versionId_example;  // string | Version of the caseplan

            try
            { 
                // Get the dataSchemas for a caseplan version.
                CaseplanDataSchemaListing result = apiInstance.GetCasemanagementCaseplanVersionDataschemas(caseplanId, versionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.GetCasemanagementCaseplanVersionDataschemas: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **caseplanId** | **string**| Caseplan ID |  |
| **versionId** | **string**| Version of the caseplan |  |

### Return type

[**CaseplanDataSchemaListing**](CaseplanDataSchemaListing)


## GetCasemanagementCaseplanVersionIntakesettings

> [**IntakeSettingsListing**](IntakeSettingsListing) GetCasemanagementCaseplanVersionIntakesettings (string caseplanId, string versionId)


Get the intake settings for a Caseplan version.

GetCasemanagementCaseplanVersionIntakesettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* caseManagement:caseplanIntakeSettings:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetCasemanagementCaseplanVersionIntakesettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var caseplanId = caseplanId_example;  // string | Caseplan ID
            var versionId = versionId_example;  // string | Version of the caseplan

            try
            { 
                // Get the intake settings for a Caseplan version.
                IntakeSettingsListing result = apiInstance.GetCasemanagementCaseplanVersionIntakesettings(caseplanId, versionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.GetCasemanagementCaseplanVersionIntakesettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **caseplanId** | **string**| Caseplan ID |  |
| **versionId** | **string**| Version of the caseplan |  |

### Return type

[**IntakeSettingsListing**](IntakeSettingsListing)


## GetCasemanagementCaseplanVersionStageplan

> [**Stageplan**](Stageplan) GetCasemanagementCaseplanVersionStageplan (string caseplanId, string versionId, string stageplanId, List<string> expands = null)


Get a Stageplan.

GetCasemanagementCaseplanVersionStageplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* caseManagement:stageplan:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetCasemanagementCaseplanVersionStageplanExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var caseplanId = caseplanId_example;  // string | Caseplan ID
            var versionId = versionId_example;  // string | Version ID
            var stageplanId = stageplanId_example;  // string | Stageplan ID
            var expands = new List<string>(); // List<string> | Which fields to expand. (optional) 

            try
            { 
                // Get a Stageplan.
                Stageplan result = apiInstance.GetCasemanagementCaseplanVersionStageplan(caseplanId, versionId, stageplanId, expands);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.GetCasemanagementCaseplanVersionStageplan: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **caseplanId** | **string**| Caseplan ID |  |
| **versionId** | **string**| Version ID |  |
| **stageplanId** | **string**| Stageplan ID |  |
| **expands** | [**List<string>**](string)| Which fields to expand. | [optional] <br />**Values**: caseplan |

### Return type

[**Stageplan**](Stageplan)


## GetCasemanagementCaseplanVersionStageplanStepplan

> [**Stepplan**](Stepplan) GetCasemanagementCaseplanVersionStageplanStepplan (string caseplanId, string versionId, string stageplanId, string stepplanId, List<string> expands = null)


Get a Stepplan.

GetCasemanagementCaseplanVersionStageplanStepplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* caseManagement:stepplan:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetCasemanagementCaseplanVersionStageplanStepplanExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var caseplanId = caseplanId_example;  // string | Caseplan ID
            var versionId = versionId_example;  // string | Version ID
            var stageplanId = stageplanId_example;  // string | Stageplan ID
            var stepplanId = stepplanId_example;  // string | Stepplan ID
            var expands = new List<string>(); // List<string> | Which fields to expand. (optional) 

            try
            { 
                // Get a Stepplan.
                Stepplan result = apiInstance.GetCasemanagementCaseplanVersionStageplanStepplan(caseplanId, versionId, stageplanId, stepplanId, expands);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.GetCasemanagementCaseplanVersionStageplanStepplan: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **caseplanId** | **string**| Caseplan ID |  |
| **versionId** | **string**| Version ID |  |
| **stageplanId** | **string**| Stageplan ID |  |
| **stepplanId** | **string**| Stepplan ID |  |
| **expands** | [**List<string>**](string)| Which fields to expand. | [optional] <br />**Values**: stageplan, caseplan, worktype |

### Return type

[**Stepplan**](Stepplan)


## GetCasemanagementCaseplanVersionStageplanStepplans

> [**StepplanListing**](StepplanListing) GetCasemanagementCaseplanVersionStageplanStepplans (string caseplanId, string versionId, string stageplanId, string before = null, string after = null, string pageSize = null, List<string> expands = null)


Get a list of Stepplans.

GetCasemanagementCaseplanVersionStageplanStepplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* caseManagement:stepplan:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetCasemanagementCaseplanVersionStageplanStepplansExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var caseplanId = caseplanId_example;  // string | Caseplan ID
            var versionId = versionId_example;  // string | Version ID
            var stageplanId = stageplanId_example;  // string | Stageplan ID
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var expands = new List<string>(); // List<string> | Which fields to expand. (optional) 

            try
            { 
                // Get a list of Stepplans.
                StepplanListing result = apiInstance.GetCasemanagementCaseplanVersionStageplanStepplans(caseplanId, versionId, stageplanId, before, after, pageSize, expands);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.GetCasemanagementCaseplanVersionStageplanStepplans: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **caseplanId** | **string**| Caseplan ID |  |
| **versionId** | **string**| Version ID |  |
| **stageplanId** | **string**| Stageplan ID |  |
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **expands** | [**List<string>**](string)| Which fields to expand. | [optional] <br />**Values**: caseplan, stageplan, worktype |

### Return type

[**StepplanListing**](StepplanListing)


## GetCasemanagementCaseplanVersionStageplans

> [**StageplanListing**](StageplanListing) GetCasemanagementCaseplanVersionStageplans (string caseplanId, string versionId, string before = null, string after = null, string pageSize = null, List<string> expands = null)


Get a list of Stageplans.

GetCasemanagementCaseplanVersionStageplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* caseManagement:stageplan:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetCasemanagementCaseplanVersionStageplansExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var caseplanId = caseplanId_example;  // string | Caseplan ID
            var versionId = versionId_example;  // string | Version ID
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var expands = new List<string>(); // List<string> | Which fields to expand. (optional) 

            try
            { 
                // Get a list of Stageplans.
                StageplanListing result = apiInstance.GetCasemanagementCaseplanVersionStageplans(caseplanId, versionId, before, after, pageSize, expands);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.GetCasemanagementCaseplanVersionStageplans: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **caseplanId** | **string**| Caseplan ID |  |
| **versionId** | **string**| Version ID |  |
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **expands** | [**List<string>**](string)| Which fields to expand. | [optional] <br />**Values**: caseplan |

### Return type

[**StageplanListing**](StageplanListing)


## GetCasemanagementCaseplans

> [**CaseplanListing**](CaseplanListing) GetCasemanagementCaseplans (string after = null, int? pageSize = null, string customerIntentId = null, string divisionIds = null)


Get a list of Caseplans.

GetCasemanagementCaseplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* caseManagement:caseplan:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetCasemanagementCaseplansExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var after = after_example;  // string | The cursor that points to the end of the set of caseplans that has been returned. (optional) 
            var pageSize = 56;  // int? | Number of caseplans to return. Maximum of 200. (optional) 
            var customerIntentId = customerIntentId_example;  // string | Filter by Customer Intent. (optional) 
            var divisionIds = divisionIds_example;  // string | Filter by Divisions. (optional) 

            try
            { 
                // Get a list of Caseplans.
                CaseplanListing result = apiInstance.GetCasemanagementCaseplans(after, pageSize, customerIntentId, divisionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.GetCasemanagementCaseplans: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **after** | **string**| The cursor that points to the end of the set of caseplans that has been returned. | [optional]  |
| **pageSize** | **int?**| Number of caseplans to return. Maximum of 200. | [optional]  |
| **customerIntentId** | **string**| Filter by Customer Intent. | [optional]  |
| **divisionIds** | **string**| Filter by Divisions. | [optional]  |

### Return type

[**CaseplanListing**](CaseplanListing)


## GetCasemanagementCasesExternalcontact

> [**CaseListing**](CaseListing) GetCasemanagementCasesExternalcontact (string externalContactId, string after = null, int? pageSize = null, string divisionIds = null, List<string> expands = null)


Get a list of cases for provided external contact id.

GetCasemanagementCasesExternalcontact is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* caseManagement:caseExternalContact:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetCasemanagementCasesExternalcontactExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var externalContactId = externalContactId_example;  // string | External Contact ID
            var after = after_example;  // string | The cursor that points to the end of the set of cases that has been returned. (optional) 
            var pageSize = 56;  // int? | Number of cases to return. Maximum of 200. (optional) 
            var divisionIds = divisionIds_example;  // string | Filter by Divisions (optional) 
            var expands = new List<string>(); // List<string> | Which fields to expand. (optional) 

            try
            { 
                // Get a list of cases for provided external contact id.
                CaseListing result = apiInstance.GetCasemanagementCasesExternalcontact(externalContactId, after, pageSize, divisionIds, expands);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.GetCasemanagementCasesExternalcontact: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **externalContactId** | **string**| External Contact ID |  |
| **after** | **string**| The cursor that points to the end of the set of cases that has been returned. | [optional]  |
| **pageSize** | **int?**| Number of cases to return. Maximum of 200. | [optional]  |
| **divisionIds** | **string**| Filter by Divisions | [optional]  |
| **expands** | [**List<string>**](string)| Which fields to expand. | [optional] <br />**Values**: caseplan |

### Return type

[**CaseListing**](CaseListing)


## GetCasemanagementCasesReference

> [**Case**](Case) GetCasemanagementCasesReference (string referenceId, string expands = null)


Get a Case by reference.

GetCasemanagementCasesReference is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* caseManagement:caseReference:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetCasemanagementCasesReferenceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var referenceId = referenceId_example;  // string | Reference
            var expands = expands_example;  // string | Which fields to expand. (optional) 

            try
            { 
                // Get a Case by reference.
                Case result = apiInstance.GetCasemanagementCasesReference(referenceId, expands);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.GetCasemanagementCasesReference: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **referenceId** | **string**| Reference |  |
| **expands** | **string**| Which fields to expand. | [optional] <br />**Values**: caseplan |

### Return type

[**Case**](Case)


## PatchCasemanagementCaseDatedue

> [**Case**](Case) PatchCasemanagementCaseDatedue (string caseId, CaseDateDueUpdate body)


Update date due of a Case.

PatchCasemanagementCaseDatedue is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* caseManagement:caseDateDue:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchCasemanagementCaseDatedueExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var caseId = caseId_example;  // string | Case ID
            var body = new CaseDateDueUpdate(); // CaseDateDueUpdate | Date due

            try
            { 
                // Update date due of a Case.
                Case result = apiInstance.PatchCasemanagementCaseDatedue(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.PatchCasemanagementCaseDatedue: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **caseId** | **string**| Case ID |  |
| **body** | [**CaseDateDueUpdate**](CaseDateDueUpdate)| Date due |  |

### Return type

[**Case**](Case)


## PatchCasemanagementCasePriority

> [**Case**](Case) PatchCasemanagementCasePriority (string caseId, CasePriorityUpdate body)


Update priority of a Case.

PatchCasemanagementCasePriority is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* caseManagement:casePriority:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchCasemanagementCasePriorityExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var caseId = caseId_example;  // string | Case ID
            var body = new CasePriorityUpdate(); // CasePriorityUpdate | Priority

            try
            { 
                // Update priority of a Case.
                Case result = apiInstance.PatchCasemanagementCasePriority(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.PatchCasemanagementCasePriority: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **caseId** | **string**| Case ID |  |
| **body** | [**CasePriorityUpdate**](CasePriorityUpdate)| Priority |  |

### Return type

[**Case**](Case)


## PatchCasemanagementCaseSummary

> [**Case**](Case) PatchCasemanagementCaseSummary (string caseId, CaseSummaryUpdate body)


Update summary of a Case.

PatchCasemanagementCaseSummary is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* caseManagement:caseSummary:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchCasemanagementCaseSummaryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var caseId = caseId_example;  // string | Case ID
            var body = new CaseSummaryUpdate(); // CaseSummaryUpdate | Summary

            try
            { 
                // Update summary of a Case.
                Case result = apiInstance.PatchCasemanagementCaseSummary(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.PatchCasemanagementCaseSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **caseId** | **string**| Case ID |  |
| **body** | [**CaseSummaryUpdate**](CaseSummaryUpdate)| Summary |  |

### Return type

[**Case**](Case)


## PatchCasemanagementCaseplan

> [**Caseplan**](Caseplan) PatchCasemanagementCaseplan (string caseplanId, CaseplanUpdate body)


Update the attributes of a Caseplan.

PatchCasemanagementCaseplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* caseManagement:caseplan:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchCasemanagementCaseplanExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var caseplanId = caseplanId_example;  // string | Caseplan ID
            var body = new CaseplanUpdate(); // CaseplanUpdate | Caseplan

            try
            { 
                // Update the attributes of a Caseplan.
                Caseplan result = apiInstance.PatchCasemanagementCaseplan(caseplanId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.PatchCasemanagementCaseplan: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **caseplanId** | **string**| Caseplan ID |  |
| **body** | [**CaseplanUpdate**](CaseplanUpdate)| Caseplan |  |

### Return type

[**Caseplan**](Caseplan)


## PatchCasemanagementCaseplanStageplan

> [**Stageplan**](Stageplan) PatchCasemanagementCaseplanStageplan (string caseplanId, string stageplanId, StageplanUpdate body)


Update the attributes of a Stageplan.

PatchCasemanagementCaseplanStageplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* caseManagement:stageplan:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchCasemanagementCaseplanStageplanExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var caseplanId = caseplanId_example;  // string | Caseplan ID
            var stageplanId = stageplanId_example;  // string | Stageplan ID
            var body = new StageplanUpdate(); // StageplanUpdate | Stageplan

            try
            { 
                // Update the attributes of a Stageplan.
                Stageplan result = apiInstance.PatchCasemanagementCaseplanStageplan(caseplanId, stageplanId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.PatchCasemanagementCaseplanStageplan: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **caseplanId** | **string**| Caseplan ID |  |
| **stageplanId** | **string**| Stageplan ID |  |
| **body** | [**StageplanUpdate**](StageplanUpdate)| Stageplan |  |

### Return type

[**Stageplan**](Stageplan)


## PatchCasemanagementCaseplanStageplanStepplan

> [**Stepplan**](Stepplan) PatchCasemanagementCaseplanStageplanStepplan (string caseplanId, string stageplanId, string stepplanId, StepplanUpdate body)


Update the attributes of a Stepplan.

PatchCasemanagementCaseplanStageplanStepplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* caseManagement:stepplan:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchCasemanagementCaseplanStageplanStepplanExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var caseplanId = caseplanId_example;  // string | Caseplan ID
            var stageplanId = stageplanId_example;  // string | Stageplan ID
            var stepplanId = stepplanId_example;  // string | Stepplan ID
            var body = new StepplanUpdate(); // StepplanUpdate | Stepplan

            try
            { 
                // Update the attributes of a Stepplan.
                Stepplan result = apiInstance.PatchCasemanagementCaseplanStageplanStepplan(caseplanId, stageplanId, stepplanId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.PatchCasemanagementCaseplanStageplanStepplan: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **caseplanId** | **string**| Caseplan ID |  |
| **stageplanId** | **string**| Stageplan ID |  |
| **stepplanId** | **string**| Stepplan ID |  |
| **body** | [**StepplanUpdate**](StepplanUpdate)| Stepplan |  |

### Return type

[**Stepplan**](Stepplan)


## PostCasemanagementCaseAssociations

> [**CaseAssociation**](CaseAssociation) PostCasemanagementCaseAssociations (string caseId, CaseAssociationCreate body = null)


Create a case association.

PostCasemanagementCaseAssociations is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* caseManagement:caseAssociation:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostCasemanagementCaseAssociationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var caseId = caseId_example;  // string | Case ID.
            var body = new CaseAssociationCreate(); // CaseAssociationCreate | Case Association (optional) 

            try
            { 
                // Create a case association.
                CaseAssociation result = apiInstance.PostCasemanagementCaseAssociations(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.PostCasemanagementCaseAssociations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **caseId** | **string**| Case ID. |  |
| **body** | [**CaseAssociationCreate**](CaseAssociationCreate)| Case Association | [optional]  |

### Return type

[**CaseAssociation**](CaseAssociation)


## PostCasemanagementCaseTerminateJobs

> [**TerminateJob**](TerminateJob) PostCasemanagementCaseTerminateJobs (string caseId)


Create a Terminate Job for a Case.

PostCasemanagementCaseTerminateJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* caseManagement:terminateJob:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostCasemanagementCaseTerminateJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var caseId = caseId_example;  // string | Case ID

            try
            { 
                // Create a Terminate Job for a Case.
                TerminateJob result = apiInstance.PostCasemanagementCaseTerminateJobs(caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.PostCasemanagementCaseTerminateJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **caseId** | **string**| Case ID |  |

### Return type

[**TerminateJob**](TerminateJob)


## PostCasemanagementCaseplanPublish

> [**Caseplan**](Caseplan) PostCasemanagementCaseplanPublish (string caseplanId)


Publish Caseplan.

PostCasemanagementCaseplanPublish is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* caseManagement:caseplan:publish

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostCasemanagementCaseplanPublishExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var caseplanId = caseplanId_example;  // string | Caseplan ID

            try
            { 
                // Publish Caseplan.
                Caseplan result = apiInstance.PostCasemanagementCaseplanPublish(caseplanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.PostCasemanagementCaseplanPublish: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **caseplanId** | **string**| Caseplan ID |  |

### Return type

[**Caseplan**](Caseplan)


## PostCasemanagementCaseplanVersions

> [**Caseplan**](Caseplan) PostCasemanagementCaseplanVersions (string caseplanId)


Create Caseplan version.

PostCasemanagementCaseplanVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* caseManagement:caseplan:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostCasemanagementCaseplanVersionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var caseplanId = caseplanId_example;  // string | Caseplan ID

            try
            { 
                // Create Caseplan version.
                Caseplan result = apiInstance.PostCasemanagementCaseplanVersions(caseplanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.PostCasemanagementCaseplanVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **caseplanId** | **string**| Caseplan ID |  |

### Return type

[**Caseplan**](Caseplan)


## PostCasemanagementCaseplans

> [**CaseplanCreateResponse**](CaseplanCreateResponse) PostCasemanagementCaseplans (CaseplanCreate body)


Create a Caseplan.

PostCasemanagementCaseplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* caseManagement:caseplan:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostCasemanagementCaseplansExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var body = new CaseplanCreate(); // CaseplanCreate | Caseplan

            try
            { 
                // Create a Caseplan.
                CaseplanCreateResponse result = apiInstance.PostCasemanagementCaseplans(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.PostCasemanagementCaseplans: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CaseplanCreate**](CaseplanCreate)| Caseplan |  |

### Return type

[**CaseplanCreateResponse**](CaseplanCreateResponse)


## PostCasemanagementCases

> [**Case**](Case) PostCasemanagementCases (CaseCreate body)


Create a Case.

PostCasemanagementCases is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* caseManagement:case:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostCasemanagementCasesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var body = new CaseCreate(); // CaseCreate | Case

            try
            { 
                // Create a Case.
                Case result = apiInstance.PostCasemanagementCases(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.PostCasemanagementCases: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CaseCreate**](CaseCreate)| Case |  |

### Return type

[**Case**](Case)


## PostCasemanagementCasesAssociationsQuery

> [**CaseAssociationQueryEntityListing**](CaseAssociationQueryEntityListing) PostCasemanagementCasesAssociationsQuery (CaseAssociationQuery body = null)


Query for case associations

PostCasemanagementCasesAssociationsQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* caseManagement:caseAssociation:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostCasemanagementCasesAssociationsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var body = new CaseAssociationQuery(); // CaseAssociationQuery | Case Association (optional) 

            try
            { 
                // Query for case associations
                CaseAssociationQueryEntityListing result = apiInstance.PostCasemanagementCasesAssociationsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.PostCasemanagementCasesAssociationsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CaseAssociationQuery**](CaseAssociationQuery)| Case Association | [optional]  |

### Return type

[**CaseAssociationQueryEntityListing**](CaseAssociationQueryEntityListing)


## PutCasemanagementCaseplanIntakesettings

> [**IntakeSettingsListing**](IntakeSettingsListing) PutCasemanagementCaseplanIntakesettings (string caseplanId, IntakeSettingsUpdate body)


Update the intake settings for a Caseplan.

PutCasemanagementCaseplanIntakesettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* caseManagement:caseplanIntakeSettings:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutCasemanagementCaseplanIntakesettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new CaseManagementApi();
            var caseplanId = caseplanId_example;  // string | Caseplan ID
            var body = new IntakeSettingsUpdate(); // IntakeSettingsUpdate | Intake Settings

            try
            { 
                // Update the intake settings for a Caseplan.
                IntakeSettingsListing result = apiInstance.PutCasemanagementCaseplanIntakesettings(caseplanId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaseManagementApi.PutCasemanagementCaseplanIntakesettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **caseplanId** | **string**| Caseplan ID |  |
| **body** | [**IntakeSettingsUpdate**](IntakeSettingsUpdate)| Intake Settings |  |

### Return type

[**IntakeSettingsListing**](IntakeSettingsListing)


_PureCloudPlatform.Client.V2 262.0.0_
