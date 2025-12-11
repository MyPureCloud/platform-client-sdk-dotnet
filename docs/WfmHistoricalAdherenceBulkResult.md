# WfmHistoricalAdherenceBulkResult

## ININ.PureCloudApi.Model.WfmHistoricalAdherenceBulkResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **StartDate** | **DateTime?** | Beginning of the date range for this result in ISO-8601 format | [optional] |
| **EndDate** | **DateTime?** | End of the date range for this result in ISO-8601 format | [optional] |
| **ManagementUnitId** | **string** | The ID of the management unit for this result | [optional] |
| **UserResults** | [**List&lt;WfmHistoricalAdherenceBulkUserResult&gt;**](WfmHistoricalAdherenceBulkUserResult) | The individual results for each user | [optional] |
| **LookupIdToSecondaryPresenceId** | **Dictionary&lt;string, string&gt;** | Map of secondary presence lookup ID to corresponding secondary presence ID | [optional] |



_PureCloudPlatform.Client.V2 251.0.0_
