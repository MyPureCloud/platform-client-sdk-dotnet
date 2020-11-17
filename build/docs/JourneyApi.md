---
title: JourneyApi
---
## PureCloudPlatform.Client.V2.Api.JourneyApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetJourneyActiontarget**](JourneyApi.html#getjourneyactiontarget) | **GET** /api/v2/journey/actiontargets/{actionTargetId} | Retrieve a single action target. |
| [**GetJourneyActiontargets**](JourneyApi.html#getjourneyactiontargets) | **GET** /api/v2/journey/actiontargets | Retrieve all action targets. |
| [**PatchJourneyActiontarget**](JourneyApi.html#patchjourneyactiontarget) | **PATCH** /api/v2/journey/actiontargets/{actionTargetId} | Update a single action target. |
| [**PostAnalyticsJourneysAggregatesQuery**](JourneyApi.html#postanalyticsjourneysaggregatesquery) | **POST** /api/v2/analytics/journeys/aggregates/query | Query for journey aggregates |
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

