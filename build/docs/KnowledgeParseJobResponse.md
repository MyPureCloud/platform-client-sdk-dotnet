---
title: KnowledgeParseJobResponse
---
## ININ.PureCloudApi.Model.KnowledgeParseJobResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Id of the parse job | [optional] |
| **DownloadURL** | **string** | The URL of the location at which the caller can download the original html file. | [optional] |
| **Hints** | **List&lt;string&gt;** | Hinted titles for the parser. | [optional] |
| **Status** | **string** | Status of the parse job | [optional] |
| **ParseResults** | [**List&lt;KnowledgeParseRecord&gt;**](KnowledgeParseRecord.html) | Results of the parse | [optional] |
| **ImportResult** | [**KnowledgeParseImportResult**](KnowledgeParseImportResult.html) | Result of the import phase | [optional] |
| **CreatedBy** | [**UserReference**](UserReference.html) | The user who created the operation | [optional] |
| **DateCreated** | **DateTime?** | Created date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Last modified date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


