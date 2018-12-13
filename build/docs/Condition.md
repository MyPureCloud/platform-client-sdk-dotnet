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
| **Value** | **string** | A value associated with this Condition. This could be text, a number, or a relative time. Not used for a DataActionCondition. | [optional] |
| **ValueType** | **string** | The type of the value associated with this Condition. Not used for a DataActionCondition. | [optional] |
| **_Operator** | **string** | An operation with which to evaluate the Condition. Not used for a DataActionCondition. | [optional] |
| **Codes** | **List&lt;string&gt;** | List of wrap-up code identifiers. Required for a wrapupCondition. | [optional] |
| **Property** | **string** | A value associated with the property type of this Condition. Required for a contactPropertyCondition. | [optional] |
| **PropertyType** | **string** | The type of the property associated with this Condition. Required for a contactPropertyCondition. | [optional] |
{: class="table table-striped"}


