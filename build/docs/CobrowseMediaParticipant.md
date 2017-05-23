---
title: CobrowseMediaParticipant
---
## ININ.PureCloudApi.Model.CobrowseMediaParticipant

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
| **User** | [**UriReference**](UriReference.html) | The PureCloud user for this participant. | [optional] |
| **Queue** | [**UriReference**](UriReference.html) | The PureCloud queue for this participant. | [optional] |
| **Attributes** | **Dictionary&lt;string, string&gt;** | A list of ad-hoc attributes for the participant. | [optional] |
| **ErrorInfo** | [**ErrorBody**](ErrorBody.html) | If the conversation ends in error, contains additional error details. | [optional] |
| **Script** | [**UriReference**](UriReference.html) | The Engage script that should be used by this participant. | [optional] |
| **WrapupTimeoutMs** | **int?** | The amount of time the participant has to complete wrap-up. | [optional] |
| **WrapupSkipped** | **bool?** | Value is true when the participant has skipped wrap-up. | [optional] |
| **Provider** | **string** | The source provider for the communication. | [optional] |
| **ExternalContact** | [**UriReference**](UriReference.html) | If this participant represents an external contact, then this will be the reference for the external contact. | [optional] |
| **ExternalOrganization** | [**UriReference**](UriReference.html) | If this participant represents an external org, then this will be the reference for the external org. | [optional] |
| **Wrapup** | [**Wrapup**](Wrapup.html) | Wrapup for this participant, if it has been applied. | [optional] |
| **Peer** | **string** | The peer communication corresponding to a matching leg for this communication. | [optional] |
| **CobrowseSessionId** | **string** | The co-browse session ID. | [optional] |
| **CobrowseRole** | **string** | This value identifies the role of the co-browse client within the co-browse session (a client is a sharer or a viewer). | [optional] |
| **Controlling** | **List&lt;string&gt;** | ID of co-browse participants for which this client has been granted control (list is empty if this client cannot control any shared pages). | [optional] |
| **ViewerUrl** | **string** | The URL that can be used to open co-browse session in web browser. | [optional] |
| **ProviderEventTime** | **DateTime?** | The time when the provider event which triggered this conversation update happened in the corrected provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
{: class="table table-striped"}


