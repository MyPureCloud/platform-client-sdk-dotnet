# Outcome

## ININ.PureCloudApi.Model.Outcome

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | ID of the outcome. | |
| **IsActive** | **bool?** | Whether or not the outcome is active. | |
| **DisplayName** | **string** | The display name of the outcome. | |
| **Version** | **int?** | The version of the outcome. | |
| **Description** | **string** | A description of the outcome. | [optional] |
| **IsPositive** | **bool?** | Whether or not the outcome is positive. | |
| **Context** | [**Context**](Context) | The context of the outcome. | |
| **Journey** | [**Journey**](Journey) | The pattern of rules defining the filter of the outcome. | |
| **AssociatedValueField** | [**AssociatedValueField**](AssociatedValueField) | The field from the event indicating the associated value. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **CreatedDate** | **DateTime?** | Timestamp indicating when the outcome was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **ModifiedDate** | **DateTime?** | Timestamp indicating when the outcome was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |



_PureCloudPlatform.Client.V2 242.0.0_
