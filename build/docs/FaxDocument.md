# FaxDocument

## ININ.PureCloudApi.Model.FaxDocument

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
| **SharingUri** | **string** |  | [optional] |
| **ContentType** | **string** |  | [optional] |
| **ContentLength** | **long?** |  | [optional] |
| **Filename** | **string** |  | [optional] |
| **Read** | **bool?** |  | [optional] |
| **PageCount** | **long?** |  | [optional] |
| **CallerAddress** | **string** |  | [optional] |
| **ReceiverAddress** | **string** |  | [optional] |
| **Thumbnails** | [**List&lt;DocumentThumbnail&gt;**](DocumentThumbnail) |  | [optional] |
| **DownloadSharingUri** | **string** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 245.0.0_
