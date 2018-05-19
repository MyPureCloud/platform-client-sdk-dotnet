---
title: UserSchedule
---
## ININ.PureCloudApi.Model.UserSchedule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Shifts** | [**List&lt;UserScheduleShift&gt;**](UserScheduleShift.html) | The shifts that belong to this schedule | [optional] |
| **FullDayTimeOffMarkers** | [**List&lt;UserScheduleFullDayTimeOffMarker&gt;**](UserScheduleFullDayTimeOffMarker.html) | Markers to indicate a full day time off request, relative to the management unit time zone | [optional] |
| **Delete** | **bool?** | If marked true for updating an existing user schedule, it will be deleted | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata.html) | Version metadata for this schedule | |
| **WorkPlanId** | **string** | ID of the work plan associated with the user during schedule creation | [optional] |
{: class="table table-striped"}


