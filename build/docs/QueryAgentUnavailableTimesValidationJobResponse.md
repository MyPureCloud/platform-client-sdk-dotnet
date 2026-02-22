# QueryAgentUnavailableTimesValidationJobResponse

## ININ.PureCloudApi.Model.QueryAgentUnavailableTimesValidationJobResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Agent** | [**UserReference**](UserReference) | The agent who started the job | |
| **Status** | **string** | Status of the job | |
| **Result** | [**UnavailableTimesValidationResult**](UnavailableTimesValidationResult) | Validation results if status &#x3D;&#x3D; &#39;Complete&#39; | [optional] |
| **Error** | [**ErrorBody**](ErrorBody) | Error details if status &#x3D;&#x3D; &#39;Error&#39;. The error occurs if the validation job has failed | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 257.0.0_
