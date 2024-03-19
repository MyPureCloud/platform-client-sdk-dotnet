---
title: RecordingApi
---
## PureCloudPlatform.Client.V2.Api.RecordingApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteConversationRecordingAnnotation**](RecordingApi.html#deleteconversationrecordingannotation) | **Delete** /api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId} | Delete annotation |
| [**DeleteOrphanrecording**](RecordingApi.html#deleteorphanrecording) | **Delete** /api/v2/orphanrecordings/{orphanId} | Deletes a single orphan recording |
| [**DeleteRecordingCrossplatformMediaretentionpolicies**](RecordingApi.html#deleterecordingcrossplatformmediaretentionpolicies) | **Delete** /api/v2/recording/crossplatform/mediaretentionpolicies | Delete media retention policies |
| [**DeleteRecordingCrossplatformMediaretentionpolicy**](RecordingApi.html#deleterecordingcrossplatformmediaretentionpolicy) | **Delete** /api/v2/recording/crossplatform/mediaretentionpolicies/{policyId} | Delete a media retention policy |
| [**DeleteRecordingJob**](RecordingApi.html#deleterecordingjob) | **Delete** /api/v2/recording/jobs/{jobId} | Delete the recording bulk job |
| [**DeleteRecordingMediaretentionpolicies**](RecordingApi.html#deleterecordingmediaretentionpolicies) | **Delete** /api/v2/recording/mediaretentionpolicies | Delete media retention policies |
| [**DeleteRecordingMediaretentionpolicy**](RecordingApi.html#deleterecordingmediaretentionpolicy) | **Delete** /api/v2/recording/mediaretentionpolicies/{policyId} | Delete a media retention policy |
| [**GetConversationRecording**](RecordingApi.html#getconversationrecording) | **Get** /api/v2/conversations/{conversationId}/recordings/{recordingId} | Gets a specific recording. |
| [**GetConversationRecordingAnnotation**](RecordingApi.html#getconversationrecordingannotation) | **Get** /api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId} | Get annotation |
| [**GetConversationRecordingAnnotations**](RecordingApi.html#getconversationrecordingannotations) | **Get** /api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations | Get annotations for recording |
| [**GetConversationRecordingmetadata**](RecordingApi.html#getconversationrecordingmetadata) | **Get** /api/v2/conversations/{conversationId}/recordingmetadata | Get recording metadata for a conversation. Does not return playable media. Annotations won&#39;t be included in the response if either recording:recording:view or recording:annotation:view permission is missing. |
| [**GetConversationRecordingmetadataRecordingId**](RecordingApi.html#getconversationrecordingmetadatarecordingid) | **Get** /api/v2/conversations/{conversationId}/recordingmetadata/{recordingId} | Get metadata for a specific recording. Does not return playable media. |
| [**GetConversationRecordings**](RecordingApi.html#getconversationrecordings) | **Get** /api/v2/conversations/{conversationId}/recordings | Get all of a Conversation&#39;s Recordings. |
| [**GetOrphanrecording**](RecordingApi.html#getorphanrecording) | **Get** /api/v2/orphanrecordings/{orphanId} | Gets a single orphan recording |
| [**GetOrphanrecordingMedia**](RecordingApi.html#getorphanrecordingmedia) | **Get** /api/v2/orphanrecordings/{orphanId}/media | Gets the media of a single orphan recording |
| [**GetOrphanrecordings**](RecordingApi.html#getorphanrecordings) | **Get** /api/v2/orphanrecordings | Gets all orphan recordings |
| [**GetRecordingBatchrequest**](RecordingApi.html#getrecordingbatchrequest) | **Get** /api/v2/recording/batchrequests/{jobId} | Get the status and results for a batch request job, only the user that submitted the job may retrieve results |
| [**GetRecordingCrossplatformMediaretentionpolicies**](RecordingApi.html#getrecordingcrossplatformmediaretentionpolicies) | **Get** /api/v2/recording/crossplatform/mediaretentionpolicies | Gets media retention policy list with query options to filter on name and enabled. |
| [**GetRecordingCrossplatformMediaretentionpolicy**](RecordingApi.html#getrecordingcrossplatformmediaretentionpolicy) | **Get** /api/v2/recording/crossplatform/mediaretentionpolicies/{policyId} | Get a media retention policy |
| [**GetRecordingJob**](RecordingApi.html#getrecordingjob) | **Get** /api/v2/recording/jobs/{jobId} | Get the status of the job associated with the job id. |
| [**GetRecordingJobFailedrecordings**](RecordingApi.html#getrecordingjobfailedrecordings) | **Get** /api/v2/recording/jobs/{jobId}/failedrecordings | Get IDs of recordings that the bulk job failed for |
| [**GetRecordingJobs**](RecordingApi.html#getrecordingjobs) | **Get** /api/v2/recording/jobs | Get the status of all jobs within the user&#39;s organization |
| [**GetRecordingKeyconfiguration**](RecordingApi.html#getrecordingkeyconfiguration) | **Get** /api/v2/recording/keyconfigurations/{keyConfigurationId} | Get the encryption key configurations |
| [**GetRecordingKeyconfigurations**](RecordingApi.html#getrecordingkeyconfigurations) | **Get** /api/v2/recording/keyconfigurations | Get a list of key configurations data |
| [**GetRecordingMediaretentionpolicies**](RecordingApi.html#getrecordingmediaretentionpolicies) | **Get** /api/v2/recording/mediaretentionpolicies | Gets media retention policy list with query options to filter on name and enabled. |
| [**GetRecordingMediaretentionpolicy**](RecordingApi.html#getrecordingmediaretentionpolicy) | **Get** /api/v2/recording/mediaretentionpolicies/{policyId} | Get a media retention policy |
| [**GetRecordingRecordingkeys**](RecordingApi.html#getrecordingrecordingkeys) | **Get** /api/v2/recording/recordingkeys | Get encryption key list |
| [**GetRecordingRecordingkeysRotationschedule**](RecordingApi.html#getrecordingrecordingkeysrotationschedule) | **Get** /api/v2/recording/recordingkeys/rotationschedule | Get key rotation schedule |
| [**GetRecordingSettings**](RecordingApi.html#getrecordingsettings) | **Get** /api/v2/recording/settings | Get the Recording Settings for the Organization |
| [**GetRecordingUploadsReport**](RecordingApi.html#getrecordinguploadsreport) | **Get** /api/v2/recording/uploads/reports/{reportId} | Get the status of a recording upload status report |
| [**GetRecordingsRetentionQuery**](RecordingApi.html#getrecordingsretentionquery) | **Get** /api/v2/recordings/retention/query | Query for recording retention data |
| [**GetRecordingsScreensessions**](RecordingApi.html#getrecordingsscreensessions) | **Get** /api/v2/recordings/screensessions | Retrieves a paged listing of screen recording sessions |
| [**GetRecordingsScreensessionsDetails**](RecordingApi.html#getrecordingsscreensessionsdetails) | **Get** /api/v2/recordings/screensessions/details | Retrieves an object containing the total number of concurrent active screen recordings |
| [**PatchRecordingCrossplatformMediaretentionpolicy**](RecordingApi.html#patchrecordingcrossplatformmediaretentionpolicy) | **Patch** /api/v2/recording/crossplatform/mediaretentionpolicies/{policyId} | Patch a media retention policy |
| [**PatchRecordingMediaretentionpolicy**](RecordingApi.html#patchrecordingmediaretentionpolicy) | **Patch** /api/v2/recording/mediaretentionpolicies/{policyId} | Patch a media retention policy |
| [**PatchRecordingsScreensession**](RecordingApi.html#patchrecordingsscreensession) | **Patch** /api/v2/recordings/screensessions/{recordingSessionId} | Update a screen recording session |
| [**PostConversationRecordingAnnotations**](RecordingApi.html#postconversationrecordingannotations) | **Post** /api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations | Create annotation |
| [**PostRecordingBatchrequests**](RecordingApi.html#postrecordingbatchrequests) | **Post** /api/v2/recording/batchrequests | Submit a batch download request for recordings. Recordings in response will be in their original format/codec - configured in the Trunk configuration. |
| [**PostRecordingCrossplatformMediaretentionpolicies**](RecordingApi.html#postrecordingcrossplatformmediaretentionpolicies) | **Post** /api/v2/recording/crossplatform/mediaretentionpolicies | Create media retention policy |
| [**PostRecordingJobs**](RecordingApi.html#postrecordingjobs) | **Post** /api/v2/recording/jobs | Create a recording bulk job. |
| [**PostRecordingKeyconfigurations**](RecordingApi.html#postrecordingkeyconfigurations) | **Post** /api/v2/recording/keyconfigurations | Setup configurations for encryption key creation |
| [**PostRecordingKeyconfigurationsValidate**](RecordingApi.html#postrecordingkeyconfigurationsvalidate) | **Post** /api/v2/recording/keyconfigurations/validate | Validate encryption key configurations without saving it |
| [**PostRecordingLocalkeys**](RecordingApi.html#postrecordinglocalkeys) | **Post** /api/v2/recording/localkeys | create a local key management recording key |
| [**PostRecordingMediaretentionpolicies**](RecordingApi.html#postrecordingmediaretentionpolicies) | **Post** /api/v2/recording/mediaretentionpolicies | Create media retention policy |
| [**PostRecordingRecordingkeys**](RecordingApi.html#postrecordingrecordingkeys) | **Post** /api/v2/recording/recordingkeys | Create encryption key |
| [**PostRecordingUploadsReports**](RecordingApi.html#postrecordinguploadsreports) | **Post** /api/v2/recording/uploads/reports | Creates a recording upload status report |
| [**PostRecordingsDeletionprotection**](RecordingApi.html#postrecordingsdeletionprotection) | **Post** /api/v2/recordings/deletionprotection | Get a list of conversations with protected recordings |
| [**PostRecordingsScreensessionsAcknowledge**](RecordingApi.html#postrecordingsscreensessionsacknowledge) | **Post** /api/v2/recordings/screensessions/acknowledge | Acknowledge a screen recording. |
| [**PostRecordingsScreensessionsMetadata**](RecordingApi.html#postrecordingsscreensessionsmetadata) | **Post** /api/v2/recordings/screensessions/metadata | Provide meta-data a screen recording. |
| [**PutConversationRecording**](RecordingApi.html#putconversationrecording) | **Put** /api/v2/conversations/{conversationId}/recordings/{recordingId} | Updates the retention records on a recording. |
| [**PutConversationRecordingAnnotation**](RecordingApi.html#putconversationrecordingannotation) | **Put** /api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId} | Update annotation |
| [**PutOrphanrecording**](RecordingApi.html#putorphanrecording) | **Put** /api/v2/orphanrecordings/{orphanId} | Updates an orphan recording to a regular recording with retention values |
| [**PutRecordingCrossplatformMediaretentionpolicy**](RecordingApi.html#putrecordingcrossplatformmediaretentionpolicy) | **Put** /api/v2/recording/crossplatform/mediaretentionpolicies/{policyId} | Update a media retention policy |
| [**PutRecordingJob**](RecordingApi.html#putrecordingjob) | **Put** /api/v2/recording/jobs/{jobId} | Execute the recording bulk job. |
| [**PutRecordingKeyconfiguration**](RecordingApi.html#putrecordingkeyconfiguration) | **Put** /api/v2/recording/keyconfigurations/{keyConfigurationId} | Update the encryption key configurations |
| [**PutRecordingMediaretentionpolicy**](RecordingApi.html#putrecordingmediaretentionpolicy) | **Put** /api/v2/recording/mediaretentionpolicies/{policyId} | Update a media retention policy |
| [**PutRecordingRecordingkeysRotationschedule**](RecordingApi.html#putrecordingrecordingkeysrotationschedule) | **Put** /api/v2/recording/recordingkeys/rotationschedule | Update key rotation schedule |
| [**PutRecordingSettings**](RecordingApi.html#putrecordingsettings) | **Put** /api/v2/recording/settings | Update the Recording Settings for the Organization |
| [**PutRecordingsDeletionprotection**](RecordingApi.html#putrecordingsdeletionprotection) | **Put** /api/v2/recordings/deletionprotection | Apply or revoke recording protection for conversations |
{: class="table table-striped"}

<a name="deleteconversationrecordingannotation"></a>

## void DeleteConversationRecordingAnnotation (string conversationId, string recordingId, string annotationId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteorphanrecording"></a>

## [**OrphanRecording**](OrphanRecording.html) DeleteOrphanrecording (string orphanId)



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
{: class="table table-striped"}

### Return type

[**OrphanRecording**](OrphanRecording.html)

<a name="deleterecordingcrossplatformmediaretentionpolicies"></a>

## void DeleteRecordingCrossplatformMediaretentionpolicies (string ids)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleterecordingcrossplatformmediaretentionpolicy"></a>

## void DeleteRecordingCrossplatformMediaretentionpolicy (string policyId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleterecordingjob"></a>

## void DeleteRecordingJob (string jobId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleterecordingmediaretentionpolicies"></a>

## void DeleteRecordingMediaretentionpolicies (string ids)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleterecordingmediaretentionpolicy"></a>

## void DeleteRecordingMediaretentionpolicy (string policyId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getconversationrecording"></a>

## [**Recording**](Recording.html) GetConversationRecording (string conversationId, string recordingId, string formatId = null, string emailFormatId = null, string chatFormatId = null, string messageFormatId = null, bool? download = null, string fileName = null, string locale = null, List<string> mediaFormats = null)



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
            var locale = locale_example;  // string | The locale for the requested file when downloading, as an ISO 639-1 code (optional) 
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
| **locale** | **string**| The locale for the requested file when downloading, as an ISO 639-1 code | [optional]  |
| **mediaFormats** | [**List<string>**](string.html)| All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3 | [optional]  |
{: class="table table-striped"}

### Return type

[**Recording**](Recording.html)

<a name="getconversationrecordingannotation"></a>

## [**Annotation**](Annotation.html) GetConversationRecordingAnnotation (string conversationId, string recordingId, string annotationId)



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
{: class="table table-striped"}

### Return type

[**Annotation**](Annotation.html)

<a name="getconversationrecordingannotations"></a>

## [**List&lt;Annotation&gt;**](Annotation.html) GetConversationRecordingAnnotations (string conversationId, string recordingId)



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
{: class="table table-striped"}

### Return type

[**List<Annotation>**](Annotation.html)

<a name="getconversationrecordingmetadata"></a>

## [**List&lt;RecordingMetadata&gt;**](RecordingMetadata.html) GetConversationRecordingmetadata (string conversationId)



Get recording metadata for a conversation. Does not return playable media. Annotations won't be included in the response if either recording:recording:view or recording:annotation:view permission is missing.

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
                // Get recording metadata for a conversation. Does not return playable media. Annotations won't be included in the response if either recording:recording:view or recording:annotation:view permission is missing.
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
{: class="table table-striped"}

### Return type

[**List<RecordingMetadata>**](RecordingMetadata.html)

<a name="getconversationrecordingmetadatarecordingid"></a>

## [**RecordingMetadata**](RecordingMetadata.html) GetConversationRecordingmetadataRecordingId (string conversationId, string recordingId)



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
{: class="table table-striped"}

### Return type

[**RecordingMetadata**](RecordingMetadata.html)

<a name="getconversationrecordings"></a>

## [**List&lt;Recording&gt;**](Recording.html) GetConversationRecordings (string conversationId, int? maxWaitMs = null, string formatId = null, List<string> mediaFormats = null)



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

            try
            { 
                // Get all of a Conversation's Recordings.
                List<Recording> result = apiInstance.GetConversationRecordings(conversationId, maxWaitMs, formatId, mediaFormats);
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
| **mediaFormats** | [**List<string>**](string.html)| All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3. | [optional]  |
{: class="table table-striped"}

### Return type

[**List<Recording>**](Recording.html)

<a name="getorphanrecording"></a>

## [**OrphanRecording**](OrphanRecording.html) GetOrphanrecording (string orphanId)



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
{: class="table table-striped"}

### Return type

[**OrphanRecording**](OrphanRecording.html)

<a name="getorphanrecordingmedia"></a>

## [**Recording**](Recording.html) GetOrphanrecordingMedia (string orphanId, string formatId = null, string emailFormatId = null, string chatFormatId = null, string messageFormatId = null, bool? download = null, string fileName = null, string locale = null, List<string> mediaFormats = null)



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
| **mediaFormats** | [**List<string>**](string.html)| All acceptable media formats. Overrides formatId. Valid values:WAV,WEBM,WAV_ULAW,OGG_VORBIS,OGG_OPUS,MP3 | [optional]  |
{: class="table table-striped"}

### Return type

[**Recording**](Recording.html)

<a name="getorphanrecordings"></a>

## [**OrphanRecordingListing**](OrphanRecordingListing.html) GetOrphanrecordings (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, bool? hasConversation = null, string media = null)



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
| **expand** | [**List<string>**](string.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **hasConversation** | **bool?**| Filter resulting orphans by whether the conversation is known. False returns all orphans for the organization. | [optional] [default to false] |
| **media** | **string**| Filter resulting orphans based on their media type | [optional] <br />**Values**: Call, Screen |
{: class="table table-striped"}

### Return type

[**OrphanRecordingListing**](OrphanRecordingListing.html)

<a name="getrecordingbatchrequest"></a>

## [**BatchDownloadJobStatusResult**](BatchDownloadJobStatusResult.html) GetRecordingBatchrequest (string jobId)



Get the status and results for a batch request job, only the user that submitted the job may retrieve results

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
                // Get the status and results for a batch request job, only the user that submitted the job may retrieve results
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
{: class="table table-striped"}

### Return type

[**BatchDownloadJobStatusResult**](BatchDownloadJobStatusResult.html)

<a name="getrecordingcrossplatformmediaretentionpolicies"></a>

## [**PolicyEntityListing**](PolicyEntityListing.html) GetRecordingCrossplatformMediaretentionpolicies (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null, int? deleteDaysThreshold = null)



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
| **expand** | [**List<string>**](string.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **name** | **string**| the policy name - used for filtering results in searches. | [optional]  |
| **enabled** | **bool?**| checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false | [optional]  |
| **summary** | **bool?**| provides a less verbose response of policy lists. | [optional] [default to false] |
| **hasErrors** | **bool?**| provides a way to fetch all policies with errors or policies that do not have errors | [optional]  |
| **deleteDaysThreshold** | **int?**| provides a way to fetch all policies with any actions having deleteDays exceeding the provided value | [optional]  |
{: class="table table-striped"}

### Return type

[**PolicyEntityListing**](PolicyEntityListing.html)

<a name="getrecordingcrossplatformmediaretentionpolicy"></a>

## [**CrossPlatformPolicy**](CrossPlatformPolicy.html) GetRecordingCrossplatformMediaretentionpolicy (string policyId)



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
{: class="table table-striped"}

### Return type

[**CrossPlatformPolicy**](CrossPlatformPolicy.html)

<a name="getrecordingjob"></a>

## [**RecordingJob**](RecordingJob.html) GetRecordingJob (string jobId)



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
{: class="table table-striped"}

### Return type

[**RecordingJob**](RecordingJob.html)

<a name="getrecordingjobfailedrecordings"></a>

## [**FailedRecordingEntityListing**](FailedRecordingEntityListing.html) GetRecordingJobFailedrecordings (string jobId, int? pageSize = null, int? pageNumber = null, bool? includeTotal = null, string cursor = null)



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
            var includeTotal = true;  // bool? | If false, cursor will be used to locate the page instead of pageNumber. (optional) 
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
| **includeTotal** | **bool?**| If false, cursor will be used to locate the page instead of pageNumber. | [optional]  |
| **cursor** | **string**| Indicates where to resume query results (not required for first page) | [optional]  |
{: class="table table-striped"}

### Return type

[**FailedRecordingEntityListing**](FailedRecordingEntityListing.html)

<a name="getrecordingjobs"></a>

## [**RecordingJobEntityListing**](RecordingJobEntityListing.html) GetRecordingJobs (int? pageSize = null, int? pageNumber = null, string sortBy = null, string state = null, bool? showOnlyMyJobs = null, string jobType = null, bool? includeTotal = null, string cursor = null)



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
            var includeTotal = true;  // bool? | If false, cursor will be used to locate the page instead of pageNumber. (optional) 
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
| **includeTotal** | **bool?**| If false, cursor will be used to locate the page instead of pageNumber. | [optional]  |
| **cursor** | **string**| Indicates where to resume query results (not required for first page) | [optional]  |
{: class="table table-striped"}

### Return type

[**RecordingJobEntityListing**](RecordingJobEntityListing.html)

<a name="getrecordingkeyconfiguration"></a>

## [**RecordingEncryptionConfiguration**](RecordingEncryptionConfiguration.html) GetRecordingKeyconfiguration (string keyConfigurationId)



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
{: class="table table-striped"}

### Return type

[**RecordingEncryptionConfiguration**](RecordingEncryptionConfiguration.html)

<a name="getrecordingkeyconfigurations"></a>

## [**RecordingEncryptionConfigurationListing**](RecordingEncryptionConfigurationListing.html) GetRecordingKeyconfigurations ()



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

[**RecordingEncryptionConfigurationListing**](RecordingEncryptionConfigurationListing.html)

<a name="getrecordingmediaretentionpolicies"></a>

## [**PolicyEntityListing**](PolicyEntityListing.html) GetRecordingMediaretentionpolicies (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null, int? deleteDaysThreshold = null)



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
| **expand** | [**List<string>**](string.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **name** | **string**| the policy name - used for filtering results in searches. | [optional]  |
| **enabled** | **bool?**| checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false | [optional]  |
| **summary** | **bool?**| provides a less verbose response of policy lists. | [optional] [default to false] |
| **hasErrors** | **bool?**| provides a way to fetch all policies with errors or policies that do not have errors | [optional]  |
| **deleteDaysThreshold** | **int?**| provides a way to fetch all policies with any actions having deleteDays exceeding the provided value | [optional]  |
{: class="table table-striped"}

### Return type

[**PolicyEntityListing**](PolicyEntityListing.html)

<a name="getrecordingmediaretentionpolicy"></a>

## [**Policy**](Policy.html) GetRecordingMediaretentionpolicy (string policyId)



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
{: class="table table-striped"}

### Return type

[**Policy**](Policy.html)

<a name="getrecordingrecordingkeys"></a>

## [**EncryptionKeyEntityListing**](EncryptionKeyEntityListing.html) GetRecordingRecordingkeys (int? pageSize = null, int? pageNumber = null)



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
{: class="table table-striped"}

### Return type

[**EncryptionKeyEntityListing**](EncryptionKeyEntityListing.html)

<a name="getrecordingrecordingkeysrotationschedule"></a>

## [**KeyRotationSchedule**](KeyRotationSchedule.html) GetRecordingRecordingkeysRotationschedule ()



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

[**KeyRotationSchedule**](KeyRotationSchedule.html)

<a name="getrecordingsettings"></a>

## [**RecordingSettings**](RecordingSettings.html) GetRecordingSettings (bool? createDefault = null)



Get the Recording Settings for the Organization

Requires ANY permissions: 

* recording:screenRecording:view
* recording:settings:editScreenRecordings

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
{: class="table table-striped"}

### Return type

[**RecordingSettings**](RecordingSettings.html)

<a name="getrecordinguploadsreport"></a>

## [**RecordingUploadReport**](RecordingUploadReport.html) GetRecordingUploadsReport (string reportId)



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
{: class="table table-striped"}

### Return type

[**RecordingUploadReport**](RecordingUploadReport.html)

<a name="getrecordingsretentionquery"></a>

## [**RecordingRetentionCursorEntityListing**](RecordingRetentionCursorEntityListing.html) GetRecordingsRetentionQuery (int? retentionThresholdDays, string cursor = null, int? pageSize = null)



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
{: class="table table-striped"}

### Return type

[**RecordingRetentionCursorEntityListing**](RecordingRetentionCursorEntityListing.html)

<a name="getrecordingsscreensessions"></a>

## [**ScreenRecordingSessionListing**](ScreenRecordingSessionListing.html) GetRecordingsScreensessions (int? pageSize = null, int? pageNumber = null)



Retrieves a paged listing of screen recording sessions

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
    public class GetRecordingsScreensessionsExample
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
                // Retrieves a paged listing of screen recording sessions
                ScreenRecordingSessionListing result = apiInstance.GetRecordingsScreensessions(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetRecordingsScreensessions: " + e.Message );
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
{: class="table table-striped"}

### Return type

[**ScreenRecordingSessionListing**](ScreenRecordingSessionListing.html)

<a name="getrecordingsscreensessionsdetails"></a>

## [**ScreenRecordingActiveSessions**](ScreenRecordingActiveSessions.html) GetRecordingsScreensessionsDetails ()



Retrieves an object containing the total number of concurrent active screen recordings

GetRecordingsScreensessionsDetails is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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

[**ScreenRecordingActiveSessions**](ScreenRecordingActiveSessions.html)

<a name="patchrecordingcrossplatformmediaretentionpolicy"></a>

## [**CrossPlatformPolicy**](CrossPlatformPolicy.html) PatchRecordingCrossplatformMediaretentionpolicy (string policyId, CrossPlatformPolicyUpdate body)



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
| **body** | [**CrossPlatformPolicyUpdate**](CrossPlatformPolicyUpdate.html)| Policy |  |
{: class="table table-striped"}

### Return type

[**CrossPlatformPolicy**](CrossPlatformPolicy.html)

<a name="patchrecordingmediaretentionpolicy"></a>

## [**Policy**](Policy.html) PatchRecordingMediaretentionpolicy (string policyId, PolicyUpdate body)



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
| **body** | [**PolicyUpdate**](PolicyUpdate.html)| Policy |  |
{: class="table table-striped"}

### Return type

[**Policy**](Policy.html)

<a name="patchrecordingsscreensession"></a>

## void PatchRecordingsScreensession (string recordingSessionId, ScreenRecordingSessionRequest body = null)



Update a screen recording session

Requires ANY permissions: 

* recording:screenRecording:stop

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchRecordingsScreensessionExample
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
            var recordingSessionId = recordingSessionId_example;  // string | Screen recording session ID
            var body = new ScreenRecordingSessionRequest(); // ScreenRecordingSessionRequest |  (optional) 

            try
            { 
                // Update a screen recording session
                apiInstance.PatchRecordingsScreensession(recordingSessionId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PatchRecordingsScreensession: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **recordingSessionId** | **string**| Screen recording session ID |  |
| **body** | [**ScreenRecordingSessionRequest**](ScreenRecordingSessionRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationrecordingannotations"></a>

## [**Annotation**](Annotation.html) PostConversationRecordingAnnotations (string conversationId, string recordingId, Annotation body)



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
| **body** | [**Annotation**](Annotation.html)| annotation |  |
{: class="table table-striped"}

### Return type

[**Annotation**](Annotation.html)

<a name="postrecordingbatchrequests"></a>

## [**BatchDownloadJobSubmissionResult**](BatchDownloadJobSubmissionResult.html) PostRecordingBatchrequests (BatchDownloadJobSubmission body)



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
| **body** | [**BatchDownloadJobSubmission**](BatchDownloadJobSubmission.html)| Job submission criteria |  |
{: class="table table-striped"}

### Return type

[**BatchDownloadJobSubmissionResult**](BatchDownloadJobSubmissionResult.html)

<a name="postrecordingcrossplatformmediaretentionpolicies"></a>

## [**CrossPlatformPolicy**](CrossPlatformPolicy.html) PostRecordingCrossplatformMediaretentionpolicies (CrossPlatformPolicyCreate body)



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
| **body** | [**CrossPlatformPolicyCreate**](CrossPlatformPolicyCreate.html)| Policy |  |
{: class="table table-striped"}

### Return type

[**CrossPlatformPolicy**](CrossPlatformPolicy.html)

<a name="postrecordingjobs"></a>

## [**RecordingJob**](RecordingJob.html) PostRecordingJobs (RecordingJobsQuery body)



Create a recording bulk job.

Each organization can run up to a maximum of two concurrent jobs that are either in pending or processing state. Furthermore, the recording:recording:viewSensitiveData permission is required to access recordings with PCI DSS and/or PII data when redaction is enabled for their organization. If the requester does not have that permission and includeRecordingsWithSensitiveData is set to true, then their request will be rejected.

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
| **body** | [**RecordingJobsQuery**](RecordingJobsQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**RecordingJob**](RecordingJob.html)

<a name="postrecordingkeyconfigurations"></a>

## [**RecordingEncryptionConfiguration**](RecordingEncryptionConfiguration.html) PostRecordingKeyconfigurations (RecordingEncryptionConfiguration body)



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
| **body** | [**RecordingEncryptionConfiguration**](RecordingEncryptionConfiguration.html)| Encryption Configuration |  |
{: class="table table-striped"}

### Return type

[**RecordingEncryptionConfiguration**](RecordingEncryptionConfiguration.html)

<a name="postrecordingkeyconfigurationsvalidate"></a>

## [**RecordingEncryptionConfiguration**](RecordingEncryptionConfiguration.html) PostRecordingKeyconfigurationsValidate (RecordingEncryptionConfiguration body)



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
| **body** | [**RecordingEncryptionConfiguration**](RecordingEncryptionConfiguration.html)| Encryption Configuration |  |
{: class="table table-striped"}

### Return type

[**RecordingEncryptionConfiguration**](RecordingEncryptionConfiguration.html)

<a name="postrecordinglocalkeys"></a>

## [**EncryptionKey**](EncryptionKey.html) PostRecordingLocalkeys (LocalEncryptionKeyRequest body)



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
| **body** | [**LocalEncryptionKeyRequest**](LocalEncryptionKeyRequest.html)| Local Encryption body |  |
{: class="table table-striped"}

### Return type

[**EncryptionKey**](EncryptionKey.html)

<a name="postrecordingmediaretentionpolicies"></a>

## [**Policy**](Policy.html) PostRecordingMediaretentionpolicies (PolicyCreate body)



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
| **body** | [**PolicyCreate**](PolicyCreate.html)| Policy |  |
{: class="table table-striped"}

### Return type

[**Policy**](Policy.html)

<a name="postrecordingrecordingkeys"></a>

## [**EncryptionKey**](EncryptionKey.html) PostRecordingRecordingkeys ()



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

[**EncryptionKey**](EncryptionKey.html)

<a name="postrecordinguploadsreports"></a>

## [**RecordingUploadReport**](RecordingUploadReport.html) PostRecordingUploadsReports (RecordingUploadReportRequest body)



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
| **body** | [**RecordingUploadReportRequest**](RecordingUploadReportRequest.html)| Report parameters |  |
{: class="table table-striped"}

### Return type

[**RecordingUploadReport**](RecordingUploadReport.html)

<a name="postrecordingsdeletionprotection"></a>

## [**List&lt;AddressableEntityRef&gt;**](AddressableEntityRef.html) PostRecordingsDeletionprotection (ConversationDeletionProtectionQuery body)



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
| **body** | [**ConversationDeletionProtectionQuery**](ConversationDeletionProtectionQuery.html)| conversationIds |  |
{: class="table table-striped"}

### Return type

[**List<AddressableEntityRef>**](AddressableEntityRef.html)

<a name="postrecordingsscreensessionsacknowledge"></a>

## void PostRecordingsScreensessionsAcknowledge (AcknowledgeScreenRecordingRequest body)



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
| **body** | [**AcknowledgeScreenRecordingRequest**](AcknowledgeScreenRecordingRequest.html)| AcknowledgeScreenRecordingRequest |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postrecordingsscreensessionsmetadata"></a>

## void PostRecordingsScreensessionsMetadata (ScreenRecordingMetaDataRequest body)



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
| **body** | [**ScreenRecordingMetaDataRequest**](ScreenRecordingMetaDataRequest.html)| ScreenRecordingMetaDataRequest |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="putconversationrecording"></a>

## [**Recording**](Recording.html) PutConversationRecording (string conversationId, string recordingId, Recording body, bool? clearExport = null)



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
| **body** | [**Recording**](Recording.html)| recording |  |
| **clearExport** | **bool?**| Whether to clear the pending export for the recording | [optional]  |
{: class="table table-striped"}

### Return type

[**Recording**](Recording.html)

<a name="putconversationrecordingannotation"></a>

## [**Annotation**](Annotation.html) PutConversationRecordingAnnotation (string conversationId, string recordingId, string annotationId, Annotation body)



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
| **body** | [**Annotation**](Annotation.html)| annotation |  |
{: class="table table-striped"}

### Return type

[**Annotation**](Annotation.html)

<a name="putorphanrecording"></a>

## [**Recording**](Recording.html) PutOrphanrecording (string orphanId, OrphanUpdateRequest body = null)



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
| **body** | [**OrphanUpdateRequest**](OrphanUpdateRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**Recording**](Recording.html)

<a name="putrecordingcrossplatformmediaretentionpolicy"></a>

## [**CrossPlatformPolicy**](CrossPlatformPolicy.html) PutRecordingCrossplatformMediaretentionpolicy (string policyId, CrossPlatformPolicy body)



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
| **body** | [**CrossPlatformPolicy**](CrossPlatformPolicy.html)| Policy |  |
{: class="table table-striped"}

### Return type

[**CrossPlatformPolicy**](CrossPlatformPolicy.html)

<a name="putrecordingjob"></a>

## [**RecordingJob**](RecordingJob.html) PutRecordingJob (string jobId, ExecuteRecordingJobsQuery body)



Execute the recording bulk job.

A job must be executed by the same user whom originally created the job.  In addition, the user must have permission to update the recording's retention.

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
| **body** | [**ExecuteRecordingJobsQuery**](ExecuteRecordingJobsQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**RecordingJob**](RecordingJob.html)

<a name="putrecordingkeyconfiguration"></a>

## [**RecordingEncryptionConfiguration**](RecordingEncryptionConfiguration.html) PutRecordingKeyconfiguration (string keyConfigurationId, RecordingEncryptionConfiguration body)



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
| **body** | [**RecordingEncryptionConfiguration**](RecordingEncryptionConfiguration.html)| Encryption key configuration metadata |  |
{: class="table table-striped"}

### Return type

[**RecordingEncryptionConfiguration**](RecordingEncryptionConfiguration.html)

<a name="putrecordingmediaretentionpolicy"></a>

## [**Policy**](Policy.html) PutRecordingMediaretentionpolicy (string policyId, Policy body)



Update a media retention policy

Policy does not work retroactively

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
| **body** | [**Policy**](Policy.html)| Policy |  |
{: class="table table-striped"}

### Return type

[**Policy**](Policy.html)

<a name="putrecordingrecordingkeysrotationschedule"></a>

## [**KeyRotationSchedule**](KeyRotationSchedule.html) PutRecordingRecordingkeysRotationschedule (KeyRotationSchedule body)



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
| **body** | [**KeyRotationSchedule**](KeyRotationSchedule.html)| KeyRotationSchedule |  |
{: class="table table-striped"}

### Return type

[**KeyRotationSchedule**](KeyRotationSchedule.html)

<a name="putrecordingsettings"></a>

## [**RecordingSettings**](RecordingSettings.html) PutRecordingSettings (RecordingSettings body)



Update the Recording Settings for the Organization

Requires ANY permissions: 

* recording:settings:editScreenRecordings

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
| **body** | [**RecordingSettings**](RecordingSettings.html)| Recording settings |  |
{: class="table table-striped"}

### Return type

[**RecordingSettings**](RecordingSettings.html)

<a name="putrecordingsdeletionprotection"></a>

## void PutRecordingsDeletionprotection (bool? protect = null, ConversationDeletionProtectionQuery body = null)



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
| **body** | [**ConversationDeletionProtectionQuery**](ConversationDeletionProtectionQuery.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

