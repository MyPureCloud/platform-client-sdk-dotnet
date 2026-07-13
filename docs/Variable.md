# Variable

## ININ.PureCloudApi.Model.Variable

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the variable. | |
| **Type** | **string** | The data type of the variable. | |
| **Scope** | **string** | The scope that determines the variable&#39;s usage context within Guides runtime. | |
| **Description** | **string** | The description of the variable used by Guides runtime for input/output handling. | [optional] |
| **Validation** | **Object** | The validation configuration for the variable. Optional - if not present, no validation is applied. | [optional] |
| **ListValues** | **Object** | The values configuration for List variables. Only applicable when type is &#39;List&#39;. | [optional] |
| **ListVariables** | [**List&lt;Variable&gt;**](Variable) | The variables that the list result will be stored in. Only applicable when type is &#39;List&#39;. | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
