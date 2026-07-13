# UploadAttachmentRequest

## ININ.PureCloudApi.Model.UploadAttachmentRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | Name of the attachment file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#| | |
| **ContentLengthBytes** | **int?** | The length of the file to upload in bytes | |
| **ContentMd5** | **string** | Content MD5 of the file to upload | [optional] |
| **InlineImage** | **bool?** | Whether or not the attachment should be attached inline | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
