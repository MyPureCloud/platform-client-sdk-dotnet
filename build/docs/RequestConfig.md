# RequestConfig

## ININ.PureCloudApi.Model.RequestConfig

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **RequestUrlTemplate** | **string** | URL that may include placeholders for requests to 3rd party service. This value is read only for Function Integrations and will be set when a draft is created. | [optional] |
| **RequestTemplate** | **string** | Velocity template to define request body sent to 3rd party service. | [optional] |
| **RequestTemplateUri** | **string** | URI to retrieve requestTemplate | [optional] |
| **RequestType** | **string** | HTTP method to use for request | [optional] |
| **Headers** | **Dictionary&lt;string, string&gt;** | Headers to include in request in (Header Name, Value) pairs. | [optional] |



_PureCloudPlatform.Client.V2 216.0.0_
