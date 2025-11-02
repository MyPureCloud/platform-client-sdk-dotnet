# RecordingJob

## ININ.PureCloudApi.Model.RecordingJob

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **State** | **string** | The current state of the job. | |
| **RecordingJobsQuery** | [**RecordingJobsQuery**](RecordingJobsQuery) | Original query of the job. | [optional] |
| **DateCreated** | **DateTime?** | Date when the job was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **TotalConversations** | **int?** | Total number of conversations affected. | [optional] |
| **TotalRecordings** | **int?** | Total number of recordings affected. | [optional] |
| **TotalSkippedRecordings** | **int?** | Total number of recordings that have been skipped. | [optional] |
| **TotalFailedRecordings** | **int?** | Total number of recordings that the bulk job failed to process. | [optional] |
| **TotalProcessedRecordings** | **int?** | Total number of recordings have been processed. | [optional] |
| **PercentProgress** | **int?** | Progress in percentage based on the number of recordings | [optional] |
| **ErrorMessage** | **string** | Error occurred during the job execution | [optional] |
| **FailedRecordings** | **string** | Get IDs of recordings that the bulk job failed for | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **User** | [**AddressableEntityRef**](AddressableEntityRef) | Details of the user created the job | [optional] |



_PureCloudPlatform.Client.V2 247.0.0_
