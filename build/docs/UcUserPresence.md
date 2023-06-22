---
title: UcUserPresence
---
## ININ.PureCloudApi.Model.UcUserPresence

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **UserId** | **string** | User ID of the associated Genesys Cloud user. | [optional] |
| **Source** | **string** | Represents the source where the Presence was set. Some examples are: PURECLOUD, MICROSOFTTEAMS, ZOOMPHONE, etc. | [optional] |
| **PresenceDefinition** | [**PresenceDefinition**](PresenceDefinition.html) |  | [optional] |
| **Message** | **string** |  | [optional] |
| **ModifiedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


