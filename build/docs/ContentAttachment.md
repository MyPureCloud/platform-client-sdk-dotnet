# ContentAttachment

## ININ.PureCloudApi.Model.ContentAttachment

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Provider specific ID for attachment. For example, a LINE sticker ID. | [optional] |
| **MediaType** | **string** | The type of attachment this instance represents. | |
| **Url** | **string** | URL of the attachment. | [optional] |
| **Mime** | **string** | Attachment mime type (https://www.iana.org/assignments/media-types/media-types.xhtml). | [optional] |
| **Text** | **string** | Text associated with attachment such as an image caption. | [optional] |
| **Sha256** | **string** | Secure hash of the attachment content. | [optional] |
| **Filename** | **string** | Suggested file name for attachment. | [optional] |
| **ContentSizeBytes** | **long?** | Size in bytes of the attachment content. | [optional] |



_PureCloudPlatform.Client.V2 222.0.0_
