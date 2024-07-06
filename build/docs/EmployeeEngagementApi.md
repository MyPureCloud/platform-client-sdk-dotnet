---
title: EmployeeEngagementApi
---
## PureCloudPlatform.Client.V2.Api.EmployeeEngagementApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteEmployeeengagementCelebration**](EmployeeEngagementApi.html#deleteemployeeengagementcelebration) | **Delete** /api/v2/employeeengagement/celebrations/{celebrationId} | Deletes a celebration |
| [**GetEmployeeengagementCelebrations**](EmployeeEngagementApi.html#getemployeeengagementcelebrations) | **Get** /api/v2/employeeengagement/celebrations | Get all celebrations |
| [**GetEmployeeengagementRecognition**](EmployeeEngagementApi.html#getemployeeengagementrecognition) | **Get** /api/v2/employeeengagement/recognitions/{recognitionId} | Gets a single recognition |
| [**PatchEmployeeengagementCelebration**](EmployeeEngagementApi.html#patchemployeeengagementcelebration) | **Patch** /api/v2/employeeengagement/celebrations/{celebrationId} | Set a state for a celebration |
| [**PostEmployeeengagementRecognitions**](EmployeeEngagementApi.html#postemployeeengagementrecognitions) | **Post** /api/v2/employeeengagement/recognitions | Creates a recognition |
{: class="table table-striped"}

<a name="deleteemployeeengagementcelebration"></a>

## void DeleteEmployeeengagementCelebration (string celebrationId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getemployeeengagementcelebrations"></a>

## [**GetCelebrationListing**](GetCelebrationListing.html) GetEmployeeengagementCelebrations (int? pageNumber = null, int? pageSize = null)



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
{: class="table table-striped"}

### Return type

[**GetCelebrationListing**](GetCelebrationListing.html)

<a name="getemployeeengagementrecognition"></a>

## [**Recognition**](Recognition.html) GetEmployeeengagementRecognition (string recognitionId)



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
{: class="table table-striped"}

### Return type

[**Recognition**](Recognition.html)

<a name="patchemployeeengagementcelebration"></a>

## void PatchEmployeeengagementCelebration (string celebrationId, CelebrationStateParam body)



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
| **body** | [**CelebrationStateParam**](CelebrationStateParam.html)| Patch Celebration state |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postemployeeengagementrecognitions"></a>

## [**RecognitionBase**](RecognitionBase.html) PostEmployeeengagementRecognitions (CreateRecognition body)



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
| **body** | [**CreateRecognition**](CreateRecognition.html)| Create Recognition |  |
{: class="table table-striped"}

### Return type

[**RecognitionBase**](RecognitionBase.html)

