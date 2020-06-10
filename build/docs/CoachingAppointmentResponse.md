---
title: CoachingAppointmentResponse
---
## ININ.PureCloudApi.Model.CoachingAppointmentResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of coaching appointment | [optional] |
| **Description** | **string** | The description of coaching appointment | [optional] |
| **DateStart** | **DateTime?** | The date/time the coaching appointment starts. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **LengthInMinutes** | **int?** | The duration of coaching appointment in minutes | [optional] |
| **Status** | **string** | The status of coaching appointment | [optional] |
| **Facilitator** | [**UserReference**](UserReference.html) | The facilitator of coaching appointment | [optional] |
| **Attendees** | [**List&lt;UserReference&gt;**](UserReference.html) | The list of attendees attending the coaching | [optional] |
| **CreatedBy** | [**UserReference**](UserReference.html) | The user who created the coaching appointment | [optional] |
| **DateCreated** | **DateTime?** | The date/time the coaching appointment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference.html) | The last user to modify the coaching appointment | [optional] |
| **DateModified** | **DateTime?** | The date/time the coaching appointment was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Conversations** | [**List&lt;ConversationReference&gt;**](ConversationReference.html) | The list of conversations associated with coaching appointment. | [optional] |
| **Documents** | [**List&lt;DocumentReference&gt;**](DocumentReference.html) | The list of documents associated with coaching appointment. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


