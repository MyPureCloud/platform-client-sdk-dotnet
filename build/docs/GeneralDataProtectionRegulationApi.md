# GeneralDataProtectionRegulationApi

## PureCloudPlatform.Client.V2.Api.GeneralDataProtectionRegulationApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetGdprRequest**](#GetGdprRequest) | **Get** /api/v2/gdpr/requests/{requestId} | Get an existing GDPR request |
| [**GetGdprRequests**](#GetGdprRequests) | **Get** /api/v2/gdpr/requests | Get all GDPR requests |
| [**GetGdprSubjects**](#GetGdprSubjects) | **Get** /api/v2/gdpr/subjects | Get GDPR subjects |
| [**PostGdprRequests**](#PostGdprRequests) | **Post** /api/v2/gdpr/requests | Submit a new GDPR request |



## GetGdprRequest

> [**GDPRRequest**](GDPRRequest) GetGdprRequest (string requestId)


Get an existing GDPR request

Requires ANY permissions: 

* gdpr:request:view

### Example
```{"language":"csharp"}
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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **requestId** | **string**| Request id |  |

### Return type

[**GDPRRequest**](GDPRRequest)


## GetGdprRequests

> [**GDPRRequestEntityListing**](GDPRRequestEntityListing) GetGdprRequests (int? pageSize = null, int? pageNumber = null)


Get all GDPR requests

Requires ANY permissions: 

* gdpr:request:view

### Example
```{"language":"csharp"}
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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |

### Return type

[**GDPRRequestEntityListing**](GDPRRequestEntityListing)


## GetGdprSubjects

> [**GDPRSubjectEntityListing**](GDPRSubjectEntityListing) GetGdprSubjects (string searchType, string searchValue)


Get GDPR subjects

Requires ANY permissions: 

* gdpr:subject:view

### Example
```{"language":"csharp"}
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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **searchType** | **string**| Search Type | <br />**Values**: NAME, ADDRESS, PHONE, EMAIL, TWITTER, INSTAGRAM, FACEBOOK |
| **searchValue** | **string**| Search Value |  |

### Return type

[**GDPRSubjectEntityListing**](GDPRSubjectEntityListing)


## PostGdprRequests

> [**GDPRRequest**](GDPRRequest) PostGdprRequests (GDPRRequest body, bool? deleteConfirmed = null)


Submit a new GDPR request

Requires ANY permissions: 

* gdpr:request:add

### Example
```{"language":"csharp"}
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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**GDPRRequest**](GDPRRequest)| GDPR request |  |
| **deleteConfirmed** | **bool?**| Confirm delete | [optional] [default to false] |

### Return type

[**GDPRRequest**](GDPRRequest)


_PureCloudPlatform.Client.V2 234.0.0_
