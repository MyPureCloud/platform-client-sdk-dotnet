---
title: Condition
---
## ININ.PureCloudApi.Model.Condition

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | The type of the condition | [optional] |
| **Inverted** | **bool?** | Indicates whether to evaluate for the opposite of the stated condition; default is false | [optional] |
| **AttributeName** | **string** | An attribute name associated with the condition (applies only to certain rule conditions) | [optional] |
| **Value** | **string** | A value associated with the condition | [optional] |
| **ValueType** | **string** | Determines the type of the value associated with the condition | [optional] |
| **_Operator** | **string** | An operation type for condition evaluation | [optional] |
| **Codes** | **List&lt;string&gt;** | List of wrap-up code identifiers (used only in conditions of type &#39;wrapupCondition&#39;) | [optional] |
{: class="table table-striped"}


