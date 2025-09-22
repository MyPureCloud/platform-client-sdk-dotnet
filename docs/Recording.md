# Recording

## ININ.PureCloudApi.Model.Recording

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **ConversationId** | **string** |  | [optional] |
| **Path** | **string** |  | [optional] |
| **StartTime** | **string** | The start time of the recording. Null when there is no playable media. | [optional] |
| **EndTime** | **string** | The end time of the recording. Null when there is no playable media. | [optional] |
| **Media** | **string** | The media type of the recording. This could be audio, chat, messaging, email, or screen. | [optional] |
| **MediaSubtype** | **string** | The media subtype of the recording. | [optional] |
| **MediaSubject** | **string** | The media subject of the recording. | [optional] |
| **Annotations** | [**List&lt;Annotation&gt;**](Annotation) | Annotations that belong to the recording. | [optional] |
| **Transcript** | [**List&lt;ChatMessage&gt;**](ChatMessage) | Represents a chat transcript | [optional] |
| **EmailTranscript** | [**List&lt;RecordingEmailMessage&gt;**](RecordingEmailMessage) | Represents an email transcript | [optional] |
| **MessagingTranscript** | [**List&lt;RecordingMessagingMessage&gt;**](RecordingMessagingMessage) | Represents a messaging transcript | [optional] |
| **FileState** | **string** | Represents the current file state for a recording. Examples: Uploading, Archived, etc | [optional] |
| **RestoreExpirationTime** | **DateTime?** | The amount of time a restored recording will remain restored before being archived again. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **MediaUris** | [**Dictionary&lt;string, MediaResult&gt;**](MediaResult) | The different mediaUris for the recording. Null when there is no playable media. | [optional] |
| **EstimatedTranscodeTimeMs** | **long?** |  | [optional] |
| **ActualTranscodeTimeMs** | **long?** |  | [optional] |
| **ArchiveDate** | **DateTime?** | The date the recording will be archived. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ArchiveMedium** | **string** | The type of archive medium used. Example: CloudArchive | [optional] |
| **DeleteDate** | **DateTime?** | The date the recording will be deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ExportDate** | **DateTime?** | The date the recording will be exported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ExportedDate** | **DateTime?** | The date the recording was exported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **OutputDurationMs** | **int?** | Duration of transcoded media in milliseconds | [optional] |
| **OutputSizeInBytes** | **int?** | Size of transcoded media in bytes. 0 if there is no transcoded media. | [optional] |
| **MaxAllowedRestorationsForOrg** | **int?** | How many archive restorations the organization is allowed to have. Deprecated - Always returns 10000 since the restoration limit is no longer enforced. | [optional] |
| **RemainingRestorationsAllowedForOrg** | **int?** | The remaining archive restorations the organization has. Deprecated - Always returns 10000 since the restoration limit is no longer enforced. | [optional] |
| **SessionId** | **string** | The session id represents an external resource id, such as email, call, chat, etc | [optional] |
| **Users** | [**List&lt;User&gt;**](User) | The users participating in the conversation | [optional] |
| **RecordingFileRole** | **string** | Role of the file recording. It can be either customer_experience or adhoc. | [optional] |
| **RecordingErrorStatus** | **string** | Status of a recording that cannot be returned because of an error | [optional] |
| **OriginalRecordingStartTime** | **DateTime?** | The start time of the full recording, before any segment access restrictions are applied. Null when there is no playable media. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreationTime** | **DateTime?** | The creation time of the recording. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 242.0.0_
