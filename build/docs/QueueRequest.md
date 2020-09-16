---
title: QueueRequest
---
## ININ.PureCloudApi.Model.QueueRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The queue name | |
| **Division** | [**WritableDivision**](WritableDivision.html) | The division to which this entity belongs. | [optional] |
| **Description** | **string** | The queue description. | [optional] |
| **DateCreated** | **DateTime?** | The date the queue was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | The date of the last modification to the queue. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ModifiedBy** | **string** | The ID of the user that last modified the queue. | [optional] |
| **CreatedBy** | **string** | The ID of the user that created the queue. | [optional] |
| **MemberCount** | **int?** | The number of users in the queue. | [optional] |
| **MediaSettings** | [**Dictionary&lt;string, MediaSetting&gt;**](MediaSetting.html) | The media settings for the queue. Valid key values: CALL, CALLBACK, CHAT, EMAIL, MESSAGE, SOCIAL_EXPRESSION, VIDEO_COMM | [optional] |
| **RoutingRules** | [**List&lt;RoutingRule&gt;**](RoutingRule.html) | The routing rules for the queue, used for routing to known or preferred agents. | [optional] |
| **Bullseye** | [**Bullseye**](Bullseye.html) | The bulls-eye settings for the queue. | [optional] |
| **AcwSettings** | [**AcwSettings**](AcwSettings.html) | The ACW settings for the queue. | [optional] |
| **SkillEvaluationMethod** | **string** | The skill evaluation method to use when routing conversations. | [optional] |
| **QueueFlow** | [**DomainEntityRef**](DomainEntityRef.html) | The in-queue flow to use for conversations waiting in queue. | [optional] |
| **WhisperPrompt** | [**DomainEntityRef**](DomainEntityRef.html) | The prompt used for whisper on the queue, if configured. | [optional] |
| **AutoAnswerOnly** | **bool?** | Specifies whether the configured whisper should play for all ACD calls, or only for those which are auto-answered. | [optional] |
| **EnableTranscription** | **bool?** | Indicates whether voice transcription is enabled for this queue. | [optional] |
| **EnableManualAssignment** | **bool?** | Indicates whether manual assignment is enabled for this queue. | [optional] |
| **CallingPartyName** | **string** | The name to use for caller identification for outbound calls from this queue. | [optional] |
| **CallingPartyNumber** | **string** | The phone number to use for caller identification for outbound calls from this queue. | [optional] |
| **DefaultScripts** | [**Dictionary&lt;string, Script&gt;**](Script.html) | The default script Ids for the communication types. | [optional] |
| **OutboundMessagingAddresses** | [**QueueMessagingAddresses**](QueueMessagingAddresses.html) | The messaging addresses for the queue. | [optional] |
| **OutboundEmailAddress** | [**QueueEmailAddress**](QueueEmailAddress.html) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


