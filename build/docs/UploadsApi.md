---
title: UploadsApi
---
## PureCloudPlatform.Client.V2.Api.UploadsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetKnowledgeKnowledgebaseUploadsUrlsJob**](UploadsApi.html#getknowledgeknowledgebaseuploadsurlsjob) | **Get** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/uploads/urls/jobs/{jobId} | Get content upload from URL job status |
| [**PostIntegrationsActionDraftFunctionUpload**](UploadsApi.html#postintegrationsactiondraftfunctionupload) | **Post** /api/v2/integrations/actions/{actionId}/draft/function/upload | Create upload presigned URL for draft function package file. |
| [**PostKnowledgeDocumentuploads**](UploadsApi.html#postknowledgedocumentuploads) | **Post** /api/v2/knowledge/documentuploads | Creates a presigned URL for uploading a knowledge import file with a set of documents |
| [**PostKnowledgeKnowledgebaseUploadsUrlsJobs**](UploadsApi.html#postknowledgeknowledgebaseuploadsurlsjobs) | **Post** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/uploads/urls/jobs | Create content upload from URL job |
| [**PostLanguageunderstandingMinerUploads**](UploadsApi.html#postlanguageunderstandingmineruploads) | **Post** /api/v2/languageunderstanding/miners/{minerId}/uploads | Creates a presigned URL for uploading a chat corpus which will be used for mining by intent miner |
| [**PostUploadsLearningCoverart**](UploadsApi.html#postuploadslearningcoverart) | **Post** /api/v2/uploads/learning/coverart | Generates pre-signed URL to upload cover art for learning modules |
| [**PostUploadsPublicassetsImages**](UploadsApi.html#postuploadspublicassetsimages) | **Post** /api/v2/uploads/publicassets/images | Creates presigned url for uploading a public asset image |
| [**PostUploadsRecordings**](UploadsApi.html#postuploadsrecordings) | **Post** /api/v2/uploads/recordings | Creates presigned url for uploading a recording file |
| [**PostUploadsWorkforcemanagementHistoricaldataCsv**](UploadsApi.html#postuploadsworkforcemanagementhistoricaldatacsv) | **Post** /api/v2/uploads/workforcemanagement/historicaldata/csv | Creates presigned url for uploading WFM historical data file. Requires data in csv format. |
{: class="table table-striped"}

<a name="getknowledgeknowledgebaseuploadsurlsjob"></a>

## [**GetUploadSourceUrlJobStatusResponse**](GetUploadSourceUrlJobStatusResponse.html) GetKnowledgeKnowledgebaseUploadsUrlsJob (string knowledgeBaseId, string jobId)



Get content upload from URL job status

GetKnowledgeKnowledgebaseUploadsUrlsJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* knowledge:uploadSourceUrlJob:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseUploadsUrlsJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UploadsApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var jobId = jobId_example;  // string | Upload job ID

            try
            { 
                // Get content upload from URL job status
                GetUploadSourceUrlJobStatusResponse result = apiInstance.GetKnowledgeKnowledgebaseUploadsUrlsJob(knowledgeBaseId, jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UploadsApi.GetKnowledgeKnowledgebaseUploadsUrlsJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **jobId** | **string**| Upload job ID |  |
{: class="table table-striped"}

### Return type

[**GetUploadSourceUrlJobStatusResponse**](GetUploadSourceUrlJobStatusResponse.html)

<a name="postintegrationsactiondraftfunctionupload"></a>

## [**FunctionUploadResponse**](FunctionUploadResponse.html) PostIntegrationsActionDraftFunctionUpload (string actionId, FunctionUploadRequest body)



Create upload presigned URL for draft function package file.

PostIntegrationsActionDraftFunctionUpload is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* integrations:actionFunction:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostIntegrationsActionDraftFunctionUploadExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UploadsApi();
            var actionId = actionId_example;  // string | actionId
            var body = new FunctionUploadRequest(); // FunctionUploadRequest | Input used to request URL upload.

            try
            { 
                // Create upload presigned URL for draft function package file.
                FunctionUploadResponse result = apiInstance.PostIntegrationsActionDraftFunctionUpload(actionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UploadsApi.PostIntegrationsActionDraftFunctionUpload: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **actionId** | **string**| actionId |  |
| **body** | [**FunctionUploadRequest**](FunctionUploadRequest.html)| Input used to request URL upload. |  |
{: class="table table-striped"}

### Return type

[**FunctionUploadResponse**](FunctionUploadResponse.html)

<a name="postknowledgedocumentuploads"></a>

## [**UploadUrlResponse**](UploadUrlResponse.html) PostKnowledgeDocumentuploads (UploadUrlRequest body)



Creates a presigned URL for uploading a knowledge import file with a set of documents

Requires ALL permissions: 

* knowledge:document:upload

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeDocumentuploadsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UploadsApi();
            var body = new UploadUrlRequest(); // UploadUrlRequest | query

            try
            { 
                // Creates a presigned URL for uploading a knowledge import file with a set of documents
                UploadUrlResponse result = apiInstance.PostKnowledgeDocumentuploads(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UploadsApi.PostKnowledgeDocumentuploads: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UploadUrlRequest**](UploadUrlRequest.html)| query |  |
{: class="table table-striped"}

### Return type

[**UploadUrlResponse**](UploadUrlResponse.html)

<a name="postknowledgeknowledgebaseuploadsurlsjobs"></a>

## [**CreateUploadSourceUrlJobResponse**](CreateUploadSourceUrlJobResponse.html) PostKnowledgeKnowledgebaseUploadsUrlsJobs (string knowledgeBaseId, CreateUploadSourceUrlJobRequest body)



Create content upload from URL job

PostKnowledgeKnowledgebaseUploadsUrlsJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* knowledge:uploadSourceUrlJob:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseUploadsUrlsJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UploadsApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var body = new CreateUploadSourceUrlJobRequest(); // CreateUploadSourceUrlJobRequest | uploadRequest

            try
            { 
                // Create content upload from URL job
                CreateUploadSourceUrlJobResponse result = apiInstance.PostKnowledgeKnowledgebaseUploadsUrlsJobs(knowledgeBaseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UploadsApi.PostKnowledgeKnowledgebaseUploadsUrlsJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **body** | [**CreateUploadSourceUrlJobRequest**](CreateUploadSourceUrlJobRequest.html)| uploadRequest |  |
{: class="table table-striped"}

### Return type

[**CreateUploadSourceUrlJobResponse**](CreateUploadSourceUrlJobResponse.html)

<a name="postlanguageunderstandingmineruploads"></a>

## [**UploadUrlResponse**](UploadUrlResponse.html) PostLanguageunderstandingMinerUploads (string minerId, Object body)



Creates a presigned URL for uploading a chat corpus which will be used for mining by intent miner

Requires ALL permissions: 

* languageUnderstanding:miner:upload

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostLanguageunderstandingMinerUploadsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UploadsApi();
            var minerId = minerId_example;  // string | Miner ID
            var body = ;  // Object | query

            try
            { 
                // Creates a presigned URL for uploading a chat corpus which will be used for mining by intent miner
                UploadUrlResponse result = apiInstance.PostLanguageunderstandingMinerUploads(minerId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UploadsApi.PostLanguageunderstandingMinerUploads: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **minerId** | **string**| Miner ID |  |
| **body** | **Object**| query |  |
{: class="table table-striped"}

### Return type

[**UploadUrlResponse**](UploadUrlResponse.html)

<a name="postuploadslearningcoverart"></a>

## [**UploadUrlResponse**](UploadUrlResponse.html) PostUploadsLearningCoverart (LearningCoverArtUploadUrlRequest body)



Generates pre-signed URL to upload cover art for learning modules

Requires ALL permissions: 

* learning:coverart:upload

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUploadsLearningCoverartExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UploadsApi();
            var body = new LearningCoverArtUploadUrlRequest(); // LearningCoverArtUploadUrlRequest | query

            try
            { 
                // Generates pre-signed URL to upload cover art for learning modules
                UploadUrlResponse result = apiInstance.PostUploadsLearningCoverart(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UploadsApi.PostUploadsLearningCoverart: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**LearningCoverArtUploadUrlRequest**](LearningCoverArtUploadUrlRequest.html)| query |  |
{: class="table table-striped"}

### Return type

[**UploadUrlResponse**](UploadUrlResponse.html)

<a name="postuploadspublicassetsimages"></a>

## [**UploadUrlResponse**](UploadUrlResponse.html) PostUploadsPublicassetsImages (UploadUrlRequest body)



Creates presigned url for uploading a public asset image

Requires ALL permissions: 

* uploads:publicasset:upload

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUploadsPublicassetsImagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UploadsApi();
            var body = new UploadUrlRequest(); // UploadUrlRequest | query

            try
            { 
                // Creates presigned url for uploading a public asset image
                UploadUrlResponse result = apiInstance.PostUploadsPublicassetsImages(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UploadsApi.PostUploadsPublicassetsImages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UploadUrlRequest**](UploadUrlRequest.html)| query |  |
{: class="table table-striped"}

### Return type

[**UploadUrlResponse**](UploadUrlResponse.html)

<a name="postuploadsrecordings"></a>

## [**UploadUrlResponse**](UploadUrlResponse.html) PostUploadsRecordings (UploadUrlRequest body)



Creates presigned url for uploading a recording file

Requires ALL permissions: 

* recording:recording:upload

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUploadsRecordingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UploadsApi();
            var body = new UploadUrlRequest(); // UploadUrlRequest | query

            try
            { 
                // Creates presigned url for uploading a recording file
                UploadUrlResponse result = apiInstance.PostUploadsRecordings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UploadsApi.PostUploadsRecordings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UploadUrlRequest**](UploadUrlRequest.html)| query |  |
{: class="table table-striped"}

### Return type

[**UploadUrlResponse**](UploadUrlResponse.html)

<a name="postuploadsworkforcemanagementhistoricaldatacsv"></a>

## [**UploadUrlResponse**](UploadUrlResponse.html) PostUploadsWorkforcemanagementHistoricaldataCsv (UploadUrlRequest body)



Creates presigned url for uploading WFM historical data file. Requires data in csv format.

Requires ALL permissions: 

* wfm:historicalData:upload

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUploadsWorkforcemanagementHistoricaldataCsvExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UploadsApi();
            var body = new UploadUrlRequest(); // UploadUrlRequest | query

            try
            { 
                // Creates presigned url for uploading WFM historical data file. Requires data in csv format.
                UploadUrlResponse result = apiInstance.PostUploadsWorkforcemanagementHistoricaldataCsv(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UploadsApi.PostUploadsWorkforcemanagementHistoricaldataCsv: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UploadUrlRequest**](UploadUrlRequest.html)| query |  |
{: class="table table-striped"}

### Return type

[**UploadUrlResponse**](UploadUrlResponse.html)

