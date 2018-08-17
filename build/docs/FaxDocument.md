---
title: FaxDocument
---
## ININ.PureCloudApi.Model.FaxDocument

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ContentUri** | **string** |  | [optional] |
| **Workspace** | [**UriReference**](UriReference.html) |  | [optional] |
| **CreatedBy** | [**UriReference**](UriReference.html) |  | [optional] |
| **ContentType** | **string** |  | [optional] |
| **ContentLength** | **long?** |  | [optional] |
| **Filename** | **string** |  | [optional] |
| **Read** | **bool?** |  | [optional] |
| **PageCount** | **long?** |  | [optional] |
| **CallerAddress** | **string** |  | [optional] |
| **ReceiverAddress** | **string** |  | [optional] |
| **Thumbnails** | [**List&lt;DocumentThumbnail&gt;**](DocumentThumbnail.html) |  | [optional] |
| **DownloadSharingUri** | **string** |  | [optional] |
| **SharingUri** | **string** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


