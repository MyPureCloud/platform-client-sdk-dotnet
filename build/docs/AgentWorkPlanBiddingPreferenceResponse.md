# AgentWorkPlanBiddingPreferenceResponse

## ININ.PureCloudApi.Model.AgentWorkPlanBiddingPreferenceResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Submitted** | **bool?** | Whether the preference is submitted | |
| **AssignedWorkPlan** | [**WorkPlanReference**](WorkPlanReference) | The work plan assigned to the agent by the bid process | [optional] |
| **OverriddenWorkPlan** | [**WorkPlanReference**](WorkPlanReference) | The work plan that overrides the assigned work plan for the agent | [optional] |
| **OverrideReason** | **string** | The reason why the assigned work plan has been overridden. This must be null without an override work plan | [optional] |
| **AgentWorkPlanBidPreferences** | [**List&lt;AgentWorkPlanBiddingPreference&gt;**](AgentWorkPlanBiddingPreference) | The list of work plan bidding preferences | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 258.0.0_
