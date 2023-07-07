---
title: MediaStatistics
---
## ININ.PureCloudApi.Model.MediaStatistics

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **CommunicationId** | **string** |  | [optional] |
| **DateStart** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreationMilliseconds** | **long?** | Relative milliseconds to create media session | [optional] |
| **PreferredRegion** | **string** | Preferred media region | [optional] |
| **EffectiveRegion** | **string** | Actual media region | [optional] |
| **_MediaStatistics** | [**List&lt;MediaEndpointStatistics&gt;**](MediaEndpointStatistics.html) | Media statistics for each media endpoint | [optional] |
{: class="table table-striped"}


