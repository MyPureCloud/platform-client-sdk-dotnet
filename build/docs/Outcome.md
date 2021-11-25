---
title: Outcome
---
## ININ.PureCloudApi.Model.Outcome

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **IsActive** | **bool?** | Whether or not the outcome is active. | [optional] |
| **DisplayName** | **string** | The display name of the outcome. | |
| **Version** | **int?** | The version of the outcome. | [optional] |
| **Description** | **string** | A description of the outcome. | [optional] |
| **IsPositive** | **bool?** | Whether or not the outcome is positive. | [optional] |
| **Context** | [**Context**](Context.html) | The context of the outcome. | [optional] |
| **Journey** | [**Journey**](Journey.html) | The pattern of rules defining the filter of the outcome. | [optional] |
| **AssociatedValueField** | [**AssociatedValueField**](AssociatedValueField.html) | The field from the event indicating the associated value. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **CreatedDate** | **DateTime?** | Timestamp indicating when the outcome was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedDate** | **DateTime?** | Timestamp indicating when the outcome was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
{: class="table table-striped"}


