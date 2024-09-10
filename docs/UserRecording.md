# UserRecording

## ININ.PureCloudApi.Model.UserRecording

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ContentUri** | **string** |  | [optional] |
| **Workspace** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **CreatedBy** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **Conversation** | [**Conversation**](Conversation) |  | [optional] |
| **ContentLength** | **long?** |  | [optional] |
| **DurationMilliseconds** | **long?** |  | [optional] |
| **Thumbnails** | [**List&lt;DocumentThumbnail&gt;**](DocumentThumbnail) |  | [optional] |
| **Read** | **bool?** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 215.0.0_
