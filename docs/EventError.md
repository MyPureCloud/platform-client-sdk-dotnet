# EventError

## ININ.PureCloudApi.Model.EventError

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EventId** | **string** | The eventId (V4 UUID) for the event that encountered an error. | [optional] |
| **Message** | **string** | A message describing the error. | [optional] |
| **Retryable** | **bool?** | The event for this eventId can be resubmitted if this value is true. | [optional] |



_PureCloudPlatform.Client.V2 242.0.0_
