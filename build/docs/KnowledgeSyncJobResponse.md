# KnowledgeSyncJobResponse

## ININ.PureCloudApi.Model.KnowledgeSyncJobResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Id of the sync job. | [optional] |
| **UploadKey** | **string** |  | [optional] |
| **Status** | **string** | The status of the export job. | [optional] |
| **Report** | [**KnowledgeSyncJobReport**](KnowledgeSyncJobReport) | Report of the sync job | [optional] |
| **KnowledgeBase** | [**KnowledgeBaseReference**](KnowledgeBaseReference) | Knowledge base which document export belongs to. | [optional] |
| **DateCreated** | **DateTime?** | The timestamp of when the export began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The timestamp of when the export stopped. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreatedBy** | [**UserReference**](UserReference) | The user who created the operation | [optional] |
| **DownloadURL** | **string** | The URL of the location at which the caller can download the sync file, when available. | [optional] |
| **FailedEntitiesURL** | **string** | The URL of the location at which the caller can download the entities in json format that failed during the sync. | [optional] |
| **Source** | [**KnowledgeOperationSource**](KnowledgeOperationSource) | Source of the sync job. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 227.0.0_
