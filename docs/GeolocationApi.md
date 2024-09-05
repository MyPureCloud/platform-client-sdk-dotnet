# GeolocationApi

## PureCloudPlatform.Client.V2.Api.GeolocationApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetGeolocationsSettings**](#GetGeolocationsSettings) | **Get** /api/v2/geolocations/settings | Get a organization&#39;s GeolocationSettings |
| [**GetUserGeolocation**](#GetUserGeolocation) | **Get** /api/v2/users/{userId}/geolocations/{clientId} | Get a user&#39;s Geolocation |
| [**PatchGeolocationsSettings**](#PatchGeolocationsSettings) | **Patch** /api/v2/geolocations/settings | Patch a organization&#39;s GeolocationSettings |
| [**PatchUserGeolocation**](#PatchUserGeolocation) | **Patch** /api/v2/users/{userId}/geolocations/{clientId} | Patch a user&#39;s Geolocation |
{: class="table table-striped"}


## GetGeolocationsSettings

> [**GeolocationSettings**](GeolocationSettings) GetGeolocationsSettings ()



Get a organization's GeolocationSettings

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
    public class GetGeolocationsSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters
This endpoint does require any parameters.


### Return type

[**GeolocationSettings**](GeolocationSettings)


## GetUserGeolocation

> [**Geolocation**](Geolocation) GetUserGeolocation (string userId, string clientId)



Get a user's Geolocation

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
    public class GetUserGeolocationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| user Id |  |
| **clientId** | **string**| client Id |  |
{: class="table table-striped"}

### Return type

[**Geolocation**](Geolocation)


## PatchGeolocationsSettings

> [**GeolocationSettings**](GeolocationSettings) PatchGeolocationsSettings (GeolocationSettings body)



Patch a organization's GeolocationSettings

Requires ANY permissions: 

* geolocation:settings:edit

### Example
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**GeolocationSettings**](GeolocationSettings)| Geolocation settings |  |
{: class="table table-striped"}

### Return type

[**GeolocationSettings**](GeolocationSettings)


## PatchUserGeolocation

> [**Geolocation**](Geolocation) PatchUserGeolocation (string userId, string clientId, Geolocation body)



Patch a user's Geolocation

The geolocation object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the client as the user's primary geolocation source.  Option 2: Provide the 'latitude' and 'longitude' values.  This will enqueue an asynchronous update of the 'city', 'region', and 'country', generating a notification. A subsequent GET operation will include the new values for 'city', 'region' and 'country'.  Option 3:  Provide the 'city', 'region', 'country' values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.

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
    public class PatchUserGeolocationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| user Id |  |
| **clientId** | **string**| client Id |  |
| **body** | [**Geolocation**](Geolocation)| Geolocation |  |
{: class="table table-striped"}

### Return type

[**Geolocation**](Geolocation)


_PureCloudPlatform.Client.V2 214.0.0_
