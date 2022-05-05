---
title: UploadUrlRequest
---
## ININ.PureCloudApi.Model.UploadUrlRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **FileName** | **string** | Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%`]\&quot;&gt;[~&lt;#| | [optional] |
| **ContentMd5** | **string** | Content MD5 of the file to upload | [optional] |
| **SignedUrlTimeoutSeconds** | **int?** | The number of seconds the presigned URL is valid for (from 1 to 604800 seconds). If none provided, defaults to 600 seconds | [optional] |
| **ServerSideEncryption** | **string** |  | [optional] |
{: class="table table-striped"}


