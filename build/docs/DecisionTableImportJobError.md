# DecisionTableImportJobError

## ININ.PureCloudApi.Model.DecisionTableImportJobError

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ErrorCode** | **string** | The error code for this job failure. | [optional] |
| **ErrorMessage** | **string** | A human-readable error message. | [optional] |
| **MessageWithParams** | **string** | Parameterized message template for the aggregate failure (when applicable) | [optional] |
| **MessageParams** | **Dictionary&lt;string, string&gt;** | Parameters for messageWithParams | [optional] |
| **ValidationErrors** | [**List&lt;DecisionTableJobValidationError&gt;**](DecisionTableJobValidationError) | Validation failures for individual rows or the file structure | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
