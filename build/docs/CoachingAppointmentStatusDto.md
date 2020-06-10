---
title: CoachingAppointmentStatusDto
---
## ININ.PureCloudApi.Model.CoachingAppointmentStatusDto

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Appointment** | [**CoachingAppointmentReference**](CoachingAppointmentReference.html) | The coaching appointment this status belongs to | [optional] |
| **CreatedBy** | [**UserReference**](UserReference.html) | User who updated the status | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the status. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Status** | **string** | The status of the coaching appointment | |
{: class="table table-striped"}


