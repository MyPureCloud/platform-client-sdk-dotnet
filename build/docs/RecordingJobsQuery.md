---
title: RecordingJobsQuery
---
## ININ.PureCloudApi.Model.RecordingJobsQuery

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Action** | **string** | Operation to perform bulk task | |
| **ActionDate** | **DateTime?** | The date when the action will be performed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | |
| **IntegrationId** | **string** | IntegrationId to Access AWS S3 bucket for bulk recording exports. This field is for EXPORT only | [optional] |
| **IncludeScreenRecordings** | **bool?** | Include Screen recordings for export action, default value = true  | [optional] |
| **ConversationQuery** | [**AsyncConversationQuery**](AsyncConversationQuery.html) | Conversation Query. Note: After the recording is created, it might take up to 48 hours for the recording to be included in the submitted job query. | |
{: class="table table-striped"}


