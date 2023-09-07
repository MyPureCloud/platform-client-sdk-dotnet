---
title: BuSchedulingSettingsRequest
---
## ININ.PureCloudApi.Model.BuSchedulingSettingsRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **MessageSeverities** | [**List&lt;SchedulerMessageTypeSeverity&gt;**](SchedulerMessageTypeSeverity.html) | Schedule generation message severity configuration | [optional] |
| **SyncTimeOffProperties** | [**SetWrapperSyncTimeOffProperty**](SetWrapperSyncTimeOffProperty.html) | Synchronize set of time off properties from scheduled activities to time off requests when the schedule is published. | [optional] |
| **ServiceGoalImpact** | [**WfmServiceGoalImpactSettings**](WfmServiceGoalImpactSettings.html) | Configures the max percent increase and decrease of service goals for this business unit | [optional] |
{: class="table table-striped"}


