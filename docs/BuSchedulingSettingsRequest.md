# BuSchedulingSettingsRequest

## ININ.PureCloudApi.Model.BuSchedulingSettingsRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **MessageSeverities** | [**List&lt;SchedulerMessageTypeSeverity&gt;**](SchedulerMessageTypeSeverity) | Schedule generation message severity configuration | [optional] |
| **SyncTimeOffProperties** | [**SetWrapperSyncTimeOffProperty**](SetWrapperSyncTimeOffProperty) | Synchronize set of time off properties from scheduled activities to time off requests when the schedule is published. | [optional] |
| **ServiceGoalImpact** | [**WfmServiceGoalImpactSettings**](WfmServiceGoalImpactSettings) | Configures the max percent increase and decrease of service goals for this business unit | [optional] |
| **AllowWorkPlanPerMinuteGranularity** | **bool?** | Indicates whether or not per minute granularity for scheduling will be enabled for this business unit. Defaults to false. | [optional] |



_PureCloudPlatform.Client.V2 216.0.0_
