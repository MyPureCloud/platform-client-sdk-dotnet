# DecisionTableImportRowMetrics

## ININ.PureCloudApi.Model.DecisionTableImportRowMetrics

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **TotalRows** | **int?** | Total number of rows in the import file (set after parsing completes) | [optional] |
| **RowsParsed** | **int?** | Number of rows successfully parsed so far | [optional] |
| **RowParseFailed** | **int?** | Number of rows that failed to parse | [optional] |
| **RowsCreated** | **int?** | Number of rows successfully created so far | [optional] |
| **RowsUpdated** | **int?** | Number of rows successfully updated so far | [optional] |
| **RowsDeleted** | **int?** | Number of rows deleted (Replace mode only) | [optional] |
| **RowCreateFailed** | **int?** | Number of rows that failed during batch create | [optional] |
| **RowUpdateFailed** | **int?** | Number of rows that failed during batch update | [optional] |
| **RowDeleteFailed** | **int?** | Number of rows that failed during delete | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
