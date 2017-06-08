---
title: LocationsApi
---
## PureCloudPlatform.Client.V2.Api.LocationsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetLocation**](LocationsApi.html#getlocation) | **GET** /api/v2/locations/{locationId} | Get Location by ID. |
| [**GetLocations**](LocationsApi.html#getlocations) | **GET** /api/v2/locations | Get a list of all locations. |
| [**GetLocationsSearch**](LocationsApi.html#getlocationssearch) | **GET** /api/v2/locations/search | Search locations using the q64 value returned from a previous search |
| [**PostLocationsSearch**](LocationsApi.html#postlocationssearch) | **POST** /api/v2/locations/search | Search locations |
{: class="table table-striped"}

<a name="getlocation"></a>

## [**LocationDefinition**](LocationDefinition.html) GetLocation (string locationId)

Get Location by ID.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new LocationsApi();
            
            
            var locationId = locationId_example;  // string | Location ID
            
            
            

            try
            {
                
                // Get Location by ID.
                
                LocationDefinition result = apiInstance.GetLocation(locationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationsApi.GetLocation: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **locationId** | **string**| Location ID |  |
{: class="table table-striped"}

### Return type

[**LocationDefinition**](LocationDefinition.html)

<a name="getlocations"></a>

## [**LocationEntityListing**](LocationEntityListing.html) GetLocations (int? pageSize = null, int? pageNumber = null, string sortOrder = null)

Get a list of all locations.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLocationsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new LocationsApi();
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var sortOrder = sortOrder_example;  // string | Sort order (optional) 
            
            
            

            try
            {
                
                // Get a list of all locations.
                
                LocationEntityListing result = apiInstance.GetLocations(pageSize, pageNumber, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationsApi.GetLocations: " + e.Message );
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
| **sortOrder** | **string**| Sort order | [optional] <br />**Values**: asc, desc |
{: class="table table-striped"}

### Return type

[**LocationEntityListing**](LocationEntityListing.html)

<a name="getlocationssearch"></a>

## [**LocationsSearchResponse**](LocationsSearchResponse.html) GetLocationsSearch (string q64, List<string> expand = null)

Search locations using the q64 value returned from a previous search



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetLocationsSearchExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new LocationsApi();
            
            
            var q64 = q64_example;  // string | q64
            
            
            
            
            
            var expand = new List<string>(); // List<string> | expand (optional) 
            
            

            try
            {
                
                // Search locations using the q64 value returned from a previous search
                
                LocationsSearchResponse result = apiInstance.GetLocationsSearch(q64, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationsApi.GetLocationsSearch: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **q64** | **string**| q64 |  |
| **expand** | [**List<string>**](string.html)| expand | [optional]  |
{: class="table table-striped"}

### Return type

[**LocationsSearchResponse**](LocationsSearchResponse.html)

<a name="postlocationssearch"></a>

## [**LocationsSearchResponse**](LocationsSearchResponse.html) PostLocationsSearch (LocationSearchRequest body)

Search locations



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostLocationsSearchExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new LocationsApi();
            
            
            
            var body = new LocationSearchRequest(); // LocationSearchRequest | Search request options
            
            

            try
            {
                
                // Search locations
                
                LocationsSearchResponse result = apiInstance.PostLocationsSearch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationsApi.PostLocationsSearch: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**LocationSearchRequest**](LocationSearchRequest.html)| Search request options |  |
{: class="table table-striped"}

### Return type

[**LocationsSearchResponse**](LocationsSearchResponse.html)

