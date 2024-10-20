# ContactsBulkOperationJob

## ININ.PureCloudApi.Model.ContactsBulkOperationJob

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique job identifier. | [optional] |
| **State** | **string** | The job state. | [optional] |
| **Type** | **string** | The job type. | [optional] |
| **TotalRecords** | **long?** | Total records that will be impacted by the bulk operation. | [optional] |
| **CompletedRecords** | **long?** | Amount of records that have been impacted by the bulk operation. | [optional] |
| **PercentComplete** | **int?** | Percentage of records that have been impacted by the bulk operation. | [optional] |
| **FailureReason** | [**ErrorInfo**](ErrorInfo) | Information on failure reason. | [optional] |
| **DownloadURI** | **string** | URI to download the original backup contacts. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 219.0.0_
