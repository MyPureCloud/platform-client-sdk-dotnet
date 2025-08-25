# CallbackMediaParticipant

## ININ.PureCloudApi.Model.CallbackMediaParticipant

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The unique participant ID. | [optional] |
| **Name** | **string** | The display friendly name of the participant. | [optional] |
| **Address** | **string** | The participant address. | [optional] |
| **StartTime** | **DateTime?** | The time when this participant first joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **StartAlertingTime** | **DateTime?** | The timestamp when it is first put into an alerting state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ConnectedTime** | **DateTime?** | The time when this participant went connected for this media (eg: video connected time). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **EndTime** | **DateTime?** | The time when this participant went disconnected for this media (eg: video disconnected time). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **StartHoldTime** | **DateTime?** | The time when this participant&#39;s hold started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Purpose** | **string** | The participant&#39;s purpose.  Values can be: &#39;agent&#39;, &#39;user&#39;, &#39;customer&#39;, &#39;external&#39;, &#39;acd&#39;, &#39;ivr | [optional] |
| **State** | **string** | The participant&#39;s state.  Values can be: &#39;alerting&#39;, &#39;connected&#39;, &#39;disconnected&#39;, &#39;dialing&#39;, &#39;contacting | [optional] |
| **Direction** | **string** | The participant&#39;s direction.  Values can be: &#39;inbound&#39; or &#39;outbound&#39; | [optional] |
| **DisconnectType** | **string** | The reason the participant was disconnected from the conversation. | [optional] |
| **Held** | **bool?** | Value is true when the participant is on hold. | [optional] |
| **WrapupRequired** | **bool?** | Value is true when the participant requires wrap-up. | [optional] |
| **WrapupPrompt** | **string** | The wrap-up prompt indicating the type of wrap-up to be performed. | [optional] |
| **MediaRoles** | **List&lt;string&gt;** | List of roles this participant&#39;s media has had on the conversation, ie monitor, coach, etc | [optional] |
| **User** | [**DomainEntityRef**](DomainEntityRef) | The PureCloud user for this participant. | [optional] |
| **Queue** | [**DomainEntityRef**](DomainEntityRef) | The PureCloud queue for this participant. | [optional] |
| **Team** | [**DomainEntityRef**](DomainEntityRef) | The PureCloud team for this participant. | [optional] |
| **Attributes** | **Dictionary&lt;string, string&gt;** | A list of ad-hoc attributes for the participant. | [optional] |
| **ErrorInfo** | [**ErrorInfo**](ErrorInfo) | If the conversation ends in error, contains additional error details. | [optional] |
| **Script** | [**DomainEntityRef**](DomainEntityRef) | The Engage script that should be used by this participant. | [optional] |
| **WrapupTimeoutMs** | **int?** | The amount of time the participant has to complete wrap-up. | [optional] |
| **WrapupSkipped** | **bool?** | Value is true when the participant has skipped wrap-up. | [optional] |
| **AlertingTimeoutMs** | **int?** | Specifies how long the agent has to answer an interaction before being marked as not responding. | [optional] |
| **Provider** | **string** | The source provider for the communication. | [optional] |
| **ExternalContact** | [**DomainEntityRef**](DomainEntityRef) | If this participant represents an external contact, then this will be the reference for the external contact. | [optional] |
| **ExternalContactInitialDivisionId** | **string** | If this participant represents an external contact, then this will be the initial division for the external contact. This value will not be updated if the external contact is reassigned. | [optional] |
| **ExternalOrganization** | [**DomainEntityRef**](DomainEntityRef) | If this participant represents an external org, then this will be the reference for the external org. | [optional] |
| **Wrapup** | [**Wrapup**](Wrapup) | Wrapup for this participant, if it has been applied. | [optional] |
| **Peer** | **string** | The peer communication corresponding to a matching leg for this communication. | [optional] |
| **FlaggedReason** | **string** | The reason specifying why participant flagged the conversation. | [optional] |
| **JourneyContext** | [**JourneyContext**](JourneyContext) | Journey System data/context that is applicable to this communication.  When used for historical purposes, the context should be immutable.  When null, there is no applicable Journey System context. | [optional] |
| **ConversationRoutingData** | [**ConversationRoutingData**](ConversationRoutingData) | Information on how a communication should be routed to an agent. | [optional] |
| **StartAcwTime** | **DateTime?** | The timestamp when this participant started after-call work. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **EndAcwTime** | **DateTime?** | The timestamp when this participant ended after-call work. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ParkTime** | **DateTime?** | The time when this participant&#39;s communication was last parked.  Does not reset on resume. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ResumeTime** | **DateTime?** | The time when this participant&#39;s communications will resume. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **OutboundPreview** | [**DialerPreview**](DialerPreview) | The outbound preview associated with this callback. | [optional] |
| **Voicemail** | [**Voicemail**](Voicemail) | The voicemail associated with this callback. | [optional] |
| **CallbackNumbers** | **List&lt;string&gt;** | The list of phone number to use for this callback. | [optional] |
| **CallbackUserName** | **string** | The name of the callback target. | [optional] |
| **ExternalCampaign** | **bool?** | True if the call for the callback uses external dialing. | [optional] |
| **SkipEnabled** | **bool?** | If true, the callback can be skipped. | [optional] |
| **TimeoutSeconds** | **int?** | Duration in seconds before the callback will be auto-dialed. | [optional] |
| **AutomatedCallbackConfigId** | **string** | The id of the config for automatically placing the callback (and handling the disposition). If absent, the callback will not be placed automatically but routed to an agent as per normal. | [optional] |
| **CallbackScheduledTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |



_PureCloudPlatform.Client.V2 240.0.0_
