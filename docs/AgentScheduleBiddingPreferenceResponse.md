# AgentScheduleBiddingPreferenceResponse

## ININ.PureCloudApi.Model.AgentScheduleBiddingPreferenceResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Submitted** | **bool?** | Whether the preference is submitted | |
| **AssignedScheduleSetId** | **string** | The schedule set assigned to the agent by the bid process. Will be set after bid is processed | [optional] |
| **OverriddenScheduleSetId** | **string** | The schedule set that overrides the assigned schedule set for the agent | [optional] |
| **OverrideReason** | **string** | The reason why the assigned schedule set has been overridden. This must be null without an override schedule set | [optional] |
| **AgentScheduleBidPreferences** | [**List&lt;AgentScheduleBiddingPreferencePriority&gt;**](AgentScheduleBiddingPreferencePriority) | The schedule bidding preferences | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
