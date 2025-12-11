# WfmHistoricalAdherenceBulkItem

## ININ.PureCloudApi.Model.WfmHistoricalAdherenceBulkItem

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ManagementUnitId** | **string** | The ID of the management unit to query | |
| **StartDate** | **DateTime?** | Beginning of the date range to query in ISO-8601 format | |
| **EndDate** | **DateTime?** | End of the date range to query in ISO-8601 format | |
| **UserIds** | **List&lt;string&gt;** | The IDs of the users to query. If not included, will query every user in the management unit | [optional] |
| **IncludeExceptions** | **bool?** | Whether user exceptions should be returned as part of the results. Defaults to false if not specified. | [optional] |
| **IncludeActuals** | **bool?** | Whether user actual activities should be returned as part of the results. Defaults to false if not specified. | [optional] |



_PureCloudPlatform.Client.V2 251.0.0_
