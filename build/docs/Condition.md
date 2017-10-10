---
title: Condition
---
## ININ.PureCloudApi.Model.Condition

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | The type of the condition. | [optional] |
| **Inverted** | **bool?** | If true, inverts the result of evaluating this Condition. Default is false. | [optional] |
| **AttributeName** | **string** | An attribute name associated with this Condition. Required for a contactAttributeCondition. | [optional] |
| **Value** | **string** | A value associated with this Condition. This could be text, a number, or a relative time. A value for relative time should follow the format PxxDTyyHzzM, where xx, yy, and zz specify the days, hours and minutes. For example, a value of P01DT08H30M corresponds to 1 day, 8 hours, and 30 minutes from now. To specify a time in the past, include a negative sign before each numeric value. For example, a value of P-01DT-08H-30M corresponds to 1 day, 8 hours, and 30 minutes in the past. You can also do things like P01DT00H-30M, which would correspond to 23 hours and 30 minutes from now (1 day - 30 minutes). | [optional] |
| **ValueType** | **string** | The type of the value associated with this Condition. | [optional] |
| **_Operator** | **string** | An operation with which to evaluate the Condition. | [optional] |
| **Codes** | **List&lt;string&gt;** | List of wrap-up code identifiers. Required for a wrapupCondition. | [optional] |
| **Property** | **string** | A value associated with the property type of this Condition. Required for a contactPropertyCondition. | [optional] |
| **PropertyType** | **string** | The type of the property associated with this Condition. | [optional] |
{: class="table table-striped"}


