# UserRecordingsApi

## PureCloudPlatform.Client.V2.Api.UserRecordingsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteUserrecording**](#DeleteUserrecording) | **Delete** /api/v2/userrecordings/{recordingId} | Delete a user recording. |
| [**GetUserrecording**](#GetUserrecording) | **Get** /api/v2/userrecordings/{recordingId} | Get a user recording. |
| [**GetUserrecordingMedia**](#GetUserrecordingMedia) | **Get** /api/v2/userrecordings/{recordingId}/media | Download a user recording. |
| [**GetUserrecordingTranscoding**](#GetUserrecordingTranscoding) | **Get** /api/v2/userrecordings/{recordingId}/transcoding | Download a user recording. |
| [**GetUserrecordings**](#GetUserrecordings) | **Get** /api/v2/userrecordings | Get a list of user recordings. |
| [**GetUserrecordingsSummary**](#GetUserrecordingsSummary) | **Get** /api/v2/userrecordings/summary | Get user recording summary |
| [**PutUserrecording**](#PutUserrecording) | **Put** /api/v2/userrecordings/{recordingId} | Update a user recording. |



## DeleteUserrecording

> void DeleteUserrecording (string recordingId)


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

### Return type

void (empty response body)


## GetUserrecording

> [**UserRecording**](UserRecording) GetUserrecording (string recordingId, List<string> expand = null)


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
| **expand** | [**List<string>**](string)| Which fields, if any, to expand. | [optional] <br />**Values**: conversation |

### Return type

[**UserRecording**](UserRecording)


## GetUserrecordingMedia

> [**DownloadResponse**](DownloadResponse) GetUserrecordingMedia (string recordingId, string formatId = null, bool? async = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Download a user recording.

API should migrate to use GET api/v2/userrecordings/{recordingId}/transcoding

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

### Return type

[**DownloadResponse**](DownloadResponse)


## GetUserrecordingTranscoding

> [**DownloadResponse**](DownloadResponse) GetUserrecordingTranscoding (string recordingId, string formatId = null)


Download a user recording.

Requires ANY permissions: 

* They are enforced by the backend

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUserrecordingTranscodingExample
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

            try
            { 
                // Download a user recording.
                DownloadResponse result = apiInstance.GetUserrecordingTranscoding(recordingId, formatId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserRecordingsApi.GetUserrecordingTranscoding: " + e.Message );
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

### Return type

[**DownloadResponse**](DownloadResponse)


## GetUserrecordings

> [**UserRecordingEntityListing**](UserRecordingEntityListing) GetUserrecordings (int? pageSize = null, int? pageNumber = null, List<string> expand = null)


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
| **expand** | [**List<string>**](string)| Which fields, if any, to expand. | [optional] <br />**Values**: conversation |

### Return type

[**UserRecordingEntityListing**](UserRecordingEntityListing)


## GetUserrecordingsSummary

> [**FaxSummary**](FaxSummary) GetUserrecordingsSummary ()


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

[**FaxSummary**](FaxSummary)


## PutUserrecording

> [**UserRecording**](UserRecording) PutUserrecording (string recordingId, UserRecording body, List<string> expand = null)


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
| **body** | [**UserRecording**](UserRecording)| UserRecording |  |
| **expand** | [**List<string>**](string)| Which fields, if any, to expand. | [optional] <br />**Values**: conversation |

### Return type

[**UserRecording**](UserRecording)


_PureCloudPlatform.Client.V2 219.0.0_
