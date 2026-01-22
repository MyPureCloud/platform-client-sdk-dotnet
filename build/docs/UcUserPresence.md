# UcUserPresence

## ININ.PureCloudApi.Model.UcUserPresence

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **UserId** | **string** | User ID of the associated Genesys Cloud user. | [optional] |
| **Source** | **string** | Deprecated - The sourceID field should be used as a replacement. | [optional] |
| **SourceId** | **string** | The registered source ID from where the presence was set | [optional] |
| **PresenceDefinition** | [**PresenceDefinition**](PresenceDefinition) |  | [optional] |
| **Message** | **string** |  | [optional] |
| **ModifiedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 255.0.0_
