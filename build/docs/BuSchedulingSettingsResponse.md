# BuSchedulingSettingsResponse

## ININ.PureCloudApi.Model.BuSchedulingSettingsResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **MessageSeverities** | [**List&lt;SchedulerMessageTypeSeverity&gt;**](SchedulerMessageTypeSeverity) | Schedule generation message severity configuration | [optional] |
| **SyncTimeOffProperties** | **List&lt;string&gt;** | Synchronize set of time off properties from scheduled activities to time off requests when the schedule is published. | [optional] |
| **ServiceGoalImpact** | [**WfmServiceGoalImpactSettings**](WfmServiceGoalImpactSettings) | Configures the max percent increase and decrease of service goals for this business unit | [optional] |
| **AllowWorkPlanPerMinuteGranularity** | **bool?** | Indicates whether or not per minute granularity for scheduling will be enabled for this business unit. Defaults to false. | [optional] |
| **ActivitySmoothingType** | **string** | The activity smoothing type for schedule generation in this business unit | |
| **InduceScheduleVariability** | **bool?** | Indicates whether to provide variability in schedule generation | |



_PureCloudPlatform.Client.V2 243.0.0_
