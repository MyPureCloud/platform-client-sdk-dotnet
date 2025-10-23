# AgentMuQueryResponse

## ININ.PureCloudApi.Model.AgentMuQueryResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Status** | **string** | The status of the operation | |
| **OperationId** | **string** | The ID for the operation | |
| **Result** | [**AgentMuScheduleResult**](AgentMuScheduleResult) | The schema of the result of the operation. Null if downloadUrl is populated, but defines the schema of the data that will be returned from the downloadUrl | [optional] |
| **DownloadUrl** | **string** | The URL from which to download the result. The result will follow the schema documented by the result field | [optional] |
| **Error** | [**ErrorBody**](ErrorBody) | Error details if status &#x3D;&#x3D; &#39;Error&#39;. Will always be null but the schema is documented in case of an error in an async notification | [optional] |



_PureCloudPlatform.Client.V2 246.0.0_
