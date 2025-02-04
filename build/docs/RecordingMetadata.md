# RecordingMetadata

## ININ.PureCloudApi.Model.RecordingMetadata

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **ConversationId** | **string** |  | [optional] |
| **Path** | **string** |  | [optional] |
| **StartTime** | **string** | The start time of the recording for screen recordings. Null for other types. | [optional] |
| **EndTime** | **string** |  | [optional] |
| **Media** | **string** | The type of media that the recording is. At the moment that could be audio, chat, email, or message. | [optional] |
| **MediaSubtype** | **string** | The recording media subtype. | [optional] |
| **MediaSubject** | **string** | The recording media subject. | [optional] |
| **Annotations** | [**List&lt;Annotation&gt;**](Annotation) | Annotations that belong to the recording. Populated when recording filestate is AVAILABLE. | [optional] |
| **FileState** | **string** | Represents the current file state for a recording. Examples: Uploading, Archived, etc | [optional] |
| **RestoreExpirationTime** | **DateTime?** | The amount of time a restored recording will remain restored before being archived again. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ArchiveDate** | **DateTime?** | The date the recording will be archived. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ArchiveMedium** | **string** | The type of archive medium used. Example: CloudArchive | [optional] |
| **DeleteDate** | **DateTime?** | The date the recording will be deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ExportDate** | **DateTime?** | The date the recording will be exported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ExportedDate** | **DateTime?** | The date the recording was exported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **MaxAllowedRestorationsForOrg** | **int?** | How many archive restorations the organization is allowed to have. | [optional] |
| **RemainingRestorationsAllowedForOrg** | **int?** | The remaining archive restorations the organization has. | [optional] |
| **SessionId** | **string** | The session id represents an external resource id, such as email, call, chat, etc | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 226.0.0_
