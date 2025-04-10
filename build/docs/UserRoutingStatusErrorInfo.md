# UserRoutingStatusErrorInfo

## ININ.PureCloudApi.Model.UserRoutingStatusErrorInfo

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ErrorCode** | **string** | A code unique to this error. Typically prefixed with the service that originated the error. For example CONFIG_USER_NOT_FOUND | [optional] |
| **Status** | **long?** | The HTTP status code for this message. If left blank the status code from the HTTP response is used. | [optional] |
| **CorrelationId** | **string** | The correlation Id or context Id for this message. If left blank the Public API will look at the HTTP response header &#39;ININ-Correlation-Id&#39; instead. | [optional] |
| **UserMessage** | **string** | A customer friendly message. This should be a complete sentence, use proper grammar and only include information useful to a customer. This is not a dev message and should not include things like Org Id | [optional] |
| **UserParamsMessage** | **string** | This is the same as userMessage except it uses template fields for variable replacement. For instance: &#39;User {username} was not found&#39; | [optional] |
| **UserParams** | [**List&lt;UserRoutingStatusUserParam&gt;**](UserRoutingStatusUserParam) | Used in conjunction with userParamsMessage. These are the template parameters. For instance: UserParam.key &#x3D; &#39;username&#39;, UserParam.value &#x3D; &#39;chuck.pulfer&#39; | [optional] |



_PureCloudPlatform.Client.V2 231.1.0_
