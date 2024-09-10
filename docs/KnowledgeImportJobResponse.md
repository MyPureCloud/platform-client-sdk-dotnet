# KnowledgeImportJobResponse

## ININ.PureCloudApi.Model.KnowledgeImportJobResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Id of the import job | [optional] |
| **DownloadURL** | **string** | The URL of the location at which the caller can download the imported file. | [optional] |
| **FailedEntitiesURL** | **string** | The URL of the location at which the caller can download the entities in json format that failed during the import. | [optional] |
| **UploadKey** | **string** | Upload key | |
| **FileType** | **string** | File type of the document | |
| **Settings** | [**KnowledgeImportJobSettings**](KnowledgeImportJobSettings) | Additional optional settings | [optional] |
| **Status** | **string** | Status of the import job | [optional] |
| **Report** | [**KnowledgeImportJobReport**](KnowledgeImportJobReport) | Report of the import job | [optional] |
| **KnowledgeBase** | [**KnowledgeBase**](KnowledgeBase) | Knowledge base which document import does belong to | [optional] |
| **CreatedBy** | [**UserReference**](UserReference) | The user who created the operation | [optional] |
| **DateCreated** | **DateTime?** | Created date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Last modified date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SkipConfirmationStep** | **bool?** | If enabled pre-validation step will be skipped. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 215.0.0_
