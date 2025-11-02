# CreateDecisionTableRowRequest

## ININ.PureCloudApi.Model.CreateDecisionTableRowRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **RowIndex** | **int?** | The absolute position of this row in the decision table. Must be an integerstarting from 1, must be positive and less than or equal to the size of the table. If not provided row will be append to the end of the table.  | [optional] |
| **Inputs** | [**Dictionary&lt;string, DecisionTableRowParameterValue&gt;**](DecisionTableRowParameterValue) | The input values of the row. The key for this map is the column ID the row value relates. Column IDs are available from the decision table entity | |
| **Outputs** | [**Dictionary&lt;string, DecisionTableRowParameterValue&gt;**](DecisionTableRowParameterValue) | The output values of the row. The key for this map is the column ID the row value relates. Column IDs are available from the decision table entity | |



_PureCloudPlatform.Client.V2 247.0.0_
