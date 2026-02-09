# EmployeeEngagementApi

## PureCloudPlatform.Client.V2.Api.EmployeeEngagementApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteEmployeeengagementCelebration**](#DeleteEmployeeengagementCelebration) | **Delete** /api/v2/employeeengagement/celebrations/{celebrationId} | Deletes a celebration |
| [**GetEmployeeengagementCelebrations**](#GetEmployeeengagementCelebrations) | **Get** /api/v2/employeeengagement/celebrations | Get all celebrations |
| [**GetEmployeeengagementRecognition**](#GetEmployeeengagementRecognition) | **Get** /api/v2/employeeengagement/recognitions/{recognitionId} | Gets a single recognition |
| [**GetEmployeeengagementRecognitions**](#GetEmployeeengagementRecognitions) | **Get** /api/v2/employeeengagement/recognitions | Gets sent recognitions |
| [**PatchEmployeeengagementCelebration**](#PatchEmployeeengagementCelebration) | **Patch** /api/v2/employeeengagement/celebrations/{celebrationId} | Set a state for a celebration |
| [**PostEmployeeengagementRecognitions**](#PostEmployeeengagementRecognitions) | **Post** /api/v2/employeeengagement/recognitions | Creates a recognition |



## DeleteEmployeeengagementCelebration

> void DeleteEmployeeengagementCelebration (string celebrationId)


Deletes a celebration

Requires ANY permissions: 

* engagement:celebration:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteEmployeeengagementCelebrationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new EmployeeEngagementApi();
            var celebrationId = celebrationId_example;  // string | The ID of the celebration

            try
            { 
                // Deletes a celebration
                apiInstance.DeleteEmployeeengagementCelebration(celebrationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeeEngagementApi.DeleteEmployeeengagementCelebration: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **celebrationId** | **string**| The ID of the celebration |  |

### Return type

void (empty response body)


## GetEmployeeengagementCelebrations

> [**GetCelebrationListing**](GetCelebrationListing) GetEmployeeengagementCelebrations (int? pageNumber = null, int? pageSize = null)


Get all celebrations

Requires ANY permissions: 

* engagement:celebration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetEmployeeengagementCelebrationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new EmployeeEngagementApi();
            var pageNumber = 56;  // int? |  (optional)  (default to 1)
            var pageSize = 56;  // int? |  (optional)  (default to 25)

            try
            { 
                // Get all celebrations
                GetCelebrationListing result = apiInstance.GetEmployeeengagementCelebrations(pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeeEngagementApi.GetEmployeeengagementCelebrations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**|  | [optional] [default to 1] |
| **pageSize** | **int?**|  | [optional] [default to 25] |

### Return type

[**GetCelebrationListing**](GetCelebrationListing)


## GetEmployeeengagementRecognition

> [**Recognition**](Recognition) GetEmployeeengagementRecognition (string recognitionId)


Gets a single recognition

Requires ANY permissions: 

* engagement:recognition:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetEmployeeengagementRecognitionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new EmployeeEngagementApi();
            var recognitionId = recognitionId_example;  // string | The Recognition ID

            try
            { 
                // Gets a single recognition
                Recognition result = apiInstance.GetEmployeeengagementRecognition(recognitionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeeEngagementApi.GetEmployeeengagementRecognition: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **recognitionId** | **string**| The Recognition ID |  |

### Return type

[**Recognition**](Recognition)


## GetEmployeeengagementRecognitions

> [**Recognitions**](Recognitions) GetEmployeeengagementRecognitions (string direction = null, string recipient = null, DateTime? dateStart = null, DateTime? dateEnd = null, int? pageSize = null, int? pageNumber = null)


Gets sent recognitions

Requires ANY permissions: 

* engagement:recognition:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetEmployeeengagementRecognitionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new EmployeeEngagementApi();
            var direction = direction_example;  // string | The direction of the recognitions. (optional)  (default to received)
            var recipient = recipient_example;  // string | The ID of the recipient (when direction is sent). (optional) 
            var dateStart = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date of the search range. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional) 
            var dateEnd = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date of the search range. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional) 
            var pageSize = 56;  // int? | Page size (optional)  (default to 100)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Gets sent recognitions
                Recognitions result = apiInstance.GetEmployeeengagementRecognitions(direction, recipient, dateStart, dateEnd, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeeEngagementApi.GetEmployeeengagementRecognitions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **direction** | **string**| The direction of the recognitions. | [optional] [default to received]<br />**Values**: sent, received |
| **recipient** | **string**| The ID of the recipient (when direction is sent). | [optional]  |
| **dateStart** | **DateTime?**| The start date of the search range. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional]  |
| **dateEnd** | **DateTime?**| The end date of the search range. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional]  |
| **pageSize** | **int?**| Page size | [optional] [default to 100] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |

### Return type

[**Recognitions**](Recognitions)


## PatchEmployeeengagementCelebration

> void PatchEmployeeengagementCelebration (string celebrationId, CelebrationStateParam body)


Set a state for a celebration

Requires ANY permissions: 

* engagement:celebration:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchEmployeeengagementCelebrationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new EmployeeEngagementApi();
            var celebrationId = celebrationId_example;  // string | The ID of the celebration
            var body = new CelebrationStateParam(); // CelebrationStateParam | Patch Celebration state

            try
            { 
                // Set a state for a celebration
                apiInstance.PatchEmployeeengagementCelebration(celebrationId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeeEngagementApi.PatchEmployeeengagementCelebration: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **celebrationId** | **string**| The ID of the celebration |  |
| **body** | [**CelebrationStateParam**](CelebrationStateParam)| Patch Celebration state |  |

### Return type

void (empty response body)


## PostEmployeeengagementRecognitions

> [**RecognitionBase**](RecognitionBase) PostEmployeeengagementRecognitions (CreateRecognition body)


Creates a recognition

Requires ANY permissions: 

* engagement:recognition:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostEmployeeengagementRecognitionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new EmployeeEngagementApi();
            var body = new CreateRecognition(); // CreateRecognition | Create Recognition

            try
            { 
                // Creates a recognition
                RecognitionBase result = apiInstance.PostEmployeeengagementRecognitions(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeeEngagementApi.PostEmployeeengagementRecognitions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateRecognition**](CreateRecognition)| Create Recognition |  |

### Return type

[**RecognitionBase**](RecognitionBase)


_PureCloudPlatform.Client.V2 256.0.0_
