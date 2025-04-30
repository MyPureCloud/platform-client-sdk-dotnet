# BulkEntityErrorEntity

## ININ.PureCloudApi.Model.BulkEntityErrorEntity

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Code** | **string** | An error code for the specific error condition. | [optional] |
| **Message** | **string** | A short error message. | [optional] |
| **Status** | **int?** | The HTTP Status Code for the error. | [optional] |
| **Retryable** | **bool?** | Whether this particular error should be retried. | [optional] |
| **Details** | [**List&lt;BulkErrorDetail&gt;**](BulkErrorDetail) | Additional error details for specific fields. | [optional] |
| **Entity** | [**Entity**](Entity) | The entity body specified in the Bulk request operation that caused this error. | [optional] |



_PureCloudPlatform.Client.V2 232.0.0_
