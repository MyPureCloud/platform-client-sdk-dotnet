# ScreenMonitoringSession

## ININ.PureCloudApi.Model.ScreenMonitoringSession

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SourceUser** | [**AddressableEntityRef**](AddressableEntityRef) | The user who initiated the screen monitoring session | |
| **TargetUser** | [**AddressableEntityRef**](AddressableEntityRef) | The user being monitored (for agent-level monitoring) | [optional] |
| **Conversation** | [**AddressableEntityRef**](AddressableEntityRef) | The conversation being monitored (for conversation-level monitoring) | [optional] |
| **ParticipantId** | **string** | The ID of the participant being monitored (for conversation-level monitoring) | [optional] |
| **MonitoringType** | **string** | The type of screen monitoring session | |
| **DateCreated** | **DateTime?** | The date and time when the screen monitoring session was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **ScreenMonitoringId** | **string** | The unique identifier for this screen monitoring session | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
