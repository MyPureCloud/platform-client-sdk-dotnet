# GetFlowExecutionDataJobResult

## ININ.PureCloudApi.Model.GetFlowExecutionDataJobResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Entities** | [**List&lt;ExecutionDataEntity&gt;**](ExecutionDataEntity) | On jobState &#x3D; Success this field will be populated with the list of results of files for download. | [optional] |
| **JobState** | **string** | The state of the backend process to prep the files for download. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 225.0.0_
