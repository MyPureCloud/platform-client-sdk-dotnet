# QualityApi

## PureCloudPlatform.Client.V2.Api.QualityApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteQualityCalibration**](#DeleteQualityCalibration) | **Delete** /api/v2/quality/calibrations/{calibrationId} | Delete a calibration by id. |
| [**DeleteQualityConversationEvaluation**](#DeleteQualityConversationEvaluation) | **Delete** /api/v2/quality/conversations/{conversationId}/evaluations/{evaluationId} | Delete an evaluation |
| [**DeleteQualityForm**](#DeleteQualityForm) | **Delete** /api/v2/quality/forms/{formId} | Delete an evaluation form. |
| [**DeleteQualityFormsEvaluation**](#DeleteQualityFormsEvaluation) | **Delete** /api/v2/quality/forms/evaluations/{formId} | Delete an evaluation form. |
| [**DeleteQualityFormsSurvey**](#DeleteQualityFormsSurvey) | **Delete** /api/v2/quality/forms/surveys/{formId} | Delete a survey form. |
| [**GetAnalyticsEvaluationsAggregatesJob**](#GetAnalyticsEvaluationsAggregatesJob) | **Get** /api/v2/analytics/evaluations/aggregates/jobs/{jobId} | Get status for async query for evaluation aggregates |
| [**GetAnalyticsEvaluationsAggregatesJobResults**](#GetAnalyticsEvaluationsAggregatesJobResults) | **Get** /api/v2/analytics/evaluations/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetAnalyticsSurveysAggregatesJob**](#GetAnalyticsSurveysAggregatesJob) | **Get** /api/v2/analytics/surveys/aggregates/jobs/{jobId} | Get status for async query for survey aggregates |
| [**GetAnalyticsSurveysAggregatesJobResults**](#GetAnalyticsSurveysAggregatesJobResults) | **Get** /api/v2/analytics/surveys/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetQualityAgentsActivity**](#GetQualityAgentsActivity) | **Get** /api/v2/quality/agents/activity | Gets a list of Agent Activities |
| [**GetQualityCalibration**](#GetQualityCalibration) | **Get** /api/v2/quality/calibrations/{calibrationId} | Get a calibration by id.  Requires either calibrator id or conversation id |
| [**GetQualityCalibrations**](#GetQualityCalibrations) | **Get** /api/v2/quality/calibrations | Get the list of calibrations |
| [**GetQualityConversationEvaluation**](#GetQualityConversationEvaluation) | **Get** /api/v2/quality/conversations/{conversationId}/evaluations/{evaluationId} | Get an evaluation |
| [**GetQualityConversationSurveys**](#GetQualityConversationSurveys) | **Get** /api/v2/quality/conversations/{conversationId}/surveys | Get the surveys for a conversation |
| [**GetQualityConversationsAuditsQueryTransactionId**](#GetQualityConversationsAuditsQueryTransactionId) | **Get** /api/v2/quality/conversations/audits/query/{transactionId} | Get status of audit query execution |
| [**GetQualityConversationsAuditsQueryTransactionIdResults**](#GetQualityConversationsAuditsQueryTransactionIdResults) | **Get** /api/v2/quality/conversations/audits/query/{transactionId}/results | Get results of audit query |
| [**GetQualityEvaluationsQuery**](#GetQualityEvaluationsQuery) | **Get** /api/v2/quality/evaluations/query | Queries Evaluations and returns a paged list |
| [**GetQualityEvaluatorsActivity**](#GetQualityEvaluatorsActivity) | **Get** /api/v2/quality/evaluators/activity | Get an evaluator activity |
| [**GetQualityForm**](#GetQualityForm) | **Get** /api/v2/quality/forms/{formId} | Get an evaluation form |
| [**GetQualityFormVersions**](#GetQualityFormVersions) | **Get** /api/v2/quality/forms/{formId}/versions | Gets all the revisions for a specific evaluation. |
| [**GetQualityForms**](#GetQualityForms) | **Get** /api/v2/quality/forms | Get the list of evaluation forms. If you set \&quot;expand&#x3D;publishHistory\&quot;, then you will be able to get published versions for each corresponding evaluation form. |
| [**GetQualityFormsEvaluation**](#GetQualityFormsEvaluation) | **Get** /api/v2/quality/forms/evaluations/{formId} | Get an evaluation form |
| [**GetQualityFormsEvaluationVersions**](#GetQualityFormsEvaluationVersions) | **Get** /api/v2/quality/forms/evaluations/{formId}/versions | Gets all the revisions for a specific evaluation. |
| [**GetQualityFormsEvaluations**](#GetQualityFormsEvaluations) | **Get** /api/v2/quality/forms/evaluations | Get the list of evaluation forms |
| [**GetQualityFormsEvaluationsBulkContexts**](#GetQualityFormsEvaluationsBulkContexts) | **Get** /api/v2/quality/forms/evaluations/bulk/contexts | Retrieve a list of the latest published evaluation form versions by context ids |
| [**GetQualityFormsSurvey**](#GetQualityFormsSurvey) | **Get** /api/v2/quality/forms/surveys/{formId} | Get a survey form |
| [**GetQualityFormsSurveyVersions**](#GetQualityFormsSurveyVersions) | **Get** /api/v2/quality/forms/surveys/{formId}/versions | Gets all the revisions for a specific survey. |
| [**GetQualityFormsSurveys**](#GetQualityFormsSurveys) | **Get** /api/v2/quality/forms/surveys | Get the list of survey forms. If you set \&quot;expand&#x3D;publishHistory\&quot;, then you will be able to get published versions for each corresponding survey form. |
| [**GetQualityFormsSurveysBulk**](#GetQualityFormsSurveysBulk) | **Get** /api/v2/quality/forms/surveys/bulk | Retrieve a list of survey forms by their ids |
| [**GetQualityFormsSurveysBulkContexts**](#GetQualityFormsSurveysBulkContexts) | **Get** /api/v2/quality/forms/surveys/bulk/contexts | Retrieve a list of the latest form versions by context ids |
| [**GetQualityPublishedform**](#GetQualityPublishedform) | **Get** /api/v2/quality/publishedforms/{formId} | Get the published evaluation forms. |
| [**GetQualityPublishedforms**](#GetQualityPublishedforms) | **Get** /api/v2/quality/publishedforms | Get the published evaluation forms. |
| [**GetQualityPublishedformsEvaluation**](#GetQualityPublishedformsEvaluation) | **Get** /api/v2/quality/publishedforms/evaluations/{formId} | Get the most recent published version of an evaluation form. |
| [**GetQualityPublishedformsEvaluations**](#GetQualityPublishedformsEvaluations) | **Get** /api/v2/quality/publishedforms/evaluations | Get the published evaluation forms. |
| [**GetQualityPublishedformsSurvey**](#GetQualityPublishedformsSurvey) | **Get** /api/v2/quality/publishedforms/surveys/{formId} | Get the most recent published version of a survey form. |
| [**GetQualityPublishedformsSurveys**](#GetQualityPublishedformsSurveys) | **Get** /api/v2/quality/publishedforms/surveys | Get the published survey forms. |
| [**GetQualitySurvey**](#GetQualitySurvey) | **Get** /api/v2/quality/surveys/{surveyId} | Get a survey for a conversation |
| [**GetQualitySurveysScorable**](#GetQualitySurveysScorable) | **Get** /api/v2/quality/surveys/scorable | Get a survey as an end-customer, for the purposes of scoring it. |
| [**PatchQualityFormsSurvey**](#PatchQualityFormsSurvey) | **Patch** /api/v2/quality/forms/surveys/{formId} | Disable a particular version of a survey form and invalidates any invitations that have already been sent to customers using this version of the form. |
| [**PostAnalyticsEvaluationsAggregatesJobs**](#PostAnalyticsEvaluationsAggregatesJobs) | **Post** /api/v2/analytics/evaluations/aggregates/jobs | Query for evaluation aggregates asynchronously |
| [**PostAnalyticsEvaluationsAggregatesQuery**](#PostAnalyticsEvaluationsAggregatesQuery) | **Post** /api/v2/analytics/evaluations/aggregates/query | Query for evaluation aggregates |
| [**PostAnalyticsSurveysAggregatesJobs**](#PostAnalyticsSurveysAggregatesJobs) | **Post** /api/v2/analytics/surveys/aggregates/jobs | Query for survey aggregates asynchronously |
| [**PostAnalyticsSurveysAggregatesQuery**](#PostAnalyticsSurveysAggregatesQuery) | **Post** /api/v2/analytics/surveys/aggregates/query | Query for survey aggregates |
| [**PostQualityCalibrations**](#PostQualityCalibrations) | **Post** /api/v2/quality/calibrations | Create a calibration |
| [**PostQualityConversationEvaluations**](#PostQualityConversationEvaluations) | **Post** /api/v2/quality/conversations/{conversationId}/evaluations | Create an evaluation |
| [**PostQualityConversationsAuditsQuery**](#PostQualityConversationsAuditsQuery) | **Post** /api/v2/quality/conversations/audits/query | Create audit query execution |
| [**PostQualityEvaluationsAggregatesQueryMe**](#PostQualityEvaluationsAggregatesQueryMe) | **Post** /api/v2/quality/evaluations/aggregates/query/me | Query for evaluation aggregates for the current user |
| [**PostQualityEvaluationsScoring**](#PostQualityEvaluationsScoring) | **Post** /api/v2/quality/evaluations/scoring | Score evaluation |
| [**PostQualityForms**](#PostQualityForms) | **Post** /api/v2/quality/forms | Create an evaluation form. |
| [**PostQualityFormsEvaluations**](#PostQualityFormsEvaluations) | **Post** /api/v2/quality/forms/evaluations | Create an evaluation form. |
| [**PostQualityFormsSurveys**](#PostQualityFormsSurveys) | **Post** /api/v2/quality/forms/surveys | Create a survey form. |
| [**PostQualityPublishedforms**](#PostQualityPublishedforms) | **Post** /api/v2/quality/publishedforms | Publish an evaluation form. |
| [**PostQualityPublishedformsEvaluations**](#PostQualityPublishedformsEvaluations) | **Post** /api/v2/quality/publishedforms/evaluations | Publish an evaluation form. |
| [**PostQualityPublishedformsSurveys**](#PostQualityPublishedformsSurveys) | **Post** /api/v2/quality/publishedforms/surveys | Publish a survey form. |
| [**PostQualitySurveysScoring**](#PostQualitySurveysScoring) | **Post** /api/v2/quality/surveys/scoring | Score survey |
| [**PutQualityCalibration**](#PutQualityCalibration) | **Put** /api/v2/quality/calibrations/{calibrationId} | Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex |
| [**PutQualityConversationEvaluation**](#PutQualityConversationEvaluation) | **Put** /api/v2/quality/conversations/{conversationId}/evaluations/{evaluationId} | Update an evaluation |
| [**PutQualityForm**](#PutQualityForm) | **Put** /api/v2/quality/forms/{formId} | Update an evaluation form. |
| [**PutQualityFormsEvaluation**](#PutQualityFormsEvaluation) | **Put** /api/v2/quality/forms/evaluations/{formId} | Update an evaluation form. |
| [**PutQualityFormsEvaluationAiscoringSettings**](#PutQualityFormsEvaluationAiscoringSettings) | **Put** /api/v2/quality/forms/evaluations/{formId}/aiscoring/settings | Update the AI Scoring settings of an evaluation form. |
| [**PutQualityFormsSurvey**](#PutQualityFormsSurvey) | **Put** /api/v2/quality/forms/surveys/{formId} | Update a survey form. |
| [**PutQualitySurveysScorable**](#PutQualitySurveysScorable) | **Put** /api/v2/quality/surveys/scorable | Update a survey as an end-customer, for the purposes of scoring it. |



## DeleteQualityCalibration

> [**Calibration**](Calibration) DeleteQualityCalibration (string calibrationId, string calibratorId)


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

### Return type

[**Calibration**](Calibration)


## DeleteQualityConversationEvaluation

> [**EvaluationResponse**](EvaluationResponse) DeleteQualityConversationEvaluation (string conversationId, string evaluationId, string expand = null)


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
            var expand = expand_example;  // string | evaluatorId, evaluationForm (optional) 

            try
            { 
                // Delete an evaluation
                EvaluationResponse result = apiInstance.DeleteQualityConversationEvaluation(conversationId, evaluationId, expand);
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
| **expand** | **string**| evaluatorId, evaluationForm | [optional]  |

### Return type

[**EvaluationResponse**](EvaluationResponse)


## DeleteQualityForm

> void DeleteQualityForm (string formId)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

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

### Return type

void (empty response body)


## DeleteQualityFormsEvaluation

> void DeleteQualityFormsEvaluation (string formId)


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

### Return type

void (empty response body)


## DeleteQualityFormsSurvey

> void DeleteQualityFormsSurvey (string formId)


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

### Return type

void (empty response body)


## GetAnalyticsEvaluationsAggregatesJob

> [**AsyncQueryStatus**](AsyncQueryStatus) GetAnalyticsEvaluationsAggregatesJob (string jobId)


Get status for async query for evaluation aggregates

GetAnalyticsEvaluationsAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
    public class GetAnalyticsEvaluationsAggregatesJobExample
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
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get status for async query for evaluation aggregates
                AsyncQueryStatus result = apiInstance.GetAnalyticsEvaluationsAggregatesJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetAnalyticsEvaluationsAggregatesJob: " + e.Message );
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

[**AsyncQueryStatus**](AsyncQueryStatus)


## GetAnalyticsEvaluationsAggregatesJobResults

> [**EvaluationAsyncAggregateQueryResponse**](EvaluationAsyncAggregateQueryResponse) GetAnalyticsEvaluationsAggregatesJobResults (string jobId, string cursor = null)


Fetch a page of results for an async aggregates query

GetAnalyticsEvaluationsAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
    public class GetAnalyticsEvaluationsAggregatesJobResultsExample
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
            var jobId = jobId_example;  // string | jobId
            var cursor = cursor_example;  // string | Cursor token to retrieve next page (optional) 

            try
            { 
                // Fetch a page of results for an async aggregates query
                EvaluationAsyncAggregateQueryResponse result = apiInstance.GetAnalyticsEvaluationsAggregatesJobResults(jobId, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetAnalyticsEvaluationsAggregatesJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
| **cursor** | **string**| Cursor token to retrieve next page | [optional]  |

### Return type

[**EvaluationAsyncAggregateQueryResponse**](EvaluationAsyncAggregateQueryResponse)


## GetAnalyticsSurveysAggregatesJob

> [**AsyncQueryStatus**](AsyncQueryStatus) GetAnalyticsSurveysAggregatesJob (string jobId)


Get status for async query for survey aggregates

GetAnalyticsSurveysAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
    public class GetAnalyticsSurveysAggregatesJobExample
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
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get status for async query for survey aggregates
                AsyncQueryStatus result = apiInstance.GetAnalyticsSurveysAggregatesJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetAnalyticsSurveysAggregatesJob: " + e.Message );
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

[**AsyncQueryStatus**](AsyncQueryStatus)


## GetAnalyticsSurveysAggregatesJobResults

> [**SurveyAsyncAggregateQueryResponse**](SurveyAsyncAggregateQueryResponse) GetAnalyticsSurveysAggregatesJobResults (string jobId, string cursor = null)


Fetch a page of results for an async aggregates query

GetAnalyticsSurveysAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
    public class GetAnalyticsSurveysAggregatesJobResultsExample
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
            var jobId = jobId_example;  // string | jobId
            var cursor = cursor_example;  // string | Cursor token to retrieve next page (optional) 

            try
            { 
                // Fetch a page of results for an async aggregates query
                SurveyAsyncAggregateQueryResponse result = apiInstance.GetAnalyticsSurveysAggregatesJobResults(jobId, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetAnalyticsSurveysAggregatesJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
| **cursor** | **string**| Cursor token to retrieve next page | [optional]  |

### Return type

[**SurveyAsyncAggregateQueryResponse**](SurveyAsyncAggregateQueryResponse)


## GetQualityAgentsActivity

> [**AgentActivityEntityListing**](AgentActivityEntityListing) GetQualityAgentsActivity (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null, string agentTeamId = null, string formContextId = null, string userState = null)


Gets a list of Agent Activities

Each item on the list shows one agent's evaluation activity comprised of the number of evaluations and the highest, average, and lowest standard and critical scores, as well as a sub list showing the number and average score of evaluations for each evaluator for that agent.  evaluatorUserId, startTime, and endTime are all filtering criteria. If specified, the only evaluations used to compile the agent activity response will be ones that match the filtering criteria. agentUserId, name, group, and agentTeamId are all agent selection criteria. criteria.  If one or more agent selection criteria are specified, then the returned activity will include users that match the criteria even if those users did not have any agent activity or evaluations that do not match any filtering criteria.  If no agent selection criteria are specified but an evaluatorUserId is, then the returned activity will be only for those agents that had evaluations where the evaluator is the evaluatorUserId.  If no agent selection criteria are specified and no evaluatorUserId is specified, then the returned activity will be for all users

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
            var agentTeamId = agentTeamId_example;  // string | team id of agents requested (optional) 
            var formContextId = formContextId_example;  // string | shared id between form versions (optional) 
            var userState = userState_example;  // string | 'Legacy' fetches active and inactive users when evaluatorUserId or no user filters are supplied; otherwise fetches active users.  'Any' fetches users of 'active', 'inactive' and 'deleted' states. (optional)  (default to Legacy)

            try
            { 
                // Gets a list of Agent Activities
                AgentActivityEntityListing result = apiInstance.GetQualityAgentsActivity(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, startTime, endTime, agentUserId, evaluatorUserId, name, group, agentTeamId, formContextId, userState);
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
| **expand** | [**List<string>**](string)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **startTime** | **DateTime?**| Start time of agent activity based on assigned date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional]  |
| **endTime** | **DateTime?**| End time of agent activity based on assigned date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional]  |
| **agentUserId** | [**List<string>**](string)| user id of agent requested | [optional]  |
| **evaluatorUserId** | **string**| user id of the evaluator | [optional]  |
| **name** | **string**| name | [optional]  |
| **group** | **string**| group id | [optional]  |
| **agentTeamId** | **string**| team id of agents requested | [optional]  |
| **formContextId** | **string**| shared id between form versions | [optional]  |
| **userState** | **string**| &#39;Legacy&#39; fetches active and inactive users when evaluatorUserId or no user filters are supplied; otherwise fetches active users.  &#39;Any&#39; fetches users of &#39;active&#39;, &#39;inactive&#39; and &#39;deleted&#39; states. | [optional] [default to Legacy]<br />**Values**: Any, Legacy |

### Return type

[**AgentActivityEntityListing**](AgentActivityEntityListing)


## GetQualityCalibration

> [**Calibration**](Calibration) GetQualityCalibration (string calibrationId, string calibratorId = null, string conversationId = null)


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

### Return type

[**Calibration**](Calibration)


## GetQualityCalibrations

> [**CalibrationEntityListing**](CalibrationEntityListing) GetQualityCalibrations (string calibratorId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null)


Get the list of calibrations

NOTE: The count for total and pageCount might not be accurate when querying for a large number of calibrations. nextUri, if present, will indicate that there are more calibrations to fetch.

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
| **expand** | [**List<string>**](string)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **conversationId** | **string**| conversation id | [optional]  |
| **startTime** | **DateTime?**| Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional]  |
| **endTime** | **DateTime?**| end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional]  |

### Return type

[**CalibrationEntityListing**](CalibrationEntityListing)


## GetQualityConversationEvaluation

> [**EvaluationResponse**](EvaluationResponse) GetQualityConversationEvaluation (string conversationId, string evaluationId, string expand = null)


Get an evaluation

Requires ANY permissions: 

* quality:evaluation:view
* quality:evaluation:assign
* quality:evaluation:release

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
            var expand = expand_example;  // string | agent, assignee, evaluator, evaluationForm (optional) 

            try
            { 
                // Get an evaluation
                EvaluationResponse result = apiInstance.GetQualityConversationEvaluation(conversationId, evaluationId, expand);
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
| **expand** | **string**| agent, assignee, evaluator, evaluationForm | [optional]  |

### Return type

[**EvaluationResponse**](EvaluationResponse)


## GetQualityConversationSurveys

> [**List&lt;Survey&gt;**](Survey) GetQualityConversationSurveys (string conversationId)


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

### Return type

[**List<Survey>**](Survey)


## GetQualityConversationsAuditsQueryTransactionId

> [**QualityAuditQueryExecutionStatusResponse**](QualityAuditQueryExecutionStatusResponse) GetQualityConversationsAuditsQueryTransactionId (string transactionId)


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

### Return type

[**QualityAuditQueryExecutionStatusResponse**](QualityAuditQueryExecutionStatusResponse)


## GetQualityConversationsAuditsQueryTransactionIdResults

> [**QualityAuditQueryExecutionResultsResponse**](QualityAuditQueryExecutionResultsResponse) GetQualityConversationsAuditsQueryTransactionIdResults (string transactionId, string cursor = null, int? pageSize = null, List<string> expand = null)


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
| **expand** | [**List<string>**](string)| Which fields, if any, to expand | [optional] <br />**Values**: user |

### Return type

[**QualityAuditQueryExecutionResultsResponse**](QualityAuditQueryExecutionResultsResponse)


## GetQualityEvaluationsQuery

> [**EvaluationEntityListing**](EvaluationEntityListing) GetQualityEvaluationsQuery (int? pageSize = null, int? pageNumber = null, List<string> expand = null, string previousPage = null, string conversationId = null, string agentUserId = null, string agentTeamId = null, string evaluatorUserId = null, string assigneeUserId = null, string queueId = null, string startTime = null, string endTime = null, string formContextId = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null, string sortOrder = null, bool? includeDeletedUsers = null)


Queries Evaluations and returns a paged list

Query params must include one of conversationId, evaluatorUserId, agentUserId or assigneeUserId. When querying by agentUserId (and not conversationId or evaluatorUserId), the results are sorted by release date. Evaluations set to 'Never Release' are omitted in this case. When querying by evaluatorUserId or conversationId (including when combined with agentUserId), the results are sorted by assigned date. NOTE: The count for total and pageCount might not be accurate when querying for a large number of evaluations. nextUri, if present, will indicate that there are more evaluations to fetch. The evaluation entities contained in the response might only contain a subset of all the properties listed below. It is often because a given property's value has not yet been populated or is not applicable in the current state of the evaluation. It might also be because the missing property in the response was not requested by the user.

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
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            var conversationId = conversationId_example;  // string | conversationId specified (optional) 
            var agentUserId = agentUserId_example;  // string | user id of the agent (optional) 
            var agentTeamId = agentTeamId_example;  // string | team id of the agent (optional) 
            var evaluatorUserId = evaluatorUserId_example;  // string | evaluator user id (optional) 
            var assigneeUserId = assigneeUserId_example;  // string | assignee user id (optional) 
            var queueId = queueId_example;  // string | queue id (optional) 
            var startTime = startTime_example;  // string | start time of the evaluation query (optional) 
            var endTime = endTime_example;  // string | end time of the evaluation query (optional) 
            var formContextId = formContextId_example;  // string | shared id between form versions (optional) 
            var evaluationState = new List<string>(); // List<string> |  (optional) 
            var isReleased = true;  // bool? | the evaluation has been released (optional) 
            var agentHasRead = true;  // bool? | agent has the evaluation (optional) 
            var expandAnswerTotalScores = true;  // bool? | get the total scores for evaluations. NOTE: The answers will only be populated if this parameter is set to true in the request. (optional) 
            var maximum = 56;  // int? | the maximum number of results to return (optional) 
            var sortOrder = sortOrder_example;  // string | NOTE: Does not work when conversationId is supplied. (optional) 
            var includeDeletedUsers = true;  // bool? | Allow returning an agent or evaluator user with a 'delete' status. Defaults to false. (optional)  (default to false)

            try
            { 
                // Queries Evaluations and returns a paged list
                EvaluationEntityListing result = apiInstance.GetQualityEvaluationsQuery(pageSize, pageNumber, expand, previousPage, conversationId, agentUserId, agentTeamId, evaluatorUserId, assigneeUserId, queueId, startTime, endTime, formContextId, evaluationState, isReleased, agentHasRead, expandAnswerTotalScores, maximum, sortOrder, includeDeletedUsers);
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
| **expand** | [**List<string>**](string)| variable name requested by expand list | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **conversationId** | **string**| conversationId specified | [optional]  |
| **agentUserId** | **string**| user id of the agent | [optional]  |
| **agentTeamId** | **string**| team id of the agent | [optional]  |
| **evaluatorUserId** | **string**| evaluator user id | [optional]  |
| **assigneeUserId** | **string**| assignee user id | [optional]  |
| **queueId** | **string**| queue id | [optional]  |
| **startTime** | **string**| start time of the evaluation query | [optional]  |
| **endTime** | **string**| end time of the evaluation query | [optional]  |
| **formContextId** | **string**| shared id between form versions | [optional]  |
| **evaluationState** | [**List<string>**](string)|  | [optional]  |
| **isReleased** | **bool?**| the evaluation has been released | [optional]  |
| **agentHasRead** | **bool?**| agent has the evaluation | [optional]  |
| **expandAnswerTotalScores** | **bool?**| get the total scores for evaluations. NOTE: The answers will only be populated if this parameter is set to true in the request. | [optional]  |
| **maximum** | **int?**| the maximum number of results to return | [optional]  |
| **sortOrder** | **string**| NOTE: Does not work when conversationId is supplied. | [optional]  |
| **includeDeletedUsers** | **bool?**| Allow returning an agent or evaluator user with a &#39;delete&#39; status. Defaults to false. | [optional] [default to false] |

### Return type

[**EvaluationEntityListing**](EvaluationEntityListing)


## GetQualityEvaluatorsActivity

> [**EvaluatorActivityEntityListing**](EvaluatorActivityEntityListing) GetQualityEvaluatorsActivity (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null, string agentTeamId = null)


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
            var agentTeamId = agentTeamId_example;  // string | team id of agents to be considered (optional) 

            try
            { 
                // Get an evaluator activity
                EvaluatorActivityEntityListing result = apiInstance.GetQualityEvaluatorsActivity(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, startTime, endTime, name, permission, group, agentTeamId);
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
| **expand** | [**List<string>**](string)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **startTime** | **DateTime?**| The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional]  |
| **endTime** | **DateTime?**| The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional]  |
| **name** | **string**| Evaluator name | [optional]  |
| **permission** | [**List<string>**](string)| permission strings | [optional]  |
| **group** | **string**| group id | [optional]  |
| **agentTeamId** | **string**| team id of agents to be considered | [optional]  |

### Return type

[**EvaluatorActivityEntityListing**](EvaluatorActivityEntityListing)


## GetQualityForm

> [**EvaluationFormResponse**](EvaluationFormResponse) GetQualityForm (string formId)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

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
                EvaluationFormResponse result = apiInstance.GetQualityForm(formId);
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

### Return type

[**EvaluationFormResponse**](EvaluationFormResponse)


## GetQualityFormVersions

> [**EvaluationFormResponseEntityListing**](EvaluationFormResponseEntityListing) GetQualityFormVersions (string formId, int? pageSize = null, int? pageNumber = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

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
                EvaluationFormResponseEntityListing result = apiInstance.GetQualityFormVersions(formId, pageSize, pageNumber);
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

### Return type

[**EvaluationFormResponseEntityListing**](EvaluationFormResponseEntityListing)


## GetQualityForms

> [**EvaluationFormResponseEntityListing**](EvaluationFormResponseEntityListing) GetQualityForms (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Get the list of evaluation forms. If you set \"expand=publishHistory\", then you will be able to get published versions for each corresponding evaluation form.

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
            var expand = expand_example;  // string | If 'expand=publishHistory', then each unpublished evaluation form includes a listing of its published versions (optional) 
            var name = name_example;  // string | Name (optional) 
            var sortOrder = sortOrder_example;  // string | Order to sort results, either asc or desc (optional) 

            try
            { 
                // Get the list of evaluation forms. If you set \"expand=publishHistory\", then you will be able to get published versions for each corresponding evaluation form.
                EvaluationFormResponseEntityListing result = apiInstance.GetQualityForms(pageSize, pageNumber, sortBy, nextPage, previousPage, expand, name, sortOrder);
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
| **expand** | **string**| If &#39;expand&#x3D;publishHistory&#39;, then each unpublished evaluation form includes a listing of its published versions | [optional] <br />**Values**: publishHistory |
| **name** | **string**| Name | [optional]  |
| **sortOrder** | **string**| Order to sort results, either asc or desc | [optional]  |

### Return type

[**EvaluationFormResponseEntityListing**](EvaluationFormResponseEntityListing)


## GetQualityFormsEvaluation

> [**EvaluationFormResponse**](EvaluationFormResponse) GetQualityFormsEvaluation (string formId)


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
                EvaluationFormResponse result = apiInstance.GetQualityFormsEvaluation(formId);
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

### Return type

[**EvaluationFormResponse**](EvaluationFormResponse)


## GetQualityFormsEvaluationVersions

> [**EvaluationFormResponseEntityListing**](EvaluationFormResponseEntityListing) GetQualityFormsEvaluationVersions (string formId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)


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
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "asc")

            try
            { 
                // Gets all the revisions for a specific evaluation.
                EvaluationFormResponseEntityListing result = apiInstance.GetQualityFormsEvaluationVersions(formId, pageSize, pageNumber, sortOrder);
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
| **sortOrder** | **string**| Sort order | [optional] [default to "asc"] |

### Return type

[**EvaluationFormResponseEntityListing**](EvaluationFormResponseEntityListing)


## GetQualityFormsEvaluations

> [**EvaluationFormResponseEntityListing**](EvaluationFormResponseEntityListing) GetQualityFormsEvaluations (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null)


Get the list of evaluation forms

By default, \"published\" field is always returned as false for all evaluation forms. If you set \"expand=publishHistory\", then you will be able to get published versions for each corresponding evaluation form. In addition, \"questionGroups\", the detailed information about evaluation form, is not returned. We will enhance this field in a future release.

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
            var expand = expand_example;  // string | If 'expand=publishHistory', then each unpublished evaluation form includes a listing of its published versions (optional) 
            var name = name_example;  // string | Name (optional) 
            var sortOrder = sortOrder_example;  // string | Order to sort results, either asc or desc (optional) 

            try
            { 
                // Get the list of evaluation forms
                EvaluationFormResponseEntityListing result = apiInstance.GetQualityFormsEvaluations(pageSize, pageNumber, sortBy, nextPage, previousPage, expand, name, sortOrder);
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
| **expand** | **string**| If &#39;expand&#x3D;publishHistory&#39;, then each unpublished evaluation form includes a listing of its published versions | [optional] <br />**Values**: publishHistory |
| **name** | **string**| Name | [optional]  |
| **sortOrder** | **string**| Order to sort results, either asc or desc | [optional]  |

### Return type

[**EvaluationFormResponseEntityListing**](EvaluationFormResponseEntityListing)


## GetQualityFormsEvaluationsBulkContexts

> [**List&lt;EvaluationFormResponse&gt;**](EvaluationFormResponse) GetQualityFormsEvaluationsBulkContexts (List<string> contextId)


Retrieve a list of the latest published evaluation form versions by context ids

Requires ALL permissions: 

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
    public class GetQualityFormsEvaluationsBulkContextsExample
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
            var contextId = new List<string>(); // List<string> | A comma-delimited list of valid evaluation form context ids

            try
            { 
                // Retrieve a list of the latest published evaluation form versions by context ids
                List<EvaluationFormResponse> result = apiInstance.GetQualityFormsEvaluationsBulkContexts(contextId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetQualityFormsEvaluationsBulkContexts: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contextId** | [**List<string>**](string)| A comma-delimited list of valid evaluation form context ids |  |

### Return type

[**List<EvaluationFormResponse>**](EvaluationFormResponse)


## GetQualityFormsSurvey

> [**SurveyForm**](SurveyForm) GetQualityFormsSurvey (string formId)


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

### Return type

[**SurveyForm**](SurveyForm)


## GetQualityFormsSurveyVersions

> [**SurveyFormEntityListing**](SurveyFormEntityListing) GetQualityFormsSurveyVersions (string formId, int? pageSize = null, int? pageNumber = null)


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

### Return type

[**SurveyFormEntityListing**](SurveyFormEntityListing)


## GetQualityFormsSurveys

> [**SurveyFormEntityListing**](SurveyFormEntityListing) GetQualityFormsSurveys (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null)


Get the list of survey forms. If you set \"expand=publishHistory\", then you will be able to get published versions for each corresponding survey form.

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
            var expand = expand_example;  // string | If 'expand=publishHistory', then each unpublished evaluation form includes a listing of its published versions (optional) 
            var name = name_example;  // string | Name (optional) 
            var sortOrder = sortOrder_example;  // string | Order to sort results, either asc or desc (optional) 

            try
            { 
                // Get the list of survey forms. If you set \"expand=publishHistory\", then you will be able to get published versions for each corresponding survey form.
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
| **expand** | **string**| If &#39;expand&#x3D;publishHistory&#39;, then each unpublished evaluation form includes a listing of its published versions | [optional] <br />**Values**: publishHistory |
| **name** | **string**| Name | [optional]  |
| **sortOrder** | **string**| Order to sort results, either asc or desc | [optional]  |

### Return type

[**SurveyFormEntityListing**](SurveyFormEntityListing)


## GetQualityFormsSurveysBulk

> [**SurveyFormEntityListing**](SurveyFormEntityListing) GetQualityFormsSurveysBulk (List<string> id)


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
| **id** | [**List<string>**](string)| A comma-delimited list of valid survey form ids |  |

### Return type

[**SurveyFormEntityListing**](SurveyFormEntityListing)


## GetQualityFormsSurveysBulkContexts

> [**List&lt;SurveyForm&gt;**](SurveyForm) GetQualityFormsSurveysBulkContexts (List<string> contextId, bool? published = null)


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
            var contextId = new List<string>(); // List<string> | A comma-delimited list of valid survey form context ids. The maximum number of ids allowed in this list is 100.
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
| **contextId** | [**List<string>**](string)| A comma-delimited list of valid survey form context ids. The maximum number of ids allowed in this list is 100. |  |
| **published** | **bool?**| If true, the latest published version will be included. If false, only the unpublished version will be included. | [optional] [default to true] |

### Return type

[**List<SurveyForm>**](SurveyForm)


## GetQualityPublishedform

> [**EvaluationFormResponse**](EvaluationFormResponse) GetQualityPublishedform (string formId)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

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
                EvaluationFormResponse result = apiInstance.GetQualityPublishedform(formId);
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

### Return type

[**EvaluationFormResponse**](EvaluationFormResponse)


## GetQualityPublishedforms

> [**EvaluationFormResponseEntityListing**](EvaluationFormResponseEntityListing) GetQualityPublishedforms (int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestPerContext = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

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
                EvaluationFormResponseEntityListing result = apiInstance.GetQualityPublishedforms(pageSize, pageNumber, name, onlyLatestPerContext);
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

### Return type

[**EvaluationFormResponseEntityListing**](EvaluationFormResponseEntityListing)


## GetQualityPublishedformsEvaluation

> [**EvaluationFormResponse**](EvaluationFormResponse) GetQualityPublishedformsEvaluation (string formId)


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
                EvaluationFormResponse result = apiInstance.GetQualityPublishedformsEvaluation(formId);
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

### Return type

[**EvaluationFormResponse**](EvaluationFormResponse)


## GetQualityPublishedformsEvaluations

> [**EvaluationFormResponseEntityListing**](EvaluationFormResponseEntityListing) GetQualityPublishedformsEvaluations (int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestPerContext = null)


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
                EvaluationFormResponseEntityListing result = apiInstance.GetQualityPublishedformsEvaluations(pageSize, pageNumber, name, onlyLatestPerContext);
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

### Return type

[**EvaluationFormResponseEntityListing**](EvaluationFormResponseEntityListing)


## GetQualityPublishedformsSurvey

> [**SurveyForm**](SurveyForm) GetQualityPublishedformsSurvey (string formId)


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

### Return type

[**SurveyForm**](SurveyForm)


## GetQualityPublishedformsSurveys

> [**SurveyFormEntityListing**](SurveyFormEntityListing) GetQualityPublishedformsSurveys (int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestEnabledPerContext = null)


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

### Return type

[**SurveyFormEntityListing**](SurveyFormEntityListing)


## GetQualitySurvey

> [**Survey**](Survey) GetQualitySurvey (string surveyId)


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

### Return type

[**Survey**](Survey)


## GetQualitySurveysScorable

> [**ScorableSurvey**](ScorableSurvey) GetQualitySurveysScorable (string customerSurveyUrl)


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

### Return type

[**ScorableSurvey**](ScorableSurvey)


## PatchQualityFormsSurvey

> [**SurveyForm**](SurveyForm) PatchQualityFormsSurvey (string formId, SurveyForm body)


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
| **body** | [**SurveyForm**](SurveyForm)| Survey form |  |

### Return type

[**SurveyForm**](SurveyForm)


## PostAnalyticsEvaluationsAggregatesJobs

> [**AsyncQueryResponse**](AsyncQueryResponse) PostAnalyticsEvaluationsAggregatesJobs (EvaluationAsyncAggregationQuery body)


Query for evaluation aggregates asynchronously

PostAnalyticsEvaluationsAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
    public class PostAnalyticsEvaluationsAggregatesJobsExample
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
            var body = new EvaluationAsyncAggregationQuery(); // EvaluationAsyncAggregationQuery | query

            try
            { 
                // Query for evaluation aggregates asynchronously
                AsyncQueryResponse result = apiInstance.PostAnalyticsEvaluationsAggregatesJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PostAnalyticsEvaluationsAggregatesJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**EvaluationAsyncAggregationQuery**](EvaluationAsyncAggregationQuery)| query |  |

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse)


## PostAnalyticsEvaluationsAggregatesQuery

> [**EvaluationAggregateQueryResponse**](EvaluationAggregateQueryResponse) PostAnalyticsEvaluationsAggregatesQuery (EvaluationAggregationQuery body)


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
| **body** | [**EvaluationAggregationQuery**](EvaluationAggregationQuery)| query |  |

### Return type

[**EvaluationAggregateQueryResponse**](EvaluationAggregateQueryResponse)


## PostAnalyticsSurveysAggregatesJobs

> [**AsyncQueryResponse**](AsyncQueryResponse) PostAnalyticsSurveysAggregatesJobs (SurveyAsyncAggregationQuery body)


Query for survey aggregates asynchronously

PostAnalyticsSurveysAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
    public class PostAnalyticsSurveysAggregatesJobsExample
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
            var body = new SurveyAsyncAggregationQuery(); // SurveyAsyncAggregationQuery | query

            try
            { 
                // Query for survey aggregates asynchronously
                AsyncQueryResponse result = apiInstance.PostAnalyticsSurveysAggregatesJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PostAnalyticsSurveysAggregatesJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SurveyAsyncAggregationQuery**](SurveyAsyncAggregationQuery)| query |  |

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse)


## PostAnalyticsSurveysAggregatesQuery

> [**SurveyAggregateQueryResponse**](SurveyAggregateQueryResponse) PostAnalyticsSurveysAggregatesQuery (SurveyAggregationQuery body)


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
| **body** | [**SurveyAggregationQuery**](SurveyAggregationQuery)| query |  |

### Return type

[**SurveyAggregateQueryResponse**](SurveyAggregateQueryResponse)


## PostQualityCalibrations

> [**Calibration**](Calibration) PostQualityCalibrations (CalibrationCreate body, string expand = null)


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
| **body** | [**CalibrationCreate**](CalibrationCreate)| calibration |  |
| **expand** | **string**| calibratorId | [optional]  |

### Return type

[**Calibration**](Calibration)


## PostQualityConversationEvaluations

> [**Evaluation**](Evaluation) PostQualityConversationEvaluations (string conversationId, EvaluationCreateBody body, string expand = null)


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
            var body = new EvaluationCreateBody(); // EvaluationCreateBody | evaluation
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
| **body** | [**EvaluationCreateBody**](EvaluationCreateBody)| evaluation |  |
| **expand** | **string**| evaluatorId | [optional]  |

### Return type

[**Evaluation**](Evaluation)


## PostQualityConversationsAuditsQuery

> [**QualityAuditQueryExecutionStatusResponse**](QualityAuditQueryExecutionStatusResponse) PostQualityConversationsAuditsQuery (QMAuditQueryRequest body)


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
| **body** | [**QMAuditQueryRequest**](QMAuditQueryRequest)| query |  |

### Return type

[**QualityAuditQueryExecutionStatusResponse**](QualityAuditQueryExecutionStatusResponse)


## PostQualityEvaluationsAggregatesQueryMe

> [**EvaluationAggregateQueryResponse**](EvaluationAggregateQueryResponse) PostQualityEvaluationsAggregatesQueryMe (EvaluationAggregationQueryMe body)


Query for evaluation aggregates for the current user

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
    public class PostQualityEvaluationsAggregatesQueryMeExample
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
            var body = new EvaluationAggregationQueryMe(); // EvaluationAggregationQueryMe | query

            try
            { 
                // Query for evaluation aggregates for the current user
                EvaluationAggregateQueryResponse result = apiInstance.PostQualityEvaluationsAggregatesQueryMe(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PostQualityEvaluationsAggregatesQueryMe: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**EvaluationAggregationQueryMe**](EvaluationAggregationQueryMe)| query |  |

### Return type

[**EvaluationAggregateQueryResponse**](EvaluationAggregateQueryResponse)


## PostQualityEvaluationsScoring

> [**EvaluationScoringSet**](EvaluationScoringSet) PostQualityEvaluationsScoring (EvaluationFormAndScoringSet body)


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
| **body** | [**EvaluationFormAndScoringSet**](EvaluationFormAndScoringSet)| evaluationAndScoringSet |  |

### Return type

[**EvaluationScoringSet**](EvaluationScoringSet)


## PostQualityForms

> [**EvaluationFormResponse**](EvaluationFormResponse) PostQualityForms (EvaluationForm body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

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
                EvaluationFormResponse result = apiInstance.PostQualityForms(body);
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
| **body** | [**EvaluationForm**](EvaluationForm)| Evaluation form |  |

### Return type

[**EvaluationFormResponse**](EvaluationFormResponse)


## PostQualityFormsEvaluations

> [**EvaluationFormResponse**](EvaluationFormResponse) PostQualityFormsEvaluations (EvaluationForm body)


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
                EvaluationFormResponse result = apiInstance.PostQualityFormsEvaluations(body);
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
| **body** | [**EvaluationForm**](EvaluationForm)| Evaluation form |  |

### Return type

[**EvaluationFormResponse**](EvaluationFormResponse)


## PostQualityFormsSurveys

> [**SurveyForm**](SurveyForm) PostQualityFormsSurveys (SurveyForm body)


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
| **body** | [**SurveyForm**](SurveyForm)| Survey form |  |

### Return type

[**SurveyForm**](SurveyForm)


## PostQualityPublishedforms

> [**EvaluationFormResponse**](EvaluationFormResponse) PostQualityPublishedforms (PublishForm body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

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
                EvaluationFormResponse result = apiInstance.PostQualityPublishedforms(body);
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
| **body** | [**PublishForm**](PublishForm)| Publish request containing id of form to publish |  |

### Return type

[**EvaluationFormResponse**](EvaluationFormResponse)


## PostQualityPublishedformsEvaluations

> [**EvaluationFormResponse**](EvaluationFormResponse) PostQualityPublishedformsEvaluations (PublishForm body)


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
                EvaluationFormResponse result = apiInstance.PostQualityPublishedformsEvaluations(body);
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
| **body** | [**PublishForm**](PublishForm)| Publish request containing id of form to publish |  |

### Return type

[**EvaluationFormResponse**](EvaluationFormResponse)


## PostQualityPublishedformsSurveys

> [**SurveyForm**](SurveyForm) PostQualityPublishedformsSurveys (PublishForm body)


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
| **body** | [**PublishForm**](PublishForm)| Survey form |  |

### Return type

[**SurveyForm**](SurveyForm)


## PostQualitySurveysScoring

> [**SurveyScoringSet**](SurveyScoringSet) PostQualitySurveysScoring (SurveyFormAndScoringSet body)


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
| **body** | [**SurveyFormAndScoringSet**](SurveyFormAndScoringSet)| surveyAndScoringSet |  |

### Return type

[**SurveyScoringSet**](SurveyScoringSet)


## PutQualityCalibration

> [**Calibration**](Calibration) PutQualityCalibration (string calibrationId, Calibration body)


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
| **body** | [**Calibration**](Calibration)| Calibration |  |

### Return type

[**Calibration**](Calibration)


## PutQualityConversationEvaluation

> [**EvaluationResponse**](EvaluationResponse) PutQualityConversationEvaluation (string conversationId, string evaluationId, Evaluation body, string expand = null)


Update an evaluation

The quality:evaluation:edit permission allows modification of most fields, while the quality:evaluation:editScore permission allows an evaluator to change just the question scores, and the quality:evaluation:editAgentSignoff permission allows an agent to change the agent comments and sign off on the evaluation. authorizedActions is not returned for this PUT request, and is only returned for GET requests to this endpoint.

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
            var expand = expand_example;  // string | evaluatorId, evaluationForm, assignee, evaluator (optional) 

            try
            { 
                // Update an evaluation
                EvaluationResponse result = apiInstance.PutQualityConversationEvaluation(conversationId, evaluationId, body, expand);
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
| **body** | [**Evaluation**](Evaluation)| evaluation |  |
| **expand** | **string**| evaluatorId, evaluationForm, assignee, evaluator | [optional]  |

### Return type

[**EvaluationResponse**](EvaluationResponse)


## PutQualityForm

> [**EvaluationFormResponse**](EvaluationFormResponse) PutQualityForm (string formId, EvaluationForm body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

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
                EvaluationFormResponse result = apiInstance.PutQualityForm(formId, body);
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
| **body** | [**EvaluationForm**](EvaluationForm)| Evaluation form |  |

### Return type

[**EvaluationFormResponse**](EvaluationFormResponse)


## PutQualityFormsEvaluation

> [**EvaluationFormResponse**](EvaluationFormResponse) PutQualityFormsEvaluation (string formId, EvaluationForm body)


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
                EvaluationFormResponse result = apiInstance.PutQualityFormsEvaluation(formId, body);
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
| **body** | [**EvaluationForm**](EvaluationForm)| Evaluation form |  |

### Return type

[**EvaluationFormResponse**](EvaluationFormResponse)


## PutQualityFormsEvaluationAiscoringSettings

> [**AiScoringSettings**](AiScoringSettings) PutQualityFormsEvaluationAiscoringSettings (string formId, AiScoringSettings body)


Update the AI Scoring settings of an evaluation form.

PutQualityFormsEvaluationAiscoringSettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* quality:evaluationForm:aiScoringEdit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutQualityFormsEvaluationAiscoringSettingsExample
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
            var body = new AiScoringSettings(); // AiScoringSettings | AI Scoring Settings

            try
            { 
                // Update the AI Scoring settings of an evaluation form.
                AiScoringSettings result = apiInstance.PutQualityFormsEvaluationAiscoringSettings(formId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PutQualityFormsEvaluationAiscoringSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **formId** | **string**| Form ID |  |
| **body** | [**AiScoringSettings**](AiScoringSettings)| AI Scoring Settings |  |

### Return type

[**AiScoringSettings**](AiScoringSettings)


## PutQualityFormsSurvey

> [**SurveyForm**](SurveyForm) PutQualityFormsSurvey (string formId, SurveyForm body)


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
| **body** | [**SurveyForm**](SurveyForm)| Survey form |  |

### Return type

[**SurveyForm**](SurveyForm)


## PutQualitySurveysScorable

> [**ScorableSurvey**](ScorableSurvey) PutQualitySurveysScorable (string customerSurveyUrl, ScorableSurvey body)


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
            var customerSurveyUrl = customerSurveyUrl_example;  // string | customerSurveyUrl
            var body = new ScorableSurvey(); // ScorableSurvey | survey

            try
            { 
                // Update a survey as an end-customer, for the purposes of scoring it.
                ScorableSurvey result = apiInstance.PutQualitySurveysScorable(customerSurveyUrl, body);
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
| **customerSurveyUrl** | **string**| customerSurveyUrl |  |
| **body** | [**ScorableSurvey**](ScorableSurvey)| survey |  |

### Return type

[**ScorableSurvey**](ScorableSurvey)


_PureCloudPlatform.Client.V2 225.0.0_
