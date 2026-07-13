# DecisionTableJobValidationError

## ININ.PureCloudApi.Model.DecisionTableJobValidationError

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Message** | **string** |  | [optional] |
| **Code** | **string** |  | [optional] |
| **Status** | **int?** |  | [optional] |
| **EntityId** | **string** |  | [optional] |
| **EntityName** | **string** |  | [optional] |
| **MessageWithParams** | **string** |  | [optional] |
| **MessageParams** | **Dictionary&lt;string, string&gt;** |  | [optional] |
| **ContextId** | **string** |  | [optional] |
| **Details** | [**List&lt;Detail&gt;**](Detail) |  | [optional] |
| **Errors** | [**List&lt;ErrorBody&gt;**](ErrorBody) |  | [optional] |
| **Limit** | [**Limit**](Limit) |  | [optional] |
| **RowNumber** | **int?** | Row number in the import file when applicable (1-based for data rows; 0 may be used for file-level issues such as headers) | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
