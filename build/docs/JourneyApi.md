---
title: JourneyApi
---
## PureCloudPlatform.Client.V2.Api.JourneyApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetJourneyActiontarget**](JourneyApi.html#getjourneyactiontarget) | **GET** /api/v2/journey/actiontargets/{actionTargetId} | Retrieve a single action target. |
| [**GetJourneyActiontargets**](JourneyApi.html#getjourneyactiontargets) | **GET** /api/v2/journey/actiontargets | Retrieve all action targets. |
| [**GetJourneyCustomerCustomerIdSegments**](JourneyApi.html#getjourneycustomercustomeridsegments) | **GET** /api/v2/journey/customers/{customerIdType}/{customerId}/segments | Retrieve segment assignments by customer ID. |
| [**GetJourneyExternalcontactSegments**](JourneyApi.html#getjourneyexternalcontactsegments) | **GET** /api/v2/journey/externalcontacts/{externalContactId}/segments | Retrieve segment assignments by external contact ID. |
| [**GetJourneySessionSegments**](JourneyApi.html#getjourneysessionsegments) | **GET** /api/v2/journey/sessions/{sessionId}/segments | Retrieve segment assignments by session ID. |
| [**PatchJourneyActiontarget**](JourneyApi.html#patchjourneyactiontarget) | **PATCH** /api/v2/journey/actiontargets/{actionTargetId} | Update a single action target. |
| [**PostAnalyticsJourneysAggregatesQuery**](JourneyApi.html#postanalyticsjourneysaggregatesquery) | **POST** /api/v2/analytics/journeys/aggregates/query | Query for journey aggregates |
| [**PostJourneyExternalcontactSegments**](JourneyApi.html#postjourneyexternalcontactsegments) | **POST** /api/v2/journey/externalcontacts/{externalContactId}/segments | Assign/Unassign a segment to/from an external contact or, if a segment is already assigned, update the expiry date of the segment assignment. |
{: class="table table-striped"}

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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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

<a name="getjourneycustomercustomeridsegments"></a>

## [**SegmentAssignmentListing**](SegmentAssignmentListing.html) GetJourneyCustomerCustomerIdSegments (string customerIdType, string customerId, string pageSize = null, string after = null, string segmentScope = null, string assignmentState = null)



Retrieve segment assignments by customer ID.



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
    public class GetJourneyCustomerCustomerIdSegmentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JourneyApi();
            var customerIdType = customerIdType_example;  // string | Type of ID used to identify customer (e.g. email, cookie, and phone).
            var customerId = customerId_example;  // string | Primary identifier of the customer to query for segment assignments.
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var segmentScope = segmentScope_example;  // string | Scope to filter on. If not specified, both session-scoped and customer-scoped assignments are returned. (optional) 
            var assignmentState = assignmentState_example;  // string | Assignment state to filter on. If not specified, both assigned and unassigned assignments are returned. (optional) 

            try
            { 
                // Retrieve segment assignments by customer ID.
                SegmentAssignmentListing result = apiInstance.GetJourneyCustomerCustomerIdSegments(customerIdType, customerId, pageSize, after, segmentScope, assignmentState);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneyCustomerCustomerIdSegments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **customerIdType** | **string**| Type of ID used to identify customer (e.g. email, cookie, and phone). |  |
| **customerId** | **string**| Primary identifier of the customer to query for segment assignments. |  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **segmentScope** | **string**| Scope to filter on. If not specified, both session-scoped and customer-scoped assignments are returned. | [optional] <br />**Values**: Session, Customer |
| **assignmentState** | **string**| Assignment state to filter on. If not specified, both assigned and unassigned assignments are returned. | [optional] <br />**Values**: Assigned, Unassigned |
{: class="table table-striped"}

### Return type

[**SegmentAssignmentListing**](SegmentAssignmentListing.html)

<a name="getjourneyexternalcontactsegments"></a>

## [**SegmentAssignmentListing**](SegmentAssignmentListing.html) GetJourneyExternalcontactSegments (string externalContactId, string pageSize = null, string after = null, string segmentScope = null, string assignmentState = null)



Retrieve segment assignments by external contact ID.



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
    public class GetJourneyExternalcontactSegmentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JourneyApi();
            var externalContactId = externalContactId_example;  // string | ID of the external contact to query for segment assignments.
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var segmentScope = segmentScope_example;  // string | Scope to filter on. If not specified, both session-scoped and customer-scoped assignments are returned. (optional) 
            var assignmentState = assignmentState_example;  // string | Assignment state to filter on. If not specified, both assigned and unassigned assignments are returned. (optional) 

            try
            { 
                // Retrieve segment assignments by external contact ID.
                SegmentAssignmentListing result = apiInstance.GetJourneyExternalcontactSegments(externalContactId, pageSize, after, segmentScope, assignmentState);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.GetJourneyExternalcontactSegments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **externalContactId** | **string**| ID of the external contact to query for segment assignments. |  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **segmentScope** | **string**| Scope to filter on. If not specified, both session-scoped and customer-scoped assignments are returned. | [optional] <br />**Values**: Session, Customer |
| **assignmentState** | **string**| Assignment state to filter on. If not specified, both assigned and unassigned assignments are returned. | [optional] <br />**Values**: Assigned, Unassigned |
{: class="table table-striped"}

### Return type

[**SegmentAssignmentListing**](SegmentAssignmentListing.html)

<a name="getjourneysessionsegments"></a>

## [**SegmentAssignmentListing**](SegmentAssignmentListing.html) GetJourneySessionSegments (string sessionId, string pageSize = null, string after = null, string segmentScope = null, string assignmentState = null)



Retrieve segment assignments by session ID.



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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

<a name="postjourneyexternalcontactsegments"></a>

## void PostJourneyExternalcontactSegments (string externalContactId, List<SegmentAssignmentsUpdate> body = null)



Assign/Unassign a segment to/from an external contact or, if a segment is already assigned, update the expiry date of the segment assignment.



Requires ANY permissions: 

* journey:segmentassignment:add
* journey:segmentassignment:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostJourneyExternalcontactSegmentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JourneyApi();
            var externalContactId = externalContactId_example;  // string | ID of the external contact to query for segment assignments.
            var body = new List<SegmentAssignmentsUpdate>(); // List<SegmentAssignmentsUpdate> |  (optional) 

            try
            { 
                // Assign/Unassign a segment to/from an external contact or, if a segment is already assigned, update the expiry date of the segment assignment.
                apiInstance.PostJourneyExternalcontactSegments(externalContactId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.PostJourneyExternalcontactSegments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **externalContactId** | **string**| ID of the external contact to query for segment assignments. |  |
| **body** | [**List<SegmentAssignmentsUpdate>**](SegmentAssignmentsUpdate.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

