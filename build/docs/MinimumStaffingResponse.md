# MinimumStaffingResponse

## ININ.PureCloudApi.Model.MinimumStaffingResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Enabled** | **bool?** | Whether the setting is turned on or off | |
| **MinimumValue** | **double?** | Default minimum staff value to be applied to all planning groups | |
| **PlanningGroupOverrides** | [**List&lt;PlanningGroupMinimumsResponse&gt;**](PlanningGroupMinimumsResponse) | List of planning groups with their minimum staff value overrides and the days to which the overrides apply | |
| **ApplicableIntervals** | **string** | The intervals to which the minimum staff values will apply | |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Metadata for the business unit&#39;s minimum staffing settings | |



_PureCloudPlatform.Client.V2 261.0.0_
