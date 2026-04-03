# MinimumStaffingRequest

## ININ.PureCloudApi.Model.MinimumStaffingRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Enabled** | **bool?** | Whether the setting is turned on or off | [optional] |
| **MinimumValue** | **double?** | Default minimum staff value to be applied to all planning groups | [optional] |
| **PlanningGroupOverrides** | [**ListWrapperPlanningGroupMinimumsRequest**](ListWrapperPlanningGroupMinimumsRequest) | List of planning groups with their minimum staff value overrides and the days to which the overrides apply. Setting the enclosed list to empty will clear out all existing overrides | [optional] |
| **ApplicableIntervals** | **string** | The intervals to which the minimum staff values will apply | [optional] |



_PureCloudPlatform.Client.V2 261.0.0_
