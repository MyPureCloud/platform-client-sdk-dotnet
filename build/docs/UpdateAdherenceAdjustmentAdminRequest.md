# UpdateAdherenceAdjustmentAdminRequest

## ININ.PureCloudApi.Model.UpdateAdherenceAdjustmentAdminRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ReasonCodeId** | **string** | The ID of the reason code for this adherence adjustment | [optional] |
| **StartDate** | **DateTime?** | The start timestamp of the adherence adjustment in ISO-8601 format | [optional] |
| **LengthMinutes** | **int?** | The length of the adherence adjustment in minutes | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Version metadata for the adherence adjustment | |
| **ReviewerNotes** | **string** | Notes provided by the reviewer for this adherence adjustment | [optional] |
| **Status** | **string** | The new status for the adherence adjustment | [optional] |



_PureCloudPlatform.Client.V2 274.0.0_
