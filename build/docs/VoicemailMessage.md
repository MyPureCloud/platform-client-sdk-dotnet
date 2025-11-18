# VoicemailMessage

## ININ.PureCloudApi.Model.VoicemailMessage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Conversation** | [**Conversation**](Conversation) | The conversation that the voicemail message is associated with | [optional] |
| **Read** | **bool?** | Whether the voicemail message is marked as read | [optional] |
| **AudioRecordingDurationSeconds** | **int?** | The voicemail message&#39;s audio recording duration in seconds | [optional] |
| **AudioRecordingSizeBytes** | **long?** | The voicemail message&#39;s audio recording size in bytes | [optional] |
| **Transcription** | **string** | The transcription of the voicemail&#39;s audio | [optional] |
| **CreatedDate** | **DateTime?** | The date the voicemail message was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedDate** | **DateTime?** | The date the voicemail message was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DeletedDate** | **DateTime?** | The date the voicemail message deleted property was set to true. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CallerAddress** | **string** | The caller address | [optional] |
| **CallerName** | **string** | Optionally the name of the caller that left the voicemail message if the caller was a known user | [optional] |
| **CallerUser** | [**User**](User) | Optionally the user that left the voicemail message if the caller was a known user | [optional] |
| **Deleted** | **bool?** | Whether the voicemail message has been marked as deleted | [optional] |
| **Note** | **string** | An optional note | [optional] |
| **User** | [**User**](User) | The user that the voicemail message belongs to or null which means the voicemail message belongs to a group or queue | [optional] |
| **Group** | [**Group**](Group) | The group that the voicemail message belongs to or null which means the voicemail message belongs to a user or queue | [optional] |
| **Queue** | [**Queue**](Queue) | The queue that the voicemail message belongs to or null which means the voicemail message belongs to a user or group | [optional] |
| **CopiedFrom** | [**VoicemailCopyRecord**](VoicemailCopyRecord) | Represents where this voicemail message was copied from | [optional] |
| **CopiedTo** | [**List&lt;VoicemailCopyRecord&gt;**](VoicemailCopyRecord) | Represents where this voicemail has been copied to | [optional] |
| **DeleteRetentionPolicy** | [**VoicemailRetentionPolicy**](VoicemailRetentionPolicy) | The retention policy for this voicemail when deleted is set to true | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 248.0.0_
