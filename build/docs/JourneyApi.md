---
title: JourneyApi
---
## PureCloudPlatform.Client.V2.Api.JourneyApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetJourneySessionEvents**](JourneyApi.html#getjourneysessionevents) | **GET** /api/v2/journey/sessions/{sessionId}/events | Retrieve all events for a given session. |
{: class="table table-striped"}

<a name="getjourneysessionevents"></a>

## [**EventListing**](EventListing.html) GetJourneySessionEvents (string sessionId, string before = null, string after = null, string limit = null)



Retrieve all events for a given session.



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
    public class GetJourneySessionEventsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JourneyApi();
            var sessionId = sessionId_example;  // string | System-generated UUID that represents the session the event is a part of.
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var limit = limit_example;  // string | Number of entities to return. Maximum of 200. (optional) 

            try
            { 
                // Retrieve all events for a given session.
                EventListing result = apiInstance.GetJourneySessionEvents(sessionId, before, after, limit);
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
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **limit** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
{: class="table table-striped"}

### Return type

[**EventListing**](EventListing.html)

