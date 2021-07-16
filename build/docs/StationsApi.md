---
title: StationsApi
---
## PureCloudPlatform.Client.V2.Api.StationsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteStationAssociateduser**](StationsApi.html#deletestationassociateduser) | **DELETE** /api/v2/stations/{stationId}/associateduser | Unassigns the user assigned to this station |
| [**GetStation**](StationsApi.html#getstation) | **GET** /api/v2/stations/{stationId} | Get station. |
| [**GetStations**](StationsApi.html#getstations) | **GET** /api/v2/stations | Get the list of available stations. |
| [**GetStationsSettings**](StationsApi.html#getstationssettings) | **GET** /api/v2/stations/settings | Get an organization&#39;s StationSettings |
| [**PatchStationsSettings**](StationsApi.html#patchstationssettings) | **PATCH** /api/v2/stations/settings | Patch an organization&#39;s StationSettings |
{: class="table table-striped"}

<a name="deletestationassociateduser"></a>

## void DeleteStationAssociateduser (string stationId)



Unassigns the user assigned to this station



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
    public class DeleteStationAssociateduserExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new StationsApi();
            var stationId = stationId_example;  // string | Station ID

            try
            { 
                // Unassigns the user assigned to this station
                apiInstance.DeleteStationAssociateduser(stationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationsApi.DeleteStationAssociateduser: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **stationId** | **string**| Station ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getstation"></a>

## [**Station**](Station.html) GetStation (string stationId)



Get station.



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
    public class GetStationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new StationsApi();
            var stationId = stationId_example;  // string | Station ID

            try
            { 
                // Get station.
                Station result = apiInstance.GetStation(stationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationsApi.GetStation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **stationId** | **string**| Station ID |  |
{: class="table table-striped"}

### Return type

[**Station**](Station.html)

<a name="getstations"></a>

## [**StationEntityListing**](StationEntityListing.html) GetStations (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, string userSelectable = null, string webRtcUserId = null, string id = null, string lineAppearanceId = null)



Get the list of available stations.



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
    public class GetStationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new StationsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)
            var name = name_example;  // string | Name (optional) 
            var userSelectable = userSelectable_example;  // string | True for stations that the user can select otherwise false (optional) 
            var webRtcUserId = webRtcUserId_example;  // string | Filter for the webRtc station of the webRtcUserId (optional) 
            var id = id_example;  // string | Comma separated list of stationIds (optional) 
            var lineAppearanceId = lineAppearanceId_example;  // string | lineAppearanceId (optional) 

            try
            { 
                // Get the list of available stations.
                StationEntityListing result = apiInstance.GetStations(pageSize, pageNumber, sortBy, name, userSelectable, webRtcUserId, id, lineAppearanceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationsApi.GetStations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional] [default to name] |
| **name** | **string**| Name | [optional]  |
| **userSelectable** | **string**| True for stations that the user can select otherwise false | [optional]  |
| **webRtcUserId** | **string**| Filter for the webRtc station of the webRtcUserId | [optional]  |
| **id** | **string**| Comma separated list of stationIds | [optional]  |
| **lineAppearanceId** | **string**| lineAppearanceId | [optional]  |
{: class="table table-striped"}

### Return type

[**StationEntityListing**](StationEntityListing.html)

<a name="getstationssettings"></a>

## [**StationSettings**](StationSettings.html) GetStationsSettings ()



Get an organization's StationSettings



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
    public class GetStationsSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new StationsApi();

            try
            { 
                // Get an organization's StationSettings
                StationSettings result = apiInstance.GetStationsSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationsApi.GetStationsSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**StationSettings**](StationSettings.html)

<a name="patchstationssettings"></a>

## [**StationSettings**](StationSettings.html) PatchStationsSettings (StationSettings body)



Patch an organization's StationSettings



Requires ANY permissions: 

* telephony:plugin:all

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchStationsSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new StationsApi();
            var body = new StationSettings(); // StationSettings | Station settings

            try
            { 
                // Patch an organization's StationSettings
                StationSettings result = apiInstance.PatchStationsSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationsApi.PatchStationsSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**StationSettings**](StationSettings.html)| Station settings |  |
{: class="table table-striped"}

### Return type

[**StationSettings**](StationSettings.html)

