---
title: QualityApi
---
## PureCloudPlatform.Client.V2.Api.QualityApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteQualityCalibration**](QualityApi.html#deletequalitycalibration) | **DELETE** /api/v2/quality/calibrations/{calibrationId} | Delete a calibration by id. |
| [**DeleteQualityConversationEvaluation**](QualityApi.html#deletequalityconversationevaluation) | **DELETE** /api/v2/quality/conversations/{conversationId}/evaluations/{evaluationId} | Delete an evaluation |
| [**DeleteQualityForm**](QualityApi.html#deletequalityform) | **DELETE** /api/v2/quality/forms/{formId} | Delete an evaluation form. |
| [**DeleteQualityKeywordset**](QualityApi.html#deletequalitykeywordset) | **DELETE** /api/v2/quality/keywordsets/{keywordSetId} | Delete a keywordSet by id. |
| [**DeleteQualityKeywordsets**](QualityApi.html#deletequalitykeywordsets) | **DELETE** /api/v2/quality/keywordsets | Delete keyword sets |
| [**GetQualityAgentsActivity**](QualityApi.html#getqualityagentsactivity) | **GET** /api/v2/quality/agents/activity | Gets a list of Agent Activities |
| [**GetQualityCalibration**](QualityApi.html#getqualitycalibration) | **GET** /api/v2/quality/calibrations/{calibrationId} | Get a calibration by id.  Requires either calibrator id or conversation id |
| [**GetQualityCalibrations**](QualityApi.html#getqualitycalibrations) | **GET** /api/v2/quality/calibrations | Get the list of calibrations |
| [**GetQualityConversationAudits**](QualityApi.html#getqualityconversationaudits) | **GET** /api/v2/quality/conversations/{conversationId}/audits | Get audits for conversation or recording |
| [**GetQualityConversationEvaluation**](QualityApi.html#getqualityconversationevaluation) | **GET** /api/v2/quality/conversations/{conversationId}/evaluations/{evaluationId} | Get an evaluation |
| [**GetQualityEvaluationsQuery**](QualityApi.html#getqualityevaluationsquery) | **GET** /api/v2/quality/evaluations/query | Queries Evaluations and returns a paged list |
| [**GetQualityEvaluatorsActivity**](QualityApi.html#getqualityevaluatorsactivity) | **GET** /api/v2/quality/evaluators/activity | Get an evaluator activity |
| [**GetQualityForm**](QualityApi.html#getqualityform) | **GET** /api/v2/quality/forms/{formId} | Get an evaluation form |
| [**GetQualityFormVersions**](QualityApi.html#getqualityformversions) | **GET** /api/v2/quality/forms/{formId}/versions | Gets all the revisions for a specific evaluation. |
| [**GetQualityForms**](QualityApi.html#getqualityforms) | **GET** /api/v2/quality/forms | Get the list of evaluation forms |
| [**GetQualityKeywordset**](QualityApi.html#getqualitykeywordset) | **GET** /api/v2/quality/keywordsets/{keywordSetId} | Get a keywordSet by id. |
| [**GetQualityKeywordsets**](QualityApi.html#getqualitykeywordsets) | **GET** /api/v2/quality/keywordsets | Get the list of keyword sets |
| [**GetQualityPublishedform**](QualityApi.html#getqualitypublishedform) | **GET** /api/v2/quality/publishedforms/{formId} | Get the published evaluation forms. |
| [**GetQualityPublishedforms**](QualityApi.html#getqualitypublishedforms) | **GET** /api/v2/quality/publishedforms | Get the published evaluation forms. |
| [**PostAnalyticsEvaluationsAggregatesQuery**](QualityApi.html#postanalyticsevaluationsaggregatesquery) | **POST** /api/v2/analytics/evaluations/aggregates/query | Query for evaluation aggregates |
| [**PostQualityCalibrations**](QualityApi.html#postqualitycalibrations) | **POST** /api/v2/quality/calibrations | Create a calibration |
| [**PostQualityConversationEvaluations**](QualityApi.html#postqualityconversationevaluations) | **POST** /api/v2/quality/conversations/{conversationId}/evaluations | Create an evaluation |
| [**PostQualityEvaluationsScoring**](QualityApi.html#postqualityevaluationsscoring) | **POST** /api/v2/quality/evaluations/scoring | Score evaluation |
| [**PostQualityForms**](QualityApi.html#postqualityforms) | **POST** /api/v2/quality/forms | Create an evaluation form. |
| [**PostQualityKeywordsets**](QualityApi.html#postqualitykeywordsets) | **POST** /api/v2/quality/keywordsets | Create a Keyword Set |
| [**PostQualityPublishedforms**](QualityApi.html#postqualitypublishedforms) | **POST** /api/v2/quality/publishedforms | Publish an evaluation form. |
| [**PostQualitySpotability**](QualityApi.html#postqualityspotability) | **POST** /api/v2/quality/spotability | Retrieve the spotability statistic |
| [**PutQualityCalibration**](QualityApi.html#putqualitycalibration) | **PUT** /api/v2/quality/calibrations/{calibrationId} | Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex |
| [**PutQualityConversationEvaluation**](QualityApi.html#putqualityconversationevaluation) | **PUT** /api/v2/quality/conversations/{conversationId}/evaluations/{evaluationId} | Update an evaluation |
| [**PutQualityForm**](QualityApi.html#putqualityform) | **PUT** /api/v2/quality/forms/{formId} | Update an evaluation form. |
| [**PutQualityKeywordset**](QualityApi.html#putqualitykeywordset) | **PUT** /api/v2/quality/keywordsets/{keywordSetId} | Update a keywordSet to the specified keywordSet via PUT. |
{: class="table table-striped"}

<a name="deletequalitycalibration"></a>

## [**Calibration**](Calibration.html) DeleteQualityCalibration (string calibrationId, string calibratorId)

Delete a calibration by id.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteQualityCalibrationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new QualityApi();
            
            
            var calibrationId = calibrationId_example;  // string | Calibration ID
            
            
            
            
            var calibratorId = calibratorId_example;  // string | calibratorId
            
            
            

            try
            {
                
                // Delete a calibration by id.
                
                Calibration result = apiInstance.DeleteQualityCalibration(calibrationId, calibratorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.DeleteQualityCalibration: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **calibrationId** | **string**| Calibration ID |  |
| **calibratorId** | **string**| calibratorId |  |
{: class="table table-striped"}

### Return type

[**Calibration**](Calibration.html)

<a name="deletequalityconversationevaluation"></a>

## [**Evaluation**](Evaluation.html) DeleteQualityConversationEvaluation (string conversationId, string evaluationId, string expand = null)

Delete an evaluation



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteQualityConversationEvaluationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new QualityApi();
            
            
            var conversationId = conversationId_example;  // string | conversationId
            
            
            
            
            var evaluationId = evaluationId_example;  // string | evaluationId
            
            
            
            
            var expand = expand_example;  // string | evaluatorId (optional) 
            
            
            

            try
            {
                
                // Delete an evaluation
                
                Evaluation result = apiInstance.DeleteQualityConversationEvaluation(conversationId, evaluationId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.DeleteQualityConversationEvaluation: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **evaluationId** | **string**| evaluationId |  |
| **expand** | **string**| evaluatorId | [optional]  |
{: class="table table-striped"}

### Return type

[**Evaluation**](Evaluation.html)

<a name="deletequalityform"></a>

## void DeleteQualityForm (string formId)

Delete an evaluation form.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteQualityFormExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new QualityApi();
            
            
            var formId = formId_example;  // string | Form ID
            
            
            

            try
            {
                
                // Delete an evaluation form.
                
                apiInstance.DeleteQualityForm(formId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.DeleteQualityForm: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **formId** | **string**| Form ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletequalitykeywordset"></a>

## void DeleteQualityKeywordset (string keywordSetId)

Delete a keywordSet by id.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteQualityKeywordsetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new QualityApi();
            
            
            var keywordSetId = keywordSetId_example;  // string | KeywordSet ID
            
            
            

            try
            {
                
                // Delete a keywordSet by id.
                
                apiInstance.DeleteQualityKeywordset(keywordSetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.DeleteQualityKeywordset: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **keywordSetId** | **string**| KeywordSet ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletequalitykeywordsets"></a>

## void DeleteQualityKeywordsets (string ids)

Delete keyword sets

Bulk delete of keyword sets; this will only delete the keyword sets that match the ids specified in the query param.

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteQualityKeywordsetsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new QualityApi();
            
            
            var ids = ids_example;  // string | A comma-delimited list of valid KeywordSet ids
            
            
            

            try
            {
                
                // Delete keyword sets
                
                apiInstance.DeleteQualityKeywordsets(ids);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.DeleteQualityKeywordsets: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ids** | **string**| A comma-delimited list of valid KeywordSet ids |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getqualityagentsactivity"></a>

## [**AgentActivityEntityListing**](AgentActivityEntityListing.html) GetQualityAgentsActivity (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, List<Object> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null)

Gets a list of Agent Activities

Including the number of evaluations and average evaluation score

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetQualityAgentsActivityExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new QualityApi();
            
            
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            
            
            
            
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            
            
            
            
            
            var expand = new List<Object>(); // List<Object> | variable name requested by expand list (optional) 
            
            
            
            var nextPage = nextPage_example;  // string | next page token (optional) 
            
            
            
            
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            
            
            
            
            var startTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional) 
            
            
            
            
            var endTime = 2013-10-20T19:20:30+01:00;  // DateTime? | End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional) 
            
            
            
            
            
            var agentUserId = new List<Object>(); // List<Object> | user id of agent requested (optional) 
            
            
            
            var evaluatorUserId = evaluatorUserId_example;  // string | user id of the evaluator (optional) 
            
            
            
            
            var name = name_example;  // string | name (optional) 
            
            
            
            
            var group = group_example;  // string | group id (optional) 
            
            
            

            try
            {
                
                // Gets a list of Agent Activities
                
                AgentActivityEntityListing result = apiInstance.GetQualityAgentsActivity(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, startTime, endTime, agentUserId, evaluatorUserId, name, group);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityAgentsActivity: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<Object>**](Object.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **startTime** | **DateTime?**| Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional]  |
| **endTime** | **DateTime?**| End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional]  |
| **agentUserId** | [**List<Object>**](Object.html)| user id of agent requested | [optional]  |
| **evaluatorUserId** | **string**| user id of the evaluator | [optional]  |
| **name** | **string**| name | [optional]  |
| **group** | **string**| group id | [optional]  |
{: class="table table-striped"}

### Return type

[**AgentActivityEntityListing**](AgentActivityEntityListing.html)

<a name="getqualitycalibration"></a>

## [**Calibration**](Calibration.html) GetQualityCalibration (string calibrationId, string calibratorId = null, string conversationId = null)

Get a calibration by id.  Requires either calibrator id or conversation id



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetQualityCalibrationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new QualityApi();
            
            
            var calibrationId = calibrationId_example;  // string | Calibration ID
            
            
            
            
            var calibratorId = calibratorId_example;  // string | calibratorId (optional) 
            
            
            
            
            var conversationId = conversationId_example;  // string | conversationId (optional) 
            
            
            

            try
            {
                
                // Get a calibration by id.  Requires either calibrator id or conversation id
                
                Calibration result = apiInstance.GetQualityCalibration(calibrationId, calibratorId, conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityCalibration: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **calibrationId** | **string**| Calibration ID |  |
| **calibratorId** | **string**| calibratorId | [optional]  |
| **conversationId** | **string**| conversationId | [optional]  |
{: class="table table-striped"}

### Return type

[**Calibration**](Calibration.html)

<a name="getqualitycalibrations"></a>

## [**CalibrationEntityListing**](CalibrationEntityListing.html) GetQualityCalibrations (string calibratorId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null)

Get the list of calibrations



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetQualityCalibrationsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new QualityApi();
            
            
            var calibratorId = calibratorId_example;  // string | user id of calibrator
            
            
            
            
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            
            
            
            
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            
            
            
            
            
            var expand = new List<Object>(); // List<Object> | variable name requested by expand list (optional) 
            
            
            
            var nextPage = nextPage_example;  // string | next page token (optional) 
            
            
            
            
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            
            
            
            
            var conversationId = conversationId_example;  // string | conversation id (optional) 
            
            
            
            
            var startTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional) 
            
            
            
            
            var endTime = 2013-10-20T19:20:30+01:00;  // DateTime? | end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional) 
            
            
            

            try
            {
                
                // Get the list of calibrations
                
                CalibrationEntityListing result = apiInstance.GetQualityCalibrations(calibratorId, pageSize, pageNumber, sortBy, expand, nextPage, previousPage, conversationId, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityCalibrations: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **calibratorId** | **string**| user id of calibrator |  |
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<Object>**](Object.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **conversationId** | **string**| conversation id | [optional]  |
| **startTime** | **DateTime?**| Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional]  |
| **endTime** | **DateTime?**| end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional]  |
{: class="table table-striped"}

### Return type

[**CalibrationEntityListing**](CalibrationEntityListing.html)

<a name="getqualityconversationaudits"></a>

## [**QualityAuditPage**](QualityAuditPage.html) GetQualityConversationAudits (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string recordingId = null, string entityType = null)

Get audits for conversation or recording



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetQualityConversationAuditsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new QualityApi();
            
            
            var conversationId = conversationId_example;  // string | Conversation ID
            
            
            
            
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            
            
            
            
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            
            
            
            
            
            var expand = new List<Object>(); // List<Object> | variable name requested by expand list (optional) 
            
            
            
            var nextPage = nextPage_example;  // string | next page token (optional) 
            
            
            
            
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            
            
            
            
            var recordingId = recordingId_example;  // string | id of the recording (optional) 
            
            
            
            
            var entityType = entityType_example;  // string | entity type options: Recording, Calibration, Evaluation, Annotation, Screen_Recording (optional)  (default to RECORDING)
            
            
            

            try
            {
                
                // Get audits for conversation or recording
                
                QualityAuditPage result = apiInstance.GetQualityConversationAudits(conversationId, pageSize, pageNumber, sortBy, expand, nextPage, previousPage, recordingId, entityType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityConversationAudits: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<Object>**](Object.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **recordingId** | **string**| id of the recording | [optional]  |
| **entityType** | **string**| entity type options: Recording, Calibration, Evaluation, Annotation, Screen_Recording | [optional] [default to RECORDING] |
{: class="table table-striped"}

### Return type

[**QualityAuditPage**](QualityAuditPage.html)

<a name="getqualityconversationevaluation"></a>

## [**Evaluation**](Evaluation.html) GetQualityConversationEvaluation (string conversationId, string evaluationId, string expand = null)

Get an evaluation



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetQualityConversationEvaluationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new QualityApi();
            
            
            var conversationId = conversationId_example;  // string | conversationId
            
            
            
            
            var evaluationId = evaluationId_example;  // string | evaluationId
            
            
            
            
            var expand = expand_example;  // string | agent, evaluator, evaluationForm (optional) 
            
            
            

            try
            {
                
                // Get an evaluation
                
                Evaluation result = apiInstance.GetQualityConversationEvaluation(conversationId, evaluationId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityConversationEvaluation: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **evaluationId** | **string**| evaluationId |  |
| **expand** | **string**| agent, evaluator, evaluationForm | [optional]  |
{: class="table table-striped"}

### Return type

[**Evaluation**](Evaluation.html)

<a name="getqualityevaluationsquery"></a>

## [**EvaluationEntityListing**](EvaluationEntityListing.html) GetQualityEvaluationsQuery (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<Object> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null)

Queries Evaluations and returns a paged list

Query params must include one of conversationId, evaluatorUserId, or agentUserId

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetQualityEvaluationsQueryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new QualityApi();
            
            
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            
            
            
            
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            
            
            
            
            
            var expand = new List<Object>(); // List<Object> | variable name requested by expand list (optional) 
            
            
            
            var nextPage = nextPage_example;  // string | next page token (optional) 
            
            
            
            
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            
            
            
            
            var conversationId = conversationId_example;  // string | conversationId specified (optional) 
            
            
            
            
            var agentUserId = agentUserId_example;  // string | user id of the agent (optional) 
            
            
            
            
            var evaluatorUserId = evaluatorUserId_example;  // string | evaluator user id (optional) 
            
            
            
            
            var queueId = queueId_example;  // string | queue id (optional) 
            
            
            
            
            var startTime = startTime_example;  // string | start time of the evaluation query (optional) 
            
            
            
            
            var endTime = endTime_example;  // string | end time of the evaluation query (optional) 
            
            
            
            
            
            var evaluationState = new List<Object>(); // List<Object> | evaluation state options: Pending, InProgress, Finished (optional) 
            
            
            
            var isReleased = true;  // bool? | the evaluation has been released (optional) 
            
            
            
            
            var agentHasRead = true;  // bool? | agent has the evaluation (optional) 
            
            
            
            
            var expandAnswerTotalScores = true;  // bool? | get the total scores for evaluations (optional) 
            
            
            
            
            var maximum = 56;  // int? | maximum (optional) 
            
            
            

            try
            {
                
                // Queries Evaluations and returns a paged list
                
                EvaluationEntityListing result = apiInstance.GetQualityEvaluationsQuery(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, conversationId, agentUserId, evaluatorUserId, queueId, startTime, endTime, evaluationState, isReleased, agentHasRead, expandAnswerTotalScores, maximum);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityEvaluationsQuery: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<Object>**](Object.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **conversationId** | **string**| conversationId specified | [optional]  |
| **agentUserId** | **string**| user id of the agent | [optional]  |
| **evaluatorUserId** | **string**| evaluator user id | [optional]  |
| **queueId** | **string**| queue id | [optional]  |
| **startTime** | **string**| start time of the evaluation query | [optional]  |
| **endTime** | **string**| end time of the evaluation query | [optional]  |
| **evaluationState** | [**List<Object>**](Object.html)| evaluation state options: Pending, InProgress, Finished | [optional]  |
| **isReleased** | **bool?**| the evaluation has been released | [optional]  |
| **agentHasRead** | **bool?**| agent has the evaluation | [optional]  |
| **expandAnswerTotalScores** | **bool?**| get the total scores for evaluations | [optional]  |
| **maximum** | **int?**| maximum | [optional]  |
{: class="table table-striped"}

### Return type

[**EvaluationEntityListing**](EvaluationEntityListing.html)

<a name="getqualityevaluatorsactivity"></a>

## [**EvaluatorActivityEntityListing**](EvaluatorActivityEntityListing.html) GetQualityEvaluatorsActivity (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<Object> permission = null, string group = null)

Get an evaluator activity



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetQualityEvaluatorsActivityExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new QualityApi();
            
            
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            
            
            
            
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            
            
            
            
            
            var expand = new List<Object>(); // List<Object> | variable name requested by expand list (optional) 
            
            
            
            var nextPage = nextPage_example;  // string | next page token (optional) 
            
            
            
            
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            
            
            
            
            var startTime = 2013-10-20T19:20:30+01:00;  // DateTime? | The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional) 
            
            
            
            
            var endTime = 2013-10-20T19:20:30+01:00;  // DateTime? | The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional) 
            
            
            
            
            var name = name_example;  // string | Evaluator name (optional) 
            
            
            
            
            
            var permission = new List<Object>(); // List<Object> | permission strings (optional) 
            
            
            
            var group = group_example;  // string | group id (optional) 
            
            
            

            try
            {
                
                // Get an evaluator activity
                
                EvaluatorActivityEntityListing result = apiInstance.GetQualityEvaluatorsActivity(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, startTime, endTime, name, permission, group);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityEvaluatorsActivity: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<Object>**](Object.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **startTime** | **DateTime?**| The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional]  |
| **endTime** | **DateTime?**| The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional]  |
| **name** | **string**| Evaluator name | [optional]  |
| **permission** | [**List<Object>**](Object.html)| permission strings | [optional]  |
| **group** | **string**| group id | [optional]  |
{: class="table table-striped"}

### Return type

[**EvaluatorActivityEntityListing**](EvaluatorActivityEntityListing.html)

<a name="getqualityform"></a>

## [**EvaluationForm**](EvaluationForm.html) GetQualityForm (string formId)

Get an evaluation form



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetQualityFormExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new QualityApi();
            
            
            var formId = formId_example;  // string | Form ID
            
            
            

            try
            {
                
                // Get an evaluation form
                
                EvaluationForm result = apiInstance.GetQualityForm(formId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityForm: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **formId** | **string**| Form ID |  |
{: class="table table-striped"}

### Return type

[**EvaluationForm**](EvaluationForm.html)

<a name="getqualityformversions"></a>

## [**EvaluationFormEntityListing**](EvaluationFormEntityListing.html) GetQualityFormVersions (string formId, int? pageSize = null, int? pageNumber = null)

Gets all the revisions for a specific evaluation.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetQualityFormVersionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new QualityApi();
            
            
            var formId = formId_example;  // string | Form ID
            
            
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            

            try
            {
                
                // Gets all the revisions for a specific evaluation.
                
                EvaluationFormEntityListing result = apiInstance.GetQualityFormVersions(formId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityFormVersions: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **formId** | **string**| Form ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**EvaluationFormEntityListing**](EvaluationFormEntityListing.html)

<a name="getqualityforms"></a>

## [**EvaluationFormEntityListing**](EvaluationFormEntityListing.html) GetQualityForms (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null)

Get the list of evaluation forms



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetQualityFormsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new QualityApi();
            
            
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            
            
            
            
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            
            
            
            
            var nextPage = nextPage_example;  // string | next page token (optional) 
            
            
            
            
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            
            
            
            
            var expand = expand_example;  // string | Expand (optional) 
            
            
            
            
            var name = name_example;  // string | Name (optional) 
            
            
            

            try
            {
                
                // Get the list of evaluation forms
                
                EvaluationFormEntityListing result = apiInstance.GetQualityForms(pageSize, pageNumber, sortBy, nextPage, previousPage, expand, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityForms: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **expand** | **string**| Expand | [optional]  |
| **name** | **string**| Name | [optional]  |
{: class="table table-striped"}

### Return type

[**EvaluationFormEntityListing**](EvaluationFormEntityListing.html)

<a name="getqualitykeywordset"></a>

## [**KeywordSet**](KeywordSet.html) GetQualityKeywordset (string keywordSetId)

Get a keywordSet by id.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetQualityKeywordsetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new QualityApi();
            
            
            var keywordSetId = keywordSetId_example;  // string | KeywordSet ID
            
            
            

            try
            {
                
                // Get a keywordSet by id.
                
                KeywordSet result = apiInstance.GetQualityKeywordset(keywordSetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityKeywordset: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **keywordSetId** | **string**| KeywordSet ID |  |
{: class="table table-striped"}

### Return type

[**KeywordSet**](KeywordSet.html)

<a name="getqualitykeywordsets"></a>

## [**KeywordSetEntityListing**](KeywordSetEntityListing.html) GetQualityKeywordsets (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string name = null, string queueId = null, string agentId = null, string _operator = null)

Get the list of keyword sets



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetQualityKeywordsetsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new QualityApi();
            
            
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            
            
            
            
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            
            
            
            
            
            var expand = new List<Object>(); // List<Object> | variable name requested by expand list (optional) 
            
            
            
            var nextPage = nextPage_example;  // string | next page token (optional) 
            
            
            
            
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            
            
            
            
            var name = name_example;  // string | the keyword set name - used for filtering results in searches. (optional) 
            
            
            
            
            var queueId = queueId_example;  // string | the queue id - used for filtering results in searches. (optional) 
            
            
            
            
            var agentId = agentId_example;  // string | the agent id - used for filtering results in searches. (optional) 
            
            
            
            
            var _operator = _operator_example;  // string | If agentID and queueId are both present, this determines whether the query is an AND or OR between those parameters. (optional) 
            
            
            

            try
            {
                
                // Get the list of keyword sets
                
                KeywordSetEntityListing result = apiInstance.GetQualityKeywordsets(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, name, queueId, agentId, _operator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityKeywordsets: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<Object>**](Object.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **name** | **string**| the keyword set name - used for filtering results in searches. | [optional]  |
| **queueId** | **string**| the queue id - used for filtering results in searches. | [optional]  |
| **agentId** | **string**| the agent id - used for filtering results in searches. | [optional]  |
| **_operator** | **string**| If agentID and queueId are both present, this determines whether the query is an AND or OR between those parameters. | [optional] <br />**Values**: AND, OR |
{: class="table table-striped"}

### Return type

[**KeywordSetEntityListing**](KeywordSetEntityListing.html)

<a name="getqualitypublishedform"></a>

## [**EvaluationForm**](EvaluationForm.html) GetQualityPublishedform (string formId)

Get the published evaluation forms.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetQualityPublishedformExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new QualityApi();
            
            
            var formId = formId_example;  // string | Form ID
            
            
            

            try
            {
                
                // Get the published evaluation forms.
                
                EvaluationForm result = apiInstance.GetQualityPublishedform(formId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityPublishedform: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **formId** | **string**| Form ID |  |
{: class="table table-striped"}

### Return type

[**EvaluationForm**](EvaluationForm.html)

<a name="getqualitypublishedforms"></a>

## [**EvaluationFormEntityListing**](EvaluationFormEntityListing.html) GetQualityPublishedforms (int? pageSize = null, int? pageNumber = null, string name = null)

Get the published evaluation forms.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetQualityPublishedformsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new QualityApi();
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var name = name_example;  // string | Name (optional) 
            
            
            

            try
            {
                
                // Get the published evaluation forms.
                
                EvaluationFormEntityListing result = apiInstance.GetQualityPublishedforms(pageSize, pageNumber, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityPublishedforms: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **name** | **string**| Name | [optional]  |
{: class="table table-striped"}

### Return type

[**EvaluationFormEntityListing**](EvaluationFormEntityListing.html)

<a name="postanalyticsevaluationsaggregatesquery"></a>

## [**AggregateQueryResponse**](AggregateQueryResponse.html) PostAnalyticsEvaluationsAggregatesQuery (AggregationQuery body)

Query for evaluation aggregates



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsEvaluationsAggregatesQueryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new QualityApi();
            
            
            
            var body = new AggregationQuery(); // AggregationQuery | query
            
            

            try
            {
                
                // Query for evaluation aggregates
                
                AggregateQueryResponse result = apiInstance.PostAnalyticsEvaluationsAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PostAnalyticsEvaluationsAggregatesQuery: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AggregationQuery**](AggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AggregateQueryResponse**](AggregateQueryResponse.html)

<a name="postqualitycalibrations"></a>

## [**Calibration**](Calibration.html) PostQualityCalibrations (CalibrationCreate body, string expand = null)

Create a calibration



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostQualityCalibrationsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new QualityApi();
            
            
            
            var body = new CalibrationCreate(); // CalibrationCreate | calibration
            
            
            
            var expand = expand_example;  // string | calibratorId (optional) 
            
            
            

            try
            {
                
                // Create a calibration
                
                Calibration result = apiInstance.PostQualityCalibrations(body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PostQualityCalibrations: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CalibrationCreate**](CalibrationCreate.html)| calibration |  |
| **expand** | **string**| calibratorId | [optional]  |
{: class="table table-striped"}

### Return type

[**Calibration**](Calibration.html)

<a name="postqualityconversationevaluations"></a>

## [**Evaluation**](Evaluation.html) PostQualityConversationEvaluations (string conversationId, Evaluation body, string expand = null)

Create an evaluation



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostQualityConversationEvaluationsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new QualityApi();
            
            
            var conversationId = conversationId_example;  // string | conversationId
            
            
            
            
            
            var body = new Evaluation(); // Evaluation | evaluation
            
            
            
            var expand = expand_example;  // string | evaluatorId (optional) 
            
            
            

            try
            {
                
                // Create an evaluation
                
                Evaluation result = apiInstance.PostQualityConversationEvaluations(conversationId, body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PostQualityConversationEvaluations: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**Evaluation**](Evaluation.html)| evaluation |  |
| **expand** | **string**| evaluatorId | [optional]  |
{: class="table table-striped"}

### Return type

[**Evaluation**](Evaluation.html)

<a name="postqualityevaluationsscoring"></a>

## [**EvaluationScoringSet**](EvaluationScoringSet.html) PostQualityEvaluationsScoring (EvaluationFormAndScoringSet body)

Score evaluation



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostQualityEvaluationsScoringExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new QualityApi();
            
            
            
            var body = new EvaluationFormAndScoringSet(); // EvaluationFormAndScoringSet | evaluationAndScoringSet
            
            

            try
            {
                
                // Score evaluation
                
                EvaluationScoringSet result = apiInstance.PostQualityEvaluationsScoring(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PostQualityEvaluationsScoring: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**EvaluationFormAndScoringSet**](EvaluationFormAndScoringSet.html)| evaluationAndScoringSet |  |
{: class="table table-striped"}

### Return type

[**EvaluationScoringSet**](EvaluationScoringSet.html)

<a name="postqualityforms"></a>

## [**EvaluationForm**](EvaluationForm.html) PostQualityForms (EvaluationForm body)

Create an evaluation form.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostQualityFormsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new QualityApi();
            
            
            
            var body = new EvaluationForm(); // EvaluationForm | Evaluation form
            
            

            try
            {
                
                // Create an evaluation form.
                
                EvaluationForm result = apiInstance.PostQualityForms(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PostQualityForms: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**EvaluationForm**](EvaluationForm.html)| Evaluation form |  |
{: class="table table-striped"}

### Return type

[**EvaluationForm**](EvaluationForm.html)

<a name="postqualitykeywordsets"></a>

## [**KeywordSet**](KeywordSet.html) PostQualityKeywordsets (KeywordSet body, string expand = null)

Create a Keyword Set



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostQualityKeywordsetsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new QualityApi();
            
            
            
            var body = new KeywordSet(); // KeywordSet | keywordSet
            
            
            
            var expand = expand_example;  // string | queueId (optional) 
            
            
            

            try
            {
                
                // Create a Keyword Set
                
                KeywordSet result = apiInstance.PostQualityKeywordsets(body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PostQualityKeywordsets: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**KeywordSet**](KeywordSet.html)| keywordSet |  |
| **expand** | **string**| queueId | [optional]  |
{: class="table table-striped"}

### Return type

[**KeywordSet**](KeywordSet.html)

<a name="postqualitypublishedforms"></a>

## [**EvaluationForm**](EvaluationForm.html) PostQualityPublishedforms (EvaluationForm body)

Publish an evaluation form.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostQualityPublishedformsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new QualityApi();
            
            
            
            var body = new EvaluationForm(); // EvaluationForm | Evaluation form
            
            

            try
            {
                
                // Publish an evaluation form.
                
                EvaluationForm result = apiInstance.PostQualityPublishedforms(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PostQualityPublishedforms: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**EvaluationForm**](EvaluationForm.html)| Evaluation form |  |
{: class="table table-striped"}

### Return type

[**EvaluationForm**](EvaluationForm.html)

<a name="postqualityspotability"></a>

## [**KeywordSet**](KeywordSet.html) PostQualitySpotability (KeywordSet body = null)

Retrieve the spotability statistic



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostQualitySpotabilityExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new QualityApi();
            
            
            
            var body = new KeywordSet(); // KeywordSet | Keyword Set (optional) 
            
            

            try
            {
                
                // Retrieve the spotability statistic
                
                KeywordSet result = apiInstance.PostQualitySpotability(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PostQualitySpotability: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**KeywordSet**](KeywordSet.html)| Keyword Set | [optional]  |
{: class="table table-striped"}

### Return type

[**KeywordSet**](KeywordSet.html)

<a name="putqualitycalibration"></a>

## [**Calibration**](Calibration.html) PutQualityCalibration (string calibrationId, Calibration body)

Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutQualityCalibrationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new QualityApi();
            
            
            var calibrationId = calibrationId_example;  // string | Calibration ID
            
            
            
            
            
            var body = new Calibration(); // Calibration | Calibration
            
            

            try
            {
                
                // Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex
                
                Calibration result = apiInstance.PutQualityCalibration(calibrationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PutQualityCalibration: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **calibrationId** | **string**| Calibration ID |  |
| **body** | [**Calibration**](Calibration.html)| Calibration |  |
{: class="table table-striped"}

### Return type

[**Calibration**](Calibration.html)

<a name="putqualityconversationevaluation"></a>

## [**Evaluation**](Evaluation.html) PutQualityConversationEvaluation (string conversationId, string evaluationId, Evaluation body, string expand = null)

Update an evaluation



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutQualityConversationEvaluationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new QualityApi();
            
            
            var conversationId = conversationId_example;  // string | conversationId
            
            
            
            
            var evaluationId = evaluationId_example;  // string | evaluationId
            
            
            
            
            
            var body = new Evaluation(); // Evaluation | evaluation
            
            
            
            var expand = expand_example;  // string | evaluatorId (optional) 
            
            
            

            try
            {
                
                // Update an evaluation
                
                Evaluation result = apiInstance.PutQualityConversationEvaluation(conversationId, evaluationId, body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PutQualityConversationEvaluation: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **evaluationId** | **string**| evaluationId |  |
| **body** | [**Evaluation**](Evaluation.html)| evaluation |  |
| **expand** | **string**| evaluatorId | [optional]  |
{: class="table table-striped"}

### Return type

[**Evaluation**](Evaluation.html)

<a name="putqualityform"></a>

## [**EvaluationForm**](EvaluationForm.html) PutQualityForm (string formId, EvaluationForm body)

Update an evaluation form.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutQualityFormExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new QualityApi();
            
            
            var formId = formId_example;  // string | Form ID
            
            
            
            
            
            var body = new EvaluationForm(); // EvaluationForm | Evaluation form
            
            

            try
            {
                
                // Update an evaluation form.
                
                EvaluationForm result = apiInstance.PutQualityForm(formId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PutQualityForm: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **formId** | **string**| Form ID |  |
| **body** | [**EvaluationForm**](EvaluationForm.html)| Evaluation form |  |
{: class="table table-striped"}

### Return type

[**EvaluationForm**](EvaluationForm.html)

<a name="putqualitykeywordset"></a>

## [**KeywordSet**](KeywordSet.html) PutQualityKeywordset (string keywordSetId, KeywordSet body)

Update a keywordSet to the specified keywordSet via PUT.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutQualityKeywordsetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new QualityApi();
            
            
            var keywordSetId = keywordSetId_example;  // string | KeywordSet ID
            
            
            
            
            
            var body = new KeywordSet(); // KeywordSet | keywordSet
            
            

            try
            {
                
                // Update a keywordSet to the specified keywordSet via PUT.
                
                KeywordSet result = apiInstance.PutQualityKeywordset(keywordSetId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PutQualityKeywordset: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **keywordSetId** | **string**| KeywordSet ID |  |
| **body** | [**KeywordSet**](KeywordSet.html)| keywordSet |  |
{: class="table table-striped"}

### Return type

[**KeywordSet**](KeywordSet.html)

