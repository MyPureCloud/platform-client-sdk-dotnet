# UserPresence

## ININ.PureCloudApi.Model.UserPresence

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Source** | **string** | Deprecated - The sourceID field should be used as a replacement. | [optional] |
| **SourceId** | **string** | Represents the ID of a registered source | [optional] |
| **Primary** | **bool?** | A boolean used to tell whether or not to set this presence source as the primary on a PATCH | [optional] |
| **PresenceDefinition** | [**PresenceDefinition**](PresenceDefinition) |  | [optional] |
| **Message** | **string** |  | [optional] |
| **ModifiedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 224.1.0_
