# AvailableTime

## ININ.PureCloudApi.Model.AvailableTime

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **DateStart** | **DateTime?** | Start of the availability period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **LengthInMinutes** | **int?** | Length of availability period in minutes | [optional] |
| **IsPaid** | **bool?** | Indicates if this availability period is paid in Workforce Management schedule | [optional] |
| **ActivityCategory** | **string** | Workforce Management activity category for this availability period | [optional] |
| **WfmSchedule** | [**WfmScheduleReference**](WfmScheduleReference) | Workforce Management schedule information associated with the available time | [optional] |



_PureCloudPlatform.Client.V2 224.1.0_
