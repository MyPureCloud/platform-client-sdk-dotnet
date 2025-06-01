# KnowledgeExportJobResponse

## ININ.PureCloudApi.Model.KnowledgeExportJobResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Id of the export job. | [optional] |
| **DownloadURL** | **string** | The URL of the location at which the caller can download the export file, when available. | [optional] |
| **FileType** | **string** | File type of the document | |
| **JsonFileVersion** | **int?** | Requested version of the exported json file. | [optional] |
| **CountDocumentProcessed** | **int?** | The current count of the number of records processed. | [optional] |
| **ExportFilter** | [**KnowledgeExportJobFilter**](KnowledgeExportJobFilter) | Filters to narrow down what to export. | [optional] |
| **Status** | **string** | The status of the export job. | [optional] |
| **KnowledgeBase** | [**KnowledgeBase**](KnowledgeBase) | Knowledge base which document export belongs to. | [optional] |
| **CreatedBy** | [**UserReference**](UserReference) | The user who created the operation | [optional] |
| **DateCreated** | **DateTime?** | The timestamp of when the export began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The timestamp of when the export stopped. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ErrorInformation** | [**ErrorBody**](ErrorBody) | Any error information, or null of the processing is not in failed state. | [optional] |
| **Source** | [**KnowledgeOperationSource**](KnowledgeOperationSource) | Source of the export job. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 235.0.0_
