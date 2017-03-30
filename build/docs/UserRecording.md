---
title: UserRecording
---
## ININ.PureCloudApi.Model.UserRecording

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
| **Conversation** | [**Conversation**](Conversation.html) |  | [optional] |
| **ContentLength** | **long?** |  | [optional] |
| **DurationMilliseconds** | **long?** |  | [optional] |
| **Thumbnails** | [**List&lt;DocumentThumbnail&gt;**](DocumentThumbnail.html) |  | [optional] |
| **Read** | **bool?** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


