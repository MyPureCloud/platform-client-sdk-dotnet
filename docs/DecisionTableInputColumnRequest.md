# DecisionTableInputColumnRequest

## ININ.PureCloudApi.Model.DecisionTableInputColumnRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **DefaultsTo** | [**DecisionTableColumnDefaultRowValue**](DecisionTableColumnDefaultRowValue) | The default row value for this column that will complete the condition expression where no value is provided by a row. | [optional] |
| **Expression** | [**DecisionTableInputColumnExpression**](DecisionTableInputColumnExpression) | The input column condition expression, comprising the left side and comparator of a logical condition in the form of left|comparator|right, where each row of the decision table will provide the right side to form a complete condition | |



_PureCloudPlatform.Client.V2 242.0.0_
