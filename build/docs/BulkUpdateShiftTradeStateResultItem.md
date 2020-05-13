---
title: BulkUpdateShiftTradeStateResultItem
---
## ININ.PureCloudApi.Model.BulkUpdateShiftTradeStateResultItem

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **State** | **string** | The state of the shift trade after the update request is processed | [optional] |
| **ReviewedBy** | [**UserReference**](UserReference.html) | The user who reviewed the request, if applicable | [optional] |
| **ReviewedDate** | **DateTime?** | The date the request was reviewed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **FailureReason** | **string** | The reason the update failed, if applicable | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata.html) | Version metadata for the shift trade | [optional] |
{: class="table table-striped"}


