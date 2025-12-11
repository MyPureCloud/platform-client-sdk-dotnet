# BulkResponseResultNoteNoteBulkEntityErrorNote

## ININ.PureCloudApi.Model.BulkResponseResultNoteNoteBulkEntityErrorNote

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The id associated with this operation. For Bulk Enrich, this id is specified in the request; for all other Bulk endpoints, this id is the id of the affected entity. | [optional] |
| **Success** | **bool?** | Whether the requested operation completed successfully. | [optional] |
| **Entity** | [**Note**](Note) | The entity which was affected by this Bulk operation. Only returned on success. | [optional] |
| **Error** | [**BulkEntityErrorNote**](BulkEntityErrorNote) | An error describing why this Bulk operation failed. Only returned on failure. | [optional] |
| **Status** | **int?** | Status Code for the requested operation. | [optional] |



_PureCloudPlatform.Client.V2 251.0.0_
