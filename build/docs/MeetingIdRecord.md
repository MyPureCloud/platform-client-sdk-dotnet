# MeetingIdRecord

## ININ.PureCloudApi.Model.MeetingIdRecord

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Ephemeral** | **bool?** | Boolean flag for ephemeral status of the created record | |
| **ConferenceId** | **string** | The conferenceId used to generate a meetingId | [optional] |
| **DateExpired** | **DateTime?** | Instant at which the meetingId record will no longer be considered active. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 231.0.0_
