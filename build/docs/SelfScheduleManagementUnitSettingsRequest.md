# SelfScheduleManagementUnitSettingsRequest

## ININ.PureCloudApi.Model.SelfScheduleManagementUnitSettingsRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Enabled** | **bool?** | Whether agent self-scheduling is enabled for this management unit | [optional] |
| **CheckWorkPlanConstraints** | **bool?** | Whether self-scheduling is further restricted by work plan constraints | [optional] |
| **MinimumMinutesBeforeEarliestScheduleChange** | **int?** | The minimum number of minutes before the new activity start time to which the agent is allowed to self-schedule | [optional] |
| **MovableActivityCategories** | [**SetWrapperActivityCategory**](SetWrapperActivityCategory) | Movable activity categories enabled for self-scheduling | [optional] |
| **MovableActivityCodeIds** | [**SetWrapperString**](SetWrapperString) | Movable activity codes enabled for self-scheduling | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Version metadata for this management unit&#39;s self-scheduling settings | |



_PureCloudPlatform.Client.V2 276.0.0_
