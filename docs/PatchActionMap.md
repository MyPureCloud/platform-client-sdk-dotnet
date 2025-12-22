# PatchActionMap

## ININ.PureCloudApi.Model.PatchActionMap

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Version** | **int?** | The version of the action map. | [optional] |
| **IsActive** | **bool?** | Whether the action map is active. | [optional] |
| **DisplayName** | **string** | Display name of the action map. | |
| **TriggerWithSegments** | **List&lt;string&gt;** | Trigger action map if any segment in the list is assigned to a given customer. | |
| **TriggerWithEventConditions** | [**List&lt;EventCondition&gt;**](EventCondition) | List of event conditions that must be satisfied to trigger the action map. | [optional] |
| **TriggerWithOutcomeProbabilityConditions** | [**List&lt;OutcomeProbabilityCondition&gt;**](OutcomeProbabilityCondition) | (deprecated - use triggerWithOutcomeQuantileConditions instead) Probability conditions for outcomes that must be satisfied to trigger the action map. | [optional] |
| **TriggerWithOutcomePercentileConditions** | [**List&lt;OutcomePercentileCondition&gt;**](OutcomePercentileCondition) | (deprecated - use triggerWithOutcomeQuantileConditions instead) Percentile conditions for outcomes that must be satisfied to trigger the action map. | [optional] |
| **TriggerWithOutcomeQuantileConditions** | [**List&lt;OutcomeQuantileCondition&gt;**](OutcomeQuantileCondition) | Quantile conditions for outcomes that must be satisfied to trigger the action map. | [optional] |
| **PageUrlConditions** | [**List&lt;UrlCondition&gt;**](UrlCondition) | URL conditions that a page must match for web actions to be displayable. | |
| **Activation** | [**Activation**](Activation) | Type of activation. | [optional] |
| **Weight** | **int?** | Weight of the action map with higher number denoting higher weight. | [optional] |
| **Action** | [**PatchAction**](PatchAction) | The action that will be executed if this action map is triggered. | [optional] |
| **ActionMapScheduleGroups** | [**PatchActionMapScheduleGroups**](PatchActionMapScheduleGroups) | The action map&#39;s associated schedule groups. | [optional] |
| **IgnoreFrequencyCap** | **bool?** | Override organization-level frequency cap and always offer web engagements from this action map. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **CreatedDate** | **DateTime?** | Timestamp indicating when the action map was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedDate** | **DateTime?** | Timestamp indicating when the action map was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **StartDate** | **DateTime?** | Timestamp at which the action map is scheduled to start firing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **EndDate** | **DateTime?** | Timestamp at which the action map is scheduled to stop firing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |



_PureCloudPlatform.Client.V2 252.0.0_
