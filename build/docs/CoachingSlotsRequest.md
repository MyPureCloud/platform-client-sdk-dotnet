# CoachingSlotsRequest

## ININ.PureCloudApi.Model.CoachingSlotsRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Interval** | **string** | Range of time to get slots for scheduling coaching appointments. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | |
| **LengthInMinutes** | **int?** | The duration of coaching appointment to schedule in 15 minutes granularity up to maximum of 60 minutes | |
| **AttendeeIds** | **List&lt;string&gt;** | List of attendees to determine coaching appointment slots | |
| **FacilitatorIds** | **List&lt;string&gt;** | List of facilitators to determine coaching appointment slots | [optional] |
| **InterruptibleAppointmentIds** | **List&lt;string&gt;** | List of appointment ids to exclude from consideration when determining blocked slots | [optional] |



_PureCloudPlatform.Client.V2 244.0.0_
