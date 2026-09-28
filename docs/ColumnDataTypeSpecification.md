# ColumnDataTypeSpecification

## ININ.PureCloudApi.Model.ColumnDataTypeSpecification

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ColumnName** | **string** | The column name of a column selected for dynamic queueing | [optional] |
| **ColumnDataType** | **string** | The data type of the column selected for dynamic queueing (TEXT, NUMERIC, TIMESTAMP or DATETIME). DATETIME supports dates from 1000-01-01 to 9999-12-31; TIMESTAMP is limited to 1970-01-01 through 2038-01-19. | [optional] |
| **Min** | **int?** | The minimum length of the numeric column selected for dynamic queueing | [optional] |
| **Max** | **int?** | The maximum length of the numeric column selected for dynamic queueing | [optional] |
| **MaxLength** | **int?** | The maximum length of the text column selected for dynamic queueing | [optional] |



_PureCloudPlatform.Client.V2 274.0.0_
