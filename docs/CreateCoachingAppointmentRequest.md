# CreateCoachingAppointmentRequest

## ININ.PureCloudApi.Model.CreateCoachingAppointmentRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of coaching appointment. | |
| **Description** | **string** | The description of coaching appointment. | |
| **DateStart** | **DateTime?** | The date/time the coaching appointment starts. Times will be rounded down to the minute. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **LengthInMinutes** | **int?** | The duration of coaching appointment in minutes. | |
| **FacilitatorId** | **string** | The facilitator ID of coaching appointment. | [optional] |
| **AttendeeIds** | **List&lt;string&gt;** | IDs of attendees in the coaching appointment. | |
| **ConversationIds** | **List&lt;string&gt;** | IDs of conversations associated with this coaching appointment. | [optional] |
| **DocumentIds** | **List&lt;string&gt;** | IDs of documents associated with this coaching appointment. | [optional] |
| **WfmSchedule** | [**WfmScheduleReference**](WfmScheduleReference) | The Workforce Management schedule the appointment is associated with. | [optional] |
| **ExternalLinks** | **List&lt;string&gt;** | The list of external links related to the appointment | [optional] |
| **Location** | **string** | The location of the appointment | [optional] |
| **ShareInsightsData** | **bool?** | Whether to share the insight data | [optional] |



_PureCloudPlatform.Client.V2 240.0.0_
