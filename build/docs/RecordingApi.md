# RecordingApi

## PureCloudPlatform.Client.V2.Api.RecordingApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteConversationRecordingAnnotation**](#DeleteConversationRecordingAnnotation) | **Delete** /api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId} | Delete annotation |
| [**DeleteOrphanrecording**](#DeleteOrphanrecording) | **Delete** /api/v2/orphanrecordings/{orphanId} | Deletes a single orphan recording |
| [**DeleteRecordingCrossplatformMediaretentionpolicies**](#DeleteRecordingCrossplatformMediaretentionpolicies) | **Delete** /api/v2/recording/crossplatform/mediaretentionpolicies | Delete media retention policies |
| [**DeleteRecordingCrossplatformMediaretentionpolicy**](#DeleteRecordingCrossplatformMediaretentionpolicy) | **Delete** /api/v2/recording/crossplatform/mediaretentionpolicies/{policyId} | Delete a media retention policy |
| [**DeleteRecordingJob**](#DeleteRecordingJob) | **Delete** /api/v2/recording/jobs/{jobId} | Delete the recording bulk job |
| [**DeleteRecordingMediaretentionpolicies**](#DeleteRecordingMediaretentionpolicies) | **Delete** /api/v2/recording/mediaretentionpolicies | Delete media retention policies |
| [**DeleteRecordingMediaretentionpolicy**](#DeleteRecordingMediaretentionpolicy) | **Delete** /api/v2/recording/mediaretentionpolicies/{policyId} | Delete a media retention policy |
| [**GetConversationRecording**](#GetConversationRecording) | **Get** /api/v2/conversations/{conversationId}/recordings/{recordingId} | Gets a specific recording. |
| [**GetConversationRecordingAnnotation**](#GetConversationRecordingAnnotation) | **Get** /api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId} | Get annotation |
| [**GetConversationRecordingAnnotations**](#GetConversationRecordingAnnotations) | **Get** /api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations | Get annotations for recording |
| [**GetConversationRecordingmetadata**](#GetConversationRecordingmetadata) | **Get** /api/v2/conversations/{conversationId}/recordingmetadata | Get recording metadata for a conversation. Does not return playable media nor system annotations. Bookmark annotations will be excluded if either recording:recording:view or recording:annotation:view permission is missing. |
| [**GetConversationRecordingmetadataRecordingId**](#GetConversationRecordingmetadataRecordingId) | **Get** /api/v2/conversations/{conversationId}/recordingmetadata/{recordingId} | Get metadata for a specific recording. Does not return playable media. |
| [**GetConversationRecordings**](#GetConversationRecordings) | **Get** /api/v2/conversations/{conversationId}/recordings | Get all of a Conversation&#39;s Recordings. |
| [**GetOrphanrecording**](#GetOrphanrecording) | **Get** /api/v2/orphanrecordings/{orphanId} | Gets a single orphan recording |
| [**GetOrphanrecordingMedia**](#GetOrphanrecordingMedia) | **Get** /api/v2/orphanrecordings/{orphanId}/media | Gets the media of a single orphan recording |
| [**GetOrphanrecordings**](#GetOrphanrecordings) | **Get** /api/v2/orphanrecordings | Gets all orphan recordings |
| [**GetRecordingBatchrequest**](#GetRecordingBatchrequest) | **Get** /api/v2/recording/batchrequests/{jobId} | Get the status and results for a batch request job, only the user that submitted the job may retrieve results. Each result may contain either a URL to a recording or an error; additionally, a recording could be associated with multiple results. |
| [**GetRecordingCrossplatformMediaretentionpolicies**](#GetRecordingCrossplatformMediaretentionpolicies) | **Get** /api/v2/recording/crossplatform/mediaretentionpolicies | Gets media retention policy list with query options to filter on name and enabled. |
| [**GetRecordingCrossplatformMediaretentionpolicy**](#GetRecordingCrossplatformMediaretentionpolicy) | **Get** /api/v2/recording/crossplatform/mediaretentionpolicies/{policyId} | Get a media retention policy |
| [**GetRecordingJob**](#GetRecordingJob) | **Get** /api/v2/recording/jobs/{jobId} | Get the status of the job associated with the job id. |
| [**GetRecordingJobFailedrecordings**](#GetRecordingJobFailedrecordings) | **Get** /api/v2/recording/jobs/{jobId}/failedrecordings | Get IDs of recordings that the bulk job failed for |
| [**GetRecordingJobs**](#GetRecordingJobs) | **Get** /api/v2/recording/jobs | Get the status of all jobs within the user&#39;s organization |
| [**GetRecordingKeyconfiguration**](#GetRecordingKeyconfiguration) | **Get** /api/v2/recording/keyconfigurations/{keyConfigurationId} | Get the encryption key configurations |
| [**GetRecordingKeyconfigurations**](#GetRecordingKeyconfigurations) | **Get** /api/v2/recording/keyconfigurations | Get a list of key configurations data |
| [**GetRecordingMediaretentionpolicies**](#GetRecordingMediaretentionpolicies) | **Get** /api/v2/recording/mediaretentionpolicies | Gets media retention policy list with query options to filter on name and enabled. |
| [**GetRecordingMediaretentionpolicy**](#GetRecordingMediaretentionpolicy) | **Get** /api/v2/recording/mediaretentionpolicies/{policyId} | Get a media retention policy |
| [**GetRecordingRecordingkeys**](#GetRecordingRecordingkeys) | **Get** /api/v2/recording/recordingkeys | Get encryption key list |
| [**GetRecordingRecordingkeysRotationschedule**](#GetRecordingRecordingkeysRotationschedule) | **Get** /api/v2/recording/recordingkeys/rotationschedule | Get key rotation schedule |
| [**GetRecordingSettings**](#GetRecordingSettings) | **Get** /api/v2/recording/settings | Get the Recording Settings for the Organization |
| [**GetRecordingUploadsReport**](#GetRecordingUploadsReport) | **Get** /api/v2/recording/uploads/reports/{reportId} | Get the status of a recording upload status report |
| [**GetRecordingsRetentionQuery**](#GetRecordingsRetentionQuery) | **Get** /api/v2/recordings/retention/query | Query for recording retention data |
| [**GetRecordingsScreensessionsDetails**](#GetRecordingsScreensessionsDetails) | **Get** /api/v2/recordings/screensessions/details | Retrieves an object containing the total number of concurrent active screen recordings |
| [**PatchRecordingCrossplatformMediaretentionpolicy**](#PatchRecordingCrossplatformMediaretentionpolicy) | **Patch** /api/v2/recording/crossplatform/mediaretentionpolicies/{policyId} | Patch a media retention policy |
| [**PatchRecordingMediaretentionpolicy**](#PatchRecordingMediaretentionpolicy) | **Patch** /api/v2/recording/mediaretentionpolicies/{policyId} | Patch a media retention policy |
| [**PostConversationRecordingAnnotations**](#PostConversationRecordingAnnotations) | **Post** /api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations | Create annotation |
| [**PostRecordingBatchrequests**](#PostRecordingBatchrequests) | **Post** /api/v2/recording/batchrequests | Submit a batch download request for recordings. Recordings in response will be in their original format/codec - configured in the Trunk configuration. |
| [**PostRecordingCrossplatformMediaretentionpolicies**](#PostRecordingCrossplatformMediaretentionpolicies) | **Post** /api/v2/recording/crossplatform/mediaretentionpolicies | Create media retention policy |
| [**PostRecordingJobs**](#PostRecordingJobs) | **Post** /api/v2/recording/jobs | Create a recording bulk job. |
| [**PostRecordingKeyconfigurations**](#PostRecordingKeyconfigurations) | **Post** /api/v2/recording/keyconfigurations | Setup configurations for encryption key creation |
| [**PostRecordingKeyconfigurationsValidate**](#PostRecordingKeyconfigurationsValidate) | **Post** /api/v2/recording/keyconfigurations/validate | Validate encryption key configurations without saving it |
| [**PostRecordingLocalkeys**](#PostRecordingLocalkeys) | **Post** /api/v2/recording/localkeys | create a local key management recording key |
| [**PostRecordingMediaretentionpolicies**](#PostRecordingMediaretentionpolicies) | **Post** /api/v2/recording/mediaretentionpolicies | Create media retention policy |
| [**PostRecordingRecordingkeys**](#PostRecordingRecordingkeys) | **Post** /api/v2/recording/recordingkeys | Create encryption key |
| [**PostRecordingUploadsReports**](#PostRecordingUploadsReports) | **Post** /api/v2/recording/uploads/reports | Creates a recording upload status report |
| [**PostRecordingsDeletionprotection**](#PostRecordingsDeletionprotection) | **Post** /api/v2/recordings/deletionprotection | Get a list of conversations with protected recordings |
| [**PostRecordingsScreensessionsAcknowledge**](#PostRecordingsScreensessionsAcknowledge) | **Post** /api/v2/recordings/screensessions/acknowledge | Acknowledge a screen recording. |
| [**PostRecordingsScreensessionsMetadata**](#PostRecordingsScreensessionsMetadata) | **Post** /api/v2/recordings/screensessions/metadata | Provide meta-data a screen recording. |
| [**PutConversationRecording**](#PutConversationRecording) | **Put** /api/v2/conversations/{conversationId}/recordings/{recordingId} | Updates the retention records on a recording. |
| [**PutConversationRecordingAnnotation**](#PutConversationRecordingAnnotation) | **Put** /api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId} | Update annotation |
| [**PutOrphanrecording**](#PutOrphanrecording) | **Put** /api/v2/orphanrecordings/{orphanId} | Updates an orphan recording to a regular recording with retention values |
| [**PutRecordingCrossplatformMediaretentionpolicy**](#PutRecordingCrossplatformMediaretentionpolicy) | **Put** /api/v2/recording/crossplatform/mediaretentionpolicies/{policyId} | Update a media retention policy |
| [**PutRecordingJob**](#PutRecordingJob) | **Put** /api/v2/recording/jobs/{jobId} | Execute the recording bulk job. |
| [**PutRecordingKeyconfiguration**](#PutRecordingKeyconfiguration) | **Put** /api/v2/recording/keyconfigurations/{keyConfigurationId} | Update the encryption key configurations |
| [**PutRecordingMediaretentionpolicy**](#PutRecordingMediaretentionpolicy) | **Put** /api/v2/recording/mediaretentionpolicies/{policyId} | Update a media retention policy |
| [**PutRecordingRecordingkeysRotationschedule**](#PutRecordingRecordingkeysRotationschedule) | **Put** /api/v2/recording/recordingkeys/rotationschedule | Update key rotation schedule |
| [**PutRecordingSettings**](#PutRecordingSettings) | **Put** /api/v2/recording/settings | Update the Recording Settings for the Organization |
| [**PutRecordingsDeletionprotection**](#PutRecordingsDeletionprotection) | **Put** /api/v2/recordings/deletionprotection | Apply or revoke recording protection for conversations |



## DeleteConversationRecordingAnnotation

> void DeleteConversationRecordingAnnotation (string conversationId, string recordingId, string annotationId)


Delete annotation

Requires ANY permissions: 

* recording:annotation:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteConversationRecordingAnnotationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var recordingId = recordingId_example;  // string | Recording ID
            var annotationId = annotationId_example;  // string | Annotation ID

            try
            { 
                // Delete annotation
                apiInstance.DeleteConversationRecordingAnnotation(conversationId, recordingId, annotationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.DeleteConversationRecordingAnnotation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **recordingId** | **string**| Recording ID |  |
| **annotationId** | **string**| Annotation ID |  |

### Return type

void (empty response body)


## DeleteOrphanrecording

> [**OrphanRecording**](OrphanRecording) DeleteOrphanrecording (string orphanId)


Deletes a single orphan recording

Requires ANY permissions: 

* recording:orphan:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOrphanrecordingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var orphanId = orphanId_example;  // string | Orphan ID

            try
            { 
                // Deletes a single orphan recording
                OrphanRecording result = apiInstance.DeleteOrphanrecording(orphanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.DeleteOrphanrecording: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **orphanId** | **string**| Orphan ID |  |

### Return type

[**OrphanRecording**](OrphanRecording)


## DeleteRecordingCrossplatformMediaretentionpolicies

> void DeleteRecordingCrossplatformMediaretentionpolicies (string ids)


Delete media retention policies

Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.

Requires ANY permissions: 

* recording:crossPlatformRetentionPolicy:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRecordingCrossplatformMediaretentionpoliciesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var ids = ids_example;  // string | 

            try
            { 
                // Delete media retention policies
                apiInstance.DeleteRecordingCrossplatformMediaretentionpolicies(ids);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.DeleteRecordingCrossplatformMediaretentionpolicies: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ids** | **string**|  |  |

### Return type

void (empty response body)


## DeleteRecordingCrossplatformMediaretentionpolicy

> void DeleteRecordingCrossplatformMediaretentionpolicy (string policyId)


Delete a media retention policy

Requires ANY permissions: 

* recording:crossPlatformRetentionPolicy:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRecordingCrossplatformMediaretentionpolicyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var policyId = policyId_example;  // string | Policy ID

            try
            { 
                // Delete a media retention policy
                apiInstance.DeleteRecordingCrossplatformMediaretentionpolicy(policyId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.DeleteRecordingCrossplatformMediaretentionpolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **policyId** | **string**| Policy ID |  |

### Return type

void (empty response body)


## DeleteRecordingJob

> void DeleteRecordingJob (string jobId)


Delete the recording bulk job

Requires ALL permissions: 

* recording:job:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRecordingJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Delete the recording bulk job
                apiInstance.DeleteRecordingJob(jobId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.DeleteRecordingJob: " + e.Message );
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

void (empty response body)


## DeleteRecordingMediaretentionpolicies

> void DeleteRecordingMediaretentionpolicies (string ids)


Delete media retention policies

Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.

Requires ANY permissions: 

* recording:retentionPolicy:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRecordingMediaretentionpoliciesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var ids = ids_example;  // string | 

            try
            { 
                // Delete media retention policies
                apiInstance.DeleteRecordingMediaretentionpolicies(ids);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.DeleteRecordingMediaretentionpolicies: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ids** | **string**|  |  |

### Return type

void (empty response body)


## DeleteRecordingMediaretentionpolicy

> void DeleteRecordingMediaretentionpolicy (string policyId)


Delete a media retention policy

Requires ANY permissions: 

* recording:retentionPolicy:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRecordingMediaretentionpolicyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var policyId = policyId_example;  // string | Policy ID

            try
            { 
                // Delete a media retention policy
                apiInstance.DeleteRecordingMediaretentionpolicy(policyId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.DeleteRecordingMediaretentionpolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **policyId** | **string**| Policy ID |  |

### Return type

void (empty response body)


## GetConversationRecording

> [**Recording**](Recording) GetConversationRecording (string conversationId, string recordingId, string formatId = null, string emailFormatId = null, string chatFormatId = null, string messageFormatId = null, bool? download = null, string fileName = null, string locale = null, List<string> mediaFormats = null)


Gets a specific recording.

Requires ANY permissions: 

* recording:recording:view
* recording:recordingSegment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationRecordingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var recordingId = recordingId_example;  // string | Recording ID
            var formatId = formatId_example;  // string | The desired media format. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3,NONE (optional)  (default to WEBM)
            var emailFormatId = emailFormatId_example;  // string | The desired media format when downloading an email recording. Valid values:EML,NONE (optional)  (default to EML)
            var chatFormatId = chatFormatId_example;  // string | The desired media format when downloading a chat recording. Valid values:ZIP,NONE  (optional)  (default to ZIP)
            var messageFormatId = messageFormatId_example;  // string | The desired media format when downloading a message recording. Valid values:ZIP,NONE (optional)  (default to ZIP)
            var download = download_example;  // bool? | requesting a download format of the recording. Valid values:true,false (optional)  (default to false)
            var fileName = fileName_example;  // string | the name of the downloaded fileName (optional) 
            var locale = locale_example;  // string | The locale for the requested file when downloading or for redacting sensitive information in requested files, as an ISO 639-1 code (optional) 
            var mediaFormats = new List<string>(); // List<string> | All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3 (optional) 

            try
            { 
                // Gets a specific recording.
                Recording result = apiInstance.GetConversationRecording(conversationId, recordingId, formatId, emailFormatId, chatFormatId, messageFormatId, download, fileName, locale, mediaFormats);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetConversationRecording: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **recordingId** | **string**| Recording ID |  |
| **formatId** | **string**| The desired media format. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3,NONE | [optional] [default to WEBM]<br />**Values**: WAV, WEBM, WAV_ULAW, OGG_VORBIS, OGG_OPUS, MP3, NONE |
| **emailFormatId** | **string**| The desired media format when downloading an email recording. Valid values:EML,NONE | [optional] [default to EML]<br />**Values**: EML, NONE |
| **chatFormatId** | **string**| The desired media format when downloading a chat recording. Valid values:ZIP,NONE  | [optional] [default to ZIP]<br />**Values**: ZIP, NONE |
| **messageFormatId** | **string**| The desired media format when downloading a message recording. Valid values:ZIP,NONE | [optional] [default to ZIP]<br />**Values**: ZIP, NONE |
| **download** | **bool?**| requesting a download format of the recording. Valid values:true,false | [optional] [default to false]<br />**Values**: true, false |
| **fileName** | **string**| the name of the downloaded fileName | [optional]  |
| **locale** | **string**| The locale for the requested file when downloading or for redacting sensitive information in requested files, as an ISO 639-1 code | [optional]  |
| **mediaFormats** | [**List<string>**](string)| All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3 | [optional]  |

### Return type

[**Recording**](Recording)


## GetConversationRecordingAnnotation

> [**Annotation**](Annotation) GetConversationRecordingAnnotation (string conversationId, string recordingId, string annotationId)


Get annotation

Requires ANY permissions: 

* recording:annotation:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationRecordingAnnotationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var recordingId = recordingId_example;  // string | Recording ID
            var annotationId = annotationId_example;  // string | Annotation ID

            try
            { 
                // Get annotation
                Annotation result = apiInstance.GetConversationRecordingAnnotation(conversationId, recordingId, annotationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetConversationRecordingAnnotation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **recordingId** | **string**| Recording ID |  |
| **annotationId** | **string**| Annotation ID |  |

### Return type

[**Annotation**](Annotation)


## GetConversationRecordingAnnotations

> [**List&lt;Annotation&gt;**](Annotation) GetConversationRecordingAnnotations (string conversationId, string recordingId)


Get annotations for recording

Requires ANY permissions: 

* recording:annotation:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationRecordingAnnotationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var recordingId = recordingId_example;  // string | Recording ID

            try
            { 
                // Get annotations for recording
                List<Annotation> result = apiInstance.GetConversationRecordingAnnotations(conversationId, recordingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetConversationRecordingAnnotations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **recordingId** | **string**| Recording ID |  |

### Return type

[**List<Annotation>**](Annotation)


## GetConversationRecordingmetadata

> [**List&lt;RecordingMetadata&gt;**](RecordingMetadata) GetConversationRecordingmetadata (string conversationId)


Get recording metadata for a conversation. Does not return playable media nor system annotations. Bookmark annotations will be excluded if either recording:recording:view or recording:annotation:view permission is missing.

Requires ANY permissions: 

* recording:recording:view
* recording:recordingSegment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationRecordingmetadataExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var conversationId = conversationId_example;  // string | Conversation ID

            try
            { 
                // Get recording metadata for a conversation. Does not return playable media nor system annotations. Bookmark annotations will be excluded if either recording:recording:view or recording:annotation:view permission is missing.
                List<RecordingMetadata> result = apiInstance.GetConversationRecordingmetadata(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetConversationRecordingmetadata: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |

### Return type

[**List<RecordingMetadata>**](RecordingMetadata)


## GetConversationRecordingmetadataRecordingId

> [**RecordingMetadata**](RecordingMetadata) GetConversationRecordingmetadataRecordingId (string conversationId, string recordingId)


Get metadata for a specific recording. Does not return playable media.

Requires ANY permissions: 

* recording:recording:view
* recording:recordingSegment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationRecordingmetadataRecordingIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var recordingId = recordingId_example;  // string | Recording ID

            try
            { 
                // Get metadata for a specific recording. Does not return playable media.
                RecordingMetadata result = apiInstance.GetConversationRecordingmetadataRecordingId(conversationId, recordingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetConversationRecordingmetadataRecordingId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **recordingId** | **string**| Recording ID |  |

### Return type

[**RecordingMetadata**](RecordingMetadata)


## GetConversationRecordings

> [**List&lt;Recording&gt;**](Recording) GetConversationRecordings (string conversationId, int? maxWaitMs = null, string formatId = null, List<string> mediaFormats = null, string locale = null, bool? includePauseAnnotationsForScreenRecordings = null)


Get all of a Conversation's Recordings.

Requires ANY permissions: 

* recording:recording:view
* recording:recordingSegment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationRecordingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var maxWaitMs = 56;  // int? | The maximum number of milliseconds to wait for the recording to be ready. Must be a positive value. (optional)  (default to 5000)
            var formatId = formatId_example;  // string | The desired media format. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3,NONE. (optional)  (default to WEBM)
            var mediaFormats = new List<string>(); // List<string> | All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3. (optional) 
            var locale = locale_example;  // string | The locale used for redacting sensitive information in requested files, as an ISO 639-1 code (optional) 
            var includePauseAnnotationsForScreenRecordings = true;  // bool? | Include applicable Secure Pause annotations from all audio recordings to all screen recordings (optional)  (default to false)

            try
            { 
                // Get all of a Conversation's Recordings.
                List<Recording> result = apiInstance.GetConversationRecordings(conversationId, maxWaitMs, formatId, mediaFormats, locale, includePauseAnnotationsForScreenRecordings);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetConversationRecordings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **maxWaitMs** | **int?**| The maximum number of milliseconds to wait for the recording to be ready. Must be a positive value. | [optional] [default to 5000] |
| **formatId** | **string**| The desired media format. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3,NONE. | [optional] [default to WEBM]<br />**Values**: WAV, WEBM, WAV_ULAW, OGG_VORBIS, OGG_OPUS, MP3, NONE |
| **mediaFormats** | [**List<string>**](string)| All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3. | [optional]  |
| **locale** | **string**| The locale used for redacting sensitive information in requested files, as an ISO 639-1 code | [optional]  |
| **includePauseAnnotationsForScreenRecordings** | **bool?**| Include applicable Secure Pause annotations from all audio recordings to all screen recordings | [optional] [default to false] |

### Return type

[**List<Recording>**](Recording)


## GetOrphanrecording

> [**OrphanRecording**](OrphanRecording) GetOrphanrecording (string orphanId)


Gets a single orphan recording

Requires ANY permissions: 

* recording:orphan:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOrphanrecordingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var orphanId = orphanId_example;  // string | Orphan ID

            try
            { 
                // Gets a single orphan recording
                OrphanRecording result = apiInstance.GetOrphanrecording(orphanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetOrphanrecording: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **orphanId** | **string**| Orphan ID |  |

### Return type

[**OrphanRecording**](OrphanRecording)


## GetOrphanrecordingMedia

> [**Recording**](Recording) GetOrphanrecordingMedia (string orphanId, string formatId = null, string emailFormatId = null, string chatFormatId = null, string messageFormatId = null, bool? download = null, string fileName = null, string locale = null, List<string> mediaFormats = null)


Gets the media of a single orphan recording

A 202 response means the orphaned media is currently transcoding and will be available shortly.A 200 response denotes the transcoded orphan media is available now and is contained in the response body.

Requires ANY permissions: 

* recording:orphan:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOrphanrecordingMediaExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var orphanId = orphanId_example;  // string | Orphan ID
            var formatId = formatId_example;  // string | The desired media format. (optional)  (default to WEBM)
            var emailFormatId = emailFormatId_example;  // string | The desired media format when downloading an email recording. (optional)  (default to EML)
            var chatFormatId = chatFormatId_example;  // string | The desired media format when downloading a chat recording. (optional)  (default to ZIP)
            var messageFormatId = messageFormatId_example;  // string | The desired media format when downloading a message recording. (optional)  (default to ZIP)
            var download = download_example;  // bool? | requesting a download format of the recording (optional)  (default to false)
            var fileName = fileName_example;  // string | the name of the downloaded fileName (optional) 
            var locale = locale_example;  // string | The locale for the requested file when downloading, as an ISO 639-1 code (optional) 
            var mediaFormats = new List<string>(); // List<string> | All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3 (optional) 

            try
            { 
                // Gets the media of a single orphan recording
                Recording result = apiInstance.GetOrphanrecordingMedia(orphanId, formatId, emailFormatId, chatFormatId, messageFormatId, download, fileName, locale, mediaFormats);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetOrphanrecordingMedia: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **orphanId** | **string**| Orphan ID |  |
| **formatId** | **string**| The desired media format. | [optional] [default to WEBM]<br />**Values**: WAV, WEBM, WAV_ULAW, OGG_VORBIS, OGG_OPUS, MP3, NONE |
| **emailFormatId** | **string**| The desired media format when downloading an email recording. | [optional] [default to EML]<br />**Values**: EML, NONE |
| **chatFormatId** | **string**| The desired media format when downloading a chat recording. | [optional] [default to ZIP]<br />**Values**: ZIP, NONE |
| **messageFormatId** | **string**| The desired media format when downloading a message recording. | [optional] [default to ZIP]<br />**Values**: ZIP, NONE |
| **download** | **bool?**| requesting a download format of the recording | [optional] [default to false]<br />**Values**: true, false |
| **fileName** | **string**| the name of the downloaded fileName | [optional]  |
| **locale** | **string**| The locale for the requested file when downloading, as an ISO 639-1 code | [optional]  |
| **mediaFormats** | [**List<string>**](string)| All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3 | [optional]  |

### Return type

[**Recording**](Recording)


## GetOrphanrecordings

> [**OrphanRecordingListing**](OrphanRecordingListing) GetOrphanrecordings (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, bool? hasConversation = null, string media = null)


Gets all orphan recordings

Requires ANY permissions: 

* recording:orphan:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOrphanrecordingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            var hasConversation = true;  // bool? | Filter resulting orphans by whether the conversation is known. False returns all orphans for the organization. (optional)  (default to false)
            var media = media_example;  // string | Filter resulting orphans based on their media type (optional) 

            try
            { 
                // Gets all orphan recordings
                OrphanRecordingListing result = apiInstance.GetOrphanrecordings(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, hasConversation, media);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetOrphanrecordings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<string>**](string)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **hasConversation** | **bool?**| Filter resulting orphans by whether the conversation is known. False returns all orphans for the organization. | [optional] [default to false] |
| **media** | **string**| Filter resulting orphans based on their media type | [optional] <br />**Values**: Call, Screen |

### Return type

[**OrphanRecordingListing**](OrphanRecordingListing)


## GetRecordingBatchrequest

> [**BatchDownloadJobStatusResult**](BatchDownloadJobStatusResult) GetRecordingBatchrequest (string jobId)


Get the status and results for a batch request job, only the user that submitted the job may retrieve results. Each result may contain either a URL to a recording or an error; additionally, a recording could be associated with multiple results.

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
    public class GetRecordingBatchrequestExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get the status and results for a batch request job, only the user that submitted the job may retrieve results. Each result may contain either a URL to a recording or an error; additionally, a recording could be associated with multiple results.
                BatchDownloadJobStatusResult result = apiInstance.GetRecordingBatchrequest(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetRecordingBatchrequest: " + e.Message );
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

[**BatchDownloadJobStatusResult**](BatchDownloadJobStatusResult)


## GetRecordingCrossplatformMediaretentionpolicies

> [**PolicyEntityListing**](PolicyEntityListing) GetRecordingCrossplatformMediaretentionpolicies (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null, int? deleteDaysThreshold = null)


Gets media retention policy list with query options to filter on name and enabled.

for a less verbose response, add summary=true to this endpoint

Requires ANY permissions: 

* recording:crossPlatformRetentionPolicy:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRecordingCrossplatformMediaretentionpoliciesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            var name = name_example;  // string | the policy name - used for filtering results in searches. (optional) 
            var enabled = true;  // bool? | checks to see if policy is enabled - use enabled = true or enabled = false (optional) 
            var summary = true;  // bool? | provides a less verbose response of policy lists. (optional)  (default to false)
            var hasErrors = true;  // bool? | provides a way to fetch all policies with errors or policies that do not have errors (optional) 
            var deleteDaysThreshold = 56;  // int? | provides a way to fetch all policies with any actions having deleteDays exceeding the provided value (optional) 

            try
            { 
                // Gets media retention policy list with query options to filter on name and enabled.
                PolicyEntityListing result = apiInstance.GetRecordingCrossplatformMediaretentionpolicies(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, name, enabled, summary, hasErrors, deleteDaysThreshold);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetRecordingCrossplatformMediaretentionpolicies: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<string>**](string)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **name** | **string**| the policy name - used for filtering results in searches. | [optional]  |
| **enabled** | **bool?**| checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false | [optional]  |
| **summary** | **bool?**| provides a less verbose response of policy lists. | [optional] [default to false] |
| **hasErrors** | **bool?**| provides a way to fetch all policies with errors or policies that do not have errors | [optional]  |
| **deleteDaysThreshold** | **int?**| provides a way to fetch all policies with any actions having deleteDays exceeding the provided value | [optional]  |

### Return type

[**PolicyEntityListing**](PolicyEntityListing)


## GetRecordingCrossplatformMediaretentionpolicy

> [**CrossPlatformPolicy**](CrossPlatformPolicy) GetRecordingCrossplatformMediaretentionpolicy (string policyId)


Get a media retention policy

Requires ANY permissions: 

* recording:crossPlatformRetentionPolicy:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRecordingCrossplatformMediaretentionpolicyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var policyId = policyId_example;  // string | Policy ID

            try
            { 
                // Get a media retention policy
                CrossPlatformPolicy result = apiInstance.GetRecordingCrossplatformMediaretentionpolicy(policyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetRecordingCrossplatformMediaretentionpolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **policyId** | **string**| Policy ID |  |

### Return type

[**CrossPlatformPolicy**](CrossPlatformPolicy)


## GetRecordingJob

> [**RecordingJob**](RecordingJob) GetRecordingJob (string jobId)


Get the status of the job associated with the job id.

Requires ALL permissions: 

* recording:job:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRecordingJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get the status of the job associated with the job id.
                RecordingJob result = apiInstance.GetRecordingJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetRecordingJob: " + e.Message );
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

[**RecordingJob**](RecordingJob)


## GetRecordingJobFailedrecordings

> [**FailedRecordingEntityListing**](FailedRecordingEntityListing) GetRecordingJobFailedrecordings (string jobId, int? pageSize = null, int? pageNumber = null, bool? includeTotal = null, string cursor = null)


Get IDs of recordings that the bulk job failed for

Requires ALL permissions: 

* recording:job:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRecordingJobFailedrecordingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var jobId = jobId_example;  // string | jobId
            var pageSize = 56;  // int? | Page size. Maximum is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var includeTotal = true;  // bool? | If false, cursor will be used to locate the page instead of pageNumber. It is recommended to set it to false for improved performance. (optional) 
            var cursor = cursor_example;  // string | Indicates where to resume query results (not required for first page) (optional) 

            try
            { 
                // Get IDs of recordings that the bulk job failed for
                FailedRecordingEntityListing result = apiInstance.GetRecordingJobFailedrecordings(jobId, pageSize, pageNumber, includeTotal, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetRecordingJobFailedrecordings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
| **pageSize** | **int?**| Page size. Maximum is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **includeTotal** | **bool?**| If false, cursor will be used to locate the page instead of pageNumber. It is recommended to set it to false for improved performance. | [optional]  |
| **cursor** | **string**| Indicates where to resume query results (not required for first page) | [optional]  |

### Return type

[**FailedRecordingEntityListing**](FailedRecordingEntityListing)


## GetRecordingJobs

> [**RecordingJobEntityListing**](RecordingJobEntityListing) GetRecordingJobs (int? pageSize = null, int? pageNumber = null, string sortBy = null, string state = null, bool? showOnlyMyJobs = null, string jobType = null, bool? includeTotal = null, string cursor = null)


Get the status of all jobs within the user's organization

Requires ALL permissions: 

* recording:job:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRecordingJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to userId)
            var state = state_example;  // string | Filter by state (optional) 
            var showOnlyMyJobs = true;  // bool? | Show only my jobs (optional) 
            var jobType = jobType_example;  // string | Job Type (Can be left empty for both) (optional) 
            var includeTotal = true;  // bool? | If false, cursor will be used to locate the page instead of pageNumber. It is recommended to set it to false for improved performance. (optional) 
            var cursor = cursor_example;  // string | Indicates where to resume query results (not required for first page) (optional) 

            try
            { 
                // Get the status of all jobs within the user's organization
                RecordingJobEntityListing result = apiInstance.GetRecordingJobs(pageSize, pageNumber, sortBy, state, showOnlyMyJobs, jobType, includeTotal, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetRecordingJobs: " + e.Message );
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
| **sortBy** | **string**| Sort by | [optional] [default to userId]<br />**Values**: userId, dateCreated |
| **state** | **string**| Filter by state | [optional] <br />**Values**: FULFILLED, PENDING, READY, PROCESSING, CANCELLED, FAILED |
| **showOnlyMyJobs** | **bool?**| Show only my jobs | [optional]  |
| **jobType** | **string**| Job Type (Can be left empty for both) | [optional] <br />**Values**: ARCHIVE, DELETE, EXPORT |
| **includeTotal** | **bool?**| If false, cursor will be used to locate the page instead of pageNumber. It is recommended to set it to false for improved performance. | [optional]  |
| **cursor** | **string**| Indicates where to resume query results (not required for first page) | [optional]  |

### Return type

[**RecordingJobEntityListing**](RecordingJobEntityListing)


## GetRecordingKeyconfiguration

> [**RecordingEncryptionConfiguration**](RecordingEncryptionConfiguration) GetRecordingKeyconfiguration (string keyConfigurationId)


Get the encryption key configurations

Requires ANY permissions: 

* recording:encryptionKey:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRecordingKeyconfigurationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var keyConfigurationId = keyConfigurationId_example;  // string | Key Configurations Id

            try
            { 
                // Get the encryption key configurations
                RecordingEncryptionConfiguration result = apiInstance.GetRecordingKeyconfiguration(keyConfigurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetRecordingKeyconfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **keyConfigurationId** | **string**| Key Configurations Id |  |

### Return type

[**RecordingEncryptionConfiguration**](RecordingEncryptionConfiguration)


## GetRecordingKeyconfigurations

> [**RecordingEncryptionConfigurationListing**](RecordingEncryptionConfigurationListing) GetRecordingKeyconfigurations ()


Get a list of key configurations data

Requires ANY permissions: 

* recording:encryptionKey:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRecordingKeyconfigurationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();

            try
            { 
                // Get a list of key configurations data
                RecordingEncryptionConfigurationListing result = apiInstance.GetRecordingKeyconfigurations();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetRecordingKeyconfigurations: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**RecordingEncryptionConfigurationListing**](RecordingEncryptionConfigurationListing)


## GetRecordingMediaretentionpolicies

> [**PolicyEntityListing**](PolicyEntityListing) GetRecordingMediaretentionpolicies (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null, int? deleteDaysThreshold = null)


Gets media retention policy list with query options to filter on name and enabled.

for a less verbose response, add summary=true to this endpoint

Requires ANY permissions: 

* recording:retentionPolicy:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRecordingMediaretentionpoliciesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            var name = name_example;  // string | the policy name - used for filtering results in searches. (optional) 
            var enabled = true;  // bool? | checks to see if policy is enabled - use enabled = true or enabled = false (optional) 
            var summary = true;  // bool? | provides a less verbose response of policy lists. (optional)  (default to false)
            var hasErrors = true;  // bool? | provides a way to fetch all policies with errors or policies that do not have errors (optional) 
            var deleteDaysThreshold = 56;  // int? | provides a way to fetch all policies with any actions having deleteDays exceeding the provided value (optional) 

            try
            { 
                // Gets media retention policy list with query options to filter on name and enabled.
                PolicyEntityListing result = apiInstance.GetRecordingMediaretentionpolicies(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, name, enabled, summary, hasErrors, deleteDaysThreshold);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetRecordingMediaretentionpolicies: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<string>**](string)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **name** | **string**| the policy name - used for filtering results in searches. | [optional]  |
| **enabled** | **bool?**| checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false | [optional]  |
| **summary** | **bool?**| provides a less verbose response of policy lists. | [optional] [default to false] |
| **hasErrors** | **bool?**| provides a way to fetch all policies with errors or policies that do not have errors | [optional]  |
| **deleteDaysThreshold** | **int?**| provides a way to fetch all policies with any actions having deleteDays exceeding the provided value | [optional]  |

### Return type

[**PolicyEntityListing**](PolicyEntityListing)


## GetRecordingMediaretentionpolicy

> [**Policy**](Policy) GetRecordingMediaretentionpolicy (string policyId)


Get a media retention policy

Requires ANY permissions: 

* recording:retentionPolicy:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRecordingMediaretentionpolicyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var policyId = policyId_example;  // string | Policy ID

            try
            { 
                // Get a media retention policy
                Policy result = apiInstance.GetRecordingMediaretentionpolicy(policyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetRecordingMediaretentionpolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **policyId** | **string**| Policy ID |  |

### Return type

[**Policy**](Policy)


## GetRecordingRecordingkeys

> [**EncryptionKeyEntityListing**](EncryptionKeyEntityListing) GetRecordingRecordingkeys (int? pageSize = null, int? pageNumber = null)


Get encryption key list

Requires ANY permissions: 

* recording:encryptionKey:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRecordingRecordingkeysExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get encryption key list
                EncryptionKeyEntityListing result = apiInstance.GetRecordingRecordingkeys(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetRecordingRecordingkeys: " + e.Message );
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

[**EncryptionKeyEntityListing**](EncryptionKeyEntityListing)


## GetRecordingRecordingkeysRotationschedule

> [**KeyRotationSchedule**](KeyRotationSchedule) GetRecordingRecordingkeysRotationschedule ()


Get key rotation schedule

Requires ANY permissions: 

* recording:encryptionKey:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRecordingRecordingkeysRotationscheduleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();

            try
            { 
                // Get key rotation schedule
                KeyRotationSchedule result = apiInstance.GetRecordingRecordingkeysRotationschedule();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetRecordingRecordingkeysRotationschedule: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**KeyRotationSchedule**](KeyRotationSchedule)


## GetRecordingSettings

> [**RecordingSettings**](RecordingSettings) GetRecordingSettings (bool? createDefault = null)


Get the Recording Settings for the Organization

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
    public class GetRecordingSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var createDefault = true;  // bool? | If no settings are found, a new one is created with default values (optional)  (default to false)

            try
            { 
                // Get the Recording Settings for the Organization
                RecordingSettings result = apiInstance.GetRecordingSettings(createDefault);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetRecordingSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **createDefault** | **bool?**| If no settings are found, a new one is created with default values | [optional] [default to false] |

### Return type

[**RecordingSettings**](RecordingSettings)


## GetRecordingUploadsReport

> [**RecordingUploadReport**](RecordingUploadReport) GetRecordingUploadsReport (string reportId)


Get the status of a recording upload status report

Requires ALL permissions: 

* recording:uploadReport:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRecordingUploadsReportExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var reportId = reportId_example;  // string | reportId

            try
            { 
                // Get the status of a recording upload status report
                RecordingUploadReport result = apiInstance.GetRecordingUploadsReport(reportId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetRecordingUploadsReport: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **reportId** | **string**| reportId |  |

### Return type

[**RecordingUploadReport**](RecordingUploadReport)


## GetRecordingsRetentionQuery

> [**RecordingRetentionCursorEntityListing**](RecordingRetentionCursorEntityListing) GetRecordingsRetentionQuery (int? retentionThresholdDays, string cursor = null, int? pageSize = null)


Query for recording retention data

Requires ANY permissions: 

* recording:recording:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRecordingsRetentionQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var retentionThresholdDays = 56;  // int? | Fetch retention data for recordings retained for more days than the provided value.
            var cursor = cursor_example;  // string | Indicates where to resume query results (not required for first page) (optional) 
            var pageSize = 56;  // int? | Page size. Maximum is 500. (optional)  (default to 25)

            try
            { 
                // Query for recording retention data
                RecordingRetentionCursorEntityListing result = apiInstance.GetRecordingsRetentionQuery(retentionThresholdDays, cursor, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetRecordingsRetentionQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **retentionThresholdDays** | **int?**| Fetch retention data for recordings retained for more days than the provided value. |  |
| **cursor** | **string**| Indicates where to resume query results (not required for first page) | [optional]  |
| **pageSize** | **int?**| Page size. Maximum is 500. | [optional] [default to 25] |

### Return type

[**RecordingRetentionCursorEntityListing**](RecordingRetentionCursorEntityListing)


## GetRecordingsScreensessionsDetails

> [**ScreenRecordingActiveSessions**](ScreenRecordingActiveSessions) GetRecordingsScreensessionsDetails ()


Retrieves an object containing the total number of concurrent active screen recordings

Requires ANY permissions: 

* recording:screenRecording:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRecordingsScreensessionsDetailsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();

            try
            { 
                // Retrieves an object containing the total number of concurrent active screen recordings
                ScreenRecordingActiveSessions result = apiInstance.GetRecordingsScreensessionsDetails();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetRecordingsScreensessionsDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**ScreenRecordingActiveSessions**](ScreenRecordingActiveSessions)


## PatchRecordingCrossplatformMediaretentionpolicy

> [**CrossPlatformPolicy**](CrossPlatformPolicy) PatchRecordingCrossplatformMediaretentionpolicy (string policyId, CrossPlatformPolicyUpdate body)


Patch a media retention policy

Requires ANY permissions: 

* recording:crossPlatformRetentionPolicy:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchRecordingCrossplatformMediaretentionpolicyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var policyId = policyId_example;  // string | Policy ID
            var body = new CrossPlatformPolicyUpdate(); // CrossPlatformPolicyUpdate | Policy

            try
            { 
                // Patch a media retention policy
                CrossPlatformPolicy result = apiInstance.PatchRecordingCrossplatformMediaretentionpolicy(policyId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PatchRecordingCrossplatformMediaretentionpolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **policyId** | **string**| Policy ID |  |
| **body** | [**CrossPlatformPolicyUpdate**](CrossPlatformPolicyUpdate)| Policy |  |

### Return type

[**CrossPlatformPolicy**](CrossPlatformPolicy)


## PatchRecordingMediaretentionpolicy

> [**Policy**](Policy) PatchRecordingMediaretentionpolicy (string policyId, PolicyUpdate body)


Patch a media retention policy

Requires ANY permissions: 

* recording:retentionPolicy:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchRecordingMediaretentionpolicyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var policyId = policyId_example;  // string | Policy ID
            var body = new PolicyUpdate(); // PolicyUpdate | Policy

            try
            { 
                // Patch a media retention policy
                Policy result = apiInstance.PatchRecordingMediaretentionpolicy(policyId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PatchRecordingMediaretentionpolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **policyId** | **string**| Policy ID |  |
| **body** | [**PolicyUpdate**](PolicyUpdate)| Policy |  |

### Return type

[**Policy**](Policy)


## PostConversationRecordingAnnotations

> [**Annotation**](Annotation) PostConversationRecordingAnnotations (string conversationId, string recordingId, Annotation body)


Create annotation

Requires ANY permissions: 

* recording:annotation:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationRecordingAnnotationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var recordingId = recordingId_example;  // string | Recording ID
            var body = new Annotation(); // Annotation | annotation

            try
            { 
                // Create annotation
                Annotation result = apiInstance.PostConversationRecordingAnnotations(conversationId, recordingId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PostConversationRecordingAnnotations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **recordingId** | **string**| Recording ID |  |
| **body** | [**Annotation**](Annotation)| annotation |  |

### Return type

[**Annotation**](Annotation)


## PostRecordingBatchrequests

> [**BatchDownloadJobSubmissionResult**](BatchDownloadJobSubmissionResult) PostRecordingBatchrequests (BatchDownloadJobSubmission body)


Submit a batch download request for recordings. Recordings in response will be in their original format/codec - configured in the Trunk configuration.

Requires ANY permissions: 

* recording:recording:view
* recording:recordingSegment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRecordingBatchrequestsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var body = new BatchDownloadJobSubmission(); // BatchDownloadJobSubmission | Job submission criteria

            try
            { 
                // Submit a batch download request for recordings. Recordings in response will be in their original format/codec - configured in the Trunk configuration.
                BatchDownloadJobSubmissionResult result = apiInstance.PostRecordingBatchrequests(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PostRecordingBatchrequests: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**BatchDownloadJobSubmission**](BatchDownloadJobSubmission)| Job submission criteria |  |

### Return type

[**BatchDownloadJobSubmissionResult**](BatchDownloadJobSubmissionResult)


## PostRecordingCrossplatformMediaretentionpolicies

> [**CrossPlatformPolicy**](CrossPlatformPolicy) PostRecordingCrossplatformMediaretentionpolicies (CrossPlatformPolicyCreate body)


Create media retention policy

Policy does not work retroactively

Requires ANY permissions: 

* recording:crossPlatformRetentionPolicy:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRecordingCrossplatformMediaretentionpoliciesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var body = new CrossPlatformPolicyCreate(); // CrossPlatformPolicyCreate | Policy

            try
            { 
                // Create media retention policy
                CrossPlatformPolicy result = apiInstance.PostRecordingCrossplatformMediaretentionpolicies(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PostRecordingCrossplatformMediaretentionpolicies: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CrossPlatformPolicyCreate**](CrossPlatformPolicyCreate)| Policy |  |

### Return type

[**CrossPlatformPolicy**](CrossPlatformPolicy)


## PostRecordingJobs

> [**RecordingJob**](RecordingJob) PostRecordingJobs (RecordingJobsQuery body)


Create a recording bulk job.

Each organization can run up to a maximum of two concurrent jobs that are either in pending or processing state. Furthermore, the recording:recording:viewSensitiveData permission is required to access recordings with PCI DSS and/or PII data when redaction is enabled for their organization. If the requester does not have that permission and includeRecordingsWithSensitiveData is set to true, then their request will be rejected. It is recommended to query over smaller time periods so your request does not time out.

Requires ALL permissions: 

* recording:job:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRecordingJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var body = new RecordingJobsQuery(); // RecordingJobsQuery | query

            try
            { 
                // Create a recording bulk job.
                RecordingJob result = apiInstance.PostRecordingJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PostRecordingJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**RecordingJobsQuery**](RecordingJobsQuery)| query |  |

### Return type

[**RecordingJob**](RecordingJob)


## PostRecordingKeyconfigurations

> [**RecordingEncryptionConfiguration**](RecordingEncryptionConfiguration) PostRecordingKeyconfigurations (RecordingEncryptionConfiguration body)


Setup configurations for encryption key creation

Requires ANY permissions: 

* recording:encryptionKey:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRecordingKeyconfigurationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var body = new RecordingEncryptionConfiguration(); // RecordingEncryptionConfiguration | Encryption Configuration

            try
            { 
                // Setup configurations for encryption key creation
                RecordingEncryptionConfiguration result = apiInstance.PostRecordingKeyconfigurations(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PostRecordingKeyconfigurations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**RecordingEncryptionConfiguration**](RecordingEncryptionConfiguration)| Encryption Configuration |  |

### Return type

[**RecordingEncryptionConfiguration**](RecordingEncryptionConfiguration)


## PostRecordingKeyconfigurationsValidate

> [**RecordingEncryptionConfiguration**](RecordingEncryptionConfiguration) PostRecordingKeyconfigurationsValidate (RecordingEncryptionConfiguration body)


Validate encryption key configurations without saving it

Requires ANY permissions: 

* recording:encryptionKey:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRecordingKeyconfigurationsValidateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var body = new RecordingEncryptionConfiguration(); // RecordingEncryptionConfiguration | Encryption Configuration

            try
            { 
                // Validate encryption key configurations without saving it
                RecordingEncryptionConfiguration result = apiInstance.PostRecordingKeyconfigurationsValidate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PostRecordingKeyconfigurationsValidate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**RecordingEncryptionConfiguration**](RecordingEncryptionConfiguration)| Encryption Configuration |  |

### Return type

[**RecordingEncryptionConfiguration**](RecordingEncryptionConfiguration)


## PostRecordingLocalkeys

> [**EncryptionKey**](EncryptionKey) PostRecordingLocalkeys (LocalEncryptionKeyRequest body)


create a local key management recording key

Requires ANY permissions: 

* recording:encryptionKey:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRecordingLocalkeysExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var body = new LocalEncryptionKeyRequest(); // LocalEncryptionKeyRequest | Local Encryption body

            try
            { 
                // create a local key management recording key
                EncryptionKey result = apiInstance.PostRecordingLocalkeys(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PostRecordingLocalkeys: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**LocalEncryptionKeyRequest**](LocalEncryptionKeyRequest)| Local Encryption body |  |

### Return type

[**EncryptionKey**](EncryptionKey)


## PostRecordingMediaretentionpolicies

> [**Policy**](Policy) PostRecordingMediaretentionpolicies (PolicyCreate body)


Create media retention policy

Policy does not work retroactively

Requires ANY permissions: 

* recording:retentionPolicy:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRecordingMediaretentionpoliciesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var body = new PolicyCreate(); // PolicyCreate | Policy

            try
            { 
                // Create media retention policy
                Policy result = apiInstance.PostRecordingMediaretentionpolicies(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PostRecordingMediaretentionpolicies: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**PolicyCreate**](PolicyCreate)| Policy |  |

### Return type

[**Policy**](Policy)


## PostRecordingRecordingkeys

> [**EncryptionKey**](EncryptionKey) PostRecordingRecordingkeys ()


Create encryption key

Requires ANY permissions: 

* recording:encryptionKey:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRecordingRecordingkeysExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();

            try
            { 
                // Create encryption key
                EncryptionKey result = apiInstance.PostRecordingRecordingkeys();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PostRecordingRecordingkeys: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**EncryptionKey**](EncryptionKey)


## PostRecordingUploadsReports

> [**RecordingUploadReport**](RecordingUploadReport) PostRecordingUploadsReports (RecordingUploadReportRequest body)


Creates a recording upload status report

Requires ALL permissions: 

* recording:uploadReport:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRecordingUploadsReportsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var body = new RecordingUploadReportRequest(); // RecordingUploadReportRequest | Report parameters

            try
            { 
                // Creates a recording upload status report
                RecordingUploadReport result = apiInstance.PostRecordingUploadsReports(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PostRecordingUploadsReports: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**RecordingUploadReportRequest**](RecordingUploadReportRequest)| Report parameters |  |

### Return type

[**RecordingUploadReport**](RecordingUploadReport)


## PostRecordingsDeletionprotection

> [**List&lt;AddressableEntityRef&gt;**](AddressableEntityRef) PostRecordingsDeletionprotection (ConversationDeletionProtectionQuery body)


Get a list of conversations with protected recordings

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
    public class PostRecordingsDeletionprotectionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var body = new ConversationDeletionProtectionQuery(); // ConversationDeletionProtectionQuery | conversationIds

            try
            { 
                // Get a list of conversations with protected recordings
                List<AddressableEntityRef> result = apiInstance.PostRecordingsDeletionprotection(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PostRecordingsDeletionprotection: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ConversationDeletionProtectionQuery**](ConversationDeletionProtectionQuery)| conversationIds |  |

### Return type

[**List<AddressableEntityRef>**](AddressableEntityRef)


## PostRecordingsScreensessionsAcknowledge

> void PostRecordingsScreensessionsAcknowledge (AcknowledgeScreenRecordingRequest body)


Acknowledge a screen recording.

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
    public class PostRecordingsScreensessionsAcknowledgeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var body = new AcknowledgeScreenRecordingRequest(); // AcknowledgeScreenRecordingRequest | AcknowledgeScreenRecordingRequest

            try
            { 
                // Acknowledge a screen recording.
                apiInstance.PostRecordingsScreensessionsAcknowledge(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PostRecordingsScreensessionsAcknowledge: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AcknowledgeScreenRecordingRequest**](AcknowledgeScreenRecordingRequest)| AcknowledgeScreenRecordingRequest |  |

### Return type

void (empty response body)


## PostRecordingsScreensessionsMetadata

> void PostRecordingsScreensessionsMetadata (ScreenRecordingMetaDataRequest body)


Provide meta-data a screen recording.

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
    public class PostRecordingsScreensessionsMetadataExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var body = new ScreenRecordingMetaDataRequest(); // ScreenRecordingMetaDataRequest | ScreenRecordingMetaDataRequest

            try
            { 
                // Provide meta-data a screen recording.
                apiInstance.PostRecordingsScreensessionsMetadata(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PostRecordingsScreensessionsMetadata: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ScreenRecordingMetaDataRequest**](ScreenRecordingMetaDataRequest)| ScreenRecordingMetaDataRequest |  |

### Return type

void (empty response body)


## PutConversationRecording

> [**Recording**](Recording) PutConversationRecording (string conversationId, string recordingId, Recording body, bool? clearExport = null)


Updates the retention records on a recording.

Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. The recording:recording:view permission is required for the recording, as well as either the recording:recording:editRetention or recording:screenRecording:editRetention permissions depending on the type of recording.

Requires ANY permissions: 

* recording:recording:view
* recording:recording:editRetention
* recording:screenRecording:editRetention

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationRecordingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var recordingId = recordingId_example;  // string | Recording ID
            var body = new Recording(); // Recording | recording
            var clearExport = true;  // bool? | Whether to clear the pending export for the recording (optional) 

            try
            { 
                // Updates the retention records on a recording.
                Recording result = apiInstance.PutConversationRecording(conversationId, recordingId, body, clearExport);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PutConversationRecording: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **recordingId** | **string**| Recording ID |  |
| **body** | [**Recording**](Recording)| recording |  |
| **clearExport** | **bool?**| Whether to clear the pending export for the recording | [optional]  |

### Return type

[**Recording**](Recording)


## PutConversationRecordingAnnotation

> [**Annotation**](Annotation) PutConversationRecordingAnnotation (string conversationId, string recordingId, string annotationId, Annotation body)


Update annotation

Requires ANY permissions: 

* recording:annotation:edit
* recording:recording:view
* recording:recordingSegment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationRecordingAnnotationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var recordingId = recordingId_example;  // string | Recording ID
            var annotationId = annotationId_example;  // string | Annotation ID
            var body = new Annotation(); // Annotation | annotation

            try
            { 
                // Update annotation
                Annotation result = apiInstance.PutConversationRecordingAnnotation(conversationId, recordingId, annotationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PutConversationRecordingAnnotation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **recordingId** | **string**| Recording ID |  |
| **annotationId** | **string**| Annotation ID |  |
| **body** | [**Annotation**](Annotation)| annotation |  |

### Return type

[**Annotation**](Annotation)


## PutOrphanrecording

> [**Recording**](Recording) PutOrphanrecording (string orphanId, OrphanUpdateRequest body = null)


Updates an orphan recording to a regular recording with retention values

If this operation is successful the orphan will no longer exist. It will be replaced by the resulting recording in the response. This replacement recording is accessible by the normal Recording api.

Requires ANY permissions: 

* recording:orphan:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOrphanrecordingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var orphanId = orphanId_example;  // string | Orphan ID
            var body = new OrphanUpdateRequest(); // OrphanUpdateRequest |  (optional) 

            try
            { 
                // Updates an orphan recording to a regular recording with retention values
                Recording result = apiInstance.PutOrphanrecording(orphanId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PutOrphanrecording: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **orphanId** | **string**| Orphan ID |  |
| **body** | [**OrphanUpdateRequest**](OrphanUpdateRequest)|  | [optional]  |

### Return type

[**Recording**](Recording)


## PutRecordingCrossplatformMediaretentionpolicy

> [**CrossPlatformPolicy**](CrossPlatformPolicy) PutRecordingCrossplatformMediaretentionpolicy (string policyId, CrossPlatformPolicy body)


Update a media retention policy

Policy does not work retroactively

Requires ANY permissions: 

* recording:crossPlatformRetentionPolicy:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutRecordingCrossplatformMediaretentionpolicyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var policyId = policyId_example;  // string | Policy ID
            var body = new CrossPlatformPolicy(); // CrossPlatformPolicy | Policy

            try
            { 
                // Update a media retention policy
                CrossPlatformPolicy result = apiInstance.PutRecordingCrossplatformMediaretentionpolicy(policyId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PutRecordingCrossplatformMediaretentionpolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **policyId** | **string**| Policy ID |  |
| **body** | [**CrossPlatformPolicy**](CrossPlatformPolicy)| Policy |  |

### Return type

[**CrossPlatformPolicy**](CrossPlatformPolicy)


## PutRecordingJob

> [**RecordingJob**](RecordingJob) PutRecordingJob (string jobId, ExecuteRecordingJobsQuery body)


Execute the recording bulk job.

Each organization can run up to a maximum of two concurrent jobs that are either in pending or processing state. A job must be executed by the same user whom originally created the job.  In addition, the user must have permission to update the recording's retention.

Requires ALL permissions: 

* recording:job:edit
* recording:recording:editRetention
* recording:screenRecording:editRetention

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutRecordingJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var jobId = jobId_example;  // string | jobId
            var body = new ExecuteRecordingJobsQuery(); // ExecuteRecordingJobsQuery | query

            try
            { 
                // Execute the recording bulk job.
                RecordingJob result = apiInstance.PutRecordingJob(jobId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PutRecordingJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
| **body** | [**ExecuteRecordingJobsQuery**](ExecuteRecordingJobsQuery)| query |  |

### Return type

[**RecordingJob**](RecordingJob)


## PutRecordingKeyconfiguration

> [**RecordingEncryptionConfiguration**](RecordingEncryptionConfiguration) PutRecordingKeyconfiguration (string keyConfigurationId, RecordingEncryptionConfiguration body)


Update the encryption key configurations

Requires ANY permissions: 

* recording:encryptionKey:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutRecordingKeyconfigurationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var keyConfigurationId = keyConfigurationId_example;  // string | Key Configurations Id
            var body = new RecordingEncryptionConfiguration(); // RecordingEncryptionConfiguration | Encryption key configuration metadata

            try
            { 
                // Update the encryption key configurations
                RecordingEncryptionConfiguration result = apiInstance.PutRecordingKeyconfiguration(keyConfigurationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PutRecordingKeyconfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **keyConfigurationId** | **string**| Key Configurations Id |  |
| **body** | [**RecordingEncryptionConfiguration**](RecordingEncryptionConfiguration)| Encryption key configuration metadata |  |

### Return type

[**RecordingEncryptionConfiguration**](RecordingEncryptionConfiguration)


## PutRecordingMediaretentionpolicy

> [**Policy**](Policy) PutRecordingMediaretentionpolicy (string policyId, Policy body)


Update a media retention policy

Policy does not work retroactively. In the conditions.forUsers section, each user object can include the 'id' field containing the user's unique identifier. Example: [{\"id\":\"<userId>\"}].

Requires ANY permissions: 

* recording:retentionPolicy:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutRecordingMediaretentionpolicyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var policyId = policyId_example;  // string | Policy ID
            var body = new Policy(); // Policy | Policy

            try
            { 
                // Update a media retention policy
                Policy result = apiInstance.PutRecordingMediaretentionpolicy(policyId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PutRecordingMediaretentionpolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **policyId** | **string**| Policy ID |  |
| **body** | [**Policy**](Policy)| Policy |  |

### Return type

[**Policy**](Policy)


## PutRecordingRecordingkeysRotationschedule

> [**KeyRotationSchedule**](KeyRotationSchedule) PutRecordingRecordingkeysRotationschedule (KeyRotationSchedule body)


Update key rotation schedule

Requires ANY permissions: 

* recording:encryptionKey:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutRecordingRecordingkeysRotationscheduleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var body = new KeyRotationSchedule(); // KeyRotationSchedule | KeyRotationSchedule

            try
            { 
                // Update key rotation schedule
                KeyRotationSchedule result = apiInstance.PutRecordingRecordingkeysRotationschedule(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PutRecordingRecordingkeysRotationschedule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**KeyRotationSchedule**](KeyRotationSchedule)| KeyRotationSchedule |  |

### Return type

[**KeyRotationSchedule**](KeyRotationSchedule)


## PutRecordingSettings

> [**RecordingSettings**](RecordingSettings) PutRecordingSettings (RecordingSettings body)


Update the Recording Settings for the Organization

Requires ANY permissions: 

* recording:settings:editScreenRecordings
* recording:settings:editRegionalStorage
* recording:settings:editUrlExpiration

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutRecordingSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var body = new RecordingSettings(); // RecordingSettings | Recording settings

            try
            { 
                // Update the Recording Settings for the Organization
                RecordingSettings result = apiInstance.PutRecordingSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PutRecordingSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**RecordingSettings**](RecordingSettings)| Recording settings |  |

### Return type

[**RecordingSettings**](RecordingSettings)


## PutRecordingsDeletionprotection

> void PutRecordingsDeletionprotection (bool? protect = null, ConversationDeletionProtectionQuery body = null)


Apply or revoke recording protection for conversations

Requires ANY permissions: 

* recording:deletionProtection:apply
* recording:deletionProtection:revoke

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutRecordingsDeletionprotectionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RecordingApi();
            var protect = true;  // bool? | Check for apply, uncheck for revoke (each action requires the respective permission) (optional)  (default to true)
            var body = new ConversationDeletionProtectionQuery(); // ConversationDeletionProtectionQuery |  (optional) 

            try
            { 
                // Apply or revoke recording protection for conversations
                apiInstance.PutRecordingsDeletionprotection(protect, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PutRecordingsDeletionprotection: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **protect** | **bool?**| Check for apply, uncheck for revoke (each action requires the respective permission) | [optional] [default to true] |
| **body** | [**ConversationDeletionProtectionQuery**](ConversationDeletionProtectionQuery)|  | [optional]  |

### Return type

void (empty response body)


_PureCloudPlatform.Client.V2 244.0.0_
