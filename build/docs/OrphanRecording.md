---
title: OrphanRecording
---
## ININ.PureCloudApi.Model.OrphanRecording

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **CreatedTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **RecoveredTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ProviderType** | **string** |  | [optional] |
| **MediaSizeBytes** | **long?** |  | [optional] |
| **MediaType** | **string** |  | [optional] |
| **FileState** | **string** |  | [optional] |
| **ProviderEndpoint** | [**Endpoint**](Endpoint.html) |  | [optional] |
| **Recording** | [**Recording**](Recording.html) |  | [optional] |
| **OrphanStatus** | **string** | The status of the orphaned recording&#39;s conversation. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


