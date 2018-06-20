---
title: GeolocationApi
---
## PureCloudPlatform.Client.V2.Api.GeolocationApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetGeolocationsSettings**](GeolocationApi.html#getgeolocationssettings) | **GET** /api/v2/geolocations/settings | Get a organization&#39;s GeolocationSettings |
| [**GetUserGeolocation**](GeolocationApi.html#getusergeolocation) | **GET** /api/v2/users/{userId}/geolocations/{clientId} | Get a user&#39;s Geolocation |
| [**PatchGeolocationsSettings**](GeolocationApi.html#patchgeolocationssettings) | **PATCH** /api/v2/geolocations/settings | Patch a organization&#39;s GeolocationSettings |
| [**PatchUserGeolocation**](GeolocationApi.html#patchusergeolocation) | **PATCH** /api/v2/users/{userId}/geolocations/{clientId} | Patch a user&#39;s Geolocation |
{: class="table table-striped"}

<a name="getgeolocationssettings"></a>

## [**GeolocationSettings**](GeolocationSettings.html) GetGeolocationsSettings ()



Get a organization's GeolocationSettings



Requires NO permissions: 


### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGeolocationsSettingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new GeolocationApi();
            

            try
            {
                
                // Get a organization's GeolocationSettings
                
                GeolocationSettings result = apiInstance.GetGeolocationsSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GeolocationApi.GetGeolocationsSettings: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**GeolocationSettings**](GeolocationSettings.html)

<a name="getusergeolocation"></a>

## [**Geolocation**](Geolocation.html) GetUserGeolocation (string userId, string clientId)



Get a user's Geolocation



Requires NO permissions: 


### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUserGeolocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new GeolocationApi();
            
            
            var userId = userId_example;  // string | user Id
            
            
            
            
            var clientId = clientId_example;  // string | client Id
            
            
            

            try
            {
                
                // Get a user's Geolocation
                
                Geolocation result = apiInstance.GetUserGeolocation(userId, clientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GeolocationApi.GetUserGeolocation: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| user Id |  |
| **clientId** | **string**| client Id |  |
{: class="table table-striped"}

### Return type

[**Geolocation**](Geolocation.html)

<a name="patchgeolocationssettings"></a>

## [**GeolocationSettings**](GeolocationSettings.html) PatchGeolocationsSettings (GeolocationSettings body)



Patch a organization's GeolocationSettings



Requires ANY permissions: 

* telephony:plugin:all

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchGeolocationsSettingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new GeolocationApi();
            
            
            
            var body = new GeolocationSettings(); // GeolocationSettings | Geolocation settings
            
            

            try
            {
                
                // Patch a organization's GeolocationSettings
                
                GeolocationSettings result = apiInstance.PatchGeolocationsSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GeolocationApi.PatchGeolocationsSettings: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**GeolocationSettings**](GeolocationSettings.html)| Geolocation settings |  |
{: class="table table-striped"}

### Return type

[**GeolocationSettings**](GeolocationSettings.html)

<a name="patchusergeolocation"></a>

## [**Geolocation**](Geolocation.html) PatchUserGeolocation (string userId, string clientId, Geolocation body)



Patch a user's Geolocation

The geolocation object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the client as the user's primary geolocation source.  Option 2: Provide the 'latitude' and 'longitude' values.  This will enqueue an asynchronous update of the 'city', 'region', and 'country', generating a notification. A subsequent GET operation will include the new values for 'city', 'region' and 'country'.  Option 3:  Provide the 'city', 'region', 'country' values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.

Requires NO permissions: 


### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchUserGeolocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new GeolocationApi();
            
            
            var userId = userId_example;  // string | user Id
            
            
            
            
            var clientId = clientId_example;  // string | client Id
            
            
            
            
            
            var body = new Geolocation(); // Geolocation | Geolocation
            
            

            try
            {
                
                // Patch a user's Geolocation
                
                Geolocation result = apiInstance.PatchUserGeolocation(userId, clientId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GeolocationApi.PatchUserGeolocation: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| user Id |  |
| **clientId** | **string**| client Id |  |
| **body** | [**Geolocation**](Geolocation.html)| Geolocation |  |
{: class="table table-striped"}

### Return type

[**Geolocation**](Geolocation.html)

