# BulkUpdateShiftTradeStateResultItem

## ININ.PureCloudApi.Model.BulkUpdateShiftTradeStateResultItem

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **State** | **string** | The state of the shift trade after the update request is processed | [optional] |
| **ReviewedBy** | [**UserReference**](UserReference) | The user who reviewed the request, if applicable. The id may be &#39;System&#39; if it was an automated process | [optional] |
| **ReviewedDate** | **DateTime?** | The date the request was reviewed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **FailureReason** | **string** | The reason the update failed, if applicable | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Version metadata for the shift trade | [optional] |



_PureCloudPlatform.Client.V2 253.0.0_
