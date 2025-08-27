# AdminAgentWorkPlanBiddingPreference

## ININ.PureCloudApi.Model.AdminAgentWorkPlanBiddingPreference

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Agent** | [**UserReference**](UserReference) | The agent to whom this work plan bidding preference applies | |
| **Submitted** | **bool?** | Whether the preference is submitted | |
| **AssignedWorkPlan** | [**WorkPlanReference**](WorkPlanReference) | The work plan assigned to the agent by the bid process | [optional] |
| **OverriddenWorkPlan** | [**WorkPlanReference**](WorkPlanReference) | The work plan that overrides the assigned work plan for the agent | [optional] |
| **OverrideReason** | **string** | The reason why the assigned work plan has been overridden. This must be null without an override work plan | [optional] |
| **Priorities** | **List&lt;int?&gt;** | The agent priorities for the list of work plans. The index of the priorities should match with the list of work plans that belong to bid group. It contains null if priority is not set for the work plan | [optional] |



_PureCloudPlatform.Client.V2 241.0.0_
