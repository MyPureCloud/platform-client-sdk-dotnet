# CoachingAppointmentResponse

## ININ.PureCloudApi.Model.CoachingAppointmentResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of coaching appointment | [optional] |
| **Description** | **string** | The description of coaching appointment | [optional] |
| **DateStart** | **DateTime?** | The date/time the coaching appointment starts. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **LengthInMinutes** | **int?** | The duration of coaching appointment in minutes | [optional] |
| **Status** | **string** | The status of coaching appointment | [optional] |
| **Facilitator** | [**UserReference**](UserReference) | The facilitator of coaching appointment | [optional] |
| **Attendees** | [**List&lt;UserReference&gt;**](UserReference) | The list of attendees attending the coaching | [optional] |
| **CreatedBy** | [**UserReference**](UserReference) | The user who created the coaching appointment | [optional] |
| **DateCreated** | **DateTime?** | The date/time the coaching appointment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference) | The last user to modify the coaching appointment | [optional] |
| **DateModified** | **DateTime?** | The date/time the coaching appointment was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Conversations** | [**List&lt;ConversationReference&gt;**](ConversationReference) | The list of conversations associated with coaching appointment. | [optional] |
| **Documents** | [**List&lt;DocumentReference&gt;**](DocumentReference) | The list of documents associated with coaching appointment. | [optional] |
| **IsOverdue** | **bool?** | Whether the appointment is overdue. | [optional] |
| **WfmSchedule** | [**WfmScheduleReference**](WfmScheduleReference) | The Workforce Management schedule the appointment is associated with. | [optional] |
| **DateCompleted** | **DateTime?** | The date/time the coaching appointment was set to completed status. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ExternalLinks** | **List&lt;string&gt;** | The list of external links related to the appointment | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 221.0.0_
