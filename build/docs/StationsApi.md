# StationsApi

## PureCloudPlatform.Client.V2.Api.StationsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteStationAssociateduser**](#DeleteStationAssociateduser) | **Delete** /api/v2/stations/{stationId}/associateduser | Unassigns the user assigned to this station |
| [**GetStation**](#GetStation) | **Get** /api/v2/stations/{stationId} | Get station. |
| [**GetStations**](#GetStations) | **Get** /api/v2/stations | Get the list of available stations. |



## DeleteStationAssociateduser

> void DeleteStationAssociateduser (string stationId)


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

### Return type

void (empty response body)


## GetStation

> [**Station**](Station) GetStation (string stationId)


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

### Return type

[**Station**](Station)


## GetStations

> [**StationEntityListing**](StationEntityListing) GetStations (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, string userSelectable = null, string webRtcUserId = null, string id = null, string lineAppearanceId = null)


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
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to "name")
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
| **sortBy** | **string**| Sort by | [optional] [default to "name"] |
| **name** | **string**| Name | [optional]  |
| **userSelectable** | **string**| True for stations that the user can select otherwise false | [optional]  |
| **webRtcUserId** | **string**| Filter for the webRtc station of the webRtcUserId | [optional]  |
| **id** | **string**| Comma separated list of stationIds | [optional]  |
| **lineAppearanceId** | **string**| lineAppearanceId | [optional]  |

### Return type

[**StationEntityListing**](StationEntityListing)


_PureCloudPlatform.Client.V2 231.1.0_
