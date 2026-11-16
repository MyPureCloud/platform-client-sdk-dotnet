# ActivityPlanOccurrenceListItem

## ININ.PureCloudApi.Model.ActivityPlanOccurrenceListItem

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | |
| **RunDate** | **DateTime?** | The date the associated activity plan was run, in ISO-8601 format | |
| **SessionDateRange** | [**RequiredDateRange**](RequiredDateRange) | The dates potentially spanned by the sessions in this occurrence, even if no sessions currently exist | |
| **Facilitated** | **bool?** | Whether the run sessions are facilitated | |
| **SessionCount** | **int?** | The number of sessions that were scheduled | |
| **ScheduledAttendeesCount** | **int?** | The number of attendees that were scheduled for this occurrence | |
| **UnscheduledAttendeesCount** | **int?** | The number of attendees that were unable to be scheduled for this occurrence | |
| **Edited** | **bool?** | Whether this occurrence is edited | [optional] |
| **ViolationCount** | **int?** | The number of violations for this occurrence | [optional] |
| **AffectedScheduleIndexes** | **List&lt;int?&gt;** | The index of the affected schedule summary in the schedules list | |
| **CreatedBy** | [**UserReference**](UserReference) | The user who started the job which created this occurrence. The id may be &#39;System&#39; if it was an automated process | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 277.0.0_
