---
title: Document
---
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
| **Workspace** | [**DomainEntityRef**](DomainEntityRef.html) |  | [optional] |
| **CreatedBy** | [**DomainEntityRef**](DomainEntityRef.html) |  | [optional] |
| **UploadedBy** | [**DomainEntityRef**](DomainEntityRef.html) |  | [optional] |
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
| **TagValues** | [**List&lt;TagValue&gt;**](TagValue.html) |  | [optional] |
| **Attributes** | [**List&lt;DocumentAttribute&gt;**](DocumentAttribute.html) |  | [optional] |
| **Thumbnails** | [**List&lt;DocumentThumbnail&gt;**](DocumentThumbnail.html) |  | [optional] |
| **UploadStatus** | [**DomainEntityRef**](DomainEntityRef.html) |  | [optional] |
| **UploadDestinationUri** | **string** |  | [optional] |
| **UploadMethod** | **string** |  | [optional] |
| **LockInfo** | [**LockInfo**](LockInfo.html) |  | [optional] |
| **Acl** | **List&lt;string&gt;** | A list of permitted action rights for the user making the request | [optional] |
| **SharingStatus** | **string** |  | [optional] |
| **DownloadSharingUri** | **string** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


