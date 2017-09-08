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
| **User** | [**UriReference**](UriReference.html) | The PureCloud user for this participant. | [optional] |
| **Queue** | [**UriReference**](UriReference.html) | The PureCloud queue for this participant. | [optional] |
| **Group** | [**UriReference**](UriReference.html) | The group involved in the group ring call. | [optional] |
| **DisconnectType** | **string** | The reason the participant was disconnected from the conversation. | [optional] |
| **ExternalContact** | [**UriReference**](UriReference.html) | The PureCloud external contact | [optional] |
| **ExternalOrganization** | [**UriReference**](UriReference.html) | The PureCloud external organization | [optional] |
{: class="table table-striped"}


