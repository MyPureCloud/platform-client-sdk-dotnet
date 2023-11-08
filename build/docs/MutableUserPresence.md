---
title: MutableUserPresence
---
## ININ.PureCloudApi.Model.MutableUserPresence

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The user&#39;s id | [optional] |
| **Name** | **string** |  | [optional] |
| **Source** | **string** | Represents the source where the Presence was set. Some examples are: PURECLOUD, LYNC, OUTLOOK, etc. | [optional] |
| **Primary** | **bool?** | A boolean used to tell whether or not to set this presence source as the primary on a PATCH | [optional] |
| **PresenceDefinition** | [**PresenceDefinition**](PresenceDefinition.html) |  | [optional] |
| **Message** | **string** |  | [optional] |
| **ModifiedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


