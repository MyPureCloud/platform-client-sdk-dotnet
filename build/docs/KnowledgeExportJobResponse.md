---
title: KnowledgeExportJobResponse
---
## ININ.PureCloudApi.Model.KnowledgeExportJobResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Id of the export job. | [optional] |
| **DownloadURL** | **string** | The URL of the location at which the caller can download the export file, when available. | [optional] |
| **FileType** | **string** | File type of the document | |
| **CountDocumentProcessed** | **int?** | The current count of the number of records processed. | [optional] |
| **ExportFilter** | [**KnowledgeExportJobFilter**](KnowledgeExportJobFilter.html) | Filters to narrow down what to export. | [optional] |
| **Status** | **string** | The status of the export job. | [optional] |
| **KnowledgeBase** | [**KnowledgeBase**](KnowledgeBase.html) | Knowledge base which document export belongs to. | [optional] |
| **CreatedBy** | [**UserReference**](UserReference.html) | The user who created the operation | [optional] |
| **DateCreated** | **DateTime?** | The timestamp of when the export began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The timestamp of when the export stopped. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ErrorInformation** | [**ErrorBody**](ErrorBody.html) | Any error information, or null of the processing is not in failed state. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


