# V3SynchronizationUploadUrlRequest

## ININ.PureCloudApi.Model.V3SynchronizationUploadUrlRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **FileName** | **string** | Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#| | |
| **ContentMd5** | **string** | Content MD5 of the file to upload encoded in base64, example: \&quot;f8VicOenD6gaWTW3Lqy+KQ&#x3D;&#x3D;\&quot;. Not the hexadecimal representation as \&quot;7fc56270e7a70fa81a5935b72eacbe29\&quot;. | [optional] |
| **ContentType** | **string** | The content type of the file to upload | [optional] |
| **ContentLength** | **int?** | The length of the file to upload in bytes | [optional] |
| **Metadata** | [**V3SynchronizationUploadMetadata**](V3SynchronizationUploadMetadata) | The metadata of the file to upload | [optional] |



_PureCloudPlatform.Client.V2 262.0.0_
