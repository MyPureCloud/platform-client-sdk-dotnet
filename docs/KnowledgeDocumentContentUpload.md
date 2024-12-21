# KnowledgeDocumentContentUpload

## ININ.PureCloudApi.Model.KnowledgeDocumentContentUpload

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **ContentType** | **string** | Type of Article Content. | |
| **FileName** | **string** | Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#| | |
| **Status** | **string** | Status of the upload operation | [optional] |
| **UploadKey** | **string** | Key that identifies the file in the storage including the file name | [optional] |
| **Url** | **string** | Presigned URL to PUT the file to | [optional] |
| **Headers** | **Dictionary&lt;string, string&gt;** | Required headers when uploading a file through PUT request to the URL | [optional] |
| **Document** | [**AddressableEntityRef**](AddressableEntityRef) | ID of the document for which article content is to be uploaded | [optional] |
| **ErrorMessage** | **string** | Error message when upload fails | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 224.0.0_
