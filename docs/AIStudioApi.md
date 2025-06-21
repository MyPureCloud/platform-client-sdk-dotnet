# AIStudioApi

## PureCloudPlatform.Client.V2.Api.AIStudioApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteGuideJobs**](#DeleteGuideJobs) | **Delete** /api/v2/guides/{guideId}/jobs | Start the deletion of a guide. |
| [**GetGuide**](#GetGuide) | **Get** /api/v2/guides/{guideId} | Get guide. |
| [**GetGuideJob**](#GetGuideJob) | **Get** /api/v2/guides/{guideId}/jobs/{jobId} | Get the specified guide deletion job. |
| [**GetGuideVersion**](#GetGuideVersion) | **Get** /api/v2/guides/{guideId}/versions/{versionId} | Get a guide version. |
| [**GetGuideVersionJob**](#GetGuideVersionJob) | **Get** /api/v2/guides/{guideId}/versions/{versionId}/jobs/{jobId} | Get the status of the publishing job for this guide version. |
| [**GetGuides**](#GetGuides) | **Get** /api/v2/guides | Get all guides. |
| [**GetGuidesJob**](#GetGuidesJob) | **Get** /api/v2/guides/jobs/{jobId} | Get the status of the guide content generation job. |
| [**PatchGuideVersion**](#PatchGuideVersion) | **Patch** /api/v2/guides/{guideId}/versions/{versionId} | Update a guide version. |
| [**PostGuideVersionJobs**](#PostGuideVersionJobs) | **Post** /api/v2/guides/{guideId}/versions/{versionId}/jobs | Start the publishing of a guide version. |
| [**PostGuideVersions**](#PostGuideVersions) | **Post** /api/v2/guides/{guideId}/versions | Create a guide version. |
| [**PostGuides**](#PostGuides) | **Post** /api/v2/guides | Create a guide. |
| [**PostGuidesJobs**](#PostGuidesJobs) | **Post** /api/v2/guides/jobs | Start a guide content generation job. |



## DeleteGuideJobs

> [**GuideJob**](GuideJob) DeleteGuideJobs (string guideId)


Start the deletion of a guide.

DeleteGuideJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* aiStudio:guideJob:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteGuideJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AIStudioApi();
            var guideId = guideId_example;  // string | Guide ID

            try
            { 
                // Start the deletion of a guide.
                GuideJob result = apiInstance.DeleteGuideJobs(guideId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AIStudioApi.DeleteGuideJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **guideId** | **string**| Guide ID |  |

### Return type

[**GuideJob**](GuideJob)


## GetGuide

> [**Guide**](Guide) GetGuide (string guideId)


Get guide.

GetGuide is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* aiStudio:guide:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGuideExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AIStudioApi();
            var guideId = guideId_example;  // string | Guide ID

            try
            { 
                // Get guide.
                Guide result = apiInstance.GetGuide(guideId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AIStudioApi.GetGuide: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **guideId** | **string**| Guide ID |  |

### Return type

[**Guide**](Guide)


## GetGuideJob

> [**GuideJob**](GuideJob) GetGuideJob (string guideId, string jobId)


Get the specified guide deletion job.

GetGuideJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* aiStudio:guideJob:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGuideJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AIStudioApi();
            var guideId = guideId_example;  // string | Guide ID
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get the specified guide deletion job.
                GuideJob result = apiInstance.GetGuideJob(guideId, jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AIStudioApi.GetGuideJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **guideId** | **string**| Guide ID |  |
| **jobId** | **string**| jobId |  |

### Return type

[**GuideJob**](GuideJob)


## GetGuideVersion

> [**GuideVersion**](GuideVersion) GetGuideVersion (string guideId, string versionId)


Get a guide version.

GetGuideVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* aiStudio:guideVersion:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGuideVersionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AIStudioApi();
            var guideId = guideId_example;  // string | Guide ID
            var versionId = versionId_example;  // string | Version ID

            try
            { 
                // Get a guide version.
                GuideVersion result = apiInstance.GetGuideVersion(guideId, versionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AIStudioApi.GetGuideVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **guideId** | **string**| Guide ID |  |
| **versionId** | **string**| Version ID |  |

### Return type

[**GuideVersion**](GuideVersion)


## GetGuideVersionJob

> [**GuideVersionPublishJob**](GuideVersionPublishJob) GetGuideVersionJob (string guideId, string versionId, string jobId)


Get the status of the publishing job for this guide version.

GetGuideVersionJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* aiStudio:guideVersionJob:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGuideVersionJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AIStudioApi();
            var guideId = guideId_example;  // string | Guide ID
            var versionId = versionId_example;  // string | Version ID
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get the status of the publishing job for this guide version.
                GuideVersionPublishJob result = apiInstance.GetGuideVersionJob(guideId, versionId, jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AIStudioApi.GetGuideVersionJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **guideId** | **string**| Guide ID |  |
| **versionId** | **string**| Version ID |  |
| **jobId** | **string**| jobId |  |

### Return type

[**GuideVersionPublishJob**](GuideVersionPublishJob)


## GetGuides

> [**GuideEntityListing**](GuideEntityListing) GetGuides (string name = null, string nameContains = null, string status = null, string sortBy = null, string sortOrder = null, int? pageNumber = null, int? pageSize = null)


Get all guides.

GetGuides is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* aiStudio:guide:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGuidesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AIStudioApi();
            var name = name_example;  // string | Filter by matching name - case insensitive. (optional) 
            var nameContains = nameContains_example;  // string | Filter by name contains - case insensitive. (optional) 
            var status = status_example;  // string | Filter by status. (optional) 
            var sortBy = sortBy_example;  // string | Sort by. Default value dateModified. (optional)  (default to dateModified)
            var sortOrder = sortOrder_example;  // string | Sort Order. Default value desc. (optional)  (default to desc)
            var pageNumber = 56;  // int? | Page number. (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size. The maximum page size is 100. (optional)  (default to 25)

            try
            { 
                // Get all guides.
                GuideEntityListing result = apiInstance.GetGuides(name, nameContains, status, sortBy, sortOrder, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AIStudioApi.GetGuides: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **name** | **string**| Filter by matching name - case insensitive. | [optional]  |
| **nameContains** | **string**| Filter by name contains - case insensitive. | [optional]  |
| **status** | **string**| Filter by status. | [optional] <br />**Values**: Published, Draft |
| **sortBy** | **string**| Sort by. Default value dateModified. | [optional] [default to dateModified]<br />**Values**: dateModified, name, status |
| **sortOrder** | **string**| Sort Order. Default value desc. | [optional] [default to desc]<br />**Values**: asc, desc |
| **pageNumber** | **int?**| Page number. | [optional] [default to 1] |
| **pageSize** | **int?**| Page size. The maximum page size is 100. | [optional] [default to 25] |

### Return type

[**GuideEntityListing**](GuideEntityListing)


## GetGuidesJob

> [**GuideContentGenerationJob**](GuideContentGenerationJob) GetGuidesJob (string jobId)


Get the status of the guide content generation job.

GetGuidesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* aiStudio:guideJob:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetGuidesJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AIStudioApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get the status of the guide content generation job.
                GuideContentGenerationJob result = apiInstance.GetGuidesJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AIStudioApi.GetGuidesJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |

### Return type

[**GuideContentGenerationJob**](GuideContentGenerationJob)


## PatchGuideVersion

> [**GuideVersion**](GuideVersion) PatchGuideVersion (string guideId, string versionId, UpdateGuideVersion body)


Update a guide version.

PatchGuideVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* aiStudio:guideVersion:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchGuideVersionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AIStudioApi();
            var guideId = guideId_example;  // string | Guide ID
            var versionId = versionId_example;  // string | Version ID
            var body = new UpdateGuideVersion(); // UpdateGuideVersion | 

            try
            { 
                // Update a guide version.
                GuideVersion result = apiInstance.PatchGuideVersion(guideId, versionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AIStudioApi.PatchGuideVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **guideId** | **string**| Guide ID |  |
| **versionId** | **string**| Version ID |  |
| **body** | [**UpdateGuideVersion**](UpdateGuideVersion)|  |  |

### Return type

[**GuideVersion**](GuideVersion)


## PostGuideVersionJobs

> [**GuideVersionPublishJob**](GuideVersionPublishJob) PostGuideVersionJobs (string guideId, string versionId, GuideVersionPublishJobRequest body)


Start the publishing of a guide version.

PostGuideVersionJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* aiStudio:guideVersionJob:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostGuideVersionJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AIStudioApi();
            var guideId = guideId_example;  // string | Guide ID
            var versionId = versionId_example;  // string | Version ID
            var body = new GuideVersionPublishJobRequest(); // GuideVersionPublishJobRequest | 

            try
            { 
                // Start the publishing of a guide version.
                GuideVersionPublishJob result = apiInstance.PostGuideVersionJobs(guideId, versionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AIStudioApi.PostGuideVersionJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **guideId** | **string**| Guide ID |  |
| **versionId** | **string**| Version ID |  |
| **body** | [**GuideVersionPublishJobRequest**](GuideVersionPublishJobRequest)|  |  |

### Return type

[**GuideVersionPublishJob**](GuideVersionPublishJob)


## PostGuideVersions

> [**GuideVersion**](GuideVersion) PostGuideVersions (string guideId, CreateGuideVersion body = null)


Create a guide version.

PostGuideVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* aiStudio:guideVersion:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostGuideVersionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AIStudioApi();
            var guideId = guideId_example;  // string | Guide ID
            var body = new CreateGuideVersion(); // CreateGuideVersion |  (optional) 

            try
            { 
                // Create a guide version.
                GuideVersion result = apiInstance.PostGuideVersions(guideId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AIStudioApi.PostGuideVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **guideId** | **string**| Guide ID |  |
| **body** | [**CreateGuideVersion**](CreateGuideVersion)|  | [optional]  |

### Return type

[**GuideVersion**](GuideVersion)


## PostGuides

> [**Guide**](Guide) PostGuides (CreateGuide body)


Create a guide.

PostGuides is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* aiStudio:guide:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostGuidesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AIStudioApi();
            var body = new CreateGuide(); // CreateGuide | 

            try
            { 
                // Create a guide.
                Guide result = apiInstance.PostGuides(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AIStudioApi.PostGuides: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateGuide**](CreateGuide)|  |  |

### Return type

[**Guide**](Guide)


## PostGuidesJobs

> [**GuideContentGenerationJob**](GuideContentGenerationJob) PostGuidesJobs (GenerateGuideContentRequest body)


Start a guide content generation job.

PostGuidesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* aiStudio:guideJob:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostGuidesJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AIStudioApi();
            var body = new GenerateGuideContentRequest(); // GenerateGuideContentRequest | 

            try
            { 
                // Start a guide content generation job.
                GuideContentGenerationJob result = apiInstance.PostGuidesJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AIStudioApi.PostGuidesJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**GenerateGuideContentRequest**](GenerateGuideContentRequest)|  |  |

### Return type

[**GuideContentGenerationJob**](GuideContentGenerationJob)


_PureCloudPlatform.Client.V2 236.0.0_
