# TestExecutionResult

## ININ.PureCloudApi.Model.TestExecutionResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Operations** | [**List&lt;TestExecutionOperationResult&gt;**](TestExecutionOperationResult) | Execution operations performed as part of the test | [optional] |
| **Error** | [**ErrorBody**](ErrorBody) | The final error encountered during the test that resulted in test failure | [optional] |
| **FinalResult** | **Object** | The final result of the test. This is the response that would be returned during normal action execution | [optional] |
| **Success** | **bool?** | Indicates whether or not the test was a success | [optional] |



_PureCloudPlatform.Client.V2 238.0.0_
