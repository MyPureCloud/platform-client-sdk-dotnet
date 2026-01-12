# FunctionConfig

## ININ.PureCloudApi.Model.FunctionConfig

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Action identifier. | [optional] |
| **Function** | [**Function**](Function) | Function configuration. | [optional] |
| **Zip** | [**FunctionZipConfig**](FunctionZipConfig) | Zip file configuration and state. | [optional] |
| **UploadExceptionHistory** | [**List&lt;FunctionZipConfig&gt;**](FunctionZipConfig) | History of failed zip upload file configuration including their state and error messages. Contains no more than last ten failures. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 253.0.0_
