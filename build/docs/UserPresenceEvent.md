# UserPresenceEvent

## ININ.PureCloudApi.Model.UserPresenceEvent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EventId** | **string** | A unique (V4 UUID) eventId for this event | |
| **EventDateTime** | **DateTime?** | A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **UserId** | **string** | The User ID of the user associated with this UserPresence | |
| **SourceId** | **string** | The id (V4 UUID) of the presence source being updated | |
| **PresenceDefinitionId** | **string** | The id (UUID) of the presence definition that the user presence is associated with | [optional] |
| **Message** | **string** | The message associated with the presence | [optional] |



_PureCloudPlatform.Client.V2 218.0.0_
