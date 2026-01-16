# DecisionTableRow

## ININ.PureCloudApi.Model.DecisionTableRow

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Table** | [**DecisionTableVersionEntity**](DecisionTableVersionEntity) | The decision table to which this row belongs | |
| **RowIndex** | **int?** | The absolute index of this row in the decision table, starting at 1 | [optional] |
| **DateCreated** | **DateTime?** | The date when this row was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The date when this row was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Inputs** | [**Dictionary&lt;string, DecisionTableRowParameterValue&gt;**](DecisionTableRowParameterValue) | The map input values of the row being created. At least one value must be provided. The key for this map is the column ID the row value relates | [optional] |
| **Outputs** | [**Dictionary&lt;string, DecisionTableRowParameterValue&gt;**](DecisionTableRowParameterValue) | The map output values of the row being created. At least one value must be provided. The key for this map is the column ID the row value relates | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 254.0.0_
