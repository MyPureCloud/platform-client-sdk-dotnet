# SkillExpressionValidationResult

## ININ.PureCloudApi.Model.SkillExpressionValidationResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Valid** | **bool?** | Whether the expression is valid | [optional] |
| **Expression** | **string** | Normalized SpEL expression (null if validation failed) | [optional] |
| **Skills** | [**List&lt;SkillReference&gt;**](SkillReference) | List of skill references extracted from the expression (empty if no skills found and/or invalid expression) | [optional] |
| **Errors** | [**List&lt;SkillExpressionValidationError&gt;**](SkillExpressionValidationError) | List of validation errors (empty if valid) | [optional] |
| **Hint** | **string** | Optional hint message (e.g., if expression is non-optimal or system is near capacity) | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
