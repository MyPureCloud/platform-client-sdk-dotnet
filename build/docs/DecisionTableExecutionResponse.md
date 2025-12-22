# DecisionTableExecutionResponse

## ININ.PureCloudApi.Model.DecisionTableExecutionResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Table** | [**DecisionTableVersionEntity**](DecisionTableVersionEntity) | The decision table version entity that was executed. | [optional] |
| **TotalMatchRowCount** | **int?** | Total number of rows that matched execution input and would return results | [optional] |
| **TopMatchRows** | [**List&lt;DecisionTableRowEntityRef&gt;**](DecisionTableRowEntityRef) | Top 5 rows matching execution input, excluding the one produced the result. | [optional] |
| **RowExecutionOutputs** | [**List&lt;DecisionTableRowExecutionOutput&gt;**](DecisionTableRowExecutionOutput) | The output data for each executed row for which output is collected. | [optional] |



_PureCloudPlatform.Client.V2 252.1.0_
