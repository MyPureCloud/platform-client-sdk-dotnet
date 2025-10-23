# VoicemailMailboxInfo

## ININ.PureCloudApi.Model.VoicemailMailboxInfo

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **OwnerType** | **string** | The owner type of the voicemail mailbox | [optional] |
| **UsageSizeBytes** | **long?** | The total number of bytes for all voicemail message audio recordings | [optional] |
| **TotalCount** | **int?** | The total number of voicemail messages | [optional] |
| **UnreadCount** | **int?** | The total number of voicemail messages marked as unread | [optional] |
| **DeletedCount** | **int?** | The total number of voicemail messages marked as deleted | [optional] |
| **CreatedDate** | **DateTime?** | The date of the oldest voicemail message. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedDate** | **DateTime?** | The date of the most recent voicemail message. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **NewestUnreadDate** | **DateTime?** | The date of the most recent unread voicemail message. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **OldestUnreadDate** | **DateTime?** | The date of the most oldest unread voicemail message. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **NewestReadDate** | **DateTime?** | The date of the most recent read voicemail message. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **OldestReadDate** | **DateTime?** | The date of the most oldest read voicemail message. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 246.0.0_
