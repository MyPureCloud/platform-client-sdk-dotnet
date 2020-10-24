---
title: CoachingNotification
---
## ININ.PureCloudApi.Model.CoachingNotification

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the appointment for this notification. | [optional] |
| **MarkedAsRead** | **bool?** | Indicates if notification is read or unread | [optional] |
| **ActionType** | **string** | Action causing the notification. | [optional] |
| **Relationship** | **string** | The relationship of this user to this notification&#39;s appointment | [optional] |
| **DateStart** | **DateTime?** | The start time of the appointment relating to this notification. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **LengthInMinutes** | **int?** | The duration of the appointment on this notification | [optional] |
| **Status** | **string** | The status of the appointment for this notification | [optional] |
| **User** | [**UserReference**](UserReference.html) | The user of this notification | [optional] |
| **Appointment** | [**CoachingAppointmentResponse**](CoachingAppointmentResponse.html) | The appointment | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


