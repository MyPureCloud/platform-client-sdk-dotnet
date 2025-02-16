# OrphanUpdateRequest

## ININ.PureCloudApi.Model.OrphanUpdateRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ArchiveDate** | **DateTime?** | The orphan recording&#39;s archive date. Must be greater than 1 day from now if set. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DeleteDate** | **DateTime?** | The orphan recording&#39;s delete date. Must be greater than archiveDate and exportDate if set, otherwise one day from now. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ExportDate** | **DateTime?** | The orphan recording&#39;s export date. Must be greater than 1 day from now if set. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **IntegrationId** | **string** | IntegrationId to access AWS S3 bucket for export. This field is required if exportDate is set. | [optional] |
| **ConversationId** | **string** | A conversation Id that this orphan&#39;s recording is to be attached to. If not present, the conversationId will be deduced from the recording media. | [optional] |



_PureCloudPlatform.Client.V2 227.0.0_
