# AdminAgentScheduleBidBiddingPreference

## ININ.PureCloudApi.Model.AdminAgentScheduleBidBiddingPreference

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Agent** | [**UserReference**](UserReference) | The agent to whom this schedule bid preference applies | |
| **Submitted** | **bool?** | Indicates whether the preference has been submitted | |
| **AssignedScheduleSetId** | **string** | The schedule set assigned to the agent by the bid process. This will be set after bid is processed | [optional] |
| **OverriddenScheduleSetId** | **string** | The schedule set that overrides the assigned schedule set for the agent | [optional] |
| **OverrideReason** | **string** | The reason the assigned schedule set has been overridden. This must be null if no override schedule is set | [optional] |
| **AgentScheduleBidPreferencePriorities** | [**List&lt;AgentScheduleBiddingPreferencePriority&gt;**](AgentScheduleBiddingPreferencePriority) | The agent schedule set preferences | |
| **EndDate** | **String** | The end date of this scheduling set preference relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
