# Document

## ININ.PureCloudApi.Model.Document

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **ChangeNumber** | **int?** |  | [optional] |
| **DateCreated** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateUploaded** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ContentUri** | **string** |  | [optional] |
| **Workspace** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **CreatedBy** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **UploadedBy** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **SharingUri** | **string** |  | [optional] |
| **ContentType** | **string** |  | [optional] |
| **ContentLength** | **long?** |  | [optional] |
| **SystemType** | **string** |  | [optional] |
| **Filename** | **string** |  | [optional] |
| **PageCount** | **long?** |  | [optional] |
| **Read** | **bool?** |  | [optional] |
| **CallerAddress** | **string** |  | [optional] |
| **ReceiverAddress** | **string** |  | [optional] |
| **Tags** | **List&lt;string&gt;** |  | [optional] |
| **TagValues** | [**List&lt;TagValue&gt;**](TagValue) |  | [optional] |
| **Attributes** | [**List&lt;DocumentAttribute&gt;**](DocumentAttribute) |  | [optional] |
| **Thumbnails** | [**List&lt;DocumentThumbnail&gt;**](DocumentThumbnail) |  | [optional] |
| **UploadStatus** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **UploadDestinationUri** | **string** |  | [optional] |
| **UploadMethod** | **string** |  | [optional] |
| **LockInfo** | [**LockInfo**](LockInfo) |  | [optional] |
| **Acl** | **List&lt;string&gt;** | A list of permitted action rights for the user making the request | [optional] |
| **SharingStatus** | **string** |  | [optional] |
| **DownloadSharingUri** | **string** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 215.1.0_
