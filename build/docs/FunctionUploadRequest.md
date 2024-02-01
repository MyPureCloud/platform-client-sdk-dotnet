---
title: FunctionUploadRequest
---
## ININ.PureCloudApi.Model.FunctionUploadRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **FileName** | **string** | Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#| | |
| **SignedUrlTimeoutSeconds** | **int?** | The number of seconds the presigned URL is valid for (from 1 to 604800 seconds). If none provided, defaults to 900 seconds | [optional] |
{: class="table table-striped"}


