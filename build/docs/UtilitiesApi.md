---
title: UtilitiesApi
---
## PureCloudPlatform.Client.V2.Api.UtilitiesApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetDate**](UtilitiesApi.html#getdate) | **GET** /api/v2/date | Get the current system date/time |
| [**GetTimezones**](UtilitiesApi.html#gettimezones) | **GET** /api/v2/timezones | Get time zones list |
| [**PostCertificateDetails**](UtilitiesApi.html#postcertificatedetails) | **POST** /api/v2/certificate/details | Returns the information about an X509 PEM encoded certificate or certificate chain. |
{: class="table table-striped"}

<a name="getdate"></a>

## [**ServerDate**](ServerDate.html) GetDate ()

Get the current system date/time



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetDateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UtilitiesApi();

            try
            {
                // Get the current system date/time
                ServerDate result = apiInstance.GetDate();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilitiesApi.GetDate: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**ServerDate**](ServerDate.html)

<a name="gettimezones"></a>

## [**TimeZoneEntityListing**](TimeZoneEntityListing.html) GetTimezones (int? pageSize = null, int? pageNumber = null)

Get time zones list



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTimezonesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UtilitiesApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get time zones list
                TimeZoneEntityListing result = apiInstance.GetTimezones(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilitiesApi.GetTimezones: " + e.Message );
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

[**TimeZoneEntityListing**](TimeZoneEntityListing.html)

<a name="postcertificatedetails"></a>

## [**ParsedCertificate**](ParsedCertificate.html) PostCertificateDetails (Certificate body)

Returns the information about an X509 PEM encoded certificate or certificate chain.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostCertificateDetailsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UtilitiesApi();
            var body = new Certificate(); // Certificate | Certificate

            try
            {
                // Returns the information about an X509 PEM encoded certificate or certificate chain.
                ParsedCertificate result = apiInstance.PostCertificateDetails(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilitiesApi.PostCertificateDetails: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Certificate**](Certificate.html)| Certificate |  |
{: class="table table-striped"}

### Return type

[**ParsedCertificate**](ParsedCertificate.html)

