# V3SynchronizationUploadUrlResponse

## ININ.PureCloudApi.Model.V3SynchronizationUploadUrlResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **FileId** | **string** | The unique identifier for the upload object. | [optional] |
| **FileName** | **string** | Name of the uploaded file. | [optional] |
| **Metadata** | [**V3SynchronizationUploadMetadata**](V3SynchronizationUploadMetadata) | The metadata of the uploaded file | [optional] |
| **Synchronization** | [**V3SynchronizationRef**](V3SynchronizationRef) | The synchronization of the file upload. | [optional] |
| **Url** | **string** | Pre-signed URL to PUT the file to. | [optional] |
| **Headers** | **Dictionary&lt;string, string&gt;** | Required headers when uploading a file through PUT request to the URL. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
