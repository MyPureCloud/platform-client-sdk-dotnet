# OutcomeRequest

## ININ.PureCloudApi.Model.OutcomeRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **IsActive** | **bool?** | Whether or not the outcome is active. | [optional] |
| **DisplayName** | **string** | The display name of the outcome. | |
| **Version** | **int?** | The version of the outcome. | [optional] |
| **Description** | **string** | A description of the outcome. | [optional] |
| **IsPositive** | **bool?** | Whether or not the outcome is positive. | [optional] |
| **Context** | [**RequestContext**](RequestContext) | The context of the outcome. | [optional] |
| **Journey** | [**RequestJourney**](RequestJourney) | The pattern of rules defining the filter of the outcome. | [optional] |
| **AssociatedValueField** | [**AssociatedValueField**](AssociatedValueField) | The field from the event indicating the associated value. | [optional] |



_PureCloudPlatform.Client.V2 251.0.0_
