# BulkFetchContactsResponse

## ININ.PureCloudApi.Model.BulkFetchContactsResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Results** | [**List&lt;BulkResponseResultExternalContactEntityBulkEntityErrorEntity&gt;**](BulkResponseResultExternalContactEntityBulkEntityErrorEntity) | A list of results for all of the Bulk operations specified in the request. Includes both successes and failures. Ordering is NOT guaranteed - may be in a different order from the request. | [optional] |
| **ErrorCount** | **int?** | The number of failed operations in the results. | [optional] |
| **ErrorIndexes** | **List&lt;int?&gt;** | The indexes of all failed operations in the results field. | [optional] |



_PureCloudPlatform.Client.V2 238.0.0_
