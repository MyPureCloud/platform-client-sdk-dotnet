# KnowledgeImport

## ININ.PureCloudApi.Model.KnowledgeImport

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Id of the import operation | [optional] |
| **Name** | **string** | Name of the import operation | [optional] |
| **UploadKey** | **string** | Upload key | |
| **FileType** | **string** | file type of the document | |
| **IgnoreHeaders** | **bool?** | Ignore headers for the specified file | [optional] |
| **Status** | **string** | Status of the operation | [optional] |
| **Report** | [**ImportReport**](ImportReport) | Report of the import operation | [optional] |
| **KnowledgeBase** | [**KnowledgeBase**](KnowledgeBase) | Knowledge base which document import does belong to | [optional] |
| **LanguageCode** | **string** | Language code | [optional] |
| **DateCreated** | **DateTime?** | Created date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Last modified date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 224.1.0_
