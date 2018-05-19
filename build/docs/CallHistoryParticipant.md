---
title: CallHistoryParticipant
---
## ININ.PureCloudApi.Model.CallHistoryParticipant

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The unique participant ID. | [optional] |
| **Name** | **string** | The display friendly name of the participant. | [optional] |
| **Address** | **string** | The participant address. | [optional] |
| **StartTime** | **DateTime?** | The time when this participant first joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **EndTime** | **DateTime?** | The time when this participant went disconnected for this media (eg: video disconnected time). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Purpose** | **string** | The participant&#39;s purpose.  Values can be: &#39;agent&#39;, &#39;user&#39;, &#39;customer&#39;, &#39;external&#39;, &#39;acd&#39;, &#39;ivr | [optional] |
| **Direction** | **string** | The participant&#39;s direction.  Values can be: &#39;inbound&#39; or &#39;outbound&#39; | [optional] |
| **Ani** | **string** | The call ANI. | [optional] |
| **Dnis** | **string** | The call DNIS. | [optional] |
| **User** | [**User**](User.html) | The PureCloud user for this participant. | [optional] |
| **Queue** | [**Queue**](Queue.html) | The PureCloud queue for this participant. | [optional] |
| **Group** | [**Group**](Group.html) | The group involved in the group ring call. | [optional] |
| **DisconnectType** | **string** | The reason the participant was disconnected from the conversation. | [optional] |
| **ExternalContact** | [**ExternalContact**](ExternalContact.html) | The PureCloud external contact | [optional] |
| **ExternalOrganization** | [**ExternalOrganization**](ExternalOrganization.html) | The PureCloud external organization | [optional] |
| **DidInteract** | **bool?** | Indicates whether the contact ever connected | [optional] |
| **SipResponseCodes** | **List&lt;long?&gt;** | Indicates SIP Response codes associated with the participant | [optional] |
| **FlaggedReason** | **string** | The reason specifying why participant flagged the conversation. | [optional] |
{: class="table table-striped"}


