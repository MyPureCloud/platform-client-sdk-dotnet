---
title: RecordingJobsQuery
---
## ININ.PureCloudApi.Model.RecordingJobsQuery

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Action** | **string** | Operation to perform bulk task | |
| **ActionDate** | **DateTime?** | The date when the action will be performed. If the operation will cause the delete date of a recording to be older than the export date, the export date will be adjusted to the delete date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **IntegrationId** | **string** | IntegrationId to Access AWS S3 bucket for bulk recording exports. This field is required and used only for EXPORT action. | [optional] |
| **IncludeScreenRecordings** | **bool?** | Include Screen recordings for export action, default value = true  | [optional] |
| **ConversationQuery** | [**AsyncConversationQuery**](AsyncConversationQuery.html) | Conversation Query. Note: After the recording is created, it might take up to 48 hours for the recording to be included in the submitted job query.  This result depends on the analytics data lake job completion. See also: https://developer.genesys.cloud/analyticsdatamanagement/analytics/jobs/conversation-details-job#data-availability | |
{: class="table table-striped"}


