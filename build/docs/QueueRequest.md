# QueueRequest

## ININ.PureCloudApi.Model.QueueRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The queue name | |
| **Division** | [**WritableDivision**](WritableDivision) | The division to which this entity belongs. | [optional] |
| **Description** | **string** | The queue description. | [optional] |
| **DateCreated** | **DateTime?** | The date the queue was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The date of the last modification to the queue. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedBy** | **string** | The ID of the user that last modified the queue. | [optional] |
| **CreatedBy** | **string** | The ID of the user that created the queue. | [optional] |
| **MemberCount** | **int?** | The total number of members in the queue. | [optional] |
| **UserMemberCount** | **int?** | The number of user members (i.e., non-group members) in the queue. | [optional] |
| **JoinedMemberCount** | **int?** | The number of joined members in the queue. | [optional] |
| **MediaSettings** | [**QueueMediaSettings**](QueueMediaSettings) | The media settings for the queue. | [optional] |
| **RoutingRules** | [**List&lt;RoutingRule&gt;**](RoutingRule) | The routing rules for the queue, used for Preferred Agent Routing. | [optional] |
| **ConditionalGroupRouting** | [**ConditionalGroupRouting**](ConditionalGroupRouting) | The Conditional Group Routing settings for the queue. | [optional] |
| **Bullseye** | [**Bullseye**](Bullseye) | The bullseye settings for the queue. | [optional] |
| **ScoringMethod** | **string** | The Scoring Method for the queue | [optional] |
| **AcwSettings** | [**AcwSettings**](AcwSettings) | The ACW settings for the queue. | [optional] |
| **SkillEvaluationMethod** | **string** | The skill evaluation method to use when routing conversations. | [optional] |
| **MemberGroups** | [**List&lt;MemberGroup&gt;**](MemberGroup) | The groups of agents associated with the queue, if any.  Queue membership will update to match group membership changes. | [optional] |
| **QueueFlow** | [**DomainEntityRef**](DomainEntityRef) | The in-queue flow to use for call conversations waiting in queue. | [optional] |
| **EmailInQueueFlow** | [**DomainEntityRef**](DomainEntityRef) | The in-queue flow to use for email conversations waiting in queue. | [optional] |
| **MessageInQueueFlow** | [**DomainEntityRef**](DomainEntityRef) | The in-queue flow to use for message conversations waiting in queue. | [optional] |
| **WhisperPrompt** | [**DomainEntityRef**](DomainEntityRef) | The prompt used for whisper on the queue, if configured. | [optional] |
| **OnHoldPrompt** | [**DomainEntityRef**](DomainEntityRef) | The audio to be played when calls on this queue are on hold. If not configured, the default on-hold music will play. | [optional] |
| **AutoAnswerOnly** | **bool?** | Specifies whether the configured whisper should play for all ACD calls, or only for those which are auto-answered. | [optional] |
| **CannedResponseLibraries** | [**CannedResponseLibraries**](CannedResponseLibraries) | Canned response library IDs and mode with which they are associated with the queue | [optional] |
| **EnableTranscription** | **bool?** | Indicates whether voice transcription is enabled for this queue. | [optional] |
| **EnableAudioMonitoring** | **bool?** | Indicates whether audio monitoring is enabled for this queue. | [optional] |
| **EnableManualAssignment** | **bool?** | Indicates whether manual assignment is enabled for this queue. | [optional] |
| **AgentOwnedRouting** | [**AgentOwnedRouting**](AgentOwnedRouting) | The Agent Owned Routing settings for the queue | [optional] |
| **DirectRouting** | [**DirectRouting**](DirectRouting) | The Direct Routing settings for the queue | [optional] |
| **CallingPartyName** | **string** | The name to use for caller identification for outbound calls from this queue. | [optional] |
| **CallingPartyNumber** | **string** | The phone number to use for caller identification for outbound calls from this queue. | [optional] |
| **DefaultScripts** | [**Dictionary&lt;string, Script&gt;**](Script) | The default script Ids for the communication types. | [optional] |
| **OutboundMessagingAddresses** | [**QueueMessagingAddresses**](QueueMessagingAddresses) | The messaging addresses for the queue. | [optional] |
| **OutboundEmailAddress** | [**QueueEmailAddress**](QueueEmailAddress) |  | [optional] |
| **PeerId** | **string** | The ID of an associated external queue. | [optional] |
| **SuppressInQueueCallRecording** | **bool?** | Indicates whether recording in-queue calls is suppressed for this queue. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 217.0.0_
