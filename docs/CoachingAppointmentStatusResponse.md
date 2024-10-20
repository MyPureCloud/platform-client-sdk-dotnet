# CoachingAppointmentStatusResponse

## ININ.PureCloudApi.Model.CoachingAppointmentStatusResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Appointment** | [**CoachingAppointmentReference**](CoachingAppointmentReference) | The coaching appointment this status belongs to | [optional] |
| **CreatedBy** | [**UserReference**](UserReference) | User who updated the status | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the status. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Status** | **string** | The status of the coaching appointment | [optional] |



_PureCloudPlatform.Client.V2 219.0.0_
