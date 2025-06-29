# UploadUrlRequest

## ININ.PureCloudApi.Model.UploadUrlRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **FileName** | **string** | Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#| | [optional] |
| **ContentMd5** | **string** | Content MD5 of the file to upload | [optional] |
| **SignedUrlTimeoutSeconds** | **int?** | The number of seconds the presigned URL is valid for (from 1 to 604800 seconds). If none provided, defaults to 600 seconds | [optional] |
| **ContentType** | **string** | The content type of the file to upload. Allows all MIME types | [optional] |
| **ServerSideEncryption** | **string** |  | [optional] |



_PureCloudPlatform.Client.V2 237.0.0_
