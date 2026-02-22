# TaskManagementObservationQueryResponse

## ININ.PureCloudApi.Model.TaskManagementObservationQueryResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Results** | [**List&lt;TaskManagementObservationResult&gt;**](TaskManagementObservationResult) | Query results grouped by the specified dimensions supplied in the groupBy parameter. Each result contains metrics for a specific group combination. | [optional] |
| **Details** | [**TaskManagementObservationDetailContainer**](TaskManagementObservationDetailContainer) | Details about entities contained in results. Provides expanded information when requested through the expands parameter. | [optional] |
| **Cursors** | [**Cursors**](Cursors) | Cursor tokens to be used for navigating paginated results | [optional] |
| **NextUri** | **string** | A URI to the next page in the listing. | [optional] |



_PureCloudPlatform.Client.V2 257.0.0_
