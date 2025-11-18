# AlternativeShiftTradeBulkUpdateTemplateItem

## ININ.PureCloudApi.Model.AlternativeShiftTradeBulkUpdateTemplateItem

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **TradeId** | **string** | The ID of this alternative shift trade | |
| **State** | **string** | The current state of this alternative shift trade request | |
| **FailureReason** | **string** | The reason the update failed, if applicable | [optional] |
| **AdminDateReviewed** | **DateTime?** | The timestamp of when the trade request was manually reviewed by an admin in ISO-8601 format | [optional] |
| **AdminReviewedBy** | [**UserReference**](UserReference) | The admin who manually reviewed this alternative shift trade after system denial | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Version metadata for this alternative shift trade | |



_PureCloudPlatform.Client.V2 248.0.0_
