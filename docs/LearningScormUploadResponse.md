# LearningScormUploadResponse

## ININ.PureCloudApi.Model.LearningScormUploadResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Status** | **string** | The status of the SCORM package | [optional] |
| **UploadUrl** | **string** | The pre-signed URL. Use it with headers below to upload file to S3 | [optional] |
| **Headers** | **Dictionary&lt;string, string&gt;** | The additional headers that need to be included in the upload request | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 235.0.0_
