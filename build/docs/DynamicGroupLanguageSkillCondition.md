# DynamicGroupLanguageSkillCondition

## ININ.PureCloudApi.Model.DynamicGroupLanguageSkillCondition

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **LanguageSkill** | **string** | The language skill to be used in the skill condition query | |
| **Comparator** | **string** | Comparator that will be applied to the proficiency | |
| **Proficiency** | **int?** | The skill proficiency that will be used for the language skill. Integer range 0-5 | |
| **ChildConditions** | [**List&lt;DynamicGroupSkillCondition&gt;**](DynamicGroupSkillCondition) | Nested conditions to be applied to this skill condition | [optional] |



_PureCloudPlatform.Client.V2 235.0.0_
