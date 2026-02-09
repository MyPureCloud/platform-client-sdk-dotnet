# CoachingScheduleSlotsJobResult

## ININ.PureCloudApi.Model.CoachingScheduleSlotsJobResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Interval** | **string** | The interval of the job. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | [optional] |
| **Status** | **string** | The status of the job | [optional] |
| **Slot** | [**CoachingScheduleSlotsJobSlot**](CoachingScheduleSlotsJobSlot) | The slot found from the job | [optional] |
| **HasConflict** | **bool?** | True if the slot conflicts with a Coaching Appointment | [optional] |



_PureCloudPlatform.Client.V2 256.0.0_
