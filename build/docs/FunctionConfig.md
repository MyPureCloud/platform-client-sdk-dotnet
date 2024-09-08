---
title: FunctionConfig
---
## ININ.PureCloudApi.Model.FunctionConfig

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Action identifier. | [optional] |
| **Function** | [**Function**](Function.html) | Function configuration. | [optional] |
| **Zip** | [**FunctionZipConfig**](FunctionZipConfig.html) | Zip file configuration and state. | [optional] |
| **UploadExceptionHistory** | [**List&lt;FunctionZipConfig&gt;**](FunctionZipConfig.html) | History of failed zip upload file configuration including their state and error messages. Contains no more than last ten failures. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


