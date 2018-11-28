---
title: AnalyticsSession
---
## ININ.PureCloudApi.Model.AnalyticsSession

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **MediaType** | **string** | The session media type | [optional] |
| **SessionId** | **string** | The unique identifier of this session | [optional] |
| **AddressOther** | **string** |  | [optional] |
| **AddressSelf** | **string** |  | [optional] |
| **AddressFrom** | **string** |  | [optional] |
| **AddressTo** | **string** |  | [optional] |
| **MessageType** | **string** | Message type for messaging services such as sms | [optional] |
| **Ani** | **string** | Automatic Number Identification (caller&#39;s number) | [optional] |
| **Direction** | **string** | Direction | [optional] |
| **Dnis** | **string** | Automatic Number Identification (caller&#39;s number) | [optional] |
| **OutboundCampaignId** | **string** | (Dialer) Unique identifier of the outbound campaign | [optional] |
| **OutboundContactId** | **string** | (Dialer) Unique identifier of the contact | [optional] |
| **OutboundContactListId** | **string** | (Dialer) Unique identifier of the contact list that this contact belongs to | [optional] |
| **DispositionAnalyzer** | **string** | (Dialer) Unique identifier of the contact list that this contact belongs to | [optional] |
| **DispositionName** | **string** | (Dialer) Result of the analysis | [optional] |
| **EdgeId** | **string** | Unique identifier of the edge device | [optional] |
| **RemoteNameDisplayable** | **string** |  | [optional] |
| **RoomId** | **string** | Unique identifier for the room | [optional] |
| **MonitoredSessionId** | **string** | The sessionID being monitored | [optional] |
| **MonitoredParticipantId** | **string** |  | [optional] |
| **CallbackUserName** | **string** | The name of the user requesting a call back | [optional] |
| **CallbackNumbers** | **List&lt;string&gt;** | List of numbers to callback | [optional] |
| **CallbackScheduledTime** | **DateTime?** | Scheduled callback date/time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ScriptId** | **string** | Scheduled callback date/time, Date time is represented as an ISO-8601 string.  | [optional] |
| **PeerId** | **string** | A unique identifier for a peer | [optional] |
| **SkipEnabled** | **bool?** | (Dialer) Whether the agent can skip the dialer contact | [optional] |
| **TimeoutSeconds** | **int?** | The number of seconds before PureCloud begins the call for a call back. 0 disables automatic calling | [optional] |
| **CobrowseRole** | **string** | Describe side of the cobrowse (sharer or viewer) | [optional] |
| **CobrowseRoomId** | **string** | A unique identifier for a PureCloud Cobrowse room. | [optional] |
| **MediaBridgeId** | **string** |  | [optional] |
| **ScreenShareAddressSelf** | **string** | Direct ScreenShare address | [optional] |
| **SharingScreen** | **bool?** | Flag determining if screenShare is started or not (true/false) | [optional] |
| **ScreenShareRoomId** | **string** | A unique identifier for a PureCloud ScreenShare room. | [optional] |
| **VideoRoomId** | **string** | A unique identifier for a PureCloud video room. | [optional] |
| **VideoAddressSelf** | **string** | Direct Video address | [optional] |
| **Segments** | [**List&lt;AnalyticsConversationSegment&gt;**](AnalyticsConversationSegment.html) | List of segments for this session | [optional] |
| **Metrics** | [**List&lt;AnalyticsSessionMetric&gt;**](AnalyticsSessionMetric.html) | List of metrics for this session | [optional] |
| **Flow** | [**AnalyticsFlow**](AnalyticsFlow.html) | IVR flow execution associated with this session | [optional] |
| **MediaEndpointStats** | [**List&lt;AnalyticsMediaEndpointStat&gt;**](AnalyticsMediaEndpointStat.html) | Media endpoint stats associated with this session | [optional] |
| **Recording** | **bool?** | Flag determining if an audio recording was started or not | [optional] |
{: class="table table-striped"}


