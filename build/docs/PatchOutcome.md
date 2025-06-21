# PatchOutcome

## ININ.PureCloudApi.Model.PatchOutcome

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **IsActive** | **bool?** | Whether or not the outcome is active. | [optional] |
| **DisplayName** | **string** | The display name of the outcome. | |
| **Version** | **int?** | The version of the outcome. | [optional] |
| **Description** | **string** | A description of the outcome. | [optional] |
| **IsPositive** | **bool?** | Whether or not the outcome is positive. | [optional] |
| **Context** | [**PatchContext**](PatchContext) | The context of the outcome. | [optional] |
| **Journey** | [**PatchJourney**](PatchJourney) | The pattern of rules defining the filter of the outcome. | [optional] |
| **AssociatedValueField** | [**PatchAssociatedValueField**](PatchAssociatedValueField) | The field from the event indicating the associated value. | [optional] |



_PureCloudPlatform.Client.V2 236.0.0_
