---
title: UserRecordingsApi
---
## PureCloudPlatform.Client.V2.Api.UserRecordingsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteUserrecording**](UserRecordingsApi.html#deleteuserrecording) | **DELETE** /api/v2/userrecordings/{recordingId} | Delete a user recording. |
| [**GetUserrecording**](UserRecordingsApi.html#getuserrecording) | **GET** /api/v2/userrecordings/{recordingId} | Get a user recording. |
| [**GetUserrecordingMedia**](UserRecordingsApi.html#getuserrecordingmedia) | **GET** /api/v2/userrecordings/{recordingId}/media | Download a user recording. |
| [**GetUserrecordings**](UserRecordingsApi.html#getuserrecordings) | **GET** /api/v2/userrecordings | Get a list of user recordings. |
| [**GetUserrecordingsSummary**](UserRecordingsApi.html#getuserrecordingssummary) | **GET** /api/v2/userrecordings/summary | Get user recording summary |
| [**PutUserrecording**](UserRecordingsApi.html#putuserrecording) | **PUT** /api/v2/userrecordings/{recordingId} | Update a user recording. |
{: class="table table-striped"}

<a name="deleteuserrecording"></a>

## void DeleteUserrecording (string recordingId)



Delete a user recording.



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
    public class DeleteUserrecordingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UserRecordingsApi();
            var recordingId = recordingId_example;  // string | User Recording ID

            try
            { 
                // Delete a user recording.
                apiInstance.DeleteUserrecording(recordingId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserRecordingsApi.DeleteUserrecording: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **recordingId** | **string**| User Recording ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getuserrecording"></a>

## [**UserRecording**](UserRecording.html) GetUserrecording (string recordingId, List<string> expand = null)



Get a user recording.



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
    public class GetUserrecordingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UserRecordingsApi();
            var recordingId = recordingId_example;  // string | User Recording ID
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 

            try
            { 
                // Get a user recording.
                UserRecording result = apiInstance.GetUserrecording(recordingId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserRecordingsApi.GetUserrecording: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **recordingId** | **string**| User Recording ID |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional] <br />**Values**: conversation |
{: class="table table-striped"}

### Return type

[**UserRecording**](UserRecording.html)

<a name="getuserrecordingmedia"></a>

## [**DownloadResponse**](DownloadResponse.html) GetUserrecordingMedia (string recordingId, string formatId = null, bool? async = null)



Download a user recording.



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
    public class GetUserrecordingMediaExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UserRecordingsApi();
            var recordingId = recordingId_example;  // string | User Recording ID
            var formatId = formatId_example;  // string | The desired media format. (optional)  (default to WEBM)
            var async = true;  // bool? | When set to true, api will return 202 response until the recording is ready for download (optional) 

            try
            { 
                // Download a user recording.
                DownloadResponse result = apiInstance.GetUserrecordingMedia(recordingId, formatId, async);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserRecordingsApi.GetUserrecordingMedia: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **recordingId** | **string**| User Recording ID |  |
| **formatId** | **string**| The desired media format. | [optional] [default to WEBM]<br />**Values**: WAV, WEBM, WAV_ULAW, OGG_VORBIS, OGG_OPUS, MP3, NONE |
| **async** | **bool?**| When set to true, api will return 202 response until the recording is ready for download | [optional]  |
{: class="table table-striped"}

### Return type

[**DownloadResponse**](DownloadResponse.html)

<a name="getuserrecordings"></a>

## [**UserRecordingEntityListing**](UserRecordingEntityListing.html) GetUserrecordings (int? pageSize = null, int? pageNumber = null, List<string> expand = null)



Get a list of user recordings.



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
    public class GetUserrecordingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UserRecordingsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 

            try
            { 
                // Get a list of user recordings.
                UserRecordingEntityListing result = apiInstance.GetUserrecordings(pageSize, pageNumber, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserRecordingsApi.GetUserrecordings: " + e.Message );
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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional] <br />**Values**: conversation |
{: class="table table-striped"}

### Return type

[**UserRecordingEntityListing**](UserRecordingEntityListing.html)

<a name="getuserrecordingssummary"></a>

## [**FaxSummary**](FaxSummary.html) GetUserrecordingsSummary ()



Get user recording summary



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
    public class GetUserrecordingsSummaryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UserRecordingsApi();

            try
            { 
                // Get user recording summary
                FaxSummary result = apiInstance.GetUserrecordingsSummary();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserRecordingsApi.GetUserrecordingsSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**FaxSummary**](FaxSummary.html)

<a name="putuserrecording"></a>

## [**UserRecording**](UserRecording.html) PutUserrecording (string recordingId, UserRecording body, List<string> expand = null)



Update a user recording.



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
    public class PutUserrecordingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UserRecordingsApi();
            var recordingId = recordingId_example;  // string | User Recording ID
            var body = new UserRecording(); // UserRecording | UserRecording
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 

            try
            { 
                // Update a user recording.
                UserRecording result = apiInstance.PutUserrecording(recordingId, body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserRecordingsApi.PutUserrecording: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **recordingId** | **string**| User Recording ID |  |
| **body** | [**UserRecording**](UserRecording.html)| UserRecording |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional] <br />**Values**: conversation |
{: class="table table-striped"}

### Return type

[**UserRecording**](UserRecording.html)

