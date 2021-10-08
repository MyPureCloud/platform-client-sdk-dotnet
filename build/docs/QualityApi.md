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
| [**DeleteQualityFormsEvaluation**](QualityApi.html#deletequalityformsevaluation) | **DELETE** /api/v2/quality/forms/evaluations/{formId} | Delete an evaluation form. |
| [**DeleteQualityFormsSurvey**](QualityApi.html#deletequalityformssurvey) | **DELETE** /api/v2/quality/forms/surveys/{formId} | Delete a survey form. |
| [**GetQualityAgentsActivity**](QualityApi.html#getqualityagentsactivity) | **GET** /api/v2/quality/agents/activity | Gets a list of Agent Activities |
| [**GetQualityCalibration**](QualityApi.html#getqualitycalibration) | **GET** /api/v2/quality/calibrations/{calibrationId} | Get a calibration by id.  Requires either calibrator id or conversation id |
| [**GetQualityCalibrations**](QualityApi.html#getqualitycalibrations) | **GET** /api/v2/quality/calibrations | Get the list of calibrations |
| [**GetQualityConversationEvaluation**](QualityApi.html#getqualityconversationevaluation) | **GET** /api/v2/quality/conversations/{conversationId}/evaluations/{evaluationId} | Get an evaluation |
| [**GetQualityConversationSurveys**](QualityApi.html#getqualityconversationsurveys) | **GET** /api/v2/quality/conversations/{conversationId}/surveys | Get the surveys for a conversation |
| [**GetQualityConversationsAuditsQueryTransactionId**](QualityApi.html#getqualityconversationsauditsquerytransactionid) | **GET** /api/v2/quality/conversations/audits/query/{transactionId} | Get status of audit query execution |
| [**GetQualityConversationsAuditsQueryTransactionIdResults**](QualityApi.html#getqualityconversationsauditsquerytransactionidresults) | **GET** /api/v2/quality/conversations/audits/query/{transactionId}/results | Get results of audit query |
| [**GetQualityEvaluationsQuery**](QualityApi.html#getqualityevaluationsquery) | **GET** /api/v2/quality/evaluations/query | Queries Evaluations and returns a paged list |
| [**GetQualityEvaluatorsActivity**](QualityApi.html#getqualityevaluatorsactivity) | **GET** /api/v2/quality/evaluators/activity | Get an evaluator activity |
| [**GetQualityForm**](QualityApi.html#getqualityform) | **GET** /api/v2/quality/forms/{formId} | Get an evaluation form |
| [**GetQualityFormVersions**](QualityApi.html#getqualityformversions) | **GET** /api/v2/quality/forms/{formId}/versions | Gets all the revisions for a specific evaluation. |
| [**GetQualityForms**](QualityApi.html#getqualityforms) | **GET** /api/v2/quality/forms | Get the list of evaluation forms |
| [**GetQualityFormsEvaluation**](QualityApi.html#getqualityformsevaluation) | **GET** /api/v2/quality/forms/evaluations/{formId} | Get an evaluation form |
| [**GetQualityFormsEvaluationVersions**](QualityApi.html#getqualityformsevaluationversions) | **GET** /api/v2/quality/forms/evaluations/{formId}/versions | Gets all the revisions for a specific evaluation. |
| [**GetQualityFormsEvaluations**](QualityApi.html#getqualityformsevaluations) | **GET** /api/v2/quality/forms/evaluations | Get the list of evaluation forms |
| [**GetQualityFormsSurvey**](QualityApi.html#getqualityformssurvey) | **GET** /api/v2/quality/forms/surveys/{formId} | Get a survey form |
| [**GetQualityFormsSurveyVersions**](QualityApi.html#getqualityformssurveyversions) | **GET** /api/v2/quality/forms/surveys/{formId}/versions | Gets all the revisions for a specific survey. |
| [**GetQualityFormsSurveys**](QualityApi.html#getqualityformssurveys) | **GET** /api/v2/quality/forms/surveys | Get the list of survey forms |
| [**GetQualityFormsSurveysBulk**](QualityApi.html#getqualityformssurveysbulk) | **GET** /api/v2/quality/forms/surveys/bulk | Retrieve a list of survey forms by their ids |
| [**GetQualityFormsSurveysBulkContexts**](QualityApi.html#getqualityformssurveysbulkcontexts) | **GET** /api/v2/quality/forms/surveys/bulk/contexts | Retrieve a list of the latest form versions by context ids |
| [**GetQualityPublishedform**](QualityApi.html#getqualitypublishedform) | **GET** /api/v2/quality/publishedforms/{formId} | Get the published evaluation forms. |
| [**GetQualityPublishedforms**](QualityApi.html#getqualitypublishedforms) | **GET** /api/v2/quality/publishedforms | Get the published evaluation forms. |
| [**GetQualityPublishedformsEvaluation**](QualityApi.html#getqualitypublishedformsevaluation) | **GET** /api/v2/quality/publishedforms/evaluations/{formId} | Get the most recent published version of an evaluation form. |
| [**GetQualityPublishedformsEvaluations**](QualityApi.html#getqualitypublishedformsevaluations) | **GET** /api/v2/quality/publishedforms/evaluations | Get the published evaluation forms. |
| [**GetQualityPublishedformsSurvey**](QualityApi.html#getqualitypublishedformssurvey) | **GET** /api/v2/quality/publishedforms/surveys/{formId} | Get the most recent published version of a survey form. |
| [**GetQualityPublishedformsSurveys**](QualityApi.html#getqualitypublishedformssurveys) | **GET** /api/v2/quality/publishedforms/surveys | Get the published survey forms. |
| [**GetQualitySurvey**](QualityApi.html#getqualitysurvey) | **GET** /api/v2/quality/surveys/{surveyId} | Get a survey for a conversation |
| [**GetQualitySurveysScorable**](QualityApi.html#getqualitysurveysscorable) | **GET** /api/v2/quality/surveys/scorable | Get a survey as an end-customer, for the purposes of scoring it. |
| [**PatchQualityFormsSurvey**](QualityApi.html#patchqualityformssurvey) | **PATCH** /api/v2/quality/forms/surveys/{formId} | Disable a particular version of a survey form and invalidates any invitations that have already been sent to customers using this version of the form. |
| [**PostAnalyticsEvaluationsAggregatesQuery**](QualityApi.html#postanalyticsevaluationsaggregatesquery) | **POST** /api/v2/analytics/evaluations/aggregates/query | Query for evaluation aggregates |
| [**PostAnalyticsSurveysAggregatesQuery**](QualityApi.html#postanalyticssurveysaggregatesquery) | **POST** /api/v2/analytics/surveys/aggregates/query | Query for survey aggregates |
| [**PostQualityCalibrations**](QualityApi.html#postqualitycalibrations) | **POST** /api/v2/quality/calibrations | Create a calibration |
| [**PostQualityConversationEvaluations**](QualityApi.html#postqualityconversationevaluations) | **POST** /api/v2/quality/conversations/{conversationId}/evaluations | Create an evaluation |
| [**PostQualityConversationsAuditsQuery**](QualityApi.html#postqualityconversationsauditsquery) | **POST** /api/v2/quality/conversations/audits/query | Create audit query execution |
| [**PostQualityEvaluationsScoring**](QualityApi.html#postqualityevaluationsscoring) | **POST** /api/v2/quality/evaluations/scoring | Score evaluation |
| [**PostQualityForms**](QualityApi.html#postqualityforms) | **POST** /api/v2/quality/forms | Create an evaluation form. |
| [**PostQualityFormsEvaluations**](QualityApi.html#postqualityformsevaluations) | **POST** /api/v2/quality/forms/evaluations | Create an evaluation form. |
| [**PostQualityFormsSurveys**](QualityApi.html#postqualityformssurveys) | **POST** /api/v2/quality/forms/surveys | Create a survey form. |
| [**PostQualityPublishedforms**](QualityApi.html#postqualitypublishedforms) | **POST** /api/v2/quality/publishedforms | Publish an evaluation form. |
| [**PostQualityPublishedformsEvaluations**](QualityApi.html#postqualitypublishedformsevaluations) | **POST** /api/v2/quality/publishedforms/evaluations | Publish an evaluation form. |
| [**PostQualityPublishedformsSurveys**](QualityApi.html#postqualitypublishedformssurveys) | **POST** /api/v2/quality/publishedforms/surveys | Publish a survey form. |
| [**PostQualitySurveysScoring**](QualityApi.html#postqualitysurveysscoring) | **POST** /api/v2/quality/surveys/scoring | Score survey |
| [**PutQualityCalibration**](QualityApi.html#putqualitycalibration) | **PUT** /api/v2/quality/calibrations/{calibrationId} | Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex |
| [**PutQualityConversationEvaluation**](QualityApi.html#putqualityconversationevaluation) | **PUT** /api/v2/quality/conversations/{conversationId}/evaluations/{evaluationId} | Update an evaluation |
| [**PutQualityForm**](QualityApi.html#putqualityform) | **PUT** /api/v2/quality/forms/{formId} | Update an evaluation form. |
| [**PutQualityFormsEvaluation**](QualityApi.html#putqualityformsevaluation) | **PUT** /api/v2/quality/forms/evaluations/{formId} | Update an evaluation form. |
| [**PutQualityFormsSurvey**](QualityApi.html#putqualityformssurvey) | **PUT** /api/v2/quality/forms/surveys/{formId} | Update a survey form. |
| [**PutQualitySurveysScorable**](QualityApi.html#putqualitysurveysscorable) | **PUT** /api/v2/quality/surveys/scorable | Update a survey as an end-customer, for the purposes of scoring it. |
{: class="table table-striped"}

<a name="deletequalitycalibration"></a>

## [**Calibration**](Calibration.html) DeleteQualityCalibration (string calibrationId, string calibratorId)



Delete a calibration by id.



Requires ANY permissions: 

* quality:calibration:delete

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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



Requires ANY permissions: 

* quality:evaluation:delete

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Delete an evaluation form.



Requires ANY permissions: 

* quality:evaluationForm:delete

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **formId** | **string**| Form ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletequalityformsevaluation"></a>

## void DeleteQualityFormsEvaluation (string formId)



Delete an evaluation form.



Requires ANY permissions: 

* quality:evaluationForm:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteQualityFormsEvaluationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var formId = formId_example;  // string | Form ID

            try
            { 
                // Delete an evaluation form.
                apiInstance.DeleteQualityFormsEvaluation(formId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.DeleteQualityFormsEvaluation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **formId** | **string**| Form ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletequalityformssurvey"></a>

## void DeleteQualityFormsSurvey (string formId)



Delete a survey form.



Requires ALL permissions: 

* quality:surveyForm:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteQualityFormsSurveyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var formId = formId_example;  // string | Form ID

            try
            { 
                // Delete a survey form.
                apiInstance.DeleteQualityFormsSurvey(formId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.DeleteQualityFormsSurvey: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **formId** | **string**| Form ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getqualityagentsactivity"></a>

## [**AgentActivityEntityListing**](AgentActivityEntityListing.html) GetQualityAgentsActivity (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null)



Gets a list of Agent Activities

Includes the number of evaluations and average evaluation score. These statistics include released evaluations only when evaluatorUserId is provided. In the absence of evaluatorUserId in the request, the api excludes evaluations which are set to never release for the calculation of evaluation statistics. 

Requires ANY permissions: 

* quality:evaluation:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            var startTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Start time of agent activity based on assigned date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional) 
            var endTime = 2013-10-20T19:20:30+01:00;  // DateTime? | End time of agent activity based on assigned date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional) 
            var agentUserId = new List<string>(); // List<string> | user id of agent requested (optional) 
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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<string>**](string.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **startTime** | **DateTime?**| Start time of agent activity based on assigned date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional]  |
| **endTime** | **DateTime?**| End time of agent activity based on assigned date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional]  |
| **agentUserId** | [**List<string>**](string.html)| user id of agent requested | [optional]  |
| **evaluatorUserId** | **string**| user id of the evaluator | [optional]  |
| **name** | **string**| name | [optional]  |
| **group** | **string**| group id | [optional]  |
{: class="table table-striped"}

### Return type

[**AgentActivityEntityListing**](AgentActivityEntityListing.html)

<a name="getqualitycalibration"></a>

## [**Calibration**](Calibration.html) GetQualityCalibration (string calibrationId, string calibratorId = null, string conversationId = null)



Get a calibration by id.  Requires either calibrator id or conversation id



Requires ANY permissions: 

* quality:calibration:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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

## [**CalibrationEntityListing**](CalibrationEntityListing.html) GetQualityCalibrations (string calibratorId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null)



Get the list of calibrations



Requires ANY permissions: 

* quality:calibration:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var calibratorId = calibratorId_example;  // string | user id of calibrator
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            var conversationId = conversationId_example;  // string | conversation id (optional) 
            var startTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional) 
            var endTime = 2013-10-20T19:20:30+01:00;  // DateTime? | end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional) 

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **calibratorId** | **string**| user id of calibrator |  |
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<string>**](string.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **conversationId** | **string**| conversation id | [optional]  |
| **startTime** | **DateTime?**| Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional]  |
| **endTime** | **DateTime?**| end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional]  |
{: class="table table-striped"}

### Return type

[**CalibrationEntityListing**](CalibrationEntityListing.html)

<a name="getqualityconversationevaluation"></a>

## [**Evaluation**](Evaluation.html) GetQualityConversationEvaluation (string conversationId, string evaluationId, string expand = null)



Get an evaluation



Requires ANY permissions: 

* quality:evaluation:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **evaluationId** | **string**| evaluationId |  |
| **expand** | **string**| agent, evaluator, evaluationForm | [optional]  |
{: class="table table-striped"}

### Return type

[**Evaluation**](Evaluation.html)

<a name="getqualityconversationsurveys"></a>

## [**List&lt;Survey&gt;**](Survey.html) GetQualityConversationSurveys (string conversationId)



Get the surveys for a conversation



Requires ANY permissions: 

* quality:survey:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetQualityConversationSurveysExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            { 
                // Get the surveys for a conversation
                List<Survey> result = apiInstance.GetQualityConversationSurveys(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityConversationSurveys: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
{: class="table table-striped"}

### Return type

[**List<Survey>**](Survey.html)

<a name="getqualityconversationsauditsquerytransactionid"></a>

## [**QualityAuditQueryExecutionStatusResponse**](QualityAuditQueryExecutionStatusResponse.html) GetQualityConversationsAuditsQueryTransactionId (string transactionId)



Get status of audit query execution



Requires ALL permissions: 

* audits:interactionDetails:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetQualityConversationsAuditsQueryTransactionIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var transactionId = transactionId_example;  // string | Transaction ID

            try
            { 
                // Get status of audit query execution
                QualityAuditQueryExecutionStatusResponse result = apiInstance.GetQualityConversationsAuditsQueryTransactionId(transactionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityConversationsAuditsQueryTransactionId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **transactionId** | **string**| Transaction ID |  |
{: class="table table-striped"}

### Return type

[**QualityAuditQueryExecutionStatusResponse**](QualityAuditQueryExecutionStatusResponse.html)

<a name="getqualityconversationsauditsquerytransactionidresults"></a>

## [**QualityAuditQueryExecutionResultsResponse**](QualityAuditQueryExecutionResultsResponse.html) GetQualityConversationsAuditsQueryTransactionIdResults (string transactionId, string cursor = null, int? pageSize = null, List<string> expand = null)



Get results of audit query



Requires ALL permissions: 

* audits:interactionDetails:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetQualityConversationsAuditsQueryTransactionIdResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var transactionId = transactionId_example;  // string | Transaction ID
            var cursor = cursor_example;  // string | Indicates where to resume query results (not required for first page) (optional) 
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            { 
                // Get results of audit query
                QualityAuditQueryExecutionResultsResponse result = apiInstance.GetQualityConversationsAuditsQueryTransactionIdResults(transactionId, cursor, pageSize, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityConversationsAuditsQueryTransactionIdResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **transactionId** | **string**| Transaction ID |  |
| **cursor** | **string**| Indicates where to resume query results (not required for first page) | [optional]  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: user |
{: class="table table-striped"}

### Return type

[**QualityAuditQueryExecutionResultsResponse**](QualityAuditQueryExecutionResultsResponse.html)

<a name="getqualityevaluationsquery"></a>

## [**EvaluationEntityListing**](EvaluationEntityListing.html) GetQualityEvaluationsQuery (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null, string sortOrder = null)



Queries Evaluations and returns a paged list

Query params must include one of conversationId, evaluatorUserId, or agentUserId

Requires ANY permissions: 

* quality:evaluation:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            var conversationId = conversationId_example;  // string | conversationId specified (optional) 
            var agentUserId = agentUserId_example;  // string | user id of the agent (optional) 
            var evaluatorUserId = evaluatorUserId_example;  // string | evaluator user id (optional) 
            var queueId = queueId_example;  // string | queue id (optional) 
            var startTime = startTime_example;  // string | start time of the evaluation query (optional) 
            var endTime = endTime_example;  // string | end time of the evaluation query (optional) 
            var evaluationState = new List<string>(); // List<string> |  (optional) 
            var isReleased = true;  // bool? | the evaluation has been released (optional) 
            var agentHasRead = true;  // bool? | agent has the evaluation (optional) 
            var expandAnswerTotalScores = true;  // bool? | get the total scores for evaluations (optional) 
            var maximum = 56;  // int? | maximum (optional) 
            var sortOrder = sortOrder_example;  // string | sort order options for agentUserId or evaluatorUserId query. Valid options are 'a', 'asc', 'ascending', 'd', 'desc', 'descending' (optional) 

            try
            { 
                // Queries Evaluations and returns a paged list
                EvaluationEntityListing result = apiInstance.GetQualityEvaluationsQuery(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, conversationId, agentUserId, evaluatorUserId, queueId, startTime, endTime, evaluationState, isReleased, agentHasRead, expandAnswerTotalScores, maximum, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityEvaluationsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<string>**](string.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **conversationId** | **string**| conversationId specified | [optional]  |
| **agentUserId** | **string**| user id of the agent | [optional]  |
| **evaluatorUserId** | **string**| evaluator user id | [optional]  |
| **queueId** | **string**| queue id | [optional]  |
| **startTime** | **string**| start time of the evaluation query | [optional]  |
| **endTime** | **string**| end time of the evaluation query | [optional]  |
| **evaluationState** | [**List<string>**](string.html)|  | [optional]  |
| **isReleased** | **bool?**| the evaluation has been released | [optional]  |
| **agentHasRead** | **bool?**| agent has the evaluation | [optional]  |
| **expandAnswerTotalScores** | **bool?**| get the total scores for evaluations | [optional]  |
| **maximum** | **int?**| maximum | [optional]  |
| **sortOrder** | **string**| sort order options for agentUserId or evaluatorUserId query. Valid options are &#39;a&#39;, &#39;asc&#39;, &#39;ascending&#39;, &#39;d&#39;, &#39;desc&#39;, &#39;descending&#39; | [optional]  |
{: class="table table-striped"}

### Return type

[**EvaluationEntityListing**](EvaluationEntityListing.html)

<a name="getqualityevaluatorsactivity"></a>

## [**EvaluatorActivityEntityListing**](EvaluatorActivityEntityListing.html) GetQualityEvaluatorsActivity (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null)



Get an evaluator activity



Requires ANY permissions: 

* quality:evaluation:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            var startTime = 2013-10-20T19:20:30+01:00;  // DateTime? | The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional) 
            var endTime = 2013-10-20T19:20:30+01:00;  // DateTime? | The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional) 
            var name = name_example;  // string | Evaluator name (optional) 
            var permission = new List<string>(); // List<string> | permission strings (optional) 
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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<string>**](string.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **startTime** | **DateTime?**| The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional]  |
| **endTime** | **DateTime?**| The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional]  |
| **name** | **string**| Evaluator name | [optional]  |
| **permission** | [**List<string>**](string.html)| permission strings | [optional]  |
| **group** | **string**| group id | [optional]  |
{: class="table table-striped"}

### Return type

[**EvaluatorActivityEntityListing**](EvaluatorActivityEntityListing.html)

<a name="getqualityform"></a>

## [**EvaluationForm**](EvaluationForm.html) GetQualityForm (string formId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get an evaluation form



Requires ANY permissions: 

* quality:evaluationForm:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **formId** | **string**| Form ID |  |
{: class="table table-striped"}

### Return type

[**EvaluationForm**](EvaluationForm.html)

<a name="getqualityformversions"></a>

## [**EvaluationFormEntityListing**](EvaluationFormEntityListing.html) GetQualityFormVersions (string formId, int? pageSize = null, int? pageNumber = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Gets all the revisions for a specific evaluation.



Requires ANY permissions: 

* quality:evaluationForm:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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

## [**EvaluationFormEntityListing**](EvaluationFormEntityListing.html) GetQualityForms (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get the list of evaluation forms



Requires ANY permissions: 

* quality:evaluationForm:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            var expand = expand_example;  // string | Expand (optional) 
            var name = name_example;  // string | Name (optional) 
            var sortOrder = sortOrder_example;  // string | Order to sort results, either asc or desc (optional) 

            try
            { 
                // Get the list of evaluation forms
                EvaluationFormEntityListing result = apiInstance.GetQualityForms(pageSize, pageNumber, sortBy, nextPage, previousPage, expand, name, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityForms: " + e.Message );
            }
        }
    }
}
```

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
| **sortOrder** | **string**| Order to sort results, either asc or desc | [optional]  |
{: class="table table-striped"}

### Return type

[**EvaluationFormEntityListing**](EvaluationFormEntityListing.html)

<a name="getqualityformsevaluation"></a>

## [**EvaluationForm**](EvaluationForm.html) GetQualityFormsEvaluation (string formId)



Get an evaluation form



Requires ANY permissions: 

* quality:evaluationForm:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetQualityFormsEvaluationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var formId = formId_example;  // string | Form ID

            try
            { 
                // Get an evaluation form
                EvaluationForm result = apiInstance.GetQualityFormsEvaluation(formId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityFormsEvaluation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **formId** | **string**| Form ID |  |
{: class="table table-striped"}

### Return type

[**EvaluationForm**](EvaluationForm.html)

<a name="getqualityformsevaluationversions"></a>

## [**EvaluationFormEntityListing**](EvaluationFormEntityListing.html) GetQualityFormsEvaluationVersions (string formId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)



Gets all the revisions for a specific evaluation.



Requires ANY permissions: 

* quality:evaluationForm:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetQualityFormsEvaluationVersionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var formId = formId_example;  // string | Form ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to asc)

            try
            { 
                // Gets all the revisions for a specific evaluation.
                EvaluationFormEntityListing result = apiInstance.GetQualityFormsEvaluationVersions(formId, pageSize, pageNumber, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityFormsEvaluationVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **formId** | **string**| Form ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortOrder** | **string**| Sort order | [optional] [default to asc] |
{: class="table table-striped"}

### Return type

[**EvaluationFormEntityListing**](EvaluationFormEntityListing.html)

<a name="getqualityformsevaluations"></a>

## [**EvaluationFormEntityListing**](EvaluationFormEntityListing.html) GetQualityFormsEvaluations (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null)



Get the list of evaluation forms



Requires ANY permissions: 

* quality:evaluationForm:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetQualityFormsEvaluationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            var expand = expand_example;  // string | Expand (optional) 
            var name = name_example;  // string | Name (optional) 
            var sortOrder = sortOrder_example;  // string | Order to sort results, either asc or desc (optional) 

            try
            { 
                // Get the list of evaluation forms
                EvaluationFormEntityListing result = apiInstance.GetQualityFormsEvaluations(pageSize, pageNumber, sortBy, nextPage, previousPage, expand, name, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityFormsEvaluations: " + e.Message );
            }
        }
    }
}
```

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
| **sortOrder** | **string**| Order to sort results, either asc or desc | [optional]  |
{: class="table table-striped"}

### Return type

[**EvaluationFormEntityListing**](EvaluationFormEntityListing.html)

<a name="getqualityformssurvey"></a>

## [**SurveyForm**](SurveyForm.html) GetQualityFormsSurvey (string formId)



Get a survey form



Requires ALL permissions: 

* quality:surveyForm:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetQualityFormsSurveyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var formId = formId_example;  // string | Form ID

            try
            { 
                // Get a survey form
                SurveyForm result = apiInstance.GetQualityFormsSurvey(formId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityFormsSurvey: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **formId** | **string**| Form ID |  |
{: class="table table-striped"}

### Return type

[**SurveyForm**](SurveyForm.html)

<a name="getqualityformssurveyversions"></a>

## [**SurveyFormEntityListing**](SurveyFormEntityListing.html) GetQualityFormsSurveyVersions (string formId, int? pageSize = null, int? pageNumber = null)



Gets all the revisions for a specific survey.



Requires ALL permissions: 

* quality:surveyForm:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetQualityFormsSurveyVersionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var formId = formId_example;  // string | Form ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Gets all the revisions for a specific survey.
                SurveyFormEntityListing result = apiInstance.GetQualityFormsSurveyVersions(formId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityFormsSurveyVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **formId** | **string**| Form ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**SurveyFormEntityListing**](SurveyFormEntityListing.html)

<a name="getqualityformssurveys"></a>

## [**SurveyFormEntityListing**](SurveyFormEntityListing.html) GetQualityFormsSurveys (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null)



Get the list of survey forms



Requires ALL permissions: 

* quality:surveyForm:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetQualityFormsSurveysExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            var expand = expand_example;  // string | Expand (optional) 
            var name = name_example;  // string | Name (optional) 
            var sortOrder = sortOrder_example;  // string | Order to sort results, either asc or desc (optional) 

            try
            { 
                // Get the list of survey forms
                SurveyFormEntityListing result = apiInstance.GetQualityFormsSurveys(pageSize, pageNumber, sortBy, nextPage, previousPage, expand, name, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityFormsSurveys: " + e.Message );
            }
        }
    }
}
```

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
| **sortOrder** | **string**| Order to sort results, either asc or desc | [optional]  |
{: class="table table-striped"}

### Return type

[**SurveyFormEntityListing**](SurveyFormEntityListing.html)

<a name="getqualityformssurveysbulk"></a>

## [**SurveyFormEntityListing**](SurveyFormEntityListing.html) GetQualityFormsSurveysBulk (List<string> id)



Retrieve a list of survey forms by their ids



Requires ALL permissions: 

* quality:surveyForm:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetQualityFormsSurveysBulkExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var id = new List<string>(); // List<string> | A comma-delimited list of valid survey form ids

            try
            { 
                // Retrieve a list of survey forms by their ids
                SurveyFormEntityListing result = apiInstance.GetQualityFormsSurveysBulk(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityFormsSurveysBulk: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | [**List<string>**](string.html)| A comma-delimited list of valid survey form ids |  |
{: class="table table-striped"}

### Return type

[**SurveyFormEntityListing**](SurveyFormEntityListing.html)

<a name="getqualityformssurveysbulkcontexts"></a>

## [**List&lt;SurveyForm&gt;**](SurveyForm.html) GetQualityFormsSurveysBulkContexts (List<string> contextId, bool? published = null)



Retrieve a list of the latest form versions by context ids



Requires ALL permissions: 

* quality:surveyForm:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetQualityFormsSurveysBulkContextsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var contextId = new List<string>(); // List<string> | A comma-delimited list of valid survey form context ids
            var published = true;  // bool? | If true, the latest published version will be included. If false, only the unpublished version will be included. (optional)  (default to true)

            try
            { 
                // Retrieve a list of the latest form versions by context ids
                List<SurveyForm> result = apiInstance.GetQualityFormsSurveysBulkContexts(contextId, published);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityFormsSurveysBulkContexts: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contextId** | [**List<string>**](string.html)| A comma-delimited list of valid survey form context ids |  |
| **published** | **bool?**| If true, the latest published version will be included. If false, only the unpublished version will be included. | [optional] [default to true] |
{: class="table table-striped"}

### Return type

[**List<SurveyForm>**](SurveyForm.html)

<a name="getqualitypublishedform"></a>

## [**EvaluationForm**](EvaluationForm.html) GetQualityPublishedform (string formId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get the published evaluation forms.



Requires ANY permissions: 

* quality:evaluationForm:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **formId** | **string**| Form ID |  |
{: class="table table-striped"}

### Return type

[**EvaluationForm**](EvaluationForm.html)

<a name="getqualitypublishedforms"></a>

## [**EvaluationFormEntityListing**](EvaluationFormEntityListing.html) GetQualityPublishedforms (int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestPerContext = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get the published evaluation forms.



Requires ANY permissions: 

* quality:evaluationForm:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var name = name_example;  // string | Name (optional) 
            var onlyLatestPerContext = true;  // bool? | onlyLatestPerContext (optional)  (default to false)

            try
            { 
                // Get the published evaluation forms.
                EvaluationFormEntityListing result = apiInstance.GetQualityPublishedforms(pageSize, pageNumber, name, onlyLatestPerContext);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityPublishedforms: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **name** | **string**| Name | [optional]  |
| **onlyLatestPerContext** | **bool?**| onlyLatestPerContext | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**EvaluationFormEntityListing**](EvaluationFormEntityListing.html)

<a name="getqualitypublishedformsevaluation"></a>

## [**EvaluationForm**](EvaluationForm.html) GetQualityPublishedformsEvaluation (string formId)



Get the most recent published version of an evaluation form.



Requires ANY permissions: 

* quality:evaluationForm:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetQualityPublishedformsEvaluationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var formId = formId_example;  // string | Form ID

            try
            { 
                // Get the most recent published version of an evaluation form.
                EvaluationForm result = apiInstance.GetQualityPublishedformsEvaluation(formId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityPublishedformsEvaluation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **formId** | **string**| Form ID |  |
{: class="table table-striped"}

### Return type

[**EvaluationForm**](EvaluationForm.html)

<a name="getqualitypublishedformsevaluations"></a>

## [**EvaluationFormEntityListing**](EvaluationFormEntityListing.html) GetQualityPublishedformsEvaluations (int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestPerContext = null)



Get the published evaluation forms.



Requires ANY permissions: 

* quality:evaluationForm:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetQualityPublishedformsEvaluationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var name = name_example;  // string | Name (optional) 
            var onlyLatestPerContext = true;  // bool? | onlyLatestPerContext (optional)  (default to false)

            try
            { 
                // Get the published evaluation forms.
                EvaluationFormEntityListing result = apiInstance.GetQualityPublishedformsEvaluations(pageSize, pageNumber, name, onlyLatestPerContext);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityPublishedformsEvaluations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **name** | **string**| Name | [optional]  |
| **onlyLatestPerContext** | **bool?**| onlyLatestPerContext | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**EvaluationFormEntityListing**](EvaluationFormEntityListing.html)

<a name="getqualitypublishedformssurvey"></a>

## [**SurveyForm**](SurveyForm.html) GetQualityPublishedformsSurvey (string formId)



Get the most recent published version of a survey form.



Requires ALL permissions: 

* quality:surveyForm:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetQualityPublishedformsSurveyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var formId = formId_example;  // string | Form ID

            try
            { 
                // Get the most recent published version of a survey form.
                SurveyForm result = apiInstance.GetQualityPublishedformsSurvey(formId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityPublishedformsSurvey: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **formId** | **string**| Form ID |  |
{: class="table table-striped"}

### Return type

[**SurveyForm**](SurveyForm.html)

<a name="getqualitypublishedformssurveys"></a>

## [**SurveyFormEntityListing**](SurveyFormEntityListing.html) GetQualityPublishedformsSurveys (int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestEnabledPerContext = null)



Get the published survey forms.



Requires ALL permissions: 

* quality:surveyForm:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetQualityPublishedformsSurveysExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var name = name_example;  // string | Name (optional) 
            var onlyLatestEnabledPerContext = true;  // bool? | onlyLatestEnabledPerContext (optional)  (default to false)

            try
            { 
                // Get the published survey forms.
                SurveyFormEntityListing result = apiInstance.GetQualityPublishedformsSurveys(pageSize, pageNumber, name, onlyLatestEnabledPerContext);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityPublishedformsSurveys: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **name** | **string**| Name | [optional]  |
| **onlyLatestEnabledPerContext** | **bool?**| onlyLatestEnabledPerContext | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**SurveyFormEntityListing**](SurveyFormEntityListing.html)

<a name="getqualitysurvey"></a>

## [**Survey**](Survey.html) GetQualitySurvey (string surveyId)



Get a survey for a conversation



Requires ANY permissions: 

* quality:survey:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetQualitySurveyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var surveyId = surveyId_example;  // string | surveyId

            try
            { 
                // Get a survey for a conversation
                Survey result = apiInstance.GetQualitySurvey(surveyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualitySurvey: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **surveyId** | **string**| surveyId |  |
{: class="table table-striped"}

### Return type

[**Survey**](Survey.html)

<a name="getqualitysurveysscorable"></a>

## [**ScorableSurvey**](ScorableSurvey.html) GetQualitySurveysScorable (string customerSurveyUrl)



Get a survey as an end-customer, for the purposes of scoring it.



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
    public class GetQualitySurveysScorableExample
    {
        public void main()
        { 

            var apiInstance = new QualityApi();
            var customerSurveyUrl = customerSurveyUrl_example;  // string | customerSurveyUrl

            try
            { 
                // Get a survey as an end-customer, for the purposes of scoring it.
                ScorableSurvey result = apiInstance.GetQualitySurveysScorable(customerSurveyUrl);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualitySurveysScorable: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **customerSurveyUrl** | **string**| customerSurveyUrl |  |
{: class="table table-striped"}

### Return type

[**ScorableSurvey**](ScorableSurvey.html)

<a name="patchqualityformssurvey"></a>

## [**SurveyForm**](SurveyForm.html) PatchQualityFormsSurvey (string formId, SurveyForm body)



Disable a particular version of a survey form and invalidates any invitations that have already been sent to customers using this version of the form.



Requires ALL permissions: 

* quality:surveyForm:disable

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchQualityFormsSurveyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var formId = formId_example;  // string | Form ID
            var body = new SurveyForm(); // SurveyForm | Survey form

            try
            { 
                // Disable a particular version of a survey form and invalidates any invitations that have already been sent to customers using this version of the form.
                SurveyForm result = apiInstance.PatchQualityFormsSurvey(formId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PatchQualityFormsSurvey: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **formId** | **string**| Form ID |  |
| **body** | [**SurveyForm**](SurveyForm.html)| Survey form |  |
{: class="table table-striped"}

### Return type

[**SurveyForm**](SurveyForm.html)

<a name="postanalyticsevaluationsaggregatesquery"></a>

## [**EvaluationAggregateQueryResponse**](EvaluationAggregateQueryResponse.html) PostAnalyticsEvaluationsAggregatesQuery (EvaluationAggregationQuery body)



Query for evaluation aggregates



Requires ANY permissions: 

* analytics:evaluationAggregate:view

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var body = new EvaluationAggregationQuery(); // EvaluationAggregationQuery | query

            try
            { 
                // Query for evaluation aggregates
                EvaluationAggregateQueryResponse result = apiInstance.PostAnalyticsEvaluationsAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PostAnalyticsEvaluationsAggregatesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**EvaluationAggregationQuery**](EvaluationAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**EvaluationAggregateQueryResponse**](EvaluationAggregateQueryResponse.html)

<a name="postanalyticssurveysaggregatesquery"></a>

## [**SurveyAggregateQueryResponse**](SurveyAggregateQueryResponse.html) PostAnalyticsSurveysAggregatesQuery (SurveyAggregationQuery body)



Query for survey aggregates



Requires ANY permissions: 

* analytics:surveyAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsSurveysAggregatesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var body = new SurveyAggregationQuery(); // SurveyAggregationQuery | query

            try
            { 
                // Query for survey aggregates
                SurveyAggregateQueryResponse result = apiInstance.PostAnalyticsSurveysAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PostAnalyticsSurveysAggregatesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SurveyAggregationQuery**](SurveyAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**SurveyAggregateQueryResponse**](SurveyAggregateQueryResponse.html)

<a name="postqualitycalibrations"></a>

## [**Calibration**](Calibration.html) PostQualityCalibrations (CalibrationCreate body, string expand = null)



Create a calibration



Requires ANY permissions: 

* quality:calibration:add

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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



Requires ANY permissions: 

* quality:evaluation:add

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**Evaluation**](Evaluation.html)| evaluation |  |
| **expand** | **string**| evaluatorId | [optional]  |
{: class="table table-striped"}

### Return type

[**Evaluation**](Evaluation.html)

<a name="postqualityconversationsauditsquery"></a>

## [**QualityAuditQueryExecutionStatusResponse**](QualityAuditQueryExecutionStatusResponse.html) PostQualityConversationsAuditsQuery (QMAuditQueryRequest body)



Create audit query execution



Requires ALL permissions: 

* audits:interactionDetails:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostQualityConversationsAuditsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var body = new QMAuditQueryRequest(); // QMAuditQueryRequest | query

            try
            { 
                // Create audit query execution
                QualityAuditQueryExecutionStatusResponse result = apiInstance.PostQualityConversationsAuditsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PostQualityConversationsAuditsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**QMAuditQueryRequest**](QMAuditQueryRequest.html)| query |  |
{: class="table table-striped"}

### Return type

[**QualityAuditQueryExecutionStatusResponse**](QualityAuditQueryExecutionStatusResponse.html)

<a name="postqualityevaluationsscoring"></a>

## [**EvaluationScoringSet**](EvaluationScoringSet.html) PostQualityEvaluationsScoring (EvaluationFormAndScoringSet body)



Score evaluation



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
    public class PostQualityEvaluationsScoringExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**EvaluationFormAndScoringSet**](EvaluationFormAndScoringSet.html)| evaluationAndScoringSet |  |
{: class="table table-striped"}

### Return type

[**EvaluationScoringSet**](EvaluationScoringSet.html)

<a name="postqualityforms"></a>

## [**EvaluationForm**](EvaluationForm.html) PostQualityForms (EvaluationForm body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Create an evaluation form.



Requires ANY permissions: 

* quality:evaluationForm:add

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**EvaluationForm**](EvaluationForm.html)| Evaluation form |  |
{: class="table table-striped"}

### Return type

[**EvaluationForm**](EvaluationForm.html)

<a name="postqualityformsevaluations"></a>

## [**EvaluationForm**](EvaluationForm.html) PostQualityFormsEvaluations (EvaluationForm body)



Create an evaluation form.



Requires ANY permissions: 

* quality:evaluationForm:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostQualityFormsEvaluationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var body = new EvaluationForm(); // EvaluationForm | Evaluation form

            try
            { 
                // Create an evaluation form.
                EvaluationForm result = apiInstance.PostQualityFormsEvaluations(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PostQualityFormsEvaluations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**EvaluationForm**](EvaluationForm.html)| Evaluation form |  |
{: class="table table-striped"}

### Return type

[**EvaluationForm**](EvaluationForm.html)

<a name="postqualityformssurveys"></a>

## [**SurveyForm**](SurveyForm.html) PostQualityFormsSurveys (SurveyForm body)



Create a survey form.



Requires ALL permissions: 

* quality:surveyForm:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostQualityFormsSurveysExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var body = new SurveyForm(); // SurveyForm | Survey form

            try
            { 
                // Create a survey form.
                SurveyForm result = apiInstance.PostQualityFormsSurveys(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PostQualityFormsSurveys: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SurveyForm**](SurveyForm.html)| Survey form |  |
{: class="table table-striped"}

### Return type

[**SurveyForm**](SurveyForm.html)

<a name="postqualitypublishedforms"></a>

## [**EvaluationForm**](EvaluationForm.html) PostQualityPublishedforms (PublishForm body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Publish an evaluation form.



Requires ANY permissions: 

* quality:evaluationForm:add

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var body = new PublishForm(); // PublishForm | Publish request containing id of form to publish

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**PublishForm**](PublishForm.html)| Publish request containing id of form to publish |  |
{: class="table table-striped"}

### Return type

[**EvaluationForm**](EvaluationForm.html)

<a name="postqualitypublishedformsevaluations"></a>

## [**EvaluationForm**](EvaluationForm.html) PostQualityPublishedformsEvaluations (PublishForm body)



Publish an evaluation form.



Requires ANY permissions: 

* quality:evaluationForm:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostQualityPublishedformsEvaluationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var body = new PublishForm(); // PublishForm | Publish request containing id of form to publish

            try
            { 
                // Publish an evaluation form.
                EvaluationForm result = apiInstance.PostQualityPublishedformsEvaluations(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PostQualityPublishedformsEvaluations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**PublishForm**](PublishForm.html)| Publish request containing id of form to publish |  |
{: class="table table-striped"}

### Return type

[**EvaluationForm**](EvaluationForm.html)

<a name="postqualitypublishedformssurveys"></a>

## [**SurveyForm**](SurveyForm.html) PostQualityPublishedformsSurveys (PublishForm body)



Publish a survey form.



Requires ALL permissions: 

* quality:surveyForm:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostQualityPublishedformsSurveysExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var body = new PublishForm(); // PublishForm | Survey form

            try
            { 
                // Publish a survey form.
                SurveyForm result = apiInstance.PostQualityPublishedformsSurveys(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PostQualityPublishedformsSurveys: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**PublishForm**](PublishForm.html)| Survey form |  |
{: class="table table-striped"}

### Return type

[**SurveyForm**](SurveyForm.html)

<a name="postqualitysurveysscoring"></a>

## [**SurveyScoringSet**](SurveyScoringSet.html) PostQualitySurveysScoring (SurveyFormAndScoringSet body)



Score survey



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
    public class PostQualitySurveysScoringExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var body = new SurveyFormAndScoringSet(); // SurveyFormAndScoringSet | surveyAndScoringSet

            try
            { 
                // Score survey
                SurveyScoringSet result = apiInstance.PostQualitySurveysScoring(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PostQualitySurveysScoring: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SurveyFormAndScoringSet**](SurveyFormAndScoringSet.html)| surveyAndScoringSet |  |
{: class="table table-striped"}

### Return type

[**SurveyScoringSet**](SurveyScoringSet.html)

<a name="putqualitycalibration"></a>

## [**Calibration**](Calibration.html) PutQualityCalibration (string calibrationId, Calibration body)



Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex



Requires ANY permissions: 

* quality:calibration:edit

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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

The quality:evaluation:edit permission allows modification of most fields, while the quality:evaluation:editScore permission allows an evaluator to change just the question scores, and the quality:evaluation:editAgentSignoff permission allows an agent to change the agent comments and sign off on the evaluation.

Requires ANY permissions: 

* quality:evaluation:edit
* quality:evaluation:editScore
* quality:evaluation:editAgentSignoff

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

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

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Update an evaluation form.



Requires ANY permissions: 

* quality:evaluationForm:edit

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **formId** | **string**| Form ID |  |
| **body** | [**EvaluationForm**](EvaluationForm.html)| Evaluation form |  |
{: class="table table-striped"}

### Return type

[**EvaluationForm**](EvaluationForm.html)

<a name="putqualityformsevaluation"></a>

## [**EvaluationForm**](EvaluationForm.html) PutQualityFormsEvaluation (string formId, EvaluationForm body)



Update an evaluation form.



Requires ANY permissions: 

* quality:evaluationForm:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutQualityFormsEvaluationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var formId = formId_example;  // string | Form ID
            var body = new EvaluationForm(); // EvaluationForm | Evaluation form

            try
            { 
                // Update an evaluation form.
                EvaluationForm result = apiInstance.PutQualityFormsEvaluation(formId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PutQualityFormsEvaluation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **formId** | **string**| Form ID |  |
| **body** | [**EvaluationForm**](EvaluationForm.html)| Evaluation form |  |
{: class="table table-striped"}

### Return type

[**EvaluationForm**](EvaluationForm.html)

<a name="putqualityformssurvey"></a>

## [**SurveyForm**](SurveyForm.html) PutQualityFormsSurvey (string formId, SurveyForm body)



Update a survey form.



Requires ALL permissions: 

* quality:surveyForm:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutQualityFormsSurveyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new QualityApi();
            var formId = formId_example;  // string | Form ID
            var body = new SurveyForm(); // SurveyForm | Survey form

            try
            { 
                // Update a survey form.
                SurveyForm result = apiInstance.PutQualityFormsSurvey(formId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PutQualityFormsSurvey: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **formId** | **string**| Form ID |  |
| **body** | [**SurveyForm**](SurveyForm.html)| Survey form |  |
{: class="table table-striped"}

### Return type

[**SurveyForm**](SurveyForm.html)

<a name="putqualitysurveysscorable"></a>

## [**ScorableSurvey**](ScorableSurvey.html) PutQualitySurveysScorable (ScorableSurvey body, string customerSurveyUrl)



Update a survey as an end-customer, for the purposes of scoring it.



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
    public class PutQualitySurveysScorableExample
    {
        public void main()
        { 

            var apiInstance = new QualityApi();
            var body = new ScorableSurvey(); // ScorableSurvey | survey
            var customerSurveyUrl = customerSurveyUrl_example;  // string | customerSurveyUrl

            try
            { 
                // Update a survey as an end-customer, for the purposes of scoring it.
                ScorableSurvey result = apiInstance.PutQualitySurveysScorable(body, customerSurveyUrl);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PutQualitySurveysScorable: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ScorableSurvey**](ScorableSurvey.html)| survey |  |
| **customerSurveyUrl** | **string**| customerSurveyUrl |  |
{: class="table table-striped"}

### Return type

[**ScorableSurvey**](ScorableSurvey.html)

