---
title: Room
---
## ININ.PureCloudApi.Model.Room

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The jid of the room | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Room&#39;s created time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **RoomType** | **string** | The type of room | [optional] |
| **Description** | **string** | Room&#39;s description | [optional] |
| **Subject** | **string** | Room&#39;s subject | [optional] |
| **ParticipantLimit** | **int?** | Room&#39;s size limit | [optional] |
| **Owners** | [**List&lt;UserReference&gt;**](UserReference.html) | Room&#39;s owners | [optional] |
| **PinnedMessages** | [**List&lt;AddressableEntityRef&gt;**](AddressableEntityRef.html) | Room&#39;s pinned messages | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


