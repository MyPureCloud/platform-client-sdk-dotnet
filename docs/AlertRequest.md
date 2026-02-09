# AlertRequest

## ININ.PureCloudApi.Model.AlertRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | The action being taken on the alert. | |
| **DateStart** | **DateTime?** | The start date of the mute/snooze period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateEnd** | **DateTime?** | The end date of the mute/snooze period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Unread** | [**UnreadFields**](UnreadFields) | The fields need for an unread update requests | [optional] |
| **ValidRequest** | **bool?** |  | [optional] |



_PureCloudPlatform.Client.V2 256.0.0_
