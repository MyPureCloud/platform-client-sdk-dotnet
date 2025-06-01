# LocationsApi

## PureCloudPlatform.Client.V2.Api.LocationsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteLocation**](#DeleteLocation) | **Delete** /api/v2/locations/{locationId} | Delete a location |
| [**GetLocation**](#GetLocation) | **Get** /api/v2/locations/{locationId} | Get Location by ID. |
| [**GetLocationSublocations**](#GetLocationSublocations) | **Get** /api/v2/locations/{locationId}/sublocations | Get sublocations for location ID. |
| [**GetLocations**](#GetLocations) | **Get** /api/v2/locations | Get a list of all locations. |
| [**GetLocationsSearch**](#GetLocationsSearch) | **Get** /api/v2/locations/search | Search locations using the q64 value returned from a previous search |
| [**PatchLocation**](#PatchLocation) | **Patch** /api/v2/locations/{locationId} | Update a location |
| [**PostLocations**](#PostLocations) | **Post** /api/v2/locations | Create a location |
| [**PostLocationsSearch**](#PostLocationsSearch) | **Post** /api/v2/locations/search | Search locations |



## DeleteLocation

> void DeleteLocation (string locationId)


Delete a location

Requires ALL permissions: 

* directory:location:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteLocationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LocationsApi();
            var locationId = locationId_example;  // string | Location ID

            try
            { 
                // Delete a location
                apiInstance.DeleteLocation(locationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationsApi.DeleteLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **locationId** | **string**| Location ID |  |

### Return type

void (empty response body)


## GetLocation

> [**LocationDefinition**](LocationDefinition) GetLocation (string locationId, List<string> expand = null)


Get Location by ID.

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
    public class GetLocationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LocationsApi();
            var locationId = locationId_example;  // string | Location ID
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            { 
                // Get Location by ID.
                LocationDefinition result = apiInstance.GetLocation(locationId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationsApi.GetLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **locationId** | **string**| Location ID |  |
| **expand** | [**List<string>**](string)| Which fields, if any, to expand | [optional] <br />**Values**: images, addressVerificationDetails |

### Return type

[**LocationDefinition**](LocationDefinition)


## GetLocationSublocations

> [**LocationEntityListing**](LocationEntityListing) GetLocationSublocations (string locationId)


Get sublocations for location ID.

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
    public class GetLocationSublocationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LocationsApi();
            var locationId = locationId_example;  // string | Location ID

            try
            { 
                // Get sublocations for location ID.
                LocationEntityListing result = apiInstance.GetLocationSublocations(locationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationsApi.GetLocationSublocations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **locationId** | **string**| Location ID |  |

### Return type

[**LocationEntityListing**](LocationEntityListing)


## GetLocations

> [**LocationEntityListing**](LocationEntityListing) GetLocations (int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortOrder = null)


Get a list of all locations.

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
    public class GetLocationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LocationsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var id = new List<string>(); // List<string> | id (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional) 

            try
            { 
                // Get a list of all locations.
                LocationEntityListing result = apiInstance.GetLocations(pageSize, pageNumber, id, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationsApi.GetLocations: " + e.Message );
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
| **id** | [**List<string>**](string)| id | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] <br />**Values**: asc, desc |

### Return type

[**LocationEntityListing**](LocationEntityListing)


## GetLocationsSearch

> [**LocationsSearchResponse**](LocationsSearchResponse) GetLocationsSearch (string q64, List<string> expand = null)


Search locations using the q64 value returned from a previous search

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
    public class GetLocationsSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LocationsApi();
            var q64 = q64_example;  // string | q64
            var expand = new List<string>(); // List<string> | Provides more details about a specified resource (optional) 

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **q64** | **string**| q64 |  |
| **expand** | [**List<string>**](string)| Provides more details about a specified resource | [optional] <br />**Values**: images, addressVerificationDetails |

### Return type

[**LocationsSearchResponse**](LocationsSearchResponse)


## PatchLocation

> [**LocationDefinition**](LocationDefinition) PatchLocation (string locationId, LocationUpdateDefinition body)


Update a location

Requires ALL permissions: 

* directory:location:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchLocationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LocationsApi();
            var locationId = locationId_example;  // string | Location ID
            var body = new LocationUpdateDefinition(); // LocationUpdateDefinition | Location

            try
            { 
                // Update a location
                LocationDefinition result = apiInstance.PatchLocation(locationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationsApi.PatchLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **locationId** | **string**| Location ID |  |
| **body** | [**LocationUpdateDefinition**](LocationUpdateDefinition)| Location |  |

### Return type

[**LocationDefinition**](LocationDefinition)


## PostLocations

> [**LocationDefinition**](LocationDefinition) PostLocations (LocationCreateDefinition body)


Create a location

Requires ALL permissions: 

* directory:location:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostLocationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new LocationsApi();
            var body = new LocationCreateDefinition(); // LocationCreateDefinition | Location

            try
            { 
                // Create a location
                LocationDefinition result = apiInstance.PostLocations(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationsApi.PostLocations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**LocationCreateDefinition**](LocationCreateDefinition)| Location |  |

### Return type

[**LocationDefinition**](LocationDefinition)


## PostLocationsSearch

> [**LocationsSearchResponse**](LocationsSearchResponse) PostLocationsSearch (LocationSearchRequest body)


Search locations

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
    public class PostLocationsSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**LocationSearchRequest**](LocationSearchRequest)| Search request options |  |

### Return type

[**LocationsSearchResponse**](LocationsSearchResponse)


_PureCloudPlatform.Client.V2 235.0.0_
