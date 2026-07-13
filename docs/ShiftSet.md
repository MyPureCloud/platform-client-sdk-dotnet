# ShiftSet

## ININ.PureCloudApi.Model.ShiftSet

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The ID of the shift set | |
| **Name** | **string** | The name given for the shift set | |
| **EffectiveWorkPlan** | [**ShiftSetEffectiveWorkPlan**](ShiftSetEffectiveWorkPlan) | The work plan or work plan rotation used for generating the shift set | |
| **Shifts** | [**List&lt;ScheduleBidScheduledShift&gt;**](ScheduleBidScheduledShift) | The scheduled shifts | |
| **SuggestedAgentCount** | **int?** | The suggested agent count | |
| **OverrideAgentCount** | **int?** | The override agent count. If it is null, it falls back to using the suggestedAgentCount | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
