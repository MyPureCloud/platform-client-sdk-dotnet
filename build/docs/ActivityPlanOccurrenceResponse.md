# ActivityPlanOccurrenceResponse

## ININ.PureCloudApi.Model.ActivityPlanOccurrenceResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | |
| **RunDate** | **DateTime?** | The date the associated activity plan was run, in ISO-8601 format | |
| **SessionDateRange** | [**RequiredDateRange**](RequiredDateRange) | The dates potentially spanned by the sessions in this occurrence, even if no sessions currently exist | |
| **Facilitated** | **bool?** | Whether the run sessions are facilitated | |
| **Edited** | **bool?** | Whether this occurrence is edited | [optional] |
| **Violations** | [**List&lt;ActivityPlanOccurrenceViolation&gt;**](ActivityPlanOccurrenceViolation) | The violations for this occurrence | [optional] |
| **Sessions** | [**List&lt;ActivityPlanOccurrenceSessionWithAttendees&gt;**](ActivityPlanOccurrenceSessionWithAttendees) | The sessions scheduled by the run | |
| **UnscheduledAttendees** | [**List&lt;ActivityPlanUnscheduledAttendee&gt;**](ActivityPlanUnscheduledAttendee) | The attendees who could not be scheduled for this occurrence | |
| **AffectedSchedules** | [**List&lt;BuScheduleSummary&gt;**](BuScheduleSummary) | Summaries of the schedules affected by this occurrence | |
| **CreatedBy** | [**UserReference**](UserReference) | The user who started the job which created this occurrence | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 277.0.0_
