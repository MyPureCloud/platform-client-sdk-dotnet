# ScreenMonitoring

## ININ.PureCloudApi.Model.ScreenMonitoring

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | A globally unique identifier for this communication. | [optional] |
| **InitialState** | **string** | The initial connection state of this communication. | [optional] |
| **State** | **string** | The connection state of this communication. | [optional] |
| **Segments** | [**List&lt;Segment&gt;**](Segment) | The time line of the participant&#39;s Screen Monitoring media, divided into activity segments. | [optional] |
| **DisconnectType** | **string** | System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects. | [optional] |
| **Provider** | **string** | The source provider of Screen Monitoring media. | [optional] |
| **TargetUser** | [**AddressableEntityRef**](AddressableEntityRef) | The user participant who is being screen monitored. | [optional] |
| **_ScreenMonitoring** | [**AddressableEntityRef**](AddressableEntityRef) | Screen Monitoring identifier unique to the sourceUserId-targetUserId pair. | [optional] |
| **MonitoringType** | **string** | The screen monitoring type. | [optional] |
| **Count** | **long?** | Number of Screen Monitoring sessions the targetUserId is involved in. | [optional] |
| **ConnectedTime** | **DateTime?** | The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DisconnectedTime** | **DateTime?** | The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |



_PureCloudPlatform.Client.V2 254.0.0_
