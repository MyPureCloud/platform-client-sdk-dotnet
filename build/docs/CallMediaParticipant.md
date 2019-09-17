---
title: CallMediaParticipant
---
## ININ.PureCloudApi.Model.CallMediaParticipant

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The unique participant ID. | [optional] |
| **Name** | **string** | The display friendly name of the participant. | [optional] |
| **Address** | **string** | The participant address. | [optional] |
| **StartTime** | **DateTime?** | The time when this participant first joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ConnectedTime** | **DateTime?** | The time when this participant went connected for this media (eg: video connected time). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **EndTime** | **DateTime?** | The time when this participant went disconnected for this media (eg: video disconnected time). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **StartHoldTime** | **DateTime?** | The time when this participant&#39;s hold started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Purpose** | **string** | The participant&#39;s purpose.  Values can be: &#39;agent&#39;, &#39;user&#39;, &#39;customer&#39;, &#39;external&#39;, &#39;acd&#39;, &#39;ivr | [optional] |
| **State** | **string** | The participant&#39;s state.  Values can be: &#39;alerting&#39;, &#39;connected&#39;, &#39;disconnected&#39;, &#39;dialing&#39;, &#39;contacting | [optional] |
| **Direction** | **string** | The participant&#39;s direction.  Values can be: &#39;inbound&#39; or &#39;outbound&#39; | [optional] |
| **DisconnectType** | **string** | The reason the participant was disconnected from the conversation. | [optional] |
| **Held** | **bool?** | Value is true when the participant is on hold. | [optional] |
| **WrapupRequired** | **bool?** | Value is true when the participant requires wrap-up. | [optional] |
| **WrapupPrompt** | **string** | The wrap-up prompt indicating the type of wrap-up to be performed. | [optional] |
| **User** | [**DomainEntityRef**](DomainEntityRef.html) | The PureCloud user for this participant. | [optional] |
| **Queue** | [**DomainEntityRef**](DomainEntityRef.html) | The PureCloud queue for this participant. | [optional] |
| **Attributes** | **Dictionary&lt;string, string&gt;** | A list of ad-hoc attributes for the participant. | [optional] |
| **ErrorInfo** | [**ErrorBody**](ErrorBody.html) | If the conversation ends in error, contains additional error details. | [optional] |
| **Script** | [**DomainEntityRef**](DomainEntityRef.html) | The Engage script that should be used by this participant. | [optional] |
| **WrapupTimeoutMs** | **int?** | The amount of time the participant has to complete wrap-up. | [optional] |
| **WrapupSkipped** | **bool?** | Value is true when the participant has skipped wrap-up. | [optional] |
| **AlertingTimeoutMs** | **int?** | Specifies how long the agent has to answer an interaction before being marked as not responding. | [optional] |
| **Provider** | **string** | The source provider for the communication. | [optional] |
| **ExternalContact** | [**DomainEntityRef**](DomainEntityRef.html) | If this participant represents an external contact, then this will be the reference for the external contact. | [optional] |
| **ExternalOrganization** | [**DomainEntityRef**](DomainEntityRef.html) | If this participant represents an external org, then this will be the reference for the external org. | [optional] |
| **Wrapup** | [**Wrapup**](Wrapup.html) | Wrapup for this participant, if it has been applied. | [optional] |
| **Peer** | **string** | The peer communication corresponding to a matching leg for this communication. | [optional] |
| **FlaggedReason** | **string** | The reason specifying why participant flagged the conversation. | [optional] |
| **JourneyContext** | [**JourneyContext**](JourneyContext.html) | Journey System data/context that is applicable to this communication.  When used for historical purposes, the context should be immutable.  When null, there is no applicable Journey System context. | [optional] |
| **ConversationRoutingData** | [**ConversationRoutingData**](ConversationRoutingData.html) | Information on how a communication should be routed to an agent. | [optional] |
| **Muted** | **bool?** | Value is true when the call is muted. | [optional] |
| **Confined** | **bool?** | Value is true when the call is confined. | [optional] |
| **Recording** | **bool?** | Value is true when the call is being recorded. | [optional] |
| **RecordingState** | **string** | The state of the call recording. | [optional] |
| **Group** | [**DomainEntityRef**](DomainEntityRef.html) | The group involved in the group ring call. | [optional] |
| **Ani** | **string** | The call ANI. | [optional] |
| **Dnis** | **string** | The call DNIS. | [optional] |
| **DocumentId** | **string** | The ID of the Content Management document if the call is a fax. | [optional] |
| **FaxStatus** | [**FaxStatus**](FaxStatus.html) | Extra fax information if the call is a fax. | [optional] |
| **MonitoredParticipantId** | **string** | The ID of the participant being monitored when performing a call monitor. | [optional] |
| **ConsultParticipantId** | **string** | The ID of the consult transfer target participant when performing a consult transfer. | [optional] |
| **UuiData** | **string** | User-to-User information which maps to a SIP header field defined in RFC7433. UUI data is used in the Public Switched Telephone Network (PSTN) for use cases described in RFC6567. | [optional] |
{: class="table table-striped"}


