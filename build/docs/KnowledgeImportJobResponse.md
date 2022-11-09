---
title: KnowledgeImportJobResponse
---
## ININ.PureCloudApi.Model.KnowledgeImportJobResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Id of the import job | [optional] |
| **UploadKey** | **string** | Upload key | |
| **FileType** | **string** | File type of the document | |
| **Settings** | [**KnowledgeImportJobSettings**](KnowledgeImportJobSettings.html) | Additional optional settings | [optional] |
| **Status** | **string** | Status of the import job | [optional] |
| **Report** | [**KnowledgeImportJobReport**](KnowledgeImportJobReport.html) | Report of the import job | [optional] |
| **KnowledgeBase** | [**KnowledgeBase**](KnowledgeBase.html) | Knowledge base which document import does belong to | [optional] |
| **DateCreated** | **DateTime?** | Created date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Last modified date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


