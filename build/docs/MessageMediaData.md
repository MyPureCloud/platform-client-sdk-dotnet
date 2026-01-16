# MessageMediaData

## ININ.PureCloudApi.Model.MessageMediaData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Url** | **string** | The location of the media, useful for retrieving it | [optional] |
| **MediaType** | **string** | The detected internet media type of the the media object.  If null then the media type should be dictated by the url. | [optional] |
| **ContentLengthBytes** | **int?** | The optional content length of the the media object, in bytes. | [optional] |
| **UploadUrl** | **string** | The URL returned to upload an attachment | [optional] |
| **Status** | **string** | The status of the media, indicates if the media is in the process of uploading. If the upload fails, the media becomes invalid | [optional] |
| **ConversationId** | **string** |  | [optional] |
| **CommunicationId** | **string** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 254.0.0_
