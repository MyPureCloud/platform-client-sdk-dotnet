# QueueConversationVideoEventTopicScreenMonitoring

## ININ.PureCloudApi.Model.QueueConversationVideoEventTopicScreenMonitoring

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | A globally unique identifier for this communication. | [optional] |
| **State** | **string** |  | [optional] |
| **InitialState** | **string** |  | [optional] |
| **Provider** | **string** | The source provider. | [optional] |
| **DisconnectType** | **string** | System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects. | [optional] |
| **ConnectedTime** | **DateTime?** | The timestamp when this communication was connected in the cloud clock. | [optional] |
| **DisconnectedTime** | **DateTime?** | The timestamp when this communication disconnected from the conversation in the provider clock. | [optional] |
| **TargetUserId** | **string** | The user ID for the participant who is being screen monitored. | [optional] |
| **ScreenMonitoringId** | **string** | Screen Monitoring identifier unique to the sourceUserId-targetUserId pair. | [optional] |
| **MonitoringType** | **string** | The screen monitoring type. | [optional] |
| **Count** | **long?** | Number of Screen Monitoring sessions the targetUserId is involved in. | [optional] |



_PureCloudPlatform.Client.V2 257.0.0_
