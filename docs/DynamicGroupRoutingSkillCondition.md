# DynamicGroupRoutingSkillCondition

## ININ.PureCloudApi.Model.DynamicGroupRoutingSkillCondition

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **RoutingSkill** | **string** | The routing skill to be used in the skill condition query | |
| **Comparator** | **string** | Comparator that will be applied to the proficiency | |
| **Proficiency** | **int?** | The skill proficiency that will be used for the routing skill. Integer range 0-5 | |
| **ChildConditions** | [**List&lt;DynamicGroupSkillCondition&gt;**](DynamicGroupSkillCondition) | Nested conditions to be applied to this skill condition | [optional] |



_PureCloudPlatform.Client.V2 255.0.0_
