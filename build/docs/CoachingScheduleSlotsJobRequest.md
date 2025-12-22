# CoachingScheduleSlotsJobRequest

## ININ.PureCloudApi.Model.CoachingScheduleSlotsJobRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **AttendeeIds** | **List&lt;string&gt;** | The attendee IDs to fetch the slots for. | |
| **FacilitatorIds** | **List&lt;string&gt;** | The facilitator IDs to fetch the slots for. | [optional] |
| **LengthInMinutes** | **int?** | The length in minutes of the slots, in 15 minutes granularity. | |
| **ActivityCodeId** | **string** | The Activity Code Id of the slots. | |
| **Intervals** | **List&lt;string&gt;** | The intervals to fetch the slots for. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | |
| **SlotsType** | **string** | The type of slots to fetch in the job. | |



_PureCloudPlatform.Client.V2 252.1.0_
