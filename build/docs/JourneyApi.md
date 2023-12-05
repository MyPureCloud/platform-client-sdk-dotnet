---
title: JourneyApi
---
## PureCloudPlatform.Client.V2.Api.JourneyApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteJourneyActionmap**](JourneyApi.html#deletejourneyactionmap) | **Delete** /api/v2/journey/actionmaps/{actionMapId} | Delete single action map. |
| [**DeleteJourneyActiontemplate**](JourneyApi.html#deletejourneyactiontemplate) | **Delete** /api/v2/journey/actiontemplates/{actionTemplateId} | Delete a single action template. |
| [**DeleteJourneyOutcome**](JourneyApi.html#deletejourneyoutcome) | **Delete** /api/v2/journey/outcomes/{outcomeId} | Delete an outcome. |
| [**DeleteJourneyOutcomesPredictor**](JourneyApi.html#deletejourneyoutcomespredictor) | **Delete** /api/v2/journey/outcomes/predictors/{predictorId} | Delete an outcome predictor. |
| [**DeleteJourneySegment**](JourneyApi.html#deletejourneysegment) | **Delete** /api/v2/journey/segments/{segmentId} | Delete a segment. |
| [**GetAnalyticsJourneysAggregatesJob**](JourneyApi.html#getanalyticsjourneysaggregatesjob) | **Get** /api/v2/analytics/journeys/aggregates/jobs/{jobId} | Get status for async query for journey aggregates |
| [**GetAnalyticsJourneysAggregatesJobResults**](JourneyApi.html#getanalyticsjourneysaggregatesjobresults) | **Get** /api/v2/analytics/journeys/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetExternalcontactsContactJourneySessions**](JourneyApi.html#getexternalcontactscontactjourneysessions) | **Get** /api/v2/externalcontacts/contacts/{contactId}/journey/sessions | Retrieve all sessions for a given external contact. |
| [**GetJourneyActionmap**](JourneyApi.html#getjourneyactionmap) | **Get** /api/v2/journey/actionmaps/{actionMapId} | Retrieve a single action map. |
| [**GetJourneyActionmaps**](JourneyApi.html#getjourneyactionmaps) | **Get** /api/v2/journey/actionmaps | Retrieve all action maps. |
| [**GetJourneyActionmapsEstimatesJob**](JourneyApi.html#getjourneyactionmapsestimatesjob) | **Get** /api/v2/journey/actionmaps/estimates/jobs/{jobId} | Get status of job. |
| [**GetJourneyActionmapsEstimatesJobResults**](JourneyApi.html#getjourneyactionmapsestimatesjobresults) | **Get** /api/v2/journey/actionmaps/estimates/jobs/{jobId}/results | Get estimates from completed job. |
| [**GetJourneyActiontarget**](JourneyApi.html#getjourneyactiontarget) | **Get** /api/v2/journey/actiontargets/{actionTargetId} | Retrieve a single action target. |
| [**GetJourneyActiontargets**](JourneyApi.html#getjourneyactiontargets) | **Get** /api/v2/journey/actiontargets | Retrieve all action targets. |
| [**GetJourneyActiontemplate**](JourneyApi.html#getjourneyactiontemplate) | **Get** /api/v2/journey/actiontemplates/{actionTemplateId} | Retrieve a single action template. |
| [**GetJourneyActiontemplates**](JourneyApi.html#getjourneyactiontemplates) | **Get** /api/v2/journey/actiontemplates | Retrieve all action templates. |
| [**GetJourneyDeploymentCustomerPing**](JourneyApi.html#getjourneydeploymentcustomerping) | **Get** /api/v2/journey/deployments/{deploymentId}/customers/{customerCookieId}/ping | Send a ping. |
| [**GetJourneyOutcome**](JourneyApi.html#getjourneyoutcome) | **Get** /api/v2/journey/outcomes/{outcomeId} | Retrieve a single outcome. |
| [**GetJourneyOutcomes**](JourneyApi.html#getjourneyoutcomes) | **Get** /api/v2/journey/outcomes | Retrieve all outcomes. |
| [**GetJourneyOutcomesAttributionsJob**](JourneyApi.html#getjourneyoutcomesattributionsjob) | **Get** /api/v2/journey/outcomes/attributions/jobs/{jobId} | Get job status. |
| [**GetJourneyOutcomesAttributionsJobResults**](JourneyApi.html#getjourneyoutcomesattributionsjobresults) | **Get** /api/v2/journey/outcomes/attributions/jobs/{jobId}/results | Get outcome attribution entities from completed job. |
| [**GetJourneyOutcomesPredictor**](JourneyApi.html#getjourneyoutcomespredictor) | **Get** /api/v2/journey/outcomes/predictors/{predictorId} | Retrieve a single outcome predictor. |
| [**GetJourneyOutcomesPredictors**](JourneyApi.html#getjourneyoutcomespredictors) | **Get** /api/v2/journey/outcomes/predictors | Retrieve all outcome predictors. |
| [**GetJourneySegment**](JourneyApi.html#getjourneysegment) | **Get** /api/v2/journey/segments/{segmentId} | Retrieve a single segment. |
| [**GetJourneySegments**](JourneyApi.html#getjourneysegments) | **Get** /api/v2/journey/segments | Retrieve all segments. |
| [**GetJourneySession**](JourneyApi.html#getjourneysession) | **Get** /api/v2/journey/sessions/{sessionId} | Retrieve a single session. |
| [**GetJourneySessionEvents**](JourneyApi.html#getjourneysessionevents) | **Get** /api/v2/journey/sessions/{sessionId}/events | Retrieve all events for a given session. |
| [**GetJourneySessionOutcomescores**](JourneyApi.html#getjourneysessionoutcomescores) | **Get** /api/v2/journey/sessions/{sessionId}/outcomescores | Retrieve latest outcome score associated with a session for all outcomes. |
| [**GetJourneySessionSegments**](JourneyApi.html#getjourneysessionsegments) | **Get** /api/v2/journey/sessions/{sessionId}/segments | Retrieve segment assignments by session ID. |
| [**PatchJourneyActionmap**](JourneyApi.html#patchjourneyactionmap) | **Patch** /api/v2/journey/actionmaps/{actionMapId} | Update single action map. |
| [**PatchJourneyActiontarget**](JourneyApi.html#patchjourneyactiontarget) | **Patch** /api/v2/journey/actiontargets/{actionTargetId} | Update a single action target. |
| [**PatchJourneyActiontemplate**](JourneyApi.html#patchjourneyactiontemplate) | **Patch** /api/v2/journey/actiontemplates/{actionTemplateId} | Update a single action template. |
| [**PatchJourneyOutcome**](JourneyApi.html#patchjourneyoutcome) | **Patch** /api/v2/journey/outcomes/{outcomeId} | Update an outcome. |
| [**PatchJourneySegment**](JourneyApi.html#patchjourneysegment) | **Patch** /api/v2/journey/segments/{segmentId} | Update a segment. |
| [**PostAnalyticsJourneysAggregatesJobs**](JourneyApi.html#postanalyticsjourneysaggregatesjobs) | **Post** /api/v2/analytics/journeys/aggregates/jobs | Query for journey aggregates asynchronously |
| [**PostAnalyticsJourneysAggregatesQuery**](JourneyApi.html#postanalyticsjourneysaggregatesquery) | **Post** /api/v2/analytics/journeys/aggregates/query | Query for journey aggregates |
| [**PostJourneyActionmaps**](JourneyApi.html#postjourneyactionmaps) | **Post** /api/v2/journey/actionmaps | Create an action map. |
| [**PostJourneyActionmapsEstimatesJobs**](JourneyApi.html#postjourneyactionmapsestimatesjobs) | **Post** /api/v2/journey/actionmaps/estimates/jobs | Query for estimates |
| [**PostJourneyActiontemplates**](JourneyApi.html#postjourneyactiontemplates) | **Post** /api/v2/journey/actiontemplates | Create a single action template. |
| [**PostJourneyDeploymentActionevent**](JourneyApi.html#postjourneydeploymentactionevent) | **Post** /api/v2/journey/deployments/{deploymentId}/actionevent | Sends an action event, which is used for changing the state of actions that have been offered to the user. |
| [**PostJourneyDeploymentAppevents**](JourneyApi.html#postjourneydeploymentappevents) | **Post** /api/v2/journey/deployments/{deploymentId}/appevents | Send a journey app event, used for tracking customer activity on an application. |
| [**PostJourneyOutcomes**](JourneyApi.html#postjourneyoutcomes) | **Post** /api/v2/journey/outcomes | Create an outcome. |
| [**PostJourneyOutcomesAttributionsJobs**](JourneyApi.html#postjourneyoutcomesattributionsjobs) | **Post** /api/v2/journey/outcomes/attributions/jobs | Create Outcome Attributions |
| [**PostJourneyOutcomesPredictors**](JourneyApi.html#postjourneyoutcomespredictors) | **Post** /api/v2/journey/outcomes/predictors | Create an outcome predictor. |
| [**PostJourneySegments**](JourneyApi.html#postjourneysegments) | **Post** /api/v2/journey/segments | Create a segment. |
{: class="table table-striped"}

<a name="deletejourneyactionmap"></a>

## void DeleteJourneyActionmap (string actionMapId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletejourneyactiontemplate"></a>

## void DeleteJourneyActiontemplate (string actionTemplateId, bool? hardDelete = null)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletejourneyoutcome"></a>

## void DeleteJourneyOutcome (string outcomeId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletejourneyoutcomespredictor"></a>

## void DeleteJourneyOutcomesPredictor (string predictorId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletejourneysegment"></a>

## void DeleteJourneySegment (string segmentId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getanalyticsjourneysaggregatesjob"></a>

## [**AsyncQueryStatus**](AsyncQueryStatus.html) GetAnalyticsJourneysAggregatesJob (string jobId)



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
{: class="table table-striped"}

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus.html)

<a name="getanalyticsjourneysaggregatesjobresults"></a>

## [**JourneyAsyncAggregateQueryResponse**](JourneyAsyncAggregateQueryResponse.html) GetAnalyticsJourneysAggregatesJobResults (string jobId, string cursor = null)



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
{: class="table table-striped"}

### Return type

[**JourneyAsyncAggregateQueryResponse**](JourneyAsyncAggregateQueryResponse.html)

<a name="getexternalcontactscontactjourneysessions"></a>

## [**SessionListing**](SessionListing.html) GetExternalcontactsContactJourneySessions (string contactId, string pageSize = null, string after = null, bool? includeMerged = null)



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
{: class="table table-striped"}

### Return type

[**SessionListing**](SessionListing.html)

<a name="getjourneyactionmap"></a>

## [**ActionMap**](ActionMap.html) GetJourneyActionmap (string actionMapId)



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
{: class="table table-striped"}

### Return type

[**ActionMap**](ActionMap.html)

<a name="getjourneyactionmaps"></a>

## [**ActionMapListing**](ActionMapListing.html) GetJourneyActionmaps (int? pageNumber = null, int? pageSize = null, string sortBy = null, string filterField = null, string filterValue = null, List<string> actionMapIds = null, List<string> queryFields = null, string queryValue = null)



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
| **actionMapIds** | [**List<string>**](string.html)| IDs of action maps to return. Use of this parameter is not compatible with pagination, filtering, sorting or querying. A maximum of 100 action maps are allowed per request. | [optional]  |
| **queryFields** | [**List<string>**](string.html)| Action Map field(s) to query on. Requires &#39;queryValue&#39; to also be set. | [optional]  |
| **queryValue** | **string**| Value to query on. Requires &#39;queryFields&#39; to also be set. | [optional]  |
{: class="table table-striped"}

### Return type

[**ActionMapListing**](ActionMapListing.html)

<a name="getjourneyactionmapsestimatesjob"></a>

## **string** GetJourneyActionmapsEstimatesJob (string jobId)



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
{: class="table table-striped"}

### Return type

**string**

<a name="getjourneyactionmapsestimatesjobresults"></a>

## [**ActionMapEstimateResult**](ActionMapEstimateResult.html) GetJourneyActionmapsEstimatesJobResults (string jobId)



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
{: class="table table-striped"}

### Return type

[**ActionMapEstimateResult**](ActionMapEstimateResult.html)

<a name="getjourneyactiontarget"></a>

## [**ActionTarget**](ActionTarget.html) GetJourneyActiontarget (string actionTargetId)



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
{: class="table table-striped"}

### Return type

[**ActionTarget**](ActionTarget.html)

<a name="getjourneyactiontargets"></a>

## [**ActionTargetListing**](ActionTargetListing.html) GetJourneyActiontargets (int? pageNumber = null, int? pageSize = null)



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
{: class="table table-striped"}

### Return type

[**ActionTargetListing**](ActionTargetListing.html)

<a name="getjourneyactiontemplate"></a>

## [**ActionTemplate**](ActionTemplate.html) GetJourneyActiontemplate (string actionTemplateId)



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
{: class="table table-striped"}

### Return type

[**ActionTemplate**](ActionTemplate.html)

<a name="getjourneyactiontemplates"></a>

## [**ActionTemplateListing**](ActionTemplateListing.html) GetJourneyActiontemplates (int? pageNumber = null, int? pageSize = null, string sortBy = null, string mediaType = null, string state = null, List<string> queryFields = null, string queryValue = null)



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
| **queryFields** | [**List<string>**](string.html)| ActionTemplate field(s) to query on. Requires &#39;queryValue&#39; to also be set. | [optional]  |
| **queryValue** | **string**| Value to query on. Requires &#39;queryFields&#39; to also be set. | [optional]  |
{: class="table table-striped"}

### Return type

[**ActionTemplateListing**](ActionTemplateListing.html)

<a name="getjourneydeploymentcustomerping"></a>

## [**DeploymentPing**](DeploymentPing.html) GetJourneyDeploymentCustomerPing (string deploymentId, string customerCookieId, string dl = null, string dt = null, string appNamespace = null, string sessionId = null, long? sinceLastBeaconMilliseconds = null)



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
{: class="table table-striped"}

### Return type

[**DeploymentPing**](DeploymentPing.html)

<a name="getjourneyoutcome"></a>

## [**Outcome**](Outcome.html) GetJourneyOutcome (string outcomeId)



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
{: class="table table-striped"}

### Return type

[**Outcome**](Outcome.html)

<a name="getjourneyoutcomes"></a>

## [**OutcomeListing**](OutcomeListing.html) GetJourneyOutcomes (int? pageNumber = null, int? pageSize = null, string sortBy = null, List<string> outcomeIds = null, List<string> queryFields = null, string queryValue = null)



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
| **outcomeIds** | [**List<string>**](string.html)| IDs of outcomes to return. Use of this parameter is not compatible with pagination, sorting or querying. A maximum of 20 outcomes are allowed per request. | [optional]  |
| **queryFields** | [**List<string>**](string.html)| Outcome field(s) to query on. Requires &#39;queryValue&#39; to also be set. | [optional]  |
| **queryValue** | **string**| Value to query on. Requires &#39;queryFields&#39; to also be set. | [optional]  |
{: class="table table-striped"}

### Return type

[**OutcomeListing**](OutcomeListing.html)

<a name="getjourneyoutcomesattributionsjob"></a>

## [**OutcomeAttributionJobStateResponse**](OutcomeAttributionJobStateResponse.html) GetJourneyOutcomesAttributionsJob (string jobId)



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
{: class="table table-striped"}

### Return type

[**OutcomeAttributionJobStateResponse**](OutcomeAttributionJobStateResponse.html)

<a name="getjourneyoutcomesattributionsjobresults"></a>

## [**OutcomeAttributionResponseListing**](OutcomeAttributionResponseListing.html) GetJourneyOutcomesAttributionsJobResults (string jobId)



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
{: class="table table-striped"}

### Return type

[**OutcomeAttributionResponseListing**](OutcomeAttributionResponseListing.html)

<a name="getjourneyoutcomespredictor"></a>

## [**OutcomePredictor**](OutcomePredictor.html) GetJourneyOutcomesPredictor (string predictorId)



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
{: class="table table-striped"}

### Return type

[**OutcomePredictor**](OutcomePredictor.html)

<a name="getjourneyoutcomespredictors"></a>

## [**OutcomePredictorListing**](OutcomePredictorListing.html) GetJourneyOutcomesPredictors ()



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

[**OutcomePredictorListing**](OutcomePredictorListing.html)

<a name="getjourneysegment"></a>

## [**JourneySegment**](JourneySegment.html) GetJourneySegment (string segmentId)



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
{: class="table table-striped"}

### Return type

[**JourneySegment**](JourneySegment.html)

<a name="getjourneysegments"></a>

## [**SegmentListing**](SegmentListing.html) GetJourneySegments (string sortBy = null, int? pageSize = null, int? pageNumber = null, bool? isActive = null, List<string> segmentIds = null, List<string> queryFields = null, string queryValue = null)



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
| **segmentIds** | [**List<string>**](string.html)| IDs of segments to return. Use of this parameter is not compatible with pagination, sorting or querying. A maximum of 100 segments are allowed per request. | [optional]  |
| **queryFields** | [**List<string>**](string.html)| Segment field(s) to query on. Requires &#39;queryValue&#39; to also be set. | [optional]  |
| **queryValue** | **string**| Value to query on. Requires &#39;queryFields&#39; to also be set. | [optional]  |
{: class="table table-striped"}

### Return type

[**SegmentListing**](SegmentListing.html)

<a name="getjourneysession"></a>

## [**Session**](Session.html) GetJourneySession (string sessionId)



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
{: class="table table-striped"}

### Return type

[**Session**](Session.html)

<a name="getjourneysessionevents"></a>

## [**EventListing**](EventListing.html) GetJourneySessionEvents (string sessionId, string pageSize = null, string after = null)



Retrieve all events for a given session.

GetJourneySessionEvents is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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

            try
            { 
                // Retrieve all events for a given session.
                EventListing result = apiInstance.GetJourneySessionEvents(sessionId, pageSize, after);
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
{: class="table table-striped"}

### Return type

[**EventListing**](EventListing.html)

<a name="getjourneysessionoutcomescores"></a>

## [**OutcomeScoresResult**](OutcomeScoresResult.html) GetJourneySessionOutcomescores (string sessionId)



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
{: class="table table-striped"}

### Return type

[**OutcomeScoresResult**](OutcomeScoresResult.html)

<a name="getjourneysessionsegments"></a>

## [**SegmentAssignmentListing**](SegmentAssignmentListing.html) GetJourneySessionSegments (string sessionId, string pageSize = null, string after = null, string segmentScope = null, string assignmentState = null)



Retrieve segment assignments by session ID.

GetJourneySessionSegments is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* journey:segmentassignment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetJourneySessionSegmentsExample
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
            var sessionId = sessionId_example;  // string | ID of the session to query for segment assignments.
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var segmentScope = segmentScope_example;  // string | Scope to filter on. If not specified, both session-scoped and customer-scoped assignments are returned. (optional) 
            var assignmentState = assignmentState_example;  // string | Assignment state to filter on. If not specified, both assigned and unassigned assignments are returned. (optional) 

            try
            { 
                // Retrieve segment assignments by session ID.
                SegmentAssignmentListing result = apiInstance.GetJourneySessionSegments(sessionId, pageSize, after, segmentScope, assignmentState);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneySessionSegments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sessionId** | **string**| ID of the session to query for segment assignments. |  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **segmentScope** | **string**| Scope to filter on. If not specified, both session-scoped and customer-scoped assignments are returned. | [optional] <br />**Values**: Session, Customer |
| **assignmentState** | **string**| Assignment state to filter on. If not specified, both assigned and unassigned assignments are returned. | [optional] <br />**Values**: Assigned, Unassigned |
{: class="table table-striped"}

### Return type

[**SegmentAssignmentListing**](SegmentAssignmentListing.html)

<a name="patchjourneyactionmap"></a>

## [**ActionMap**](ActionMap.html) PatchJourneyActionmap (string actionMapId, PatchActionMap body = null)



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
| **body** | [**PatchActionMap**](PatchActionMap.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**ActionMap**](ActionMap.html)

<a name="patchjourneyactiontarget"></a>

## [**ActionTarget**](ActionTarget.html) PatchJourneyActiontarget (string actionTargetId, PatchActionTarget body = null)



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
| **body** | [**PatchActionTarget**](PatchActionTarget.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**ActionTarget**](ActionTarget.html)

<a name="patchjourneyactiontemplate"></a>

## [**ActionTemplate**](ActionTemplate.html) PatchJourneyActiontemplate (string actionTemplateId, PatchActionTemplate body = null)



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
| **body** | [**PatchActionTemplate**](PatchActionTemplate.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**ActionTemplate**](ActionTemplate.html)

<a name="patchjourneyoutcome"></a>

## [**Outcome**](Outcome.html) PatchJourneyOutcome (string outcomeId, PatchOutcome body = null)



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
| **body** | [**PatchOutcome**](PatchOutcome.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**Outcome**](Outcome.html)

<a name="patchjourneysegment"></a>

## [**JourneySegment**](JourneySegment.html) PatchJourneySegment (string segmentId, PatchSegment body = null)



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
| **body** | [**PatchSegment**](PatchSegment.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**JourneySegment**](JourneySegment.html)

<a name="postanalyticsjourneysaggregatesjobs"></a>

## [**AsyncQueryResponse**](AsyncQueryResponse.html) PostAnalyticsJourneysAggregatesJobs (JourneyAsyncAggregationQuery body)



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
| **body** | [**JourneyAsyncAggregationQuery**](JourneyAsyncAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse.html)

<a name="postanalyticsjourneysaggregatesquery"></a>

## [**JourneyAggregateQueryResponse**](JourneyAggregateQueryResponse.html) PostAnalyticsJourneysAggregatesQuery (JourneyAggregationQuery body)



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
| **body** | [**JourneyAggregationQuery**](JourneyAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**JourneyAggregateQueryResponse**](JourneyAggregateQueryResponse.html)

<a name="postjourneyactionmaps"></a>

## [**ActionMap**](ActionMap.html) PostJourneyActionmaps (ActionMap body = null)



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
| **body** | [**ActionMap**](ActionMap.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**ActionMap**](ActionMap.html)

<a name="postjourneyactionmapsestimatesjobs"></a>

## [**EstimateJobAsyncResponse**](EstimateJobAsyncResponse.html) PostJourneyActionmapsEstimatesJobs (ActionMapEstimateRequest body)



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
| **body** | [**ActionMapEstimateRequest**](ActionMapEstimateRequest.html)| audience estimator request |  |
{: class="table table-striped"}

### Return type

[**EstimateJobAsyncResponse**](EstimateJobAsyncResponse.html)

<a name="postjourneyactiontemplates"></a>

## [**ActionTemplate**](ActionTemplate.html) PostJourneyActiontemplates (ActionTemplate body = null)



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
| **body** | [**ActionTemplate**](ActionTemplate.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**ActionTemplate**](ActionTemplate.html)

<a name="postjourneydeploymentactionevent"></a>

## void PostJourneyDeploymentActionevent (string deploymentId, ActionEventRequest body)



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
| **body** | [**ActionEventRequest**](ActionEventRequest.html)|  |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postjourneydeploymentappevents"></a>

## [**AppEventResponse**](AppEventResponse.html) PostJourneyDeploymentAppevents (string deploymentId, AppEventRequest body = null)



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
| **body** | [**AppEventRequest**](AppEventRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**AppEventResponse**](AppEventResponse.html)

<a name="postjourneyoutcomes"></a>

## [**Outcome**](Outcome.html) PostJourneyOutcomes (Outcome body = null)



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
            var body = new Outcome(); // Outcome |  (optional) 

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
| **body** | [**Outcome**](Outcome.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**Outcome**](Outcome.html)

<a name="postjourneyoutcomesattributionsjobs"></a>

## [**OutcomeAttributionAsyncResponse**](OutcomeAttributionAsyncResponse.html) PostJourneyOutcomesAttributionsJobs (OutcomeAttributionListing body = null)



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
| **body** | [**OutcomeAttributionListing**](OutcomeAttributionListing.html)| outcome attribution request | [optional]  |
{: class="table table-striped"}

### Return type

[**OutcomeAttributionAsyncResponse**](OutcomeAttributionAsyncResponse.html)

<a name="postjourneyoutcomespredictors"></a>

## [**OutcomePredictor**](OutcomePredictor.html) PostJourneyOutcomesPredictors (OutcomePredictorRequest body = null)



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
| **body** | [**OutcomePredictorRequest**](OutcomePredictorRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**OutcomePredictor**](OutcomePredictor.html)

<a name="postjourneysegments"></a>

## [**JourneySegment**](JourneySegment.html) PostJourneySegments (JourneySegment body = null)



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
            var body = new JourneySegment(); // JourneySegment |  (optional) 

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
| **body** | [**JourneySegment**](JourneySegment.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**JourneySegment**](JourneySegment.html)

