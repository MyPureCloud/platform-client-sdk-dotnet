# JourneyApi

## PureCloudPlatform.Client.V2.Api.JourneyApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteJourneyActionmap**](#DeleteJourneyActionmap) | **Delete** /api/v2/journey/actionmaps/{actionMapId} | Delete single action map. |
| [**DeleteJourneyActiontemplate**](#DeleteJourneyActiontemplate) | **Delete** /api/v2/journey/actiontemplates/{actionTemplateId} | Delete a single action template. |
| [**DeleteJourneyOutcome**](#DeleteJourneyOutcome) | **Delete** /api/v2/journey/outcomes/{outcomeId} | Delete an outcome. |
| [**DeleteJourneyOutcomesPredictor**](#DeleteJourneyOutcomesPredictor) | **Delete** /api/v2/journey/outcomes/predictors/{predictorId} | Delete an outcome predictor. |
| [**DeleteJourneySegment**](#DeleteJourneySegment) | **Delete** /api/v2/journey/segments/{segmentId} | Delete a segment. |
| [**DeleteJourneyView**](#DeleteJourneyView) | **Delete** /api/v2/journey/views/{viewId} | Delete a Journey View by ID |
| [**GetAnalyticsJourneysAggregatesJob**](#GetAnalyticsJourneysAggregatesJob) | **Get** /api/v2/analytics/journeys/aggregates/jobs/{jobId} | Get status for async query for journey aggregates |
| [**GetAnalyticsJourneysAggregatesJobResults**](#GetAnalyticsJourneysAggregatesJobResults) | **Get** /api/v2/analytics/journeys/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetExternalcontactsContactJourneySessions**](#GetExternalcontactsContactJourneySessions) | **Get** /api/v2/externalcontacts/contacts/{contactId}/journey/sessions | Retrieve all sessions for a given external contact. |
| [**GetJourneyActionmap**](#GetJourneyActionmap) | **Get** /api/v2/journey/actionmaps/{actionMapId} | Retrieve a single action map. |
| [**GetJourneyActionmaps**](#GetJourneyActionmaps) | **Get** /api/v2/journey/actionmaps | Retrieve all action maps. |
| [**GetJourneyActionmapsEstimatesJob**](#GetJourneyActionmapsEstimatesJob) | **Get** /api/v2/journey/actionmaps/estimates/jobs/{jobId} | Get status of job. |
| [**GetJourneyActionmapsEstimatesJobResults**](#GetJourneyActionmapsEstimatesJobResults) | **Get** /api/v2/journey/actionmaps/estimates/jobs/{jobId}/results | Get estimates from completed job. |
| [**GetJourneyActiontarget**](#GetJourneyActiontarget) | **Get** /api/v2/journey/actiontargets/{actionTargetId} | Retrieve a single action target. |
| [**GetJourneyActiontargets**](#GetJourneyActiontargets) | **Get** /api/v2/journey/actiontargets | Retrieve all action targets. |
| [**GetJourneyActiontemplate**](#GetJourneyActiontemplate) | **Get** /api/v2/journey/actiontemplates/{actionTemplateId} | Retrieve a single action template. |
| [**GetJourneyActiontemplates**](#GetJourneyActiontemplates) | **Get** /api/v2/journey/actiontemplates | Retrieve all action templates. |
| [**GetJourneyDeploymentCustomerPing**](#GetJourneyDeploymentCustomerPing) | **Get** /api/v2/journey/deployments/{deploymentId}/customers/{customerCookieId}/ping | Send a ping. |
| [**GetJourneyOutcome**](#GetJourneyOutcome) | **Get** /api/v2/journey/outcomes/{outcomeId} | Retrieve a single outcome. |
| [**GetJourneyOutcomes**](#GetJourneyOutcomes) | **Get** /api/v2/journey/outcomes | Retrieve all outcomes. |
| [**GetJourneyOutcomesAttributionsJob**](#GetJourneyOutcomesAttributionsJob) | **Get** /api/v2/journey/outcomes/attributions/jobs/{jobId} | Get job status. |
| [**GetJourneyOutcomesAttributionsJobResults**](#GetJourneyOutcomesAttributionsJobResults) | **Get** /api/v2/journey/outcomes/attributions/jobs/{jobId}/results | Get outcome attribution entities from completed job. |
| [**GetJourneyOutcomesPredictor**](#GetJourneyOutcomesPredictor) | **Get** /api/v2/journey/outcomes/predictors/{predictorId} | Retrieve a single outcome predictor. |
| [**GetJourneyOutcomesPredictors**](#GetJourneyOutcomesPredictors) | **Get** /api/v2/journey/outcomes/predictors | Retrieve all outcome predictors. |
| [**GetJourneySegment**](#GetJourneySegment) | **Get** /api/v2/journey/segments/{segmentId} | Retrieve a single segment. |
| [**GetJourneySegments**](#GetJourneySegments) | **Get** /api/v2/journey/segments | Retrieve all segments. |
| [**GetJourneySession**](#GetJourneySession) | **Get** /api/v2/journey/sessions/{sessionId} | Retrieve a single session. |
| [**GetJourneySessionEvents**](#GetJourneySessionEvents) | **Get** /api/v2/journey/sessions/{sessionId}/events | Retrieve all events for a given session. |
| [**GetJourneySessionOutcomescores**](#GetJourneySessionOutcomescores) | **Get** /api/v2/journey/sessions/{sessionId}/outcomescores | Retrieve latest outcome score associated with a session for all outcomes. |
| [**GetJourneyView**](#GetJourneyView) | **Get** /api/v2/journey/views/{viewId} | Get a Journey View by ID |
| [**GetJourneyViewVersion**](#GetJourneyViewVersion) | **Get** /api/v2/journey/views/{viewId}/versions/{versionId} | Get a Journey View by ID and version |
| [**GetJourneyViewVersionChart**](#GetJourneyViewVersionChart) | **Get** /api/v2/journey/views/{viewId}/versions/{journeyViewVersion}/charts/{chartId} | Get a Chart by ID |
| [**GetJourneyViewVersionChartVersion**](#GetJourneyViewVersionChartVersion) | **Get** /api/v2/journey/views/{viewId}/versions/{journeyViewVersion}/charts/{chartId}/versions/{chartVersion} | Get a Chart by ID and version |
| [**GetJourneyViewVersionJob**](#GetJourneyViewVersionJob) | **Get** /api/v2/journey/views/{viewId}/versions/{journeyVersionId}/jobs/{jobId} | Get the job for a journey view version. |
| [**GetJourneyViewVersionJobResults**](#GetJourneyViewVersionJobResults) | **Get** /api/v2/journey/views/{viewId}/versions/{journeyViewVersion}/jobs/{jobId}/results | Get the result of a job for a journey view version. |
| [**GetJourneyViewVersionJobResultsChart**](#GetJourneyViewVersionJobResultsChart) | **Get** /api/v2/journey/views/{viewId}/versions/{journeyVersionId}/jobs/{jobId}/results/charts/{chartId} | Get the chart result associated with a journey view job. |
| [**GetJourneyViewVersionJobsLatest**](#GetJourneyViewVersionJobsLatest) | **Get** /api/v2/journey/views/{viewId}/versions/{journeyVersionId}/jobs/latest | Get the latest job of a journey view version. |
| [**GetJourneyViews**](#GetJourneyViews) | **Get** /api/v2/journey/views | Get a list of Journey Views |
| [**GetJourneyViewsEventdefinition**](#GetJourneyViewsEventdefinition) | **Get** /api/v2/journey/views/eventdefinitions/{eventDefinitionId} | Get an Event Definition |
| [**GetJourneyViewsEventdefinitions**](#GetJourneyViewsEventdefinitions) | **Get** /api/v2/journey/views/eventdefinitions | Get a list of Event Definitions |
| [**GetJourneyViewsJobs**](#GetJourneyViewsJobs) | **Get** /api/v2/journey/views/jobs | Get the jobs for an organization. |
| [**PatchJourneyActionmap**](#PatchJourneyActionmap) | **Patch** /api/v2/journey/actionmaps/{actionMapId} | Update single action map. |
| [**PatchJourneyActiontarget**](#PatchJourneyActiontarget) | **Patch** /api/v2/journey/actiontargets/{actionTargetId} | Update a single action target. |
| [**PatchJourneyActiontemplate**](#PatchJourneyActiontemplate) | **Patch** /api/v2/journey/actiontemplates/{actionTemplateId} | Update a single action template. |
| [**PatchJourneyOutcome**](#PatchJourneyOutcome) | **Patch** /api/v2/journey/outcomes/{outcomeId} | Update an outcome. |
| [**PatchJourneySegment**](#PatchJourneySegment) | **Patch** /api/v2/journey/segments/{segmentId} | Update a segment. |
| [**PatchJourneyViewVersionJob**](#PatchJourneyViewVersionJob) | **Patch** /api/v2/journey/views/{viewId}/versions/{journeyVersionId}/jobs/{jobId} | Update the job for a journey view version. Only the status can be changed and only to Cancelled |
| [**PostAnalyticsJourneysAggregatesJobs**](#PostAnalyticsJourneysAggregatesJobs) | **Post** /api/v2/analytics/journeys/aggregates/jobs | Query for journey aggregates asynchronously |
| [**PostAnalyticsJourneysAggregatesQuery**](#PostAnalyticsJourneysAggregatesQuery) | **Post** /api/v2/analytics/journeys/aggregates/query | Query for journey aggregates |
| [**PostJourneyActionmaps**](#PostJourneyActionmaps) | **Post** /api/v2/journey/actionmaps | Create an action map. |
| [**PostJourneyActionmapsEstimatesJobs**](#PostJourneyActionmapsEstimatesJobs) | **Post** /api/v2/journey/actionmaps/estimates/jobs | Query for estimates |
| [**PostJourneyActiontemplates**](#PostJourneyActiontemplates) | **Post** /api/v2/journey/actiontemplates | Create a single action template. |
| [**PostJourneyDeploymentActionevent**](#PostJourneyDeploymentActionevent) | **Post** /api/v2/journey/deployments/{deploymentId}/actionevent | Sends an action event, which is used for changing the state of actions that have been offered to the user. |
| [**PostJourneyDeploymentAppevents**](#PostJourneyDeploymentAppevents) | **Post** /api/v2/journey/deployments/{deploymentId}/appevents | Send a journey app event, used for tracking customer activity on an application. |
| [**PostJourneyDeploymentWebevents**](#PostJourneyDeploymentWebevents) | **Post** /api/v2/journey/deployments/{deploymentId}/webevents | Send a journey web event, used for tracking customer activity on a website. |
| [**PostJourneyFlowsPathsQuery**](#PostJourneyFlowsPathsQuery) | **Post** /api/v2/journey/flows/paths/query | Query for flow paths. |
| [**PostJourneyOutcomes**](#PostJourneyOutcomes) | **Post** /api/v2/journey/outcomes | Create an outcome. |
| [**PostJourneyOutcomesAttributionsJobs**](#PostJourneyOutcomesAttributionsJobs) | **Post** /api/v2/journey/outcomes/attributions/jobs | Create Outcome Attributions |
| [**PostJourneyOutcomesPredictors**](#PostJourneyOutcomesPredictors) | **Post** /api/v2/journey/outcomes/predictors | Create an outcome predictor. |
| [**PostJourneySegments**](#PostJourneySegments) | **Post** /api/v2/journey/segments | Create a segment. |
| [**PostJourneyViewVersionJobs**](#PostJourneyViewVersionJobs) | **Post** /api/v2/journey/views/{viewId}/versions/{journeyVersionId}/jobs | Submit a job request for a journey view version. |
| [**PostJourneyViewVersions**](#PostJourneyViewVersions) | **Post** /api/v2/journey/views/{viewId}/versions | Update a Journey View by ID |
| [**PostJourneyViews**](#PostJourneyViews) | **Post** /api/v2/journey/views | Create a new Journey View |
| [**PostJourneyViewsEncodingsValidate**](#PostJourneyViewsEncodingsValidate) | **Post** /api/v2/journey/views/encodings/validate | Validate whether an encoding exist for a label/value combination. |
| [**PutJourneyViewVersion**](#PutJourneyViewVersion) | **Put** /api/v2/journey/views/{viewId}/versions/{versionId} | Update a Journey View by ID and version |



## DeleteJourneyActionmap

> void DeleteJourneyActionmap (string actionMapId)


Delete single action map.

Requires ANY permissions: 

* journey:actionmap:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteJourneyActionmapExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var actionMapId = actionMapId_example;  // string | ID of the action map.

            try
            { 
                // Delete single action map.
                apiInstance.DeleteJourneyActionmap(actionMapId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.DeleteJourneyActionmap: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionMapId** | **string**| ID of the action map. |  |

### Return type

void (empty response body)


## DeleteJourneyActiontemplate

> void DeleteJourneyActiontemplate (string actionTemplateId, bool? hardDelete = null)


Delete a single action template.

Requires ANY permissions: 

* journey:actiontemplate:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteJourneyActiontemplateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var actionTemplateId = actionTemplateId_example;  // string | ID of the action template.
            var hardDelete = true;  // bool? | Determines whether Action Template should be soft-deleted (have it's state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. (optional) 

            try
            { 
                // Delete a single action template.
                apiInstance.DeleteJourneyActiontemplate(actionTemplateId, hardDelete);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.DeleteJourneyActiontemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionTemplateId** | **string**| ID of the action template. |  |
| **hardDelete** | **bool?**| Determines whether Action Template should be soft-deleted (have it&#39;s state set to deleted) or hard-deleted (permanently removed). Set to false (soft-delete) by default. | [optional]  |

### Return type

void (empty response body)


## DeleteJourneyOutcome

> void DeleteJourneyOutcome (string outcomeId)


Delete an outcome.

Requires ANY permissions: 

* journey:outcome:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteJourneyOutcomeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var outcomeId = outcomeId_example;  // string | ID of the outcome.

            try
            { 
                // Delete an outcome.
                apiInstance.DeleteJourneyOutcome(outcomeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.DeleteJourneyOutcome: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **outcomeId** | **string**| ID of the outcome. |  |

### Return type

void (empty response body)


## DeleteJourneyOutcomesPredictor

> void DeleteJourneyOutcomesPredictor (string predictorId)


Delete an outcome predictor.

Requires ANY permissions: 

* journey:outcomepredictor:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteJourneyOutcomesPredictorExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var predictorId = predictorId_example;  // string | ID of predictor

            try
            { 
                // Delete an outcome predictor.
                apiInstance.DeleteJourneyOutcomesPredictor(predictorId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.DeleteJourneyOutcomesPredictor: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **predictorId** | **string**| ID of predictor |  |

### Return type

void (empty response body)


## DeleteJourneySegment

> void DeleteJourneySegment (string segmentId)


Delete a segment.

Requires ANY permissions: 

* journey:segment:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteJourneySegmentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var segmentId = segmentId_example;  // string | ID of the segment.

            try
            { 
                // Delete a segment.
                apiInstance.DeleteJourneySegment(segmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.DeleteJourneySegment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **segmentId** | **string**| ID of the segment. |  |

### Return type

void (empty response body)


## DeleteJourneyView

> void DeleteJourneyView (string viewId)


Delete a Journey View by ID

deletes all versions

Requires ALL permissions: 

* journey:views:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteJourneyViewExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var viewId = viewId_example;  // string | viewId

            try
            { 
                // Delete a Journey View by ID
                apiInstance.DeleteJourneyView(viewId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.DeleteJourneyView: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **viewId** | **string**| viewId |  |

### Return type

void (empty response body)


## GetAnalyticsJourneysAggregatesJob

> [**AsyncQueryStatus**](AsyncQueryStatus) GetAnalyticsJourneysAggregatesJob (string jobId)


Get status for async query for journey aggregates

GetAnalyticsJourneysAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:journeyAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsJourneysAggregatesJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get status for async query for journey aggregates
                AsyncQueryStatus result = apiInstance.GetAnalyticsJourneysAggregatesJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetAnalyticsJourneysAggregatesJob: " + e.Message );
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


## GetAnalyticsJourneysAggregatesJobResults

> [**JourneyAsyncAggregateQueryResponse**](JourneyAsyncAggregateQueryResponse) GetAnalyticsJourneysAggregatesJobResults (string jobId, string cursor = null)


Fetch a page of results for an async aggregates query

GetAnalyticsJourneysAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:journeyAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsJourneysAggregatesJobResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var jobId = jobId_example;  // string | jobId
            var cursor = cursor_example;  // string | Cursor token to retrieve next page (optional) 

            try
            { 
                // Fetch a page of results for an async aggregates query
                JourneyAsyncAggregateQueryResponse result = apiInstance.GetAnalyticsJourneysAggregatesJobResults(jobId, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetAnalyticsJourneysAggregatesJobResults: " + e.Message );
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

[**JourneyAsyncAggregateQueryResponse**](JourneyAsyncAggregateQueryResponse)


## GetExternalcontactsContactJourneySessions

> [**SessionListing**](SessionListing) GetExternalcontactsContactJourneySessions (string contactId, string pageSize = null, string after = null, bool? includeMerged = null)


Retrieve all sessions for a given external contact.

Requires ANY permissions: 

* externalContacts:session:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetExternalcontactsContactJourneySessionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var contactId = contactId_example;  // string | ExternalContact ID
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var includeMerged = true;  // bool? | Indicates whether to return sessions from all external contacts in the merge-set of the given one. (optional) 

            try
            { 
                // Retrieve all sessions for a given external contact.
                SessionListing result = apiInstance.GetExternalcontactsContactJourneySessions(contactId, pageSize, after, includeMerged);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetExternalcontactsContactJourneySessions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactId** | **string**| ExternalContact ID |  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **includeMerged** | **bool?**| Indicates whether to return sessions from all external contacts in the merge-set of the given one. | [optional]  |

### Return type

[**SessionListing**](SessionListing)


## GetJourneyActionmap

> [**ActionMap**](ActionMap) GetJourneyActionmap (string actionMapId)


Retrieve a single action map.

Requires ANY permissions: 

* journey:actionmap:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneyActionmapExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var actionMapId = actionMapId_example;  // string | ID of the action map.

            try
            { 
                // Retrieve a single action map.
                ActionMap result = apiInstance.GetJourneyActionmap(actionMapId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneyActionmap: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionMapId** | **string**| ID of the action map. |  |

### Return type

[**ActionMap**](ActionMap)


## GetJourneyActionmaps

> [**ActionMapListing**](ActionMapListing) GetJourneyActionmaps (int? pageNumber = null, int? pageSize = null, string sortBy = null, string filterField = null, string filterValue = null, List<string> actionMapIds = null, List<string> queryFields = null, string queryValue = null)


Retrieve all action maps.

Requires ANY permissions: 

* journey:actionmap:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneyActionmapsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Field(s) to sort by. Prefix with '-' for descending (e.g. sortBy=displayName,-createdDate). (optional) 
            var filterField = filterField_example;  // string | Field to filter by (e.g. filterField=weight or filterField=action.actionTemplate.id). Requires 'filterField' to also be set. (optional) 
            var filterValue = filterValue_example;  // string | Value to filter by. Requires 'filterValue' to also be set. (optional) 
            var actionMapIds = new List<string>(); // List<string> | IDs of action maps to return. Use of this parameter is not compatible with pagination, filtering, sorting or querying. A maximum of 100 action maps are allowed per request. (optional) 
            var queryFields = new List<string>(); // List<string> | Action Map field(s) to query on. Requires 'queryValue' to also be set. (optional) 
            var queryValue = queryValue_example;  // string | Value to query on. Requires 'queryFields' to also be set. (optional) 

            try
            { 
                // Retrieve all action maps.
                ActionMapListing result = apiInstance.GetJourneyActionmaps(pageNumber, pageSize, sortBy, filterField, filterValue, actionMapIds, queryFields, queryValue);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneyActionmaps: " + e.Message );
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
| **sortBy** | **string**| Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;displayName,-createdDate). | [optional]  |
| **filterField** | **string**| Field to filter by (e.g. filterField&#x3D;weight or filterField&#x3D;action.actionTemplate.id). Requires &#39;filterField&#39; to also be set. | [optional]  |
| **filterValue** | **string**| Value to filter by. Requires &#39;filterValue&#39; to also be set. | [optional]  |
| **actionMapIds** | [**List<string>**](string)| IDs of action maps to return. Use of this parameter is not compatible with pagination, filtering, sorting or querying. A maximum of 100 action maps are allowed per request. | [optional]  |
| **queryFields** | [**List<string>**](string)| Action Map field(s) to query on. Requires &#39;queryValue&#39; to also be set. | [optional]  |
| **queryValue** | **string**| Value to query on. Requires &#39;queryFields&#39; to also be set. | [optional]  |

### Return type

[**ActionMapListing**](ActionMapListing)


## GetJourneyActionmapsEstimatesJob

> **string** GetJourneyActionmapsEstimatesJob (string jobId)


Get status of job.

Requires ALL permissions: 

* journey:actionmapEstimateJob:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneyActionmapsEstimatesJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var jobId = jobId_example;  // string | ID of the job.

            try
            { 
                // Get status of job.
                string result = apiInstance.GetJourneyActionmapsEstimatesJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneyActionmapsEstimatesJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| ID of the job. |  |

### Return type

**string**


## GetJourneyActionmapsEstimatesJobResults

> [**ActionMapEstimateResult**](ActionMapEstimateResult) GetJourneyActionmapsEstimatesJobResults (string jobId)


Get estimates from completed job.

Requires ALL permissions: 

* journey:actionmapEstimate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneyActionmapsEstimatesJobResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var jobId = jobId_example;  // string | ID of the job.

            try
            { 
                // Get estimates from completed job.
                ActionMapEstimateResult result = apiInstance.GetJourneyActionmapsEstimatesJobResults(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneyActionmapsEstimatesJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| ID of the job. |  |

### Return type

[**ActionMapEstimateResult**](ActionMapEstimateResult)


## GetJourneyActiontarget

> [**ActionTarget**](ActionTarget) GetJourneyActiontarget (string actionTargetId)


Retrieve a single action target.

Requires ANY permissions: 

* journey:actiontarget:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneyActiontargetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var actionTargetId = actionTargetId_example;  // string | ID of the action target.

            try
            { 
                // Retrieve a single action target.
                ActionTarget result = apiInstance.GetJourneyActiontarget(actionTargetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneyActiontarget: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionTargetId** | **string**| ID of the action target. |  |

### Return type

[**ActionTarget**](ActionTarget)


## GetJourneyActiontargets

> [**ActionTargetListing**](ActionTargetListing) GetJourneyActiontargets (int? pageNumber = null, int? pageSize = null)


Retrieve all action targets.

Requires ANY permissions: 

* journey:actiontarget:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneyActiontargetsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            { 
                // Retrieve all action targets.
                ActionTargetListing result = apiInstance.GetJourneyActiontargets(pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneyActiontargets: " + e.Message );
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

### Return type

[**ActionTargetListing**](ActionTargetListing)


## GetJourneyActiontemplate

> [**ActionTemplate**](ActionTemplate) GetJourneyActiontemplate (string actionTemplateId)


Retrieve a single action template.

Requires ANY permissions: 

* journey:actiontemplate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneyActiontemplateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var actionTemplateId = actionTemplateId_example;  // string | ID of the action template.

            try
            { 
                // Retrieve a single action template.
                ActionTemplate result = apiInstance.GetJourneyActiontemplate(actionTemplateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneyActiontemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionTemplateId** | **string**| ID of the action template. |  |

### Return type

[**ActionTemplate**](ActionTemplate)


## GetJourneyActiontemplates

> [**ActionTemplateListing**](ActionTemplateListing) GetJourneyActiontemplates (int? pageNumber = null, int? pageSize = null, string sortBy = null, string mediaType = null, string state = null, List<string> queryFields = null, string queryValue = null)


Retrieve all action templates.

Requires ANY permissions: 

* journey:actiontemplate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneyActiontemplatesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Field(s) to sort by. Prefix with '-' for descending (e.g. sortBy=name,-createdDate). (optional) 
            var mediaType = mediaType_example;  // string | Media type (optional) 
            var state = state_example;  // string | Action template state. (optional) 
            var queryFields = new List<string>(); // List<string> | ActionTemplate field(s) to query on. Requires 'queryValue' to also be set. (optional) 
            var queryValue = queryValue_example;  // string | Value to query on. Requires 'queryFields' to also be set. (optional) 

            try
            { 
                // Retrieve all action templates.
                ActionTemplateListing result = apiInstance.GetJourneyActiontemplates(pageNumber, pageSize, sortBy, mediaType, state, queryFields, queryValue);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneyActiontemplates: " + e.Message );
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
| **sortBy** | **string**| Field(s) to sort by. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;name,-createdDate). | [optional]  |
| **mediaType** | **string**| Media type | [optional] <br />**Values**: webchat, webMessagingOffer, contentOffer, integrationAction, architectFlow, openAction |
| **state** | **string**| Action template state. | [optional] <br />**Values**: Active, Inactive, Deleted |
| **queryFields** | [**List<string>**](string)| ActionTemplate field(s) to query on. Requires &#39;queryValue&#39; to also be set. | [optional]  |
| **queryValue** | **string**| Value to query on. Requires &#39;queryFields&#39; to also be set. | [optional]  |

### Return type

[**ActionTemplateListing**](ActionTemplateListing)


## GetJourneyDeploymentCustomerPing

> [**DeploymentPing**](DeploymentPing) GetJourneyDeploymentCustomerPing (string deploymentId, string customerCookieId, string dl = null, string dt = null, string appNamespace = null, string sessionId = null, long? sinceLastBeaconMilliseconds = null)


Send a ping.

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
    public class GetJourneyDeploymentCustomerPingExample
    {
        public void main()
        { 

            var apiInstance = new JourneyApi();
            var deploymentId = deploymentId_example;  // string | The ID of the deployment sending the ping.
            var customerCookieId = customerCookieId_example;  // string | ID of the customer associated with the ping.
            var dl = dl_example;  // string | Document Location: 1) Web Page URL if overridden or URL fragment identifier (window.location.hash). OR  2) Application screen name that the ping request was sent from in the app. e.g. 'home' or 'help. Pings without this parameter will not return actions. (optional) 
            var dt = dt_example;  // string | Document Title.  A human readable name for the page or screen (optional) 
            var appNamespace = appNamespace_example;  // string | Namespace of the application (e.g. com.genesys.bancodinero). Used for domain filtering in application sessions (optional) 
            var sessionId = sessionId_example;  // string | UUID of the customer session. Use the same Session Id for all pings, AppEvents and ActionEvents in the session (optional) 
            var sinceLastBeaconMilliseconds = 789;  // long? | How long (milliseconds) since the last app event or beacon was sent. The response may return a pollInternvalMilliseconds to reduce the frequency of pings. (optional) 

            try
            { 
                // Send a ping.
                DeploymentPing result = apiInstance.GetJourneyDeploymentCustomerPing(deploymentId, customerCookieId, dl, dt, appNamespace, sessionId, sinceLastBeaconMilliseconds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneyDeploymentCustomerPing: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deploymentId** | **string**| The ID of the deployment sending the ping. |  |
| **customerCookieId** | **string**| ID of the customer associated with the ping. |  |
| **dl** | **string**| Document Location: 1) Web Page URL if overridden or URL fragment identifier (window.location.hash). OR  2) Application screen name that the ping request was sent from in the app. e.g. &#39;home&#39; or &#39;help. Pings without this parameter will not return actions. | [optional]  |
| **dt** | **string**| Document Title.  A human readable name for the page or screen | [optional]  |
| **appNamespace** | **string**| Namespace of the application (e.g. com.genesys.bancodinero). Used for domain filtering in application sessions | [optional]  |
| **sessionId** | **string**| UUID of the customer session. Use the same Session Id for all pings, AppEvents and ActionEvents in the session | [optional]  |
| **sinceLastBeaconMilliseconds** | **long?**| How long (milliseconds) since the last app event or beacon was sent. The response may return a pollInternvalMilliseconds to reduce the frequency of pings. | [optional]  |

### Return type

[**DeploymentPing**](DeploymentPing)


## GetJourneyOutcome

> [**Outcome**](Outcome) GetJourneyOutcome (string outcomeId)


Retrieve a single outcome.

Requires ANY permissions: 

* journey:outcome:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneyOutcomeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var outcomeId = outcomeId_example;  // string | ID of the outcome.

            try
            { 
                // Retrieve a single outcome.
                Outcome result = apiInstance.GetJourneyOutcome(outcomeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneyOutcome: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **outcomeId** | **string**| ID of the outcome. |  |

### Return type

[**Outcome**](Outcome)


## GetJourneyOutcomes

> [**OutcomeListing**](OutcomeListing) GetJourneyOutcomes (int? pageNumber = null, int? pageSize = null, string sortBy = null, List<string> outcomeIds = null, List<string> queryFields = null, string queryValue = null)


Retrieve all outcomes.

Requires ANY permissions: 

* journey:outcome:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneyOutcomesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with '-' for descending (e.g. sortBy=displayName,-createdDate). (optional) 
            var outcomeIds = new List<string>(); // List<string> | IDs of outcomes to return. Use of this parameter is not compatible with pagination, sorting or querying. A maximum of 20 outcomes are allowed per request. (optional) 
            var queryFields = new List<string>(); // List<string> | Outcome field(s) to query on. Requires 'queryValue' to also be set. (optional) 
            var queryValue = queryValue_example;  // string | Value to query on. Requires 'queryFields' to also be set. (optional) 

            try
            { 
                // Retrieve all outcomes.
                OutcomeListing result = apiInstance.GetJourneyOutcomes(pageNumber, pageSize, sortBy, outcomeIds, queryFields, queryValue);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneyOutcomes: " + e.Message );
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
| **sortBy** | **string**| Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;displayName,-createdDate). | [optional]  |
| **outcomeIds** | [**List<string>**](string)| IDs of outcomes to return. Use of this parameter is not compatible with pagination, sorting or querying. A maximum of 20 outcomes are allowed per request. | [optional]  |
| **queryFields** | [**List<string>**](string)| Outcome field(s) to query on. Requires &#39;queryValue&#39; to also be set. | [optional]  |
| **queryValue** | **string**| Value to query on. Requires &#39;queryFields&#39; to also be set. | [optional]  |

### Return type

[**OutcomeListing**](OutcomeListing)


## GetJourneyOutcomesAttributionsJob

> [**OutcomeAttributionJobStateResponse**](OutcomeAttributionJobStateResponse) GetJourneyOutcomesAttributionsJob (string jobId)


Get job status.

GetJourneyOutcomesAttributionsJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* journey:outcomeAttributionJob:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneyOutcomesAttributionsJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var jobId = jobId_example;  // string | ID of the job.

            try
            { 
                // Get job status.
                OutcomeAttributionJobStateResponse result = apiInstance.GetJourneyOutcomesAttributionsJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneyOutcomesAttributionsJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| ID of the job. |  |

### Return type

[**OutcomeAttributionJobStateResponse**](OutcomeAttributionJobStateResponse)


## GetJourneyOutcomesAttributionsJobResults

> [**OutcomeAttributionResponseListing**](OutcomeAttributionResponseListing) GetJourneyOutcomesAttributionsJobResults (string jobId)


Get outcome attribution entities from completed job.

GetJourneyOutcomesAttributionsJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* journey:outcomeAttribution:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneyOutcomesAttributionsJobResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var jobId = jobId_example;  // string | ID of the job.

            try
            { 
                // Get outcome attribution entities from completed job.
                OutcomeAttributionResponseListing result = apiInstance.GetJourneyOutcomesAttributionsJobResults(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneyOutcomesAttributionsJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| ID of the job. |  |

### Return type

[**OutcomeAttributionResponseListing**](OutcomeAttributionResponseListing)


## GetJourneyOutcomesPredictor

> [**OutcomePredictor**](OutcomePredictor) GetJourneyOutcomesPredictor (string predictorId)


Retrieve a single outcome predictor.

Requires ANY permissions: 

* journey:outcomepredictor:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneyOutcomesPredictorExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var predictorId = predictorId_example;  // string | ID of predictor

            try
            { 
                // Retrieve a single outcome predictor.
                OutcomePredictor result = apiInstance.GetJourneyOutcomesPredictor(predictorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneyOutcomesPredictor: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **predictorId** | **string**| ID of predictor |  |

### Return type

[**OutcomePredictor**](OutcomePredictor)


## GetJourneyOutcomesPredictors

> [**OutcomePredictorListing**](OutcomePredictorListing) GetJourneyOutcomesPredictors ()


Retrieve all outcome predictors.

Requires ANY permissions: 

* journey:outcomepredictor:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneyOutcomesPredictorsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();

            try
            { 
                // Retrieve all outcome predictors.
                OutcomePredictorListing result = apiInstance.GetJourneyOutcomesPredictors();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneyOutcomesPredictors: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**OutcomePredictorListing**](OutcomePredictorListing)


## GetJourneySegment

> [**JourneySegment**](JourneySegment) GetJourneySegment (string segmentId)


Retrieve a single segment.

Requires ANY permissions: 

* journey:segment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneySegmentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var segmentId = segmentId_example;  // string | ID of the segment.

            try
            { 
                // Retrieve a single segment.
                JourneySegment result = apiInstance.GetJourneySegment(segmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneySegment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **segmentId** | **string**| ID of the segment. |  |

### Return type

[**JourneySegment**](JourneySegment)


## GetJourneySegments

> [**SegmentListing**](SegmentListing) GetJourneySegments (string sortBy = null, int? pageSize = null, int? pageNumber = null, bool? isActive = null, List<string> segmentIds = null, List<string> queryFields = null, string queryValue = null)


Retrieve all segments.

Requires ANY permissions: 

* journey:segment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneySegmentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var sortBy = sortBy_example;  // string | Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with '-' for descending (e.g. sortBy=displayName,-createdDate). (optional) 
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var isActive = true;  // bool? | Determines whether or not to show only active segments. (optional) 
            var segmentIds = new List<string>(); // List<string> | IDs of segments to return. Use of this parameter is not compatible with pagination, sorting or querying. A maximum of 100 segments are allowed per request. (optional) 
            var queryFields = new List<string>(); // List<string> | Segment field(s) to query on. Requires 'queryValue' to also be set. (optional) 
            var queryValue = queryValue_example;  // string | Value to query on. Requires 'queryFields' to also be set. (optional) 

            try
            { 
                // Retrieve all segments.
                SegmentListing result = apiInstance.GetJourneySegments(sortBy, pageSize, pageNumber, isActive, segmentIds, queryFields, queryValue);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneySegments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sortBy** | **string**| Field(s) to sort by. The response can be sorted by any first level property on the Outcome response. Prefix with &#39;-&#39; for descending (e.g. sortBy&#x3D;displayName,-createdDate). | [optional]  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **isActive** | **bool?**| Determines whether or not to show only active segments. | [optional]  |
| **segmentIds** | [**List<string>**](string)| IDs of segments to return. Use of this parameter is not compatible with pagination, sorting or querying. A maximum of 100 segments are allowed per request. | [optional]  |
| **queryFields** | [**List<string>**](string)| Segment field(s) to query on. Requires &#39;queryValue&#39; to also be set. | [optional]  |
| **queryValue** | **string**| Value to query on. Requires &#39;queryFields&#39; to also be set. | [optional]  |

### Return type

[**SegmentListing**](SegmentListing)


## GetJourneySession

> [**Session**](Session) GetJourneySession (string sessionId)


Retrieve a single session.

Requires ANY permissions: 

* journey:session:view
* externalContacts:session:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneySessionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var sessionId = sessionId_example;  // string | ID of the session.

            try
            { 
                // Retrieve a single session.
                Session result = apiInstance.GetJourneySession(sessionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneySession: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sessionId** | **string**| ID of the session. |  |

### Return type

[**Session**](Session)


## GetJourneySessionEvents

> [**EventListing**](EventListing) GetJourneySessionEvents (string sessionId, string pageSize = null, string after = null, string eventType = null)


Retrieve all events for a given session.

Requires ANY permissions: 

* journey:event:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneySessionEventsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var sessionId = sessionId_example;  // string | System-generated UUID that represents the session the event is a part of.
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var eventType = eventType_example;  // string | A comma separated list of journey event types to include in the results. (optional) 

            try
            { 
                // Retrieve all events for a given session.
                EventListing result = apiInstance.GetJourneySessionEvents(sessionId, pageSize, after, eventType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneySessionEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sessionId** | **string**| System-generated UUID that represents the session the event is a part of. |  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **eventType** | **string**| A comma separated list of journey event types to include in the results. | [optional] <br />**Values**: com.genesys.journey.OutcomeAchievedEvent, com.genesys.journey.SegmentAssignmentEvent, com.genesys.journey.WebActionEvent, com.genesys.journey.WebEvent, com.genesys.journey.AppEvent |

### Return type

[**EventListing**](EventListing)


## GetJourneySessionOutcomescores

> [**OutcomeScoresResult**](OutcomeScoresResult) GetJourneySessionOutcomescores (string sessionId)


Retrieve latest outcome score associated with a session for all outcomes.

Requires ANY permissions: 

* journey:outcomescores:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneySessionOutcomescoresExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var sessionId = sessionId_example;  // string | ID of the session.

            try
            { 
                // Retrieve latest outcome score associated with a session for all outcomes.
                OutcomeScoresResult result = apiInstance.GetJourneySessionOutcomescores(sessionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneySessionOutcomescores: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sessionId** | **string**| ID of the session. |  |

### Return type

[**OutcomeScoresResult**](OutcomeScoresResult)


## GetJourneyView

> [**JourneyView**](JourneyView) GetJourneyView (string viewId)


Get a Journey View by ID

returns the latest version

Requires ALL permissions: 

* journey:views:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneyViewExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var viewId = viewId_example;  // string | viewId

            try
            { 
                // Get a Journey View by ID
                JourneyView result = apiInstance.GetJourneyView(viewId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneyView: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **viewId** | **string**| viewId |  |

### Return type

[**JourneyView**](JourneyView)


## GetJourneyViewVersion

> [**JourneyView**](JourneyView) GetJourneyViewVersion (string viewId, string versionId)


Get a Journey View by ID and version

Requires ALL permissions: 

* journey:views:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneyViewVersionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var viewId = viewId_example;  // string | viewId
            var versionId = versionId_example;  // string | versionId

            try
            { 
                // Get a Journey View by ID and version
                JourneyView result = apiInstance.GetJourneyViewVersion(viewId, versionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneyViewVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **viewId** | **string**| viewId |  |
| **versionId** | **string**| versionId |  |

### Return type

[**JourneyView**](JourneyView)


## GetJourneyViewVersionChart

> [**JourneyViewChart**](JourneyViewChart) GetJourneyViewVersionChart (string viewId, string journeyViewVersion, string chartId)


Get a Chart by ID

returns the latest version

Requires ALL permissions: 

* journey:views:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneyViewVersionChartExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var viewId = viewId_example;  // string | viewId
            var journeyViewVersion = journeyViewVersion_example;  // string | Journey View Version
            var chartId = chartId_example;  // string | chartId

            try
            { 
                // Get a Chart by ID
                JourneyViewChart result = apiInstance.GetJourneyViewVersionChart(viewId, journeyViewVersion, chartId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneyViewVersionChart: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **viewId** | **string**| viewId |  |
| **journeyViewVersion** | **string**| Journey View Version |  |
| **chartId** | **string**| chartId |  |

### Return type

[**JourneyViewChart**](JourneyViewChart)


## GetJourneyViewVersionChartVersion

> [**JourneyViewChart**](JourneyViewChart) GetJourneyViewVersionChartVersion (string viewId, string journeyViewVersion, string chartId, string chartVersion)


Get a Chart by ID and version

Requires ALL permissions: 

* journey:views:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneyViewVersionChartVersionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var viewId = viewId_example;  // string | viewId
            var journeyViewVersion = journeyViewVersion_example;  // string | Journey View Version
            var chartId = chartId_example;  // string | chartId
            var chartVersion = chartVersion_example;  // string | chartVersion

            try
            { 
                // Get a Chart by ID and version
                JourneyViewChart result = apiInstance.GetJourneyViewVersionChartVersion(viewId, journeyViewVersion, chartId, chartVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneyViewVersionChartVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **viewId** | **string**| viewId |  |
| **journeyViewVersion** | **string**| Journey View Version |  |
| **chartId** | **string**| chartId |  |
| **chartVersion** | **string**| chartVersion |  |

### Return type

[**JourneyViewChart**](JourneyViewChart)


## GetJourneyViewVersionJob

> [**JourneyViewJob**](JourneyViewJob) GetJourneyViewVersionJob (string viewId, string journeyVersionId, string jobId)


Get the job for a journey view version.

used for long descriptions

Requires ALL permissions: 

* journey:viewsJobs:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneyViewVersionJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var viewId = viewId_example;  // string | Journey View Id
            var journeyVersionId = journeyVersionId_example;  // string | Journey View Version
            var jobId = jobId_example;  // string | JobId

            try
            { 
                // Get the job for a journey view version.
                JourneyViewJob result = apiInstance.GetJourneyViewVersionJob(viewId, journeyVersionId, jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneyViewVersionJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **viewId** | **string**| Journey View Id |  |
| **journeyVersionId** | **string**| Journey View Version |  |
| **jobId** | **string**| JobId |  |

### Return type

[**JourneyViewJob**](JourneyViewJob)


## GetJourneyViewVersionJobResults

> [**JourneyViewResult**](JourneyViewResult) GetJourneyViewVersionJobResults (string viewId, string journeyViewVersion, string jobId)


Get the result of a job for a journey view version.

used for long descriptions

Requires ALL permissions: 

* journey:viewsResults:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneyViewVersionJobResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var viewId = viewId_example;  // string | JourneyViewResult id
            var journeyViewVersion = journeyViewVersion_example;  // string | Journey View Version
            var jobId = jobId_example;  // string | Id of the executing job

            try
            { 
                // Get the result of a job for a journey view version.
                JourneyViewResult result = apiInstance.GetJourneyViewVersionJobResults(viewId, journeyViewVersion, jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneyViewVersionJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **viewId** | **string**| JourneyViewResult id |  |
| **journeyViewVersion** | **string**| Journey View Version |  |
| **jobId** | **string**| Id of the executing job |  |

### Return type

[**JourneyViewResult**](JourneyViewResult)


## GetJourneyViewVersionJobResultsChart

> [**JourneyViewChartResult**](JourneyViewChartResult) GetJourneyViewVersionJobResultsChart (string viewId, string journeyVersionId, string jobId, string chartId)


Get the chart result associated with a journey view job.

Requires ALL permissions: 

* journey:viewsResults:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneyViewVersionJobResultsChartExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var viewId = viewId_example;  // string | Journey View Id
            var journeyVersionId = journeyVersionId_example;  // string | Journey View Version
            var jobId = jobId_example;  // string | JobId
            var chartId = chartId_example;  // string | ChartId

            try
            { 
                // Get the chart result associated with a journey view job.
                JourneyViewChartResult result = apiInstance.GetJourneyViewVersionJobResultsChart(viewId, journeyVersionId, jobId, chartId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneyViewVersionJobResultsChart: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **viewId** | **string**| Journey View Id |  |
| **journeyVersionId** | **string**| Journey View Version |  |
| **jobId** | **string**| JobId |  |
| **chartId** | **string**| ChartId |  |

### Return type

[**JourneyViewChartResult**](JourneyViewChartResult)


## GetJourneyViewVersionJobsLatest

> [**JourneyViewJob**](JourneyViewJob) GetJourneyViewVersionJobsLatest (string viewId, string journeyVersionId)


Get the latest job of a journey view version.

used for long descriptions

Requires ALL permissions: 

* journey:viewsJobs:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneyViewVersionJobsLatestExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var viewId = viewId_example;  // string | Journey View Id
            var journeyVersionId = journeyVersionId_example;  // string | Journey View Version

            try
            { 
                // Get the latest job of a journey view version.
                JourneyViewJob result = apiInstance.GetJourneyViewVersionJobsLatest(viewId, journeyVersionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneyViewVersionJobsLatest: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **viewId** | **string**| Journey View Id |  |
| **journeyVersionId** | **string**| Journey View Version |  |

### Return type

[**JourneyViewJob**](JourneyViewJob)


## GetJourneyViews

> [**JourneyViewListing**](JourneyViewListing) GetJourneyViews (int? pageNumber = null, int? pageSize = null, string nameOrCreatedBy = null, string expand = null, string id = null)


Get a list of Journey Views

Requires ALL permissions: 

* journey:views:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneyViewsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var nameOrCreatedBy = nameOrCreatedBy_example;  // string | Journey View Name or Created By (optional) 
            var expand = expand_example;  // string | Parameter to request additional data to return in Journey payload (optional) 
            var id = id_example;  // string | Parameter to request a list of Journey Views by id, separated by commas. Limit of 100 items. (optional) 

            try
            { 
                // Get a list of Journey Views
                JourneyViewListing result = apiInstance.GetJourneyViews(pageNumber, pageSize, nameOrCreatedBy, expand, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneyViews: " + e.Message );
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
| **nameOrCreatedBy** | **string**| Journey View Name or Created By | [optional]  |
| **expand** | **string**| Parameter to request additional data to return in Journey payload | [optional] <br />**Values**: charts |
| **id** | **string**| Parameter to request a list of Journey Views by id, separated by commas. Limit of 100 items. | [optional]  |

### Return type

[**JourneyViewListing**](JourneyViewListing)


## GetJourneyViewsEventdefinition

> [**JourneyEventDefinition**](JourneyEventDefinition) GetJourneyViewsEventdefinition (string eventDefinitionId)


Get an Event Definition

GetJourneyViewsEventdefinition is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* journey:eventDefinition:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneyViewsEventdefinitionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var eventDefinitionId = eventDefinitionId_example;  // string | Event Definition ID

            try
            { 
                // Get an Event Definition
                JourneyEventDefinition result = apiInstance.GetJourneyViewsEventdefinition(eventDefinitionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneyViewsEventdefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **eventDefinitionId** | **string**| Event Definition ID |  |

### Return type

[**JourneyEventDefinition**](JourneyEventDefinition)


## GetJourneyViewsEventdefinitions

> [**JourneyEventDefinitionListing**](JourneyEventDefinitionListing) GetJourneyViewsEventdefinitions ()


Get a list of Event Definitions

GetJourneyViewsEventdefinitions is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* journey:eventDefinition:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneyViewsEventdefinitionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();

            try
            { 
                // Get a list of Event Definitions
                JourneyEventDefinitionListing result = apiInstance.GetJourneyViewsEventdefinitions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneyViewsEventdefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**JourneyEventDefinitionListing**](JourneyEventDefinitionListing)


## GetJourneyViewsJobs

> [**JourneyViewJobListing**](JourneyViewJobListing) GetJourneyViewsJobs (int? pageNumber = null, int? pageSize = null, string interval = null, string statuses = null)


Get the jobs for an organization.

Requires ALL permissions: 

* journey:viewsJobs:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneyViewsJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var pageNumber = 56;  // int? | The number of the page to return (optional)  (default to 1)
            var pageSize = 56;  // int? | Max number of entities to return (optional)  (default to 25)
            var interval = 2023-07-17T00:00:00Z/2023-07-18T00:00:00Z;  // string | An absolute timeframe for filtering the jobs, expressed as an ISO 8601 interval. (optional) 
            var statuses = statuses&#x3D;Accepted,Executing,Complete,Failed;  // string | Job statuses to filter for (optional) 

            try
            { 
                // Get the jobs for an organization.
                JourneyViewJobListing result = apiInstance.GetJourneyViewsJobs(pageNumber, pageSize, interval, statuses);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneyViewsJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| The number of the page to return | [optional] [default to 1] |
| **pageSize** | **int?**| Max number of entities to return | [optional] [default to 25] |
| **interval** | **string**| An absolute timeframe for filtering the jobs, expressed as an ISO 8601 interval. | [optional]  |
| **statuses** | **string**| Job statuses to filter for | [optional]  |

### Return type

[**JourneyViewJobListing**](JourneyViewJobListing)


## PatchJourneyActionmap

> [**ActionMap**](ActionMap) PatchJourneyActionmap (string actionMapId, PatchActionMap body = null)


Update single action map.

Requires ANY permissions: 

* journey:actionmap:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchJourneyActionmapExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var actionMapId = actionMapId_example;  // string | ID of the action map.
            var body = new PatchActionMap(); // PatchActionMap |  (optional) 

            try
            { 
                // Update single action map.
                ActionMap result = apiInstance.PatchJourneyActionmap(actionMapId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.PatchJourneyActionmap: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionMapId** | **string**| ID of the action map. |  |
| **body** | [**PatchActionMap**](PatchActionMap)|  | [optional]  |

### Return type

[**ActionMap**](ActionMap)


## PatchJourneyActiontarget

> [**ActionTarget**](ActionTarget) PatchJourneyActiontarget (string actionTargetId, PatchActionTarget body = null)


Update a single action target.

Requires ANY permissions: 

* journey:actiontarget:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchJourneyActiontargetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var actionTargetId = actionTargetId_example;  // string | ID of the action target.
            var body = new PatchActionTarget(); // PatchActionTarget |  (optional) 

            try
            { 
                // Update a single action target.
                ActionTarget result = apiInstance.PatchJourneyActiontarget(actionTargetId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.PatchJourneyActiontarget: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionTargetId** | **string**| ID of the action target. |  |
| **body** | [**PatchActionTarget**](PatchActionTarget)|  | [optional]  |

### Return type

[**ActionTarget**](ActionTarget)


## PatchJourneyActiontemplate

> [**ActionTemplate**](ActionTemplate) PatchJourneyActiontemplate (string actionTemplateId, PatchActionTemplate body = null)


Update a single action template.

Requires ANY permissions: 

* journey:actiontemplate:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchJourneyActiontemplateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var actionTemplateId = actionTemplateId_example;  // string | ID of the action template.
            var body = new PatchActionTemplate(); // PatchActionTemplate |  (optional) 

            try
            { 
                // Update a single action template.
                ActionTemplate result = apiInstance.PatchJourneyActiontemplate(actionTemplateId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.PatchJourneyActiontemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionTemplateId** | **string**| ID of the action template. |  |
| **body** | [**PatchActionTemplate**](PatchActionTemplate)|  | [optional]  |

### Return type

[**ActionTemplate**](ActionTemplate)


## PatchJourneyOutcome

> [**Outcome**](Outcome) PatchJourneyOutcome (string outcomeId, PatchOutcome body = null)


Update an outcome.

Requires ANY permissions: 

* journey:outcome:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchJourneyOutcomeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var outcomeId = outcomeId_example;  // string | ID of the outcome.
            var body = new PatchOutcome(); // PatchOutcome |  (optional) 

            try
            { 
                // Update an outcome.
                Outcome result = apiInstance.PatchJourneyOutcome(outcomeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.PatchJourneyOutcome: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **outcomeId** | **string**| ID of the outcome. |  |
| **body** | [**PatchOutcome**](PatchOutcome)|  | [optional]  |

### Return type

[**Outcome**](Outcome)


## PatchJourneySegment

> [**JourneySegment**](JourneySegment) PatchJourneySegment (string segmentId, PatchSegment body = null)


Update a segment.

Requires ANY permissions: 

* journey:segment:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchJourneySegmentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var segmentId = segmentId_example;  // string | ID of the segment.
            var body = new PatchSegment(); // PatchSegment |  (optional) 

            try
            { 
                // Update a segment.
                JourneySegment result = apiInstance.PatchJourneySegment(segmentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.PatchJourneySegment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **segmentId** | **string**| ID of the segment. |  |
| **body** | [**PatchSegment**](PatchSegment)|  | [optional]  |

### Return type

[**JourneySegment**](JourneySegment)


## PatchJourneyViewVersionJob

> [**JourneyViewJob**](JourneyViewJob) PatchJourneyViewVersionJob (string viewId, string journeyVersionId, string jobId, JourneyViewJob body)


Update the job for a journey view version. Only the status can be changed and only to Cancelled

used for long descriptions

Requires ALL permissions: 

* journey:viewsJobs:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchJourneyViewVersionJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var viewId = viewId_example;  // string | Journey View Id
            var journeyVersionId = journeyVersionId_example;  // string | Journey View Version
            var jobId = jobId_example;  // string | JobId
            var body = new JourneyViewJob(); // JourneyViewJob | journeyViewJob

            try
            { 
                // Update the job for a journey view version. Only the status can be changed and only to Cancelled
                JourneyViewJob result = apiInstance.PatchJourneyViewVersionJob(viewId, journeyVersionId, jobId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.PatchJourneyViewVersionJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **viewId** | **string**| Journey View Id |  |
| **journeyVersionId** | **string**| Journey View Version |  |
| **jobId** | **string**| JobId |  |
| **body** | [**JourneyViewJob**](JourneyViewJob)| journeyViewJob |  |

### Return type

[**JourneyViewJob**](JourneyViewJob)


## PostAnalyticsJourneysAggregatesJobs

> [**AsyncQueryResponse**](AsyncQueryResponse) PostAnalyticsJourneysAggregatesJobs (JourneyAsyncAggregationQuery body)


Query for journey aggregates asynchronously

PostAnalyticsJourneysAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:journeyAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsJourneysAggregatesJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var body = new JourneyAsyncAggregationQuery(); // JourneyAsyncAggregationQuery | query

            try
            { 
                // Query for journey aggregates asynchronously
                AsyncQueryResponse result = apiInstance.PostAnalyticsJourneysAggregatesJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.PostAnalyticsJourneysAggregatesJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**JourneyAsyncAggregationQuery**](JourneyAsyncAggregationQuery)| query |  |

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse)


## PostAnalyticsJourneysAggregatesQuery

> [**JourneyAggregateQueryResponse**](JourneyAggregateQueryResponse) PostAnalyticsJourneysAggregatesQuery (JourneyAggregationQuery body)


Query for journey aggregates

Requires ANY permissions: 

* analytics:journeyAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsJourneysAggregatesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var body = new JourneyAggregationQuery(); // JourneyAggregationQuery | query

            try
            { 
                // Query for journey aggregates
                JourneyAggregateQueryResponse result = apiInstance.PostAnalyticsJourneysAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.PostAnalyticsJourneysAggregatesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**JourneyAggregationQuery**](JourneyAggregationQuery)| query |  |

### Return type

[**JourneyAggregateQueryResponse**](JourneyAggregateQueryResponse)


## PostJourneyActionmaps

> [**ActionMap**](ActionMap) PostJourneyActionmaps (ActionMap body = null)


Create an action map.

Requires ANY permissions: 

* journey:actionmap:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostJourneyActionmapsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var body = new ActionMap(); // ActionMap |  (optional) 

            try
            { 
                // Create an action map.
                ActionMap result = apiInstance.PostJourneyActionmaps(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.PostJourneyActionmaps: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ActionMap**](ActionMap)|  | [optional]  |

### Return type

[**ActionMap**](ActionMap)


## PostJourneyActionmapsEstimatesJobs

> [**EstimateJobAsyncResponse**](EstimateJobAsyncResponse) PostJourneyActionmapsEstimatesJobs (ActionMapEstimateRequest body)


Query for estimates

Requires ANY permissions: 

* journey:actionmapEstimateJob:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostJourneyActionmapsEstimatesJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var body = new ActionMapEstimateRequest(); // ActionMapEstimateRequest | audience estimator request

            try
            { 
                // Query for estimates
                EstimateJobAsyncResponse result = apiInstance.PostJourneyActionmapsEstimatesJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.PostJourneyActionmapsEstimatesJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ActionMapEstimateRequest**](ActionMapEstimateRequest)| audience estimator request |  |

### Return type

[**EstimateJobAsyncResponse**](EstimateJobAsyncResponse)


## PostJourneyActiontemplates

> [**ActionTemplate**](ActionTemplate) PostJourneyActiontemplates (ActionTemplate body = null)


Create a single action template.

Requires ANY permissions: 

* journey:actiontemplate:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostJourneyActiontemplatesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var body = new ActionTemplate(); // ActionTemplate |  (optional) 

            try
            { 
                // Create a single action template.
                ActionTemplate result = apiInstance.PostJourneyActiontemplates(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.PostJourneyActiontemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ActionTemplate**](ActionTemplate)|  | [optional]  |

### Return type

[**ActionTemplate**](ActionTemplate)


## PostJourneyDeploymentActionevent

> void PostJourneyDeploymentActionevent (string deploymentId, ActionEventRequest body)


Sends an action event, which is used for changing the state of actions that have been offered to the user.

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
    public class PostJourneyDeploymentActioneventExample
    {
        public void main()
        { 

            var apiInstance = new JourneyApi();
            var deploymentId = deploymentId_example;  // string | The ID of the deployment sending the beacon.
            var body = new ActionEventRequest(); // ActionEventRequest | 

            try
            { 
                // Sends an action event, which is used for changing the state of actions that have been offered to the user.
                apiInstance.PostJourneyDeploymentActionevent(deploymentId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.PostJourneyDeploymentActionevent: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deploymentId** | **string**| The ID of the deployment sending the beacon. |  |
| **body** | [**ActionEventRequest**](ActionEventRequest)|  |  |

### Return type

void (empty response body)


## PostJourneyDeploymentAppevents

> [**AppEventResponse**](AppEventResponse) PostJourneyDeploymentAppevents (string deploymentId, AppEventRequest body = null)


Send a journey app event, used for tracking customer activity on an application.

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
    public class PostJourneyDeploymentAppeventsExample
    {
        public void main()
        { 

            var apiInstance = new JourneyApi();
            var deploymentId = deploymentId_example;  // string | The ID of the deployment sending the app event.
            var body = new AppEventRequest(); // AppEventRequest |  (optional) 

            try
            { 
                // Send a journey app event, used for tracking customer activity on an application.
                AppEventResponse result = apiInstance.PostJourneyDeploymentAppevents(deploymentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.PostJourneyDeploymentAppevents: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deploymentId** | **string**| The ID of the deployment sending the app event. |  |
| **body** | [**AppEventRequest**](AppEventRequest)|  | [optional]  |

### Return type

[**AppEventResponse**](AppEventResponse)


## PostJourneyDeploymentWebevents

> [**WebEventResponse**](WebEventResponse) PostJourneyDeploymentWebevents (string deploymentId, WebEventRequest body = null)


Send a journey web event, used for tracking customer activity on a website.

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
    public class PostJourneyDeploymentWebeventsExample
    {
        public void main()
        { 

            var apiInstance = new JourneyApi();
            var deploymentId = deploymentId_example;  // string | The ID of the deployment sending the web event.
            var body = new WebEventRequest(); // WebEventRequest |  (optional) 

            try
            { 
                // Send a journey web event, used for tracking customer activity on a website.
                WebEventResponse result = apiInstance.PostJourneyDeploymentWebevents(deploymentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.PostJourneyDeploymentWebevents: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **deploymentId** | **string**| The ID of the deployment sending the web event. |  |
| **body** | [**WebEventRequest**](WebEventRequest)|  | [optional]  |

### Return type

[**WebEventResponse**](WebEventResponse)


## PostJourneyFlowsPathsQuery

> [**FlowPaths**](FlowPaths) PostJourneyFlowsPathsQuery (FlowPathsQuery body = null)


Query for flow paths.

Requires ALL permissions: 

* journey:flowpaths:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostJourneyFlowsPathsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var body = new FlowPathsQuery(); // FlowPathsQuery |  (optional) 

            try
            { 
                // Query for flow paths.
                FlowPaths result = apiInstance.PostJourneyFlowsPathsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.PostJourneyFlowsPathsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**FlowPathsQuery**](FlowPathsQuery)|  | [optional]  |

### Return type

[**FlowPaths**](FlowPaths)


## PostJourneyOutcomes

> [**Outcome**](Outcome) PostJourneyOutcomes (OutcomeRequest body = null)


Create an outcome.

Requires ANY permissions: 

* journey:outcome:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostJourneyOutcomesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var body = new OutcomeRequest(); // OutcomeRequest |  (optional) 

            try
            { 
                // Create an outcome.
                Outcome result = apiInstance.PostJourneyOutcomes(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.PostJourneyOutcomes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OutcomeRequest**](OutcomeRequest)|  | [optional]  |

### Return type

[**Outcome**](Outcome)


## PostJourneyOutcomesAttributionsJobs

> [**OutcomeAttributionAsyncResponse**](OutcomeAttributionAsyncResponse) PostJourneyOutcomesAttributionsJobs (OutcomeAttributionListing body = null)


Create Outcome Attributions

PostJourneyOutcomesAttributionsJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* journey:outcomeAttributionJob:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostJourneyOutcomesAttributionsJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var body = new OutcomeAttributionListing(); // OutcomeAttributionListing | outcome attribution request (optional) 

            try
            { 
                // Create Outcome Attributions
                OutcomeAttributionAsyncResponse result = apiInstance.PostJourneyOutcomesAttributionsJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.PostJourneyOutcomesAttributionsJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OutcomeAttributionListing**](OutcomeAttributionListing)| outcome attribution request | [optional]  |

### Return type

[**OutcomeAttributionAsyncResponse**](OutcomeAttributionAsyncResponse)


## PostJourneyOutcomesPredictors

> [**OutcomePredictor**](OutcomePredictor) PostJourneyOutcomesPredictors (OutcomePredictorRequest body = null)


Create an outcome predictor.

Requires ANY permissions: 

* journey:outcomepredictor:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostJourneyOutcomesPredictorsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var body = new OutcomePredictorRequest(); // OutcomePredictorRequest |  (optional) 

            try
            { 
                // Create an outcome predictor.
                OutcomePredictor result = apiInstance.PostJourneyOutcomesPredictors(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.PostJourneyOutcomesPredictors: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OutcomePredictorRequest**](OutcomePredictorRequest)|  | [optional]  |

### Return type

[**OutcomePredictor**](OutcomePredictor)


## PostJourneySegments

> [**JourneySegment**](JourneySegment) PostJourneySegments (JourneySegmentRequest body = null)


Create a segment.

Requires ANY permissions: 

* journey:segment:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostJourneySegmentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var body = new JourneySegmentRequest(); // JourneySegmentRequest |  (optional) 

            try
            { 
                // Create a segment.
                JourneySegment result = apiInstance.PostJourneySegments(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.PostJourneySegments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**JourneySegmentRequest**](JourneySegmentRequest)|  | [optional]  |

### Return type

[**JourneySegment**](JourneySegment)


## PostJourneyViewVersionJobs

> [**JourneyViewJob**](JourneyViewJob) PostJourneyViewVersionJobs (string viewId, string journeyVersionId)


Submit a job request for a journey view version.

used for long descriptions

Requires ALL permissions: 

* journey:viewsJobs:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostJourneyViewVersionJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var viewId = viewId_example;  // string | Journey View Id
            var journeyVersionId = journeyVersionId_example;  // string | Journey View Version

            try
            { 
                // Submit a job request for a journey view version.
                JourneyViewJob result = apiInstance.PostJourneyViewVersionJobs(viewId, journeyVersionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.PostJourneyViewVersionJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **viewId** | **string**| Journey View Id |  |
| **journeyVersionId** | **string**| Journey View Version |  |

### Return type

[**JourneyViewJob**](JourneyViewJob)


## PostJourneyViewVersions

> [**JourneyView**](JourneyView) PostJourneyViewVersions (string viewId, JourneyView body)


Update a Journey View by ID

creates a new version

Requires ALL permissions: 

* journey:views:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostJourneyViewVersionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var viewId = viewId_example;  // string | viewId
            var body = new JourneyView(); // JourneyView | JourneyView

            try
            { 
                // Update a Journey View by ID
                JourneyView result = apiInstance.PostJourneyViewVersions(viewId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.PostJourneyViewVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **viewId** | **string**| viewId |  |
| **body** | [**JourneyView**](JourneyView)| JourneyView |  |

### Return type

[**JourneyView**](JourneyView)


## PostJourneyViews

> [**JourneyView**](JourneyView) PostJourneyViews (JourneyView body)


Create a new Journey View

Requires ALL permissions: 

* journey:views:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostJourneyViewsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var body = new JourneyView(); // JourneyView | JourneyView

            try
            { 
                // Create a new Journey View
                JourneyView result = apiInstance.PostJourneyViews(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.PostJourneyViews: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**JourneyView**](JourneyView)| JourneyView |  |

### Return type

[**JourneyView**](JourneyView)


## PostJourneyViewsEncodingsValidate

> [**EntityListing**](EntityListing) PostJourneyViewsEncodingsValidate (List<Label> body = null)


Validate whether an encoding exist for a label/value combination.

True indicates a valid encoding

PostJourneyViewsEncodingsValidate is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* journey:viewsEncodings:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostJourneyViewsEncodingsValidateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var body = new List<Label>(); // List<Label> |  (optional) 

            try
            { 
                // Validate whether an encoding exist for a label/value combination.
                EntityListing result = apiInstance.PostJourneyViewsEncodingsValidate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.PostJourneyViewsEncodingsValidate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**List<Label>**](Label)|  | [optional]  |

### Return type

[**EntityListing**](EntityListing)


## PutJourneyViewVersion

> [**JourneyView**](JourneyView) PutJourneyViewVersion (string viewId, string versionId, JourneyView body)


Update a Journey View by ID and version

does not create a new version

Requires ALL permissions: 

* journey:views:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutJourneyViewVersionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new JourneyApi();
            var viewId = viewId_example;  // string | viewId
            var versionId = versionId_example;  // string | versionId
            var body = new JourneyView(); // JourneyView | JourneyView

            try
            { 
                // Update a Journey View by ID and version
                JourneyView result = apiInstance.PutJourneyViewVersion(viewId, versionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.PutJourneyViewVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **viewId** | **string**| viewId |  |
| **versionId** | **string**| versionId |  |
| **body** | [**JourneyView**](JourneyView)| JourneyView |  |

### Return type

[**JourneyView**](JourneyView)


_PureCloudPlatform.Client.V2 218.0.0_
