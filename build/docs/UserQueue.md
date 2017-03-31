---
title: UserQueue
---
## ININ.PureCloudApi.Model.UserQueue

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Description** | **string** |  | [optional] |
| **Version** | **int?** |  | [optional] |
| **DateCreated** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ModifiedBy** | **string** |  | [optional] |
| **CreatedBy** | **string** |  | [optional] |
| **State** | **string** |  | [optional] |
| **ModifiedByApp** | **string** |  | [optional] |
| **CreatedByApp** | **string** |  | [optional] |
| **MediaSettings** | [**Dictionary&lt;string, MediaSetting&gt;**](MediaSetting.html) | The media settings for the queue. | |
| **Bullseye** | [**Bullseye**](Bullseye.html) | The bulls-eye settings for the queue. | [optional] |
| **AcwSettings** | [**AcwSettings**](AcwSettings.html) | The ACW settings for the queue. | |
| **SkillEvaluationMethod** | **string** | The skill evaluation method to use when routing conversations. | |
| **QueueFlow** | [**UriReference**](UriReference.html) | The in-queue flow to use for conversations waiting in queue. | [optional] |
| **CallingPartyName** | **string** | The name to use for caller identification for outbound calls from this queue. | [optional] |
| **CallingPartyNumber** | **string** | The phone number to use for caller identification for outbound calls from this queue. | [optional] |
| **DefaultScripts** | [**Dictionary&lt;string, Script&gt;**](Script.html) | The default script Ids for the communication types. | [optional] |
| **OutboundEmailAddress** | [**QueueEmailAddress**](QueueEmailAddress.html) |  | [optional] |
| **Joined** | **bool?** |  | [optional] |
| **MemberCount** | **int?** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


