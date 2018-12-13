---
title: GeneralDataProtectionRegulationApi
---
## PureCloudPlatform.Client.V2.Api.GeneralDataProtectionRegulationApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetGdprRequest**](GeneralDataProtectionRegulationApi.html#getgdprrequest) | **GET** /api/v2/gdpr/requests/{requestId} | Get an existing GDPR request |
| [**GetGdprRequests**](GeneralDataProtectionRegulationApi.html#getgdprrequests) | **GET** /api/v2/gdpr/requests | Get all GDPR requests |
| [**GetGdprSubjects**](GeneralDataProtectionRegulationApi.html#getgdprsubjects) | **GET** /api/v2/gdpr/subjects | Get GDPR subjects |
| [**PostGdprRequests**](GeneralDataProtectionRegulationApi.html#postgdprrequests) | **POST** /api/v2/gdpr/requests | Submit a new GDPR request |
{: class="table table-striped"}

<a name="getgdprrequest"></a>

## [**GDPRRequest**](GDPRRequest.html) GetGdprRequest (string requestId)



Get an existing GDPR request



Requires ANY permissions: 

* gdpr:request:view

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGdprRequestExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new GeneralDataProtectionRegulationApi();
            
            
            var requestId = requestId_example;  // string | Request id
            
            
            

            try
            {
                
                // Get an existing GDPR request
                
                GDPRRequest result = apiInstance.GetGdprRequest(requestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GeneralDataProtectionRegulationApi.GetGdprRequest: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **requestId** | **string**| Request id |  |
{: class="table table-striped"}

### Return type

[**GDPRRequest**](GDPRRequest.html)

<a name="getgdprrequests"></a>

## [**GDPRRequestEntityListing**](GDPRRequestEntityListing.html) GetGdprRequests (int? pageSize = null, int? pageNumber = null)



Get all GDPR requests



Requires ANY permissions: 

* gdpr:request:view

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGdprRequestsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new GeneralDataProtectionRegulationApi();
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            

            try
            {
                
                // Get all GDPR requests
                
                GDPRRequestEntityListing result = apiInstance.GetGdprRequests(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GeneralDataProtectionRegulationApi.GetGdprRequests: " + e.Message );
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
{: class="table table-striped"}

### Return type

[**GDPRRequestEntityListing**](GDPRRequestEntityListing.html)

<a name="getgdprsubjects"></a>

## [**GDPRSubjectEntityListing**](GDPRSubjectEntityListing.html) GetGdprSubjects (string searchType, string searchValue)



Get GDPR subjects



Requires ANY permissions: 

* gdpr:subject:view

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGdprSubjectsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new GeneralDataProtectionRegulationApi();
            
            
            var searchType = searchType_example;  // string | Search Type
            
            
            
            
            var searchValue = searchValue_example;  // string | Search Value
            
            
            

            try
            {
                
                // Get GDPR subjects
                
                GDPRSubjectEntityListing result = apiInstance.GetGdprSubjects(searchType, searchValue);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GeneralDataProtectionRegulationApi.GetGdprSubjects: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **searchType** | **string**| Search Type | <br />**Values**: NAME, ADDRESS, PHONE, EMAIL |
| **searchValue** | **string**| Search Value |  |
{: class="table table-striped"}

### Return type

[**GDPRSubjectEntityListing**](GDPRSubjectEntityListing.html)

<a name="postgdprrequests"></a>

## [**GDPRRequest**](GDPRRequest.html) PostGdprRequests (GDPRRequest body, bool? deleteConfirmed = null)



Submit a new GDPR request



Requires ANY permissions: 

* gdpr:request:add

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostGdprRequestsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new GeneralDataProtectionRegulationApi();
            
            
            
            var body = new GDPRRequest(); // GDPRRequest | GDPR request
            
            
            
            var deleteConfirmed = true;  // bool? | Confirm delete (optional)  (default to false)
            
            
            

            try
            {
                
                // Submit a new GDPR request
                
                GDPRRequest result = apiInstance.PostGdprRequests(body, deleteConfirmed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GeneralDataProtectionRegulationApi.PostGdprRequests: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**GDPRRequest**](GDPRRequest.html)| GDPR request |  |
| **deleteConfirmed** | **bool?**| Confirm delete | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**GDPRRequest**](GDPRRequest.html)

