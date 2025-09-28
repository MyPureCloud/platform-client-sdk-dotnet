# AIStudioApi

## PureCloudPlatform.Client.V2.Api.AIStudioApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteConversationsSummariesSetting**](#DeleteConversationsSummariesSetting) | **Delete** /api/v2/conversations/summaries/settings/{summarySettingId} | Delete a summary setting. |
| [**DeleteGuideJobs**](#DeleteGuideJobs) | **Delete** /api/v2/guides/{guideId}/jobs | Start the deletion of a guide. |
| [**GetConversationsSummariesSetting**](#GetConversationsSummariesSetting) | **Get** /api/v2/conversations/summaries/settings/{summarySettingId} | Receive a summary setting. |
| [**GetConversationsSummariesSettings**](#GetConversationsSummariesSettings) | **Get** /api/v2/conversations/summaries/settings | Get all summary settings. |
| [**GetGuide**](#GetGuide) | **Get** /api/v2/guides/{guideId} | Get guide. |
| [**GetGuideJob**](#GetGuideJob) | **Get** /api/v2/guides/{guideId}/jobs/{jobId} | Get the specified guide deletion job. |
| [**GetGuideVersion**](#GetGuideVersion) | **Get** /api/v2/guides/{guideId}/versions/{versionId} | Get a guide version. |
| [**GetGuideVersionJob**](#GetGuideVersionJob) | **Get** /api/v2/guides/{guideId}/versions/{versionId}/jobs/{jobId} | Get the status of the publishing job for this guide version. |
| [**GetGuides**](#GetGuides) | **Get** /api/v2/guides | Get all guides. |
| [**GetGuidesJob**](#GetGuidesJob) | **Get** /api/v2/guides/jobs/{jobId} | Get the status of the guide content generation job. |
| [**PatchGuide**](#PatchGuide) | **Patch** /api/v2/guides/{guideId} | Update a guide. |
| [**PatchGuideVersion**](#PatchGuideVersion) | **Patch** /api/v2/guides/{guideId}/versions/{versionId} | Update a guide version. |
| [**PostConversationsSummariesPreview**](#PostConversationsSummariesPreview) | **Post** /api/v2/conversations/summaries/preview | Trigger summary preview event generation. |
| [**PostConversationsSummariesSettings**](#PostConversationsSummariesSettings) | **Post** /api/v2/conversations/summaries/settings | Create a summary setting. |
| [**PostGuideVersionJobs**](#PostGuideVersionJobs) | **Post** /api/v2/guides/{guideId}/versions/{versionId}/jobs | Start the publishing of a guide version. |
| [**PostGuideVersions**](#PostGuideVersions) | **Post** /api/v2/guides/{guideId}/versions | Create a guide version. |
| [**PostGuides**](#PostGuides) | **Post** /api/v2/guides | Create a guide. |
| [**PostGuidesJobs**](#PostGuidesJobs) | **Post** /api/v2/guides/jobs | Start a guide content generation job. |
| [**PutConversationsSummariesSetting**](#PutConversationsSummariesSetting) | **Put** /api/v2/conversations/summaries/settings/{summarySettingId} | Update a summary setting. |



## DeleteConversationsSummariesSetting

> void DeleteConversationsSummariesSetting (string summarySettingId)


Delete a summary setting.

Requires ALL permissions: 

* aiStudio:summaryConfig:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteConversationsSummariesSettingExample
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
            var summarySettingId = summarySettingId_example;  // string | Summary setting id

            try
            { 
                // Delete a summary setting.
                apiInstance.DeleteConversationsSummariesSetting(summarySettingId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AIStudioApi.DeleteConversationsSummariesSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **summarySettingId** | **string**| Summary setting id |  |

### Return type

void (empty response body)


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


## GetConversationsSummariesSetting

> [**SummarySetting**](SummarySetting) GetConversationsSummariesSetting (string summarySettingId)


Receive a summary setting.

Requires ALL permissions: 

* aiStudio:summaryConfig:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsSummariesSettingExample
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
            var summarySettingId = summarySettingId_example;  // string | Summary setting id

            try
            { 
                // Receive a summary setting.
                SummarySetting result = apiInstance.GetConversationsSummariesSetting(summarySettingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AIStudioApi.GetConversationsSummariesSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **summarySettingId** | **string**| Summary setting id |  |

### Return type

[**SummarySetting**](SummarySetting)


## GetConversationsSummariesSettings

> [**SummarySettingEntityListing**](SummarySettingEntityListing) GetConversationsSummariesSettings (string language = null, string name = null, string sortBy = null, string sortOrder = null, int? pageNumber = null, int? pageSize = null)


Get all summary settings.

Requires ALL permissions: 

* aiStudio:summaryConfig:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsSummariesSettingsExample
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
            var language = language_example;  // string | Filter by matching language - case insensitive. (optional) 
            var name = name_example;  // string | Filter by partially matching name - case insensitive. (optional) 
            var sortBy = sortBy_example;  // string | Sort by. Default value dateModified. (optional)  (default to dateModified)
            var sortOrder = sortOrder_example;  // string | Sort Order. Default value desc. (optional)  (default to desc)
            var pageNumber = 56;  // int? | Page number. (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size. The maximum page size is 100. (optional)  (default to 25)

            try
            { 
                // Get all summary settings.
                SummarySettingEntityListing result = apiInstance.GetConversationsSummariesSettings(language, name, sortBy, sortOrder, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AIStudioApi.GetConversationsSummariesSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **language** | **string**| Filter by matching language - case insensitive. | [optional]  |
| **name** | **string**| Filter by partially matching name - case insensitive. | [optional]  |
| **sortBy** | **string**| Sort by. Default value dateModified. | [optional] [default to dateModified]<br />**Values**: dateModified, name |
| **sortOrder** | **string**| Sort Order. Default value desc. | [optional] [default to desc]<br />**Values**: asc, desc |
| **pageNumber** | **int?**| Page number. | [optional] [default to 1] |
| **pageSize** | **int?**| Page size. The maximum page size is 100. | [optional] [default to 25] |

### Return type

[**SummarySettingEntityListing**](SummarySettingEntityListing)


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


## PatchGuide

> [**Guide**](Guide) PatchGuide (string guideId, UpdateGuide body)


Update a guide.

PatchGuide is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* aiStudio:guide:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchGuideExample
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
            var body = new UpdateGuide(); // UpdateGuide | 

            try
            { 
                // Update a guide.
                Guide result = apiInstance.PatchGuide(guideId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AIStudioApi.PatchGuide: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **guideId** | **string**| Guide ID |  |
| **body** | [**UpdateGuide**](UpdateGuide)|  |  |

### Return type

[**Guide**](Guide)


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


## PostConversationsSummariesPreview

> void PostConversationsSummariesPreview (SummarySettingWithTranscript body)


Trigger summary preview event generation.

Requires ALL permissions: 

* aiStudio:summaryPreview:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsSummariesPreviewExample
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
            var body = new SummarySettingWithTranscript(); // SummarySettingWithTranscript | 

            try
            { 
                // Trigger summary preview event generation.
                apiInstance.PostConversationsSummariesPreview(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AIStudioApi.PostConversationsSummariesPreview: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SummarySettingWithTranscript**](SummarySettingWithTranscript)|  |  |

### Return type

void (empty response body)


## PostConversationsSummariesSettings

> [**SummarySetting**](SummarySetting) PostConversationsSummariesSettings (SummarySetting body)


Create a summary setting.

Requires ALL permissions: 

* aiStudio:summaryConfig:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsSummariesSettingsExample
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
            var body = new SummarySetting(); // SummarySetting | 

            try
            { 
                // Create a summary setting.
                SummarySetting result = apiInstance.PostConversationsSummariesSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AIStudioApi.PostConversationsSummariesSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SummarySetting**](SummarySetting)|  |  |

### Return type

[**SummarySetting**](SummarySetting)


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


## PutConversationsSummariesSetting

> [**SummarySetting**](SummarySetting) PutConversationsSummariesSetting (string summarySettingId, SummarySetting body)


Update a summary setting.

Requires ALL permissions: 

* aiStudio:summaryConfig:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationsSummariesSettingExample
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
            var summarySettingId = summarySettingId_example;  // string | Summary setting id
            var body = new SummarySetting(); // SummarySetting | 

            try
            { 
                // Update a summary setting.
                SummarySetting result = apiInstance.PutConversationsSummariesSetting(summarySettingId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AIStudioApi.PutConversationsSummariesSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **summarySettingId** | **string**| Summary setting id |  |
| **body** | [**SummarySetting**](SummarySetting)|  |  |

### Return type

[**SummarySetting**](SummarySetting)


_PureCloudPlatform.Client.V2 243.0.0_
