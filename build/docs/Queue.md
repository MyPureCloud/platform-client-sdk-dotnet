---
title: Queue
---
## ININ.PureCloudApi.Model.Queue

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Division** | [**UriReference**](UriReference.html) | The division to which this entity belongs. | [optional] |
| **Description** | **string** | The queue description. | [optional] |
| **Version** | **int?** | The current version of the queue. | [optional] |
| **DateCreated** | **DateTime?** | The date the queue was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | The date of the last modification to the queue. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ModifiedBy** | **string** | The ID of the user that last modified the queue. | [optional] |
| **CreatedBy** | **string** | The ID of the user that created the queue. | [optional] |
| **State** | **string** | Indicates if the queue is active, inactive, or deleted. | [optional] |
| **ModifiedByApp** | **string** | The application that last modified the queue. | [optional] |
| **CreatedByApp** | **string** | The application that created the queue. | [optional] |
| **MediaSettings** | [**Dictionary&lt;string, MediaSetting&gt;**](MediaSetting.html) | The media settings for the queue. Valid Key Values: CALL, CALLBACK, CHAT, EMAIL, SOCIAL_EXPRESSION | |
| **Bullseye** | [**Bullseye**](Bullseye.html) | The bulls-eye settings for the queue. | [optional] |
| **AcwSettings** | [**AcwSettings**](AcwSettings.html) | The ACW settings for the queue. | |
| **SkillEvaluationMethod** | **string** | The skill evaluation method to use when routing conversations. | |
| **QueueFlow** | [**UriReference**](UriReference.html) | The in-queue flow to use for conversations waiting in queue. | [optional] |
| **WhisperPrompt** | [**UriReference**](UriReference.html) | The prompt used for whisper on the queue, if configured. | [optional] |
| **AutoAnswerOnly** | **bool?** | Specifies whether the configured whisper should play for all ACD calls, or only for those which are auto-answered. | [optional] |
| **CallingPartyName** | **string** | The name to use for caller identification for outbound calls from this queue. | [optional] |
| **CallingPartyNumber** | **string** | The phone number to use for caller identification for outbound calls from this queue. | [optional] |
| **DefaultScripts** | [**Dictionary&lt;string, Script&gt;**](Script.html) | The default script Ids for the communication types. | [optional] |
| **OutboundEmailAddress** | [**QueueEmailAddress**](QueueEmailAddress.html) |  | [optional] |
| **MemberCount** | **int?** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


